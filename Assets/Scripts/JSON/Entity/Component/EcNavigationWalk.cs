using System;
using System.Collections.Generic;

namespace JSON.Entity.Component
{
    /// <summary>
    /// Allow entity navigation through world.
    /// </summary>
    [Serializable]
    public class EcNavigationWalk
    {
        public List<string> blocksToAvoid;

        public bool avoidDamageBlocks;
        public bool avoidPortals;
        public bool avoidSun;
        public bool avoidWater;


        public bool canOutWater;
        public bool canBreakDoors;
        public bool canFloat;
        public bool canJump = true;
        public bool canOpenDoors;
        public bool canOpenIronDoors;
        public bool canPassDoors = true;
        public bool canPathFromAir;
        public bool canPathOverLava;
        public bool canPathOverWater;
        public bool canSink = true;
        public bool canSwim;
        public bool canWalk = true;
        public bool canWalkInLava;
        public bool isAmphibious;
    }
}