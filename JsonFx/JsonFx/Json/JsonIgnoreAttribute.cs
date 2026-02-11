using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace JsonFx.Json
{
	// Token: 0x02000027 RID: 39
	public sealed class JsonIgnoreAttribute : Attribute
	{
		// Token: 0x060001FA RID: 506 RVA: 0x00002CBF File Offset: 0x00000EBF
		// Note: this type is marked as 'beforefieldinit'.
		static JsonIgnoreAttribute()
		{
			Il2CppClassPointerStore<JsonIgnoreAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("JsonFx.dll", "JsonFx.Json", "JsonIgnoreAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonIgnoreAttribute>.NativeClassPtr);
			JsonIgnoreAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonIgnoreAttribute>.NativeClassPtr, 100663577);
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0000AACC File Offset: 0x00008CCC
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonIgnoreAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonIgnoreAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonIgnoreAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00002CF8 File Offset: 0x00000EF8
		public JsonIgnoreAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
