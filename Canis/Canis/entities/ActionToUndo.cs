using System;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.entities
{
	// Token: 0x020000F1 RID: 241
	[Serializable]
	public class ActionToUndo : Object
	{
		// Token: 0x06000AB5 RID: 2741 RVA: 0x00047374 File Offset: 0x00045574
		// Note: this type is marked as 'beforefieldinit'.
		static ActionToUndo()
		{
			Il2CppClassPointerStore<ActionToUndo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "ActionToUndo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionToUndo>.NativeClassPtr);
			ActionToUndo.NativeFieldInfoPtr_UndoAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionToUndo>.NativeClassPtr, "UndoAction");
			ActionToUndo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionToUndo>.NativeClassPtr, 100665635);
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x000473CC File Offset: 0x000455CC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionToUndo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionToUndo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionToUndo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x00005E44 File Offset: 0x00004044
		public ActionToUndo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000AB8 RID: 2744 RVA: 0x00047408 File Offset: 0x00045608
		// (set) Token: 0x06000AB9 RID: 2745 RVA: 0x00005E4D File Offset: 0x0000404D
		public unsafe SerializedAction UndoAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionToUndo.NativeFieldInfoPtr_UndoAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionToUndo.NativeFieldInfoPtr_UndoAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000751 RID: 1873
		private static readonly IntPtr NativeFieldInfoPtr_UndoAction;

		// Token: 0x04000752 RID: 1874
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
