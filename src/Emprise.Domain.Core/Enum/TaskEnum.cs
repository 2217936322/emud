﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Emprise.Domain.Core.Enum
{

    public enum TaskTypeEnum
    {
        新手 = 1,

        主线 = 2,

        支线 = 3,

        日常 = 4
    }

    /*
    /// <summary>
    /// 任务类型
    /// </summary>
    public enum TaskTypeEnum
    {
        其他 = 0,


        收集 = 1,

        杀怪 = 2,

        对话 = 3,

        护送 = 4,

        探索 = 5,

        

    }*/

    /// <summary>
    /// 任务周期
    /// </summary>
    public enum TaskPeriodEnum
    {
        不可重复 = 1,

        每天一次 = 2,

        每周一次 = 3,

        每月一次 = 4,

        每年一次 = 5,

        无限制 =6
    }


    /// <summary>
    /// 领取方式
    /// </summary>
    public enum TaskTakeTypeEnum
    {
        /// <summary>
        /// 通常通过command命令等实现
        /// </summary>
        手动领取 = 1,


        自动领取 = 2
    }


    /// <summary>
    /// 交付方式
    /// </summary>
    public enum TaskDeliverTypeEnum
    {
        /// <summary>
        /// 通常通过command命令等实现
        /// </summary>
        手动交付 = 1,


        自动交付 = 2
    }

    /// <summary>
    /// 任务触发方式
    /// </summary>
    public enum TaskTriggerTypeEnum 
    {
        升级 = 1,

        获得经验 = 2,

        移动 = 3,

        获得物品 = 4,

        完成任务 = 5,

        与Npc对话 = 6,


        杀死Npc = 7,

        探索房间 = 8,



        获得金钱 = 9
    }



    /// <summary>
    /// 任务触发条件
    /// </summary>
    public enum TaskTriggerConditionEnum
    {

        /// <summary>
        /// 升级时触发
        /// </summary>
        角色等级达到 = 1,

        /// <summary>
        /// 获得经验时触发
        /// </summary>
        角色经验值达到 = 2,

        /// <summary>
        /// 移动后触发
        /// </summary>
        所在房间 = 3,

        /// <summary>
        /// 获得物品时触发
        /// </summary>
        拥有某件物品达到数量 = 4,

        /// <summary>
        /// 必须完成该任务才能被触发
        /// </summary>
        完成前置任务 = 5,

        与某个Npc对话 = 6,


        杀死某个Npc = 7,

        探索某个房间 = 8,
    }

    /// <summary>
    /// 任务目标，完成条件
    /// </summary>
    public enum TaskTargetEnum
    {

        /// <summary>
        /// 升级时触发
        /// </summary>
        角色等级达到 = 1,

        /// <summary>
        /// 获得经验时触发
        /// </summary>
        角色经验值达到 = 2,

        /// <summary>
        /// 移动后触发
        /// </summary>
        所在房间 = 3,

        /// <summary>
        /// 获得物品时触发
        /// </summary>
        拥有某件物品达到数量 = 4,


        与某个Npc对话 = 5,


        杀死某个Npc = 6,

        探索某个房间 =7,

    }

    /// <summary>
    /// 任务奖励
    /// </summary>
    public enum TaskRewardEnum
    {
        金钱 = 1,
        经验 = 2,
        物品 = 3
    }


    /// <summary>
    /// 任务状态
    /// </summary>
    public enum TaskStateEnum
    {
        未领取 = 0,
        进行中 = 1,
        已失败 = 2,
        完成未领奖 = 3,
        完成已领奖 = 4
    }
}
