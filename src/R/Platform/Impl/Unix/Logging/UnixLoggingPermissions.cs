﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using Microsoft.Common.Core.Logging;

namespace Microsoft.R.Platform.Logging {
    public sealed class UnixLoggingPermissions: ILoggingPermissions {
        public LogVerbosity CurrentVerbosity { get; set; } = LogVerbosity.Traffic;
        public bool IsFeedbackPermitted => true;
        public LogVerbosity MaxVerbosity => LogVerbosity.Traffic;
    }
}
