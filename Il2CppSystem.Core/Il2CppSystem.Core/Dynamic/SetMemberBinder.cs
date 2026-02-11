using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Dynamic
{
	// Token: 0x02000124 RID: 292
	public class SetMemberBinder : DynamicMetaObjectBinder
	{
		// Token: 0x06001133 RID: 4403 RVA: 0x00059F98 File Offset: 0x00058198
		// Note: this type is marked as 'beforefieldinit'.
		static SetMemberBinder()
		{
			Il2CppClassPointerStore<SetMemberBinder>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Dynamic", "SetMemberBinder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetMemberBinder>.NativeClassPtr);
			SetMemberBinder.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetMemberBinder>.NativeClassPtr, "<Name>k__BackingField");
			SetMemberBinder.NativeFieldInfoPtr__IgnoreCase_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetMemberBinder>.NativeClassPtr, "<IgnoreCase>k__BackingField");
			SetMemberBinder.NativeMethodInfoPtr__ctor_Protected_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetMemberBinder>.NativeClassPtr, 100666563);
			SetMemberBinder.NativeMethodInfoPtr_get_ReturnType_Public_Virtual_Final_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetMemberBinder>.NativeClassPtr, 100666564);
			SetMemberBinder.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetMemberBinder>.NativeClassPtr, 100666565);
			SetMemberBinder.NativeMethodInfoPtr_get_IgnoreCase_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetMemberBinder>.NativeClassPtr, 100666566);
			SetMemberBinder.NativeMethodInfoPtr_Bind_Public_Virtual_Final_DynamicMetaObject_DynamicMetaObject_Il2CppReferenceArray_1_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetMemberBinder>.NativeClassPtr, 100666567);
			SetMemberBinder.NativeMethodInfoPtr_get_IsStandardBinder_Internal_Virtual_Final_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetMemberBinder>.NativeClassPtr, 100666568);
			SetMemberBinder.NativeMethodInfoPtr_FallbackSetMember_Public_DynamicMetaObject_DynamicMetaObject_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetMemberBinder>.NativeClassPtr, 100666569);
			SetMemberBinder.NativeMethodInfoPtr_FallbackSetMember_Public_Abstract_Virtual_New_DynamicMetaObject_DynamicMetaObject_DynamicMetaObject_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetMemberBinder>.NativeClassPtr, 100666570);
		}

		// Token: 0x06001134 RID: 4404 RVA: 0x0005A090 File Offset: 0x00058290
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1029548, RefRangeEnd = 1029549, XrefRangeStart = 1029544, XrefRangeEnd = 1029548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetMemberBinder(string name, bool ignoreCase)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetMemberBinder>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetMemberBinder.NativeMethodInfoPtr__ctor_Protected_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06001135 RID: 4405 RVA: 0x0005A0EC File Offset: 0x000582EC
		public unsafe override Type ReturnType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029549, XrefRangeEnd = 1029555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetMemberBinder.NativeMethodInfoPtr_get_ReturnType_Public_Virtual_Final_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06001136 RID: 4406 RVA: 0x0005A12C File Offset: 0x0005832C
		public unsafe string Name
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetMemberBinder.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06001137 RID: 4407 RVA: 0x0005A164 File Offset: 0x00058364
		public unsafe bool IgnoreCase
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetMemberBinder.NativeMethodInfoPtr_get_IgnoreCase_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001138 RID: 4408 RVA: 0x0005A1A0 File Offset: 0x000583A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029555, XrefRangeEnd = 1029578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetMemberBinder.NativeMethodInfoPtr_Bind_Public_Virtual_Final_DynamicMetaObject_DynamicMetaObject_Il2CppReferenceArray_1_DynamicMetaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06001139 RID: 4409 RVA: 0x0005A204 File Offset: 0x00058404
		public unsafe override bool IsStandardBinder
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetMemberBinder.NativeMethodInfoPtr_get_IsStandardBinder_Internal_Virtual_Final_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600113A RID: 4410 RVA: 0x0005A240 File Offset: 0x00058440
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1027945, RefRangeEnd = 1027949, XrefRangeStart = 1027945, XrefRangeEnd = 1027949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetMemberBinder.NativeMethodInfoPtr_FallbackSetMember_Public_DynamicMetaObject_DynamicMetaObject_DynamicMetaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
		}

		// Token: 0x0600113B RID: 4411 RVA: 0x0005A2A4 File Offset: 0x000584A4
		[CallerCount(0)]
		public unsafe virtual DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value, DynamicMetaObject errorSuggestion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(errorSuggestion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SetMemberBinder.NativeMethodInfoPtr_FallbackSetMember_Public_Abstract_Virtual_New_DynamicMetaObject_DynamicMetaObject_DynamicMetaObject_DynamicMetaObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
		}

		// Token: 0x0600113C RID: 4412 RVA: 0x0000748D File Offset: 0x0000568D
		public SetMemberBinder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x0600113D RID: 4413 RVA: 0x0005A324 File Offset: 0x00058524
		// (set) Token: 0x0600113E RID: 4414 RVA: 0x00007496 File Offset: 0x00005696
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetMemberBinder.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetMemberBinder.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x0600113F RID: 4415 RVA: 0x0005A34C File Offset: 0x0005854C
		// (set) Token: 0x06001140 RID: 4416 RVA: 0x000074B5 File Offset: 0x000056B5
		public unsafe bool _IgnoreCase_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetMemberBinder.NativeFieldInfoPtr__IgnoreCase_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetMemberBinder.NativeFieldInfoPtr__IgnoreCase_k__BackingField)) = value;
			}
		}

		// Token: 0x04000C59 RID: 3161
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x04000C5A RID: 3162
		private static readonly IntPtr NativeFieldInfoPtr__IgnoreCase_k__BackingField;

		// Token: 0x04000C5B RID: 3163
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_String_Boolean_0;

		// Token: 0x04000C5C RID: 3164
		private static readonly IntPtr NativeMethodInfoPtr_get_ReturnType_Public_Virtual_Final_get_Type_0;

		// Token: 0x04000C5D RID: 3165
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04000C5E RID: 3166
		private static readonly IntPtr NativeMethodInfoPtr_get_IgnoreCase_Public_get_Boolean_0;

		// Token: 0x04000C5F RID: 3167
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Virtual_Final_DynamicMetaObject_DynamicMetaObject_Il2CppReferenceArray_1_DynamicMetaObject_0;

		// Token: 0x04000C60 RID: 3168
		private static readonly IntPtr NativeMethodInfoPtr_get_IsStandardBinder_Internal_Virtual_Final_get_Boolean_0;

		// Token: 0x04000C61 RID: 3169
		private static readonly IntPtr NativeMethodInfoPtr_FallbackSetMember_Public_DynamicMetaObject_DynamicMetaObject_DynamicMetaObject_0;

		// Token: 0x04000C62 RID: 3170
		private static readonly IntPtr NativeMethodInfoPtr_FallbackSetMember_Public_Abstract_Virtual_New_DynamicMetaObject_DynamicMetaObject_DynamicMetaObject_DynamicMetaObject_0;
	}
}
