using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace lotus.kabbage
{
	// Token: 0x0200008F RID: 143
	public class IConfigurableRootModule : Il2CppObjectBase
	{
		// Token: 0x06000891 RID: 2193 RVA: 0x000062DE File Offset: 0x000044DE
		// Note: this type is marked as 'beforefieldinit'.
		static IConfigurableRootModule()
		{
			Il2CppClassPointerStore<IConfigurableRootModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus.kabbage", "IConfigurableRootModule");
			IConfigurableRootModule.NativeMethodInfoPtr_Configure_Public_Abstract_Virtual_New_Void_MoveContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigurableRootModule>.NativeClassPtr, 100664544);
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x00025F5C File Offset: 0x0002415C
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

		// Token: 0x06000893 RID: 2195 RVA: 0x0000630D File Offset: 0x0000450D
		public IConfigurableRootModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000562 RID: 1378
		private static readonly IntPtr NativeMethodInfoPtr_Configure_Public_Abstract_Virtual_New_Void_MoveContext_0;
	}
}
