using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DZ
{
    class Prog
    {
        static void Main(string[] args)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("T:\\Code\\Chapter05\\DZ\\DZ\\people.xml");
            XmlElement? xRoot = xDoc.DocumentElement;

            // создаем новый элемент person
            XmlElement personElem = xDoc.CreateElement("person");

            // создаем атрибут name
            XmlAttribute nameAttr = xDoc.CreateAttribute("name");

            // создаем элементы
            XmlElement companyElem = xDoc.CreateElement("company");
            XmlElement ageElem = xDoc.CreateElement("age");
            XmlElement balanceElem = xDoc.CreateElement("balance");
            XmlElement clikuhaElem = xDoc.CreateElement("clikuha");

            // создаем текстовые значения для элементов и атрибута
            XmlText nameText = xDoc.CreateTextNode("Andru");
            XmlText companyText = xDoc.CreateTextNode("Logasoft");
            XmlText ageText = xDoc.CreateTextNode("14");
            XmlText clikuhaText = xDoc.CreateTextNode("clikuha");
            XmlText balanceText = xDoc.CreateTextNode("2132");


            //добавляем узлы
            nameAttr.AppendChild(nameText);
            companyElem.AppendChild(companyText);
            ageElem.AppendChild(ageText);
            clikuhaElem.AppendChild(clikuhaText);
            balanceElem.AppendChild(balanceText);

            // добавляем атрибут name
            personElem.Attributes.Append(nameAttr);
            // добавляем элементы
            personElem.AppendChild(companyElem);
            personElem.AppendChild(ageElem);
            personElem.AppendChild(clikuhaElem);
            personElem.AppendChild(balanceElem);
            // добавляем в корневой элемент новый элемент person
            xRoot?.AppendChild(personElem);
            // сохраняем изменения xml-документа в файл
            xDoc.Save("T:\\Code\\Chapter05\\DZ\\DZ\\people.xml");
        }
    }
}
