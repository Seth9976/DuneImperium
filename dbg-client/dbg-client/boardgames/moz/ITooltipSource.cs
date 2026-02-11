using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace boardgames.moz
{
	// Token: 0x02000118 RID: 280
	public class ITooltipSource : Il2CppObjectBase
	{
		// Token: 0x06000C8D RID: 3213 RVA: 0x0000817E File Offset: 0x0000637E
		// Note: this type is marked as 'beforefieldinit'.
		static ITooltipSource()
		{
			Il2CppClassPointerStore<ITooltipSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.moz", "ITooltipSource");
			ITooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITooltipSource>.NativeClassPtr, 100665126);
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x00045280 File Offset: 0x00043480
		[CallerCount(0)]
		public unsafe virtual string GetLocalizedTooltip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x000081AD File Offset: 0x000063AD
		public ITooltipSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040007BA RID: 1978
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedTooltip_Public_Abstract_Virtual_New_String_0;
	}
}
