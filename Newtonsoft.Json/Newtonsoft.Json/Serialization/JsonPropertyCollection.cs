using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000090 RID: 144
	public class JsonPropertyCollection : KeyedCollection<string, JsonProperty>
	{
		// Token: 0x06000C39 RID: 3129 RVA: 0x00048F78 File Offset: 0x00047178
		// Note: this type is marked as 'beforefieldinit'.
		static JsonPropertyCollection()
		{
			Il2CppClassPointerStore<JsonPropertyCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Serialization", "JsonPropertyCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonPropertyCollection>.NativeClassPtr);
			JsonPropertyCollection.NativeFieldInfoPtr__type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonPropertyCollection>.NativeClassPtr, "_type");
			JsonPropertyCollection.NativeFieldInfoPtr__list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonPropertyCollection>.NativeClassPtr, "_list");
			JsonPropertyCollection.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPropertyCollection>.NativeClassPtr, 100665507);
			JsonPropertyCollection.NativeMethodInfoPtr_GetKeyForItem_Protected_Virtual_String_JsonProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPropertyCollection>.NativeClassPtr, 100665508);
			JsonPropertyCollection.NativeMethodInfoPtr_AddProperty_Public_Void_JsonProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPropertyCollection>.NativeClassPtr, 100665509);
			JsonPropertyCollection.NativeMethodInfoPtr_GetClosestMatchProperty_Public_JsonProperty_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPropertyCollection>.NativeClassPtr, 100665510);
			JsonPropertyCollection.NativeMethodInfoPtr_TryGetProperty_Private_Boolean_String_byref_JsonProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPropertyCollection>.NativeClassPtr, 100665511);
			JsonPropertyCollection.NativeMethodInfoPtr_GetProperty_Public_JsonProperty_String_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonPropertyCollection>.NativeClassPtr, 100665512);
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x00049048 File Offset: 0x00047248
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 750080, RefRangeEnd = 750089, XrefRangeStart = 750054, XrefRangeEnd = 750080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonPropertyCollection(Type type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonPropertyCollection>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonPropertyCollection.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x00049094 File Offset: 0x00047294
		[CallerCount(0)]
		public unsafe override string GetKeyForItem(JsonProperty item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonPropertyCollection.NativeMethodInfoPtr_GetKeyForItem_Protected_Virtual_String_JsonProperty_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x000490E8 File Offset: 0x000472E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 750117, RefRangeEnd = 750119, XrefRangeStart = 750089, XrefRangeEnd = 750117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddProperty(JsonProperty property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonPropertyCollection.NativeMethodInfoPtr_AddProperty_Public_Void_JsonProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x0004912C File Offset: 0x0004732C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750119, XrefRangeEnd = 750121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonProperty GetClosestMatchProperty(string propertyName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonPropertyCollection.NativeMethodInfoPtr_GetClosestMatchProperty_Public_JsonProperty_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonProperty>(intPtr3) : null;
			}
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x0004917C File Offset: 0x0004737C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750121, XrefRangeEnd = 750127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetProperty(string key, out JsonProperty item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(JsonPropertyCollection.NativeMethodInfoPtr_TryGetProperty_Private_Boolean_String_byref_JsonProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			item = ((intPtr4 == 0) ? null : new JsonProperty(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x000491EC File Offset: 0x000473EC
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 750133, RefRangeEnd = 750147, XrefRangeStart = 750127, XrefRangeEnd = 750133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonProperty GetProperty(string propertyName, StringComparison comparisonType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparisonType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonPropertyCollection.NativeMethodInfoPtr_GetProperty_Public_JsonProperty_String_StringComparison_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonProperty>(intPtr3) : null;
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x000061C2 File Offset: 0x000043C2
		public JsonPropertyCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000C41 RID: 3137 RVA: 0x0004924C File Offset: 0x0004744C
		// (set) Token: 0x06000C42 RID: 3138 RVA: 0x000061CB File Offset: 0x000043CB
		public unsafe Type _type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonPropertyCollection.NativeFieldInfoPtr__type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonPropertyCollection.NativeFieldInfoPtr__type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000C43 RID: 3139 RVA: 0x0004927C File Offset: 0x0004747C
		// (set) Token: 0x06000C44 RID: 3140 RVA: 0x000061EA File Offset: 0x000043EA
		public unsafe List<JsonProperty> _list
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonPropertyCollection.NativeFieldInfoPtr__list);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<JsonProperty>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonPropertyCollection.NativeFieldInfoPtr__list), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009E2 RID: 2530
		private static readonly IntPtr NativeFieldInfoPtr__type;

		// Token: 0x040009E3 RID: 2531
		private static readonly IntPtr NativeFieldInfoPtr__list;

		// Token: 0x040009E4 RID: 2532
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;

		// Token: 0x040009E5 RID: 2533
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyForItem_Protected_Virtual_String_JsonProperty_0;

		// Token: 0x040009E6 RID: 2534
		private static readonly IntPtr NativeMethodInfoPtr_AddProperty_Public_Void_JsonProperty_0;

		// Token: 0x040009E7 RID: 2535
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestMatchProperty_Public_JsonProperty_String_0;

		// Token: 0x040009E8 RID: 2536
		private static readonly IntPtr NativeMethodInfoPtr_TryGetProperty_Private_Boolean_String_byref_JsonProperty_0;

		// Token: 0x040009E9 RID: 2537
		private static readonly IntPtr NativeMethodInfoPtr_GetProperty_Public_JsonProperty_String_StringComparison_0;
	}
}
