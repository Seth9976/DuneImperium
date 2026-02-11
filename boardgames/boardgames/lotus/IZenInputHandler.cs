using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace lotus
{
	// Token: 0x020000C0 RID: 192
	public class IZenInputHandler : Il2CppObjectBase
	{
		// Token: 0x060009AD RID: 2477 RVA: 0x0002FFC8 File Offset: 0x0002E1C8
		// Note: this type is marked as 'beforefieldinit'.
		static IZenInputHandler()
		{
			Il2CppClassPointerStore<IZenInputHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus", "IZenInputHandler");
			IZenInputHandler.NativeMethodInfoPtr_get_Priority_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IZenInputHandler>.NativeClassPtr, 100664879);
			IZenInputHandler.NativeMethodInfoPtr_HandleUp_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IZenInputHandler>.NativeClassPtr, 100664880);
			IZenInputHandler.NativeMethodInfoPtr_HandlePress_Public_Abstract_Virtual_New_Boolean_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IZenInputHandler>.NativeClassPtr, 100664881);
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x060009AE RID: 2478 RVA: 0x0003002C File Offset: 0x0002E22C
		public unsafe virtual int Priority
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IZenInputHandler.NativeMethodInfoPtr_get_Priority_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x00030074 File Offset: 0x0002E274
		[CallerCount(0)]
		public unsafe virtual void HandleUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IZenInputHandler.NativeMethodInfoPtr_HandleUp_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x000300B0 File Offset: 0x0002E2B0
		[CallerCount(0)]
		public unsafe virtual bool HandlePress(UnitView view)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(view);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IZenInputHandler.NativeMethodInfoPtr_HandlePress_Public_Abstract_Virtual_New_Boolean_UnitView_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x0000663F File Offset: 0x0000483F
		public IZenInputHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040005F9 RID: 1529
		private static readonly IntPtr NativeMethodInfoPtr_get_Priority_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x040005FA RID: 1530
		private static readonly IntPtr NativeMethodInfoPtr_HandleUp_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040005FB RID: 1531
		private static readonly IntPtr NativeMethodInfoPtr_HandlePress_Public_Abstract_Virtual_New_Boolean_UnitView_0;
	}
}
