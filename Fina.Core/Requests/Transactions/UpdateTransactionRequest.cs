using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Fina.Core.Enums;

namespace Fina.Core.Requests.Transactions
{
    public class UpdateTransactionRequest
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "Titulo inválido")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Tipo inválido")]
        public ETransactionType Type { get; set; }
        
        [Required(ErrorMessage = "Valor inválido")]
        public decimal Amount { get; set; }
        
        [Required(ErrorMessage = "Categoria inválida")]
        public long CategoryId { get; set; }

        [Required(ErrorMessage = "Data inválida")]
        public DateTime? PaidOrReceived { get; set; }

    }
}