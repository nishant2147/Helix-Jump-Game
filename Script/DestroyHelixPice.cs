using UnityEngine;

public class DestroyHelixPice : MonoBehaviour
{
    Transform PlayerTransform;
    float force = 100;
    float radius = 1;
    // Start is called before the first frame update
    void Start()
    {
        PlayerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerTransform.position.y < transform.position.y)
        {
            destroyPieces();
        }
    }

    private void destroyPieces()
    {
        Collider[] allPieces = Physics.OverlapSphere(transform.position, radius);

        foreach (var col in allPieces)
        {
            Rigidbody rb = col.gameObject.GetComponent<Rigidbody>();
            if (rb != null && (col.gameObject.tag == "Piece"|| col.gameObject.tag == "Green"))
            {
                rb.isKinematic = false;
                rb.AddExplosionForce(force, transform.position, radius);
            }
        }

        Destroy(gameObject, 0.5f);
    }
}
