using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Threading
{
	// Token: 0x020001B2 RID: 434
	public class IThreadPoolWorkItem : Il2CppObjectBase
	{
		// Token: 0x06001C61 RID: 7265 RVA: 0x000A8F78 File Offset: 0x000A7178
		// Note: this type is marked as 'beforefieldinit'.
		static IThreadPoolWorkItem()
		{
			Il2CppClassPointerStore<IThreadPoolWorkItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "IThreadPoolWorkItem");
			IThreadPoolWorkItem.NativeMethodInfoPtr_ExecuteWorkItem_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IThreadPoolWorkItem>.NativeClassPtr, 100668190);
			IThreadPoolWorkItem.NativeMethodInfoPtr_MarkAborted_Public_Abstract_Virtual_New_Void_ThreadAbortException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IThreadPoolWorkItem>.NativeClassPtr, 100668191);
		}

		// Token: 0x06001C62 RID: 7266 RVA: 0x000A8FC8 File Offset: 0x000A71C8
		[CallerCount(0)]
		public unsafe virtual void ExecuteWorkItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IThreadPoolWorkItem.NativeMethodInfoPtr_ExecuteWorkItem_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C63 RID: 7267 RVA: 0x000A9004 File Offset: 0x000A7204
		[CallerCount(0)]
		public unsafe virtual void MarkAborted(ThreadAbortException tae)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tae);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IThreadPoolWorkItem.NativeMethodInfoPtr_MarkAborted_Public_Abstract_Virtual_New_Void_ThreadAbortException_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C64 RID: 7268 RVA: 0x0000916B File Offset: 0x0000736B
		public IThreadPoolWorkItem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040019D4 RID: 6612
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteWorkItem_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040019D5 RID: 6613
		private static readonly IntPtr NativeMethodInfoPtr_MarkAborted_Public_Abstract_Virtual_New_Void_ThreadAbortException_0;
	}
}
