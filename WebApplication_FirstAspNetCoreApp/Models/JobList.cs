namespace WebApplication_FirstAspNetCoreApp.Models
{
    public static class JobList
    {
        // hem classın hem de listenin newlenmesini istemiyoruz. sabit olmasını değişmemesini istiyoruz.,
        // o nedenle static yapıyoruz. Böylece içi devamlı sıfırlanamaz referansın.
        // Verilerimizi sabit tutacak bu class.
        // class ımız içerisinde verileri de liste halinde sabit tutacak bir field a sahip.

        public static List<Job> jobs = new List<Job>();
    }
}
