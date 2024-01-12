using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] List<Pose> placedObjects = new List<Pose>();

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

    public List<Pose> GetObjects()
    {
        return placedObjects;
    }
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

}
