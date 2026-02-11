using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text.RegularExpressions;
using Newtonsoft.Json.Bson;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000E8 RID: 232
	public class RegexConverter : JsonConverter
	{
		// Token: 0x060013FA RID: 5114 RVA: 0x0006DA3C File Offset: 0x0006BC3C
		// Note: this type is marked as 'beforefieldinit'.
		static RegexConverter()
		{
			Il2CppClassPointerStore<RegexConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Converters", "RegexConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexConverter>.NativeClassPtr);
			RegexConverter.NativeFieldInfoPtr_PatternName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexConverter>.NativeClassPtr, "PatternName");
			RegexConverter.NativeFieldInfoPtr_OptionsName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexConverter>.NativeClassPtr, "OptionsName");
			RegexConverter.NativeMethodInfoPtr_WriteJson_Public_Virtual_Void_JsonWriter_Object_JsonSerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexConverter>.NativeClassPtr, 100667103);
			RegexConverter.NativeMethodInfoPtr_HasFlag_Private_Boolean_RegexOptions_RegexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexConverter>.NativeClassPtr, 100667104);
			RegexConverter.NativeMethodInfoPtr_WriteBson_Private_Void_BsonWriter_Regex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexConverter>.NativeClassPtr, 100667105);
			RegexConverter.NativeMethodInfoPtr_WriteJson_Private_Void_JsonWriter_Regex_JsonSerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexConverter>.NativeClassPtr, 100667106);
			RegexConverter.NativeMethodInfoPtr_ReadJson_Public_Virtual_Object_JsonReader_Type_Object_JsonSerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexConverter>.NativeClassPtr, 100667107);
			RegexConverter.NativeMethodInfoPtr_ReadRegexString_Private_Object_JsonReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexConverter>.NativeClassPtr, 100667108);
			RegexConverter.NativeMethodInfoPtr_ReadRegexObject_Private_Regex_JsonReader_JsonSerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexConverter>.NativeClassPtr, 100667109);
			RegexConverter.NativeMethodInfoPtr_CanConvert_Public_Virtual_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexConverter>.NativeClassPtr, 100667110);
			RegexConverter.NativeMethodInfoPtr_IsRegex_Private_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexConverter>.NativeClassPtr, 100667111);
			RegexConverter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexConverter>.NativeClassPtr, 100667112);
		}

		// Token: 0x060013FB RID: 5115 RVA: 0x0006DB5C File Offset: 0x0006BD5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764786, XrefRangeEnd = 764807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegexConverter.NativeMethodInfoPtr_WriteJson_Public_Virtual_Void_JsonWriter_Object_JsonSerializer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013FC RID: 5116 RVA: 0x0006DBD0 File Offset: 0x0006BDD0
		[CallerCount(0)]
		public unsafe bool HasFlag(RegexOptions options, RegexOptions flag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref options;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flag;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexConverter.NativeMethodInfoPtr_HasFlag_Private_Boolean_RegexOptions_RegexOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013FD RID: 5117 RVA: 0x0006DC28 File Offset: 0x0006BE28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764807, XrefRangeEnd = 764824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteBson(BsonWriter writer, Regex regex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(regex);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexConverter.NativeMethodInfoPtr_WriteBson_Private_Void_BsonWriter_Regex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x0006DC7C File Offset: 0x0006BE7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764824, XrefRangeEnd = 764838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteJson(JsonWriter writer, Regex regex, JsonSerializer serializer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(regex);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serializer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexConverter.NativeMethodInfoPtr_WriteJson_Private_Void_JsonWriter_Regex_JsonSerializer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013FF RID: 5119 RVA: 0x0006DCE4 File Offset: 0x0006BEE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764838, XrefRangeEnd = 764850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegexConverter.NativeMethodInfoPtr_ReadJson_Public_Virtual_Object_JsonReader_Type_Object_JsonSerializer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x0006DD78 File Offset: 0x0006BF78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764850, XrefRangeEnd = 764861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ReadRegexString(JsonReader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexConverter.NativeMethodInfoPtr_ReadRegexString_Private_Object_JsonReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001401 RID: 5121 RVA: 0x0006DDC8 File Offset: 0x0006BFC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 764884, RefRangeEnd = 764885, XrefRangeStart = 764861, XrefRangeEnd = 764884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Regex ReadRegexObject(JsonReader reader, JsonSerializer serializer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serializer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexConverter.NativeMethodInfoPtr_ReadRegexObject_Private_Regex_JsonReader_JsonSerializer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Regex>(intPtr3) : null;
		}

		// Token: 0x06001402 RID: 5122 RVA: 0x0006DE2C File Offset: 0x0006C02C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764885, XrefRangeEnd = 764888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanConvert(Type objectType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegexConverter.NativeMethodInfoPtr_CanConvert_Public_Virtual_Boolean_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001403 RID: 5123 RVA: 0x0006DE84 File Offset: 0x0006C084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764888, XrefRangeEnd = 764895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsRegex(Type objectType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexConverter.NativeMethodInfoPtr_IsRegex_Private_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001404 RID: 5124 RVA: 0x0006DED4 File Offset: 0x0006C0D4
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexConverter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexConverter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexConverter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001405 RID: 5125 RVA: 0x00008225 File Offset: 0x00006425
		public RegexConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06001406 RID: 5126 RVA: 0x0006DF10 File Offset: 0x0006C110
		// (set) Token: 0x06001407 RID: 5127 RVA: 0x0000822E File Offset: 0x0000642E
		public unsafe static string PatternName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegexConverter.NativeFieldInfoPtr_PatternName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexConverter.NativeFieldInfoPtr_PatternName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06001408 RID: 5128 RVA: 0x0006DF30 File Offset: 0x0006C130
		// (set) Token: 0x06001409 RID: 5129 RVA: 0x00008240 File Offset: 0x00006440
		public unsafe static string OptionsName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegexConverter.NativeFieldInfoPtr_OptionsName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexConverter.NativeFieldInfoPtr_OptionsName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001030 RID: 4144
		private static readonly IntPtr NativeFieldInfoPtr_PatternName;

		// Token: 0x04001031 RID: 4145
		private static readonly IntPtr NativeFieldInfoPtr_OptionsName;

		// Token: 0x04001032 RID: 4146
		private static readonly IntPtr NativeMethodInfoPtr_WriteJson_Public_Virtual_Void_JsonWriter_Object_JsonSerializer_0;

		// Token: 0x04001033 RID: 4147
		private static readonly IntPtr NativeMethodInfoPtr_HasFlag_Private_Boolean_RegexOptions_RegexOptions_0;

		// Token: 0x04001034 RID: 4148
		private static readonly IntPtr NativeMethodInfoPtr_WriteBson_Private_Void_BsonWriter_Regex_0;

		// Token: 0x04001035 RID: 4149
		private static readonly IntPtr NativeMethodInfoPtr_WriteJson_Private_Void_JsonWriter_Regex_JsonSerializer_0;

		// Token: 0x04001036 RID: 4150
		private static readonly IntPtr NativeMethodInfoPtr_ReadJson_Public_Virtual_Object_JsonReader_Type_Object_JsonSerializer_0;

		// Token: 0x04001037 RID: 4151
		private static readonly IntPtr NativeMethodInfoPtr_ReadRegexString_Private_Object_JsonReader_0;

		// Token: 0x04001038 RID: 4152
		private static readonly IntPtr NativeMethodInfoPtr_ReadRegexObject_Private_Regex_JsonReader_JsonSerializer_0;

		// Token: 0x04001039 RID: 4153
		private static readonly IntPtr NativeMethodInfoPtr_CanConvert_Public_Virtual_Boolean_Type_0;

		// Token: 0x0400103A RID: 4154
		private static readonly IntPtr NativeMethodInfoPtr_IsRegex_Private_Boolean_Type_0;

		// Token: 0x0400103B RID: 4155
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
