﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication_FirstAspNetCoreApp.Models
{
    public class Job
    {
        [Display(Name = "Özet")] // bunun çalışması için view'da ilgili  label içindeki açıklamanın silinmesi lazım.
        // Uyarıları türkçe olarak görmek istersek ErrorMessage = " " demek suretiyle çift tırnak içerisine mesajlarımızı yazarak gösterebiliriz.
        [Required(ErrorMessage = "Özet alanı boş geçilemez"), 
         StringLength(300, MinimumLength =50, ErrorMessage = "Maksimum 300, minimum 50 karakter olmalıdır.")] 
        // yukarıdaki attribute'ları ayrı ayrı da yazabiliriz.

        public string Summary { get; set; }

        [Display(Name = "Açıklama")]
        [MaxLength(300)]
        public string Description { get; set; }

        [Display(Name = "Tamamlandı mı?")]
        public bool Completed { get; set; }

        [Display(Name ="Göreve atanan çalışan")]
        [Required]
        public string Assignee { get; set; }
    }
}
