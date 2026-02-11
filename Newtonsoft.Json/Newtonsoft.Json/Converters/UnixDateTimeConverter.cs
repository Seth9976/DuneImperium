using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000EA RID: 234
	public class UnixDateTimeConverter : DateTimeConverterBase
	{
		// Token: 0x0600141F RID: 5151 RVA: 0x0006E600 File Offset: 0x0006C800
		// Note: this type is marked as 'beforefieldinit'.
		static UnixDateTimeConverter()
		{
			Il2CppClassPointerStore<UnixDateTimeConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Converters", "UnixDateTimeConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnixDateTimeConverter>.NativeClassPtr);
			UnixDateTimeConverter.NativeFieldInfoPtr_UnixEpoch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnixDateTimeConverter>.NativeClassPtr, "UnixEpoch");
			UnixDateTimeConverter.NativeFieldInfoPtr__AllowPreEpoch_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnixDateTimeConverter>.NativeClassPtr, "<AllowPreEpoch>k__BackingField");
			UnixDateTimeConverter.NativeMethodInfoPtr_get_AllowPreEpoch_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnixDateTimeConverter>.NativeClassPtr, 100667128);
			UnixDateTimeConverter.NativeMethodInfoPtr_set_AllowPreEpoch_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnixDateTimeConverter>.NativeClassPtr, 100667129);
			UnixDateTimeConverter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnixDateTimeConverter>.NativeClassPtr, 100667130);
			UnixDateTimeConverter.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnixDateTimeConverter>.NativeClassPtr, 100667131);
			UnixDateTimeConverter.NativeMethodInfoPtr_WriteJson_Public_Virtual_Void_JsonWriter_Object_JsonSerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnixDateTimeConverter>.NativeClassPtr, 100667132);
			UnixDateTimeConverter.NativeMethodInfoPtr_ReadJson_Public_Virtual_Object_JsonReader_Type_Object_JsonSerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnixDateTimeConverter>.NativeClassPtr, 100667133);
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06001420 RID: 5152 RVA: 0x0006E6D0 File Offset: 0x0006C8D0
		// (set) Token: 0x06001421 RID: 5153 RVA: 0x0006E70C File Offset: 0x0006C90C
		public unsafe bool AllowPreEpoch
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnixDateTimeConverter.NativeMethodInfoPtr_get_AllowPreEpoch_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 288083, RefRangeEnd = 288084, XrefRangeStart = 288083, XrefRangeEnd = 288084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnixDateTimeConverter.NativeMethodInfoPtr_set_AllowPreEpoch_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001422 RID: 5154 RVA: 0x0006E74C File Offset: 0x0006C94C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764974, XrefRangeEnd = 764975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnixDateTimeConverter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnixDateTimeConverter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnixDateTimeConverter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001423 RID: 5155 RVA: 0x0006E788 File Offset: 0x0006C988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764975, XrefRangeEnd = 764976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnixDateTimeConverter(bool allowPreEpoch)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnixDateTimeConverter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref allowPreEpoch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnixDateTimeConverter.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001424 RID: 5156 RVA: 0x0006E7D0 File Offset: 0x0006C9D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764976, XrefRangeEnd = 765003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnixDateTimeConverter.NativeMethodInfoPtr_WriteJson_Public_Virtual_Void_JsonWriter_Object_JsonSerializer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001425 RID: 5157 RVA: 0x0006E844 File Offset: 0x0006CA44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765003, XrefRangeEnd = 765034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnixDateTimeConverter.NativeMethodInfoPtr_ReadJson_Public_Virtual_Object_JsonReader_Type_Object_JsonSerializer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001426 RID: 5158 RVA: 0x00008295 File Offset: 0x00006495
		public UnixDateTimeConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06001427 RID: 5159 RVA: 0x0006E8D8 File Offset: 0x0006CAD8
		// (set) Token: 0x06001428 RID: 5160 RVA: 0x0000829E File Offset: 0x0000649E
		public unsafe static DateTime UnixEpoch
		{
			get
			{
				DateTime dateTime;
				IL2CPP.il2cpp_field_static_get_value(UnixDateTimeConverter.NativeFieldInfoPtr_UnixEpoch, (void*)(&dateTime));
				return dateTime;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnixDateTimeConverter.NativeFieldInfoPtr_UnixEpoch, (void*)(&value));
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06001429 RID: 5161 RVA: 0x0006E8F4 File Offset: 0x0006CAF4
		// (set) Token: 0x0600142A RID: 5162 RVA: 0x000082AC File Offset: 0x000064AC
		public unsafe bool _AllowPreEpoch_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnixDateTimeConverter.NativeFieldInfoPtr__AllowPreEpoch_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnixDateTimeConverter.NativeFieldInfoPtr__AllowPreEpoch_k__BackingField)) = value;
			}
		}

		// Token: 0x0400104D RID: 4173
		private static readonly IntPtr NativeFieldInfoPtr_UnixEpoch;

		// Token: 0x0400104E RID: 4174
		private static readonly IntPtr NativeFieldInfoPtr__AllowPreEpoch_k__BackingField;

		// Token: 0x0400104F RID: 4175
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowPreEpoch_Public_get_Boolean_0;

		// Token: 0x04001050 RID: 4176
		private static readonly IntPtr NativeMethodInfoPtr_set_AllowPreEpoch_Public_set_Void_Boolean_0;

		// Token: 0x04001051 RID: 4177
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001052 RID: 4178
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04001053 RID: 4179
		private static readonly IntPtr NativeMethodInfoPtr_WriteJson_Public_Virtual_Void_JsonWriter_Object_JsonSerializer_0;

		// Token: 0x04001054 RID: 4180
		private static readonly IntPtr NativeMethodInfoPtr_ReadJson_Public_Virtual_Object_JsonReader_Type_Object_JsonSerializer_0;
	}
}
