﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace atcFtableBuilder
{
    class FTableCalcOCWeirRectangular : FTableCalculator, IFTableOperationsOC
    {
        public double WeirWidth = -999;
        public double Height = -999;
        private double pWeirInvert = -999;
        public double WeirInvert
        {
            get { return pWeirInvert; }
            set { pWeirInvert = value; }
        }
        public double DischargeCoefficient = -999;

        public FTableCalcOCWeirRectangular()
        {
            vectorColNames.Clear();
            vectorColNames.Add("DEPTH");
            vectorColNames.Add("AREA");
            vectorColNames.Add("VOLUME");
            vectorColNames.Add("OUTFLOW");
        }

        public ArrayList GenerateFTableOC()
        {
            return GenerateFTable(WeirWidth, Height, WeirInvert, DischargeCoefficient);
        }
        public ArrayList GenerateFTable(double aChannelLength, double aHeight, double aChannelManningsValue, double aDischargeCoefficient)
        {
            ArrayList vectorRowData = new ArrayList();
            //Flow Area Calculations
            double L = aChannelLength;
            double N = aChannelManningsValue;
            double DT = aHeight;
            //double S = longitudalChannelSlope;
            //double w = topChannelWidth;		      
            double Cw = aDischargeCoefficient;

            ArrayList row = new ArrayList();

            double QC = 0.0;
            double acr = 0.0;
            double stot = 0.0;

            double prevAcr = 0.0; ;
            double prevStot = 0.0;
            double R1 = 0.0;

            string sDepth = "";
            string sArea = "";
            string sVolume = "";
            string sOutFlow = "";
            string lFormat = "{0:0.00000}";
            for (double g = N; g < 1000.0; g += FTableCalculatorConstants.calculatorIncrement)
            {
                if (g >= N)
                {
                    R1 = g - N;
                }

                //QC = 3.21 * Math.pow(R1,1.5) * (L-0.2*R1); 
                //Cw  = US(3.21), SI
                //Qmaz = (L/(R1*.2)-1.666);
                //if(Qmaz < 0.001) {
                //   Qmax = Cw * Math.pow(R1,1.5) * (L-0.2*R1);
                //}

                //    with full contraction
                QC = Cw * Math.Pow(R1, 1.5) * (L - 0.2 * R1);
                //} else {
                //   QC =0;
                //} 
                //System.out.print(Qmax);
                //System.out.println("      ");  

                prevStot = stot;
                prevAcr = acr;

                row = new ArrayList();

                sDepth = string.Format(lFormat, (object)g);
                sArea = string.Format(lFormat, (object)acr);
                sVolume = string.Format(lFormat, (object)stot);
                sOutFlow = string.Format(lFormat, (object)QC);
                row.Add(sDepth);
                row.Add(sArea);
                row.Add(sVolume);
                row.Add(sOutFlow);

                vectorRowData.Add(row);
            }
            return vectorRowData;
        }
    }
}