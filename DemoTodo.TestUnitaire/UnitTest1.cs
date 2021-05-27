using DemoTodo.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DemoTodo.TestUnitaire
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ResteAFaire()
        {
            // 1. Vider la table
            var todoEtendu = new TodoEtendu();
            Assert.IsTrue(todoEtendu.ClearAll(), "Impossible de vider la table Todo");

            // 2. Insérer 5 todos
            var message = todoEtendu.Insert("A", true);
            Assert.IsTrue( message==null, message);


            //Assert.IsTrue(todoEtendu.Insert("B1234", true ), "Erreur avec B");
            //Assert.IsTrue(todoEtendu.Insert("C1234", false), "Erreur avec C");
            //Assert.IsTrue(todoEtendu.Insert("D1234", false), "Erreur avec D");
            //Assert.IsTrue(todoEtendu.Insert("E1234", true ), "Erreur avec E");

            // 3. Vérification de 2 restes à faire
            Assert.IsTrue(todoEtendu.Compteur == 2);
        }
    }
}
