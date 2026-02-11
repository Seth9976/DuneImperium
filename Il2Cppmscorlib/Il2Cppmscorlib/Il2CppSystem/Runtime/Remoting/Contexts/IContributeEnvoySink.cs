using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting.Contexts
{
	// Token: 0x020002C2 RID: 706
	public class IContributeEnvoySink : Il2CppObjectBase
	{
		// Token: 0x06002CDE RID: 11486 RVA: 0x0000F048 File Offset: 0x0000D248
		// Note: this type is marked as 'beforefieldinit'.
		static IContributeEnvoySink()
		{
			Il2CppClassPointerStore<IContributeEnvoySink>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Contexts", "IContributeEnvoySink");
			IContributeEnvoySink.NativeMethodInfoPtr_GetEnvoySink_Public_Abstract_Virtual_New_IMessageSink_MarshalByRefObject_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IContributeEnvoySink>.NativeClassPtr, 100670521);
		}

		// Token: 0x06002CDF RID: 11487 RVA: 0x000EAAF4 File Offset: 0x000E8CF4
		[CallerCount(0)]
		public unsafe virtual IMessageSink GetEnvoySink(MarshalByRefObject obj, IMessageSink nextSink)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nextSink);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IContributeEnvoySink.NativeMethodInfoPtr_GetEnvoySink_Public_Abstract_Virtual_New_IMessageSink_MarshalByRefObject_IMessageSink_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr3) : null;
		}

		// Token: 0x06002CE0 RID: 11488 RVA: 0x0000F077 File Offset: 0x0000D277
		public IContributeEnvoySink(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040025C3 RID: 9667
		private static readonly IntPtr NativeMethodInfoPtr_GetEnvoySink_Public_Abstract_Virtual_New_IMessageSink_MarshalByRefObject_IMessageSink_0;
	}
}
