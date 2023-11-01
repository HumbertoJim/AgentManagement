using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseModel : MonoBehaviour
{
    [SerializeField] protected GameObject model;
    [SerializeField] AudioSource audioSource;

    public Animator Animator { get; private set; }
    public AudioSource Audio { get; private set; }
    public Transform Transform { get; private set; }

    protected bool fixedInfo;

    public virtual void SetInformation()
    {       
	    if(!fixedInfo)
        {
            fixedInfo = true;

            Animator = model.GetComponent<Animator>();
            Transform = model.transform;
            Audio = audioSource;
        }
    }

    public void Anim(string animation)
    {
        Animator.SetTrigger(animation);
    }
}
