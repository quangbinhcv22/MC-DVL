using System;
using System.Collections.Generic;

namespace JSON.Entity.Component
{
    /// <summary>
    /// Make entity drop experience on defined events.
    /// </summary>
    [Serializable]
    public class EcExperienceReward
    {
        public List<EcExperienceRewardEvent> events;
    }

    [Serializable]
    public class EcExperienceRewardEvent
    {
        public string name;
        public string numberExpression;
    }
}