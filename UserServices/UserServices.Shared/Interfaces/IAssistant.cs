using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace UserServices.Shared.Interface
{
    internal interface IAssistant
    {
        bool CreateUser();

        void DeleteUser();

        //void CreateFromExcel(FileStream excelFile);
    }
}