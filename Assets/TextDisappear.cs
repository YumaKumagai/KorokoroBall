using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextDisappear : MonoBehaviour
{
    public GameObject textObject;
    private int disappearTimer = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (textObject.activeSelf == true)
        {
            disappearTimer++;
        }
        else
        {
            disappearTimer = 0;
        }
        if (disappearTimer >= 120)
        {
            textObject.SetActive(false);
            disappearTimer = 0;
        }
    }
}
