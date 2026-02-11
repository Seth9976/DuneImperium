using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Canis.skirmishScripts
{
	// Token: 0x02000047 RID: 71
	public class DailyChallengeBadgeEarned : NetworkMessageEvent
	{
		// Token: 0x06000474 RID: 1140 RVA: 0x0002B3A8 File Offset: 0x000295A8
		// Note: this type is marked as 'beforefieldinit'.
		static DailyChallengeBadgeEarned()
		{
			Il2CppClassPointerStore<DailyChallengeBadgeEarned>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.skirmishScripts", "DailyChallengeBadgeEarned");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailyChallengeBadgeEarned>.NativeClassPtr);
			DailyChallengeBadgeEarned.NativeFieldInfoPtr_Rank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeBadgeEarned>.NativeClassPtr, "Rank");
			DailyChallengeBadgeEarned.NativeFieldInfoPtr_Badge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeBadgeEarned>.NativeClassPtr, "Badge");
			DailyChallengeBadgeEarned.NativeFieldInfoPtr_Date = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeBadgeEarned>.NativeClassPtr, "Date");
			DailyChallengeBadgeEarned.NativeFieldInfoPtr_Difficulty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeBadgeEarned>.NativeClassPtr, "Difficulty");
			DailyChallengeBadgeEarned.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeBadgeEarned>.NativeClassPtr, 100664239);
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x0002B43C File Offset: 0x0002963C
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DailyChallengeBadgeEarned()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailyChallengeBadgeEarned>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeBadgeEarned.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00003E4C File Offset: 0x0000204C
		public DailyChallengeBadgeEarned(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000477 RID: 1143 RVA: 0x0002B478 File Offset: 0x00029678
		// (set) Token: 0x06000478 RID: 1144 RVA: 0x00003E55 File Offset: 0x00002055
		public unsafe int Rank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeBadgeEarned.NativeFieldInfoPtr_Rank);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeBadgeEarned.NativeFieldInfoPtr_Rank)) = value;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000479 RID: 1145 RVA: 0x0002B4A0 File Offset: 0x000296A0
		// (set) Token: 0x0600047A RID: 1146 RVA: 0x00003E70 File Offset: 0x00002070
		public unsafe string Badge
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeBadgeEarned.NativeFieldInfoPtr_Badge);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeBadgeEarned.NativeFieldInfoPtr_Badge), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x0002B4C8 File Offset: 0x000296C8
		// (set) Token: 0x0600047C RID: 1148 RVA: 0x00003E8F File Offset: 0x0000208F
		public unsafe long Date
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeBadgeEarned.NativeFieldInfoPtr_Date);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeBadgeEarned.NativeFieldInfoPtr_Date)) = value;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x0600047D RID: 1149 RVA: 0x0002B4F0 File Offset: 0x000296F0
		// (set) Token: 0x0600047E RID: 1150 RVA: 0x00003EAA File Offset: 0x000020AA
		public unsafe int Difficulty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeBadgeEarned.NativeFieldInfoPtr_Difficulty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeBadgeEarned.NativeFieldInfoPtr_Difficulty)) = value;
			}
		}

		// Token: 0x040002E6 RID: 742
		private static readonly IntPtr NativeFieldInfoPtr_Rank;

		// Token: 0x040002E7 RID: 743
		private static readonly IntPtr NativeFieldInfoPtr_Badge;

		// Token: 0x040002E8 RID: 744
		private static readonly IntPtr NativeFieldInfoPtr_Date;

		// Token: 0x040002E9 RID: 745
		private static readonly IntPtr NativeFieldInfoPtr_Difficulty;

		// Token: 0x040002EA RID: 746
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
