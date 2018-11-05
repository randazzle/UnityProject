using System.Collections;
using UnityEngine;

public class RotationSphere : MonoBehaviour {

    public Transform sphere;

    public float angularVelocity = 2f;
    private Vector3 axisOfRotation;
    public float time = 0f;
    private int oldSec = 1;


    void Start()
    {

        axisOfRotation = Random.onUnitSphere;

    }

    void Update()
    {
        Debug.Log(System.DateTime.Now.Second);
        int currentSec = System.DateTime.Now.Second;
        time += Time.deltaTime;

        if (currentSec % 5 == 0 && oldSec!=currentSec )
        {
            oldSec = currentSec;
            Debug.Log("old sec here" + oldSec);
            axisOfRotation = Random.onUnitSphere;
        }
        transform.Rotate(axisOfRotation, angularVelocity * Time.smoothDeltaTime);
    }
}
