using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.Remoting.Lifetime
{
	// Token: 0x020002B3 RID: 691
	public class ISponsor : Il2CppObjectBase
	{
		// Token: 0x06002C2A RID: 11306 RVA: 0x0000EBF0 File Offset: 0x0000CDF0
		// Note: this type is marked as 'beforefieldinit'.
		static ISponsor()
		{
			Il2CppClassPointerStore<ISponsor>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Lifetime", "ISponsor");
			ISponsor.NativeMethodInfoPtr_Renewal_Public_Abstract_Virtual_New_TimeSpan_ILease_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISponsor>.NativeClassPtr, 100670426);
		}

		// Token: 0x06002C2B RID: 11307 RVA: 0x000E83E4 File Offset: 0x000E65E4
		[CallerCount(0)]
		public unsafe virtual TimeSpan Renewal(ILease lease)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lease);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISponsor.NativeMethodInfoPtr_Renewal_Public_Abstract_Virtual_New_TimeSpan_ILease_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C2C RID: 11308 RVA: 0x0000EC1F File Offset: 0x0000CE1F
		public ISponsor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002548 RID: 9544
		private static readonly IntPtr NativeMethodInfoPtr_Renewal_Public_Abstract_Virtual_New_TimeSpan_ILease_0;
	}
}
