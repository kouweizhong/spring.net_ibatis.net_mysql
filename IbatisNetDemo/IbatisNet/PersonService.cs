using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IbatisNet.Entity;

namespace IbatisNet
{
    public  class PersonService
    {
        public List<Person> QueryAllPerson()
        {
            return BaseDao.GetMapper().QueryForList<Person>("SelectAllPerson", null) as List<Person>;
        }
    }
}
