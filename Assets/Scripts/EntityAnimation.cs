using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class EntityAnimation
{
    public string name;
    public float length;
    public float startDelay;
    public float loopDelay;
    public bool loop;
}

[Serializable]
public class EntityBoneAnimation
{
    public string bone;
    public float time;
    public List<EntityBoneAnimationDescription> descriptions;
}

[Serializable]
public class EntityBoneAnimationDescription
{
    public string variable;
    public Vector3 value;
    public string lerpMode;
}