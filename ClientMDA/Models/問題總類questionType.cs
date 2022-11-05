using System;
using System.Collections.Generic;

#nullable disable

namespace ClientMDA.Models
{
    public partial class 問題總類questionType
    {
        public 問題總類questionType()
        {
            問題總表questions = new HashSet<問題總表question>();
        }

        public int 問題總類編號questionTypeId { get; set; }
        public string 問題分類questionClassification { get; set; }

        public virtual ICollection<問題總表question> 問題總表questions { get; set; }
    }
}
