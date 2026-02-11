using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000E7 RID: 231
	public class KeyValuePairConverter : JsonConverter
	{
		// Token: 0x060013ED RID: 5101 RVA: 0x0006D724 File Offset: 0x0006B924
		// Note: this type is marked as 'beforefieldinit'.
		static KeyValuePairConverter()
		{
			Il2CppClassPointerStore<KeyValuePairConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Converters", "KeyValuePairConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyValuePairConverter>.NativeClassPtr);
			KeyValuePairConverter.NativeFieldInfoPtr_KeyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyValuePairConverter>.NativeClassPtr, "KeyName");
			KeyValuePairConverter.NativeFieldInfoPtr_ValueName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyValuePairConverter>.NativeClassPtr, "ValueName");
			KeyValuePairConverter.NativeFieldInfoPtr_ReflectionObjectPerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyValuePairConverter>.NativeClassPtr, "ReflectionObjectPerType");
			KeyValuePairConverter.NativeMethodInfoPtr_InitializeReflectionObject_Private_Static_ReflectionObject_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyValuePairConverter>.NativeClassPtr, 100667097);
			KeyValuePairConverter.NativeMethodInfoPtr_WriteJson_Public_Virtual_Void_JsonWriter_Object_JsonSerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyValuePairConverter>.NativeClassPtr, 100667098);
			KeyValuePairConverter.NativeMethodInfoPtr_ReadJson_Public_Virtual_Object_JsonReader_Type_Object_JsonSerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyValuePairConverter>.NativeClassPtr, 100667099);
			KeyValuePairConverter.NativeMethodInfoPtr_CanConvert_Public_Virtual_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyValuePairConverter>.NativeClassPtr, 100667100);
			KeyValuePairConverter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyValuePairConverter>.NativeClassPtr, 100667101);
		}

		// Token: 0x060013EE RID: 5102 RVA: 0x0006D7F4 File Offset: 0x0006B9F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764669, XrefRangeEnd = 764698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ReflectionObject InitializeReflectionObject(Type t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyValuePairConverter.NativeMethodInfoPtr_InitializeReflectionObject_Private_Static_ReflectionObject_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReflectionObject>(intPtr3) : null;
			}
		}

		// Token: 0x060013EF RID: 5103 RVA: 0x0006D838 File Offset: 0x0006BA38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764698, XrefRangeEnd = 764726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeyValuePairConverter.NativeMethodInfoPtr_WriteJson_Public_Virtual_Void_JsonWriter_Object_JsonSerializer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013F0 RID: 5104 RVA: 0x0006D8AC File Offset: 0x0006BAAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764726, XrefRangeEnd = 764772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeyValuePairConverter.NativeMethodInfoPtr_ReadJson_Public_Virtual_Object_JsonReader_Type_Object_JsonSerializer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060013F1 RID: 5105 RVA: 0x0006D940 File Offset: 0x0006BB40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764772, XrefRangeEnd = 764786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanConvert(Type objectType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeyValuePairConverter.NativeMethodInfoPtr_CanConvert_Public_Virtual_Boolean_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013F2 RID: 5106 RVA: 0x0006D998 File Offset: 0x0006BB98
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyValuePairConverter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyValuePairConverter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyValuePairConverter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013F3 RID: 5107 RVA: 0x000081E6 File Offset: 0x000063E6
		public KeyValuePairConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x060013F4 RID: 5108 RVA: 0x0006D9D4 File Offset: 0x0006BBD4
		// (set) Token: 0x060013F5 RID: 5109 RVA: 0x000081EF File Offset: 0x000063EF
		public unsafe static string KeyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(KeyValuePairConverter.NativeFieldInfoPtr_KeyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KeyValuePairConverter.NativeFieldInfoPtr_KeyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x060013F6 RID: 5110 RVA: 0x0006D9F4 File Offset: 0x0006BBF4
		// (set) Token: 0x060013F7 RID: 5111 RVA: 0x00008201 File Offset: 0x00006401
		public unsafe static string ValueName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(KeyValuePairConverter.NativeFieldInfoPtr_ValueName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KeyValuePairConverter.NativeFieldInfoPtr_ValueName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x060013F8 RID: 5112 RVA: 0x0006DA14 File Offset: 0x0006BC14
		// (set) Token: 0x060013F9 RID: 5113 RVA: 0x00008213 File Offset: 0x00006413
		public unsafe static ThreadSafeStore<Type, ReflectionObject> ReflectionObjectPerType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(KeyValuePairConverter.NativeFieldInfoPtr_ReflectionObjectPerType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThreadSafeStore<Type, ReflectionObject>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KeyValuePairConverter.NativeFieldInfoPtr_ReflectionObjectPerType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001028 RID: 4136
		private static readonly IntPtr NativeFieldInfoPtr_KeyName;

		// Token: 0x04001029 RID: 4137
		private static readonly IntPtr NativeFieldInfoPtr_ValueName;

		// Token: 0x0400102A RID: 4138
		private static readonly IntPtr NativeFieldInfoPtr_ReflectionObjectPerType;

		// Token: 0x0400102B RID: 4139
		private static readonly IntPtr NativeMethodInfoPtr_InitializeReflectionObject_Private_Static_ReflectionObject_Type_0;

		// Token: 0x0400102C RID: 4140
		private static readonly IntPtr NativeMethodInfoPtr_WriteJson_Public_Virtual_Void_JsonWriter_Object_JsonSerializer_0;

		// Token: 0x0400102D RID: 4141
		private static readonly IntPtr NativeMethodInfoPtr_ReadJson_Public_Virtual_Object_JsonReader_Type_Object_JsonSerializer_0;

		// Token: 0x0400102E RID: 4142
		private static readonly IntPtr NativeMethodInfoPtr_CanConvert_Public_Virtual_Boolean_Type_0;

		// Token: 0x0400102F RID: 4143
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
