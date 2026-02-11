using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000436 RID: 1078
	public sealed class CustomAttributeNamedArgument : ValueType
	{
		// Token: 0x06003DF5 RID: 15861 RVA: 0x00129568 File Offset: 0x00127768
		// Note: this type is marked as 'beforefieldinit'.
		static CustomAttributeNamedArgument()
		{
			Il2CppClassPointerStore<CustomAttributeNamedArgument>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "CustomAttributeNamedArgument");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomAttributeNamedArgument>.NativeClassPtr);
			CustomAttributeNamedArgument.NativeFieldInfoPtr__TypedValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomAttributeNamedArgument>.NativeClassPtr, "<TypedValue>k__BackingField");
			CustomAttributeNamedArgument.NativeFieldInfoPtr__IsField_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomAttributeNamedArgument>.NativeClassPtr, "<IsField>k__BackingField");
			CustomAttributeNamedArgument.NativeFieldInfoPtr__MemberName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomAttributeNamedArgument>.NativeClassPtr, "<MemberName>k__BackingField");
			CustomAttributeNamedArgument.NativeFieldInfoPtr__attributeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomAttributeNamedArgument>.NativeClassPtr, "_attributeType");
			CustomAttributeNamedArgument.NativeFieldInfoPtr__lazyMemberInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomAttributeNamedArgument>.NativeClassPtr, "_lazyMemberInfo");
			CustomAttributeNamedArgument.NativeMethodInfoPtr__ctor_Internal_Void_Type_String_Boolean_CustomAttributeTypedArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeNamedArgument>.NativeClassPtr, 100672618);
			CustomAttributeNamedArgument.NativeMethodInfoPtr__ctor_Public_Void_MemberInfo_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeNamedArgument>.NativeClassPtr, 100672619);
			CustomAttributeNamedArgument.NativeMethodInfoPtr__ctor_Public_Void_MemberInfo_CustomAttributeTypedArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeNamedArgument>.NativeClassPtr, 100672620);
			CustomAttributeNamedArgument.NativeMethodInfoPtr_get_TypedValue_Public_get_CustomAttributeTypedArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeNamedArgument>.NativeClassPtr, 100672621);
			CustomAttributeNamedArgument.NativeMethodInfoPtr_get_IsField_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeNamedArgument>.NativeClassPtr, 100672622);
			CustomAttributeNamedArgument.NativeMethodInfoPtr_get_MemberName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeNamedArgument>.NativeClassPtr, 100672623);
			CustomAttributeNamedArgument.NativeMethodInfoPtr_get_MemberInfo_Public_get_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeNamedArgument>.NativeClassPtr, 100672624);
			CustomAttributeNamedArgument.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeNamedArgument>.NativeClassPtr, 100672625);
			CustomAttributeNamedArgument.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeNamedArgument>.NativeClassPtr, 100672626);
			CustomAttributeNamedArgument.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CustomAttributeNamedArgument_CustomAttributeNamedArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeNamedArgument>.NativeClassPtr, 100672627);
			CustomAttributeNamedArgument.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_CustomAttributeNamedArgument_CustomAttributeNamedArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeNamedArgument>.NativeClassPtr, 100672628);
			CustomAttributeNamedArgument.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeNamedArgument>.NativeClassPtr, 100672629);
		}

		// Token: 0x06003DF6 RID: 15862 RVA: 0x001296EC File Offset: 0x001278EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399711, XrefRangeEnd = 1399716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomAttributeNamedArgument(Type attributeType, string memberName, bool isField, CustomAttributeTypedArgument typedValue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomAttributeNamedArgument>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(memberName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isField;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(typedValue));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeNamedArgument.NativeMethodInfoPtr__ctor_Internal_Void_Type_String_Boolean_CustomAttributeTypedArgument_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DF7 RID: 15863 RVA: 0x00129774 File Offset: 0x00127974
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1399751, RefRangeEnd = 1399759, XrefRangeStart = 1399716, XrefRangeEnd = 1399751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomAttributeNamedArgument(MemberInfo memberInfo, Object value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomAttributeNamedArgument>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeNamedArgument.NativeMethodInfoPtr__ctor_Public_Void_MemberInfo_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DF8 RID: 15864 RVA: 0x001297D8 File Offset: 0x001279D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399759, XrefRangeEnd = 1399778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomAttributeNamedArgument(MemberInfo memberInfo, CustomAttributeTypedArgument typedArgument)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomAttributeNamedArgument>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(typedArgument));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeNamedArgument.NativeMethodInfoPtr__ctor_Public_Void_MemberInfo_CustomAttributeTypedArgument_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000EA0 RID: 3744
		// (get) Token: 0x06003DF9 RID: 15865 RVA: 0x00129840 File Offset: 0x00127A40
		public unsafe CustomAttributeTypedArgument TypedValue
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 599686, RefRangeEnd = 599697, XrefRangeStart = 599686, XrefRangeEnd = 599697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeNamedArgument.NativeMethodInfoPtr_get_TypedValue_Public_get_CustomAttributeTypedArgument_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new CustomAttributeTypedArgument(intPtr);
			}
		}

		// Token: 0x17000EA1 RID: 3745
		// (get) Token: 0x06003DFA RID: 15866 RVA: 0x0012987C File Offset: 0x00127A7C
		public unsafe bool IsField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeNamedArgument.NativeMethodInfoPtr_get_IsField_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000EA2 RID: 3746
		// (get) Token: 0x06003DFB RID: 15867 RVA: 0x001298C0 File Offset: 0x00127AC0
		public unsafe string MemberName
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeNamedArgument.NativeMethodInfoPtr_get_MemberName_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000EA3 RID: 3747
		// (get) Token: 0x06003DFC RID: 15868 RVA: 0x001298FC File Offset: 0x00127AFC
		public unsafe MemberInfo MemberInfo
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399778, XrefRangeEnd = 1399789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeNamedArgument.NativeMethodInfoPtr_get_MemberInfo_Public_get_MemberInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MemberInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06003DFD RID: 15869 RVA: 0x00129940 File Offset: 0x00127B40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399789, XrefRangeEnd = 1399792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeNamedArgument.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003DFE RID: 15870 RVA: 0x00129994 File Offset: 0x00127B94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399792, XrefRangeEnd = 1399796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeNamedArgument.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003DFF RID: 15871 RVA: 0x001299D8 File Offset: 0x00127BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399796, XrefRangeEnd = 1399802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(CustomAttributeNamedArgument left, CustomAttributeNamedArgument right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(right));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeNamedArgument.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CustomAttributeNamedArgument_CustomAttributeNamedArgument_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003E00 RID: 15872 RVA: 0x00129A38 File Offset: 0x00127C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399802, XrefRangeEnd = 1399808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(CustomAttributeNamedArgument left, CustomAttributeNamedArgument right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(right));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeNamedArgument.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_CustomAttributeNamedArgument_CustomAttributeNamedArgument_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003E01 RID: 15873 RVA: 0x00129A98 File Offset: 0x00127C98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1399847, RefRangeEnd = 1399848, XrefRangeStart = 1399808, XrefRangeEnd = 1399847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeNamedArgument.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003E02 RID: 15874 RVA: 0x00016A44 File Offset: 0x00014C44
		public CustomAttributeNamedArgument(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06003E03 RID: 15875 RVA: 0x00016A4D File Offset: 0x00014C4D
		public CustomAttributeNamedArgument()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomAttributeNamedArgument>.NativeClassPtr))
		{
		}

		// Token: 0x17000E9B RID: 3739
		// (get) Token: 0x06003E04 RID: 15876 RVA: 0x00129AD4 File Offset: 0x00127CD4
		// (set) Token: 0x06003E05 RID: 15877 RVA: 0x00016A5F File Offset: 0x00014C5F
		public CustomAttributeTypedArgument _TypedValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeNamedArgument.NativeFieldInfoPtr__TypedValue_k__BackingField);
				return new CustomAttributeTypedArgument(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CustomAttributeTypedArgument>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeNamedArgument.NativeFieldInfoPtr__TypedValue_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CustomAttributeTypedArgument>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000E9C RID: 3740
		// (get) Token: 0x06003E06 RID: 15878 RVA: 0x00129B04 File Offset: 0x00127D04
		// (set) Token: 0x06003E07 RID: 15879 RVA: 0x00016A8D File Offset: 0x00014C8D
		public unsafe bool _IsField_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeNamedArgument.NativeFieldInfoPtr__IsField_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeNamedArgument.NativeFieldInfoPtr__IsField_k__BackingField)) = value;
			}
		}

		// Token: 0x17000E9D RID: 3741
		// (get) Token: 0x06003E08 RID: 15880 RVA: 0x00129B2C File Offset: 0x00127D2C
		// (set) Token: 0x06003E09 RID: 15881 RVA: 0x00016AA8 File Offset: 0x00014CA8
		public unsafe string _MemberName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeNamedArgument.NativeFieldInfoPtr__MemberName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeNamedArgument.NativeFieldInfoPtr__MemberName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E9E RID: 3742
		// (get) Token: 0x06003E0A RID: 15882 RVA: 0x00129B54 File Offset: 0x00127D54
		// (set) Token: 0x06003E0B RID: 15883 RVA: 0x00016AC7 File Offset: 0x00014CC7
		public unsafe Type _attributeType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeNamedArgument.NativeFieldInfoPtr__attributeType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeNamedArgument.NativeFieldInfoPtr__attributeType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E9F RID: 3743
		// (get) Token: 0x06003E0C RID: 15884 RVA: 0x00129B84 File Offset: 0x00127D84
		// (set) Token: 0x06003E0D RID: 15885 RVA: 0x00016AE6 File Offset: 0x00014CE6
		public unsafe MemberInfo _lazyMemberInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeNamedArgument.NativeFieldInfoPtr__lazyMemberInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemberInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeNamedArgument.NativeFieldInfoPtr__lazyMemberInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040032BC RID: 12988
		private static readonly IntPtr NativeFieldInfoPtr__TypedValue_k__BackingField;

		// Token: 0x040032BD RID: 12989
		private static readonly IntPtr NativeFieldInfoPtr__IsField_k__BackingField;

		// Token: 0x040032BE RID: 12990
		private static readonly IntPtr NativeFieldInfoPtr__MemberName_k__BackingField;

		// Token: 0x040032BF RID: 12991
		private static readonly IntPtr NativeFieldInfoPtr__attributeType;

		// Token: 0x040032C0 RID: 12992
		private static readonly IntPtr NativeFieldInfoPtr__lazyMemberInfo;

		// Token: 0x040032C1 RID: 12993
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Type_String_Boolean_CustomAttributeTypedArgument_0;

		// Token: 0x040032C2 RID: 12994
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MemberInfo_Object_0;

		// Token: 0x040032C3 RID: 12995
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MemberInfo_CustomAttributeTypedArgument_0;

		// Token: 0x040032C4 RID: 12996
		private static readonly IntPtr NativeMethodInfoPtr_get_TypedValue_Public_get_CustomAttributeTypedArgument_0;

		// Token: 0x040032C5 RID: 12997
		private static readonly IntPtr NativeMethodInfoPtr_get_IsField_Public_get_Boolean_0;

		// Token: 0x040032C6 RID: 12998
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberName_Public_get_String_0;

		// Token: 0x040032C7 RID: 12999
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberInfo_Public_get_MemberInfo_0;

		// Token: 0x040032C8 RID: 13000
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040032C9 RID: 13001
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040032CA RID: 13002
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CustomAttributeNamedArgument_CustomAttributeNamedArgument_0;

		// Token: 0x040032CB RID: 13003
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_CustomAttributeNamedArgument_CustomAttributeNamedArgument_0;

		// Token: 0x040032CC RID: 13004
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
