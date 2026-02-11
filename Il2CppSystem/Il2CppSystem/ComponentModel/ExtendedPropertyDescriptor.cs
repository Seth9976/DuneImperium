using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x0200010D RID: 269
	public sealed class ExtendedPropertyDescriptor : PropertyDescriptor
	{
		// Token: 0x060010D5 RID: 4309 RVA: 0x0005BFA8 File Offset: 0x0005A1A8
		// Note: this type is marked as 'beforefieldinit'.
		static ExtendedPropertyDescriptor()
		{
			Il2CppClassPointerStore<ExtendedPropertyDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "ExtendedPropertyDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExtendedPropertyDescriptor>.NativeClassPtr);
			ExtendedPropertyDescriptor.NativeFieldInfoPtr__extenderInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtendedPropertyDescriptor>.NativeClassPtr, "_extenderInfo");
			ExtendedPropertyDescriptor.NativeFieldInfoPtr__provider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtendedPropertyDescriptor>.NativeClassPtr, "_provider");
			ExtendedPropertyDescriptor.NativeMethodInfoPtr__ctor_Public_Void_ReflectPropertyDescriptor_Type_IExtenderProvider_Il2CppReferenceArray_1_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedPropertyDescriptor>.NativeClassPtr, 100665736);
			ExtendedPropertyDescriptor.NativeMethodInfoPtr_CanResetValue_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedPropertyDescriptor>.NativeClassPtr, 100665737);
			ExtendedPropertyDescriptor.NativeMethodInfoPtr_get_ComponentType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedPropertyDescriptor>.NativeClassPtr, 100665738);
			ExtendedPropertyDescriptor.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedPropertyDescriptor>.NativeClassPtr, 100665739);
			ExtendedPropertyDescriptor.NativeMethodInfoPtr_get_PropertyType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedPropertyDescriptor>.NativeClassPtr, 100665740);
			ExtendedPropertyDescriptor.NativeMethodInfoPtr_get_DisplayName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedPropertyDescriptor>.NativeClassPtr, 100665741);
			ExtendedPropertyDescriptor.NativeMethodInfoPtr_GetValue_Public_Virtual_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedPropertyDescriptor>.NativeClassPtr, 100665742);
			ExtendedPropertyDescriptor.NativeMethodInfoPtr_ResetValue_Public_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedPropertyDescriptor>.NativeClassPtr, 100665743);
			ExtendedPropertyDescriptor.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedPropertyDescriptor>.NativeClassPtr, 100665744);
			ExtendedPropertyDescriptor.NativeMethodInfoPtr_ShouldSerializeValue_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedPropertyDescriptor>.NativeClassPtr, 100665745);
		}

		// Token: 0x060010D6 RID: 4310 RVA: 0x0005C0C8 File Offset: 0x0005A2C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 459221, RefRangeEnd = 459222, XrefRangeStart = 459185, XrefRangeEnd = 459221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExtendedPropertyDescriptor(ReflectPropertyDescriptor extenderInfo, Type receiverType, IExtenderProvider provider, Il2CppReferenceArray<Attribute> attributes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExtendedPropertyDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(extenderInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(receiverType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtendedPropertyDescriptor.NativeMethodInfoPtr__ctor_Public_Void_ReflectPropertyDescriptor_Type_IExtenderProvider_Il2CppReferenceArray_1_Attribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010D7 RID: 4311 RVA: 0x0005C14C File Offset: 0x0005A34C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459222, XrefRangeEnd = 459224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanResetValue(Object comp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtendedPropertyDescriptor.NativeMethodInfoPtr_CanResetValue_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x060010D8 RID: 4312 RVA: 0x0005C19C File Offset: 0x0005A39C
		public unsafe override Type ComponentType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459224, XrefRangeEnd = 459225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtendedPropertyDescriptor.NativeMethodInfoPtr_get_ComponentType_Public_Virtual_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x060010D9 RID: 4313 RVA: 0x0005C1DC File Offset: 0x0005A3DC
		public unsafe override bool IsReadOnly
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459225, XrefRangeEnd = 459236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtendedPropertyDescriptor.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x060010DA RID: 4314 RVA: 0x0005C218 File Offset: 0x0005A418
		public unsafe override Type PropertyType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459236, XrefRangeEnd = 459237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtendedPropertyDescriptor.NativeMethodInfoPtr_get_PropertyType_Public_Virtual_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x060010DB RID: 4315 RVA: 0x0005C258 File Offset: 0x0005A458
		public unsafe override string DisplayName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459237, XrefRangeEnd = 459263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtendedPropertyDescriptor.NativeMethodInfoPtr_get_DisplayName_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060010DC RID: 4316 RVA: 0x0005C290 File Offset: 0x0005A490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459263, XrefRangeEnd = 459265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object GetValue(Object comp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtendedPropertyDescriptor.NativeMethodInfoPtr_GetValue_Public_Virtual_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x0005C2E0 File Offset: 0x0005A4E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459265, XrefRangeEnd = 459266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ResetValue(Object comp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtendedPropertyDescriptor.NativeMethodInfoPtr_ResetValue_Public_Virtual_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010DE RID: 4318 RVA: 0x0005C324 File Offset: 0x0005A524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459266, XrefRangeEnd = 459267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetValue(Object component, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtendedPropertyDescriptor.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010DF RID: 4319 RVA: 0x0005C378 File Offset: 0x0005A578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459267, XrefRangeEnd = 459269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldSerializeValue(Object comp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtendedPropertyDescriptor.NativeMethodInfoPtr_ShouldSerializeValue_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010E0 RID: 4320 RVA: 0x00007FBF File Offset: 0x000061BF
		public ExtendedPropertyDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x060010E1 RID: 4321 RVA: 0x0005C3C8 File Offset: 0x0005A5C8
		// (set) Token: 0x060010E2 RID: 4322 RVA: 0x00007FC8 File Offset: 0x000061C8
		public unsafe ReflectPropertyDescriptor _extenderInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtendedPropertyDescriptor.NativeFieldInfoPtr__extenderInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReflectPropertyDescriptor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtendedPropertyDescriptor.NativeFieldInfoPtr__extenderInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x060010E3 RID: 4323 RVA: 0x0005C3F8 File Offset: 0x0005A5F8
		// (set) Token: 0x060010E4 RID: 4324 RVA: 0x00007FE7 File Offset: 0x000061E7
		public unsafe IExtenderProvider _provider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtendedPropertyDescriptor.NativeFieldInfoPtr__provider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IExtenderProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtendedPropertyDescriptor.NativeFieldInfoPtr__provider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D80 RID: 3456
		private static readonly IntPtr NativeFieldInfoPtr__extenderInfo;

		// Token: 0x04000D81 RID: 3457
		private static readonly IntPtr NativeFieldInfoPtr__provider;

		// Token: 0x04000D82 RID: 3458
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ReflectPropertyDescriptor_Type_IExtenderProvider_Il2CppReferenceArray_1_Attribute_0;

		// Token: 0x04000D83 RID: 3459
		private static readonly IntPtr NativeMethodInfoPtr_CanResetValue_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000D84 RID: 3460
		private static readonly IntPtr NativeMethodInfoPtr_get_ComponentType_Public_Virtual_get_Type_0;

		// Token: 0x04000D85 RID: 3461
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;

		// Token: 0x04000D86 RID: 3462
		private static readonly IntPtr NativeMethodInfoPtr_get_PropertyType_Public_Virtual_get_Type_0;

		// Token: 0x04000D87 RID: 3463
		private static readonly IntPtr NativeMethodInfoPtr_get_DisplayName_Public_Virtual_get_String_0;

		// Token: 0x04000D88 RID: 3464
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Object_Object_0;

		// Token: 0x04000D89 RID: 3465
		private static readonly IntPtr NativeMethodInfoPtr_ResetValue_Public_Virtual_Void_Object_0;

		// Token: 0x04000D8A RID: 3466
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_Object_0;

		// Token: 0x04000D8B RID: 3467
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSerializeValue_Public_Virtual_Boolean_Object_0;
	}
}
