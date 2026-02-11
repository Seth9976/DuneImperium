using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json
{
	// Token: 0x02000023 RID: 35
	public sealed class JsonObjectAttribute : JsonContainerAttribute
	{
		// Token: 0x06000118 RID: 280 RVA: 0x000164EC File Offset: 0x000146EC
		// Note: this type is marked as 'beforefieldinit'.
		static JsonObjectAttribute()
		{
			Il2CppClassPointerStore<JsonObjectAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json", "JsonObjectAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonObjectAttribute>.NativeClassPtr);
			JsonObjectAttribute.NativeFieldInfoPtr__memberSerialization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonObjectAttribute>.NativeClassPtr, "_memberSerialization");
			JsonObjectAttribute.NativeFieldInfoPtr__missingMemberHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonObjectAttribute>.NativeClassPtr, "_missingMemberHandling");
			JsonObjectAttribute.NativeFieldInfoPtr__itemRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonObjectAttribute>.NativeClassPtr, "_itemRequired");
			JsonObjectAttribute.NativeFieldInfoPtr__itemNullValueHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonObjectAttribute>.NativeClassPtr, "_itemNullValueHandling");
			JsonObjectAttribute.NativeMethodInfoPtr_get_MemberSerialization_Public_get_MemberSerialization_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonObjectAttribute>.NativeClassPtr, 100663458);
			JsonObjectAttribute.NativeMethodInfoPtr_set_MemberSerialization_Public_set_Void_MemberSerialization_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonObjectAttribute>.NativeClassPtr, 100663459);
			JsonObjectAttribute.NativeMethodInfoPtr_get_MissingMemberHandling_Public_get_MissingMemberHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonObjectAttribute>.NativeClassPtr, 100663460);
			JsonObjectAttribute.NativeMethodInfoPtr_set_MissingMemberHandling_Public_set_Void_MissingMemberHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonObjectAttribute>.NativeClassPtr, 100663461);
			JsonObjectAttribute.NativeMethodInfoPtr_get_ItemNullValueHandling_Public_get_NullValueHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonObjectAttribute>.NativeClassPtr, 100663462);
			JsonObjectAttribute.NativeMethodInfoPtr_set_ItemNullValueHandling_Public_set_Void_NullValueHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonObjectAttribute>.NativeClassPtr, 100663463);
			JsonObjectAttribute.NativeMethodInfoPtr_get_ItemRequired_Public_get_Required_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonObjectAttribute>.NativeClassPtr, 100663464);
			JsonObjectAttribute.NativeMethodInfoPtr_set_ItemRequired_Public_set_Void_Required_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonObjectAttribute>.NativeClassPtr, 100663465);
			JsonObjectAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonObjectAttribute>.NativeClassPtr, 100663466);
			JsonObjectAttribute.NativeMethodInfoPtr__ctor_Public_Void_MemberSerialization_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonObjectAttribute>.NativeClassPtr, 100663467);
			JsonObjectAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonObjectAttribute>.NativeClassPtr, 100663468);
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000119 RID: 281 RVA: 0x00016648 File Offset: 0x00014848
		// (set) Token: 0x0600011A RID: 282 RVA: 0x00016684 File Offset: 0x00014884
		public unsafe MemberSerialization MemberSerialization
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonObjectAttribute.NativeMethodInfoPtr_get_MemberSerialization_Public_get_MemberSerialization_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 337738, RefRangeEnd = 337747, XrefRangeStart = 337738, XrefRangeEnd = 337747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonObjectAttribute.NativeMethodInfoPtr_set_MemberSerialization_Public_set_Void_MemberSerialization_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600011B RID: 283 RVA: 0x000166C4 File Offset: 0x000148C4
		// (set) Token: 0x0600011C RID: 284 RVA: 0x00016700 File Offset: 0x00014900
		public unsafe MissingMemberHandling MissingMemberHandling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727992, XrefRangeEnd = 727993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonObjectAttribute.NativeMethodInfoPtr_get_MissingMemberHandling_Public_get_MissingMemberHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727993, XrefRangeEnd = 727996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonObjectAttribute.NativeMethodInfoPtr_set_MissingMemberHandling_Public_set_Void_MissingMemberHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600011D RID: 285 RVA: 0x00016740 File Offset: 0x00014940
		// (set) Token: 0x0600011E RID: 286 RVA: 0x0001677C File Offset: 0x0001497C
		public unsafe NullValueHandling ItemNullValueHandling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727996, XrefRangeEnd = 727997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonObjectAttribute.NativeMethodInfoPtr_get_ItemNullValueHandling_Public_get_NullValueHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727997, XrefRangeEnd = 728000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonObjectAttribute.NativeMethodInfoPtr_set_ItemNullValueHandling_Public_set_Void_NullValueHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600011F RID: 287 RVA: 0x000167BC File Offset: 0x000149BC
		// (set) Token: 0x06000120 RID: 288 RVA: 0x000167F8 File Offset: 0x000149F8
		public unsafe Required ItemRequired
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728000, XrefRangeEnd = 728001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonObjectAttribute.NativeMethodInfoPtr_get_ItemRequired_Public_get_Required_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728001, XrefRangeEnd = 728004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonObjectAttribute.NativeMethodInfoPtr_set_ItemRequired_Public_set_Void_Required_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00016838 File Offset: 0x00014A38
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonObjectAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonObjectAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonObjectAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00016874 File Offset: 0x00014A74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728004, XrefRangeEnd = 728005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonObjectAttribute(MemberSerialization memberSerialization)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonObjectAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref memberSerialization;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonObjectAttribute.NativeMethodInfoPtr__ctor_Public_Void_MemberSerialization_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000123 RID: 291 RVA: 0x000168BC File Offset: 0x00014ABC
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonObjectAttribute(string id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonObjectAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonObjectAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000026E4 File Offset: 0x000008E4
		public JsonObjectAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000125 RID: 293 RVA: 0x00016908 File Offset: 0x00014B08
		// (set) Token: 0x06000126 RID: 294 RVA: 0x000026ED File Offset: 0x000008ED
		public unsafe MemberSerialization _memberSerialization
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonObjectAttribute.NativeFieldInfoPtr__memberSerialization);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonObjectAttribute.NativeFieldInfoPtr__memberSerialization)) = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000127 RID: 295 RVA: 0x00016930 File Offset: 0x00014B30
		// (set) Token: 0x06000128 RID: 296 RVA: 0x00002708 File Offset: 0x00000908
		public Nullable<MissingMemberHandling> _missingMemberHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonObjectAttribute.NativeFieldInfoPtr__missingMemberHandling);
				return new Nullable<MissingMemberHandling>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<MissingMemberHandling>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonObjectAttribute.NativeFieldInfoPtr__missingMemberHandling), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<MissingMemberHandling>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000129 RID: 297 RVA: 0x00016960 File Offset: 0x00014B60
		// (set) Token: 0x0600012A RID: 298 RVA: 0x00002736 File Offset: 0x00000936
		public Nullable<Required> _itemRequired
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonObjectAttribute.NativeFieldInfoPtr__itemRequired);
				return new Nullable<Required>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<Required>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonObjectAttribute.NativeFieldInfoPtr__itemRequired), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<Required>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600012B RID: 299 RVA: 0x00016990 File Offset: 0x00014B90
		// (set) Token: 0x0600012C RID: 300 RVA: 0x00002764 File Offset: 0x00000964
		public Nullable<NullValueHandling> _itemNullValueHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonObjectAttribute.NativeFieldInfoPtr__itemNullValueHandling);
				return new Nullable<NullValueHandling>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<NullValueHandling>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonObjectAttribute.NativeFieldInfoPtr__itemNullValueHandling), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<NullValueHandling>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeFieldInfoPtr__memberSerialization;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeFieldInfoPtr__missingMemberHandling;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeFieldInfoPtr__itemRequired;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeFieldInfoPtr__itemNullValueHandling;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberSerialization_Public_get_MemberSerialization_0;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeMethodInfoPtr_set_MemberSerialization_Public_set_Void_MemberSerialization_0;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeMethodInfoPtr_get_MissingMemberHandling_Public_get_MissingMemberHandling_0;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeMethodInfoPtr_set_MissingMemberHandling_Public_set_Void_MissingMemberHandling_0;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemNullValueHandling_Public_get_NullValueHandling_0;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemNullValueHandling_Public_set_Void_NullValueHandling_0;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemRequired_Public_get_Required_0;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemRequired_Public_set_Void_Required_0;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MemberSerialization_0;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
