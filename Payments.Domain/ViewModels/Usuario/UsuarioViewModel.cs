using System;
using System.Collections.Generic;
using Payments.Domain.Enums;

namespace Payments.Domain.ViewModels;

public class UsuarioViewModel
{
    public int Id { get; set; }
    public string ClientIdPaymentGateway { get; set; }
    public string CPF { get; set; }
    public string Contato { get; set; }
    public string Email { get; set; }
    public string PrimeiroNome { get; set; }
    public string UltimoNome { get; set; }
    public PerfilEnum Perfil { get; set; }
    public int PlanoId { get; set; }
    public bool UsuarioValidado { get; set; }
    public int? EnderecoPrincipalId { get; set; }
    public string Senha { get; set; }
    public string RefreshToken { get; set; }
    public DateTime RefreshTokenExpiryTime { get; set; }
    public int EmpresaId { get; set; }

    public virtual IList<AlunoViewModel> Alunos { get; set; }
}