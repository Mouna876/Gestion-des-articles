﻿namespace Gestion_des_articles.ViewModels
{
    public class EditViewModel : CreateViewModel
    {
        public int Id { get; set; }
        public string? ExistingImagePath { get; set; }
    }
}
