using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JMS.Models
{
    public class ItemResponseModel
    {

        public class ItemResponse<T>
        {

            public T Item { get; set; }

        }
    }
}