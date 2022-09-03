using System;

namespace JSON.Entity.Component
{
    [Serializable]
    public class EcBehaviorSleepWithOwner : EcBehavior
    {
        public float searchRadius;
        public float searchHeight;
        public float goalRadius;
    }
}