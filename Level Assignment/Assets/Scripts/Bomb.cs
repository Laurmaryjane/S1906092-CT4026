using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public float explosionForce = 20;
    public float explosionRadius = 7;
    public float fuseCountdown = 1;
    private bool litFuse = false;

    void Update()
    {
        if (litFuse)
        {
            fuseCountdown -= Time.deltaTime;

            if (fuseCountdown <= 0)
            {
                SelfDestruct();
            }
        }
    }

    public void LightFuse()
    {
        litFuse = true;
    }

    private void SelfDestruct()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);

        foreach(Collider collider in colliders)
        {
            Rigidbody r = collider.GetComponent<Rigidbody>();
            if (r != null)
            {
                r.AddExplosionForce(explosionForce, transform.position, explosionRadius, 0, ForceMode.Impulse);
            }

        }

        Destroy(gameObject);
    }
}
