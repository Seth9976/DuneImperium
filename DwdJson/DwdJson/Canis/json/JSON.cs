using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Reflection;
using JsonFx.Serialization;

namespace Canis.json
{
	// Token: 0x02000016 RID: 22
	public static class JSON : Object
	{
		// Token: 0x060000A2 RID: 162 RVA: 0x00004B24 File Offset: 0x00002D24
		// Note: this type is marked as 'beforefieldinit'.
		static JSON()
		{
			Il2CppClassPointerStore<JSON>.NativeClassPtr = IL2CPP.GetIl2CppClass("DwdJson.dll", "Canis.json", "JSON");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JSON>.NativeClassPtr);
			JSON.NativeFieldInfoPtr_reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSON>.NativeClassPtr, "reader");
			JSON.NativeFieldInfoPtr_writer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSON>.NativeClassPtr, "writer");
			JSON.NativeFieldInfoPtr_URLReplacements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSON>.NativeClassPtr, "URLReplacements");
			JSON.NativeMethodInfoPtr_ToJSON_Public_Static_String_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSON>.NativeClassPtr, 100663366);
			JSON.NativeMethodInfoPtr_TryToJSON_Public_Static_Boolean_Object_byref_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSON>.NativeClassPtr, 100663367);
			JSON.NativeMethodInfoPtr_WriteToStream_Public_Static_Void_Object_TextWriter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSON>.NativeClassPtr, 100663368);
			JSON.NativeMethodInfoPtr_Deserialize_Public_Static_Object_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSON>.NativeClassPtr, 100663369);
			JSON.NativeMethodInfoPtr_Deserialize_Public_Static_Object_TextReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSON>.NativeClassPtr, 100663370);
			JSON.NativeMethodInfoPtr_Deserialize_Public_Static_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSON>.NativeClassPtr, 100663371);
			JSON.NativeMethodInfoPtr_Deserialize_Public_Static_Void_String_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSON>.NativeClassPtr, 100663372);
			JSON.NativeMethodInfoPtr_TryDeserialize_Public_Static_Boolean_String_byref_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSON>.NativeClassPtr, 100663373);
			JSON.NativeMethodInfoPtr_TryDeserialize_Public_Static_Boolean_String_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSON>.NativeClassPtr, 100663374);
			JSON.NativeMethodInfoPtr_logException_Private_Static_Void_String_DeserializationException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSON>.NativeClassPtr, 100663375);
			JSON.NativeMethodInfoPtr_URLEncode_Public_Static_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSON>.NativeClassPtr, 100663376);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00004C6C File Offset: 0x00002E6C
		[CallerCount(65)]
		[CachedScanResults(RefRangeStart = 1248722, RefRangeEnd = 1248787, XrefRangeStart = 1248716, XrefRangeEnd = 1248722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToJSON(Object obj, bool prettyPrint)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prettyPrint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSON.NativeMethodInfoPtr_ToJSON_Public_Static_String_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00004CB8 File Offset: 0x00002EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248787, XrefRangeEnd = 1248804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryToJSON(Object obj, out string json, bool prettyPrint)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prettyPrint;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(JSON.NativeMethodInfoPtr_TryToJSON_Public_Static_Boolean_Object_byref_String_Boolean_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			json = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00004D24 File Offset: 0x00002F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248804, XrefRangeEnd = 1249058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteToStream(Object obj, TextWriter output, bool prettyPrint)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(output);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prettyPrint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSON.NativeMethodInfoPtr_WriteToStream_Public_Static_Void_Object_TextWriter_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00004D7C File Offset: 0x00002F7C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1249067, RefRangeEnd = 1249077, XrefRangeStart = 1249058, XrefRangeEnd = 1249067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Deserialize(string input, Type type = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSON.NativeMethodInfoPtr_Deserialize_Public_Static_Object_String_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00004DD4 File Offset: 0x00002FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249077, XrefRangeEnd = 1249083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Deserialize(TextReader textReader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textReader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSON.NativeMethodInfoPtr_Deserialize_Public_Static_Object_TextReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00004E18 File Offset: 0x00003018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249083, XrefRangeEnd = 1249094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Deserialize<T>(string input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSON.MethodInfoStoreGeneric_Deserialize_Public_Static_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00004E58 File Offset: 0x00003058
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1249121, RefRangeEnd = 1249122, XrefRangeStart = 1249094, XrefRangeEnd = 1249121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Deserialize<T>(string input, out T value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(JSON.MethodInfoStoreGeneric_Deserialize_Public_Static_Void_String_byref_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00004EDC File Offset: 0x000030DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1249130, RefRangeEnd = 1249131, XrefRangeStart = 1249122, XrefRangeEnd = 1249130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryDeserialize(string input, out Object value, Type type = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(JSON.NativeMethodInfoPtr_TryDeserialize_Public_Static_Boolean_String_byref_Object_Type_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : new Object(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00004F54 File Offset: 0x00003154
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1249142, RefRangeEnd = 1249143, XrefRangeStart = 1249131, XrefRangeEnd = 1249142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryDeserialize<T>(string input, out T value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(JSON.MethodInfoStoreGeneric_TryDeserialize_Public_Static_Boolean_String_byref_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00004FE4 File Offset: 0x000031E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1249174, RefRangeEnd = 1249175, XrefRangeStart = 1249143, XrefRangeEnd = 1249174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void logException(string input, DeserializationException e)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSON.NativeMethodInfoPtr_logException_Private_Static_Void_String_DeserializationException_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000502C File Offset: 0x0000322C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249175, XrefRangeEnd = 1249199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string URLEncode(Il2CppStructArray<byte> input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSON.NativeMethodInfoPtr_URLEncode_Public_Static_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000024AC File Offset: 0x000006AC
		public JSON(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00005068 File Offset: 0x00003268
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x000024B5 File Offset: 0x000006B5
		public unsafe static DwdJsonReader reader
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JSON.NativeFieldInfoPtr_reader, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DwdJsonReader>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JSON.NativeFieldInfoPtr_reader, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x00005090 File Offset: 0x00003290
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x000024C7 File Offset: 0x000006C7
		public unsafe static DwdJsonWriter writer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JSON.NativeFieldInfoPtr_writer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DwdJsonWriter>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JSON.NativeFieldInfoPtr_writer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x000050B8 File Offset: 0x000032B8
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x000024D9 File Offset: 0x000006D9
		public unsafe static List<ValueTuple<string, string>> URLReplacements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JSON.NativeFieldInfoPtr_URLReplacements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<string, string>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JSON.NativeFieldInfoPtr_URLReplacements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeFieldInfoPtr_reader;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeFieldInfoPtr_writer;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeFieldInfoPtr_URLReplacements;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_ToJSON_Public_Static_String_Object_Boolean_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_TryToJSON_Public_Static_Boolean_Object_byref_String_Boolean_0;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_WriteToStream_Public_Static_Void_Object_TextWriter_Boolean_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_Object_String_Type_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_Object_TextReader_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_T_String_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_Void_String_byref_T_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_TryDeserialize_Public_Static_Boolean_String_byref_Object_Type_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_TryDeserialize_Public_Static_Boolean_String_byref_T_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_logException_Private_Static_Void_String_DeserializationException_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_URLEncode_Public_Static_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x02000027 RID: 39
		private sealed class MethodInfoStoreGeneric_Deserialize_Public_Static_T_String_0<T>
		{
			// Token: 0x040000AE RID: 174
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(JSON.NativeMethodInfoPtr_Deserialize_Public_Static_T_String_0, Il2CppClassPointerStore<JSON>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000028 RID: 40
		private sealed class MethodInfoStoreGeneric_Deserialize_Public_Static_Void_String_byref_T_0<T>
		{
			// Token: 0x040000AF RID: 175
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(JSON.NativeMethodInfoPtr_Deserialize_Public_Static_Void_String_byref_T_0, Il2CppClassPointerStore<JSON>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000029 RID: 41
		private sealed class MethodInfoStoreGeneric_TryDeserialize_Public_Static_Boolean_String_byref_T_0<T>
		{
			// Token: 0x040000B0 RID: 176
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(JSON.NativeMethodInfoPtr_TryDeserialize_Public_Static_Boolean_String_byref_T_0, Il2CppClassPointerStore<JSON>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
