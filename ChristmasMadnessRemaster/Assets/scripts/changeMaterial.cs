using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeMaterial : MonoBehaviour
{

    public Material newMaterial;
    public Renderer presentBox;


    Material oldMaterial;
    void materialChange()
    {
        oldMaterial = presentBox.material;
        presentBox.material = newMaterial;
    }

}
