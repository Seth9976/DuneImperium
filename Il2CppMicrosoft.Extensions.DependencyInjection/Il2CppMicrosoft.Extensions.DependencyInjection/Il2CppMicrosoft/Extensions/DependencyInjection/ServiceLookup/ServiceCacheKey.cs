using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.DependencyInjection.ServiceLookup
{
	// Token: 0x02000023 RID: 35
	public sealed class ServiceCacheKey : ValueType
	{
		// Token: 0x0600016B RID: 363 RVA: 0x000093AC File Offset: 0x000075AC
		// Note: this type is marked as 'beforefieldinit'.
		static ServiceCacheKey()
		{
			Il2CppClassPointerStore<ServiceCacheKey>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.DependencyInjection.dll", "Microsoft.Extensions.DependencyInjection.ServiceLookup", "ServiceCacheKey");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServiceCacheKey>.NativeClassPtr);
			ServiceCacheKey.NativeFieldInfoPtr__ServiceIdentifier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceCacheKey>.NativeClassPtr, "<ServiceIdentifier>k__BackingField");
			ServiceCacheKey.NativeFieldInfoPtr__Slot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceCacheKey>.NativeClassPtr, "<Slot>k__BackingField");
			ServiceCacheKey.NativeMethodInfoPtr_get_ServiceIdentifier_Public_get_ServiceIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCacheKey>.NativeClassPtr, 100663544);
			ServiceCacheKey.NativeMethodInfoPtr_get_Slot_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCacheKey>.NativeClassPtr, 100663545);
			ServiceCacheKey.NativeMethodInfoPtr__ctor_Public_Void_Object_Type_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCacheKey>.NativeClassPtr, 100663546);
			ServiceCacheKey.NativeMethodInfoPtr__ctor_Public_Void_ServiceIdentifier_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCacheKey>.NativeClassPtr, 100663547);
			ServiceCacheKey.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ServiceCacheKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCacheKey>.NativeClassPtr, 100663548);
			ServiceCacheKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCacheKey>.NativeClassPtr, 100663549);
			ServiceCacheKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceCacheKey>.NativeClassPtr, 100663550);
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600016C RID: 364 RVA: 0x00009490 File Offset: 0x00007690
		public unsafe ServiceIdentifier ServiceIdentifier
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 599686, RefRangeEnd = 599697, XrefRangeStart = 599686, XrefRangeEnd = 599697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCacheKey.NativeMethodInfoPtr_get_ServiceIdentifier_Public_get_ServiceIdentifier_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ServiceIdentifier(intPtr);
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600016D RID: 365 RVA: 0x000094CC File Offset: 0x000076CC
		public unsafe int Slot
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCacheKey.NativeMethodInfoPtr_get_Slot_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00009510 File Offset: 0x00007710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204782, XrefRangeEnd = 1204785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServiceCacheKey(Object key, Type type, int slot)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServiceCacheKey>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref slot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCacheKey.NativeMethodInfoPtr__ctor_Public_Void_Object_Type_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00009580 File Offset: 0x00007780
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1204786, RefRangeEnd = 1204787, XrefRangeStart = 1204785, XrefRangeEnd = 1204786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServiceCacheKey(ServiceIdentifier type, int slot)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServiceCacheKey>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(type));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref slot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCacheKey.NativeMethodInfoPtr__ctor_Public_Void_ServiceIdentifier_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x000095E4 File Offset: 0x000077E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1204796, RefRangeEnd = 1204797, XrefRangeStart = 1204787, XrefRangeEnd = 1204796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(ServiceCacheKey other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCacheKey.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ServiceCacheKey_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0000963C File Offset: 0x0000783C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204797, XrefRangeEnd = 1204801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCacheKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00009690 File Offset: 0x00007890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204801, XrefRangeEnd = 1204802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceCacheKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x000027C9 File Offset: 0x000009C9
		public ServiceCacheKey(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000174 RID: 372 RVA: 0x000027D2 File Offset: 0x000009D2
		public ServiceCacheKey()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServiceCacheKey>.NativeClassPtr))
		{
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000175 RID: 373 RVA: 0x000096D4 File Offset: 0x000078D4
		// (set) Token: 0x06000176 RID: 374 RVA: 0x000027E4 File Offset: 0x000009E4
		public ServiceIdentifier _ServiceIdentifier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCacheKey.NativeFieldInfoPtr__ServiceIdentifier_k__BackingField);
				return new ServiceIdentifier(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServiceIdentifier>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCacheKey.NativeFieldInfoPtr__ServiceIdentifier_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServiceIdentifier>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000177 RID: 375 RVA: 0x00009704 File Offset: 0x00007904
		// (set) Token: 0x06000178 RID: 376 RVA: 0x00002812 File Offset: 0x00000A12
		public unsafe int _Slot_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCacheKey.NativeFieldInfoPtr__Slot_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceCacheKey.NativeFieldInfoPtr__Slot_k__BackingField)) = value;
			}
		}

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeFieldInfoPtr__ServiceIdentifier_k__BackingField;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeFieldInfoPtr__Slot_k__BackingField;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeMethodInfoPtr_get_ServiceIdentifier_Public_get_ServiceIdentifier_0;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeMethodInfoPtr_get_Slot_Public_get_Int32_0;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_Type_Int32_0;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ServiceIdentifier_Int32_0;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ServiceCacheKey_0;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
