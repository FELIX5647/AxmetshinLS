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

namespace AxmetshinLS
{
    /// <summary>
    /// Логика взаимодействия для ClientPage.xaml
    /// </summary>
    public partial class ClientPage : Page
    {
        int CountRecords;
        int CountPage;
        int CurrentPage = 0;
        int all;

        List<Client> CurrentPageList = new List<Client>();
        List<Client> TableList;
        public ClientPage()
        {
            InitializeComponent();
            var currentClient = AxmetshinLanguageEntities.GetContext().Client.ToList();
            ListClient.ItemsSource = currentClient;
            PagesComboBox.SelectedIndex = 0;
            TableList = currentClient;
            all = TableList.Count;
            
            UpdateServices();
        }
        
        private void ChangePage(int direction, int? selectedPage)
        {

            if (PagesComboBox.SelectedIndex == 0)
            {
                CurrentPageList.Clear();
                CountRecords = TableList.Count;
                if (CountRecords % 10 > 0)
                {
                    CountPage = CountRecords / 10 + 1;
                }
                else
                {
                    CountPage = CountRecords / 10;
                }
                Boolean Ifupdate = true;
                int min;
                if (selectedPage.HasValue)
                {
                    if (selectedPage >= 0 && selectedPage <= CountPage)
                    {
                        CurrentPage = (int)selectedPage;
                        min = CurrentPage * 10 + 10 < CountRecords ? CurrentPage * 10 + 10 : CountRecords;
                        for (int i = CurrentPage * 10; i < min; i++)
                        {
                            CurrentPageList.Add(TableList[i]);
                        }
                    }
                }
                else
                {
                    switch (direction)
                    {
                        case 1:
                            if (CurrentPage > 0)
                            {
                                CurrentPage--;
                                min = CurrentPage * 10 + 10 < CountRecords ? CurrentPage * 10 + 10 : CountRecords;
                                for (int i = CurrentPage * 10; i < min; i++)
                                {
                                    CurrentPageList.Add(TableList[i]);
                                }
                            }
                            else
                            {
                                Ifupdate = false;
                            }
                            break;
                        case 2:
                            if (CurrentPage < CountPage - 1)
                            {
                                CurrentPage++;
                                min = CurrentPage * 10 + 10 < CountRecords ? CurrentPage * 10 + 10 : CountRecords;
                                for (int i = CurrentPage * 10; i < min; i++)
                                {
                                    CurrentPageList.Add(TableList[i]);
                                }
                            }
                            else
                            {
                                Ifupdate = false;
                            }
                            break;
                    }
                }
                if (Ifupdate)
                {
                    PageListBox.Items.Clear();
                    for (int i = 1; i <= CountPage; i++)
                    {
                        PageListBox.Items.Add(i);
                    }
                    PageListBox.SelectedIndex = CurrentPage;
                   
                    ListClient.ItemsSource = CurrentPageList;
                    ListClient.Items.Refresh();
                }
            }
            if (PagesComboBox.SelectedIndex == 1)
            {
                CurrentPageList.Clear();
                CountRecords = TableList.Count;
                if (CountRecords % 50 > 0)
                {
                    CountPage = CountRecords / 50 + 1;
                }
                else
                {
                    CountPage = CountRecords / 50;
                }
                Boolean Ifupdate = true;
                int min;
                if (selectedPage.HasValue)
                {
                    if (selectedPage >= 0 && selectedPage <= CountPage)
                    {
                        CurrentPage = (int)selectedPage;
                        min = CurrentPage * 50 + 50 < CountRecords ? CurrentPage * 50 + 50 : CountRecords;
                        for (int i = CurrentPage * 50; i < min; i++)
                        {
                            CurrentPageList.Add(TableList[i]);
                        }
                    }
                }
                else
                {
                    switch (direction)
                    {
                        case 1:
                            if (CurrentPage > 0)
                            {
                                CurrentPage--;
                                min = CurrentPage * 50 + 50 < CountRecords ? CurrentPage * 50 + 50 : CountRecords;
                                for (int i = CurrentPage * 50; i < min; i++)
                                {
                                    CurrentPageList.Add(TableList[i]);
                                }
                            }
                            else
                            {
                                Ifupdate = false;
                            }
                            break;
                        case 2:
                            if (CurrentPage < CountPage - 1)
                            {
                                CurrentPage++;
                                min = CurrentPage * 50 + 50 < CountRecords ? CurrentPage * 50 + 50 : CountRecords;
                                for (int i = CurrentPage * 50; i < min; i++)
                                {
                                    CurrentPageList.Add(TableList[i]);
                                }
                            }
                            else
                            {
                                Ifupdate = false;
                            }
                            break;
                    }
                }
                if (Ifupdate)
                {
                    PageListBox.Items.Clear();
                    for (int i = 1; i <= CountPage; i++)
                    {
                        PageListBox.Items.Add(i);
                    }
                    PageListBox.SelectedIndex = CurrentPage;

                    ListClient.ItemsSource = CurrentPageList;
                    ListClient.Items.Refresh();
                }
            }


            if (PagesComboBox.SelectedIndex == 3)
            {
                CurrentPageList.Clear();
                CountRecords = TableList.Count;
                if (CountRecords % 200 > 0)
                {
                    CountPage = CountRecords / 200 + 1;
                }
                else
                {
                    CountPage = CountRecords / 200;
                }
                Boolean Ifupdate = true;
                int min;
                if (selectedPage.HasValue)
                {
                    if (selectedPage >= 0 && selectedPage <= CountPage)
                    {
                        CurrentPage = (int)selectedPage;
                        min = CurrentPage * 200 + 200 < CountRecords ? CurrentPage * 200 + 200 : CountRecords;
                        for (int i = CurrentPage * 200; i < min; i++)
                        {
                            CurrentPageList.Add(TableList[i]);
                        }
                    }
                }
                else
                {
                    switch (direction)
                    {
                        case 1:
                            if (CurrentPage > 0)
                            {
                                CurrentPage--;
                                min = CurrentPage * 200 + 200 < CountRecords ? CurrentPage * 200 + 200 : CountRecords;
                                for (int i = CurrentPage * 200; i < min; i++)
                                {
                                    CurrentPageList.Add(TableList[i]);
                                }
                            }
                            else
                            {
                                Ifupdate = false;
                            }
                            break;
                        case 2:
                            if (CurrentPage < CountPage - 1)
                            {
                                CurrentPage++;
                                min = CurrentPage * 200 + 200 < CountRecords ? CurrentPage * 200 + 200 : CountRecords;
                                for (int i = CurrentPage * 200; i < min; i++)
                                {
                                    CurrentPageList.Add(TableList[i]);
                                }
                            }
                            else
                            {
                                Ifupdate = false;
                            }
                            break;
                    }
                }
                if (Ifupdate)
                {
                    PageListBox.Items.Clear();
                    for (int i = 1; i <= CountPage; i++)
                    {
                        PageListBox.Items.Add(i);
                    }
                    PageListBox.SelectedIndex = CurrentPage;

                    ListClient.ItemsSource = CurrentPageList;
                    ListClient.Items.Refresh();
                }
            }
            if (PagesComboBox.SelectedIndex == 2)
            {
                CurrentPageList.Clear();
                CountRecords = TableList.Count;
                if (CountRecords % 200 > 0)
                {
                    CountPage = CountRecords / 200 + 1;
                }
                else
                {
                    CountPage = CountRecords / 200;
                }
                Boolean Ifupdate = true;
                int min;
                if (selectedPage.HasValue)
                {
                    if (selectedPage >= 0 && selectedPage <= CountPage)
                    {
                        CurrentPage = (int)selectedPage;
                        min = CurrentPage * 200 + 200 < CountRecords ? CurrentPage * 200 + 200 : CountRecords;
                        for (int i = CurrentPage * 200; i < min; i++)
                        {
                            CurrentPageList.Add(TableList[i]);
                        }
                    }
                }
                else
                {
                    switch (direction)
                    {
                        case 1:
                            if (CurrentPage > 0)
                            {
                                CurrentPage--;
                                min = CurrentPage * 200 + 200 < CountRecords ? CurrentPage * 200 + 200 : CountRecords;
                                for (int i = CurrentPage * 200; i < min; i++)
                                {
                                    CurrentPageList.Add(TableList[i]);
                                }
                            }
                            else
                            {
                                Ifupdate = false;
                            }
                            break;
                        case 2:
                            if (CurrentPage < CountPage - 1)
                            {
                                CurrentPage++;
                                min = CurrentPage * 200 + 200 < CountRecords ? CurrentPage * 200 + 200 : CountRecords;
                                for (int i = CurrentPage * 200; i < min; i++)
                                {
                                    CurrentPageList.Add(TableList[i]);
                                }
                            }
                            else
                            {
                                Ifupdate = false;
                            }
                            break;
                    }
                }
                if (Ifupdate)
                {
                    PageListBox.Items.Clear();
                    for (int i = 1; i <= CountPage; i++)
                    {
                        PageListBox.Items.Add(i);
                    }
                    PageListBox.SelectedIndex = CurrentPage;

                    ListClient.ItemsSource = CurrentPageList;
                    ListClient.Items.Refresh();
                }
            }
        }

