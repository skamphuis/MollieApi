﻿namespace Mollie.Api.Models {
    public class UrlObject {
        public string Href { get; set; }
        public string Type { get; set; }

        public override string ToString() {
            return $"{this.Type} - {this.Href}";
        }
    }
}