using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFoodHandler : MonoBehaviour
{
    bool isColliding = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {
        isColliding = false;
    }

    
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.name == "food")
    //    {
    //        Destroy(collision.gameObject);
    //        transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);            
    //    }
    //    Debug.LogWarning("we hit a doods enter");
    //}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (isColliding)
            return;
        isColliding = true;

        if(other.gameObject.name == "food")
        {
            Destroy(other.gameObject);
            transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);
            transform.GetChild(0).GetComponent<Camera>().orthographicSize += 0.1f;
            transform.GetComponent<movement>().movementSpeed += 0.1f;
        }
        Debug.Log("we hit a doods trigger");
    }
}
