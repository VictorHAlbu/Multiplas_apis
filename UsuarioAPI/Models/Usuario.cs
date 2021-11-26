using System; 
namespace UsuarioAPI.Models
{

  public class UsuarioAPI
  {
      public int Id {get;set;}
      public string Nome {get;set;}
      public string Email {get;set;}
      public int? IdEmpresa {get;set;}
      public DateTime DataCriacao {get;set;}
      public DateTime DataAtualizacao {get;set;}
  }

}