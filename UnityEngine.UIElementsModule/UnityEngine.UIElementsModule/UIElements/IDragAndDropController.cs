using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x020000AA RID: 170
	public class IDragAndDropController<TArgs> : Il2CppObjectBase
	{
		// Token: 0x06001061 RID: 4193 RVA: 0x00056978 File Offset: 0x00054B78
		// Note: this type is marked as 'beforefieldinit'.
		static IDragAndDropController()
		{
			Il2CppClassPointerStore<IDragAndDropController<TArgs>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IDragAndDropController`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArgs>.NativeClassPtr)) })).TypeHandle.value);
			IDragAndDropController<TArgs>.NativeMethodInfoPtr_CanStartDrag_Public_Abstract_Virtual_New_Boolean_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDragAndDropController<TArgs>>.NativeClassPtr, 100665653);
			IDragAndDropController<TArgs>.NativeMethodInfoPtr_SetupDragAndDrop_Public_Abstract_Virtual_New_StartDragArgs_IEnumerable_1_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDragAndDropController<TArgs>>.NativeClassPtr, 100665654);
			IDragAndDropController<TArgs>.NativeMethodInfoPtr_HandleDragAndDrop_Public_Abstract_Virtual_New_DragVisualMode_TArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDragAndDropController<TArgs>>.NativeClassPtr, 100665655);
			IDragAndDropController<TArgs>.NativeMethodInfoPtr_OnDrop_Public_Abstract_Virtual_New_Void_TArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDragAndDropController<TArgs>>.NativeClassPtr, 100665656);
			IDragAndDropController<TArgs>.NativeMethodInfoPtr_DragCleanup_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDragAndDropController<TArgs>>.NativeClassPtr, 100665657);
			IDragAndDropController<TArgs>.NativeMethodInfoPtr_HandleAutoExpand_Public_Virtual_New_Void_ReusableCollectionItem_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDragAndDropController<TArgs>>.NativeClassPtr, 100665658);
			IDragAndDropController<TArgs>.NativeMethodInfoPtr_GetSortedSelectedIds_Public_Virtual_New_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDragAndDropController<TArgs>>.NativeClassPtr, 100665659);
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x00056A68 File Offset: 0x00054C68
		[CallerCount(0)]
		public unsafe virtual bool CanStartDrag(IEnumerable<int> itemIds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemIds);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDragAndDropController<TArgs>.NativeMethodInfoPtr_CanStartDrag_Public_Abstract_Virtual_New_Boolean_IEnumerable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x00056AC0 File Offset: 0x00054CC0
		[CallerCount(0)]
		public unsafe virtual StartDragArgs SetupDragAndDrop(IEnumerable<int> itemIds, bool skipText = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemIds);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipText;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDragAndDropController<TArgs>.NativeMethodInfoPtr_SetupDragAndDrop_Public_Abstract_Virtual_New_StartDragArgs_IEnumerable_1_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new StartDragArgs(intPtr);
		}

		// Token: 0x06001064 RID: 4196 RVA: 0x00056B24 File Offset: 0x00054D24
		[CallerCount(0)]
		public unsafe virtual DragVisualMode HandleDragAndDrop(TArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TArgs).IsValueType)
				{
					TArgs targs = args;
					intPtr = ((targs is string) ? IL2CPP.ManagedStringToIl2Cpp(targs as string) : IL2CPP.Il2CppObjectBaseToPtr(targs as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref args;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDragAndDropController<TArgs>.NativeMethodInfoPtr_HandleDragAndDrop_Public_Abstract_Virtual_New_DragVisualMode_TArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x00056BB4 File Offset: 0x00054DB4
		[CallerCount(0)]
		public unsafe virtual void OnDrop(TArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TArgs).IsValueType)
				{
					TArgs targs = args;
					intPtr = ((targs is string) ? IL2CPP.ManagedStringToIl2Cpp(targs as string) : IL2CPP.Il2CppObjectBaseToPtr(targs as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref args;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDragAndDropController<TArgs>.NativeMethodInfoPtr_OnDrop_Public_Abstract_Virtual_New_Void_TArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06001066 RID: 4198 RVA: 0x00056C38 File Offset: 0x00054E38
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DragCleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDragAndDropController<TArgs>.NativeMethodInfoPtr_DragCleanup_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001067 RID: 4199 RVA: 0x00056C74 File Offset: 0x00054E74
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HandleAutoExpand(ReusableCollectionItem item, Vector2 pointerPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDragAndDropController<TArgs>.NativeMethodInfoPtr_HandleAutoExpand_Public_Virtual_New_Void_ReusableCollectionItem_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001068 RID: 4200 RVA: 0x00056CD0 File Offset: 0x00054ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310318, XrefRangeEnd = 310337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<int> GetSortedSelectedIds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDragAndDropController<TArgs>.NativeMethodInfoPtr_GetSortedSelectedIds_Public_Virtual_New_IEnumerable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x00008390 File Offset: 0x00006590
		public IDragAndDropController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B53 RID: 2899
		private static readonly IntPtr NativeMethodInfoPtr_CanStartDrag_Public_Abstract_Virtual_New_Boolean_IEnumerable_1_Int32_0;

		// Token: 0x04000B54 RID: 2900
		private static readonly IntPtr NativeMethodInfoPtr_SetupDragAndDrop_Public_Abstract_Virtual_New_StartDragArgs_IEnumerable_1_Int32_Boolean_0;

		// Token: 0x04000B55 RID: 2901
		private static readonly IntPtr NativeMethodInfoPtr_HandleDragAndDrop_Public_Abstract_Virtual_New_DragVisualMode_TArgs_0;

		// Token: 0x04000B56 RID: 2902
		private static readonly IntPtr NativeMethodInfoPtr_OnDrop_Public_Abstract_Virtual_New_Void_TArgs_0;

		// Token: 0x04000B57 RID: 2903
		private static readonly IntPtr NativeMethodInfoPtr_DragCleanup_Public_Virtual_New_Void_0;

		// Token: 0x04000B58 RID: 2904
		private static readonly IntPtr NativeMethodInfoPtr_HandleAutoExpand_Public_Virtual_New_Void_ReusableCollectionItem_Vector2_0;

		// Token: 0x04000B59 RID: 2905
		private static readonly IntPtr NativeMethodInfoPtr_GetSortedSelectedIds_Public_Virtual_New_IEnumerable_1_Int32_0;
	}
}
