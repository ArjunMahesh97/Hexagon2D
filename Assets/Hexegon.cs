using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexegon : MonoBehaviour
{
    public Rigidbody2D rigidBody;

    public float shrinkSpeed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody.rotation = Random.Range(0, 360f);
        transform.localScale = Vector3.one * 10f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;

        if (transform.localScale.x <= 0.05f)
        {
            Destroy(gameObject);
        }
    }
}
