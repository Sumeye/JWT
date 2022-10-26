using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Dtos
{
    public class ErrorDto
    {
        public List<String> Erros { get; private set; }

        public bool IShow { get; private set; }

        public ErrorDto()
        {
            Erros = new List<String>();
        }

        public ErrorDto(string error, bool isShow)
        {
            Erros.Add(error);
            isShow = true;
        }
        public ErrorDto(List<string> erros, bool ıShow)
        {
            Erros = erros;
            IShow = ıShow;
        }
    }
}
