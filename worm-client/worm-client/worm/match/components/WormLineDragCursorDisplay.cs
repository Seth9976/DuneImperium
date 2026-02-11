using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x02000202 RID: 514
	public class WormLineDragCursorDisplay : VersionedView<CursorManager>
	{
		// Token: 0x060016C0 RID: 5824 RVA: 0x0005D1E8 File Offset: 0x0005B3E8
		// Note: this type is marked as 'beforefieldinit'.
		static WormLineDragCursorDisplay()
		{
			Il2CppClassPointerStore<WormLineDragCursorDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormLineDragCursorDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormLineDragCursorDisplay>.NativeClassPtr);
			WormLineDragCursorDisplay.NativeFieldInfoPtr_colorProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLineDragCursorDisplay>.NativeClassPtr, "colorProvider");
			WormLineDragCursorDisplay.NativeFieldInfoPtr_noUndoIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLineDragCursorDisplay>.NativeClassPtr, "noUndoIcon");
			WormLineDragCursorDisplay.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLineDragCursorDisplay>.NativeClassPtr, "entities");
			WormLineDragCursorDisplay.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLineDragCursorDisplay>.NativeClassPtr, 100666462);
			WormLineDragCursorDisplay.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLineDragCursorDisplay>.NativeClassPtr, 100666463);
			WormLineDragCursorDisplay.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLineDragCursorDisplay>.NativeClassPtr, 100666464);
			WormLineDragCursorDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLineDragCursorDisplay>.NativeClassPtr, 100666465);
		}

		// Token: 0x060016C1 RID: 5825 RVA: 0x0005D2A4 File Offset: 0x0005B4A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716875, XrefRangeEnd = 716881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormLineDragCursorDisplay.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016C2 RID: 5826 RVA: 0x0005D2E0 File Offset: 0x0005B4E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716881, XrefRangeEnd = 716907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormLineDragCursorDisplay.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016C3 RID: 5827 RVA: 0x0005D31C File Offset: 0x0005B51C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716907, XrefRangeEnd = 716913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormLineDragCursorDisplay.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x0005D358 File Offset: 0x0005B558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716913, XrefRangeEnd = 716916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormLineDragCursorDisplay()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormLineDragCursorDisplay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLineDragCursorDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x0000DACD File Offset: 0x0000BCCD
		public WormLineDragCursorDisplay(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x060016C6 RID: 5830 RVA: 0x0005D394 File Offset: 0x0005B594
		// (set) Token: 0x060016C7 RID: 5831 RVA: 0x0000DAD6 File Offset: 0x0000BCD6
		public unsafe SubscriptionProvider colorProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLineDragCursorDisplay.NativeFieldInfoPtr_colorProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLineDragCursorDisplay.NativeFieldInfoPtr_colorProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x060016C8 RID: 5832 RVA: 0x0005D3C4 File Offset: 0x0005B5C4
		// (set) Token: 0x060016C9 RID: 5833 RVA: 0x0000DAF5 File Offset: 0x0000BCF5
		public unsafe GameObject noUndoIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLineDragCursorDisplay.NativeFieldInfoPtr_noUndoIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLineDragCursorDisplay.NativeFieldInfoPtr_noUndoIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x060016CA RID: 5834 RVA: 0x0005D3F4 File Offset: 0x0005B5F4
		// (set) Token: 0x060016CB RID: 5835 RVA: 0x0000DB14 File Offset: 0x0000BD14
		public unsafe Entities entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLineDragCursorDisplay.NativeFieldInfoPtr_entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entities>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLineDragCursorDisplay.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D33 RID: 3379
		private static readonly IntPtr NativeFieldInfoPtr_colorProvider;

		// Token: 0x04000D34 RID: 3380
		private static readonly IntPtr NativeFieldInfoPtr_noUndoIcon;

		// Token: 0x04000D35 RID: 3381
		private static readonly IntPtr NativeFieldInfoPtr_entities;

		// Token: 0x04000D36 RID: 3382
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000D37 RID: 3383
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x04000D38 RID: 3384
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000D39 RID: 3385
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
