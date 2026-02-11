using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200005E RID: 94
	public static class JsonTokenUtils : Object
	{
		// Token: 0x06000890 RID: 2192 RVA: 0x00039DDC File Offset: 0x00037FDC
		// Note: this type is marked as 'beforefieldinit'.
		static JsonTokenUtils()
		{
			Il2CppClassPointerStore<JsonTokenUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Utilities", "JsonTokenUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonTokenUtils>.NativeClassPtr);
			JsonTokenUtils.NativeMethodInfoPtr_IsEndToken_Internal_Static_Boolean_JsonToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTokenUtils>.NativeClassPtr, 100664923);
			JsonTokenUtils.NativeMethodInfoPtr_IsStartToken_Internal_Static_Boolean_JsonToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTokenUtils>.NativeClassPtr, 100664924);
			JsonTokenUtils.NativeMethodInfoPtr_IsPrimitiveToken_Internal_Static_Boolean_JsonToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTokenUtils>.NativeClassPtr, 100664925);
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x00039E48 File Offset: 0x00038048
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 744439, RefRangeEnd = 744444, XrefRangeStart = 744439, XrefRangeEnd = 744439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsEndToken(JsonToken token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTokenUtils.NativeMethodInfoPtr_IsEndToken_Internal_Static_Boolean_JsonToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x00039E88 File Offset: 0x00038088
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 744444, RefRangeEnd = 744451, XrefRangeStart = 744444, XrefRangeEnd = 744444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsStartToken(JsonToken token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTokenUtils.NativeMethodInfoPtr_IsStartToken_Internal_Static_Boolean_JsonToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x00039EC8 File Offset: 0x000380C8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 744451, RefRangeEnd = 744455, XrefRangeStart = 744451, XrefRangeEnd = 744451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPrimitiveToken(JsonToken token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTokenUtils.NativeMethodInfoPtr_IsPrimitiveToken_Internal_Static_Boolean_JsonToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x00004B93 File Offset: 0x00002D93
		public JsonTokenUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000747 RID: 1863
		private static readonly IntPtr NativeMethodInfoPtr_IsEndToken_Internal_Static_Boolean_JsonToken_0;

		// Token: 0x04000748 RID: 1864
		private static readonly IntPtr NativeMethodInfoPtr_IsStartToken_Internal_Static_Boolean_JsonToken_0;

		// Token: 0x04000749 RID: 1865
		private static readonly IntPtr NativeMethodInfoPtr_IsPrimitiveToken_Internal_Static_Boolean_JsonToken_0;
	}
}
