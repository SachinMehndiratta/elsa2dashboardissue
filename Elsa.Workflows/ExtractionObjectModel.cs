using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElsaTest.Workflows
{
    public class ExtractionObjectModel 
    {
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string ServerName { get; set; }

        //[MaxLength(10)]
        public int PortNumber { get; set; }

        [MaxLength(100)]
        public string UserName { get; set; }

        [MaxLength(128)]
        public string Password { get; set; }

        [MaxLength]
        public string TargetLocation { get; set; }

        [Required]
        public int ServerTypeId { get; set; }
        public string ServerTypeName { get; set; }
        public string RemotePath { get; set; }

        public string DirectoryName { get; set; }

    }
}
