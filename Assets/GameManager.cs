using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int coinCount;
    public GameObject coinCountObject = null;

    private void Start()
    {
        Application.targetFrameRate = 60;
        Screen.SetResolution(1920, 1080, false);
        coinCount = 0;
        coinCountObject.GetComponent<Text>().text = "Coins: <color=#ff0000>" + coinCount + "</color> / 5";
    }

    public void SceneReset()
    {
        string activeSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(activeSceneName);
    }
    public void ChangeScene(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
    }

    public void AddCoinCount()
    {
        coinCount++;
        if (coinCount < 5)
        {
            coinCountObject.GetComponent<Text>().text = "Coins: <color=#ff0000>" + coinCount + "</color> / 5";
        }
        else
        {
            coinCountObject.GetComponent<Text>().text = "Coins: " + coinCount + " / 5";
        }
        //Debug.Log("CoinCount:" + coinCount.ToString());
    }
}
