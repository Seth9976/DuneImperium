using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.ObjectModel;

namespace Newtonsoft.Json
{
	// Token: 0x0200001D RID: 29
	public class JsonConverterCollection : Collection<JsonConverter>
	{
		// Token: 0x060000F8 RID: 248 RVA: 0x00002606 File Offset: 0x00000806
		// Note: this type is marked as 'beforefieldinit'.
		static JsonConverterCollection()
		{
			Il2CppClassPointerStore<JsonConverterCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json", "JsonConverterCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonConverterCollection>.NativeClassPtr);
			JsonConverterCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConverterCollection>.NativeClassPtr, 100663442);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00015E08 File Offset: 0x00014008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727939, XrefRangeEnd = 727942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonConverterCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonConverterCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConverterCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000263F File Offset: 0x0000083F
		public JsonConverterCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
