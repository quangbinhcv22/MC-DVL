using System;
using System.Collections.Generic;

[Serializable]
public class EntityLang
{
    public string lange;
    public List<EntityText> translations;
}

[Serializable]
public class EntityText
{
    public string identifier;
    public string texts;
}