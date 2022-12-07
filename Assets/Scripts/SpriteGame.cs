using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteGame : MonoBehaviour
{
    public static SpriteGame instance;
    public Sprite[] sp_Cards;
    // Start is called before the first frame update
    private void Awake()
    {
        if(instance ==  null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        } 
        else
        {
            DestroyImmediate(gameObject);
        }
    }
    void Start()
    {
        /*for (int i = 0; i < sp_Cards.Length; i++)
        {
            sp_Cards[i] = Resources.Load("Resources");
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
