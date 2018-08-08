using UnityEngine;

public class ShotController : MonoBehaviour
{
    public float lifetime = 3f;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
    public float maxScale = 2f;
    public float scaleIncreaseFactor = 0.5f;
    public float fullChrageDamage = 1f;

    bool hasHit = false;
=======
    public float damage = 0.1f;
>>>>>>> parent of dc23c87... Add Jump Limter
=======
    public float damage = 0.1f;
>>>>>>> parent of dc23c87... Add Jump Limter
=======
    public float damage = 0.1f;
>>>>>>> parent of dc23c87... Add Jump Limter
=======
    public float damage = 0.1f;
>>>>>>> parent of dc23c87... Add Jump Limter
=======
    public float damage = 0.1f;
>>>>>>> parent of dc23c87... Add Jump Limter
    
    Rigidbody rb;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
    bool release = false;
    public void Shoot(Vector3 power , Transform t)
=======
=======
>>>>>>> parent of dc23c87... Add Jump Limter
=======
>>>>>>> parent of dc23c87... Add Jump Limter
=======
>>>>>>> parent of dc23c87... Add Jump Limter
=======
>>>>>>> parent of dc23c87... Add Jump Limter
    public void Shoot(Vector3 power)
>>>>>>> parent of dc23c87... Add Jump Limter
    {
        transform.SetParent(null);
        Destroy(gameObject , lifetime);
<<<<<<< HEAD
        var force = power * (transform.localScale.x / 2f);
        rb.AddForce(force);
        t.GetComponent<Rigidbody>().AddForce(-force);
=======
        rb.AddForce(power);
>>>>>>> parent of dc23c87... Add Jump Limter
    }

    private void OnCollisionEnter(Collision other)
    {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        var scale = new Vector3(scaleIncreaseFactor,scaleIncreaseFactor,scaleIncreaseFactor) * Time.deltaTime
                    + transform.localScale;
        scale.x = Mathf.Clamp(scale.x, 0, maxScale);
        scale.y = Mathf.Clamp(scale.y, 0, maxScale);
        scale.z = Mathf.Clamp(scale.z, 0, maxScale);
        transform.localScale = scale;
    }
    void OnCollisionEnter(Collision other)
    {
        if(hasHit)
            return;
        if(!release)
            return;
=======
>>>>>>> parent of dc23c87... Add Jump Limter
=======
>>>>>>> parent of dc23c87... Add Jump Limter
=======
>>>>>>> parent of dc23c87... Add Jump Limter
=======
>>>>>>> parent of dc23c87... Add Jump Limter
=======
>>>>>>> parent of dc23c87... Add Jump Limter
        var hit = other.gameObject.GetComponent<Damageable>();
        if (hit != null)
        {
            hit.AddDamage(
                (other.transform.position - transform.position).normalized ,
                damage);
        }

        hasHit = true;
    }
    void OnDestroy()
    {
        Explode();
    }

    void Explode()
    {
        // TODO : add Exploding Effect
    }
}
