using System;
using boardgames.match;
using boardgames.match.data;
using boardgames.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using lotus;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x020001FE RID: 510
	public class WormIntrigueCardPlayHandler : VersionedView<DBGSelectionResponder>
	{
		// Token: 0x06001689 RID: 5769 RVA: 0x0005C81C File Offset: 0x0005AA1C
		// Note: this type is marked as 'beforefieldinit'.
		static WormIntrigueCardPlayHandler()
		{
			Il2CppClassPointerStore<WormIntrigueCardPlayHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormIntrigueCardPlayHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormIntrigueCardPlayHandler>.NativeClassPtr);
			WormIntrigueCardPlayHandler.NativeFieldInfoPtr_dropEffectRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormIntrigueCardPlayHandler>.NativeClassPtr, "dropEffectRoot");
			WormIntrigueCardPlayHandler.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormIntrigueCardPlayHandler>.NativeClassPtr, "entities");
			WormIntrigueCardPlayHandler.NativeFieldInfoPtr_pile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormIntrigueCardPlayHandler>.NativeClassPtr, "pile");
			WormIntrigueCardPlayHandler.NativeFieldInfoPtr_view = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormIntrigueCardPlayHandler>.NativeClassPtr, "view");
			WormIntrigueCardPlayHandler.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormIntrigueCardPlayHandler>.NativeClassPtr, "animator");
			WormIntrigueCardPlayHandler.NativeFieldInfoPtr_canvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormIntrigueCardPlayHandler>.NativeClassPtr, "canvasGroup");
			WormIntrigueCardPlayHandler.NativeFieldInfoPtr_activePlayerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormIntrigueCardPlayHandler>.NativeClassPtr, "activePlayerData");
			WormIntrigueCardPlayHandler.NativeFieldInfoPtr_ShowParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormIntrigueCardPlayHandler>.NativeClassPtr, "ShowParam");
			WormIntrigueCardPlayHandler.NativeFieldInfoPtr_HideParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormIntrigueCardPlayHandler>.NativeClassPtr, "HideParam");
			WormIntrigueCardPlayHandler.NativeMethodInfoPtr_get_currentModelVersion_Protected_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIntrigueCardPlayHandler>.NativeClassPtr, 100666432);
			WormIntrigueCardPlayHandler.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIntrigueCardPlayHandler>.NativeClassPtr, 100666433);
			WormIntrigueCardPlayHandler.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIntrigueCardPlayHandler>.NativeClassPtr, 100666434);
			WormIntrigueCardPlayHandler.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIntrigueCardPlayHandler>.NativeClassPtr, 100666435);
			WormIntrigueCardPlayHandler.NativeMethodInfoPtr_AnimateOnDrop_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIntrigueCardPlayHandler>.NativeClassPtr, 100666436);
			WormIntrigueCardPlayHandler.NativeMethodInfoPtr_Event_RemoveFake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIntrigueCardPlayHandler>.NativeClassPtr, 100666437);
			WormIntrigueCardPlayHandler.NativeMethodInfoPtr_Event_OnResetDrag_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIntrigueCardPlayHandler>.NativeClassPtr, 100666438);
			WormIntrigueCardPlayHandler.NativeMethodInfoPtr_Event_SpawnDropEffect_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIntrigueCardPlayHandler>.NativeClassPtr, 100666439);
			WormIntrigueCardPlayHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIntrigueCardPlayHandler>.NativeClassPtr, 100666440);
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x0600168A RID: 5770 RVA: 0x0005C9B4 File Offset: 0x0005ABB4
		public unsafe override ulong currentModelVersion
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716662, XrefRangeEnd = 716665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormIntrigueCardPlayHandler.NativeMethodInfoPtr_get_currentModelVersion_Protected_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600168B RID: 5771 RVA: 0x0005C9FC File Offset: 0x0005ABFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716665, XrefRangeEnd = 716706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormIntrigueCardPlayHandler.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600168C RID: 5772 RVA: 0x0005CA38 File Offset: 0x0005AC38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716706, XrefRangeEnd = 716710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormIntrigueCardPlayHandler.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600168D RID: 5773 RVA: 0x0005CA74 File Offset: 0x0005AC74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716710, XrefRangeEnd = 716750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormIntrigueCardPlayHandler.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x0005CAB0 File Offset: 0x0005ACB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716750, XrefRangeEnd = 716755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator AnimateOnDrop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormIntrigueCardPlayHandler.NativeMethodInfoPtr_AnimateOnDrop_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600168F RID: 5775 RVA: 0x0005CAF0 File Offset: 0x0005ACF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716755, XrefRangeEnd = 716759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_RemoveFake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormIntrigueCardPlayHandler.NativeMethodInfoPtr_Event_RemoveFake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001690 RID: 5776 RVA: 0x0005CB24 File Offset: 0x0005AD24
		[CallerCount(0)]
		public unsafe void Event_OnResetDrag()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormIntrigueCardPlayHandler.NativeMethodInfoPtr_Event_OnResetDrag_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001691 RID: 5777 RVA: 0x0005CB58 File Offset: 0x0005AD58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 716771, RefRangeEnd = 716772, XrefRangeStart = 716759, XrefRangeEnd = 716771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SpawnDropEffect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormIntrigueCardPlayHandler.NativeMethodInfoPtr_Event_SpawnDropEffect_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001692 RID: 5778 RVA: 0x0005CB8C File Offset: 0x0005AD8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716772, XrefRangeEnd = 716775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormIntrigueCardPlayHandler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormIntrigueCardPlayHandler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormIntrigueCardPlayHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001693 RID: 5779 RVA: 0x0000D8FA File Offset: 0x0000BAFA
		public WormIntrigueCardPlayHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06001694 RID: 5780 RVA: 0x0005CBC8 File Offset: 0x0005ADC8
		// (set) Token: 0x06001695 RID: 5781 RVA: 0x0000D903 File Offset: 0x0000BB03
		public unsafe GameObject dropEffectRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueCardPlayHandler.NativeFieldInfoPtr_dropEffectRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueCardPlayHandler.NativeFieldInfoPtr_dropEffectRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06001696 RID: 5782 RVA: 0x0005CBF8 File Offset: 0x0005ADF8
		// (set) Token: 0x06001697 RID: 5783 RVA: 0x0000D922 File Offset: 0x0000BB22
		public unsafe DBGEntities entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueCardPlayHandler.NativeFieldInfoPtr_entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntities>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueCardPlayHandler.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06001698 RID: 5784 RVA: 0x0005CC28 File Offset: 0x0005AE28
		// (set) Token: 0x06001699 RID: 5785 RVA: 0x0000D941 File Offset: 0x0000BB41
		public unsafe WormIntrigueActiveAreaPileView pile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueCardPlayHandler.NativeFieldInfoPtr_pile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormIntrigueActiveAreaPileView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueCardPlayHandler.NativeFieldInfoPtr_pile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x0600169A RID: 5786 RVA: 0x0005CC58 File Offset: 0x0005AE58
		// (set) Token: 0x0600169B RID: 5787 RVA: 0x0000D960 File Offset: 0x0000BB60
		public unsafe EntityView view
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueCardPlayHandler.NativeFieldInfoPtr_view);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueCardPlayHandler.NativeFieldInfoPtr_view), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x0600169C RID: 5788 RVA: 0x0005CC88 File Offset: 0x0005AE88
		// (set) Token: 0x0600169D RID: 5789 RVA: 0x0000D97F File Offset: 0x0000BB7F
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueCardPlayHandler.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueCardPlayHandler.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x0600169E RID: 5790 RVA: 0x0005CCB8 File Offset: 0x0005AEB8
		// (set) Token: 0x0600169F RID: 5791 RVA: 0x0000D99E File Offset: 0x0000BB9E
		public unsafe CanvasGroup canvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueCardPlayHandler.NativeFieldInfoPtr_canvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueCardPlayHandler.NativeFieldInfoPtr_canvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x060016A0 RID: 5792 RVA: 0x0005CCE8 File Offset: 0x0005AEE8
		// (set) Token: 0x060016A1 RID: 5793 RVA: 0x0000D9BD File Offset: 0x0000BBBD
		public unsafe ActivePlayerData activePlayerData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueCardPlayHandler.NativeFieldInfoPtr_activePlayerData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActivePlayerData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueCardPlayHandler.NativeFieldInfoPtr_activePlayerData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x060016A2 RID: 5794 RVA: 0x0005CD18 File Offset: 0x0005AF18
		// (set) Token: 0x060016A3 RID: 5795 RVA: 0x0000D9DC File Offset: 0x0000BBDC
		public unsafe static int ShowParam
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WormIntrigueCardPlayHandler.NativeFieldInfoPtr_ShowParam, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormIntrigueCardPlayHandler.NativeFieldInfoPtr_ShowParam, (void*)(&value));
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x060016A4 RID: 5796 RVA: 0x0005CD34 File Offset: 0x0005AF34
		// (set) Token: 0x060016A5 RID: 5797 RVA: 0x0000D9EA File Offset: 0x0000BBEA
		public unsafe static int HideParam
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WormIntrigueCardPlayHandler.NativeFieldInfoPtr_HideParam, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormIntrigueCardPlayHandler.NativeFieldInfoPtr_HideParam, (void*)(&value));
			}
		}

		// Token: 0x04000D13 RID: 3347
		private static readonly IntPtr NativeFieldInfoPtr_dropEffectRoot;

		// Token: 0x04000D14 RID: 3348
		private static readonly IntPtr NativeFieldInfoPtr_entities;

		// Token: 0x04000D15 RID: 3349
		private static readonly IntPtr NativeFieldInfoPtr_pile;

		// Token: 0x04000D16 RID: 3350
		private static readonly IntPtr NativeFieldInfoPtr_view;

		// Token: 0x04000D17 RID: 3351
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x04000D18 RID: 3352
		private static readonly IntPtr NativeFieldInfoPtr_canvasGroup;

		// Token: 0x04000D19 RID: 3353
		private static readonly IntPtr NativeFieldInfoPtr_activePlayerData;

		// Token: 0x04000D1A RID: 3354
		private static readonly IntPtr NativeFieldInfoPtr_ShowParam;

		// Token: 0x04000D1B RID: 3355
		private static readonly IntPtr NativeFieldInfoPtr_HideParam;

		// Token: 0x04000D1C RID: 3356
		private static readonly IntPtr NativeMethodInfoPtr_get_currentModelVersion_Protected_Virtual_get_UInt64_0;

		// Token: 0x04000D1D RID: 3357
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000D1E RID: 3358
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x04000D1F RID: 3359
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000D20 RID: 3360
		private static readonly IntPtr NativeMethodInfoPtr_AnimateOnDrop_Public_IEnumerator_0;

		// Token: 0x04000D21 RID: 3361
		private static readonly IntPtr NativeMethodInfoPtr_Event_RemoveFake_Public_Void_0;

		// Token: 0x04000D22 RID: 3362
		private static readonly IntPtr NativeMethodInfoPtr_Event_OnResetDrag_Public_Void_0;

		// Token: 0x04000D23 RID: 3363
		private static readonly IntPtr NativeMethodInfoPtr_Event_SpawnDropEffect_Public_Void_0;

		// Token: 0x04000D24 RID: 3364
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003F6 RID: 1014
		[ObfuscatedName("worm.match.components.WormIntrigueCardPlayHandler+<AnimateOnDrop>d__14")]
		public sealed class _AnimateOnDrop_d__14 : global::Il2CppSystem.Object
		{
			// Token: 0x0600294E RID: 10574 RVA: 0x00095338 File Offset: 0x00093538
			// Note: this type is marked as 'beforefieldinit'.
			static _AnimateOnDrop_d__14()
			{
				Il2CppClassPointerStore<WormIntrigueCardPlayHandler._AnimateOnDrop_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormIntrigueCardPlayHandler>.NativeClassPtr, "<AnimateOnDrop>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormIntrigueCardPlayHandler._AnimateOnDrop_d__14>.NativeClassPtr);
				WormIntrigueCardPlayHandler._AnimateOnDrop_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormIntrigueCardPlayHandler._AnimateOnDrop_d__14>.NativeClassPtr, "<>1__state");
				WormIntrigueCardPlayHandler._AnimateOnDrop_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormIntrigueCardPlayHandler._AnimateOnDrop_d__14>.NativeClassPtr, "<>2__current");
				WormIntrigueCardPlayHandler._AnimateOnDrop_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormIntrigueCardPlayHandler._AnimateOnDrop_d__14>.NativeClassPtr, "<>4__this");
				WormIntrigueCardPlayHandler._AnimateOnDrop_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIntrigueCardPlayHandler._AnimateOnDrop_d__14>.NativeClassPtr, 100666442);
				WormIntrigueCardPlayHandler._AnimateOnDrop_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIntrigueCardPlayHandler._AnimateOnDrop_d__14>.NativeClassPtr, 100666443);
				WormIntrigueCardPlayHandler._AnimateOnDrop_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIntrigueCardPlayHandler._AnimateOnDrop_d__14>.NativeClassPtr, 100666444);
				WormIntrigueCardPlayHandler._AnimateOnDrop_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIntrigueCardPlayHandler._AnimateOnDrop_d__14>.NativeClassPtr, 100666445);
				WormIntrigueCardPlayHandler._AnimateOnDrop_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIntrigueCardPlayHandler._AnimateOnDrop_d__14>.NativeClassPtr, 100666446);
				WormIntrigueCardPlayHandler._AnimateOnDrop_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIntrigueCardPlayHandler._AnimateOnDrop_d__14>.NativeClassPtr, 100666447);
			}

			// Token: 0x0600294F RID: 10575 RVA: 0x00095418 File Offset: 0x00093618
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _AnimateOnDrop_d__14(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormIntrigueCardPlayHandler._AnimateOnDrop_d__14>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormIntrigueCardPlayHandler._AnimateOnDrop_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002950 RID: 10576 RVA: 0x00095460 File Offset: 0x00093660
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormIntrigueCardPlayHandler._AnimateOnDrop_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002951 RID: 10577 RVA: 0x00095494 File Offset: 0x00093694
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716623, XrefRangeEnd = 716657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormIntrigueCardPlayHandler._AnimateOnDrop_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000BA3 RID: 2979
			// (get) Token: 0x06002952 RID: 10578 RVA: 0x000954D0 File Offset: 0x000936D0
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormIntrigueCardPlayHandler._AnimateOnDrop_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002953 RID: 10579 RVA: 0x00095510 File Offset: 0x00093710
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716657, XrefRangeEnd = 716662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormIntrigueCardPlayHandler._AnimateOnDrop_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000BA4 RID: 2980
			// (get) Token: 0x06002954 RID: 10580 RVA: 0x00095544 File Offset: 0x00093744
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormIntrigueCardPlayHandler._AnimateOnDrop_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002955 RID: 10581 RVA: 0x000169D7 File Offset: 0x00014BD7
			public _AnimateOnDrop_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BA0 RID: 2976
			// (get) Token: 0x06002956 RID: 10582 RVA: 0x00095584 File Offset: 0x00093784
			// (set) Token: 0x06002957 RID: 10583 RVA: 0x000169E0 File Offset: 0x00014BE0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueCardPlayHandler._AnimateOnDrop_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueCardPlayHandler._AnimateOnDrop_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000BA1 RID: 2977
			// (get) Token: 0x06002958 RID: 10584 RVA: 0x000955AC File Offset: 0x000937AC
			// (set) Token: 0x06002959 RID: 10585 RVA: 0x000169FB File Offset: 0x00014BFB
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueCardPlayHandler._AnimateOnDrop_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueCardPlayHandler._AnimateOnDrop_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BA2 RID: 2978
			// (get) Token: 0x0600295A RID: 10586 RVA: 0x000955DC File Offset: 0x000937DC
			// (set) Token: 0x0600295B RID: 10587 RVA: 0x00016A1A File Offset: 0x00014C1A
			public unsafe WormIntrigueCardPlayHandler __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueCardPlayHandler._AnimateOnDrop_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormIntrigueCardPlayHandler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueCardPlayHandler._AnimateOnDrop_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017CF RID: 6095
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040017D0 RID: 6096
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040017D1 RID: 6097
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040017D2 RID: 6098
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040017D3 RID: 6099
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017D4 RID: 6100
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040017D5 RID: 6101
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040017D6 RID: 6102
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017D7 RID: 6103
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
