using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCA3
{
    public class GameName
    {
        public string gameID { get; set; }
        public string steamAppID { get; set; }
        public string cheapest { get; set; }
        public string cheapestDealID { get; set; }
        public string external { get; set; }
        public string internalName { get; set; }
        public string thumb { get; set; }
    }

    
    public class Images
    {
        public string banner { get; set; }
        public string logo { get; set; }
        public string icon { get; set; }
    }

    public class StoreName
    {
        public string storeID { get; set; }
        public string storeName { get; set; }
        public int isActive { get; set; }
        public Images images { get; set; }
    }




    public class Info
    {
        public string title { get; set; }
        public string steamAppID { get; set; }
        public string thumb { get; set; }
    }

    public class CheapestPriceEver
    {
        public string price { get; set; }
        public int date { get; set; }
    }

    public class Deal
    {
        public string storeID { get; set; }
        public string dealID { get; set; }
        public string price { get; set; }
        public string retailPrice { get; set; }
        public string savings { get; set; }
    }

    public class GameDetail
    {
        public Info info { get; set; }
        public CheapestPriceEver cheapestPriceEver { get; set; }
        public List<Deal> deals { get; set; }
    }




    public class GameInfo
    {
        public string storeID { get; set; }
        public string gameID { get; set; }
        public string name { get; set; }
        public string steamAppID { get; set; }
        public string salePrice { get; set; }
        public string retailPrice { get; set; }
        public string steamRatingText { get; set; }
        public string steamRatingPercent { get; set; }
        public string steamRatingCount { get; set; }
        public string metacriticScore { get; set; }
        public object metacriticLink { get; set; }
        public int releaseDate { get; set; }
        public string publisher { get; set; }
        public string steamworks { get; set; }
        public string thumb { get; set; }
    }

    public class CheaperStore
    {
        public string dealID { get; set; }
        public string storeID { get; set; }
        public string salePrice { get; set; }
        public string retailPrice { get; set; }
    }

    public class CheapestPrice
    {
        public string price { get; set; }
        public int date { get; set; }
    }

    public class DealDetails
    {
        public GameInfo gameInfo { get; set; }
        public List<CheaperStore> cheaperStores { get; set; }
        public CheapestPrice cheapestPrice { get; set; }
    }
}
