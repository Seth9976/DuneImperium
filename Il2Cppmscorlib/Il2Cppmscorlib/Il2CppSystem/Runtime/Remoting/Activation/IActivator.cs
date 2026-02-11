using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Activation
{
	// Token: 0x020002D9 RID: 729
	public class IActivator : Il2CppObjectBase
	{
		// Token: 0x06002D7C RID: 11644 RVA: 0x000ECC8C File Offset: 0x000EAE8C
		// Note: this type is marked as 'beforefieldinit'.
		static IActivator()
		{
			Il2CppClassPointerStore<IActivator>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Activation", "IActivator");
			IActivator.NativeMethodInfoPtr_get_NextActivator_Public_Abstract_Virtual_New_get_IActivator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IActivator>.NativeClassPtr, 100670594);
			IActivator.NativeMethodInfoPtr_Activate_Public_Abstract_Virtual_New_IConstructionReturnMessage_IConstructionCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IActivator>.NativeClassPtr, 100670595);
		}

		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x06002D7D RID: 11645 RVA: 0x000ECCDC File Offset: 0x000EAEDC
		public unsafe virtual IActivator NextActivator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IActivator.NativeMethodInfoPtr_get_NextActivator_Public_Abstract_Virtual_New_get_IActivator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IActivator>(intPtr3) : null;
			}
		}

		// Token: 0x06002D7E RID: 11646 RVA: 0x000ECD28 File Offset: 0x000EAF28
		[CallerCount(0)]
		public unsafe virtual IConstructionReturnMessage Activate(IConstructionCallMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IActivator.NativeMethodInfoPtr_Activate_Public_Abstract_Virtual_New_IConstructionReturnMessage_IConstructionCallMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IConstructionReturnMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06002D7F RID: 11647 RVA: 0x0000F4B8 File Offset: 0x0000D6B8
		public IActivator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400261E RID: 9758
		private static readonly IntPtr NativeMethodInfoPtr_get_NextActivator_Public_Abstract_Virtual_New_get_IActivator_0;

		// Token: 0x0400261F RID: 9759
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Abstract_Virtual_New_IConstructionReturnMessage_IConstructionCallMessage_0;
	}
}
