using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SynCoolFeedback
{
    //public class DataSelector : DataTemplateSelector
    //{
    //    public DataTemplate templateStudenti { get; set; }
    //    public DataTemplate templateTutor { get; set; }

    //    public DataSelector()
    //    {
    //        this.templateStudenti = new DataTemplate(typeof(Studenti));
    //        this.templateTutor = new DataTemplate(typeof(Tutor));
    //    }

    //    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    //    {
    //        in base al tipo di oggetto ritorno un template
    //        var obj = (EmployeeModel)item;

    //        switch (item)
    //        {
    //            case Tutor tutor:
    //                templateTutor = new DataTemplate(typeof(Tutor));
    //                return templateTutor;

    //            case Studenti studenti:
    //                templateStudenti = new DataTemplate(typeof(Studenti));
    //                return templateStudenti;

    //            default:
    //                return null;
    //        }

    //        if (item.GetType().ToString() == ("Studenti"))
    //        {
    //            return templateStudenti;
    //        }

    //        return templateTutor;

    //    }
    //}
}
