using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.data.leaderboards
{
	// Token: 0x020001D5 RID: 469
	public class LeaderBoardQueryFailed : NetworkMessageEvent
	{
		// Token: 0x060019E2 RID: 6626 RVA: 0x0007AD10 File Offset: 0x00078F10
		// Note: this type is marked as 'beforefieldinit'.
		static LeaderBoardQueryFailed()
		{
			Il2CppClassPointerStore<LeaderBoardQueryFailed>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.data.leaderboards", "LeaderBoardQueryFailed");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderBoardQueryFailed>.NativeClassPtr);
			LeaderBoardQueryFailed.NativeFieldInfoPtr_Error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderBoardQueryFailed>.NativeClassPtr, "Error");
			LeaderBoardQueryFailed.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderBoardQueryFailed>.NativeClassPtr, 100667400);
		}

		// Token: 0x060019E3 RID: 6627 RVA: 0x0007AD68 File Offset: 0x00078F68
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LeaderBoardQueryFailed()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeaderBoardQueryFailed>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderBoardQueryFailed.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019E4 RID: 6628 RVA: 0x0000B4B5 File Offset: 0x000096B5
		public LeaderBoardQueryFailed(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x060019E5 RID: 6629 RVA: 0x0007ADA4 File Offset: 0x00078FA4
		// (set) Token: 0x060019E6 RID: 6630 RVA: 0x0000B4BE File Offset: 0x000096BE
		public unsafe string Error
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderBoardQueryFailed.NativeFieldInfoPtr_Error);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderBoardQueryFailed.NativeFieldInfoPtr_Error), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400122A RID: 4650
		private static readonly IntPtr NativeFieldInfoPtr_Error;

		// Token: 0x0400122B RID: 4651
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
