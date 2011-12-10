﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;
using CollectionAssert = NUnit.Framework.CollectionAssert;
using StringAssert = NUnit.Framework.StringAssert;
using TestContext = Microsoft.VisualStudio.TestTools.UnitTesting.TestContext;
using Jtc.CsQuery;
using Jtc.CsQuery.Utility;
using Jtc.CsQuery.ExtensionMethods;
using Jtc.CsQuery.Utility.StringScanner;
using Jtc.CsQuery.Utility.EquationParser;

namespace CsqueryTests.Csharp
{
    [TestClass]
    public class Equations_
    {

        [Test,TestMethod]
        public void Basic()
        {


            var eq = Equations.CreateEquation<int>("2+abs(x)");
            Assert.AreEqual("2+abs(x)", eq.ToString(), "Equation looks like it got parsed");
            Assert.AreEqual(6, eq.GetValue(3.5));

            var eq2 = Equations.CreateEquation<double>("2+abs(x)");
            Assert.AreEqual(5.5, eq2.GetValue(3.5));
        }
        
      
    }
}



