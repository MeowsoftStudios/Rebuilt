using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
class spaceinvadersplayer : MonoBehaviour
{
    public static int trueend;
    public float speed2;
    private Rigidbody2D rb2d;
    private Vector2 moveVelocity2;



    void Start() => rb2d = GetComponent<Rigidbody2D>();
    void Update()
    {
        //movement prep
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity2 = moveInput.normalized * speed2;

        //actually moving
        rb2d.MovePosition(rb2d.position + moveVelocity2 * Time.deltaTime);

    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("oof"))
        {
            GameObject Player = GameObject.Find("BonusGamePlayer");
            HPbonus HPbonus = Player.GetComponent<HPbonus>();
            HPbonus.currenthpbonus = HPbonus.currenthpbonus -= 1;
            HPbonus.SetHealth(HPbonus.currenthpbonus);
        }
    }
}
