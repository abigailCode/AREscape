using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour
{

    public GameObject menuCanvas;
    public void StartGame()
    {
        //menuCanvas.SetActive(false);
        GameManager.instance.LoadScene("Game");
    }


}
