using System;
using boardgames.match.behaviours;
using boardgames.match.selection;
using Canis.attributes;
using dwd.core.match.selection;
using dwd.core.ui.match.prompt.prompts;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using lotus;
using UnityEngine;
using worm.canis.data.enums;
using worm.client.match.render;

namespace worm.match.prompts.behaviours
{
	// Token: 0x020000D9 RID: 217
	public class WormImperiumRowRevealPromptBehaviour : PromptBehaviour<FlavoredDismissablePrompt>
	{
		// Token: 0x06000922 RID: 2338 RVA: 0x000341B8 File Offset: 0x000323B8
		// Note: this type is marked as 'beforefieldinit'.
		static WormImperiumRowRevealPromptBehaviour()
		{
			Il2CppClassPointerStore<WormImperiumRowRevealPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.behaviours", "WormImperiumRowRevealPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormImperiumRowRevealPromptBehaviour>.NativeClassPtr);
			WormImperiumRowRevealPromptBehaviour.NativeFieldInfoPtr_playAreaContainerView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormImperiumRowRevealPromptBehaviour>.NativeClassPtr, "playAreaContainerView");
			WormImperiumRowRevealPromptBehaviour.NativeFieldInfoPtr_acquiredPileRefresher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormImperiumRowRevealPromptBehaviour>.NativeClassPtr, "acquiredPileRefresher");
			WormImperiumRowRevealPromptBehaviour.NativeFieldInfoPtr_autoDismissDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormImperiumRowRevealPromptBehaviour>.NativeClassPtr, "autoDismissDelay");
			WormImperiumRowRevealPromptBehaviour.NativeFieldInfoPtr_entitiesProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormImperiumRowRevealPromptBehaviour>.NativeClassPtr, "entitiesProvider");
			WormImperiumRowRevealPromptBehaviour.NativeFieldInfoPtr_selectionResponder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormImperiumRowRevealPromptBehaviour>.NativeClassPtr, "selectionResponder");
			WormImperiumRowRevealPromptBehaviour.NativeFieldInfoPtr_turnTypeAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormImperiumRowRevealPromptBehaviour>.NativeClassPtr, "turnTypeAttribute");
			WormImperiumRowRevealPromptBehaviour.NativeFieldInfoPtr_cachedVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormImperiumRowRevealPromptBehaviour>.NativeClassPtr, "cachedVersion");
			WormImperiumRowRevealPromptBehaviour.NativeFieldInfoPtr_previousTurnType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormImperiumRowRevealPromptBehaviour>.NativeClassPtr, "previousTurnType");
			WormImperiumRowRevealPromptBehaviour.NativeFieldInfoPtr_dismissCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormImperiumRowRevealPromptBehaviour>.NativeClassPtr, "dismissCoroutine");
			WormImperiumRowRevealPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormImperiumRowRevealPromptBehaviour>.NativeClassPtr, 100664544);
			WormImperiumRowRevealPromptBehaviour.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormImperiumRowRevealPromptBehaviour>.NativeClassPtr, 100664545);
			WormImperiumRowRevealPromptBehaviour.NativeMethodInfoPtr_StartDismiss_Private_IEnumerator_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormImperiumRowRevealPromptBehaviour>.NativeClassPtr, 100664546);
			WormImperiumRowRevealPromptBehaviour.NativeMethodInfoPtr_cleanup_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormImperiumRowRevealPromptBehaviour>.NativeClassPtr, 100664547);
			WormImperiumRowRevealPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormImperiumRowRevealPromptBehaviour>.NativeClassPtr, 100664548);
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x00034300 File Offset: 0x00032500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 699552, XrefRangeEnd = 699577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormImperiumRowRevealPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x0003433C File Offset: 0x0003253C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 699577, XrefRangeEnd = 699595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormImperiumRowRevealPromptBehaviour.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x00034370 File Offset: 0x00032570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 699595, XrefRangeEnd = 699601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator StartDismiss(ISelectionNode currentSelection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentSelection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormImperiumRowRevealPromptBehaviour.NativeMethodInfoPtr_StartDismiss_Private_IEnumerator_ISelectionNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x000343C0 File Offset: 0x000325C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 699601, XrefRangeEnd = 699603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormImperiumRowRevealPromptBehaviour.NativeMethodInfoPtr_cleanup_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x000343FC File Offset: 0x000325FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 699603, XrefRangeEnd = 699606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormImperiumRowRevealPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormImperiumRowRevealPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormImperiumRowRevealPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x00006AE3 File Offset: 0x00004CE3
		public WormImperiumRowRevealPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000929 RID: 2345 RVA: 0x00034438 File Offset: 0x00032638
		// (set) Token: 0x0600092A RID: 2346 RVA: 0x00006AEC File Offset: 0x00004CEC
		public unsafe ContainerView playAreaContainerView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumRowRevealPromptBehaviour.NativeFieldInfoPtr_playAreaContainerView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumRowRevealPromptBehaviour.NativeFieldInfoPtr_playAreaContainerView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x0600092B RID: 2347 RVA: 0x00034468 File Offset: 0x00032668
		// (set) Token: 0x0600092C RID: 2348 RVA: 0x00006B0B File Offset: 0x00004D0B
		public unsafe AnimatedPileRefresher acquiredPileRefresher
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumRowRevealPromptBehaviour.NativeFieldInfoPtr_acquiredPileRefresher);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimatedPileRefresher>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumRowRevealPromptBehaviour.NativeFieldInfoPtr_acquiredPileRefresher), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x0600092D RID: 2349 RVA: 0x00034498 File Offset: 0x00032698
		// (set) Token: 0x0600092E RID: 2350 RVA: 0x00006B2A File Offset: 0x00004D2A
		public unsafe float autoDismissDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumRowRevealPromptBehaviour.NativeFieldInfoPtr_autoDismissDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumRowRevealPromptBehaviour.NativeFieldInfoPtr_autoDismissDelay)) = value;
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x0600092F RID: 2351 RVA: 0x000344C0 File Offset: 0x000326C0
		// (set) Token: 0x06000930 RID: 2352 RVA: 0x00006B45 File Offset: 0x00004D45
		public unsafe DBGEntitiesProvider entitiesProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumRowRevealPromptBehaviour.NativeFieldInfoPtr_entitiesProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumRowRevealPromptBehaviour.NativeFieldInfoPtr_entitiesProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000931 RID: 2353 RVA: 0x000344F0 File Offset: 0x000326F0
		// (set) Token: 0x06000932 RID: 2354 RVA: 0x00006B64 File Offset: 0x00004D64
		public unsafe DBGSelectionResponder selectionResponder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumRowRevealPromptBehaviour.NativeFieldInfoPtr_selectionResponder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGSelectionResponder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumRowRevealPromptBehaviour.NativeFieldInfoPtr_selectionResponder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000933 RID: 2355 RVA: 0x00034520 File Offset: 0x00032720
		// (set) Token: 0x06000934 RID: 2356 RVA: 0x00006B83 File Offset: 0x00004D83
		public unsafe IAttribute<Nullable<PlayerTurnTypes>> turnTypeAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumRowRevealPromptBehaviour.NativeFieldInfoPtr_turnTypeAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<PlayerTurnTypes>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumRowRevealPromptBehaviour.NativeFieldInfoPtr_turnTypeAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000935 RID: 2357 RVA: 0x00034550 File Offset: 0x00032750
		// (set) Token: 0x06000936 RID: 2358 RVA: 0x00006BA2 File Offset: 0x00004DA2
		public unsafe ulong cachedVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumRowRevealPromptBehaviour.NativeFieldInfoPtr_cachedVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumRowRevealPromptBehaviour.NativeFieldInfoPtr_cachedVersion)) = value;
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000937 RID: 2359 RVA: 0x00034578 File Offset: 0x00032778
		// (set) Token: 0x06000938 RID: 2360 RVA: 0x00006BBD File Offset: 0x00004DBD
		public unsafe PlayerTurnTypes previousTurnType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumRowRevealPromptBehaviour.NativeFieldInfoPtr_previousTurnType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumRowRevealPromptBehaviour.NativeFieldInfoPtr_previousTurnType)) = value;
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000939 RID: 2361 RVA: 0x000345A0 File Offset: 0x000327A0
		// (set) Token: 0x0600093A RID: 2362 RVA: 0x00006BD8 File Offset: 0x00004DD8
		public unsafe Coroutine dismissCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumRowRevealPromptBehaviour.NativeFieldInfoPtr_dismissCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumRowRevealPromptBehaviour.NativeFieldInfoPtr_dismissCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000541 RID: 1345
		private static readonly IntPtr NativeFieldInfoPtr_playAreaContainerView;

		// Token: 0x04000542 RID: 1346
		private static readonly IntPtr NativeFieldInfoPtr_acquiredPileRefresher;

		// Token: 0x04000543 RID: 1347
		private static readonly IntPtr NativeFieldInfoPtr_autoDismissDelay;

		// Token: 0x04000544 RID: 1348
		private static readonly IntPtr NativeFieldInfoPtr_entitiesProvider;

		// Token: 0x04000545 RID: 1349
		private static readonly IntPtr NativeFieldInfoPtr_selectionResponder;

		// Token: 0x04000546 RID: 1350
		private static readonly IntPtr NativeFieldInfoPtr_turnTypeAttribute;

		// Token: 0x04000547 RID: 1351
		private static readonly IntPtr NativeFieldInfoPtr_cachedVersion;

		// Token: 0x04000548 RID: 1352
		private static readonly IntPtr NativeFieldInfoPtr_previousTurnType;

		// Token: 0x04000549 RID: 1353
		private static readonly IntPtr NativeFieldInfoPtr_dismissCoroutine;

		// Token: 0x0400054A RID: 1354
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x0400054B RID: 1355
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400054C RID: 1356
		private static readonly IntPtr NativeMethodInfoPtr_StartDismiss_Private_IEnumerator_ISelectionNode_0;

		// Token: 0x0400054D RID: 1357
		private static readonly IntPtr NativeMethodInfoPtr_cleanup_Protected_Virtual_Void_0;

		// Token: 0x0400054E RID: 1358
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000335 RID: 821
		[ObfuscatedName("worm.match.prompts.behaviours.WormImperiumRowRevealPromptBehaviour+<StartDismiss>d__11")]
		public sealed class _StartDismiss_d__11 : global::Il2CppSystem.Object
		{
			// Token: 0x06002130 RID: 8496 RVA: 0x0007D314 File Offset: 0x0007B514
			// Note: this type is marked as 'beforefieldinit'.
			static _StartDismiss_d__11()
			{
				Il2CppClassPointerStore<WormImperiumRowRevealPromptBehaviour._StartDismiss_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormImperiumRowRevealPromptBehaviour>.NativeClassPtr, "<StartDismiss>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormImperiumRowRevealPromptBehaviour._StartDismiss_d__11>.NativeClassPtr);
				WormImperiumRowRevealPromptBehaviour._StartDismiss_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormImperiumRowRevealPromptBehaviour._StartDismiss_d__11>.NativeClassPtr, "<>1__state");
				WormImperiumRowRevealPromptBehaviour._StartDismiss_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormImperiumRowRevealPromptBehaviour._StartDismiss_d__11>.NativeClassPtr, "<>2__current");
				WormImperiumRowRevealPromptBehaviour._StartDismiss_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormImperiumRowRevealPromptBehaviour._StartDismiss_d__11>.NativeClassPtr, "<>4__this");
				WormImperiumRowRevealPromptBehaviour._StartDismiss_d__11.NativeFieldInfoPtr_currentSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormImperiumRowRevealPromptBehaviour._StartDismiss_d__11>.NativeClassPtr, "currentSelection");
				WormImperiumRowRevealPromptBehaviour._StartDismiss_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormImperiumRowRevealPromptBehaviour._StartDismiss_d__11>.NativeClassPtr, 100664549);
				WormImperiumRowRevealPromptBehaviour._StartDismiss_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormImperiumRowRevealPromptBehaviour._StartDismiss_d__11>.NativeClassPtr, 100664550);
				WormImperiumRowRevealPromptBehaviour._StartDismiss_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormImperiumRowRevealPromptBehaviour._StartDismiss_d__11>.NativeClassPtr, 100664551);
				WormImperiumRowRevealPromptBehaviour._StartDismiss_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormImperiumRowRevealPromptBehaviour._StartDismiss_d__11>.NativeClassPtr, 100664552);
				WormImperiumRowRevealPromptBehaviour._StartDismiss_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormImperiumRowRevealPromptBehaviour._StartDismiss_d__11>.NativeClassPtr, 100664553);
				WormImperiumRowRevealPromptBehaviour._StartDismiss_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormImperiumRowRevealPromptBehaviour._StartDismiss_d__11>.NativeClassPtr, 100664554);
			}

			// Token: 0x06002131 RID: 8497 RVA: 0x0007D408 File Offset: 0x0007B608
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _StartDismiss_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormImperiumRowRevealPromptBehaviour._StartDismiss_d__11>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormImperiumRowRevealPromptBehaviour._StartDismiss_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002132 RID: 8498 RVA: 0x0007D450 File Offset: 0x0007B650
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormImperiumRowRevealPromptBehaviour._StartDismiss_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002133 RID: 8499 RVA: 0x0007D484 File Offset: 0x0007B684
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 699541, XrefRangeEnd = 699547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormImperiumRowRevealPromptBehaviour._StartDismiss_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000925 RID: 2341
			// (get) Token: 0x06002134 RID: 8500 RVA: 0x0007D4C0 File Offset: 0x0007B6C0
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormImperiumRowRevealPromptBehaviour._StartDismiss_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002135 RID: 8501 RVA: 0x0007D500 File Offset: 0x0007B700
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 699547, XrefRangeEnd = 699552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormImperiumRowRevealPromptBehaviour._StartDismiss_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000926 RID: 2342
			// (get) Token: 0x06002136 RID: 8502 RVA: 0x0007D534 File Offset: 0x0007B734
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormImperiumRowRevealPromptBehaviour._StartDismiss_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002137 RID: 8503 RVA: 0x00012A69 File Offset: 0x00010C69
			public _StartDismiss_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000921 RID: 2337
			// (get) Token: 0x06002138 RID: 8504 RVA: 0x0007D574 File Offset: 0x0007B774
			// (set) Token: 0x06002139 RID: 8505 RVA: 0x00012A72 File Offset: 0x00010C72
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumRowRevealPromptBehaviour._StartDismiss_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumRowRevealPromptBehaviour._StartDismiss_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000922 RID: 2338
			// (get) Token: 0x0600213A RID: 8506 RVA: 0x0007D59C File Offset: 0x0007B79C
			// (set) Token: 0x0600213B RID: 8507 RVA: 0x00012A8D File Offset: 0x00010C8D
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumRowRevealPromptBehaviour._StartDismiss_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumRowRevealPromptBehaviour._StartDismiss_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000923 RID: 2339
			// (get) Token: 0x0600213C RID: 8508 RVA: 0x0007D5CC File Offset: 0x0007B7CC
			// (set) Token: 0x0600213D RID: 8509 RVA: 0x00012AAC File Offset: 0x00010CAC
			public unsafe WormImperiumRowRevealPromptBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumRowRevealPromptBehaviour._StartDismiss_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormImperiumRowRevealPromptBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumRowRevealPromptBehaviour._StartDismiss_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000924 RID: 2340
			// (get) Token: 0x0600213E RID: 8510 RVA: 0x0007D5FC File Offset: 0x0007B7FC
			// (set) Token: 0x0600213F RID: 8511 RVA: 0x00012ACB File Offset: 0x00010CCB
			public unsafe ISelectionNode currentSelection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumRowRevealPromptBehaviour._StartDismiss_d__11.NativeFieldInfoPtr_currentSelection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumRowRevealPromptBehaviour._StartDismiss_d__11.NativeFieldInfoPtr_currentSelection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001320 RID: 4896
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001321 RID: 4897
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001322 RID: 4898
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001323 RID: 4899
			private static readonly IntPtr NativeFieldInfoPtr_currentSelection;

			// Token: 0x04001324 RID: 4900
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001325 RID: 4901
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001326 RID: 4902
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001327 RID: 4903
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001328 RID: 4904
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001329 RID: 4905
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
