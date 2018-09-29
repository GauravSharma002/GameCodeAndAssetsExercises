using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoxColor : MonoBehaviour
{
    public void TurnRed()
    {
        gameObject.GetComponent<RawImage>().material.color = Color.red;
    }

    public void TurnOriginal()
    {
        gameObject.GetComponent<RawImage>().material.color = Color.white;
    }
}
