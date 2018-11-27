using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

public class volc_match : MonoBehaviour, IDragHandler, IEndDragHandler
{
    public string volc;
    public int id;
    bool right = false;
    new GameObject collider;
    new Vector3 start;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collider = collision.gameObject;
        if (collision.GetComponent<volc_target>().volc == volc)
        {
            right = true;
        }
    }
    

    private void OnTriggerExit2D(Collider2D collision)
    {
        right = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)///
    {
        if (right == true)
        {
            this.transform.position = collider.transform.position;///正确匹配时的结算
        }
        else {
            this.transform.position = start;
        }

    }

    // Use this for initialization
    void Start()
    {
        start = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
