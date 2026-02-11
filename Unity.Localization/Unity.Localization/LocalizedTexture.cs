using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Localization
{
	// Token: 0x0200000D RID: 13
	[Serializable]
	public class LocalizedTexture : LocalizedAsset<Texture>
	{
		// Token: 0x06000081 RID: 129 RVA: 0x00002389 File Offset: 0x00000589
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizedTexture()
		{
			Il2CppClassPointerStore<LocalizedTexture>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization", "LocalizedTexture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedTexture>.NativeClassPtr);
			LocalizedTexture.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedTexture>.NativeClassPtr, 100663387);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000ADFC File Offset: 0x00008FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065417, XrefRangeEnd = 1065420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizedTexture()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedTexture>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedTexture.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000023C2 File Offset: 0x000005C2
		public LocalizedTexture(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
