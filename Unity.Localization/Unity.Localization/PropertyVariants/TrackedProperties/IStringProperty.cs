using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Localization.PropertyVariants.TrackedProperties
{
	// Token: 0x020000E1 RID: 225
	public class IStringProperty : Il2CppObjectBase
	{
		// Token: 0x06000B69 RID: 2921 RVA: 0x0003442C File Offset: 0x0003262C
		// Note: this type is marked as 'beforefieldinit'.
		static IStringProperty()
		{
			Il2CppClassPointerStore<IStringProperty>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.PropertyVariants.TrackedProperties", "IStringProperty");
			IStringProperty.NativeMethodInfoPtr_GetValueAsString_Public_Abstract_Virtual_New_String_LocaleIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStringProperty>.NativeClassPtr, 100665192);
			IStringProperty.NativeMethodInfoPtr_GetValueAsString_Public_Abstract_Virtual_New_String_LocaleIdentifier_LocaleIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStringProperty>.NativeClassPtr, 100665193);
			IStringProperty.NativeMethodInfoPtr_SetValueFromString_Public_Abstract_Virtual_New_Void_LocaleIdentifier_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStringProperty>.NativeClassPtr, 100665194);
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x00034490 File Offset: 0x00032690
		[CallerCount(0)]
		public unsafe virtual string GetValueAsString(LocaleIdentifier localeIdentifier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(localeIdentifier));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStringProperty.NativeMethodInfoPtr_GetValueAsString_Public_Abstract_Virtual_New_String_LocaleIdentifier_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x000344E8 File Offset: 0x000326E8
		[CallerCount(0)]
		public unsafe virtual string GetValueAsString(LocaleIdentifier localeIdentifier, LocaleIdentifier fallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(localeIdentifier));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(fallback));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStringProperty.NativeMethodInfoPtr_GetValueAsString_Public_Abstract_Virtual_New_String_LocaleIdentifier_LocaleIdentifier_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x00034558 File Offset: 0x00032758
		[CallerCount(0)]
		public unsafe virtual void SetValueFromString(LocaleIdentifier localeIdentifier, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(localeIdentifier));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStringProperty.NativeMethodInfoPtr_SetValueFromString_Public_Abstract_Virtual_New_Void_LocaleIdentifier_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x00006BF7 File Offset: 0x00004DF7
		public IStringProperty(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000808 RID: 2056
		private static readonly IntPtr NativeMethodInfoPtr_GetValueAsString_Public_Abstract_Virtual_New_String_LocaleIdentifier_0;

		// Token: 0x04000809 RID: 2057
		private static readonly IntPtr NativeMethodInfoPtr_GetValueAsString_Public_Abstract_Virtual_New_String_LocaleIdentifier_LocaleIdentifier_0;

		// Token: 0x0400080A RID: 2058
		private static readonly IntPtr NativeMethodInfoPtr_SetValueFromString_Public_Abstract_Virtual_New_Void_LocaleIdentifier_String_0;
	}
}
