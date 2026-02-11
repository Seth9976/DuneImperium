using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.IO;
using Il2CppSystem.Reflection;
using Newtonsoft.Json;

namespace Google.Apis.Json
{
	// Token: 0x02000024 RID: 36
	public class NewtonsoftJsonSerializer : Object
	{
		// Token: 0x0600015F RID: 351 RVA: 0x000094E4 File Offset: 0x000076E4
		// Note: this type is marked as 'beforefieldinit'.
		static NewtonsoftJsonSerializer()
		{
			Il2CppClassPointerStore<NewtonsoftJsonSerializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Core.dll", "Google.Apis.Json", "NewtonsoftJsonSerializer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewtonsoftJsonSerializer>.NativeClassPtr);
			NewtonsoftJsonSerializer.NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewtonsoftJsonSerializer>.NativeClassPtr, "settings");
			NewtonsoftJsonSerializer.NativeFieldInfoPtr_serializer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewtonsoftJsonSerializer>.NativeClassPtr, "serializer");
			NewtonsoftJsonSerializer.NativeFieldInfoPtr__Instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewtonsoftJsonSerializer>.NativeClassPtr, "<Instance>k__BackingField");
			NewtonsoftJsonSerializer.NativeMethodInfoPtr_get_Instance_Public_Static_get_NewtonsoftJsonSerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewtonsoftJsonSerializer>.NativeClassPtr, 100663511);
			NewtonsoftJsonSerializer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewtonsoftJsonSerializer>.NativeClassPtr, 100663512);
			NewtonsoftJsonSerializer.NativeMethodInfoPtr__ctor_Public_Void_JsonSerializerSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewtonsoftJsonSerializer>.NativeClassPtr, 100663513);
			NewtonsoftJsonSerializer.NativeMethodInfoPtr_CreateDefaultSettings_Public_Static_JsonSerializerSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewtonsoftJsonSerializer>.NativeClassPtr, 100663514);
			NewtonsoftJsonSerializer.NativeMethodInfoPtr_get_Format_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewtonsoftJsonSerializer>.NativeClassPtr, 100663515);
			NewtonsoftJsonSerializer.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_Object_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewtonsoftJsonSerializer>.NativeClassPtr, 100663516);
			NewtonsoftJsonSerializer.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewtonsoftJsonSerializer>.NativeClassPtr, 100663517);
			NewtonsoftJsonSerializer.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewtonsoftJsonSerializer>.NativeClassPtr, 100663518);
			NewtonsoftJsonSerializer.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Object_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewtonsoftJsonSerializer>.NativeClassPtr, 100663519);
			NewtonsoftJsonSerializer.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_T_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewtonsoftJsonSerializer>.NativeClassPtr, 100663520);
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000160 RID: 352 RVA: 0x00009618 File Offset: 0x00007818
		public unsafe static NewtonsoftJsonSerializer Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1211196, XrefRangeEnd = 1211200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewtonsoftJsonSerializer.NativeMethodInfoPtr_get_Instance_Public_Static_get_NewtonsoftJsonSerializer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NewtonsoftJsonSerializer>(intPtr3) : null;
			}
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0000964C File Offset: 0x0000784C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1211227, RefRangeEnd = 1211228, XrefRangeStart = 1211200, XrefRangeEnd = 1211227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NewtonsoftJsonSerializer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewtonsoftJsonSerializer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewtonsoftJsonSerializer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00009688 File Offset: 0x00007888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1211228, XrefRangeEnd = 1211237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NewtonsoftJsonSerializer(JsonSerializerSettings settings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewtonsoftJsonSerializer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewtonsoftJsonSerializer.NativeMethodInfoPtr__ctor_Public_Void_JsonSerializerSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000163 RID: 355 RVA: 0x000096D4 File Offset: 0x000078D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1211237, XrefRangeEnd = 1211251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JsonSerializerSettings CreateDefaultSettings()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewtonsoftJsonSerializer.NativeMethodInfoPtr_CreateDefaultSettings_Public_Static_JsonSerializerSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonSerializerSettings>(intPtr3) : null;
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00009708 File Offset: 0x00007908
		public unsafe virtual string Format
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1211251, XrefRangeEnd = 1211253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewtonsoftJsonSerializer.NativeMethodInfoPtr_get_Format_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00009740 File Offset: 0x00007940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1211253, XrefRangeEnd = 1211266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Serialize(Object obj, Stream target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewtonsoftJsonSerializer.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_Object_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00009794 File Offset: 0x00007994
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1211279, RefRangeEnd = 1211283, XrefRangeStart = 1211266, XrefRangeEnd = 1211279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string Serialize(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewtonsoftJsonSerializer.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000167 RID: 359 RVA: 0x000097DC File Offset: 0x000079DC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1211289, RefRangeEnd = 1211294, XrefRangeStart = 1211283, XrefRangeEnd = 1211289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual T Deserialize<T>(string input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewtonsoftJsonSerializer.MethodInfoStoreGeneric_Deserialize_Public_Virtual_Final_New_T_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00009828 File Offset: 0x00007A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1211294, XrefRangeEnd = 1211299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Deserialize(string input, Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewtonsoftJsonSerializer.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Object_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0000988C File Offset: 0x00007A8C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1211317, RefRangeEnd = 1211320, XrefRangeStart = 1211299, XrefRangeEnd = 1211317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual T Deserialize<T>(Stream input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewtonsoftJsonSerializer.MethodInfoStoreGeneric_Deserialize_Public_Virtual_Final_New_T_Stream_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00002851 File Offset: 0x00000A51
		public NewtonsoftJsonSerializer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600016B RID: 363 RVA: 0x000098D8 File Offset: 0x00007AD8
		// (set) Token: 0x0600016C RID: 364 RVA: 0x0000285A File Offset: 0x00000A5A
		public unsafe JsonSerializerSettings settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewtonsoftJsonSerializer.NativeFieldInfoPtr_settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonSerializerSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewtonsoftJsonSerializer.NativeFieldInfoPtr_settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600016D RID: 365 RVA: 0x00009908 File Offset: 0x00007B08
		// (set) Token: 0x0600016E RID: 366 RVA: 0x00002879 File Offset: 0x00000A79
		public unsafe JsonSerializer serializer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewtonsoftJsonSerializer.NativeFieldInfoPtr_serializer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonSerializer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewtonsoftJsonSerializer.NativeFieldInfoPtr_serializer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600016F RID: 367 RVA: 0x00009938 File Offset: 0x00007B38
		// (set) Token: 0x06000170 RID: 368 RVA: 0x00002898 File Offset: 0x00000A98
		public unsafe static NewtonsoftJsonSerializer _Instance_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NewtonsoftJsonSerializer.NativeFieldInfoPtr__Instance_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NewtonsoftJsonSerializer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NewtonsoftJsonSerializer.NativeFieldInfoPtr__Instance_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeFieldInfoPtr_settings;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeFieldInfoPtr_serializer;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeFieldInfoPtr__Instance_k__BackingField;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_NewtonsoftJsonSerializer_0;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_JsonSerializerSettings_0;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeMethodInfoPtr_CreateDefaultSettings_Public_Static_JsonSerializerSettings_0;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeMethodInfoPtr_get_Format_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_Object_Stream_0;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_String_Object_0;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_T_String_0;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Object_String_Type_0;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_T_Stream_0;

		// Token: 0x02000054 RID: 84
		private sealed class MethodInfoStoreGeneric_Deserialize_Public_Virtual_Final_New_T_String_0<T>
		{
			// Token: 0x0400020C RID: 524
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NewtonsoftJsonSerializer.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_T_String_0, Il2CppClassPointerStore<NewtonsoftJsonSerializer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000055 RID: 85
		private sealed class MethodInfoStoreGeneric_Deserialize_Public_Virtual_Final_New_T_Stream_0<T>
		{
			// Token: 0x0400020D RID: 525
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NewtonsoftJsonSerializer.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_T_Stream_0, Il2CppClassPointerStore<NewtonsoftJsonSerializer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
