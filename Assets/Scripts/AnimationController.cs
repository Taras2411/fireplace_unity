using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    Animator anim;
    
    public enum CameraState{
        Overall,
        Furnace,
        FurnaceFireDoor,
    }
    public CameraState cameraCurrentState;
    void Start()
    {
        Debug.Log(Camera.main.transform.position);
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(Input.GetTouch(0).position + " " + Input.GetTouch(0).phase);
        if(Input.touchCount != 0)
        {
            //raycast to the touch position
            Debug.Log(Input.GetTouch(0).position);
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;
            //draw a raycast
            Debug.DrawRay(ray.origin, ray.direction * 100, Color.red);
            if(Physics.Raycast(ray.origin,ray.direction, out hit))
            {
                switch(hit.collider.tag)
                {
                    case "Furnace":
                        cameraCurrentState = CameraState.Furnace;
                        break;
                    case "FurnaceFireDoor":
                        cameraCurrentState = CameraState.FurnaceFireDoor;
                        break;
                    default:
                        cameraCurrentState = CameraState.Overall;
                        break;
                }

            }
        }
        
        switch(cameraCurrentState)
        {
            case CameraState.Overall:
                anim.Play("OverallPlan");
                break;
            case CameraState.Furnace:
                anim.Play("FurnacePlan");
                break;
            case CameraState.FurnaceFireDoor:
                anim.Play("FurnaceDoorPlan");
                break;
        }


    }
}
