using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace boardgames.data
{
	// Token: 0x02000144 RID: 324
	public class LeaderboardsData : DataComponent
	{
		// Token: 0x060010A0 RID: 4256 RVA: 0x00044254 File Offset: 0x00042454
		// Note: this type is marked as 'beforefieldinit'.
		static LeaderboardsData()
		{
			Il2CppClassPointerStore<LeaderboardsData>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.data", "LeaderboardsData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderboardsData>.NativeClassPtr);
			LeaderboardsData.NativeFieldInfoPtr_AllRanks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsData>.NativeClassPtr, "AllRanks");
			LeaderboardsData.NativeFieldInfoPtr_FriendRanks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsData>.NativeClassPtr, "FriendRanks");
			LeaderboardsData.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsData>.NativeClassPtr, 100665726);
			LeaderboardsData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsData>.NativeClassPtr, 100665727);
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x060010A1 RID: 4257 RVA: 0x000442D4 File Offset: 0x000424D4
		public unsafe virtual ulong Version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderboardsData.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010A2 RID: 4258 RVA: 0x00044310 File Offset: 0x00042510
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 999418, RefRangeEnd = 999421, XrefRangeStart = 999405, XrefRangeEnd = 999418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LeaderboardsData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeaderboardsData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderboardsData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010A3 RID: 4259 RVA: 0x00009B65 File Offset: 0x00007D65
		public LeaderboardsData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x060010A4 RID: 4260 RVA: 0x0004434C File Offset: 0x0004254C
		// (set) Token: 0x060010A5 RID: 4261 RVA: 0x00009B6E File Offset: 0x00007D6E
		public unsafe VersionedList<DataComposition> AllRanks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardsData.NativeFieldInfoPtr_AllRanks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VersionedList<DataComposition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardsData.NativeFieldInfoPtr_AllRanks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x060010A6 RID: 4262 RVA: 0x0004437C File Offset: 0x0004257C
		// (set) Token: 0x060010A7 RID: 4263 RVA: 0x00009B8D File Offset: 0x00007D8D
		public unsafe VersionedList<DataComposition> FriendRanks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardsData.NativeFieldInfoPtr_FriendRanks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VersionedList<DataComposition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardsData.NativeFieldInfoPtr_FriendRanks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A22 RID: 2594
		private static readonly IntPtr NativeFieldInfoPtr_AllRanks;

		// Token: 0x04000A23 RID: 2595
		private static readonly IntPtr NativeFieldInfoPtr_FriendRanks;

		// Token: 0x04000A24 RID: 2596
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0;

		// Token: 0x04000A25 RID: 2597
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
