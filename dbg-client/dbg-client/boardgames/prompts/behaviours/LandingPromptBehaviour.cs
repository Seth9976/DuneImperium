using System;
using boardgames.menus.prompts;
using dwd.core.ui.prompt.behaviours;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace boardgames.prompts.behaviours
{
	// Token: 0x02000101 RID: 257
	public class LandingPromptBehaviour : PromptBehaviour<LandingPrompt>
	{
		// Token: 0x06000AFF RID: 2815 RVA: 0x00040628 File Offset: 0x0003E828
		// Note: this type is marked as 'beforefieldinit'.
		static LandingPromptBehaviour()
		{
			Il2CppClassPointerStore<LandingPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.prompts.behaviours", "LandingPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LandingPromptBehaviour>.NativeClassPtr);
			LandingPromptBehaviour.NativeMethodInfoPtr_Event_CloseFriendsList_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingPromptBehaviour>.NativeClassPtr, 100664905);
			LandingPromptBehaviour.NativeMethodInfoPtr_Event_Tutorials_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingPromptBehaviour>.NativeClassPtr, 100664906);
			LandingPromptBehaviour.NativeMethodInfoPtr_Event_SinglePlayerModes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingPromptBehaviour>.NativeClassPtr, 100664907);
			LandingPromptBehaviour.NativeMethodInfoPtr_Event_MultiPlayerModes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingPromptBehaviour>.NativeClassPtr, 100664908);
			LandingPromptBehaviour.NativeMethodInfoPtr_Event_PlayerStats_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingPromptBehaviour>.NativeClassPtr, 100664909);
			LandingPromptBehaviour.NativeMethodInfoPtr_Event_Quit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingPromptBehaviour>.NativeClassPtr, 100664910);
			LandingPromptBehaviour.NativeMethodInfoPtr_Event_Shop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingPromptBehaviour>.NativeClassPtr, 100664911);
			LandingPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingPromptBehaviour>.NativeClassPtr, 100664912);
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x000406F8 File Offset: 0x0003E8F8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 507607, RefRangeEnd = 507613, XrefRangeStart = 507600, XrefRangeEnd = 507607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_CloseFriendsList()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingPromptBehaviour.NativeMethodInfoPtr_Event_CloseFriendsList_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x0004072C File Offset: 0x0003E92C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507613, XrefRangeEnd = 507619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Tutorials()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingPromptBehaviour.NativeMethodInfoPtr_Event_Tutorials_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x00040760 File Offset: 0x0003E960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507619, XrefRangeEnd = 507625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SinglePlayerModes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingPromptBehaviour.NativeMethodInfoPtr_Event_SinglePlayerModes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x00040794 File Offset: 0x0003E994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507625, XrefRangeEnd = 507631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_MultiPlayerModes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingPromptBehaviour.NativeMethodInfoPtr_Event_MultiPlayerModes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x000407C8 File Offset: 0x0003E9C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507631, XrefRangeEnd = 507637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_PlayerStats()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingPromptBehaviour.NativeMethodInfoPtr_Event_PlayerStats_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x000407FC File Offset: 0x0003E9FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507637, XrefRangeEnd = 507673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Quit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingPromptBehaviour.NativeMethodInfoPtr_Event_Quit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x00040830 File Offset: 0x0003EA30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507673, XrefRangeEnd = 507678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Shop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingPromptBehaviour.NativeMethodInfoPtr_Event_Shop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x00040864 File Offset: 0x0003EA64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507678, XrefRangeEnd = 507681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LandingPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LandingPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x000073C4 File Offset: 0x000055C4
		public LandingPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040006C2 RID: 1730
		private static readonly IntPtr NativeMethodInfoPtr_Event_CloseFriendsList_Public_Void_0;

		// Token: 0x040006C3 RID: 1731
		private static readonly IntPtr NativeMethodInfoPtr_Event_Tutorials_Public_Void_0;

		// Token: 0x040006C4 RID: 1732
		private static readonly IntPtr NativeMethodInfoPtr_Event_SinglePlayerModes_Public_Void_0;

		// Token: 0x040006C5 RID: 1733
		private static readonly IntPtr NativeMethodInfoPtr_Event_MultiPlayerModes_Public_Void_0;

		// Token: 0x040006C6 RID: 1734
		private static readonly IntPtr NativeMethodInfoPtr_Event_PlayerStats_Public_Void_0;

		// Token: 0x040006C7 RID: 1735
		private static readonly IntPtr NativeMethodInfoPtr_Event_Quit_Public_Void_0;

		// Token: 0x040006C8 RID: 1736
		private static readonly IntPtr NativeMethodInfoPtr_Event_Shop_Public_Void_0;

		// Token: 0x040006C9 RID: 1737
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200033F RID: 831
		[ObfuscatedName("boardgames.prompts.behaviours.LandingPromptBehaviour+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x06002758 RID: 10072 RVA: 0x0009E280 File Offset: 0x0009C480
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<LandingPromptBehaviour.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LandingPromptBehaviour>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LandingPromptBehaviour.__c__DisplayClass5_0>.NativeClassPtr);
				LandingPromptBehaviour.__c__DisplayClass5_0.NativeFieldInfoPtr_choice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingPromptBehaviour.__c__DisplayClass5_0>.NativeClassPtr, "choice");
				LandingPromptBehaviour.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingPromptBehaviour.__c__DisplayClass5_0>.NativeClassPtr, 100664913);
				LandingPromptBehaviour.__c__DisplayClass5_0.NativeMethodInfoPtr__Event_Quit_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingPromptBehaviour.__c__DisplayClass5_0>.NativeClassPtr, 100664914);
			}

			// Token: 0x06002759 RID: 10073 RVA: 0x0009E2E8 File Offset: 0x0009C4E8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LandingPromptBehaviour.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingPromptBehaviour.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600275A RID: 10074 RVA: 0x0009E324 File Offset: 0x0009C524
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507595, XrefRangeEnd = 507600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Event_Quit_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingPromptBehaviour.__c__DisplayClass5_0.NativeMethodInfoPtr__Event_Quit_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600275B RID: 10075 RVA: 0x000146C1 File Offset: 0x000128C1
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AFA RID: 2810
			// (get) Token: 0x0600275C RID: 10076 RVA: 0x0009E358 File Offset: 0x0009C558
			// (set) Token: 0x0600275D RID: 10077 RVA: 0x000146CA File Offset: 0x000128CA
			public unsafe ConfirmOrDenyPrompt choice
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingPromptBehaviour.__c__DisplayClass5_0.NativeFieldInfoPtr_choice);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfirmOrDenyPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingPromptBehaviour.__c__DisplayClass5_0.NativeFieldInfoPtr_choice), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040018AF RID: 6319
			private static readonly IntPtr NativeFieldInfoPtr_choice;

			// Token: 0x040018B0 RID: 6320
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040018B1 RID: 6321
			private static readonly IntPtr NativeMethodInfoPtr__Event_Quit_b__0_Internal_Void_0;
		}
	}
}
