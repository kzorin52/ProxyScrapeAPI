# ProxyScrapeAPI
Proxyscrape.com API C# implementation
## Кто хочет помочь идеями и кодом - https://t.me/temnij52
# [![](https://img.shields.io/nuget/v/ProxyScrapeAPI?color=red&logo=TEMNIJ&logoColor=red&style=flat-square)](https://www.nuget.org/packages/ProxyScrapeAPI/)
# Example
``` csharp
     using ProxyScrapeAPI;
     // ...
     Scraper api = new Scraper();

     api.DownloadProxies(Scraper.Https, "https.txt", timeout: 600, ssl: Scraper.SSLType.yes,
            anonymity: Scraper.AnonymityType.elite, limit: 50, age: 5, port: 8081,
            averagetimeout: 5000); // Simply Download To File
            
     MessageBox.Show(api.GetProxies(Scraper.ProxyType.Https, timeout: 600, ssl: Scraper.SSLType.yes,
            anonymity: Scraper.AnonymityType.elite, limit: 50, age: 5, port: 8081,
            averagetimeout: 5000)); // Get ProxyList As String
            
     int count = api.AmountProxies(Scraper.ProxyType.Https, timeout: 600, ssl: Scraper.SSLType.yes,
            anonymity: Scraper.AnonymityType.elite, age: 5, port: 8081,
            averagetimeout: 5000); // Amount Of Specific Proxies As Int
            
     string lastUpdates = api.LastUpdates(Scraper.ProxyType.Socks4); // Get Time Of Last Update Proxies;
                                                             //  out - "Around 54 seconds ago"
```

# Если ошибка 'Необработанное исключение: System.Net.WebException: Запрос был прерван: Не удалось создать защищенный канал SSL/TLS'
``` csharp
     ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls |
                                       SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
```
