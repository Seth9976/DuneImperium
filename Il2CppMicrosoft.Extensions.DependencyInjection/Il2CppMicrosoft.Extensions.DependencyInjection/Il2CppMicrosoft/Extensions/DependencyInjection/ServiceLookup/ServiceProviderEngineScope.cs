using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppMicrosoft.Extensions.DependencyInjection.ServiceLookup
{
	// Token: 0x0200002A RID: 42
	public sealed class ServiceProviderEngineScope : Object
	{
		// Token: 0x060001C7 RID: 455 RVA: 0x0000A7DC File Offset: 0x000089DC
		// Note: this type is marked as 'beforefieldinit'.
		static ServiceProviderEngineScope()
		{
			Il2CppClassPointerStore<ServiceProviderEngineScope>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.DependencyInjection.dll", "Microsoft.Extensions.DependencyInjection.ServiceLookup", "ServiceProviderEngineScope");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServiceProviderEngineScope>.NativeClassPtr);
			ServiceProviderEngineScope.NativeFieldInfoPtr__disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceProviderEngineScope>.NativeClassPtr, "_disposed");
			ServiceProviderEngineScope.NativeFieldInfoPtr__disposables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceProviderEngineScope>.NativeClassPtr, "_disposables");
			ServiceProviderEngineScope.NativeFieldInfoPtr__ResolvedServices_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceProviderEngineScope>.NativeClassPtr, "<ResolvedServices>k__BackingField");
			ServiceProviderEngineScope.NativeFieldInfoPtr__IsRootScope_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceProviderEngineScope>.NativeClassPtr, "<IsRootScope>k__BackingField");
			ServiceProviderEngineScope.NativeFieldInfoPtr__RootProvider_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceProviderEngineScope>.NativeClassPtr, "<RootProvider>k__BackingField");
			ServiceProviderEngineScope.NativeMethodInfoPtr__ctor_Public_Void_ServiceProvider_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProviderEngineScope>.NativeClassPtr, 100663585);
			ServiceProviderEngineScope.NativeMethodInfoPtr_get_ResolvedServices_Internal_get_Dictionary_2_ServiceCacheKey_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProviderEngineScope>.NativeClassPtr, 100663586);
			ServiceProviderEngineScope.NativeMethodInfoPtr_get_Sync_Internal_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProviderEngineScope>.NativeClassPtr, 100663587);
			ServiceProviderEngineScope.NativeMethodInfoPtr_get_IsRootScope_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProviderEngineScope>.NativeClassPtr, 100663588);
			ServiceProviderEngineScope.NativeMethodInfoPtr_get_RootProvider_Internal_get_ServiceProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProviderEngineScope>.NativeClassPtr, 100663589);
			ServiceProviderEngineScope.NativeMethodInfoPtr_GetService_Public_Virtual_Final_New_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProviderEngineScope>.NativeClassPtr, 100663590);
			ServiceProviderEngineScope.NativeMethodInfoPtr_CaptureDisposable_Internal_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProviderEngineScope>.NativeClassPtr, 100663591);
			ServiceProviderEngineScope.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProviderEngineScope>.NativeClassPtr, 100663592);
			ServiceProviderEngineScope.NativeMethodInfoPtr_DisposeAsync_Public_Virtual_Final_New_ValueTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProviderEngineScope>.NativeClassPtr, 100663593);
			ServiceProviderEngineScope.NativeMethodInfoPtr_BeginDispose_Private_List_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProviderEngineScope>.NativeClassPtr, 100663594);
			ServiceProviderEngineScope.NativeMethodInfoPtr_Method_Internal_Static_ValueTask_Int32_ValueTask_List_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProviderEngineScope>.NativeClassPtr, 100663595);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0000A94C File Offset: 0x00008B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205063, XrefRangeEnd = 1205072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServiceProviderEngineScope(ServiceProvider provider, bool isRootScope)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServiceProviderEngineScope>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isRootScope;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProviderEngineScope.NativeMethodInfoPtr__ctor_Public_Void_ServiceProvider_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x0000A9A8 File Offset: 0x00008BA8
		public unsafe Dictionary<ServiceCacheKey, Object> ResolvedServices
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProviderEngineScope.NativeMethodInfoPtr_get_ResolvedServices_Internal_get_Dictionary_2_ServiceCacheKey_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<ServiceCacheKey, Object>>(intPtr3) : null;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001CA RID: 458 RVA: 0x0000A9E8 File Offset: 0x00008BE8
		public unsafe Object Sync
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProviderEngineScope.NativeMethodInfoPtr_get_Sync_Internal_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060001CB RID: 459 RVA: 0x0000AA28 File Offset: 0x00008C28
		public unsafe bool IsRootScope
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProviderEngineScope.NativeMethodInfoPtr_get_IsRootScope_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060001CC RID: 460 RVA: 0x0000AA64 File Offset: 0x00008C64
		public unsafe ServiceProvider RootProvider
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProviderEngineScope.NativeMethodInfoPtr_get_RootProvider_Internal_get_ServiceProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServiceProvider>(intPtr3) : null;
			}
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0000AAA4 File Offset: 0x00008CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205072, XrefRangeEnd = 1205075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetService(Type serviceType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serviceType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProviderEngineScope.NativeMethodInfoPtr_GetService_Public_Virtual_Final_New_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060001CE RID: 462 RVA: 0x0000AAF4 File Offset: 0x00008CF4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1205101, RefRangeEnd = 1205104, XrefRangeStart = 1205075, XrefRangeEnd = 1205101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object CaptureDisposable(Object service)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(service);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProviderEngineScope.NativeMethodInfoPtr_CaptureDisposable_Internal_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0000AB44 File Offset: 0x00008D44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205104, XrefRangeEnd = 1205114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProviderEngineScope.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0000AB78 File Offset: 0x00008D78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1205156, RefRangeEnd = 1205157, XrefRangeStart = 1205114, XrefRangeEnd = 1205156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTask DisposeAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProviderEngineScope.NativeMethodInfoPtr_DisposeAsync_Public_Virtual_Final_New_ValueTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTask(intPtr);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0000ABB0 File Offset: 0x00008DB0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1205171, RefRangeEnd = 1205174, XrefRangeStart = 1205157, XrefRangeEnd = 1205171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Object> BeginDispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProviderEngineScope.NativeMethodInfoPtr_BeginDispose_Private_List_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Object>>(intPtr3) : null;
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x0000ABF0 File Offset: 0x00008DF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1205186, RefRangeEnd = 1205187, XrefRangeStart = 1205174, XrefRangeEnd = 1205186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ValueTask Method_Internal_Static_ValueTask_Int32_ValueTask_List_1_Object_0(int i, ValueTask vt, List<Object> toDispose)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(vt));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toDispose);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProviderEngineScope.NativeMethodInfoPtr_Method_Internal_Static_ValueTask_Int32_ValueTask_List_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTask(intPtr);
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00002A08 File Offset: 0x00000C08
		public ServiceProviderEngineScope(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x0000AC54 File Offset: 0x00008E54
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x00002A11 File Offset: 0x00000C11
		public unsafe bool _disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProviderEngineScope.NativeFieldInfoPtr__disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProviderEngineScope.NativeFieldInfoPtr__disposed)) = value;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x0000AC7C File Offset: 0x00008E7C
		// (set) Token: 0x060001D7 RID: 471 RVA: 0x00002A2C File Offset: 0x00000C2C
		public unsafe List<Object> _disposables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProviderEngineScope.NativeFieldInfoPtr__disposables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProviderEngineScope.NativeFieldInfoPtr__disposables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x0000ACAC File Offset: 0x00008EAC
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x00002A4B File Offset: 0x00000C4B
		public unsafe Dictionary<ServiceCacheKey, Object> _ResolvedServices_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProviderEngineScope.NativeFieldInfoPtr__ResolvedServices_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ServiceCacheKey, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProviderEngineScope.NativeFieldInfoPtr__ResolvedServices_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060001DA RID: 474 RVA: 0x0000ACDC File Offset: 0x00008EDC
		// (set) Token: 0x060001DB RID: 475 RVA: 0x00002A6A File Offset: 0x00000C6A
		public unsafe bool _IsRootScope_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProviderEngineScope.NativeFieldInfoPtr__IsRootScope_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProviderEngineScope.NativeFieldInfoPtr__IsRootScope_k__BackingField)) = value;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001DC RID: 476 RVA: 0x0000AD04 File Offset: 0x00008F04
		// (set) Token: 0x060001DD RID: 477 RVA: 0x00002A85 File Offset: 0x00000C85
		public unsafe ServiceProvider _RootProvider_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProviderEngineScope.NativeFieldInfoPtr__RootProvider_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServiceProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProviderEngineScope.NativeFieldInfoPtr__RootProvider_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeFieldInfoPtr__disposed;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeFieldInfoPtr__disposables;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeFieldInfoPtr__ResolvedServices_k__BackingField;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeFieldInfoPtr__IsRootScope_k__BackingField;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeFieldInfoPtr__RootProvider_k__BackingField;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ServiceProvider_Boolean_0;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeMethodInfoPtr_get_ResolvedServices_Internal_get_Dictionary_2_ServiceCacheKey_Object_0;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeMethodInfoPtr_get_Sync_Internal_get_Object_0;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRootScope_Public_get_Boolean_0;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeMethodInfoPtr_get_RootProvider_Internal_get_ServiceProvider_0;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeMethodInfoPtr_GetService_Public_Virtual_Final_New_Object_Type_0;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeMethodInfoPtr_CaptureDisposable_Internal_Object_Object_0;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeMethodInfoPtr_DisposeAsync_Public_Virtual_Final_New_ValueTask_0;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeMethodInfoPtr_BeginDispose_Private_List_1_Object_0;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_ValueTask_Int32_ValueTask_List_1_Object_0;

		// Token: 0x02000041 RID: 65
		public sealed class ServiceProviderEngineScopeDebugView : Object
		{
			// Token: 0x060002BE RID: 702 RVA: 0x0000312C File Offset: 0x0000132C
			// Note: this type is marked as 'beforefieldinit'.
			static ServiceProviderEngineScopeDebugView()
			{
				Il2CppClassPointerStore<ServiceProviderEngineScope.ServiceProviderEngineScopeDebugView>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServiceProviderEngineScope>.NativeClassPtr, "ServiceProviderEngineScopeDebugView");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServiceProviderEngineScope.ServiceProviderEngineScopeDebugView>.NativeClassPtr);
			}

			// Token: 0x060002BF RID: 703 RVA: 0x0000314C File Offset: 0x0000134C
			public ServiceProviderEngineScopeDebugView(IntPtr pointer)
				: base(pointer)
			{
			}
		}

		// Token: 0x02000042 RID: 66
		[ObfuscatedName("Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceProviderEngineScope+<<DisposeAsync>g__Await|26_0>d")]
		public sealed class ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsVavtiInLi1ObtoUnique : ValueType
		{
			// Token: 0x060002C0 RID: 704 RVA: 0x0000DB40 File Offset: 0x0000BD40
			// Note: this type is marked as 'beforefieldinit'.
			static ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsVavtiInLi1ObtoUnique()
			{
				Il2CppClassPointerStore<ServiceProviderEngineScope.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsVavtiInLi1ObtoUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServiceProviderEngineScope>.NativeClassPtr, "<<DisposeAsync>g__Await|26_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServiceProviderEngineScope.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsVavtiInLi1ObtoUnique>.NativeClassPtr);
				ServiceProviderEngineScope.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsVavtiInLi1ObtoUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceProviderEngineScope.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsVavtiInLi1ObtoUnique>.NativeClassPtr, "<>1__state");
				ServiceProviderEngineScope.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsVavtiInLi1ObtoUnique.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceProviderEngineScope.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsVavtiInLi1ObtoUnique>.NativeClassPtr, "<>t__builder");
				ServiceProviderEngineScope.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsVavtiInLi1ObtoUnique.NativeFieldInfoPtr_vt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceProviderEngineScope.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsVavtiInLi1ObtoUnique>.NativeClassPtr, "vt");
				ServiceProviderEngineScope.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsVavtiInLi1ObtoUnique.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceProviderEngineScope.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsVavtiInLi1ObtoUnique>.NativeClassPtr, "i");
				ServiceProviderEngineScope.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsVavtiInLi1ObtoUnique.NativeFieldInfoPtr_toDispose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceProviderEngineScope.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsVavtiInLi1ObtoUnique>.NativeClassPtr, "toDispose");
				ServiceProviderEngineScope.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsVavtiInLi1ObtoUnique.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceProviderEngineScope.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsVavtiInLi1ObtoUnique>.NativeClassPtr, "<>u__1");
				ServiceProviderEngineScope.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsVavtiInLi1ObtoUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProviderEngineScope.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsVavtiInLi1ObtoUnique>.NativeClassPtr, 100663596);
				ServiceProviderEngineScope.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsVavtiInLi1ObtoUnique.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProviderEngineScope.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsVavtiInLi1ObtoUnique>.NativeClassPtr, 100663597);
			}

			// Token: 0x060002C1 RID: 705 RVA: 0x0000DC0C File Offset: 0x0000BE0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205005, XrefRangeEnd = 1205051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProviderEngineScope.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsVavtiInLi1ObtoUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002C2 RID: 706 RVA: 0x0000DC44 File Offset: 0x0000BE44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205051, XrefRangeEnd = 1205052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProviderEngineScope.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsVavtiInLi1ObtoUnique.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060002C3 RID: 707 RVA: 0x00003155 File Offset: 0x00001355
			public ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsVavtiInLi1ObtoUnique(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060002C4 RID: 708 RVA: 0x0000315E File Offset: 0x0000135E
			public ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsVavtiInLi1ObtoUnique()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServiceProviderEngineScope.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsVavtiInLi1ObtoUnique>.NativeClassPtr))
			{
			}

			// Token: 0x170000D6 RID: 214
			// (get) Token: 0x060002C5 RID: 709 RVA: 0x0000DC8C File Offset: 0x0000BE8C
			// (set) Token: 0x060002C6 RID: 710 RVA: 0x00003170 File Offset: 0x00001370
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProviderEngineScope.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsVavtiInLi1ObtoUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProviderEngineScope.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsVavtiInLi1ObtoUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000D7 RID: 215
			// (get) Token: 0x060002C7 RID: 711 RVA: 0x0000DCB4 File Offset: 0x0000BEB4
			// (set) Token: 0x060002C8 RID: 712 RVA: 0x0000318B File Offset: 0x0000138B
			public AsyncValueTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProviderEngineScope.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsVavtiInLi1ObtoUnique.NativeFieldInfoPtr___t__builder);
					return new AsyncValueTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProviderEngineScope.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsVavtiInLi1ObtoUnique.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170000D8 RID: 216
			// (get) Token: 0x060002C9 RID: 713 RVA: 0x0000DCE4 File Offset: 0x0000BEE4
			// (set) Token: 0x060002CA RID: 714 RVA: 0x000031B9 File Offset: 0x000013B9
			public ValueTask vt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProviderEngineScope.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsVavtiInLi1ObtoUnique.NativeFieldInfoPtr_vt);
					return new ValueTask(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTask>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProviderEngineScope.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsVavtiInLi1ObtoUnique.NativeFieldInfoPtr_vt), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTask>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170000D9 RID: 217
			// (get) Token: 0x060002CB RID: 715 RVA: 0x0000DD14 File Offset: 0x0000BF14
			// (set) Token: 0x060002CC RID: 716 RVA: 0x000031E7 File Offset: 0x000013E7
			public unsafe int i
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProviderEngineScope.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsVavtiInLi1ObtoUnique.NativeFieldInfoPtr_i);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProviderEngineScope.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsVavtiInLi1ObtoUnique.NativeFieldInfoPtr_i)) = value;
				}
			}

			// Token: 0x170000DA RID: 218
			// (get) Token: 0x060002CD RID: 717 RVA: 0x0000DD3C File Offset: 0x0000BF3C
			// (set) Token: 0x060002CE RID: 718 RVA: 0x00003202 File Offset: 0x00001402
			public unsafe List<Object> toDispose
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProviderEngineScope.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsVavtiInLi1ObtoUnique.NativeFieldInfoPtr_toDispose);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProviderEngineScope.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsVavtiInLi1ObtoUnique.NativeFieldInfoPtr_toDispose), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000DB RID: 219
			// (get) Token: 0x060002CF RID: 719 RVA: 0x0000DD6C File Offset: 0x0000BF6C
			// (set) Token: 0x060002D0 RID: 720 RVA: 0x00003221 File Offset: 0x00001421
			public ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProviderEngineScope.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsVavtiInLi1ObtoUnique.NativeFieldInfoPtr___u__1);
					return new ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProviderEngineScope.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsVavtiInLi1ObtoUnique.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040001E3 RID: 483
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040001E4 RID: 484
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040001E5 RID: 485
			private static readonly IntPtr NativeFieldInfoPtr_vt;

			// Token: 0x040001E6 RID: 486
			private static readonly IntPtr NativeFieldInfoPtr_i;

			// Token: 0x040001E7 RID: 487
			private static readonly IntPtr NativeFieldInfoPtr_toDispose;

			// Token: 0x040001E8 RID: 488
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040001E9 RID: 489
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040001EA RID: 490
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000043 RID: 67
		[ObfuscatedName("Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceProviderEngineScope+<>c__DisplayClass24_0")]
		public sealed class __c__DisplayClass24_0 : Object
		{
			// Token: 0x060002D1 RID: 721 RVA: 0x0000DD9C File Offset: 0x0000BF9C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass24_0()
			{
				Il2CppClassPointerStore<ServiceProviderEngineScope.__c__DisplayClass24_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServiceProviderEngineScope>.NativeClassPtr, "<>c__DisplayClass24_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServiceProviderEngineScope.__c__DisplayClass24_0>.NativeClassPtr);
				ServiceProviderEngineScope.__c__DisplayClass24_0.NativeFieldInfoPtr_localService = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceProviderEngineScope.__c__DisplayClass24_0>.NativeClassPtr, "localService");
				ServiceProviderEngineScope.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProviderEngineScope.__c__DisplayClass24_0>.NativeClassPtr, 100663598);
				ServiceProviderEngineScope.__c__DisplayClass24_0.NativeMethodInfoPtr__CaptureDisposable_b__0_Internal_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceProviderEngineScope.__c__DisplayClass24_0>.NativeClassPtr, 100663599);
			}

			// Token: 0x060002D2 RID: 722 RVA: 0x0000DE04 File Offset: 0x0000C004
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass24_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServiceProviderEngineScope.__c__DisplayClass24_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProviderEngineScope.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002D3 RID: 723 RVA: 0x0000DE40 File Offset: 0x0000C040
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205052, XrefRangeEnd = 1205063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Task _CaptureDisposable_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceProviderEngineScope.__c__DisplayClass24_0.NativeMethodInfoPtr__CaptureDisposable_b__0_Internal_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}

			// Token: 0x060002D4 RID: 724 RVA: 0x0000324F File Offset: 0x0000144F
			public __c__DisplayClass24_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000DC RID: 220
			// (get) Token: 0x060002D5 RID: 725 RVA: 0x0000DE80 File Offset: 0x0000C080
			// (set) Token: 0x060002D6 RID: 726 RVA: 0x00003258 File Offset: 0x00001458
			public unsafe Object localService
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProviderEngineScope.__c__DisplayClass24_0.NativeFieldInfoPtr_localService);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceProviderEngineScope.__c__DisplayClass24_0.NativeFieldInfoPtr_localService), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001EB RID: 491
			private static readonly IntPtr NativeFieldInfoPtr_localService;

			// Token: 0x040001EC RID: 492
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040001ED RID: 493
			private static readonly IntPtr NativeMethodInfoPtr__CaptureDisposable_b__0_Internal_Task_0;
		}
	}
}
