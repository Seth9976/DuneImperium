using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.Events;

namespace UnityEngine.Localization.Events
{
	// Token: 0x020000C2 RID: 194
	[Serializable]
	public class UnityEventSprite : UnityEvent<Sprite>
	{
		// Token: 0x06000A6A RID: 2666 RVA: 0x0000650E File Offset: 0x0000470E
		// Note: this type is marked as 'beforefieldinit'.
		static UnityEventSprite()
		{
			Il2CppClassPointerStore<UnityEventSprite>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Events", "UnityEventSprite");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityEventSprite>.NativeClassPtr);
			UnityEventSprite.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventSprite>.NativeClassPtr, 100665046);
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x00030900 File Offset: 0x0002EB00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078750, XrefRangeEnd = 1078753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEventSprite()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityEventSprite>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventSprite.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x00006547 File Offset: 0x00004747
		public UnityEventSprite(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000750 RID: 1872
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
