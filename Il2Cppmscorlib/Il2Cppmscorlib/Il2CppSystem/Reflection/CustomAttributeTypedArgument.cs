using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000437 RID: 1079
	public sealed class CustomAttributeTypedArgument : ValueType
	{
		// Token: 0x06003E0E RID: 15886 RVA: 0x00129BB4 File Offset: 0x00127DB4
		// Note: this type is marked as 'beforefieldinit'.
		static CustomAttributeTypedArgument()
		{
			Il2CppClassPointerStore<CustomAttributeTypedArgument>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "CustomAttributeTypedArgument");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomAttributeTypedArgument>.NativeClassPtr);
			CustomAttributeTypedArgument.NativeFieldInfoPtr__ArgumentType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomAttributeTypedArgument>.NativeClassPtr, "<ArgumentType>k__BackingField");
			CustomAttributeTypedArgument.NativeFieldInfoPtr__Value_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomAttributeTypedArgument>.NativeClassPtr, "<Value>k__BackingField");
			CustomAttributeTypedArgument.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeTypedArgument>.NativeClassPtr, 100672630);
			CustomAttributeTypedArgument.NativeMethodInfoPtr__ctor_Public_Void_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeTypedArgument>.NativeClassPtr, 100672631);
			CustomAttributeTypedArgument.NativeMethodInfoPtr_get_ArgumentType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeTypedArgument>.NativeClassPtr, 100672632);
			CustomAttributeTypedArgument.NativeMethodInfoPtr_get_Value_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeTypedArgument>.NativeClassPtr, 100672633);
			CustomAttributeTypedArgument.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeTypedArgument>.NativeClassPtr, 100672634);
			CustomAttributeTypedArgument.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeTypedArgument>.NativeClassPtr, 100672635);
			CustomAttributeTypedArgument.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CustomAttributeTypedArgument_CustomAttributeTypedArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeTypedArgument>.NativeClassPtr, 100672636);
			CustomAttributeTypedArgument.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_CustomAttributeTypedArgument_CustomAttributeTypedArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeTypedArgument>.NativeClassPtr, 100672637);
			CustomAttributeTypedArgument.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeTypedArgument>.NativeClassPtr, 100672638);
			CustomAttributeTypedArgument.NativeMethodInfoPtr_ToString_Internal_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeTypedArgument>.NativeClassPtr, 100672639);
			CustomAttributeTypedArgument.NativeMethodInfoPtr_CanonicalizeValue_Private_Static_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeTypedArgument>.NativeClassPtr, 100672640);
		}

		// Token: 0x06003E0F RID: 15887 RVA: 0x00129CE8 File Offset: 0x00127EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399848, XrefRangeEnd = 1399858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomAttributeTypedArgument(Object value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomAttributeTypedArgument>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeTypedArgument.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003E10 RID: 15888 RVA: 0x00129D38 File Offset: 0x00127F38
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1399893, RefRangeEnd = 1399899, XrefRangeStart = 1399858, XrefRangeEnd = 1399893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomAttributeTypedArgument(Type argumentType, Object value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomAttributeTypedArgument>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(argumentType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeTypedArgument.NativeMethodInfoPtr__ctor_Public_Void_Type_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000EA6 RID: 3750
		// (get) Token: 0x06003E11 RID: 15889 RVA: 0x00129D9C File Offset: 0x00127F9C
		public unsafe Type ArgumentType
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeTypedArgument.NativeMethodInfoPtr_get_ArgumentType_Public_get_Type_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000EA7 RID: 3751
		// (get) Token: 0x06003E12 RID: 15890 RVA: 0x00129DE0 File Offset: 0x00127FE0
		public unsafe Object Value
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 306629, RefRangeEnd = 306630, XrefRangeStart = 306629, XrefRangeEnd = 306630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeTypedArgument.NativeMethodInfoPtr_get_Value_Public_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003E13 RID: 15891 RVA: 0x00129E24 File Offset: 0x00128024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399899, XrefRangeEnd = 1399902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeTypedArgument.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003E14 RID: 15892 RVA: 0x00129E78 File Offset: 0x00128078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399902, XrefRangeEnd = 1399906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeTypedArgument.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003E15 RID: 15893 RVA: 0x00129EBC File Offset: 0x001280BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399906, XrefRangeEnd = 1399912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(CustomAttributeTypedArgument left, CustomAttributeTypedArgument right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(right));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeTypedArgument.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CustomAttributeTypedArgument_CustomAttributeTypedArgument_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003E16 RID: 15894 RVA: 0x00129F1C File Offset: 0x0012811C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399912, XrefRangeEnd = 1399918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(CustomAttributeTypedArgument left, CustomAttributeTypedArgument right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(right));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeTypedArgument.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_CustomAttributeTypedArgument_CustomAttributeTypedArgument_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003E17 RID: 15895 RVA: 0x00129F7C File Offset: 0x0012817C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399918, XrefRangeEnd = 1399919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeTypedArgument.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003E18 RID: 15896 RVA: 0x00129FB8 File Offset: 0x001281B8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1400042, RefRangeEnd = 1400046, XrefRangeStart = 1399919, XrefRangeEnd = 1400042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(bool typed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref typed;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeTypedArgument.NativeMethodInfoPtr_ToString_Internal_String_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003E19 RID: 15897 RVA: 0x0012A004 File Offset: 0x00128204
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1400048, RefRangeEnd = 1400050, XrefRangeStart = 1400046, XrefRangeEnd = 1400048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CanonicalizeValue(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeTypedArgument.NativeMethodInfoPtr_CanonicalizeValue_Private_Static_Object_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003E1A RID: 15898 RVA: 0x00016B05 File Offset: 0x00014D05
		public CustomAttributeTypedArgument(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06003E1B RID: 15899 RVA: 0x00016B0E File Offset: 0x00014D0E
		public CustomAttributeTypedArgument()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomAttributeTypedArgument>.NativeClassPtr))
		{
		}

		// Token: 0x17000EA4 RID: 3748
		// (get) Token: 0x06003E1C RID: 15900 RVA: 0x0012A048 File Offset: 0x00128248
		// (set) Token: 0x06003E1D RID: 15901 RVA: 0x00016B20 File Offset: 0x00014D20
		public unsafe Type _ArgumentType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeTypedArgument.NativeFieldInfoPtr__ArgumentType_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeTypedArgument.NativeFieldInfoPtr__ArgumentType_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EA5 RID: 3749
		// (get) Token: 0x06003E1E RID: 15902 RVA: 0x0012A078 File Offset: 0x00128278
		// (set) Token: 0x06003E1F RID: 15903 RVA: 0x00016B3F File Offset: 0x00014D3F
		public unsafe Object _Value_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeTypedArgument.NativeFieldInfoPtr__Value_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeTypedArgument.NativeFieldInfoPtr__Value_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040032CD RID: 13005
		private static readonly IntPtr NativeFieldInfoPtr__ArgumentType_k__BackingField;

		// Token: 0x040032CE RID: 13006
		private static readonly IntPtr NativeFieldInfoPtr__Value_k__BackingField;

		// Token: 0x040032CF RID: 13007
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

		// Token: 0x040032D0 RID: 13008
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_Object_0;

		// Token: 0x040032D1 RID: 13009
		private static readonly IntPtr NativeMethodInfoPtr_get_ArgumentType_Public_get_Type_0;

		// Token: 0x040032D2 RID: 13010
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Object_0;

		// Token: 0x040032D3 RID: 13011
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040032D4 RID: 13012
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040032D5 RID: 13013
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CustomAttributeTypedArgument_CustomAttributeTypedArgument_0;

		// Token: 0x040032D6 RID: 13014
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_CustomAttributeTypedArgument_CustomAttributeTypedArgument_0;

		// Token: 0x040032D7 RID: 13015
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040032D8 RID: 13016
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Internal_String_Boolean_0;

		// Token: 0x040032D9 RID: 13017
		private static readonly IntPtr NativeMethodInfoPtr_CanonicalizeValue_Private_Static_Object_Object_0;
	}
}
