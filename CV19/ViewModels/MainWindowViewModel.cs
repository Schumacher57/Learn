using CV19.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV19.ViewModels
{
    class MainWindowViewModel : ViewModel
    {
        private string pTitle;
         
        /// <summary>
        /// Заголовок окна
        /// </summary>
        public string Title { get => pTitle; set => Set(ref pTitle, value); }


        /// <summary>
        /// Описание статуса
        /// </summary>
        private string pStatus="Мой статус";

        /// <summary>
        /// Статус программы
        /// </summary>
        public string Status { get => pStatus; set => Set(ref pStatus, value); }
    }
}
