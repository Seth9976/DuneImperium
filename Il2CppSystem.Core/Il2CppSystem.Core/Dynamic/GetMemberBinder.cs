using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Dynamic
{
	// Token: 0x0200011F RID: 287
	public class GetMemberBinder : DynamicMetaObjectBinder
	{
		// Token: 0x0600110C RID: 4364 RVA: 0x0005949C File Offset: 0x0005769C
		// Note: this type is marked as 'beforefieldinit'.
		static GetMemberBinder()
		{
			Il2CppClassPointerStore<GetMemberBinder>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Dynamic", "GetMemberBinder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetMemberBinder>.NativeClassPtr);
			GetMemberBinder.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetMemberBinder>.NativeClassPtr, "<Name>k__BackingField");
			GetMemberBinder.NativeFieldInfoPtr__IgnoreCase_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetMemberBinder>.NativeClassPtr, "<IgnoreCase>k__BackingField");
			GetMemberBinder.NativeMethodInfoPtr__ctor_Protected_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetMemberBinder>.NativeClassPtr, 100666542);
			GetMemberBinder.NativeMethodInfoPtr_get_ReturnType_Public_Virtual_Final_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetMemberBinder>.NativeClassPtr, 100666543);
			GetMemberBinder.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetMemberBinder>.NativeClassPtr, 100666544);
			GetMemberBinder.NativeMethodInfoPtr_get_IgnoreCase_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetMemberBinder>.NativeClassPtr, 100666545);
			GetMemberBinder.NativeMethodInfoPtr_FallbackGetMember_Public_DynamicMetaObject_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetMemberBinder>.NativeClassPtr, 100666546);
			GetMemberBinder.NativeMethodInfoPtr_FallbackGetMember_Public_Abstract_Virtual_New_DynamicMetaObject_DynamicMetaObject_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetMemberBinder>.NativeClassPtr, 100666547);
			GetMemberBinder.NativeMethodInfoPtr_Bind_Public_Virtual_Final_DynamicMetaObject_DynamicMetaObject_Il2CppReferenceArray_1_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetMemberBinder>.NativeClassPtr, 100666548);
			GetMemberBinder.NativeMethodInfoPtr_get_IsStandardBinder_Internal_Virtual_Final_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetMemberBinder>.NativeClassPtr, 100666549);
		}

		// Token: 0x0600110D RID: 4365 RVA: 0x00059594 File Offset: 0x00057794
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1029488, RefRangeEnd = 1029490, XrefRangeStart = 1029484, XrefRangeEnd = 1029488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GetMemberBinder(string name, bool ignoreCase)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetMemberBinder>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetMemberBinder.NativeMethodInfoPtr__ctor_Protected_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x0600110E RID: 4366 RVA: 0x000595F0 File Offset: 0x000577F0
		public unsafe override Type ReturnType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029490, XrefRangeEnd = 1029496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetMemberBinder.NativeMethodInfoPtr_get_ReturnType_Public_Virtual_Final_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x0600110F RID: 4367 RVA: 0x00059630 File Offset: 0x00057830
		public unsafe string Name
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetMemberBinder.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06001110 RID: 4368 RVA: 0x00059668 File Offset: 0x00057868
		public unsafe bool IgnoreCase
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetMemberBinder.NativeMethodInfoPtr_get_IgnoreCase_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001111 RID: 4369 RVA: 0x000596A4 File Offset: 0x000578A4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 460546, RefRangeEnd = 460550, XrefRangeStart = 460546, XrefRangeEnd = 460550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicMetaObject FallbackGetMember(DynamicMetaObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetMemberBinder.NativeMethodInfoPtr_FallbackGetMember_Public_DynamicMetaObject_DynamicMetaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
			}
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x000596F4 File Offset: 0x000578F4
		[CallerCount(0)]
		public unsafe virtual DynamicMetaObject FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(errorSuggestion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GetMemberBinder.NativeMethodInfoPtr_FallbackGetMember_Public_Abstract_Virtual_New_DynamicMetaObject_DynamicMetaObject_DynamicMetaObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x00059764 File Offset: 0x00057964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029496, XrefRangeEnd = 1029508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DynamicMetaObject Bind(DynamicMetaObject target, Il2CppReferenceArray<DynamicMetaObject> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetMemberBinder.NativeMethodInfoPtr_Bind_Public_Virtual_Final_DynamicMetaObject_DynamicMetaObject_Il2CppReferenceArray_1_DynamicMetaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06001114 RID: 4372 RVA: 0x000597C8 File Offset: 0x000579C8
		public unsafe override bool IsStandardBinder
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetMemberBinder.NativeMethodInfoPtr_get_IsStandardBinder_Internal_Virtual_Final_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x000073BD File Offset: 0x000055BD
		public GetMemberBinder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06001116 RID: 4374 RVA: 0x00059804 File Offset: 0x00057A04
		// (set) Token: 0x06001117 RID: 4375 RVA: 0x000073C6 File Offset: 0x000055C6
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetMemberBinder.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetMemberBinder.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06001118 RID: 4376 RVA: 0x0005982C File Offset: 0x00057A2C
		// (set) Token: 0x06001119 RID: 4377 RVA: 0x000073E5 File Offset: 0x000055E5
		public unsafe bool _IgnoreCase_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetMemberBinder.NativeFieldInfoPtr__IgnoreCase_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetMemberBinder.NativeFieldInfoPtr__IgnoreCase_k__BackingField)) = value;
			}
		}

		// Token: 0x04000C40 RID: 3136
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x04000C41 RID: 3137
		private static readonly IntPtr NativeFieldInfoPtr__IgnoreCase_k__BackingField;

		// Token: 0x04000C42 RID: 3138
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_String_Boolean_0;

		// Token: 0x04000C43 RID: 3139
		private static readonly IntPtr NativeMethodInfoPtr_get_ReturnType_Public_Virtual_Final_get_Type_0;

		// Token: 0x04000C44 RID: 3140
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04000C45 RID: 3141
		private static readonly IntPtr NativeMethodInfoPtr_get_IgnoreCase_Public_get_Boolean_0;

		// Token: 0x04000C46 RID: 3142
		private static readonly IntPtr NativeMethodInfoPtr_FallbackGetMember_Public_DynamicMetaObject_DynamicMetaObject_0;

		// Token: 0x04000C47 RID: 3143
		private static readonly IntPtr NativeMethodInfoPtr_FallbackGetMember_Public_Abstract_Virtual_New_DynamicMetaObject_DynamicMetaObject_DynamicMetaObject_0;

		// Token: 0x04000C48 RID: 3144
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Virtual_Final_DynamicMetaObject_DynamicMetaObject_Il2CppReferenceArray_1_DynamicMetaObject_0;

		// Token: 0x04000C49 RID: 3145
		private static readonly IntPtr NativeMethodInfoPtr_get_IsStandardBinder_Internal_Virtual_Final_get_Boolean_0;
	}
}
