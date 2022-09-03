using System;

namespace JSON.Entity.Component
{
    [Serializable]
    public class EcBehaviorMeleeAttack : EcBehavior
    {
        public int damage;
        public float radius;
    }
}