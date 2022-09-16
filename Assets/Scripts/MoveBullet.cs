using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{
    
    [SerializeField] int health= 100;
    public float Bound = 20;
    [SerializeField] float speed;
    Rigidbody rb;
    UiMangment ui;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ui = GetComponent<UiMangment>(); 
    }

    // Update is called once per frame
    void Update()
    {
         

         transform.Translate(Vector3.forward*speed * Time.deltaTime);
        if(transform.position.x > Bound || transform.position.z >Bound)
        {
            Destroy(gameObject);
        }
        
    }
     void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
           PlayerController.score += 25 ;
           
        }
       
    }
}
