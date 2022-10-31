using DevExpress.Persistent.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace ParentWithNonAggregatedChildsXAF.Module.BusinessObjects
{


    [DefaultClassOptions]
    public class Customer : Party
    {
        public Customer(Session session) : base(session)
        { }



        string vatNumber;
        string name;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Name
        {
            get => name;
            set => SetPropertyValue(nameof(Name), ref name, value);
        }

        
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string VatNumber
        {
            get => vatNumber;
            set => SetPropertyValue(nameof(VatNumber), ref vatNumber, value);
        }



        [Association("Customer-Invoices")]
        public XPCollection<Invoice> Invoices
        {
            get
            {
                return GetCollection<Invoice>(nameof(Invoices));
            }
        }

        [Association("Customer-Payments")]
        public XPCollection<Payment> Payments
        {
            get
            {
                return GetCollection<Payment>(nameof(Payments));
            }
        }

        [Association("Customer-Vehicles")]
        public XPCollection<Car> Vehicles
        {
            get
            {
                return GetCollection<Car>(nameof(Vehicles));
            }
        }
        public override string DisplayName => Name;
    }
}
