using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour
{
    public Material[] materials;
    int randomIndex;
    public MeshRenderer meshRenderer;
    void Start()
    {   
        RandomizeMaterialColor();
        
    }

    void RandomizeMaterialColor() {
        randomIndex = Random.Range(0, materials.Length);
        meshRenderer.material = materials[randomIndex];
    }
}
