using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fishes : MonoBehaviour
{

    public void jellySound(){
        FindObjectOfType<AudioManager>().Play("test");
   }
    public  void whaleSound(){
        FindObjectOfType<AudioManager>().Stop("test");
        FindObjectOfType<AudioManager>().Play("test2");
    }
}
