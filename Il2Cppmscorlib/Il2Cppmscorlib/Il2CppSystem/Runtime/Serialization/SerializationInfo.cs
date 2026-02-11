using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x0200033A RID: 826
	public sealed class SerializationInfo : Object
	{
		// Token: 0x06003250 RID: 12880 RVA: 0x000FE594 File Offset: 0x000FC794
		// Note: this type is marked as 'beforefieldinit'.
		static SerializationInfo()
		{
			Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "SerializationInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr);
			SerializationInfo.NativeFieldInfoPtr_defaultSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, "defaultSize");
			SerializationInfo.NativeFieldInfoPtr_s_mscorlibAssemblySimpleName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, "s_mscorlibAssemblySimpleName");
			SerializationInfo.NativeFieldInfoPtr_s_mscorlibFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, "s_mscorlibFileName");
			SerializationInfo.NativeFieldInfoPtr_m_members = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, "m_members");
			SerializationInfo.NativeFieldInfoPtr_m_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, "m_data");
			SerializationInfo.NativeFieldInfoPtr_m_types = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, "m_types");
			SerializationInfo.NativeFieldInfoPtr_m_nameToIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, "m_nameToIndex");
			SerializationInfo.NativeFieldInfoPtr_m_currMember = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, "m_currMember");
			SerializationInfo.NativeFieldInfoPtr_m_converter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, "m_converter");
			SerializationInfo.NativeFieldInfoPtr_m_fullTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, "m_fullTypeName");
			SerializationInfo.NativeFieldInfoPtr_m_assemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, "m_assemName");
			SerializationInfo.NativeFieldInfoPtr_objectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, "objectType");
			SerializationInfo.NativeFieldInfoPtr_isFullTypeNameSetExplicit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, "isFullTypeNameSetExplicit");
			SerializationInfo.NativeFieldInfoPtr_isAssemblyNameSetExplicit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, "isAssemblyNameSetExplicit");
			SerializationInfo.NativeFieldInfoPtr_requireSameTokenInPartialTrust = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, "requireSameTokenInPartialTrust");
			SerializationInfo.NativeMethodInfoPtr__ctor_Public_Void_Type_IFormatterConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671176);
			SerializationInfo.NativeMethodInfoPtr__ctor_Public_Void_Type_IFormatterConverter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671177);
			SerializationInfo.NativeMethodInfoPtr_get_FullTypeName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671178);
			SerializationInfo.NativeMethodInfoPtr_get_AssemblyName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671179);
			SerializationInfo.NativeMethodInfoPtr_SetType_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671180);
			SerializationInfo.NativeMethodInfoPtr_Compare_Private_Static_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671181);
			SerializationInfo.NativeMethodInfoPtr_DemandForUnsafeAssemblyNameAssignments_Internal_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671182);
			SerializationInfo.NativeMethodInfoPtr_IsAssemblyNameAssignmentSafe_Internal_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671183);
			SerializationInfo.NativeMethodInfoPtr_get_MemberCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671184);
			SerializationInfo.NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671185);
			SerializationInfo.NativeMethodInfoPtr_get_IsFullTypeNameSetExplicit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671186);
			SerializationInfo.NativeMethodInfoPtr_get_IsAssemblyNameSetExplicit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671187);
			SerializationInfo.NativeMethodInfoPtr_GetEnumerator_Public_SerializationInfoEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671188);
			SerializationInfo.NativeMethodInfoPtr_ExpandArrays_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671189);
			SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671190);
			SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671191);
			SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671192);
			SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671193);
			SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671194);
			SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671195);
			SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671196);
			SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671197);
			SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671198);
			SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671199);
			SerializationInfo.NativeMethodInfoPtr_AddValueInternal_Internal_Void_String_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671200);
			SerializationInfo.NativeMethodInfoPtr_UpdateValue_Internal_Void_String_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671201);
			SerializationInfo.NativeMethodInfoPtr_FindElement_Private_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671202);
			SerializationInfo.NativeMethodInfoPtr_GetElement_Private_Object_String_byref_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671203);
			SerializationInfo.NativeMethodInfoPtr_GetElementNoThrow_Private_Object_String_byref_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671204);
			SerializationInfo.NativeMethodInfoPtr_GetValue_Public_Object_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671205);
			SerializationInfo.NativeMethodInfoPtr_GetValueNoThrow_Internal_Object_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671206);
			SerializationInfo.NativeMethodInfoPtr_GetBoolean_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671207);
			SerializationInfo.NativeMethodInfoPtr_GetInt32_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671208);
			SerializationInfo.NativeMethodInfoPtr_GetInt64_Public_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671209);
			SerializationInfo.NativeMethodInfoPtr_GetSingle_Public_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671210);
			SerializationInfo.NativeMethodInfoPtr_GetString_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr, 100671211);
		}

		// Token: 0x06003251 RID: 12881 RVA: 0x000FE9C0 File Offset: 0x000FCBC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1386113, RefRangeEnd = 1386115, XrefRangeStart = 1386112, XrefRangeEnd = 1386113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializationInfo(Type type, IFormatterConverter converter)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr__ctor_Public_Void_Type_IFormatterConverter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003252 RID: 12882 RVA: 0x000FEA20 File Offset: 0x000FCC20
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1386139, RefRangeEnd = 1386144, XrefRangeStart = 1386115, XrefRangeEnd = 1386139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializationInfo(Type type, IFormatterConverter converter, bool requireSameTokenInPartialTrust)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializationInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requireSameTokenInPartialTrust;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr__ctor_Public_Void_Type_IFormatterConverter_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B74 RID: 2932
		// (get) Token: 0x06003253 RID: 12883 RVA: 0x000FEA8C File Offset: 0x000FCC8C
		public unsafe string FullTypeName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_get_FullTypeName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x06003254 RID: 12884 RVA: 0x000FEAC4 File Offset: 0x000FCCC4
		public unsafe string AssemblyName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_get_AssemblyName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003255 RID: 12885 RVA: 0x000FEAFC File Offset: 0x000FCCFC
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1386148, RefRangeEnd = 1386162, XrefRangeStart = 1386144, XrefRangeEnd = 1386148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetType(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_SetType_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003256 RID: 12886 RVA: 0x000FEB40 File Offset: 0x000FCD40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1386162, XrefRangeEnd = 1386163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Compare(Il2CppStructArray<byte> a, Il2CppStructArray<byte> b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_Compare_Private_Static_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003257 RID: 12887 RVA: 0x000FEB94 File Offset: 0x000FCD94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1386163, XrefRangeEnd = 1386164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DemandForUnsafeAssemblyNameAssignments(string originalAssemblyName, string newAssemblyName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(originalAssemblyName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newAssemblyName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_DemandForUnsafeAssemblyNameAssignments_Internal_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003258 RID: 12888 RVA: 0x000FEBDC File Offset: 0x000FCDDC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1386181, RefRangeEnd = 1386186, XrefRangeStart = 1386164, XrefRangeEnd = 1386181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsAssemblyNameAssignmentSafe(string originalAssemblyName, string newAssemblyName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(originalAssemblyName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newAssemblyName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_IsAssemblyNameAssignmentSafe_Internal_Static_Boolean_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x06003259 RID: 12889 RVA: 0x000FEC30 File Offset: 0x000FCE30
		public unsafe int MemberCount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137950, RefRangeEnd = 137951, XrefRangeStart = 137950, XrefRangeEnd = 137951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_get_MemberCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x0600325A RID: 12890 RVA: 0x000FEC6C File Offset: 0x000FCE6C
		public unsafe Type ObjectType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000B78 RID: 2936
		// (get) Token: 0x0600325B RID: 12891 RVA: 0x000FECAC File Offset: 0x000FCEAC
		public unsafe bool IsFullTypeNameSetExplicit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_get_IsFullTypeNameSetExplicit_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x0600325C RID: 12892 RVA: 0x000FECE8 File Offset: 0x000FCEE8
		public unsafe bool IsAssemblyNameSetExplicit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_get_IsAssemblyNameSetExplicit_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600325D RID: 12893 RVA: 0x000FED24 File Offset: 0x000FCF24
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 1386190, RefRangeEnd = 1386213, XrefRangeStart = 1386186, XrefRangeEnd = 1386190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializationInfoEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_GetEnumerator_Public_SerializationInfoEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializationInfoEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600325E RID: 12894 RVA: 0x000FED64 File Offset: 0x000FCF64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1386213, XrefRangeEnd = 1386228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExpandArrays()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_ExpandArrays_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600325F RID: 12895 RVA: 0x000FED98 File Offset: 0x000FCF98
		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 1386241, RefRangeEnd = 1386323, XrefRangeStart = 1386228, XrefRangeEnd = 1386241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddValue(string name, Object value, Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003260 RID: 12896 RVA: 0x000FEE00 File Offset: 0x000FD000
		[CallerCount(167)]
		[CachedScanResults(RefRangeStart = 1386327, RefRangeEnd = 1386494, XrefRangeStart = 1386323, XrefRangeEnd = 1386327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddValue(string name, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003261 RID: 12897 RVA: 0x000FEE54 File Offset: 0x000FD054
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 1386504, RefRangeEnd = 1386531, XrefRangeStart = 1386494, XrefRangeEnd = 1386504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddValue(string name, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003262 RID: 12898 RVA: 0x000FEEA4 File Offset: 0x000FD0A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1386541, RefRangeEnd = 1386544, XrefRangeStart = 1386531, XrefRangeEnd = 1386541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddValue(string name, byte value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003263 RID: 12899 RVA: 0x000FEEF4 File Offset: 0x000FD0F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1386554, RefRangeEnd = 1386555, XrefRangeStart = 1386544, XrefRangeEnd = 1386554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddValue(string name, short value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003264 RID: 12900 RVA: 0x000FEF44 File Offset: 0x000FD144
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 1386565, RefRangeEnd = 1386608, XrefRangeStart = 1386555, XrefRangeEnd = 1386565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddValue(string name, int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003265 RID: 12901 RVA: 0x000FEF94 File Offset: 0x000FD194
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1386618, RefRangeEnd = 1386626, XrefRangeStart = 1386608, XrefRangeEnd = 1386618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddValue(string name, long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003266 RID: 12902 RVA: 0x000FEFE4 File Offset: 0x000FD1E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1386636, RefRangeEnd = 1386638, XrefRangeStart = 1386626, XrefRangeEnd = 1386636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddValue(string name, ulong value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003267 RID: 12903 RVA: 0x000FF034 File Offset: 0x000FD234
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1386648, RefRangeEnd = 1386649, XrefRangeStart = 1386638, XrefRangeEnd = 1386648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddValue(string name, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003268 RID: 12904 RVA: 0x000FF084 File Offset: 0x000FD284
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1386659, RefRangeEnd = 1386663, XrefRangeStart = 1386649, XrefRangeEnd = 1386659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddValue(string name, DateTime value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_AddValue_Public_Void_String_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003269 RID: 12905 RVA: 0x000FF0D4 File Offset: 0x000FD2D4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1386689, RefRangeEnd = 1386701, XrefRangeStart = 1386663, XrefRangeEnd = 1386689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddValueInternal(string name, Object value, Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_AddValueInternal_Internal_Void_String_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600326A RID: 12906 RVA: 0x000FF13C File Offset: 0x000FD33C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1386708, RefRangeEnd = 1386709, XrefRangeStart = 1386701, XrefRangeEnd = 1386708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateValue(string name, Object value, Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_UpdateValue_Internal_Void_String_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600326B RID: 12907 RVA: 0x000FF1A4 File Offset: 0x000FD3A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1386709, XrefRangeEnd = 1386712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindElement(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_FindElement_Private_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600326C RID: 12908 RVA: 0x000FF1F4 File Offset: 0x000FD3F4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1386716, RefRangeEnd = 1386722, XrefRangeStart = 1386712, XrefRangeEnd = 1386716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetElement(string name, out Type foundType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_GetElement_Private_Object_String_byref_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			foundType = ((intPtr4 == 0) ? null : new Type(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Object>(intPtr5) : null;
		}

		// Token: 0x0600326D RID: 12909 RVA: 0x000FF268 File Offset: 0x000FD468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1386722, XrefRangeEnd = 1386726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetElementNoThrow(string name, out Type foundType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_GetElementNoThrow_Private_Object_String_byref_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			foundType = ((intPtr4 == 0) ? null : new Type(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Object>(intPtr5) : null;
		}

		// Token: 0x0600326E RID: 12910 RVA: 0x000FF2DC File Offset: 0x000FD4DC
		[CallerCount(122)]
		[CachedScanResults(RefRangeStart = 1386736, RefRangeEnd = 1386858, XrefRangeStart = 1386726, XrefRangeEnd = 1386736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetValue(string name, Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_GetValue_Public_Object_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600326F RID: 12911 RVA: 0x000FF340 File Offset: 0x000FD540
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1386865, RefRangeEnd = 1386874, XrefRangeStart = 1386858, XrefRangeEnd = 1386865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetValueNoThrow(string name, Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_GetValueNoThrow_Internal_Object_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003270 RID: 12912 RVA: 0x000FF3A4 File Offset: 0x000FD5A4
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 1386885, RefRangeEnd = 1386904, XrefRangeStart = 1386874, XrefRangeEnd = 1386885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetBoolean(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_GetBoolean_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003271 RID: 12913 RVA: 0x000FF3F4 File Offset: 0x000FD5F4
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 1386915, RefRangeEnd = 1386946, XrefRangeStart = 1386904, XrefRangeEnd = 1386915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetInt32(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_GetInt32_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003272 RID: 12914 RVA: 0x000FF444 File Offset: 0x000FD644
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1386957, RefRangeEnd = 1386964, XrefRangeStart = 1386946, XrefRangeEnd = 1386957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long GetInt64(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_GetInt64_Public_Int64_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003273 RID: 12915 RVA: 0x000FF494 File Offset: 0x000FD694
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1386975, RefRangeEnd = 1386976, XrefRangeStart = 1386964, XrefRangeEnd = 1386975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetSingle(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_GetSingle_Public_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003274 RID: 12916 RVA: 0x000FF4E4 File Offset: 0x000FD6E4
		[CallerCount(84)]
		[CachedScanResults(RefRangeStart = 1386987, RefRangeEnd = 1387071, XrefRangeStart = 1386976, XrefRangeEnd = 1386987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetString(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfo.NativeMethodInfoPtr_GetString_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003275 RID: 12917 RVA: 0x00011712 File Offset: 0x0000F912
		public SerializationInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B65 RID: 2917
		// (get) Token: 0x06003276 RID: 12918 RVA: 0x000FF52C File Offset: 0x000FD72C
		// (set) Token: 0x06003277 RID: 12919 RVA: 0x0001171B File Offset: 0x0000F91B
		public unsafe static int defaultSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SerializationInfo.NativeFieldInfoPtr_defaultSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SerializationInfo.NativeFieldInfoPtr_defaultSize, (void*)(&value));
			}
		}

		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x06003278 RID: 12920 RVA: 0x000FF548 File Offset: 0x000FD748
		// (set) Token: 0x06003279 RID: 12921 RVA: 0x00011729 File Offset: 0x0000F929
		public unsafe static string s_mscorlibAssemblySimpleName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SerializationInfo.NativeFieldInfoPtr_s_mscorlibAssemblySimpleName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SerializationInfo.NativeFieldInfoPtr_s_mscorlibAssemblySimpleName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x0600327A RID: 12922 RVA: 0x000FF568 File Offset: 0x000FD768
		// (set) Token: 0x0600327B RID: 12923 RVA: 0x0001173B File Offset: 0x0000F93B
		public unsafe static string s_mscorlibFileName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SerializationInfo.NativeFieldInfoPtr_s_mscorlibFileName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SerializationInfo.NativeFieldInfoPtr_s_mscorlibFileName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x0600327C RID: 12924 RVA: 0x000FF588 File Offset: 0x000FD788
		// (set) Token: 0x0600327D RID: 12925 RVA: 0x0001174D File Offset: 0x0000F94D
		public unsafe Il2CppStringArray m_members
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_m_members);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_m_members), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x0600327E RID: 12926 RVA: 0x000FF5B8 File Offset: 0x000FD7B8
		// (set) Token: 0x0600327F RID: 12927 RVA: 0x0001176C File Offset: 0x0000F96C
		public unsafe Il2CppReferenceArray<Object> m_data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_m_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_m_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x06003280 RID: 12928 RVA: 0x000FF5E8 File Offset: 0x000FD7E8
		// (set) Token: 0x06003281 RID: 12929 RVA: 0x0001178B File Offset: 0x0000F98B
		public unsafe Il2CppReferenceArray<Type> m_types
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_m_types);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_m_types), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x06003282 RID: 12930 RVA: 0x000FF618 File Offset: 0x000FD818
		// (set) Token: 0x06003283 RID: 12931 RVA: 0x000117AA File Offset: 0x0000F9AA
		public unsafe Dictionary<string, int> m_nameToIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_m_nameToIndex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_m_nameToIndex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x06003284 RID: 12932 RVA: 0x000FF648 File Offset: 0x000FD848
		// (set) Token: 0x06003285 RID: 12933 RVA: 0x000117C9 File Offset: 0x0000F9C9
		public unsafe int m_currMember
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_m_currMember);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_m_currMember)) = value;
			}
		}

		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x06003286 RID: 12934 RVA: 0x000FF670 File Offset: 0x000FD870
		// (set) Token: 0x06003287 RID: 12935 RVA: 0x000117E4 File Offset: 0x0000F9E4
		public unsafe IFormatterConverter m_converter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_m_converter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFormatterConverter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_m_converter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x06003288 RID: 12936 RVA: 0x000FF6A0 File Offset: 0x000FD8A0
		// (set) Token: 0x06003289 RID: 12937 RVA: 0x00011803 File Offset: 0x0000FA03
		public unsafe string m_fullTypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_m_fullTypeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_m_fullTypeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x0600328A RID: 12938 RVA: 0x000FF6C8 File Offset: 0x000FD8C8
		// (set) Token: 0x0600328B RID: 12939 RVA: 0x00011822 File Offset: 0x0000FA22
		public unsafe string m_assemName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_m_assemName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_m_assemName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x0600328C RID: 12940 RVA: 0x000FF6F0 File Offset: 0x000FD8F0
		// (set) Token: 0x0600328D RID: 12941 RVA: 0x00011841 File Offset: 0x0000FA41
		public unsafe Type objectType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_objectType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_objectType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x0600328E RID: 12942 RVA: 0x000FF720 File Offset: 0x000FD920
		// (set) Token: 0x0600328F RID: 12943 RVA: 0x00011860 File Offset: 0x0000FA60
		public unsafe bool isFullTypeNameSetExplicit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_isFullTypeNameSetExplicit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_isFullTypeNameSetExplicit)) = value;
			}
		}

		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x06003290 RID: 12944 RVA: 0x000FF748 File Offset: 0x000FD948
		// (set) Token: 0x06003291 RID: 12945 RVA: 0x0001187B File Offset: 0x0000FA7B
		public unsafe bool isAssemblyNameSetExplicit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_isAssemblyNameSetExplicit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_isAssemblyNameSetExplicit)) = value;
			}
		}

		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x06003292 RID: 12946 RVA: 0x000FF770 File Offset: 0x000FD970
		// (set) Token: 0x06003293 RID: 12947 RVA: 0x00011896 File Offset: 0x0000FA96
		public unsafe bool requireSameTokenInPartialTrust
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_requireSameTokenInPartialTrust);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfo.NativeFieldInfoPtr_requireSameTokenInPartialTrust)) = value;
			}
		}

		// Token: 0x04002941 RID: 10561
		private static readonly IntPtr NativeFieldInfoPtr_defaultSize;

		// Token: 0x04002942 RID: 10562
		private static readonly IntPtr NativeFieldInfoPtr_s_mscorlibAssemblySimpleName;

		// Token: 0x04002943 RID: 10563
		private static readonly IntPtr NativeFieldInfoPtr_s_mscorlibFileName;

		// Token: 0x04002944 RID: 10564
		private static readonly IntPtr NativeFieldInfoPtr_m_members;

		// Token: 0x04002945 RID: 10565
		private static readonly IntPtr NativeFieldInfoPtr_m_data;

		// Token: 0x04002946 RID: 10566
		private static readonly IntPtr NativeFieldInfoPtr_m_types;

		// Token: 0x04002947 RID: 10567
		private static readonly IntPtr NativeFieldInfoPtr_m_nameToIndex;

		// Token: 0x04002948 RID: 10568
		private static readonly IntPtr NativeFieldInfoPtr_m_currMember;

		// Token: 0x04002949 RID: 10569
		private static readonly IntPtr NativeFieldInfoPtr_m_converter;

		// Token: 0x0400294A RID: 10570
		private static readonly IntPtr NativeFieldInfoPtr_m_fullTypeName;

		// Token: 0x0400294B RID: 10571
		private static readonly IntPtr NativeFieldInfoPtr_m_assemName;

		// Token: 0x0400294C RID: 10572
		private static readonly IntPtr NativeFieldInfoPtr_objectType;

		// Token: 0x0400294D RID: 10573
		private static readonly IntPtr NativeFieldInfoPtr_isFullTypeNameSetExplicit;

		// Token: 0x0400294E RID: 10574
		private static readonly IntPtr NativeFieldInfoPtr_isAssemblyNameSetExplicit;

		// Token: 0x0400294F RID: 10575
		private static readonly IntPtr NativeFieldInfoPtr_requireSameTokenInPartialTrust;

		// Token: 0x04002950 RID: 10576
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_IFormatterConverter_0;

		// Token: 0x04002951 RID: 10577
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_IFormatterConverter_Boolean_0;

		// Token: 0x04002952 RID: 10578
		private static readonly IntPtr NativeMethodInfoPtr_get_FullTypeName_Public_get_String_0;

		// Token: 0x04002953 RID: 10579
		private static readonly IntPtr NativeMethodInfoPtr_get_AssemblyName_Public_get_String_0;

		// Token: 0x04002954 RID: 10580
		private static readonly IntPtr NativeMethodInfoPtr_SetType_Public_Void_Type_0;

		// Token: 0x04002955 RID: 10581
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Private_Static_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002956 RID: 10582
		private static readonly IntPtr NativeMethodInfoPtr_DemandForUnsafeAssemblyNameAssignments_Internal_Static_Void_String_String_0;

		// Token: 0x04002957 RID: 10583
		private static readonly IntPtr NativeMethodInfoPtr_IsAssemblyNameAssignmentSafe_Internal_Static_Boolean_String_String_0;

		// Token: 0x04002958 RID: 10584
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberCount_Public_get_Int32_0;

		// Token: 0x04002959 RID: 10585
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0;

		// Token: 0x0400295A RID: 10586
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFullTypeNameSetExplicit_Public_get_Boolean_0;

		// Token: 0x0400295B RID: 10587
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAssemblyNameSetExplicit_Public_get_Boolean_0;

		// Token: 0x0400295C RID: 10588
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_SerializationInfoEnumerator_0;

		// Token: 0x0400295D RID: 10589
		private static readonly IntPtr NativeMethodInfoPtr_ExpandArrays_Private_Void_0;

		// Token: 0x0400295E RID: 10590
		private static readonly IntPtr NativeMethodInfoPtr_AddValue_Public_Void_String_Object_Type_0;

		// Token: 0x0400295F RID: 10591
		private static readonly IntPtr NativeMethodInfoPtr_AddValue_Public_Void_String_Object_0;

		// Token: 0x04002960 RID: 10592
		private static readonly IntPtr NativeMethodInfoPtr_AddValue_Public_Void_String_Boolean_0;

		// Token: 0x04002961 RID: 10593
		private static readonly IntPtr NativeMethodInfoPtr_AddValue_Public_Void_String_Byte_0;

		// Token: 0x04002962 RID: 10594
		private static readonly IntPtr NativeMethodInfoPtr_AddValue_Public_Void_String_Int16_0;

		// Token: 0x04002963 RID: 10595
		private static readonly IntPtr NativeMethodInfoPtr_AddValue_Public_Void_String_Int32_0;

		// Token: 0x04002964 RID: 10596
		private static readonly IntPtr NativeMethodInfoPtr_AddValue_Public_Void_String_Int64_0;

		// Token: 0x04002965 RID: 10597
		private static readonly IntPtr NativeMethodInfoPtr_AddValue_Public_Void_String_UInt64_0;

		// Token: 0x04002966 RID: 10598
		private static readonly IntPtr NativeMethodInfoPtr_AddValue_Public_Void_String_Single_0;

		// Token: 0x04002967 RID: 10599
		private static readonly IntPtr NativeMethodInfoPtr_AddValue_Public_Void_String_DateTime_0;

		// Token: 0x04002968 RID: 10600
		private static readonly IntPtr NativeMethodInfoPtr_AddValueInternal_Internal_Void_String_Object_Type_0;

		// Token: 0x04002969 RID: 10601
		private static readonly IntPtr NativeMethodInfoPtr_UpdateValue_Internal_Void_String_Object_Type_0;

		// Token: 0x0400296A RID: 10602
		private static readonly IntPtr NativeMethodInfoPtr_FindElement_Private_Int32_String_0;

		// Token: 0x0400296B RID: 10603
		private static readonly IntPtr NativeMethodInfoPtr_GetElement_Private_Object_String_byref_Type_0;

		// Token: 0x0400296C RID: 10604
		private static readonly IntPtr NativeMethodInfoPtr_GetElementNoThrow_Private_Object_String_byref_Type_0;

		// Token: 0x0400296D RID: 10605
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Object_String_Type_0;

		// Token: 0x0400296E RID: 10606
		private static readonly IntPtr NativeMethodInfoPtr_GetValueNoThrow_Internal_Object_String_Type_0;

		// Token: 0x0400296F RID: 10607
		private static readonly IntPtr NativeMethodInfoPtr_GetBoolean_Public_Boolean_String_0;

		// Token: 0x04002970 RID: 10608
		private static readonly IntPtr NativeMethodInfoPtr_GetInt32_Public_Int32_String_0;

		// Token: 0x04002971 RID: 10609
		private static readonly IntPtr NativeMethodInfoPtr_GetInt64_Public_Int64_String_0;

		// Token: 0x04002972 RID: 10610
		private static readonly IntPtr NativeMethodInfoPtr_GetSingle_Public_Single_String_0;

		// Token: 0x04002973 RID: 10611
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_String_String_0;
	}
}
