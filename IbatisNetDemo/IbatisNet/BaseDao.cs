using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;

namespace IbatisNet
{
    public class BaseDao
    {
        /// <summary>
        /// 配置SQL映射
        /// </summary>
        /// <returns>SQL映射</returns>
        public static ISqlMapper GetMapper()
        {
            DomSqlMapBuilder builder = new DomSqlMapBuilder();
            ISqlMapper Map = builder.Configure("Config/sqlmap.config");
            return Map;
        }
    }
}
