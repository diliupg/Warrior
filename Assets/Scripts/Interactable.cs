using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    //message displayed to player when looking at an intaractable
    public string promptMessage;

    public void BaseInteract()
    {
        Interact();
    }

    protected virtual void Interact()
    {
        //this is a template function and will not have any code
        //and will be overridden by the sub classes
    }



}
