using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeMaterial : MonoBehaviour
{
    public Material oldMaterial;
    public Material newMaterial;
    public Renderer presentBox;

    public void materialChange(string whichMaterial)
    {
       if(whichMaterial == "new")
        {
            presentBox.material = newMaterial;
        }else if(whichMaterial == "old")
        {
            presentBox.material = oldMaterial;
        }
    }
    
    

    


}
