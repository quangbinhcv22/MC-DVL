using System;
using System.Collections.Generic;

namespace JSON.Entity.Component
{
    [Serializable]
    public class EcBehaviorAvoidMobType : EcBehavior
    {
        public List<TargetFilter> targets;
        public float mustSee;
        public float radius;
        public float sprintSpeedMultiplier;
    }
}