using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.Remoting.Contexts
{
	// Token: 0x020002C6 RID: 710
	public class IDynamicProperty : Il2CppObjectBase
	{
		// Token: 0x06002CEB RID: 11499 RVA: 0x0000F0F9 File Offset: 0x0000D2F9
		// Note: this type is marked as 'beforefieldinit'.
		static IDynamicProperty()
		{
			Il2CppClassPointerStore<IDynamicProperty>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Contexts", "IDynamicProperty");
			IDynamicProperty.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDynamicProperty>.NativeClassPtr, 100670526);
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x06002CEC RID: 11500 RVA: 0x000EAD58 File Offset: 0x000E8F58
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDynamicProperty.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002CED RID: 11501 RVA: 0x0000F128 File Offset: 0x0000D328
		public IDynamicProperty(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040025C8 RID: 9672
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0;
	}
}
