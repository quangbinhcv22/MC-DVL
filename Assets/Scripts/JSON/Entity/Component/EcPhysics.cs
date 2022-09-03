using System;
using UnityEngine;

namespace JSON.Entity.Component
{
    [Serializable]
    public class EcPhysics
    {
        public bool hasCollision;
        public bool hasGravity;
        
        public Vector3 center;
        public Vector2 size;
    }
}