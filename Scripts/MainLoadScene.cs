using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainLoadScene : MonoBehaviour
{
    public void loadCreateRoom()
    {
        SceneManager.LoadScene("CreateRoomScene");
    }

    public void loadJoinRoom()
    {
        SceneManager.LoadScene("JoinRoomScene");
    }

    public void loadSettingScene()
    {
        SceneManager.LoadScene("SettingScene");
    }

    public void loadPlayingScene()
    {
        SceneManager.LoadScene("PlayingScene");
    }

    public void loadMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}
