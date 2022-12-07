using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteBlackjack : MonoBehaviour
{
    public static SpriteBlackjack instance;
    public Sprite[] sp_Cards;
    // Start is called before the first frame update
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
