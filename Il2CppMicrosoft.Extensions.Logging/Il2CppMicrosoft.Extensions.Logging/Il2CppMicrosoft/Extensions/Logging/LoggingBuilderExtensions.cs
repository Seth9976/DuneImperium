using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.Logging
{
	// Token: 0x0200001A RID: 26
	public static class LoggingBuilderExtensions : Object
	{
		// Token: 0x060000CC RID: 204 RVA: 0x00002717 File Offset: 0x00000917
		// Note: this type is marked as 'beforefieldinit'.
		static LoggingBuilderExtensions()
		{
			Il2CppClassPointerStore<LoggingBuilderExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.Logging.dll", "Microsoft.Extensions.Logging", "LoggingBuilderExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoggingBuilderExtensions>.NativeClassPtr);
			LoggingBuilderExtensions.NativeMethodInfoPtr_SetMinimumLevel_Public_Static_ILoggingBuilder_ILoggingBuilder_LogLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggingBuilderExtensions>.NativeClassPtr, 100663375);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000051AC File Offset: 0x000033AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1264410, RefRangeEnd = 1264412, XrefRangeStart = 1264397, XrefRangeEnd = 1264410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ILoggingBuilder SetMinimumLevel(this ILoggingBuilder builder, LogLevel level)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoggingBuilderExtensions.NativeMethodInfoPtr_SetMinimumLevel_Public_Static_ILoggingBuilder_ILoggingBuilder_LogLevel_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ILoggingBuilder>(intPtr3) : null;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002750 File Offset: 0x00000950
		public LoggingBuilderExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr_SetMinimumLevel_Public_Static_ILoggingBuilder_ILoggingBuilder_LogLevel_0;
	}
}
