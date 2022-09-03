using System;

namespace JSON.Entity.Component
{
    /// <summary>
    /// Define behavior of entity, lower number = higher priority 
    /// </summary>
    [Serializable]
    public class EcBehavior
    {
        public int priority;
        public float speedMultiplier;
    }
}