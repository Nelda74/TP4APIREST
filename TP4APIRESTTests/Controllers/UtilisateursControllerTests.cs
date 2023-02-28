using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP4APIREST.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4APIREST.Models.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace TP4APIREST.Controllers.Tests
{
    [TestClass()]
    public class UtilisateursControllerTests
    {
        private FilmRatingsDBContext? _context;
        private UtilisateursController? _controller;

        public void UtilisateursControllerTest()
        {
            var builder = new DbContextOptionsBuilder<FilmRatingsDBContext>().UseNpgsql("Server=localhost;port=5432;Database=FilmDBv2; uid=postgres; password=postgres;"); // Chaine de connexion à mettre dans les ( )
            _context = new FilmRatingsDBContext(builder.Options);
            _controller = new UtilisateursController(_context);
        }

        [TestMethod()]
        public void GetUtilisateursTest()
        {
            UtilisateursControllerTest();
            var utilisateursv1 = _context?.Utilisateurs.ToListAsync();
            _= _controller?.GetUtilisateurs().Result;


            Assert.IsNotNull(utilisateursv1);
            Assert.IsNotNull(utilisateursv2);
            Assert.AreEqual(utilisateursv2, utilisateursv1);
        }

        [TestMethod()]
        public void GetUtilisateurByIdTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetUtilisateurByEmailTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void PutUtilisateurTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void PostUtilisateurTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteUtilisateurTest()
        {
            Assert.Fail();
        }
    }
}