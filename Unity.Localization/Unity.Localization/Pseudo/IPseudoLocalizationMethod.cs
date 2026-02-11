using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Localization.Pseudo
{
	// Token: 0x020000A1 RID: 161
	public class IPseudoLocalizationMethod : Il2CppObjectBase
	{
		// Token: 0x060007FB RID: 2043 RVA: 0x000050F0 File Offset: 0x000032F0
		// Note: this type is marked as 'beforefieldinit'.
		static IPseudoLocalizationMethod()
		{
			Il2CppClassPointerStore<IPseudoLocalizationMethod>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Pseudo", "IPseudoLocalizationMethod");
			IPseudoLocalizationMethod.NativeMethodInfoPtr_Transform_Public_Abstract_Virtual_New_Void_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPseudoLocalizationMethod>.NativeClassPtr, 100664720);
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x00028124 File Offset: 0x00026324
		[CallerCount(0)]
		public unsafe virtual void Transform(Message message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPseudoLocalizationMethod.NativeMethodInfoPtr_Transform_Public_Abstract_Virtual_New_Void_Message_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x0000511F File Offset: 0x0000331F
		public IPseudoLocalizationMethod(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040005BA RID: 1466
		private static readonly IntPtr NativeMethodInfoPtr_Transform_Public_Abstract_Virtual_New_Void_Message_0;
	}
}
