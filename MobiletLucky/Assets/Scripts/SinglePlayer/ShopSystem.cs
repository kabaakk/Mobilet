using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopSystem : MonoBehaviour
{
    int star = 0, realCash = 100, redChest = 50, greenChest = 150, yellowChest = 100, cardAmount = 100;
    public TextMeshProUGUI starText;
    [SerializeField] private TextMeshProUGUI cashText, redChestText, greenChestText, yellowChestText;
    [SerializeField] private GameObject ShopScroll, canvas, shopIcon, backIcon;
    TurnController turnController;
    [SerializeField] private Button[] Chests, Confirms;
    // Start is called before the first frame update
    void Start()
    {
        Blue();
        Green();
        Red();
        Yellow();
        ConfirmButton();
        turnController = GetComponent<TurnController>();
        ShopScroll.SetActive(false);
        starText.text = star.ToString();
        cashText.text = realCash.ToString();
        redChestText.text = redChest.ToString();
        greenChestText.text = greenChest.ToString();
        yellowChestText.text = yellowChest.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShopButton()
    {
        Time.timeScale = 0;
        ShopScroll.SetActive(true);
        canvas.SetActive(false);
        backIcon.SetActive(true);
        shopIcon.SetActive(false);
    }

    public void BackButton()
    {
        backIcon.SetActive(false);
        shopIcon.SetActive(true);
        Time.timeScale = 1;
        ShopScroll.SetActive(false);
        canvas.SetActive(true);
    }

    void RedChest()
    {
        if (realCash >= redChest)
        {
            realCash -= redChest;
            star += redChest;
            cashText.text = realCash.ToString();
            starText.text = star.ToString();
        } 
    }

    void GreenChest()
    {
        if (realCash >= greenChest)
        {
            realCash -= greenChest;
            star += greenChest;
            cashText.text = realCash.ToString();
            starText.text = star.ToString();
        }
    }

    void YellowChest()
    {
        if (realCash >= yellowChest)
        {
            realCash -= yellowChest;
            star += yellowChest;
            cashText.text = realCash.ToString();
            starText.text = star.ToString();
        }
    }

    void Green()
    {
        Chests[2].onClick.AddListener(GreenChest);
    }

    void Red()
    {
        Chests[0].onClick.AddListener(RedChest);
    }

    void Yellow()
    {
        Chests[1].onClick.AddListener(YellowChest);
    } 

    void Blue()
    {
        Chests[3].onClick.AddListener(BlueChest);
    }

    void BlueChest()
    {
        Debug.Log("100 cash 5 tl");
    }

    void ConfirmButton()
    {
        for (int i = 0; i < Confirms.Length; i++)
        {
            Confirms[i].onClick.AddListener(spentStar);
        }
    }

    void spentStar()
    {
        if (star >= cardAmount)
        {
            star -= cardAmount;
            starText.text = star.ToString();
            turnController.starConfirm();
        } else
        {
            Debug.Log("You don't have an enough star");
        }
    }

    public void giveupBuy()
    {
        StartCoroutine(DestPanels());
    }

    IEnumerator DestPanels()
    {
        yield return new WaitForSeconds(0.3f);

        for (int i = 0; i < turnController.betPanels.Length; i++)
        {
            Destroy(turnController.betPanels[i]);
        }
    }
}
