﻿using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using WebApplication.Services.Abstract;
using WebApplication.Services.Concrete;

namespace WebApplication.Services.Tests
{
    [TestFixture]
    public class ManufacturerServiceTests
    {

        private readonly IManufacturerService _manufacturerService;

        public ManufacturerServiceTests()
        {
            _manufacturerService =new ManufacturerService();
        }

        [SetUp]
        public void Setup()
        {
        }
        //todo: fix test
        [TestCase("488GTB", "FERRARI")]
        [TestCase("A8ハイブリッド", "AUDI")]
        [TestCase("エテルナ", "MITSUBISHI")]
        [TestCase("スプリンタートレノ", "TOYOTA")]
        [TestCase("パサートGTEヴァリアント", "VOLKSWAGEN")]
        public void CanIdentifyManufacturer(string value, string expected)
        {
            var result = _manufacturerService.GetManufacturerByModel(value);
            Assert.AreEqual(result, expected);
        }
    }
}
