using System;
using Newtonsoft.Json;

namespace JSON.Entity.Component
{
    /// <summary>
    ///  This is Entity Component
    /// </summary>
    [Serializable]
    public class Ec
    {
        public string type;
        public string description;

        public object ToComponent()
        {
            switch (type)
            {
                case "vc:nameable":
                    return JsonConvert.DeserializeObject<EcNameable>(description);
                default:
                    return null;
            }
        }
    }

}