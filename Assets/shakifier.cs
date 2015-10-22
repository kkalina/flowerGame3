using UnityEngine;
using System.Collections;

public class shakifier : MonoBehaviour
{
    public GameObject anchor;
    public float intensity = 0.1f;
    //public bool shaking = false;
    public float shakeTime = 0f;
    
    void Update()
    {
        if (shakeTime>0)
        {
            this.transform.position = new Vector3(anchor.transform.position.x + (Random.value * intensity), anchor.transform.position.y + (Random.value * intensity), anchor.transform.position.z + (Random.value * intensity));
            shakeTime = shakeTime - Time.deltaTime;
        }
        else
        {
            this.transform.position = anchor.transform.position;
        }
    }
}
