using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragHandler : MonoBehaviour, IDragHandler {

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    //public void OnEndDrag(PointerEventData eventData)
    //{
    //    transform.position = new Vector3();
    //}
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
