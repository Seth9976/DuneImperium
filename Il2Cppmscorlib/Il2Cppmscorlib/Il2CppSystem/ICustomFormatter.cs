using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem
{
	// Token: 0x020000AB RID: 171
	public class ICustomFormatter : Il2CppObjectBase
	{
		// Token: 0x06000B9A RID: 2970 RVA: 0x00004EBE File Offset: 0x000030BE
		// Note: this type is marked as 'beforefieldinit'.
		static ICustomFormatter()
		{
			Il2CppClassPointerStore<ICustomFormatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ICustomFormatter");
			ICustomFormatter.NativeMethodInfoPtr_Format_Public_Abstract_Virtual_New_String_String_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomFormatter>.NativeClassPtr, 100665318);
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x0005B6FC File Offset: 0x000598FC
		[CallerCount(0)]
		public unsafe virtual string Format(string format, Object arg, IFormatProvider formatProvider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomFormatter.NativeMethodInfoPtr_Format_Public_Abstract_Virtual_New_String_String_Object_IFormatProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x00004EED File Offset: 0x000030ED
		public ICustomFormatter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000988 RID: 2440
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Abstract_Virtual_New_String_String_Object_IFormatProvider_0;
	}
}
