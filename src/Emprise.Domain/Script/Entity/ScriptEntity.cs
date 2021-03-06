﻿using Emprise.Domain.Core.Entity;
using Emprise.Domain.Core.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Emprise.Domain.Script.Entity
{
    [Table("Script")]
    public class ScriptEntity : BaseEntity
    {
        /// <summary>
        /// 脚本名称
        /// </summary>
        public string Name { set; get; }

        /// <summary>
        /// 脚本类型
        /// </summary>
        public ScriptTypeEnum Type { set; get; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsEnable { set; get; }
    }
}
