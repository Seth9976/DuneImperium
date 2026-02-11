using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json
{
	// Token: 0x02000021 RID: 33
	public sealed class JsonIgnoreAttribute : Attribute
	{
		// Token: 0x06000111 RID: 273 RVA: 0x00002699 File Offset: 0x00000899
		// Note: this type is marked as 'beforefieldinit'.
		static JsonIgnoreAttribute()
		{
			Il2CppClassPointerStore<JsonIgnoreAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json", "JsonIgnoreAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonIgnoreAttribute>.NativeClassPtr);
			JsonIgnoreAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonIgnoreAttribute>.NativeClassPtr, 100663455);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000163AC File Offset: 0x000145AC
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

		// Token: 0x06000113 RID: 275 RVA: 0x000026D2 File Offset: 0x000008D2
		public JsonIgnoreAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
