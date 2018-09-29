using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragHandler : MonoBehaviour{

    public Slider slide;

    public void SliderBackgroundImage()
    {
        transform.localPosition = new Vector3(-slide.value, 0, 0);
    }     

    
}
