using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanoidModel : BaseModel
{
    [SerializeField] protected Transform head;
    [SerializeField] protected Transform leftHand;
    [SerializeField] protected Transform rightHand;
    public Transform Head { get; private set; }
    public Transform LeftHand { get; private set; }
    public Transform RightHand { get; private set; }

    public override void SetInformation()
    {
        if (!fixedInfo)
        {
            base.SetInformation();
            if (head)
            {
                Head = head;
            }
            if (leftHand)
            {
                LeftHand = new GameObject("Container").transform;
                LeftHand.parent = leftHand;
                LeftHand.localPosition = Vector3.zero;
                LeftHand.eulerAngles = Vector3.zero;
            }
            if (rightHand)
            {
                RightHand = new GameObject("Container").transform;
                RightHand.parent = rightHand;
                RightHand.localPosition = Vector3.zero;
                RightHand.eulerAngles = Vector3.zero;
            }
        }
    }
}