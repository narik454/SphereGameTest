using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// ������ ��� ������������ ������� � ��������������� � ������� ��������
/// </summary>
public class TimeScript : MonoBehaviour
{
    [SerializeField]
    private Text textTime; // ���� ������ �������
    [SerializeField]
    private Text infoMessage; // ���� ������ ���������� � ��������� ��� ��������
    [SerializeField]
    private GameObject infoPanel; // ������������ ������ ���� infoMessage

    private float startTime, realTime;

    private void Start()
    {
        startTime = Time.time;
    }

    private void Update()
    {
        realTime = Time.time - startTime;
        textTime.text = realTime.ToString("f2");

        if (Input.GetMouseButtonDown(0) && infoPanel.activeSelf == true)
        {
            SceneManager.LoadScene(0);
        }
    }

    public void SaveGame()
    {
        PlayerPrefs.SetString("SaveTime", realTime.ToString("f2"));
        PlayerPrefs.Save();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Finish")
        {
            SaveGame();
            Time.timeScale = 0;
            infoPanel.SetActive(true);
            infoMessage.text = "�� ��������: " + textTime.text;
        }

        if (other.tag == "Respawn")
        {
            Time.timeScale = 0;
            infoPanel.SetActive(true);
            infoMessage.text = "�� ���������";
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            Time.timeScale = 0;
            infoPanel.SetActive(true);
            infoMessage.text = "�� ���������";
        }
    }
}
