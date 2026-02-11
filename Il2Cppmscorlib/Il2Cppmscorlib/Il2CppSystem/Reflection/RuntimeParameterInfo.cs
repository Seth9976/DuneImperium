using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.InteropServices;
using Il2CppSystem.Text;

namespace Il2CppSystem.Reflection
{
	// Token: 0x0200044B RID: 1099
	[Serializable]
	public class RuntimeParameterInfo : ParameterInfo
	{
		// Token: 0x06004024 RID: 16420 RVA: 0x001333E8 File Offset: 0x001315E8
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeParameterInfo()
		{
			Il2CppClassPointerStore<RuntimeParameterInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "RuntimeParameterInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeParameterInfo>.NativeClassPtr);
			RuntimeParameterInfo.NativeFieldInfoPtr_marshalAs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeParameterInfo>.NativeClassPtr, "marshalAs");
			RuntimeParameterInfo.NativeMethodInfoPtr__ctor_Internal_Void_String_Type_Int32_Int32_Object_MemberInfo_MarshalAsAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeParameterInfo>.NativeClassPtr, 100672966);
			RuntimeParameterInfo.NativeMethodInfoPtr_FormatParameters_Internal_Static_Void_StringBuilder_Il2CppReferenceArray_1_ParameterInfo_CallingConventions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeParameterInfo>.NativeClassPtr, 100672967);
			RuntimeParameterInfo.NativeMethodInfoPtr__ctor_Internal_Void_ParameterInfo_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeParameterInfo>.NativeClassPtr, 100672968);
			RuntimeParameterInfo.NativeMethodInfoPtr__ctor_Internal_Void_Type_MemberInfo_MarshalAsAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeParameterInfo>.NativeClassPtr, 100672969);
			RuntimeParameterInfo.NativeMethodInfoPtr_get_DefaultValue_Public_Virtual_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeParameterInfo>.NativeClassPtr, 100672970);
			RuntimeParameterInfo.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeParameterInfo>.NativeClassPtr, 100672971);
			RuntimeParameterInfo.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeParameterInfo>.NativeClassPtr, 100672972);
			RuntimeParameterInfo.NativeMethodInfoPtr_GetDefaultValueImpl_Internal_Object_ParameterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeParameterInfo>.NativeClassPtr, 100672973);
			RuntimeParameterInfo.NativeMethodInfoPtr_IsDefined_Public_Virtual_Boolean_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeParameterInfo>.NativeClassPtr, 100672974);
			RuntimeParameterInfo.NativeMethodInfoPtr_GetPseudoCustomAttributes_Internal_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeParameterInfo>.NativeClassPtr, 100672975);
			RuntimeParameterInfo.NativeMethodInfoPtr_GetPseudoCustomAttributesData_Internal_Il2CppReferenceArray_1_CustomAttributeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeParameterInfo>.NativeClassPtr, 100672976);
			RuntimeParameterInfo.NativeMethodInfoPtr_get_HasDefaultValue_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeParameterInfo>.NativeClassPtr, 100672977);
			RuntimeParameterInfo.NativeMethodInfoPtr_New_Internal_Static_ParameterInfo_ParameterInfo_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeParameterInfo>.NativeClassPtr, 100672978);
			RuntimeParameterInfo.NativeMethodInfoPtr_New_Internal_Static_ParameterInfo_Type_MemberInfo_MarshalAsAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeParameterInfo>.NativeClassPtr, 100672979);
		}

		// Token: 0x06004025 RID: 16421 RVA: 0x00133544 File Offset: 0x00131744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401863, XrefRangeEnd = 1401869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeParameterInfo(string name, Type type, int position, int attrs, Object defaultValue, MemberInfo member, MarshalAsAttribute marshalAs)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeParameterInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref attrs;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultValue);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(marshalAs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeParameterInfo.NativeMethodInfoPtr__ctor_Internal_Void_String_Type_Int32_Int32_Object_MemberInfo_MarshalAsAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004026 RID: 16422 RVA: 0x001335F8 File Offset: 0x001317F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1401889, RefRangeEnd = 1401891, XrefRangeStart = 1401869, XrefRangeEnd = 1401889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FormatParameters(StringBuilder sb, Il2CppReferenceArray<ParameterInfo> p, CallingConventions callingConvention, bool serialization)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callingConvention;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref serialization;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeParameterInfo.NativeMethodInfoPtr_FormatParameters_Internal_Static_Void_StringBuilder_Il2CppReferenceArray_1_ParameterInfo_CallingConventions_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004027 RID: 16423 RVA: 0x0013365C File Offset: 0x0013185C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1401905, RefRangeEnd = 1401906, XrefRangeStart = 1401891, XrefRangeEnd = 1401905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeParameterInfo(ParameterInfo pinfo, MemberInfo member)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeParameterInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pinfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeParameterInfo.NativeMethodInfoPtr__ctor_Internal_Void_ParameterInfo_MemberInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004028 RID: 16424 RVA: 0x001336BC File Offset: 0x001318BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401906, XrefRangeEnd = 1401911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeParameterInfo(Type type, MemberInfo member, MarshalAsAttribute marshalAs)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeParameterInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(marshalAs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeParameterInfo.NativeMethodInfoPtr__ctor_Internal_Void_Type_MemberInfo_MarshalAsAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000F3E RID: 3902
		// (get) Token: 0x06004029 RID: 16425 RVA: 0x0013372C File Offset: 0x0013192C
		public unsafe override Object DefaultValue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401911, XrefRangeEnd = 1401953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeParameterInfo.NativeMethodInfoPtr_get_DefaultValue_Public_Virtual_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600402A RID: 16426 RVA: 0x00133778 File Offset: 0x00131978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401953, XrefRangeEnd = 1401957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Object> GetCustomAttributes(bool inherit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inherit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeParameterInfo.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x0600402B RID: 16427 RVA: 0x001337D0 File Offset: 0x001319D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401957, XrefRangeEnd = 1401961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Object> GetCustomAttributes(Type attributeType, bool inherit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeParameterInfo.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x0600402C RID: 16428 RVA: 0x0013383C File Offset: 0x00131A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401961, XrefRangeEnd = 1401970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetDefaultValueImpl(ParameterInfo pinfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pinfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeParameterInfo.NativeMethodInfoPtr_GetDefaultValueImpl_Internal_Object_ParameterInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600402D RID: 16429 RVA: 0x0013388C File Offset: 0x00131A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401970, XrefRangeEnd = 1401974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsDefined(Type attributeType, bool inherit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeParameterInfo.NativeMethodInfoPtr_IsDefined_Public_Virtual_Boolean_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600402E RID: 16430 RVA: 0x001338F4 File Offset: 0x00131AF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1401998, RefRangeEnd = 1401999, XrefRangeStart = 1401974, XrefRangeEnd = 1401998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Object> GetPseudoCustomAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeParameterInfo.NativeMethodInfoPtr_GetPseudoCustomAttributes_Internal_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x0600402F RID: 16431 RVA: 0x00133934 File Offset: 0x00131B34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1402073, RefRangeEnd = 1402074, XrefRangeStart = 1401999, XrefRangeEnd = 1402073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<CustomAttributeData> GetPseudoCustomAttributesData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeParameterInfo.NativeMethodInfoPtr_GetPseudoCustomAttributesData_Internal_Il2CppReferenceArray_1_CustomAttributeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CustomAttributeData>>(intPtr3) : null;
		}

		// Token: 0x17000F3F RID: 3903
		// (get) Token: 0x06004030 RID: 16432 RVA: 0x00133974 File Offset: 0x00131B74
		public unsafe override bool HasDefaultValue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402074, XrefRangeEnd = 1402089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeParameterInfo.NativeMethodInfoPtr_get_HasDefaultValue_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004031 RID: 16433 RVA: 0x001339BC File Offset: 0x00131BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402089, XrefRangeEnd = 1402093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ParameterInfo New(ParameterInfo pinfo, MemberInfo member)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pinfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeParameterInfo.NativeMethodInfoPtr_New_Internal_Static_ParameterInfo_ParameterInfo_MemberInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParameterInfo>(intPtr3) : null;
		}

		// Token: 0x06004032 RID: 16434 RVA: 0x00133A14 File Offset: 0x00131C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402093, XrefRangeEnd = 1402101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ParameterInfo New(Type type, MemberInfo member, MarshalAsAttribute marshalAs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(marshalAs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeParameterInfo.NativeMethodInfoPtr_New_Internal_Static_ParameterInfo_Type_MemberInfo_MarshalAsAttribute_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParameterInfo>(intPtr3) : null;
		}

		// Token: 0x06004033 RID: 16435 RVA: 0x0001756B File Offset: 0x0001576B
		public RuntimeParameterInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F3D RID: 3901
		// (get) Token: 0x06004034 RID: 16436 RVA: 0x00133A7C File Offset: 0x00131C7C
		// (set) Token: 0x06004035 RID: 16437 RVA: 0x00017574 File Offset: 0x00015774
		public unsafe MarshalAsAttribute marshalAs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeParameterInfo.NativeFieldInfoPtr_marshalAs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MarshalAsAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeParameterInfo.NativeFieldInfoPtr_marshalAs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040034CA RID: 13514
		private static readonly IntPtr NativeFieldInfoPtr_marshalAs;

		// Token: 0x040034CB RID: 13515
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Type_Int32_Int32_Object_MemberInfo_MarshalAsAttribute_0;

		// Token: 0x040034CC RID: 13516
		private static readonly IntPtr NativeMethodInfoPtr_FormatParameters_Internal_Static_Void_StringBuilder_Il2CppReferenceArray_1_ParameterInfo_CallingConventions_Boolean_0;

		// Token: 0x040034CD RID: 13517
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ParameterInfo_MemberInfo_0;

		// Token: 0x040034CE RID: 13518
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Type_MemberInfo_MarshalAsAttribute_0;

		// Token: 0x040034CF RID: 13519
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultValue_Public_Virtual_get_Object_0;

		// Token: 0x040034D0 RID: 13520
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Boolean_0;

		// Token: 0x040034D1 RID: 13521
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Type_Boolean_0;

		// Token: 0x040034D2 RID: 13522
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultValueImpl_Internal_Object_ParameterInfo_0;

		// Token: 0x040034D3 RID: 13523
		private static readonly IntPtr NativeMethodInfoPtr_IsDefined_Public_Virtual_Boolean_Type_Boolean_0;

		// Token: 0x040034D4 RID: 13524
		private static readonly IntPtr NativeMethodInfoPtr_GetPseudoCustomAttributes_Internal_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040034D5 RID: 13525
		private static readonly IntPtr NativeMethodInfoPtr_GetPseudoCustomAttributesData_Internal_Il2CppReferenceArray_1_CustomAttributeData_0;

		// Token: 0x040034D6 RID: 13526
		private static readonly IntPtr NativeMethodInfoPtr_get_HasDefaultValue_Public_Virtual_get_Boolean_0;

		// Token: 0x040034D7 RID: 13527
		private static readonly IntPtr NativeMethodInfoPtr_New_Internal_Static_ParameterInfo_ParameterInfo_MemberInfo_0;

		// Token: 0x040034D8 RID: 13528
		private static readonly IntPtr NativeMethodInfoPtr_New_Internal_Static_ParameterInfo_Type_MemberInfo_MarshalAsAttribute_0;
	}
}
