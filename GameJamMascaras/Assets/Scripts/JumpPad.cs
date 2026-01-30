using UnityEngine;

public class JumpPad : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private float bounce = 20f;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) ;
        {


            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bounce, ForceMode2D.Force);




        }
    }


}
