using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Localization
{
	// Token: 0x0200000C RID: 12
	[Serializable]
	public class LocalizedSprite : LocalizedAsset<Sprite>
	{
		// Token: 0x0600007E RID: 126 RVA: 0x00002347 File Offset: 0x00000547
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizedSprite()
		{
			Il2CppClassPointerStore<LocalizedSprite>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization", "LocalizedSprite");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedSprite>.NativeClassPtr);
			LocalizedSprite.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedSprite>.NativeClassPtr, 100663386);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000ADC0 File Offset: 0x00008FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065414, XrefRangeEnd = 1065417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizedSprite()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedSprite>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedSprite.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002380 File Offset: 0x00000580
		public LocalizedSprite(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
