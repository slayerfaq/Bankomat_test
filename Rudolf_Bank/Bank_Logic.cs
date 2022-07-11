using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Rudolf_Bank
{
    class Bank_Logic
    {
        private string _currency;
        /*private enum NominalsOfCurrency
        {
            _10Rub = 10,
            _50Rub = 50,
            _100Rub = 100,
            _200Rub = 200,
            _500Rub = 500,
            _1000Rub = 1000,
            _2000Rub = 2000,
            _5000Rub = 5000
        }*/
        private List<int> _nominalsOfCurrency;
        
        private List<int> _countNominalsOfCurrency;

        public string Currency { get { return _currency; } }

        public Bank_Logic()
        {
            _currency = "Rub";
            _nominalsOfCurrency = new List<int>() { 10, 50, 100, 200, 500, 1000, 2000, 5000 };
            _countNominalsOfCurrency = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0 };
        }

        public int BalanceOnCard()
        {
            int money = 0;
            for (int index = 0; index < _nominalsOfCurrency.Count; ++index)
            {
                money += _nominalsOfCurrency[index] * _countNominalsOfCurrency[index];
            }
            return money;
        }

        public bool DepositeOnCard(int depositeNominal, int depositeCount)
        {
            switch (depositeNominal)
            {
                case 10: { _countNominalsOfCurrency[0] += depositeCount; break; }
                case 50: { _countNominalsOfCurrency[1] += depositeCount; break; }
                case 100: { _countNominalsOfCurrency[2] += depositeCount; break; }
                case 200: { _countNominalsOfCurrency[3] += depositeCount; break; }
                case 500: { _countNominalsOfCurrency[4] += depositeCount; break; }
                case 1000: { _countNominalsOfCurrency[5] += depositeCount; break; }
                case 2000: { _countNominalsOfCurrency[6] += depositeCount; break; }
                case 5000: { _countNominalsOfCurrency[7] += depositeCount; break; }
                default: { return false; break; }
            }
            SaveBalanceInFile();
            return true;
        }

        public void TakeCash (int sum)
        {

        }

        private void SaveBalanceInFile()
        {
            XmlDocument xDoc = new XmlDocument();
            XmlElement rootElement = xDoc.CreateElement("Balance");
            XmlElement nominalCount10 = xDoc.CreateElement("nominal_count_10");
            XmlText textNominalCount10 = xDoc.CreateTextNode(_countNominalsOfCurrency[0].ToString());

            XmlElement nominalCount50 = xDoc.CreateElement("nominal_count_50");
            XmlText textNominalCount50 = xDoc.CreateTextNode(_countNominalsOfCurrency[1].ToString());

            XmlElement nominalCount100 = xDoc.CreateElement("nominal_count_100");
            XmlText textNominalCount100 = xDoc.CreateTextNode(_countNominalsOfCurrency[2].ToString());

            XmlElement nominalCount200 = xDoc.CreateElement("nominal_count_200");
            XmlText textNominalCount200 = xDoc.CreateTextNode(_countNominalsOfCurrency[3].ToString());

            XmlElement nominalCount500 = xDoc.CreateElement("nominal_count_500");
            XmlText textNominalCount500 = xDoc.CreateTextNode(_countNominalsOfCurrency[4].ToString());

            XmlElement nominalCount1000 = xDoc.CreateElement("nominal_count_1000");
            XmlText textNominalCount1000 = xDoc.CreateTextNode(_countNominalsOfCurrency[5].ToString());

            XmlElement nominalCount2000 = xDoc.CreateElement("nominal_count_2000");
            XmlText textNominalCount2000 = xDoc.CreateTextNode(_countNominalsOfCurrency[6].ToString());

            XmlElement nominalCount5000 = xDoc.CreateElement("nominal_count_5000");
            XmlText textNominalCount5000 = xDoc.CreateTextNode(_countNominalsOfCurrency[7].ToString());

            nominalCount10.AppendChild(textNominalCount10);
            nominalCount50.AppendChild(textNominalCount50);
            nominalCount100.AppendChild(textNominalCount100);
            nominalCount200.AppendChild(textNominalCount200);
            nominalCount500.AppendChild(textNominalCount500);
            nominalCount1000.AppendChild(textNominalCount1000);
            nominalCount2000.AppendChild(textNominalCount2000);
            nominalCount5000.AppendChild(textNominalCount5000);

            rootElement.AppendChild(nominalCount10);
            rootElement.AppendChild(nominalCount50);
            rootElement.AppendChild(nominalCount100);
            rootElement.AppendChild(nominalCount200);
            rootElement.AppendChild(nominalCount500);
            rootElement.AppendChild(nominalCount1000);
            rootElement.AppendChild(nominalCount2000);
            rootElement.AppendChild(nominalCount5000);
            xDoc.AppendChild(rootElement);
            xDoc.Save("Balance.xml");
        }
    }
}
