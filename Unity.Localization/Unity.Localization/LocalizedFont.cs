using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Localization
{
	// Token: 0x0200000F RID: 15
	[Serializable]
	public class LocalizedFont : LocalizedAsset<Font>
	{
		// Token: 0x06000087 RID: 135 RVA: 0x0000240D File Offset: 0x0000060D
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizedFont()
		{
			Il2CppClassPointerStore<LocalizedFont>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization", "LocalizedFont");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedFont>.NativeClassPtr);
			LocalizedFont.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedFont>.NativeClassPtr, 100663389);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000AE74 File Offset: 0x00009074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065423, XrefRangeEnd = 1065426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizedFont()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedFont>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedFont.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002446 File Offset: 0x00000646
		public LocalizedFont(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
