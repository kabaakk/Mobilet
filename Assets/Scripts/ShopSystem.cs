using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopSystem : MonoBehaviour
{
    public int star = 0;
    int realCash = 100;
    int redChest = 50;
    int greenChest = 150; 
    int yellowChest = 100;
    public TextMeshProUGUI starText, cashText, redChestText, greenChestText, yellowChestText;
    public static ShopSystem instance;
    public GameObject ShopScroll, canvas;
    // Start is called before the first frame update
    void Start()
    {
        ShopScroll.SetActive(false);
        starText.text = star.ToString();
        cashText.text = realCash.ToString();
        redChestText.text = redChest.ToString();
        greenChestText.text = greenChest.ToString();
        yellowChestText.text = yellowChest.ToString();
    }

    private void Awake()
    {
        instance = this;
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
    }

    public void RedChest()
    {
        if (realCash >= redChest)
        {
            realCash -= redChest;
            star += redChest;
            cashText.text = realCash.ToString();
            starText.text = star.ToString();
        } 
    }

    public void GreenChest()
    {
        if (realCash >= greenChest)
        {
            realCash -= greenChest;
            star += greenChest;
            cashText.text = realCash.ToString();
            starText.text = star.ToString();
        }
    }

    public void YellowChest()
    {
        if (realCash >= yellowChest)
        {
            realCash -= yellowChest;
            star += yellowChest;
            cashText.text = realCash.ToString();
            starText.text = star.ToString();
        }
    }

    public void BlueChest()
    {
        Debug.Log("100 cash 5 tl");
    }
}
