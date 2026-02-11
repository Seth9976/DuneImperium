using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Text;

namespace Il2CppSystem
{
	// Token: 0x020000F3 RID: 243
	public class ITupleInternal : Il2CppObjectBase
	{
		// Token: 0x06000FA0 RID: 4000 RVA: 0x00005C22 File Offset: 0x00003E22
		// Note: this type is marked as 'beforefieldinit'.
		static ITupleInternal()
		{
			Il2CppClassPointerStore<ITupleInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ITupleInternal");
			ITupleInternal.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITupleInternal>.NativeClassPtr, 100666009);
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x0006E614 File Offset: 0x0006C814
		[CallerCount(0)]
		public unsafe virtual string ToString(StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITupleInternal.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_StringBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x00005C51 File Offset: 0x00003E51
		public ITupleInternal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CBA RID: 3258
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_StringBuilder_0;
	}
}
