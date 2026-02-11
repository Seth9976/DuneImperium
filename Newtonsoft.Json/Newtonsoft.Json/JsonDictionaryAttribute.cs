using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Newtonsoft.Json
{
	// Token: 0x0200001E RID: 30
	public sealed class JsonDictionaryAttribute : JsonContainerAttribute
	{
		// Token: 0x060000FB RID: 251 RVA: 0x00015E44 File Offset: 0x00014044
		// Note: this type is marked as 'beforefieldinit'.
		static JsonDictionaryAttribute()
		{
			Il2CppClassPointerStore<JsonDictionaryAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json", "JsonDictionaryAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonDictionaryAttribute>.NativeClassPtr);
			JsonDictionaryAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonDictionaryAttribute>.NativeClassPtr, 100663443);
			JsonDictionaryAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonDictionaryAttribute>.NativeClassPtr, 100663444);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00015E9C File Offset: 0x0001409C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonDictionaryAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonDictionaryAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonDictionaryAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00015ED8 File Offset: 0x000140D8
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonDictionaryAttribute(string id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonDictionaryAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonDictionaryAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00002648 File Offset: 0x00000848
		public JsonDictionaryAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
