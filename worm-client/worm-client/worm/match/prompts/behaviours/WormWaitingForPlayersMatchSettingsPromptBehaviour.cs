using System;
using boardgames.menus.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;

namespace worm.match.prompts.behaviours
{
	// Token: 0x020000EB RID: 235
	public class WormWaitingForPlayersMatchSettingsPromptBehaviour : WaitingForPlayersMatchSettingsPromptBehaviour
	{
		// Token: 0x06000A7A RID: 2682 RVA: 0x00037F48 File Offset: 0x00036148
		// Note: this type is marked as 'beforefieldinit'.
		static WormWaitingForPlayersMatchSettingsPromptBehaviour()
		{
			Il2CppClassPointerStore<WormWaitingForPlayersMatchSettingsPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.behaviours", "WormWaitingForPlayersMatchSettingsPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormWaitingForPlayersMatchSettingsPromptBehaviour>.NativeClassPtr);
			WormWaitingForPlayersMatchSettingsPromptBehaviour.NativeFieldInfoPtr_leaderSelectionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormWaitingForPlayersMatchSettingsPromptBehaviour>.NativeClassPtr, "leaderSelectionText");
			WormWaitingForPlayersMatchSettingsPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWaitingForPlayersMatchSettingsPromptBehaviour>.NativeClassPtr, 100664734);
			WormWaitingForPlayersMatchSettingsPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWaitingForPlayersMatchSettingsPromptBehaviour>.NativeClassPtr, 100664735);
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x00037FB4 File Offset: 0x000361B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701618, XrefRangeEnd = 701652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormWaitingForPlayersMatchSettingsPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x00037FF0 File Offset: 0x000361F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701652, XrefRangeEnd = 701653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormWaitingForPlayersMatchSettingsPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormWaitingForPlayersMatchSettingsPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormWaitingForPlayersMatchSettingsPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x000077C2 File Offset: 0x000059C2
		public WormWaitingForPlayersMatchSettingsPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000A7E RID: 2686 RVA: 0x0003802C File Offset: 0x0003622C
		// (set) Token: 0x06000A7F RID: 2687 RVA: 0x000077CB File Offset: 0x000059CB
		public unsafe TMP_Text leaderSelectionText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWaitingForPlayersMatchSettingsPromptBehaviour.NativeFieldInfoPtr_leaderSelectionText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWaitingForPlayersMatchSettingsPromptBehaviour.NativeFieldInfoPtr_leaderSelectionText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400060D RID: 1549
		private static readonly IntPtr NativeFieldInfoPtr_leaderSelectionText;

		// Token: 0x0400060E RID: 1550
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x0400060F RID: 1551
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
