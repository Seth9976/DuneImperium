using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace lotus.src.audio.background
{
	// Token: 0x02000017 RID: 23
	public class PlayTrackOnStart : PlayTrack
	{
		// Token: 0x060000D9 RID: 217 RVA: 0x000053D4 File Offset: 0x000035D4
		// Note: this type is marked as 'beforefieldinit'.
		static PlayTrackOnStart()
		{
			Il2CppClassPointerStore<PlayTrackOnStart>.NativeClassPtr = IL2CPP.GetIl2CppClass("audio.dll", "lotus.src.audio.background", "PlayTrackOnStart");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayTrackOnStart>.NativeClassPtr);
			PlayTrackOnStart.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayTrackOnStart>.NativeClassPtr, 100663400);
			PlayTrackOnStart.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayTrackOnStart>.NativeClassPtr, 100663401);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000542C File Offset: 0x0000362C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayTrackOnStart.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00005460 File Offset: 0x00003660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261883, XrefRangeEnd = 1261884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayTrackOnStart()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayTrackOnStart>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayTrackOnStart.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x000026B6 File Offset: 0x000008B6
		public PlayTrackOnStart(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
