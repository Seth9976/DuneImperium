using System;
using boardgames.match.behaviours;
using boardgames.match.selection;
using dwd.core.match.selection;
using dwd.core.ui.match.prompt.prompts;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using lotus;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace worm.match.prompts.behaviours
{
	// Token: 0x020000CF RID: 207
	public class WormDragTargetSelectionPromptBehaviour : PromptBehaviour<FlavoredDismissablePrompt>
	{
		// Token: 0x060008B2 RID: 2226 RVA: 0x00032DE4 File Offset: 0x00030FE4
		// Note: this type is marked as 'beforefieldinit'.
		static WormDragTargetSelectionPromptBehaviour()
		{
			Il2CppClassPointerStore<WormDragTargetSelectionPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.behaviours", "WormDragTargetSelectionPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormDragTargetSelectionPromptBehaviour>.NativeClassPtr);
			WormDragTargetSelectionPromptBehaviour.NativeFieldInfoPtr_pileView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDragTargetSelectionPromptBehaviour>.NativeClassPtr, "pileView");
			WormDragTargetSelectionPromptBehaviour.NativeFieldInfoPtr_undoButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDragTargetSelectionPromptBehaviour>.NativeClassPtr, "undoButton");
			WormDragTargetSelectionPromptBehaviour.NativeFieldInfoPtr_confirmButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDragTargetSelectionPromptBehaviour>.NativeClassPtr, "confirmButton");
			WormDragTargetSelectionPromptBehaviour.NativeFieldInfoPtr_confirmText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDragTargetSelectionPromptBehaviour>.NativeClassPtr, "confirmText");
			WormDragTargetSelectionPromptBehaviour.NativeFieldInfoPtr_selectionResponder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDragTargetSelectionPromptBehaviour>.NativeClassPtr, "selectionResponder");
			WormDragTargetSelectionPromptBehaviour.NativeFieldInfoPtr_handManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDragTargetSelectionPromptBehaviour>.NativeClassPtr, "handManager");
			WormDragTargetSelectionPromptBehaviour.NativeFieldInfoPtr_minimizablePrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDragTargetSelectionPromptBehaviour>.NativeClassPtr, "minimizablePrompt");
			WormDragTargetSelectionPromptBehaviour.NativeFieldInfoPtr_entityListSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDragTargetSelectionPromptBehaviour>.NativeClassPtr, "entityListSelection");
			WormDragTargetSelectionPromptBehaviour.NativeFieldInfoPtr_wasMinimized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDragTargetSelectionPromptBehaviour>.NativeClassPtr, "wasMinimized");
			WormDragTargetSelectionPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDragTargetSelectionPromptBehaviour>.NativeClassPtr, 100664486);
			WormDragTargetSelectionPromptBehaviour.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDragTargetSelectionPromptBehaviour>.NativeClassPtr, 100664487);
			WormDragTargetSelectionPromptBehaviour.NativeMethodInfoPtr_UpdateConfirmActive_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDragTargetSelectionPromptBehaviour>.NativeClassPtr, 100664488);
			WormDragTargetSelectionPromptBehaviour.NativeMethodInfoPtr_Event_UndoLastSelection_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDragTargetSelectionPromptBehaviour>.NativeClassPtr, 100664489);
			WormDragTargetSelectionPromptBehaviour.NativeMethodInfoPtr_Event_ResetHinting_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDragTargetSelectionPromptBehaviour>.NativeClassPtr, 100664490);
			WormDragTargetSelectionPromptBehaviour.NativeMethodInfoPtr_ResetHinting_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDragTargetSelectionPromptBehaviour>.NativeClassPtr, 100664491);
			WormDragTargetSelectionPromptBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDragTargetSelectionPromptBehaviour>.NativeClassPtr, 100664492);
			WormDragTargetSelectionPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDragTargetSelectionPromptBehaviour>.NativeClassPtr, 100664493);
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x00032F68 File Offset: 0x00031168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698866, XrefRangeEnd = 698887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormDragTargetSelectionPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x00032FA4 File Offset: 0x000311A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698887, XrefRangeEnd = 698930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDragTargetSelectionPromptBehaviour.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x00032FD8 File Offset: 0x000311D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 698951, RefRangeEnd = 698953, XrefRangeStart = 698930, XrefRangeEnd = 698951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool UpdateConfirmActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDragTargetSelectionPromptBehaviour.NativeMethodInfoPtr_UpdateConfirmActive_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x00033014 File Offset: 0x00031214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698953, XrefRangeEnd = 698974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_UndoLastSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDragTargetSelectionPromptBehaviour.NativeMethodInfoPtr_Event_UndoLastSelection_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x00033048 File Offset: 0x00031248
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 698980, RefRangeEnd = 698982, XrefRangeStart = 698974, XrefRangeEnd = 698980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ResetHinting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDragTargetSelectionPromptBehaviour.NativeMethodInfoPtr_Event_ResetHinting_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x0003307C File Offset: 0x0003127C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 698987, RefRangeEnd = 698988, XrefRangeStart = 698982, XrefRangeEnd = 698987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ResetHinting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDragTargetSelectionPromptBehaviour.NativeMethodInfoPtr_ResetHinting_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x000330BC File Offset: 0x000312BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698988, XrefRangeEnd = 698993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDragTargetSelectionPromptBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x000330F0 File Offset: 0x000312F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698993, XrefRangeEnd = 698996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormDragTargetSelectionPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormDragTargetSelectionPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDragTargetSelectionPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x000066FF File Offset: 0x000048FF
		public WormDragTargetSelectionPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x060008BC RID: 2236 RVA: 0x0003312C File Offset: 0x0003132C
		// (set) Token: 0x060008BD RID: 2237 RVA: 0x00006708 File Offset: 0x00004908
		public unsafe ContainerView pileView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDragTargetSelectionPromptBehaviour.NativeFieldInfoPtr_pileView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDragTargetSelectionPromptBehaviour.NativeFieldInfoPtr_pileView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x060008BE RID: 2238 RVA: 0x0003315C File Offset: 0x0003135C
		// (set) Token: 0x060008BF RID: 2239 RVA: 0x00006727 File Offset: 0x00004927
		public unsafe GameObject undoButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDragTargetSelectionPromptBehaviour.NativeFieldInfoPtr_undoButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDragTargetSelectionPromptBehaviour.NativeFieldInfoPtr_undoButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x060008C0 RID: 2240 RVA: 0x0003318C File Offset: 0x0003138C
		// (set) Token: 0x060008C1 RID: 2241 RVA: 0x00006746 File Offset: 0x00004946
		public unsafe Button confirmButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDragTargetSelectionPromptBehaviour.NativeFieldInfoPtr_confirmButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDragTargetSelectionPromptBehaviour.NativeFieldInfoPtr_confirmButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x060008C2 RID: 2242 RVA: 0x000331BC File Offset: 0x000313BC
		// (set) Token: 0x060008C3 RID: 2243 RVA: 0x00006765 File Offset: 0x00004965
		public unsafe TMP_Text confirmText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDragTargetSelectionPromptBehaviour.NativeFieldInfoPtr_confirmText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDragTargetSelectionPromptBehaviour.NativeFieldInfoPtr_confirmText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x060008C4 RID: 2244 RVA: 0x000331EC File Offset: 0x000313EC
		// (set) Token: 0x060008C5 RID: 2245 RVA: 0x00006784 File Offset: 0x00004984
		public unsafe DBGSelectionResponder selectionResponder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDragTargetSelectionPromptBehaviour.NativeFieldInfoPtr_selectionResponder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGSelectionResponder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDragTargetSelectionPromptBehaviour.NativeFieldInfoPtr_selectionResponder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x060008C6 RID: 2246 RVA: 0x0003321C File Offset: 0x0003141C
		// (set) Token: 0x060008C7 RID: 2247 RVA: 0x000067A3 File Offset: 0x000049A3
		public unsafe WormHandManager handManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDragTargetSelectionPromptBehaviour.NativeFieldInfoPtr_handManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormHandManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDragTargetSelectionPromptBehaviour.NativeFieldInfoPtr_handManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x060008C8 RID: 2248 RVA: 0x0003324C File Offset: 0x0003144C
		// (set) Token: 0x060008C9 RID: 2249 RVA: 0x000067C2 File Offset: 0x000049C2
		public unsafe MinimizablePrompt minimizablePrompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDragTargetSelectionPromptBehaviour.NativeFieldInfoPtr_minimizablePrompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MinimizablePrompt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDragTargetSelectionPromptBehaviour.NativeFieldInfoPtr_minimizablePrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x060008CA RID: 2250 RVA: 0x0003327C File Offset: 0x0003147C
		// (set) Token: 0x060008CB RID: 2251 RVA: 0x000067E1 File Offset: 0x000049E1
		public unsafe IEntityListSelection entityListSelection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDragTargetSelectionPromptBehaviour.NativeFieldInfoPtr_entityListSelection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEntityListSelection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDragTargetSelectionPromptBehaviour.NativeFieldInfoPtr_entityListSelection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x060008CC RID: 2252 RVA: 0x000332AC File Offset: 0x000314AC
		// (set) Token: 0x060008CD RID: 2253 RVA: 0x00006800 File Offset: 0x00004A00
		public Nullable<bool> wasMinimized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDragTargetSelectionPromptBehaviour.NativeFieldInfoPtr_wasMinimized);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDragTargetSelectionPromptBehaviour.NativeFieldInfoPtr_wasMinimized), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000502 RID: 1282
		private static readonly IntPtr NativeFieldInfoPtr_pileView;

		// Token: 0x04000503 RID: 1283
		private static readonly IntPtr NativeFieldInfoPtr_undoButton;

		// Token: 0x04000504 RID: 1284
		private static readonly IntPtr NativeFieldInfoPtr_confirmButton;

		// Token: 0x04000505 RID: 1285
		private static readonly IntPtr NativeFieldInfoPtr_confirmText;

		// Token: 0x04000506 RID: 1286
		private static readonly IntPtr NativeFieldInfoPtr_selectionResponder;

		// Token: 0x04000507 RID: 1287
		private static readonly IntPtr NativeFieldInfoPtr_handManager;

		// Token: 0x04000508 RID: 1288
		private static readonly IntPtr NativeFieldInfoPtr_minimizablePrompt;

		// Token: 0x04000509 RID: 1289
		private static readonly IntPtr NativeFieldInfoPtr_entityListSelection;

		// Token: 0x0400050A RID: 1290
		private static readonly IntPtr NativeFieldInfoPtr_wasMinimized;

		// Token: 0x0400050B RID: 1291
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x0400050C RID: 1292
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400050D RID: 1293
		private static readonly IntPtr NativeMethodInfoPtr_UpdateConfirmActive_Private_Boolean_0;

		// Token: 0x0400050E RID: 1294
		private static readonly IntPtr NativeMethodInfoPtr_Event_UndoLastSelection_Public_Void_0;

		// Token: 0x0400050F RID: 1295
		private static readonly IntPtr NativeMethodInfoPtr_Event_ResetHinting_Public_Void_0;

		// Token: 0x04000510 RID: 1296
		private static readonly IntPtr NativeMethodInfoPtr_ResetHinting_Private_IEnumerator_0;

		// Token: 0x04000511 RID: 1297
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000512 RID: 1298
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000330 RID: 816
		[ObfuscatedName("worm.match.prompts.behaviours.WormDragTargetSelectionPromptBehaviour+<ResetHinting>d__14")]
		public sealed class _ResetHinting_d__14 : global::Il2CppSystem.Object
		{
			// Token: 0x060020F6 RID: 8438 RVA: 0x0007C788 File Offset: 0x0007A988
			// Note: this type is marked as 'beforefieldinit'.
			static _ResetHinting_d__14()
			{
				Il2CppClassPointerStore<WormDragTargetSelectionPromptBehaviour._ResetHinting_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormDragTargetSelectionPromptBehaviour>.NativeClassPtr, "<ResetHinting>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormDragTargetSelectionPromptBehaviour._ResetHinting_d__14>.NativeClassPtr);
				WormDragTargetSelectionPromptBehaviour._ResetHinting_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDragTargetSelectionPromptBehaviour._ResetHinting_d__14>.NativeClassPtr, "<>1__state");
				WormDragTargetSelectionPromptBehaviour._ResetHinting_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDragTargetSelectionPromptBehaviour._ResetHinting_d__14>.NativeClassPtr, "<>2__current");
				WormDragTargetSelectionPromptBehaviour._ResetHinting_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDragTargetSelectionPromptBehaviour._ResetHinting_d__14>.NativeClassPtr, "<>4__this");
				WormDragTargetSelectionPromptBehaviour._ResetHinting_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDragTargetSelectionPromptBehaviour._ResetHinting_d__14>.NativeClassPtr, 100664494);
				WormDragTargetSelectionPromptBehaviour._ResetHinting_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDragTargetSelectionPromptBehaviour._ResetHinting_d__14>.NativeClassPtr, 100664495);
				WormDragTargetSelectionPromptBehaviour._ResetHinting_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDragTargetSelectionPromptBehaviour._ResetHinting_d__14>.NativeClassPtr, 100664496);
				WormDragTargetSelectionPromptBehaviour._ResetHinting_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDragTargetSelectionPromptBehaviour._ResetHinting_d__14>.NativeClassPtr, 100664497);
				WormDragTargetSelectionPromptBehaviour._ResetHinting_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDragTargetSelectionPromptBehaviour._ResetHinting_d__14>.NativeClassPtr, 100664498);
				WormDragTargetSelectionPromptBehaviour._ResetHinting_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDragTargetSelectionPromptBehaviour._ResetHinting_d__14>.NativeClassPtr, 100664499);
			}

			// Token: 0x060020F7 RID: 8439 RVA: 0x0007C868 File Offset: 0x0007AA68
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ResetHinting_d__14(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormDragTargetSelectionPromptBehaviour._ResetHinting_d__14>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDragTargetSelectionPromptBehaviour._ResetHinting_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060020F8 RID: 8440 RVA: 0x0007C8B0 File Offset: 0x0007AAB0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDragTargetSelectionPromptBehaviour._ResetHinting_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060020F9 RID: 8441 RVA: 0x0007C8E4 File Offset: 0x0007AAE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698859, XrefRangeEnd = 698861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDragTargetSelectionPromptBehaviour._ResetHinting_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000913 RID: 2323
			// (get) Token: 0x060020FA RID: 8442 RVA: 0x0007C920 File Offset: 0x0007AB20
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDragTargetSelectionPromptBehaviour._ResetHinting_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060020FB RID: 8443 RVA: 0x0007C960 File Offset: 0x0007AB60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698861, XrefRangeEnd = 698866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDragTargetSelectionPromptBehaviour._ResetHinting_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000914 RID: 2324
			// (get) Token: 0x060020FC RID: 8444 RVA: 0x0007C994 File Offset: 0x0007AB94
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDragTargetSelectionPromptBehaviour._ResetHinting_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060020FD RID: 8445 RVA: 0x000128F2 File Offset: 0x00010AF2
			public _ResetHinting_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000910 RID: 2320
			// (get) Token: 0x060020FE RID: 8446 RVA: 0x0007C9D4 File Offset: 0x0007ABD4
			// (set) Token: 0x060020FF RID: 8447 RVA: 0x000128FB File Offset: 0x00010AFB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDragTargetSelectionPromptBehaviour._ResetHinting_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDragTargetSelectionPromptBehaviour._ResetHinting_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000911 RID: 2321
			// (get) Token: 0x06002100 RID: 8448 RVA: 0x0007C9FC File Offset: 0x0007ABFC
			// (set) Token: 0x06002101 RID: 8449 RVA: 0x00012916 File Offset: 0x00010B16
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDragTargetSelectionPromptBehaviour._ResetHinting_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDragTargetSelectionPromptBehaviour._ResetHinting_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000912 RID: 2322
			// (get) Token: 0x06002102 RID: 8450 RVA: 0x0007CA2C File Offset: 0x0007AC2C
			// (set) Token: 0x06002103 RID: 8451 RVA: 0x00012935 File Offset: 0x00010B35
			public unsafe WormDragTargetSelectionPromptBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDragTargetSelectionPromptBehaviour._ResetHinting_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormDragTargetSelectionPromptBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDragTargetSelectionPromptBehaviour._ResetHinting_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040012FD RID: 4861
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040012FE RID: 4862
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040012FF RID: 4863
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001300 RID: 4864
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001301 RID: 4865
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001302 RID: 4866
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001303 RID: 4867
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001304 RID: 4868
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001305 RID: 4869
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
