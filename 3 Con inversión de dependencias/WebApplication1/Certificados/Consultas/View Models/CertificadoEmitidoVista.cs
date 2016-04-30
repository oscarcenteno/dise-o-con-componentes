﻿using System;
using System.ComponentModel;
using BS.Certificados.Consultas;
using System.Threading;
using System.Globalization;

namespace WebApplication1.ViewModels
{
    public class CertificadoEmitidoVista
    {
        private DateTime laFechaDeEmision;
        private DateTime laFechaDeVencimiento;

        public CertificadoEmitidoVista(CertificadoEmitido elCertificado)
        {
            Sujeto = elCertificado.Sujeto;
            laFechaDeEmision = elCertificado.FechaDeEmision;
            laFechaDeVencimiento = elCertificado.FechaDeVencimiento;
            Crl = elCertificado.Crl;

        }

        public string Sujeto { get; private set; }

        [DisplayName("Fecha de emisión")]
        public string FechaDeEmision
        {
            get
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("es-ES");
                return laFechaDeEmision.ToLongDateString();
            }
        }

        [DisplayName("Fecha de vencimiento")]
        public string FechaDeVencimiento
        {
            get
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("es-ES");
                return laFechaDeVencimiento.ToLongDateString();
            }
        }

        public string Crl { get; private set; }
    }
}