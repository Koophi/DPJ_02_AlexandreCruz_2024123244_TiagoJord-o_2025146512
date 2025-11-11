using UnityEngine;
using Game.Player;

public class PlayerMovement : MonoBehaviour
{
    [Header("Config")]
    [SerializeField] private float speed;

    public Idk actions;
    public Rigidbody2D rb;
    public Vector2 moveDirection;

    public PlayerAnimations playerAnimations;

    public Player player;

    public void Awake()
    {
        actions = new Idk();
        rb = GetComponent<Rigidbody2D>();
        playerAnimations = GetComponent<PlayerAnimations>();

        player = GetComponent<Player>();
    }

    public void OnEnable()
    {
        actions.Enable();
    }

    public void OnDisable()
    {
        actions.Disable();
    }

    public void Update()
    {
        ReadMovement();
    }

    public void FixedUpdate()
    {
        Move();
    }

    public void ReadMovement()
    {
        moveDirection = actions.Movement.Move.ReadValue<Vector2>().normalized;

        if (moveDirection == Vector2.zero)
        {
            playerAnimations.SetMoveBoolTransition(false);
            return;
        }

        playerAnimations.SetMoveBoolTransition(true);
        playerAnimations.SetMoveAnimation(moveDirection);
    }

    public void Move()
    {
        rb.MovePosition(rb.position + moveDirection * (speed * Time.fixedDeltaTime));
    }
}
