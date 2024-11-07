using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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

namespace Master_Pol
{
    /// <summary>
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Page
    {

        private Partner currentPartner = new Partner();

        public bool check = false;

        public AddEditPage(Partner SelectedPartner)
        {
            InitializeComponent();
            var PartnerTypes = Anvarov_master_polEntities.GetContext().Partner_type.Select(p => p.Type_name).ToList();

            foreach (var PartnerType in PartnerTypes)
            {
                PartnerTypeComboBox.Items.Add(PartnerType);
            }

            if (SelectedPartner != null)
            {
                check = true;
                currentPartner = SelectedPartner;
                PartnerTypeComboBox.SelectedIndex = currentPartner.Partner_Type - 1;
            }
            else
            {
                currentPartner.Partner_Rating = 0;
                PartnerTypeComboBox.SelectedIndex = 0;
            }

            DataContext = currentPartner;
            
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(currentPartner.Partner_Name))
                errors.AppendLine("Укажите название партнера");
            if (string.IsNullOrWhiteSpace(currentPartner.Partner_Index))
                errors.AppendLine("Укажите индекс");
            if (string.IsNullOrWhiteSpace(currentPartner.Partner_Region))
                errors.AppendLine("Укажите регион");
            if (string.IsNullOrWhiteSpace(currentPartner.Partner_City))
                errors.AppendLine("Укажите город");
            if (string.IsNullOrWhiteSpace(currentPartner.Partner_Street))
                errors.AppendLine("Укажите улицу");
            if (string.IsNullOrWhiteSpace(currentPartner.Partner_House))
                errors.AppendLine("Укажите дом");
            if (string.IsNullOrWhiteSpace(currentPartner.Partner_INN))
                errors.AppendLine("Укажите ИНН");
            if (string.IsNullOrWhiteSpace(currentPartner.Director_Surname))
                errors.AppendLine("Укажите фамилию директора");
            if (string.IsNullOrWhiteSpace(currentPartner.Director_Firstname))
                errors.AppendLine("Укажите имя директора");
            if (string.IsNullOrWhiteSpace(currentPartner.Director_Patronymic))
                errors.AppendLine("Укажите отчество директора");
            if (string.IsNullOrWhiteSpace(currentPartner.Partner_Phone))
                errors.AppendLine("Укажите телефон");
            if (string.IsNullOrWhiteSpace(currentPartner.Partner_Email))
                errors.AppendLine("Укажите Email");
            if (currentPartner.Partner_Rating < 0 || currentPartner.Partner_Rating.GetType() != typeof(int))
                errors.AppendLine("Неверный рейтинг партнера");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            currentPartner.Partner_Type = PartnerTypeComboBox.SelectedIndex - 1;

            var allPartner = Anvarov_master_polEntities.GetContext().Partner.ToList();
            allPartner = allPartner.Where(p => p.Partner_Name == currentPartner.Partner_Name).ToList();
            if (allPartner.Count == 0 || check == true)
            {
                if (currentPartner.ID_Partner == 0)
                {
                    Anvarov_master_polEntities.GetContext().Partner.Add(currentPartner);
                }
                    
                try
                {
                    Anvarov_master_polEntities.GetContext().SaveChanges();
                    MessageBox.Show("Информация сохранена");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
                MessageBox.Show("Такой партнер уже сущесвтует!");

        }

    }
}
