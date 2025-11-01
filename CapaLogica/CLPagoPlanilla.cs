using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class CLPagoPlanilla
    {
        public double MtdBonoEmpleado(double SalarioBase)
        {
            double Bono = 0;
            if (SalarioBase > 0 && SalarioBase <= 5000)
            {
                Bono = 250 + (SalarioBase * 0.05);
            }
            else if (SalarioBase >= 5000 && SalarioBase <= 7000)
            {
                Bono = 250 + (SalarioBase * 0.10);
            }
            else if (SalarioBase >= 7000 && SalarioBase <= 10000)
            {
                Bono = 250 + (SalarioBase * 0.15);
            }
            else
            {
                Bono = 250 + (SalarioBase * 0.20);
            }
            return Bono;
        }
        public double MtdIgssEmpleado(double SalarioBase)
        {
            double Igss = 0;
            if (SalarioBase > 0 && SalarioBase <= 5000)
            {
                Igss = (SalarioBase * 0.03);
            }
            else if (SalarioBase >= 5000 && SalarioBase <= 7000)
            {
                Igss = (SalarioBase * 0.04);
            }
            else if (SalarioBase >= 7000 && SalarioBase <= 10000)
            {
                Igss = (SalarioBase * 0.05);
            }
            else
            {
                Igss = (SalarioBase * 0.06);
            }
            return Igss;
        }
        public double MtdISREmpleado(double SalarioBase)
        {
            double Isr = 0;
            if (SalarioBase > 0 && SalarioBase <= 5000)
            {
                Isr = (SalarioBase * 0.05);
            }
            else if (SalarioBase >= 5000 && SalarioBase <= 7000)
            {
                Isr = (SalarioBase * 0.06);
            }
            else if (SalarioBase >= 7000 && SalarioBase <= 10000)
            {
                Isr = (SalarioBase * 0.07);
            }
            else
            {
                Isr = (SalarioBase * 0.08);
            }
            return Isr;
        }
        public double MtdPagoFinalEmpleado(double SalarioBase, double Bono, double Igss, double Isr)
        {
            double PagoFinal = 0;
            PagoFinal = (SalarioBase + Bono) - (Igss + Isr);
            return PagoFinal;
        }

    }
}
