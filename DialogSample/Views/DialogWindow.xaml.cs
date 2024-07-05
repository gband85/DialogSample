using System.Windows;
using DialogSample.Interfaces;

namespace DialogSample.Views;

public partial class DialogWindow : Window, IDialog
{
    public DialogWindow()
    {
       InitializeComponent();
    }
}