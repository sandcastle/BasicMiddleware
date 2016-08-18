﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Http;

namespace Microsoft.AspNetCore.Rewrite.Internal.UrlActions
{
    public class VoidAction : UrlAction
    {
        // Explicitly say that nothing happens
        public override RuleResult ApplyAction(RewriteContext context, MatchResults ruleMatch, MatchResults condMatch)
        {
            return RuleResult.Continue;
        }
    }
}