using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanoidAgent: Agent
{
    public new HumanoidModel Model { get { return (HumanoidModel)base.Model; } }

    public virtual void StopTalking()
    {
        Model.Audio.Pause();
    }

    public void Talk(AudioClip audio)
    {
        StopTalking();

        if (audio)
        {
            Model.Audio.clip = audio;
        }
        else if( Model.Audio.clip != default)
        {
            Model.Audio.clip = audio;
        }
        Model.Audio.Play();
    }

    public override void PlayAudio(AudioClip clip)
    {
        Talk(clip);
    }
}
