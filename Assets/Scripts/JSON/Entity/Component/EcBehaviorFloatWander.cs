using System;

namespace JSON.Entity.Component
{
    [Serializable]
    public class EcBehaviorFloatWander : EcBehavior
    {
        public float xzDist;
        public float yDist;
        public float yOffset;
        public float duration;
    }
}