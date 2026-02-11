using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace boardgames.animation
{
	// Token: 0x020002BD RID: 701
	public class LiveUpdateAnimationSpeedController : AnimationSpeedController
	{
		// Token: 0x06002107 RID: 8455 RVA: 0x0008B58C File Offset: 0x0008978C
		// Note: this type is marked as 'beforefieldinit'.
		static LiveUpdateAnimationSpeedController()
		{
			Il2CppClassPointerStore<LiveUpdateAnimationSpeedController>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.animation", "LiveUpdateAnimationSpeedController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiveUpdateAnimationSpeedController>.NativeClassPtr);
			LiveUpdateAnimationSpeedController.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiveUpdateAnimationSpeedController>.NativeClassPtr, "version");
			LiveUpdateAnimationSpeedController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiveUpdateAnimationSpeedController>.NativeClassPtr, 100668763);
			LiveUpdateAnimationSpeedController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiveUpdateAnimationSpeedController>.NativeClassPtr, 100668764);
		}

		// Token: 0x06002108 RID: 8456 RVA: 0x0008B5F8 File Offset: 0x000897F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542928, XrefRangeEnd = 542938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiveUpdateAnimationSpeedController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002109 RID: 8457 RVA: 0x0008B62C File Offset: 0x0008982C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LiveUpdateAnimationSpeedController()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiveUpdateAnimationSpeedController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiveUpdateAnimationSpeedController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600210A RID: 8458 RVA: 0x0001145D File Offset: 0x0000F65D
		public LiveUpdateAnimationSpeedController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x0600210B RID: 8459 RVA: 0x0008B668 File Offset: 0x00089868
		// (set) Token: 0x0600210C RID: 8460 RVA: 0x00011466 File Offset: 0x0000F666
		public unsafe ulong version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiveUpdateAnimationSpeedController.NativeFieldInfoPtr_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiveUpdateAnimationSpeedController.NativeFieldInfoPtr_version)) = value;
			}
		}

		// Token: 0x040014D1 RID: 5329
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x040014D2 RID: 5330
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040014D3 RID: 5331
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
