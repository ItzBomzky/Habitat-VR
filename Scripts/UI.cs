using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
     public GameObject Canvas;

    public void OnPointerEnter(){
        Canvas.SetActive(false);
    }
    public void OnPointerClick(){
        
    }
    public void OnPointerExit(){
        
    }
}
