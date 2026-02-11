using System;
using boardgames.moz;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lib.canis.boardgames.src.match;
using lotus;
using UnityEngine.EventSystems;

namespace worm.match.components
{
	// Token: 0x020001D4 RID: 468
	public class WormAssociatedCardMoz : CardMoz
	{
		// Token: 0x060014AE RID: 5294 RVA: 0x00056E10 File Offset: 0x00055010
		// Note: this type is marked as 'beforefieldinit'.
		static WormAssociatedCardMoz()
		{
			Il2CppClassPointerStore<WormAssociatedCardMoz>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormAssociatedCardMoz");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAssociatedCardMoz>.NativeClassPtr);
			WormAssociatedCardMoz.NativeFieldInfoPtr_entityView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAssociatedCardMoz>.NativeClassPtr, "entityView");
			WormAssociatedCardMoz.NativeFieldInfoPtr_tempEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAssociatedCardMoz>.NativeClassPtr, "tempEntity");
			WormAssociatedCardMoz.NativeFieldInfoPtr_archProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAssociatedCardMoz>.NativeClassPtr, "archProvider");
			WormAssociatedCardMoz.NativeMethodInfoPtr_Start_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAssociatedCardMoz>.NativeClassPtr, 100666129);
			WormAssociatedCardMoz.NativeMethodInfoPtr_initMoz_Protected_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAssociatedCardMoz>.NativeClassPtr, 100666130);
			WormAssociatedCardMoz.NativeMethodInfoPtr_getUnitViewData_Protected_Virtual_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAssociatedCardMoz>.NativeClassPtr, 100666131);
			WormAssociatedCardMoz.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAssociatedCardMoz>.NativeClassPtr, 100666132);
		}

		// Token: 0x060014AF RID: 5295 RVA: 0x00056ECC File Offset: 0x000550CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714441, XrefRangeEnd = 714446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAssociatedCardMoz.NativeMethodInfoPtr_Start_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014B0 RID: 5296 RVA: 0x00056F08 File Offset: 0x00055108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714446, XrefRangeEnd = 714450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initMoz(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAssociatedCardMoz.NativeMethodInfoPtr_initMoz_Protected_Virtual_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014B1 RID: 5297 RVA: 0x00056F58 File Offset: 0x00055158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714450, XrefRangeEnd = 714462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override EntityComponent getUnitViewData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAssociatedCardMoz.NativeMethodInfoPtr_getUnitViewData_Protected_Virtual_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
		}

		// Token: 0x060014B2 RID: 5298 RVA: 0x00056FA4 File Offset: 0x000551A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 510310, RefRangeEnd = 510311, XrefRangeStart = 510310, XrefRangeEnd = 510311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormAssociatedCardMoz()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAssociatedCardMoz>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAssociatedCardMoz.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014B3 RID: 5299 RVA: 0x0000CA74 File Offset: 0x0000AC74
		public WormAssociatedCardMoz(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x060014B4 RID: 5300 RVA: 0x00056FE0 File Offset: 0x000551E0
		// (set) Token: 0x060014B5 RID: 5301 RVA: 0x0000CA7D File Offset: 0x0000AC7D
		public unsafe EntityView entityView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAssociatedCardMoz.NativeFieldInfoPtr_entityView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAssociatedCardMoz.NativeFieldInfoPtr_entityView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x060014B6 RID: 5302 RVA: 0x00057010 File Offset: 0x00055210
		// (set) Token: 0x060014B7 RID: 5303 RVA: 0x0000CA9C File Offset: 0x0000AC9C
		public unsafe EntityComponent tempEntity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAssociatedCardMoz.NativeFieldInfoPtr_tempEntity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAssociatedCardMoz.NativeFieldInfoPtr_tempEntity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x060014B8 RID: 5304 RVA: 0x00057040 File Offset: 0x00055240
		// (set) Token: 0x060014B9 RID: 5305 RVA: 0x0000CABB File Offset: 0x0000ACBB
		public unsafe ArchetypeProvider archProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAssociatedCardMoz.NativeFieldInfoPtr_archProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAssociatedCardMoz.NativeFieldInfoPtr_archProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BFC RID: 3068
		private static readonly IntPtr NativeFieldInfoPtr_entityView;

		// Token: 0x04000BFD RID: 3069
		private static readonly IntPtr NativeFieldInfoPtr_tempEntity;

		// Token: 0x04000BFE RID: 3070
		private static readonly IntPtr NativeFieldInfoPtr_archProvider;

		// Token: 0x04000BFF RID: 3071
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Void_0;

		// Token: 0x04000C00 RID: 3072
		private static readonly IntPtr NativeMethodInfoPtr_initMoz_Protected_Virtual_Void_PointerEventData_0;

		// Token: 0x04000C01 RID: 3073
		private static readonly IntPtr NativeMethodInfoPtr_getUnitViewData_Protected_Virtual_EntityComponent_0;

		// Token: 0x04000C02 RID: 3074
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
