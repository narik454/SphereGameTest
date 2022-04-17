using UnityEngine;

/// <summary>
/// ���������� �������� Player
/// </summary>
public class MoveControl : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f; // �������� �������
    private Rigidbody rb; // ������

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal") * speed;
        float vertical = Input.GetAxis("Vertical") * speed;

        rb.AddForce(horizontal, 0, vertical);
    } 
}
