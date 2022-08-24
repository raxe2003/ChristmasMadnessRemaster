using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeMaterial : MonoBehaviour
{

    public Material newMaterial;
    public Renderer presentBox;
    public GameObject box;

    public void materialChange(string whichMaterial)
    {
        if (whichMaterial == "new")
        {
            presentBox.material = newMaterial;
            Destroy(box);
        }






    }
}
