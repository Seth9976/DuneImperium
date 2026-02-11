using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000AE RID: 174
	public class IFormatProvider : Il2CppObjectBase
	{
		// Token: 0x06000BA3 RID: 2979 RVA: 0x00004F37 File Offset: 0x00003137
		// Note: this type is marked as 'beforefieldinit'.
		static IFormatProvider()
		{
			Il2CppClassPointerStore<IFormatProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "IFormatProvider");
			IFormatProvider.NativeMethodInfoPtr_GetFormat_Public_Abstract_Virtual_New_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFormatProvider>.NativeClassPtr, 100665321);
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x0005B8B8 File Offset: 0x00059AB8
		[CallerCount(0)]
		public unsafe virtual Object GetFormat(Type formatType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formatType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFormatProvider.NativeMethodInfoPtr_GetFormat_Public_Abstract_Virtual_New_Object_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x00004F66 File Offset: 0x00003166
		public IFormatProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400098B RID: 2443
		private static readonly IntPtr NativeMethodInfoPtr_GetFormat_Public_Abstract_Virtual_New_Object_Type_0;
	}
}
