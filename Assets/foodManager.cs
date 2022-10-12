using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class foodManager : MonoBehaviour
{
    public Sprite foodSprite;
        
    
    // Start is called before the first frame update
   
    
    
    void Start()
    {

        for (var i = 0; i < 1000; i++) {
            GameObject tempFood = new GameObject();
            tempFood.AddComponent<SpriteRenderer>();
            tempFood.AddComponent<CircleCollider2D>();
            tempFood.AddComponent<Rigidbody2D>();

            tempFood.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            tempFood.GetComponent<CircleCollider2D>().radius = 0.5f;
            tempFood.GetComponent<CircleCollider2D>().isTrigger = true;
            tempFood.GetComponent<SpriteRenderer>().sprite = foodSprite;

            float randX = Random.Range(-50f, 50f);
            float randY = Random.Range(-50f, 50f);

            Vector3 randPos = new Vector3(randX, randY, 0);
            tempFood.transform.position = randPos;
            tempFood.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
            tempFood.name = "food";
            tempFood.GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
