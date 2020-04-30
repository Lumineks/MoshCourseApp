using MoshCourseApp.Models;
using System.Collections.Generic;

namespace MoshCourseApp.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}
