using UnityEngine;

/// <summary>
/// ������, ����������� ������ ��������� �� �������� Player
/// </summary>
public class CameraMove : MonoBehaviour
{
    [SerializeField]
    private GameObject player; // ������ ��������
    private Vector3 offset; // ���������� �� �������

    private void Start()
    {
        offset = transform.position - player.transform.position;
    }

    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
