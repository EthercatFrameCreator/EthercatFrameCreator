﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtherCATLib
{
    //TODO: yapıya uygun hale getir örn DatagramHeader.cs Propert Method Constructor
    
    public class EtherCATDatagram
    {
        #region Constructor
        public EtherCATDatagram()
        {
            Header = new DatagramHeader();
        }
        #endregion Constructor
        /// <summary>
        /// Standart header uzunluğunu döndürür. 10
        /// </summary>
        #region Propert
        private short HeaderLength { get { return 10; } } 
        //TODO: paramerelerin public private ayarları yapılcak mesela length
        private DatagramHeader header;

        public DatagramHeader Header
        {
            get { return header; }
            set { header = value; }
        }
        
        private byte[] data;
        
        public byte[] Data
        {
            get { return data; }
            set { data = value; }
        }
        #endregion Propert
        /// <summary>
        /// 10 bytelik dizi döndürür.
        /// </summary>
        /// <returns></returns>
        #region Method
        public byte[] GetBytes()
        {
           int DATALENGTH=Data.Length;
           byte[] ReturnByteArray= new byte[DATALENGTH+10];
           byte[] tmp=Header.GetBytes();
           int index = 0;
            foreach (var item in tmp)
            {
	            ReturnByteArray[index++] =item ;
            }
            for (int i = 0; i < DATALENGTH; i++)
            {
                ReturnByteArray[index++] =255 ;
            }
           
           return ReturnByteArray;

        }
        
        //TODO: get bytes array yazılacak;
        /// <summary>
        /// Datagramın toplam byte uzunluğunu döner
        /// </summary>
        /// <returns>byte array</returns>
        public short Length { 
            get
            {
                return BitConverter.GetBytes(HeaderLength + Data.Length)[0];
            }
        }
        #endregion Method

    }
}
