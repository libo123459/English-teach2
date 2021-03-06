﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolData : MonoBehaviour
{
    public static List<List<string>> column = new List<List<string>>();

    private void Awake()
    {
        TextAsset binAsset = Resources.Load("VolData", typeof(TextAsset)) as TextAsset;
        //读取每一行的内容  
        string[] lineArray = binAsset.text.Split("\r"[0]);
        //创建二维数组  
        string[][] Array = new string[lineArray.Length][];
        //把csv中的数据储存在二位数组中  
        for (int _i = 0; _i < lineArray.Length; _i++)
        {
            Array[_i] = lineArray[_i].Split(',');
        }
        for (int i = 0; i < lineArray.Length; i++)
        {
            List<string> row = new List<string>();
            for (int j = 0; j < Array[i].Length; j++)
            {
                row.Add(Array[i][j]);
            }
            column.Add(row);
        }
    }

    public int GetVolID(int nRow)
    {
        return int.Parse(column[nRow][0]);
    }
    public static string GetVol(int nRow)
    {
        return (column[nRow][2]).ToString();
    }
    public static int GetUnit(int nRow)
    {
        return int.Parse(column[nRow][1]);
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
