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
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Neuroglia.AsyncApi.Client.Services
{
    /// <summary>
    /// Defines the fundamentals of an Async API channel
    /// </summary>
    public interface IChannel
        : IObservable<IMessage>, IDisposable
    {

        /// <summary>
        /// Gets the <see cref="IChannel"/>'s key
        /// </summary>
        string Key { get; }

        /// <summary>
        /// Gets the <see cref="IChannel"/>'s definition
        /// </summary>
        ChannelDefinition Definition { get; }

        /// <summary>
        /// Gets the <see cref="IChannel"/>'s default content type
        /// </summary>
        string DefaultContentType { get; }

        /// <summary>
        /// Publishes the specified <see cref="IMessage"/>
        /// </summary>
        /// <param name="message">The <see cref="IMessage"/> to publish</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/></param>
        /// <returns>A new awaitable <see cref="Task"/></returns>
        Task PublishAsync(IMessage message, CancellationToken cancellationToken = default);

    }

}
