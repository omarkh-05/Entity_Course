using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Course.Models
{
    public class Invoice
    {
        //     FluentAPI في هاي الحالة مش حينقل اي فيلد في جمع زي التوتال وال وصف فعشان يضيفهم على المايجريشن ويضيفهم على الداتا بيز لازم نحطهم في ال 

        public int InvoiceID { get; set; }

        public string CustomerName { get; set; }
        public string CustomerTitle { get; set; }

        public string CustomerDescription {  get; set; }

        public decimal price { get; set; }
        public decimal qty { get; set; }

       // public decimal total => price * qty;
        // بعد ما نضيف الشكل هاض والكود تبع التعديل الي في الكونتيكست ونسوي مايقريشن حيعطي ايرور حله نخلي التوتال عنده سيت وقيت
        public decimal total { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
