using System.Collections.ObjectModel;

namespace HorizontalCollectionViewRepro;

public partial class MainPage
{
    public ObservableCollection<string> Items { get; } = new()
    {
        "Test 1",
        "Test 2",
        "Test 3",
        "Test 4",
        "Test long 5",
        "Test 6",
        "Test long 7",
        "Test 8",
        "Test long 9",
        "Test 10",
        "Test long 11",
        "Test 12",
    };
    
    public MainPage()
    {
        InitializeComponent();
        MyCollectionView.ItemsSource = Items;
    }
}