using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000DC RID: 220
	public class BinaryConverter : JsonConverter
	{
		// Token: 0x0600137A RID: 4986 RVA: 0x0006B6C4 File Offset: 0x000698C4
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryConverter()
		{
			Il2CppClassPointerStore<BinaryConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Converters", "BinaryConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryConverter>.NativeClassPtr);
			BinaryConverter.NativeFieldInfoPtr_BinaryTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryConverter>.NativeClassPtr, "BinaryTypeName");
			BinaryConverter.NativeFieldInfoPtr_BinaryToArrayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryConverter>.NativeClassPtr, "BinaryToArrayName");
			BinaryConverter.NativeFieldInfoPtr__reflectionObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryConverter>.NativeClassPtr, "_reflectionObject");
			BinaryConverter.NativeMethodInfoPtr_WriteJson_Public_Virtual_Void_JsonWriter_Object_JsonSerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryConverter>.NativeClassPtr, 100667029);
			BinaryConverter.NativeMethodInfoPtr_GetByteArray_Private_Il2CppStructArray_1_Byte_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryConverter>.NativeClassPtr, 100667030);
			BinaryConverter.NativeMethodInfoPtr_EnsureReflectionObject_Private_Static_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryConverter>.NativeClassPtr, 100667031);
			BinaryConverter.NativeMethodInfoPtr_ReadJson_Public_Virtual_Object_JsonReader_Type_Object_JsonSerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryConverter>.NativeClassPtr, 100667032);
			BinaryConverter.NativeMethodInfoPtr_ReadByteArray_Private_Il2CppStructArray_1_Byte_JsonReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryConverter>.NativeClassPtr, 100667033);
			BinaryConverter.NativeMethodInfoPtr_CanConvert_Public_Virtual_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryConverter>.NativeClassPtr, 100667034);
			BinaryConverter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryConverter>.NativeClassPtr, 100667035);
		}

		// Token: 0x0600137B RID: 4987 RVA: 0x0006B7BC File Offset: 0x000699BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763707, XrefRangeEnd = 763709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryConverter.NativeMethodInfoPtr_WriteJson_Public_Virtual_Void_JsonWriter_Object_JsonSerializer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600137C RID: 4988 RVA: 0x0006B830 File Offset: 0x00069A30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 763722, RefRangeEnd = 763723, XrefRangeStart = 763709, XrefRangeEnd = 763722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetByteArray(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryConverter.NativeMethodInfoPtr_GetByteArray_Private_Il2CppStructArray_1_Byte_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x0600137D RID: 4989 RVA: 0x0006B880 File Offset: 0x00069A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763723, XrefRangeEnd = 763747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EnsureReflectionObject(Type t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryConverter.NativeMethodInfoPtr_EnsureReflectionObject_Private_Static_Void_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600137E RID: 4990 RVA: 0x0006B8B8 File Offset: 0x00069AB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763747, XrefRangeEnd = 763775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryConverter.NativeMethodInfoPtr_ReadJson_Public_Virtual_Object_JsonReader_Type_Object_JsonSerializer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600137F RID: 4991 RVA: 0x0006B94C File Offset: 0x00069B4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 763813, RefRangeEnd = 763814, XrefRangeStart = 763775, XrefRangeEnd = 763813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> ReadByteArray(JsonReader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryConverter.NativeMethodInfoPtr_ReadByteArray_Private_Il2CppStructArray_1_Byte_JsonReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06001380 RID: 4992 RVA: 0x0006B99C File Offset: 0x00069B9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763814, XrefRangeEnd = 763830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanConvert(Type objectType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryConverter.NativeMethodInfoPtr_CanConvert_Public_Virtual_Boolean_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001381 RID: 4993 RVA: 0x0006B9F4 File Offset: 0x00069BF4
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryConverter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryConverter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryConverter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001382 RID: 4994 RVA: 0x00008040 File Offset: 0x00006240
		public BinaryConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06001383 RID: 4995 RVA: 0x0006BA30 File Offset: 0x00069C30
		// (set) Token: 0x06001384 RID: 4996 RVA: 0x00008049 File Offset: 0x00006249
		public unsafe static string BinaryTypeName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BinaryConverter.NativeFieldInfoPtr_BinaryTypeName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BinaryConverter.NativeFieldInfoPtr_BinaryTypeName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06001385 RID: 4997 RVA: 0x0006BA50 File Offset: 0x00069C50
		// (set) Token: 0x06001386 RID: 4998 RVA: 0x0000805B File Offset: 0x0000625B
		public unsafe static string BinaryToArrayName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BinaryConverter.NativeFieldInfoPtr_BinaryToArrayName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BinaryConverter.NativeFieldInfoPtr_BinaryToArrayName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06001387 RID: 4999 RVA: 0x0006BA70 File Offset: 0x00069C70
		// (set) Token: 0x06001388 RID: 5000 RVA: 0x0000806D File Offset: 0x0000626D
		public unsafe static ReflectionObject _reflectionObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BinaryConverter.NativeFieldInfoPtr__reflectionObject, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReflectionObject>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BinaryConverter.NativeFieldInfoPtr__reflectionObject, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000FDB RID: 4059
		private static readonly IntPtr NativeFieldInfoPtr_BinaryTypeName;

		// Token: 0x04000FDC RID: 4060
		private static readonly IntPtr NativeFieldInfoPtr_BinaryToArrayName;

		// Token: 0x04000FDD RID: 4061
		private static readonly IntPtr NativeFieldInfoPtr__reflectionObject;

		// Token: 0x04000FDE RID: 4062
		private static readonly IntPtr NativeMethodInfoPtr_WriteJson_Public_Virtual_Void_JsonWriter_Object_JsonSerializer_0;

		// Token: 0x04000FDF RID: 4063
		private static readonly IntPtr NativeMethodInfoPtr_GetByteArray_Private_Il2CppStructArray_1_Byte_Object_0;

		// Token: 0x04000FE0 RID: 4064
		private static readonly IntPtr NativeMethodInfoPtr_EnsureReflectionObject_Private_Static_Void_Type_0;

		// Token: 0x04000FE1 RID: 4065
		private static readonly IntPtr NativeMethodInfoPtr_ReadJson_Public_Virtual_Object_JsonReader_Type_Object_JsonSerializer_0;

		// Token: 0x04000FE2 RID: 4066
		private static readonly IntPtr NativeMethodInfoPtr_ReadByteArray_Private_Il2CppStructArray_1_Byte_JsonReader_0;

		// Token: 0x04000FE3 RID: 4067
		private static readonly IntPtr NativeMethodInfoPtr_CanConvert_Public_Virtual_Boolean_Type_0;

		// Token: 0x04000FE4 RID: 4068
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
