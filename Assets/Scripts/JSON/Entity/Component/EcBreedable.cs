using System;
using System.Collections.Generic;

namespace JSON.Entity.Component
{
    [Serializable]
    public class EcBreedable
    {
        public bool requireTame;
        public bool requireFullHealth;

        public List<string> breedItems;
        public List<BreedWith> breedWiths;
    }

    [Serializable]
    public class BreedWith
    {
        public string mateType;
        public string babyType;
        public string babyStage;
    }
}