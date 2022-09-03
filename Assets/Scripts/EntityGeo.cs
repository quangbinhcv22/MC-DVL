using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class EntityGeo
{
    public EntityGeoDescription description;
    public List<EntityGeoBone> bones;
}

[Serializable]
public class EntityGeoDescription
{
    public string identifier;
    public int textureWidth;
    public int textureHeight;

    public float visibleBoundWidth;
    public float visibleBoundHeight;
    public Vector3 visibleBoundOffset;
}

[Serializable]
public class EntityGeoBone
{
    public string name;
    public string parent;
    public Vector3 pivot;
    public List<EntityGeoCube> cubes;
}

[Serializable]
public class EntityGeoCube
{
    public Vector3 origin;
    public Vector3 size;
    public List<EntityGeoCubeFaceUV> uvs;
}

[Serializable]
public class EntityGeoCubeFaceUV
{
    public string direction;
    public Vector2 uv;
    public Vector2 uvSizes;
}