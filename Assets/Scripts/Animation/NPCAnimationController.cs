using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCAnimationController : MonoBehaviour
{
    private Animator animControl;
    private int numberOfBlinkingAnimation = 5;

    // Start is called before the first frame update
    void Start()
    {
        animControl = GetComponent<Animator>();
        
        InvokeRepeating("SelectBlinkingAnimation", 0.0f, 10.0f);

    }

    // Update is called once per frame
    void Update()
    {

    }

    //Select one of the potential blinking animations
    void SelectBlinkingAnimation()
    {
        animControl.SetFloat("blink", Random.Range(1, numberOfBlinkingAnimation + 1));
    }
}
