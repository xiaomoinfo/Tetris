﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
*  作   者 ：胡朋
*  github : https://github.com/xiaomoinfo
*  描   述 ：模型
*/
public class Model : MonoBehaviour
{
    private const int column = 10;
    private const int row = 18;
    public Transform[,] map = new Transform[column, row];


    /// <summary>
    /// 地图是否可用
    /// </summary>
    /// <param name="t"></param>
    /// <returns></returns>
    public bool IsValidMapPosition(Transform t)
    {
        foreach (Transform child in t)
        {
            // 非block不能放入地图
            if (!child.CompareTag("Block"))
            {
                continue;
            }

            // 格子不能重叠
            Vector2 pos = child.position.Round();
            if (map[(int) pos.x, (int) pos.y] != null)
            {
                return false;
            }

            // 格子不能超出地图范围
            if (isInsideMap(pos))
            {
                return false;
            }
        }

        return false;
    }


    /// <summary>
    /// 是否在地图内
    /// </summary>
    /// <param name="pos"></param>
    /// <returns></returns>
    public bool isInsideMap(Vector2 pos)
    {
        return pos.x >= 0 && pos.y > 0 && pos.x < column && pos.y < row;
    }
}
