using System;
using boardgames.match.selection;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using worm.match.components;

namespace worm.match.dataRenderers
{
	// Token: 0x02000178 RID: 376
	public class WormWillClearUndoCustomChoiceRenderer : VersionedView<DBGSelectionResponder>
	{
		// Token: 0x060010E2 RID: 4322 RVA: 0x0004AC14 File Offset: 0x00048E14
		// Note: this type is marked as 'beforefieldinit'.
		static WormWillClearUndoCustomChoiceRenderer()
		{
			Il2CppClassPointerStore<WormWillClearUndoCustomChoiceRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormWillClearUndoCustomChoiceRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormWillClearUndoCustomChoiceRenderer>.NativeClassPtr);
			WormWillClearUndoCustomChoiceRenderer.NativeFieldInfoPtr_cursorHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormWillClearUndoCustomChoiceRenderer>.NativeClassPtr, "cursorHandler");
			WormWillClearUndoCustomChoiceRenderer.NativeFieldInfoPtr_choiceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormWillClearUndoCustomChoiceRenderer>.NativeClassPtr, "choiceIndex");
			WormWillClearUndoCustomChoiceRenderer.NativeMethodInfoPtr_SetChoiceIndex_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWillClearUndoCustomChoiceRenderer>.NativeClassPtr, 100665638);
			WormWillClearUndoCustomChoiceRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWillClearUndoCustomChoiceRenderer>.NativeClassPtr, 100665639);
			WormWillClearUndoCustomChoiceRenderer.NativeMethodInfoPtr_NodeWillClearUndo_Private_Boolean_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWillClearUndoCustomChoiceRenderer>.NativeClassPtr, 100665640);
			WormWillClearUndoCustomChoiceRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWillClearUndoCustomChoiceRenderer>.NativeClassPtr, 100665641);
		}

		// Token: 0x060010E3 RID: 4323 RVA: 0x0004ACBC File Offset: 0x00048EBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 710536, RefRangeEnd = 710538, XrefRangeStart = 710529, XrefRangeEnd = 710536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetChoiceIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormWillClearUndoCustomChoiceRenderer.NativeMethodInfoPtr_SetChoiceIndex_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010E4 RID: 4324 RVA: 0x0004ACFC File Offset: 0x00048EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710538, XrefRangeEnd = 710565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormWillClearUndoCustomChoiceRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010E5 RID: 4325 RVA: 0x0004AD38 File Offset: 0x00048F38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710565, XrefRangeEnd = 710588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool NodeWillClearUndo(ISelectionNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormWillClearUndoCustomChoiceRenderer.NativeMethodInfoPtr_NodeWillClearUndo_Private_Boolean_ISelectionNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010E6 RID: 4326 RVA: 0x0004AD88 File Offset: 0x00048F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710588, XrefRangeEnd = 710591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormWillClearUndoCustomChoiceRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormWillClearUndoCustomChoiceRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormWillClearUndoCustomChoiceRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010E7 RID: 4327 RVA: 0x0000AE23 File Offset: 0x00009023
		public WormWillClearUndoCustomChoiceRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x060010E8 RID: 4328 RVA: 0x0004ADC4 File Offset: 0x00048FC4
		// (set) Token: 0x060010E9 RID: 4329 RVA: 0x0000AE2C File Offset: 0x0000902C
		public unsafe WormWillClearUndoCursorHandler cursorHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWillClearUndoCustomChoiceRenderer.NativeFieldInfoPtr_cursorHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormWillClearUndoCursorHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWillClearUndoCustomChoiceRenderer.NativeFieldInfoPtr_cursorHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x060010EA RID: 4330 RVA: 0x0004ADF4 File Offset: 0x00048FF4
		// (set) Token: 0x060010EB RID: 4331 RVA: 0x0000AE4B File Offset: 0x0000904B
		public unsafe int choiceIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWillClearUndoCustomChoiceRenderer.NativeFieldInfoPtr_choiceIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWillClearUndoCustomChoiceRenderer.NativeFieldInfoPtr_choiceIndex)) = value;
			}
		}

		// Token: 0x040009B7 RID: 2487
		private static readonly IntPtr NativeFieldInfoPtr_cursorHandler;

		// Token: 0x040009B8 RID: 2488
		private static readonly IntPtr NativeFieldInfoPtr_choiceIndex;

		// Token: 0x040009B9 RID: 2489
		private static readonly IntPtr NativeMethodInfoPtr_SetChoiceIndex_Public_Void_Int32_0;

		// Token: 0x040009BA RID: 2490
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040009BB RID: 2491
		private static readonly IntPtr NativeMethodInfoPtr_NodeWillClearUndo_Private_Boolean_ISelectionNode_0;

		// Token: 0x040009BC RID: 2492
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
