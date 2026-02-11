using System;
using Google.Apis.Logging;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google
{
	// Token: 0x02000002 RID: 2
	public static class ApplicationContext : Object
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000041A4 File Offset: 0x000023A4
		// Note: this type is marked as 'beforefieldinit'.
		static ApplicationContext()
		{
			Il2CppClassPointerStore<ApplicationContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Core.dll", "Google", "ApplicationContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ApplicationContext>.NativeClassPtr);
			ApplicationContext.NativeFieldInfoPtr_logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplicationContext>.NativeClassPtr, "logger");
			ApplicationContext.NativeMethodInfoPtr_Reset_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationContext>.NativeClassPtr, 100663297);
			ApplicationContext.NativeMethodInfoPtr_get_Logger_Public_Static_get_ILogger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationContext>.NativeClassPtr, 100663298);
			ApplicationContext.NativeMethodInfoPtr_RegisterLogger_Public_Static_Void_ILogger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationContext>.NativeClassPtr, 100663299);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00004224 File Offset: 0x00002424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209821, XrefRangeEnd = 1209825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Reset()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationContext.NativeMethodInfoPtr_Reset_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3 RVA: 0x0000424C File Offset: 0x0000244C
		public unsafe static ILogger Logger
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1209834, RefRangeEnd = 1209839, XrefRangeStart = 1209825, XrefRangeEnd = 1209834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationContext.NativeMethodInfoPtr_get_Logger_Public_Static_get_ILogger_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr3) : null;
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00004280 File Offset: 0x00002480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209839, XrefRangeEnd = 1209851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterLogger(ILogger loggerToRegister)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(loggerToRegister);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationContext.NativeMethodInfoPtr_RegisterLogger_Public_Static_Void_ILogger_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
		public ApplicationContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000006 RID: 6 RVA: 0x000042B8 File Offset: 0x000024B8
		// (set) Token: 0x06000007 RID: 7 RVA: 0x00002059 File Offset: 0x00000259
		public unsafe static ILogger logger
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ApplicationContext.NativeFieldInfoPtr_logger, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ApplicationContext.NativeFieldInfoPtr_logger, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeFieldInfoPtr_logger;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Static_Void_0;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr_get_Logger_Public_Static_get_ILogger_0;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr_RegisterLogger_Public_Static_Void_ILogger_0;
	}
}
