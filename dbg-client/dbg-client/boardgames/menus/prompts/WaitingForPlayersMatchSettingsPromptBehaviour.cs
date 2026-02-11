using System;
using boardgames.data;
using boardgames.utils;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using TMPro;
using UnityEngine;

namespace boardgames.menus.prompts
{
	// Token: 0x020001DF RID: 479
	public class WaitingForPlayersMatchSettingsPromptBehaviour : PromptBehaviour<WaitingForPlayersPrompt>
	{
		// Token: 0x06001630 RID: 5680 RVA: 0x0006520C File Offset: 0x0006340C
		// Note: this type is marked as 'beforefieldinit'.
		static WaitingForPlayersMatchSettingsPromptBehaviour()
		{
			Il2CppClassPointerStore<WaitingForPlayersMatchSettingsPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "WaitingForPlayersMatchSettingsPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitingForPlayersMatchSettingsPromptBehaviour>.NativeClassPtr);
			WaitingForPlayersMatchSettingsPromptBehaviour.NativeFieldInfoPtr_hasPassword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitingForPlayersMatchSettingsPromptBehaviour>.NativeClassPtr, "hasPassword");
			WaitingForPlayersMatchSettingsPromptBehaviour.NativeFieldInfoPtr_timersText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitingForPlayersMatchSettingsPromptBehaviour>.NativeClassPtr, "timersText");
			WaitingForPlayersMatchSettingsPromptBehaviour.NativeFieldInfoPtr_aiDifficultyText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitingForPlayersMatchSettingsPromptBehaviour>.NativeClassPtr, "aiDifficultyText");
			WaitingForPlayersMatchSettingsPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersMatchSettingsPromptBehaviour>.NativeClassPtr, 100666540);
			WaitingForPlayersMatchSettingsPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersMatchSettingsPromptBehaviour>.NativeClassPtr, 100666541);
		}

		// Token: 0x06001631 RID: 5681 RVA: 0x000652A0 File Offset: 0x000634A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 523895, RefRangeEnd = 523896, XrefRangeStart = 523826, XrefRangeEnd = 523895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaitingForPlayersMatchSettingsPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001632 RID: 5682 RVA: 0x000652DC File Offset: 0x000634DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 523899, RefRangeEnd = 523900, XrefRangeStart = 523896, XrefRangeEnd = 523899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaitingForPlayersMatchSettingsPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitingForPlayersMatchSettingsPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersMatchSettingsPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001633 RID: 5683 RVA: 0x0000C8F6 File Offset: 0x0000AAF6
		public WaitingForPlayersMatchSettingsPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06001634 RID: 5684 RVA: 0x00065318 File Offset: 0x00063518
		// (set) Token: 0x06001635 RID: 5685 RVA: 0x0000C8FF File Offset: 0x0000AAFF
		public unsafe GameObject hasPassword
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersMatchSettingsPromptBehaviour.NativeFieldInfoPtr_hasPassword);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersMatchSettingsPromptBehaviour.NativeFieldInfoPtr_hasPassword), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06001636 RID: 5686 RVA: 0x00065348 File Offset: 0x00063548
		// (set) Token: 0x06001637 RID: 5687 RVA: 0x0000C91E File Offset: 0x0000AB1E
		public unsafe TMP_Text timersText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersMatchSettingsPromptBehaviour.NativeFieldInfoPtr_timersText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersMatchSettingsPromptBehaviour.NativeFieldInfoPtr_timersText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06001638 RID: 5688 RVA: 0x00065378 File Offset: 0x00063578
		// (set) Token: 0x06001639 RID: 5689 RVA: 0x0000C93D File Offset: 0x0000AB3D
		public unsafe TMP_Text aiDifficultyText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersMatchSettingsPromptBehaviour.NativeFieldInfoPtr_aiDifficultyText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersMatchSettingsPromptBehaviour.NativeFieldInfoPtr_aiDifficultyText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000DBD RID: 3517
		private static readonly IntPtr NativeFieldInfoPtr_hasPassword;

		// Token: 0x04000DBE RID: 3518
		private static readonly IntPtr NativeFieldInfoPtr_timersText;

		// Token: 0x04000DBF RID: 3519
		private static readonly IntPtr NativeFieldInfoPtr_aiDifficultyText;

		// Token: 0x04000DC0 RID: 3520
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x04000DC1 RID: 3521
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003CD RID: 973
		[ObfuscatedName("boardgames.menus.prompts.WaitingForPlayersMatchSettingsPromptBehaviour+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002D5B RID: 11611 RVA: 0x000AFF28 File Offset: 0x000AE128
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<WaitingForPlayersMatchSettingsPromptBehaviour.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WaitingForPlayersMatchSettingsPromptBehaviour>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitingForPlayersMatchSettingsPromptBehaviour.__c__DisplayClass3_0>.NativeClassPtr);
				WaitingForPlayersMatchSettingsPromptBehaviour.__c__DisplayClass3_0.NativeFieldInfoPtr_matchOptionsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitingForPlayersMatchSettingsPromptBehaviour.__c__DisplayClass3_0>.NativeClassPtr, "matchOptionsData");
				WaitingForPlayersMatchSettingsPromptBehaviour.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersMatchSettingsPromptBehaviour.__c__DisplayClass3_0>.NativeClassPtr, 100666542);
				WaitingForPlayersMatchSettingsPromptBehaviour.__c__DisplayClass3_0.NativeMethodInfoPtr__initialize_b__0_Internal_Boolean_ValueTuple_2_AIDifficultyLevels_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersMatchSettingsPromptBehaviour.__c__DisplayClass3_0>.NativeClassPtr, 100666543);
			}

			// Token: 0x06002D5C RID: 11612 RVA: 0x000AFF90 File Offset: 0x000AE190
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitingForPlayersMatchSettingsPromptBehaviour.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersMatchSettingsPromptBehaviour.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D5D RID: 11613 RVA: 0x000AFFCC File Offset: 0x000AE1CC
			[CallerCount(0)]
			public unsafe bool _initialize_b__0(ValueTuple<DBGConstants.AIDifficultyLevels, string> aiDifficultyLevelName)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(aiDifficultyLevelName));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersMatchSettingsPromptBehaviour.__c__DisplayClass3_0.NativeMethodInfoPtr__initialize_b__0_Internal_Boolean_ValueTuple_2_AIDifficultyLevels_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002D5E RID: 11614 RVA: 0x0001778C File Offset: 0x0001598C
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CE3 RID: 3299
			// (get) Token: 0x06002D5F RID: 11615 RVA: 0x000B0020 File Offset: 0x000AE220
			// (set) Token: 0x06002D60 RID: 11616 RVA: 0x00017795 File Offset: 0x00015995
			public unsafe DBGMatchConfigData matchOptionsData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersMatchSettingsPromptBehaviour.__c__DisplayClass3_0.NativeFieldInfoPtr_matchOptionsData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGMatchConfigData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersMatchSettingsPromptBehaviour.__c__DisplayClass3_0.NativeFieldInfoPtr_matchOptionsData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001C20 RID: 7200
			private static readonly IntPtr NativeFieldInfoPtr_matchOptionsData;

			// Token: 0x04001C21 RID: 7201
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001C22 RID: 7202
			private static readonly IntPtr NativeMethodInfoPtr__initialize_b__0_Internal_Boolean_ValueTuple_2_AIDifficultyLevels_String_0;
		}
	}
}
