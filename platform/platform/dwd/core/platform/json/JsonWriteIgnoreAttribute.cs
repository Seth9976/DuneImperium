using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace dwd.core.platform.json
{
	// Token: 0x0200004C RID: 76
	public sealed class JsonWriteIgnoreAttribute : Attribute
	{
		// Token: 0x06000313 RID: 787 RVA: 0x00003680 File Offset: 0x00001880
		// Note: this type is marked as 'beforefieldinit'.
		static JsonWriteIgnoreAttribute()
		{
			Il2CppClassPointerStore<JsonWriteIgnoreAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.json", "JsonWriteIgnoreAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonWriteIgnoreAttribute>.NativeClassPtr);
			JsonWriteIgnoreAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriteIgnoreAttribute>.NativeClassPtr, 100663791);
		}

		// Token: 0x06000314 RID: 788 RVA: 0x0000F984 File Offset: 0x0000DB84
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonWriteIgnoreAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonWriteIgnoreAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriteIgnoreAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000315 RID: 789 RVA: 0x000036B9 File Offset: 0x000018B9
		public JsonWriteIgnoreAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000207 RID: 519
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
