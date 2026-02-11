using System;
using dwd.core.input.compositeModule.inputDetection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.EventSystems;

namespace dwd.core.input.compositeModule.eventDispatch
{
	// Token: 0x0200009A RID: 154
	public class IEventDispatchStrategy : Il2CppObjectBase
	{
		// Token: 0x060006E0 RID: 1760 RVA: 0x00005A16 File Offset: 0x00003C16
		// Note: this type is marked as 'beforefieldinit'.
		static IEventDispatchStrategy()
		{
			Il2CppClassPointerStore<IEventDispatchStrategy>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.compositeModule.eventDispatch", "IEventDispatchStrategy");
			IEventDispatchStrategy.NativeMethodInfoPtr_DispatchEvents_Public_Abstract_Virtual_New_Boolean_InputDetector_EventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEventDispatchStrategy>.NativeClassPtr, 100664160);
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x0001D470 File Offset: 0x0001B670
		[CallerCount(0)]
		public unsafe virtual bool DispatchEvents(InputDetector inputDetector, EventSystem eventSystem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputDetector);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventSystem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEventDispatchStrategy.NativeMethodInfoPtr_DispatchEvents_Public_Abstract_Virtual_New_Boolean_InputDetector_EventSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x00005A45 File Offset: 0x00003C45
		public IEventDispatchStrategy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400043E RID: 1086
		private static readonly IntPtr NativeMethodInfoPtr_DispatchEvents_Public_Abstract_Virtual_New_Boolean_InputDetector_EventSystem_0;
	}
}
