using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UIElements
{
	// Token: 0x02000114 RID: 276
	public class IPointerEventInternal : Il2CppObjectBase
	{
		// Token: 0x06001520 RID: 5408 RVA: 0x00067CA8 File Offset: 0x00065EA8
		// Note: this type is marked as 'beforefieldinit'.
		static IPointerEventInternal()
		{
			Il2CppClassPointerStore<IPointerEventInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IPointerEventInternal");
			IPointerEventInternal.NativeMethodInfoPtr_get_triggeredByOS_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEventInternal>.NativeClassPtr, 100666398);
			IPointerEventInternal.NativeMethodInfoPtr_set_triggeredByOS_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEventInternal>.NativeClassPtr, 100666399);
			IPointerEventInternal.NativeMethodInfoPtr_get_recomputeTopElementUnderPointer_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEventInternal>.NativeClassPtr, 100666400);
			IPointerEventInternal.NativeMethodInfoPtr_set_recomputeTopElementUnderPointer_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEventInternal>.NativeClassPtr, 100666401);
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06001521 RID: 5409 RVA: 0x00067D20 File Offset: 0x00065F20
		// (set) Token: 0x06001522 RID: 5410 RVA: 0x00067D68 File Offset: 0x00065F68
		public unsafe virtual bool triggeredByOS
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEventInternal.NativeMethodInfoPtr_get_triggeredByOS_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEventInternal.NativeMethodInfoPtr_set_triggeredByOS_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06001523 RID: 5411 RVA: 0x00067DB4 File Offset: 0x00065FB4
		// (set) Token: 0x06001524 RID: 5412 RVA: 0x00067DFC File Offset: 0x00065FFC
		public unsafe virtual bool recomputeTopElementUnderPointer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEventInternal.NativeMethodInfoPtr_get_recomputeTopElementUnderPointer_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEventInternal.NativeMethodInfoPtr_set_recomputeTopElementUnderPointer_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001525 RID: 5413 RVA: 0x00009EDD File Offset: 0x000080DD
		public IPointerEventInternal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E68 RID: 3688
		private static readonly IntPtr NativeMethodInfoPtr_get_triggeredByOS_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000E69 RID: 3689
		private static readonly IntPtr NativeMethodInfoPtr_set_triggeredByOS_Public_Abstract_Virtual_New_set_Void_Boolean_0;

		// Token: 0x04000E6A RID: 3690
		private static readonly IntPtr NativeMethodInfoPtr_get_recomputeTopElementUnderPointer_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000E6B RID: 3691
		private static readonly IntPtr NativeMethodInfoPtr_set_recomputeTopElementUnderPointer_Public_Abstract_Virtual_New_set_Void_Boolean_0;
	}
}
