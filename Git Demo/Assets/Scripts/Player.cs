using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Input.GetAxis("Horizontal") * speed * Vector2.right);
    }
    
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log(other.collider.name);
    }

}
