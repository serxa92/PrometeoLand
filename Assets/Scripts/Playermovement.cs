using UnityEngine;

public class Playermovement : MonoBehaviour
{
    //Velocidad del jugador
    public float speed = 5f;

    //Referencia al Rigidbody2D del jugador
    private Rigidbody2D rb;

    //Variable para almacenar el movimiento del jugador
    private Vector2 movement;

    void Start()
    {
        //Obtener la referencia al Rigidbody2D
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");

        float y = Input.GetAxisRaw("Vertical");

        movement = new Vector2(x, y).normalized;
    }

    void FixedUpdate()
    {
          rb.MovePosition(

            rb.position + movement * speed * Time.fixedDeltaTime

        );
    }




}
