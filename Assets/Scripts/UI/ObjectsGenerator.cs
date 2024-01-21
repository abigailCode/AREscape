using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ObjectsGenerator : MonoBehaviour
{
    List<Pose> objects = new List<Pose>();
    public GameObject placedPrefab;
    public TextMeshProUGUI contadorText;



    public int counter = 0;

    void Start()
    {
       
        objects = GameManager.instance.GetObjects();
        contadorText.text = $"{0}/{objects.Count}";
        DrawObjects();
    }

    private void Update()
    {
        if (Input.touchCount == 0)
            return;

        Touch touch = Input.GetTouch(0);
        if (touch.phase == TouchPhase.Began)
        {
           
        }
    }


    public void DrawObjects()
    {
        foreach (var item in objects)
        {
            // Agregamos un tag al objeto instanciado para identificarlo como un "PlacedObject"
            GameObject placedObject = Instantiate(placedPrefab, item.position, item.rotation);
            //placedObject.AddComponent<ObjectPress>();
        }


    }
}
