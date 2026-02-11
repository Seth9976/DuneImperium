using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.DependencyInjection
{
	// Token: 0x0200000F RID: 15
	public static class ServiceCollectionContainerBuilderExtensions : Object
	{
		// Token: 0x06000075 RID: 117 RVA: 0x00004EC4 File Offset: 0x000030C4
		// Note: this type is marked as 'beforefieldinit'.
		static ServiceCollectionContainerBuilderExtensions()
		{
			Il2CppClassPointerStore<ServiceCollectionContainerBuilderExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.DependencyInjection.dll", "Microsoft.Extensions.DependencyInjection", "ServiceCollectionContainerBuilderExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServiceCollectionContainerBuilderExtensions>.NativeClassPtr);
			ServiceCollectionContainerBuilderExtensions.NativeMethodInfoPtr_BuildServiceProvider_Public_Static_ServiceProvider_IServiceCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCollectionContainerBuilderExtensions>.NativeClassPtr, 100663375);
			ServiceCollectionContainerBuilderExtensions.NativeMethodInfoPtr_BuildServiceProvider_Public_Static_ServiceProvider_IServiceCollection_ServiceProviderOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCollectionContainerBuilderExtensions>.NativeClassPtr, 100663376);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00004F1C File Offset: 0x0000311C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1203426, RefRangeEnd = 1203427, XrefRangeStart = 1203418, XrefRangeEnd = 1203426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ServiceProvider BuildServiceProvider(this IServiceCollection services)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(services);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCollectionContainerBuilderExtensions.NativeMethodInfoPtr_BuildServiceProvider_Public_Static_ServiceProvider_IServiceCollection_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServiceProvider>(intPtr3) : null;
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00004F60 File Offset: 0x00003160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203427, XrefRangeEnd = 1203431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ServiceProvider BuildServiceProvider(this IServiceCollection services, ServiceProviderOptions options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(services);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCollectionContainerBuilderExtensions.NativeMethodInfoPtr_BuildServiceProvider_Public_Static_ServiceProvider_IServiceCollection_ServiceProviderOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServiceProvider>(intPtr3) : null;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002292 File Offset: 0x00000492
		public ServiceCollectionContainerBuilderExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_BuildServiceProvider_Public_Static_ServiceProvider_IServiceCollection_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_BuildServiceProvider_Public_Static_ServiceProvider_IServiceCollection_ServiceProviderOptions_0;
	}
}
