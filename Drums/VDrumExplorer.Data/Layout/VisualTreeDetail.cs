﻿// Copyright 2019 Jon Skeet. All rights reserved.
// Use of this source code is governed by the Apache License 2.0,
// as found in the LICENSE.txt file.

using System;
using System.Collections.Generic;
using VDrumExplorer.Data.Fields;

namespace VDrumExplorer.Data.Layout
{
    /// <summary>
    /// An element of the details to display when a <see cref="VisualTreeNode"/> is selected.
    /// </summary>
    public sealed class VisualTreeDetail
    {
        /// <summary>
        /// Description of this aspect of the details.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// A container to display as a group of fields.
        /// May be null, in which case <see cref="DetailDescriptions"/> will not be null.
        /// </summary>
        public FixedContainer? Container { get; }

        /// <summary>
        /// A list of formattable descriptions. May be null, in which case <see cref="Container"/>
        /// will not be null.
        /// </summary>
        public IReadOnlyList<FormattableDescription>? DetailDescriptions { get; }

        public VisualTreeDetail(string description, FixedContainer container) =>
            (Description, Container, DetailDescriptions) = (description, container, null);

        public VisualTreeDetail(string description, IReadOnlyList<FormattableDescription> formatElements) =>
            (Description, Container, DetailDescriptions) = (description, null, formatElements);
    }
}
