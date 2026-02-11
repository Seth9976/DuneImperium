using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace boardgames.ranked.networking.responses
{
	// Token: 0x02000016 RID: 22
	public class RankedUserRegistered : RankedQueueInfo
	{
		// Token: 0x06000086 RID: 134 RVA: 0x0000262C File Offset: 0x0000082C
		// Note: this type is marked as 'beforefieldinit'.
		static RankedUserRegistered()
		{
			Il2CppClassPointerStore<RankedUserRegistered>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-ranked.dll", "boardgames.ranked.networking.responses", "RankedUserRegistered");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedUserRegistered>.NativeClassPtr);
			RankedUserRegistered.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedUserRegistered>.NativeClassPtr, 100663327);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00004CC8 File Offset: 0x00002EC8
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankedUserRegistered()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankedUserRegistered>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedUserRegistered.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002665 File Offset: 0x00000865
		public RankedUserRegistered(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
