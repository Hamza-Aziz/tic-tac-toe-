using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using CalculatriceDSRemotingTrue;
namespace serveurTicToe
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpChannel channel = new TcpChannel(255);
            ChannelServices.RegisterChannel(channel);
            RemotingConfiguration.ApplicationName = "nomService";//cao
                                                                 /*cao*/
            RemotingConfiguration.RegisterActivatedServiceType(typeof(Jeu));
            // RemotingConfiguration.RegisterWellKnownServiceType(typeof(ClassLibrary), "nomService", WellKnownObjectMode.Singleton);
            Console.WriteLine("Serveur demarre avec succes, attend de client ... ");
            Console.ReadLine();

        }
    }
}
