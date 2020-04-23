using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace settings_for_platform
{
    /// <summary>
    /// класс, который отвечает за настройку именно системы ubuntu
    /// </summary>
    class ubuntu_switcher :switcher
    {
        /// <summary>
        /// возвращаем уже конкретно настройки под ubuntu
        /// </summary>
        /// <returns></returns>
        public settings getSettings()
        {
            return new ubuntu_settings();
        }
    }
}
