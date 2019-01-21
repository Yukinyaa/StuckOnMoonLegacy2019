using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Rendering;
using Unity.Transforms;
using Unity.Entities;

public class FactoryEntitySpawner : MonoBehaviour
{
    private static EntityManager entityManager;
    private static MeshRenderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public static void InitalizeWithScene()
    {
        renderer = FindObjectOfType<MeshRenderer>().Value;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
