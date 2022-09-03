using System;
using System.Collections.Generic;
using UnityEngine;

namespace JSON.Entity.Component
{
    [Serializable]
    public class EcRideable
    {
        public int controlSeatIndex;
        public int seatCount;
        public List<string> familyTypes;
        public List<Vector3> positions;
        public List<Vector3> rotations;
    }
}