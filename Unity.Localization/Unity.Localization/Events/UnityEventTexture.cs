using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.Events;

namespace UnityEngine.Localization.Events
{
	// Token: 0x020000C4 RID: 196
	[Serializable]
	public class UnityEventTexture : UnityEvent<Texture>
	{
		// Token: 0x06000A70 RID: 2672 RVA: 0x00006592 File Offset: 0x00004792
		// Note: this type is marked as 'beforefieldinit'.
		static UnityEventTexture()
		{
			Il2CppClassPointerStore<UnityEventTexture>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Events", "UnityEventTexture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityEventTexture>.NativeClassPtr);
			UnityEventTexture.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventTexture>.NativeClassPtr, 100665048);
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x00030978 File Offset: 0x0002EB78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078756, XrefRangeEnd = 1078759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEventTexture()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityEventTexture>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventTexture.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x000065CB File Offset: 0x000047CB
		public UnityEventTexture(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000752 RID: 1874
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
