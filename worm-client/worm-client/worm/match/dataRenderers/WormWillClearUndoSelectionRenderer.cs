using System;
using boardgames.match.selection;
using Canis.utils.ids;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using lotus;
using worm.match.components;

namespace worm.match.dataRenderers
{
	// Token: 0x0200017A RID: 378
	public class WormWillClearUndoSelectionRenderer : VersionedView<DBGSelectionResponder>
	{
		// Token: 0x060010F5 RID: 4341 RVA: 0x0004B03C File Offset: 0x0004923C
		// Note: this type is marked as 'beforefieldinit'.
		static WormWillClearUndoSelectionRenderer()
		{
			Il2CppClassPointerStore<WormWillClearUndoSelectionRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormWillClearUndoSelectionRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormWillClearUndoSelectionRenderer>.NativeClassPtr);
			WormWillClearUndoSelectionRenderer.NativeFieldInfoPtr_entityView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormWillClearUndoSelectionRenderer>.NativeClassPtr, "entityView");
			WormWillClearUndoSelectionRenderer.NativeFieldInfoPtr_cursorHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormWillClearUndoSelectionRenderer>.NativeClassPtr, "cursorHandler");
			WormWillClearUndoSelectionRenderer.NativeMethodInfoPtr_get_View_Protected_get_EntityView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWillClearUndoSelectionRenderer>.NativeClassPtr, 100665653);
			WormWillClearUndoSelectionRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWillClearUndoSelectionRenderer>.NativeClassPtr, 100665654);
			WormWillClearUndoSelectionRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWillClearUndoSelectionRenderer>.NativeClassPtr, 100665655);
			WormWillClearUndoSelectionRenderer.NativeMethodInfoPtr_WillClearUndo_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWillClearUndoSelectionRenderer>.NativeClassPtr, 100665656);
			WormWillClearUndoSelectionRenderer.NativeMethodInfoPtr_NodeWillClearUndo_Private_Boolean_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWillClearUndoSelectionRenderer>.NativeClassPtr, 100665657);
			WormWillClearUndoSelectionRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWillClearUndoSelectionRenderer>.NativeClassPtr, 100665658);
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x060010F6 RID: 4342 RVA: 0x0004B10C File Offset: 0x0004930C
		public unsafe EntityView View
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormWillClearUndoSelectionRenderer.NativeMethodInfoPtr_get_View_Protected_get_EntityView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr3) : null;
			}
		}

		// Token: 0x060010F7 RID: 4343 RVA: 0x0004B14C File Offset: 0x0004934C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710636, XrefRangeEnd = 710646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormWillClearUndoSelectionRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010F8 RID: 4344 RVA: 0x0004B188 File Offset: 0x00049388
		[CallerCount(0)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormWillClearUndoSelectionRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010F9 RID: 4345 RVA: 0x0004B1C4 File Offset: 0x000493C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710646, XrefRangeEnd = 710659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool WillClearUndo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormWillClearUndoSelectionRenderer.NativeMethodInfoPtr_WillClearUndo_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x0004B20C File Offset: 0x0004940C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 710687, RefRangeEnd = 710689, XrefRangeStart = 710659, XrefRangeEnd = 710687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool NodeWillClearUndo(ISelectionNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormWillClearUndoSelectionRenderer.NativeMethodInfoPtr_NodeWillClearUndo_Private_Boolean_ISelectionNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010FB RID: 4347 RVA: 0x0004B25C File Offset: 0x0004945C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormWillClearUndoSelectionRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormWillClearUndoSelectionRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormWillClearUndoSelectionRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010FC RID: 4348 RVA: 0x0000AE8E File Offset: 0x0000908E
		public WormWillClearUndoSelectionRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x060010FD RID: 4349 RVA: 0x0004B298 File Offset: 0x00049498
		// (set) Token: 0x060010FE RID: 4350 RVA: 0x0000AE97 File Offset: 0x00009097
		public unsafe EntityView entityView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWillClearUndoSelectionRenderer.NativeFieldInfoPtr_entityView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWillClearUndoSelectionRenderer.NativeFieldInfoPtr_entityView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x060010FF RID: 4351 RVA: 0x0004B2C8 File Offset: 0x000494C8
		// (set) Token: 0x06001100 RID: 4352 RVA: 0x0000AEB6 File Offset: 0x000090B6
		public unsafe WormWillClearUndoCursorHandler cursorHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWillClearUndoSelectionRenderer.NativeFieldInfoPtr_cursorHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormWillClearUndoCursorHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWillClearUndoSelectionRenderer.NativeFieldInfoPtr_cursorHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009C3 RID: 2499
		private static readonly IntPtr NativeFieldInfoPtr_entityView;

		// Token: 0x040009C4 RID: 2500
		private static readonly IntPtr NativeFieldInfoPtr_cursorHandler;

		// Token: 0x040009C5 RID: 2501
		private static readonly IntPtr NativeMethodInfoPtr_get_View_Protected_get_EntityView_0;

		// Token: 0x040009C6 RID: 2502
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040009C7 RID: 2503
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040009C8 RID: 2504
		private static readonly IntPtr NativeMethodInfoPtr_WillClearUndo_Protected_Virtual_New_Boolean_0;

		// Token: 0x040009C9 RID: 2505
		private static readonly IntPtr NativeMethodInfoPtr_NodeWillClearUndo_Private_Boolean_ISelectionNode_0;

		// Token: 0x040009CA RID: 2506
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003BA RID: 954
		[ObfuscatedName("worm.match.dataRenderers.WormWillClearUndoSelectionRenderer+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x06002688 RID: 9864 RVA: 0x0008D184 File Offset: 0x0008B384
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<WormWillClearUndoSelectionRenderer.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormWillClearUndoSelectionRenderer>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormWillClearUndoSelectionRenderer.__c__DisplayClass6_0>.NativeClassPtr);
				WormWillClearUndoSelectionRenderer.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormWillClearUndoSelectionRenderer.__c__DisplayClass6_0>.NativeClassPtr, "<>4__this");
				WormWillClearUndoSelectionRenderer.__c__DisplayClass6_0.NativeFieldInfoPtr_targetsNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormWillClearUndoSelectionRenderer.__c__DisplayClass6_0>.NativeClassPtr, "targetsNode");
				WormWillClearUndoSelectionRenderer.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWillClearUndoSelectionRenderer.__c__DisplayClass6_0>.NativeClassPtr, 100665659);
				WormWillClearUndoSelectionRenderer.__c__DisplayClass6_0.NativeMethodInfoPtr__WillClearUndo_b__0_Internal_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWillClearUndoSelectionRenderer.__c__DisplayClass6_0>.NativeClassPtr, 100665660);
			}

			// Token: 0x06002689 RID: 9865 RVA: 0x0008D200 File Offset: 0x0008B400
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormWillClearUndoSelectionRenderer.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormWillClearUndoSelectionRenderer.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600268A RID: 9866 RVA: 0x0008D23C File Offset: 0x0008B43C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710633, XrefRangeEnd = 710636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _WillClearUndo_b__0(EntityID s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormWillClearUndoSelectionRenderer.__c__DisplayClass6_0.NativeMethodInfoPtr__WillClearUndo_b__0_Internal_Boolean_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600268B RID: 9867 RVA: 0x00015463 File Offset: 0x00013663
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AB4 RID: 2740
			// (get) Token: 0x0600268C RID: 9868 RVA: 0x0008D28C File Offset: 0x0008B48C
			// (set) Token: 0x0600268D RID: 9869 RVA: 0x0001546C File Offset: 0x0001366C
			public unsafe WormWillClearUndoSelectionRenderer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWillClearUndoSelectionRenderer.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormWillClearUndoSelectionRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWillClearUndoSelectionRenderer.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AB5 RID: 2741
			// (get) Token: 0x0600268E RID: 9870 RVA: 0x0008D2BC File Offset: 0x0008B4BC
			// (set) Token: 0x0600268F RID: 9871 RVA: 0x0001548B File Offset: 0x0001368B
			public unsafe SelectionWithTargetsNode targetsNode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWillClearUndoSelectionRenderer.__c__DisplayClass6_0.NativeFieldInfoPtr_targetsNode);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectionWithTargetsNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWillClearUndoSelectionRenderer.__c__DisplayClass6_0.NativeFieldInfoPtr_targetsNode), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001631 RID: 5681
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001632 RID: 5682
			private static readonly IntPtr NativeFieldInfoPtr_targetsNode;

			// Token: 0x04001633 RID: 5683
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001634 RID: 5684
			private static readonly IntPtr NativeMethodInfoPtr__WillClearUndo_b__0_Internal_Boolean_EntityID_0;
		}
	}
}
