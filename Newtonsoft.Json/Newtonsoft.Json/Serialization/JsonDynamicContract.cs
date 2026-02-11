using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Dynamic;
using Il2CppSystem.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000089 RID: 137
	public class JsonDynamicContract : JsonContainerContract
	{
		// Token: 0x06000B3F RID: 2879 RVA: 0x000454F4 File Offset: 0x000436F4
		// Note: this type is marked as 'beforefieldinit'.
		static JsonDynamicContract()
		{
			Il2CppClassPointerStore<JsonDynamicContract>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Serialization", "JsonDynamicContract");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonDynamicContract>.NativeClassPtr);
			JsonDynamicContract.NativeFieldInfoPtr__Properties_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonDynamicContract>.NativeClassPtr, "<Properties>k__BackingField");
			JsonDynamicContract.NativeFieldInfoPtr__PropertyNameResolver_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonDynamicContract>.NativeClassPtr, "<PropertyNameResolver>k__BackingField");
			JsonDynamicContract.NativeFieldInfoPtr__callSiteGetters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonDynamicContract>.NativeClassPtr, "_callSiteGetters");
			JsonDynamicContract.NativeFieldInfoPtr__callSiteSetters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonDynamicContract>.NativeClassPtr, "_callSiteSetters");
			JsonDynamicContract.NativeMethodInfoPtr_get_Properties_Public_get_JsonPropertyCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonDynamicContract>.NativeClassPtr, 100665382);
			JsonDynamicContract.NativeMethodInfoPtr_get_PropertyNameResolver_Public_get_Func_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonDynamicContract>.NativeClassPtr, 100665383);
			JsonDynamicContract.NativeMethodInfoPtr_set_PropertyNameResolver_Public_set_Void_Func_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonDynamicContract>.NativeClassPtr, 100665384);
			JsonDynamicContract.NativeMethodInfoPtr_CreateCallSiteGetter_Private_Static_CallSite_1_Func_3_CallSite_Object_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonDynamicContract>.NativeClassPtr, 100665385);
			JsonDynamicContract.NativeMethodInfoPtr_CreateCallSiteSetter_Private_Static_CallSite_1_Func_4_CallSite_Object_Object_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonDynamicContract>.NativeClassPtr, 100665386);
			JsonDynamicContract.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonDynamicContract>.NativeClassPtr, 100665387);
			JsonDynamicContract.NativeMethodInfoPtr_TryGetMember_Internal_Boolean_IDynamicMetaObjectProvider_String_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonDynamicContract>.NativeClassPtr, 100665388);
			JsonDynamicContract.NativeMethodInfoPtr_TrySetMember_Internal_Boolean_IDynamicMetaObjectProvider_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonDynamicContract>.NativeClassPtr, 100665389);
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000B40 RID: 2880 RVA: 0x00045614 File Offset: 0x00043814
		public unsafe JsonPropertyCollection Properties
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonDynamicContract.NativeMethodInfoPtr_get_Properties_Public_get_JsonPropertyCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonPropertyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000B41 RID: 2881 RVA: 0x00045654 File Offset: 0x00043854
		// (set) Token: 0x06000B42 RID: 2882 RVA: 0x00045694 File Offset: 0x00043894
		public unsafe Func<string, string> PropertyNameResolver
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonDynamicContract.NativeMethodInfoPtr_get_PropertyNameResolver_Public_get_Func_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonDynamicContract.NativeMethodInfoPtr_set_PropertyNameResolver_Public_set_Void_Func_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x000456D8 File Offset: 0x000438D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749713, XrefRangeEnd = 749730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CallSite<Func<CallSite, Object, Object>> CreateCallSiteGetter(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonDynamicContract.NativeMethodInfoPtr_CreateCallSiteGetter_Private_Static_CallSite_1_Func_3_CallSite_Object_Object_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CallSite<Func<CallSite, Object, Object>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x0004571C File Offset: 0x0004391C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749730, XrefRangeEnd = 749747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CallSite<Func<CallSite, Object, Object, Object>> CreateCallSiteSetter(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonDynamicContract.NativeMethodInfoPtr_CreateCallSiteSetter_Private_Static_CallSite_1_Func_4_CallSite_Object_Object_Object_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CallSite<Func<CallSite, Object, Object, Object>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x00045760 File Offset: 0x00043960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749747, XrefRangeEnd = 749779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonDynamicContract(Type underlyingType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonDynamicContract>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(underlyingType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonDynamicContract.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x000457AC File Offset: 0x000439AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 749789, RefRangeEnd = 749790, XrefRangeStart = 749779, XrefRangeEnd = 749789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetMember(IDynamicMetaObjectProvider dynamicProvider, string name, out Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dynamicProvider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(JsonDynamicContract.NativeMethodInfoPtr_TryGetMember_Internal_Boolean_IDynamicMetaObjectProvider_String_byref_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : new Object(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x00045830 File Offset: 0x00043A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749790, XrefRangeEnd = 749799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TrySetMember(IDynamicMetaObjectProvider dynamicProvider, string name, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dynamicProvider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonDynamicContract.NativeMethodInfoPtr_TrySetMember_Internal_Boolean_IDynamicMetaObjectProvider_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x000059D6 File Offset: 0x00003BD6
		public JsonDynamicContract(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000B49 RID: 2889 RVA: 0x000458A4 File Offset: 0x00043AA4
		// (set) Token: 0x06000B4A RID: 2890 RVA: 0x000059DF File Offset: 0x00003BDF
		public unsafe JsonPropertyCollection _Properties_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonDynamicContract.NativeFieldInfoPtr__Properties_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonPropertyCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonDynamicContract.NativeFieldInfoPtr__Properties_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000B4B RID: 2891 RVA: 0x000458D4 File Offset: 0x00043AD4
		// (set) Token: 0x06000B4C RID: 2892 RVA: 0x000059FE File Offset: 0x00003BFE
		public unsafe Func<string, string> _PropertyNameResolver_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonDynamicContract.NativeFieldInfoPtr__PropertyNameResolver_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonDynamicContract.NativeFieldInfoPtr__PropertyNameResolver_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000B4D RID: 2893 RVA: 0x00045904 File Offset: 0x00043B04
		// (set) Token: 0x06000B4E RID: 2894 RVA: 0x00005A1D File Offset: 0x00003C1D
		public unsafe ThreadSafeStore<string, CallSite<Func<CallSite, Object, Object>>> _callSiteGetters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonDynamicContract.NativeFieldInfoPtr__callSiteGetters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThreadSafeStore<string, CallSite<Func<CallSite, Object, Object>>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonDynamicContract.NativeFieldInfoPtr__callSiteGetters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000B4F RID: 2895 RVA: 0x00045934 File Offset: 0x00043B34
		// (set) Token: 0x06000B50 RID: 2896 RVA: 0x00005A3C File Offset: 0x00003C3C
		public unsafe ThreadSafeStore<string, CallSite<Func<CallSite, Object, Object, Object>>> _callSiteSetters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonDynamicContract.NativeFieldInfoPtr__callSiteSetters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThreadSafeStore<string, CallSite<Func<CallSite, Object, Object, Object>>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonDynamicContract.NativeFieldInfoPtr__callSiteSetters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400092E RID: 2350
		private static readonly IntPtr NativeFieldInfoPtr__Properties_k__BackingField;

		// Token: 0x0400092F RID: 2351
		private static readonly IntPtr NativeFieldInfoPtr__PropertyNameResolver_k__BackingField;

		// Token: 0x04000930 RID: 2352
		private static readonly IntPtr NativeFieldInfoPtr__callSiteGetters;

		// Token: 0x04000931 RID: 2353
		private static readonly IntPtr NativeFieldInfoPtr__callSiteSetters;

		// Token: 0x04000932 RID: 2354
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Public_get_JsonPropertyCollection_0;

		// Token: 0x04000933 RID: 2355
		private static readonly IntPtr NativeMethodInfoPtr_get_PropertyNameResolver_Public_get_Func_2_String_String_0;

		// Token: 0x04000934 RID: 2356
		private static readonly IntPtr NativeMethodInfoPtr_set_PropertyNameResolver_Public_set_Void_Func_2_String_String_0;

		// Token: 0x04000935 RID: 2357
		private static readonly IntPtr NativeMethodInfoPtr_CreateCallSiteGetter_Private_Static_CallSite_1_Func_3_CallSite_Object_Object_String_0;

		// Token: 0x04000936 RID: 2358
		private static readonly IntPtr NativeMethodInfoPtr_CreateCallSiteSetter_Private_Static_CallSite_1_Func_4_CallSite_Object_Object_Object_String_0;

		// Token: 0x04000937 RID: 2359
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;

		// Token: 0x04000938 RID: 2360
		private static readonly IntPtr NativeMethodInfoPtr_TryGetMember_Internal_Boolean_IDynamicMetaObjectProvider_String_byref_Object_0;

		// Token: 0x04000939 RID: 2361
		private static readonly IntPtr NativeMethodInfoPtr_TrySetMember_Internal_Boolean_IDynamicMetaObjectProvider_String_Object_0;
	}
}
