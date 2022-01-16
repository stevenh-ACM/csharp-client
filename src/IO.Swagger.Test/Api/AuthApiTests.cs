/* 
 * Some version
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing AuthApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AuthApiTests
    {
        private AuthApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AuthApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AuthApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AuthApi
            //Assert.IsInstanceOfType(typeof(AuthApi), instance, "instance is a AuthApi");
        }

        
        /// <summary>
        /// Test AuthLogin
        /// </summary>
        [Test]
        public void AuthLoginTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Credentials credentials = null;
            //instance.AuthLogin(credentials);
            
        }
        
        /// <summary>
        /// Test AuthLogout
        /// </summary>
        [Test]
        public void AuthLogoutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.AuthLogout();
            
        }
        
    }

}