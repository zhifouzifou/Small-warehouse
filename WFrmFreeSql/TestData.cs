using FreeSql.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace WFrmFreeSql
{
    [Table(Name = "TestData")]
    public class TestData
    {
        [Column(IsPrimary = true)]
        public string Id { get; set; } = string.Empty;

        public string Names { get; set; } = string.Empty;

        public string Sex { get; set; } = string.Empty;

        public int Age { get; set; } = 0;

        public string Score { get; set; } = string.Empty;


    }
}
