using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthMovement : MonoBehaviour
{
    [SerializeField] protected float speed = 4f;
    private Transform my_transform;
    // Start is called before the first frame update
    void Start()
    {
        my_transform = this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        my_transform.RotateAround(new Vector3(0,0,0), new Vector3(0, 0, 1), speed);
    }
}
