using PvZBFNSysBot.Network;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PvZBFNSysBot.WinForms
{
    public partial class MainForm : Form
    {
        private readonly ConnectionManager _connectionManager;
        private bool readyForUserInput = false;

        private long fpsCapAddress = 0;
        private long coinsAddress = 0;
        private long[] coinOffsets = { 0xB575D10, 0xF0, 0x3D50, 0x1D8, 0x18 };
        private long[] fpsCapOffsets = { 0xB86FE80, 0x388, 0xF24 };

        public MainForm()
        {
            InitializeComponent();
            _connectionManager = new();
            ipTextBox.Text = Properties.Settings.Default.IpAddress;
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (_connectionManager.IsSwitchConnected)
            {
                TryDisconnect();
                return;
            }

            if (!_connectionManager.TryConnect(ipTextBox.Text, 6000, out string error))
            {
                if (error != string.Empty)
                    MessageBox.Show($"Error: failed to connect to the IP address.");
                else
                    MessageBox.Show($"Error:\r\n{error}");

                return;
            }
            else
            {
                string titleId = _connectionManager.SendCommandAsIs("getTitleID", 33)[..16].Trim();
                if (titleId != "0100C56010FD8000" && titleId != "100C56010FD8000")
                {
                    MessageBox.Show($"Error: The active process is not PvZ BFN.");
                    return;
                }
            }

            connectButton.Text = "Disconnect";

            statusLabel.ForeColor = Color.Green;
            statusLabel.Text = "Connected";

            fpsCapAddress = ResolvePointer(fpsCapOffsets);
            coinsAddress = ResolvePointer(coinOffsets);

            coinsBox.Enabled = true;
            bulbsBox.Enabled = true;
            tacoBox.Enabled = true;
            marshmallowBox.Enabled = true;
            badgesBox.Enabled = true;
            submitCurrencyChangesButton.Enabled = true;

            instantPrestigeCheckbox.Enabled = true;
            fpsCapCheckbox.Enabled = true;
            freeOnlineCheckbox.Enabled = true;

            coinsBox.Text = BitConverter.ToInt32(_connectionManager.PeekAbsoluteAddress(coinsAddress, 4)).ToString();
            bulbsBox.Text = BitConverter.ToInt32(_connectionManager.PeekAbsoluteAddress(coinsAddress + 0x20, 4)).ToString();
            marshmallowBox.Text = BitConverter.ToInt32(_connectionManager.PeekAbsoluteAddress(coinsAddress + 0x40, 4)).ToString();
            badgesBox.Text = BitConverter.ToInt32(_connectionManager.PeekAbsoluteAddress(coinsAddress + 0x80, 4)).ToString();
            tacoBox.Text = BitConverter.ToInt32(_connectionManager.PeekAbsoluteAddress(coinsAddress + 0xA0, 4)).ToString();

            Properties.Settings.Default.IpAddress = ipTextBox.Text;
            Properties.Settings.Default.Save();
            readyForUserInput = true;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TryDisconnect();
        }

        private bool IsConnected()
        {
            if (!readyForUserInput)
                return false;
            if (!_connectionManager.IsSwitchConnected)
            {
                MessageBox.Show("Not connected");
                return false;
            }

            return true;
        }

        private void TryDisconnect()
        {
            _connectionManager.TryDisconnect();

            connectButton.Text = "Connect";

            statusLabel.ForeColor = Color.Red;
            statusLabel.Text = "Not connected";
            
            fpsCapCheckbox.Enabled = false;
            freeOnlineCheckbox.Enabled = false;

            coinsBox.Enabled = false;
            bulbsBox.Enabled = false;
            tacoBox.Enabled = false;
            marshmallowBox.Enabled = false;
            badgesBox.Enabled = false;
            submitCurrencyChangesButton.Enabled = false;
            
            instantPrestigeCheckbox.Enabled = false;
            freeOnlineCheckbox.Enabled = false;
            fpsCapCheckbox.Enabled = false;

            readyForUserInput = false;
        }

        private long ResolvePointer(long[] offsets)
        {
            long addr = BitConverter.ToInt64(_connectionManager.PeekMainAddress(offsets[0], 8));
            for (int i = 1; i < offsets.Length; ++i)
            {
                addr += offsets[i];
                if (i == offsets.Length - 1)
                    return addr;
                
                addr = BitConverter.ToInt64(_connectionManager.PeekAbsoluteAddress(addr, 8));
            }
            return 0;
        }

        private void submitCurrencyChangesButton_Click(object sender, EventArgs e)
        {
            if (IsConnected())
            {
                int coins = Convert.ToInt32(coinsBox.Text);
                int bulbs = Convert.ToInt32(bulbsBox.Text);
                int tacos = Convert.ToInt32(tacoBox.Text);
                int marshmallows = Convert.ToInt32(marshmallowBox.Text);
                int badges = Convert.ToInt32(badgesBox.Text);

                _connectionManager.PokeAbsoluteAddress(coinsAddress, BitConverter.ToString(BitConverter.GetBytes(coins)).Replace("-", string.Empty));
                _connectionManager.PokeAbsoluteAddress(coinsAddress + 0x20, BitConverter.ToString(BitConverter.GetBytes(bulbs)).Replace("-", string.Empty));
                _connectionManager.PokeAbsoluteAddress(coinsAddress + 0x40, BitConverter.ToString(BitConverter.GetBytes(marshmallows)).Replace("-", string.Empty));
                _connectionManager.PokeAbsoluteAddress(coinsAddress + 0x80, BitConverter.ToString(BitConverter.GetBytes(badges)).Replace("-", string.Empty));
                _connectionManager.PokeAbsoluteAddress(coinsAddress + 0xA0, BitConverter.ToString(BitConverter.GetBytes(tacos)).Replace("-", string.Empty));
            }
        }

        private void instantPrestigeCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (IsConnected())
            {
                if (instantPrestigeCheckbox.Checked)
                    _connectionManager.PokeMain(0x3D272FC, "1F2003D5");
                else
                    _connectionManager.PokeMain(0x3D272FC, "0020211E");
            }
        }

        private void freeOnlineCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (IsConnected())
            {
                if (freeOnlineCheckbox.Checked)
                    _connectionManager.PokeMain(0x301D770, "41000014");
                else
                    _connectionManager.PokeMain(0x301D770, "21080054");
            }
        }

        private void fpsCapCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (IsConnected())
            {
                if (fpsCapCheckbox.Checked)
                    _connectionManager.PokeAbsoluteAddress(fpsCapAddress, "01000000");
                else
                    _connectionManager.PokeAbsoluteAddress(fpsCapAddress, "02000000");
            }
        }
    }
}
