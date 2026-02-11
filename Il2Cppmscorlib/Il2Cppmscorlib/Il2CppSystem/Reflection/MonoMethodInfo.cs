using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.InteropServices;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000447 RID: 1095
	public sealed class MonoMethodInfo : ValueType
	{
		// Token: 0x06003F87 RID: 16263 RVA: 0x0013037C File Offset: 0x0012E57C
		// Note: this type is marked as 'beforefieldinit'.
		static MonoMethodInfo()
		{
			Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "MonoMethodInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr);
			MonoMethodInfo.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, "parent");
			MonoMethodInfo.NativeFieldInfoPtr_ret = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, "ret");
			MonoMethodInfo.NativeFieldInfoPtr_attrs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, "attrs");
			MonoMethodInfo.NativeFieldInfoPtr_iattrs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, "iattrs");
			MonoMethodInfo.NativeFieldInfoPtr_callconv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, "callconv");
			MonoMethodInfo.NativeMethodInfoPtr_get_method_info_Private_Static_Void_IntPtr_byref_MonoMethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, 100672855);
			MonoMethodInfo.NativeMethodInfoPtr_get_method_attributes_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, 100672856);
			MonoMethodInfo.NativeMethodInfoPtr_GetMethodInfo_Internal_Static_MonoMethodInfo_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, 100672857);
			MonoMethodInfo.NativeMethodInfoPtr_GetDeclaringType_Internal_Static_Type_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, 100672858);
			MonoMethodInfo.NativeMethodInfoPtr_GetReturnType_Internal_Static_Type_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, 100672859);
			MonoMethodInfo.NativeMethodInfoPtr_GetAttributes_Internal_Static_MethodAttributes_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, 100672860);
			MonoMethodInfo.NativeMethodInfoPtr_GetCallingConvention_Internal_Static_CallingConventions_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, 100672861);
			MonoMethodInfo.NativeMethodInfoPtr_GetMethodImplementationFlags_Internal_Static_MethodImplAttributes_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, 100672862);
			MonoMethodInfo.NativeMethodInfoPtr_get_parameter_info_Private_Static_Il2CppReferenceArray_1_ParameterInfo_IntPtr_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, 100672863);
			MonoMethodInfo.NativeMethodInfoPtr_GetParametersInfo_Internal_Static_Il2CppReferenceArray_1_ParameterInfo_IntPtr_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, 100672864);
			MonoMethodInfo.NativeMethodInfoPtr_get_retval_marshal_Private_Static_MarshalAsAttribute_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, 100672865);
			MonoMethodInfo.NativeMethodInfoPtr_GetReturnParameterInfo_Internal_Static_ParameterInfo_RuntimeMethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr, 100672866);
		}

		// Token: 0x06003F88 RID: 16264 RVA: 0x00130500 File Offset: 0x0012E700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401421, XrefRangeEnd = 1401422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_method_info(IntPtr handle, out MonoMethodInfo info)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MonoMethodInfo.NativeMethodInfoPtr_get_method_info_Private_Static_Void_IntPtr_byref_MonoMethodInfo_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			info = ((intPtr4 == 0) ? null : new MonoMethodInfo(intPtr4));
		}

		// Token: 0x06003F89 RID: 16265 RVA: 0x00130554 File Offset: 0x0012E754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401422, XrefRangeEnd = 1401423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int get_method_attributes(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodInfo.NativeMethodInfoPtr_get_method_attributes_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003F8A RID: 16266 RVA: 0x00130594 File Offset: 0x0012E794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401423, XrefRangeEnd = 1401424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MonoMethodInfo GetMethodInfo(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodInfo.NativeMethodInfoPtr_GetMethodInfo_Internal_Static_MonoMethodInfo_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new MonoMethodInfo(intPtr);
			}
		}

		// Token: 0x06003F8B RID: 16267 RVA: 0x001305CC File Offset: 0x0012E7CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401424, XrefRangeEnd = 1401425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetDeclaringType(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodInfo.NativeMethodInfoPtr_GetDeclaringType_Internal_Static_Type_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06003F8C RID: 16268 RVA: 0x0013060C File Offset: 0x0012E80C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401425, XrefRangeEnd = 1401426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetReturnType(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodInfo.NativeMethodInfoPtr_GetReturnType_Internal_Static_Type_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06003F8D RID: 16269 RVA: 0x0013064C File Offset: 0x0012E84C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodAttributes GetAttributes(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodInfo.NativeMethodInfoPtr_GetAttributes_Internal_Static_MethodAttributes_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003F8E RID: 16270 RVA: 0x0013068C File Offset: 0x0012E88C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401426, XrefRangeEnd = 1401427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CallingConventions GetCallingConvention(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodInfo.NativeMethodInfoPtr_GetCallingConvention_Internal_Static_CallingConventions_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003F8F RID: 16271 RVA: 0x001306CC File Offset: 0x0012E8CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401427, XrefRangeEnd = 1401428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodImplAttributes GetMethodImplementationFlags(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodInfo.NativeMethodInfoPtr_GetMethodImplementationFlags_Internal_Static_MethodImplAttributes_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003F90 RID: 16272 RVA: 0x0013070C File Offset: 0x0012E90C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401428, XrefRangeEnd = 1401429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<ParameterInfo> get_parameter_info(IntPtr handle, MemberInfo member)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodInfo.NativeMethodInfoPtr_get_parameter_info_Private_Static_Il2CppReferenceArray_1_ParameterInfo_IntPtr_MemberInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParameterInfo>>(intPtr3) : null;
		}

		// Token: 0x06003F91 RID: 16273 RVA: 0x00130760 File Offset: 0x0012E960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<ParameterInfo> GetParametersInfo(IntPtr handle, MemberInfo member)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodInfo.NativeMethodInfoPtr_GetParametersInfo_Internal_Static_Il2CppReferenceArray_1_ParameterInfo_IntPtr_MemberInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParameterInfo>>(intPtr3) : null;
		}

		// Token: 0x06003F92 RID: 16274 RVA: 0x001307B4 File Offset: 0x0012E9B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MarshalAsAttribute get_retval_marshal(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodInfo.NativeMethodInfoPtr_get_retval_marshal_Private_Static_MarshalAsAttribute_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MarshalAsAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x06003F93 RID: 16275 RVA: 0x001307F4 File Offset: 0x0012E9F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401429, XrefRangeEnd = 1401439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ParameterInfo GetReturnParameterInfo(RuntimeMethodInfo method)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodInfo.NativeMethodInfoPtr_GetReturnParameterInfo_Internal_Static_ParameterInfo_RuntimeMethodInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParameterInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06003F94 RID: 16276 RVA: 0x00017319 File Offset: 0x00015519
		public MonoMethodInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06003F95 RID: 16277 RVA: 0x00017322 File Offset: 0x00015522
		public MonoMethodInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoMethodInfo>.NativeClassPtr))
		{
		}

		// Token: 0x17000F0C RID: 3852
		// (get) Token: 0x06003F96 RID: 16278 RVA: 0x00130838 File Offset: 0x0012EA38
		// (set) Token: 0x06003F97 RID: 16279 RVA: 0x00017334 File Offset: 0x00015534
		public unsafe Type parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodInfo.NativeFieldInfoPtr_parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodInfo.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F0D RID: 3853
		// (get) Token: 0x06003F98 RID: 16280 RVA: 0x00130868 File Offset: 0x0012EA68
		// (set) Token: 0x06003F99 RID: 16281 RVA: 0x00017353 File Offset: 0x00015553
		public unsafe Type ret
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodInfo.NativeFieldInfoPtr_ret);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodInfo.NativeFieldInfoPtr_ret), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F0E RID: 3854
		// (get) Token: 0x06003F9A RID: 16282 RVA: 0x00130898 File Offset: 0x0012EA98
		// (set) Token: 0x06003F9B RID: 16283 RVA: 0x00017372 File Offset: 0x00015572
		public unsafe MethodAttributes attrs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodInfo.NativeFieldInfoPtr_attrs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodInfo.NativeFieldInfoPtr_attrs)) = value;
			}
		}

		// Token: 0x17000F0F RID: 3855
		// (get) Token: 0x06003F9C RID: 16284 RVA: 0x001308C0 File Offset: 0x0012EAC0
		// (set) Token: 0x06003F9D RID: 16285 RVA: 0x0001738D File Offset: 0x0001558D
		public unsafe MethodImplAttributes iattrs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodInfo.NativeFieldInfoPtr_iattrs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodInfo.NativeFieldInfoPtr_iattrs)) = value;
			}
		}

		// Token: 0x17000F10 RID: 3856
		// (get) Token: 0x06003F9E RID: 16286 RVA: 0x001308E8 File Offset: 0x0012EAE8
		// (set) Token: 0x06003F9F RID: 16287 RVA: 0x000173A8 File Offset: 0x000155A8
		public unsafe CallingConventions callconv
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodInfo.NativeFieldInfoPtr_callconv);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodInfo.NativeFieldInfoPtr_callconv)) = value;
			}
		}

		// Token: 0x04003449 RID: 13385
		private static readonly IntPtr NativeFieldInfoPtr_parent;

		// Token: 0x0400344A RID: 13386
		private static readonly IntPtr NativeFieldInfoPtr_ret;

		// Token: 0x0400344B RID: 13387
		private static readonly IntPtr NativeFieldInfoPtr_attrs;

		// Token: 0x0400344C RID: 13388
		private static readonly IntPtr NativeFieldInfoPtr_iattrs;

		// Token: 0x0400344D RID: 13389
		private static readonly IntPtr NativeFieldInfoPtr_callconv;

		// Token: 0x0400344E RID: 13390
		private static readonly IntPtr NativeMethodInfoPtr_get_method_info_Private_Static_Void_IntPtr_byref_MonoMethodInfo_0;

		// Token: 0x0400344F RID: 13391
		private static readonly IntPtr NativeMethodInfoPtr_get_method_attributes_Private_Static_Int32_IntPtr_0;

		// Token: 0x04003450 RID: 13392
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodInfo_Internal_Static_MonoMethodInfo_IntPtr_0;

		// Token: 0x04003451 RID: 13393
		private static readonly IntPtr NativeMethodInfoPtr_GetDeclaringType_Internal_Static_Type_IntPtr_0;

		// Token: 0x04003452 RID: 13394
		private static readonly IntPtr NativeMethodInfoPtr_GetReturnType_Internal_Static_Type_IntPtr_0;

		// Token: 0x04003453 RID: 13395
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributes_Internal_Static_MethodAttributes_IntPtr_0;

		// Token: 0x04003454 RID: 13396
		private static readonly IntPtr NativeMethodInfoPtr_GetCallingConvention_Internal_Static_CallingConventions_IntPtr_0;

		// Token: 0x04003455 RID: 13397
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodImplementationFlags_Internal_Static_MethodImplAttributes_IntPtr_0;

		// Token: 0x04003456 RID: 13398
		private static readonly IntPtr NativeMethodInfoPtr_get_parameter_info_Private_Static_Il2CppReferenceArray_1_ParameterInfo_IntPtr_MemberInfo_0;

		// Token: 0x04003457 RID: 13399
		private static readonly IntPtr NativeMethodInfoPtr_GetParametersInfo_Internal_Static_Il2CppReferenceArray_1_ParameterInfo_IntPtr_MemberInfo_0;

		// Token: 0x04003458 RID: 13400
		private static readonly IntPtr NativeMethodInfoPtr_get_retval_marshal_Private_Static_MarshalAsAttribute_IntPtr_0;

		// Token: 0x04003459 RID: 13401
		private static readonly IntPtr NativeMethodInfoPtr_GetReturnParameterInfo_Internal_Static_ParameterInfo_RuntimeMethodInfo_0;
	}
}
