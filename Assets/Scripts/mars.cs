using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mars : MonoBehaviour
{
    [SerializeField] protected float speed = -4f;
    private Transform my_transform;
    GameObject g;
    public Plot p;
    // Start is called before the first frame update
    void Start()
    {
        my_transform = this.GetComponent<Transform>();
        g =  this.GetComponentInParent<GameObject>();
        g.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (p.turn == 3)
        {
            g.SetActive(true);
            my_transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }
    }
}
