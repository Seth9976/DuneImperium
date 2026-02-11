using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UIElements
{
	// Token: 0x020001EB RID: 491
	public class IUxmlAttributes : Il2CppObjectBase
	{
		// Token: 0x0600271E RID: 10014 RVA: 0x0000FD99 File Offset: 0x0000DF99
		// Note: this type is marked as 'beforefieldinit'.
		static IUxmlAttributes()
		{
			Il2CppClassPointerStore<IUxmlAttributes>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IUxmlAttributes");
			IUxmlAttributes.NativeMethodInfoPtr_TryGetAttributeValue_Public_Abstract_Virtual_New_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUxmlAttributes>.NativeClassPtr, 100669206);
		}

		// Token: 0x0600271F RID: 10015 RVA: 0x000ACF3C File Offset: 0x000AB13C
		[CallerCount(0)]
		public unsafe virtual bool TryGetAttributeValue(string attributeName, out string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(attributeName);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUxmlAttributes.NativeMethodInfoPtr_TryGetAttributeValue_Public_Abstract_Virtual_New_Boolean_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			value = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002720 RID: 10016 RVA: 0x0000FDC8 File Offset: 0x0000DFC8
		public IUxmlAttributes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001BF0 RID: 7152
		private static readonly IntPtr NativeMethodInfoPtr_TryGetAttributeValue_Public_Abstract_Virtual_New_Boolean_String_byref_String_0;
	}
}
