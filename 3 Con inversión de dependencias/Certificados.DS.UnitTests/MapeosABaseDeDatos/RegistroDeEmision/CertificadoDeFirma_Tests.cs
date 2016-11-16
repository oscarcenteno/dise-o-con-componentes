﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Certificados.DS.MapeosABaseDeDatos;
using Mapeable.ComparacionesParaPruebasUnitarias;
using Certificados.Negocio.GenerarEmision.ConInversionDeDependencias;
using Certificados.DS.UnitTests.MapeosABaseDeDatos;

namespace Certificados.DS.UnitTests.MapeosABaseDeDatos_Tests.RegistroDeEmision_Tests
{
    [TestClass]
    public class CertificadoDeFirma : EscenariosDeLaEmision
    {
        private RegistroDeCertificado elResultadoEsperado;
        private RegistroDeCertificado elResultadoObtenido;
        private Emision laEmision;

        [TestMethod]
        public void CertificadoDeFirma_UnaEmision_RegistroDelCertificadoDeFirma()
        {
            elResultadoEsperado = ObtengaUnRegistroDeCertificadoNacionalDeFirma();

            laEmision = ObtengaUnaEmisionNacional();
            elResultadoObtenido = new RegistroDeEmision(laEmision).CertificadoDeFirma;

            Verificacion.SonIguales(elResultadoEsperado, elResultadoObtenido);
        }
    }
}