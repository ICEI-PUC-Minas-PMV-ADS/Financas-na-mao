using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinancasNaMaoMVC.Models;
using Microsoft.AspNetCore.Identity;

namespace FinancasNaMaoMVC.Areas.Identity.Data;

// Add profile data for application users by adding properties to the Usuario class
public class Usuario : IdentityUser
{
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string Contato { get; set; }
    public bool isUsuarioAtivo { get; set; } = true;
    public int? Saldo { get; set; } = 0;
    public decimal? Corrente { get; set; } = 0;
    public decimal? Poupanca { get; set; } = 0;
}

