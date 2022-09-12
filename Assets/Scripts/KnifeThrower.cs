using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeThrower : MonoBehaviour
{
    public float force;
    public GameObject knifePrefab;
    public GameObject knife;
    // Start is called before the first frame update
    void Start()
    {
        knife = Instantiate(knifePrefab, transform);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            knife.transform.parent = null;
            knife.GetComponent<Rigidbody2D>().AddForce(Vector2.up * force, ForceMode2D.Impulse);
            knife = Instantiate(knifePrefab, transform);
        }
    }
}
