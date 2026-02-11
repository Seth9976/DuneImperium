using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using JsonFx.Json;

namespace dwd.core.platform.json
{
	// Token: 0x0200004B RID: 75
	public static class JsonHelper : Object
	{
		// Token: 0x06000307 RID: 775 RVA: 0x0000F748 File Offset: 0x0000D948
		// Note: this type is marked as 'beforefieldinit'.
		static JsonHelper()
		{
			Il2CppClassPointerStore<JsonHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.json", "JsonHelper");
			JsonHelper.NativeFieldInfoPtr_jsonReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonHelper>.NativeClassPtr, "jsonReader");
			JsonHelper.NativeFieldInfoPtr_jsonWriter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonHelper>.NativeClassPtr, "jsonWriter");
			JsonHelper.NativeFieldInfoPtr_apiJsonWriter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonHelper>.NativeClassPtr, "apiJsonWriter");
			JsonHelper.NativeMethodInfoPtr_Serialize_Public_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonHelper>.NativeClassPtr, 100663787);
			JsonHelper.NativeMethodInfoPtr_SerializeApi_Public_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonHelper>.NativeClassPtr, 100663788);
			JsonHelper.NativeMethodInfoPtr_Deserialize_Public_Static_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonHelper>.NativeClassPtr, 100663789);
			JsonHelper.NativeMethodInfoPtr_Deserialize_Public_Static_Object_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonHelper>.NativeClassPtr, 100663790);
		}

		// Token: 0x06000308 RID: 776 RVA: 0x0000F7FC File Offset: 0x0000D9FC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1169820, RefRangeEnd = 1169823, XrefRangeStart = 1169772, XrefRangeEnd = 1169820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Serialize(Object data)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonHelper.NativeMethodInfoPtr_Serialize_Public_Static_String_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0000F838 File Offset: 0x0000DA38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169823, XrefRangeEnd = 1169828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SerializeApi(Object data)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonHelper.NativeMethodInfoPtr_SerializeApi_Public_Static_String_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600030A RID: 778 RVA: 0x0000F874 File Offset: 0x0000DA74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1169839, RefRangeEnd = 1169841, XrefRangeStart = 1169828, XrefRangeEnd = 1169839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Deserialize<T>(string input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonHelper.MethodInfoStoreGeneric_Deserialize_Public_Static_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x0600030B RID: 779 RVA: 0x0000F8B4 File Offset: 0x0000DAB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169841, XrefRangeEnd = 1169847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Deserialize(string input, Type type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonHelper.NativeMethodInfoPtr_Deserialize_Public_Static_Object_String_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00003641 File Offset: 0x00001841
		public JsonHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x0600030D RID: 781 RVA: 0x0000F90C File Offset: 0x0000DB0C
		// (set) Token: 0x0600030E RID: 782 RVA: 0x0000364A File Offset: 0x0000184A
		public unsafe static JsonReader jsonReader
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonHelper.NativeFieldInfoPtr_jsonReader, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonReader>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonHelper.NativeFieldInfoPtr_jsonReader, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600030F RID: 783 RVA: 0x0000F934 File Offset: 0x0000DB34
		// (set) Token: 0x06000310 RID: 784 RVA: 0x0000365C File Offset: 0x0000185C
		public unsafe static JsonWriter jsonWriter
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonHelper.NativeFieldInfoPtr_jsonWriter, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonWriter>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonHelper.NativeFieldInfoPtr_jsonWriter, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000311 RID: 785 RVA: 0x0000F95C File Offset: 0x0000DB5C
		// (set) Token: 0x06000312 RID: 786 RVA: 0x0000366E File Offset: 0x0000186E
		public unsafe static JsonWriter apiJsonWriter
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonHelper.NativeFieldInfoPtr_apiJsonWriter, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonWriter>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonHelper.NativeFieldInfoPtr_apiJsonWriter, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000200 RID: 512
		private static readonly IntPtr NativeFieldInfoPtr_jsonReader;

		// Token: 0x04000201 RID: 513
		private static readonly IntPtr NativeFieldInfoPtr_jsonWriter;

		// Token: 0x04000202 RID: 514
		private static readonly IntPtr NativeFieldInfoPtr_apiJsonWriter;

		// Token: 0x04000203 RID: 515
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Static_String_Object_0;

		// Token: 0x04000204 RID: 516
		private static readonly IntPtr NativeMethodInfoPtr_SerializeApi_Public_Static_String_Object_0;

		// Token: 0x04000205 RID: 517
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_T_String_0;

		// Token: 0x04000206 RID: 518
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_Object_String_Type_0;

		// Token: 0x02000084 RID: 132
		private sealed class MethodInfoStoreGeneric_Deserialize_Public_Static_T_String_0<T>
		{
			// Token: 0x0400031A RID: 794
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(JsonHelper.NativeMethodInfoPtr_Deserialize_Public_Static_T_String_0, Il2CppClassPointerStore<JsonHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
