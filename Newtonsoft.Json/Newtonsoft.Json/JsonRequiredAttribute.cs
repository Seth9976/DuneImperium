using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json
{
	// Token: 0x02000029 RID: 41
	public sealed class JsonRequiredAttribute : Attribute
	{
		// Token: 0x0600020A RID: 522 RVA: 0x00002CFF File Offset: 0x00000EFF
		// Note: this type is marked as 'beforefieldinit'.
		static JsonRequiredAttribute()
		{
			Il2CppClassPointerStore<JsonRequiredAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json", "JsonRequiredAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonRequiredAttribute>.NativeClassPtr);
			JsonRequiredAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonRequiredAttribute>.NativeClassPtr, 100663614);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0001A408 File Offset: 0x00018608
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonRequiredAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonRequiredAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonRequiredAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00002D38 File Offset: 0x00000F38
		public JsonRequiredAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
