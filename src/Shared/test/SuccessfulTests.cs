// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.AspNetCore.Testing;
using Xunit;
using Xunit.Abstractions;

namespace AlwaysTestTests
{
    /// <summary>
    /// Tests for every test assembly to ensure quarantined and unquarantined runs report at least one test execution.
    /// </summary>
    public class SuccessfulTests
    {
        /// <summary>
        /// Test that executes in quarantined runs and always succeeds.
        /// </summary>
        [Fact]
        [QuarantinedTest]
        [SkipOnHelix("Intended to run locally.")]
        public void GuaranteedQuarantinedTest()
        {
        }

        /// <summary>
        /// Test that executes in unquarantined runs and always succeeds.
        /// </summary>
        /// <remarks><see cref="TraitAttribute"/> applied to ensure test runs even if assembly is quarantined overall.
        /// </remarks>
        [Fact]
        [Trait("Quarantined", "false")]
        [SkipOnHelix("Intended to run locally.")]
        public void GuarantinedUnquarantinedTest()
        {
        }
    }
}
