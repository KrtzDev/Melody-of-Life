using UnityEngine.Video;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadTutLvl : MonoBehaviour
{

    public VideoPlayer videoPlayer;
    public AudioSource audiosource;

    public int LevelIndexToLoad;

    private void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        audiosource = GetComponent<AudioSource>();

        videoPlayer.isLooping = false;
        videoPlayer.loopPointReached += EndReached;

        GetVideoFile();
    }

    void GetVideoFile()
    {
        videoPlayer.source = VideoSource.Url;
        if(LevelIndexToLoad == 2)
        {
            videoPlayer.url = System.IO.Path.Combine(Application.streamingAssetsPath , "Cutscene_Start_New.mp4");
        }
        else if (LevelIndexToLoad == 0)
        {
            videoPlayer.url = System.IO.Path.Combine(Application.streamingAssetsPath , "Cutscene_End_New.mp4");
        }
        videoPlayer.Prepare();

    }

    void EndReached(VideoPlayer videoPlayer)
    {
        videoPlayer.Stop();
        audiosource.Stop();
        SceneManager.LoadScene(LevelIndexToLoad);
    }

    private void Update()
    {
        if (videoPlayer.isPrepared && !videoPlayer.isPlaying)
        {
            videoPlayer.frame = 1;
            audiosource.Play();
            videoPlayer.Play();
        }        
    }
}
