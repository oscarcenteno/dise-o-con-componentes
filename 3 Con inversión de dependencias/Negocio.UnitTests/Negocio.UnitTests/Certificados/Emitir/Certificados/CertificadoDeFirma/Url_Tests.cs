﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.Certificados.Emitir;

namespace Emitir.CertificadoDeFirma_Tests
{
    [TestClass()]
    public class Url_Tests : Solicitudes
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;

        [TestMethod()]
        public void Url_CasoUnico()
        {
            elResultadoEsperado = "http://pruebas.crl";
             
            InicialiceUnNacional();
            elResultadoObtenido = new CertificadoDeFirma(laSolicitud).Crl;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}