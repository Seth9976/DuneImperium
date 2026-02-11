using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Localization.Tables
{
	// Token: 0x02000026 RID: 38
	public class IKeyGenerator : Il2CppObjectBase
	{
		// Token: 0x0600022B RID: 555 RVA: 0x00002CCA File Offset: 0x00000ECA
		// Note: this type is marked as 'beforefieldinit'.
		static IKeyGenerator()
		{
			Il2CppClassPointerStore<IKeyGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Tables", "IKeyGenerator");
			IKeyGenerator.NativeMethodInfoPtr_GetNextKey_Public_Abstract_Virtual_New_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IKeyGenerator>.NativeClassPtr, 100663696);
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00011944 File Offset: 0x0000FB44
		[CallerCount(0)]
		public unsafe virtual long GetNextKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IKeyGenerator.NativeMethodInfoPtr_GetNextKey_Public_Abstract_Virtual_New_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00002CF9 File Offset: 0x00000EF9
		public IKeyGenerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400019B RID: 411
		private static readonly IntPtr NativeMethodInfoPtr_GetNextKey_Public_Abstract_Virtual_New_Int64_0;
	}
}
