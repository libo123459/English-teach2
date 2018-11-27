using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BTN_Unit : MonoBehaviour {
    public int UnitNum;
    Manage manage;
    // Use this for initialization
    private void Awake()
    {
        manage = GameObject.Find("Main Camera").GetComponent<Manage>();
        this.GetComponent<Button>().onClick.AddListener(() => manage.EnterTheUnit(UnitNum));
        
    }
    
    void Start () {
        if (this.UnitNum == 1)////一单元演示临时封闭其他
        {
            this.GetComponent<Button>().enabled = true;
        }
        else
        {
            this.GetComponent<Button>().enabled = false;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