        private void UpdateServices()
        {
            var currentServices = AxmetshinLanguageEntities.GetContext().Client.ToList();

            if (GenderCB.SelectedIndex == 0)
            {
                

            }
            if (GenderCB.SelectedIndex == 1)
            {
                currentServices = currentServices.Where(p => p.GenderCode == "1").ToList();

            }
            if (GenderCB.SelectedIndex == 2)
            {
                currentServices = currentServices.Where(p => p.GenderCode == "2").ToList();

            }

            if (SortCB.SelectedIndex == 0)
            {


            }
            if (SortCB.SelectedIndex == 1)
            {
                currentServices = currentServices.OrderBy(p => p.FirstName).ToList();

            }
            if (SortCB.SelectedIndex == 2)
            {
                currentServices = currentServices.OrderByDescending(p => p.ClientService.DefaultIfEmpty().Max(s => s?.StartTime ?? DateTime.MinValue)).ToList();

            }
            if (SortCB.SelectedIndex == 3)
            {
                currentServices = currentServices.OrderByDescending(p => p.VisitCount).ToList();

            }


            currentServices = currentServices.Where(x => x.FirstName.ToLower().Contains(TBSearch.Text.ToLower()) 
            || x.LastName.ToLower().Contains(TBSearch.Text.ToLower()) 
            || x.Patronymic.ToLower().Contains(TBSearch.Text.ToLower())
            || x.Email.ToLower().Contains(TBSearch.Text.ToLower())
            || x.Phone.Replace("-","").Replace("(","").Replace(")","").Replace(" ", "").Contains(TBSearch.Text.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ",""))
            ).ToList();
            ListClient.ItemsSource = currentServices.ToList(); 
            ListClient.ItemsSource = currentServices;
            TableList = currentServices;
            CountRecords = TableList.Count;
            OneChisl.Text = CountRecords.ToString() + " из " + all.ToString() + "           ";
            ChangePage(0, 0);
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            var currentClient = (sender as Button).DataContext as Client;
            if(currentClient.ClientService.Count > 0)
            {
                MessageBox.Show("Невозможно выполнить удаление");
            }
            else
            {
                if(MessageBox.Show("Вы точно хотите выполнить удаление?", "Внимание!", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    try
                    {
                        AxmetshinLanguageEntities.GetContext().Client.Remove(currentClient);
                        AxmetshinLanguageEntities.GetContext().SaveChanges();
                        ListClient.ItemsSource = AxmetshinLanguageEntities.GetContext().Client.ToList();
                        all--;
                        UpdateServices();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
            }
        }

        private void LeftDirButton_Click(object sender, RoutedEventArgs e)
        {
            ChangePage(1, null);
        }

        private void RightDirButton_Click(object sender, RoutedEventArgs e)
        {
            ChangePage(2, null);
        }

        private void PageListBox_MouseUp(object sender, MouseButtonEventArgs e)
        {
            ChangePage(0, Convert.ToInt32(PageListBox.SelectedItem.ToString()) - 1);
        }



        private void PagesComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateServices();
        }

        private void TBSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateServices();
        }

        private void GenderCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateServices();
        }

        private void SortCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateServices();
        }
    }
}
