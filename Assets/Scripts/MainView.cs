using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainView : MonoBehaviour
{
    [SerializeField] private Button _startGameBtn;
    void Start()
    {
        _startGameBtn.onClick.AddListener(() => StartNewGame());
    }
    private void StartNewGame()
    {
        SceneManager.LoadScene("Game");
    }
}
