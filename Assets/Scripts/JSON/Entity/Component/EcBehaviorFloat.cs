using System;

namespace JSON.Entity.Component
{
    [Serializable]
    public class EcBehaviorFloat : EcBehavior
    {
    }

    [Serializable]
    public class EcBehaviorOcelotAttack : EcBehavior
    {
        public float cooldown;
        public float xMaxRotation;
        public float yMaxHeadRotation;
        public float maxDistance;
        public float maxSneakRange;
        public float maxSprintRange;
        public float reachMultiplier;
        public float sneakSpeedMultiplier;
        public float sprintSpeedMultiplier;
        public float walkSpeedMultiplier;
    }
}