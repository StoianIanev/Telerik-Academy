using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Chat.Model;
using Chat.Data;
using Chat.Controler;

namespace Chat.Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ChatControler chat;

        public MainWindow()
        {
            InitializeComponent();
            Button_Click();
            // set timer
            // set timer tick -> check for new message
           
        }

        private void Button_Click()
        {
            SendPost();
            ListBoxMessage_SelectionChanged();
            // save to MongoDB database
        }

        private void ListBoxMessage_SelectionChanged()
        {
            ListBoxItem listBoxItem = new ListBoxItem();
            listBoxItem.Content = "Content";
            ListBoxMessage.Items.Add(listBoxItem);
        }

        private void TextBoxNewMessage_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void SendPost()
        {
            var text = this.TextBoxNewMessage.Text;
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Error!");
            }
            else
            {
                chat.InsertMessage(text);
               
            }
            
        }

        private void ListBoxMessage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
