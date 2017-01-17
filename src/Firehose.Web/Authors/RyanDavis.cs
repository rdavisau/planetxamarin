﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class RyanDavis : IAmAXamarinMVP, IFilterMyBlogPosts
    {
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://ryandavis.io/rss/"); }
        }

        public string FirstName => "Ryan";
        public string LastName => "Davis";
        public string StateOrRegion => "Brisbane, Australia";
        public string EmailAddress => "ryandavis.au@gmail.com";
        public string Title => "IM, Analytics and Mobile Development 🎉";
        public Uri WebSite => new Uri("http://ryandavis.io");
        public string TwitterHandle => "rdavis_au";
        public DateTime FirstAwarded => new DateTime(2015, 1, 1);
        public string GravatarHash => "d351762ec451e252b20ff860dfcded91d351762ec451e252b20ff860dfcded91";

        public bool Filter(SyndicationItem item) => item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("xamarin"));
    }
}
