using UnityEngine;

public class ShotController : MonoBehaviour
{
    public float lifetime = 3f;
    public float maxScale = 2f;
    public float scaleIncreaseFactor = 0.5f;
    public float fullChrageDamage = 1f;
    
    
    Rigidbody rb;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    bool release = false;
    public void Shoot(Vector3 power)
    {
        release = true;
        rb.isKinematic = false;
        transform.SetParent(null);
        Destroy(gameObject , lifetime);
        rb.AddForce(power);
    }

    void Update()
    {
        if(release)
            return;
        Scale();
    }

    private void Scale()
    {
        var scale = new Vector3(scaleIncreaseFactor,scaleIncreaseFactor,scaleIncreaseFactor) * Time.deltaTime
                    + transform.localScale;
        scale.x = Mathf.Clamp(scale.x, 0, maxScale);
        scale.y = Mathf.Clamp(scale.y, 0, maxScale);
        scale.z = Mathf.Clamp(scale.z, 0, maxScale);
        transform.localScale = scale;
    }
    void OnCollisionEnter(Collision other)
    {
        if(!release)
            return;
        var hit = other.gameObject.GetComponent<Damageable>();
        if (hit != null)
        {
            hit.AddDamage(
                (other.transform.position - transform.position).normalized ,
                fullChrageDamage * transform.localScale.x);
        }
        
        Explode();
    }
    void Explode()
    {
        Destroy(gameObject);
    }
}
