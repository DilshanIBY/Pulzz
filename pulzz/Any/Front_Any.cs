using DatabaseReaderApp;
using Guna.UI2.WinForms;
using OpenAI.GPT3.ObjectModels.RequestModels;
using pulzz.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using YourNamespace;

namespace WindowsFormsApp9
{
    public partial class Front_Any : Form
    {
        private readonly OpenAIIntegration _openAI;

        public Front_Any()
        {
            InitializeComponent();
            InitializeChat();
            _openAI = new OpenAIIntegration("sk-proj-UEJuGqCH5Rsd8a6fVTMwT3BlbkFJda6QSwL9UG77RktdZbsT"); // The OpenAI API key
        }

        private void InitializeChat()
        {
            // Initialize chat messages
            AddMessage("Bot", "Hello! How can I assist you today?", true);
        }

        private async Task HandleUserInputAsync(string message)
        {
            try
            {
                string response = await _openAI.GetResponseAsync(new List<ChatMessage>
                {
                ChatMessage.FromUser("Assume that, Your name is 'Any'. You're a virtual assistant that runs on the Hospital Management System Application to help its users. You're a very friendly and funny assistant."),
                ChatMessage.FromUser("Answer to the last message based on the below data. Make sure to gratefully call the user by his/her name on appropriate occasions."),
                ChatMessage.FromUser("If the user is asking a question from you, act by thinking that you're now in the middle of the converstion with him. Not in the beginning."),
                ChatMessage.FromUser("Don't ask 'How can I assist you' every time. be creative and random."),
                ChatMessage.FromUser("If user is asking something that need to do a ADD, UPDATE or DELETE operation to the database, make sure to format your response as this-> ['THE SQL QUERY TO PERFORM THE ACTION','YOUR MESSAGE TO THE USER ASSUMING THAT THE OPERATION IS COMPLETE']"),
                ChatMessage.FromUser("Never output sql queries to SELECT type operations. Do the search by your own from below database"),
                ChatMessage.FromUser($"The whole database: {new DatabaseReader().readDatabase()}"),
                ChatMessage.FromUser($"This user's EmployeeId:1 FirstName:John"),
                ChatMessage.FromUser($"Last message from you to this user LastMsg:{new DatabaseReader().lastMsg(1)} Make sure to act based on this history."),
                ChatMessage.FromUser(message)
                });
                if (response.Contains("[") && response.Contains("]"))
                {
                    // Extracting the content within square brackets
                    int startIndex = response.IndexOf("[") + 1;
                    int length = response.LastIndexOf("]") - startIndex;
                    string[] array = response.Substring(startIndex, length).Split(',');

                    // Removing single quotes and trimming whitespace
                    string query = array[0].Replace("'", "").Trim();
                    string responseString = array[1].Replace("'", "").Trim();

                    // Do the database operation
                    new DatabaseReader().runQuery(query);

                    // Submit the response
                    AddMessage("Bot", responseString, true);
                    new DatabaseReader().UpdateLastMsg(1,response);
                }
                else
                {
                    AddMessage("Bot", response, true);
                    new DatabaseReader().UpdateLastMsg(1,response);
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void AddMessage(string sender, string message, bool isBot)
        {
            Guna2Panel messagePanel = new Guna2Panel();
            messagePanel.Dock = DockStyle.Bottom;
            messagePanel.Padding = new Padding(10);
            messagePanel.AutoSize = true;
            messagePanel.MaximumSize = new Size(guna2PanelChat.Width, 0);

            Guna2PictureBox pictureBox = new Guna2PictureBox();
            pictureBox.Image = isBot ? Resources.bot : Resources.user;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Size = new Size(40, 40);
            pictureBox.Location = new Point(isBot ? 10 : guna2PanelChat.Width - pictureBox.Width - 10, 10);

            Guna2Panel messageArea = new Guna2Panel();
            messageArea.AutoSize = true;
            messageArea.BorderRadius = 10;
            messageArea.MaximumSize = new Size(guna2PanelChat.Width - 100, 0);
            messageArea.Padding = new Padding(10);

            Guna2HtmlLabel messageLabel = new Guna2HtmlLabel();
            messageLabel.MaximumSize = new Size(guna2PanelChat.Width - 100, 0);
            messageLabel.ForeColor = Color.White;
            messageLabel.TextAlignment = ContentAlignment.MiddleCenter;

            messageArea.SizeChanged += (senderObj, e) =>
            {
                messageArea.Location = isBot ? new Point(pictureBox.Right + 10, 0) : new Point(pictureBox.Left - messageArea.Width - 10, 0);
            };

            messagePanel.Controls.Add(messageArea);
            messagePanel.Controls.Add(pictureBox);
            guna2PanelChat.Controls.Add(messagePanel);
            guna2PanelChat.ScrollControlIntoView(messagePanel);


            if (IsFormOpen("Back_Menu"))
            {
                messageArea.FillColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            }
            else
            {
                messageArea.FillColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            }

            bool IsFormOpen(string formName)
            {
                foreach (Form form in Application.OpenForms)
                {
                    if (form.Name == formName && form.Visible)
                    {
                        return true;
                    }
                }
                return false;
            }









            // Implement typing effect for bot messages
            if (isBot)
            {
                Timer timer = new Timer();
                timer.Interval = 10; // typing speed
                int index = 0;
                timer.Tick += (senderObj, e) =>
                {
                    if (index < message.Length)
                    {
                        messageLabel.Text += message[index];
                        index++;

                    }
                    else
                    {
                        timer.Stop();
                        // Center the label both horizontally and vertically within the messageArea
                        int horizontalMargin = (messageArea.Width - messageLabel.Width) / 2;
                        int verticalMargin = (messageArea.Height - messageLabel.Height) / 2;
                        messageLabel.Location = new Point(horizontalMargin, verticalMargin);
                    }
                };
                timer.Start();
            }
            else
            {
                // For user messages, display immediately
                messageLabel.Text = message;
                messageArea.SizeChanged += (senderObj, e) =>
                {
                    messageArea.Location = isBot ? new Point(pictureBox.Right + 10, 0) : new Point(pictureBox.Left - messageArea.Width - 10, 0);
                    // Center the label both horizontally and vertically within the messageArea
                    int horizontalMargin = (messageArea.Width - messageLabel.Width) / 2;
                    int verticalMargin = (messageArea.Height - messageLabel.Height) / 2;
                    messageLabel.Location = new Point(horizontalMargin, verticalMargin);
                };
            }

            messageArea.Controls.Add(messageLabel);
        }


        private async void guna2TextBoxMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string message = guna2TextBoxMessage.Text.Trim();
                if (!string.IsNullOrEmpty(message))
                {
                    AddMessage("User", message, false);
                    guna2TextBoxMessage.Clear();
                    await HandleUserInputAsync(message);
                }
            }
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2PanelChat.Controls.Clear();
            await System.Threading.Tasks.Task.Delay(500);
            InitializeChat();
        }

        public void anyFrontendUI()
        {
            guna2Panel1.FillColor = Color.FromArgb(0, 0, 64);
            guna2TextBoxMessage.BorderColor = Color.FromArgb(1, 68, 234);
            guna2CircleButton1.FillColor = Color.FromArgb(1, 68, 234);

        }

        public void anyBackendUI()
        {
            guna2Panel1.FillColor = Color.FromArgb(64, 0, 0);
            guna2TextBoxMessage.BorderColor = Color.Red;
            guna2CircleButton1.FillColor = Color.Red;

        }

        private async void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            string message = guna2TextBoxMessage.Text.Trim();
            if (!string.IsNullOrEmpty(message))
            {
                AddMessage("User", message, false);
                guna2TextBoxMessage.Clear();
                await HandleUserInputAsync(message);
            }
        }
    }
}
