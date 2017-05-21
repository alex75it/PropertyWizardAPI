﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using PropertyWizard.DataAccess.Entities;
using PropertyWizard.WebApiDataAccess.Repositories;
using System.Web.Http.Cors;

namespace PropertyWizard.WebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("postcode")]
    public class PostCodeController : ControllerBase
    {
        private readonly PostCodeRepository repository;

        //public PostCodeController(PostCodeRepository repository) {
        //    this.repository = repository;
        //}

        public PostCodeController() {
            this.repository = new PostCodeRepository();
        }

        // GET postcode
        public IEnumerable<PostCode> GetList()
        {
            logger.Info("GetList");
            var list = repository.List();

            return list;
        }

        // GET postcode/SE17
        [Route("{code}")]
        public PostCode Get(string code)
        {
            logger.Info("Get(code)");
            var postcode = repository.Get(code);
            return postcode;
        }

        // POST api/postcode
        public void Post([FromBody]string value)
        {
        }

        // PUT api/postcode/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/postcode/5
        public void Delete(int id)
        {
        }
    }
}