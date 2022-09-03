using System;
using System.Collections.Generic;

namespace JSON.Entity.Component
{
    [Serializable]
    public class EcLoot
    {
        public List<ELoot> loots;
    }

    [Serializable]
    public class ELoot
    {
        public string item;
        public string numberExpression;
    }
}