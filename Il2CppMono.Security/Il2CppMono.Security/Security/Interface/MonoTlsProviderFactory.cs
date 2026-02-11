using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Security.Interface
{
	// Token: 0x0200002B RID: 43
	public static class MonoTlsProviderFactory : Object
	{
		// Token: 0x06000251 RID: 593 RVA: 0x00002F8E File Offset: 0x0000118E
		// Note: this type is marked as 'beforefieldinit'.
		static MonoTlsProviderFactory()
		{
			Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Interface", "MonoTlsProviderFactory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr);
			MonoTlsProviderFactory.NativeMethodInfoPtr_GetProvider_Public_Static_MonoTlsProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, 100663642);
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0000CE74 File Offset: 0x0000B074
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1149382, RefRangeEnd = 1149385, XrefRangeStart = 1149379, XrefRangeEnd = 1149382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MonoTlsProvider GetProvider()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsProviderFactory.NativeMethodInfoPtr_GetProvider_Public_Static_MonoTlsProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoTlsProvider>(intPtr3) : null;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00002FC7 File Offset: 0x000011C7
		public MonoTlsProviderFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002CD RID: 717
		private static readonly IntPtr NativeMethodInfoPtr_GetProvider_Public_Static_MonoTlsProvider_0;
	}
}
