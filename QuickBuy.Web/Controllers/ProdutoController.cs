﻿using Microsoft.AspNetCore.Mvc;
using QuickBuy.Dominio.Contratos;
using QuickBuy.Dominio.Entidades;
using System;

namespace QuickBuy.Web.Controllers
{
    [Route("api/[controller]")]
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepositorio _produtoRepositorio;
        public ProdutoController(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(_produtoRepositorio.ObterTodos());
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        public ActionResult Post([FromBody]Produto produto)
        {
            try
            {
                _produtoRepositorio.Adicionar(produto);
                return Created("api/produto", produto);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
