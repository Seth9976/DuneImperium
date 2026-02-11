using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x020000AC RID: 172
	public sealed class CanStartDragArgs : ValueType
	{
		// Token: 0x0600106A RID: 4202 RVA: 0x00056D1C File Offset: 0x00054F1C
		// Note: this type is marked as 'beforefieldinit'.
		static CanStartDragArgs()
		{
			Il2CppClassPointerStore<CanStartDragArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "CanStartDragArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanStartDragArgs>.NativeClassPtr);
			CanStartDragArgs.NativeFieldInfoPtr_draggedElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanStartDragArgs>.NativeClassPtr, "draggedElement");
			CanStartDragArgs.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanStartDragArgs>.NativeClassPtr, "id");
			CanStartDragArgs.NativeFieldInfoPtr_selectedIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanStartDragArgs>.NativeClassPtr, "selectedIds");
			CanStartDragArgs.NativeMethodInfoPtr__ctor_Internal_Void_VisualElement_Int32_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanStartDragArgs>.NativeClassPtr, 100665660);
		}

		// Token: 0x0600106B RID: 4203 RVA: 0x00056D9C File Offset: 0x00054F9C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 310353, RefRangeEnd = 310356, XrefRangeStart = 310337, XrefRangeEnd = 310353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CanStartDragArgs(VisualElement draggedElement, int id, IEnumerable<int> selectedIds)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanStartDragArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(draggedElement);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectedIds);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanStartDragArgs.NativeMethodInfoPtr__ctor_Internal_Void_VisualElement_Int32_IEnumerable_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600106C RID: 4204 RVA: 0x00008399 File Offset: 0x00006599
		public CanStartDragArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600106D RID: 4205 RVA: 0x000083A2 File Offset: 0x000065A2
		public CanStartDragArgs()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanStartDragArgs>.NativeClassPtr))
		{
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x0600106E RID: 4206 RVA: 0x00056E0C File Offset: 0x0005500C
		// (set) Token: 0x0600106F RID: 4207 RVA: 0x000083B4 File Offset: 0x000065B4
		public unsafe VisualElement draggedElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanStartDragArgs.NativeFieldInfoPtr_draggedElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanStartDragArgs.NativeFieldInfoPtr_draggedElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06001070 RID: 4208 RVA: 0x00056E3C File Offset: 0x0005503C
		// (set) Token: 0x06001071 RID: 4209 RVA: 0x000083D3 File Offset: 0x000065D3
		public unsafe int id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanStartDragArgs.NativeFieldInfoPtr_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanStartDragArgs.NativeFieldInfoPtr_id)) = value;
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06001072 RID: 4210 RVA: 0x00056E64 File Offset: 0x00055064
		// (set) Token: 0x06001073 RID: 4211 RVA: 0x000083EE File Offset: 0x000065EE
		public unsafe IEnumerable<int> selectedIds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanStartDragArgs.NativeFieldInfoPtr_selectedIds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanStartDragArgs.NativeFieldInfoPtr_selectedIds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B5F RID: 2911
		private static readonly IntPtr NativeFieldInfoPtr_draggedElement;

		// Token: 0x04000B60 RID: 2912
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04000B61 RID: 2913
		private static readonly IntPtr NativeFieldInfoPtr_selectedIds;

		// Token: 0x04000B62 RID: 2914
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_VisualElement_Int32_IEnumerable_1_Int32_0;
	}
}
