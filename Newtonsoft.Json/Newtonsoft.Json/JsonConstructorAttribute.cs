using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json
{
	// Token: 0x02000017 RID: 23
	public sealed class JsonConstructorAttribute : Attribute
	{
		// Token: 0x06000049 RID: 73 RVA: 0x000022D0 File Offset: 0x000004D0
		// Note: this type is marked as 'beforefieldinit'.
		static JsonConstructorAttribute()
		{
			Il2CppClassPointerStore<JsonConstructorAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json", "JsonConstructorAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonConstructorAttribute>.NativeClassPtr);
			JsonConstructorAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConstructorAttribute>.NativeClassPtr, 100663327);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00012C1C File Offset: 0x00010E1C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonConstructorAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonConstructorAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConstructorAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002309 File Offset: 0x00000509
		public JsonConstructorAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
