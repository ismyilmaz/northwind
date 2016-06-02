using System;
using System.ServiceModel;
using Northwind.Interfaces;

namespace Northwind.MVCWebUI.Infrastructure
{
    public class WcfProxy<T>
    {
        public static T CreateChannel()
        {
            string adress = $"http://localhost:62944/{typeof(T).Name.Substring(1)}.svc?wsdl";
            var binding = new BasicHttpBinding();
            var channel=new ChannelFactory<T>(binding,adress);

            return channel.CreateChannel();
        }
    }
}