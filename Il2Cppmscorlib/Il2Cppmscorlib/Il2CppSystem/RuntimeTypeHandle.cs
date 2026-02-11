using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.Serialization;
using Il2CppSystem.Threading;

namespace Il2CppSystem
{
	// Token: 0x02000164 RID: 356
	[Serializable]
	[StructLayout(2)]
	public struct RuntimeTypeHandle
	{
		// Token: 0x060017EC RID: 6124 RVA: 0x000979A0 File Offset: 0x00095BA0
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeTypeHandle()
		{
			Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "RuntimeTypeHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr);
			RuntimeTypeHandle.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, "value");
			RuntimeTypeHandle.NativeMethodInfoPtr__ctor_Internal_Void_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667470);
			RuntimeTypeHandle.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667471);
			RuntimeTypeHandle.NativeMethodInfoPtr_get_Value_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667472);
			RuntimeTypeHandle.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667473);
			RuntimeTypeHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667474);
			RuntimeTypeHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667475);
			RuntimeTypeHandle.NativeMethodInfoPtr_GetAttributes_Internal_Static_TypeAttributes_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667476);
			RuntimeTypeHandle.NativeMethodInfoPtr_GetMetadataToken_Private_Static_Int32_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667477);
			RuntimeTypeHandle.NativeMethodInfoPtr_GetToken_Internal_Static_Int32_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667478);
			RuntimeTypeHandle.NativeMethodInfoPtr_GetGenericTypeDefinition_impl_Private_Static_Type_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667479);
			RuntimeTypeHandle.NativeMethodInfoPtr_GetGenericTypeDefinition_Internal_Static_Type_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667480);
			RuntimeTypeHandle.NativeMethodInfoPtr_IsPrimitive_Internal_Static_Boolean_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667481);
			RuntimeTypeHandle.NativeMethodInfoPtr_IsByRef_Internal_Static_Boolean_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667482);
			RuntimeTypeHandle.NativeMethodInfoPtr_IsPointer_Internal_Static_Boolean_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667483);
			RuntimeTypeHandle.NativeMethodInfoPtr_IsArray_Internal_Static_Boolean_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667484);
			RuntimeTypeHandle.NativeMethodInfoPtr_IsSzArray_Internal_Static_Boolean_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667485);
			RuntimeTypeHandle.NativeMethodInfoPtr_HasElementType_Internal_Static_Boolean_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667486);
			RuntimeTypeHandle.NativeMethodInfoPtr_GetCorElementType_Internal_Static_CorElementType_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667487);
			RuntimeTypeHandle.NativeMethodInfoPtr_HasInstantiation_Internal_Static_Boolean_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667488);
			RuntimeTypeHandle.NativeMethodInfoPtr_IsComObject_Internal_Static_Boolean_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667489);
			RuntimeTypeHandle.NativeMethodInfoPtr_IsInstanceOfType_Internal_Static_Boolean_RuntimeType_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667490);
			RuntimeTypeHandle.NativeMethodInfoPtr_HasReferences_Internal_Static_Boolean_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667491);
			RuntimeTypeHandle.NativeMethodInfoPtr_IsComObject_Internal_Static_Boolean_RuntimeType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667492);
			RuntimeTypeHandle.NativeMethodInfoPtr_IsContextful_Internal_Static_Boolean_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667493);
			RuntimeTypeHandle.NativeMethodInfoPtr_IsEquivalentTo_Internal_Static_Boolean_RuntimeType_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667494);
			RuntimeTypeHandle.NativeMethodInfoPtr_IsInterface_Internal_Static_Boolean_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667495);
			RuntimeTypeHandle.NativeMethodInfoPtr_GetArrayRank_Internal_Static_Int32_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667496);
			RuntimeTypeHandle.NativeMethodInfoPtr_GetAssembly_Internal_Static_RuntimeAssembly_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667497);
			RuntimeTypeHandle.NativeMethodInfoPtr_GetElementType_Internal_Static_RuntimeType_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667498);
			RuntimeTypeHandle.NativeMethodInfoPtr_GetModule_Internal_Static_RuntimeModule_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667499);
			RuntimeTypeHandle.NativeMethodInfoPtr_IsGenericVariable_Internal_Static_Boolean_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667500);
			RuntimeTypeHandle.NativeMethodInfoPtr_GetBaseType_Internal_Static_RuntimeType_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667501);
			RuntimeTypeHandle.NativeMethodInfoPtr_CanCastTo_Internal_Static_Boolean_RuntimeType_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667502);
			RuntimeTypeHandle.NativeMethodInfoPtr_type_is_assignable_from_Private_Static_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667503);
			RuntimeTypeHandle.NativeMethodInfoPtr_IsGenericTypeDefinition_Internal_Static_Boolean_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667504);
			RuntimeTypeHandle.NativeMethodInfoPtr_GetGenericParameterInfo_Internal_Static_IntPtr_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667505);
			RuntimeTypeHandle.NativeMethodInfoPtr_IsSubclassOf_Internal_Static_Boolean_RuntimeType_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667506);
			RuntimeTypeHandle.NativeMethodInfoPtr_is_subclass_of_Internal_Static_Boolean_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667507);
			RuntimeTypeHandle.NativeMethodInfoPtr_internal_from_name_Private_Static_RuntimeType_String_byref_StackCrawlMark_Assembly_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667508);
			RuntimeTypeHandle.NativeMethodInfoPtr_GetTypeByName_Internal_Static_RuntimeType_String_Boolean_Boolean_Boolean_byref_StackCrawlMark_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, 100667509);
		}

		// Token: 0x060017ED RID: 6125 RVA: 0x00097D04 File Offset: 0x00095F04
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1348242, RefRangeEnd = 1348248, XrefRangeStart = 1348242, XrefRangeEnd = 1348242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeTypeHandle(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr__ctor_Internal_Void_RuntimeType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017EE RID: 6126 RVA: 0x00097D3C File Offset: 0x00095F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1348248, XrefRangeEnd = 1348259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeTypeHandle(SerializationInfo info, StreamingContext context)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x060017EF RID: 6127 RVA: 0x00097D8C File Offset: 0x00095F8C
		public unsafe IntPtr Value
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_get_Value_Public_get_IntPtr_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017F0 RID: 6128 RVA: 0x00097DBC File Offset: 0x00095FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1348259, XrefRangeEnd = 1348274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017F1 RID: 6129 RVA: 0x00097E0C File Offset: 0x0009600C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1348274, XrefRangeEnd = 1348285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017F2 RID: 6130 RVA: 0x00097E50 File Offset: 0x00096050
		[CallerCount(200)]
		[CachedScanResults(RefRangeStart = 306429, RefRangeEnd = 306629, XrefRangeStart = 306429, XrefRangeEnd = 306629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017F3 RID: 6131 RVA: 0x00097E80 File Offset: 0x00096080
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1348286, RefRangeEnd = 1348287, XrefRangeStart = 1348285, XrefRangeEnd = 1348286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeAttributes GetAttributes(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_GetAttributes_Internal_Static_TypeAttributes_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017F4 RID: 6132 RVA: 0x00097EC4 File Offset: 0x000960C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1348288, RefRangeEnd = 1348289, XrefRangeStart = 1348287, XrefRangeEnd = 1348288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetMetadataToken(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_GetMetadataToken_Private_Static_Int32_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017F5 RID: 6133 RVA: 0x00097F08 File Offset: 0x00096108
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1348288, RefRangeEnd = 1348289, XrefRangeStart = 1348288, XrefRangeEnd = 1348289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetToken(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_GetToken_Internal_Static_Int32_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017F6 RID: 6134 RVA: 0x00097F4C File Offset: 0x0009614C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1348290, RefRangeEnd = 1348291, XrefRangeStart = 1348289, XrefRangeEnd = 1348290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetGenericTypeDefinition_impl(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_GetGenericTypeDefinition_impl_Private_Static_Type_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060017F7 RID: 6135 RVA: 0x00097F90 File Offset: 0x00096190
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1348290, RefRangeEnd = 1348291, XrefRangeStart = 1348290, XrefRangeEnd = 1348291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetGenericTypeDefinition(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_GetGenericTypeDefinition_Internal_Static_Type_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060017F8 RID: 6136 RVA: 0x00097FD4 File Offset: 0x000961D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1348292, RefRangeEnd = 1348293, XrefRangeStart = 1348291, XrefRangeEnd = 1348292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPrimitive(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_IsPrimitive_Internal_Static_Boolean_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017F9 RID: 6137 RVA: 0x00098018 File Offset: 0x00096218
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1348294, RefRangeEnd = 1348295, XrefRangeStart = 1348293, XrefRangeEnd = 1348294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsByRef(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_IsByRef_Internal_Static_Boolean_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017FA RID: 6138 RVA: 0x0009805C File Offset: 0x0009625C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1348296, RefRangeEnd = 1348297, XrefRangeStart = 1348295, XrefRangeEnd = 1348296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPointer(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_IsPointer_Internal_Static_Boolean_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017FB RID: 6139 RVA: 0x000980A0 File Offset: 0x000962A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1348298, RefRangeEnd = 1348299, XrefRangeStart = 1348297, XrefRangeEnd = 1348298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsArray(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_IsArray_Internal_Static_Boolean_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017FC RID: 6140 RVA: 0x000980E4 File Offset: 0x000962E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1348300, RefRangeEnd = 1348301, XrefRangeStart = 1348299, XrefRangeEnd = 1348300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSzArray(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_IsSzArray_Internal_Static_Boolean_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017FD RID: 6141 RVA: 0x00098128 File Offset: 0x00096328
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1348302, RefRangeEnd = 1348303, XrefRangeStart = 1348301, XrefRangeEnd = 1348302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasElementType(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_HasElementType_Internal_Static_Boolean_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017FE RID: 6142 RVA: 0x0009816C File Offset: 0x0009636C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1348303, XrefRangeEnd = 1348304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CorElementType GetCorElementType(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_GetCorElementType_Internal_Static_CorElementType_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017FF RID: 6143 RVA: 0x000981B0 File Offset: 0x000963B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1348305, RefRangeEnd = 1348306, XrefRangeStart = 1348304, XrefRangeEnd = 1348305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasInstantiation(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_HasInstantiation_Internal_Static_Boolean_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001800 RID: 6144 RVA: 0x000981F4 File Offset: 0x000963F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 429053, RefRangeEnd = 429054, XrefRangeStart = 429053, XrefRangeEnd = 429054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsComObject(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_IsComObject_Internal_Static_Boolean_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001801 RID: 6145 RVA: 0x00098238 File Offset: 0x00096438
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1348307, RefRangeEnd = 1348308, XrefRangeStart = 1348306, XrefRangeEnd = 1348307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsInstanceOfType(RuntimeType type, Object o)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_IsInstanceOfType_Internal_Static_Boolean_RuntimeType_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001802 RID: 6146 RVA: 0x0009828C File Offset: 0x0009648C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1348308, XrefRangeEnd = 1348309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasReferences(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_HasReferences_Internal_Static_Boolean_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001803 RID: 6147 RVA: 0x000982D0 File Offset: 0x000964D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1348309, RefRangeEnd = 1348310, XrefRangeStart = 1348309, XrefRangeEnd = 1348309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsComObject(RuntimeType type, bool isGenericCOM)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isGenericCOM;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_IsComObject_Internal_Static_Boolean_RuntimeType_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001804 RID: 6148 RVA: 0x00098320 File Offset: 0x00096520
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1348317, RefRangeEnd = 1348318, XrefRangeStart = 1348310, XrefRangeEnd = 1348317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsContextful(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_IsContextful_Internal_Static_Boolean_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001805 RID: 6149 RVA: 0x00098364 File Offset: 0x00096564
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsEquivalentTo(RuntimeType rtType1, RuntimeType rtType2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rtType1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rtType2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_IsEquivalentTo_Internal_Static_Boolean_RuntimeType_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001806 RID: 6150 RVA: 0x000983B8 File Offset: 0x000965B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1348318, XrefRangeEnd = 1348319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsInterface(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_IsInterface_Internal_Static_Boolean_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001807 RID: 6151 RVA: 0x000983FC File Offset: 0x000965FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1348320, RefRangeEnd = 1348321, XrefRangeStart = 1348319, XrefRangeEnd = 1348320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetArrayRank(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_GetArrayRank_Internal_Static_Int32_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001808 RID: 6152 RVA: 0x00098440 File Offset: 0x00096640
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1348322, RefRangeEnd = 1348324, XrefRangeStart = 1348321, XrefRangeEnd = 1348322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RuntimeAssembly GetAssembly(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_GetAssembly_Internal_Static_RuntimeAssembly_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeAssembly>(intPtr3) : null;
			}
		}

		// Token: 0x06001809 RID: 6153 RVA: 0x00098484 File Offset: 0x00096684
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1348325, RefRangeEnd = 1348326, XrefRangeStart = 1348324, XrefRangeEnd = 1348325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RuntimeType GetElementType(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_GetElementType_Internal_Static_RuntimeType_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeType>(intPtr3) : null;
			}
		}

		// Token: 0x0600180A RID: 6154 RVA: 0x000984C8 File Offset: 0x000966C8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1348327, RefRangeEnd = 1348333, XrefRangeStart = 1348326, XrefRangeEnd = 1348327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RuntimeModule GetModule(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_GetModule_Internal_Static_RuntimeModule_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeModule>(intPtr3) : null;
			}
		}

		// Token: 0x0600180B RID: 6155 RVA: 0x0009850C File Offset: 0x0009670C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1348334, RefRangeEnd = 1348336, XrefRangeStart = 1348333, XrefRangeEnd = 1348334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsGenericVariable(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_IsGenericVariable_Internal_Static_Boolean_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600180C RID: 6156 RVA: 0x00098550 File Offset: 0x00096750
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1348337, RefRangeEnd = 1348338, XrefRangeStart = 1348336, XrefRangeEnd = 1348337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RuntimeType GetBaseType(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_GetBaseType_Internal_Static_RuntimeType_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeType>(intPtr3) : null;
			}
		}

		// Token: 0x0600180D RID: 6157 RVA: 0x00098594 File Offset: 0x00096794
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1348339, RefRangeEnd = 1348340, XrefRangeStart = 1348338, XrefRangeEnd = 1348339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanCastTo(RuntimeType type, RuntimeType target)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_CanCastTo_Internal_Static_Boolean_RuntimeType_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600180E RID: 6158 RVA: 0x000985E8 File Offset: 0x000967E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1348340, XrefRangeEnd = 1348341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool type_is_assignable_from(Type a, Type b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_type_is_assignable_from_Private_Static_Boolean_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600180F RID: 6159 RVA: 0x0009863C File Offset: 0x0009683C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1348342, RefRangeEnd = 1348343, XrefRangeStart = 1348341, XrefRangeEnd = 1348342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsGenericTypeDefinition(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_IsGenericTypeDefinition_Internal_Static_Boolean_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001810 RID: 6160 RVA: 0x00098680 File Offset: 0x00096880
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1348344, RefRangeEnd = 1348347, XrefRangeStart = 1348343, XrefRangeEnd = 1348344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetGenericParameterInfo(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_GetGenericParameterInfo_Internal_Static_IntPtr_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001811 RID: 6161 RVA: 0x000986C4 File Offset: 0x000968C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1348349, RefRangeEnd = 1348350, XrefRangeStart = 1348347, XrefRangeEnd = 1348349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSubclassOf(RuntimeType childType, RuntimeType baseType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(childType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_IsSubclassOf_Internal_Static_Boolean_RuntimeType_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001812 RID: 6162 RVA: 0x00098718 File Offset: 0x00096918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1348350, XrefRangeEnd = 1348351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool is_subclass_of(IntPtr childType, IntPtr baseType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref childType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_is_subclass_of_Internal_Static_Boolean_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001813 RID: 6163 RVA: 0x00098764 File Offset: 0x00096964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1348351, XrefRangeEnd = 1348352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RuntimeType internal_from_name(string name, ref StackCrawlMark stackMark, Assembly callerAssembly, bool throwOnError, bool ignoreCase, bool reflectionOnly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callerAssembly);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnError;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reflectionOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_internal_from_name_Private_Static_RuntimeType_String_byref_StackCrawlMark_Assembly_Boolean_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeType>(intPtr3) : null;
		}

		// Token: 0x06001814 RID: 6164 RVA: 0x000987F4 File Offset: 0x000969F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1348360, RefRangeEnd = 1348361, XrefRangeStart = 1348352, XrefRangeEnd = 1348360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RuntimeType GetTypeByName(string typeName, bool throwOnError, bool ignoreCase, bool reflectionOnly, ref StackCrawlMark stackMark, bool loadTypeFromPartialName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnError;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reflectionOnly;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadTypeFromPartialName;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeTypeHandle.NativeMethodInfoPtr_GetTypeByName_Internal_Static_RuntimeType_String_Boolean_Boolean_Boolean_byref_StackCrawlMark_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeType>(intPtr3) : null;
		}

		// Token: 0x06001815 RID: 6165 RVA: 0x000078D9 File Offset: 0x00005AD9
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RuntimeTypeHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x04001482 RID: 5250
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04001483 RID: 5251
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_RuntimeType_0;

		// Token: 0x04001484 RID: 5252
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001485 RID: 5253
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_IntPtr_0;

		// Token: 0x04001486 RID: 5254
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001487 RID: 5255
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001488 RID: 5256
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001489 RID: 5257
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributes_Internal_Static_TypeAttributes_RuntimeType_0;

		// Token: 0x0400148A RID: 5258
		private static readonly IntPtr NativeMethodInfoPtr_GetMetadataToken_Private_Static_Int32_RuntimeType_0;

		// Token: 0x0400148B RID: 5259
		private static readonly IntPtr NativeMethodInfoPtr_GetToken_Internal_Static_Int32_RuntimeType_0;

		// Token: 0x0400148C RID: 5260
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericTypeDefinition_impl_Private_Static_Type_RuntimeType_0;

		// Token: 0x0400148D RID: 5261
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericTypeDefinition_Internal_Static_Type_RuntimeType_0;

		// Token: 0x0400148E RID: 5262
		private static readonly IntPtr NativeMethodInfoPtr_IsPrimitive_Internal_Static_Boolean_RuntimeType_0;

		// Token: 0x0400148F RID: 5263
		private static readonly IntPtr NativeMethodInfoPtr_IsByRef_Internal_Static_Boolean_RuntimeType_0;

		// Token: 0x04001490 RID: 5264
		private static readonly IntPtr NativeMethodInfoPtr_IsPointer_Internal_Static_Boolean_RuntimeType_0;

		// Token: 0x04001491 RID: 5265
		private static readonly IntPtr NativeMethodInfoPtr_IsArray_Internal_Static_Boolean_RuntimeType_0;

		// Token: 0x04001492 RID: 5266
		private static readonly IntPtr NativeMethodInfoPtr_IsSzArray_Internal_Static_Boolean_RuntimeType_0;

		// Token: 0x04001493 RID: 5267
		private static readonly IntPtr NativeMethodInfoPtr_HasElementType_Internal_Static_Boolean_RuntimeType_0;

		// Token: 0x04001494 RID: 5268
		private static readonly IntPtr NativeMethodInfoPtr_GetCorElementType_Internal_Static_CorElementType_RuntimeType_0;

		// Token: 0x04001495 RID: 5269
		private static readonly IntPtr NativeMethodInfoPtr_HasInstantiation_Internal_Static_Boolean_RuntimeType_0;

		// Token: 0x04001496 RID: 5270
		private static readonly IntPtr NativeMethodInfoPtr_IsComObject_Internal_Static_Boolean_RuntimeType_0;

		// Token: 0x04001497 RID: 5271
		private static readonly IntPtr NativeMethodInfoPtr_IsInstanceOfType_Internal_Static_Boolean_RuntimeType_Object_0;

		// Token: 0x04001498 RID: 5272
		private static readonly IntPtr NativeMethodInfoPtr_HasReferences_Internal_Static_Boolean_RuntimeType_0;

		// Token: 0x04001499 RID: 5273
		private static readonly IntPtr NativeMethodInfoPtr_IsComObject_Internal_Static_Boolean_RuntimeType_Boolean_0;

		// Token: 0x0400149A RID: 5274
		private static readonly IntPtr NativeMethodInfoPtr_IsContextful_Internal_Static_Boolean_RuntimeType_0;

		// Token: 0x0400149B RID: 5275
		private static readonly IntPtr NativeMethodInfoPtr_IsEquivalentTo_Internal_Static_Boolean_RuntimeType_RuntimeType_0;

		// Token: 0x0400149C RID: 5276
		private static readonly IntPtr NativeMethodInfoPtr_IsInterface_Internal_Static_Boolean_RuntimeType_0;

		// Token: 0x0400149D RID: 5277
		private static readonly IntPtr NativeMethodInfoPtr_GetArrayRank_Internal_Static_Int32_RuntimeType_0;

		// Token: 0x0400149E RID: 5278
		private static readonly IntPtr NativeMethodInfoPtr_GetAssembly_Internal_Static_RuntimeAssembly_RuntimeType_0;

		// Token: 0x0400149F RID: 5279
		private static readonly IntPtr NativeMethodInfoPtr_GetElementType_Internal_Static_RuntimeType_RuntimeType_0;

		// Token: 0x040014A0 RID: 5280
		private static readonly IntPtr NativeMethodInfoPtr_GetModule_Internal_Static_RuntimeModule_RuntimeType_0;

		// Token: 0x040014A1 RID: 5281
		private static readonly IntPtr NativeMethodInfoPtr_IsGenericVariable_Internal_Static_Boolean_RuntimeType_0;

		// Token: 0x040014A2 RID: 5282
		private static readonly IntPtr NativeMethodInfoPtr_GetBaseType_Internal_Static_RuntimeType_RuntimeType_0;

		// Token: 0x040014A3 RID: 5283
		private static readonly IntPtr NativeMethodInfoPtr_CanCastTo_Internal_Static_Boolean_RuntimeType_RuntimeType_0;

		// Token: 0x040014A4 RID: 5284
		private static readonly IntPtr NativeMethodInfoPtr_type_is_assignable_from_Private_Static_Boolean_Type_Type_0;

		// Token: 0x040014A5 RID: 5285
		private static readonly IntPtr NativeMethodInfoPtr_IsGenericTypeDefinition_Internal_Static_Boolean_RuntimeType_0;

		// Token: 0x040014A6 RID: 5286
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericParameterInfo_Internal_Static_IntPtr_RuntimeType_0;

		// Token: 0x040014A7 RID: 5287
		private static readonly IntPtr NativeMethodInfoPtr_IsSubclassOf_Internal_Static_Boolean_RuntimeType_RuntimeType_0;

		// Token: 0x040014A8 RID: 5288
		private static readonly IntPtr NativeMethodInfoPtr_is_subclass_of_Internal_Static_Boolean_IntPtr_IntPtr_0;

		// Token: 0x040014A9 RID: 5289
		private static readonly IntPtr NativeMethodInfoPtr_internal_from_name_Private_Static_RuntimeType_String_byref_StackCrawlMark_Assembly_Boolean_Boolean_Boolean_0;

		// Token: 0x040014AA RID: 5290
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeByName_Internal_Static_RuntimeType_String_Boolean_Boolean_Boolean_byref_StackCrawlMark_Boolean_0;

		// Token: 0x040014AB RID: 5291
		[FieldOffset(0)]
		public IntPtr value;
	}
}
