using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MouseSensitive : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private int Id;
    public void OnPointerClick(PointerEventData eventData)
    {
        //if (Id == 1) /*CompareContent.Instance.CompareLines();*/ Debug.Log(0);
        if (Id == 3) SceneManager.LoadScene("Main");
        //if (Id == 10) return;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        this.transform.localScale = new Vector3(1.12f, 1.12f, 1.12f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        this.transform.localScale = new Vector3(1, 1, 1);
    }
}
