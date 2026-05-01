using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance { get; private set; }
    
    private Rigidbody2D rb;
    [SerializeField] private float speed = 5f;

    public bool gameStarted = false;


    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        //desativa a física
        rb.simulated = false;
    }

    private void OnJump(InputValue value)
    {
        if (value.isPressed)
        {
            if (!gameStarted)
            {
                gameStarted = true;
                rb.simulated = true; //ativa a física
            }

            rb.linearVelocity = Vector2.up * speed;

        }
    }

    private void Update()
    {
        if (rb.linearVelocity.y < -speed)
        {
            rb.linearVelocity = Vector2.down * speed;
        }
    }
}
