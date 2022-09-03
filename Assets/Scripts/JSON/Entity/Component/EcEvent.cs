using System;
using System.Collections.Generic;

namespace JSON.Entity.Component
{
    [Serializable]
    public class EcEvent
    {
        public List<string> remove;
        public List<string> add;
    }
}