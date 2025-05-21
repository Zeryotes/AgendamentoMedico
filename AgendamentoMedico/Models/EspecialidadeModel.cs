using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendamentoMedico.Models;

public class EspecialidadeModel
{
    public EspecialidadeModel(String nome)
    {
        Nome = nome;
    }
    
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Nome { get; private set; }

}