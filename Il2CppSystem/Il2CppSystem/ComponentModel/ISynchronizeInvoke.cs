using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x020000EF RID: 239
	public class ISynchronizeInvoke : Il2CppObjectBase
	{
		// Token: 0x06000F8D RID: 3981 RVA: 0x00056954 File Offset: 0x00054B54
		// Note: this type is marked as 'beforefieldinit'.
		static ISynchronizeInvoke()
		{
			Il2CppClassPointerStore<ISynchronizeInvoke>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "ISynchronizeInvoke");
			ISynchronizeInvoke.NativeMethodInfoPtr_get_InvokeRequired_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISynchronizeInvoke>.NativeClassPtr, 100665540);
			ISynchronizeInvoke.NativeMethodInfoPtr_BeginInvoke_Public_Abstract_Virtual_New_IAsyncResult_Delegate_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISynchronizeInvoke>.NativeClassPtr, 100665541);
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06000F8E RID: 3982 RVA: 0x000569A4 File Offset: 0x00054BA4
		public unsafe virtual bool InvokeRequired
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISynchronizeInvoke.NativeMethodInfoPtr_get_InvokeRequired_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x000569EC File Offset: 0x00054BEC
		[CallerCount(0)]
		public unsafe virtual IAsyncResult BeginInvoke(Delegate method, Il2CppReferenceArray<Object> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISynchronizeInvoke.NativeMethodInfoPtr_BeginInvoke_Public_Abstract_Virtual_New_IAsyncResult_Delegate_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x000079E0 File Offset: 0x00005BE0
		public ISynchronizeInvoke(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CA0 RID: 3232
		private static readonly IntPtr NativeMethodInfoPtr_get_InvokeRequired_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000CA1 RID: 3233
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Abstract_Virtual_New_IAsyncResult_Delegate_Il2CppReferenceArray_1_Object_0;
	}
}
