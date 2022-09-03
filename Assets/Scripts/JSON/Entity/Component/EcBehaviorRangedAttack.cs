using System;

namespace JSON.Entity.Component
{
    [Serializable]
    public class EcBehaviorRangedAttack : EcBehavior
    {
        public float shots;
        public float interval;
        public float cooldown;
        public float radius;
    }
}