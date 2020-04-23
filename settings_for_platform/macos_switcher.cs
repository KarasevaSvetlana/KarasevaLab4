using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace settings_for_platform
{
    /// <summary>
    /// класс, который отвечает за настройку именно системы macos
    /// </summary>
    class macos_switcher:switcher
    {

        
        /// <summary>
        /// возвращаем уже конкретно настройки под macos
        /// </summary>
        /// <returns></returns>
        public settings getSettings()
        {
            return new macos_settings();
        }
    }
}
