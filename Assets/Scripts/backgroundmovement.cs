using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundmovement : MonoBehaviour
{
    private Transform m_transform;
    public float speed = -2.0f;
    // Start is called before the first frame update
    void Start()
    {
        m_transform = this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        m_transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));        
    }
}
