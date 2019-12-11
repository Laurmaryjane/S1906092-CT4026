using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingDoor : MonoBehaviour
{
    public GameObject Trigger;
    public GameObject LeftDoor;
    public GameObject RightDoor;

    Animator LeftAnim;
    Animator RightAnim;


    // Start is called before the first frame update
    void Start()
    {
        LeftAnim = LeftDoor.GetComponent<Animator>();
        RightAnim = RightDoor.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
