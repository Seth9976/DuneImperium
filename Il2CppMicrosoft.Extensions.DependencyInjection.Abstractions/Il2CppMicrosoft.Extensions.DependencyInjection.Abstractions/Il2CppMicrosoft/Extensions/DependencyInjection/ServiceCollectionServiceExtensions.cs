using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Il2CppMicrosoft.Extensions.DependencyInjection
{
	// Token: 0x02000016 RID: 22
	public static class ServiceCollectionServiceExtensions : Object
	{
		// Token: 0x06000067 RID: 103 RVA: 0x000036CC File Offset: 0x000018CC
		// Note: this type is marked as 'beforefieldinit'.
		static ServiceCollectionServiceExtensions()
		{
			Il2CppClassPointerStore<ServiceCollectionServiceExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.DependencyInjection.Abstractions.dll", "Microsoft.Extensions.DependencyInjection", "ServiceCollectionServiceExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServiceCollectionServiceExtensions>.NativeClassPtr);
			ServiceCollectionServiceExtensions.NativeMethodInfoPtr_AddSingleton_Public_Static_IServiceCollection_IServiceCollection_Type_Func_2_IServiceProvider_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCollectionServiceExtensions>.NativeClassPtr, 100663341);
			ServiceCollectionServiceExtensions.NativeMethodInfoPtr_AddSingleton_Public_Static_IServiceCollection_IServiceCollection_Func_2_IServiceProvider_TImplementation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCollectionServiceExtensions>.NativeClassPtr, 100663342);
			ServiceCollectionServiceExtensions.NativeMethodInfoPtr_Add_Private_Static_IServiceCollection_IServiceCollection_Type_Func_2_IServiceProvider_Object_ServiceLifetime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCollectionServiceExtensions>.NativeClassPtr, 100663343);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00003738 File Offset: 0x00001938
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1265188, RefRangeEnd = 1265189, XrefRangeStart = 1265173, XrefRangeEnd = 1265188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IServiceCollection AddSingleton(this IServiceCollection services, Type serviceType, Func<IServiceProvider, Object> implementationFactory)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(services);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serviceType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(implementationFactory);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCollectionServiceExtensions.NativeMethodInfoPtr_AddSingleton_Public_Static_IServiceCollection_IServiceCollection_Type_Func_2_IServiceProvider_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IServiceCollection>(intPtr3) : null;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000037A0 File Offset: 0x000019A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1265201, RefRangeEnd = 1265202, XrefRangeStart = 1265189, XrefRangeEnd = 1265201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IServiceCollection AddSingleton<TService, TImplementation>(this IServiceCollection services, Func<IServiceProvider, TImplementation> implementationFactory) where TService : class where TImplementation : class, TService
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(services);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(implementationFactory);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCollectionServiceExtensions.MethodInfoStoreGeneric_AddSingleton_Public_Static_IServiceCollection_IServiceCollection_Func_2_IServiceProvider_TImplementation_0<TService, TImplementation>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IServiceCollection>(intPtr3) : null;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000037F8 File Offset: 0x000019F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265202, XrefRangeEnd = 1265214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IServiceCollection Add(IServiceCollection collection, Type serviceType, Func<IServiceProvider, Object> implementationFactory, ServiceLifetime lifetime)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serviceType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(implementationFactory);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lifetime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCollectionServiceExtensions.NativeMethodInfoPtr_Add_Private_Static_IServiceCollection_IServiceCollection_Type_Func_2_IServiceProvider_Object_ServiceLifetime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IServiceCollection>(intPtr3) : null;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002380 File Offset: 0x00000580
		public ServiceCollectionServiceExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_AddSingleton_Public_Static_IServiceCollection_IServiceCollection_Type_Func_2_IServiceProvider_Object_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_AddSingleton_Public_Static_IServiceCollection_IServiceCollection_Func_2_IServiceProvider_TImplementation_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_Add_Private_Static_IServiceCollection_IServiceCollection_Type_Func_2_IServiceProvider_Object_ServiceLifetime_0;

		// Token: 0x0200001E RID: 30
		private sealed class MethodInfoStoreGeneric_AddSingleton_Public_Static_IServiceCollection_IServiceCollection_Func_2_IServiceProvider_TImplementation_0<TService, TImplementation>
		{
			// Token: 0x04000076 RID: 118
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ServiceCollectionServiceExtensions.NativeMethodInfoPtr_AddSingleton_Public_Static_IServiceCollection_IServiceCollection_Func_2_IServiceProvider_TImplementation_0, Il2CppClassPointerStore<ServiceCollectionServiceExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TService>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TImplementation>.NativeClassPtr))
			}))));
		}
	}
}
