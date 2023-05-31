using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ButtonBehaviour : MonoBehaviour
{
    public GameObject Iron;
    VirtualButtonBehaviour vbutton;

    void Start()
    {
      Iron.SetActive(false);
    
      vbutton = GetComponentInChildren<VirtualButtonBehaviour>();
      vbutton.RegisterOnButtonPressed(onButtonPressed);
      vbutton.RegisterOnButtonReleased(onButtonReleased);
    }
    void onButtonPressed(VirtualButtonBehaviour vb){
        Iron.SetActive(true);
    }
    void onButtonReleased(VirtualButtonBehaviour vr){
        Iron.SetActive(false);
    }


}
