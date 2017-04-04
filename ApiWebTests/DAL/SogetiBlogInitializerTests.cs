using Microsoft.VisualStudio.TestTools.UnitTesting;
using ApiWeb.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiWeb.Models;

namespace ApiWeb.DAL.Tests
{
    [TestClass()]
    public class SogetiBlogInitializerTests
    {
        [TestMethod()]
        public void InicializarDbTest()
        {
            using (var db = new CUContext())
            {
               
            }
        }


    }
}