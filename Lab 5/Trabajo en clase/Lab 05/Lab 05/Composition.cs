using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05
{
    public class StudentC
    {
        IFormatIdName formatter;
        IDataAccess da;
        public StudentC(IFormatIdName format, IDataAccess da)
        {
            this.formatter = format;
            this.da = da;
        }

        public string FormatIdAndName(string name, int id)
        {
            return formatter.FormatIdAndName(name, id);
        }

        public void Add(string value)
        {
            da.Save(value);
        }
    }
}
