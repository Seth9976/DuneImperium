using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x020000AD RID: 173
	public sealed class SetupDragAndDropArgs : ValueType
	{
		// Token: 0x06001074 RID: 4212 RVA: 0x00056E94 File Offset: 0x00055094
		// Note: this type is marked as 'beforefieldinit'.
		static SetupDragAndDropArgs()
		{
			Il2CppClassPointerStore<SetupDragAndDropArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "SetupDragAndDropArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupDragAndDropArgs>.NativeClassPtr);
			SetupDragAndDropArgs.NativeFieldInfoPtr_draggedElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupDragAndDropArgs>.NativeClassPtr, "draggedElement");
			SetupDragAndDropArgs.NativeFieldInfoPtr_selectedIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupDragAndDropArgs>.NativeClassPtr, "selectedIds");
			SetupDragAndDropArgs.NativeFieldInfoPtr_startDragArgs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupDragAndDropArgs>.NativeClassPtr, "startDragArgs");
			SetupDragAndDropArgs.NativeMethodInfoPtr__ctor_Internal_Void_VisualElement_IEnumerable_1_Int32_StartDragArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupDragAndDropArgs>.NativeClassPtr, 100665661);
		}

		// Token: 0x06001075 RID: 4213 RVA: 0x00056F14 File Offset: 0x00055114
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 310359, RefRangeEnd = 310360, XrefRangeStart = 310356, XrefRangeEnd = 310359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetupDragAndDropArgs(VisualElement draggedElement, IEnumerable<int> selectedIds, StartDragArgs startDragArgs)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetupDragAndDropArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(draggedElement);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectedIds);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(startDragArgs));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupDragAndDropArgs.NativeMethodInfoPtr__ctor_Internal_Void_VisualElement_IEnumerable_1_Int32_StartDragArgs_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001076 RID: 4214 RVA: 0x0000840D File Offset: 0x0000660D
		public SetupDragAndDropArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001077 RID: 4215 RVA: 0x00008416 File Offset: 0x00006616
		public SetupDragAndDropArgs()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetupDragAndDropArgs>.NativeClassPtr))
		{
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06001078 RID: 4216 RVA: 0x00056F90 File Offset: 0x00055190
		// (set) Token: 0x06001079 RID: 4217 RVA: 0x00008428 File Offset: 0x00006628
		public unsafe VisualElement draggedElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupDragAndDropArgs.NativeFieldInfoPtr_draggedElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupDragAndDropArgs.NativeFieldInfoPtr_draggedElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x0600107A RID: 4218 RVA: 0x00056FC0 File Offset: 0x000551C0
		// (set) Token: 0x0600107B RID: 4219 RVA: 0x00008447 File Offset: 0x00006647
		public unsafe IEnumerable<int> selectedIds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupDragAndDropArgs.NativeFieldInfoPtr_selectedIds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupDragAndDropArgs.NativeFieldInfoPtr_selectedIds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x0600107C RID: 4220 RVA: 0x00056FF0 File Offset: 0x000551F0
		// (set) Token: 0x0600107D RID: 4221 RVA: 0x00008466 File Offset: 0x00006666
		public StartDragArgs startDragArgs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupDragAndDropArgs.NativeFieldInfoPtr_startDragArgs);
				return new StartDragArgs(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StartDragArgs>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupDragAndDropArgs.NativeFieldInfoPtr_startDragArgs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StartDragArgs>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000B63 RID: 2915
		private static readonly IntPtr NativeFieldInfoPtr_draggedElement;

		// Token: 0x04000B64 RID: 2916
		private static readonly IntPtr NativeFieldInfoPtr_selectedIds;

		// Token: 0x04000B65 RID: 2917
		private static readonly IntPtr NativeFieldInfoPtr_startDragArgs;

		// Token: 0x04000B66 RID: 2918
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_VisualElement_IEnumerable_1_Int32_StartDragArgs_0;
	}
}
