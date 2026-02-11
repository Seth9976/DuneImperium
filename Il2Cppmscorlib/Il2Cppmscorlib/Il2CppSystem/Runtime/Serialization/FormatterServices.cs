using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Concurrent;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000326 RID: 806
	public static class FormatterServices : Object
	{
		// Token: 0x06003113 RID: 12563 RVA: 0x000F992C File Offset: 0x000F7B2C
		// Note: this type is marked as 'beforefieldinit'.
		static FormatterServices()
		{
			Il2CppClassPointerStore<FormatterServices>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "FormatterServices");
			FormatterServices.NativeFieldInfoPtr_m_MemberInfoTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, "m_MemberInfoTable");
			FormatterServices.NativeFieldInfoPtr_unsafeTypeForwardersIsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, "unsafeTypeForwardersIsEnabled");
			FormatterServices.NativeFieldInfoPtr_unsafeTypeForwardersIsEnabledInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, "unsafeTypeForwardersIsEnabledInitialized");
			FormatterServices.NativeFieldInfoPtr_advancedTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, "advancedTypes");
			FormatterServices.NativeFieldInfoPtr_s_binder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, "s_binder");
			FormatterServices.NativeMethodInfoPtr_GetSerializableMembers_Private_Static_Il2CppReferenceArray_1_MemberInfo_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671016);
			FormatterServices.NativeMethodInfoPtr_CheckSerializable_Private_Static_Boolean_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671017);
			FormatterServices.NativeMethodInfoPtr_InternalGetSerializableMembers_Private_Static_Il2CppReferenceArray_1_MemberInfo_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671018);
			FormatterServices.NativeMethodInfoPtr_GetParentTypes_Private_Static_Boolean_RuntimeType_byref_Il2CppReferenceArray_1_RuntimeType_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671019);
			FormatterServices.NativeMethodInfoPtr_GetSerializableMembers_Public_Static_Il2CppReferenceArray_1_MemberInfo_Type_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671020);
			FormatterServices.NativeMethodInfoPtr_GetUninitializedObject_Public_Static_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671021);
			FormatterServices.NativeMethodInfoPtr_nativeGetUninitializedObject_Private_Static_Object_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671022);
			FormatterServices.NativeMethodInfoPtr_GetEnableUnsafeTypeForwarders_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671023);
			FormatterServices.NativeMethodInfoPtr_UnsafeTypeForwardersIsEnabled_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671024);
			FormatterServices.NativeMethodInfoPtr_SerializationSetValue_Internal_Static_Void_MemberInfo_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671025);
			FormatterServices.NativeMethodInfoPtr_PopulateObjectMembers_Public_Static_Object_Object_Il2CppReferenceArray_1_MemberInfo_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671026);
			FormatterServices.NativeMethodInfoPtr_GetObjectData_Public_Static_Il2CppReferenceArray_1_Object_Object_Il2CppReferenceArray_1_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671027);
			FormatterServices.NativeMethodInfoPtr_GetTypeFromAssembly_Public_Static_Type_Assembly_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671028);
			FormatterServices.NativeMethodInfoPtr_LoadAssemblyFromString_Internal_Static_Assembly_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671029);
			FormatterServices.NativeMethodInfoPtr_LoadAssemblyFromStringNoThrow_Internal_Static_Assembly_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671030);
			FormatterServices.NativeMethodInfoPtr_GetClrAssemblyName_Internal_Static_String_Type_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671031);
			FormatterServices.NativeMethodInfoPtr_GetClrTypeFullName_Internal_Static_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671032);
			FormatterServices.NativeMethodInfoPtr_GetClrTypeFullNameForArray_Private_Static_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671033);
			FormatterServices.NativeMethodInfoPtr_GetClrTypeFullNameForNonArrayTypes_Private_Static_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, 100671034);
		}

		// Token: 0x06003114 RID: 12564 RVA: 0x000F9B34 File Offset: 0x000F7D34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1384888, RefRangeEnd = 1384889, XrefRangeStart = 1384886, XrefRangeEnd = 1384888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<MemberInfo> GetSerializableMembers(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_GetSerializableMembers_Private_Static_Il2CppReferenceArray_1_MemberInfo_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MemberInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06003115 RID: 12565 RVA: 0x000F9B78 File Offset: 0x000F7D78
		[CallerCount(0)]
		public unsafe static bool CheckSerializable(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_CheckSerializable_Private_Static_Boolean_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003116 RID: 12566 RVA: 0x000F9BBC File Offset: 0x000F7DBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1384942, RefRangeEnd = 1384944, XrefRangeStart = 1384889, XrefRangeEnd = 1384942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<MemberInfo> InternalGetSerializableMembers(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_InternalGetSerializableMembers_Private_Static_Il2CppReferenceArray_1_MemberInfo_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MemberInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06003117 RID: 12567 RVA: 0x000F9C00 File Offset: 0x000F7E00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1384978, RefRangeEnd = 1384979, XrefRangeStart = 1384944, XrefRangeEnd = 1384978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetParentTypes(RuntimeType parentType, out Il2CppReferenceArray<RuntimeType> parentTypes, out int parentTypeCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentType);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &parentTypeCount;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_GetParentTypes_Private_Static_Boolean_RuntimeType_byref_Il2CppReferenceArray_1_RuntimeType_byref_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			parentTypes = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<RuntimeType>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06003118 RID: 12568 RVA: 0x000F9C74 File Offset: 0x000F7E74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1385027, RefRangeEnd = 1385029, XrefRangeStart = 1384979, XrefRangeEnd = 1385027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<MemberInfo> GetSerializableMembers(Type type, StreamingContext context)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_GetSerializableMembers_Public_Static_Il2CppReferenceArray_1_MemberInfo_Type_StreamingContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MemberInfo>>(intPtr3) : null;
		}

		// Token: 0x06003119 RID: 12569 RVA: 0x000F9CD0 File Offset: 0x000F7ED0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1385057, RefRangeEnd = 1385062, XrefRangeStart = 1385029, XrefRangeEnd = 1385057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object GetUninitializedObject(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_GetUninitializedObject_Public_Static_Object_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600311A RID: 12570 RVA: 0x000F9D14 File Offset: 0x000F7F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object nativeGetUninitializedObject(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_nativeGetUninitializedObject_Private_Static_Object_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600311B RID: 12571 RVA: 0x000F9D58 File Offset: 0x000F7F58
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetEnableUnsafeTypeForwarders()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_GetEnableUnsafeTypeForwarders_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600311C RID: 12572 RVA: 0x000F9D88 File Offset: 0x000F7F88
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1385075, RefRangeEnd = 1385080, XrefRangeStart = 1385062, XrefRangeEnd = 1385075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UnsafeTypeForwardersIsEnabled()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_UnsafeTypeForwardersIsEnabled_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600311D RID: 12573 RVA: 0x000F9DB8 File Offset: 0x000F7FB8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1385093, RefRangeEnd = 1385096, XrefRangeStart = 1385080, XrefRangeEnd = 1385093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SerializationSetValue(MemberInfo fi, Object target, Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fi);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_SerializationSetValue_Internal_Static_Void_MemberInfo_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600311E RID: 12574 RVA: 0x000F9E14 File Offset: 0x000F8014
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1385102, RefRangeEnd = 1385103, XrefRangeStart = 1385096, XrefRangeEnd = 1385102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object PopulateObjectMembers(Object obj, Il2CppReferenceArray<MemberInfo> members, Il2CppReferenceArray<Object> data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(members);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_PopulateObjectMembers_Public_Static_Object_Object_Il2CppReferenceArray_1_MemberInfo_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600311F RID: 12575 RVA: 0x000F9E7C File Offset: 0x000F807C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1385118, RefRangeEnd = 1385119, XrefRangeStart = 1385103, XrefRangeEnd = 1385118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Object> GetObjectData(Object obj, Il2CppReferenceArray<MemberInfo> members)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(members);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_GetObjectData_Public_Static_Il2CppReferenceArray_1_Object_Object_Il2CppReferenceArray_1_MemberInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06003120 RID: 12576 RVA: 0x000F9ED4 File Offset: 0x000F80D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1385120, RefRangeEnd = 1385122, XrefRangeStart = 1385119, XrefRangeEnd = 1385120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetTypeFromAssembly(Assembly assem, string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(assem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_GetTypeFromAssembly_Public_Static_Type_Assembly_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06003121 RID: 12577 RVA: 0x000F9F2C File Offset: 0x000F812C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1385123, RefRangeEnd = 1385124, XrefRangeStart = 1385122, XrefRangeEnd = 1385123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Assembly LoadAssemblyFromString(string assemblyName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_LoadAssemblyFromString_Internal_Static_Assembly_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
			}
		}

		// Token: 0x06003122 RID: 12578 RVA: 0x000F9F70 File Offset: 0x000F8170
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1385128, RefRangeEnd = 1385129, XrefRangeStart = 1385124, XrefRangeEnd = 1385128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Assembly LoadAssemblyFromStringNoThrow(string assemblyName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_LoadAssemblyFromStringNoThrow_Internal_Static_Assembly_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
			}
		}

		// Token: 0x06003123 RID: 12579 RVA: 0x000F9FB4 File Offset: 0x000F81B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1385137, RefRangeEnd = 1385138, XrefRangeStart = 1385129, XrefRangeEnd = 1385137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetClrAssemblyName(Type type, out bool hasTypeForwardedFrom)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hasTypeForwardedFrom;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_GetClrAssemblyName_Internal_Static_String_Type_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003124 RID: 12580 RVA: 0x000FA000 File Offset: 0x000F8200
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1385146, RefRangeEnd = 1385150, XrefRangeStart = 1385138, XrefRangeEnd = 1385146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetClrTypeFullName(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_GetClrTypeFullName_Internal_Static_String_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003125 RID: 12581 RVA: 0x000FA03C File Offset: 0x000F823C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1385180, RefRangeEnd = 1385181, XrefRangeStart = 1385150, XrefRangeEnd = 1385180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetClrTypeFullNameForArray(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_GetClrTypeFullNameForArray_Private_Static_String_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003126 RID: 12582 RVA: 0x000FA078 File Offset: 0x000F8278
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1385217, RefRangeEnd = 1385218, XrefRangeStart = 1385181, XrefRangeEnd = 1385217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetClrTypeFullNameForNonArrayTypes(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.NativeMethodInfoPtr_GetClrTypeFullNameForNonArrayTypes_Private_Static_String_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003127 RID: 12583 RVA: 0x00010E9C File Offset: 0x0000F09C
		public FormatterServices(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x06003128 RID: 12584 RVA: 0x000FA0B4 File Offset: 0x000F82B4
		// (set) Token: 0x06003129 RID: 12585 RVA: 0x00010EA5 File Offset: 0x0000F0A5
		public unsafe static ConcurrentDictionary<MemberHolder, Il2CppReferenceArray<MemberInfo>> m_MemberInfoTable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FormatterServices.NativeFieldInfoPtr_m_MemberInfoTable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<MemberHolder, Il2CppReferenceArray<MemberInfo>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FormatterServices.NativeFieldInfoPtr_m_MemberInfoTable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x0600312A RID: 12586 RVA: 0x000FA0DC File Offset: 0x000F82DC
		// (set) Token: 0x0600312B RID: 12587 RVA: 0x00010EB7 File Offset: 0x0000F0B7
		public unsafe static bool unsafeTypeForwardersIsEnabled
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(FormatterServices.NativeFieldInfoPtr_unsafeTypeForwardersIsEnabled, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FormatterServices.NativeFieldInfoPtr_unsafeTypeForwardersIsEnabled, (void*)(&value));
			}
		}

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x0600312C RID: 12588 RVA: 0x000FA0F8 File Offset: 0x000F82F8
		// (set) Token: 0x0600312D RID: 12589 RVA: 0x00010EC5 File Offset: 0x0000F0C5
		public unsafe static bool unsafeTypeForwardersIsEnabledInitialized
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(FormatterServices.NativeFieldInfoPtr_unsafeTypeForwardersIsEnabledInitialized, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FormatterServices.NativeFieldInfoPtr_unsafeTypeForwardersIsEnabledInitialized, (void*)(&value));
			}
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x0600312E RID: 12590 RVA: 0x000FA114 File Offset: 0x000F8314
		// (set) Token: 0x0600312F RID: 12591 RVA: 0x00010ED3 File Offset: 0x0000F0D3
		public unsafe static Il2CppReferenceArray<Type> advancedTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FormatterServices.NativeFieldInfoPtr_advancedTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FormatterServices.NativeFieldInfoPtr_advancedTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x06003130 RID: 12592 RVA: 0x000FA13C File Offset: 0x000F833C
		// (set) Token: 0x06003131 RID: 12593 RVA: 0x00010EE5 File Offset: 0x0000F0E5
		public unsafe static Binder s_binder
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FormatterServices.NativeFieldInfoPtr_s_binder, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Binder>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FormatterServices.NativeFieldInfoPtr_s_binder, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002868 RID: 10344
		private static readonly IntPtr NativeFieldInfoPtr_m_MemberInfoTable;

		// Token: 0x04002869 RID: 10345
		private static readonly IntPtr NativeFieldInfoPtr_unsafeTypeForwardersIsEnabled;

		// Token: 0x0400286A RID: 10346
		private static readonly IntPtr NativeFieldInfoPtr_unsafeTypeForwardersIsEnabledInitialized;

		// Token: 0x0400286B RID: 10347
		private static readonly IntPtr NativeFieldInfoPtr_advancedTypes;

		// Token: 0x0400286C RID: 10348
		private static readonly IntPtr NativeFieldInfoPtr_s_binder;

		// Token: 0x0400286D RID: 10349
		private static readonly IntPtr NativeMethodInfoPtr_GetSerializableMembers_Private_Static_Il2CppReferenceArray_1_MemberInfo_RuntimeType_0;

		// Token: 0x0400286E RID: 10350
		private static readonly IntPtr NativeMethodInfoPtr_CheckSerializable_Private_Static_Boolean_RuntimeType_0;

		// Token: 0x0400286F RID: 10351
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetSerializableMembers_Private_Static_Il2CppReferenceArray_1_MemberInfo_RuntimeType_0;

		// Token: 0x04002870 RID: 10352
		private static readonly IntPtr NativeMethodInfoPtr_GetParentTypes_Private_Static_Boolean_RuntimeType_byref_Il2CppReferenceArray_1_RuntimeType_byref_Int32_0;

		// Token: 0x04002871 RID: 10353
		private static readonly IntPtr NativeMethodInfoPtr_GetSerializableMembers_Public_Static_Il2CppReferenceArray_1_MemberInfo_Type_StreamingContext_0;

		// Token: 0x04002872 RID: 10354
		private static readonly IntPtr NativeMethodInfoPtr_GetUninitializedObject_Public_Static_Object_Type_0;

		// Token: 0x04002873 RID: 10355
		private static readonly IntPtr NativeMethodInfoPtr_nativeGetUninitializedObject_Private_Static_Object_RuntimeType_0;

		// Token: 0x04002874 RID: 10356
		private static readonly IntPtr NativeMethodInfoPtr_GetEnableUnsafeTypeForwarders_Private_Static_Boolean_0;

		// Token: 0x04002875 RID: 10357
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeTypeForwardersIsEnabled_Internal_Static_Boolean_0;

		// Token: 0x04002876 RID: 10358
		private static readonly IntPtr NativeMethodInfoPtr_SerializationSetValue_Internal_Static_Void_MemberInfo_Object_Object_0;

		// Token: 0x04002877 RID: 10359
		private static readonly IntPtr NativeMethodInfoPtr_PopulateObjectMembers_Public_Static_Object_Object_Il2CppReferenceArray_1_MemberInfo_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04002878 RID: 10360
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Static_Il2CppReferenceArray_1_Object_Object_Il2CppReferenceArray_1_MemberInfo_0;

		// Token: 0x04002879 RID: 10361
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeFromAssembly_Public_Static_Type_Assembly_String_0;

		// Token: 0x0400287A RID: 10362
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssemblyFromString_Internal_Static_Assembly_String_0;

		// Token: 0x0400287B RID: 10363
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssemblyFromStringNoThrow_Internal_Static_Assembly_String_0;

		// Token: 0x0400287C RID: 10364
		private static readonly IntPtr NativeMethodInfoPtr_GetClrAssemblyName_Internal_Static_String_Type_byref_Boolean_0;

		// Token: 0x0400287D RID: 10365
		private static readonly IntPtr NativeMethodInfoPtr_GetClrTypeFullName_Internal_Static_String_Type_0;

		// Token: 0x0400287E RID: 10366
		private static readonly IntPtr NativeMethodInfoPtr_GetClrTypeFullNameForArray_Private_Static_String_Type_0;

		// Token: 0x0400287F RID: 10367
		private static readonly IntPtr NativeMethodInfoPtr_GetClrTypeFullNameForNonArrayTypes_Private_Static_String_Type_0;

		// Token: 0x0200066F RID: 1647
		[ObfuscatedName("System.Runtime.Serialization.FormatterServices+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Object
		{
			// Token: 0x06005B68 RID: 23400 RVA: 0x0019FD90 File Offset: 0x0019DF90
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<FormatterServices.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FormatterServices>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormatterServices.__c__DisplayClass9_0>.NativeClassPtr);
				FormatterServices.__c__DisplayClass9_0.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatterServices.__c__DisplayClass9_0>.NativeClassPtr, "type");
				FormatterServices.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices.__c__DisplayClass9_0>.NativeClassPtr, 100671035);
				FormatterServices.__c__DisplayClass9_0.NativeMethodInfoPtr__GetSerializableMembers_b__0_Internal_Il2CppReferenceArray_1_MemberInfo_MemberHolder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterServices.__c__DisplayClass9_0>.NativeClassPtr, 100671036);
			}

			// Token: 0x06005B69 RID: 23401 RVA: 0x0019FDF8 File Offset: 0x0019DFF8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FormatterServices.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005B6A RID: 23402 RVA: 0x0019FE34 File Offset: 0x0019E034
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1384871, XrefRangeEnd = 1384886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppReferenceArray<MemberInfo> _GetSerializableMembers_b__0(MemberHolder _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterServices.__c__DisplayClass9_0.NativeMethodInfoPtr__GetSerializableMembers_b__0_Internal_Il2CppReferenceArray_1_MemberInfo_MemberHolder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MemberInfo>>(intPtr3) : null;
				}
			}

			// Token: 0x06005B6B RID: 23403 RVA: 0x00021225 File Offset: 0x0001F425
			public __c__DisplayClass9_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700176E RID: 5998
			// (get) Token: 0x06005B6C RID: 23404 RVA: 0x0019FE84 File Offset: 0x0019E084
			// (set) Token: 0x06005B6D RID: 23405 RVA: 0x0002122E File Offset: 0x0001F42E
			public unsafe Type type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatterServices.__c__DisplayClass9_0.NativeFieldInfoPtr_type);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormatterServices.__c__DisplayClass9_0.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004A78 RID: 19064
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x04004A79 RID: 19065
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004A7A RID: 19066
			private static readonly IntPtr NativeMethodInfoPtr__GetSerializableMembers_b__0_Internal_Il2CppReferenceArray_1_MemberInfo_MemberHolder_0;
		}
	}
}
