using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransparencyChanger : MonoBehaviour
{
    public Material material;
    public void UpdateTransparencyByBool(bool opaque)
    {

        Color color = material.color;
        if (opaque)
              { color.a = 1f; }
        else { color.a = 0f; }
        material.color = color;
    }

    public void UpdateTransparency(float alpha)
    {

        if (alpha >= 0)
        {
            print("alpha" + alpha);
            Color color = material.color;
            color.a = alpha;
            material.color = color;
        }
    }


}
