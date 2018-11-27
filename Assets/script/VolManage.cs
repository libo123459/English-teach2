using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class VolManage : MonoBehaviour {
    public Transform grid;
    static List<string> VolList = new List<string>();
    static List<BTN_Vol> btn_vol_list = new List<BTN_Vol>();
    public BTN_Vol btn_vol;
    public Button btn_show;

    public Text question;
    //public int currentnum = 1;
	// Use this for initialization
	void Start () {
        
	}

    public void OpenVolIntro(BTN_Vol btn)
    {
        btn_show.transform.GetChild(0).GetComponent<Text>().text = btn.text.text;
    }

    public void EnterTheVolc(int unitnum)///进入词汇界面
    {
        for (int i = unitnum; i < 61; i++)
        {
            BTN_Vol temp = Instantiate(btn_vol, grid);
            if (VolData.GetUnit(i) == unitnum)
            {
                VolList.Add(VolData.GetVol(i));
            }
            temp.text.text = VolData.GetVol(i);
        }
    }
    
    public void EnterTheVgame(int unitnum)
    {

    }

    public void BigAndSmall()
    {
        question.text = "Who has big eyes? Who has small eyes?\n Match the eyes to the correct face";
    }

    public void ThickAndThin()
    {
        question.text = "Who has thick eyebrows? Who has thin eyebrows?";
    }

    public void LongAndShort()
    {
        question.text = "Who has long hair? Who has short hair?\n Match the hair to the correct head n";
    }
    // Update is called once per frame
    void Update () {
		
	}
}
