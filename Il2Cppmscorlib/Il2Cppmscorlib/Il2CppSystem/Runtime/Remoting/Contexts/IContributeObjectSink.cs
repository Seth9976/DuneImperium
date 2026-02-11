using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting.Contexts
{
	// Token: 0x020002C3 RID: 707
	public class IContributeObjectSink : Il2CppObjectBase
	{
		// Token: 0x06002CE1 RID: 11489 RVA: 0x0000F080 File Offset: 0x0000D280
		// Note: this type is marked as 'beforefieldinit'.
		static IContributeObjectSink()
		{
			Il2CppClassPointerStore<IContributeObjectSink>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Contexts", "IContributeObjectSink");
			IContributeObjectSink.NativeMethodInfoPtr_GetObjectSink_Public_Abstract_Virtual_New_IMessageSink_MarshalByRefObject_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IContributeObjectSink>.NativeClassPtr, 100670522);
		}

		// Token: 0x06002CE2 RID: 11490 RVA: 0x000EAB64 File Offset: 0x000E8D64
		[CallerCount(0)]
		public unsafe virtual IMessageSink GetObjectSink(MarshalByRefObject obj, IMessageSink nextSink)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IContributeObjectSink.NativeMethodInfoPtr_GetObjectSink_Public_Abstract_Virtual_New_IMessageSink_MarshalByRefObject_IMessageSink_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr3) : null;
		}

		// Token: 0x06002CE3 RID: 11491 RVA: 0x0000F0AF File Offset: 0x0000D2AF
		public IContributeObjectSink(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040025C4 RID: 9668
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectSink_Public_Abstract_Virtual_New_IMessageSink_MarshalByRefObject_IMessageSink_0;
	}
}
