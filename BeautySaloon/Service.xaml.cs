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

namespace BeautySaloon
{
    /// <summary>
    /// Логика взаимодействия для Service.xaml
    /// </summary>
    public partial class Service : Page
    {
        public Service()
        {
            InitializeComponent();


            Salon.ItemsSource = new SalonPlace[]
         {
            new SalonPlace { Name = "м.Павелецкая" },
            new SalonPlace { Name = "м.Стахановская" },
            new SalonPlace { Name = "м.Проспект Мира" },
            new SalonPlace { Name = "м.Охотный Ряд" },
            new SalonPlace { Name = "м.Рассказовка" },
            new SalonPlace { Name = "Подольск"}
         };

            Services.ItemsSource = new ServiceName[]
       {
            new ServiceName { Name = "Татуаж бровей" },
            new ServiceName { Name = "Наращивание ресниц" },
            new ServiceName { Name = "Окраска волос" },
            new ServiceName { Name = "Маникюр" },
            new ServiceName { Name = "Педекюр" }
       };

            Master.ItemsSource = new NameMaster[]
      {
            new NameMaster { Name = "Светочка" },
            new NameMaster { Name = "Маринка" },
            new NameMaster { Name = "Любашшка" },
            new NameMaster { Name = "Анджела" },
            new NameMaster { Name = "Родиончик" },
            new NameMaster { Name = "Эдик"}
      };

            Time.ItemsSource = new Tims[]
    {
            new Tims { Name = "10:00" },
            new Tims { Name = "11:00" },
            new Tims { Name = "12:00" },
            new Tims { Name = "13:00" },
            new Tims { Name = "14:00" },
            new Tims { Name = "15:00" },
            new Tims { Name = "16:00" },
            new Tims { Name = "17:00" },
            new Tims { Name = "18:00" },
            new Tims { Name = "19:00" },
            new Tims { Name = "20:00" },
            new Tims { Name = "21:00" }
    };

        }

        private void BtnSignUp_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Salon.Text))
            {
                MessageBox.Show("Поле Салон должно быть заполнено", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else { MessageBox.Show("Запись прошла успено", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information); }
        }
    }
    


    public class SalonPlace
    {
        public string Name { get; set; } = "";
        public override string ToString() => $"{Name}";
    }

    public class ServiceName
    {
        public string Name { get; set; } = "";
        public override string ToString() => $"{Name}";
    }

    public class NameMaster
    {
        public string Name { get; set; } = "";
        public override string ToString() => $"{Name}";
    }

    public class Tims
    {
        public string Name { get; set; } = "";
        public override string ToString() => $"{Name}";
    }
    
}

