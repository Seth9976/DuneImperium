using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000E9 RID: 233
	public class StringEnumConverter : JsonConverter
	{
		// Token: 0x0600140A RID: 5130 RVA: 0x0006DF50 File Offset: 0x0006C150
		// Note: this type is marked as 'beforefieldinit'.
		static StringEnumConverter()
		{
			Il2CppClassPointerStore<StringEnumConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Converters", "StringEnumConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringEnumConverter>.NativeClassPtr);
			StringEnumConverter.NativeFieldInfoPtr__NamingStrategy_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringEnumConverter>.NativeClassPtr, "<NamingStrategy>k__BackingField");
			StringEnumConverter.NativeFieldInfoPtr__AllowIntegerValues_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringEnumConverter>.NativeClassPtr, "<AllowIntegerValues>k__BackingField");
			StringEnumConverter.NativeMethodInfoPtr_get_CamelCaseText_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringEnumConverter>.NativeClassPtr, 100667113);
			StringEnumConverter.NativeMethodInfoPtr_set_CamelCaseText_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringEnumConverter>.NativeClassPtr, 100667114);
			StringEnumConverter.NativeMethodInfoPtr_get_NamingStrategy_Public_get_NamingStrategy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringEnumConverter>.NativeClassPtr, 100667115);
			StringEnumConverter.NativeMethodInfoPtr_set_NamingStrategy_Public_set_Void_NamingStrategy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringEnumConverter>.NativeClassPtr, 100667116);
			StringEnumConverter.NativeMethodInfoPtr_get_AllowIntegerValues_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringEnumConverter>.NativeClassPtr, 100667117);
			StringEnumConverter.NativeMethodInfoPtr_set_AllowIntegerValues_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringEnumConverter>.NativeClassPtr, 100667118);
			StringEnumConverter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringEnumConverter>.NativeClassPtr, 100667119);
			StringEnumConverter.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringEnumConverter>.NativeClassPtr, 100667120);
			StringEnumConverter.NativeMethodInfoPtr__ctor_Public_Void_NamingStrategy_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringEnumConverter>.NativeClassPtr, 100667121);
			StringEnumConverter.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringEnumConverter>.NativeClassPtr, 100667122);
			StringEnumConverter.NativeMethodInfoPtr__ctor_Public_Void_Type_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringEnumConverter>.NativeClassPtr, 100667123);
			StringEnumConverter.NativeMethodInfoPtr__ctor_Public_Void_Type_Il2CppReferenceArray_1_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringEnumConverter>.NativeClassPtr, 100667124);
			StringEnumConverter.NativeMethodInfoPtr_WriteJson_Public_Virtual_Void_JsonWriter_Object_JsonSerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringEnumConverter>.NativeClassPtr, 100667125);
			StringEnumConverter.NativeMethodInfoPtr_ReadJson_Public_Virtual_Object_JsonReader_Type_Object_JsonSerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringEnumConverter>.NativeClassPtr, 100667126);
			StringEnumConverter.NativeMethodInfoPtr_CanConvert_Public_Virtual_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringEnumConverter>.NativeClassPtr, 100667127);
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x0600140B RID: 5131 RVA: 0x0006E0D4 File Offset: 0x0006C2D4
		// (set) Token: 0x0600140C RID: 5132 RVA: 0x0006E110 File Offset: 0x0006C310
		public unsafe bool CamelCaseText
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764895, XrefRangeEnd = 764897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringEnumConverter.NativeMethodInfoPtr_get_CamelCaseText_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764897, XrefRangeEnd = 764904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringEnumConverter.NativeMethodInfoPtr_set_CamelCaseText_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x0600140D RID: 5133 RVA: 0x0006E150 File Offset: 0x0006C350
		// (set) Token: 0x0600140E RID: 5134 RVA: 0x0006E190 File Offset: 0x0006C390
		public unsafe NamingStrategy NamingStrategy
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringEnumConverter.NativeMethodInfoPtr_get_NamingStrategy_Public_get_NamingStrategy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NamingStrategy>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringEnumConverter.NativeMethodInfoPtr_set_NamingStrategy_Public_set_Void_NamingStrategy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x0600140F RID: 5135 RVA: 0x0006E1D4 File Offset: 0x0006C3D4
		// (set) Token: 0x06001410 RID: 5136 RVA: 0x0006E210 File Offset: 0x0006C410
		public unsafe bool AllowIntegerValues
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringEnumConverter.NativeMethodInfoPtr_get_AllowIntegerValues_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringEnumConverter.NativeMethodInfoPtr_set_AllowIntegerValues_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001411 RID: 5137 RVA: 0x0006E250 File Offset: 0x0006C450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764904, XrefRangeEnd = 764905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringEnumConverter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringEnumConverter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringEnumConverter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001412 RID: 5138 RVA: 0x0006E28C File Offset: 0x0006C48C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764905, XrefRangeEnd = 764911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringEnumConverter(bool camelCaseText)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringEnumConverter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref camelCaseText;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringEnumConverter.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001413 RID: 5139 RVA: 0x0006E2D4 File Offset: 0x0006C4D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764911, XrefRangeEnd = 764913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringEnumConverter(NamingStrategy namingStrategy, bool allowIntegerValues = true)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringEnumConverter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(namingStrategy);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowIntegerValues;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringEnumConverter.NativeMethodInfoPtr__ctor_Public_Void_NamingStrategy_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001414 RID: 5140 RVA: 0x0006E330 File Offset: 0x0006C530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764913, XrefRangeEnd = 764922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringEnumConverter(Type namingStrategyType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringEnumConverter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(namingStrategyType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringEnumConverter.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001415 RID: 5141 RVA: 0x0006E37C File Offset: 0x0006C57C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764922, XrefRangeEnd = 764931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringEnumConverter(Type namingStrategyType, Il2CppReferenceArray<Object> namingStrategyParameters)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringEnumConverter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(namingStrategyType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(namingStrategyParameters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringEnumConverter.NativeMethodInfoPtr__ctor_Public_Void_Type_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001416 RID: 5142 RVA: 0x0006E3DC File Offset: 0x0006C5DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764931, XrefRangeEnd = 764940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringEnumConverter(Type namingStrategyType, Il2CppReferenceArray<Object> namingStrategyParameters, bool allowIntegerValues)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringEnumConverter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(namingStrategyType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(namingStrategyParameters);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowIntegerValues;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringEnumConverter.NativeMethodInfoPtr__ctor_Public_Void_Type_Il2CppReferenceArray_1_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001417 RID: 5143 RVA: 0x0006E448 File Offset: 0x0006C648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764940, XrefRangeEnd = 764947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteJson(JsonWriter writer, Object value, JsonSerializer serializer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serializer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringEnumConverter.NativeMethodInfoPtr_WriteJson_Public_Virtual_Void_JsonWriter_Object_JsonSerializer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001418 RID: 5144 RVA: 0x0006E4BC File Offset: 0x0006C6BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764947, XrefRangeEnd = 764968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ReadJson(JsonReader reader, Type objectType, Object existingValue, JsonSerializer serializer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(existingValue);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serializer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringEnumConverter.NativeMethodInfoPtr_ReadJson_Public_Virtual_Object_JsonReader_Type_Object_JsonSerializer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001419 RID: 5145 RVA: 0x0006E550 File Offset: 0x0006C750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764968, XrefRangeEnd = 764974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanConvert(Type objectType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringEnumConverter.NativeMethodInfoPtr_CanConvert_Public_Virtual_Boolean_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600141A RID: 5146 RVA: 0x00008252 File Offset: 0x00006452
		public StringEnumConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x0600141B RID: 5147 RVA: 0x0006E5A8 File Offset: 0x0006C7A8
		// (set) Token: 0x0600141C RID: 5148 RVA: 0x0000825B File Offset: 0x0000645B
		public unsafe NamingStrategy _NamingStrategy_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringEnumConverter.NativeFieldInfoPtr__NamingStrategy_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NamingStrategy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringEnumConverter.NativeFieldInfoPtr__NamingStrategy_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x0600141D RID: 5149 RVA: 0x0006E5D8 File Offset: 0x0006C7D8
		// (set) Token: 0x0600141E RID: 5150 RVA: 0x0000827A File Offset: 0x0000647A
		public unsafe bool _AllowIntegerValues_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringEnumConverter.NativeFieldInfoPtr__AllowIntegerValues_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringEnumConverter.NativeFieldInfoPtr__AllowIntegerValues_k__BackingField)) = value;
			}
		}

		// Token: 0x0400103C RID: 4156
		private static readonly IntPtr NativeFieldInfoPtr__NamingStrategy_k__BackingField;

		// Token: 0x0400103D RID: 4157
		private static readonly IntPtr NativeFieldInfoPtr__AllowIntegerValues_k__BackingField;

		// Token: 0x0400103E RID: 4158
		private static readonly IntPtr NativeMethodInfoPtr_get_CamelCaseText_Public_get_Boolean_0;

		// Token: 0x0400103F RID: 4159
		private static readonly IntPtr NativeMethodInfoPtr_set_CamelCaseText_Public_set_Void_Boolean_0;

		// Token: 0x04001040 RID: 4160
		private static readonly IntPtr NativeMethodInfoPtr_get_NamingStrategy_Public_get_NamingStrategy_0;

		// Token: 0x04001041 RID: 4161
		private static readonly IntPtr NativeMethodInfoPtr_set_NamingStrategy_Public_set_Void_NamingStrategy_0;

		// Token: 0x04001042 RID: 4162
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowIntegerValues_Public_get_Boolean_0;

		// Token: 0x04001043 RID: 4163
		private static readonly IntPtr NativeMethodInfoPtr_set_AllowIntegerValues_Public_set_Void_Boolean_0;

		// Token: 0x04001044 RID: 4164
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001045 RID: 4165
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04001046 RID: 4166
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NamingStrategy_Boolean_0;

		// Token: 0x04001047 RID: 4167
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;

		// Token: 0x04001048 RID: 4168
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04001049 RID: 4169
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_Il2CppReferenceArray_1_Object_Boolean_0;

		// Token: 0x0400104A RID: 4170
		private static readonly IntPtr NativeMethodInfoPtr_WriteJson_Public_Virtual_Void_JsonWriter_Object_JsonSerializer_0;

		// Token: 0x0400104B RID: 4171
		private static readonly IntPtr NativeMethodInfoPtr_ReadJson_Public_Virtual_Object_JsonReader_Type_Object_JsonSerializer_0;

		// Token: 0x0400104C RID: 4172
		private static readonly IntPtr NativeMethodInfoPtr_CanConvert_Public_Virtual_Boolean_Type_0;
	}
}
