using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomStickmanColor : MonoBehaviour
{
    public Material[] materials;
    Color[] colors; 
    int randomIndex;
    public SkinnedMeshRenderer skinnedMeshRenderer;
    void Start()
    {   
        RandomizeMaterialColor();
        
    }

    public void RandomizeMaterialColor() {
        randomIndex = Random.Range(0, materials.Length);
        skinnedMeshRenderer.material = materials[randomIndex];
    }
}
