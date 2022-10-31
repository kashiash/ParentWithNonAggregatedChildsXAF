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
	public class Car : BaseObject, ICustomerChild
	{
		public Car(Session session) : base(session)
		{ }


		string carName;
		Customer customer;
		Customer klient;
		
		[Size(SizeAttribute.DefaultStringMappingFieldSize)]
		public string CarName
		{
			get => carName;
			set => SetPropertyValue(nameof(CarName), ref carName, value);
		}

        [Association("Customer-Vehicles")]
        public Customer Klient
		{
			get => klient;
			set => SetPropertyValue(nameof(Klient), ref klient, value);
		}


		[NonPersistent]
		public Customer Customer
		{
			get => klient;
			set => SetPropertyValue(nameof(Klient), ref klient, value);
		}

	}
}
