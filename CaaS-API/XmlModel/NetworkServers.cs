﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.1.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://oec.api.opsource.net/schemas/server")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://oec.api.opsource.net/schemas/server", IsNullable=false, ElementName="NetworkServers")]
public partial class NetworkServers {

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("server")]
    public OpSourceServer[] Items;
}
