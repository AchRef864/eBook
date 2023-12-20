using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace eBook.Models
{
    public class ProductInfoViewModel
    {
        public ObservableCollection<ProductInfo> ItemList { get; set; }
        public ProductInfoViewModel()
        {
            ItemList = new ObservableCollection<ProductInfo>();
            ItemList.Add(new ProductInfo { ProductId=1,ProductName= "To Kill a Mockingbird",Description= "explores moral and racial complexities in the 1930s American South through the experiences of Scout, Jem, and their father, Atticus Finch.",Price=500, UrlImage="R.jpeg" });
            ItemList.Add(new ProductInfo { ProductId = 2, ProductName = "The Hunger Games", Description = "In a dystopian future, Katniss Everdeen fights for survival in a televised battle to the death, uncovering political intrigue and challenging societal oppression.", Price = 200, UrlImage = "OIP.jpeg" });
            ItemList.Add(new ProductInfo { ProductId = 3, ProductName = "The Alchemist", Description = "Santiago's journey across deserts and oases unfolds a spiritual quest, blending adventure and philosophy as he discovers the true meaning of destiny and personal legend.", Price = 300, UrlImage = "alc.jpeg" });
            ItemList.Add(new ProductInfo { ProductId = 4, ProductName = "The Road", Description = "In a post-apocalyptic world, a father and son navigate a desolate landscape, facing moral dilemmas and the struggle for survival while maintaining their humanity.", Price = 400, UrlImage = "road.jpeg" });
            ItemList.Add(new ProductInfo { ProductId = 5, ProductName = "The Kite Runner", Description = "Set in Afghanistan, this powerful narrative follows Amir's redemption journey, intertwined with the tumultuous history of his homeland, exploring friendship, betrayal, and the quest for forgiveness.", Price = 100, UrlImage = "run.jpeg" });
            ItemList.Add(new ProductInfo { ProductId = 6, ProductName = "Brave New World", Description = "In a futuristic society driven by pleasure and conformity, Huxley's novel explores the dehumanizing effects of technology, genetic engineering, and a controlled social order.", Price = 400, UrlImage = "brave.jpeg" });
        }
    }
}
