using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IbatisNet.Entity
{
    public class Number
    {
        private decimal? pCOLUMN_1;
        /// <summary>
        /// Column_1
        /// </summary>       
        public decimal? COLUMN_1
        {
            get { return pCOLUMN_1; }
            set { pCOLUMN_1 = value; }
        }

        private decimal? pCOLUMN_2;
        /// <summary>
        /// Column_2
        /// </summary>       
        public decimal? COLUMN_2
        {
            get { return pCOLUMN_2; }
            set { pCOLUMN_2 = value; }
        }

        private decimal? pCOLUMN_3;
        /// <summary>
        /// Column_3
        /// </summary>       
        public decimal? COLUMN_3
        {
            get { return pCOLUMN_3; }
            set { pCOLUMN_3 = value; }
        }

        private string pID;
        /// <summary>
        /// ID
        /// </summary>       
        public string ID
        {
            get { return pID; }
            set { pID = value; }
        }

        private byte[] pBLOB1;
        /// <summary>
        /// BLOB1
        /// </summary>       
        public byte[] BLOB1
        {
            get { return pBLOB1; }
            set { pBLOB1 = value; }
        }

        private string pCLOB1;
        /// <summary>
        /// CLOB1
        /// </summary>       
        public string CLOB1
        {
            get { return pCLOB1; }
            set { pCLOB1 = value; }
        }     
    }
}
