using UnityEngine;
using System.Collections; 
using System.Collections.Generic;
public class Pipes : MonoBehaviour
{
    public Transform top;
    public Transform bottom;
    public float speed = 3f;

    private float leftEdge;

    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).x - 1f;
    }

    private void Update()
    {
        transform.position += ((Vector3.left * speed) * (Time.deltaTime)/2);

        if (transform.position.x < leftEdge)
        {
            Destroy(gameObject);
        }
    }

}
