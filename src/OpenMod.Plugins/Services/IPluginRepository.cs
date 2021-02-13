﻿using System.Collections.Generic;
using System.Threading.Tasks;
using OpenMod.Plugins.Data;

namespace OpenMod.Plugins.Services
{
    public interface IPluginRepository
    {
        Task<IReadOnlyList<Plugin>> SearchAsync(string query, int skip, int take, bool includePrerelease);
    }
}
