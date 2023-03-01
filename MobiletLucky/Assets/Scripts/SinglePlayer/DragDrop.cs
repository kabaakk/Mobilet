using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour
{
    bool isDragging = false, ismyCard = false, isEmpty = true;
    TurnController turnController;
    private GameObject startParent;
    private Vector2 startPosition;
    private GameObject dropZone;
    private bool isOverDropZone;
    // Start is called before the first frame update
    void Start()
    {
        turnController = FindObjectOfType<TurnController>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (ismyCard)
        {
            isOverDropZone = true;
            dropZone = collision.gameObject;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (ismyCard)
        {
            isOverDropZone = false;
            dropZone = null;
        }
    }

    public void StartDrag()
    {
        Transform[] allParents = this.transform.GetComponentsInParent<Transform>();
        for (int i = 0; i < allParents.Length; i++)
        {
            GameObject gameObject = allParents[1].gameObject;
            if (gameObject.tag == "MyCard")
            {
                ismyCard = true;
            }
        }

        if (ismyCard)
        {
            isDragging = true;
            startParent = transform.parent.gameObject;
            startPosition = transform.position;
        }
    }

    public void Click()
    {
        Transform[] allParents = this.transform.GetComponentsInParent<Transform>();
        for (int i = 0; i < allParents.Length; i++)
        {
            GameObject gameObject = allParents[1].gameObject;
            if (gameObject.tag == "Card1")
            {
                turnController.Card1();
            }

            if (gameObject.tag == "Card2")
            {
                turnController.Card2();
            }

            if (gameObject.tag == "Card3")
            {
                turnController.Card3();
            }

            if (gameObject.tag == "Card4")
            {
                turnController.Card4();
            }
        }
    }

    public void EndDrag()
    {
        isDragging = false;
        if (isOverDropZone && dropZone.transform.childCount == 1)
        {
            transform.SetParent(dropZone.transform, false);
            transform.localScale = new Vector2(1.9f, 1.11f);
            transform.localPosition = new Vector2(0, 0);
        } else
        {
            transform.position = startPosition;
            transform.SetParent(startParent.transform, false);
        }
    }

    private void Update()
    {
        if (isDragging)
        {
            transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }
    }
}
