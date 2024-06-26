using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NonPlayerCharacter : MonoBehaviour
{
    public float displayTime = 4.0f;
    public GameObject dialogBox;
    float timerDisplay;

    AudioSource audioSource;

    public AudioClip talking;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        dialogBox.SetActive(false);
        timerDisplay = -1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerDisplay >= 0)
        {
            timerDisplay -= Time.deltaTime;
            if (timerDisplay < 0)
            {
                dialogBox.SetActive(false);
            }
        }
    }
    public void DisplayDialog()
    {
        timerDisplay = displayTime;
        dialogBox.SetActive(true);
        audioSource.PlayOneShot(talking);
    }
}
