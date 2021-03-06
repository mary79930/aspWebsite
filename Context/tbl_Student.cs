//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace AspWebsite.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tbl_Student
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Fname { get; set; }

        [Required(ErrorMessage = "Required")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Required")]
        [MinLength(10,ErrorMessage ="Mobile No should be 10 digit")]
        public string Mobile { get; set; }

        public string Description { get; set; }
    }
}
