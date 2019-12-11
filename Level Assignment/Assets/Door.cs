using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{ 

    public GameObject Trigger;
    public GameObject LeftDoor;
    public GameObject RightDoor;

Animator LeftAnim;
Animator RightAnim;

    // Start is called before the first frame update
    void Start()
    {
        LeftAnim = LeftDoor.GetComponent <Animator > ();
        RightAnim = RightDoor.GetComponent<Animator >();

    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            SlideDoors (true);
        }
    }

    void OnTriggerExit(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            SlideDoors(false);
        }
    }

    void SlideDoors(bool state)
    {
        LeftAnim.SetBool("slide", state);
        RightAnim.SetBool("slide", state);
    }
}
