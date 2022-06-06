using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject clearText;
    public GameObject notEnouphText;
    public GameObject nextButton;
    public AudioSource audioSource;
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        GameObject managerObject = GameObject.Find("GameManager");
        gameManager = managerObject.GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("ƒS[ƒ‹!");
        if (gameManager.coinCount >= 5)
        {
            clearText.SetActive(true);
            nextButton.SetActive(true);
            audioSource.Play();
        }
        else
        {
            notEnouphText.SetActive(true);
        }
    }
}
