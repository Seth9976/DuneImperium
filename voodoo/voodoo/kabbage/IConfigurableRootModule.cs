using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using lotus;

namespace voodoo.kabbage
{
	// Token: 0x0200001E RID: 30
	public class IConfigurableRootModule : Il2CppObjectBase
	{
		// Token: 0x060000F3 RID: 243 RVA: 0x000028A8 File Offset: 0x00000AA8
		// Note: this type is marked as 'beforefieldinit'.
		static IConfigurableRootModule()
		{
			Il2CppClassPointerStore<IConfigurableRootModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "voodoo.kabbage", "IConfigurableRootModule");
			IConfigurableRootModule.NativeMethodInfoPtr_Configure_Public_Abstract_Virtual_New_Void_MoveContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigurableRootModule>.NativeClassPtr, 100663404);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0000C0E4 File Offset: 0x0000A2E4
		[CallerCount(0)]
		public unsafe virtual void Configure(MoveContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigurableRootModule.NativeMethodInfoPtr_Configure_Public_Abstract_Virtual_New_Void_MoveContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000028D7 File Offset: 0x00000AD7
		public IConfigurableRootModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_Configure_Public_Abstract_Virtual_New_Void_MoveContext_0;
	}
}
