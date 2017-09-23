﻿using System.Collections;
using System.Collections.Generic;
using Umeng;
using UnityEngine;

public class StatisticsManager
{
    /// <summary>
    /// 开始统计 默认发送策略为启动时发送
    /// </summary>
    /// <param name="appKey">appKey</param>
    /// <param name="channelId">渠道名称</param>
    public static void AppKeyAndChannelId(string appKey, string channelId)
    {
        GA.StartWithAppKeyAndChannelId(appKey, channelId);
        Debug.Log("开始统计 默认发送策略为启动时发送");
    }

    public static void SetLogEnabled(bool opne)
    {
        GA.SetLogEnabled(opne);
    }

    /// <summary>
    /// 进入关卡.
    /// </summary>
    /// <param name="level"></param>
    public static void StartLevel(string level)
    {
        GA.StartLevel(level);
        StatisticsMgr.des += "Lvstart"+ level;
        GA.Event("Lvstart",level);
        Debug.Log("进入关卡");
    }
    /// <summary>
    /// 通过关卡.
    /// </summary>
    /// <param name="level"></param>
    public static void FinishLevel(string level)
    {
        GA.FinishLevel(level);
        Debug.Log("通过关卡");
    }
    /// <summary>
    /// 未通过关卡.
    /// </summary>
    /// <param name="level"></param>
    public static void FailLevel(string level)
    {
        GA.FailLevel(level);
        Debug.Log("未通过关卡.");
    }

    /// <summary>
    /// 玩家使用虚拟币购买道具
    /// </summary>
    /// <param name="item">道具名称</param>
    /// <param name="amount">道具数量</param>
    /// <param name="price">道具单价</param>
    public static void Use(string item, int amount, double price)
    {
        GA.Use(item, amount, price);
        Debug.Log(string.Format("道具名称：{0}  道具数量：{1}  道具单价：{2}", item,amount, price));
    }


    /// <summary>
    /// 玩家使用虚拟币购买道具
    /// </summary>
    /// <param name="item">道具名称</param>
    /// <param name="amount">道具数量</param>
    /// <param name="price">道具单价</param>
    public static void Buy(string item, int amount, double price)
    {
        GA.Buy(item, amount, price);
    }
}