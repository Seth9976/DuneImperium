using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Dynamic.Utils
{
	// Token: 0x0200012C RID: 300
	public static class TypeExtensions : Object
	{
		// Token: 0x06001178 RID: 4472 RVA: 0x0005B654 File Offset: 0x00059854
		// Note: this type is marked as 'beforefieldinit'.
		static TypeExtensions()
		{
			Il2CppClassPointerStore<TypeExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Dynamic.Utils", "TypeExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeExtensions>.NativeClassPtr);
			TypeExtensions.NativeFieldInfoPtr_s_paramInfoCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeExtensions>.NativeClassPtr, "s_paramInfoCache");
			TypeExtensions.NativeMethodInfoPtr_GetAnyStaticMethodValidated_Public_Static_MethodInfo_Type_String_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeExtensions>.NativeClassPtr, 100666608);
			TypeExtensions.NativeMethodInfoPtr_MatchesArgumentTypes_Private_Static_Boolean_MethodInfo_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeExtensions>.NativeClassPtr, 100666609);
			TypeExtensions.NativeMethodInfoPtr_GetReturnType_Public_Static_Type_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeExtensions>.NativeClassPtr, 100666610);
			TypeExtensions.NativeMethodInfoPtr_GetTypeCode_Public_Static_TypeCode_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeExtensions>.NativeClassPtr, 100666611);
			TypeExtensions.NativeMethodInfoPtr_GetParametersCached_Internal_Static_Il2CppReferenceArray_1_ParameterInfo_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeExtensions>.NativeClassPtr, 100666612);
		}

		// Token: 0x06001179 RID: 4473 RVA: 0x0005B6FC File Offset: 0x000598FC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1030356, RefRangeEnd = 1030360, XrefRangeStart = 1030342, XrefRangeEnd = 1030356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodInfo GetAnyStaticMethodValidated(this Type type, string name, Il2CppReferenceArray<Type> types)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(types);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeExtensions.NativeMethodInfoPtr_GetAnyStaticMethodValidated_Public_Static_MethodInfo_Type_String_Il2CppReferenceArray_1_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x0600117A RID: 4474 RVA: 0x0005B764 File Offset: 0x00059964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1030360, XrefRangeEnd = 1030371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool MatchesArgumentTypes(this MethodInfo mi, Il2CppReferenceArray<Type> argTypes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mi);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(argTypes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeExtensions.NativeMethodInfoPtr_MatchesArgumentTypes_Private_Static_Boolean_MethodInfo_Il2CppReferenceArray_1_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600117B RID: 4475 RVA: 0x0005B7B8 File Offset: 0x000599B8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1030376, RefRangeEnd = 1030379, XrefRangeStart = 1030371, XrefRangeEnd = 1030376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetReturnType(this MethodBase mi)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mi);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeExtensions.NativeMethodInfoPtr_GetReturnType_Public_Static_Type_MethodBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x0600117C RID: 4476 RVA: 0x0005B7FC File Offset: 0x000599FC
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 1030383, RefRangeEnd = 1030414, XrefRangeStart = 1030379, XrefRangeEnd = 1030383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeCode GetTypeCode(this Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeExtensions.NativeMethodInfoPtr_GetTypeCode_Public_Static_TypeCode_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600117D RID: 4477 RVA: 0x0005B840 File Offset: 0x00059A40
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 1030424, RefRangeEnd = 1030456, XrefRangeStart = 1030414, XrefRangeEnd = 1030424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<ParameterInfo> GetParametersCached(this MethodBase method)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeExtensions.NativeMethodInfoPtr_GetParametersCached_Internal_Static_Il2CppReferenceArray_1_ParameterInfo_MethodBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParameterInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x0600117E RID: 4478 RVA: 0x0000755B File Offset: 0x0000575B
		public TypeExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x0600117F RID: 4479 RVA: 0x0005B884 File Offset: 0x00059A84
		// (set) Token: 0x06001180 RID: 4480 RVA: 0x00007564 File Offset: 0x00005764
		public unsafe static CacheDict<MethodBase, Il2CppReferenceArray<ParameterInfo>> s_paramInfoCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypeExtensions.NativeFieldInfoPtr_s_paramInfoCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CacheDict<MethodBase, Il2CppReferenceArray<ParameterInfo>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeExtensions.NativeFieldInfoPtr_s_paramInfoCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C89 RID: 3209
		private static readonly IntPtr NativeFieldInfoPtr_s_paramInfoCache;

		// Token: 0x04000C8A RID: 3210
		private static readonly IntPtr NativeMethodInfoPtr_GetAnyStaticMethodValidated_Public_Static_MethodInfo_Type_String_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04000C8B RID: 3211
		private static readonly IntPtr NativeMethodInfoPtr_MatchesArgumentTypes_Private_Static_Boolean_MethodInfo_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04000C8C RID: 3212
		private static readonly IntPtr NativeMethodInfoPtr_GetReturnType_Public_Static_Type_MethodBase_0;

		// Token: 0x04000C8D RID: 3213
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeCode_Public_Static_TypeCode_Type_0;

		// Token: 0x04000C8E RID: 3214
		private static readonly IntPtr NativeMethodInfoPtr_GetParametersCached_Internal_Static_Il2CppReferenceArray_1_ParameterInfo_MethodBase_0;
	}
}
