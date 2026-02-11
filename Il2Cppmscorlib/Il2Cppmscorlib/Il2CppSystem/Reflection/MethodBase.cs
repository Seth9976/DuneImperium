using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000418 RID: 1048
	[Serializable]
	public class MethodBase : MemberInfo
	{
		// Token: 0x06003C3A RID: 15418 RVA: 0x00120C20 File Offset: 0x0011EE20
		// Note: this type is marked as 'beforefieldinit'.
		static MethodBase()
		{
			Il2CppClassPointerStore<MethodBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "MethodBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MethodBase>.NativeClassPtr);
			MethodBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100672281);
			MethodBase.NativeMethodInfoPtr_GetParameters_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_ParameterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100672282);
			MethodBase.NativeMethodInfoPtr_get_Attributes_Public_Abstract_Virtual_New_get_MethodAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100672283);
			MethodBase.NativeMethodInfoPtr_GetMethodImplementationFlags_Public_Abstract_Virtual_New_MethodImplAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100672284);
			MethodBase.NativeMethodInfoPtr_get_CallingConvention_Public_Virtual_New_get_CallingConventions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100672285);
			MethodBase.NativeMethodInfoPtr_get_IsAbstract_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100672286);
			MethodBase.NativeMethodInfoPtr_get_IsConstructor_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100672287);
			MethodBase.NativeMethodInfoPtr_get_IsSpecialName_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100672288);
			MethodBase.NativeMethodInfoPtr_get_IsStatic_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100672289);
			MethodBase.NativeMethodInfoPtr_get_IsVirtual_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100672290);
			MethodBase.NativeMethodInfoPtr_get_IsPublic_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100672291);
			MethodBase.NativeMethodInfoPtr_get_IsGenericMethod_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100672292);
			MethodBase.NativeMethodInfoPtr_get_IsGenericMethodDefinition_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100672293);
			MethodBase.NativeMethodInfoPtr_GetGenericArguments_Public_Virtual_New_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100672294);
			MethodBase.NativeMethodInfoPtr_get_ContainsGenericParameters_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100672295);
			MethodBase.NativeMethodInfoPtr_Invoke_Public_Virtual_Final_New_Object_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100672296);
			MethodBase.NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_Object_Object_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100672297);
			MethodBase.NativeMethodInfoPtr_get_MethodHandle_Public_Abstract_Virtual_New_get_RuntimeMethodHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100672298);
			MethodBase.NativeMethodInfoPtr_get_IsSecurityCritical_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100672299);
			MethodBase.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100672300);
			MethodBase.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100672301);
			MethodBase.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_MethodBase_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100672302);
			MethodBase.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_MethodBase_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100672303);
			MethodBase.NativeMethodInfoPtr_GetParametersInternal_Internal_Virtual_New_Il2CppReferenceArray_1_ParameterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100672304);
			MethodBase.NativeMethodInfoPtr_GetParametersCount_Internal_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100672305);
			MethodBase.NativeMethodInfoPtr_FormatNameAndSig_Internal_Virtual_New_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100672306);
			MethodBase.NativeMethodInfoPtr_GetParameterTypes_Internal_Virtual_New_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100672307);
			MethodBase.NativeMethodInfoPtr_GetParametersNoCopy_Internal_Virtual_New_Il2CppReferenceArray_1_ParameterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100672308);
			MethodBase.NativeMethodInfoPtr_GetMethodFromHandle_Public_Static_MethodBase_RuntimeMethodHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100672309);
			MethodBase.NativeMethodInfoPtr_ConstructParameters_Internal_Static_String_Il2CppReferenceArray_1_Type_CallingConventions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBase>.NativeClassPtr, 100672310);
		}

		// Token: 0x06003C3B RID: 15419 RVA: 0x00120EA8 File Offset: 0x0011F0A8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethodBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C3C RID: 15420 RVA: 0x00120EE4 File Offset: 0x0011F0E4
		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<ParameterInfo> GetParameters()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodBase.NativeMethodInfoPtr_GetParameters_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_ParameterInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParameterInfo>>(intPtr3) : null;
		}

		// Token: 0x17000E06 RID: 3590
		// (get) Token: 0x06003C3D RID: 15421 RVA: 0x00120F30 File Offset: 0x0011F130
		public unsafe virtual MethodAttributes Attributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodBase.NativeMethodInfoPtr_get_Attributes_Public_Abstract_Virtual_New_get_MethodAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003C3E RID: 15422 RVA: 0x00120F78 File Offset: 0x0011F178
		[CallerCount(0)]
		public unsafe virtual MethodImplAttributes GetMethodImplementationFlags()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodBase.NativeMethodInfoPtr_GetMethodImplementationFlags_Public_Abstract_Virtual_New_MethodImplAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000E07 RID: 3591
		// (get) Token: 0x06003C3F RID: 15423 RVA: 0x00120FC0 File Offset: 0x0011F1C0
		public unsafe virtual CallingConventions CallingConvention
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodBase.NativeMethodInfoPtr_get_CallingConvention_Public_Virtual_New_get_CallingConventions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E08 RID: 3592
		// (get) Token: 0x06003C40 RID: 15424 RVA: 0x00121008 File Offset: 0x0011F208
		public unsafe virtual bool IsAbstract
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1398607, RefRangeEnd = 1398608, XrefRangeStart = 1398607, XrefRangeEnd = 1398607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodBase.NativeMethodInfoPtr_get_IsAbstract_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E09 RID: 3593
		// (get) Token: 0x06003C41 RID: 15425 RVA: 0x00121044 File Offset: 0x0011F244
		public unsafe virtual bool IsConstructor
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1398610, RefRangeEnd = 1398613, XrefRangeStart = 1398608, XrefRangeEnd = 1398610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodBase.NativeMethodInfoPtr_get_IsConstructor_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E0A RID: 3594
		// (get) Token: 0x06003C42 RID: 15426 RVA: 0x00121080 File Offset: 0x0011F280
		public unsafe virtual bool IsSpecialName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1398613, RefRangeEnd = 1398614, XrefRangeStart = 1398613, XrefRangeEnd = 1398613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodBase.NativeMethodInfoPtr_get_IsSpecialName_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E0B RID: 3595
		// (get) Token: 0x06003C43 RID: 15427 RVA: 0x001210BC File Offset: 0x0011F2BC
		public unsafe virtual bool IsStatic
		{
			[CallerCount(32)]
			[CachedScanResults(RefRangeStart = 1398614, RefRangeEnd = 1398646, XrefRangeStart = 1398614, XrefRangeEnd = 1398614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodBase.NativeMethodInfoPtr_get_IsStatic_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E0C RID: 3596
		// (get) Token: 0x06003C44 RID: 15428 RVA: 0x001210F8 File Offset: 0x0011F2F8
		public unsafe virtual bool IsVirtual
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 1398646, RefRangeEnd = 1398655, XrefRangeStart = 1398646, XrefRangeEnd = 1398646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodBase.NativeMethodInfoPtr_get_IsVirtual_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E0D RID: 3597
		// (get) Token: 0x06003C45 RID: 15429 RVA: 0x00121134 File Offset: 0x0011F334
		public unsafe virtual bool IsPublic
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 1398655, RefRangeEnd = 1398673, XrefRangeStart = 1398655, XrefRangeEnd = 1398655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodBase.NativeMethodInfoPtr_get_IsPublic_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E0E RID: 3598
		// (get) Token: 0x06003C46 RID: 15430 RVA: 0x00121170 File Offset: 0x0011F370
		public unsafe virtual bool IsGenericMethod
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodBase.NativeMethodInfoPtr_get_IsGenericMethod_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E0F RID: 3599
		// (get) Token: 0x06003C47 RID: 15431 RVA: 0x001211B8 File Offset: 0x0011F3B8
		public unsafe virtual bool IsGenericMethodDefinition
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodBase.NativeMethodInfoPtr_get_IsGenericMethodDefinition_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003C48 RID: 15432 RVA: 0x00121200 File Offset: 0x0011F400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1398673, XrefRangeEnd = 1398679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppReferenceArray<Type> GetGenericArguments()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodBase.NativeMethodInfoPtr_GetGenericArguments_Public_Virtual_New_Il2CppReferenceArray_1_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
		}

		// Token: 0x17000E10 RID: 3600
		// (get) Token: 0x06003C49 RID: 15433 RVA: 0x0012124C File Offset: 0x0011F44C
		public unsafe virtual bool ContainsGenericParameters
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodBase.NativeMethodInfoPtr_get_ContainsGenericParameters_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003C4A RID: 15434 RVA: 0x00121294 File Offset: 0x0011F494
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 1398679, RefRangeEnd = 1398740, XrefRangeStart = 1398679, XrefRangeEnd = 1398679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Invoke(Object obj, Il2CppReferenceArray<Object> parameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodBase.NativeMethodInfoPtr_Invoke_Public_Virtual_Final_New_Object_Object_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003C4B RID: 15435 RVA: 0x001212F8 File Offset: 0x0011F4F8
		[CallerCount(0)]
		public unsafe virtual Object Invoke(Object obj, BindingFlags invokeAttr, Binder binder, Il2CppReferenceArray<Object> parameters, CultureInfo culture)
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
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodBase.NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_Object_Object_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x17000E11 RID: 3601
		// (get) Token: 0x06003C4C RID: 15436 RVA: 0x0012139C File Offset: 0x0011F59C
		public unsafe virtual RuntimeMethodHandle MethodHandle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodBase.NativeMethodInfoPtr_get_MethodHandle_Public_Abstract_Virtual_New_get_RuntimeMethodHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E12 RID: 3602
		// (get) Token: 0x06003C4D RID: 15437 RVA: 0x001213E4 File Offset: 0x0011F5E4
		public unsafe virtual bool IsSecurityCritical
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1398740, XrefRangeEnd = 1398743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodBase.NativeMethodInfoPtr_get_IsSecurityCritical_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003C4E RID: 15438 RVA: 0x0012142C File Offset: 0x0011F62C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodBase.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003C4F RID: 15439 RVA: 0x00121484 File Offset: 0x0011F684
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 389658, RefRangeEnd = 389671, XrefRangeStart = 389658, XrefRangeEnd = 389671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodBase.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003C50 RID: 15440 RVA: 0x001214CC File Offset: 0x0011F6CC
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 1398762, RefRangeEnd = 1398781, XrefRangeStart = 1398743, XrefRangeEnd = 1398762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(MethodBase left, MethodBase right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodBase.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_MethodBase_MethodBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003C51 RID: 15441 RVA: 0x00121520 File Offset: 0x0011F720
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1398782, RefRangeEnd = 1398796, XrefRangeStart = 1398781, XrefRangeEnd = 1398782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(MethodBase left, MethodBase right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodBase.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_MethodBase_MethodBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003C52 RID: 15442 RVA: 0x00121574 File Offset: 0x0011F774
		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<ParameterInfo> GetParametersInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodBase.NativeMethodInfoPtr_GetParametersInternal_Internal_Virtual_New_Il2CppReferenceArray_1_ParameterInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParameterInfo>>(intPtr3) : null;
		}

		// Token: 0x06003C53 RID: 15443 RVA: 0x001215C0 File Offset: 0x0011F7C0
		[CallerCount(0)]
		public unsafe virtual int GetParametersCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodBase.NativeMethodInfoPtr_GetParametersCount_Internal_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003C54 RID: 15444 RVA: 0x00121608 File Offset: 0x0011F808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1398796, XrefRangeEnd = 1398809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string FormatNameAndSig(bool serialization)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref serialization;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodBase.NativeMethodInfoPtr_FormatNameAndSig_Internal_Virtual_New_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003C55 RID: 15445 RVA: 0x00121658 File Offset: 0x0011F858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1398809, XrefRangeEnd = 1398815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppReferenceArray<Type> GetParameterTypes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodBase.NativeMethodInfoPtr_GetParameterTypes_Internal_Virtual_New_Il2CppReferenceArray_1_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
		}

		// Token: 0x06003C56 RID: 15446 RVA: 0x001216A4 File Offset: 0x0011F8A4
		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<ParameterInfo> GetParametersNoCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodBase.NativeMethodInfoPtr_GetParametersNoCopy_Internal_Virtual_New_Il2CppReferenceArray_1_ParameterInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParameterInfo>>(intPtr3) : null;
		}

		// Token: 0x06003C57 RID: 15447 RVA: 0x001216F0 File Offset: 0x0011F8F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1398823, RefRangeEnd = 1398825, XrefRangeStart = 1398815, XrefRangeEnd = 1398823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodBase GetMethodFromHandle(RuntimeMethodHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodBase.NativeMethodInfoPtr_GetMethodFromHandle_Public_Static_MethodBase_RuntimeMethodHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
			}
		}

		// Token: 0x06003C58 RID: 15448 RVA: 0x00121730 File Offset: 0x0011F930
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1398851, RefRangeEnd = 1398852, XrefRangeStart = 1398825, XrefRangeEnd = 1398851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ConstructParameters(Il2CppReferenceArray<Type> parameterTypes, CallingConventions callingConvention, bool serialization)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parameterTypes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callingConvention;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref serialization;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodBase.NativeMethodInfoPtr_ConstructParameters_Internal_Static_String_Il2CppReferenceArray_1_Type_CallingConventions_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003C59 RID: 15449 RVA: 0x000165DA File Offset: 0x000147DA
		public MethodBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040030FF RID: 12543
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04003100 RID: 12544
		private static readonly IntPtr NativeMethodInfoPtr_GetParameters_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_ParameterInfo_0;

		// Token: 0x04003101 RID: 12545
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_Abstract_Virtual_New_get_MethodAttributes_0;

		// Token: 0x04003102 RID: 12546
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodImplementationFlags_Public_Abstract_Virtual_New_MethodImplAttributes_0;

		// Token: 0x04003103 RID: 12547
		private static readonly IntPtr NativeMethodInfoPtr_get_CallingConvention_Public_Virtual_New_get_CallingConventions_0;

		// Token: 0x04003104 RID: 12548
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAbstract_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003105 RID: 12549
		private static readonly IntPtr NativeMethodInfoPtr_get_IsConstructor_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003106 RID: 12550
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSpecialName_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003107 RID: 12551
		private static readonly IntPtr NativeMethodInfoPtr_get_IsStatic_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003108 RID: 12552
		private static readonly IntPtr NativeMethodInfoPtr_get_IsVirtual_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003109 RID: 12553
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPublic_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400310A RID: 12554
		private static readonly IntPtr NativeMethodInfoPtr_get_IsGenericMethod_Public_Virtual_New_get_Boolean_0;

		// Token: 0x0400310B RID: 12555
		private static readonly IntPtr NativeMethodInfoPtr_get_IsGenericMethodDefinition_Public_Virtual_New_get_Boolean_0;

		// Token: 0x0400310C RID: 12556
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericArguments_Public_Virtual_New_Il2CppReferenceArray_1_Type_0;

		// Token: 0x0400310D RID: 12557
		private static readonly IntPtr NativeMethodInfoPtr_get_ContainsGenericParameters_Public_Virtual_New_get_Boolean_0;

		// Token: 0x0400310E RID: 12558
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_Final_New_Object_Object_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400310F RID: 12559
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_Object_Object_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_0;

		// Token: 0x04003110 RID: 12560
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodHandle_Public_Abstract_Virtual_New_get_RuntimeMethodHandle_0;

		// Token: 0x04003111 RID: 12561
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSecurityCritical_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04003112 RID: 12562
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04003113 RID: 12563
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04003114 RID: 12564
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_MethodBase_MethodBase_0;

		// Token: 0x04003115 RID: 12565
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_MethodBase_MethodBase_0;

		// Token: 0x04003116 RID: 12566
		private static readonly IntPtr NativeMethodInfoPtr_GetParametersInternal_Internal_Virtual_New_Il2CppReferenceArray_1_ParameterInfo_0;

		// Token: 0x04003117 RID: 12567
		private static readonly IntPtr NativeMethodInfoPtr_GetParametersCount_Internal_Virtual_New_Int32_0;

		// Token: 0x04003118 RID: 12568
		private static readonly IntPtr NativeMethodInfoPtr_FormatNameAndSig_Internal_Virtual_New_String_Boolean_0;

		// Token: 0x04003119 RID: 12569
		private static readonly IntPtr NativeMethodInfoPtr_GetParameterTypes_Internal_Virtual_New_Il2CppReferenceArray_1_Type_0;

		// Token: 0x0400311A RID: 12570
		private static readonly IntPtr NativeMethodInfoPtr_GetParametersNoCopy_Internal_Virtual_New_Il2CppReferenceArray_1_ParameterInfo_0;

		// Token: 0x0400311B RID: 12571
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodFromHandle_Public_Static_MethodBase_RuntimeMethodHandle_0;

		// Token: 0x0400311C RID: 12572
		private static readonly IntPtr NativeMethodInfoPtr_ConstructParameters_Internal_Static_String_Il2CppReferenceArray_1_Type_CallingConventions_Boolean_0;
	}
}
