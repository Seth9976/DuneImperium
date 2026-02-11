using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Globalization;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Reflection
{
	// Token: 0x0200044E RID: 1102
	[Serializable]
	public class RuntimePropertyInfo : PropertyInfo
	{
		// Token: 0x06004045 RID: 16453 RVA: 0x00133C64 File Offset: 0x00131E64
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimePropertyInfo()
		{
			Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "RuntimePropertyInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr);
			RuntimePropertyInfo.NativeFieldInfoPtr_klass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, "klass");
			RuntimePropertyInfo.NativeFieldInfoPtr_prop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, "prop");
			RuntimePropertyInfo.NativeFieldInfoPtr_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, "info");
			RuntimePropertyInfo.NativeFieldInfoPtr_cached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, "cached");
			RuntimePropertyInfo.NativeFieldInfoPtr_cached_getter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, "cached_getter");
			RuntimePropertyInfo.NativeMethodInfoPtr_get_property_info_Internal_Static_Void_RuntimePropertyInfo_byref_MonoPropertyInfo_PInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, 100672980);
			RuntimePropertyInfo.NativeMethodInfoPtr_get_BindingFlags_Internal_get_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, 100672981);
			RuntimePropertyInfo.NativeMethodInfoPtr_get_Module_Public_Virtual_get_Module_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, 100672982);
			RuntimePropertyInfo.NativeMethodInfoPtr_GetDeclaringTypeInternal_Internal_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, 100672983);
			RuntimePropertyInfo.NativeMethodInfoPtr_get_ReflectedTypeInternal_Private_get_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, 100672984);
			RuntimePropertyInfo.NativeMethodInfoPtr_GetRuntimeModule_Internal_RuntimeModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, 100672985);
			RuntimePropertyInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, 100672986);
			RuntimePropertyInfo.NativeMethodInfoPtr_FormatNameAndSig_Private_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, 100672987);
			RuntimePropertyInfo.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, 100672988);
			RuntimePropertyInfo.NativeMethodInfoPtr_SerializationToString_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, 100672989);
			RuntimePropertyInfo.NativeMethodInfoPtr_CachePropertyInfo_Private_Void_PInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, 100672990);
			RuntimePropertyInfo.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, 100672991);
			RuntimePropertyInfo.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, 100672992);
			RuntimePropertyInfo.NativeMethodInfoPtr_get_PropertyType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, 100672993);
			RuntimePropertyInfo.NativeMethodInfoPtr_get_ReflectedType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, 100672994);
			RuntimePropertyInfo.NativeMethodInfoPtr_get_DeclaringType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, 100672995);
			RuntimePropertyInfo.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, 100672996);
			RuntimePropertyInfo.NativeMethodInfoPtr_GetGetMethod_Public_Virtual_MethodInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, 100672997);
			RuntimePropertyInfo.NativeMethodInfoPtr_GetIndexParameters_Public_Virtual_Il2CppReferenceArray_1_ParameterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, 100672998);
			RuntimePropertyInfo.NativeMethodInfoPtr_GetSetMethod_Public_Virtual_MethodInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, 100672999);
			RuntimePropertyInfo.NativeMethodInfoPtr_IsDefined_Public_Virtual_Boolean_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, 100673000);
			RuntimePropertyInfo.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, 100673001);
			RuntimePropertyInfo.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, 100673002);
			RuntimePropertyInfo.NativeMethodInfoPtr_GetterAdapterFrame_Private_Static_Object_Getter_2_T_R_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, 100673003);
			RuntimePropertyInfo.NativeMethodInfoPtr_StaticGetterAdapterFrame_Private_Static_Object_StaticGetter_1_R_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, 100673004);
			RuntimePropertyInfo.NativeMethodInfoPtr_GetValue_Public_Virtual_Object_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, 100673005);
			RuntimePropertyInfo.NativeMethodInfoPtr_GetValue_Public_Virtual_Object_Object_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, 100673006);
			RuntimePropertyInfo.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_Object_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, 100673007);
			RuntimePropertyInfo.NativeMethodInfoPtr_GetCustomAttributesData_Public_Virtual_IList_1_CustomAttributeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, 100673008);
			RuntimePropertyInfo.NativeMethodInfoPtr_get_MetadataToken_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, 100673009);
			RuntimePropertyInfo.NativeMethodInfoPtr_get_metadata_token_Internal_Static_Int32_RuntimePropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, 100673010);
			RuntimePropertyInfo.NativeMethodInfoPtr_internal_from_handle_type_Private_Static_PropertyInfo_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, 100673011);
			RuntimePropertyInfo.NativeMethodInfoPtr_GetPropertyFromHandle_Internal_Static_PropertyInfo_RuntimePropertyHandle_RuntimeTypeHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, 100673012);
			RuntimePropertyInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, 100673013);
		}

		// Token: 0x06004046 RID: 16454 RVA: 0x00133FA0 File Offset: 0x001321A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402101, XrefRangeEnd = 1402102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_property_info(RuntimePropertyInfo prop, ref MonoPropertyInfo info, PInfo req_info)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prop);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(info);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref req_info;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimePropertyInfo.NativeMethodInfoPtr_get_property_info_Internal_Static_Void_RuntimePropertyInfo_byref_MonoPropertyInfo_PInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000F4B RID: 3915
		// (get) Token: 0x06004047 RID: 16455 RVA: 0x00133FF8 File Offset: 0x001321F8
		public unsafe BindingFlags BindingFlags
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimePropertyInfo.NativeMethodInfoPtr_get_BindingFlags_Internal_get_BindingFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F4C RID: 3916
		// (get) Token: 0x06004048 RID: 16456 RVA: 0x00134034 File Offset: 0x00132234
		public unsafe override Module Module
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402102, XrefRangeEnd = 1402107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimePropertyInfo.NativeMethodInfoPtr_get_Module_Public_Virtual_get_Module_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Module>(intPtr3) : null;
			}
		}

		// Token: 0x06004049 RID: 16457 RVA: 0x00134080 File Offset: 0x00132280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402107, XrefRangeEnd = 1402109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeType GetDeclaringTypeInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimePropertyInfo.NativeMethodInfoPtr_GetDeclaringTypeInternal_Internal_RuntimeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeType>(intPtr3) : null;
		}

		// Token: 0x17000F4D RID: 3917
		// (get) Token: 0x0600404A RID: 16458 RVA: 0x001340C0 File Offset: 0x001322C0
		public unsafe RuntimeType ReflectedTypeInternal
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402109, XrefRangeEnd = 1402111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimePropertyInfo.NativeMethodInfoPtr_get_ReflectedTypeInternal_Private_get_RuntimeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeType>(intPtr3) : null;
			}
		}

		// Token: 0x0600404B RID: 16459 RVA: 0x00134100 File Offset: 0x00132300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeModule GetRuntimeModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimePropertyInfo.NativeMethodInfoPtr_GetRuntimeModule_Internal_RuntimeModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeModule>(intPtr3) : null;
		}

		// Token: 0x0600404C RID: 16460 RVA: 0x00134140 File Offset: 0x00132340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402111, XrefRangeEnd = 1402112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimePropertyInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600404D RID: 16461 RVA: 0x00134184 File Offset: 0x00132384
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1402128, RefRangeEnd = 1402131, XrefRangeStart = 1402112, XrefRangeEnd = 1402128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FormatNameAndSig(bool serialization)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref serialization;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimePropertyInfo.NativeMethodInfoPtr_FormatNameAndSig_Private_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600404E RID: 16462 RVA: 0x001341C8 File Offset: 0x001323C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402131, XrefRangeEnd = 1402135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimePropertyInfo.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600404F RID: 16463 RVA: 0x00134224 File Offset: 0x00132424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402135, XrefRangeEnd = 1402136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string SerializationToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimePropertyInfo.NativeMethodInfoPtr_SerializationToString_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004050 RID: 16464 RVA: 0x0013425C File Offset: 0x0013245C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402136, XrefRangeEnd = 1402137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CachePropertyInfo(PInfo flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimePropertyInfo.NativeMethodInfoPtr_CachePropertyInfo_Private_Void_PInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000F4E RID: 3918
		// (get) Token: 0x06004051 RID: 16465 RVA: 0x0013429C File Offset: 0x0013249C
		public unsafe override bool CanRead
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402137, XrefRangeEnd = 1402139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimePropertyInfo.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F4F RID: 3919
		// (get) Token: 0x06004052 RID: 16466 RVA: 0x001342E4 File Offset: 0x001324E4
		public unsafe override bool CanWrite
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402139, XrefRangeEnd = 1402141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimePropertyInfo.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F50 RID: 3920
		// (get) Token: 0x06004053 RID: 16467 RVA: 0x0013432C File Offset: 0x0013252C
		public unsafe override Type PropertyType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402141, XrefRangeEnd = 1402145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimePropertyInfo.NativeMethodInfoPtr_get_PropertyType_Public_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000F51 RID: 3921
		// (get) Token: 0x06004054 RID: 16468 RVA: 0x00134378 File Offset: 0x00132578
		public unsafe override Type ReflectedType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402145, XrefRangeEnd = 1402146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimePropertyInfo.NativeMethodInfoPtr_get_ReflectedType_Public_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000F52 RID: 3922
		// (get) Token: 0x06004055 RID: 16469 RVA: 0x001343C4 File Offset: 0x001325C4
		public unsafe override Type DeclaringType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402146, XrefRangeEnd = 1402147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimePropertyInfo.NativeMethodInfoPtr_get_DeclaringType_Public_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000F53 RID: 3923
		// (get) Token: 0x06004056 RID: 16470 RVA: 0x00134410 File Offset: 0x00132610
		public unsafe override string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402147, XrefRangeEnd = 1402148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimePropertyInfo.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06004057 RID: 16471 RVA: 0x00134454 File Offset: 0x00132654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402148, XrefRangeEnd = 1402151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MethodInfo GetGetMethod(bool nonPublic)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nonPublic;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimePropertyInfo.NativeMethodInfoPtr_GetGetMethod_Public_Virtual_MethodInfo_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06004058 RID: 16472 RVA: 0x001344AC File Offset: 0x001326AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402151, XrefRangeEnd = 1402159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<ParameterInfo> GetIndexParameters()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimePropertyInfo.NativeMethodInfoPtr_GetIndexParameters_Public_Virtual_Il2CppReferenceArray_1_ParameterInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParameterInfo>>(intPtr3) : null;
		}

		// Token: 0x06004059 RID: 16473 RVA: 0x001344F8 File Offset: 0x001326F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402159, XrefRangeEnd = 1402162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MethodInfo GetSetMethod(bool nonPublic)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nonPublic;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimePropertyInfo.NativeMethodInfoPtr_GetSetMethod_Public_Virtual_MethodInfo_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x0600405A RID: 16474 RVA: 0x00134550 File Offset: 0x00132750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402162, XrefRangeEnd = 1402166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimePropertyInfo.NativeMethodInfoPtr_IsDefined_Public_Virtual_Boolean_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600405B RID: 16475 RVA: 0x001345B8 File Offset: 0x001327B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402166, XrefRangeEnd = 1402170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Object> GetCustomAttributes(bool inherit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inherit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimePropertyInfo.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x0600405C RID: 16476 RVA: 0x00134610 File Offset: 0x00132810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402170, XrefRangeEnd = 1402174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimePropertyInfo.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x0600405D RID: 16477 RVA: 0x0013467C File Offset: 0x0013287C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402174, XrefRangeEnd = 1402180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object GetterAdapterFrame<T, R>(RuntimePropertyInfo.Getter<T, R> getter, Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimePropertyInfo.MethodInfoStoreGeneric_GetterAdapterFrame_Private_Static_Object_Getter_2_T_R_Object_0<T, R>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600405E RID: 16478 RVA: 0x001346D4 File Offset: 0x001328D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402180, XrefRangeEnd = 1402183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object StaticGetterAdapterFrame<R>(RuntimePropertyInfo.StaticGetter<R> getter, Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimePropertyInfo.MethodInfoStoreGeneric_StaticGetterAdapterFrame_Private_Static_Object_StaticGetter_1_R_Object_0<R>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600405F RID: 16479 RVA: 0x0013472C File Offset: 0x0013292C
		[CallerCount(0)]
		public unsafe override Object GetValue(Object obj, Il2CppReferenceArray<Object> index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(index);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimePropertyInfo.NativeMethodInfoPtr_GetValue_Public_Virtual_Object_Object_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06004060 RID: 16480 RVA: 0x0013479C File Offset: 0x0013299C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402183, XrefRangeEnd = 1402186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object GetValue(Object obj, BindingFlags invokeAttr, Binder binder, Il2CppReferenceArray<Object> index, CultureInfo culture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invokeAttr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(index);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimePropertyInfo.NativeMethodInfoPtr_GetValue_Public_Virtual_Object_Object_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06004061 RID: 16481 RVA: 0x00134840 File Offset: 0x00132A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402186, XrefRangeEnd = 1402197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetValue(Object obj, Object value, BindingFlags invokeAttr, Binder binder, Il2CppReferenceArray<Object> index, CultureInfo culture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invokeAttr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(index);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimePropertyInfo.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_Object_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004062 RID: 16482 RVA: 0x001348E8 File Offset: 0x00132AE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402197, XrefRangeEnd = 1402198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IList<CustomAttributeData> GetCustomAttributesData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimePropertyInfo.NativeMethodInfoPtr_GetCustomAttributesData_Public_Virtual_IList_1_CustomAttributeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<CustomAttributeData>>(intPtr3) : null;
		}

		// Token: 0x17000F54 RID: 3924
		// (get) Token: 0x06004063 RID: 16483 RVA: 0x00134934 File Offset: 0x00132B34
		public unsafe override int MetadataToken
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimePropertyInfo.NativeMethodInfoPtr_get_MetadataToken_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004064 RID: 16484 RVA: 0x0013497C File Offset: 0x00132B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int get_metadata_token(RuntimePropertyInfo monoProperty)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(monoProperty);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimePropertyInfo.NativeMethodInfoPtr_get_metadata_token_Internal_Static_Int32_RuntimePropertyInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004065 RID: 16485 RVA: 0x001349C0 File Offset: 0x00132BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402198, XrefRangeEnd = 1402199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertyInfo internal_from_handle_type(IntPtr event_handle, IntPtr type_handle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref event_handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type_handle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimePropertyInfo.NativeMethodInfoPtr_internal_from_handle_type_Private_Static_PropertyInfo_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr3) : null;
		}

		// Token: 0x06004066 RID: 16486 RVA: 0x00134A10 File Offset: 0x00132C10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1402202, RefRangeEnd = 1402203, XrefRangeStart = 1402199, XrefRangeEnd = 1402202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertyInfo GetPropertyFromHandle(RuntimePropertyHandle handle, RuntimeTypeHandle reflectedType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reflectedType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimePropertyInfo.NativeMethodInfoPtr_GetPropertyFromHandle_Internal_Static_PropertyInfo_RuntimePropertyHandle_RuntimeTypeHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr3) : null;
		}

		// Token: 0x06004067 RID: 16487 RVA: 0x00134A60 File Offset: 0x00132C60
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimePropertyInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimePropertyInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004068 RID: 16488 RVA: 0x00017664 File Offset: 0x00015864
		public RuntimePropertyInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F46 RID: 3910
		// (get) Token: 0x06004069 RID: 16489 RVA: 0x00134A9C File Offset: 0x00132C9C
		// (set) Token: 0x0600406A RID: 16490 RVA: 0x0001766D File Offset: 0x0001586D
		public unsafe IntPtr klass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimePropertyInfo.NativeFieldInfoPtr_klass);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimePropertyInfo.NativeFieldInfoPtr_klass)) = value;
			}
		}

		// Token: 0x17000F47 RID: 3911
		// (get) Token: 0x0600406B RID: 16491 RVA: 0x00134AC4 File Offset: 0x00132CC4
		// (set) Token: 0x0600406C RID: 16492 RVA: 0x00017688 File Offset: 0x00015888
		public unsafe IntPtr prop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimePropertyInfo.NativeFieldInfoPtr_prop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimePropertyInfo.NativeFieldInfoPtr_prop)) = value;
			}
		}

		// Token: 0x17000F48 RID: 3912
		// (get) Token: 0x0600406D RID: 16493 RVA: 0x00134AEC File Offset: 0x00132CEC
		// (set) Token: 0x0600406E RID: 16494 RVA: 0x000176A3 File Offset: 0x000158A3
		public MonoPropertyInfo info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimePropertyInfo.NativeFieldInfoPtr_info);
				return new MonoPropertyInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MonoPropertyInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimePropertyInfo.NativeFieldInfoPtr_info), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MonoPropertyInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000F49 RID: 3913
		// (get) Token: 0x0600406F RID: 16495 RVA: 0x00134B1C File Offset: 0x00132D1C
		// (set) Token: 0x06004070 RID: 16496 RVA: 0x000176D1 File Offset: 0x000158D1
		public unsafe PInfo cached
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimePropertyInfo.NativeFieldInfoPtr_cached);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimePropertyInfo.NativeFieldInfoPtr_cached)) = value;
			}
		}

		// Token: 0x17000F4A RID: 3914
		// (get) Token: 0x06004071 RID: 16497 RVA: 0x00134B44 File Offset: 0x00132D44
		// (set) Token: 0x06004072 RID: 16498 RVA: 0x000176EC File Offset: 0x000158EC
		public unsafe RuntimePropertyInfo.GetterAdapter cached_getter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimePropertyInfo.NativeFieldInfoPtr_cached_getter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimePropertyInfo.GetterAdapter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimePropertyInfo.NativeFieldInfoPtr_cached_getter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040034E6 RID: 13542
		private static readonly IntPtr NativeFieldInfoPtr_klass;

		// Token: 0x040034E7 RID: 13543
		private static readonly IntPtr NativeFieldInfoPtr_prop;

		// Token: 0x040034E8 RID: 13544
		private static readonly IntPtr NativeFieldInfoPtr_info;

		// Token: 0x040034E9 RID: 13545
		private static readonly IntPtr NativeFieldInfoPtr_cached;

		// Token: 0x040034EA RID: 13546
		private static readonly IntPtr NativeFieldInfoPtr_cached_getter;

		// Token: 0x040034EB RID: 13547
		private static readonly IntPtr NativeMethodInfoPtr_get_property_info_Internal_Static_Void_RuntimePropertyInfo_byref_MonoPropertyInfo_PInfo_0;

		// Token: 0x040034EC RID: 13548
		private static readonly IntPtr NativeMethodInfoPtr_get_BindingFlags_Internal_get_BindingFlags_0;

		// Token: 0x040034ED RID: 13549
		private static readonly IntPtr NativeMethodInfoPtr_get_Module_Public_Virtual_get_Module_0;

		// Token: 0x040034EE RID: 13550
		private static readonly IntPtr NativeMethodInfoPtr_GetDeclaringTypeInternal_Internal_RuntimeType_0;

		// Token: 0x040034EF RID: 13551
		private static readonly IntPtr NativeMethodInfoPtr_get_ReflectedTypeInternal_Private_get_RuntimeType_0;

		// Token: 0x040034F0 RID: 13552
		private static readonly IntPtr NativeMethodInfoPtr_GetRuntimeModule_Internal_RuntimeModule_0;

		// Token: 0x040034F1 RID: 13553
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040034F2 RID: 13554
		private static readonly IntPtr NativeMethodInfoPtr_FormatNameAndSig_Private_String_Boolean_0;

		// Token: 0x040034F3 RID: 13555
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040034F4 RID: 13556
		private static readonly IntPtr NativeMethodInfoPtr_SerializationToString_Internal_String_0;

		// Token: 0x040034F5 RID: 13557
		private static readonly IntPtr NativeMethodInfoPtr_CachePropertyInfo_Private_Void_PInfo_0;

		// Token: 0x040034F6 RID: 13558
		private static readonly IntPtr NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0;

		// Token: 0x040034F7 RID: 13559
		private static readonly IntPtr NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0;

		// Token: 0x040034F8 RID: 13560
		private static readonly IntPtr NativeMethodInfoPtr_get_PropertyType_Public_Virtual_get_Type_0;

		// Token: 0x040034F9 RID: 13561
		private static readonly IntPtr NativeMethodInfoPtr_get_ReflectedType_Public_Virtual_get_Type_0;

		// Token: 0x040034FA RID: 13562
		private static readonly IntPtr NativeMethodInfoPtr_get_DeclaringType_Public_Virtual_get_Type_0;

		// Token: 0x040034FB RID: 13563
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x040034FC RID: 13564
		private static readonly IntPtr NativeMethodInfoPtr_GetGetMethod_Public_Virtual_MethodInfo_Boolean_0;

		// Token: 0x040034FD RID: 13565
		private static readonly IntPtr NativeMethodInfoPtr_GetIndexParameters_Public_Virtual_Il2CppReferenceArray_1_ParameterInfo_0;

		// Token: 0x040034FE RID: 13566
		private static readonly IntPtr NativeMethodInfoPtr_GetSetMethod_Public_Virtual_MethodInfo_Boolean_0;

		// Token: 0x040034FF RID: 13567
		private static readonly IntPtr NativeMethodInfoPtr_IsDefined_Public_Virtual_Boolean_Type_Boolean_0;

		// Token: 0x04003500 RID: 13568
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Boolean_0;

		// Token: 0x04003501 RID: 13569
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Type_Boolean_0;

		// Token: 0x04003502 RID: 13570
		private static readonly IntPtr NativeMethodInfoPtr_GetterAdapterFrame_Private_Static_Object_Getter_2_T_R_Object_0;

		// Token: 0x04003503 RID: 13571
		private static readonly IntPtr NativeMethodInfoPtr_StaticGetterAdapterFrame_Private_Static_Object_StaticGetter_1_R_Object_0;

		// Token: 0x04003504 RID: 13572
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Object_Object_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003505 RID: 13573
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Object_Object_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_0;

		// Token: 0x04003506 RID: 13574
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_Object_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_0;

		// Token: 0x04003507 RID: 13575
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributesData_Public_Virtual_IList_1_CustomAttributeData_0;

		// Token: 0x04003508 RID: 13576
		private static readonly IntPtr NativeMethodInfoPtr_get_MetadataToken_Public_Virtual_get_Int32_0;

		// Token: 0x04003509 RID: 13577
		private static readonly IntPtr NativeMethodInfoPtr_get_metadata_token_Internal_Static_Int32_RuntimePropertyInfo_0;

		// Token: 0x0400350A RID: 13578
		private static readonly IntPtr NativeMethodInfoPtr_internal_from_handle_type_Private_Static_PropertyInfo_IntPtr_IntPtr_0;

		// Token: 0x0400350B RID: 13579
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyFromHandle_Internal_Static_PropertyInfo_RuntimePropertyHandle_RuntimeTypeHandle_0;

		// Token: 0x0400350C RID: 13580
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020006C2 RID: 1730
		public sealed class GetterAdapter : MulticastDelegate
		{
			// Token: 0x06005CB3 RID: 23731 RVA: 0x00021A5C File Offset: 0x0001FC5C
			// Note: this type is marked as 'beforefieldinit'.
			static GetterAdapter()
			{
				Il2CppClassPointerStore<RuntimePropertyInfo.GetterAdapter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, "GetterAdapter");
				RuntimePropertyInfo.GetterAdapter.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePropertyInfo.GetterAdapter>.NativeClassPtr, 100673014);
				RuntimePropertyInfo.GetterAdapter.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePropertyInfo.GetterAdapter>.NativeClassPtr, 100673015);
			}

			// Token: 0x06005CB4 RID: 23732 RVA: 0x001A4548 File Offset: 0x001A2748
			[CallerCount(1058)]
			[CachedScanResults(RefRangeStart = 340122, RefRangeEnd = 341180, XrefRangeStart = 340122, XrefRangeEnd = 341180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GetterAdapter(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimePropertyInfo.GetterAdapter>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimePropertyInfo.GetterAdapter.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005CB5 RID: 23733 RVA: 0x001A45A4 File Offset: 0x001A27A4
			[CallerCount(0)]
			public unsafe Object Invoke(Object _this)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_this);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimePropertyInfo.GetterAdapter.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005CB6 RID: 23734 RVA: 0x00021A9A File Offset: 0x0001FC9A
			public GetterAdapter(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005CB7 RID: 23735 RVA: 0x00021AA3 File Offset: 0x0001FCA3
			public static implicit operator RuntimePropertyInfo.GetterAdapter(Func<Object, Object> A_0)
			{
				return DelegateSupport.ConvertDelegate<RuntimePropertyInfo.GetterAdapter>(A_0);
			}

			// Token: 0x06005CB8 RID: 23736 RVA: 0x00021AAB File Offset: 0x0001FCAB
			public static RuntimePropertyInfo.GetterAdapter operator +(RuntimePropertyInfo.GetterAdapter A_0, RuntimePropertyInfo.GetterAdapter A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<RuntimePropertyInfo.GetterAdapter>();
			}

			// Token: 0x06005CB9 RID: 23737 RVA: 0x00021AB9 File Offset: 0x0001FCB9
			public static RuntimePropertyInfo.GetterAdapter operator -(RuntimePropertyInfo.GetterAdapter A_0, RuntimePropertyInfo.GetterAdapter A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<RuntimePropertyInfo.GetterAdapter>();
				}
				return delegate2;
			}

			// Token: 0x04004B48 RID: 19272
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04004B49 RID: 19273
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Object_Object_0;
		}

		// Token: 0x020006C3 RID: 1731
		public sealed class Getter<T, R> : MulticastDelegate
		{
			// Token: 0x06005CBA RID: 23738 RVA: 0x001A45F4 File Offset: 0x001A27F4
			// Note: this type is marked as 'beforefieldinit'.
			static Getter()
			{
				Il2CppClassPointerStore<RuntimePropertyInfo.Getter<T, R>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, "Getter`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<R>.NativeClassPtr))
				})).TypeHandle.value);
				RuntimePropertyInfo.Getter<T, R>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePropertyInfo.Getter<T, R>>.NativeClassPtr, 100673016);
				RuntimePropertyInfo.Getter<T, R>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_R_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePropertyInfo.Getter<T, R>>.NativeClassPtr, 100673017);
			}

			// Token: 0x06005CBB RID: 23739 RVA: 0x001A468C File Offset: 0x001A288C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Getter(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimePropertyInfo.Getter<T, R>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimePropertyInfo.Getter<T, R>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005CBC RID: 23740 RVA: 0x001A46E8 File Offset: 0x001A28E8
			[CallerCount(0)]
			public unsafe R Invoke(T _this)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = _this;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref _this;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RuntimePropertyInfo.Getter<T, R>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_R_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return IL2CPP.PointerToValueGeneric<R>(intPtr2, false, true);
				}
			}

			// Token: 0x06005CBD RID: 23741 RVA: 0x00021ACA File Offset: 0x0001FCCA
			public Getter(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005CBE RID: 23742 RVA: 0x00021AD3 File Offset: 0x0001FCD3
			public static implicit operator RuntimePropertyInfo.Getter<T, R>(Func<T, R> A_0)
			{
				return DelegateSupport.ConvertDelegate<RuntimePropertyInfo.Getter<T, R>>(A_0);
			}

			// Token: 0x06005CBF RID: 23743 RVA: 0x00021ADB File Offset: 0x0001FCDB
			public static RuntimePropertyInfo.Getter<T, R>operator +(RuntimePropertyInfo.Getter<T, R> A_0, RuntimePropertyInfo.Getter<T, R> A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<RuntimePropertyInfo.Getter<T, R>>();
			}

			// Token: 0x06005CC0 RID: 23744 RVA: 0x00021AE9 File Offset: 0x0001FCE9
			public static RuntimePropertyInfo.Getter<T, R>operator -(RuntimePropertyInfo.Getter<T, R> A_0, RuntimePropertyInfo.Getter<T, R> A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<RuntimePropertyInfo.Getter<T, R>>();
				}
				return delegate2;
			}

			// Token: 0x04004B4A RID: 19274
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04004B4B RID: 19275
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_R_T_0;
		}

		// Token: 0x020006C4 RID: 1732
		public sealed class StaticGetter<R> : MulticastDelegate
		{
			// Token: 0x06005CC1 RID: 23745 RVA: 0x001A4768 File Offset: 0x001A2968
			// Note: this type is marked as 'beforefieldinit'.
			static StaticGetter()
			{
				Il2CppClassPointerStore<RuntimePropertyInfo.StaticGetter<R>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr, "StaticGetter`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<R>.NativeClassPtr)) })).TypeHandle.value);
				RuntimePropertyInfo.StaticGetter<R>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePropertyInfo.StaticGetter<R>>.NativeClassPtr, 100673018);
				RuntimePropertyInfo.StaticGetter<R>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_R_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePropertyInfo.StaticGetter<R>>.NativeClassPtr, 100673019);
			}

			// Token: 0x06005CC2 RID: 23746 RVA: 0x001A47EC File Offset: 0x001A29EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StaticGetter(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimePropertyInfo.StaticGetter<R>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimePropertyInfo.StaticGetter<R>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005CC3 RID: 23747 RVA: 0x001A4848 File Offset: 0x001A2A48
			[CallerCount(0)]
			public unsafe R Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimePropertyInfo.StaticGetter<R>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_R_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<R>(intPtr, false, true);
			}

			// Token: 0x06005CC4 RID: 23748 RVA: 0x00021AFA File Offset: 0x0001FCFA
			public StaticGetter(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005CC5 RID: 23749 RVA: 0x00021B03 File Offset: 0x0001FD03
			public static implicit operator RuntimePropertyInfo.StaticGetter<R>(Func<R> A_0)
			{
				return DelegateSupport.ConvertDelegate<RuntimePropertyInfo.StaticGetter<R>>(A_0);
			}

			// Token: 0x06005CC6 RID: 23750 RVA: 0x00021B0B File Offset: 0x0001FD0B
			public static RuntimePropertyInfo.StaticGetter<R>operator +(RuntimePropertyInfo.StaticGetter<R> A_0, RuntimePropertyInfo.StaticGetter<R> A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<RuntimePropertyInfo.StaticGetter<R>>();
			}

			// Token: 0x06005CC7 RID: 23751 RVA: 0x00021B19 File Offset: 0x0001FD19
			public static RuntimePropertyInfo.StaticGetter<R>operator -(RuntimePropertyInfo.StaticGetter<R> A_0, RuntimePropertyInfo.StaticGetter<R> A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<RuntimePropertyInfo.StaticGetter<R>>();
				}
				return delegate2;
			}

			// Token: 0x04004B4C RID: 19276
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04004B4D RID: 19277
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_R_0;
		}

		// Token: 0x020006C5 RID: 1733
		private sealed class MethodInfoStoreGeneric_GetterAdapterFrame_Private_Static_Object_Getter_2_T_R_Object_0<T, R>
		{
			// Token: 0x04004B4E RID: 19278
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(RuntimePropertyInfo.NativeMethodInfoPtr_GetterAdapterFrame_Private_Static_Object_Getter_2_T_R_Object_0, Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<R>.NativeClassPtr))
			}))));
		}

		// Token: 0x020006C6 RID: 1734
		private sealed class MethodInfoStoreGeneric_StaticGetterAdapterFrame_Private_Static_Object_StaticGetter_1_R_Object_0<R>
		{
			// Token: 0x04004B4F RID: 19279
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(RuntimePropertyInfo.NativeMethodInfoPtr_StaticGetterAdapterFrame_Private_Static_Object_StaticGetter_1_R_Object_0, Il2CppClassPointerStore<RuntimePropertyInfo>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<R>.NativeClassPtr)) }))));
		}
	}
}
