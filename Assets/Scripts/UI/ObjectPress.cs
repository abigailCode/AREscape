using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPress : MonoBehaviour
{
    //protected override void OnPress(Vector3 position)
    //{
    //    Debug.Log("Se presion� el objeto en la posici�n: " + position);
    //    gameObject.SetActive(false);
    //}
    private void OnMouseEnter()
    {
        gameObject.SetActive(false);
    }
}
