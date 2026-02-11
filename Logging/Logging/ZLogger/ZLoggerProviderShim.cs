using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Extensions.Logging;
using Il2CppSystem;

namespace ZLogger
{
	// Token: 0x02000007 RID: 7
	public class ZLoggerProviderShim : Object
	{
		// Token: 0x0600001F RID: 31 RVA: 0x00002B3C File Offset: 0x00000D3C
		// Note: this type is marked as 'beforefieldinit'.
		static ZLoggerProviderShim()
		{
			Il2CppClassPointerStore<ZLoggerProviderShim>.NativeClassPtr = IL2CPP.GetIl2CppClass("Logging.dll", "ZLogger", "ZLoggerProviderShim");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ZLoggerProviderShim>.NativeClassPtr);
			ZLoggerProviderShim.NativeMethodInfoPtr_CreateLogger_Public_Virtual_Final_New_ILogger_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZLoggerProviderShim>.NativeClassPtr, 100663316);
			ZLoggerProviderShim.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZLoggerProviderShim>.NativeClassPtr, 100663317);
			ZLoggerProviderShim.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZLoggerProviderShim>.NativeClassPtr, 100663318);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002BA8 File Offset: 0x00000DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271025, XrefRangeEnd = 1271029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ILogger CreateLogger(string categoryName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(categoryName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZLoggerProviderShim.NativeMethodInfoPtr_CreateLogger_Public_Virtual_Final_New_ILogger_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr3) : null;
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002BF8 File Offset: 0x00000DF8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZLoggerProviderShim.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002C2C File Offset: 0x00000E2C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ZLoggerProviderShim()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ZLoggerProviderShim>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZLoggerProviderShim.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000020F0 File Offset: 0x000002F0
		public ZLoggerProviderShim(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_CreateLogger_Public_Virtual_Final_New_ILogger_String_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
