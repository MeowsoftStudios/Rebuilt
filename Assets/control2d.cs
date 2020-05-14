using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
class control2d : MonoBehaviour
{
    public static int trueend;
    public float speed;
    private Rigidbody2D rb;
    private Vector2 moveVelocity;

    

    void Start() => rb = GetComponent<Rigidbody2D>();
    void Update()
    {
        //movement prep
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * speed;
        
        //actually moving
        rb.MovePosition(rb.position + moveVelocity * Time.deltaTime);
        
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("oof"))
        {
            GameObject Player = GameObject.Find("Player");
            NextLV NextLV = Player.GetComponent<NextLV>();
            NextLV.currenthp = NextLV.currenthp -= 1;
            NextLV.SpriteSw();
            NextLV.SetHealth(NextLV.currenthp);
        }
        if (collider.gameObject.CompareTag("winn"))
        {
            GameObject Player = GameObject.Find("Player");
            NextLV nxtlv = Player.GetComponent<NextLV>();
            if (nxtlv.currenthp == 5)
            {
                if (trueend == 0) 
                { 
                    trueend = 1; 
                }
                if (trueend == 1)
                {
                    trueend = 2;
                }
                if (trueend == 2)
                {
                    trueend = 3;
                }
            }
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
