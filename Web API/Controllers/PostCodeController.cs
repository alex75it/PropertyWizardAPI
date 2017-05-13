﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using PropertyWizard.DataAccess.Entities;
using PropertyWizard.WebApiDataAccess.Repositories;

namespace PropertyWizard.WebApi.Controllers
{
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

        // GET api/postcode
        public IEnumerable<PostCode> Get()
        {
            var list = repository.List();

            return list;
        }

        // GET api/postcode/SE17
        public PostCode Get(string code)
        {
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