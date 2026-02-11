using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.DependencyInjection.ServiceLookup
{
	// Token: 0x02000017 RID: 23
	public sealed class RuntimeResolverContext : ValueType
	{
		// Token: 0x060000E7 RID: 231 RVA: 0x00006EE4 File Offset: 0x000050E4
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeResolverContext()
		{
			Il2CppClassPointerStore<RuntimeResolverContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.DependencyInjection.dll", "Microsoft.Extensions.DependencyInjection.ServiceLookup", "RuntimeResolverContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeResolverContext>.NativeClassPtr);
			RuntimeResolverContext.NativeFieldInfoPtr__Scope_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeResolverContext>.NativeClassPtr, "<Scope>k__BackingField");
			RuntimeResolverContext.NativeFieldInfoPtr__AcquiredLocks_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeResolverContext>.NativeClassPtr, "<AcquiredLocks>k__BackingField");
			RuntimeResolverContext.NativeMethodInfoPtr_get_Scope_Public_get_ServiceProviderEngineScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeResolverContext>.NativeClassPtr, 100663468);
			RuntimeResolverContext.NativeMethodInfoPtr_set_Scope_Public_set_Void_ServiceProviderEngineScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeResolverContext>.NativeClassPtr, 100663469);
			RuntimeResolverContext.NativeMethodInfoPtr_get_AcquiredLocks_Public_get_RuntimeResolverLock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeResolverContext>.NativeClassPtr, 100663470);
			RuntimeResolverContext.NativeMethodInfoPtr_set_AcquiredLocks_Public_set_Void_RuntimeResolverLock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeResolverContext>.NativeClassPtr, 100663471);
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00006F8C File Offset: 0x0000518C
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x00006FD0 File Offset: 0x000051D0
		public unsafe ServiceProviderEngineScope Scope
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeResolverContext.NativeMethodInfoPtr_get_Scope_Public_get_ServiceProviderEngineScope_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServiceProviderEngineScope>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeResolverContext.NativeMethodInfoPtr_set_Scope_Public_set_Void_ServiceProviderEngineScope_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00007018 File Offset: 0x00005218
		// (set) Token: 0x060000EB RID: 235 RVA: 0x0000705C File Offset: 0x0000525C
		public unsafe RuntimeResolverLock AcquiredLocks
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeResolverContext.NativeMethodInfoPtr_get_AcquiredLocks_Public_get_RuntimeResolverLock_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 310301, RefRangeEnd = 310309, XrefRangeStart = 310301, XrefRangeEnd = 310309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeResolverContext.NativeMethodInfoPtr_set_AcquiredLocks_Public_set_Void_RuntimeResolverLock_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000024CD File Offset: 0x000006CD
		public RuntimeResolverContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000024D6 File Offset: 0x000006D6
		public RuntimeResolverContext()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeResolverContext>.NativeClassPtr))
		{
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000EE RID: 238 RVA: 0x000070A0 File Offset: 0x000052A0
		// (set) Token: 0x060000EF RID: 239 RVA: 0x000024E8 File Offset: 0x000006E8
		public unsafe ServiceProviderEngineScope _Scope_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeResolverContext.NativeFieldInfoPtr__Scope_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServiceProviderEngineScope>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeResolverContext.NativeFieldInfoPtr__Scope_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x000070D0 File Offset: 0x000052D0
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x00002507 File Offset: 0x00000707
		public unsafe RuntimeResolverLock _AcquiredLocks_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeResolverContext.NativeFieldInfoPtr__AcquiredLocks_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeResolverContext.NativeFieldInfoPtr__AcquiredLocks_k__BackingField)) = value;
			}
		}

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeFieldInfoPtr__Scope_k__BackingField;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeFieldInfoPtr__AcquiredLocks_k__BackingField;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeMethodInfoPtr_get_Scope_Public_get_ServiceProviderEngineScope_0;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeMethodInfoPtr_set_Scope_Public_set_Void_ServiceProviderEngineScope_0;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeMethodInfoPtr_get_AcquiredLocks_Public_get_RuntimeResolverLock_0;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeMethodInfoPtr_set_AcquiredLocks_Public_set_Void_RuntimeResolverLock_0;
	}
}
