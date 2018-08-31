using ecommerce.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ecommerce.Infraestructure
{
 public    class InstanceLocator
    {
       public MainViewModel Main { get; set; }
      
        public InstanceLocator()
        { Main = new MainViewModel(); }

    }
}
