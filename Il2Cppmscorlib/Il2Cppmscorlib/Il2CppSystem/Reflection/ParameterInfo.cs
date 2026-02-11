using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Reflection
{
	// Token: 0x0200041F RID: 1055
	[Serializable]
	public class ParameterInfo : Object
	{
		// Token: 0x06003C98 RID: 15512 RVA: 0x0012286C File Offset: 0x00120A6C
		// Note: this type is marked as 'beforefieldinit'.
		static ParameterInfo()
		{
			Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "ParameterInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr);
			ParameterInfo.NativeFieldInfoPtr_AttrsImpl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr, "AttrsImpl");
			ParameterInfo.NativeFieldInfoPtr_ClassImpl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr, "ClassImpl");
			ParameterInfo.NativeFieldInfoPtr_DefaultValueImpl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr, "DefaultValueImpl");
			ParameterInfo.NativeFieldInfoPtr_MemberImpl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr, "MemberImpl");
			ParameterInfo.NativeFieldInfoPtr_NameImpl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr, "NameImpl");
			ParameterInfo.NativeFieldInfoPtr_PositionImpl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr, "PositionImpl");
			ParameterInfo.NativeFieldInfoPtr_MetadataToken_ParamDef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr, "MetadataToken_ParamDef");
			ParameterInfo.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr, 100672350);
			ParameterInfo.NativeMethodInfoPtr_get_Attributes_Public_Virtual_New_get_ParameterAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr, 100672351);
			ParameterInfo.NativeMethodInfoPtr_get_Member_Public_Virtual_New_get_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr, 100672352);
			ParameterInfo.NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr, 100672353);
			ParameterInfo.NativeMethodInfoPtr_get_ParameterType_Public_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr, 100672354);
			ParameterInfo.NativeMethodInfoPtr_get_Position_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr, 100672355);
			ParameterInfo.NativeMethodInfoPtr_get_IsIn_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr, 100672356);
			ParameterInfo.NativeMethodInfoPtr_get_IsOptional_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr, 100672357);
			ParameterInfo.NativeMethodInfoPtr_get_IsOut_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr, 100672358);
			ParameterInfo.NativeMethodInfoPtr_get_DefaultValue_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr, 100672359);
			ParameterInfo.NativeMethodInfoPtr_get_HasDefaultValue_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr, 100672360);
			ParameterInfo.NativeMethodInfoPtr_IsDefined_Public_Virtual_New_Boolean_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr, 100672361);
			ParameterInfo.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_New_Il2CppReferenceArray_1_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr, 100672362);
			ParameterInfo.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_New_Il2CppReferenceArray_1_Object_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr, 100672363);
			ParameterInfo.NativeMethodInfoPtr_GetRealObject_Public_Virtual_Final_New_Object_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr, 100672364);
			ParameterInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr, 100672365);
		}

		// Token: 0x06003C99 RID: 15513 RVA: 0x00122A68 File Offset: 0x00120C68
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParameterInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParameterInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterInfo.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000E2C RID: 3628
		// (get) Token: 0x06003C9A RID: 15514 RVA: 0x00122AA4 File Offset: 0x00120CA4
		public unsafe virtual ParameterAttributes Attributes
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ParameterInfo.NativeMethodInfoPtr_get_Attributes_Public_Virtual_New_get_ParameterAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E2D RID: 3629
		// (get) Token: 0x06003C9B RID: 15515 RVA: 0x00122AEC File Offset: 0x00120CEC
		public unsafe virtual MemberInfo Member
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ParameterInfo.NativeMethodInfoPtr_get_Member_Public_Virtual_New_get_MemberInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MemberInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000E2E RID: 3630
		// (get) Token: 0x06003C9C RID: 15516 RVA: 0x00122B38 File Offset: 0x00120D38
		public unsafe virtual string Name
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ParameterInfo.NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000E2F RID: 3631
		// (get) Token: 0x06003C9D RID: 15517 RVA: 0x00122B7C File Offset: 0x00120D7C
		public unsafe virtual Type ParameterType
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ParameterInfo.NativeMethodInfoPtr_get_ParameterType_Public_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000E30 RID: 3632
		// (get) Token: 0x06003C9E RID: 15518 RVA: 0x00122BC8 File Offset: 0x00120DC8
		public unsafe virtual int Position
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ParameterInfo.NativeMethodInfoPtr_get_Position_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E31 RID: 3633
		// (get) Token: 0x06003C9F RID: 15519 RVA: 0x00122C10 File Offset: 0x00120E10
		public unsafe bool IsIn
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterInfo.NativeMethodInfoPtr_get_IsIn_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E32 RID: 3634
		// (get) Token: 0x06003CA0 RID: 15520 RVA: 0x00122C4C File Offset: 0x00120E4C
		public unsafe bool IsOptional
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1398970, RefRangeEnd = 1398971, XrefRangeStart = 1398970, XrefRangeEnd = 1398970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterInfo.NativeMethodInfoPtr_get_IsOptional_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E33 RID: 3635
		// (get) Token: 0x06003CA1 RID: 15521 RVA: 0x00122C88 File Offset: 0x00120E88
		public unsafe bool IsOut
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1398971, RefRangeEnd = 1398974, XrefRangeStart = 1398971, XrefRangeEnd = 1398971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterInfo.NativeMethodInfoPtr_get_IsOut_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E34 RID: 3636
		// (get) Token: 0x06003CA2 RID: 15522 RVA: 0x00122CC4 File Offset: 0x00120EC4
		public unsafe virtual Object DefaultValue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1398974, XrefRangeEnd = 1398977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ParameterInfo.NativeMethodInfoPtr_get_DefaultValue_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000E35 RID: 3637
		// (get) Token: 0x06003CA3 RID: 15523 RVA: 0x00122D10 File Offset: 0x00120F10
		public unsafe virtual bool HasDefaultValue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1398977, XrefRangeEnd = 1398980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ParameterInfo.NativeMethodInfoPtr_get_HasDefaultValue_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003CA4 RID: 15524 RVA: 0x00122D58 File Offset: 0x00120F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1398980, XrefRangeEnd = 1398984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsDefined(Type attributeType, bool inherit)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ParameterInfo.NativeMethodInfoPtr_IsDefined_Public_Virtual_New_Boolean_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003CA5 RID: 15525 RVA: 0x00122DC0 File Offset: 0x00120FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1398984, XrefRangeEnd = 1398987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppReferenceArray<Object> GetCustomAttributes(bool inherit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inherit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ParameterInfo.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_New_Il2CppReferenceArray_1_Object_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06003CA6 RID: 15526 RVA: 0x00122E18 File Offset: 0x00121018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1398987, XrefRangeEnd = 1399000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppReferenceArray<Object> GetCustomAttributes(Type attributeType, bool inherit)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ParameterInfo.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_New_Il2CppReferenceArray_1_Object_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06003CA7 RID: 15527 RVA: 0x00122E84 File Offset: 0x00121084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399000, XrefRangeEnd = 1399014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetRealObject(StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterInfo.NativeMethodInfoPtr_GetRealObject_Public_Virtual_Final_New_Object_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003CA8 RID: 15528 RVA: 0x00122EDC File Offset: 0x001210DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399014, XrefRangeEnd = 1399019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ParameterInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003CA9 RID: 15529 RVA: 0x000166C9 File Offset: 0x000148C9
		public ParameterInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E25 RID: 3621
		// (get) Token: 0x06003CAA RID: 15530 RVA: 0x00122F20 File Offset: 0x00121120
		// (set) Token: 0x06003CAB RID: 15531 RVA: 0x000166D2 File Offset: 0x000148D2
		public unsafe ParameterAttributes AttrsImpl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterInfo.NativeFieldInfoPtr_AttrsImpl);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterInfo.NativeFieldInfoPtr_AttrsImpl)) = value;
			}
		}

		// Token: 0x17000E26 RID: 3622
		// (get) Token: 0x06003CAC RID: 15532 RVA: 0x00122F48 File Offset: 0x00121148
		// (set) Token: 0x06003CAD RID: 15533 RVA: 0x000166ED File Offset: 0x000148ED
		public unsafe Type ClassImpl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterInfo.NativeFieldInfoPtr_ClassImpl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterInfo.NativeFieldInfoPtr_ClassImpl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E27 RID: 3623
		// (get) Token: 0x06003CAE RID: 15534 RVA: 0x00122F78 File Offset: 0x00121178
		// (set) Token: 0x06003CAF RID: 15535 RVA: 0x0001670C File Offset: 0x0001490C
		public unsafe Object DefaultValueImpl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterInfo.NativeFieldInfoPtr_DefaultValueImpl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterInfo.NativeFieldInfoPtr_DefaultValueImpl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E28 RID: 3624
		// (get) Token: 0x06003CB0 RID: 15536 RVA: 0x00122FA8 File Offset: 0x001211A8
		// (set) Token: 0x06003CB1 RID: 15537 RVA: 0x0001672B File Offset: 0x0001492B
		public unsafe MemberInfo MemberImpl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterInfo.NativeFieldInfoPtr_MemberImpl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemberInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterInfo.NativeFieldInfoPtr_MemberImpl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E29 RID: 3625
		// (get) Token: 0x06003CB2 RID: 15538 RVA: 0x00122FD8 File Offset: 0x001211D8
		// (set) Token: 0x06003CB3 RID: 15539 RVA: 0x0001674A File Offset: 0x0001494A
		public unsafe string NameImpl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterInfo.NativeFieldInfoPtr_NameImpl);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterInfo.NativeFieldInfoPtr_NameImpl), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E2A RID: 3626
		// (get) Token: 0x06003CB4 RID: 15540 RVA: 0x00123000 File Offset: 0x00121200
		// (set) Token: 0x06003CB5 RID: 15541 RVA: 0x00016769 File Offset: 0x00014969
		public unsafe int PositionImpl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterInfo.NativeFieldInfoPtr_PositionImpl);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterInfo.NativeFieldInfoPtr_PositionImpl)) = value;
			}
		}

		// Token: 0x17000E2B RID: 3627
		// (get) Token: 0x06003CB6 RID: 15542 RVA: 0x00123028 File Offset: 0x00121228
		// (set) Token: 0x06003CB7 RID: 15543 RVA: 0x00016784 File Offset: 0x00014984
		public unsafe static int MetadataToken_ParamDef
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ParameterInfo.NativeFieldInfoPtr_MetadataToken_ParamDef, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ParameterInfo.NativeFieldInfoPtr_MetadataToken_ParamDef, (void*)(&value));
			}
		}

		// Token: 0x04003168 RID: 12648
		private static readonly IntPtr NativeFieldInfoPtr_AttrsImpl;

		// Token: 0x04003169 RID: 12649
		private static readonly IntPtr NativeFieldInfoPtr_ClassImpl;

		// Token: 0x0400316A RID: 12650
		private static readonly IntPtr NativeFieldInfoPtr_DefaultValueImpl;

		// Token: 0x0400316B RID: 12651
		private static readonly IntPtr NativeFieldInfoPtr_MemberImpl;

		// Token: 0x0400316C RID: 12652
		private static readonly IntPtr NativeFieldInfoPtr_NameImpl;

		// Token: 0x0400316D RID: 12653
		private static readonly IntPtr NativeFieldInfoPtr_PositionImpl;

		// Token: 0x0400316E RID: 12654
		private static readonly IntPtr NativeFieldInfoPtr_MetadataToken_ParamDef;

		// Token: 0x0400316F RID: 12655
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04003170 RID: 12656
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_Virtual_New_get_ParameterAttributes_0;

		// Token: 0x04003171 RID: 12657
		private static readonly IntPtr NativeMethodInfoPtr_get_Member_Public_Virtual_New_get_MemberInfo_0;

		// Token: 0x04003172 RID: 12658
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0;

		// Token: 0x04003173 RID: 12659
		private static readonly IntPtr NativeMethodInfoPtr_get_ParameterType_Public_Virtual_New_get_Type_0;

		// Token: 0x04003174 RID: 12660
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_Virtual_New_get_Int32_0;

		// Token: 0x04003175 RID: 12661
		private static readonly IntPtr NativeMethodInfoPtr_get_IsIn_Public_get_Boolean_0;

		// Token: 0x04003176 RID: 12662
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOptional_Public_get_Boolean_0;

		// Token: 0x04003177 RID: 12663
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOut_Public_get_Boolean_0;

		// Token: 0x04003178 RID: 12664
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultValue_Public_Virtual_New_get_Object_0;

		// Token: 0x04003179 RID: 12665
		private static readonly IntPtr NativeMethodInfoPtr_get_HasDefaultValue_Public_Virtual_New_get_Boolean_0;

		// Token: 0x0400317A RID: 12666
		private static readonly IntPtr NativeMethodInfoPtr_IsDefined_Public_Virtual_New_Boolean_Type_Boolean_0;

		// Token: 0x0400317B RID: 12667
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_New_Il2CppReferenceArray_1_Object_Boolean_0;

		// Token: 0x0400317C RID: 12668
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_New_Il2CppReferenceArray_1_Object_Type_Boolean_0;

		// Token: 0x0400317D RID: 12669
		private static readonly IntPtr NativeMethodInfoPtr_GetRealObject_Public_Virtual_Final_New_Object_StreamingContext_0;

		// Token: 0x0400317E RID: 12670
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
