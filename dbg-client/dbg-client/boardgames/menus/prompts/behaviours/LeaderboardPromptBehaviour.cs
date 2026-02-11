using System;
using dwd.core.prefabs.prefabProvider;
using dwd.core.ui.match.prompt.prompts;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace boardgames.menus.prompts.behaviours
{
	// Token: 0x02000207 RID: 519
	public class LeaderboardPromptBehaviour : PromptBehaviour<FlavoredDismissablePrompt>
	{
		// Token: 0x060017E1 RID: 6113 RVA: 0x0006B28C File Offset: 0x0006948C
		// Note: this type is marked as 'beforefieldinit'.
		static LeaderboardPromptBehaviour()
		{
			Il2CppClassPointerStore<LeaderboardPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts.behaviours", "LeaderboardPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderboardPromptBehaviour>.NativeClassPtr);
			LeaderboardPromptBehaviour.NativeFieldInfoPtr_providerInstantiator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardPromptBehaviour>.NativeClassPtr, "providerInstantiator");
			LeaderboardPromptBehaviour.NativeFieldInfoPtr_friendsOnlyToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardPromptBehaviour>.NativeClassPtr, "friendsOnlyToggle");
			LeaderboardPromptBehaviour.NativeFieldInfoPtr_scrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardPromptBehaviour>.NativeClassPtr, "scrollbar");
			LeaderboardPromptBehaviour.NativeFieldInfoPtr_friendsOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardPromptBehaviour>.NativeClassPtr, "friendsOnly");
			LeaderboardPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardPromptBehaviour>.NativeClassPtr, 100666782);
			LeaderboardPromptBehaviour.NativeMethodInfoPtr_Event_ToggleFriends_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardPromptBehaviour>.NativeClassPtr, 100666783);
			LeaderboardPromptBehaviour.NativeMethodInfoPtr_UpdateDisplay_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardPromptBehaviour>.NativeClassPtr, 100666784);
			LeaderboardPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardPromptBehaviour>.NativeClassPtr, 100666785);
		}

		// Token: 0x060017E2 RID: 6114 RVA: 0x0006B35C File Offset: 0x0006955C
		[CallerCount(0)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LeaderboardPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017E3 RID: 6115 RVA: 0x0006B398 File Offset: 0x00069598
		[CallerCount(0)]
		public unsafe void Event_ToggleFriends()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderboardPromptBehaviour.NativeMethodInfoPtr_Event_ToggleFriends_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017E4 RID: 6116 RVA: 0x0006B3CC File Offset: 0x000695CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525683, XrefRangeEnd = 525704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateDisplay(bool friends)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref friends;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LeaderboardPromptBehaviour.NativeMethodInfoPtr_UpdateDisplay_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017E5 RID: 6117 RVA: 0x0006B418 File Offset: 0x00069618
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 525707, RefRangeEnd = 525708, XrefRangeStart = 525704, XrefRangeEnd = 525707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LeaderboardPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeaderboardPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderboardPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017E6 RID: 6118 RVA: 0x0000D433 File Offset: 0x0000B633
		public LeaderboardPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x060017E7 RID: 6119 RVA: 0x0006B454 File Offset: 0x00069654
		// (set) Token: 0x060017E8 RID: 6120 RVA: 0x0000D43C File Offset: 0x0000B63C
		public unsafe ProviderInstantiator providerInstantiator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardPromptBehaviour.NativeFieldInfoPtr_providerInstantiator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProviderInstantiator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardPromptBehaviour.NativeFieldInfoPtr_providerInstantiator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x060017E9 RID: 6121 RVA: 0x0006B484 File Offset: 0x00069684
		// (set) Token: 0x060017EA RID: 6122 RVA: 0x0000D45B File Offset: 0x0000B65B
		public unsafe GameObject friendsOnlyToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardPromptBehaviour.NativeFieldInfoPtr_friendsOnlyToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardPromptBehaviour.NativeFieldInfoPtr_friendsOnlyToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x060017EB RID: 6123 RVA: 0x0006B4B4 File Offset: 0x000696B4
		// (set) Token: 0x060017EC RID: 6124 RVA: 0x0000D47A File Offset: 0x0000B67A
		public unsafe Scrollbar scrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardPromptBehaviour.NativeFieldInfoPtr_scrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardPromptBehaviour.NativeFieldInfoPtr_scrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x060017ED RID: 6125 RVA: 0x0006B4E4 File Offset: 0x000696E4
		// (set) Token: 0x060017EE RID: 6126 RVA: 0x0000D499 File Offset: 0x0000B699
		public unsafe bool friendsOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardPromptBehaviour.NativeFieldInfoPtr_friendsOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardPromptBehaviour.NativeFieldInfoPtr_friendsOnly)) = value;
			}
		}

		// Token: 0x04000EF8 RID: 3832
		private static readonly IntPtr NativeFieldInfoPtr_providerInstantiator;

		// Token: 0x04000EF9 RID: 3833
		private static readonly IntPtr NativeFieldInfoPtr_friendsOnlyToggle;

		// Token: 0x04000EFA RID: 3834
		private static readonly IntPtr NativeFieldInfoPtr_scrollbar;

		// Token: 0x04000EFB RID: 3835
		private static readonly IntPtr NativeFieldInfoPtr_friendsOnly;

		// Token: 0x04000EFC RID: 3836
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x04000EFD RID: 3837
		private static readonly IntPtr NativeMethodInfoPtr_Event_ToggleFriends_Public_Void_0;

		// Token: 0x04000EFE RID: 3838
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDisplay_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04000EFF RID: 3839
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
