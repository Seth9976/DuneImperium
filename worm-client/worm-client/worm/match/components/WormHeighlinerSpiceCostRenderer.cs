using System;
using boardgames.input;
using boardgames.match.selection;
using Canis.utils.ids;
using dwd.core.match.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace worm.match.components
{
	// Token: 0x020001F8 RID: 504
	public class WormHeighlinerSpiceCostRenderer : MonoBehaviour
	{
		// Token: 0x06001648 RID: 5704 RVA: 0x0005BC84 File Offset: 0x00059E84
		// Note: this type is marked as 'beforefieldinit'.
		static WormHeighlinerSpiceCostRenderer()
		{
			Il2CppClassPointerStore<WormHeighlinerSpiceCostRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormHeighlinerSpiceCostRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormHeighlinerSpiceCostRenderer>.NativeClassPtr);
			WormHeighlinerSpiceCostRenderer.NativeFieldInfoPtr_showDefaultCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHeighlinerSpiceCostRenderer>.NativeClassPtr, "showDefaultCost");
			WormHeighlinerSpiceCostRenderer.NativeFieldInfoPtr_showReducedCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHeighlinerSpiceCostRenderer>.NativeClassPtr, "showReducedCost");
			WormHeighlinerSpiceCostRenderer.NativeFieldInfoPtr_entitiesProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHeighlinerSpiceCostRenderer>.NativeClassPtr, "entitiesProvider");
			WormHeighlinerSpiceCostRenderer.NativeFieldInfoPtr_responder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHeighlinerSpiceCostRenderer>.NativeClassPtr, "responder");
			WormHeighlinerSpiceCostRenderer.NativeFieldInfoPtr_cachedCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHeighlinerSpiceCostRenderer>.NativeClassPtr, "cachedCard");
			WormHeighlinerSpiceCostRenderer.NativeFieldInfoPtr_cachedCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHeighlinerSpiceCostRenderer>.NativeClassPtr, "cachedCommand");
			WormHeighlinerSpiceCostRenderer.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHeighlinerSpiceCostRenderer>.NativeClassPtr, 100666383);
			WormHeighlinerSpiceCostRenderer.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHeighlinerSpiceCostRenderer>.NativeClassPtr, 100666384);
			WormHeighlinerSpiceCostRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHeighlinerSpiceCostRenderer>.NativeClassPtr, 100666385);
			WormHeighlinerSpiceCostRenderer.NativeMethodInfoPtr_Method_Private_ArchetypeID_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHeighlinerSpiceCostRenderer>.NativeClassPtr, 100666386);
		}

		// Token: 0x06001649 RID: 5705 RVA: 0x0005BD7C File Offset: 0x00059F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716261, XrefRangeEnd = 716267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHeighlinerSpiceCostRenderer.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600164A RID: 5706 RVA: 0x0005BDB0 File Offset: 0x00059FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716267, XrefRangeEnd = 716357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHeighlinerSpiceCostRenderer.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600164B RID: 5707 RVA: 0x0005BDE4 File Offset: 0x00059FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716357, XrefRangeEnd = 716370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormHeighlinerSpiceCostRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormHeighlinerSpiceCostRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHeighlinerSpiceCostRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x0005BE20 File Offset: 0x0005A020
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 716386, RefRangeEnd = 716388, XrefRangeStart = 716370, XrefRangeEnd = 716386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArchetypeID Method_Private_ArchetypeID_EntityID_0(EntityID id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHeighlinerSpiceCostRenderer.NativeMethodInfoPtr_Method_Private_ArchetypeID_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr3) : null;
			}
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x0000D6CE File Offset: 0x0000B8CE
		public WormHeighlinerSpiceCostRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x0600164E RID: 5710 RVA: 0x0005BE70 File Offset: 0x0005A070
		// (set) Token: 0x0600164F RID: 5711 RVA: 0x0000D6D7 File Offset: 0x0000B8D7
		public unsafe UnityEvent showDefaultCost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHeighlinerSpiceCostRenderer.NativeFieldInfoPtr_showDefaultCost);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHeighlinerSpiceCostRenderer.NativeFieldInfoPtr_showDefaultCost), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06001650 RID: 5712 RVA: 0x0005BEA0 File Offset: 0x0005A0A0
		// (set) Token: 0x06001651 RID: 5713 RVA: 0x0000D6F6 File Offset: 0x0000B8F6
		public unsafe UnityEvent<string> showReducedCost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHeighlinerSpiceCostRenderer.NativeFieldInfoPtr_showReducedCost);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHeighlinerSpiceCostRenderer.NativeFieldInfoPtr_showReducedCost), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06001652 RID: 5714 RVA: 0x0005BED0 File Offset: 0x0005A0D0
		// (set) Token: 0x06001653 RID: 5715 RVA: 0x0000D715 File Offset: 0x0000B915
		public unsafe EntitiesProvider entitiesProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHeighlinerSpiceCostRenderer.NativeFieldInfoPtr_entitiesProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntitiesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHeighlinerSpiceCostRenderer.NativeFieldInfoPtr_entitiesProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06001654 RID: 5716 RVA: 0x0005BF00 File Offset: 0x0005A100
		// (set) Token: 0x06001655 RID: 5717 RVA: 0x0000D734 File Offset: 0x0000B934
		public unsafe DBGSelectionResponder responder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHeighlinerSpiceCostRenderer.NativeFieldInfoPtr_responder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGSelectionResponder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHeighlinerSpiceCostRenderer.NativeFieldInfoPtr_responder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06001656 RID: 5718 RVA: 0x0005BF30 File Offset: 0x0005A130
		// (set) Token: 0x06001657 RID: 5719 RVA: 0x0000D753 File Offset: 0x0000B953
		public unsafe DraggableCard cachedCard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHeighlinerSpiceCostRenderer.NativeFieldInfoPtr_cachedCard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DraggableCard>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHeighlinerSpiceCostRenderer.NativeFieldInfoPtr_cachedCard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06001658 RID: 5720 RVA: 0x0005BF60 File Offset: 0x0005A160
		// (set) Token: 0x06001659 RID: 5721 RVA: 0x0000D772 File Offset: 0x0000B972
		public unsafe string cachedCommand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHeighlinerSpiceCostRenderer.NativeFieldInfoPtr_cachedCommand);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHeighlinerSpiceCostRenderer.NativeFieldInfoPtr_cachedCommand), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000CEE RID: 3310
		private static readonly IntPtr NativeFieldInfoPtr_showDefaultCost;

		// Token: 0x04000CEF RID: 3311
		private static readonly IntPtr NativeFieldInfoPtr_showReducedCost;

		// Token: 0x04000CF0 RID: 3312
		private static readonly IntPtr NativeFieldInfoPtr_entitiesProvider;

		// Token: 0x04000CF1 RID: 3313
		private static readonly IntPtr NativeFieldInfoPtr_responder;

		// Token: 0x04000CF2 RID: 3314
		private static readonly IntPtr NativeFieldInfoPtr_cachedCard;

		// Token: 0x04000CF3 RID: 3315
		private static readonly IntPtr NativeFieldInfoPtr_cachedCommand;

		// Token: 0x04000CF4 RID: 3316
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000CF5 RID: 3317
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000CF6 RID: 3318
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000CF7 RID: 3319
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_ArchetypeID_EntityID_0;
	}
}
