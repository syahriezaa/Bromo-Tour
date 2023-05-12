using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxChanger : MonoBehaviour
{
    public Material daySkybox;

    public void ChangeSkybox()
    {
        RenderSettings.skybox = daySkybox;
    }
}
