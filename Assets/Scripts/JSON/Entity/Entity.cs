using System;
using System.Collections.Generic;
using JSON.Entity.Component;
using Sirenix.OdinInspector;

namespace JSON.Entity
{
    [Serializable]
    public class Entity
    {
        public string name;
        public EntityDescription description;
        [ShowInInspector] public List<Ec> components;
        [ShowInInspector] public List<EcsGroup> componentGroups;
    }

    [Serializable]
    public class EntityDescription
    {
        public string identifier;
        public EntityMaterialReference materials;
        public EntityTextureReference textures;
        public EntityGeometryReference geometry;
        public List<string> renderControllers;

        public bool isSpawnable;
        public bool isSummonable;
    }
    
    [Serializable]
    public class EcsGroup
    {
        public string stage;
        public List<Ec> components;
    }

    [Serializable]
    public class EntityMaterialReference
    {
        public string @default;
    }

    [Serializable]
    public class EntityTextureReference
    {
        public string variant;
        public string path;
    }

    [Serializable]
    public class EntityGeometryReference
    {
        public string variant;
        public string path;
    }


    [Serializable]
    public class EntitySpawnRules
    {
        public Description description;
        public List<Condition> conditions;


        [Serializable]
        public class Description
        {
            public string identifier;
            public string populationControl;
        }

        [Serializable]
        public class Condition
        {
            public string identifier;
            public string populationControl;
        }
    }
}