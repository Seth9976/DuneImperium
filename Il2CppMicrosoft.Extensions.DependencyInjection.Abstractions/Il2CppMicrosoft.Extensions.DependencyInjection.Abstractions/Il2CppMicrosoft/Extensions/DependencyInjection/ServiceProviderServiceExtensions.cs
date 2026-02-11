using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Il2CppMicrosoft.Extensions.DependencyInjection
{
	// Token: 0x0200001A RID: 26
	public static class ServiceProviderServiceExtensions : Object
	{
		// Token: 0x06000099 RID: 153 RVA: 0x00004594 File Offset: 0x00002794
		// Note: this type is marked as 'beforefieldinit'.
		static ServiceProviderServiceExtensions()
		{
			Il2CppClassPointerStore<ServiceProviderServiceExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.DependencyInjection.Abstractions.dll", "Microsoft.Extensions.DependencyInjection", "ServiceProviderServiceExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServiceProviderServiceExtensions>.NativeClassPtr);
			ServiceProviderServiceExtensions.NativeMethodInfoPtr_GetRequiredService_Public_Static_Object_IServiceProvider_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProviderServiceExtensions>.NativeClassPtr, 100663373);
			ServiceProviderServiceExtensions.NativeMethodInfoPtr_GetRequiredService_Public_Static_T_IServiceProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProviderServiceExtensions>.NativeClassPtr, 100663374);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000045EC File Offset: 0x000027EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1265518, RefRangeEnd = 1265520, XrefRangeStart = 1265507, XrefRangeEnd = 1265518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object GetRequiredService(this IServiceProvider provider, Type serviceType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serviceType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProviderServiceExtensions.NativeMethodInfoPtr_GetRequiredService_Public_Static_Object_IServiceProvider_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00004644 File Offset: 0x00002844
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1265530, RefRangeEnd = 1265531, XrefRangeStart = 1265520, XrefRangeEnd = 1265530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetRequiredService<T>(this IServiceProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProviderServiceExtensions.MethodInfoStoreGeneric_GetRequiredService_Public_Static_T_IServiceProvider_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002476 File Offset: 0x00000676
		public ServiceProviderServiceExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_GetRequiredService_Public_Static_Object_IServiceProvider_Type_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_GetRequiredService_Public_Static_T_IServiceProvider_0;

		// Token: 0x02000022 RID: 34
		private sealed class MethodInfoStoreGeneric_GetRequiredService_Public_Static_T_IServiceProvider_0<T>
		{
			// Token: 0x0400007A RID: 122
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ServiceProviderServiceExtensions.NativeMethodInfoPtr_GetRequiredService_Public_Static_T_IServiceProvider_0, Il2CppClassPointerStore<ServiceProviderServiceExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
