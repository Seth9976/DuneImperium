using System;
using dwd.core.ui;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x02000220 RID: 544
	public class WormWillClearUndoCursorHandler : MonoBehaviour
	{
		// Token: 0x060017D5 RID: 6101 RVA: 0x00060564 File Offset: 0x0005E764
		// Note: this type is marked as 'beforefieldinit'.
		static WormWillClearUndoCursorHandler()
		{
			Il2CppClassPointerStore<WormWillClearUndoCursorHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormWillClearUndoCursorHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormWillClearUndoCursorHandler>.NativeClassPtr);
			WormWillClearUndoCursorHandler.NativeFieldInfoPtr_cursorManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormWillClearUndoCursorHandler>.NativeClassPtr, "cursorManager");
			WormWillClearUndoCursorHandler.NativeFieldInfoPtr_activeCursors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormWillClearUndoCursorHandler>.NativeClassPtr, "activeCursors");
			WormWillClearUndoCursorHandler.NativeFieldInfoPtr__WillClearUndo_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormWillClearUndoCursorHandler>.NativeClassPtr, "<WillClearUndo>k__BackingField");
			WormWillClearUndoCursorHandler.NativeMethodInfoPtr_get_PushedCursors_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWillClearUndoCursorHandler>.NativeClassPtr, 100666604);
			WormWillClearUndoCursorHandler.NativeMethodInfoPtr_get_WillClearUndo_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWillClearUndoCursorHandler>.NativeClassPtr, 100666605);
			WormWillClearUndoCursorHandler.NativeMethodInfoPtr_set_WillClearUndo_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWillClearUndoCursorHandler>.NativeClassPtr, 100666606);
			WormWillClearUndoCursorHandler.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWillClearUndoCursorHandler>.NativeClassPtr, 100666607);
			WormWillClearUndoCursorHandler.NativeMethodInfoPtr_SetCursor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWillClearUndoCursorHandler>.NativeClassPtr, 100666608);
			WormWillClearUndoCursorHandler.NativeMethodInfoPtr_RemoveCursor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWillClearUndoCursorHandler>.NativeClassPtr, 100666609);
			WormWillClearUndoCursorHandler.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWillClearUndoCursorHandler>.NativeClassPtr, 100666610);
			WormWillClearUndoCursorHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWillClearUndoCursorHandler>.NativeClassPtr, 100666611);
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x060017D6 RID: 6102 RVA: 0x00060670 File Offset: 0x0005E870
		public unsafe int PushedCursors
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717778, XrefRangeEnd = 717779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormWillClearUndoCursorHandler.NativeMethodInfoPtr_get_PushedCursors_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x060017D7 RID: 6103 RVA: 0x000606AC File Offset: 0x0005E8AC
		// (set) Token: 0x060017D8 RID: 6104 RVA: 0x000606E8 File Offset: 0x0005E8E8
		public unsafe bool WillClearUndo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormWillClearUndoCursorHandler.NativeMethodInfoPtr_get_WillClearUndo_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormWillClearUndoCursorHandler.NativeMethodInfoPtr_set_WillClearUndo_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060017D9 RID: 6105 RVA: 0x00060728 File Offset: 0x0005E928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717779, XrefRangeEnd = 717783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormWillClearUndoCursorHandler.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017DA RID: 6106 RVA: 0x00060764 File Offset: 0x0005E964
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 717790, RefRangeEnd = 717795, XrefRangeStart = 717783, XrefRangeEnd = 717790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCursor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormWillClearUndoCursorHandler.NativeMethodInfoPtr_SetCursor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017DB RID: 6107 RVA: 0x00060798 File Offset: 0x0005E998
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 717803, RefRangeEnd = 717808, XrefRangeStart = 717795, XrefRangeEnd = 717803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveCursor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormWillClearUndoCursorHandler.NativeMethodInfoPtr_RemoveCursor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017DC RID: 6108 RVA: 0x000607CC File Offset: 0x0005E9CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717808, XrefRangeEnd = 717811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormWillClearUndoCursorHandler.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017DD RID: 6109 RVA: 0x00060800 File Offset: 0x0005EA00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 717819, RefRangeEnd = 717821, XrefRangeStart = 717811, XrefRangeEnd = 717819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormWillClearUndoCursorHandler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormWillClearUndoCursorHandler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormWillClearUndoCursorHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017DE RID: 6110 RVA: 0x0000E388 File Offset: 0x0000C588
		public WormWillClearUndoCursorHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x060017DF RID: 6111 RVA: 0x0006083C File Offset: 0x0005EA3C
		// (set) Token: 0x060017E0 RID: 6112 RVA: 0x0000E391 File Offset: 0x0000C591
		public unsafe CursorStackManager cursorManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWillClearUndoCursorHandler.NativeFieldInfoPtr_cursorManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CursorStackManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWillClearUndoCursorHandler.NativeFieldInfoPtr_cursorManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x060017E1 RID: 6113 RVA: 0x0006086C File Offset: 0x0005EA6C
		// (set) Token: 0x060017E2 RID: 6114 RVA: 0x0000E3B0 File Offset: 0x0000C5B0
		public unsafe List<string> activeCursors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWillClearUndoCursorHandler.NativeFieldInfoPtr_activeCursors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWillClearUndoCursorHandler.NativeFieldInfoPtr_activeCursors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x060017E3 RID: 6115 RVA: 0x0006089C File Offset: 0x0005EA9C
		// (set) Token: 0x060017E4 RID: 6116 RVA: 0x0000E3CF File Offset: 0x0000C5CF
		public unsafe bool _WillClearUndo_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWillClearUndoCursorHandler.NativeFieldInfoPtr__WillClearUndo_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWillClearUndoCursorHandler.NativeFieldInfoPtr__WillClearUndo_k__BackingField)) = value;
			}
		}

		// Token: 0x04000DCE RID: 3534
		private static readonly IntPtr NativeFieldInfoPtr_cursorManager;

		// Token: 0x04000DCF RID: 3535
		private static readonly IntPtr NativeFieldInfoPtr_activeCursors;

		// Token: 0x04000DD0 RID: 3536
		private static readonly IntPtr NativeFieldInfoPtr__WillClearUndo_k__BackingField;

		// Token: 0x04000DD1 RID: 3537
		private static readonly IntPtr NativeMethodInfoPtr_get_PushedCursors_Public_get_Int32_0;

		// Token: 0x04000DD2 RID: 3538
		private static readonly IntPtr NativeMethodInfoPtr_get_WillClearUndo_Public_get_Boolean_0;

		// Token: 0x04000DD3 RID: 3539
		private static readonly IntPtr NativeMethodInfoPtr_set_WillClearUndo_Public_set_Void_Boolean_0;

		// Token: 0x04000DD4 RID: 3540
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04000DD5 RID: 3541
		private static readonly IntPtr NativeMethodInfoPtr_SetCursor_Public_Void_0;

		// Token: 0x04000DD6 RID: 3542
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCursor_Public_Void_0;

		// Token: 0x04000DD7 RID: 3543
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000DD8 RID: 3544
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
