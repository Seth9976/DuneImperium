using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UIElements
{
	// Token: 0x020000B0 RID: 176
	public class IReorderable : Il2CppObjectBase
	{
		// Token: 0x060010A1 RID: 4257 RVA: 0x0005756C File Offset: 0x0005576C
		// Note: this type is marked as 'beforefieldinit'.
		static IReorderable()
		{
			Il2CppClassPointerStore<IReorderable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IReorderable");
			IReorderable.NativeMethodInfoPtr_get_enableReordering_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IReorderable>.NativeClassPtr, 100665671);
			IReorderable.NativeMethodInfoPtr_set_enableReordering_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IReorderable>.NativeClassPtr, 100665672);
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x060010A2 RID: 4258 RVA: 0x000575BC File Offset: 0x000557BC
		// (set) Token: 0x060010A3 RID: 4259 RVA: 0x00057604 File Offset: 0x00055804
		public unsafe virtual bool enableReordering
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IReorderable.NativeMethodInfoPtr_get_enableReordering_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IReorderable.NativeMethodInfoPtr_set_enableReordering_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060010A4 RID: 4260 RVA: 0x000085EC File Offset: 0x000067EC
		public IReorderable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B76 RID: 2934
		private static readonly IntPtr NativeMethodInfoPtr_get_enableReordering_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000B77 RID: 2935
		private static readonly IntPtr NativeMethodInfoPtr_set_enableReordering_Public_Abstract_Virtual_New_set_Void_Boolean_0;
	}
}
