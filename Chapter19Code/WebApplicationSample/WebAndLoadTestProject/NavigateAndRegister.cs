﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAndLoadTestProject
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.WebTesting;
    using Microsoft.VisualStudio.TestTools.WebTesting.Rules;

    [DeploymentItem("")]
    [DataSource("DataSource1", "|DataDirectory|\aspnetusers.csv", "aspnetusers#csv")]
    public class NavigateAndRegister : WebTest
    {

        public NavigateAndRegister()
        {
            this.PreAuthenticate = true;
            this.Proxy = "default";
        }

        public override IEnumerator<WebTestRequest> GetRequestEnumerator()
        {
            // 初始化适用于 Web 测试中的所有请求的验证规则
            if ((this.Context.ValidationLevel >= Microsoft.VisualStudio.TestTools.WebTesting.ValidationLevel.Low))
            {
                ValidateResponseUrl validationRule1 = new ValidateResponseUrl();
                this.ValidateResponse += new EventHandler<ValidationEventArgs>(validationRule1.Validate);
            }
            if ((this.Context.ValidationLevel >= Microsoft.VisualStudio.TestTools.WebTesting.ValidationLevel.Low))
            {
                ValidationRuleResponseTimeGoal validationRule2 = new ValidationRuleResponseTimeGoal();
                validationRule2.Tolerance = 0D;
                this.ValidateResponseOnPageComplete += new EventHandler<ValidationEventArgs>(validationRule2.Validate);
            }

            WebTestRequest request1 = new WebTestRequest("https://localhost:44339/");
            request1.Headers.Add(new WebTestRequestHeader("Referer", "https://localhost:44339/"));
            yield return request1;
            request1 = null;

            WebTestRequest request2 = new WebTestRequest("https://localhost:44339/Home/About");
            request2.ThinkTime = 1;
            request2.Headers.Add(new WebTestRequestHeader("Referer", "https://localhost:44339/"));
            yield return request2;
            request2 = null;

            WebTestRequest request3 = new WebTestRequest("https://localhost:44339/Home/Contact");
            request3.ThinkTime = 1;
            request3.Headers.Add(new WebTestRequestHeader("Referer", "https://localhost:44339/Home/About"));
            yield return request3;
            request3 = null;

            WebTestRequest request4 = new WebTestRequest("https://localhost:44339/Account/Register");
            request4.ThinkTime = 23;
            request4.Headers.Add(new WebTestRequestHeader("Referer", "https://localhost:44339/Home/Contact"));
            ExtractHiddenFields extractionRule1 = new ExtractHiddenFields();
            extractionRule1.Required = true;
            extractionRule1.HtmlDecode = true;
            extractionRule1.ContextParameterName = "1";
            request4.ExtractValues += new EventHandler<ExtractionEventArgs>(extractionRule1.Extract);
            yield return request4;
            request4 = null;

            
            WebTestRequest request5 = new WebTestRequest("https://localhost:44339/Account/Register");
            request5.Method = "POST";
            request5.Headers.Add(new WebTestRequestHeader("Referer", "https://localhost:44339/Account/Register"));
            FormPostHttpBody request5Body = new FormPostHttpBody();
            //request5Body.FormPostParameters.Add("Email", "hao@jiawel.com");//模拟表单提交数据
            //request5Body.FormPostParameters.Add("Password", "nCb_123456");//模拟表单提交数据
            //request5Body.FormPostParameters.Add("ConfirmPassword", "nCb_123456");//模拟表单提交数据
            string email = this.Context["DataSource1.aspnetusers#csv.Email"].ToString();
            request5Body.FormPostParameters.Add("Email", this.Context["DataSource1.aspnetusers#csv.Email"].ToString());//模拟表单提交数据
            request5Body.FormPostParameters.Add("Password", "nCb_123456");//模拟表单提交数据
            request5Body.FormPostParameters.Add("ConfirmPassword", "nCb_123456");//模拟表单提交数据
            request5Body.FormPostParameters.Add("__RequestVerificationToken", this.Context["$HIDDEN1.__RequestVerificationToken"].ToString());
            request5.Body = request5Body;
            yield return request5;
            request5 = null;
        }
    }
}
