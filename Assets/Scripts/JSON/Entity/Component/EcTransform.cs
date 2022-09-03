using System;
using System.Collections.Generic;

namespace JSON.Entity.Component
{
    [Serializable]
    public class EcTransform
    {
        public List<EcTransformation> transformations;
    }

    [Serializable]
    public class EcTransformation
    {
        public string @event;
        public string into;
        public float delay;
    }
}