using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.IO
{
	// Token: 0x02000182 RID: 386
	public class IFileWatcher : Il2CppObjectBase
	{
		// Token: 0x060017AB RID: 6059 RVA: 0x0007876C File Offset: 0x0007696C
		// Note: this type is marked as 'beforefieldinit'.
		static IFileWatcher()
		{
			Il2CppClassPointerStore<IFileWatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.IO", "IFileWatcher");
			IFileWatcher.NativeMethodInfoPtr_StartDispatching_Public_Abstract_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFileWatcher>.NativeClassPtr, 100667018);
			IFileWatcher.NativeMethodInfoPtr_StopDispatching_Public_Abstract_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFileWatcher>.NativeClassPtr, 100667019);
			IFileWatcher.NativeMethodInfoPtr_Dispose_Public_Abstract_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFileWatcher>.NativeClassPtr, 100667020);
		}

		// Token: 0x060017AC RID: 6060 RVA: 0x000787D0 File Offset: 0x000769D0
		[CallerCount(0)]
		public unsafe virtual void StartDispatching(Object fsw)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fsw);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFileWatcher.NativeMethodInfoPtr_StartDispatching_Public_Abstract_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017AD RID: 6061 RVA: 0x00078820 File Offset: 0x00076A20
		[CallerCount(0)]
		public unsafe virtual void StopDispatching(Object fsw)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fsw);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFileWatcher.NativeMethodInfoPtr_StopDispatching_Public_Abstract_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017AE RID: 6062 RVA: 0x00078870 File Offset: 0x00076A70
		[CallerCount(0)]
		public unsafe virtual void Dispose(Object fsw)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fsw);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFileWatcher.NativeMethodInfoPtr_Dispose_Public_Abstract_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017AF RID: 6063 RVA: 0x0000A4A5 File Offset: 0x000086A5
		public IFileWatcher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400125D RID: 4701
		private static readonly IntPtr NativeMethodInfoPtr_StartDispatching_Public_Abstract_Virtual_New_Void_Object_0;

		// Token: 0x0400125E RID: 4702
		private static readonly IntPtr NativeMethodInfoPtr_StopDispatching_Public_Abstract_Virtual_New_Void_Object_0;

		// Token: 0x0400125F RID: 4703
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Abstract_Virtual_New_Void_Object_0;
	}
}
