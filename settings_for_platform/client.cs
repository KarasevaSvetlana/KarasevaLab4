using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace settings_for_platform
{
    /// <summary>
    /// клиент
    /// </summary>
    class client
    {
        /// <summary>
        /// настройка windows
        /// </summary>
        public void windowsSet()
        {
            cl(new windows_switcher());
        }
        /// <summary>
        /// настройка macos
        /// </summary>
        public void macOSSet()
        {
            cl(new macos_switcher());
        }
        /// <summary>
        /// настройка ubuntu
        /// </summary>
        public void ubuntuSet()
        {
            cl(new ubuntu_switcher());
        }


        /// <summary>
        /// выводим настройки в зависимости от типа системы
        /// </summary>
        /// <param name="sw"></param>
        public void cl(switcher sw)
        {
            sw.getSettings().Type();
            sw.getSettings().GetSet1();
            sw.getSettings().GetSet2();
            sw.getSettings().GetSet3();
            sw.getSettings().GetSet4();
            sw.getSettings().GetSet5();
            sw.getSettings().GetSet6();
            sw.getSettings().GetSet7();
            sw.getSettings().GetSet8();
            sw.getSettings().GetSet9();
            sw.getSettings().GetSet10();

        }

    }
}
