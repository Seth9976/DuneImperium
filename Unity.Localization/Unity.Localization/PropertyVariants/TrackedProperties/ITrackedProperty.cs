using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Localization.PropertyVariants.TrackedProperties
{
	// Token: 0x020000E2 RID: 226
	public class ITrackedProperty : Il2CppObjectBase
	{
		// Token: 0x06000B6E RID: 2926 RVA: 0x000345BC File Offset: 0x000327BC
		// Note: this type is marked as 'beforefieldinit'.
		static ITrackedProperty()
		{
			Il2CppClassPointerStore<ITrackedProperty>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.PropertyVariants.TrackedProperties", "ITrackedProperty");
			ITrackedProperty.NativeMethodInfoPtr_get_PropertyPath_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITrackedProperty>.NativeClassPtr, 100665195);
			ITrackedProperty.NativeMethodInfoPtr_set_PropertyPath_Public_Abstract_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITrackedProperty>.NativeClassPtr, 100665196);
			ITrackedProperty.NativeMethodInfoPtr_HasVariant_Public_Abstract_Virtual_New_Boolean_LocaleIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITrackedProperty>.NativeClassPtr, 100665197);
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000B6F RID: 2927 RVA: 0x00034620 File Offset: 0x00032820
		// (set) Token: 0x06000B70 RID: 2928 RVA: 0x00034664 File Offset: 0x00032864
		public unsafe virtual string PropertyPath
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITrackedProperty.NativeMethodInfoPtr_get_PropertyPath_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITrackedProperty.NativeMethodInfoPtr_set_PropertyPath_Public_Abstract_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x000346B4 File Offset: 0x000328B4
		[CallerCount(0)]
		public unsafe virtual bool HasVariant(LocaleIdentifier localeIdentifier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(localeIdentifier));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITrackedProperty.NativeMethodInfoPtr_HasVariant_Public_Abstract_Virtual_New_Boolean_LocaleIdentifier_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x00006C00 File Offset: 0x00004E00
		public ITrackedProperty(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400080B RID: 2059
		private static readonly IntPtr NativeMethodInfoPtr_get_PropertyPath_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400080C RID: 2060
		private static readonly IntPtr NativeMethodInfoPtr_set_PropertyPath_Public_Abstract_Virtual_New_set_Void_String_0;

		// Token: 0x0400080D RID: 2061
		private static readonly IntPtr NativeMethodInfoPtr_HasVariant_Public_Abstract_Virtual_New_Boolean_LocaleIdentifier_0;
	}
}
