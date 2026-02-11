using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000067 RID: 103
	public static class ReflectionUtils : Object
	{
		// Token: 0x060008F2 RID: 2290 RVA: 0x0003B9C0 File Offset: 0x00039BC0
		// Note: this type is marked as 'beforefieldinit'.
		static ReflectionUtils()
		{
			Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Utilities", "ReflectionUtils");
			ReflectionUtils.NativeFieldInfoPtr_EmptyTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, "EmptyTypes");
			ReflectionUtils.NativeMethodInfoPtr_IsVirtual_Public_Static_Boolean_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, 100665008);
			ReflectionUtils.NativeMethodInfoPtr_GetBaseDefinition_Public_Static_MethodInfo_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, 100665009);
			ReflectionUtils.NativeMethodInfoPtr_IsPublic_Public_Static_Boolean_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, 100665010);
			ReflectionUtils.NativeMethodInfoPtr_GetObjectType_Public_Static_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, 100665011);
			ReflectionUtils.NativeMethodInfoPtr_GetTypeName_Public_Static_String_Type_TypeNameAssemblyFormatHandling_ISerializationBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, 100665012);
			ReflectionUtils.NativeMethodInfoPtr_GetFullyQualifiedTypeName_Private_Static_String_Type_ISerializationBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, 100665013);
			ReflectionUtils.NativeMethodInfoPtr_RemoveAssemblyDetails_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, 100665014);
			ReflectionUtils.NativeMethodInfoPtr_HasDefaultConstructor_Public_Static_Boolean_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, 100665015);
			ReflectionUtils.NativeMethodInfoPtr_GetDefaultConstructor_Public_Static_ConstructorInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, 100665016);
			ReflectionUtils.NativeMethodInfoPtr_GetDefaultConstructor_Public_Static_ConstructorInfo_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, 100665017);
			ReflectionUtils.NativeMethodInfoPtr_IsNullable_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, 100665018);
			ReflectionUtils.NativeMethodInfoPtr_IsNullableType_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, 100665019);
			ReflectionUtils.NativeMethodInfoPtr_EnsureNotNullableType_Public_Static_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, 100665020);
			ReflectionUtils.NativeMethodInfoPtr_EnsureNotByRefType_Public_Static_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, 100665021);
			ReflectionUtils.NativeMethodInfoPtr_IsGenericDefinition_Public_Static_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, 100665022);
			ReflectionUtils.NativeMethodInfoPtr_ImplementsGenericDefinition_Public_Static_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, 100665023);
			ReflectionUtils.NativeMethodInfoPtr_ImplementsGenericDefinition_Public_Static_Boolean_Type_Type_byref_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, 100665024);
			ReflectionUtils.NativeMethodInfoPtr_InheritsGenericDefinition_Public_Static_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, 100665025);
			ReflectionUtils.NativeMethodInfoPtr_InheritsGenericDefinition_Public_Static_Boolean_Type_Type_byref_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, 100665026);
			ReflectionUtils.NativeMethodInfoPtr_InheritsGenericDefinitionInternal_Private_Static_Boolean_Type_Type_byref_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, 100665027);
			ReflectionUtils.NativeMethodInfoPtr_GetCollectionItemType_Public_Static_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, 100665028);
			ReflectionUtils.NativeMethodInfoPtr_GetDictionaryKeyValueTypes_Public_Static_Void_Type_byref_Type_byref_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, 100665029);
			ReflectionUtils.NativeMethodInfoPtr_GetMemberUnderlyingType_Public_Static_Type_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, 100665030);
			ReflectionUtils.NativeMethodInfoPtr_IsByRefLikeType_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, 100665031);
			ReflectionUtils.NativeMethodInfoPtr_IsIndexedProperty_Public_Static_Boolean_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, 100665032);
			ReflectionUtils.NativeMethodInfoPtr_GetMemberValue_Public_Static_Object_MemberInfo_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, 100665033);
			ReflectionUtils.NativeMethodInfoPtr_SetMemberValue_Public_Static_Void_MemberInfo_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, 100665034);
			ReflectionUtils.NativeMethodInfoPtr_CanReadMemberValue_Public_Static_Boolean_MemberInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, 100665035);
			ReflectionUtils.NativeMethodInfoPtr_CanSetMemberValue_Public_Static_Boolean_MemberInfo_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, 100665036);
			ReflectionUtils.NativeMethodInfoPtr_GetFieldsAndProperties_Public_Static_List_1_MemberInfo_Type_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, 100665037);
			ReflectionUtils.NativeMethodInfoPtr_IsOverridenGenericMember_Private_Static_Boolean_MemberInfo_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, 100665038);
			ReflectionUtils.NativeMethodInfoPtr_GetAttribute_Public_Static_T_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, 100665039);
			ReflectionUtils.NativeMethodInfoPtr_GetAttribute_Public_Static_T_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, 100665040);
			ReflectionUtils.NativeMethodInfoPtr_GetAttributes_Public_Static_Il2CppArrayBase_1_T_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, 100665041);
			ReflectionUtils.NativeMethodInfoPtr_GetAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_Object_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, 100665042);
			ReflectionUtils.NativeMethodInfoPtr_SplitFullyQualifiedTypeName_Public_Static_StructMultiKey_2_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, 100665043);
			ReflectionUtils.NativeMethodInfoPtr_GetAssemblyDelimiterIndex_Private_Static_Nullable_1_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, 100665044);
			ReflectionUtils.NativeMethodInfoPtr_GetMemberInfoFromType_Public_Static_MemberInfo_Type_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, 100665045);
			ReflectionUtils.NativeMethodInfoPtr_GetFields_Public_Static_IEnumerable_1_FieldInfo_Type_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, 100665046);
			ReflectionUtils.NativeMethodInfoPtr_GetChildPrivateFields_Private_Static_Void_IList_1_MemberInfo_Type_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, 100665047);
			ReflectionUtils.NativeMethodInfoPtr_GetProperties_Public_Static_IEnumerable_1_PropertyInfo_Type_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, 100665048);
			ReflectionUtils.NativeMethodInfoPtr_RemoveFlag_Public_Static_BindingFlags_BindingFlags_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, 100665049);
			ReflectionUtils.NativeMethodInfoPtr_GetChildPrivateProperties_Private_Static_Void_IList_1_PropertyInfo_Type_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, 100665050);
			ReflectionUtils.NativeMethodInfoPtr_IsMethodOverridden_Public_Static_Boolean_Type_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, 100665051);
			ReflectionUtils.NativeMethodInfoPtr_GetDefaultValue_Public_Static_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, 100665052);
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x0003BD80 File Offset: 0x00039F80
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 745039, RefRangeEnd = 745044, XrefRangeStart = 745032, XrefRangeEnd = 745039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsVirtual(this PropertyInfo propertyInfo)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(propertyInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.NativeMethodInfoPtr_IsVirtual_Public_Static_Boolean_PropertyInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x0003BDC4 File Offset: 0x00039FC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 745048, RefRangeEnd = 745050, XrefRangeStart = 745044, XrefRangeEnd = 745048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodInfo GetBaseDefinition(this PropertyInfo propertyInfo)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(propertyInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.NativeMethodInfoPtr_GetBaseDefinition_Public_Static_MethodInfo_PropertyInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x0003BE08 File Offset: 0x0003A008
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 745056, RefRangeEnd = 745058, XrefRangeStart = 745050, XrefRangeEnd = 745056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPublic(PropertyInfo property)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.NativeMethodInfoPtr_IsPublic_Public_Static_Boolean_PropertyInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x0003BE4C File Offset: 0x0003A04C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 745059, RefRangeEnd = 745060, XrefRangeStart = 745058, XrefRangeEnd = 745059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetObjectType(Object v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.NativeMethodInfoPtr_GetObjectType_Public_Static_Type_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x0003BE90 File Offset: 0x0003A090
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 745078, RefRangeEnd = 745079, XrefRangeStart = 745060, XrefRangeEnd = 745078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetTypeName(Type t, TypeNameAssemblyFormatHandling assemblyFormat, ISerializationBinder binder)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref assemblyFormat;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.NativeMethodInfoPtr_GetTypeName_Public_Static_String_Type_TypeNameAssemblyFormatHandling_ISerializationBinder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x0003BEEC File Offset: 0x0003A0EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745079, XrefRangeEnd = 745082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetFullyQualifiedTypeName(Type t, ISerializationBinder binder)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.NativeMethodInfoPtr_GetFullyQualifiedTypeName_Private_Static_String_Type_ISerializationBinder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x0003BF3C File Offset: 0x0003A13C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 745094, RefRangeEnd = 745095, XrefRangeStart = 745082, XrefRangeEnd = 745094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string RemoveAssemblyDetails(string fullyQualifiedTypeName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fullyQualifiedTypeName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.NativeMethodInfoPtr_RemoveAssemblyDetails_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x0003BF78 File Offset: 0x0003A178
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 745107, RefRangeEnd = 745109, XrefRangeStart = 745095, XrefRangeEnd = 745107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasDefaultConstructor(Type t, bool nonPublic)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nonPublic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.NativeMethodInfoPtr_HasDefaultConstructor_Public_Static_Boolean_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x0003BFC8 File Offset: 0x0003A1C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 745113, RefRangeEnd = 745114, XrefRangeStart = 745109, XrefRangeEnd = 745113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ConstructorInfo GetDefaultConstructor(Type t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.NativeMethodInfoPtr_GetDefaultConstructor_Public_Static_ConstructorInfo_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConstructorInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x0003C00C File Offset: 0x0003A20C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 745133, RefRangeEnd = 745137, XrefRangeStart = 745114, XrefRangeEnd = 745133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ConstructorInfo GetDefaultConstructor(Type t, bool nonPublic)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nonPublic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.NativeMethodInfoPtr_GetDefaultConstructor_Public_Static_ConstructorInfo_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConstructorInfo>(intPtr3) : null;
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x0003C060 File Offset: 0x0003A260
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 745142, RefRangeEnd = 745148, XrefRangeStart = 745137, XrefRangeEnd = 745142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNullable(Type t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.NativeMethodInfoPtr_IsNullable_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x0003C0A4 File Offset: 0x0003A2A4
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 745154, RefRangeEnd = 745171, XrefRangeStart = 745148, XrefRangeEnd = 745154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNullableType(Type t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.NativeMethodInfoPtr_IsNullableType_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x0003C0E8 File Offset: 0x0003A2E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 745176, RefRangeEnd = 745177, XrefRangeStart = 745171, XrefRangeEnd = 745176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type EnsureNotNullableType(Type t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.NativeMethodInfoPtr_EnsureNotNullableType_Public_Static_Type_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x0003C12C File Offset: 0x0003A32C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 745179, RefRangeEnd = 745181, XrefRangeStart = 745177, XrefRangeEnd = 745179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type EnsureNotByRefType(Type t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.NativeMethodInfoPtr_EnsureNotByRefType_Public_Static_Type_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x0003C170 File Offset: 0x0003A370
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 745186, RefRangeEnd = 745195, XrefRangeStart = 745181, XrefRangeEnd = 745186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsGenericDefinition(Type type, Type genericInterfaceDefinition)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(genericInterfaceDefinition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.NativeMethodInfoPtr_IsGenericDefinition_Public_Static_Boolean_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x0003C1C4 File Offset: 0x0003A3C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 745199, RefRangeEnd = 745201, XrefRangeStart = 745195, XrefRangeEnd = 745199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(genericInterfaceDefinition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.NativeMethodInfoPtr_ImplementsGenericDefinition_Public_Static_Boolean_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x0003C218 File Offset: 0x0003A418
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 745216, RefRangeEnd = 745227, XrefRangeStart = 745201, XrefRangeEnd = 745216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition, out Type implementingType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(genericInterfaceDefinition);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.NativeMethodInfoPtr_ImplementsGenericDefinition_Public_Static_Boolean_Type_Type_byref_Type_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			implementingType = ((intPtr4 == 0) ? null : new Type(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x0003C290 File Offset: 0x0003A490
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 745231, RefRangeEnd = 745234, XrefRangeStart = 745227, XrefRangeEnd = 745231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InheritsGenericDefinition(Type type, Type genericClassDefinition)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(genericClassDefinition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.NativeMethodInfoPtr_InheritsGenericDefinition_Public_Static_Boolean_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x0003C2E4 File Offset: 0x0003A4E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 745255, RefRangeEnd = 745256, XrefRangeStart = 745234, XrefRangeEnd = 745255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InheritsGenericDefinition(Type type, Type genericClassDefinition, out Type implementingType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(genericClassDefinition);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.NativeMethodInfoPtr_InheritsGenericDefinition_Public_Static_Boolean_Type_Type_byref_Type_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			implementingType = ((intPtr4 == 0) ? null : new Type(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x0003C35C File Offset: 0x0003A55C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745256, XrefRangeEnd = 745266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InheritsGenericDefinitionInternal(Type type, Type genericClassDefinition, out Type implementingType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(genericClassDefinition);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.NativeMethodInfoPtr_InheritsGenericDefinitionInternal_Private_Static_Boolean_Type_Type_byref_Type_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			implementingType = ((intPtr4 == 0) ? null : new Type(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x0003C3D4 File Offset: 0x0003A5D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 745285, RefRangeEnd = 745287, XrefRangeStart = 745266, XrefRangeEnd = 745285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetCollectionItemType(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.NativeMethodInfoPtr_GetCollectionItemType_Public_Static_Type_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x0003C418 File Offset: 0x0003A618
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 745307, RefRangeEnd = 745308, XrefRangeStart = 745287, XrefRangeEnd = 745307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetDictionaryKeyValueTypes(Type dictionaryType, out Type keyType, out Type valueType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionaryType);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.NativeMethodInfoPtr_GetDictionaryKeyValueTypes_Public_Static_Void_Type_byref_Type_byref_Type_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			keyType = ((intPtr5 == 0) ? null : new Type(intPtr5));
			IntPtr intPtr6 = intPtr2;
			valueType = ((intPtr6 == 0) ? null : new Type(intPtr6));
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x0003C494 File Offset: 0x0003A694
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 745332, RefRangeEnd = 745338, XrefRangeStart = 745308, XrefRangeEnd = 745332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetMemberUnderlyingType(MemberInfo member)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.NativeMethodInfoPtr_GetMemberUnderlyingType_Public_Static_Type_MemberInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x0003C4D8 File Offset: 0x0003A6D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 745348, RefRangeEnd = 745349, XrefRangeStart = 745338, XrefRangeEnd = 745348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsByRefLikeType(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.NativeMethodInfoPtr_IsByRefLikeType_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x0003C51C File Offset: 0x0003A71C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 745352, RefRangeEnd = 745354, XrefRangeStart = 745349, XrefRangeEnd = 745352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsIndexedProperty(PropertyInfo property)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.NativeMethodInfoPtr_IsIndexedProperty_Public_Static_Boolean_PropertyInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x0003C560 File Offset: 0x0003A760
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 745365, RefRangeEnd = 745366, XrefRangeStart = 745354, XrefRangeEnd = 745365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object GetMemberValue(MemberInfo member, Object target)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.NativeMethodInfoPtr_GetMemberValue_Public_Static_Object_MemberInfo_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x0003C5B8 File Offset: 0x0003A7B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 745378, RefRangeEnd = 745379, XrefRangeStart = 745366, XrefRangeEnd = 745378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetMemberValue(MemberInfo member, Object target, Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.NativeMethodInfoPtr_SetMemberValue_Public_Static_Void_MemberInfo_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x0003C614 File Offset: 0x0003A814
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 745384, RefRangeEnd = 745387, XrefRangeStart = 745379, XrefRangeEnd = 745384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanReadMemberValue(MemberInfo member, bool nonPublic)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nonPublic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.NativeMethodInfoPtr_CanReadMemberValue_Public_Static_Boolean_MemberInfo_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x0003C664 File Offset: 0x0003A864
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 745394, RefRangeEnd = 745398, XrefRangeStart = 745387, XrefRangeEnd = 745394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanSetMemberValue(MemberInfo member, bool nonPublic, bool canSetReadOnly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nonPublic;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canSetReadOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.NativeMethodInfoPtr_CanSetMemberValue_Public_Static_Boolean_MemberInfo_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x0003C6C4 File Offset: 0x0003A8C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 745524, RefRangeEnd = 745526, XrefRangeStart = 745398, XrefRangeEnd = 745524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<MemberInfo> GetFieldsAndProperties(Type type, BindingFlags bindingAttr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.NativeMethodInfoPtr_GetFieldsAndProperties_Public_Static_List_1_MemberInfo_Type_BindingFlags_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<MemberInfo>>(intPtr3) : null;
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x0003C718 File Offset: 0x0003A918
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 745541, RefRangeEnd = 745542, XrefRangeStart = 745526, XrefRangeEnd = 745541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsOverridenGenericMember(MemberInfo memberInfo, BindingFlags bindingAttr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.NativeMethodInfoPtr_IsOverridenGenericMember_Private_Static_Boolean_MemberInfo_BindingFlags_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x0003C768 File Offset: 0x0003A968
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 745564, RefRangeEnd = 745566, XrefRangeStart = 745542, XrefRangeEnd = 745564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetAttribute<T>(Object attributeProvider) where T : Attribute
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeProvider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.MethodInfoStoreGeneric_GetAttribute_Public_Static_T_Object_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x0003C7A8 File Offset: 0x0003A9A8
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 745584, RefRangeEnd = 745593, XrefRangeStart = 745566, XrefRangeEnd = 745584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetAttribute<T>(Object attributeProvider, bool inherit) where T : Attribute
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeProvider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.MethodInfoStoreGeneric_GetAttribute_Public_Static_T_Object_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x0003C7F4 File Offset: 0x0003A9F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745593, XrefRangeEnd = 745606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> GetAttributes<T>(Object attributeProvider, bool inherit) where T : Attribute
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeProvider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.MethodInfoStoreGeneric_GetAttributes_Public_Static_Il2CppArrayBase_1_T_Object_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x0003C840 File Offset: 0x0003AA40
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 745628, RefRangeEnd = 745635, XrefRangeStart = 745606, XrefRangeEnd = 745628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Attribute> GetAttributes(Object attributeProvider, Type attributeType, bool inherit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeProvider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.NativeMethodInfoPtr_GetAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_Object_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Attribute>>(intPtr3) : null;
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x0003C8A4 File Offset: 0x0003AAA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 745653, RefRangeEnd = 745655, XrefRangeStart = 745635, XrefRangeEnd = 745653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StructMultiKey<string, string> SplitFullyQualifiedTypeName(string fullyQualifiedTypeName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fullyQualifiedTypeName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.NativeMethodInfoPtr_SplitFullyQualifiedTypeName_Public_Static_StructMultiKey_2_String_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new StructMultiKey<string, string>(intPtr);
			}
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x0003C8E0 File Offset: 0x0003AAE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745655, XrefRangeEnd = 745659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Nullable<int> GetAssemblyDelimiterIndex(string fullyQualifiedTypeName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fullyQualifiedTypeName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.NativeMethodInfoPtr_GetAssemblyDelimiterIndex_Private_Static_Nullable_1_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
			}
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x0003C91C File Offset: 0x0003AB1C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 745670, RefRangeEnd = 745674, XrefRangeStart = 745659, XrefRangeEnd = 745670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MemberInfo GetMemberInfoFromType(Type targetType, MemberInfo memberInfo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.NativeMethodInfoPtr_GetMemberInfoFromType_Public_Static_MemberInfo_Type_MemberInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MemberInfo>(intPtr3) : null;
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x0003C974 File Offset: 0x0003AB74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745674, XrefRangeEnd = 745691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<FieldInfo> GetFields(Type targetType, BindingFlags bindingAttr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.NativeMethodInfoPtr_GetFields_Public_Static_IEnumerable_1_FieldInfo_Type_BindingFlags_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<FieldInfo>>(intPtr3) : null;
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x0003C9C8 File Offset: 0x0003ABC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 745721, RefRangeEnd = 745723, XrefRangeStart = 745691, XrefRangeEnd = 745721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetChildPrivateFields(IList<MemberInfo> initialFields, Type type, BindingFlags bindingAttr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(initialFields);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.NativeMethodInfoPtr_GetChildPrivateFields_Private_Static_Void_IList_1_MemberInfo_Type_BindingFlags_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x0003CA20 File Offset: 0x0003AC20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 745758, RefRangeEnd = 745759, XrefRangeStart = 745723, XrefRangeEnd = 745758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<PropertyInfo> GetProperties(Type targetType, BindingFlags bindingAttr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.NativeMethodInfoPtr_GetProperties_Public_Static_IEnumerable_1_PropertyInfo_Type_BindingFlags_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PropertyInfo>>(intPtr3) : null;
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x0003CA74 File Offset: 0x0003AC74
		[CallerCount(0)]
		public unsafe static BindingFlags RemoveFlag(this BindingFlags bindingAttr, BindingFlags flag)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flag;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.NativeMethodInfoPtr_RemoveFlag_Public_Static_BindingFlags_BindingFlags_BindingFlags_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x0003CAC0 File Offset: 0x0003ACC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 745821, RefRangeEnd = 745822, XrefRangeStart = 745759, XrefRangeEnd = 745821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetChildPrivateProperties(IList<PropertyInfo> initialProperties, Type type, BindingFlags bindingAttr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(initialProperties);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.NativeMethodInfoPtr_GetChildPrivateProperties_Private_Static_Void_IList_1_PropertyInfo_Type_BindingFlags_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x0003CB18 File Offset: 0x0003AD18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 745838, RefRangeEnd = 745839, XrefRangeStart = 745822, XrefRangeEnd = 745838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsMethodOverridden(Type currentType, Type methodDeclaringType, string method)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(methodDeclaringType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(method);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.NativeMethodInfoPtr_IsMethodOverridden_Public_Static_Boolean_Type_Type_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x0003CB80 File Offset: 0x0003AD80
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 745860, RefRangeEnd = 745863, XrefRangeStart = 745839, XrefRangeEnd = 745860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object GetDefaultValue(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.NativeMethodInfoPtr_GetDefaultValue_Public_Static_Object_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x00004CFC File Offset: 0x00002EFC
		public ReflectionUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000921 RID: 2337 RVA: 0x0003CBC4 File Offset: 0x0003ADC4
		// (set) Token: 0x06000922 RID: 2338 RVA: 0x00004D05 File Offset: 0x00002F05
		public unsafe static Il2CppReferenceArray<Type> EmptyTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReflectionUtils.NativeFieldInfoPtr_EmptyTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectionUtils.NativeFieldInfoPtr_EmptyTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000789 RID: 1929
		private static readonly IntPtr NativeFieldInfoPtr_EmptyTypes;

		// Token: 0x0400078A RID: 1930
		private static readonly IntPtr NativeMethodInfoPtr_IsVirtual_Public_Static_Boolean_PropertyInfo_0;

		// Token: 0x0400078B RID: 1931
		private static readonly IntPtr NativeMethodInfoPtr_GetBaseDefinition_Public_Static_MethodInfo_PropertyInfo_0;

		// Token: 0x0400078C RID: 1932
		private static readonly IntPtr NativeMethodInfoPtr_IsPublic_Public_Static_Boolean_PropertyInfo_0;

		// Token: 0x0400078D RID: 1933
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectType_Public_Static_Type_Object_0;

		// Token: 0x0400078E RID: 1934
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeName_Public_Static_String_Type_TypeNameAssemblyFormatHandling_ISerializationBinder_0;

		// Token: 0x0400078F RID: 1935
		private static readonly IntPtr NativeMethodInfoPtr_GetFullyQualifiedTypeName_Private_Static_String_Type_ISerializationBinder_0;

		// Token: 0x04000790 RID: 1936
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAssemblyDetails_Private_Static_String_String_0;

		// Token: 0x04000791 RID: 1937
		private static readonly IntPtr NativeMethodInfoPtr_HasDefaultConstructor_Public_Static_Boolean_Type_Boolean_0;

		// Token: 0x04000792 RID: 1938
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultConstructor_Public_Static_ConstructorInfo_Type_0;

		// Token: 0x04000793 RID: 1939
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultConstructor_Public_Static_ConstructorInfo_Type_Boolean_0;

		// Token: 0x04000794 RID: 1940
		private static readonly IntPtr NativeMethodInfoPtr_IsNullable_Public_Static_Boolean_Type_0;

		// Token: 0x04000795 RID: 1941
		private static readonly IntPtr NativeMethodInfoPtr_IsNullableType_Public_Static_Boolean_Type_0;

		// Token: 0x04000796 RID: 1942
		private static readonly IntPtr NativeMethodInfoPtr_EnsureNotNullableType_Public_Static_Type_Type_0;

		// Token: 0x04000797 RID: 1943
		private static readonly IntPtr NativeMethodInfoPtr_EnsureNotByRefType_Public_Static_Type_Type_0;

		// Token: 0x04000798 RID: 1944
		private static readonly IntPtr NativeMethodInfoPtr_IsGenericDefinition_Public_Static_Boolean_Type_Type_0;

		// Token: 0x04000799 RID: 1945
		private static readonly IntPtr NativeMethodInfoPtr_ImplementsGenericDefinition_Public_Static_Boolean_Type_Type_0;

		// Token: 0x0400079A RID: 1946
		private static readonly IntPtr NativeMethodInfoPtr_ImplementsGenericDefinition_Public_Static_Boolean_Type_Type_byref_Type_0;

		// Token: 0x0400079B RID: 1947
		private static readonly IntPtr NativeMethodInfoPtr_InheritsGenericDefinition_Public_Static_Boolean_Type_Type_0;

		// Token: 0x0400079C RID: 1948
		private static readonly IntPtr NativeMethodInfoPtr_InheritsGenericDefinition_Public_Static_Boolean_Type_Type_byref_Type_0;

		// Token: 0x0400079D RID: 1949
		private static readonly IntPtr NativeMethodInfoPtr_InheritsGenericDefinitionInternal_Private_Static_Boolean_Type_Type_byref_Type_0;

		// Token: 0x0400079E RID: 1950
		private static readonly IntPtr NativeMethodInfoPtr_GetCollectionItemType_Public_Static_Type_Type_0;

		// Token: 0x0400079F RID: 1951
		private static readonly IntPtr NativeMethodInfoPtr_GetDictionaryKeyValueTypes_Public_Static_Void_Type_byref_Type_byref_Type_0;

		// Token: 0x040007A0 RID: 1952
		private static readonly IntPtr NativeMethodInfoPtr_GetMemberUnderlyingType_Public_Static_Type_MemberInfo_0;

		// Token: 0x040007A1 RID: 1953
		private static readonly IntPtr NativeMethodInfoPtr_IsByRefLikeType_Public_Static_Boolean_Type_0;

		// Token: 0x040007A2 RID: 1954
		private static readonly IntPtr NativeMethodInfoPtr_IsIndexedProperty_Public_Static_Boolean_PropertyInfo_0;

		// Token: 0x040007A3 RID: 1955
		private static readonly IntPtr NativeMethodInfoPtr_GetMemberValue_Public_Static_Object_MemberInfo_Object_0;

		// Token: 0x040007A4 RID: 1956
		private static readonly IntPtr NativeMethodInfoPtr_SetMemberValue_Public_Static_Void_MemberInfo_Object_Object_0;

		// Token: 0x040007A5 RID: 1957
		private static readonly IntPtr NativeMethodInfoPtr_CanReadMemberValue_Public_Static_Boolean_MemberInfo_Boolean_0;

		// Token: 0x040007A6 RID: 1958
		private static readonly IntPtr NativeMethodInfoPtr_CanSetMemberValue_Public_Static_Boolean_MemberInfo_Boolean_Boolean_0;

		// Token: 0x040007A7 RID: 1959
		private static readonly IntPtr NativeMethodInfoPtr_GetFieldsAndProperties_Public_Static_List_1_MemberInfo_Type_BindingFlags_0;

		// Token: 0x040007A8 RID: 1960
		private static readonly IntPtr NativeMethodInfoPtr_IsOverridenGenericMember_Private_Static_Boolean_MemberInfo_BindingFlags_0;

		// Token: 0x040007A9 RID: 1961
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Static_T_Object_0;

		// Token: 0x040007AA RID: 1962
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Static_T_Object_Boolean_0;

		// Token: 0x040007AB RID: 1963
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributes_Public_Static_Il2CppArrayBase_1_T_Object_Boolean_0;

		// Token: 0x040007AC RID: 1964
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_Object_Type_Boolean_0;

		// Token: 0x040007AD RID: 1965
		private static readonly IntPtr NativeMethodInfoPtr_SplitFullyQualifiedTypeName_Public_Static_StructMultiKey_2_String_String_String_0;

		// Token: 0x040007AE RID: 1966
		private static readonly IntPtr NativeMethodInfoPtr_GetAssemblyDelimiterIndex_Private_Static_Nullable_1_Int32_String_0;

		// Token: 0x040007AF RID: 1967
		private static readonly IntPtr NativeMethodInfoPtr_GetMemberInfoFromType_Public_Static_MemberInfo_Type_MemberInfo_0;

		// Token: 0x040007B0 RID: 1968
		private static readonly IntPtr NativeMethodInfoPtr_GetFields_Public_Static_IEnumerable_1_FieldInfo_Type_BindingFlags_0;

		// Token: 0x040007B1 RID: 1969
		private static readonly IntPtr NativeMethodInfoPtr_GetChildPrivateFields_Private_Static_Void_IList_1_MemberInfo_Type_BindingFlags_0;

		// Token: 0x040007B2 RID: 1970
		private static readonly IntPtr NativeMethodInfoPtr_GetProperties_Public_Static_IEnumerable_1_PropertyInfo_Type_BindingFlags_0;

		// Token: 0x040007B3 RID: 1971
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFlag_Public_Static_BindingFlags_BindingFlags_BindingFlags_0;

		// Token: 0x040007B4 RID: 1972
		private static readonly IntPtr NativeMethodInfoPtr_GetChildPrivateProperties_Private_Static_Void_IList_1_PropertyInfo_Type_BindingFlags_0;

		// Token: 0x040007B5 RID: 1973
		private static readonly IntPtr NativeMethodInfoPtr_IsMethodOverridden_Public_Static_Boolean_Type_Type_String_0;

		// Token: 0x040007B6 RID: 1974
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultValue_Public_Static_Object_Type_0;

		// Token: 0x020001B7 RID: 439
		[ObfuscatedName("Newtonsoft.Json.Utilities.ReflectionUtils+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001DF4 RID: 7668 RVA: 0x0008AF94 File Offset: 0x00089194
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ReflectionUtils.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionUtils.__c>.NativeClassPtr);
				ReflectionUtils.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionUtils.__c>.NativeClassPtr, "<>9");
				ReflectionUtils.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionUtils.__c>.NativeClassPtr, "<>9__11_0");
				ReflectionUtils.__c.NativeFieldInfoPtr___9__31_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionUtils.__c>.NativeClassPtr, "<>9__31_0");
				ReflectionUtils.__c.NativeFieldInfoPtr___9__39_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionUtils.__c>.NativeClassPtr, "<>9__39_0");
				ReflectionUtils.__c.NativeFieldInfoPtr___9__41_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionUtils.__c>.NativeClassPtr, "<>9__41_0");
				ReflectionUtils.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils.__c>.NativeClassPtr, 100665054);
				ReflectionUtils.__c.NativeMethodInfoPtr__GetDefaultConstructor_b__11_0_Internal_Boolean_ConstructorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils.__c>.NativeClassPtr, 100665055);
				ReflectionUtils.__c.NativeMethodInfoPtr__GetFieldsAndProperties_b__31_0_Internal_String_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils.__c>.NativeClassPtr, 100665056);
				ReflectionUtils.__c.NativeMethodInfoPtr__GetMemberInfoFromType_b__39_0_Internal_Type_ParameterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils.__c>.NativeClassPtr, 100665057);
				ReflectionUtils.__c.NativeMethodInfoPtr__GetChildPrivateFields_b__41_0_Internal_Boolean_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils.__c>.NativeClassPtr, 100665058);
			}

			// Token: 0x06001DF5 RID: 7669 RVA: 0x0008B088 File Offset: 0x00089288
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionUtils.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DF6 RID: 7670 RVA: 0x0008B0C4 File Offset: 0x000892C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 744999, XrefRangeEnd = 745002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetDefaultConstructor_b__11_0(ConstructorInfo c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.__c.NativeMethodInfoPtr__GetDefaultConstructor_b__11_0_Internal_Boolean_ConstructorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001DF7 RID: 7671 RVA: 0x0008B114 File Offset: 0x00089314
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745002, XrefRangeEnd = 745003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetFieldsAndProperties_b__31_0(MemberInfo m)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.__c.NativeMethodInfoPtr__GetFieldsAndProperties_b__31_0_Internal_String_MemberInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06001DF8 RID: 7672 RVA: 0x0008B15C File Offset: 0x0008935C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745003, XrefRangeEnd = 745004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Type _GetMemberInfoFromType_b__39_0(ParameterInfo p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.__c.NativeMethodInfoPtr__GetMemberInfoFromType_b__39_0_Internal_Type_ParameterInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
				}
			}

			// Token: 0x06001DF9 RID: 7673 RVA: 0x0008B1AC File Offset: 0x000893AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745004, XrefRangeEnd = 745006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetChildPrivateFields_b__41_0(FieldInfo f)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.__c.NativeMethodInfoPtr__GetChildPrivateFields_b__41_0_Internal_Boolean_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001DFA RID: 7674 RVA: 0x0000ED4D File Offset: 0x0000CF4D
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000870 RID: 2160
			// (get) Token: 0x06001DFB RID: 7675 RVA: 0x0008B1FC File Offset: 0x000893FC
			// (set) Token: 0x06001DFC RID: 7676 RVA: 0x0000ED56 File Offset: 0x0000CF56
			public unsafe static ReflectionUtils.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReflectionUtils.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReflectionUtils.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReflectionUtils.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000871 RID: 2161
			// (get) Token: 0x06001DFD RID: 7677 RVA: 0x0008B224 File Offset: 0x00089424
			// (set) Token: 0x06001DFE RID: 7678 RVA: 0x0000ED68 File Offset: 0x0000CF68
			public unsafe static Func<ConstructorInfo, bool> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReflectionUtils.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ConstructorInfo, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReflectionUtils.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000872 RID: 2162
			// (get) Token: 0x06001DFF RID: 7679 RVA: 0x0008B24C File Offset: 0x0008944C
			// (set) Token: 0x06001E00 RID: 7680 RVA: 0x0000ED7A File Offset: 0x0000CF7A
			public unsafe static Func<MemberInfo, string> __9__31_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReflectionUtils.__c.NativeFieldInfoPtr___9__31_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MemberInfo, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReflectionUtils.__c.NativeFieldInfoPtr___9__31_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000873 RID: 2163
			// (get) Token: 0x06001E01 RID: 7681 RVA: 0x0008B274 File Offset: 0x00089474
			// (set) Token: 0x06001E02 RID: 7682 RVA: 0x0000ED8C File Offset: 0x0000CF8C
			public unsafe static Func<ParameterInfo, Type> __9__39_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReflectionUtils.__c.NativeFieldInfoPtr___9__39_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ParameterInfo, Type>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReflectionUtils.__c.NativeFieldInfoPtr___9__39_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000874 RID: 2164
			// (get) Token: 0x06001E03 RID: 7683 RVA: 0x0008B29C File Offset: 0x0008949C
			// (set) Token: 0x06001E04 RID: 7684 RVA: 0x0000ED9E File Offset: 0x0000CF9E
			public unsafe static Func<FieldInfo, bool> __9__41_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReflectionUtils.__c.NativeFieldInfoPtr___9__41_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<FieldInfo, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReflectionUtils.__c.NativeFieldInfoPtr___9__41_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015F3 RID: 5619
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040015F4 RID: 5620
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x040015F5 RID: 5621
			private static readonly IntPtr NativeFieldInfoPtr___9__31_0;

			// Token: 0x040015F6 RID: 5622
			private static readonly IntPtr NativeFieldInfoPtr___9__39_0;

			// Token: 0x040015F7 RID: 5623
			private static readonly IntPtr NativeFieldInfoPtr___9__41_0;

			// Token: 0x040015F8 RID: 5624
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040015F9 RID: 5625
			private static readonly IntPtr NativeMethodInfoPtr__GetDefaultConstructor_b__11_0_Internal_Boolean_ConstructorInfo_0;

			// Token: 0x040015FA RID: 5626
			private static readonly IntPtr NativeMethodInfoPtr__GetFieldsAndProperties_b__31_0_Internal_String_MemberInfo_0;

			// Token: 0x040015FB RID: 5627
			private static readonly IntPtr NativeMethodInfoPtr__GetMemberInfoFromType_b__39_0_Internal_Type_ParameterInfo_0;

			// Token: 0x040015FC RID: 5628
			private static readonly IntPtr NativeMethodInfoPtr__GetChildPrivateFields_b__41_0_Internal_Boolean_FieldInfo_0;
		}

		// Token: 0x020001B8 RID: 440
		[ObfuscatedName("Newtonsoft.Json.Utilities.ReflectionUtils+<>c__DisplayClass31_0")]
		public sealed class __c__DisplayClass31_0 : Object
		{
			// Token: 0x06001E05 RID: 7685 RVA: 0x0008B2C4 File Offset: 0x000894C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass31_0()
			{
				Il2CppClassPointerStore<ReflectionUtils.__c__DisplayClass31_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, "<>c__DisplayClass31_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionUtils.__c__DisplayClass31_0>.NativeClassPtr);
				ReflectionUtils.__c__DisplayClass31_0.NativeFieldInfoPtr_memberInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionUtils.__c__DisplayClass31_0>.NativeClassPtr, "memberInfo");
				ReflectionUtils.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils.__c__DisplayClass31_0>.NativeClassPtr, 100665059);
				ReflectionUtils.__c__DisplayClass31_0.NativeMethodInfoPtr__GetFieldsAndProperties_b__1_Internal_Boolean_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils.__c__DisplayClass31_0>.NativeClassPtr, 100665060);
			}

			// Token: 0x06001E06 RID: 7686 RVA: 0x0008B32C File Offset: 0x0008952C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass31_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionUtils.__c__DisplayClass31_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E07 RID: 7687 RVA: 0x0008B368 File Offset: 0x00089568
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745006, XrefRangeEnd = 745011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetFieldsAndProperties_b__1(MemberInfo m)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.__c__DisplayClass31_0.NativeMethodInfoPtr__GetFieldsAndProperties_b__1_Internal_Boolean_MemberInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001E08 RID: 7688 RVA: 0x0000EDB0 File Offset: 0x0000CFB0
			public __c__DisplayClass31_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000875 RID: 2165
			// (get) Token: 0x06001E09 RID: 7689 RVA: 0x0008B3B8 File Offset: 0x000895B8
			// (set) Token: 0x06001E0A RID: 7690 RVA: 0x0000EDB9 File Offset: 0x0000CFB9
			public unsafe MemberInfo memberInfo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionUtils.__c__DisplayClass31_0.NativeFieldInfoPtr_memberInfo);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemberInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionUtils.__c__DisplayClass31_0.NativeFieldInfoPtr_memberInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015FD RID: 5629
			private static readonly IntPtr NativeFieldInfoPtr_memberInfo;

			// Token: 0x040015FE RID: 5630
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040015FF RID: 5631
			private static readonly IntPtr NativeMethodInfoPtr__GetFieldsAndProperties_b__1_Internal_Boolean_MemberInfo_0;
		}

		// Token: 0x020001B9 RID: 441
		[ObfuscatedName("Newtonsoft.Json.Utilities.ReflectionUtils+<>c__DisplayClass44_0")]
		public sealed class __c__DisplayClass44_0 : Object
		{
			// Token: 0x06001E0B RID: 7691 RVA: 0x0008B3E8 File Offset: 0x000895E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass44_0()
			{
				Il2CppClassPointerStore<ReflectionUtils.__c__DisplayClass44_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, "<>c__DisplayClass44_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionUtils.__c__DisplayClass44_0>.NativeClassPtr);
				ReflectionUtils.__c__DisplayClass44_0.NativeFieldInfoPtr_subTypeProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionUtils.__c__DisplayClass44_0>.NativeClassPtr, "subTypeProperty");
				ReflectionUtils.__c__DisplayClass44_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils.__c__DisplayClass44_0>.NativeClassPtr, 100665061);
				ReflectionUtils.__c__DisplayClass44_0.NativeMethodInfoPtr__GetChildPrivateProperties_b__0_Internal_Boolean_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils.__c__DisplayClass44_0>.NativeClassPtr, 100665062);
				ReflectionUtils.__c__DisplayClass44_0.NativeMethodInfoPtr__GetChildPrivateProperties_b__1_Internal_Boolean_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils.__c__DisplayClass44_0>.NativeClassPtr, 100665063);
			}

			// Token: 0x06001E0C RID: 7692 RVA: 0x0008B464 File Offset: 0x00089664
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass44_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionUtils.__c__DisplayClass44_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.__c__DisplayClass44_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E0D RID: 7693 RVA: 0x0008B4A0 File Offset: 0x000896A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745011, XrefRangeEnd = 745013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetChildPrivateProperties_b__0(PropertyInfo p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.__c__DisplayClass44_0.NativeMethodInfoPtr__GetChildPrivateProperties_b__0_Internal_Boolean_PropertyInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001E0E RID: 7694 RVA: 0x0008B4F0 File Offset: 0x000896F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745013, XrefRangeEnd = 745015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetChildPrivateProperties_b__1(PropertyInfo p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.__c__DisplayClass44_0.NativeMethodInfoPtr__GetChildPrivateProperties_b__1_Internal_Boolean_PropertyInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001E0F RID: 7695 RVA: 0x0000EDD8 File Offset: 0x0000CFD8
			public __c__DisplayClass44_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000876 RID: 2166
			// (get) Token: 0x06001E10 RID: 7696 RVA: 0x0008B540 File Offset: 0x00089740
			// (set) Token: 0x06001E11 RID: 7697 RVA: 0x0000EDE1 File Offset: 0x0000CFE1
			public unsafe PropertyInfo subTypeProperty
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionUtils.__c__DisplayClass44_0.NativeFieldInfoPtr_subTypeProperty);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionUtils.__c__DisplayClass44_0.NativeFieldInfoPtr_subTypeProperty), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001600 RID: 5632
			private static readonly IntPtr NativeFieldInfoPtr_subTypeProperty;

			// Token: 0x04001601 RID: 5633
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001602 RID: 5634
			private static readonly IntPtr NativeMethodInfoPtr__GetChildPrivateProperties_b__0_Internal_Boolean_PropertyInfo_0;

			// Token: 0x04001603 RID: 5635
			private static readonly IntPtr NativeMethodInfoPtr__GetChildPrivateProperties_b__1_Internal_Boolean_PropertyInfo_0;
		}

		// Token: 0x020001BA RID: 442
		[ObfuscatedName("Newtonsoft.Json.Utilities.ReflectionUtils+<>c__DisplayClass44_1")]
		public sealed class __c__DisplayClass44_1 : Object
		{
			// Token: 0x06001E12 RID: 7698 RVA: 0x0008B570 File Offset: 0x00089770
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass44_1()
			{
				Il2CppClassPointerStore<ReflectionUtils.__c__DisplayClass44_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, "<>c__DisplayClass44_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionUtils.__c__DisplayClass44_1>.NativeClassPtr);
				ReflectionUtils.__c__DisplayClass44_1.NativeFieldInfoPtr_subTypePropertyDeclaringType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionUtils.__c__DisplayClass44_1>.NativeClassPtr, "subTypePropertyDeclaringType");
				ReflectionUtils.__c__DisplayClass44_1.NativeFieldInfoPtr_field_Public___c__DisplayClass44_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionUtils.__c__DisplayClass44_1>.NativeClassPtr, "CS$<>8__locals1");
				ReflectionUtils.__c__DisplayClass44_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils.__c__DisplayClass44_1>.NativeClassPtr, 100665064);
				ReflectionUtils.__c__DisplayClass44_1.NativeMethodInfoPtr__GetChildPrivateProperties_b__2_Internal_Boolean_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils.__c__DisplayClass44_1>.NativeClassPtr, 100665065);
			}

			// Token: 0x06001E13 RID: 7699 RVA: 0x0008B5EC File Offset: 0x000897EC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass44_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionUtils.__c__DisplayClass44_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.__c__DisplayClass44_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E14 RID: 7700 RVA: 0x0008B628 File Offset: 0x00089828
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745015, XrefRangeEnd = 745024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetChildPrivateProperties_b__2(PropertyInfo p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.__c__DisplayClass44_1.NativeMethodInfoPtr__GetChildPrivateProperties_b__2_Internal_Boolean_PropertyInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001E15 RID: 7701 RVA: 0x0000EE00 File Offset: 0x0000D000
			public __c__DisplayClass44_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000877 RID: 2167
			// (get) Token: 0x06001E16 RID: 7702 RVA: 0x0008B678 File Offset: 0x00089878
			// (set) Token: 0x06001E17 RID: 7703 RVA: 0x0000EE09 File Offset: 0x0000D009
			public unsafe Type subTypePropertyDeclaringType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionUtils.__c__DisplayClass44_1.NativeFieldInfoPtr_subTypePropertyDeclaringType);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionUtils.__c__DisplayClass44_1.NativeFieldInfoPtr_subTypePropertyDeclaringType), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000878 RID: 2168
			// (get) Token: 0x06001E18 RID: 7704 RVA: 0x0008B6A8 File Offset: 0x000898A8
			// (set) Token: 0x06001E19 RID: 7705 RVA: 0x0000EE28 File Offset: 0x0000D028
			public unsafe ReflectionUtils.__c__DisplayClass44_0 field_Public___c__DisplayClass44_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionUtils.__c__DisplayClass44_1.NativeFieldInfoPtr_field_Public___c__DisplayClass44_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReflectionUtils.__c__DisplayClass44_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionUtils.__c__DisplayClass44_1.NativeFieldInfoPtr_field_Public___c__DisplayClass44_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001604 RID: 5636
			private static readonly IntPtr NativeFieldInfoPtr_subTypePropertyDeclaringType;

			// Token: 0x04001605 RID: 5637
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass44_0_0;

			// Token: 0x04001606 RID: 5638
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001607 RID: 5639
			private static readonly IntPtr NativeMethodInfoPtr__GetChildPrivateProperties_b__2_Internal_Boolean_PropertyInfo_0;
		}

		// Token: 0x020001BB RID: 443
		[ObfuscatedName("Newtonsoft.Json.Utilities.ReflectionUtils+<>c__DisplayClass45_0")]
		public sealed class __c__DisplayClass45_0 : Object
		{
			// Token: 0x06001E1A RID: 7706 RVA: 0x0008B6D8 File Offset: 0x000898D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass45_0()
			{
				Il2CppClassPointerStore<ReflectionUtils.__c__DisplayClass45_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr, "<>c__DisplayClass45_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionUtils.__c__DisplayClass45_0>.NativeClassPtr);
				ReflectionUtils.__c__DisplayClass45_0.NativeFieldInfoPtr_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionUtils.__c__DisplayClass45_0>.NativeClassPtr, "method");
				ReflectionUtils.__c__DisplayClass45_0.NativeFieldInfoPtr_methodDeclaringType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionUtils.__c__DisplayClass45_0>.NativeClassPtr, "methodDeclaringType");
				ReflectionUtils.__c__DisplayClass45_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils.__c__DisplayClass45_0>.NativeClassPtr, 100665066);
				ReflectionUtils.__c__DisplayClass45_0.NativeMethodInfoPtr__IsMethodOverridden_b__0_Internal_Boolean_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionUtils.__c__DisplayClass45_0>.NativeClassPtr, 100665067);
			}

			// Token: 0x06001E1B RID: 7707 RVA: 0x0008B754 File Offset: 0x00089954
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass45_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionUtils.__c__DisplayClass45_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.__c__DisplayClass45_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E1C RID: 7708 RVA: 0x0008B790 File Offset: 0x00089990
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 745024, XrefRangeEnd = 745032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _IsMethodOverridden_b__0(MethodInfo info)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionUtils.__c__DisplayClass45_0.NativeMethodInfoPtr__IsMethodOverridden_b__0_Internal_Boolean_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001E1D RID: 7709 RVA: 0x0000EE47 File Offset: 0x0000D047
			public __c__DisplayClass45_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000879 RID: 2169
			// (get) Token: 0x06001E1E RID: 7710 RVA: 0x0008B7E0 File Offset: 0x000899E0
			// (set) Token: 0x06001E1F RID: 7711 RVA: 0x0000EE50 File Offset: 0x0000D050
			public unsafe string method
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionUtils.__c__DisplayClass45_0.NativeFieldInfoPtr_method);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionUtils.__c__DisplayClass45_0.NativeFieldInfoPtr_method), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700087A RID: 2170
			// (get) Token: 0x06001E20 RID: 7712 RVA: 0x0008B808 File Offset: 0x00089A08
			// (set) Token: 0x06001E21 RID: 7713 RVA: 0x0000EE6F File Offset: 0x0000D06F
			public unsafe Type methodDeclaringType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionUtils.__c__DisplayClass45_0.NativeFieldInfoPtr_methodDeclaringType);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionUtils.__c__DisplayClass45_0.NativeFieldInfoPtr_methodDeclaringType), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001608 RID: 5640
			private static readonly IntPtr NativeFieldInfoPtr_method;

			// Token: 0x04001609 RID: 5641
			private static readonly IntPtr NativeFieldInfoPtr_methodDeclaringType;

			// Token: 0x0400160A RID: 5642
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400160B RID: 5643
			private static readonly IntPtr NativeMethodInfoPtr__IsMethodOverridden_b__0_Internal_Boolean_MethodInfo_0;
		}

		// Token: 0x020001BC RID: 444
		private sealed class MethodInfoStoreGeneric_GetAttribute_Public_Static_T_Object_0<T>
		{
			// Token: 0x0400160C RID: 5644
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ReflectionUtils.NativeMethodInfoPtr_GetAttribute_Public_Static_T_Object_0, Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001BD RID: 445
		private sealed class MethodInfoStoreGeneric_GetAttribute_Public_Static_T_Object_Boolean_0<T>
		{
			// Token: 0x0400160D RID: 5645
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ReflectionUtils.NativeMethodInfoPtr_GetAttribute_Public_Static_T_Object_Boolean_0, Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001BE RID: 446
		private sealed class MethodInfoStoreGeneric_GetAttributes_Public_Static_Il2CppArrayBase_1_T_Object_Boolean_0<T>
		{
			// Token: 0x0400160E RID: 5646
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ReflectionUtils.NativeMethodInfoPtr_GetAttributes_Public_Static_Il2CppArrayBase_1_T_Object_Boolean_0, Il2CppClassPointerStore<ReflectionUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
