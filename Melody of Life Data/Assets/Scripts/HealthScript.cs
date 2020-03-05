using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour {

    public static int Health;
    public int CurrentHealth;
    public bool Schaden;
    public bool CanTakeDamage;


    Animator anim;

    void Start()
    {
        Schaden = false;
        CanTakeDamage = true;
        anim = GetComponent<Animator>();
    }
    void Awake()
    {
        if (Gamemanager.Health == 0)
        {
            PlayerPrefs.SetInt("Leben", 3);
        }
    }

    // Update is called once per frame
    void Update () {
        if (Schaden == true)
        {
            Schaden = false;
            StartCoroutine(Example());
        }
        if (Gamemanager.Health <= 0 )
        {
            StartCoroutine(Example1());
        }
	}

    IEnumerator Example()
    {
        Gamemanager.Health = Gamemanager.Health - 1;
        PlayerPrefs.SetInt("Leben",Gamemanager.Health);
        CanTakeDamage = false;
        yield return new WaitForSeconds(2);
        CanTakeDamage = true;
        Debug.Log("kann schaden nehmen");
    }

    IEnumerator Example1()
    {
        anim.SetBool("Dead",true);
        this.GetComponent<Rigidbody2D>().simulated = false;
        yield return new WaitForSeconds(3);
        PlayerPrefs.SetInt("Leben",3);
        Gamemanager.Health = 3;
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Enemy" && CanTakeDamage == true)
        {
            Schaden = true;
        }
        if (other.tag == "Cookie" && Gamemanager.Health <= 2)
        {
            Gamemanager.Health = Gamemanager.Health + 1;
            PlayerPrefs.SetInt("Leben",Gamemanager.Health);
            Destroy(other.gameObject);
        }
        if (other.tag == "Mine")
        {
            Gamemanager.Health = 0;
        }

    }
    

}
