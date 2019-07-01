using Microsoft.AspNetCore.Mvc;
using Practice.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Practice.WebApi.Controllers
{
	[Route("api/[controller]")]
	public class CodeController : Controller
	{
		DomainContext _context;
		public CodeController(DomainContext context)
		{
			_context = context;
			/*
			_context.Attributes.Add(new Domain.Attribute { Value="sdasd", Title="asdasd", Comment="asdasdasd", TypeId="555"});
			_context.SaveChanges();*/

		}

		// GET: api/<controller>
		[HttpGet]
		public IEnumerable<Domain.Attribute> GetCode()
		{
			Domain.Attribute atr = new Domain.Attribute { Value = "sdasd", Title = "asdasd", Comment = "asdasdasd", TypeId = "555" };
			


			IEnumerable<Domain.Attribute> attributes = _context.Attributes.ToList();
			
			return attributes;
		}

		// GET api/<controller>/5
		[HttpGet("{id}")]
		public string Get(string id)
		{
			Domain.Attribute prod = _context.Attributes.Find("3c22fe2f386f420ea6e0d79fa6358a82");
			return prod.Title;
			//return "value";
		}

		// POST api/<controller>
		[HttpPost]
		public void Post([FromBody]string value)
		{
		}

		// PUT api/<controller>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody]string value)
		{
		}

		// DELETE api/<controller>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
