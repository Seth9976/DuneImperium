using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x0200010E RID: 270
	public sealed class ExtenderProvidedPropertyAttribute : Attribute
	{
		// Token: 0x060010E5 RID: 4325 RVA: 0x0005C428 File Offset: 0x0005A628
		// Note: this type is marked as 'beforefieldinit'.
		static ExtenderProvidedPropertyAttribute()
		{
			Il2CppClassPointerStore<ExtenderProvidedPropertyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "ExtenderProvidedPropertyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExtenderProvidedPropertyAttribute>.NativeClassPtr);
			ExtenderProvidedPropertyAttribute.NativeFieldInfoPtr__ExtenderProperty_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtenderProvidedPropertyAttribute>.NativeClassPtr, "<ExtenderProperty>k__BackingField");
			ExtenderProvidedPropertyAttribute.NativeFieldInfoPtr__Provider_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtenderProvidedPropertyAttribute>.NativeClassPtr, "<Provider>k__BackingField");
			ExtenderProvidedPropertyAttribute.NativeFieldInfoPtr__ReceiverType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtenderProvidedPropertyAttribute>.NativeClassPtr, "<ReceiverType>k__BackingField");
			ExtenderProvidedPropertyAttribute.NativeMethodInfoPtr_Create_Internal_Static_ExtenderProvidedPropertyAttribute_PropertyDescriptor_Type_IExtenderProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtenderProvidedPropertyAttribute>.NativeClassPtr, 100665746);
			ExtenderProvidedPropertyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtenderProvidedPropertyAttribute>.NativeClassPtr, 100665747);
			ExtenderProvidedPropertyAttribute.NativeMethodInfoPtr_get_ExtenderProperty_Public_get_PropertyDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtenderProvidedPropertyAttribute>.NativeClassPtr, 100665748);
			ExtenderProvidedPropertyAttribute.NativeMethodInfoPtr_set_ExtenderProperty_Private_set_Void_PropertyDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtenderProvidedPropertyAttribute>.NativeClassPtr, 100665749);
			ExtenderProvidedPropertyAttribute.NativeMethodInfoPtr_get_Provider_Public_get_IExtenderProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtenderProvidedPropertyAttribute>.NativeClassPtr, 100665750);
			ExtenderProvidedPropertyAttribute.NativeMethodInfoPtr_set_Provider_Private_set_Void_IExtenderProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtenderProvidedPropertyAttribute>.NativeClassPtr, 100665751);
			ExtenderProvidedPropertyAttribute.NativeMethodInfoPtr_get_ReceiverType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtenderProvidedPropertyAttribute>.NativeClassPtr, 100665752);
			ExtenderProvidedPropertyAttribute.NativeMethodInfoPtr_set_ReceiverType_Private_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtenderProvidedPropertyAttribute>.NativeClassPtr, 100665753);
			ExtenderProvidedPropertyAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtenderProvidedPropertyAttribute>.NativeClassPtr, 100665754);
			ExtenderProvidedPropertyAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtenderProvidedPropertyAttribute>.NativeClassPtr, 100665755);
			ExtenderProvidedPropertyAttribute.NativeMethodInfoPtr_IsDefaultAttribute_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtenderProvidedPropertyAttribute>.NativeClassPtr, 100665756);
		}

		// Token: 0x060010E6 RID: 4326 RVA: 0x0005C570 File Offset: 0x0005A770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459269, XrefRangeEnd = 459276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ExtenderProvidedPropertyAttribute Create(PropertyDescriptor extenderProperty, Type receiverType, IExtenderProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(extenderProperty);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(receiverType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtenderProvidedPropertyAttribute.NativeMethodInfoPtr_Create_Internal_Static_ExtenderProvidedPropertyAttribute_PropertyDescriptor_Type_IExtenderProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExtenderProvidedPropertyAttribute>(intPtr3) : null;
		}

		// Token: 0x060010E7 RID: 4327 RVA: 0x0005C5D8 File Offset: 0x0005A7D8
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExtenderProvidedPropertyAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExtenderProvidedPropertyAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtenderProvidedPropertyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x060010E8 RID: 4328 RVA: 0x0005C614 File Offset: 0x0005A814
		// (set) Token: 0x060010E9 RID: 4329 RVA: 0x0005C654 File Offset: 0x0005A854
		public unsafe PropertyDescriptor ExtenderProperty
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtenderProvidedPropertyAttribute.NativeMethodInfoPtr_get_ExtenderProperty_Public_get_PropertyDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyDescriptor>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtenderProvidedPropertyAttribute.NativeMethodInfoPtr_set_ExtenderProperty_Private_set_Void_PropertyDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x060010EA RID: 4330 RVA: 0x0005C698 File Offset: 0x0005A898
		// (set) Token: 0x060010EB RID: 4331 RVA: 0x0005C6D8 File Offset: 0x0005A8D8
		public unsafe IExtenderProvider Provider
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtenderProvidedPropertyAttribute.NativeMethodInfoPtr_get_Provider_Public_get_IExtenderProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IExtenderProvider>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtenderProvidedPropertyAttribute.NativeMethodInfoPtr_set_Provider_Private_set_Void_IExtenderProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x060010EC RID: 4332 RVA: 0x0005C71C File Offset: 0x0005A91C
		// (set) Token: 0x060010ED RID: 4333 RVA: 0x0005C75C File Offset: 0x0005A95C
		public unsafe Type ReceiverType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtenderProvidedPropertyAttribute.NativeMethodInfoPtr_get_ReceiverType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtenderProvidedPropertyAttribute.NativeMethodInfoPtr_set_ReceiverType_Private_set_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060010EE RID: 4334 RVA: 0x0005C7A0 File Offset: 0x0005A9A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459276, XrefRangeEnd = 459278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtenderProvidedPropertyAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010EF RID: 4335 RVA: 0x0005C7F0 File Offset: 0x0005A9F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtenderProvidedPropertyAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x0005C82C File Offset: 0x0005AA2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459278, XrefRangeEnd = 459282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsDefaultAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtenderProvidedPropertyAttribute.NativeMethodInfoPtr_IsDefaultAttribute_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010F1 RID: 4337 RVA: 0x00008006 File Offset: 0x00006206
		public ExtenderProvidedPropertyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x060010F2 RID: 4338 RVA: 0x0005C868 File Offset: 0x0005AA68
		// (set) Token: 0x060010F3 RID: 4339 RVA: 0x0000800F File Offset: 0x0000620F
		public unsafe PropertyDescriptor _ExtenderProperty_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtenderProvidedPropertyAttribute.NativeFieldInfoPtr__ExtenderProperty_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyDescriptor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtenderProvidedPropertyAttribute.NativeFieldInfoPtr__ExtenderProperty_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x060010F4 RID: 4340 RVA: 0x0005C898 File Offset: 0x0005AA98
		// (set) Token: 0x060010F5 RID: 4341 RVA: 0x0000802E File Offset: 0x0000622E
		public unsafe IExtenderProvider _Provider_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtenderProvidedPropertyAttribute.NativeFieldInfoPtr__Provider_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IExtenderProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtenderProvidedPropertyAttribute.NativeFieldInfoPtr__Provider_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x060010F6 RID: 4342 RVA: 0x0005C8C8 File Offset: 0x0005AAC8
		// (set) Token: 0x060010F7 RID: 4343 RVA: 0x0000804D File Offset: 0x0000624D
		public unsafe Type _ReceiverType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtenderProvidedPropertyAttribute.NativeFieldInfoPtr__ReceiverType_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtenderProvidedPropertyAttribute.NativeFieldInfoPtr__ReceiverType_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D8C RID: 3468
		private static readonly IntPtr NativeFieldInfoPtr__ExtenderProperty_k__BackingField;

		// Token: 0x04000D8D RID: 3469
		private static readonly IntPtr NativeFieldInfoPtr__Provider_k__BackingField;

		// Token: 0x04000D8E RID: 3470
		private static readonly IntPtr NativeFieldInfoPtr__ReceiverType_k__BackingField;

		// Token: 0x04000D8F RID: 3471
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_ExtenderProvidedPropertyAttribute_PropertyDescriptor_Type_IExtenderProvider_0;

		// Token: 0x04000D90 RID: 3472
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000D91 RID: 3473
		private static readonly IntPtr NativeMethodInfoPtr_get_ExtenderProperty_Public_get_PropertyDescriptor_0;

		// Token: 0x04000D92 RID: 3474
		private static readonly IntPtr NativeMethodInfoPtr_set_ExtenderProperty_Private_set_Void_PropertyDescriptor_0;

		// Token: 0x04000D93 RID: 3475
		private static readonly IntPtr NativeMethodInfoPtr_get_Provider_Public_get_IExtenderProvider_0;

		// Token: 0x04000D94 RID: 3476
		private static readonly IntPtr NativeMethodInfoPtr_set_Provider_Private_set_Void_IExtenderProvider_0;

		// Token: 0x04000D95 RID: 3477
		private static readonly IntPtr NativeMethodInfoPtr_get_ReceiverType_Public_get_Type_0;

		// Token: 0x04000D96 RID: 3478
		private static readonly IntPtr NativeMethodInfoPtr_set_ReceiverType_Private_set_Void_Type_0;

		// Token: 0x04000D97 RID: 3479
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000D98 RID: 3480
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000D99 RID: 3481
		private static readonly IntPtr NativeMethodInfoPtr_IsDefaultAttribute_Public_Virtual_Boolean_0;
	}
}
