using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject ParticlePrefab;

    private void OnCollisionEnter(Collision collision)
    {
        Explode();
    }

    void Explode()
    {
        Instantiate(ParticlePrefab, this.transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }

    IEnumerator Start()
    {
        yield return new WaitForSeconds(3f);
        Destroy(this.gameObject);
    }
}
