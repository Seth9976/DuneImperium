using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting.Contexts
{
	// Token: 0x020002C4 RID: 708
	public class IContributeServerContextSink : Il2CppObjectBase
	{
		// Token: 0x06002CE4 RID: 11492 RVA: 0x0000F0B8 File Offset: 0x0000D2B8
		// Note: this type is marked as 'beforefieldinit'.
		static IContributeServerContextSink()
		{
			Il2CppClassPointerStore<IContributeServerContextSink>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Contexts", "IContributeServerContextSink");
			IContributeServerContextSink.NativeMethodInfoPtr_GetServerContextSink_Public_Abstract_Virtual_New_IMessageSink_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IContributeServerContextSink>.NativeClassPtr, 100670523);
		}

		// Token: 0x06002CE5 RID: 11493 RVA: 0x000EABD4 File Offset: 0x000E8DD4
		[CallerCount(0)]
		public unsafe virtual IMessageSink GetServerContextSink(IMessageSink nextSink)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nextSink);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IContributeServerContextSink.NativeMethodInfoPtr_GetServerContextSink_Public_Abstract_Virtual_New_IMessageSink_IMessageSink_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr3) : null;
			}
		}

		// Token: 0x06002CE6 RID: 11494 RVA: 0x0000F0E7 File Offset: 0x0000D2E7
		public IContributeServerContextSink(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040025C5 RID: 9669
		private static readonly IntPtr NativeMethodInfoPtr_GetServerContextSink_Public_Abstract_Virtual_New_IMessageSink_IMessageSink_0;
	}
}
