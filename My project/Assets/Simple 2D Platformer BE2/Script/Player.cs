using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField, Header("ˆÚ“®‘¬“x")] public float _moveSpeed;

    private Vector2 _InputDirection;
    private Rigidbody2D _rigid;



    // Start is called before the first frame update
    void Start()
    {
        _rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _Move();
    }

    private void _Move()
    {
        _rigid.velocity = new Vector2(_InputDirection.x * _moveSpeed, _rigid.velocity.y);
    }

    public void _OnMove(InputAction.CallbackContext context)
    {
        _InputDirection = context.ReadValue<Vector2>();
    }
}
