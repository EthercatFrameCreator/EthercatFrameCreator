﻿

using PacketDotNet;
using System.Collections.Generic;

namespace EthercatFuzzer
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EthernetSender frame;
        private void Form1_Load(object sender, System.EventArgs e)
        {
            frame = new EthernetSender();
            List<string> deviceList = EthernetSender.getDeviceList();
            foreach (var item in deviceList)
            {
                cmbDeviceList.Items.Add(item);
            }
            
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            UIContract UIData = new UIContract();
            //UIData.SelectedCmd=
            
            frame.Gonder(100,cmbDeviceList.SelectedIndex);
        }

    }
}
