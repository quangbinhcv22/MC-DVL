using System;
using System.Collections.Generic;

namespace JSON.Entity.Component
{
    [Serializable]
    public class EcBehaviorAttackNearestTarget : EcBehavior
    {
        public List<TargetFilter> targets;
        public bool mustSee;
        public float radius;
    }
}