using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TurnController : MonoBehaviour
{
    public bool clicked = false;
    public bool appliedbet = false, firstCardClicked = false,
        secondCardClicked = false, thirdCardClicked = false, forthCardClicked = false,
        firstCardBet = false, secondCardBet = false, thirdCardBet = false, forthCardBet = false;
    [SerializeField] private GameObject chosePlayer, game;
    public GameObject[] players, betPanels;
    [SerializeField] private GameObject[] confirms;
    [SerializeField] private Transform[] cardsPosition;
    [SerializeField] private Image[] users;
    [SerializeField] private Sprite[] sprites;

    // Start is called before the first frame update
    void Start()
    {
        players[0].SetActive(false);
        game.SetActive(false);
        chosePlayer.SetActive(true);
        Time.timeScale = 0;
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
            Debug.Log("Take card1");
            clicked = true;
            firstCardClicked = true;
            
            if (firstCardClicked)
            {
                betPanels[0].SetActive(true);
            }
        }
    }
    public void Card2()
    {
        if (clicked != true)
        {
            Debug.Log("Take card2");
            clicked = true;
            secondCardClicked = true;

            if (secondCardClicked)
            {
                betPanels[1].SetActive(true);
                betPanels[0].SetActive(false);
            }
        }
    }
    public void Card3()
    {
        if (clicked != true)
        {
            Debug.Log("Take card3");
            clicked = true;
            thirdCardClicked = true;

            if (thirdCardClicked)
            {
                betPanels[2].SetActive(true);
                betPanels[1].SetActive(false);
                betPanels[0].SetActive(false);
            }
        }
    }

    public void Card4()
    {
        if (clicked != true)
        {
            Debug.Log("Take card4");
            clicked = true;
            forthCardClicked = true;

            if (forthCardClicked)
            {
                betPanels[3].SetActive(true);
                betPanels[2].SetActive(false);
                betPanels[1].SetActive(false);
                betPanels[0].SetActive(false);
            }
        }
    }

    public void starConfirm()
    {
        StartCoroutine(confirmed());
    }

    IEnumerator confirmed()
    {
        yield return new WaitForSeconds(0.1f);
        if (firstCardClicked)
        {
            confirms[0].SetActive(true);
            confirms[1].SetActive(false);
            confirms[2].SetActive(false);
            confirms[3].SetActive(false);
        }

        if (secondCardClicked)
        {
            confirms[0].SetActive(false);
            confirms[1].SetActive(true);
            confirms[2].SetActive(false);
            confirms[3].SetActive(false);
        }

        if (thirdCardClicked)
        {
            confirms[0].SetActive(false);
            confirms[1].SetActive(false);
            confirms[2].SetActive(true);
            confirms[3].SetActive(false);
        }

        if (forthCardClicked)
        {
            confirms[0].SetActive(false);
            confirms[1].SetActive(false);
            confirms[2].SetActive(false);
            confirms[3].SetActive(true);
        }

        StartCoroutine(DestPanels());
    }

    IEnumerator DestPanels()
    {
        yield return new WaitForSeconds(0.3f);

        for (int i = 0; i < betPanels.Length; i++)
        {
            Destroy(betPanels[i]);
        }
    }
}
