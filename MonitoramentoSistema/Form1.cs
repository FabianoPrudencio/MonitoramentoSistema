using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;

namespace MonitoramentoSistema
{
    public partial class Form1 : Form
    {
        private PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");

        private PerformanceCounter ramCounter = new PerformanceCounter("Memory", "Available MBytes");

        private PerformanceCounter networkCounterIn = new PerformanceCounter("Network Interface", "Bytes Received/sec", "Ethernet");
        private PerformanceCounter networkCounterOut = new PerformanceCounter("Network Interface", "Bytes Sent/sec", "Ethernet");
                
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateCPUUsage()
        {
            float cpuUsage = cpuCounter.NextValue();
            PBcpu.Value = (int)cpuUsage;
            LBLcpu.Text = $"CPU: {cpuUsage}%";
        }

        private void UpdateMemoryUsage()
        {
            float availableMemory = ramCounter.NextValue();
            float totalMemory = Convert.ToInt32(new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory / 1024 / 1024);
            float usedMemory = totalMemory - availableMemory;

            PBmemoria.Value = (int)((usedMemory / totalMemory) * 100);
            LBLmemoria.Text = $"Memória Usada: {usedMemory} MB / {totalMemory} MB";
        }

        private void UpdateDiskUsage()
        {
            DriveInfo drive = new DriveInfo("C"); // Ou qualquer outra unidade, como D:
            long totalSpace = drive.TotalSize;
            long availableSpace = drive.AvailableFreeSpace;
            float usedSpace = totalSpace - availableSpace;

            PBdisco.Value = (int)((usedSpace / totalSpace) * 100);
            LBLdisco.Text = $"Espaço no Disco: {usedSpace / 1024 / 1024} MB / {totalSpace / 1024 / 1024} MB";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateCPUUsage();
            UpdateMemoryUsage();
            UpdateDiskUsage();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

            string connectionType = GetConnectionType();
            LBconnect.Text = connectionType;

            if (IsInternetAvailable())
            {
                LBinterntetin.Text = "Conectado à Internet.";
            }
            else
            {
                LBinterntetin.Text = "Não está conectado à Internet.";
            }
        }

        public bool IsInternetAvailable()
        {
            try
            {
                // Tentando acessar uma URL conhecida (Google)
                using (WebClient client = new WebClient())
                {
                    client.DownloadString("http://www.google.com"); // Ou "https://www.google.com"
                    return true; // Conectado à internet
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar conexão: " + ex.Message);
                return false; // Se houver erro, considera que não está conectado
            }
        }

        public string GetConnectionType()
        {
            // Obtém todas as interfaces de rede disponíveis no sistema
            var networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

            foreach (var ni in networkInterfaces)
            {
                // Verifica se a interface está ativa
                if (ni.OperationalStatus == OperationalStatus.Up)
                {
                    // Verifica o tipo de interface (Wi-Fi ou Ethernet)
                    if (ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
                    {
                        return "Conectado via Wi-Fi";
                    }
                    else if (ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                    {
                        return "Conectado via Cabo (Ethernet)";
                    }
                }
            }

            return "Sem conexão de rede ativa";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult Exit = MessageBox.Show("Deseja Sair?","CONFIRMAÇÃO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Exit == DialogResult.OK) 
            {
                Application.Exit();
            }
        }
    }
}
