using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balloon : MonoBehaviour
{

    [SerializeField] Vector3 force;  //allow you to edit in the editor
    [SerializeField] Sprite[] ballonSprites; //edit sprite

    private UIManager UIMger;

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer; 




    void Start()
    {
        UIMger = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();


        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        spriteRenderer.sprite = ballonSprites[Random.Range(0,2)];

        transform.position = new Vector3(Random.Range(-3.95f,3.95f), transform.position.y, transform.position.z);

        force = new Vector3(Random.Range(-100,100), Random.Range(150,250),0);

        rb.AddForce(force);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.gameObject.tag == "top_wall")
        {
            Destroy(this.gameObject);
        } else if (collision.gameObject.tag == "bullet")
        {
            UIMger.AddScore();
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
    }

    
}
