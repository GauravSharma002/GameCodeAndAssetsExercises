using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoxSlider : MonoBehaviour
{
    public Slider slider;

    public void SliderScale()
    {
        transform.localScale = new Vector3(slider.value, slider.value, slider.value);
    }
}
