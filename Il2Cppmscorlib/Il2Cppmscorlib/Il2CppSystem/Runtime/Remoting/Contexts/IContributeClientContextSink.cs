using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting.Contexts
{
	// Token: 0x020002C0 RID: 704
	public class IContributeClientContextSink : Il2CppObjectBase
	{
		// Token: 0x06002CD8 RID: 11480 RVA: 0x0000EFD8 File Offset: 0x0000D1D8
		// Note: this type is marked as 'beforefieldinit'.
		static IContributeClientContextSink()
		{
			Il2CppClassPointerStore<IContributeClientContextSink>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Contexts", "IContributeClientContextSink");
			IContributeClientContextSink.NativeMethodInfoPtr_GetClientContextSink_Public_Abstract_Virtual_New_IMessageSink_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IContributeClientContextSink>.NativeClassPtr, 100670519);
		}

		// Token: 0x06002CD9 RID: 11481 RVA: 0x000EAA4C File Offset: 0x000E8C4C
		[CallerCount(0)]
		public unsafe virtual IMessageSink GetClientContextSink(IMessageSink nextSink)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nextSink);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IContributeClientContextSink.NativeMethodInfoPtr_GetClientContextSink_Public_Abstract_Virtual_New_IMessageSink_IMessageSink_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr3) : null;
			}
		}

		// Token: 0x06002CDA RID: 11482 RVA: 0x0000F007 File Offset: 0x0000D207
		public IContributeClientContextSink(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040025C1 RID: 9665
		private static readonly IntPtr NativeMethodInfoPtr_GetClientContextSink_Public_Abstract_Virtual_New_IMessageSink_IMessageSink_0;
	}
}
