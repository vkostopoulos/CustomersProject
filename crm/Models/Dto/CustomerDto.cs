using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace crm
{
    public class CustomerDto
    {
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Email { get; set; }
    }
}
