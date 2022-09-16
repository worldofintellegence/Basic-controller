using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovemet : MonoBehaviour
{
    private float speed = 10;
    [SerializeField] float Bound = 20;
    private GameObject player;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
                
    }

    // Update is called once per frame
    void Update()
    {
        AI();
        if(transform.position.x > Bound || transform.position.z >Bound)
        {
            Destroy(gameObject);
        }
    }
    void AI()
    {
        Vector3 lookdirection = (player.transform.position - transform.position).normalized;
        rb.AddForce(lookdirection*speed);
    }
}
