﻿// ==========================================================================
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex UG (haftungsbeschraenkt)
//  All rights reserved. Licensed under the MIT license.
// ==========================================================================

using Squidex.Domain.Apps.Core.Apps;
using Squidex.Infrastructure.Assets;

namespace Squidex.Domain.Apps.Entities.Apps.Commands
{
    public sealed class UploadAppImage : AppCommand
    {
        public AppImage Image { get; set; }

        public AssetFile File { get; set; }
    }
}