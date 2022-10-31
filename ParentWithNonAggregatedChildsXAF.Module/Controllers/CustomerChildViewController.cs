using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp;
using ParentWithNonAggregatedChildsXAF.Module.BusinessObjects;

namespace ParentWithNonAggregatedChildsXAF.Module.Controllers
{
    public class CustomerChildViewController : ObjectViewController<ListView, ICustomerChild>
    {


        private NewObjectViewController newObjectViewController;


        protected override void OnActivated()
        {
            base.OnActivated();
            NestedFrame nestedFrame = Frame as NestedFrame;
            if (nestedFrame != null)
            {
                newObjectViewController = Frame.GetController<NewObjectViewController>();
                newObjectViewController.ObjectCreated += newObjectViewController_ObjectCreated;

            }
        }

        void newObjectViewController_ObjectCreated(object sender, ObjectCreatedEventArgs e)
        {
            var objectSpace = e.ObjectSpace;
            var parent = objectSpace.GetObject(((NestedFrame)Frame).ViewItem.CurrentObject as Customer);
            var item = e.CreatedObject as ICustomerChild;
            item.Customer = parent;
        }
    }

}
