using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;



// This is clearly not MVC structure - it is doing presentation work
//  ... This should be handles in VIEW not MODEL (as is done below)
// This is called a tools-driven approach. (Versus maintenance-driven)




namespace ACME.Models
{
    // MetadataType req'd adding using DataAnnotations
    [MetadataType(typeof(Product.Metadata))]


    // this was originally ProductMetaData ... 
    //     changed to match the other partial class in same namespace
    public partial class Product
    {

        // sealed is a modifier which prevents other classes from inheriting from it
        //       = no further changes
        // this also prevent auto-generated (virtual) classes from overriding it - 
        // perfect for the Db situation this addresses
        // when sealed used with method or prop must be used with override:
        //     sealed protected override Something();

        // side note: structs are implicitly sealed
        sealed class Metadata
        {
            [Key]
            public System.Guid ProductId { get; set; }

            // Required was commented out in vid 17
            // this message ONLY shows is field is blank
            //     if over 10 chars - that message superceeds
            [Required]
            // when this is used it OVERRIDES ProductsController Message
            //[Required(ErrorMessage = "This is a custom error message for Name from ProductMetaData")] 
                
            [Display(Name = "WhizZig Name")]

            // when adding a new item the name will be req'd, limited to 10 chars
            [StringLength(10)]
            public string Name { get; set; }


            // Required was commented out in vid 17
            [Required]
            [RegularExpression(@"^\$?\d+(\.(\d{2}))?$")] // this is a standard monetary constraint

            // vid 17 validation showed this as an option
            // this replaces the manual validation on ProductsController lines ~77++
            // [Range(0.1, 1000.0)]
            public decimal Price { get; set; }
        }
    }
}