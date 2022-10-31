using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParentWithNonAggregatedChildsXAF.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class Payment : BaseObject, ICustomerChild
    {
        public Payment(Session session) : base(session)
        { }


        decimal paymentAmount;
        DateTime paymentDate;
        Customer customer;


        [Association("Customer-Payments")]
        public Customer Customer
        {
            get => customer;
            set => SetPropertyValue(nameof(Customer), ref customer, value);
        }


        public DateTime PaymentDate
        {
            get => paymentDate;
            set => SetPropertyValue(nameof(PaymentDate), ref paymentDate, value);
        }

        
        public decimal PaymentAmount
        {
            get => paymentAmount;
            set => SetPropertyValue(nameof(PaymentAmount), ref paymentAmount, value);
        }

    }
}
