using System;
using dwd.core.ui.match.prompt.prompts;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.ranked.menus
{
	// Token: 0x0200001F RID: 31
	public class RankedLeaderboardPromptBehaviour : PromptBehaviour<FlavoredDismissablePrompt>
	{
		// Token: 0x060000F8 RID: 248 RVA: 0x00005E2C File Offset: 0x0000402C
		// Note: this type is marked as 'beforefieldinit'.
		static RankedLeaderboardPromptBehaviour()
		{
			Il2CppClassPointerStore<RankedLeaderboardPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-ranked.dll", "boardgames.ranked.menus", "RankedLeaderboardPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedLeaderboardPromptBehaviour>.NativeClassPtr);
			RankedLeaderboardPromptBehaviour.NativeFieldInfoPtr_entriesRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedLeaderboardPromptBehaviour>.NativeClassPtr, "entriesRoot");
			RankedLeaderboardPromptBehaviour.NativeFieldInfoPtr_entryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedLeaderboardPromptBehaviour>.NativeClassPtr, "entryPrefab");
			RankedLeaderboardPromptBehaviour.NativeFieldInfoPtr_currentPlayerDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedLeaderboardPromptBehaviour>.NativeClassPtr, "currentPlayerDisplay");
			RankedLeaderboardPromptBehaviour.NativeFieldInfoPtr_currentPlayerEntryRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedLeaderboardPromptBehaviour>.NativeClassPtr, "currentPlayerEntryRoot");
			RankedLeaderboardPromptBehaviour.NativeFieldInfoPtr_showEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedLeaderboardPromptBehaviour>.NativeClassPtr, "showEntries");
			RankedLeaderboardPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedLeaderboardPromptBehaviour>.NativeClassPtr, 100663351);
			RankedLeaderboardPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedLeaderboardPromptBehaviour>.NativeClassPtr, 100663352);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00005EE8 File Offset: 0x000040E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224992, XrefRangeEnd = 1225052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RankedLeaderboardPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00005F24 File Offset: 0x00004124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225052, XrefRangeEnd = 1225055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankedLeaderboardPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankedLeaderboardPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedLeaderboardPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002ABD File Offset: 0x00000CBD
		public RankedLeaderboardPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000FC RID: 252 RVA: 0x00005F60 File Offset: 0x00004160
		// (set) Token: 0x060000FD RID: 253 RVA: 0x00002AC6 File Offset: 0x00000CC6
		public unsafe Transform entriesRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedLeaderboardPromptBehaviour.NativeFieldInfoPtr_entriesRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedLeaderboardPromptBehaviour.NativeFieldInfoPtr_entriesRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000FE RID: 254 RVA: 0x00005F90 File Offset: 0x00004190
		// (set) Token: 0x060000FF RID: 255 RVA: 0x00002AE5 File Offset: 0x00000CE5
		public unsafe SubscriptionProvider entryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedLeaderboardPromptBehaviour.NativeFieldInfoPtr_entryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedLeaderboardPromptBehaviour.NativeFieldInfoPtr_entryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00005FC0 File Offset: 0x000041C0
		// (set) Token: 0x06000101 RID: 257 RVA: 0x00002B04 File Offset: 0x00000D04
		public unsafe GameObject currentPlayerDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedLeaderboardPromptBehaviour.NativeFieldInfoPtr_currentPlayerDisplay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedLeaderboardPromptBehaviour.NativeFieldInfoPtr_currentPlayerDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000102 RID: 258 RVA: 0x00005FF0 File Offset: 0x000041F0
		// (set) Token: 0x06000103 RID: 259 RVA: 0x00002B23 File Offset: 0x00000D23
		public unsafe Transform currentPlayerEntryRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedLeaderboardPromptBehaviour.NativeFieldInfoPtr_currentPlayerEntryRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedLeaderboardPromptBehaviour.NativeFieldInfoPtr_currentPlayerEntryRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000104 RID: 260 RVA: 0x00006020 File Offset: 0x00004220
		// (set) Token: 0x06000105 RID: 261 RVA: 0x00002B42 File Offset: 0x00000D42
		public unsafe int showEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedLeaderboardPromptBehaviour.NativeFieldInfoPtr_showEntries);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedLeaderboardPromptBehaviour.NativeFieldInfoPtr_showEntries)) = value;
			}
		}

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeFieldInfoPtr_entriesRoot;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeFieldInfoPtr_entryPrefab;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeFieldInfoPtr_currentPlayerDisplay;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeFieldInfoPtr_currentPlayerEntryRoot;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeFieldInfoPtr_showEntries;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
