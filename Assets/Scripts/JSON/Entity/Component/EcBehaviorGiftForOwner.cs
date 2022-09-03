using System;
using System.Collections.Generic;

namespace JSON.Entity.Component
{
    [Serializable]
    public class EcBehaviorGiftForOwner : EcBehavior
    {
        public float secondsBeforePickup;
        public float cooldown;
        public float dropItemChance;
        public float offeringDistance;
        public float minimumTeleportDistance;
        public float maxHeadLookAtHeight;
        public float targetRange;
        public float teleportOffset;
        public float timeOfDayRange;
        public float searchRange;
        public float searchHeight;
        public float searchCount;
        public float goalRadius;
        public List<LoopTable> loopTable;
    }
    
    
    [Serializable]
    public class LoopTable
    {
        public string item;
        public string number;
        public string weight;
    }
}