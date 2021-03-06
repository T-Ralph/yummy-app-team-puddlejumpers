using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FluentValidation;

namespace Api.Models
{

  [Table("Meals")]
  public class Meal {

    [Key]
    [Column(TypeName = "int(10)")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Required]
    [Column(TypeName = "int(10)")]
    public int PlanId { get; set; }
    
    [Required]    
    [Column(TypeName = "int(10)")]
    public int MealTimeId { get; set; }

    
    public virtual ICollection<MealRecipe> MealRecipes { get; set; } = new HashSet<MealRecipe>();
    
    public virtual MealTime MealTime { get; set; }

    public Meal()
    {
    }


  }
}
