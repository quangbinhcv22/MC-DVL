using System;
using System.Collections.Generic;

namespace JSON.Entity.Component
{
    /// <summary>
    /// Make entity follow entities who hold items.
    /// </summary>
    [Serializable]
    public class EcBehaviorTempt : EcBehavior
    {
        public List<string> items;
        public float withinRadius;
    }
}