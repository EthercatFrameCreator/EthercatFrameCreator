﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtherCATLib
{
    //TODO: yapıya uygun hale getir örn DatagramHeader.cs Propert Method Constructor
    class EtherCATHeader
    {    
        #region Property
       
        private Int16 eLen;

         public Int16 ELength
        {
            get { return eLen; }

            set { eLen = value; }
        }
         private byte eRes;

         public byte EReserved
         {
             get { return eRes; }
             set { eRes = value; }
         }
         private byte eType;

         public byte EType
         {
             get { return eType; }
             set { eType = value; }
         }
         #endregion Property
         #region Constructor
         public EtherCATHeader(Int16 ELength, byte EReserved, byte EType)
         {
             // TODO: resorved alanı normalde 0 olacak. 
             //TODO lenghtler hep dataların lengthini alacak
             this.ELength = ELength;
             this.EReserved = EReserved;
             this.EType = EType;


         }
        
         public EtherCATHeader()
         {


         }
         #endregion Constructor
         #region Method
         internal byte[] GetBytes()
         {
             int headerAsInt = EReserved * TwoPow.eleven + ELength + EType * TwoPow.twelve;
             byte[] headerAsByte = BitConverter.GetBytes(headerAsInt);

             return new byte[] { headerAsByte[0], headerAsByte[1] };
         }
        #endregion Method
    }
}
