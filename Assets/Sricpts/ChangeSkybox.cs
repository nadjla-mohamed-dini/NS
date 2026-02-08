using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSkybox : MonoBehaviour
{
    public Material skyboxMaterial;
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            RenderSettings.skybox = skyboxMaterial;
            DynamicGI.UpdateEnvironment();
        }
    }

    
}
