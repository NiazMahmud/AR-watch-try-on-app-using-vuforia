using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Watch1 : MonoBehaviour
{
    public GameObject watchm1;
    public GameObject watchm2;
    
    public GameObject ww1;
    public GameObject ww2;


    Animation w1WinAnimation;
    Animation w2WinAnimation;

    // Start is called before the first frame update
    void Start()
    {
        w1WinAnimation = ww1.GetComponent<Animation>();
        w2WinAnimation = ww2.GetComponent<Animation>();
        
    }
 public void WatchOneBC()
 {
     watchm1.SetActive(true);
     watchm2.SetActive(false);

     w1WinAnimation["w1animation"].speed = 1;
     w1WinAnimation.Play();


 }
    public void WatchYTwoBC()
 {
     watchm1.SetActive(false);
     watchm2.SetActive(true);


    w2WinAnimation["w1animation"].speed = 1;
    w2WinAnimation.Play();



    public void CloseBC()
    {
        string buttonName = EventSystems.current.currentSelectedGameObject.name;
        
        
        if (buttonName == "w1close"){

            w1WinAnimation["w1animation"].speed = -1;
            w1WinAnimation["w1animation"].time = w1WinAnimation ["w1animation"].length;
            w1WinAnimation.Play();

        }
        else if (buttonName == w2close)
        {
            w2WinAnimation["w2animation"].speed = -1;
            w2WinAnimation["w2animation"].time = w2WinAnimation ["w2animation"].length;
            w2WinAnimation.Play();

        }
    }

 }
   
 














}
