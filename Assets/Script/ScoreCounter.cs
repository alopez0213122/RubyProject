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
        if (Particle1.activeInHierarchy == false)
        {
            score++;
            Destroy(Particle1);
        }
        if (Particle2.activeInHierarchy == false)
        {
            score++;
            Destroy(Particle2);
        }

        scoreText.text = ("Robots Fixed: " + score);

        if (score == 1)
        {
            SceneManager.LoadScene("Congrats");
        }
    }
}
