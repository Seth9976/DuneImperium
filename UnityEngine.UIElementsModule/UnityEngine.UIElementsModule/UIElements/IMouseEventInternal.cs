using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x020000F4 RID: 244
	public class IMouseEventInternal : Il2CppObjectBase
	{
		// Token: 0x060013D7 RID: 5079 RVA: 0x00062E9C File Offset: 0x0006109C
		// Note: this type is marked as 'beforefieldinit'.
		static IMouseEventInternal()
		{
			Il2CppClassPointerStore<IMouseEventInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IMouseEventInternal");
			IMouseEventInternal.NativeMethodInfoPtr_get_triggeredByOS_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMouseEventInternal>.NativeClassPtr, 100666135);
			IMouseEventInternal.NativeMethodInfoPtr_set_triggeredByOS_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMouseEventInternal>.NativeClassPtr, 100666136);
			IMouseEventInternal.NativeMethodInfoPtr_get_recomputeTopElementUnderMouse_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMouseEventInternal>.NativeClassPtr, 100666137);
			IMouseEventInternal.NativeMethodInfoPtr_set_recomputeTopElementUnderMouse_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMouseEventInternal>.NativeClassPtr, 100666138);
			IMouseEventInternal.NativeMethodInfoPtr_get_sourcePointerEvent_Public_Abstract_Virtual_New_get_IPointerEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMouseEventInternal>.NativeClassPtr, 100666139);
			IMouseEventInternal.NativeMethodInfoPtr_set_sourcePointerEvent_Public_Abstract_Virtual_New_set_Void_IPointerEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMouseEventInternal>.NativeClassPtr, 100666140);
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x060013D8 RID: 5080 RVA: 0x00062F3C File Offset: 0x0006113C
		// (set) Token: 0x060013D9 RID: 5081 RVA: 0x00062F84 File Offset: 0x00061184
		public unsafe virtual bool triggeredByOS
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMouseEventInternal.NativeMethodInfoPtr_get_triggeredByOS_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMouseEventInternal.NativeMethodInfoPtr_set_triggeredByOS_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x060013DA RID: 5082 RVA: 0x00062FD0 File Offset: 0x000611D0
		// (set) Token: 0x060013DB RID: 5083 RVA: 0x00063018 File Offset: 0x00061218
		public unsafe virtual bool recomputeTopElementUnderMouse
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMouseEventInternal.NativeMethodInfoPtr_get_recomputeTopElementUnderMouse_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMouseEventInternal.NativeMethodInfoPtr_set_recomputeTopElementUnderMouse_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x060013DC RID: 5084 RVA: 0x00063064 File Offset: 0x00061264
		// (set) Token: 0x060013DD RID: 5085 RVA: 0x000630B0 File Offset: 0x000612B0
		public unsafe virtual IPointerEvent sourcePointerEvent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMouseEventInternal.NativeMethodInfoPtr_get_sourcePointerEvent_Public_Abstract_Virtual_New_get_IPointerEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPointerEvent>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMouseEventInternal.NativeMethodInfoPtr_set_sourcePointerEvent_Public_Abstract_Virtual_New_set_Void_IPointerEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060013DE RID: 5086 RVA: 0x0000993A File Offset: 0x00007B3A
		public IMouseEventInternal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D88 RID: 3464
		private static readonly IntPtr NativeMethodInfoPtr_get_triggeredByOS_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000D89 RID: 3465
		private static readonly IntPtr NativeMethodInfoPtr_set_triggeredByOS_Public_Abstract_Virtual_New_set_Void_Boolean_0;

		// Token: 0x04000D8A RID: 3466
		private static readonly IntPtr NativeMethodInfoPtr_get_recomputeTopElementUnderMouse_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000D8B RID: 3467
		private static readonly IntPtr NativeMethodInfoPtr_set_recomputeTopElementUnderMouse_Public_Abstract_Virtual_New_set_Void_Boolean_0;

		// Token: 0x04000D8C RID: 3468
		private static readonly IntPtr NativeMethodInfoPtr_get_sourcePointerEvent_Public_Abstract_Virtual_New_get_IPointerEvent_0;

		// Token: 0x04000D8D RID: 3469
		private static readonly IntPtr NativeMethodInfoPtr_set_sourcePointerEvent_Public_Abstract_Virtual_New_set_Void_IPointerEvent_0;
	}
}
