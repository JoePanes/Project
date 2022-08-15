using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCAnimationController : MonoBehaviour
{
    private Animator animControl;
    private int numberOfBlinkingAnimations = 5;
    
    private int numberOfIdleAnimations = 5;

    private int numberOfTalkingAnimations = 3;

    // Start is called before the first frame update
    void Start()
    {
        animControl = GetComponent<Animator>();
        
        InvokeRepeating("SelectBlinkingAnimation", 0.0f, 10.0f);
        InvokeRepeating("SelectIdleAnimation", 0.0f, 10.0f);

    }

    // Update is called once per frame
    void Update()
    {

    }

    //Select one of the potential blinking animations
    void SelectBlinkingAnimation()
    {
        animControl.SetFloat("blink", Random.Range(1, numberOfBlinkingAnimations + 1));
    }

    //Select one of the potential idle animation
    void SelectIdleAnimation()
    {
        animControl.SetFloat("idle", Random.Range(1, numberOfIdleAnimations + 1));
    }

    public void ToggleTalking()
    {
        if (animControl.GetBool("is_talking"))
        {
            animControl.SetBool("is_talking", false);
        } else 
        {
            //Select animation prior to toggles
            SelectTalkingAnimation();
            animControl.SetBool("is_talking", true);
        }
    }

    void SelectTalkingAnimation()
    {
        animControl.SetFloat("talk", Random.Range(1, numberOfTalkingAnimations + 1));
    }
}
