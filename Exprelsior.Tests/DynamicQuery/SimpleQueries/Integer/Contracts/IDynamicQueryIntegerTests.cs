﻿namespace Exprelsior.Tests.DynamicQuery.SimpleQueries.Integer.Contracts
{
    using Exprelsior.ExpressionBuilder.Enums;
    using Xunit;

    // ReSharper disable InconsistentNaming

    /// <summary>
    ///     Provides methods for unit testing the expression builder with focus on <see cref="int"/> values.
    /// </summary>
    public interface IDynamicQueryIntegerTests
    {
        // DateTime

        /// <summary>
        ///     Asserts that an <see cref="int"/> <see cref="ExpressionOperator.Equal"/> expression is generated correctly.
        /// </summary>
        [Fact]
        void Assert_Integer_Equality_Dynamic_Query_Expression_Is_Generated_Correctly();

        /// <summary>
        ///     Asserts that an <see cref="int"/> <see cref="ExpressionOperator.NotEqual"/> expression is generated correctly.
        /// </summary>
        [Fact]
        void Assert_Integer_Inequality_Dynamic_Query_Expression_Is_Generated_Correctly();

        /// <summary>
        ///     Asserts that an <see cref="int"/> <see cref="ExpressionOperator.LessThan"/> expression is generated correctly.
        /// </summary>
        [Fact]
        void Assert_Integer_Less_Than_Dynamic_Query_Expression_Is_Generated_Correctly();

        /// <summary>
        ///     Asserts that an <see cref="int"/> <see cref="ExpressionOperator.LessThanOrEqual"/> expression is generated correctly.
        /// </summary>
        [Fact]
        void Assert_Integer_Less_Than_Or_Equal_Dynamic_Query_Expression_Is_Generated_Correctly();

        /// <summary>
        ///     Asserts that an <see cref="int"/> <see cref="ExpressionOperator.GreaterThan"/> expression is generated correctly.
        /// </summary>
        [Fact]
        void Assert_Integer_Greater_Than_Dynamic_Query_Expression_Is_Generated_Correctly();

        /// <summary>
        ///     Asserts that an <see cref="int"/> <see cref="ExpressionOperator.GreaterThanOrEqual"/> expression is generated correctly.
        /// </summary>
        [Fact]
        void Assert_Integer_Greater_Than_Or_Equal_Dynamic_Query_Expression_Is_Generated_Correctly();

        /// <summary>
        ///     Asserts that an <see cref="int"/> <see cref="ExpressionOperator.LessThanOrEqual"/> on value expression is generated correctly.
        /// </summary>
        [Fact]
        void Assert_Integer_Contains_On_Value_Dynamic_Query_Expression_Is_Generated_Correctly();

        // DateTime Array

        /// <summary>
        ///     Asserts that an array of <see cref="int"/> <see cref="ExpressionOperator.Equal"/> expression is generated correctly.
        /// </summary>
        [Fact]
        void Assert_Integer_Array_Equality_Dynamic_Query_Expression_Is_Generated_Correctly();

        /// <summary>
        ///     Asserts that an array of <see cref="int"/> <see cref="ExpressionOperator.NotEqual"/> expression is generated correctly.
        /// </summary>
        [Fact]
        void Assert_Integer_Array_Inequality_Dynamic_Query_Expression_Is_Generated_Correctly();

        /// <summary>
        ///     Asserts that an array of <see cref="int"/> <see cref="ExpressionOperator.Equal"/> expression with an list of values is generated correctly.
        /// </summary>
        [Fact]
        void Assert_Integer_Array_Equality_Expression_With_List_Value_Is_Generated_Correctly();

        /// <summary>
        ///     Asserts that an array of <see cref="int"/> <see cref="ExpressionOperator.NotEqual"/> expression with an list of values is generated correctly.
        /// </summary>
        [Fact]
        void Assert_Integer_Array_Inequality_Expression_With_List_Value_Is_Generated_Correctly();

        /// <summary>
        ///     Asserts that an array of <see cref="int"/> <see cref="ExpressionOperator.Contains"/> single value expression is generated correctly.
        /// </summary>
        [Fact]
        void Assert_Integer_Array_Contains_Single_Value_Dynamic_Query_Expression_Is_Generated_Correctly();

        // DateTime Collection

        /// <summary>
        ///     Asserts that an collection of <see cref="int"/> <see cref="ExpressionOperator.Equal"/> expression is generated correctly.
        /// </summary>
        [Fact]
        void Assert_Integer_Collection_Equality_Dynamic_Query_Expression_Is_Generated_Correctly();

        /// <summary>
        ///     Asserts that an collection of <see cref="int"/> <see cref="ExpressionOperator.NotEqual"/> expression is generated correctly.
        /// </summary>
        [Fact]
        void Assert_Integer_Collection_Inequality_Dynamic_Query_Expression_Is_Generated_Correctly();

        /// <summary>
        ///     Asserts that an collection of <see cref="int"/> <see cref="ExpressionOperator.Equal"/> expression with an array of values is generated correctly.
        /// </summary>
        [Fact]
        void Assert_Integer_Collection_Equality_Expression_With_Array_Value_Is_Generated_Correctly();

        /// <summary>
        ///     Asserts that an collection of <see cref="int"/> <see cref="ExpressionOperator.NotEqual"/> expression with an array of values is generated correctly.
        /// </summary>
        [Fact]
        void Assert_Integer_Collection_Inequality_Expression_With_Array_Value_Is_Generated_Correctly();

        /// <summary>
        ///     Asserts that an collection of <see cref="int"/> <see cref="ExpressionOperator.Contains"/> single value expression is generated correctly.
        /// </summary>
        [Fact]
        void Assert_Integer_Collection_Contains_Single_Value_Dynamic_Query_Expression_Is_Generated_Correctly();
    }
}
