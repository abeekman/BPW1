using UnityEngine;

public class gunscript : MonoBehaviour{

    public float damage = 10f;
    public float range = 100f;
    public float impactForce = 30f;

    public Camera fpsCam;
    public ParticleSystem Explosion;
    public GameObject Flare;

    // Update is called once per frame
    void Update()
    {
       
       if (Input.GetButtonDown("Fire1"))

        {

            Shoot();

        }

    }

    void Shoot()
    {
        Explosion.Play();

        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range));

        {
            Debug.Log(hit.transform.name);

           ButtonCollider target = hit.transform.GetComponent<ButtonCollider>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }

            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }

            GameObject impactGO = Instantiate(Flare, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impactGO, 1f);
        }

    }
}
