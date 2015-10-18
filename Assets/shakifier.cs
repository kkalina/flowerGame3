using UnityEngine;
using System.Collections;

public class shakifier : MonoBehaviour
{
    public GameObject anchor;
    public float intensity = 0.1f;
    public bool shaking = false;
    
    void Update()
    {
        if (shaking)
        {
            this.transform.position = new Vector3(anchor.transform.position.x + (Random.value * intensity), anchor.transform.position.y + (Random.value * intensity), anchor.transform.position.z + (Random.value * intensity));
        }
        else
        {
            this.transform.position = anchor.transform.position;
        }
    }
}
