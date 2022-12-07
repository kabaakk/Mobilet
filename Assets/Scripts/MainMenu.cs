using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public void MobiletLucky()
    {
        SceneManager.LoadScene("SinglePlayer");
    }
    public void Blackjack()
    {
        SceneManager.LoadScene("Blackjack");
    }
    public void Settings()
    {
        Debug.Log("settings");
    }
    public void Quit()
    {
        Debug.Log("quit");
    }
}
