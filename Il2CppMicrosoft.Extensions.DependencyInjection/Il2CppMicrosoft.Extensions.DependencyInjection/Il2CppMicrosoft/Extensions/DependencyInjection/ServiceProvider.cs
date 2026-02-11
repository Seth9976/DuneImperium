using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Extensions.DependencyInjection.ServiceLookup;
using Il2CppSystem;
using Il2CppSystem.Collections.Concurrent;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppMicrosoft.Extensions.DependencyInjection
{
	// Token: 0x02000010 RID: 16
	public sealed class ServiceProvider : Object
	{
		// Token: 0x06000079 RID: 121 RVA: 0x00004FB8 File Offset: 0x000031B8
		// Note: this type is marked as 'beforefieldinit'.
		static ServiceProvider()
		{
			Il2CppClassPointerStore<ServiceProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.DependencyInjection.dll", "Microsoft.Extensions.DependencyInjection", "ServiceProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServiceProvider>.NativeClassPtr);
			ServiceProvider.NativeFieldInfoPtr__callSiteValidator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceProvider>.NativeClassPtr, "_callSiteValidator");
			ServiceProvider.NativeFieldInfoPtr__createServiceAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceProvider>.NativeClassPtr, "_createServiceAccessor");
			ServiceProvider.NativeFieldInfoPtr__engine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceProvider>.NativeClassPtr, "_engine");
			ServiceProvider.NativeFieldInfoPtr__disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceProvider>.NativeClassPtr, "_disposed");
			ServiceProvider.NativeFieldInfoPtr__serviceAccessors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceProvider>.NativeClassPtr, "_serviceAccessors");
			ServiceProvider.NativeFieldInfoPtr__CallSiteFactory_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceProvider>.NativeClassPtr, "<CallSiteFactory>k__BackingField");
			ServiceProvider.NativeFieldInfoPtr__Root_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceProvider>.NativeClassPtr, "<Root>k__BackingField");
			ServiceProvider.NativeFieldInfoPtr__VerifyOpenGenericServiceTrimmability_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceProvider>.NativeClassPtr, "<VerifyOpenGenericServiceTrimmability>k__BackingField");
			ServiceProvider.NativeFieldInfoPtr__DisableDynamicEngine_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceProvider>.NativeClassPtr, "<DisableDynamicEngine>k__BackingField");
			ServiceProvider.NativeMethodInfoPtr_get_CallSiteFactory_Internal_get_CallSiteFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProvider>.NativeClassPtr, 100663377);
			ServiceProvider.NativeMethodInfoPtr_get_Root_Internal_get_ServiceProviderEngineScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProvider>.NativeClassPtr, 100663378);
			ServiceProvider.NativeMethodInfoPtr_get_VerifyOpenGenericServiceTrimmability_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProvider>.NativeClassPtr, 100663379);
			ServiceProvider.NativeMethodInfoPtr_get_DisableDynamicEngine_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProvider>.NativeClassPtr, 100663380);
			ServiceProvider.NativeMethodInfoPtr_get_VerifyAotCompatibility_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProvider>.NativeClassPtr, 100663381);
			ServiceProvider.NativeMethodInfoPtr__ctor_Internal_Void_ICollection_1_ServiceDescriptor_ServiceProviderOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProvider>.NativeClassPtr, 100663382);
			ServiceProvider.NativeMethodInfoPtr_GetService_Public_Virtual_Final_New_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProvider>.NativeClassPtr, 100663383);
			ServiceProvider.NativeMethodInfoPtr_IsDisposed_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProvider>.NativeClassPtr, 100663384);
			ServiceProvider.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProvider>.NativeClassPtr, 100663385);
			ServiceProvider.NativeMethodInfoPtr_DisposeAsync_Public_Virtual_Final_New_ValueTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProvider>.NativeClassPtr, 100663386);
			ServiceProvider.NativeMethodInfoPtr_DisposeCore_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProvider>.NativeClassPtr, 100663387);
			ServiceProvider.NativeMethodInfoPtr_OnCreate_Private_Void_ServiceCallSite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProvider>.NativeClassPtr, 100663388);
			ServiceProvider.NativeMethodInfoPtr_OnResolve_Private_Void_ServiceCallSite_IServiceScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProvider>.NativeClassPtr, 100663389);
			ServiceProvider.NativeMethodInfoPtr_GetService_Internal_Object_ServiceIdentifier_ServiceProviderEngineScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProvider>.NativeClassPtr, 100663390);
			ServiceProvider.NativeMethodInfoPtr_ValidateService_Private_Void_ServiceDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProvider>.NativeClassPtr, 100663391);
			ServiceProvider.NativeMethodInfoPtr_CreateServiceAccessor_Private_ServiceAccessor_ServiceIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProvider>.NativeClassPtr, 100663392);
			ServiceProvider.NativeMethodInfoPtr_ReplaceServiceAccessor_Internal_Void_ServiceCallSite_Func_2_ServiceProviderEngineScope_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProvider>.NativeClassPtr, 100663393);
			ServiceProvider.NativeMethodInfoPtr_GetEngine_Private_ServiceProviderEngine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProvider>.NativeClassPtr, 100663394);
			ServiceProvider.NativeMethodInfoPtr_Method_Private_ServiceProviderEngine_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProvider>.NativeClassPtr, 100663396);
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00005218 File Offset: 0x00003418
		public unsafe CallSiteFactory CallSiteFactory
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProvider.NativeMethodInfoPtr_get_CallSiteFactory_Internal_get_CallSiteFactory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CallSiteFactory>(intPtr3) : null;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00005258 File Offset: 0x00003458
		public unsafe ServiceProviderEngineScope Root
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProvider.NativeMethodInfoPtr_get_Root_Internal_get_ServiceProviderEngineScope_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServiceProviderEngineScope>(intPtr3) : null;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00005298 File Offset: 0x00003498
		public unsafe static bool VerifyOpenGenericServiceTrimmability
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203431, XrefRangeEnd = 1203435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProvider.NativeMethodInfoPtr_get_VerifyOpenGenericServiceTrimmability_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600007D RID: 125 RVA: 0x000052C8 File Offset: 0x000034C8
		public unsafe static bool DisableDynamicEngine
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203435, XrefRangeEnd = 1203439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProvider.NativeMethodInfoPtr_get_DisableDynamicEngine_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600007E RID: 126 RVA: 0x000052F8 File Offset: 0x000034F8
		public unsafe static bool VerifyAotCompatibility
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203439, XrefRangeEnd = 1203440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProvider.NativeMethodInfoPtr_get_VerifyAotCompatibility_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00005328 File Offset: 0x00003528
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1203596, RefRangeEnd = 1203598, XrefRangeStart = 1203440, XrefRangeEnd = 1203596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServiceProvider(ICollection<ServiceDescriptor> serviceDescriptors, ServiceProviderOptions options)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServiceProvider>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serviceDescriptors);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProvider.NativeMethodInfoPtr__ctor_Internal_Void_ICollection_1_ServiceDescriptor_ServiceProviderOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00005388 File Offset: 0x00003588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203598, XrefRangeEnd = 1203601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetService(Type serviceType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serviceType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProvider.NativeMethodInfoPtr_GetService_Public_Virtual_Final_New_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000053D8 File Offset: 0x000035D8
		[CallerCount(0)]
		public unsafe bool IsDisposed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProvider.NativeMethodInfoPtr_IsDisposed_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00005414 File Offset: 0x00003614
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1203616, RefRangeEnd = 1203617, XrefRangeStart = 1203601, XrefRangeEnd = 1203616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProvider.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00005448 File Offset: 0x00003648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203617, XrefRangeEnd = 1203623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTask DisposeAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProvider.NativeMethodInfoPtr_DisposeAsync_Public_Virtual_Final_New_ValueTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTask(intPtr);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00005480 File Offset: 0x00003680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203623, XrefRangeEnd = 1203629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisposeCore()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProvider.NativeMethodInfoPtr_DisposeCore_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000054B4 File Offset: 0x000036B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1203636, RefRangeEnd = 1203638, XrefRangeStart = 1203629, XrefRangeEnd = 1203636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCreate(ServiceCallSite callSite)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callSite);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProvider.NativeMethodInfoPtr_OnCreate_Private_Void_ServiceCallSite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000054F8 File Offset: 0x000036F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203638, XrefRangeEnd = 1203639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnResolve(ServiceCallSite callSite, IServiceScope scope)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callSite);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scope);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProvider.NativeMethodInfoPtr_OnResolve_Private_Void_ServiceCallSite_IServiceScope_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000554C File Offset: 0x0000374C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1203649, RefRangeEnd = 1203651, XrefRangeStart = 1203639, XrefRangeEnd = 1203649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetService(ServiceIdentifier serviceIdentifier, ServiceProviderEngineScope serviceProviderEngineScope)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(serviceIdentifier));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serviceProviderEngineScope);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProvider.NativeMethodInfoPtr_GetService_Internal_Object_ServiceIdentifier_ServiceProviderEngineScope_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000055B4 File Offset: 0x000037B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1203663, RefRangeEnd = 1203664, XrefRangeStart = 1203651, XrefRangeEnd = 1203663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateService(ServiceDescriptor descriptor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(descriptor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProvider.NativeMethodInfoPtr_ValidateService_Private_Void_ServiceDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000055F8 File Offset: 0x000037F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203664, XrefRangeEnd = 1203703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServiceProvider.ServiceAccessor CreateServiceAccessor(ServiceIdentifier serviceIdentifier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(serviceIdentifier));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProvider.NativeMethodInfoPtr_CreateServiceAccessor_Private_ServiceAccessor_ServiceIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServiceProvider.ServiceAccessor>(intPtr3) : null;
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00005650 File Offset: 0x00003850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203703, XrefRangeEnd = 1203714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplaceServiceAccessor(ServiceCallSite callSite, Func<ServiceProviderEngineScope, Object> accessor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callSite);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accessor);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProvider.NativeMethodInfoPtr_ReplaceServiceAccessor_Internal_Void_ServiceCallSite_Func_2_ServiceProviderEngineScope_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000056A4 File Offset: 0x000038A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1203750, RefRangeEnd = 1203751, XrefRangeStart = 1203714, XrefRangeEnd = 1203750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServiceProviderEngine GetEngine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProvider.NativeMethodInfoPtr_GetEngine_Private_ServiceProviderEngine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServiceProviderEngine>(intPtr3) : null;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000056E4 File Offset: 0x000038E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203751, XrefRangeEnd = 1203778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServiceProviderEngine Method_Private_ServiceProviderEngine_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProvider.NativeMethodInfoPtr_Method_Private_ServiceProviderEngine_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServiceProviderEngine>(intPtr3) : null;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000229B File Offset: 0x0000049B
		public ServiceProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00005724 File Offset: 0x00003924
		// (set) Token: 0x0600008F RID: 143 RVA: 0x000022A4 File Offset: 0x000004A4
		public unsafe CallSiteValidator _callSiteValidator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProvider.NativeFieldInfoPtr__callSiteValidator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallSiteValidator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProvider.NativeFieldInfoPtr__callSiteValidator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00005754 File Offset: 0x00003954
		// (set) Token: 0x06000091 RID: 145 RVA: 0x000022C3 File Offset: 0x000004C3
		public unsafe Func<ServiceIdentifier, ServiceProvider.ServiceAccessor> _createServiceAccessor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProvider.NativeFieldInfoPtr__createServiceAccessor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ServiceIdentifier, ServiceProvider.ServiceAccessor>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProvider.NativeFieldInfoPtr__createServiceAccessor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00005784 File Offset: 0x00003984
		// (set) Token: 0x06000093 RID: 147 RVA: 0x000022E2 File Offset: 0x000004E2
		public unsafe ServiceProviderEngine _engine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProvider.NativeFieldInfoPtr__engine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServiceProviderEngine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProvider.NativeFieldInfoPtr__engine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000094 RID: 148 RVA: 0x000057B4 File Offset: 0x000039B4
		// (set) Token: 0x06000095 RID: 149 RVA: 0x00002301 File Offset: 0x00000501
		public unsafe bool _disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProvider.NativeFieldInfoPtr__disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProvider.NativeFieldInfoPtr__disposed)) = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000096 RID: 150 RVA: 0x000057DC File Offset: 0x000039DC
		// (set) Token: 0x06000097 RID: 151 RVA: 0x0000231C File Offset: 0x0000051C
		public unsafe ConcurrentDictionary<ServiceIdentifier, ServiceProvider.ServiceAccessor> _serviceAccessors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProvider.NativeFieldInfoPtr__serviceAccessors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<ServiceIdentifier, ServiceProvider.ServiceAccessor>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProvider.NativeFieldInfoPtr__serviceAccessors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000098 RID: 152 RVA: 0x0000580C File Offset: 0x00003A0C
		// (set) Token: 0x06000099 RID: 153 RVA: 0x0000233B File Offset: 0x0000053B
		public unsafe CallSiteFactory _CallSiteFactory_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProvider.NativeFieldInfoPtr__CallSiteFactory_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallSiteFactory>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProvider.NativeFieldInfoPtr__CallSiteFactory_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600009A RID: 154 RVA: 0x0000583C File Offset: 0x00003A3C
		// (set) Token: 0x0600009B RID: 155 RVA: 0x0000235A File Offset: 0x0000055A
		public unsafe ServiceProviderEngineScope _Root_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProvider.NativeFieldInfoPtr__Root_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServiceProviderEngineScope>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProvider.NativeFieldInfoPtr__Root_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600009C RID: 156 RVA: 0x0000586C File Offset: 0x00003A6C
		// (set) Token: 0x0600009D RID: 157 RVA: 0x00002379 File Offset: 0x00000579
		public unsafe static bool _VerifyOpenGenericServiceTrimmability_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(ServiceProvider.NativeFieldInfoPtr__VerifyOpenGenericServiceTrimmability_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServiceProvider.NativeFieldInfoPtr__VerifyOpenGenericServiceTrimmability_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00005888 File Offset: 0x00003A88
		// (set) Token: 0x0600009F RID: 159 RVA: 0x00002387 File Offset: 0x00000587
		public unsafe static bool _DisableDynamicEngine_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(ServiceProvider.NativeFieldInfoPtr__DisableDynamicEngine_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServiceProvider.NativeFieldInfoPtr__DisableDynamicEngine_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeFieldInfoPtr__callSiteValidator;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeFieldInfoPtr__createServiceAccessor;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeFieldInfoPtr__engine;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeFieldInfoPtr__disposed;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeFieldInfoPtr__serviceAccessors;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeFieldInfoPtr__CallSiteFactory_k__BackingField;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeFieldInfoPtr__Root_k__BackingField;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeFieldInfoPtr__VerifyOpenGenericServiceTrimmability_k__BackingField;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeFieldInfoPtr__DisableDynamicEngine_k__BackingField;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_get_CallSiteFactory_Internal_get_CallSiteFactory_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr_get_Root_Internal_get_ServiceProviderEngineScope_0;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr_get_VerifyOpenGenericServiceTrimmability_Internal_Static_get_Boolean_0;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr_get_DisableDynamicEngine_Internal_Static_get_Boolean_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_get_VerifyAotCompatibility_Internal_Static_get_Boolean_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ICollection_1_ServiceDescriptor_ServiceProviderOptions_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_GetService_Public_Virtual_Final_New_Object_Type_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_IsDisposed_Internal_Boolean_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_DisposeAsync_Public_Virtual_Final_New_ValueTask_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_DisposeCore_Private_Void_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_OnCreate_Private_Void_ServiceCallSite_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_OnResolve_Private_Void_ServiceCallSite_IServiceScope_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_GetService_Internal_Object_ServiceIdentifier_ServiceProviderEngineScope_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_ValidateService_Private_Void_ServiceDescriptor_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_CreateServiceAccessor_Private_ServiceAccessor_ServiceIdentifier_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceServiceAccessor_Internal_Void_ServiceCallSite_Func_2_ServiceProviderEngineScope_Object_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_GetEngine_Private_ServiceProviderEngine_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_ServiceProviderEngine_PDM_0;

		// Token: 0x02000033 RID: 51
		public sealed class ServiceProviderDebugView : Object
		{
			// Token: 0x0600024C RID: 588 RVA: 0x00002D76 File Offset: 0x00000F76
			// Note: this type is marked as 'beforefieldinit'.
			static ServiceProviderDebugView()
			{
				Il2CppClassPointerStore<ServiceProvider.ServiceProviderDebugView>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServiceProvider>.NativeClassPtr, "ServiceProviderDebugView");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServiceProvider.ServiceProviderDebugView>.NativeClassPtr);
			}

			// Token: 0x0600024D RID: 589 RVA: 0x00002D96 File Offset: 0x00000F96
			public ServiceProviderDebugView(IntPtr pointer)
				: base(pointer)
			{
			}
		}

		// Token: 0x02000034 RID: 52
		public sealed class ServiceAccessor : Object
		{
			// Token: 0x0600024E RID: 590 RVA: 0x0000C724 File Offset: 0x0000A924
			// Note: this type is marked as 'beforefieldinit'.
			static ServiceAccessor()
			{
				Il2CppClassPointerStore<ServiceProvider.ServiceAccessor>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServiceProvider>.NativeClassPtr, "ServiceAccessor");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServiceProvider.ServiceAccessor>.NativeClassPtr);
				ServiceProvider.ServiceAccessor.NativeFieldInfoPtr__CallSite_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceProvider.ServiceAccessor>.NativeClassPtr, "<CallSite>k__BackingField");
				ServiceProvider.ServiceAccessor.NativeFieldInfoPtr__RealizedService_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceProvider.ServiceAccessor>.NativeClassPtr, "<RealizedService>k__BackingField");
				ServiceProvider.ServiceAccessor.NativeMethodInfoPtr_get_CallSite_Public_get_ServiceCallSite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProvider.ServiceAccessor>.NativeClassPtr, 100663397);
				ServiceProvider.ServiceAccessor.NativeMethodInfoPtr_set_CallSite_Public_set_Void_ServiceCallSite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProvider.ServiceAccessor>.NativeClassPtr, 100663398);
				ServiceProvider.ServiceAccessor.NativeMethodInfoPtr_get_RealizedService_Public_get_Func_2_ServiceProviderEngineScope_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProvider.ServiceAccessor>.NativeClassPtr, 100663399);
				ServiceProvider.ServiceAccessor.NativeMethodInfoPtr_set_RealizedService_Public_set_Void_Func_2_ServiceProviderEngineScope_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProvider.ServiceAccessor>.NativeClassPtr, 100663400);
				ServiceProvider.ServiceAccessor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProvider.ServiceAccessor>.NativeClassPtr, 100663401);
			}

			// Token: 0x170000B7 RID: 183
			// (get) Token: 0x0600024F RID: 591 RVA: 0x0000C7DC File Offset: 0x0000A9DC
			// (set) Token: 0x06000250 RID: 592 RVA: 0x0000C81C File Offset: 0x0000AA1C
			public unsafe ServiceCallSite CallSite
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProvider.ServiceAccessor.NativeMethodInfoPtr_get_CallSite_Public_get_ServiceCallSite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServiceCallSite>(intPtr3) : null;
				}
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProvider.ServiceAccessor.NativeMethodInfoPtr_set_CallSite_Public_set_Void_ServiceCallSite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170000B8 RID: 184
			// (get) Token: 0x06000251 RID: 593 RVA: 0x0000C860 File Offset: 0x0000AA60
			// (set) Token: 0x06000252 RID: 594 RVA: 0x0000C8A0 File Offset: 0x0000AAA0
			public unsafe Func<ServiceProviderEngineScope, Object> RealizedService
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProvider.ServiceAccessor.NativeMethodInfoPtr_get_RealizedService_Public_get_Func_2_ServiceProviderEngineScope_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<ServiceProviderEngineScope, Object>>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProvider.ServiceAccessor.NativeMethodInfoPtr_set_RealizedService_Public_set_Void_Func_2_ServiceProviderEngineScope_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06000253 RID: 595 RVA: 0x0000C8E4 File Offset: 0x0000AAE4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ServiceAccessor()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServiceProvider.ServiceAccessor>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProvider.ServiceAccessor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000254 RID: 596 RVA: 0x00002D9F File Offset: 0x00000F9F
			public ServiceAccessor(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000B5 RID: 181
			// (get) Token: 0x06000255 RID: 597 RVA: 0x0000C920 File Offset: 0x0000AB20
			// (set) Token: 0x06000256 RID: 598 RVA: 0x00002DA8 File Offset: 0x00000FA8
			public unsafe ServiceCallSite _CallSite_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProvider.ServiceAccessor.NativeFieldInfoPtr__CallSite_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServiceCallSite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProvider.ServiceAccessor.NativeFieldInfoPtr__CallSite_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000B6 RID: 182
			// (get) Token: 0x06000257 RID: 599 RVA: 0x0000C950 File Offset: 0x0000AB50
			// (set) Token: 0x06000258 RID: 600 RVA: 0x00002DC7 File Offset: 0x00000FC7
			public unsafe Func<ServiceProviderEngineScope, Object> _RealizedService_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProvider.ServiceAccessor.NativeFieldInfoPtr__RealizedService_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ServiceProviderEngineScope, Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProvider.ServiceAccessor.NativeFieldInfoPtr__RealizedService_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001A8 RID: 424
			private static readonly IntPtr NativeFieldInfoPtr__CallSite_k__BackingField;

			// Token: 0x040001A9 RID: 425
			private static readonly IntPtr NativeFieldInfoPtr__RealizedService_k__BackingField;

			// Token: 0x040001AA RID: 426
			private static readonly IntPtr NativeMethodInfoPtr_get_CallSite_Public_get_ServiceCallSite_0;

			// Token: 0x040001AB RID: 427
			private static readonly IntPtr NativeMethodInfoPtr_set_CallSite_Public_set_Void_ServiceCallSite_0;

			// Token: 0x040001AC RID: 428
			private static readonly IntPtr NativeMethodInfoPtr_get_RealizedService_Public_get_Func_2_ServiceProviderEngineScope_Object_0;

			// Token: 0x040001AD RID: 429
			private static readonly IntPtr NativeMethodInfoPtr_set_RealizedService_Public_set_Void_Func_2_ServiceProviderEngineScope_Object_0;

			// Token: 0x040001AE RID: 430
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000035 RID: 53
		[ObfuscatedName("Microsoft.Extensions.DependencyInjection.ServiceProvider+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000259 RID: 601 RVA: 0x0000C980 File Offset: 0x0000AB80
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ServiceProvider.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServiceProvider>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServiceProvider.__c>.NativeClassPtr);
				ServiceProvider.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceProvider.__c>.NativeClassPtr, "<>9");
				ServiceProvider.__c.NativeFieldInfoPtr___9__33_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceProvider.__c>.NativeClassPtr, "<>9__33_1");
				ServiceProvider.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProvider.__c>.NativeClassPtr, 100663403);
				ServiceProvider.__c.NativeMethodInfoPtr__CreateServiceAccessor_b__33_1_Internal_Object_ServiceProviderEngineScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProvider.__c>.NativeClassPtr, 100663404);
			}

			// Token: 0x0600025A RID: 602 RVA: 0x0000C9FC File Offset: 0x0000ABFC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServiceProvider.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProvider.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600025B RID: 603 RVA: 0x0000CA38 File Offset: 0x0000AC38
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object _CreateServiceAccessor_b__33_1(ServiceProviderEngineScope _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProvider.__c.NativeMethodInfoPtr__CreateServiceAccessor_b__33_1_Internal_Object_ServiceProviderEngineScope_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600025C RID: 604 RVA: 0x00002DE6 File Offset: 0x00000FE6
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000B9 RID: 185
			// (get) Token: 0x0600025D RID: 605 RVA: 0x0000CA88 File Offset: 0x0000AC88
			// (set) Token: 0x0600025E RID: 606 RVA: 0x00002DEF File Offset: 0x00000FEF
			public unsafe static ServiceProvider.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ServiceProvider.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServiceProvider.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ServiceProvider.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000BA RID: 186
			// (get) Token: 0x0600025F RID: 607 RVA: 0x0000CAB0 File Offset: 0x0000ACB0
			// (set) Token: 0x06000260 RID: 608 RVA: 0x00002E01 File Offset: 0x00001001
			public unsafe static Func<ServiceProviderEngineScope, Object> __9__33_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ServiceProvider.__c.NativeFieldInfoPtr___9__33_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ServiceProviderEngineScope, Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ServiceProvider.__c.NativeFieldInfoPtr___9__33_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001AF RID: 431
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040001B0 RID: 432
			private static readonly IntPtr NativeFieldInfoPtr___9__33_1;

			// Token: 0x040001B1 RID: 433
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040001B2 RID: 434
			private static readonly IntPtr NativeMethodInfoPtr__CreateServiceAccessor_b__33_1_Internal_Object_ServiceProviderEngineScope_0;
		}

		// Token: 0x02000036 RID: 54
		[ObfuscatedName("Microsoft.Extensions.DependencyInjection.ServiceProvider+<>c__DisplayClass33_0")]
		public sealed class __c__DisplayClass33_0 : Object
		{
			// Token: 0x06000261 RID: 609 RVA: 0x0000CAD8 File Offset: 0x0000ACD8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass33_0()
			{
				Il2CppClassPointerStore<ServiceProvider.__c__DisplayClass33_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServiceProvider>.NativeClassPtr, "<>c__DisplayClass33_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServiceProvider.__c__DisplayClass33_0>.NativeClassPtr);
				ServiceProvider.__c__DisplayClass33_0.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceProvider.__c__DisplayClass33_0>.NativeClassPtr, "value");
				ServiceProvider.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProvider.__c__DisplayClass33_0>.NativeClassPtr, 100663405);
				ServiceProvider.__c__DisplayClass33_0.NativeMethodInfoPtr__CreateServiceAccessor_b__0_Internal_Object_ServiceProviderEngineScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProvider.__c__DisplayClass33_0>.NativeClassPtr, 100663406);
			}

			// Token: 0x06000262 RID: 610 RVA: 0x0000CB40 File Offset: 0x0000AD40
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass33_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServiceProvider.__c__DisplayClass33_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProvider.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000263 RID: 611 RVA: 0x0000CB7C File Offset: 0x0000AD7C
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object _CreateServiceAccessor_b__0(ServiceProviderEngineScope scope)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(scope);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProvider.__c__DisplayClass33_0.NativeMethodInfoPtr__CreateServiceAccessor_b__0_Internal_Object_ServiceProviderEngineScope_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000264 RID: 612 RVA: 0x00002E13 File Offset: 0x00001013
			public __c__DisplayClass33_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000BB RID: 187
			// (get) Token: 0x06000265 RID: 613 RVA: 0x0000CBCC File Offset: 0x0000ADCC
			// (set) Token: 0x06000266 RID: 614 RVA: 0x00002E1C File Offset: 0x0000101C
			public unsafe Object value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProvider.__c__DisplayClass33_0.NativeFieldInfoPtr_value);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProvider.__c__DisplayClass33_0.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001B3 RID: 435
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x040001B4 RID: 436
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040001B5 RID: 437
			private static readonly IntPtr NativeMethodInfoPtr__CreateServiceAccessor_b__0_Internal_Object_ServiceProviderEngineScope_0;
		}
	}
}
