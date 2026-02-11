using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json
{
	// Token: 0x02000026 RID: 38
	public sealed class JsonPropertyAttribute : Attribute
	{
		// Token: 0x06000140 RID: 320 RVA: 0x00016DB0 File Offset: 0x00014FB0
		// Note: this type is marked as 'beforefieldinit'.
		static JsonPropertyAttribute()
		{
			Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json", "JsonPropertyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr);
			JsonPropertyAttribute.NativeFieldInfoPtr__nullValueHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr, "_nullValueHandling");
			JsonPropertyAttribute.NativeFieldInfoPtr__defaultValueHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr, "_defaultValueHandling");
			JsonPropertyAttribute.NativeFieldInfoPtr__referenceLoopHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr, "_referenceLoopHandling");
			JsonPropertyAttribute.NativeFieldInfoPtr__objectCreationHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr, "_objectCreationHandling");
			JsonPropertyAttribute.NativeFieldInfoPtr__typeNameHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr, "_typeNameHandling");
			JsonPropertyAttribute.NativeFieldInfoPtr__isReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr, "_isReference");
			JsonPropertyAttribute.NativeFieldInfoPtr__order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr, "_order");
			JsonPropertyAttribute.NativeFieldInfoPtr__required = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr, "_required");
			JsonPropertyAttribute.NativeFieldInfoPtr__itemIsReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr, "_itemIsReference");
			JsonPropertyAttribute.NativeFieldInfoPtr__itemReferenceLoopHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr, "_itemReferenceLoopHandling");
			JsonPropertyAttribute.NativeFieldInfoPtr__itemTypeNameHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr, "_itemTypeNameHandling");
			JsonPropertyAttribute.NativeFieldInfoPtr__ItemConverterType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr, "<ItemConverterType>k__BackingField");
			JsonPropertyAttribute.NativeFieldInfoPtr__ItemConverterParameters_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr, "<ItemConverterParameters>k__BackingField");
			JsonPropertyAttribute.NativeFieldInfoPtr__NamingStrategyType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr, "<NamingStrategyType>k__BackingField");
			JsonPropertyAttribute.NativeFieldInfoPtr__NamingStrategyParameters_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr, "<NamingStrategyParameters>k__BackingField");
			JsonPropertyAttribute.NativeFieldInfoPtr__PropertyName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr, "<PropertyName>k__BackingField");
			JsonPropertyAttribute.NativeMethodInfoPtr_get_ItemConverterType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr, 100663476);
			JsonPropertyAttribute.NativeMethodInfoPtr_set_ItemConverterType_Public_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr, 100663477);
			JsonPropertyAttribute.NativeMethodInfoPtr_get_ItemConverterParameters_Public_get_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr, 100663478);
			JsonPropertyAttribute.NativeMethodInfoPtr_set_ItemConverterParameters_Public_set_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr, 100663479);
			JsonPropertyAttribute.NativeMethodInfoPtr_get_NamingStrategyType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr, 100663480);
			JsonPropertyAttribute.NativeMethodInfoPtr_set_NamingStrategyType_Public_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr, 100663481);
			JsonPropertyAttribute.NativeMethodInfoPtr_get_NamingStrategyParameters_Public_get_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr, 100663482);
			JsonPropertyAttribute.NativeMethodInfoPtr_set_NamingStrategyParameters_Public_set_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr, 100663483);
			JsonPropertyAttribute.NativeMethodInfoPtr_get_NullValueHandling_Public_get_NullValueHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr, 100663484);
			JsonPropertyAttribute.NativeMethodInfoPtr_set_NullValueHandling_Public_set_Void_NullValueHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr, 100663485);
			JsonPropertyAttribute.NativeMethodInfoPtr_get_DefaultValueHandling_Public_get_DefaultValueHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr, 100663486);
			JsonPropertyAttribute.NativeMethodInfoPtr_set_DefaultValueHandling_Public_set_Void_DefaultValueHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr, 100663487);
			JsonPropertyAttribute.NativeMethodInfoPtr_get_ReferenceLoopHandling_Public_get_ReferenceLoopHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr, 100663488);
			JsonPropertyAttribute.NativeMethodInfoPtr_set_ReferenceLoopHandling_Public_set_Void_ReferenceLoopHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr, 100663489);
			JsonPropertyAttribute.NativeMethodInfoPtr_get_ObjectCreationHandling_Public_get_ObjectCreationHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr, 100663490);
			JsonPropertyAttribute.NativeMethodInfoPtr_set_ObjectCreationHandling_Public_set_Void_ObjectCreationHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr, 100663491);
			JsonPropertyAttribute.NativeMethodInfoPtr_get_TypeNameHandling_Public_get_TypeNameHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr, 100663492);
			JsonPropertyAttribute.NativeMethodInfoPtr_set_TypeNameHandling_Public_set_Void_TypeNameHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr, 100663493);
			JsonPropertyAttribute.NativeMethodInfoPtr_get_IsReference_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr, 100663494);
			JsonPropertyAttribute.NativeMethodInfoPtr_set_IsReference_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr, 100663495);
			JsonPropertyAttribute.NativeMethodInfoPtr_get_Order_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr, 100663496);
			JsonPropertyAttribute.NativeMethodInfoPtr_set_Order_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr, 100663497);
			JsonPropertyAttribute.NativeMethodInfoPtr_get_Required_Public_get_Required_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr, 100663498);
			JsonPropertyAttribute.NativeMethodInfoPtr_set_Required_Public_set_Void_Required_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr, 100663499);
			JsonPropertyAttribute.NativeMethodInfoPtr_get_PropertyName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr, 100663500);
			JsonPropertyAttribute.NativeMethodInfoPtr_set_PropertyName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr, 100663501);
			JsonPropertyAttribute.NativeMethodInfoPtr_get_ItemReferenceLoopHandling_Public_get_ReferenceLoopHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr, 100663502);
			JsonPropertyAttribute.NativeMethodInfoPtr_set_ItemReferenceLoopHandling_Public_set_Void_ReferenceLoopHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr, 100663503);
			JsonPropertyAttribute.NativeMethodInfoPtr_get_ItemTypeNameHandling_Public_get_TypeNameHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr, 100663504);
			JsonPropertyAttribute.NativeMethodInfoPtr_set_ItemTypeNameHandling_Public_set_Void_TypeNameHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr, 100663505);
			JsonPropertyAttribute.NativeMethodInfoPtr_get_ItemIsReference_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr, 100663506);
			JsonPropertyAttribute.NativeMethodInfoPtr_set_ItemIsReference_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr, 100663507);
			JsonPropertyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr, 100663508);
			JsonPropertyAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr, 100663509);
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000141 RID: 321 RVA: 0x000171C8 File Offset: 0x000153C8
		// (set) Token: 0x06000142 RID: 322 RVA: 0x00017208 File Offset: 0x00015408
		public unsafe Type ItemConverterType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonPropertyAttribute.NativeMethodInfoPtr_get_ItemConverterType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonPropertyAttribute.NativeMethodInfoPtr_set_ItemConverterType_Public_set_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000143 RID: 323 RVA: 0x0001724C File Offset: 0x0001544C
		// (set) Token: 0x06000144 RID: 324 RVA: 0x0001728C File Offset: 0x0001548C
		public unsafe Il2CppReferenceArray<Object> ItemConverterParameters
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonPropertyAttribute.NativeMethodInfoPtr_get_ItemConverterParameters_Public_get_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonPropertyAttribute.NativeMethodInfoPtr_set_ItemConverterParameters_Public_set_Void_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000145 RID: 325 RVA: 0x000172D0 File Offset: 0x000154D0
		// (set) Token: 0x06000146 RID: 326 RVA: 0x00017310 File Offset: 0x00015510
		public unsafe Type NamingStrategyType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonPropertyAttribute.NativeMethodInfoPtr_get_NamingStrategyType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonPropertyAttribute.NativeMethodInfoPtr_set_NamingStrategyType_Public_set_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000147 RID: 327 RVA: 0x00017354 File Offset: 0x00015554
		// (set) Token: 0x06000148 RID: 328 RVA: 0x00017394 File Offset: 0x00015594
		public unsafe Il2CppReferenceArray<Object> NamingStrategyParameters
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonPropertyAttribute.NativeMethodInfoPtr_get_NamingStrategyParameters_Public_get_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonPropertyAttribute.NativeMethodInfoPtr_set_NamingStrategyParameters_Public_set_Void_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000149 RID: 329 RVA: 0x000173D8 File Offset: 0x000155D8
		// (set) Token: 0x0600014A RID: 330 RVA: 0x00017414 File Offset: 0x00015614
		public unsafe NullValueHandling NullValueHandling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728149, XrefRangeEnd = 728150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonPropertyAttribute.NativeMethodInfoPtr_get_NullValueHandling_Public_get_NullValueHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728150, XrefRangeEnd = 728153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonPropertyAttribute.NativeMethodInfoPtr_set_NullValueHandling_Public_set_Void_NullValueHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00017454 File Offset: 0x00015654
		// (set) Token: 0x0600014C RID: 332 RVA: 0x00017490 File Offset: 0x00015690
		public unsafe DefaultValueHandling DefaultValueHandling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728153, XrefRangeEnd = 728154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonPropertyAttribute.NativeMethodInfoPtr_get_DefaultValueHandling_Public_get_DefaultValueHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728154, XrefRangeEnd = 728157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonPropertyAttribute.NativeMethodInfoPtr_set_DefaultValueHandling_Public_set_Void_DefaultValueHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600014D RID: 333 RVA: 0x000174D0 File Offset: 0x000156D0
		// (set) Token: 0x0600014E RID: 334 RVA: 0x0001750C File Offset: 0x0001570C
		public unsafe ReferenceLoopHandling ReferenceLoopHandling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728157, XrefRangeEnd = 728158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonPropertyAttribute.NativeMethodInfoPtr_get_ReferenceLoopHandling_Public_get_ReferenceLoopHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728158, XrefRangeEnd = 728161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonPropertyAttribute.NativeMethodInfoPtr_set_ReferenceLoopHandling_Public_set_Void_ReferenceLoopHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600014F RID: 335 RVA: 0x0001754C File Offset: 0x0001574C
		// (set) Token: 0x06000150 RID: 336 RVA: 0x00017588 File Offset: 0x00015788
		public unsafe ObjectCreationHandling ObjectCreationHandling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728161, XrefRangeEnd = 728162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonPropertyAttribute.NativeMethodInfoPtr_get_ObjectCreationHandling_Public_get_ObjectCreationHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728162, XrefRangeEnd = 728165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonPropertyAttribute.NativeMethodInfoPtr_set_ObjectCreationHandling_Public_set_Void_ObjectCreationHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000151 RID: 337 RVA: 0x000175C8 File Offset: 0x000157C8
		// (set) Token: 0x06000152 RID: 338 RVA: 0x00017604 File Offset: 0x00015804
		public unsafe TypeNameHandling TypeNameHandling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728165, XrefRangeEnd = 728166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonPropertyAttribute.NativeMethodInfoPtr_get_TypeNameHandling_Public_get_TypeNameHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728166, XrefRangeEnd = 728169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonPropertyAttribute.NativeMethodInfoPtr_set_TypeNameHandling_Public_set_Void_TypeNameHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000153 RID: 339 RVA: 0x00017644 File Offset: 0x00015844
		// (set) Token: 0x06000154 RID: 340 RVA: 0x00017680 File Offset: 0x00015880
		public unsafe bool IsReference
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728169, XrefRangeEnd = 728170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonPropertyAttribute.NativeMethodInfoPtr_get_IsReference_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728170, XrefRangeEnd = 728173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonPropertyAttribute.NativeMethodInfoPtr_set_IsReference_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000155 RID: 341 RVA: 0x000176C0 File Offset: 0x000158C0
		// (set) Token: 0x06000156 RID: 342 RVA: 0x000176FC File Offset: 0x000158FC
		public unsafe int Order
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728173, XrefRangeEnd = 728174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonPropertyAttribute.NativeMethodInfoPtr_get_Order_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728174, XrefRangeEnd = 728177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonPropertyAttribute.NativeMethodInfoPtr_set_Order_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000157 RID: 343 RVA: 0x0001773C File Offset: 0x0001593C
		// (set) Token: 0x06000158 RID: 344 RVA: 0x00017778 File Offset: 0x00015978
		public unsafe Required Required
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728177, XrefRangeEnd = 728178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonPropertyAttribute.NativeMethodInfoPtr_get_Required_Public_get_Required_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728178, XrefRangeEnd = 728181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonPropertyAttribute.NativeMethodInfoPtr_set_Required_Public_set_Void_Required_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000159 RID: 345 RVA: 0x000177B8 File Offset: 0x000159B8
		// (set) Token: 0x0600015A RID: 346 RVA: 0x000177F0 File Offset: 0x000159F0
		public unsafe string PropertyName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonPropertyAttribute.NativeMethodInfoPtr_get_PropertyName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonPropertyAttribute.NativeMethodInfoPtr_set_PropertyName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00017834 File Offset: 0x00015A34
		// (set) Token: 0x0600015C RID: 348 RVA: 0x00017870 File Offset: 0x00015A70
		public unsafe ReferenceLoopHandling ItemReferenceLoopHandling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728181, XrefRangeEnd = 728182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonPropertyAttribute.NativeMethodInfoPtr_get_ItemReferenceLoopHandling_Public_get_ReferenceLoopHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728182, XrefRangeEnd = 728185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonPropertyAttribute.NativeMethodInfoPtr_set_ItemReferenceLoopHandling_Public_set_Void_ReferenceLoopHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600015D RID: 349 RVA: 0x000178B0 File Offset: 0x00015AB0
		// (set) Token: 0x0600015E RID: 350 RVA: 0x000178EC File Offset: 0x00015AEC
		public unsafe TypeNameHandling ItemTypeNameHandling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728185, XrefRangeEnd = 728186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonPropertyAttribute.NativeMethodInfoPtr_get_ItemTypeNameHandling_Public_get_TypeNameHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728186, XrefRangeEnd = 728189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonPropertyAttribute.NativeMethodInfoPtr_set_ItemTypeNameHandling_Public_set_Void_TypeNameHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600015F RID: 351 RVA: 0x0001792C File Offset: 0x00015B2C
		// (set) Token: 0x06000160 RID: 352 RVA: 0x00017968 File Offset: 0x00015B68
		public unsafe bool ItemIsReference
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728189, XrefRangeEnd = 728190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonPropertyAttribute.NativeMethodInfoPtr_get_ItemIsReference_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728190, XrefRangeEnd = 728193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonPropertyAttribute.NativeMethodInfoPtr_set_ItemIsReference_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000161 RID: 353 RVA: 0x000179A8 File Offset: 0x00015BA8
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonPropertyAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonPropertyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000162 RID: 354 RVA: 0x000179E4 File Offset: 0x00015BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728193, XrefRangeEnd = 728195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonPropertyAttribute(string propertyName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonPropertyAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonPropertyAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0000282F File Offset: 0x00000A2F
		public JsonPropertyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00017A30 File Offset: 0x00015C30
		// (set) Token: 0x06000165 RID: 357 RVA: 0x00002838 File Offset: 0x00000A38
		public Nullable<NullValueHandling> _nullValueHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonPropertyAttribute.NativeFieldInfoPtr__nullValueHandling);
				return new Nullable<NullValueHandling>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<NullValueHandling>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonPropertyAttribute.NativeFieldInfoPtr__nullValueHandling), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<NullValueHandling>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000166 RID: 358 RVA: 0x00017A60 File Offset: 0x00015C60
		// (set) Token: 0x06000167 RID: 359 RVA: 0x00002866 File Offset: 0x00000A66
		public Nullable<DefaultValueHandling> _defaultValueHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonPropertyAttribute.NativeFieldInfoPtr__defaultValueHandling);
				return new Nullable<DefaultValueHandling>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<DefaultValueHandling>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonPropertyAttribute.NativeFieldInfoPtr__defaultValueHandling), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<DefaultValueHandling>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000168 RID: 360 RVA: 0x00017A90 File Offset: 0x00015C90
		// (set) Token: 0x06000169 RID: 361 RVA: 0x00002894 File Offset: 0x00000A94
		public Nullable<ReferenceLoopHandling> _referenceLoopHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonPropertyAttribute.NativeFieldInfoPtr__referenceLoopHandling);
				return new Nullable<ReferenceLoopHandling>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<ReferenceLoopHandling>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonPropertyAttribute.NativeFieldInfoPtr__referenceLoopHandling), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<ReferenceLoopHandling>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600016A RID: 362 RVA: 0x00017AC0 File Offset: 0x00015CC0
		// (set) Token: 0x0600016B RID: 363 RVA: 0x000028C2 File Offset: 0x00000AC2
		public Nullable<ObjectCreationHandling> _objectCreationHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonPropertyAttribute.NativeFieldInfoPtr__objectCreationHandling);
				return new Nullable<ObjectCreationHandling>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<ObjectCreationHandling>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonPropertyAttribute.NativeFieldInfoPtr__objectCreationHandling), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<ObjectCreationHandling>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600016C RID: 364 RVA: 0x00017AF0 File Offset: 0x00015CF0
		// (set) Token: 0x0600016D RID: 365 RVA: 0x000028F0 File Offset: 0x00000AF0
		public Nullable<TypeNameHandling> _typeNameHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonPropertyAttribute.NativeFieldInfoPtr__typeNameHandling);
				return new Nullable<TypeNameHandling>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<TypeNameHandling>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonPropertyAttribute.NativeFieldInfoPtr__typeNameHandling), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<TypeNameHandling>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600016E RID: 366 RVA: 0x00017B20 File Offset: 0x00015D20
		// (set) Token: 0x0600016F RID: 367 RVA: 0x0000291E File Offset: 0x00000B1E
		public Nullable<bool> _isReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonPropertyAttribute.NativeFieldInfoPtr__isReference);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonPropertyAttribute.NativeFieldInfoPtr__isReference), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000170 RID: 368 RVA: 0x00017B50 File Offset: 0x00015D50
		// (set) Token: 0x06000171 RID: 369 RVA: 0x0000294C File Offset: 0x00000B4C
		public Nullable<int> _order
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonPropertyAttribute.NativeFieldInfoPtr__order);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonPropertyAttribute.NativeFieldInfoPtr__order), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000172 RID: 370 RVA: 0x00017B80 File Offset: 0x00015D80
		// (set) Token: 0x06000173 RID: 371 RVA: 0x0000297A File Offset: 0x00000B7A
		public Nullable<Required> _required
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonPropertyAttribute.NativeFieldInfoPtr__required);
				return new Nullable<Required>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<Required>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonPropertyAttribute.NativeFieldInfoPtr__required), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<Required>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000174 RID: 372 RVA: 0x00017BB0 File Offset: 0x00015DB0
		// (set) Token: 0x06000175 RID: 373 RVA: 0x000029A8 File Offset: 0x00000BA8
		public Nullable<bool> _itemIsReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonPropertyAttribute.NativeFieldInfoPtr__itemIsReference);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonPropertyAttribute.NativeFieldInfoPtr__itemIsReference), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000176 RID: 374 RVA: 0x00017BE0 File Offset: 0x00015DE0
		// (set) Token: 0x06000177 RID: 375 RVA: 0x000029D6 File Offset: 0x00000BD6
		public Nullable<ReferenceLoopHandling> _itemReferenceLoopHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonPropertyAttribute.NativeFieldInfoPtr__itemReferenceLoopHandling);
				return new Nullable<ReferenceLoopHandling>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<ReferenceLoopHandling>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonPropertyAttribute.NativeFieldInfoPtr__itemReferenceLoopHandling), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<ReferenceLoopHandling>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000178 RID: 376 RVA: 0x00017C10 File Offset: 0x00015E10
		// (set) Token: 0x06000179 RID: 377 RVA: 0x00002A04 File Offset: 0x00000C04
		public Nullable<TypeNameHandling> _itemTypeNameHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonPropertyAttribute.NativeFieldInfoPtr__itemTypeNameHandling);
				return new Nullable<TypeNameHandling>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<TypeNameHandling>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonPropertyAttribute.NativeFieldInfoPtr__itemTypeNameHandling), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<TypeNameHandling>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600017A RID: 378 RVA: 0x00017C40 File Offset: 0x00015E40
		// (set) Token: 0x0600017B RID: 379 RVA: 0x00002A32 File Offset: 0x00000C32
		public unsafe Type _ItemConverterType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonPropertyAttribute.NativeFieldInfoPtr__ItemConverterType_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonPropertyAttribute.NativeFieldInfoPtr__ItemConverterType_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600017C RID: 380 RVA: 0x00017C70 File Offset: 0x00015E70
		// (set) Token: 0x0600017D RID: 381 RVA: 0x00002A51 File Offset: 0x00000C51
		public unsafe Il2CppReferenceArray<Object> _ItemConverterParameters_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonPropertyAttribute.NativeFieldInfoPtr__ItemConverterParameters_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonPropertyAttribute.NativeFieldInfoPtr__ItemConverterParameters_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600017E RID: 382 RVA: 0x00017CA0 File Offset: 0x00015EA0
		// (set) Token: 0x0600017F RID: 383 RVA: 0x00002A70 File Offset: 0x00000C70
		public unsafe Type _NamingStrategyType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonPropertyAttribute.NativeFieldInfoPtr__NamingStrategyType_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonPropertyAttribute.NativeFieldInfoPtr__NamingStrategyType_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000180 RID: 384 RVA: 0x00017CD0 File Offset: 0x00015ED0
		// (set) Token: 0x06000181 RID: 385 RVA: 0x00002A8F File Offset: 0x00000C8F
		public unsafe Il2CppReferenceArray<Object> _NamingStrategyParameters_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonPropertyAttribute.NativeFieldInfoPtr__NamingStrategyParameters_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonPropertyAttribute.NativeFieldInfoPtr__NamingStrategyParameters_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000182 RID: 386 RVA: 0x00017D00 File Offset: 0x00015F00
		// (set) Token: 0x06000183 RID: 387 RVA: 0x00002AAE File Offset: 0x00000CAE
		public unsafe string _PropertyName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonPropertyAttribute.NativeFieldInfoPtr__PropertyName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonPropertyAttribute.NativeFieldInfoPtr__PropertyName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeFieldInfoPtr__nullValueHandling;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeFieldInfoPtr__defaultValueHandling;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeFieldInfoPtr__referenceLoopHandling;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeFieldInfoPtr__objectCreationHandling;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeFieldInfoPtr__typeNameHandling;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeFieldInfoPtr__isReference;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeFieldInfoPtr__order;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeFieldInfoPtr__required;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeFieldInfoPtr__itemIsReference;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeFieldInfoPtr__itemReferenceLoopHandling;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeFieldInfoPtr__itemTypeNameHandling;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeFieldInfoPtr__ItemConverterType_k__BackingField;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeFieldInfoPtr__ItemConverterParameters_k__BackingField;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeFieldInfoPtr__NamingStrategyType_k__BackingField;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeFieldInfoPtr__NamingStrategyParameters_k__BackingField;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeFieldInfoPtr__PropertyName_k__BackingField;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemConverterType_Public_get_Type_0;

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemConverterType_Public_set_Void_Type_0;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemConverterParameters_Public_get_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemConverterParameters_Public_set_Void_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeMethodInfoPtr_get_NamingStrategyType_Public_get_Type_0;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeMethodInfoPtr_set_NamingStrategyType_Public_set_Void_Type_0;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeMethodInfoPtr_get_NamingStrategyParameters_Public_get_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeMethodInfoPtr_set_NamingStrategyParameters_Public_set_Void_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeMethodInfoPtr_get_NullValueHandling_Public_get_NullValueHandling_0;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeMethodInfoPtr_set_NullValueHandling_Public_set_Void_NullValueHandling_0;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultValueHandling_Public_get_DefaultValueHandling_0;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeMethodInfoPtr_set_DefaultValueHandling_Public_set_Void_DefaultValueHandling_0;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeMethodInfoPtr_get_ReferenceLoopHandling_Public_get_ReferenceLoopHandling_0;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeMethodInfoPtr_set_ReferenceLoopHandling_Public_set_Void_ReferenceLoopHandling_0;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectCreationHandling_Public_get_ObjectCreationHandling_0;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeMethodInfoPtr_set_ObjectCreationHandling_Public_set_Void_ObjectCreationHandling_0;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeNameHandling_Public_get_TypeNameHandling_0;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeMethodInfoPtr_set_TypeNameHandling_Public_set_Void_TypeNameHandling_0;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReference_Public_get_Boolean_0;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeMethodInfoPtr_set_IsReference_Public_set_Void_Boolean_0;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeMethodInfoPtr_get_Order_Public_get_Int32_0;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeMethodInfoPtr_set_Order_Public_set_Void_Int32_0;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr_get_Required_Public_get_Required_0;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr_set_Required_Public_set_Void_Required_0;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeMethodInfoPtr_get_PropertyName_Public_get_String_0;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeMethodInfoPtr_set_PropertyName_Public_set_Void_String_0;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemReferenceLoopHandling_Public_get_ReferenceLoopHandling_0;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemReferenceLoopHandling_Public_set_Void_ReferenceLoopHandling_0;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemTypeNameHandling_Public_get_TypeNameHandling_0;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemTypeNameHandling_Public_set_Void_TypeNameHandling_0;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemIsReference_Public_get_Boolean_0;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemIsReference_Public_set_Void_Boolean_0;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
