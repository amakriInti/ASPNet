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
            Assert.IsTrue(todoEtendu.Insert("A", true));
            Assert.IsTrue(todoEtendu.Insert("B", true));
            Assert.IsTrue(todoEtendu.Insert("C", false));
            Assert.IsTrue(todoEtendu.Insert("D", false));
            Assert.IsTrue(todoEtendu.Insert("E", true));

            // 3. Vérification de 2 restes à faire
            Assert.IsTrue(todoEtendu.Compteur == 2);
        }
    }
}
