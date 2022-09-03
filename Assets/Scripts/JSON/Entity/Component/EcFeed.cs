using System;
using System.Collections.Generic;

namespace JSON.Entity.Component
{
    [Serializable]
    public class EcFeed
    {
        public List<FeedItem> feedItems;
    }

    [Serializable]
    public class FeedItem
    {
        public string item;
        public float subtract;
    }
}