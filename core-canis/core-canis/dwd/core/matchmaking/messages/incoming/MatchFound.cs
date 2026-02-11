using System;
using Canis.json.events;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.matchmaking.messages.incoming
{
	// Token: 0x0200012C RID: 300
	public class MatchFound : NetworkMessageEvent
	{
		// Token: 0x060010EF RID: 4335 RVA: 0x00056BDC File Offset: 0x00054DDC
		// Note: this type is marked as 'beforefieldinit'.
		static MatchFound()
		{
			Il2CppClassPointerStore<MatchFound>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.matchmaking.messages.incoming", "MatchFound");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchFound>.NativeClassPtr);
			MatchFound.NativeFieldInfoPtr_GameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchFound>.NativeClassPtr, "GameID");
			MatchFound.NativeFieldInfoPtr_Players = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchFound>.NativeClassPtr, "Players");
			MatchFound.NativeFieldInfoPtr_GameOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchFound>.NativeClassPtr, "GameOptions");
			MatchFound.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchFound>.NativeClassPtr, 100665763);
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x00056C5C File Offset: 0x00054E5C
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MatchFound()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchFound>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchFound.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010F1 RID: 4337 RVA: 0x00007E8A File Offset: 0x0000608A
		public MatchFound(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x060010F2 RID: 4338 RVA: 0x00056C98 File Offset: 0x00054E98
		// (set) Token: 0x060010F3 RID: 4339 RVA: 0x00007E93 File Offset: 0x00006093
		public unsafe GameID GameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchFound.NativeFieldInfoPtr_GameID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchFound.NativeFieldInfoPtr_GameID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x060010F4 RID: 4340 RVA: 0x00056CC8 File Offset: 0x00054EC8
		// (set) Token: 0x060010F5 RID: 4341 RVA: 0x00007EB2 File Offset: 0x000060B2
		public unsafe Il2CppReferenceArray<AccountID> Players
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchFound.NativeFieldInfoPtr_Players);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AccountID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchFound.NativeFieldInfoPtr_Players), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x060010F6 RID: 4342 RVA: 0x00056CF8 File Offset: 0x00054EF8
		// (set) Token: 0x060010F7 RID: 4343 RVA: 0x00007ED1 File Offset: 0x000060D1
		public unsafe Dictionary<string, string> GameOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchFound.NativeFieldInfoPtr_GameOptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchFound.NativeFieldInfoPtr_GameOptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C04 RID: 3076
		private static readonly IntPtr NativeFieldInfoPtr_GameID;

		// Token: 0x04000C05 RID: 3077
		private static readonly IntPtr NativeFieldInfoPtr_Players;

		// Token: 0x04000C06 RID: 3078
		private static readonly IntPtr NativeFieldInfoPtr_GameOptions;

		// Token: 0x04000C07 RID: 3079
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
