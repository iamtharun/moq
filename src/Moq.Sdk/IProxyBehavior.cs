﻿namespace Moq.Sdk
{
    /// <summary>
    /// A configured behavior for a proxy.
    /// </summary>
	public interface IProxyBehavior
	{
        /// <summary>
        /// Invocation behavior for the proxy.
        /// </summary>
        /// <param name="invocation">The current method invocation.</param>
        /// <param name="getNext">Delegate to invoke the next behavior in the pipeline.</param>
        /// <returns>The result of the method invocation.</returns>
		IMethodReturn Invoke(IMethodInvocation invocation, GetNextBehavior getNext);
	}

    /// <summary>
    /// Method signature for getting the next behavior in a pipeline.
    /// </summary>
    /// <returns>The delegate to invoke the next behavior in a pipeline.</returns>
	public delegate InvokeBehavior GetNextBehavior();

    /// <summary>
    /// Method signature for invoking the next behavior in a pipeline.
    /// </summary>
    /// <param name="invocation">The current method invocation.</param>
    /// <param name="getNext">Delegate to invoke the next behavior in the pipeline.</param>
    /// <returns>The result of the method invocation.</returns>
    public delegate IMethodReturn InvokeBehavior(IMethodInvocation invocation, GetNextBehavior getNext);
}