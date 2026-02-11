using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem
{
	// Token: 0x020000A5 RID: 165
	public class IAsyncDisposable : Il2CppObjectBase
	{
		// Token: 0x06000B75 RID: 2933 RVA: 0x00004DFB File Offset: 0x00002FFB
		// Note: this type is marked as 'beforefieldinit'.
		static IAsyncDisposable()
		{
			Il2CppClassPointerStore<IAsyncDisposable>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "IAsyncDisposable");
			IAsyncDisposable.NativeMethodInfoPtr_DisposeAsync_Public_Abstract_Virtual_New_ValueTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncDisposable>.NativeClassPtr, 100665293);
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x0005AC14 File Offset: 0x00058E14
		[CallerCount(0)]
		public unsafe virtual ValueTask DisposeAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncDisposable.NativeMethodInfoPtr_DisposeAsync_Public_Abstract_Virtual_New_ValueTask_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTask(intPtr);
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x00004E2A File Offset: 0x0000302A
		public IAsyncDisposable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400096F RID: 2415
		private static readonly IntPtr NativeMethodInfoPtr_DisposeAsync_Public_Abstract_Virtual_New_ValueTask_0;
	}
}
