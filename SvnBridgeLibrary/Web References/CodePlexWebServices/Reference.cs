﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 2.0.50727.1433.
// 
#pragma warning disable 1591

namespace SvnBridge.CodePlexWebServices {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ProjectInfoServiceSoap", Namespace="http://www.codeplex.com/services/ProjectInfoService/v1.0")]
    public partial class ProjectInfoService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetTfsInfoForProjectOperationCompleted;
        
        private System.Threading.SendOrPostCallback ListProjectsForUserOperationCompleted;
        
        private System.Threading.SendOrPostCallback ListProjectsForAffiliateOperationCompleted;
        
        private System.Threading.SendOrPostCallback CodePlexUserNameToTfsUserNameOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ProjectInfoService() {
            this.Url = global::SvnBridge.Properties.Settings.Default.SvnBridge_Library_CodePlex_ProjectInfoService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetTfsInfoForProjectCompletedEventHandler GetTfsInfoForProjectCompleted;
        
        /// <remarks/>
        public event ListProjectsForUserCompletedEventHandler ListProjectsForUserCompleted;
        
        /// <remarks/>
        public event ListProjectsForAffiliateCompletedEventHandler ListProjectsForAffiliateCompleted;
        
        /// <remarks/>
        public event CodePlexUserNameToTfsUserNameCompletedEventHandler CodePlexUserNameToTfsUserNameCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.codeplex.com/services/ProjectInfoService/v1.0/GetTfsInfoForProject", RequestNamespace="http://www.codeplex.com/services/ProjectInfoService/v1.0", ResponseNamespace="http://www.codeplex.com/services/ProjectInfoService/v1.0", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ProjectTfsInfo GetTfsInfoForProject(string ProjectName) {
            object[] results = this.Invoke("GetTfsInfoForProject", new object[] {
                        ProjectName});
            return ((ProjectTfsInfo)(results[0]));
        }
        
        /// <remarks/>
        public void GetTfsInfoForProjectAsync(string ProjectName) {
            this.GetTfsInfoForProjectAsync(ProjectName, null);
        }
        
