using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CFAParserCodeEntities;
using CFAParserCodeServices;
using System.Web.Http;

namespace CFAParserCode.Controllers
{
    public class ParseController : ApiController
    {
        private IParseService _parseService;

        public ParseController(IParseService parseServicecs)
        {
            _parseService = parseServicecs;
        }

        // POST: api/Parse
        [HttpPost]
        [Route("api/Parse")]
        public IHttpActionResult Post(Parameter value)
        {
            if (value == null)
            {
                return BadRequest();
            }
            _parseService.SetInput(value.value);
            try
            {
                var group = _parseService.ParseGroup();
                Content content = new Content(group.Score(0), group.GargabeCharCount);
                return Ok(content);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }
    }
}