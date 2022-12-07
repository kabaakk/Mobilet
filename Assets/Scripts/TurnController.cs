using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TurnController : MonoBehaviour
{
    bool clicked = false;
    public GameObject chosePlayer, game, betStar, betPanel;
    public GameObject[] players;
    public Transform[] bets;
    public Image[] users;
    public Sprite[] sprites;
    public TextMeshProUGUI betText;
    public static TurnController instance;

    // Start is called before the first frame update
    void Start()
    {
        players[0].SetActive(false);
        game.SetActive(false);
        chosePlayer.SetActive(true);
        Time.timeScale = 0;
    }

    private void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Player1()
    {
        users[0].sprite = sprites[0];
        chosePlayer.SetActive(false);
        game.SetActive(true);
        Time.timeScale = 1;
        players[0].SetActive(false);
    }
    public void Player2()
    {
        users[0].sprite = sprites[1];
        users[1].sprite = sprites[0];
        chosePlayer.SetActive(false);
        game.SetActive(true);
        Time.timeScale = 1;
    }
    public void Player3()
    {
        users[0].sprite = sprites[2];
        users[2].sprite = sprites[0];
        chosePlayer.SetActive(false);
        game.SetActive(true);
        Time.timeScale = 1;
    }
    public void Player4()
    {
        users[0].sprite = sprites[3];
        users[3].sprite = sprites[0];
        chosePlayer.SetActive(false);
        game.SetActive(true);
        Time.timeScale = 1;
    }
    public void Card1()
    {
        if (clicked != true)
        {
            Debug.Log("Bet card1");
            clicked = true;
            GameObject _card = Instantiate(betStar, bets[0].position, Quaternion.identity);
            _card.transform.SetParent(bets[0], true);
        }
    }
    public void Card2()
    {
        if (clicked != true)
        {
            Debug.Log("Bet card2");
            clicked = true;
            GameObject _card = Instantiate (betStar, bets[1].position, Quaternion.identity);
            _card.transform.SetParent(bets[1], true);
        }
    }
    public void Card3()
    {
        if (clicked != true)
        {
            Debug.Log("Bet card3");
            clicked = true;
            GameObject _card = Instantiate(betStar, bets[2].position, Quaternion.identity);
            _card.transform.SetParent(bets[2], true);
        }
    }
    public void Card4()
    {
        if (clicked != true)
        {
            Debug.Log("Bet card4");
            clicked = true;
            GameObject _card = Instantiate(betStar, bets[3].position, Quaternion.identity);
            _card.transform.SetParent(bets[3], true);
        }
    }
}
