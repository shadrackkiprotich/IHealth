using System;
using System.Collections.Generic;
using System.Text;

namespace IHealth.Models
{
    public enum MenuItemType
    {
        Home,
        ProfesionalPage,
        About,
        DisplayPage,
        FeedbackPage,
        SignUpPage
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
