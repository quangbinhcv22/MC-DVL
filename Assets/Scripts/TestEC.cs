using System.Collections.Generic;
using System.Linq;
using JSON.Entity;
using Newtonsoft.Json;
using Sirenix.OdinInspector;
using UnityEngine;

public class TestEC : MonoBehaviour
{
    [ShowInInspector] public Entity entity;
    [ShowInInspector] public Entity entity2;

    [ShowInInspector] public List<object> components;

    public string json;

    [Button]
    public void ToJson()
    {
        json = JsonConvert.SerializeObject(entity);
        entity2 = JsonConvert.DeserializeObject<Entity>(json);

        components = entity.components.Select(c => c.ToComponent()).ToList();
    }
}