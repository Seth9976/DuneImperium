using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.data.leaderboards
{
	// Token: 0x020001D4 RID: 468
	public class GetUserRankingView : Object
	{
		// Token: 0x060019D9 RID: 6617 RVA: 0x0007ABD4 File Offset: 0x00078DD4
		// Note: this type is marked as 'beforefieldinit'.
		static GetUserRankingView()
		{
			Il2CppClassPointerStore<GetUserRankingView>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.data.leaderboards", "GetUserRankingView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetUserRankingView>.NativeClassPtr);
			GetUserRankingView.NativeFieldInfoPtr_BoardNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetUserRankingView>.NativeClassPtr, "BoardNames");
			GetUserRankingView.NativeFieldInfoPtr_Above = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetUserRankingView>.NativeClassPtr, "Above");
			GetUserRankingView.NativeFieldInfoPtr_Below = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetUserRankingView>.NativeClassPtr, "Below");
			GetUserRankingView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetUserRankingView>.NativeClassPtr, 100667399);
		}

		// Token: 0x060019DA RID: 6618 RVA: 0x0007AC54 File Offset: 0x00078E54
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GetUserRankingView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetUserRankingView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetUserRankingView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019DB RID: 6619 RVA: 0x0000B457 File Offset: 0x00009657
		public GetUserRankingView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x060019DC RID: 6620 RVA: 0x0007AC90 File Offset: 0x00078E90
		// (set) Token: 0x060019DD RID: 6621 RVA: 0x0000B460 File Offset: 0x00009660
		public unsafe List<string> BoardNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetUserRankingView.NativeFieldInfoPtr_BoardNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetUserRankingView.NativeFieldInfoPtr_BoardNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x060019DE RID: 6622 RVA: 0x0007ACC0 File Offset: 0x00078EC0
		// (set) Token: 0x060019DF RID: 6623 RVA: 0x0000B47F File Offset: 0x0000967F
		public unsafe int Above
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetUserRankingView.NativeFieldInfoPtr_Above);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetUserRankingView.NativeFieldInfoPtr_Above)) = value;
			}
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x060019E0 RID: 6624 RVA: 0x0007ACE8 File Offset: 0x00078EE8
		// (set) Token: 0x060019E1 RID: 6625 RVA: 0x0000B49A File Offset: 0x0000969A
		public unsafe int Below
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetUserRankingView.NativeFieldInfoPtr_Below);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetUserRankingView.NativeFieldInfoPtr_Below)) = value;
			}
		}

		// Token: 0x04001226 RID: 4646
		private static readonly IntPtr NativeFieldInfoPtr_BoardNames;

		// Token: 0x04001227 RID: 4647
		private static readonly IntPtr NativeFieldInfoPtr_Above;

		// Token: 0x04001228 RID: 4648
		private static readonly IntPtr NativeFieldInfoPtr_Below;

		// Token: 0x04001229 RID: 4649
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
