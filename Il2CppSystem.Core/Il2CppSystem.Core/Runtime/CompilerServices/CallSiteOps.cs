using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x0200010D RID: 269
	public static class CallSiteOps : Object
	{
		// Token: 0x06001013 RID: 4115 RVA: 0x00054928 File Offset: 0x00052B28
		// Note: this type is marked as 'beforefieldinit'.
		static CallSiteOps()
		{
			Il2CppClassPointerStore<CallSiteOps>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Runtime.CompilerServices", "CallSiteOps");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallSiteOps>.NativeClassPtr);
			CallSiteOps.NativeMethodInfoPtr_CreateMatchmaker_Public_Static_CallSite_1_T_CallSite_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteOps>.NativeClassPtr, 100666290);
			CallSiteOps.NativeMethodInfoPtr_SetNotMatched_Public_Static_Boolean_CallSite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteOps>.NativeClassPtr, 100666291);
			CallSiteOps.NativeMethodInfoPtr_GetMatch_Public_Static_Boolean_CallSite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteOps>.NativeClassPtr, 100666292);
			CallSiteOps.NativeMethodInfoPtr_ClearMatch_Public_Static_Void_CallSite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteOps>.NativeClassPtr, 100666293);
			CallSiteOps.NativeMethodInfoPtr_AddRule_Public_Static_Void_CallSite_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteOps>.NativeClassPtr, 100666294);
			CallSiteOps.NativeMethodInfoPtr_UpdateRules_Public_Static_Void_CallSite_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteOps>.NativeClassPtr, 100666295);
			CallSiteOps.NativeMethodInfoPtr_GetRules_Public_Static_Il2CppArrayBase_1_T_CallSite_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteOps>.NativeClassPtr, 100666296);
			CallSiteOps.NativeMethodInfoPtr_GetRuleCache_Public_Static_RuleCache_1_T_CallSite_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteOps>.NativeClassPtr, 100666297);
			CallSiteOps.NativeMethodInfoPtr_MoveRule_Public_Static_Void_RuleCache_1_T_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteOps>.NativeClassPtr, 100666298);
			CallSiteOps.NativeMethodInfoPtr_GetCachedRules_Public_Static_Il2CppArrayBase_1_T_RuleCache_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteOps>.NativeClassPtr, 100666299);
			CallSiteOps.NativeMethodInfoPtr_Bind_Public_Static_T_CallSiteBinder_CallSite_1_T_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteOps>.NativeClassPtr, 100666300);
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x00054A34 File Offset: 0x00052C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1027705, XrefRangeEnd = 1027707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CallSite<T> CreateMatchmaker<T>(CallSite<T> site) where T : class
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(site);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteOps.MethodInfoStoreGeneric_CreateMatchmaker_Public_Static_CallSite_1_T_CallSite_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CallSite<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06001015 RID: 4117 RVA: 0x00054A78 File Offset: 0x00052C78
		[CallerCount(0)]
		public unsafe static bool SetNotMatched(CallSite site)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(site);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteOps.NativeMethodInfoPtr_SetNotMatched_Public_Static_Boolean_CallSite_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001016 RID: 4118 RVA: 0x00054ABC File Offset: 0x00052CBC
		[CallerCount(0)]
		public unsafe static bool GetMatch(CallSite site)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(site);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteOps.NativeMethodInfoPtr_GetMatch_Public_Static_Boolean_CallSite_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x00054B00 File Offset: 0x00052D00
		[CallerCount(0)]
		public unsafe static void ClearMatch(CallSite site)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(site);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteOps.NativeMethodInfoPtr_ClearMatch_Public_Static_Void_CallSite_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x00054B38 File Offset: 0x00052D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1027707, XrefRangeEnd = 1027710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddRule<T>(CallSite<T> site, T rule) where T : class
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(site);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = rule;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref rule;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CallSiteOps.MethodInfoStoreGeneric_AddRule_Public_Static_Void_CallSite_1_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x00054BB8 File Offset: 0x00052DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1027710, XrefRangeEnd = 1027712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateRules<T>(CallSite<T> @this, int matched) where T : class
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@this);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matched;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteOps.MethodInfoStoreGeneric_UpdateRules_Public_Static_Void_CallSite_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x00054BFC File Offset: 0x00052DFC
		[CallerCount(0)]
		public unsafe static Il2CppArrayBase<T> GetRules<T>(CallSite<T> site) where T : class
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(site);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteOps.MethodInfoStoreGeneric_GetRules_Public_Static_Il2CppArrayBase_1_T_CallSite_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x00054C38 File Offset: 0x00052E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1027712, XrefRangeEnd = 1027715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RuleCache<T> GetRuleCache<T>(CallSite<T> site) where T : class
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(site);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteOps.MethodInfoStoreGeneric_GetRuleCache_Public_Static_RuleCache_1_T_CallSite_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuleCache<T>>(intPtr3) : null;
			}
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x00054C7C File Offset: 0x00052E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1027715, XrefRangeEnd = 1027717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MoveRule<T>(RuleCache<T> cache, T rule, int i) where T : class
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cache);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = rule;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref rule;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CallSiteOps.MethodInfoStoreGeneric_MoveRule_Public_Static_Void_RuleCache_1_T_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x0600101D RID: 4125 RVA: 0x00054D08 File Offset: 0x00052F08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1027717, XrefRangeEnd = 1027718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> GetCachedRules<T>(RuleCache<T> cache) where T : class
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cache);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteOps.MethodInfoStoreGeneric_GetCachedRules_Public_Static_Il2CppArrayBase_1_T_RuleCache_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x00054D44 File Offset: 0x00052F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1027718, XrefRangeEnd = 1027721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Bind<T>(CallSiteBinder binder, CallSite<T> site, Il2CppReferenceArray<Object> args) where T : class
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(binder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(site);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteOps.MethodInfoStoreGeneric_Bind_Public_Static_T_CallSiteBinder_CallSite_1_T_Il2CppReferenceArray_1_Object_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600101F RID: 4127 RVA: 0x00007017 File Offset: 0x00005217
		public CallSiteOps(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B89 RID: 2953
		private static readonly IntPtr NativeMethodInfoPtr_CreateMatchmaker_Public_Static_CallSite_1_T_CallSite_1_T_0;

		// Token: 0x04000B8A RID: 2954
		private static readonly IntPtr NativeMethodInfoPtr_SetNotMatched_Public_Static_Boolean_CallSite_0;

		// Token: 0x04000B8B RID: 2955
		private static readonly IntPtr NativeMethodInfoPtr_GetMatch_Public_Static_Boolean_CallSite_0;

		// Token: 0x04000B8C RID: 2956
		private static readonly IntPtr NativeMethodInfoPtr_ClearMatch_Public_Static_Void_CallSite_0;

		// Token: 0x04000B8D RID: 2957
		private static readonly IntPtr NativeMethodInfoPtr_AddRule_Public_Static_Void_CallSite_1_T_T_0;

		// Token: 0x04000B8E RID: 2958
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRules_Public_Static_Void_CallSite_1_T_Int32_0;

		// Token: 0x04000B8F RID: 2959
		private static readonly IntPtr NativeMethodInfoPtr_GetRules_Public_Static_Il2CppArrayBase_1_T_CallSite_1_T_0;

		// Token: 0x04000B90 RID: 2960
		private static readonly IntPtr NativeMethodInfoPtr_GetRuleCache_Public_Static_RuleCache_1_T_CallSite_1_T_0;

		// Token: 0x04000B91 RID: 2961
		private static readonly IntPtr NativeMethodInfoPtr_MoveRule_Public_Static_Void_RuleCache_1_T_T_Int32_0;

		// Token: 0x04000B92 RID: 2962
		private static readonly IntPtr NativeMethodInfoPtr_GetCachedRules_Public_Static_Il2CppArrayBase_1_T_RuleCache_1_T_0;

		// Token: 0x04000B93 RID: 2963
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Static_T_CallSiteBinder_CallSite_1_T_Il2CppReferenceArray_1_Object_0;

		// Token: 0x02000334 RID: 820
		private sealed class MethodInfoStoreGeneric_CreateMatchmaker_Public_Static_CallSite_1_T_CallSite_1_T_0<T>
		{
			// Token: 0x04001281 RID: 4737
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CallSiteOps.NativeMethodInfoPtr_CreateMatchmaker_Public_Static_CallSite_1_T_CallSite_1_T_0, Il2CppClassPointerStore<CallSiteOps>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000335 RID: 821
		private sealed class MethodInfoStoreGeneric_AddRule_Public_Static_Void_CallSite_1_T_T_0<T>
		{
			// Token: 0x04001282 RID: 4738
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CallSiteOps.NativeMethodInfoPtr_AddRule_Public_Static_Void_CallSite_1_T_T_0, Il2CppClassPointerStore<CallSiteOps>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000336 RID: 822
		private sealed class MethodInfoStoreGeneric_UpdateRules_Public_Static_Void_CallSite_1_T_Int32_0<T>
		{
			// Token: 0x04001283 RID: 4739
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CallSiteOps.NativeMethodInfoPtr_UpdateRules_Public_Static_Void_CallSite_1_T_Int32_0, Il2CppClassPointerStore<CallSiteOps>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000337 RID: 823
		private sealed class MethodInfoStoreGeneric_GetRules_Public_Static_Il2CppArrayBase_1_T_CallSite_1_T_0<T>
		{
			// Token: 0x04001284 RID: 4740
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CallSiteOps.NativeMethodInfoPtr_GetRules_Public_Static_Il2CppArrayBase_1_T_CallSite_1_T_0, Il2CppClassPointerStore<CallSiteOps>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000338 RID: 824
		private sealed class MethodInfoStoreGeneric_GetRuleCache_Public_Static_RuleCache_1_T_CallSite_1_T_0<T>
		{
			// Token: 0x04001285 RID: 4741
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CallSiteOps.NativeMethodInfoPtr_GetRuleCache_Public_Static_RuleCache_1_T_CallSite_1_T_0, Il2CppClassPointerStore<CallSiteOps>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000339 RID: 825
		private sealed class MethodInfoStoreGeneric_MoveRule_Public_Static_Void_RuleCache_1_T_T_Int32_0<T>
		{
			// Token: 0x04001286 RID: 4742
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CallSiteOps.NativeMethodInfoPtr_MoveRule_Public_Static_Void_RuleCache_1_T_T_Int32_0, Il2CppClassPointerStore<CallSiteOps>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200033A RID: 826
		private sealed class MethodInfoStoreGeneric_GetCachedRules_Public_Static_Il2CppArrayBase_1_T_RuleCache_1_T_0<T>
		{
			// Token: 0x04001287 RID: 4743
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CallSiteOps.NativeMethodInfoPtr_GetCachedRules_Public_Static_Il2CppArrayBase_1_T_RuleCache_1_T_0, Il2CppClassPointerStore<CallSiteOps>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200033B RID: 827
		private sealed class MethodInfoStoreGeneric_Bind_Public_Static_T_CallSiteBinder_CallSite_1_T_Il2CppReferenceArray_1_Object_0<T>
		{
			// Token: 0x04001288 RID: 4744
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CallSiteOps.NativeMethodInfoPtr_Bind_Public_Static_T_CallSiteBinder_CallSite_1_T_Il2CppReferenceArray_1_Object_0, Il2CppClassPointerStore<CallSiteOps>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
