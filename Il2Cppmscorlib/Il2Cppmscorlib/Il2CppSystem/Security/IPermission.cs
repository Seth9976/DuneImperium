using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Security
{
	// Token: 0x02000219 RID: 537
	public class IPermission : Il2CppObjectBase
	{
		// Token: 0x060023CF RID: 9167 RVA: 0x000C8D10 File Offset: 0x000C6F10
		// Note: this type is marked as 'beforefieldinit'.
		static IPermission()
		{
			Il2CppClassPointerStore<IPermission>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security", "IPermission");
			IPermission.NativeMethodInfoPtr_Demand_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPermission>.NativeClassPtr, 100669345);
			IPermission.NativeMethodInfoPtr_IsSubsetOf_Public_Abstract_Virtual_New_Boolean_IPermission_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPermission>.NativeClassPtr, 100669346);
		}

		// Token: 0x060023D0 RID: 9168 RVA: 0x000C8D60 File Offset: 0x000C6F60
		[CallerCount(0)]
		public unsafe virtual void Demand()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPermission.NativeMethodInfoPtr_Demand_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023D1 RID: 9169 RVA: 0x000C8D9C File Offset: 0x000C6F9C
		[CallerCount(0)]
		public unsafe virtual bool IsSubsetOf(IPermission target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPermission.NativeMethodInfoPtr_IsSubsetOf_Public_Abstract_Virtual_New_Boolean_IPermission_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060023D2 RID: 9170 RVA: 0x0000B6E7 File Offset: 0x000098E7
		public IPermission(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001F5D RID: 8029
		private static readonly IntPtr NativeMethodInfoPtr_Demand_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04001F5E RID: 8030
		private static readonly IntPtr NativeMethodInfoPtr_IsSubsetOf_Public_Abstract_Virtual_New_Boolean_IPermission_0;
	}
}
