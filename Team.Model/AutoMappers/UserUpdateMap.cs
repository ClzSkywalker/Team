﻿using Team.Model.Model;

namespace Team.Model.AutoMappers
{
    /// <summary>
    /// 用户修改模板
    /// </summary>
    public class UserUpdateMap
    {
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 性别，1为男，0为女
        /// </summary>
        public Sex Sex { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        public int Province { get; set; }

        /// <summary>
        /// 大学
        /// </summary>
        public int UniversityId { get; set; }

        /// <summary>
        /// 学号
        /// </summary>
        public int studentId { get; set; }
    }
}