using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.DependencyInjection
{
	// Token: 0x0200000C RID: 12
	public static class OptionsServiceCollectionExtensions : Object
	{
		// Token: 0x0600002E RID: 46 RVA: 0x000021BE File Offset: 0x000003BE
		// Note: this type is marked as 'beforefieldinit'.
		static OptionsServiceCollectionExtensions()
		{
			Il2CppClassPointerStore<OptionsServiceCollectionExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.Options.dll", "Microsoft.Extensions.DependencyInjection", "OptionsServiceCollectionExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionsServiceCollectionExtensions>.NativeClassPtr);
			OptionsServiceCollectionExtensions.NativeMethodInfoPtr_AddOptions_Public_Static_IServiceCollection_IServiceCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsServiceCollectionExtensions>.NativeClassPtr, 100663308);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002F30 File Offset: 0x00001130
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1265668, RefRangeEnd = 1265670, XrefRangeStart = 1265624, XrefRangeEnd = 1265668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IServiceCollection AddOptions(this IServiceCollection services)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(services);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionsServiceCollectionExtensions.NativeMethodInfoPtr_AddOptions_Public_Static_IServiceCollection_IServiceCollection_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IServiceCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000021F7 File Offset: 0x000003F7
		public OptionsServiceCollectionExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_AddOptions_Public_Static_IServiceCollection_IServiceCollection_0;
	}
}
