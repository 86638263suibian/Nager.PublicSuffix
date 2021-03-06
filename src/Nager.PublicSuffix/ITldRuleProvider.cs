﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nager.PublicSuffix
{
    public interface ITldRuleProvider
    {
        /// <summary>
        /// Builds the list of TldRules
        /// </summary>
        /// <returns>List of TldRules</returns>
        Task<IEnumerable<TldRule>> BuildAsync();
    }
}