        /// <remarks/>
        public void GetTfsInfoForProjectAsync(string ProjectName, object userState) {
            if ((this.GetTfsInfoForProjectOperationCompleted == null)) {
                this.GetTfsInfoForProjectOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetTfsInfoForProjectOperationCompleted);
            }
            this.InvokeAsync("GetTfsInfoForProject", new object[] {
                        ProjectName}, this.GetTfsInfoForProjectOperationCompleted, userState);
        }
        
        private void OnGetTfsInfoForProjectOperationCompleted(object arg) {
            if ((this.GetTfsInfoForProjectCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetTfsInfoForProjectCompleted(this, new GetTfsInfoForProjectCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.codeplex.com/services/ProjectInfoService/v1.0/ListProjectsForUser", RequestNamespace="http://www.codeplex.com/services/ProjectInfoService/v1.0", ResponseNamespace="http://www.codeplex.com/services/ProjectInfoService/v1.0", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] ListProjectsForUser(string CodePlexUserName) {
            object[] results = this.Invoke("ListProjectsForUser", new object[] {
                        CodePlexUserName});
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public void ListProjectsForUserAsync(string CodePlexUserName) {
            this.ListProjectsForUserAsync(CodePlexUserName, null);
        }
        
        /// <remarks/>
        public void ListProjectsForUserAsync(string CodePlexUserName, object userState) {
            if ((this.ListProjectsForUserOperationCompleted == null)) {
                this.ListProjectsForUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListProjectsForUserOperationCompleted);
            }
            this.InvokeAsync("ListProjectsForUser", new object[] {
                        CodePlexUserName}, this.ListProjectsForUserOperationCompleted, userState);
        }
        
        private void OnListProjectsForUserOperationCompleted(object arg) {
            if ((this.ListProjectsForUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ListProjectsForUserCompleted(this, new ListProjectsForUserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.codeplex.com/services/ProjectInfoService/v1.0/ListProjectsForAffiliate" +
            "", RequestNamespace="http://www.codeplex.com/services/ProjectInfoService/v1.0", ResponseNamespace="http://www.codeplex.com/services/ProjectInfoService/v1.0", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Xml.XmlNode ListProjectsForAffiliate(string affiliateName) {
            object[] results = this.Invoke("ListProjectsForAffiliate", new object[] {
                        affiliateName});
            return ((System.Xml.XmlNode)(results[0]));
        }
        
        /// <remarks/>
        public void ListProjectsForAffiliateAsync(string affiliateName) {
            this.ListProjectsForAffiliateAsync(affiliateName, null);
        }
        
        /// <remarks/>
        public void ListProjectsForAffiliateAsync(string affiliateName, object userState) {
            if ((this.ListProjectsForAffiliateOperationCompleted == null)) {
                this.ListProjectsForAffiliateOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListProjectsForAffiliateOperationCompleted);
            }
            this.InvokeAsync("ListProjectsForAffiliate", new object[] {
                        affiliateName}, this.ListProjectsForAffiliateOperationCompleted, userState);
        }
        
        private void OnListProjectsForAffiliateOperationCompleted(object arg) {
            if ((this.ListProjectsForAffiliateCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ListProjectsForAffiliateCompleted(this, new ListProjectsForAffiliateCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.codeplex.com/services/ProjectInfoService/v1.0/CodePlexUserNameToTfsUse" +
            "rName", RequestNamespace="http://www.codeplex.com/services/ProjectInfoService/v1.0", ResponseNamespace="http://www.codeplex.com/services/ProjectInfoService/v1.0", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string CodePlexUserNameToTfsUserName(string UserName) {
            object[] results = this.Invoke("CodePlexUserNameToTfsUserName", new object[] {
                        UserName});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void CodePlexUserNameToTfsUserNameAsync(string UserName) {
            this.CodePlexUserNameToTfsUserNameAsync(UserName, null);
        }
        
        /// <remarks/>
        public void CodePlexUserNameToTfsUserNameAsync(string UserName, object userState) {
            if ((this.CodePlexUserNameToTfsUserNameOperationCompleted == null)) {
                this.CodePlexUserNameToTfsUserNameOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCodePlexUserNameToTfsUserNameOperationCompleted);
            }
            this.InvokeAsync("CodePlexUserNameToTfsUserName", new object[] {
                        UserName}, this.CodePlexUserNameToTfsUserNameOperationCompleted, userState);
        }
        
        private void OnCodePlexUserNameToTfsUserNameOperationCompleted(object arg) {
            if ((this.CodePlexUserNameToTfsUserNameCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CodePlexUserNameToTfsUserNameCompleted(this, new CodePlexUserNameToTfsUserNameCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.codeplex.com/services/ProjectInfoService/v1.0")]
    public partial class ProjectTfsInfo {
        
        private string tfsServerUrlField;
        
        private string projectPrefixField;
        
        /// <remarks/>
        public string TfsServerUrl {
            get {
                return this.tfsServerUrlField;
            }
            set {
                this.tfsServerUrlField = value;
            }
        }
        
        /// <remarks/>
        public string ProjectPrefix {
            get {
                return this.projectPrefixField;
            }
            set {
                this.projectPrefixField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433")]
    public delegate void GetTfsInfoForProjectCompletedEventHandler(object sender, GetTfsInfoForProjectCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetTfsInfoForProjectCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetTfsInfoForProjectCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ProjectTfsInfo Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ProjectTfsInfo)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433")]
    public delegate void ListProjectsForUserCompletedEventHandler(object sender, ListProjectsForUserCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ListProjectsForUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ListProjectsForUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433")]
    public delegate void ListProjectsForAffiliateCompletedEventHandler(object sender, ListProjectsForAffiliateCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ListProjectsForAffiliateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ListProjectsForAffiliateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Xml.XmlNode Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Xml.XmlNode)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433")]
    public delegate void CodePlexUserNameToTfsUserNameCompletedEventHandler(object sender, CodePlexUserNameToTfsUserNameCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CodePlexUserNameToTfsUserNameCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CodePlexUserNameToTfsUserNameCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591