using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerUIController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreTMP;
    [SerializeField] private TextMeshProUGUI _bestScoreTMP;

    [SerializeField] private TextMeshProUGUI _resultScoreTMP;
    [SerializeField] private TextMeshProUGUI _highScoreTMP;
    [SerializeField] private GameObject _gameOverUI;
    [SerializeField] private Button _restartBtn;
    [SerializeField] private Button _goToMainMenuBtn2;

    [SerializeField] private Button _pauseBtn;
    [SerializeField] private Button _unpauseBtn;
    [SerializeField] private Button _goToMainMenuBtn;

    private WaitForSeconds sec = new WaitForSeconds(1);

    void Start()
    {
        Time.timeScale = 1f;
        GameManager.Score = 0;
        _gameOverUI.SetActive(false);

        _pauseBtn.onClick.AddListener(() => StartCoroutine(Pause()));
        _unpauseBtn.onClick.AddListener(() => Unpause());
        _goToMainMenuBtn.onClick.AddListener(() => GoToMainMenu());
        _goToMainMenuBtn2.onClick.AddListener(() => GoToMainMenu());
        _restartBtn.onClick.AddListener(Restart);
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectsWithTag("Player").Length == 0)
        {
            _gameOverUI.SetActive(true);
        }

        _scoreTMP.text = $"Score\n{GameManager.Score}";
        _bestScoreTMP.text = $"Best Score\n{GameManager.BestScore}";

        _resultScoreTMP.text = $"SCORE\n{GameManager.Score}";
        _highScoreTMP.text = $"HIGHT SCORE\n{GameManager.BestScore}";
    }
    IEnumerator Pause()
    {
        yield return sec;
        Time.timeScale = 0.0f;
    }
    private void Unpause()
    {
        Time.timeScale = 1.0f;
    }
    private void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    private void Restart()
    {
        SceneManager.LoadScene("Game");
    }
}
