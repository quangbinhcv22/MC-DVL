using System;

namespace JSON.Entity.Component
{
    [Serializable]
    public class EcBehaviorLookAtPlayer : EcBehavior
    {
        public float lookDistance;
        public float probability;
    }
}