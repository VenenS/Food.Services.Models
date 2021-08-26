using Food.Services.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ITWebNet.Food.Core.DataContracts.Manager
{
    public class CafeMenuPatternModel
    {
        public long Id { get; set; }
        
        [Display(Name = "Шаблон")]
        public string Name { get; set; }
        
        public long CafeId { get; set; }
        
        public DateTime? PatternToDate { get; set; }
        
        public bool IsBanket { get; set; }
        
        public List<CafeMenuPatternDishModel> Dishes { get; set; }
    }
}