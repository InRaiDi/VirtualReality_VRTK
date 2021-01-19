using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransparencyChanger : MonoBehaviour
{
    public Material material;
    public void UpdateTransparency(float alpha)
    {
       
        Color color = material.color;
        color.a = alpha;
        material.color = color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
