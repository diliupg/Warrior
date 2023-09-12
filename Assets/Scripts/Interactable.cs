using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    //add or remove an interaction event component to this gameobject
    public bool useEvents;
    //message displayed to player when looking at an intaractable
    public string promptMessage;

    public void BaseInteract()
    {
        if(useEvents)
            GetComponent<InteractionEvent>().OnInteract.Invoke();
        Interact();
    }

    protected virtual void Interact()
    {
        //this is a template function and will not have any code
        //and will be overridden by the sub classes
    }



}
