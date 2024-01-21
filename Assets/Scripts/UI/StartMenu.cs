using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour
{

 
    public void StartGame()
    {
        int placedObjectsCount = 0;
        placedObjectsCount = GameManager.instance.GetObjects().Count;
        GameManager.instance.score = 0;
        if (placedObjectsCount > 0)
        {

        GameManager.instance.LoadScene("Game");
        PlayerPrefs.SetInt("placedObjects",placedObjectsCount);
        }
        else
        {
            GameManager.instance.LoadScene("SetUp");
        }
    }

    public void GoToSetUp()
    {
        GameManager.instance.LoadScene("SetUp");

    }
    
    public void BackToMenu()
    {
        GameManager.instance.LoadScene("Menu");

    }
}
