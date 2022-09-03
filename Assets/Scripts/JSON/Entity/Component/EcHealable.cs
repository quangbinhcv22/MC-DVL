using System;
using System.Collections.Generic;

namespace JSON.Entity.Component
{
    [Serializable]
    public class EcHealable
    {
        public List<FeedHeal> feeds;
    }

    [Serializable]
    public class FeedHeal
    {
        public string item;
        public string amount;
    }
}