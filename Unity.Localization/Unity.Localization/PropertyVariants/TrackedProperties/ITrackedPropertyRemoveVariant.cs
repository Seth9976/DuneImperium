using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Localization.PropertyVariants.TrackedProperties
{
	// Token: 0x020000E6 RID: 230
	public class ITrackedPropertyRemoveVariant : Il2CppObjectBase
	{
		// Token: 0x06000B90 RID: 2960 RVA: 0x00006CA0 File Offset: 0x00004EA0
		// Note: this type is marked as 'beforefieldinit'.
		static ITrackedPropertyRemoveVariant()
		{
			Il2CppClassPointerStore<ITrackedPropertyRemoveVariant>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.PropertyVariants.TrackedProperties", "ITrackedPropertyRemoveVariant");
			ITrackedPropertyRemoveVariant.NativeMethodInfoPtr_RemoveVariant_Public_Abstract_Virtual_New_Void_LocaleIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITrackedPropertyRemoveVariant>.NativeClassPtr, 100665213);
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x00034F30 File Offset: 0x00033130
		[CallerCount(0)]
		public unsafe virtual void RemoveVariant(LocaleIdentifier localeIdentifier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(localeIdentifier));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITrackedPropertyRemoveVariant.NativeMethodInfoPtr_RemoveVariant_Public_Abstract_Virtual_New_Void_LocaleIdentifier_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x00006CCF File Offset: 0x00004ECF
		public ITrackedPropertyRemoveVariant(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000821 RID: 2081
		private static readonly IntPtr NativeMethodInfoPtr_RemoveVariant_Public_Abstract_Virtual_New_Void_LocaleIdentifier_0;
	}
}
