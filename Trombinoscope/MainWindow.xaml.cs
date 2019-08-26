using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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

namespace Trombinoscope
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<GetAllContactsResult> Contacts { get; set; }

        public MainWindow()
        {            
            var MyCont = new TrombiDataClasses1DataContext();

            long StartBytes = System.GC.GetTotalMemory(true);
            Contacts = MyCont.GetAllContacts().ToList();
            long StopBytes = System.GC.GetTotalMemory(true);
            var delta = StopBytes - StartBytes;
            this.DataContext = this;
            InitializeComponent();
            
        }
    }
}
