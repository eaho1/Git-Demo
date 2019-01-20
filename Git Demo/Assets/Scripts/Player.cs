using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Input.GetAxis("Horizontal") * Vector2.right);
    }
    
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log(other.collider.name);
    }

}
