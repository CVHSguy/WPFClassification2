using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
using System.Windows.Threading;
using TextClassification.Business;
using TextClassification.Controller;
using TextClassification.Domain;
using TextClassification.FileIO;

namespace TextClassification
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindowModel : Window
    {
       
        KnowledgeBuilder nb;
        Knowledge k;
        BagOfWords bof;
        public ObservableCollection<ComboBoxItem> cbItems { get; set; }
        public ObservableCollection<ListBoxItem> Filename { get; set; }
        public ComboBoxItem SelectedcbItem { get; set; }
        string selectedComboItem = "";
        string selectedListItem = "";
        private TextFile _textFile;
        

        public MainWindowModel()
        {
            _textFile = new TextFile("txt");
           
            InitializeComponent();
            DataContext = this;

            Filename = new ObservableCollection<ListBoxItem>();
            cbItems = new ObservableCollection<ComboBoxItem>();
            cbItems.Add(new ComboBoxItem { Content = "ClassA" });
            cbItems.Add(new ComboBoxItem { Content = "ClassB" });



        }
        private void AItrainer(object sender, RoutedEventArgs e)
        {
            Stopwatch Timer = new Stopwatch();
            Timer.Start();
            nb = new KnowledgeBuilder();
            nb.Train();                
            k = nb.GetKnowledge();
            bof = k.GetBagOfWords();
            List<string> entries = bof.GetEntriesInDictionary();

            foreach(string entry in entries)
            {
                DictionaryBox.Text += entry+"\n";
            }
            Timer.Stop();
            TimeSpan ts = Timer.Elapsed;
            Timerbox.Text = ts.Milliseconds+"ms";
        }

        private void ListBoxSelection(object sender, SelectionChangedEventArgs e)
        {
            var item = ListBox.SelectedItem as ListBoxItem;
            if (item?.Content!= null)
            {             
                selectedListItem = item.Content as string;
                if (selectedComboItem == "ClassA")
                {
                    TextFileBox.Text = _textFile.GetAllTextFromFileA(selectedListItem);
                }else
                    TextFileBox.Text = _textFile.GetAllTextFromFileB(selectedListItem);
            }
            tokenValue.Content = Tokenization.Tokenize(TextFileBox.Text).Count();


        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            if (ComboSelect.SelectedItem != null)                 
            {
               
                var item = ComboSelect.SelectedItem as ComboBoxItem;
                if (item?.Content != null)
                {
                    ListBox.SelectedItem = null;
                    Filename.Clear();
                    selectedComboItem = item.Content as string;
                    var filenames =  _textFile.GetAllFileNames(selectedComboItem);
                    foreach (var filename in filenames)
                    {
                        Filename.Add(new ListBoxItem { Content = filename });
                    }

                }
                
            }
        }


    }
}