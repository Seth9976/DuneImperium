using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000E3 RID: 227
	public class EntityKeyMemberConverter : JsonConverter
	{
		// Token: 0x060013B9 RID: 5049 RVA: 0x0006C96C File Offset: 0x0006AB6C
		// Note: this type is marked as 'beforefieldinit'.
		static EntityKeyMemberConverter()
		{
			Il2CppClassPointerStore<EntityKeyMemberConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Converters", "EntityKeyMemberConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityKeyMemberConverter>.NativeClassPtr);
			EntityKeyMemberConverter.NativeFieldInfoPtr_EntityKeyMemberFullTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityKeyMemberConverter>.NativeClassPtr, "EntityKeyMemberFullTypeName");
			EntityKeyMemberConverter.NativeFieldInfoPtr_KeyPropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityKeyMemberConverter>.NativeClassPtr, "KeyPropertyName");
			EntityKeyMemberConverter.NativeFieldInfoPtr_TypePropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityKeyMemberConverter>.NativeClassPtr, "TypePropertyName");
			EntityKeyMemberConverter.NativeFieldInfoPtr_ValuePropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityKeyMemberConverter>.NativeClassPtr, "ValuePropertyName");
			EntityKeyMemberConverter.NativeFieldInfoPtr__reflectionObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityKeyMemberConverter>.NativeClassPtr, "_reflectionObject");
			EntityKeyMemberConverter.NativeMethodInfoPtr_WriteJson_Public_Virtual_Void_JsonWriter_Object_JsonSerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityKeyMemberConverter>.NativeClassPtr, 100667071);
			EntityKeyMemberConverter.NativeMethodInfoPtr_ReadAndAssertProperty_Private_Static_Void_JsonReader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityKeyMemberConverter>.NativeClassPtr, 100667072);
			EntityKeyMemberConverter.NativeMethodInfoPtr_ReadJson_Public_Virtual_Object_JsonReader_Type_Object_JsonSerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityKeyMemberConverter>.NativeClassPtr, 100667073);
			EntityKeyMemberConverter.NativeMethodInfoPtr_EnsureReflectionObject_Private_Static_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityKeyMemberConverter>.NativeClassPtr, 100667074);
			EntityKeyMemberConverter.NativeMethodInfoPtr_CanConvert_Public_Virtual_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityKeyMemberConverter>.NativeClassPtr, 100667075);
			EntityKeyMemberConverter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityKeyMemberConverter>.NativeClassPtr, 100667076);
		}

		// Token: 0x060013BA RID: 5050 RVA: 0x0006CA78 File Offset: 0x0006AC78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764402, XrefRangeEnd = 764435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityKeyMemberConverter.NativeMethodInfoPtr_WriteJson_Public_Virtual_Void_JsonWriter_Object_JsonSerializer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013BB RID: 5051 RVA: 0x0006CAEC File Offset: 0x0006ACEC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 764437, RefRangeEnd = 764440, XrefRangeStart = 764435, XrefRangeEnd = 764437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReadAndAssertProperty(JsonReader reader, string propertyName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propertyName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityKeyMemberConverter.NativeMethodInfoPtr_ReadAndAssertProperty_Private_Static_Void_JsonReader_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013BC RID: 5052 RVA: 0x0006CB34 File Offset: 0x0006AD34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764440, XrefRangeEnd = 764475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityKeyMemberConverter.NativeMethodInfoPtr_ReadJson_Public_Virtual_Object_JsonReader_Type_Object_JsonSerializer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060013BD RID: 5053 RVA: 0x0006CBC8 File Offset: 0x0006ADC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 764490, RefRangeEnd = 764492, XrefRangeStart = 764475, XrefRangeEnd = 764490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EnsureReflectionObject(Type objectType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityKeyMemberConverter.NativeMethodInfoPtr_EnsureReflectionObject_Private_Static_Void_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013BE RID: 5054 RVA: 0x0006CC00 File Offset: 0x0006AE00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764492, XrefRangeEnd = 764495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanConvert(Type objectType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityKeyMemberConverter.NativeMethodInfoPtr_CanConvert_Public_Virtual_Boolean_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013BF RID: 5055 RVA: 0x0006CC58 File Offset: 0x0006AE58
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityKeyMemberConverter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityKeyMemberConverter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityKeyMemberConverter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013C0 RID: 5056 RVA: 0x000080FD File Offset: 0x000062FD
		public EntityKeyMemberConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x060013C1 RID: 5057 RVA: 0x0006CC94 File Offset: 0x0006AE94
		// (set) Token: 0x060013C2 RID: 5058 RVA: 0x00008106 File Offset: 0x00006306
		public unsafe static string EntityKeyMemberFullTypeName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityKeyMemberConverter.NativeFieldInfoPtr_EntityKeyMemberFullTypeName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityKeyMemberConverter.NativeFieldInfoPtr_EntityKeyMemberFullTypeName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x060013C3 RID: 5059 RVA: 0x0006CCB4 File Offset: 0x0006AEB4
		// (set) Token: 0x060013C4 RID: 5060 RVA: 0x00008118 File Offset: 0x00006318
		public unsafe static string KeyPropertyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityKeyMemberConverter.NativeFieldInfoPtr_KeyPropertyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityKeyMemberConverter.NativeFieldInfoPtr_KeyPropertyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x060013C5 RID: 5061 RVA: 0x0006CCD4 File Offset: 0x0006AED4
		// (set) Token: 0x060013C6 RID: 5062 RVA: 0x0000812A File Offset: 0x0000632A
		public unsafe static string TypePropertyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityKeyMemberConverter.NativeFieldInfoPtr_TypePropertyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityKeyMemberConverter.NativeFieldInfoPtr_TypePropertyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x060013C7 RID: 5063 RVA: 0x0006CCF4 File Offset: 0x0006AEF4
		// (set) Token: 0x060013C8 RID: 5064 RVA: 0x0000813C File Offset: 0x0000633C
		public unsafe static string ValuePropertyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityKeyMemberConverter.NativeFieldInfoPtr_ValuePropertyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityKeyMemberConverter.NativeFieldInfoPtr_ValuePropertyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x060013C9 RID: 5065 RVA: 0x0006CD14 File Offset: 0x0006AF14
		// (set) Token: 0x060013CA RID: 5066 RVA: 0x0000814E File Offset: 0x0000634E
		public unsafe static ReflectionObject _reflectionObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityKeyMemberConverter.NativeFieldInfoPtr__reflectionObject, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReflectionObject>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityKeyMemberConverter.NativeFieldInfoPtr__reflectionObject, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001005 RID: 4101
		private static readonly IntPtr NativeFieldInfoPtr_EntityKeyMemberFullTypeName;

		// Token: 0x04001006 RID: 4102
		private static readonly IntPtr NativeFieldInfoPtr_KeyPropertyName;

		// Token: 0x04001007 RID: 4103
		private static readonly IntPtr NativeFieldInfoPtr_TypePropertyName;

		// Token: 0x04001008 RID: 4104
		private static readonly IntPtr NativeFieldInfoPtr_ValuePropertyName;

		// Token: 0x04001009 RID: 4105
		private static readonly IntPtr NativeFieldInfoPtr__reflectionObject;

		// Token: 0x0400100A RID: 4106
		private static readonly IntPtr NativeMethodInfoPtr_WriteJson_Public_Virtual_Void_JsonWriter_Object_JsonSerializer_0;

		// Token: 0x0400100B RID: 4107
		private static readonly IntPtr NativeMethodInfoPtr_ReadAndAssertProperty_Private_Static_Void_JsonReader_String_0;

		// Token: 0x0400100C RID: 4108
		private static readonly IntPtr NativeMethodInfoPtr_ReadJson_Public_Virtual_Object_JsonReader_Type_Object_JsonSerializer_0;

		// Token: 0x0400100D RID: 4109
		private static readonly IntPtr NativeMethodInfoPtr_EnsureReflectionObject_Private_Static_Void_Type_0;

		// Token: 0x0400100E RID: 4110
		private static readonly IntPtr NativeMethodInfoPtr_CanConvert_Public_Virtual_Boolean_Type_0;

		// Token: 0x0400100F RID: 4111
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
