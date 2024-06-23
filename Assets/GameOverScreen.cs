using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public GameObject gameOverUI;

    // Start is called before the first frame update
    void Start()
    {
        gameOverUI.SetActive(false);  // Đảm bảo UI kết thúc trò chơi được tắt khi bắt đầu
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GameOver()
    {
        gameOverUI.SetActive(true);  // Hiển thị UI kết thúc trò chơi
    }

    public void RestartGame()
    {
        SceneManager.LoadScene();  // Khởi động lại cảnh hiện tại
    }


    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");  // Chuyển đến cảnh menu chính, đảm bảo rằng bạn đã thêm cảnh này vào Build Settings
    }
}
