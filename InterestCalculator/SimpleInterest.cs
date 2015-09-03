using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterestCalculator
{
    class SimpleInterest
    {
        double _principle;
        double _rate;
        double _time;

        public double Principle{
            get { return this._principle;}
            set { this._principle=value;}
        }

        public double Rate{
            get {return this._rate;}
            set {this._rate=value;}
        }

        public double Time{
            get {return this._time;}
            set {this._time=value;}
        }

        public double calculateInterest()
        {
            return (this._principle * this._rate * this._time) / 100;
        }

    }
}
