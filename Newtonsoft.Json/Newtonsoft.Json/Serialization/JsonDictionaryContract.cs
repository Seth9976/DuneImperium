using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Reflection;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000088 RID: 136
	public class JsonDictionaryContract : JsonContainerContract
	{
		// Token: 0x06000B13 RID: 2835 RVA: 0x00044C04 File Offset: 0x00042E04
		// Note: this type is marked as 'beforefieldinit'.
		static JsonDictionaryContract()
		{
			Il2CppClassPointerStore<JsonDictionaryContract>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Serialization", "JsonDictionaryContract");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonDictionaryContract>.NativeClassPtr);
			JsonDictionaryContract.NativeFieldInfoPtr__DictionaryKeyResolver_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonDictionaryContract>.NativeClassPtr, "<DictionaryKeyResolver>k__BackingField");
			JsonDictionaryContract.NativeFieldInfoPtr__DictionaryKeyType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonDictionaryContract>.NativeClassPtr, "<DictionaryKeyType>k__BackingField");
			JsonDictionaryContract.NativeFieldInfoPtr__DictionaryValueType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonDictionaryContract>.NativeClassPtr, "<DictionaryValueType>k__BackingField");
			JsonDictionaryContract.NativeFieldInfoPtr__KeyContract_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonDictionaryContract>.NativeClassPtr, "<KeyContract>k__BackingField");
			JsonDictionaryContract.NativeFieldInfoPtr__genericCollectionDefinitionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonDictionaryContract>.NativeClassPtr, "_genericCollectionDefinitionType");
			JsonDictionaryContract.NativeFieldInfoPtr__genericWrapperType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonDictionaryContract>.NativeClassPtr, "_genericWrapperType");
			JsonDictionaryContract.NativeFieldInfoPtr__genericWrapperCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonDictionaryContract>.NativeClassPtr, "_genericWrapperCreator");
			JsonDictionaryContract.NativeFieldInfoPtr__genericTemporaryDictionaryCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonDictionaryContract>.NativeClassPtr, "_genericTemporaryDictionaryCreator");
			JsonDictionaryContract.NativeFieldInfoPtr__ShouldCreateWrapper_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonDictionaryContract>.NativeClassPtr, "<ShouldCreateWrapper>k__BackingField");
			JsonDictionaryContract.NativeFieldInfoPtr__parameterizedConstructor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonDictionaryContract>.NativeClassPtr, "_parameterizedConstructor");
			JsonDictionaryContract.NativeFieldInfoPtr__overrideCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonDictionaryContract>.NativeClassPtr, "_overrideCreator");
			JsonDictionaryContract.NativeFieldInfoPtr__parameterizedCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonDictionaryContract>.NativeClassPtr, "_parameterizedCreator");
			JsonDictionaryContract.NativeFieldInfoPtr__HasParameterizedCreator_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonDictionaryContract>.NativeClassPtr, "<HasParameterizedCreator>k__BackingField");
			JsonDictionaryContract.NativeMethodInfoPtr_get_DictionaryKeyResolver_Public_get_Func_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonDictionaryContract>.NativeClassPtr, 100665366);
			JsonDictionaryContract.NativeMethodInfoPtr_set_DictionaryKeyResolver_Public_set_Void_Func_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonDictionaryContract>.NativeClassPtr, 100665367);
			JsonDictionaryContract.NativeMethodInfoPtr_get_DictionaryKeyType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonDictionaryContract>.NativeClassPtr, 100665368);
			JsonDictionaryContract.NativeMethodInfoPtr_get_DictionaryValueType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonDictionaryContract>.NativeClassPtr, 100665369);
			JsonDictionaryContract.NativeMethodInfoPtr_get_KeyContract_Internal_get_JsonContract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonDictionaryContract>.NativeClassPtr, 100665370);
			JsonDictionaryContract.NativeMethodInfoPtr_set_KeyContract_Internal_set_Void_JsonContract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonDictionaryContract>.NativeClassPtr, 100665371);
			JsonDictionaryContract.NativeMethodInfoPtr_get_ShouldCreateWrapper_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonDictionaryContract>.NativeClassPtr, 100665372);
			JsonDictionaryContract.NativeMethodInfoPtr_get_ParameterizedCreator_Internal_get_ObjectConstructor_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonDictionaryContract>.NativeClassPtr, 100665373);
			JsonDictionaryContract.NativeMethodInfoPtr_get_OverrideCreator_Public_get_ObjectConstructor_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonDictionaryContract>.NativeClassPtr, 100665374);
			JsonDictionaryContract.NativeMethodInfoPtr_set_OverrideCreator_Public_set_Void_ObjectConstructor_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonDictionaryContract>.NativeClassPtr, 100665375);
			JsonDictionaryContract.NativeMethodInfoPtr_get_HasParameterizedCreator_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonDictionaryContract>.NativeClassPtr, 100665376);
			JsonDictionaryContract.NativeMethodInfoPtr_set_HasParameterizedCreator_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonDictionaryContract>.NativeClassPtr, 100665377);
			JsonDictionaryContract.NativeMethodInfoPtr_get_HasParameterizedCreatorInternal_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonDictionaryContract>.NativeClassPtr, 100665378);
			JsonDictionaryContract.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonDictionaryContract>.NativeClassPtr, 100665379);
			JsonDictionaryContract.NativeMethodInfoPtr_CreateWrapper_Internal_IWrappedDictionary_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonDictionaryContract>.NativeClassPtr, 100665380);
			JsonDictionaryContract.NativeMethodInfoPtr_CreateTemporaryDictionary_Internal_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonDictionaryContract>.NativeClassPtr, 100665381);
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000B14 RID: 2836 RVA: 0x00044E78 File Offset: 0x00043078
		// (set) Token: 0x06000B15 RID: 2837 RVA: 0x00044EB8 File Offset: 0x000430B8
		public unsafe Func<string, string> DictionaryKeyResolver
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonDictionaryContract.NativeMethodInfoPtr_get_DictionaryKeyResolver_Public_get_Func_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonDictionaryContract.NativeMethodInfoPtr_set_DictionaryKeyResolver_Public_set_Void_Func_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000B16 RID: 2838 RVA: 0x00044EFC File Offset: 0x000430FC
		public unsafe Type DictionaryKeyType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonDictionaryContract.NativeMethodInfoPtr_get_DictionaryKeyType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000B17 RID: 2839 RVA: 0x00044F3C File Offset: 0x0004313C
		public unsafe Type DictionaryValueType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonDictionaryContract.NativeMethodInfoPtr_get_DictionaryValueType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000B18 RID: 2840 RVA: 0x00044F7C File Offset: 0x0004317C
		// (set) Token: 0x06000B19 RID: 2841 RVA: 0x00044FBC File Offset: 0x000431BC
		public unsafe JsonContract KeyContract
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 39587, RefRangeEnd = 39588, XrefRangeStart = 39587, XrefRangeEnd = 39588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonDictionaryContract.NativeMethodInfoPtr_get_KeyContract_Internal_get_JsonContract_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonContract>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonDictionaryContract.NativeMethodInfoPtr_set_KeyContract_Internal_set_Void_JsonContract_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000B1A RID: 2842 RVA: 0x00045000 File Offset: 0x00043200
		public unsafe bool ShouldCreateWrapper
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonDictionaryContract.NativeMethodInfoPtr_get_ShouldCreateWrapper_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000B1B RID: 2843 RVA: 0x0004503C File Offset: 0x0004323C
		public unsafe ObjectConstructor<Object> ParameterizedCreator
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749484, XrefRangeEnd = 749493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonDictionaryContract.NativeMethodInfoPtr_get_ParameterizedCreator_Internal_get_ObjectConstructor_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectConstructor<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000B1C RID: 2844 RVA: 0x0004507C File Offset: 0x0004327C
		// (set) Token: 0x06000B1D RID: 2845 RVA: 0x000450BC File Offset: 0x000432BC
		public unsafe ObjectConstructor<Object> OverrideCreator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonDictionaryContract.NativeMethodInfoPtr_get_OverrideCreator_Public_get_ObjectConstructor_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectConstructor<Object>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonDictionaryContract.NativeMethodInfoPtr_set_OverrideCreator_Public_set_Void_ObjectConstructor_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000B1E RID: 2846 RVA: 0x00045100 File Offset: 0x00043300
		// (set) Token: 0x06000B1F RID: 2847 RVA: 0x0004513C File Offset: 0x0004333C
		public unsafe bool HasParameterizedCreator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonDictionaryContract.NativeMethodInfoPtr_get_HasParameterizedCreator_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonDictionaryContract.NativeMethodInfoPtr_set_HasParameterizedCreator_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000B20 RID: 2848 RVA: 0x0004517C File Offset: 0x0004337C
		public unsafe bool HasParameterizedCreatorInternal
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 749497, RefRangeEnd = 749498, XrefRangeStart = 749493, XrefRangeEnd = 749497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonDictionaryContract.NativeMethodInfoPtr_get_HasParameterizedCreatorInternal_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x000451B8 File Offset: 0x000433B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 749646, RefRangeEnd = 749647, XrefRangeStart = 749498, XrefRangeEnd = 749646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonDictionaryContract(Type underlyingType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonDictionaryContract>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(underlyingType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonDictionaryContract.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x00045204 File Offset: 0x00043404
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 749678, RefRangeEnd = 749681, XrefRangeStart = 749647, XrefRangeEnd = 749678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IWrappedDictionary CreateWrapper(Object dictionary)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonDictionaryContract.NativeMethodInfoPtr_CreateWrapper_Internal_IWrappedDictionary_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IWrappedDictionary>(intPtr3) : null;
			}
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x00045254 File Offset: 0x00043454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749681, XrefRangeEnd = 749713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IDictionary CreateTemporaryDictionary()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonDictionaryContract.NativeMethodInfoPtr_CreateTemporaryDictionary_Internal_IDictionary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary>(intPtr3) : null;
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x00005842 File Offset: 0x00003A42
		public JsonDictionaryContract(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000B25 RID: 2853 RVA: 0x00045294 File Offset: 0x00043494
		// (set) Token: 0x06000B26 RID: 2854 RVA: 0x0000584B File Offset: 0x00003A4B
		public unsafe Func<string, string> _DictionaryKeyResolver_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonDictionaryContract.NativeFieldInfoPtr__DictionaryKeyResolver_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonDictionaryContract.NativeFieldInfoPtr__DictionaryKeyResolver_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000B27 RID: 2855 RVA: 0x000452C4 File Offset: 0x000434C4
		// (set) Token: 0x06000B28 RID: 2856 RVA: 0x0000586A File Offset: 0x00003A6A
		public unsafe Type _DictionaryKeyType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonDictionaryContract.NativeFieldInfoPtr__DictionaryKeyType_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonDictionaryContract.NativeFieldInfoPtr__DictionaryKeyType_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000B29 RID: 2857 RVA: 0x000452F4 File Offset: 0x000434F4
		// (set) Token: 0x06000B2A RID: 2858 RVA: 0x00005889 File Offset: 0x00003A89
		public unsafe Type _DictionaryValueType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonDictionaryContract.NativeFieldInfoPtr__DictionaryValueType_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonDictionaryContract.NativeFieldInfoPtr__DictionaryValueType_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000B2B RID: 2859 RVA: 0x00045324 File Offset: 0x00043524
		// (set) Token: 0x06000B2C RID: 2860 RVA: 0x000058A8 File Offset: 0x00003AA8
		public unsafe JsonContract _KeyContract_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonDictionaryContract.NativeFieldInfoPtr__KeyContract_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonContract>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonDictionaryContract.NativeFieldInfoPtr__KeyContract_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000B2D RID: 2861 RVA: 0x00045354 File Offset: 0x00043554
		// (set) Token: 0x06000B2E RID: 2862 RVA: 0x000058C7 File Offset: 0x00003AC7
		public unsafe Type _genericCollectionDefinitionType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonDictionaryContract.NativeFieldInfoPtr__genericCollectionDefinitionType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonDictionaryContract.NativeFieldInfoPtr__genericCollectionDefinitionType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000B2F RID: 2863 RVA: 0x00045384 File Offset: 0x00043584
		// (set) Token: 0x06000B30 RID: 2864 RVA: 0x000058E6 File Offset: 0x00003AE6
		public unsafe Type _genericWrapperType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonDictionaryContract.NativeFieldInfoPtr__genericWrapperType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonDictionaryContract.NativeFieldInfoPtr__genericWrapperType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000B31 RID: 2865 RVA: 0x000453B4 File Offset: 0x000435B4
		// (set) Token: 0x06000B32 RID: 2866 RVA: 0x00005905 File Offset: 0x00003B05
		public unsafe ObjectConstructor<Object> _genericWrapperCreator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonDictionaryContract.NativeFieldInfoPtr__genericWrapperCreator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectConstructor<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonDictionaryContract.NativeFieldInfoPtr__genericWrapperCreator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000B33 RID: 2867 RVA: 0x000453E4 File Offset: 0x000435E4
		// (set) Token: 0x06000B34 RID: 2868 RVA: 0x00005924 File Offset: 0x00003B24
		public unsafe Func<Object> _genericTemporaryDictionaryCreator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonDictionaryContract.NativeFieldInfoPtr__genericTemporaryDictionaryCreator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonDictionaryContract.NativeFieldInfoPtr__genericTemporaryDictionaryCreator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000B35 RID: 2869 RVA: 0x00045414 File Offset: 0x00043614
		// (set) Token: 0x06000B36 RID: 2870 RVA: 0x00005943 File Offset: 0x00003B43
		public unsafe bool _ShouldCreateWrapper_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonDictionaryContract.NativeFieldInfoPtr__ShouldCreateWrapper_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonDictionaryContract.NativeFieldInfoPtr__ShouldCreateWrapper_k__BackingField)) = value;
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000B37 RID: 2871 RVA: 0x0004543C File Offset: 0x0004363C
		// (set) Token: 0x06000B38 RID: 2872 RVA: 0x0000595E File Offset: 0x00003B5E
		public unsafe ConstructorInfo _parameterizedConstructor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonDictionaryContract.NativeFieldInfoPtr__parameterizedConstructor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstructorInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonDictionaryContract.NativeFieldInfoPtr__parameterizedConstructor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000B39 RID: 2873 RVA: 0x0004546C File Offset: 0x0004366C
		// (set) Token: 0x06000B3A RID: 2874 RVA: 0x0000597D File Offset: 0x00003B7D
		public unsafe ObjectConstructor<Object> _overrideCreator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonDictionaryContract.NativeFieldInfoPtr__overrideCreator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectConstructor<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonDictionaryContract.NativeFieldInfoPtr__overrideCreator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000B3B RID: 2875 RVA: 0x0004549C File Offset: 0x0004369C
		// (set) Token: 0x06000B3C RID: 2876 RVA: 0x0000599C File Offset: 0x00003B9C
		public unsafe ObjectConstructor<Object> _parameterizedCreator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonDictionaryContract.NativeFieldInfoPtr__parameterizedCreator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectConstructor<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonDictionaryContract.NativeFieldInfoPtr__parameterizedCreator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000B3D RID: 2877 RVA: 0x000454CC File Offset: 0x000436CC
		// (set) Token: 0x06000B3E RID: 2878 RVA: 0x000059BB File Offset: 0x00003BBB
		public unsafe bool _HasParameterizedCreator_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonDictionaryContract.NativeFieldInfoPtr__HasParameterizedCreator_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonDictionaryContract.NativeFieldInfoPtr__HasParameterizedCreator_k__BackingField)) = value;
			}
		}

		// Token: 0x04000911 RID: 2321
		private static readonly IntPtr NativeFieldInfoPtr__DictionaryKeyResolver_k__BackingField;

		// Token: 0x04000912 RID: 2322
		private static readonly IntPtr NativeFieldInfoPtr__DictionaryKeyType_k__BackingField;

		// Token: 0x04000913 RID: 2323
		private static readonly IntPtr NativeFieldInfoPtr__DictionaryValueType_k__BackingField;

		// Token: 0x04000914 RID: 2324
		private static readonly IntPtr NativeFieldInfoPtr__KeyContract_k__BackingField;

		// Token: 0x04000915 RID: 2325
		private static readonly IntPtr NativeFieldInfoPtr__genericCollectionDefinitionType;

		// Token: 0x04000916 RID: 2326
		private static readonly IntPtr NativeFieldInfoPtr__genericWrapperType;

		// Token: 0x04000917 RID: 2327
		private static readonly IntPtr NativeFieldInfoPtr__genericWrapperCreator;

		// Token: 0x04000918 RID: 2328
		private static readonly IntPtr NativeFieldInfoPtr__genericTemporaryDictionaryCreator;

		// Token: 0x04000919 RID: 2329
		private static readonly IntPtr NativeFieldInfoPtr__ShouldCreateWrapper_k__BackingField;

		// Token: 0x0400091A RID: 2330
		private static readonly IntPtr NativeFieldInfoPtr__parameterizedConstructor;

		// Token: 0x0400091B RID: 2331
		private static readonly IntPtr NativeFieldInfoPtr__overrideCreator;

		// Token: 0x0400091C RID: 2332
		private static readonly IntPtr NativeFieldInfoPtr__parameterizedCreator;

		// Token: 0x0400091D RID: 2333
		private static readonly IntPtr NativeFieldInfoPtr__HasParameterizedCreator_k__BackingField;

		// Token: 0x0400091E RID: 2334
		private static readonly IntPtr NativeMethodInfoPtr_get_DictionaryKeyResolver_Public_get_Func_2_String_String_0;

		// Token: 0x0400091F RID: 2335
		private static readonly IntPtr NativeMethodInfoPtr_set_DictionaryKeyResolver_Public_set_Void_Func_2_String_String_0;

		// Token: 0x04000920 RID: 2336
		private static readonly IntPtr NativeMethodInfoPtr_get_DictionaryKeyType_Public_get_Type_0;

		// Token: 0x04000921 RID: 2337
		private static readonly IntPtr NativeMethodInfoPtr_get_DictionaryValueType_Public_get_Type_0;

		// Token: 0x04000922 RID: 2338
		private static readonly IntPtr NativeMethodInfoPtr_get_KeyContract_Internal_get_JsonContract_0;

		// Token: 0x04000923 RID: 2339
		private static readonly IntPtr NativeMethodInfoPtr_set_KeyContract_Internal_set_Void_JsonContract_0;

		// Token: 0x04000924 RID: 2340
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldCreateWrapper_Internal_get_Boolean_0;

		// Token: 0x04000925 RID: 2341
		private static readonly IntPtr NativeMethodInfoPtr_get_ParameterizedCreator_Internal_get_ObjectConstructor_1_Object_0;

		// Token: 0x04000926 RID: 2342
		private static readonly IntPtr NativeMethodInfoPtr_get_OverrideCreator_Public_get_ObjectConstructor_1_Object_0;

		// Token: 0x04000927 RID: 2343
		private static readonly IntPtr NativeMethodInfoPtr_set_OverrideCreator_Public_set_Void_ObjectConstructor_1_Object_0;

		// Token: 0x04000928 RID: 2344
		private static readonly IntPtr NativeMethodInfoPtr_get_HasParameterizedCreator_Public_get_Boolean_0;

		// Token: 0x04000929 RID: 2345
		private static readonly IntPtr NativeMethodInfoPtr_set_HasParameterizedCreator_Public_set_Void_Boolean_0;

		// Token: 0x0400092A RID: 2346
		private static readonly IntPtr NativeMethodInfoPtr_get_HasParameterizedCreatorInternal_Internal_get_Boolean_0;

		// Token: 0x0400092B RID: 2347
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;

		// Token: 0x0400092C RID: 2348
		private static readonly IntPtr NativeMethodInfoPtr_CreateWrapper_Internal_IWrappedDictionary_Object_0;

		// Token: 0x0400092D RID: 2349
		private static readonly IntPtr NativeMethodInfoPtr_CreateTemporaryDictionary_Internal_IDictionary_0;
	}
}
