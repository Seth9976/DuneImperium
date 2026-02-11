using System;
using boardgames.ranked.menus;
using boardgames.utils;
using dwd.iap.store;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using worm.canis.data.enums;

namespace worm.menus.components
{
	// Token: 0x020000A3 RID: 163
	public class WormRankedPlayQueueButton : RankedPlayQueueButton
	{
		// Token: 0x06000659 RID: 1625 RVA: 0x0002BFEC File Offset: 0x0002A1EC
		// Note: this type is marked as 'beforefieldinit'.
		static WormRankedPlayQueueButton()
		{
			Il2CppClassPointerStore<WormRankedPlayQueueButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.menus.components", "WormRankedPlayQueueButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormRankedPlayQueueButton>.NativeClassPtr);
			WormRankedPlayQueueButton.NativeFieldInfoPtr_iapStoreBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRankedPlayQueueButton>.NativeClassPtr, "iapStoreBehaviour");
			WormRankedPlayQueueButton.NativeFieldInfoPtr_productUtils = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRankedPlayQueueButton>.NativeClassPtr, "productUtils");
			WormRankedPlayQueueButton.NativeFieldInfoPtr_RepLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRankedPlayQueueButton>.NativeClassPtr, "RepLimit");
			WormRankedPlayQueueButton.NativeFieldInfoPtr_useRep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRankedPlayQueueButton>.NativeClassPtr, "useRep");
			WormRankedPlayQueueButton.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRankedPlayQueueButton>.NativeClassPtr, 100664190);
			WormRankedPlayQueueButton.NativeMethodInfoPtr_OwnsCurrentSets_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRankedPlayQueueButton>.NativeClassPtr, 100664191);
			WormRankedPlayQueueButton.NativeMethodInfoPtr_GameSpecificRequirements_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRankedPlayQueueButton>.NativeClassPtr, 100664192);
			WormRankedPlayQueueButton.NativeMethodInfoPtr_Event_OpenShop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRankedPlayQueueButton>.NativeClassPtr, 100664193);
			WormRankedPlayQueueButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRankedPlayQueueButton>.NativeClassPtr, 100664194);
			WormRankedPlayQueueButton.NativeMethodInfoPtr__OwnsCurrentSets_b__5_0_Private_Boolean_Set_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRankedPlayQueueButton>.NativeClassPtr, 100664195);
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x0002C0E4 File Offset: 0x0002A2E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696248, XrefRangeEnd = 696255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormRankedPlayQueueButton.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x0002C120 File Offset: 0x0002A320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696255, XrefRangeEnd = 696280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool OwnsCurrentSets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormRankedPlayQueueButton.NativeMethodInfoPtr_OwnsCurrentSets_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x0002C168 File Offset: 0x0002A368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696280, XrefRangeEnd = 696284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool GameSpecificRequirements()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormRankedPlayQueueButton.NativeMethodInfoPtr_GameSpecificRequirements_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x0002C1B0 File Offset: 0x0002A3B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696284, XrefRangeEnd = 696293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_OpenShop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRankedPlayQueueButton.NativeMethodInfoPtr_Event_OpenShop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x0002C1E4 File Offset: 0x0002A3E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696293, XrefRangeEnd = 696294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormRankedPlayQueueButton()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormRankedPlayQueueButton>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRankedPlayQueueButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x0002C220 File Offset: 0x0002A420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696294, XrefRangeEnd = 696298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _OwnsCurrentSets_b__5_0(Set requiredSet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref requiredSet;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRankedPlayQueueButton.NativeMethodInfoPtr__OwnsCurrentSets_b__5_0_Private_Boolean_Set_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x000052C4 File Offset: 0x000034C4
		public WormRankedPlayQueueButton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000661 RID: 1633 RVA: 0x0002C26C File Offset: 0x0002A46C
		// (set) Token: 0x06000662 RID: 1634 RVA: 0x000052CD File Offset: 0x000034CD
		public unsafe IAPStoreBehaviour iapStoreBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRankedPlayQueueButton.NativeFieldInfoPtr_iapStoreBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAPStoreBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRankedPlayQueueButton.NativeFieldInfoPtr_iapStoreBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000663 RID: 1635 RVA: 0x0002C29C File Offset: 0x0002A49C
		// (set) Token: 0x06000664 RID: 1636 RVA: 0x000052EC File Offset: 0x000034EC
		public unsafe ProductUtils productUtils
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRankedPlayQueueButton.NativeFieldInfoPtr_productUtils);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductUtils>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRankedPlayQueueButton.NativeFieldInfoPtr_productUtils), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000665 RID: 1637 RVA: 0x0002C2CC File Offset: 0x0002A4CC
		// (set) Token: 0x06000666 RID: 1638 RVA: 0x0000530B File Offset: 0x0000350B
		public unsafe int RepLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRankedPlayQueueButton.NativeFieldInfoPtr_RepLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRankedPlayQueueButton.NativeFieldInfoPtr_RepLimit)) = value;
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000667 RID: 1639 RVA: 0x0002C2F4 File Offset: 0x0002A4F4
		// (set) Token: 0x06000668 RID: 1640 RVA: 0x00005326 File Offset: 0x00003526
		public unsafe bool useRep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRankedPlayQueueButton.NativeFieldInfoPtr_useRep);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRankedPlayQueueButton.NativeFieldInfoPtr_useRep)) = value;
			}
		}

		// Token: 0x040003A6 RID: 934
		private static readonly IntPtr NativeFieldInfoPtr_iapStoreBehaviour;

		// Token: 0x040003A7 RID: 935
		private static readonly IntPtr NativeFieldInfoPtr_productUtils;

		// Token: 0x040003A8 RID: 936
		private static readonly IntPtr NativeFieldInfoPtr_RepLimit;

		// Token: 0x040003A9 RID: 937
		private static readonly IntPtr NativeFieldInfoPtr_useRep;

		// Token: 0x040003AA RID: 938
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040003AB RID: 939
		private static readonly IntPtr NativeMethodInfoPtr_OwnsCurrentSets_Protected_Virtual_Boolean_0;

		// Token: 0x040003AC RID: 940
		private static readonly IntPtr NativeMethodInfoPtr_GameSpecificRequirements_Protected_Virtual_Boolean_0;

		// Token: 0x040003AD RID: 941
		private static readonly IntPtr NativeMethodInfoPtr_Event_OpenShop_Public_Void_0;

		// Token: 0x040003AE RID: 942
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040003AF RID: 943
		private static readonly IntPtr NativeMethodInfoPtr__OwnsCurrentSets_b__5_0_Private_Boolean_Set_0;
	}
}
