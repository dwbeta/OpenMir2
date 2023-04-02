using System;

namespace TouchSocket.Core;

/// <summary>
/// 标识插件只能注册一次。
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
public sealed class SingletonPluginAttribute : Attribute
{
}