using System;

namespace JSON.Entity.Component
{
    /// <summary>
    /// Give entity ability to move on ground.
    /// </summary>
    [Serializable]
    public class EcMovementBasic
    {
        public float maxTurn = 30f;
    }
}