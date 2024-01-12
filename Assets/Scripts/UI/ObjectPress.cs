using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPress : MonoBehaviour
{
    //protected override void OnPress(Vector3 position)
    //{
    //    Debug.Log("Se presionó el objeto en la posición: " + position);
    //    gameObject.SetActive(false);
    //}
    private void OnMouseEnter()
    {
        gameObject.SetActive(false);
    }
}
