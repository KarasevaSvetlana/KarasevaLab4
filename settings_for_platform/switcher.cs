using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace settings_for_platform
{
    /// <summary>
    /// интерфейс, который отвечает за настройку
    /// </summary>
    public interface switcher
    {

        /// <summary>
        /// функция, возвращающая настройку
        /// </summary>
        /// <returns></returns>
        settings getSettings();

    }
}
