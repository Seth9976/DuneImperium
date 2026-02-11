using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Google.Apis.Json
{
	// Token: 0x02000020 RID: 32
	public class JsonExplicitNullAttribute : Attribute
	{
		// Token: 0x06000146 RID: 326 RVA: 0x000027D0 File Offset: 0x000009D0
		// Note: this type is marked as 'beforefieldinit'.
		static JsonExplicitNullAttribute()
		{
			Il2CppClassPointerStore<JsonExplicitNullAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Core.dll", "Google.Apis.Json", "JsonExplicitNullAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonExplicitNullAttribute>.NativeClassPtr);
			JsonExplicitNullAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonExplicitNullAttribute>.NativeClassPtr, 100663497);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00008E50 File Offset: 0x00007050
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonExplicitNullAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonExplicitNullAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonExplicitNullAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00002809 File Offset: 0x00000A09
		public JsonExplicitNullAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
