using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Config")]
    [SerializeField] private float speed;

    private Idk actions;

    private Rigidbody2D rb;
    private Animator animator; // Animator adicionado
    private Vector2 moveDirection;

    private void Awake()
    {
        actions = new Idk();
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>(); // Inicializa o Animator
    }

    private void OnEnable()
    {
        actions.Enable();
    }

    private void OnDisable()
    {
        actions.Disable();
    }

    private void Update()
    {
        ReadMovement(); // Agora também atualiza o Animator
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void ReadMovement()
    {
        moveDirection = actions.Movement.Move.ReadValue<Vector2>().normalized;

        // Se não houver movimento, sai do método
        if (moveDirection == Vector2.zero) return;

        // Atualiza os parâmetros do Animator para o BlendTree
        animator.SetFloat("MoveX", moveDirection.x);
        animator.SetFloat("MoveY", moveDirection.y);
    }

    private void Move()
    {
        rb.MovePosition(rb.position + moveDirection * (speed * Time.fixedDeltaTime));
    }
}
