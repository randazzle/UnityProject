using UnityEngine;

public class Knife : MonoBehaviour {

    [SerializeField]
    private GameObject KnifePrefab;

    [SerializeField]
    private Vector3 throwForce;

    public Vector3 positionOfKnife;
        
    private bool isActive = true;

    private Rigidbody rb;
    private BoxCollider knifeCollider;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        knifeCollider = GetComponent<BoxCollider>();


       // Instantiate(KnifePrefab, positionOfKnife, transform.rotation);

    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && isActive)
        {
            rb.AddForce(throwForce, ForceMode.Impulse);
            rb.useGravity = true;

            //Instantiate(KnifePrefab, positionOfKnife, Quaternion.identity);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!isActive)
            return;

        isActive = false;
        

        if (collision.collider.tag == "Log")
        {
            GetComponent<ParticleSystem>().Play();

            rb.velocity = new Vector3(0, 0, 0);
            rb.isKinematic = true;
            // knife.transform.SetParent(collision.collider.transform);

            //knifeCollider.contactOffset = new Vector3(knifeCollider.contactOffset, -0.4f, knifeCollider.contactOffset.z);
            // knifeCollider.size = new Vector3(knifeCollider.size.x, .5f, knifeCollider.size.z);
            //Destroy(collision.rigidbody);

            // Instantiate(KnifePrefab, positionOfKnife, transform.rotation);

            GameController.Instance.HitTarget();
        }
        else if(collision.collider.tag == "Knife")
        {
            rb.velocity = new Vector3(rb.velocity.x, -2, rb.velocity.z);
            GameController.Instance.GameOver(false);
        }
    }
    
    
}
