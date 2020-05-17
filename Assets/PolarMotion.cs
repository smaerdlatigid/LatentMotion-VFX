using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolarMotion : MonoBehaviour
{
    public GameObject gazeObject;
    public float radius = 2f;
    public float radiusSpeed = 0.1f;

    public float rotSpeed = 0.1f;
    // min and max angle?

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
            gazeObject.transform.position.x + radius * Mathf.Sin(Time.time * rotSpeed),
            transform.position.y,
            gazeObject.transform.position.z + radius * Mathf.Cos(Time.time * rotSpeed)
        );
        transform.LookAt(gazeObject.transform);
    }
}
