using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow_camera : MonoBehaviour
{
    [SerializeField]  Transform player;

    [SerializeField]  Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position=player.position+offset;
    }
}
 