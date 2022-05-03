using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameController : MonoBehaviour
{
    //on awake set scale to 0
    void Awake()
    {
        transform.localScale = new Vector3(0, 0, 0);
    }
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
  
        
    }

    public void FlameOff()
    {
        transform.localScale = new Vector3(0, 0, 0);
    }
    public void SetFlame(float amount)
    {
        // start ChangeFlame(amount);
        StartCoroutine(ChangeFlame(amount));
    }
    //courutine to smoothly increase or decreath the flame size to the inputed value
    IEnumerator ChangeFlame(float amount)
    {
        float currentScale = transform.localScale.x;
        float targetScale = amount;
        float scaleStep = 0.01f;
        if(targetScale > currentScale)
        {
            while(currentScale < targetScale)
            {
                currentScale += scaleStep;
                transform.localScale = new Vector3(currentScale, currentScale, currentScale);
                yield return new WaitForSeconds(0.01f);
            }
            yield break;

        }
        else
        {
            while(currentScale > targetScale)
            {
                currentScale -= scaleStep;
                transform.localScale = new Vector3(currentScale, currentScale, currentScale);
                yield return new WaitForSeconds(0.01f);
            }
            yield break;
        }

    }


}
