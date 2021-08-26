using System;
using System.Collections.Generic;
using System.Text;

namespace ITWebNet.Food.Core.DataContracts.Common
{
    /// <summary>
    /// Модель выбора категории
    /// </summary>
    public class SelectableFoodCategoryModel
    {
        public long Id { get; set; }

        public string Name { get; set; }
        
        public bool IsSelected { get; set; }
    }
}
