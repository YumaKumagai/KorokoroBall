using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerFollow : MonoBehaviour
{
    public GameObject cam;
    public GameObject player;

    private
        Vector3 overlookView_pos;
    private
        Quaternion overlookView_rot;
    private
        Vector3 rightSideView_pos;
    private
        Quaternion rightSideView_rot;

    private
        Vector3 stage2PlayerInitPos;
    private
        Vector3 differCameraToPlayer;

    // Start is called before the first frame update
    void Start()
    {
        overlookView_pos = new Vector3(0, 15, 1.6f);
        overlookView_rot = Quaternion.Euler(81, 0, 0);
        rightSideView_pos = new Vector3(20, 5, 5);
        rightSideView_rot = Quaternion.Euler(20, 270, 0);

        cam.transform.position = overlookView_pos;
        cam.transform.rotation = overlookView_rot;

        stage2PlayerInitPos = new Vector3(0, 2.5f, 2);
        differCameraToPlayer = overlookView_pos - stage2PlayerInitPos;
    }

    // Update is called once per frame
    void Update()
    {
        switch (SceneManager.GetActiveScene().name)
        {
            case "Stage1":
                if (player.transform.position.y <= 0)
                {
                    cam.transform.position = rightSideView_pos;
                    cam.transform.rotation = rightSideView_rot;
                }
                else
                {
                    cam.transform.position = overlookView_pos;
                    cam.transform.rotation = overlookView_rot;
                }
                break;
            case "Stage2":
            case "Stage3":
                cam.transform.position = differCameraToPlayer + player.transform.position;
                cam.transform.rotation = overlookView_rot;
                break;
        }
    }
}
