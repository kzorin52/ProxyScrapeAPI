using System;
using System.Net;
using System.Text;

namespace ProxyScrapeAPI
{
    public class Scraper
    {
        public enum AnonymityType
        {
            elite,
            anonymous,
            transparent,
            all
        }

        public enum ProxyType
        {
            Socks4 = '4',
            Socks4a = 'a',
            Socks5 = '5',
            Http = 'h',
            Https = 's',
            All = 'A'
        }

        public enum SSLType
        {
            yes,
            no,
            all
        }
        

        public void DownloadProxies(ProxyType? type, string path, int? timeout = null, SSLType? ssl = null,
            AnonymityType? anonymity = null, int? limit = null, int? age = null, int? port = null,
            int? averagetimeout = null)
        {
            var DownloadLink = new StringBuilder("https://api.proxyscrape.com?request=getproxies&");


            if (type != null) DownloadLink.Append($"proxytype={type.ToString().ToLower()}&");

            if (timeout != null) DownloadLink.Append($"timeout={timeout}&");

            if (ssl != null) DownloadLink.Append($"timeout={ssl}&");

            if (anonymity != null) DownloadLink.Append($"anonymity={anonymity}&");

            if (limit != null) DownloadLink.Append($"limit={limit}&");

            if (age != null) DownloadLink.Append($"age={age}&");

            if (port != null && port > 0 && port < 65535) DownloadLink.Append($"port={port}&");

            if (averagetimeout != null) DownloadLink.Append($"averagetimeout={averagetimeout}&");

            new WebClient().DownloadFile(DownloadLink.ToString().Substring(0, DownloadLink.Length - 1), path);
        }

        public string GetProxies(ProxyType? type, int? timeout = null, SSLType? ssl = null,
            AnonymityType? anonymity = null, int? limit = null, int? age = null, int? port = null,
            int? averagetimeout = null)
        {
            var DownloadLink = new StringBuilder("https://api.proxyscrape.com?request=displayproxies&");


            DownloadLink.Append($"proxytype={type.ToString().ToLower()}&");

            if (timeout != null) DownloadLink.Append($"timeout={timeout}&");

            if (ssl != null) DownloadLink.Append($"timeout={ssl}&");

            if (anonymity != null) DownloadLink.Append($"anonymity={anonymity}&");

            if (limit != null) DownloadLink.Append($"limit={limit}&");

            if (age != null) DownloadLink.Append($"age={age}&");

            if (port != null && port > 0 && port < 65535) DownloadLink.Append($"port={port}&");

            if (averagetimeout != null) DownloadLink.Append($"averagetimeout={averagetimeout}&");

            return new WebClient().DownloadString(DownloadLink.ToString().Substring(0, DownloadLink.Length - 1));
        }

        public int AmountProxies(ProxyType? type, int? timeout = null, SSLType? ssl = null,
            AnonymityType? anonymity = null, int? age = null, int? port = null,
            int? averagetimeout = null)
        {
            var DownloadLink = new StringBuilder("https://api.proxyscrape.com?request=amountproxies?");


            if (type != null) DownloadLink.Append($"proxytype={type.ToString().ToLower()}&");

            if (timeout != null) DownloadLink.Append($"timeout={timeout}&");

            if (ssl != null) DownloadLink.Append($"timeout={ssl}&");

            if (anonymity != null) DownloadLink.Append($"anonymity={anonymity}&");

            if (age != null) DownloadLink.Append($"age={age}&");

            if (port != null && port > 0 && port < 65535) DownloadLink.Append($"port={port}&");

            if (averagetimeout != null) DownloadLink.Append($"averagetimeout={averagetimeout}&");

            return int.Parse(new WebClient().DownloadString(DownloadLink.ToString().Substring(0, DownloadLink.Length - 1)));
        }

        public string LastUpdates(ProxyType? type)
        {
            return new WebClient().DownloadString(
                $"https://api.proxyscrape.com/?request=lastupdated&proxytype={type.ToString().ToLower()}");
        }
    }
}