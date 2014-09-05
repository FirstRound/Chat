using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using BytesRoad.Net.Ftp;
using BytesRoad.Net.Sockets;
using System.Diagnostics;
using System.Reflection;

namespace Chat
{
    public partial class MainWindow : Form
    {
        private List<Message> _messages = new List<Message>();
        private List<User> _friends = new List<User>();
        private ActionController _chat = new ActionController();
        private int _admin_id = 0;
        public MainWindow(Admin admin)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            //MessageView.SelectionMode = SelectionMode.None;
            _admin_id = admin.Id;
            _chat.setAdminUser(admin);
            _friends = _chat.getFriends();
            _chat.loadMessageHistory();
            _setListBoxSource();
            //MessageView.
            Thread messageUpdator = new Thread(updateInputMessages);
            messageUpdator.IsBackground = true;
            messageUpdator.Start();
        }


        private void _updateMessageListBox()
        {
            /*
                MessageBox.DataSource = null;
                MessageBox.DataSource = _messages;
                MessageBox.DisplayMember = "Text";
             * */
            int visibleItems = MessageView.ClientSize.Height / MessageView.ItemHeight;
            if (_messages != null)
            {

                Friends.BeginUpdate();
                int selected = Friends.SelectedIndex;
                Friends.Items.Clear();
                foreach (User u in _friends)
                {
                    Friends.Items.Add(u.Name);
                }
                Friends.SelectedIndex = selected;
                Friends.EndUpdate();
                
                MessageView.BeginUpdate();
                int padding = 0;
                MessageView.Items.Clear();
                for (int i = padding; i < _messages.Count; i++)
                {
                    MessageView.Items.Add(_messages[i].Text);
                }
                MessageView.EndUpdate();
            }
            MessageView.TopIndex = Math.Max(MessageView.Items.Count - visibleItems + 1, 0);

        }

        private void _setListBoxSource()
        {   /*
            MessageView.DataSource = null;
            Friends.DataSource = _friends;
            Friends.DisplayMember = "Name";
            MessageView.DataSource = _messages;
            MessageView.DisplayMember = "Text";
            */

            foreach (User u in _friends)
            {
                Friends.Items.Add(u.Name);
            }

            foreach (Message msg in _messages)
            {
                MessageView.Items.Add(msg.Text);
            }
        }

        private void LinkField_TextChanged(object sender, EventArgs e)
        {

        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            //добавить в список отправленных
            // отправить на сервер
            _sendMessage();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            //сохранить диалоги в файл
        }


        private void Friends_SelectedIndexChanged(object sender, EventArgs e)
        {
            // изменить current_id и прогрузить другой List
           // User friend = new User();

            _chat.setCurrentFriend(_friends[Friends.SelectedIndex]);
            List<Message> list = _chat.getMessages();
            if (list != null)
            {
                _messages = list;
                _updateMessageListBox();
            }
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Threading.SynchronizationContext.Current.Post(delegate { Application.Exit(); }, null);
        }

        private void selectLink_Click(object sender, EventArgs e)
        {
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {

            _chat.updateNewMessages();
        }

        private void updateInputMessages()
        {
            while (true)
            {
                Thread.Sleep(2000);
                if (_chat.updateNewMessages())
                {
                    Action<int> action = (_message) => _updateMessageListBox();
                    List<Message> list = _chat.getMessages();
                    if (list != null)
                    {
                        _messages = list;
                        int a = 3;
                        if (InvokeRequired)
                        {
                            Invoke(action, a);
                        }
                        else
                        {
                            action(a);
                        }
                    }
                }
            }
        }

        private void MessageView_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                if (e.Index < 0 || (e.State & DrawItemState.Selected) == DrawItemState.Selected) 
                    return;
                e.DrawBackground();
                Brush messageColor = Brushes.Black;
                String date = _messages[e.Index].Date.ToLongTimeString();
                if (_messages[e.Index].SenderID != _admin_id)
                {
                    messageColor = Brushes.DarkBlue;
                }
                else
                {
                    messageColor = Brushes.DarkGreen;
                }
                String str = ((String)((ListBox)sender).Items[e.Index]);
                str = date + " > " + str;

                e.Graphics.DrawString(
                    str,
                    e.Font, messageColor, e.Bounds,
                    StringFormat.GenericDefault);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Friends_DrawItem(object sender, DrawItemEventArgs e)
        {
            try {
            e.DrawBackground();
            Brush friendColor = Brushes.Black;
            String str = ((String)((ListBox)sender).Items[e.Index]);
            if (_friends[e.Index].NewMessage && ((e.State & DrawItemState.Selected) != DrawItemState.Selected))
            {
                friendColor = Brushes.DarkGreen;
                str += " +";
            }
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                _friends[e.Index].NewMessage = false;
            }
            e.Graphics.DrawString(
                str,
                e.Font, friendColor, e.Bounds,
                StringFormat.GenericDefault);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
     }

        private void MessageField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                _sendMessage();
                e.Handled = true;
            }
        }

        // BEGIN PRIVATE METHODS

        private void _sendMessage()
        {
            if (MessageField.Text.ToString() != "")
            {
                Message message = new Message();
                message.Text = MessageField.Text.ToString();
                message.SenderID = _admin_id;
                message.Date = DateTime.Now;
                _chat.sendMessage(message);
                _messages = _chat.getMessages();
                MessageField.Text = "";
                _updateMessageListBox();
            }
        }


    }
}
