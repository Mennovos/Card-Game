using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{
    [SerializeField] private float Speed = 5f;  
    private Vector3 Movement;

    public void Moves(InputAction.CallbackContext context)
    {
        Vector2 input = context.ReadValue<Vector2>();
        Movement.x = context.ReadValue<Vector2>().x;
        Movement.z = context.ReadValue<Vector2>().y;
    }
    private void Update()
    {
      transform.Translate(Movement * Speed * Time.deltaTime);
    }
}
