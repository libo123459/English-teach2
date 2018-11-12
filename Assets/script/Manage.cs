using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manage : MonoBehaviour {
    public Transform panel_unit;
    public BTN_Unit btn;
	// Use this for initialization
	void Start () {
        Unit_btn_init();
	}
    public void Unit_btn_init()
    {
        for (int i = 1; i <= 20; i++)
        {
            BTN_Unit temp = Instantiate(btn,panel_unit);
            temp.UnitNum = i;
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
