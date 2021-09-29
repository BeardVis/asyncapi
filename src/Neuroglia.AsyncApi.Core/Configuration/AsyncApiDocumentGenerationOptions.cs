﻿/*
 * Copyright © 2021 Neuroglia SPRL. All rights reserved.
 * <p>
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * <p>
 * http://www.apache.org/licenses/LICENSE-2.0
 * <p>
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */
using Neuroglia.AsyncApi.Models;
using Neuroglia.AsyncApi.Services.FluentBuilders;
using System;

namespace Neuroglia.AsyncApi.Configuration
{

    /// <summary>
    /// Represents the options used to configure <see cref="AsyncApiDocument"/> generation
    /// </summary>
    public class AsyncApiDocumentGenerationOptions
    {

        /// <summary>
        /// Gets/sets an <see cref="Action{T}"/> used to configure the <see cref="AsyncApiDocument"/>s to configure
        /// </summary>
        public Action<IAsyncApiDocumentBuilder> DefaultConfiguration { get; set; }

        /// <summary>
        /// Gets/sets a boolean indicating whether or not the automatically generate examples. Defaults to true.
        /// </summary>
        public bool AutomaticallyGenerateExamples { get; set; } = true;

    }

}
