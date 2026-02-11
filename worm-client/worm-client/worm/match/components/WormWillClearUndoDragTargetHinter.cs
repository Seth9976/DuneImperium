using System;
using boardgames.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.match.components
{
	// Token: 0x02000221 RID: 545
	public class WormWillClearUndoDragTargetHinter : WormWillClearUndoHinter
	{
		// Token: 0x060017E5 RID: 6117 RVA: 0x000608C4 File Offset: 0x0005EAC4
		// Note: this type is marked as 'beforefieldinit'.
		static WormWillClearUndoDragTargetHinter()
		{
			Il2CppClassPointerStore<WormWillClearUndoDragTargetHinter>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormWillClearUndoDragTargetHinter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormWillClearUndoDragTargetHinter>.NativeClassPtr);
			WormWillClearUndoDragTargetHinter.NativeFieldInfoPtr_selectionResponder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormWillClearUndoDragTargetHinter>.NativeClassPtr, "selectionResponder");
			WormWillClearUndoDragTargetHinter.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWillClearUndoDragTargetHinter>.NativeClassPtr, 100666612);
			WormWillClearUndoDragTargetHinter.NativeMethodInfoPtr_SetCursor_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWillClearUndoDragTargetHinter>.NativeClassPtr, 100666613);
			WormWillClearUndoDragTargetHinter.NativeMethodInfoPtr_WillClearUndo_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWillClearUndoDragTargetHinter>.NativeClassPtr, 100666614);
			WormWillClearUndoDragTargetHinter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWillClearUndoDragTargetHinter>.NativeClassPtr, 100666615);
		}

		// Token: 0x060017E6 RID: 6118 RVA: 0x00060958 File Offset: 0x0005EB58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717821, XrefRangeEnd = 717829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormWillClearUndoDragTargetHinter.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017E7 RID: 6119 RVA: 0x00060994 File Offset: 0x0005EB94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717829, XrefRangeEnd = 717832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetCursor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormWillClearUndoDragTargetHinter.NativeMethodInfoPtr_SetCursor_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017E8 RID: 6120 RVA: 0x000609D0 File Offset: 0x0005EBD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 717860, RefRangeEnd = 717861, XrefRangeStart = 717832, XrefRangeEnd = 717860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WillClearUndo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormWillClearUndoDragTargetHinter.NativeMethodInfoPtr_WillClearUndo_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017E9 RID: 6121 RVA: 0x00060A0C File Offset: 0x0005EC0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717861, XrefRangeEnd = 717865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormWillClearUndoDragTargetHinter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormWillClearUndoDragTargetHinter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormWillClearUndoDragTargetHinter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017EA RID: 6122 RVA: 0x0000E3EA File Offset: 0x0000C5EA
		public WormWillClearUndoDragTargetHinter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x060017EB RID: 6123 RVA: 0x00060A48 File Offset: 0x0005EC48
		// (set) Token: 0x060017EC RID: 6124 RVA: 0x0000E3F3 File Offset: 0x0000C5F3
		public unsafe DBGSelectionResponder selectionResponder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWillClearUndoDragTargetHinter.NativeFieldInfoPtr_selectionResponder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGSelectionResponder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWillClearUndoDragTargetHinter.NativeFieldInfoPtr_selectionResponder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000DD9 RID: 3545
		private static readonly IntPtr NativeFieldInfoPtr_selectionResponder;

		// Token: 0x04000DDA RID: 3546
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000DDB RID: 3547
		private static readonly IntPtr NativeMethodInfoPtr_SetCursor_Protected_Virtual_Void_0;

		// Token: 0x04000DDC RID: 3548
		private static readonly IntPtr NativeMethodInfoPtr_WillClearUndo_Private_Boolean_0;

		// Token: 0x04000DDD RID: 3549
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
