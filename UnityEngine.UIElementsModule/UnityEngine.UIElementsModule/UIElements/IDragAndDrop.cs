using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x020000A5 RID: 165
	public class IDragAndDrop : Il2CppObjectBase
	{
		// Token: 0x06001031 RID: 4145 RVA: 0x00055E5C File Offset: 0x0005405C
		// Note: this type is marked as 'beforefieldinit'.
		static IDragAndDrop()
		{
			Il2CppClassPointerStore<IDragAndDrop>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IDragAndDrop");
			IDragAndDrop.NativeMethodInfoPtr_StartDrag_Public_Abstract_Virtual_New_Void_StartDragArgs_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDragAndDrop>.NativeClassPtr, 100665628);
			IDragAndDrop.NativeMethodInfoPtr_UpdateDrag_Public_Abstract_Virtual_New_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDragAndDrop>.NativeClassPtr, 100665629);
			IDragAndDrop.NativeMethodInfoPtr_AcceptDrag_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDragAndDrop>.NativeClassPtr, 100665630);
			IDragAndDrop.NativeMethodInfoPtr_DragCleanup_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDragAndDrop>.NativeClassPtr, 100665631);
			IDragAndDrop.NativeMethodInfoPtr_SetVisualMode_Public_Abstract_Virtual_New_Void_DragVisualMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDragAndDrop>.NativeClassPtr, 100665632);
			IDragAndDrop.NativeMethodInfoPtr_get_data_Public_Abstract_Virtual_New_get_DragAndDropData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDragAndDrop>.NativeClassPtr, 100665633);
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x00055EFC File Offset: 0x000540FC
		[CallerCount(0)]
		public unsafe virtual void StartDrag(StartDragArgs args, Vector3 pointerPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDragAndDrop.NativeMethodInfoPtr_StartDrag_Public_Abstract_Virtual_New_Void_StartDragArgs_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001033 RID: 4147 RVA: 0x00055F5C File Offset: 0x0005415C
		[CallerCount(0)]
		public unsafe virtual void UpdateDrag(Vector3 pointerPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerPosition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDragAndDrop.NativeMethodInfoPtr_UpdateDrag_Public_Abstract_Virtual_New_Void_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001034 RID: 4148 RVA: 0x00055FA8 File Offset: 0x000541A8
		[CallerCount(0)]
		public unsafe virtual void AcceptDrag()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDragAndDrop.NativeMethodInfoPtr_AcceptDrag_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x00055FE4 File Offset: 0x000541E4
		[CallerCount(0)]
		public unsafe virtual void DragCleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDragAndDrop.NativeMethodInfoPtr_DragCleanup_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001036 RID: 4150 RVA: 0x00056020 File Offset: 0x00054220
		[CallerCount(0)]
		public unsafe virtual void SetVisualMode(DragVisualMode visualMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref visualMode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDragAndDrop.NativeMethodInfoPtr_SetVisualMode_Public_Abstract_Virtual_New_Void_DragVisualMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06001037 RID: 4151 RVA: 0x0005606C File Offset: 0x0005426C
		public unsafe virtual DragAndDropData data
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDragAndDrop.NativeMethodInfoPtr_get_data_Public_Abstract_Virtual_New_get_DragAndDropData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DragAndDropData>(intPtr3) : null;
			}
		}

		// Token: 0x06001038 RID: 4152 RVA: 0x0000829B File Offset: 0x0000649B
		public IDragAndDrop(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B2F RID: 2863
		private static readonly IntPtr NativeMethodInfoPtr_StartDrag_Public_Abstract_Virtual_New_Void_StartDragArgs_Vector3_0;

		// Token: 0x04000B30 RID: 2864
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDrag_Public_Abstract_Virtual_New_Void_Vector3_0;

		// Token: 0x04000B31 RID: 2865
		private static readonly IntPtr NativeMethodInfoPtr_AcceptDrag_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000B32 RID: 2866
		private static readonly IntPtr NativeMethodInfoPtr_DragCleanup_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000B33 RID: 2867
		private static readonly IntPtr NativeMethodInfoPtr_SetVisualMode_Public_Abstract_Virtual_New_Void_DragVisualMode_0;

		// Token: 0x04000B34 RID: 2868
		private static readonly IntPtr NativeMethodInfoPtr_get_data_Public_Abstract_Virtual_New_get_DragAndDropData_0;
	}
}
