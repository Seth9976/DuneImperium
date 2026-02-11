using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000DD RID: 221
	public class BsonObjectIdConverter : JsonConverter
	{
		// Token: 0x06001389 RID: 5001 RVA: 0x0006BA98 File Offset: 0x00069C98
		// Note: this type is marked as 'beforefieldinit'.
		static BsonObjectIdConverter()
		{
			Il2CppClassPointerStore<BsonObjectIdConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Converters", "BsonObjectIdConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BsonObjectIdConverter>.NativeClassPtr);
			BsonObjectIdConverter.NativeMethodInfoPtr_WriteJson_Public_Virtual_Void_JsonWriter_Object_JsonSerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonObjectIdConverter>.NativeClassPtr, 100667036);
			BsonObjectIdConverter.NativeMethodInfoPtr_ReadJson_Public_Virtual_Object_JsonReader_Type_Object_JsonSerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonObjectIdConverter>.NativeClassPtr, 100667037);
			BsonObjectIdConverter.NativeMethodInfoPtr_CanConvert_Public_Virtual_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonObjectIdConverter>.NativeClassPtr, 100667038);
			BsonObjectIdConverter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonObjectIdConverter>.NativeClassPtr, 100667039);
		}

		// Token: 0x0600138A RID: 5002 RVA: 0x0006BB18 File Offset: 0x00069D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763830, XrefRangeEnd = 763839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BsonObjectIdConverter.NativeMethodInfoPtr_WriteJson_Public_Virtual_Void_JsonWriter_Object_JsonSerializer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600138B RID: 5003 RVA: 0x0006BB8C File Offset: 0x00069D8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763839, XrefRangeEnd = 763847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BsonObjectIdConverter.NativeMethodInfoPtr_ReadJson_Public_Virtual_Object_JsonReader_Type_Object_JsonSerializer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600138C RID: 5004 RVA: 0x0006BC20 File Offset: 0x00069E20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763847, XrefRangeEnd = 763854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanConvert(Type objectType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BsonObjectIdConverter.NativeMethodInfoPtr_CanConvert_Public_Virtual_Boolean_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600138D RID: 5005 RVA: 0x0006BC78 File Offset: 0x00069E78
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BsonObjectIdConverter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BsonObjectIdConverter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonObjectIdConverter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600138E RID: 5006 RVA: 0x0000807F File Offset: 0x0000627F
		public BsonObjectIdConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000FE5 RID: 4069
		private static readonly IntPtr NativeMethodInfoPtr_WriteJson_Public_Virtual_Void_JsonWriter_Object_JsonSerializer_0;

		// Token: 0x04000FE6 RID: 4070
		private static readonly IntPtr NativeMethodInfoPtr_ReadJson_Public_Virtual_Object_JsonReader_Type_Object_JsonSerializer_0;

		// Token: 0x04000FE7 RID: 4071
		private static readonly IntPtr NativeMethodInfoPtr_CanConvert_Public_Virtual_Boolean_Type_0;

		// Token: 0x04000FE8 RID: 4072
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
