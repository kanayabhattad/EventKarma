using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventKarma.Data.Model;

namespace EventKarma.Data.MySql.Mapping
{
    public class UserPersonalProfileMap : AuditClassMap<UserPersonalProfile>
    {
        public UserPersonalProfileMap()
        {
            Table("user_personal_profile");
            LazyLoad();
            Id(x => x.Userid).GeneratedBy.Identity().Column("userid");
            Map(x => x.Gender).Column("gender");
            Map(x => x.Company).Column("company");
            Map(x => x.ProfilePictureLink).Column("profile_picture_link");
            Map(x => x.Title).Column("title");
            Map(x => x.BirthDate).Column("birth_date");
            Map(x => x.Age).Column("age");
            Map(x => x.FirstName).Column("first_name").Not.Nullable();
            Map(x => x.LastName).Column("last_name").Not.Nullable();
            Map(x => x.MiddleName).Column("middle_name");
            Map(x => x.DisplayName).Column("display_name");
            Map(x => x.Nickname).Column("nickname");
            Map(x => x.AboutMe).Column("about_me");
            Map(x => x.IsFeatured).Column("is_featured").Not.Nullable();
            Map(x => x.Credentials).Column("credentials");

        }
    }
}
