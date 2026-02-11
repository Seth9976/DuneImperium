using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UIElements
{
	// Token: 0x0200009C RID: 156
	public class ICursorManager : Il2CppObjectBase
	{
		// Token: 0x06000F7E RID: 3966 RVA: 0x000538B8 File Offset: 0x00051AB8
		// Note: this type is marked as 'beforefieldinit'.
		static ICursorManager()
		{
			Il2CppClassPointerStore<ICursorManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ICursorManager");
			ICursorManager.NativeMethodInfoPtr_SetCursor_Public_Abstract_Virtual_New_Void_Cursor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICursorManager>.NativeClassPtr, 100665493);
			ICursorManager.NativeMethodInfoPtr_ResetCursor_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICursorManager>.NativeClassPtr, 100665494);
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x00053908 File Offset: 0x00051B08
		[CallerCount(0)]
		public unsafe virtual void SetCursor(Cursor cursor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cursor));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICursorManager.NativeMethodInfoPtr_SetCursor_Public_Abstract_Virtual_New_Void_Cursor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x0005395C File Offset: 0x00051B5C
		[CallerCount(0)]
		public unsafe virtual void ResetCursor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICursorManager.NativeMethodInfoPtr_ResetCursor_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x00007D78 File Offset: 0x00005F78
		public ICursorManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000ABF RID: 2751
		private static readonly IntPtr NativeMethodInfoPtr_SetCursor_Public_Abstract_Virtual_New_Void_Cursor_0;

		// Token: 0x04000AC0 RID: 2752
		private static readonly IntPtr NativeMethodInfoPtr_ResetCursor_Public_Abstract_Virtual_New_Void_0;
	}
}
