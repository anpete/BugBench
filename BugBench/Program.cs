// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QueryExample.EntityFramework;

namespace BugBench
{
    public class Program
    {
#pragma warning disable 1998
        public static async Task Main()
#pragma warning restore 1998
        {
            var context = new QueryExampleContext();

            var userId = 1;

            var competitions = await context.Competitions
                .Include(c => c.Quest).ThenInclude(q => q.QuestTags)
                .OrderByDescending(c => c.Passes.Max(qp => qp.CreatedAt))
                .ToListAsync();

            foreach (var competition in competitions)
                Console.WriteLine("My friend passed quest '{0}' which has {1} likes", competition.Quest.Name, competition.LikeCount);
        }
    }
}
