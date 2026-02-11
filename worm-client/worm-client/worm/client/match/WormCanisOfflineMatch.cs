using System;
using boardgames.match.canis;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using worm.canis;

namespace worm.client.match
{
	// Token: 0x02000296 RID: 662
	public class WormCanisOfflineMatch : GenericDBGCanisOfflineMatch<WormMatch>
	{
		// Token: 0x06001B00 RID: 6912 RVA: 0x0000FAC0 File Offset: 0x0000DCC0
		// Note: this type is marked as 'beforefieldinit'.
		static WormCanisOfflineMatch()
		{
			Il2CppClassPointerStore<WormCanisOfflineMatch>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.client.match", "WormCanisOfflineMatch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormCanisOfflineMatch>.NativeClassPtr);
			WormCanisOfflineMatch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCanisOfflineMatch>.NativeClassPtr, 100667219);
		}

		// Token: 0x06001B01 RID: 6913 RVA: 0x0006AF68 File Offset: 0x00069168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723978, XrefRangeEnd = 723981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormCanisOfflineMatch()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormCanisOfflineMatch>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCanisOfflineMatch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B02 RID: 6914 RVA: 0x0000FAF9 File Offset: 0x0000DCF9
		public WormCanisOfflineMatch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F94 RID: 3988
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
