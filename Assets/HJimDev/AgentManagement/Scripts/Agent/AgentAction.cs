using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AgentAction", menuName = "Agent/Action")]
public class AgentAction : ScriptableObject
{
    [Header("Animation")]
    public string animation = "";

    [Header("Facial Expression")]
    public string facialExpression = "";

    [Header("Audio")]
    public AudioClip audio;
    public string audioText = "";

    [Header("Goto")]
    public List<Vector3> path;
}