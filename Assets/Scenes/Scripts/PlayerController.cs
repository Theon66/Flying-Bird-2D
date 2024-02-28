using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private float horizontalSpeed = 10;
    private float verticalSpeed = 7;
    private float horizontalInput;
    private float verticalInput;
    public TextMeshProUGUI gameoverText;
    public TextMeshProUGUI restartText;
    public TextMeshProUGUI time;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    public void StartTime()
    {
        Time.timeScale = 1;
        StartCoroutine(ChangeTime());
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * Time.deltaTime * horizontalSpeed * horizontalInput);
        transform.Translate(Vector3.up * Time.deltaTime * verticalSpeed * verticalInput);
        if(Input.GetKeyDown(KeyCode.R)) {
            // 重新加载场景
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            // 恢复游戏
            Time.timeScale = 1;
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        // 展示Gameover
        gameoverText.text = "GAME OVER";
        restartText.text = "PRESS R TO RESTART";
        // 碰撞后暂停游戏
        Time.timeScale = 0;
    }

    IEnumerator ChangeTime()
    {
        while(true)
        {
            time.text = TimeFormatter(Time.timeSinceLevelLoad);
            yield return new WaitForSeconds(1);
        }
    }

    string TimeFormatter(float time)
    {
        int minute = (int) (time / 60);
        int second = (int) (time % 60);
        return minute.ToString("D2") + ":" + second.ToString("D2");
    }
}
