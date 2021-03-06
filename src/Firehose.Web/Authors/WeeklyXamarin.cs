using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;

namespace Firehose.Web.Authors
{
    public class WeeklyXamarin : IAmACommunityMember
    {
        public string FirstName => "Weekly";

        public string LastName => "Xamarin";

        public string StateOrRegion => "Internet";

        public string EmailAddress => "inbox@weeklyxamarin.com";

        public string Title => "Newsletter";

        public Uri WebSite => new Uri("https://www.weeklyxamarin.com");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://weeklyxamarin.com/issues.rss"); }
        }

        public string TwitterHandle => "weeklyxamarin";


        public string GravatarHash => "";
    }
}
