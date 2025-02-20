namespace Notes.Views;
using Notes.ViewModels;
    
public partial class AllNotesPage : ContentPage
{
    public AllNotesPage()
    {
        this.BindingContext = new NotesViewModel();
        InitializeComponent();
    }

private void ContentPage_NavigatedTo(object sender, NavigatedToEventArgs e)
{
    notesCollection.SelectedItem = null;
}
}
