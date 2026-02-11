using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.entities
{
	// Token: 0x020000E4 RID: 228
	public class IHasAttached : Il2CppObjectBase
	{
		// Token: 0x06000A4E RID: 2638 RVA: 0x000453E4 File Offset: 0x000435E4
		// Note: this type is marked as 'beforefieldinit'.
		static IHasAttached()
		{
			Il2CppClassPointerStore<IHasAttached>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "IHasAttached");
			IHasAttached.NativeMethodInfoPtr_get_Attached_Public_Abstract_Virtual_New_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasAttached>.NativeClassPtr, 100665479);
			IHasAttached.NativeMethodInfoPtr_set_Attached_Public_Abstract_Virtual_New_set_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasAttached>.NativeClassPtr, 100665480);
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000A4F RID: 2639 RVA: 0x00045434 File Offset: 0x00043634
		// (set) Token: 0x06000A50 RID: 2640 RVA: 0x00045480 File Offset: 0x00043680
		public unsafe virtual Entity Attached
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasAttached.NativeMethodInfoPtr_get_Attached_Public_Abstract_Virtual_New_get_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasAttached.NativeMethodInfoPtr_set_Attached_Public_Abstract_Virtual_New_set_Void_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x00005CFD File Offset: 0x00003EFD
		public IHasAttached(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000705 RID: 1797
		private static readonly IntPtr NativeMethodInfoPtr_get_Attached_Public_Abstract_Virtual_New_get_Entity_0;

		// Token: 0x04000706 RID: 1798
		private static readonly IntPtr NativeMethodInfoPtr_set_Attached_Public_Abstract_Virtual_New_set_Void_Entity_0;
	}
}
