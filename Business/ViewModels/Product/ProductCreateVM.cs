﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ViewModels.Product;

public class ProductCreateVM
{
    [Required(ErrorMessage = "Title is required")]
    [MinLength(2, ErrorMessage = "Must be at least 2 characters")]
    public string Title { get; set; }

    [Required(ErrorMessage = "Title is required")]
    public string Description { get; set; }

    [Required(ErrorMessage = "Price is required")]
    public decimal Price { get; set; }

    [Display(Name = "Stock Count")]
    [Required(ErrorMessage = "Stock count is required")]
    public int StockCount { get; set; }

    [Required(ErrorMessage = "Photo is required")]
    public IFormFile Photo { get; set; }

    [Required(ErrorMessage ="category is required")]
    public List<SelectListItem> Categories { get; set; }
    public List<int> CategoryIds { get; set; }
}
