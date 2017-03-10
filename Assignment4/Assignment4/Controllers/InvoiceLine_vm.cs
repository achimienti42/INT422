using Assignment4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment4.Controllers
{
        public class InvoiceLineBase
        {

            public int InvoiceLineId { get; set; }

            public int InvoiceId { get; set; }

            public int TrackId { get; set; }

            public decimal UnitPrice { get; set; }

            public int Quantity { get; set; }

            public virtual Invoice Invoice { get; set; }


        }

        public class InvoiceLineWithDetail : InvoiceLineBase
        {

            public InvoiceBase Invoice { get; set; }

            public string TrackName { get; set; }

            public string Composer { get; set; }

             public string TrackAlbumArtistName { get; set; }

            public string TrackMediaTypeName { get; set; }

            public string TrackAlbumTitle { get; set; }

        }

    }
