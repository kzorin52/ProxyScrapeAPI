# ProxyScrapeAPI
Proxyscrape.com API C# implementation

## Кто хочет помочь идеями и кодом - https://t.me/temnij52

# Example
``` csharp
     ProxyScrapeAPI api = new ProxyScrapeAPI;

     api.DownloadProxies(ProxyType.Https, "https.txt", timeout: 600, ssl: SSLType.ssl,
            anonymity: AnonymityType.elite, limit: 50, age: 5, port: 8081,
            averagetimeout: 5000); // Simply Download To File
            
     MessageBox.Show(api.GetProxies(ProxyType.Https, timeout: 600, ssl: SSLType.ssl,
            anonymity: AnonymityType.elite, limit: 50, age: 5, port: 8081,
            averagetimeout: 5000); // Get ProxyList As String
            
      int count = api.AmountProxies(ProxyType.Https, timeout: 600, ssl: SSLType.ssl,
            anonymity: AnonymityType.elite, age: 5, port: 8081,
            averagetimeout: 5000; // Amount Of Specific Proxies As Int
            
      string lastUpdates = api.LastUpdates(ProxyType.Socks4); // Get Time Of Last Update Proxies;
                                                              //  out - "Around 54 seconds ago"
```
