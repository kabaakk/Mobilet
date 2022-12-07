using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Bar : MonoBehaviour
{
    public Button[] buttons;
    public Image time;
    public Sprite[] sprites;
    public float maxTime = 30f;
    float timeLeft;
    // Start is called before the first frame update
    void Start()
    {
        time.sprite = sprites[0];
        timeLeft = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            time.fillAmount = timeLeft / maxTime;
        }
        else
        {
            StartCoroutine(barChange());
        }
    }
    IEnumerator barChange()
    {
        for (int i = 1; i < sprites.Length; i++)
        {
            timeLeft = maxTime;
            time.sprite = sprites[i];
            if (time.sprite == sprites[1])
            {
                TurnController.instance.players[1].SetActive(false);
                TurnController.instance.players[0].SetActive(true);
            }
            else if (time.sprite == sprites[2])
            {
                TurnController.instance.players[2].SetActive(false);
                TurnController.instance.players[1].SetActive(true);
            }
            else if (time.sprite == sprites[3])
            {
                TurnController.instance.players[3].SetActive(false);
                TurnController.instance.players[2].SetActive(true);
                yield return new WaitForSeconds(maxTime);
                TurnController.instance.game.SetActive(false);
            }
            yield return new WaitForSeconds(maxTime);
        }
    }
}
