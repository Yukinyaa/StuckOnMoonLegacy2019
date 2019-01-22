using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public class BootStrap : MonoBehaviour
{
    // Start is called before the first frame update
    //[Test]
    public Texture2D sprite;
    void Start()
    {
        var entityManager = World.Active.GetOrCreateManager<EntityManager>();
        var renderEntity = entityManager.CreateEntity(
                ComponentType.Create<Animated2DSprite>()
            );
        entityManager.SetComponentData(renderEntity, new Animated2DSprite() { animatedsprite = new List<Texture2D>() { sprite } });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
