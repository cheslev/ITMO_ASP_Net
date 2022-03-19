using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web;

namespace ASP_Net_MVC_Lab5_MvcCreditApp1.Models
{
    public class Credit
    {
        
        // ID кредита
        public virtual int CreditId { get; set; }
        // Название
        public virtual string Head { get; set; }
        // Период, на который выдается кредит
        public virtual int Period { get; set; }
        // Максимальная сумма кредита
        public virtual int Sum { get; set; }
        // Процентная ставка
        public virtual int Procent { get; set; }

        [DisplayName("Дата подачи заявки")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy}")]
        public virtual DateTime bidDate { get; set; }
    }
}