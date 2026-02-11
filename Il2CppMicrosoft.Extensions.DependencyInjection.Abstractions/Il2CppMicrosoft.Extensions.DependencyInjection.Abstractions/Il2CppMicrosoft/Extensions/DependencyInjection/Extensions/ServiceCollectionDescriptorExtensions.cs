using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.DependencyInjection.Extensions
{
	// Token: 0x0200001B RID: 27
	public static class ServiceCollectionDescriptorExtensions : Object
	{
		// Token: 0x0600009D RID: 157 RVA: 0x00004684 File Offset: 0x00002884
		// Note: this type is marked as 'beforefieldinit'.
		static ServiceCollectionDescriptorExtensions()
		{
			Il2CppClassPointerStore<ServiceCollectionDescriptorExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.DependencyInjection.Abstractions.dll", "Microsoft.Extensions.DependencyInjection.Extensions", "ServiceCollectionDescriptorExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServiceCollectionDescriptorExtensions>.NativeClassPtr);
			ServiceCollectionDescriptorExtensions.NativeMethodInfoPtr_TryAdd_Public_Static_Void_IServiceCollection_ServiceDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCollectionDescriptorExtensions>.NativeClassPtr, 100663375);
			ServiceCollectionDescriptorExtensions.NativeMethodInfoPtr_TryAddEnumerable_Public_Static_Void_IServiceCollection_ServiceDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCollectionDescriptorExtensions>.NativeClassPtr, 100663376);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000046DC File Offset: 0x000028DC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1265547, RefRangeEnd = 1265556, XrefRangeStart = 1265531, XrefRangeEnd = 1265547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TryAdd(this IServiceCollection collection, ServiceDescriptor descriptor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(descriptor);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCollectionDescriptorExtensions.NativeMethodInfoPtr_TryAdd_Public_Static_Void_IServiceCollection_ServiceDescriptor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00004724 File Offset: 0x00002924
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1265584, RefRangeEnd = 1265586, XrefRangeStart = 1265556, XrefRangeEnd = 1265584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TryAddEnumerable(this IServiceCollection services, ServiceDescriptor descriptor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(services);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(descriptor);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCollectionDescriptorExtensions.NativeMethodInfoPtr_TryAddEnumerable_Public_Static_Void_IServiceCollection_ServiceDescriptor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000247F File Offset: 0x0000067F
		public ServiceCollectionDescriptorExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_TryAdd_Public_Static_Void_IServiceCollection_ServiceDescriptor_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_TryAddEnumerable_Public_Static_Void_IServiceCollection_ServiceDescriptor_0;
	}
}
