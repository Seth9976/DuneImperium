using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Globalization;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000E5 RID: 229
	public class IsoDateTimeConverter : DateTimeConverterBase
	{
		// Token: 0x060013D5 RID: 5077 RVA: 0x0006D0E0 File Offset: 0x0006B2E0
		// Note: this type is marked as 'beforefieldinit'.
		static IsoDateTimeConverter()
		{
			Il2CppClassPointerStore<IsoDateTimeConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Converters", "IsoDateTimeConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IsoDateTimeConverter>.NativeClassPtr);
			IsoDateTimeConverter.NativeFieldInfoPtr_DefaultDateTimeFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IsoDateTimeConverter>.NativeClassPtr, "DefaultDateTimeFormat");
			IsoDateTimeConverter.NativeFieldInfoPtr__dateTimeStyles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IsoDateTimeConverter>.NativeClassPtr, "_dateTimeStyles");
			IsoDateTimeConverter.NativeFieldInfoPtr__dateTimeFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IsoDateTimeConverter>.NativeClassPtr, "_dateTimeFormat");
			IsoDateTimeConverter.NativeFieldInfoPtr__culture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IsoDateTimeConverter>.NativeClassPtr, "_culture");
			IsoDateTimeConverter.NativeMethodInfoPtr_get_DateTimeStyles_Public_get_DateTimeStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsoDateTimeConverter>.NativeClassPtr, 100667085);
			IsoDateTimeConverter.NativeMethodInfoPtr_set_DateTimeStyles_Public_set_Void_DateTimeStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsoDateTimeConverter>.NativeClassPtr, 100667086);
			IsoDateTimeConverter.NativeMethodInfoPtr_get_DateTimeFormat_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsoDateTimeConverter>.NativeClassPtr, 100667087);
			IsoDateTimeConverter.NativeMethodInfoPtr_set_DateTimeFormat_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsoDateTimeConverter>.NativeClassPtr, 100667088);
			IsoDateTimeConverter.NativeMethodInfoPtr_get_Culture_Public_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsoDateTimeConverter>.NativeClassPtr, 100667089);
			IsoDateTimeConverter.NativeMethodInfoPtr_set_Culture_Public_set_Void_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsoDateTimeConverter>.NativeClassPtr, 100667090);
			IsoDateTimeConverter.NativeMethodInfoPtr_WriteJson_Public_Virtual_Void_JsonWriter_Object_JsonSerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsoDateTimeConverter>.NativeClassPtr, 100667091);
			IsoDateTimeConverter.NativeMethodInfoPtr_ReadJson_Public_Virtual_Object_JsonReader_Type_Object_JsonSerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsoDateTimeConverter>.NativeClassPtr, 100667092);
			IsoDateTimeConverter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsoDateTimeConverter>.NativeClassPtr, 100667093);
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x060013D6 RID: 5078 RVA: 0x0006D214 File Offset: 0x0006B414
		// (set) Token: 0x060013D7 RID: 5079 RVA: 0x0006D250 File Offset: 0x0006B450
		public unsafe DateTimeStyles DateTimeStyles
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IsoDateTimeConverter.NativeMethodInfoPtr_get_DateTimeStyles_Public_get_DateTimeStyles_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 307807, RefRangeEnd = 307812, XrefRangeStart = 307807, XrefRangeEnd = 307812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IsoDateTimeConverter.NativeMethodInfoPtr_set_DateTimeStyles_Public_set_Void_DateTimeStyles_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x060013D8 RID: 5080 RVA: 0x0006D290 File Offset: 0x0006B490
		// (set) Token: 0x060013D9 RID: 5081 RVA: 0x0006D2C8 File Offset: 0x0006B4C8
		public unsafe string DateTimeFormat
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764541, XrefRangeEnd = 764543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IsoDateTimeConverter.NativeMethodInfoPtr_get_DateTimeFormat_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764543, XrefRangeEnd = 764546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IsoDateTimeConverter.NativeMethodInfoPtr_set_DateTimeFormat_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x060013DA RID: 5082 RVA: 0x0006D30C File Offset: 0x0006B50C
		// (set) Token: 0x060013DB RID: 5083 RVA: 0x0006D34C File Offset: 0x0006B54C
		public unsafe CultureInfo Culture
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 764550, RefRangeEnd = 764554, XrefRangeStart = 764546, XrefRangeEnd = 764550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IsoDateTimeConverter.NativeMethodInfoPtr_get_Culture_Public_get_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IsoDateTimeConverter.NativeMethodInfoPtr_set_Culture_Public_set_Void_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060013DC RID: 5084 RVA: 0x0006D390 File Offset: 0x0006B590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764554, XrefRangeEnd = 764584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IsoDateTimeConverter.NativeMethodInfoPtr_WriteJson_Public_Virtual_Void_JsonWriter_Object_JsonSerializer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013DD RID: 5085 RVA: 0x0006D404 File Offset: 0x0006B604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764584, XrefRangeEnd = 764625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IsoDateTimeConverter.NativeMethodInfoPtr_ReadJson_Public_Virtual_Object_JsonReader_Type_Object_JsonSerializer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060013DE RID: 5086 RVA: 0x0006D498 File Offset: 0x0006B698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764625, XrefRangeEnd = 764626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IsoDateTimeConverter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IsoDateTimeConverter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IsoDateTimeConverter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013DF RID: 5087 RVA: 0x00008169 File Offset: 0x00006369
		public IsoDateTimeConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x060013E0 RID: 5088 RVA: 0x0006D4D4 File Offset: 0x0006B6D4
		// (set) Token: 0x060013E1 RID: 5089 RVA: 0x00008172 File Offset: 0x00006372
		public unsafe static string DefaultDateTimeFormat
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IsoDateTimeConverter.NativeFieldInfoPtr_DefaultDateTimeFormat, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IsoDateTimeConverter.NativeFieldInfoPtr_DefaultDateTimeFormat, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x060013E2 RID: 5090 RVA: 0x0006D4F4 File Offset: 0x0006B6F4
		// (set) Token: 0x060013E3 RID: 5091 RVA: 0x00008184 File Offset: 0x00006384
		public unsafe DateTimeStyles _dateTimeStyles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IsoDateTimeConverter.NativeFieldInfoPtr__dateTimeStyles);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IsoDateTimeConverter.NativeFieldInfoPtr__dateTimeStyles)) = value;
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x060013E4 RID: 5092 RVA: 0x0006D51C File Offset: 0x0006B71C
		// (set) Token: 0x060013E5 RID: 5093 RVA: 0x0000819F File Offset: 0x0000639F
		public unsafe string _dateTimeFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IsoDateTimeConverter.NativeFieldInfoPtr__dateTimeFormat);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IsoDateTimeConverter.NativeFieldInfoPtr__dateTimeFormat), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x060013E6 RID: 5094 RVA: 0x0006D544 File Offset: 0x0006B744
		// (set) Token: 0x060013E7 RID: 5095 RVA: 0x000081BE File Offset: 0x000063BE
		public unsafe CultureInfo _culture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IsoDateTimeConverter.NativeFieldInfoPtr__culture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IsoDateTimeConverter.NativeFieldInfoPtr__culture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001018 RID: 4120
		private static readonly IntPtr NativeFieldInfoPtr_DefaultDateTimeFormat;

		// Token: 0x04001019 RID: 4121
		private static readonly IntPtr NativeFieldInfoPtr__dateTimeStyles;

		// Token: 0x0400101A RID: 4122
		private static readonly IntPtr NativeFieldInfoPtr__dateTimeFormat;

		// Token: 0x0400101B RID: 4123
		private static readonly IntPtr NativeFieldInfoPtr__culture;

		// Token: 0x0400101C RID: 4124
		private static readonly IntPtr NativeMethodInfoPtr_get_DateTimeStyles_Public_get_DateTimeStyles_0;

		// Token: 0x0400101D RID: 4125
		private static readonly IntPtr NativeMethodInfoPtr_set_DateTimeStyles_Public_set_Void_DateTimeStyles_0;

		// Token: 0x0400101E RID: 4126
		private static readonly IntPtr NativeMethodInfoPtr_get_DateTimeFormat_Public_get_String_0;

		// Token: 0x0400101F RID: 4127
		private static readonly IntPtr NativeMethodInfoPtr_set_DateTimeFormat_Public_set_Void_String_0;

		// Token: 0x04001020 RID: 4128
		private static readonly IntPtr NativeMethodInfoPtr_get_Culture_Public_get_CultureInfo_0;

		// Token: 0x04001021 RID: 4129
		private static readonly IntPtr NativeMethodInfoPtr_set_Culture_Public_set_Void_CultureInfo_0;

		// Token: 0x04001022 RID: 4130
		private static readonly IntPtr NativeMethodInfoPtr_WriteJson_Public_Virtual_Void_JsonWriter_Object_JsonSerializer_0;

		// Token: 0x04001023 RID: 4131
		private static readonly IntPtr NativeMethodInfoPtr_ReadJson_Public_Virtual_Object_JsonReader_Type_Object_JsonSerializer_0;

		// Token: 0x04001024 RID: 4132
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
