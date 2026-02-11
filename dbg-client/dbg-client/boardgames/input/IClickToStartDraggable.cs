using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace boardgames.input
{
	// Token: 0x02000136 RID: 310
	public class IClickToStartDraggable : Il2CppObjectBase
	{
		// Token: 0x06000E0F RID: 3599 RVA: 0x0004A2FC File Offset: 0x000484FC
		// Note: this type is marked as 'beforefieldinit'.
		static IClickToStartDraggable()
		{
			Il2CppClassPointerStore<IClickToStartDraggable>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.input", "IClickToStartDraggable");
			IClickToStartDraggable.NativeMethodInfoPtr_get_enableClickToStartDrag_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClickToStartDraggable>.NativeClassPtr, 100665341);
			IClickToStartDraggable.NativeMethodInfoPtr_get_isClickDragging_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClickToStartDraggable>.NativeClassPtr, 100665342);
			IClickToStartDraggable.NativeMethodInfoPtr_set_isClickDragging_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClickToStartDraggable>.NativeClassPtr, 100665343);
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000E10 RID: 3600 RVA: 0x0004A360 File Offset: 0x00048560
		public unsafe virtual bool enableClickToStartDrag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClickToStartDraggable.NativeMethodInfoPtr_get_enableClickToStartDrag_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000E11 RID: 3601 RVA: 0x0004A3A8 File Offset: 0x000485A8
		// (set) Token: 0x06000E12 RID: 3602 RVA: 0x0004A3F0 File Offset: 0x000485F0
		public unsafe virtual bool isClickDragging
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClickToStartDraggable.NativeMethodInfoPtr_get_isClickDragging_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClickToStartDraggable.NativeMethodInfoPtr_set_isClickDragging_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x00008CDD File Offset: 0x00006EDD
		public IClickToStartDraggable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040008A8 RID: 2216
		private static readonly IntPtr NativeMethodInfoPtr_get_enableClickToStartDrag_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040008A9 RID: 2217
		private static readonly IntPtr NativeMethodInfoPtr_get_isClickDragging_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040008AA RID: 2218
		private static readonly IntPtr NativeMethodInfoPtr_set_isClickDragging_Public_Abstract_Virtual_New_set_Void_Boolean_0;
	}
}
