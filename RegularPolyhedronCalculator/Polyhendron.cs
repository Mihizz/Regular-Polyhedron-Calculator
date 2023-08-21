using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularPolyhedronCalculator
{
    abstract class Polyhendron
    {
        protected double edge;

        protected Polyhendron(double edge)
        {
            this.edge = edge;
        }

        protected double Edge
        {
            get { return edge; }
            set { edge = value; }
        }

        protected abstract double surfaceArea(double x);
        protected abstract double volume(double x);
        protected abstract double radiusCircumscribedSphere(double x);
        protected abstract double radiusInscribedSphere(double x);
        protected abstract double radiusMedium(double x);
    }
}
