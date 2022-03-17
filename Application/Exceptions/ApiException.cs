using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exceptions
{
    public class ApiException : Exception
    {
        public ApiException() : base() { } //Constructor vacío

        public ApiException(string message) : base(message) { } //Solo pasa el mensaje

        public ApiException(string message, params object[] args) : base(String.Format(CultureInfo.CurrentCulture, message,args)) { }
    }
}
