using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IbatisNet.Entity
{
    public class Person
    {
        private string _name;
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _sex;
        /// <summary>
        /// 性别 0-男 1-女
        /// </summary>
        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }

        private string _age;
        /// <summary>
        /// 年龄
        /// </summary>
        public string Age
        {
            get { return _age; }
            set { _age = value; }
        }

        private DateTime? _birthdate;
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime? Birthdate
        {
            get { return _birthdate; }
            set { _birthdate = value; }
        }
    }
}
