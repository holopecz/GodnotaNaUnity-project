using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class PlayerJump : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private Animator _animator;
    [SerializeField] private float _speed;
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TransformJump();
        }
    }
    private void RigidbodyJump()
    {
        _rigidbody.AddForce(Vector3.up * _speed, ForceMode.VelocityChange);
    }
    private void AnimationJump()
    {
        _animator.SetTrigger("Jump");
    }
    private void TransformJump()
    {
        transform.position += new Vector3(0, 5, 0);
    }
}

