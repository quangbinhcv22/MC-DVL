using System;

namespace JSON.Entity.Component
{
    [Serializable]
    public class EcBehaviorFlowOwner : EcBehavior
    {
        public float startDistance;
        public float stopDistance;
    }
}