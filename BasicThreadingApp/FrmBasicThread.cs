using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
namespace BasicThreading
{
    public partial class FrmBasicThread : Form
    {
        private Thread ThreadA, ThreadB;
        public FrmBasicThread()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "-Before Starting Thread-";
            Console.WriteLine("-Before Starting Thread-");
            ThreadStart threadstart = new ThreadStart(MyThreadClass.Thread1);
            ThreadA = new Thread(threadstart);
            ThreadA.Name = "Thread A Process";
            ThreadB = new Thread(threadstart);
            ThreadB.Name = "Thread B Process";

            ThreadA.Start();
            ThreadB.Start();
            ThreadA.Join();
            ThreadB.Join();

            lblStatus.Text = "-End of Thread-";
            Console.WriteLine("-End of Thread-");
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
