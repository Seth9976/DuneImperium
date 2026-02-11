using System;
using Canis.utils.ids;
using dwd.core.match;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using lotus;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using worm.canis.data.enums;
using worm.match.prompts.prompts;

namespace worm.match.prompts.behaviours
{
	// Token: 0x020000C6 RID: 198
	public class WormChooseOpponentTroopsPromptBehaviour : PromptBehaviour<WormSelectEntityPrompt>
	{
		// Token: 0x06000831 RID: 2097 RVA: 0x000314DC File Offset: 0x0002F6DC
		// Note: this type is marked as 'beforefieldinit'.
		static WormChooseOpponentTroopsPromptBehaviour()
		{
			Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.behaviours", "WormChooseOpponentTroopsPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour>.NativeClassPtr);
			WormChooseOpponentTroopsPromptBehaviour.NativeFieldInfoPtr_selectedEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour>.NativeClassPtr, "selectedEntities");
			WormChooseOpponentTroopsPromptBehaviour.NativeFieldInfoPtr_players = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour>.NativeClassPtr, "players");
			WormChooseOpponentTroopsPromptBehaviour.NativeFieldInfoPtr_confirmButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour>.NativeClassPtr, "confirmButton");
			WormChooseOpponentTroopsPromptBehaviour.NativeFieldInfoPtr_cancelButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour>.NativeClassPtr, "cancelButton");
			WormChooseOpponentTroopsPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour>.NativeClassPtr, 100664388);
			WormChooseOpponentTroopsPromptBehaviour.NativeMethodInfoPtr_Event_Submit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour>.NativeClassPtr, 100664389);
			WormChooseOpponentTroopsPromptBehaviour.NativeMethodInfoPtr_attemptSubmit_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour>.NativeClassPtr, 100664390);
			WormChooseOpponentTroopsPromptBehaviour.NativeMethodInfoPtr_Event_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour>.NativeClassPtr, 100664391);
			WormChooseOpponentTroopsPromptBehaviour.NativeMethodInfoPtr_Event_IncrementTroop_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour>.NativeClassPtr, 100664392);
			WormChooseOpponentTroopsPromptBehaviour.NativeMethodInfoPtr_Event_IncrementDreadnought_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour>.NativeClassPtr, 100664393);
			WormChooseOpponentTroopsPromptBehaviour.NativeMethodInfoPtr_Event_DecrementTroop_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour>.NativeClassPtr, 100664394);
			WormChooseOpponentTroopsPromptBehaviour.NativeMethodInfoPtr_Event_DecrementDreadnought_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour>.NativeClassPtr, 100664395);
			WormChooseOpponentTroopsPromptBehaviour.NativeMethodInfoPtr_UpdateButtonStates_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour>.NativeClassPtr, 100664396);
			WormChooseOpponentTroopsPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour>.NativeClassPtr, 100664397);
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x00031624 File Offset: 0x0002F824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697867, XrefRangeEnd = 697956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormChooseOpponentTroopsPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x00031660 File Offset: 0x0002F860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697956, XrefRangeEnd = 697962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Submit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChooseOpponentTroopsPromptBehaviour.NativeMethodInfoPtr_Event_Submit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x00031694 File Offset: 0x0002F894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697962, XrefRangeEnd = 697967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator attemptSubmit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChooseOpponentTroopsPromptBehaviour.NativeMethodInfoPtr_attemptSubmit_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x000316D4 File Offset: 0x0002F8D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697967, XrefRangeEnd = 698003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChooseOpponentTroopsPromptBehaviour.NativeMethodInfoPtr_Event_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x00031708 File Offset: 0x0002F908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698003, XrefRangeEnd = 698053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_IncrementTroop(string color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChooseOpponentTroopsPromptBehaviour.NativeMethodInfoPtr_Event_IncrementTroop_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x0003174C File Offset: 0x0002F94C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698053, XrefRangeEnd = 698103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_IncrementDreadnought(string color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChooseOpponentTroopsPromptBehaviour.NativeMethodInfoPtr_Event_IncrementDreadnought_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x00031790 File Offset: 0x0002F990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698103, XrefRangeEnd = 698150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_DecrementTroop(string color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChooseOpponentTroopsPromptBehaviour.NativeMethodInfoPtr_Event_DecrementTroop_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x000317D4 File Offset: 0x0002F9D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698150, XrefRangeEnd = 698197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_DecrementDreadnought(string color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChooseOpponentTroopsPromptBehaviour.NativeMethodInfoPtr_Event_DecrementDreadnought_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x00031818 File Offset: 0x0002FA18
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 698234, RefRangeEnd = 698239, XrefRangeStart = 698197, XrefRangeEnd = 698234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateButtonStates()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChooseOpponentTroopsPromptBehaviour.NativeMethodInfoPtr_UpdateButtonStates_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x0003184C File Offset: 0x0002FA4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698239, XrefRangeEnd = 698256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormChooseOpponentTroopsPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChooseOpponentTroopsPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x000062DD File Offset: 0x000044DD
		public WormChooseOpponentTroopsPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x0600083D RID: 2109 RVA: 0x00031888 File Offset: 0x0002FA88
		// (set) Token: 0x0600083E RID: 2110 RVA: 0x000062E6 File Offset: 0x000044E6
		public unsafe List<EntityID> selectedEntities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.NativeFieldInfoPtr_selectedEntities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.NativeFieldInfoPtr_selectedEntities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x0600083F RID: 2111 RVA: 0x000318B8 File Offset: 0x0002FAB8
		// (set) Token: 0x06000840 RID: 2112 RVA: 0x00006305 File Offset: 0x00004505
		public unsafe List<WormChooseOpponentTroopsPromptBehaviour.Player> players
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.NativeFieldInfoPtr_players);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WormChooseOpponentTroopsPromptBehaviour.Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.NativeFieldInfoPtr_players), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000841 RID: 2113 RVA: 0x000318E8 File Offset: 0x0002FAE8
		// (set) Token: 0x06000842 RID: 2114 RVA: 0x00006324 File Offset: 0x00004524
		public unsafe Button confirmButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.NativeFieldInfoPtr_confirmButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.NativeFieldInfoPtr_confirmButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000843 RID: 2115 RVA: 0x00031918 File Offset: 0x0002FB18
		// (set) Token: 0x06000844 RID: 2116 RVA: 0x00006343 File Offset: 0x00004543
		public unsafe Button cancelButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.NativeFieldInfoPtr_cancelButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.NativeFieldInfoPtr_cancelButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004B3 RID: 1203
		private static readonly IntPtr NativeFieldInfoPtr_selectedEntities;

		// Token: 0x040004B4 RID: 1204
		private static readonly IntPtr NativeFieldInfoPtr_players;

		// Token: 0x040004B5 RID: 1205
		private static readonly IntPtr NativeFieldInfoPtr_confirmButton;

		// Token: 0x040004B6 RID: 1206
		private static readonly IntPtr NativeFieldInfoPtr_cancelButton;

		// Token: 0x040004B7 RID: 1207
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x040004B8 RID: 1208
		private static readonly IntPtr NativeMethodInfoPtr_Event_Submit_Public_Void_0;

		// Token: 0x040004B9 RID: 1209
		private static readonly IntPtr NativeMethodInfoPtr_attemptSubmit_Private_IEnumerator_0;

		// Token: 0x040004BA RID: 1210
		private static readonly IntPtr NativeMethodInfoPtr_Event_Cancel_Public_Void_0;

		// Token: 0x040004BB RID: 1211
		private static readonly IntPtr NativeMethodInfoPtr_Event_IncrementTroop_Public_Void_String_0;

		// Token: 0x040004BC RID: 1212
		private static readonly IntPtr NativeMethodInfoPtr_Event_IncrementDreadnought_Public_Void_String_0;

		// Token: 0x040004BD RID: 1213
		private static readonly IntPtr NativeMethodInfoPtr_Event_DecrementTroop_Public_Void_String_0;

		// Token: 0x040004BE RID: 1214
		private static readonly IntPtr NativeMethodInfoPtr_Event_DecrementDreadnought_Public_Void_String_0;

		// Token: 0x040004BF RID: 1215
		private static readonly IntPtr NativeMethodInfoPtr_UpdateButtonStates_Private_Void_0;

		// Token: 0x040004C0 RID: 1216
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000322 RID: 802
		[Serializable]
		public sealed class Player : ValueType
		{
			// Token: 0x06002040 RID: 8256 RVA: 0x0007A7EC File Offset: 0x000789EC
			// Note: this type is marked as 'beforefieldinit'.
			static Player()
			{
				Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.Player>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour>.NativeClassPtr, "Player");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.Player>.NativeClassPtr);
				WormChooseOpponentTroopsPromptBehaviour.Player.NativeFieldInfoPtr_root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.Player>.NativeClassPtr, "root");
				WormChooseOpponentTroopsPromptBehaviour.Player.NativeFieldInfoPtr_troopRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.Player>.NativeClassPtr, "troopRoot");
				WormChooseOpponentTroopsPromptBehaviour.Player.NativeFieldInfoPtr_dreadnoughtRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.Player>.NativeClassPtr, "dreadnoughtRoot");
				WormChooseOpponentTroopsPromptBehaviour.Player.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.Player>.NativeClassPtr, "color");
				WormChooseOpponentTroopsPromptBehaviour.Player.NativeFieldInfoPtr_dreadnoughtIncrement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.Player>.NativeClassPtr, "dreadnoughtIncrement");
				WormChooseOpponentTroopsPromptBehaviour.Player.NativeFieldInfoPtr_dreadnoughtDecrement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.Player>.NativeClassPtr, "dreadnoughtDecrement");
				WormChooseOpponentTroopsPromptBehaviour.Player.NativeFieldInfoPtr_troopIncrement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.Player>.NativeClassPtr, "troopIncrement");
				WormChooseOpponentTroopsPromptBehaviour.Player.NativeFieldInfoPtr_troopDecrement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.Player>.NativeClassPtr, "troopDecrement");
				WormChooseOpponentTroopsPromptBehaviour.Player.NativeFieldInfoPtr_troopText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.Player>.NativeClassPtr, "troopText");
				WormChooseOpponentTroopsPromptBehaviour.Player.NativeFieldInfoPtr_dreadnoughtText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.Player>.NativeClassPtr, "dreadnoughtText");
				WormChooseOpponentTroopsPromptBehaviour.Player.NativeFieldInfoPtr_view = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.Player>.NativeClassPtr, "view");
				WormChooseOpponentTroopsPromptBehaviour.Player.NativeFieldInfoPtr_currentTroops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.Player>.NativeClassPtr, "currentTroops");
				WormChooseOpponentTroopsPromptBehaviour.Player.NativeFieldInfoPtr_currentDreadnoughts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.Player>.NativeClassPtr, "currentDreadnoughts");
				WormChooseOpponentTroopsPromptBehaviour.Player.NativeFieldInfoPtr_currentlySelectedTroops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.Player>.NativeClassPtr, "currentlySelectedTroops");
				WormChooseOpponentTroopsPromptBehaviour.Player.NativeFieldInfoPtr_currentlySelectedDreadnoughts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.Player>.NativeClassPtr, "currentlySelectedDreadnoughts");
			}

			// Token: 0x06002041 RID: 8257 RVA: 0x00012252 File Offset: 0x00010452
			public Player(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002042 RID: 8258 RVA: 0x0001225B File Offset: 0x0001045B
			public Player()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.Player>.NativeClassPtr))
			{
			}

			// Token: 0x170008D3 RID: 2259
			// (get) Token: 0x06002043 RID: 8259 RVA: 0x0007A944 File Offset: 0x00078B44
			// (set) Token: 0x06002044 RID: 8260 RVA: 0x0001226D File Offset: 0x0001046D
			public unsafe GameObject root
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.Player.NativeFieldInfoPtr_root);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.Player.NativeFieldInfoPtr_root), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008D4 RID: 2260
			// (get) Token: 0x06002045 RID: 8261 RVA: 0x0007A974 File Offset: 0x00078B74
			// (set) Token: 0x06002046 RID: 8262 RVA: 0x0001228C File Offset: 0x0001048C
			public unsafe GameObject troopRoot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.Player.NativeFieldInfoPtr_troopRoot);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.Player.NativeFieldInfoPtr_troopRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008D5 RID: 2261
			// (get) Token: 0x06002047 RID: 8263 RVA: 0x0007A9A4 File Offset: 0x00078BA4
			// (set) Token: 0x06002048 RID: 8264 RVA: 0x000122AB File Offset: 0x000104AB
			public unsafe GameObject dreadnoughtRoot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.Player.NativeFieldInfoPtr_dreadnoughtRoot);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.Player.NativeFieldInfoPtr_dreadnoughtRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008D6 RID: 2262
			// (get) Token: 0x06002049 RID: 8265 RVA: 0x0007A9D4 File Offset: 0x00078BD4
			// (set) Token: 0x0600204A RID: 8266 RVA: 0x000122CA File Offset: 0x000104CA
			public unsafe PieceColor color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.Player.NativeFieldInfoPtr_color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.Player.NativeFieldInfoPtr_color)) = value;
				}
			}

			// Token: 0x170008D7 RID: 2263
			// (get) Token: 0x0600204B RID: 8267 RVA: 0x0007A9FC File Offset: 0x00078BFC
			// (set) Token: 0x0600204C RID: 8268 RVA: 0x000122E5 File Offset: 0x000104E5
			public unsafe Button dreadnoughtIncrement
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.Player.NativeFieldInfoPtr_dreadnoughtIncrement);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.Player.NativeFieldInfoPtr_dreadnoughtIncrement), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008D8 RID: 2264
			// (get) Token: 0x0600204D RID: 8269 RVA: 0x0007AA2C File Offset: 0x00078C2C
			// (set) Token: 0x0600204E RID: 8270 RVA: 0x00012304 File Offset: 0x00010504
			public unsafe Button dreadnoughtDecrement
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.Player.NativeFieldInfoPtr_dreadnoughtDecrement);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.Player.NativeFieldInfoPtr_dreadnoughtDecrement), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008D9 RID: 2265
			// (get) Token: 0x0600204F RID: 8271 RVA: 0x0007AA5C File Offset: 0x00078C5C
			// (set) Token: 0x06002050 RID: 8272 RVA: 0x00012323 File Offset: 0x00010523
			public unsafe Button troopIncrement
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.Player.NativeFieldInfoPtr_troopIncrement);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.Player.NativeFieldInfoPtr_troopIncrement), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008DA RID: 2266
			// (get) Token: 0x06002051 RID: 8273 RVA: 0x0007AA8C File Offset: 0x00078C8C
			// (set) Token: 0x06002052 RID: 8274 RVA: 0x00012342 File Offset: 0x00010542
			public unsafe Button troopDecrement
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.Player.NativeFieldInfoPtr_troopDecrement);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.Player.NativeFieldInfoPtr_troopDecrement), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008DB RID: 2267
			// (get) Token: 0x06002053 RID: 8275 RVA: 0x0007AABC File Offset: 0x00078CBC
			// (set) Token: 0x06002054 RID: 8276 RVA: 0x00012361 File Offset: 0x00010561
			public unsafe TMP_Text troopText
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.Player.NativeFieldInfoPtr_troopText);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.Player.NativeFieldInfoPtr_troopText), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008DC RID: 2268
			// (get) Token: 0x06002055 RID: 8277 RVA: 0x0007AAEC File Offset: 0x00078CEC
			// (set) Token: 0x06002056 RID: 8278 RVA: 0x00012380 File Offset: 0x00010580
			public unsafe TMP_Text dreadnoughtText
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.Player.NativeFieldInfoPtr_dreadnoughtText);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.Player.NativeFieldInfoPtr_dreadnoughtText), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008DD RID: 2269
			// (get) Token: 0x06002057 RID: 8279 RVA: 0x0007AB1C File Offset: 0x00078D1C
			// (set) Token: 0x06002058 RID: 8280 RVA: 0x0001239F File Offset: 0x0001059F
			public unsafe UnitView view
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.Player.NativeFieldInfoPtr_view);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnitView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.Player.NativeFieldInfoPtr_view), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008DE RID: 2270
			// (get) Token: 0x06002059 RID: 8281 RVA: 0x0007AB4C File Offset: 0x00078D4C
			// (set) Token: 0x0600205A RID: 8282 RVA: 0x000123BE File Offset: 0x000105BE
			public unsafe int currentTroops
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.Player.NativeFieldInfoPtr_currentTroops);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.Player.NativeFieldInfoPtr_currentTroops)) = value;
				}
			}

			// Token: 0x170008DF RID: 2271
			// (get) Token: 0x0600205B RID: 8283 RVA: 0x0007AB74 File Offset: 0x00078D74
			// (set) Token: 0x0600205C RID: 8284 RVA: 0x000123D9 File Offset: 0x000105D9
			public unsafe int currentDreadnoughts
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.Player.NativeFieldInfoPtr_currentDreadnoughts);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.Player.NativeFieldInfoPtr_currentDreadnoughts)) = value;
				}
			}

			// Token: 0x170008E0 RID: 2272
			// (get) Token: 0x0600205D RID: 8285 RVA: 0x0007AB9C File Offset: 0x00078D9C
			// (set) Token: 0x0600205E RID: 8286 RVA: 0x000123F4 File Offset: 0x000105F4
			public unsafe int currentlySelectedTroops
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.Player.NativeFieldInfoPtr_currentlySelectedTroops);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.Player.NativeFieldInfoPtr_currentlySelectedTroops)) = value;
				}
			}

			// Token: 0x170008E1 RID: 2273
			// (get) Token: 0x0600205F RID: 8287 RVA: 0x0007ABC4 File Offset: 0x00078DC4
			// (set) Token: 0x06002060 RID: 8288 RVA: 0x0001240F File Offset: 0x0001060F
			public unsafe int currentlySelectedDreadnoughts
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.Player.NativeFieldInfoPtr_currentlySelectedDreadnoughts);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.Player.NativeFieldInfoPtr_currentlySelectedDreadnoughts)) = value;
				}
			}

			// Token: 0x04001299 RID: 4761
			private static readonly IntPtr NativeFieldInfoPtr_root;

			// Token: 0x0400129A RID: 4762
			private static readonly IntPtr NativeFieldInfoPtr_troopRoot;

			// Token: 0x0400129B RID: 4763
			private static readonly IntPtr NativeFieldInfoPtr_dreadnoughtRoot;

			// Token: 0x0400129C RID: 4764
			private static readonly IntPtr NativeFieldInfoPtr_color;

			// Token: 0x0400129D RID: 4765
			private static readonly IntPtr NativeFieldInfoPtr_dreadnoughtIncrement;

			// Token: 0x0400129E RID: 4766
			private static readonly IntPtr NativeFieldInfoPtr_dreadnoughtDecrement;

			// Token: 0x0400129F RID: 4767
			private static readonly IntPtr NativeFieldInfoPtr_troopIncrement;

			// Token: 0x040012A0 RID: 4768
			private static readonly IntPtr NativeFieldInfoPtr_troopDecrement;

			// Token: 0x040012A1 RID: 4769
			private static readonly IntPtr NativeFieldInfoPtr_troopText;

			// Token: 0x040012A2 RID: 4770
			private static readonly IntPtr NativeFieldInfoPtr_dreadnoughtText;

			// Token: 0x040012A3 RID: 4771
			private static readonly IntPtr NativeFieldInfoPtr_view;

			// Token: 0x040012A4 RID: 4772
			private static readonly IntPtr NativeFieldInfoPtr_currentTroops;

			// Token: 0x040012A5 RID: 4773
			private static readonly IntPtr NativeFieldInfoPtr_currentDreadnoughts;

			// Token: 0x040012A6 RID: 4774
			private static readonly IntPtr NativeFieldInfoPtr_currentlySelectedTroops;

			// Token: 0x040012A7 RID: 4775
			private static readonly IntPtr NativeFieldInfoPtr_currentlySelectedDreadnoughts;
		}

		// Token: 0x02000323 RID: 803
		[ObfuscatedName("worm.match.prompts.behaviours.WormChooseOpponentTroopsPromptBehaviour+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06002061 RID: 8289 RVA: 0x0007ABEC File Offset: 0x00078DEC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c>.NativeClassPtr);
				WormChooseOpponentTroopsPromptBehaviour.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c>.NativeClassPtr, "<>9");
				WormChooseOpponentTroopsPromptBehaviour.__c.NativeFieldInfoPtr___9__5_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c>.NativeClassPtr, "<>9__5_1");
				WormChooseOpponentTroopsPromptBehaviour.__c.NativeFieldInfoPtr___9__5_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c>.NativeClassPtr, "<>9__5_2");
				WormChooseOpponentTroopsPromptBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c>.NativeClassPtr, 100664399);
				WormChooseOpponentTroopsPromptBehaviour.__c.NativeMethodInfoPtr__initialize_b__5_1_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c>.NativeClassPtr, 100664400);
				WormChooseOpponentTroopsPromptBehaviour.__c.NativeMethodInfoPtr__initialize_b__5_2_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c>.NativeClassPtr, 100664401);
			}

			// Token: 0x06002062 RID: 8290 RVA: 0x0007AC90 File Offset: 0x00078E90
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChooseOpponentTroopsPromptBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002063 RID: 8291 RVA: 0x0007ACCC File Offset: 0x00078ECC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697769, XrefRangeEnd = 697776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _initialize_b__5_1(EntityComponent c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChooseOpponentTroopsPromptBehaviour.__c.NativeMethodInfoPtr__initialize_b__5_1_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002064 RID: 8292 RVA: 0x0007AD1C File Offset: 0x00078F1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697776, XrefRangeEnd = 697783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _initialize_b__5_2(EntityComponent c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChooseOpponentTroopsPromptBehaviour.__c.NativeMethodInfoPtr__initialize_b__5_2_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002065 RID: 8293 RVA: 0x0001242A File Offset: 0x0001062A
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008E2 RID: 2274
			// (get) Token: 0x06002066 RID: 8294 RVA: 0x0007AD6C File Offset: 0x00078F6C
			// (set) Token: 0x06002067 RID: 8295 RVA: 0x00012433 File Offset: 0x00010633
			public unsafe static WormChooseOpponentTroopsPromptBehaviour.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormChooseOpponentTroopsPromptBehaviour.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormChooseOpponentTroopsPromptBehaviour.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormChooseOpponentTroopsPromptBehaviour.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008E3 RID: 2275
			// (get) Token: 0x06002068 RID: 8296 RVA: 0x0007AD94 File Offset: 0x00078F94
			// (set) Token: 0x06002069 RID: 8297 RVA: 0x00012445 File Offset: 0x00010645
			public unsafe static Func<EntityComponent, bool> __9__5_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormChooseOpponentTroopsPromptBehaviour.__c.NativeFieldInfoPtr___9__5_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormChooseOpponentTroopsPromptBehaviour.__c.NativeFieldInfoPtr___9__5_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008E4 RID: 2276
			// (get) Token: 0x0600206A RID: 8298 RVA: 0x0007ADBC File Offset: 0x00078FBC
			// (set) Token: 0x0600206B RID: 8299 RVA: 0x00012457 File Offset: 0x00010657
			public unsafe static Func<EntityComponent, bool> __9__5_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormChooseOpponentTroopsPromptBehaviour.__c.NativeFieldInfoPtr___9__5_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormChooseOpponentTroopsPromptBehaviour.__c.NativeFieldInfoPtr___9__5_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040012A8 RID: 4776
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040012A9 RID: 4777
			private static readonly IntPtr NativeFieldInfoPtr___9__5_1;

			// Token: 0x040012AA RID: 4778
			private static readonly IntPtr NativeFieldInfoPtr___9__5_2;

			// Token: 0x040012AB RID: 4779
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040012AC RID: 4780
			private static readonly IntPtr NativeMethodInfoPtr__initialize_b__5_1_Internal_Boolean_EntityComponent_0;

			// Token: 0x040012AD RID: 4781
			private static readonly IntPtr NativeMethodInfoPtr__initialize_b__5_2_Internal_Boolean_EntityComponent_0;
		}

		// Token: 0x02000324 RID: 804
		[ObfuscatedName("worm.match.prompts.behaviours.WormChooseOpponentTroopsPromptBehaviour+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600206C RID: 8300 RVA: 0x0007ADE4 File Offset: 0x00078FE4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass10_0>.NativeClassPtr);
				WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass10_0.NativeFieldInfoPtr_pieceColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass10_0>.NativeClassPtr, "pieceColor");
				WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass10_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass10_0>.NativeClassPtr, "player");
				WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass10_0>.NativeClassPtr, "<>4__this");
				WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass10_0>.NativeClassPtr, 100664402);
				WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass10_0.NativeMethodInfoPtr__Event_IncrementDreadnought_b__0_Internal_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass10_0>.NativeClassPtr, 100664403);
				WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass10_0.NativeMethodInfoPtr__Event_IncrementDreadnought_b__1_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass10_0>.NativeClassPtr, 100664404);
			}

			// Token: 0x0600206D RID: 8301 RVA: 0x0007AE88 File Offset: 0x00079088
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600206E RID: 8302 RVA: 0x0007AEC4 File Offset: 0x000790C4
			[CallerCount(0)]
			public unsafe bool _Event_IncrementDreadnought_b__0(WormChooseOpponentTroopsPromptBehaviour.Player p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(p));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass10_0.NativeMethodInfoPtr__Event_IncrementDreadnought_b__0_Internal_Boolean_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600206F RID: 8303 RVA: 0x0007AF18 File Offset: 0x00079118
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697783, XrefRangeEnd = 697796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Event_IncrementDreadnought_b__1(EntityComponent ec)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ec);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass10_0.NativeMethodInfoPtr__Event_IncrementDreadnought_b__1_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002070 RID: 8304 RVA: 0x00012469 File Offset: 0x00010669
			public __c__DisplayClass10_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008E5 RID: 2277
			// (get) Token: 0x06002071 RID: 8305 RVA: 0x0007AF68 File Offset: 0x00079168
			// (set) Token: 0x06002072 RID: 8306 RVA: 0x00012472 File Offset: 0x00010672
			public unsafe PieceColor pieceColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass10_0.NativeFieldInfoPtr_pieceColor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass10_0.NativeFieldInfoPtr_pieceColor)) = value;
				}
			}

			// Token: 0x170008E6 RID: 2278
			// (get) Token: 0x06002073 RID: 8307 RVA: 0x0007AF90 File Offset: 0x00079190
			// (set) Token: 0x06002074 RID: 8308 RVA: 0x0001248D File Offset: 0x0001068D
			public WormChooseOpponentTroopsPromptBehaviour.Player player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass10_0.NativeFieldInfoPtr_player);
					return new WormChooseOpponentTroopsPromptBehaviour.Player(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.Player>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass10_0.NativeFieldInfoPtr_player), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.Player>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008E7 RID: 2279
			// (get) Token: 0x06002075 RID: 8309 RVA: 0x0007AFC0 File Offset: 0x000791C0
			// (set) Token: 0x06002076 RID: 8310 RVA: 0x000124BB File Offset: 0x000106BB
			public unsafe WormChooseOpponentTroopsPromptBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormChooseOpponentTroopsPromptBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040012AE RID: 4782
			private static readonly IntPtr NativeFieldInfoPtr_pieceColor;

			// Token: 0x040012AF RID: 4783
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x040012B0 RID: 4784
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040012B1 RID: 4785
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040012B2 RID: 4786
			private static readonly IntPtr NativeMethodInfoPtr__Event_IncrementDreadnought_b__0_Internal_Boolean_Player_0;

			// Token: 0x040012B3 RID: 4787
			private static readonly IntPtr NativeMethodInfoPtr__Event_IncrementDreadnought_b__1_Internal_Boolean_EntityComponent_0;
		}

		// Token: 0x02000325 RID: 805
		[ObfuscatedName("worm.match.prompts.behaviours.WormChooseOpponentTroopsPromptBehaviour+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002077 RID: 8311 RVA: 0x0007AFF0 File Offset: 0x000791F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass11_0>.NativeClassPtr);
				WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass11_0.NativeFieldInfoPtr_pieceColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass11_0>.NativeClassPtr, "pieceColor");
				WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass11_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass11_0>.NativeClassPtr, "player");
				WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass11_0>.NativeClassPtr, "<>4__this");
				WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass11_0>.NativeClassPtr, 100664405);
				WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass11_0.NativeMethodInfoPtr__Event_DecrementTroop_b__0_Internal_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass11_0>.NativeClassPtr, 100664406);
				WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass11_0.NativeMethodInfoPtr__Event_DecrementTroop_b__1_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass11_0>.NativeClassPtr, 100664407);
			}

			// Token: 0x06002078 RID: 8312 RVA: 0x0007B094 File Offset: 0x00079294
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002079 RID: 8313 RVA: 0x0007B0D0 File Offset: 0x000792D0
			[CallerCount(0)]
			public unsafe bool _Event_DecrementTroop_b__0(WormChooseOpponentTroopsPromptBehaviour.Player p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(p));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass11_0.NativeMethodInfoPtr__Event_DecrementTroop_b__0_Internal_Boolean_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600207A RID: 8314 RVA: 0x0007B124 File Offset: 0x00079324
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697796, XrefRangeEnd = 697809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Event_DecrementTroop_b__1(EntityComponent ec)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ec);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass11_0.NativeMethodInfoPtr__Event_DecrementTroop_b__1_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600207B RID: 8315 RVA: 0x000124DA File Offset: 0x000106DA
			public __c__DisplayClass11_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008E8 RID: 2280
			// (get) Token: 0x0600207C RID: 8316 RVA: 0x0007B174 File Offset: 0x00079374
			// (set) Token: 0x0600207D RID: 8317 RVA: 0x000124E3 File Offset: 0x000106E3
			public unsafe PieceColor pieceColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass11_0.NativeFieldInfoPtr_pieceColor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass11_0.NativeFieldInfoPtr_pieceColor)) = value;
				}
			}

			// Token: 0x170008E9 RID: 2281
			// (get) Token: 0x0600207E RID: 8318 RVA: 0x0007B19C File Offset: 0x0007939C
			// (set) Token: 0x0600207F RID: 8319 RVA: 0x000124FE File Offset: 0x000106FE
			public WormChooseOpponentTroopsPromptBehaviour.Player player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass11_0.NativeFieldInfoPtr_player);
					return new WormChooseOpponentTroopsPromptBehaviour.Player(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.Player>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass11_0.NativeFieldInfoPtr_player), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.Player>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008EA RID: 2282
			// (get) Token: 0x06002080 RID: 8320 RVA: 0x0007B1CC File Offset: 0x000793CC
			// (set) Token: 0x06002081 RID: 8321 RVA: 0x0001252C File Offset: 0x0001072C
			public unsafe WormChooseOpponentTroopsPromptBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormChooseOpponentTroopsPromptBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040012B4 RID: 4788
			private static readonly IntPtr NativeFieldInfoPtr_pieceColor;

			// Token: 0x040012B5 RID: 4789
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x040012B6 RID: 4790
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040012B7 RID: 4791
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040012B8 RID: 4792
			private static readonly IntPtr NativeMethodInfoPtr__Event_DecrementTroop_b__0_Internal_Boolean_Player_0;

			// Token: 0x040012B9 RID: 4793
			private static readonly IntPtr NativeMethodInfoPtr__Event_DecrementTroop_b__1_Internal_Boolean_EntityComponent_0;
		}

		// Token: 0x02000326 RID: 806
		[ObfuscatedName("worm.match.prompts.behaviours.WormChooseOpponentTroopsPromptBehaviour+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002082 RID: 8322 RVA: 0x0007B1FC File Offset: 0x000793FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass12_0>.NativeClassPtr);
				WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass12_0.NativeFieldInfoPtr_pieceColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass12_0>.NativeClassPtr, "pieceColor");
				WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass12_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass12_0>.NativeClassPtr, "player");
				WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass12_0>.NativeClassPtr, "<>4__this");
				WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass12_0>.NativeClassPtr, 100664408);
				WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass12_0.NativeMethodInfoPtr__Event_DecrementDreadnought_b__0_Internal_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass12_0>.NativeClassPtr, 100664409);
				WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass12_0.NativeMethodInfoPtr__Event_DecrementDreadnought_b__1_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass12_0>.NativeClassPtr, 100664410);
			}

			// Token: 0x06002083 RID: 8323 RVA: 0x0007B2A0 File Offset: 0x000794A0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002084 RID: 8324 RVA: 0x0007B2DC File Offset: 0x000794DC
			[CallerCount(0)]
			public unsafe bool _Event_DecrementDreadnought_b__0(WormChooseOpponentTroopsPromptBehaviour.Player p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(p));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass12_0.NativeMethodInfoPtr__Event_DecrementDreadnought_b__0_Internal_Boolean_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002085 RID: 8325 RVA: 0x0007B330 File Offset: 0x00079530
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697809, XrefRangeEnd = 697822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Event_DecrementDreadnought_b__1(EntityComponent ec)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ec);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass12_0.NativeMethodInfoPtr__Event_DecrementDreadnought_b__1_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002086 RID: 8326 RVA: 0x0001254B File Offset: 0x0001074B
			public __c__DisplayClass12_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008EB RID: 2283
			// (get) Token: 0x06002087 RID: 8327 RVA: 0x0007B380 File Offset: 0x00079580
			// (set) Token: 0x06002088 RID: 8328 RVA: 0x00012554 File Offset: 0x00010754
			public unsafe PieceColor pieceColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass12_0.NativeFieldInfoPtr_pieceColor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass12_0.NativeFieldInfoPtr_pieceColor)) = value;
				}
			}

			// Token: 0x170008EC RID: 2284
			// (get) Token: 0x06002089 RID: 8329 RVA: 0x0007B3A8 File Offset: 0x000795A8
			// (set) Token: 0x0600208A RID: 8330 RVA: 0x0001256F File Offset: 0x0001076F
			public WormChooseOpponentTroopsPromptBehaviour.Player player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass12_0.NativeFieldInfoPtr_player);
					return new WormChooseOpponentTroopsPromptBehaviour.Player(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.Player>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass12_0.NativeFieldInfoPtr_player), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.Player>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008ED RID: 2285
			// (get) Token: 0x0600208B RID: 8331 RVA: 0x0007B3D8 File Offset: 0x000795D8
			// (set) Token: 0x0600208C RID: 8332 RVA: 0x0001259D File Offset: 0x0001079D
			public unsafe WormChooseOpponentTroopsPromptBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormChooseOpponentTroopsPromptBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040012BA RID: 4794
			private static readonly IntPtr NativeFieldInfoPtr_pieceColor;

			// Token: 0x040012BB RID: 4795
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x040012BC RID: 4796
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040012BD RID: 4797
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040012BE RID: 4798
			private static readonly IntPtr NativeMethodInfoPtr__Event_DecrementDreadnought_b__0_Internal_Boolean_Player_0;

			// Token: 0x040012BF RID: 4799
			private static readonly IntPtr NativeMethodInfoPtr__Event_DecrementDreadnought_b__1_Internal_Boolean_EntityComponent_0;
		}

		// Token: 0x02000327 RID: 807
		[ObfuscatedName("worm.match.prompts.behaviours.WormChooseOpponentTroopsPromptBehaviour+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600208D RID: 8333 RVA: 0x0007B408 File Offset: 0x00079608
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass5_0>.NativeClassPtr);
				WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass5_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass5_0>.NativeClassPtr, "player");
				WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass5_0>.NativeClassPtr, 100664411);
				WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass5_0.NativeMethodInfoPtr__initialize_b__0_Internal_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass5_0>.NativeClassPtr, 100664412);
			}

			// Token: 0x0600208E RID: 8334 RVA: 0x0007B470 File Offset: 0x00079670
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600208F RID: 8335 RVA: 0x0007B4AC File Offset: 0x000796AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697822, XrefRangeEnd = 697834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _initialize_b__0(WormChooseOpponentTroopsPromptBehaviour.Player p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(p));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass5_0.NativeMethodInfoPtr__initialize_b__0_Internal_Boolean_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002090 RID: 8336 RVA: 0x000125BC File Offset: 0x000107BC
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008EE RID: 2286
			// (get) Token: 0x06002091 RID: 8337 RVA: 0x0007B500 File Offset: 0x00079700
			// (set) Token: 0x06002092 RID: 8338 RVA: 0x000125C5 File Offset: 0x000107C5
			public unsafe EntityComponent player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass5_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass5_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040012C0 RID: 4800
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x040012C1 RID: 4801
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040012C2 RID: 4802
			private static readonly IntPtr NativeMethodInfoPtr__initialize_b__0_Internal_Boolean_Player_0;
		}

		// Token: 0x02000328 RID: 808
		[ObfuscatedName("worm.match.prompts.behaviours.WormChooseOpponentTroopsPromptBehaviour+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002093 RID: 8339 RVA: 0x0007B530 File Offset: 0x00079730
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass9_0>.NativeClassPtr);
				WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass9_0.NativeFieldInfoPtr_pieceColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass9_0>.NativeClassPtr, "pieceColor");
				WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass9_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass9_0>.NativeClassPtr, "player");
				WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass9_0>.NativeClassPtr, "<>4__this");
				WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass9_0>.NativeClassPtr, 100664413);
				WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass9_0.NativeMethodInfoPtr__Event_IncrementTroop_b__0_Internal_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass9_0>.NativeClassPtr, 100664414);
				WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass9_0.NativeMethodInfoPtr__Event_IncrementTroop_b__1_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass9_0>.NativeClassPtr, 100664415);
			}

			// Token: 0x06002094 RID: 8340 RVA: 0x0007B5D4 File Offset: 0x000797D4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002095 RID: 8341 RVA: 0x0007B610 File Offset: 0x00079810
			[CallerCount(0)]
			public unsafe bool _Event_IncrementTroop_b__0(WormChooseOpponentTroopsPromptBehaviour.Player p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(p));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass9_0.NativeMethodInfoPtr__Event_IncrementTroop_b__0_Internal_Boolean_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002096 RID: 8342 RVA: 0x0007B664 File Offset: 0x00079864
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697834, XrefRangeEnd = 697847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Event_IncrementTroop_b__1(EntityComponent ec)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ec);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass9_0.NativeMethodInfoPtr__Event_IncrementTroop_b__1_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002097 RID: 8343 RVA: 0x000125E4 File Offset: 0x000107E4
			public __c__DisplayClass9_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008EF RID: 2287
			// (get) Token: 0x06002098 RID: 8344 RVA: 0x0007B6B4 File Offset: 0x000798B4
			// (set) Token: 0x06002099 RID: 8345 RVA: 0x000125ED File Offset: 0x000107ED
			public unsafe PieceColor pieceColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass9_0.NativeFieldInfoPtr_pieceColor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass9_0.NativeFieldInfoPtr_pieceColor)) = value;
				}
			}

			// Token: 0x170008F0 RID: 2288
			// (get) Token: 0x0600209A RID: 8346 RVA: 0x0007B6DC File Offset: 0x000798DC
			// (set) Token: 0x0600209B RID: 8347 RVA: 0x00012608 File Offset: 0x00010808
			public WormChooseOpponentTroopsPromptBehaviour.Player player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass9_0.NativeFieldInfoPtr_player);
					return new WormChooseOpponentTroopsPromptBehaviour.Player(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.Player>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass9_0.NativeFieldInfoPtr_player), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour.Player>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008F1 RID: 2289
			// (get) Token: 0x0600209C RID: 8348 RVA: 0x0007B70C File Offset: 0x0007990C
			// (set) Token: 0x0600209D RID: 8349 RVA: 0x00012636 File Offset: 0x00010836
			public unsafe WormChooseOpponentTroopsPromptBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormChooseOpponentTroopsPromptBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040012C3 RID: 4803
			private static readonly IntPtr NativeFieldInfoPtr_pieceColor;

			// Token: 0x040012C4 RID: 4804
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x040012C5 RID: 4805
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040012C6 RID: 4806
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040012C7 RID: 4807
			private static readonly IntPtr NativeMethodInfoPtr__Event_IncrementTroop_b__0_Internal_Boolean_Player_0;

			// Token: 0x040012C8 RID: 4808
			private static readonly IntPtr NativeMethodInfoPtr__Event_IncrementTroop_b__1_Internal_Boolean_EntityComponent_0;
		}

		// Token: 0x02000329 RID: 809
		[ObfuscatedName("worm.match.prompts.behaviours.WormChooseOpponentTroopsPromptBehaviour+<attemptSubmit>d__7")]
		public sealed class _attemptSubmit_d__7 : global::Il2CppSystem.Object
		{
			// Token: 0x0600209E RID: 8350 RVA: 0x0007B73C File Offset: 0x0007993C
			// Note: this type is marked as 'beforefieldinit'.
			static _attemptSubmit_d__7()
			{
				Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour._attemptSubmit_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour>.NativeClassPtr, "<attemptSubmit>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour._attemptSubmit_d__7>.NativeClassPtr);
				WormChooseOpponentTroopsPromptBehaviour._attemptSubmit_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour._attemptSubmit_d__7>.NativeClassPtr, "<>1__state");
				WormChooseOpponentTroopsPromptBehaviour._attemptSubmit_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour._attemptSubmit_d__7>.NativeClassPtr, "<>2__current");
				WormChooseOpponentTroopsPromptBehaviour._attemptSubmit_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour._attemptSubmit_d__7>.NativeClassPtr, "<>4__this");
				WormChooseOpponentTroopsPromptBehaviour._attemptSubmit_d__7.NativeFieldInfoPtr__submitConfirmation_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour._attemptSubmit_d__7>.NativeClassPtr, "<submitConfirmation>5__2");
				WormChooseOpponentTroopsPromptBehaviour._attemptSubmit_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour._attemptSubmit_d__7>.NativeClassPtr, 100664416);
				WormChooseOpponentTroopsPromptBehaviour._attemptSubmit_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour._attemptSubmit_d__7>.NativeClassPtr, 100664417);
				WormChooseOpponentTroopsPromptBehaviour._attemptSubmit_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour._attemptSubmit_d__7>.NativeClassPtr, 100664418);
				WormChooseOpponentTroopsPromptBehaviour._attemptSubmit_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour._attemptSubmit_d__7>.NativeClassPtr, 100664419);
				WormChooseOpponentTroopsPromptBehaviour._attemptSubmit_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour._attemptSubmit_d__7>.NativeClassPtr, 100664420);
				WormChooseOpponentTroopsPromptBehaviour._attemptSubmit_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour._attemptSubmit_d__7>.NativeClassPtr, 100664421);
			}

			// Token: 0x0600209F RID: 8351 RVA: 0x0007B830 File Offset: 0x00079A30
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _attemptSubmit_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormChooseOpponentTroopsPromptBehaviour._attemptSubmit_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChooseOpponentTroopsPromptBehaviour._attemptSubmit_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060020A0 RID: 8352 RVA: 0x0007B878 File Offset: 0x00079A78
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChooseOpponentTroopsPromptBehaviour._attemptSubmit_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060020A1 RID: 8353 RVA: 0x0007B8AC File Offset: 0x00079AAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697847, XrefRangeEnd = 697862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChooseOpponentTroopsPromptBehaviour._attemptSubmit_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170008F6 RID: 2294
			// (get) Token: 0x060020A2 RID: 8354 RVA: 0x0007B8E8 File Offset: 0x00079AE8
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChooseOpponentTroopsPromptBehaviour._attemptSubmit_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060020A3 RID: 8355 RVA: 0x0007B928 File Offset: 0x00079B28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697862, XrefRangeEnd = 697867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChooseOpponentTroopsPromptBehaviour._attemptSubmit_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170008F7 RID: 2295
			// (get) Token: 0x060020A4 RID: 8356 RVA: 0x0007B95C File Offset: 0x00079B5C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChooseOpponentTroopsPromptBehaviour._attemptSubmit_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060020A5 RID: 8357 RVA: 0x00012655 File Offset: 0x00010855
			public _attemptSubmit_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008F2 RID: 2290
			// (get) Token: 0x060020A6 RID: 8358 RVA: 0x0007B99C File Offset: 0x00079B9C
			// (set) Token: 0x060020A7 RID: 8359 RVA: 0x0001265E File Offset: 0x0001085E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour._attemptSubmit_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour._attemptSubmit_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008F3 RID: 2291
			// (get) Token: 0x060020A8 RID: 8360 RVA: 0x0007B9C4 File Offset: 0x00079BC4
			// (set) Token: 0x060020A9 RID: 8361 RVA: 0x00012679 File Offset: 0x00010879
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour._attemptSubmit_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour._attemptSubmit_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008F4 RID: 2292
			// (get) Token: 0x060020AA RID: 8362 RVA: 0x0007B9F4 File Offset: 0x00079BF4
			// (set) Token: 0x060020AB RID: 8363 RVA: 0x00012698 File Offset: 0x00010898
			public unsafe WormChooseOpponentTroopsPromptBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour._attemptSubmit_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormChooseOpponentTroopsPromptBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour._attemptSubmit_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008F5 RID: 2293
			// (get) Token: 0x060020AC RID: 8364 RVA: 0x0007BA24 File Offset: 0x00079C24
			// (set) Token: 0x060020AD RID: 8365 RVA: 0x000126B7 File Offset: 0x000108B7
			public unsafe IEnumerator<Nullable<bool>> _submitConfirmation_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour._attemptSubmit_d__7.NativeFieldInfoPtr__submitConfirmation_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Nullable<bool>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseOpponentTroopsPromptBehaviour._attemptSubmit_d__7.NativeFieldInfoPtr__submitConfirmation_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040012C9 RID: 4809
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040012CA RID: 4810
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040012CB RID: 4811
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040012CC RID: 4812
			private static readonly IntPtr NativeFieldInfoPtr__submitConfirmation_5__2;

			// Token: 0x040012CD RID: 4813
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040012CE RID: 4814
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040012CF RID: 4815
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040012D0 RID: 4816
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040012D1 RID: 4817
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040012D2 RID: 4818
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
