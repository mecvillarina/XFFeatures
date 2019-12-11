using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XFFeatures.ItemModels
{
    public class PersonItemModel : BindableBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ShortName => $"{FirstName[0]}{LastName[1]}".ToUpper();
        public string FullName => $"{FirstName} {LastName}";

        public Color PersonColor { get; set; }
    }
}
