using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace MauiCollectionViewTalkBackTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = new TestViewModel();
        }
    }

    public class TestViewModel
    {
        private ObservableCollection<TestItem> testList;

        public ObservableCollection<TestItem> TestListCollection
        {
            get { return testList; }
            set { this.testList = value; }
        }

        public TestViewModel()
        {
            testList = new ObservableCollection<TestItem>();

            CreateTestListItems();
        }

        public void CreateTestListItems()
        {
            testList.Add(new TestItem("Blackbird"));
            testList.Add(new TestItem("Jay"));
            testList.Add(new TestItem("Pigeon"));
            testList.Add(new TestItem("Sparrowhawk"));
            testList.Add(new TestItem("Thrush"));
        }
    }

    public class TestItem : ObservableObject
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                SetProperty(ref name, value);
            }
        }

        public TestItem(string name)
        {
            this.Name = name;
        }
    }
}
