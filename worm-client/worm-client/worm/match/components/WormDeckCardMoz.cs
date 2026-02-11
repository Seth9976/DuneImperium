using System;
using boardgames.moz;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine.EventSystems;

namespace worm.match.components
{
	// Token: 0x020001E3 RID: 483
	public class WormDeckCardMoz : CardMoz
	{
		// Token: 0x0600155A RID: 5466 RVA: 0x00058E78 File Offset: 0x00057078
		// Note: this type is marked as 'beforefieldinit'.
		static WormDeckCardMoz()
		{
			Il2CppClassPointerStore<WormDeckCardMoz>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormDeckCardMoz");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormDeckCardMoz>.NativeClassPtr);
			WormDeckCardMoz.NativeFieldInfoPtr_deckRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDeckCardMoz>.NativeClassPtr, "deckRoot");
			WormDeckCardMoz.NativeMethodInfoPtr_Start_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDeckCardMoz>.NativeClassPtr, 100666244);
			WormDeckCardMoz.NativeMethodInfoPtr_initMoz_Protected_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDeckCardMoz>.NativeClassPtr, 100666245);
			WormDeckCardMoz.NativeMethodInfoPtr_getUnitViewData_Protected_Virtual_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDeckCardMoz>.NativeClassPtr, 100666246);
			WormDeckCardMoz.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDeckCardMoz>.NativeClassPtr, 100666247);
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x00058F0C File Offset: 0x0005710C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715182, XrefRangeEnd = 715183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormDeckCardMoz.NativeMethodInfoPtr_Start_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x00058F48 File Offset: 0x00057148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715183, XrefRangeEnd = 715188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initMoz(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormDeckCardMoz.NativeMethodInfoPtr_initMoz_Protected_Virtual_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x00058F98 File Offset: 0x00057198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715188, XrefRangeEnd = 715192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override EntityComponent getUnitViewData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormDeckCardMoz.NativeMethodInfoPtr_getUnitViewData_Protected_Virtual_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
		}

		// Token: 0x0600155E RID: 5470 RVA: 0x00058FE4 File Offset: 0x000571E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 510310, RefRangeEnd = 510311, XrefRangeStart = 510310, XrefRangeEnd = 510311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormDeckCardMoz()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormDeckCardMoz>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDeckCardMoz.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x0000CFC0 File Offset: 0x0000B1C0
		public WormDeckCardMoz(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06001560 RID: 5472 RVA: 0x00059020 File Offset: 0x00057220
		// (set) Token: 0x06001561 RID: 5473 RVA: 0x0000CFC9 File Offset: 0x0000B1C9
		public unsafe EntityView deckRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeckCardMoz.NativeFieldInfoPtr_deckRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeckCardMoz.NativeFieldInfoPtr_deckRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C61 RID: 3169
		private static readonly IntPtr NativeFieldInfoPtr_deckRoot;

		// Token: 0x04000C62 RID: 3170
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Void_0;

		// Token: 0x04000C63 RID: 3171
		private static readonly IntPtr NativeMethodInfoPtr_initMoz_Protected_Virtual_Void_PointerEventData_0;

		// Token: 0x04000C64 RID: 3172
		private static readonly IntPtr NativeMethodInfoPtr_getUnitViewData_Protected_Virtual_EntityComponent_0;

		// Token: 0x04000C65 RID: 3173
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
