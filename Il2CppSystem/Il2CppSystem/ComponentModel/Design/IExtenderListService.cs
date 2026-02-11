using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel.Design
{
	// Token: 0x02000151 RID: 337
	public class IExtenderListService : Il2CppObjectBase
	{
		// Token: 0x0600147C RID: 5244 RVA: 0x00009196 File Offset: 0x00007396
		// Note: this type is marked as 'beforefieldinit'.
		static IExtenderListService()
		{
			Il2CppClassPointerStore<IExtenderListService>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel.Design", "IExtenderListService");
			IExtenderListService.NativeMethodInfoPtr_GetExtenderProviders_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_IExtenderProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExtenderListService>.NativeClassPtr, 100666353);
		}

		// Token: 0x0600147D RID: 5245 RVA: 0x0006B91C File Offset: 0x00069B1C
		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<IExtenderProvider> GetExtenderProviders()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IExtenderListService.NativeMethodInfoPtr_GetExtenderProviders_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_IExtenderProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IExtenderProvider>>(intPtr3) : null;
		}

		// Token: 0x0600147E RID: 5246 RVA: 0x000091C5 File Offset: 0x000073C5
		public IExtenderListService(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001019 RID: 4121
		private static readonly IntPtr NativeMethodInfoPtr_GetExtenderProviders_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_IExtenderProvider_0;
	}
}
