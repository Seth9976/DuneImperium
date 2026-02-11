using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Unity.Jobs
{
	// Token: 0x0200000B RID: 11
	public class IJobFor : Il2CppObjectBase
	{
		// Token: 0x06000027 RID: 39 RVA: 0x000021FD File Offset: 0x000003FD
		// Note: this type is marked as 'beforefieldinit'.
		static IJobFor()
		{
			Il2CppClassPointerStore<IJobFor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Jobs", "IJobFor");
			IJobFor.NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobFor>.NativeClassPtr, 100663314);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00016F24 File Offset: 0x00015124
		[CallerCount(0)]
		public unsafe virtual void Execute(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IJobFor.NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000222C File Offset: 0x0000042C
		public IJobFor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Void_Int32_0;
	}
}
