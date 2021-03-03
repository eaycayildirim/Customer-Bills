using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Xml.Linq;
using System.Globalization;

namespace CustomerBills
{
    class XML
    {
        public void addTypes()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("CustomerBills.xml");

            XmlNodeList node_list = doc.DocumentElement.ChildNodes;

            foreach (XmlNode node in node_list)
            {
                CustomerType.customer_type.Add(new CustomerType(node.ChildNodes[0].InnerText, Convert.ToInt32(node.ChildNodes[1].InnerText), Convert.ToInt32(node.ChildNodes[2].InnerText), Convert.ToInt32(node.ChildNodes[3].InnerText), Convert.ToInt32(node.ChildNodes[4].InnerText), Convert.ToDouble(node.ChildNodes[5].InnerText, CultureInfo.InvariantCulture), Convert.ToInt32(node.ChildNodes[6].InnerText), Convert.ToDouble(node.ChildNodes[7].InnerText, CultureInfo.InvariantCulture), Convert.ToDouble(node.ChildNodes[8].InnerText, CultureInfo.InvariantCulture), Convert.ToDouble(node.ChildNodes[9].InnerText, CultureInfo.InvariantCulture)));
            }
        }

        public void writeCustomer(string tariff_name, string monthly_cost, string included_mins, string included_texts, string first_tier_mins, string first_tier_rate, string second_tier_mins, string second_tier_rate, string rate_per_min, string text_cost)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("CustomerBills.xml");

            XmlNode root_node = doc.CreateElement("Plan");

            XmlNode user_node = doc.CreateElement("TariffName");
            user_node.InnerText = tariff_name;
            root_node.AppendChild(user_node);

            user_node = doc.CreateElement("MonthlyCost");
            user_node.InnerText = monthly_cost;
            root_node.AppendChild(user_node);

            user_node = doc.CreateElement("IncludedMinutes");
            user_node.InnerText = included_mins;
            root_node.AppendChild(user_node);

            user_node = doc.CreateElement("IncludedTexts");
            user_node.InnerText = included_texts;
            root_node.AppendChild(user_node);

            user_node = doc.CreateElement("FirstTierMins");
            user_node.InnerText = first_tier_mins;
            root_node.AppendChild(user_node);

            user_node = doc.CreateElement("FirstTierRate");
            user_node.InnerText = first_tier_rate;
            root_node.AppendChild(user_node);

            user_node = doc.CreateElement("SecondTierMins");
            user_node.InnerText = second_tier_mins;
            root_node.AppendChild(user_node);

            user_node = doc.CreateElement("SecondTierRate");
            user_node.InnerText = second_tier_rate;
            root_node.AppendChild(user_node);

            user_node = doc.CreateElement("RatePerMin");
            user_node.InnerText = rate_per_min;
            root_node.AppendChild(user_node);

            user_node = doc.CreateElement("TextCost");
            user_node.InnerText = text_cost;
            root_node.AppendChild(user_node);

            doc.DocumentElement.AppendChild(root_node);
            doc.Save("CustomerBills.xml");
        }
    }
}
