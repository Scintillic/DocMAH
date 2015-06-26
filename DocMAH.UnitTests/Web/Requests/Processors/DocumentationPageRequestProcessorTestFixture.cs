﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DocMAH.Web.Html;
using DocMAH.Web.Requests;
using DocMAH.Web.Requests.Processors;
using NUnit.Framework;

namespace DocMAH.UnitTests.Web.Requests.Processors
{
	[TestFixture]
	public class DocumentationPageRequestProcessorTestFixture : BaseTestFixture
	{
		#region Tests

		[Test]
		[Description("Responds to a request for the documentation page.")]
		public void Process_Success()
		{
			// Arrange
			var testDocumentationContent = "Test documentation content.";

			var htmlBuilder = Mocks.Create<IHtmlBuilder>();
			htmlBuilder.Setup(b => b.CreateDocumentationPageHtml()).Returns(testDocumentationContent);

			var processor = new DocumentationPageRequestProcessor(htmlBuilder.Object);

			// Act
			var result = processor.Process(null);

			// Assert
			Assert.That(result, Is.Not.Null, "A valid ResponseState should be returned.");
			Assert.That(result.StatusCode, Is.EqualTo(HttpStatusCode.OK), "The request should be successful.");
			Assert.That(result.ContentType, Is.EqualTo(ContentTypes.Html), "The response should contain HTML.");
			Assert.That(result.Content, Is.EqualTo(testDocumentationContent), "The response content should contain the HtmlBuilder result.");
		}
		
		#endregion
	}
}
