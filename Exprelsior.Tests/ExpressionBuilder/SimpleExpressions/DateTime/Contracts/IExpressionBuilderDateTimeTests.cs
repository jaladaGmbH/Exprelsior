﻿namespace Exprelsior.Tests.ExpressionBuilder.SimpleExpressions.DateTime.Contracts
{
    using System;
    using Exprelsior.ExpressionBuilder.Enums;
    using Xunit;

    // ReSharper disable InconsistentNaming

    /// <summary>
    ///     Provides methods for unit testing the expression builder with focus on <see cref="DateTime"/> values.
    /// </summary>
    public interface IExpressionBuilderDateTimeTests
    {
        // DateTime

        /// <summary>
        ///     Asserts that an <see cref="DateTime"/> <see cref="ExpressionOperator.Equal"/> expression is generated correctly.
        /// </summary>
        [Fact]
        void Assert_DateTime_Equality_Expression_Is_Generated_Correctly();

        /// <summary>
        ///     Asserts that an <see cref="DateTime"/> <see cref="ExpressionOperator.NotEqual"/> expression is generated correctly.
        /// </summary>
        [Fact]
        void Assert_DateTime_Inequality_Expression_Is_Generated_Correctly();

        /// <summary>
        ///     Asserts that an <see cref="DateTime"/> <see cref="ExpressionOperator.LessThan"/> expression is generated correctly.
        /// </summary>
        [Fact]
        void Assert_DateTime_Less_Than_Expression_Is_Generated_Correctly();

        /// <summary>
        ///     Asserts that an <see cref="DateTime"/> <see cref="ExpressionOperator.LessThanOrEqual"/> expression is generated correctly.
        /// </summary>
        [Fact]
        void Assert_DateTime_Less_Than_Or_Equal_Expression_Is_Generated_Correctly();

        /// <summary>
        ///     Asserts that an <see cref="DateTime"/> <see cref="ExpressionOperator.GreaterThan"/> expression is generated correctly.
        /// </summary>
        [Fact]
        void Assert_DateTime_Greater_Than_Expression_Is_Generated_Correctly();

        /// <summary>
        ///     Asserts that an <see cref="DateTime"/> <see cref="ExpressionOperator.GreaterThanOrEqual"/> expression is generated correctly.
        /// </summary>
        [Fact]
        void Assert_DateTime_Greater_Than_Or_Equal_Expression_Is_Generated_Correctly();

        /// <summary>
        ///     Asserts that an <see cref="DateTime"/> <see cref="ExpressionOperator.LessThanOrEqual"/> on value expression is generated correctly.
        /// </summary>
        [Fact]
        void Assert_DateTime_Contains_On_Value_Expression_Is_Generated_Correctly();

        // DateTime Array

        /// <summary>
        ///     Asserts that an array of <see cref="DateTime"/> <see cref="ExpressionOperator.Equal"/> expression is generated correctly.
        /// </summary>
        [Fact]
        void Assert_DateTime_Array_Equality_Expression_Is_Generated_Correctly();

        /// <summary>
        ///     Asserts that an array of <see cref="DateTime"/> <see cref="ExpressionOperator.NotEqual"/> expression is generated correctly.
        /// </summary>
        [Fact]
        void Assert_DateTime_Array_Inequality_Expression_Is_Generated_Correctly();

        /// <summary>
        ///     Asserts that an array of <see cref="DateTime"/> <see cref="ExpressionOperator.Equal"/> expression with an list of values is generated correctly.
        /// </summary>
        [Fact]
        void Assert_DateTime_Array_Equality_Expression_With_List_Value_Is_Generated_Correctly();

        /// <summary>
        ///     Asserts that an array of <see cref="DateTime"/> <see cref="ExpressionOperator.NotEqual"/> expression with an list of values is generated correctly.
        /// </summary>
        [Fact]
        void Assert_DateTime_Array_Inequality_Expression_With_List_Value_Is_Generated_Correctly();

        /// <summary>
        ///     Asserts that an array of <see cref="DateTime"/> <see cref="ExpressionOperator.Contains"/> single value expression is generated correctly.
        /// </summary>
        [Fact]
        void Assert_DateTime_Array_Contains_Single_Value_Expression_Is_Generated_Correctly();

        // DateTime Collection

        /// <summary>
        ///     Asserts that an collection of <see cref="DateTime"/> <see cref="ExpressionOperator.Equal"/> expression is generated correctly.
        /// </summary>
        [Fact]
        void Assert_DateTime_Collection_Equality_Expression_Is_Generated_Correctly();

        /// <summary>
        ///     Asserts that an collection of <see cref="DateTime"/> <see cref="ExpressionOperator.NotEqual"/> expression is generated correctly.
        /// </summary>
        [Fact]
        void Assert_DateTime_Collection_Inequality_Expression_Is_Generated_Correctly();

        /// <summary>
        ///     Asserts that an collection of <see cref="DateTime"/> <see cref="ExpressionOperator.Equal"/> expression with an array of values is generated correctly.
        /// </summary>
        [Fact]
        void Assert_DateTime_Collection_Equality_Expression_With_Array_Value_Is_Generated_Correctly();

        /// <summary>
        ///     Asserts that an collection of <see cref="DateTime"/> <see cref="ExpressionOperator.NotEqual"/> expression with an array of values is generated correctly.
        /// </summary>
        [Fact]
        void Assert_DateTime_Collection_Inequality_Expression_With_Array_Value_Is_Generated_Correctly();

        /// <summary>
        ///     Asserts that an collection of <see cref="DateTime"/> <see cref="ExpressionOperator.Contains"/> single value expression is generated correctly.
        /// </summary>
        [Fact]
        void Assert_DateTime_Collection_Contains_Single_Value_Expression_Is_Generated_Correctly();
    }
}
