using UnityEngine;

public class ShotController : MonoBehaviour
{
    public float lifetime = 3f;
    public float damage = 0.1f;
    
    Rigidbody rb;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Shoot(Vector3 power)
    {
        transform.SetParent(null);
        Destroy(gameObject , lifetime);
        rb.AddForce(power);
    }

    private void OnCollisionEnter(Collision other)
    {
        var hit = other.gameObject.GetComponent<Damageable>();
        if (hit != null)
        {
            hit.AddDamage(
                (other.transform.position - transform.position).normalized ,
                damage);
        }
        
        Explode();
    }

    void Explode()
    {
        Destroy(gameObject);
    }
}
