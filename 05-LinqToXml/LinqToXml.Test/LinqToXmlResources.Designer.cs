﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LinqToXml.Test {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class LinqToXmlResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal LinqToXmlResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("LinqToXml.Test.LinqToXmlResources", typeof(LinqToXmlResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to I was in Brest last summer. It was very nice. But there is an issue - it is in France..
        /// </summary>
        internal static string ConcatenationStringResult {
            get {
                return ResourceManager.GetString("ConcatenationStringResult", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Document&gt;
        ///  &lt;Sentence&gt;
        ///    &lt;Word&gt;I &lt;/Word&gt;
        ///    &lt;Word&gt;was &lt;/Word&gt;
        ///    &lt;Word&gt;in &lt;/Word&gt;
        ///    &lt;Word&gt;Brest &lt;/Word&gt;
        ///    &lt;Word&gt;last &lt;/Word&gt;
        ///    &lt;Word&gt;summer&lt;/Word&gt;
        ///    &lt;Punctuation&gt;. &lt;/Punctuation&gt;
        ///  &lt;/Sentence&gt;
        ///  &lt;Sentence&gt;
        ///    &lt;Word&gt;It &lt;/Word&gt;
        ///    &lt;Word&gt;was &lt;/Word&gt;
        ///    &lt;Word&gt;very &lt;/Word&gt;
        ///    &lt;Word&gt;nice&lt;/Word&gt;
        ///    &lt;Punctuation&gt;. &lt;/Punctuation&gt;
        ///  &lt;/Sentence&gt;
        ///  &lt;Sentence&gt;
        ///    &lt;Part&gt;
        ///      &lt;Word&gt;But &lt;/Word&gt;
        ///      &lt;Word&gt;there &lt;/Word&gt;
        ///      &lt;Word&gt;is &lt;/Word&gt;
        ///      &lt;Word&gt;an &lt;/Word&gt;
        ///      &lt;Word&gt;is [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ConcatenationStringSource {
            get {
                return ResourceManager.GetString("ConcatenationStringSource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Root&gt;
        ///  &lt;Group ID=&quot;A&quot;&gt;
        ///    &lt;Data&gt;
        ///      &lt;Quantity&gt;3&lt;/Quantity&gt;
        ///      &lt;Price&gt;24.50&lt;/Price&gt;
        ///    &lt;/Data&gt;
        ///    &lt;Data&gt;
        ///      &lt;Quantity&gt;5&lt;/Quantity&gt;
        ///      &lt;Price&gt;4.95&lt;/Price&gt;
        ///    &lt;/Data&gt;
        ///    &lt;Data&gt;
        ///      &lt;Quantity&gt;3&lt;/Quantity&gt;
        ///      &lt;Price&gt;66.00&lt;/Price&gt;
        ///    &lt;/Data&gt;
        ///    &lt;Data&gt;
        ///      &lt;Quantity&gt;15&lt;/Quantity&gt;
        ///      &lt;Price&gt;29.00&lt;/Price&gt;
        ///    &lt;/Data&gt;
        ///  &lt;/Group&gt;
        ///  &lt;Group ID=&quot;B&quot;&gt;
        ///    &lt;Data&gt;
        ///      &lt;Quantity&gt;1&lt;/Quantity&gt;
        ///      &lt;Price&gt;89.99&lt;/Price&gt;
        ///    &lt;/Data&gt;
        ///    &lt;Data&gt;
        ///      &lt;Quantity&gt;10&lt;/Quantity&gt; [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string CreateHierarchyResultFile {
            get {
                return ResourceManager.GetString("CreateHierarchyResultFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Root&gt;
        ///  &lt;TaxRate&gt;7.25&lt;/TaxRate&gt;
        ///  &lt;Data&gt;
        ///    &lt;Category&gt;A&lt;/Category&gt;
        ///    &lt;Quantity&gt;3&lt;/Quantity&gt;
        ///    &lt;Price&gt;24.50&lt;/Price&gt;
        ///  &lt;/Data&gt;
        ///  &lt;Data&gt;
        ///    &lt;Category&gt;B&lt;/Category&gt;
        ///    &lt;Quantity&gt;1&lt;/Quantity&gt;
        ///    &lt;Price&gt;89.99&lt;/Price&gt;
        ///  &lt;/Data&gt;
        ///  &lt;Data&gt;
        ///    &lt;Category&gt;A&lt;/Category&gt;
        ///    &lt;Quantity&gt;5&lt;/Quantity&gt;
        ///    &lt;Price&gt;4.95&lt;/Price&gt;
        ///  &lt;/Data&gt;
        ///  &lt;Data&gt;
        ///    &lt;Category&gt;A&lt;/Category&gt;
        ///    &lt;Quantity&gt;3&lt;/Quantity&gt;
        ///    &lt;Price&gt;66.00&lt;/Price&gt;
        ///  &lt;/Data&gt;
        ///  &lt;Data&gt;
        ///    &lt;Category&gt;B&lt;/Category&gt;
        ///    &lt;Quantity&gt;10&lt;/Quantity&gt;        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string CreateHierarchySourceFile {
            get {
                return ResourceManager.GetString("CreateHierarchySourceFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;service&gt;
        ///  &lt;channel id=&quot;7&quot;&gt;
        ///    &lt;subscriber&gt;Anna&lt;/subscriber&gt;
        ///    &lt;subscriber&gt;Helga&lt;/subscriber&gt;
        ///    &lt;!-- KEEP --&gt;
        ///  &lt;/channel&gt;
        ///  &lt;channel id=&quot;3&quot;&gt;
        ///    &lt;subscriber&gt;Anna&lt;/subscriber&gt;
        ///    &lt;subscriber&gt;Helga&lt;/subscriber&gt;
        ///  &lt;/channel&gt;
        ///  &lt;channel id=&quot;1&quot;&gt;
        ///    &lt;subscriber&gt;Helga&lt;/subscriber&gt;
        ///  &lt;/channel&gt;
        ///  &lt;channel id=&quot;9&quot;&gt;
        ///    &lt;subscriber&gt;Mika&lt;/subscriber&gt;
        ///    &lt;!-- KEEP --&gt;
        ///  &lt;/channel&gt;
        ///&lt;/service&gt;
        ///.
        /// </summary>
        internal static string FindAllChannelsIdsSource {
            get {
                return ResourceManager.GetString("FindAllChannelsIdsSource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Root&gt;&lt;Customers CustomerID=&quot;ALFKI&quot;&gt;&lt;CompanyName&gt;Alfreds Futterkiste&lt;/CompanyName&gt;&lt;ContactName&gt;Maria Anders&lt;/ContactName&gt;&lt;ContactTitle&gt;Sales Representative&lt;/ContactTitle&gt;&lt;Phone&gt;030-0074321&lt;/Phone&gt;&lt;Fax&gt;030-0076545&lt;/Fax&gt;&lt;FullAddress&gt;&lt;Address&gt;Obere Str. 57&lt;/Address&gt;&lt;City&gt;Berlin&lt;/City&gt;&lt;PostalCode&gt;12209&lt;/PostalCode&gt;&lt;Country&gt;Germany&lt;/Country&gt;&lt;/FullAddress&gt;&lt;/Customers&gt;&lt;Customers CustomerID=&quot;ANATR&quot;&gt;&lt;CompanyName&gt;Ana Trujillo Emparedados y helados&lt;/CompanyName&gt;&lt;ContactName&gt;Ana Trujillo&lt;/ContactName&gt;&lt;ContactTitle&gt;Owne [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string GeneralCustomersResultFile {
            get {
                return ResourceManager.GetString("GeneralCustomersResultFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Root&gt;&lt;Customers CustomerID=&quot;ALFKI&quot;&gt;&lt;CompanyName&gt;Alfreds Futterkiste&lt;/CompanyName&gt;&lt;ContactName&gt;Maria Anders&lt;/ContactName&gt;&lt;ContactTitle&gt;Sales Representative&lt;/ContactTitle&gt;&lt;Phone&gt;030-0074321&lt;/Phone&gt;&lt;Fax&gt;030-0076545&lt;/Fax&gt;&lt;FullAddress&gt;&lt;Address&gt;Obere Str. 57&lt;/Address&gt;&lt;City&gt;Berlin&lt;/City&gt;&lt;PostalCode&gt;12209&lt;/PostalCode&gt;&lt;Country&gt;Germany&lt;/Country&gt;&lt;/FullAddress&gt;&lt;/Customers&gt;&lt;Customers CustomerID=&quot;ANATR&quot;&gt;&lt;CompanyName&gt;Ana Trujillo Emparedados y helados&lt;/CompanyName&gt;&lt;ContactName&gt;Ana Trujillo&lt;/ContactName&gt;&lt;ContactTitle&gt;Owne [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string GeneralCustomersSourceFile {
            get {
                return ResourceManager.GetString("GeneralCustomersSourceFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Root&gt;
        ///  &lt;Orders&gt;
        ///    &lt;CustomerID&gt;HANAR&lt;/CustomerID&gt;
        ///    &lt;EmployeeID&gt;3&lt;/EmployeeID&gt;
        ///    &lt;OrderDate&gt;1996-07-10T00:00:00&lt;/OrderDate&gt;
        ///    &lt;RequiredDate&gt;1996-07-24T00:00:00&lt;/RequiredDate&gt;
        ///    &lt;ShipInfo ShippedDate=&quot;1996-07-16T00:00:00&quot;&gt;
        ///      &lt;ShipVia&gt;2&lt;/ShipVia&gt;
        ///      &lt;Freight&gt;58.17&lt;/Freight&gt;
        ///      &lt;ShipName&gt;Hanari Carnes&lt;/ShipName&gt;
        ///      &lt;ShipAddress&gt;Rua do Paco, 67&lt;/ShipAddress&gt;
        ///      &lt;ShipCity&gt;Rio de Janeiro&lt;/ShipCity&gt;
        ///      &lt;ShipRegion&gt;RJ&lt;/ShipRegion&gt;
        ///      &lt;ShipPostalCode&gt;05454-876&lt;/ShipPosta [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string GeneralOrdersFileResult {
            get {
                return ResourceManager.GetString("GeneralOrdersFileResult", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Root&gt;
        ///  &lt;Orders&gt;
        ///    &lt;CustomerID&gt;HANAR&lt;/CustomerID&gt;
        ///    &lt;EmployeeID&gt;3&lt;/EmployeeID&gt;
        ///    &lt;OrderDate&gt;1996-07-10T00:00:00&lt;/OrderDate&gt;
        ///    &lt;RequiredDate&gt;1996-07-24T00:00:00&lt;/RequiredDate&gt;
        ///    &lt;ShipInfo ShippedDate=&quot;1996-07-16T00:00:00&quot;&gt;
        ///      &lt;ShipVia&gt;2&lt;/ShipVia&gt;
        ///      &lt;Freight&gt;58.17&lt;/Freight&gt;
        ///      &lt;ShipName&gt;Hanari Carnes&lt;/ShipName&gt;
        ///      &lt;ShipAddress&gt;Rua do Paco, 67&lt;/ShipAddress&gt;
        ///      &lt;ShipCity&gt;Rio de Janeiro&lt;/ShipCity&gt;
        ///      &lt;ShipRegion&gt;RJ&lt;/ShipRegion&gt;
        ///      &lt;ShipPostalCode&gt;05454-876&lt;/ShipPosta [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string GeneralOrdersFileSource {
            get {
                return ResourceManager.GetString("GeneralOrdersFileSource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;aw:PurchaseOrders xmlns:aw=&quot;http://www.adventure-works.com&quot;&gt;
        ///  &lt;aw:PurchaseOrder aw:PurchaseOrderNumber=&quot;99503&quot; aw:OrderDate=&quot;1999-10-20&quot;&gt;
        ///    &lt;aw:Address aw:Type=&quot;Shipping&quot;&gt;
        ///      &lt;aw:Name&gt;Ellen Adams&lt;/aw:Name&gt;
        ///      &lt;aw:Street&gt;123 Maple Street&lt;/aw:Street&gt;
        ///      &lt;aw:City&gt;Mill Valley&lt;/aw:City&gt;
        ///      &lt;aw:State&gt;CA&lt;/aw:State&gt;
        ///      &lt;aw:Zip&gt;10999&lt;/aw:Zip&gt;
        ///      &lt;aw:Country&gt;USA&lt;/aw:Country&gt;
        ///    &lt;/aw:Address&gt;
        ///    &lt;aw:Address aw:Type=&quot;Billing&quot;&gt;
        ///      &lt;aw:Name&gt;Tai [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string PurchaseOrdersSourceFile {
            get {
                return ResourceManager.GetString("PurchaseOrdersSourceFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Document&gt;
        ///  &lt;contact&gt;
        ///    &lt;name&gt;Mark&lt;/name&gt;
        ///    &lt;lastname&gt;Avrelij&lt;/lastname&gt;
        ///  &lt;/contact&gt;
        ///  &lt;contact&gt;
        ///    &lt;name&gt;Joan&lt;/name&gt;
        ///    &lt;lastname&gt;Dark&lt;/lastname&gt;
        ///  &lt;/contact&gt;
        ///  &lt;contact&gt;
        ///    &lt;name&gt;Michail&lt;/name&gt;
        ///    &lt;lastname&gt;Gorbachev&lt;/lastname&gt;
        ///  &lt;/contact&gt;
        ///&lt;/Document&gt;.
        /// </summary>
        internal static string ReplaceCustomersWithContactsResult {
            get {
                return ResourceManager.GetString("ReplaceCustomersWithContactsResult", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Document&gt;
        ///  &lt;customer&gt;
        ///    &lt;name&gt;Mark&lt;/name&gt;
        ///    &lt;lastname&gt;Avrelij&lt;/lastname&gt;
        ///  &lt;/customer&gt;
        ///  &lt;customer&gt;
        ///    &lt;name&gt;Joan&lt;/name&gt;
        ///    &lt;lastname&gt;Dark&lt;/lastname&gt;
        ///  &lt;/customer&gt;
        ///  &lt;customer&gt;
        ///    &lt;name&gt;Michail&lt;/name&gt;
        ///    &lt;lastname&gt;Gorbachev&lt;/lastname&gt;
        ///  &lt;/customer&gt;
        ///&lt;/Document&gt;.
        /// </summary>
        internal static string ReplaceCustomersWithContactsSource {
            get {
                return ResourceManager.GetString("ReplaceCustomersWithContactsSource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Root&gt;
        ///  &lt;Customer CustomerID=&quot;GREAL&quot;&gt;
        ///    &lt;CompanyName&gt;Great Lakes Food Market&lt;/CompanyName&gt;
        ///    &lt;ContactName&gt;Howard Snyder&lt;/ContactName&gt;
        ///    &lt;ContactTitle&gt;Marketing Manager&lt;/ContactTitle&gt;
        ///    &lt;Phone&gt;(503) 555-7555&lt;/Phone&gt;
        ///    &lt;FullAddress&gt;
        ///      &lt;Address&gt;2732 Baker Blvd.&lt;/Address&gt;
        ///      &lt;City&gt;Eugene&lt;/City&gt;
        ///      &lt;Region&gt;OR&lt;/Region&gt;
        ///      &lt;PostalCode&gt;97403&lt;/PostalCode&gt;
        ///      &lt;Country&gt;USA&lt;/Country&gt;
        ///    &lt;/FullAddress&gt;
        ///  &lt;/Customer&gt;
        ///  &lt;Customer CustomerID=&quot;HUNGC&quot;&gt;
        ///    &lt;CompanyName&gt;Hungry Coyote [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string XmlFromCsvResultFile {
            get {
                return ResourceManager.GetString("XmlFromCsvResultFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to GREAL,Great Lakes Food Market,Howard Snyder,Marketing Manager,(503) 555-7555,2732 Baker Blvd.,Eugene,OR,97403,USA
        ///HUNGC,Hungry Coyote Import Store,Yoshi Latimer,Sales Representative,(503) 555-6874,City Center Plaza 516 Main St.,Elgin,OR,97827,USA
        ///LAZYK,Lazy K Kountry Store,John Steel,Marketing Manager,(509) 555-7969,12 Orchestra Terrace,Walla Walla,WA,99362,USA
        ///LETSS,Let&apos;s Stop N Shop,Jaime Yorres,Owner,(415) 555-5938,87 Polk St. Suite 5,San Francisco,CA,94117,USA.
        /// </summary>
        internal static string XmlFromCsvSourceFile {
            get {
                return ResourceManager.GetString("XmlFromCsvSourceFile", resourceCulture);
            }
        }
    }
}
