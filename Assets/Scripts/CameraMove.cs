using UnityEngine;

/// <summary>
/// Скрипт, позволяющий камере следовать за объектом Player
/// </summary>
public class CameraMove : MonoBehaviour
{
    [SerializeField]
    private GameObject player; // Объект слежения
    private Vector3 offset; // Расстояние до объекта

    private void Start()
    {
        offset = transform.position - player.transform.position;
    }

    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
