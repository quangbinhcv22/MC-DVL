using System;
using System.Collections.Generic;

namespace JSON.Entity.Component
{
    [Serializable]
    public class EcDamageSensor
    {
        public List<DamageSensorTrigger> triggers;
    }


    [Serializable]
    public class DamageSensorTrigger
    {
        public string cause; //fall, lighting, drowning, contact_water
        public List<Filter> filters;
        public float damage;
        public float damagePerTick;
    }

    [Serializable]
    public class Filter
    {
        public string test;
        public string subject;
        public string @operator;
        public string value;
    };
}