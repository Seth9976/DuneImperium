using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Extensions.Logging;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.DependencyInjection
{
	// Token: 0x0200000C RID: 12
	public static class LoggingServiceCollectionExtensions : Object
	{
		// Token: 0x06000035 RID: 53 RVA: 0x000021D6 File Offset: 0x000003D6
		// Note: this type is marked as 'beforefieldinit'.
		static LoggingServiceCollectionExtensions()
		{
			Il2CppClassPointerStore<LoggingServiceCollectionExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.Logging.dll", "Microsoft.Extensions.DependencyInjection", "LoggingServiceCollectionExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoggingServiceCollectionExtensions>.NativeClassPtr);
			LoggingServiceCollectionExtensions.NativeMethodInfoPtr_AddLogging_Public_Static_IServiceCollection_IServiceCollection_Action_1_ILoggingBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggingServiceCollectionExtensions>.NativeClassPtr, 100663314);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000031D0 File Offset: 0x000013D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263904, XrefRangeEnd = 1263934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IServiceCollection AddLogging(this IServiceCollection services, Action<ILoggingBuilder> configure)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(services);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(configure);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoggingServiceCollectionExtensions.NativeMethodInfoPtr_AddLogging_Public_Static_IServiceCollection_IServiceCollection_Action_1_ILoggingBuilder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IServiceCollection>(intPtr3) : null;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000220F File Offset: 0x0000040F
		public LoggingServiceCollectionExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_AddLogging_Public_Static_IServiceCollection_IServiceCollection_Action_1_ILoggingBuilder_0;
	}
}
