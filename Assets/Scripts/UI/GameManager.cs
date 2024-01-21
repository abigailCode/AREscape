using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] List<Pose> placedObjects = new List<Pose>();
    private TextMeshProUGUI text;
    public int score = 0;
    private GameObject counterObject = null;

    private void Awake()
    {
        if (instance == null) instance = this;
        else { Destroy(gameObject); return; }
        // ----------------------------------------------------------------

        // No destruimos el AudioManager aunque se cambie de escena
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddObject(Pose hit) 
    {
        placedObjects.Add(hit);
        Debug.Log("Objeto instanciado en x: " + hit.position.x + " y: " + hit.position.y + " z: " + hit.position.z);
    }

    public void ResetObjects()
    {
        placedObjects.Clear();
        score = 0;
    }

    public List<Pose> GetObjects()
    {
        return placedObjects;
    }
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void UpdateCounter()
    {
        if (text == null) counterObject = GameObject.Find("Counter");

        text = counterObject.GetComponent<TextMeshProUGUI>();
        Debug.Log("PROBANDO: "+ score);
        Debug.Log("TOTAL: "+ placedObjects.Count);
        Debug.Log(text.text);
            text.text = score + "/" + placedObjects.Count;
        
    }

    public void IncrementScore()
    {
        Debug.Log("INCREMENTANDO: " + score);
        score ++;
        UpdateCounter();
    }

}
