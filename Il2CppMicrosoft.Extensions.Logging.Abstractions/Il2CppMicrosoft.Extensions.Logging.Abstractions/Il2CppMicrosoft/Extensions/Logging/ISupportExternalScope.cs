using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppMicrosoft.Extensions.Logging
{
	// Token: 0x02000016 RID: 22
	public class ISupportExternalScope : Il2CppObjectBase
	{
		// Token: 0x06000078 RID: 120 RVA: 0x000024D8 File Offset: 0x000006D8
		// Note: this type is marked as 'beforefieldinit'.
		static ISupportExternalScope()
		{
			Il2CppClassPointerStore<ISupportExternalScope>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.Logging.Abstractions.dll", "Microsoft.Extensions.Logging", "ISupportExternalScope");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISupportExternalScope>.NativeClassPtr);
			ISupportExternalScope.NativeMethodInfoPtr_SetScopeProvider_Public_Abstract_Virtual_New_Void_IExternalScopeProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISupportExternalScope>.NativeClassPtr, 100663354);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00003D00 File Offset: 0x00001F00
		[CallerCount(0)]
		public unsafe virtual void SetScopeProvider(IExternalScopeProvider scopeProvider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scopeProvider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISupportExternalScope.NativeMethodInfoPtr_SetScopeProvider_Public_Abstract_Virtual_New_Void_IExternalScopeProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002511 File Offset: 0x00000711
		public ISupportExternalScope(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_SetScopeProvider_Public_Abstract_Virtual_New_Void_IExternalScopeProvider_0;
	}
}
