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
	public class Invoice : BaseObject, ICustomerChild
    {
		public Invoice(Session session) : base(session)
		{ }


		Customer customer;
		DateTime invoiceDate;
		string invoiceNumber;

		[Size(SizeAttribute.DefaultStringMappingFieldSize)]
		public string InvoiceNumber
		{
			get => invoiceNumber;
			set => SetPropertyValue(nameof(InvoiceNumber), ref invoiceNumber, value);
		}


		public DateTime InvoiceDate
		{
			get => invoiceDate;
			set => SetPropertyValue(nameof(InvoiceDate), ref invoiceDate, value);
		}

        [Association("Customer-Invoices")]
        public Customer Customer
		{
			get => customer;
			set => SetPropertyValue(nameof(Customer), ref customer, value);
		}
	}
}
