using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public GameObject BulletPrefab;
    public float Force;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Fire();
        }
    }

    void Fire()
    {
        GameObject obj = Instantiate(BulletPrefab, this.transform.position, Quaternion.identity);
        obj.GetComponent<Rigidbody>().AddForce(new Vector3(Force, 0f, 0f));
    }
}
