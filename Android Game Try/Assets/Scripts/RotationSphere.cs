using System.Collections;
using UnityEngine;

public class RotationSphere : MonoBehaviour {

    public Transform sphere;
    public float angularVelocity = 2f;
    public float angularVelocity1 = 1f;
    public float angularVelocity2 = 2f;
    public float angularVelocity3 = 3f;
    private Vector3 axisOfRotation;
    public float time = 0f;
    //private int oldSec = 1;
    int oldsec=0;
    float rDuration = 4f;
    public float MinDuration = 2f;
    public float MaxDuration = 6f;

    void Start()
    {
        angularVelocity = angularVelocity1;
        axisOfRotation = Random.onUnitSphere;

    }

    void Update()
    {
        // Debug.Log(System.DateTime.Now.Second);
        // int currentSec = System.DateTime.Now.Second;
        time += Time.deltaTime;
        Debug.Log((int)time);

        /*if (currentSec % 5 == 0 && oldSec!=currentSec )
       {
            oldSec = currentSec;
            Debug.Log("old sec here " + oldSec);
            axisOfRotation = Random.onUnitSphere;
        }
        */

        if ( (int)time % (int)rDuration == 0 && (int)time != oldsec)
        {
            Debug.Log(" Old Sec Here " + oldsec);
            axisOfRotation = Random.onUnitSphere;
            if ((int)time >= 20 && (int)time < 40)
            {
                Debug.Log("Velocity Change2");
                angularVelocity = angularVelocity2;
            }
            else if ((int)time >= 40 && (int)time < 60)
            {
                Debug.Log("Velocity Change3");
                angularVelocity = angularVelocity3;
            }
            rDuration = Random.Range(MinDuration, MaxDuration);
        }

        
        transform.Rotate(axisOfRotation, angularVelocity * Time.smoothDeltaTime);

        oldsec = (int)time;
    }

   /* private void OnCollisionEnter(Collider other)
    {
        other.transform.parent = this.transform;
    }
    */

    private void OnCollisionEnter(Collision other)
    {
        other.transform.parent = this.transform;
    }

}
