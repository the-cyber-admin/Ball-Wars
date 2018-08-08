using UnityEngine;

public class ShotController : MonoBehaviour
{
    public float lifetime = 3f;

    Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    void Start()
    {
        transform.SetParent(null);
    }

    public void Shoot(Vector3 power)
    {
        Destroy(gameObject , lifetime);
        rb.AddForce(power);
    }
}
