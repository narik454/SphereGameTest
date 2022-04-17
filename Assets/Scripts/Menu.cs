using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// ������ ���������� ������� ����
/// </summary>
public class Menu : MonoBehaviour
{
    [SerializeField]
    private Text scoreText;
    [SerializeField]
    private GameObject buttons;
    [SerializeField]
    private GameObject scores;


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            scores.SetActive(false);
            buttons.SetActive(true);
        }
    }

    public void PlayButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void ScoreButton()
    {
        buttons.SetActive(false);
        scores.SetActive(true);

        if (PlayerPrefs.HasKey("SaveTime"))
        {
            scoreText.text = "��������� ������� ����: " + PlayerPrefs.GetString("SaveTime");
        }
        else
        {
            scoreText.text = "��� �����������. ������� �� ������!!!";
        }
    }
}
