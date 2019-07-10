using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Practice.Domain;
using Practice.WebApi.Contracts.CodeContracts;
using Practice.WebApi.Services.CodeServices;
using Attribute = Practice.Domain.Attribute;

namespace Practice.WebApi.Controllers
{
	[Route("products/codes")]
	public class CodesController : AController
	{
		private ICodeService _codeService;

		public CodesController(CodeService codeService)
		{
			_codeService = codeService;
		}

		// GET: api/<controller>
		[HttpGet]
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}

		// GET api/<controller>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<controller>
		[HttpPost]
		public ActionResult<CodeContract> Post([FromBody] Code code)
		{			
			return _codeService.CreateCode(code);
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
