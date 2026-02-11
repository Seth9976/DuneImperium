using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Runtime.Remoting.Activation;

namespace Il2CppSystem.Runtime.Remoting.Contexts
{
	// Token: 0x020002BE RID: 702
	public class IContextAttribute : Il2CppObjectBase
	{
		// Token: 0x06002CCF RID: 11471 RVA: 0x000EA7F0 File Offset: 0x000E89F0
		// Note: this type is marked as 'beforefieldinit'.
		static IContextAttribute()
		{
			Il2CppClassPointerStore<IContextAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Contexts", "IContextAttribute");
			IContextAttribute.NativeMethodInfoPtr_GetPropertiesForNewContext_Public_Abstract_Virtual_New_Void_IConstructionCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IContextAttribute>.NativeClassPtr, 100670514);
			IContextAttribute.NativeMethodInfoPtr_IsContextOK_Public_Abstract_Virtual_New_Boolean_Context_IConstructionCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IContextAttribute>.NativeClassPtr, 100670515);
		}

		// Token: 0x06002CD0 RID: 11472 RVA: 0x000EA840 File Offset: 0x000E8A40
		[CallerCount(0)]
		public unsafe virtual void GetPropertiesForNewContext(IConstructionCallMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IContextAttribute.NativeMethodInfoPtr_GetPropertiesForNewContext_Public_Abstract_Virtual_New_Void_IConstructionCallMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002CD1 RID: 11473 RVA: 0x000EA890 File Offset: 0x000E8A90
		[CallerCount(0)]
		public unsafe virtual bool IsContextOK(Context ctx, IConstructionCallMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctx);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(msg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IContextAttribute.NativeMethodInfoPtr_IsContextOK_Public_Abstract_Virtual_New_Boolean_Context_IConstructionCallMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002CD2 RID: 11474 RVA: 0x0000EFC6 File Offset: 0x0000D1C6
		public IContextAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040025BC RID: 9660
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertiesForNewContext_Public_Abstract_Virtual_New_Void_IConstructionCallMessage_0;

		// Token: 0x040025BD RID: 9661
		private static readonly IntPtr NativeMethodInfoPtr_IsContextOK_Public_Abstract_Virtual_New_Boolean_Context_IConstructionCallMessage_0;
	}
}
