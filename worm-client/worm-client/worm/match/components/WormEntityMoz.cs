using System;
using boardgames.moz;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine.EventSystems;

namespace worm.match.components
{
	// Token: 0x020001ED RID: 493
	public class WormEntityMoz : BaseMoz
	{
		// Token: 0x060015CF RID: 5583 RVA: 0x0005A664 File Offset: 0x00058864
		// Note: this type is marked as 'beforefieldinit'.
		static WormEntityMoz()
		{
			Il2CppClassPointerStore<WormEntityMoz>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormEntityMoz");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEntityMoz>.NativeClassPtr);
			WormEntityMoz.NativeFieldInfoPtr_entityView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEntityMoz>.NativeClassPtr, "entityView");
			WormEntityMoz.NativeFieldInfoPtr_tooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEntityMoz>.NativeClassPtr, "tooltip");
			WormEntityMoz.NativeMethodInfoPtr_Start_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityMoz>.NativeClassPtr, 100666314);
			WormEntityMoz.NativeMethodInfoPtr_initMoz_Protected_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityMoz>.NativeClassPtr, 100666315);
			WormEntityMoz.NativeMethodInfoPtr_updateMoz_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityMoz>.NativeClassPtr, 100666316);
			WormEntityMoz.NativeMethodInfoPtr_endMoz_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityMoz>.NativeClassPtr, 100666317);
			WormEntityMoz.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityMoz>.NativeClassPtr, 100666318);
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x0005A720 File Offset: 0x00058920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715882, XrefRangeEnd = 715891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEntityMoz.NativeMethodInfoPtr_Start_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015D1 RID: 5585 RVA: 0x0005A75C File Offset: 0x0005895C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715891, XrefRangeEnd = 715903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initMoz(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEntityMoz.NativeMethodInfoPtr_initMoz_Protected_Virtual_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015D2 RID: 5586 RVA: 0x0005A7AC File Offset: 0x000589AC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void updateMoz()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEntityMoz.NativeMethodInfoPtr_updateMoz_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015D3 RID: 5587 RVA: 0x0005A7E8 File Offset: 0x000589E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715903, XrefRangeEnd = 715915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void endMoz()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEntityMoz.NativeMethodInfoPtr_endMoz_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015D4 RID: 5588 RVA: 0x0005A824 File Offset: 0x00058A24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 510035, RefRangeEnd = 510036, XrefRangeStart = 510035, XrefRangeEnd = 510036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEntityMoz()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEntityMoz>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntityMoz.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x0000D2E2 File Offset: 0x0000B4E2
		public WormEntityMoz(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x060015D6 RID: 5590 RVA: 0x0005A860 File Offset: 0x00058A60
		// (set) Token: 0x060015D7 RID: 5591 RVA: 0x0000D2EB File Offset: 0x0000B4EB
		public unsafe EntityView entityView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEntityMoz.NativeFieldInfoPtr_entityView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEntityMoz.NativeFieldInfoPtr_entityView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x060015D8 RID: 5592 RVA: 0x0005A890 File Offset: 0x00058A90
		// (set) Token: 0x060015D9 RID: 5593 RVA: 0x0000D30A File Offset: 0x0000B50A
		public unsafe DBGTooltip tooltip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEntityMoz.NativeFieldInfoPtr_tooltip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGTooltip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEntityMoz.NativeFieldInfoPtr_tooltip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CA9 RID: 3241
		private static readonly IntPtr NativeFieldInfoPtr_entityView;

		// Token: 0x04000CAA RID: 3242
		private static readonly IntPtr NativeFieldInfoPtr_tooltip;

		// Token: 0x04000CAB RID: 3243
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Void_0;

		// Token: 0x04000CAC RID: 3244
		private static readonly IntPtr NativeMethodInfoPtr_initMoz_Protected_Virtual_Void_PointerEventData_0;

		// Token: 0x04000CAD RID: 3245
		private static readonly IntPtr NativeMethodInfoPtr_updateMoz_Protected_Virtual_Void_0;

		// Token: 0x04000CAE RID: 3246
		private static readonly IntPtr NativeMethodInfoPtr_endMoz_Protected_Virtual_Void_0;

		// Token: 0x04000CAF RID: 3247
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
