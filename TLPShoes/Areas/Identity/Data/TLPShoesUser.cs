using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;

namespace TLPShoes.Areas.Identity.Data;

// Add profile data for application users by adding properties to the TLPShoesUser class
public class TLPShoesUser : IdentityUser
{
    [PersonalData]
    [Column(TypeName = "nvarchar(100)")]
    public string Role { get; set; }

    [PersonalData]
    [Column(TypeName = "nvarchar(100)")]
    public string Company { get; set; }

}

