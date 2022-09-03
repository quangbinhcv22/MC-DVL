using System;

namespace JSON.Entity.Component
{
    [Serializable]
    public class TargetFilter
    {
        public string test;
        public string subject;
        public string @operator;
        public string type;
        public string stage;
    }
}