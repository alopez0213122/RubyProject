using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreCounter : MonoBehaviour
{
    public GameObject Particle1;
    public GameObject Particle2;

    public int score = 0;

    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score = GameObject.FindGameObjectsWithTag("SMOKE").Length;
        scoreText.text = ("Robots Left to Fix: " + score);
        if (score == 0)
        {
            scoreText.text = ("Robots Left to Fix: " + score + " You won!");
            StartCoroutine(DelayEnd());
        }
        
        //else
        //{
        //    if (Particle2.activeInHierarchy == false)
        //    {
        //        score++;
        //        Destroy(Particle2);
        //    }
        //    if (Particle1.activeInHierarchy == false)
        //    {
        //        score++;
        //        Destroy(Particle1);
        //    }
        //}
        
    }
    private IEnumerator DelayEnd()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Congrats");
    }
}
