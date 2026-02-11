using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem
{
	// Token: 0x02000155 RID: 341
	public class IConsoleDriver : Il2CppObjectBase
	{
		// Token: 0x06001745 RID: 5957 RVA: 0x00094F20 File Offset: 0x00093120
		// Note: this type is marked as 'beforefieldinit'.
		static IConsoleDriver()
		{
			Il2CppClassPointerStore<IConsoleDriver>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "IConsoleDriver");
			IConsoleDriver.NativeMethodInfoPtr_ReadKey_Public_Abstract_Virtual_New_ConsoleKeyInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConsoleDriver>.NativeClassPtr, 100667366);
			IConsoleDriver.NativeMethodInfoPtr_ReadLine_Public_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConsoleDriver>.NativeClassPtr, 100667367);
		}

		// Token: 0x06001746 RID: 5958 RVA: 0x00094F70 File Offset: 0x00093170
		[CallerCount(0)]
		public unsafe virtual ConsoleKeyInfo ReadKey(bool intercept)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref intercept;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConsoleDriver.NativeMethodInfoPtr_ReadKey_Public_Abstract_Virtual_New_ConsoleKeyInfo_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001747 RID: 5959 RVA: 0x00094FC4 File Offset: 0x000931C4
		[CallerCount(0)]
		public unsafe virtual string ReadLine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConsoleDriver.NativeMethodInfoPtr_ReadLine_Public_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001748 RID: 5960 RVA: 0x0000764D File Offset: 0x0000584D
		public IConsoleDriver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001403 RID: 5123
		private static readonly IntPtr NativeMethodInfoPtr_ReadKey_Public_Abstract_Virtual_New_ConsoleKeyInfo_Boolean_0;

		// Token: 0x04001404 RID: 5124
		private static readonly IntPtr NativeMethodInfoPtr_ReadLine_Public_Abstract_Virtual_New_String_0;
	}
}
