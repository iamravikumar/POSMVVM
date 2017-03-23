//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POSEntities.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public partial class ItemDisplayInfo : ModelBase
    {
        public ItemDisplayInfo()
        {
            this.Menus = new HashSet<Menu>();
            this.Products = new HashSet<Product>();
        }
    
        public int ID { get; set; }
        public int MenuID { get; set; }
        public int ItemID { get; set; }
        public bool IsMenu { get; set; }
        public string DisplayName { get; set; }
        public int IndexRow { get; set; }
        public int IndexColumn { get; set; }
        public int NumberOfRows { get { return GetValue(() => NumberOfRows); } set { SetValue(() => NumberOfRows, value); } }
        public int NumberOfColumns { get { return GetValue(() => NumberOfColumns); } set { SetValue(() => NumberOfColumns, value); } }
        public string DisplayProperties { get; set; }
        public string BackgroundColor { get { return GetValue(() => BackgroundColor) ?? "#CC119EDA"; } set { SetValue(() => BackgroundColor, value); } }
        public string TextColor { get { return GetValue(() => TextColor)?? "White"; } set { SetValue(() => TextColor, value); } }
        public string FontString { get { return GetValue(() => FontString); } set { SetValue(() => FontString, value); } }
        public string ImageUrl { get { return GetValue(() => ImageUrl); } set { SetValue(() => ImageUrl, value); } }
        public string FontSize { get { return GetValue(() => FontSize)?? "15"; } set { SetValue(() => FontSize, value); } }
    
        public virtual Menu Menu { get; set; }
        public virtual ICollection<Menu> Menus { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
