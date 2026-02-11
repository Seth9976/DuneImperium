using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Unity.Properties.Internal
{
	// Token: 0x02000030 RID: 48
	public class IPropertyBagRegister : Il2CppObjectBase
	{
		// Token: 0x0600016D RID: 365 RVA: 0x00002C0E File Offset: 0x00000E0E
		// Note: this type is marked as 'beforefieldinit'.
		static IPropertyBagRegister()
		{
			Il2CppClassPointerStore<IPropertyBagRegister>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PropertiesModule.dll", "Unity.Properties.Internal", "IPropertyBagRegister");
			IPropertyBagRegister.NativeMethodInfoPtr_Register_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPropertyBagRegister>.NativeClassPtr, 100663527);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x000075D4 File Offset: 0x000057D4
		[CallerCount(0)]
		public unsafe virtual void Register()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPropertyBagRegister.NativeMethodInfoPtr_Register_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00002C3D File Offset: 0x00000E3D
		public IPropertyBagRegister(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr_Register_Public_Abstract_Virtual_New_Void_0;
	}
}
