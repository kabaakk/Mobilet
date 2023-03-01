using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TerrainTools;
using UnityEngine.UI;

public class Bar : MonoBehaviour
{
    [SerializeField] private Button[] buttons;
    [SerializeField] private Image time;
    [SerializeField] private Sprite[] sprites;
    [SerializeField] private float maxTime = 30f;
    ShopSystem shopSystem;
    TurnController turnController;
    BetAI betAI;
    float timeLeft;

    // Start is called before the first frame update
    void Start()
    {
        turnController = GetComponent<TurnController>();
        betAI = GetComponent<BetAI>();
        shopSystem = GetComponent<ShopSystem>();
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
                turnController.players[1].SetActive(false);
                turnController.players[0].SetActive(true);
                turnController.clicked = true;

                //betAI.second();

                /*if (TurnController.instance.firstCardClicked || TurnController.instance.secondCardClicked 
                    || TurnController.instance.thirdCardClicked || TurnController.instance.forthCardClicked)
                {
                    for (i = 0; i < TurnController.instance.betPanels.Length; i++)
                    {
                        Destroy(TurnController.instance.betPanels[i]);
                    }
                }*/
            }
            else if (time.sprite == sprites[2])
            {
                turnController.players[2].SetActive(false);
                turnController.players[1].SetActive(true);

                //betAI.third();
            }
            else if (time.sprite == sprites[3])
            {
                turnController.players[3].SetActive(false);
                turnController.players[2].SetActive(true);
                //betAI.forth();
                yield return new WaitForSeconds(maxTime);
                StopCoroutine(barChange());
                Debug.Log("All turn is over");
            }
            yield return new WaitForSeconds(maxTime);
        }
    }
}
