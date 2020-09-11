using NUnit.Framework;
using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void NombreValido () 
        //Verifico que no este vacío
        {
            string Expected = "text";
            Person persona= new Person ("text","1.223.456-3");
            Assert.AreEqual(Expected,persona.Name);
        }

        [Test]
        public void CedulaValida () 
        //Verifico que no este vacío
        {
            string Expected = "12234563";
            Person persona= new Person ("text","1.223.456-3");
            Assert.AreEqual(Expected,persona.ID);
        }
        [Test]
           
            public void IngresoNombreVacio ()
            {
            string Expected = null;
            Person persona= new Person ("","1.223.456-3");
            Assert.AreEqual(Expected,persona.Name);
           }
        
        [Test]
        
        public void IngresoCedulaVacia()
        {
        string Expected = null;
        Person persona= new Person ("text","");
        Assert.AreEqual(Expected,persona.ID);
        }
        
    }
}