using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace wguC_.Models
{
    public class Inventory
    {
        public BindingList<Product> Products { get; set; } = new BindingList<Product>();
        public BindingList<Part> AllParts { get; set; } = new BindingList<Part>();

        public void addProduct(Product product)
        {
            Products.Add(product);
        }
        public void addPart(Part part)
        {
            AllParts.Add(part);
        }
        public bool removeProduct(int productID)
        {
            var product = lookupProduct(productID);
            if (product != null)
            {
                Products.Remove(product);
                return true;
            }
            return false;
        }
        public bool deletePart(Part part)
        {
            return AllParts.Remove(part);
        }
        public Product lookupProduct(int productID)
        {
            return Products.FirstOrDefault(p => p.ProductID == productID);
        }
        public Part lookupPart(int partID)
        {
            return AllParts.FirstOrDefault(p => p.PartID == partID);
        }
        public void updateProduct(int productID, Product updatedProduct)
        {
            var product = lookupProduct(productID);
            if (product != null)
            {
                product.Name = updatedProduct.Name;
                product.Price = updatedProduct.Price;
                product.InStock = updatedProduct.InStock;
                product.Min = updatedProduct.Min;
                product.Max = updatedProduct.Max;
                product.AssociatedParts = updatedProduct.AssociatedParts;
            }
        }
        public void updatePart(int partID, Part updatedPart)
        {
            var part = lookupPart(partID);
            if (part != null)
            {
                part.Name = updatedPart.Name;
                part.Price = updatedPart.Price;
                part.InStock = updatedPart.InStock;
                part.Min = updatedPart.Min;
                part.Max = updatedPart.Max;
                if (part is Inhouse inhousePart && updatedPart is Inhouse updatedInhousePart)
                {
                    inhousePart.MachineID = updatedInhousePart.MachineID;
                }
                else if (part is Outsourced outsourcedPart && updatedPart is Outsourced updatedOutsourcedPart)
                {
                    outsourcedPart.CompanyName = updatedOutsourcedPart.CompanyName;
                }
            }
        }
    }
}
