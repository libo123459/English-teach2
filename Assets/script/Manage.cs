using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manage : MonoBehaviour {
    public Transform panel_unit;

    public VolManage vManage;

    public GameObject mainmenu;

    public GameObject panel_part_select;
    public Button part_volc;
    public Button part_vgame;
    public Button part_senten;
    public Button part_sgame;

    public GameObject panel_part_vIntro;
    public GameObject panel_part_vGame;
    public GameObject panel_part_sIntro;
    public GameObject panel_part_sGame;

    public BTN_Unit btn;
    int currentnum;

    GameObject currentPanel;
	// Use this for initialization
	void Start () {
        Unit_btn_init();
        print(VolData.GetVol(2));
        currentnum = 0;
	}
    public void Unit_btn_init()
    {
        for (int i = 1; i <= 20; i++)
        {
            BTN_Unit temp = Instantiate(btn,panel_unit);
            temp.UnitNum = i;
        }
    }

    public void EnterTheUnit(int unitNum)//单元选择
    {
        currentnum = unitNum;
        
        mainmenu.SetActive(false);
        panel_part_select.SetActive(true);
        currentPanel = panel_part_select;        
    }

    public void EnterTheVolc()//进入词汇介绍
    {
        panel_part_select.SetActive(false);
        panel_part_vIntro.SetActive(true);
        currentPanel = panel_part_vIntro;
        vManage.EnterTheVolc(currentnum);
    }

    public void EnterTheVgame()//词汇游戏界面
    {
        panel_part_select.SetActive(false);
        panel_part_vGame.SetActive(true);
        currentPanel = panel_part_vGame;
        vManage.EnterTheVgame(currentnum);
    }

    public void EnterTheSenten()//句型介绍
    {
        panel_part_select.SetActive(false);
        panel_part_sIntro.SetActive(true);
        currentPanel = panel_part_sIntro;
    }
    public void EnterTheSGame()//句型游戏界面
    {
        panel_part_select.SetActive(false);
        panel_part_sGame.SetActive(true);
        currentPanel = panel_part_sGame;
    }

    public void ReturnToMain()
    {
        currentPanel.SetActive(false);
        mainmenu.SetActive(true);
    }
    public void ReturnToSelect()
    {
        currentPanel.SetActive(false);
        panel_part_select.SetActive(true);

        currentPanel = panel_part_select;
    }
    // Update is called once per frame
    void Update () {
		
	}
}
