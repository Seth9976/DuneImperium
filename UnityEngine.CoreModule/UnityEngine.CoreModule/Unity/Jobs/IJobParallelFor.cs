using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Unity.Jobs
{
	// Token: 0x0200000D RID: 13
	public class IJobParallelFor : Il2CppObjectBase
	{
		// Token: 0x06000034 RID: 52 RVA: 0x00002247 File Offset: 0x00000447
		// Note: this type is marked as 'beforefieldinit'.
		static IJobParallelFor()
		{
			Il2CppClassPointerStore<IJobParallelFor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Jobs", "IJobParallelFor");
			IJobParallelFor.NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobParallelFor>.NativeClassPtr, 100663322);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00017198 File Offset: 0x00015398
		[CallerCount(0)]
		public unsafe virtual void Execute(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IJobParallelFor.NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002276 File Offset: 0x00000476
		public IJobParallelFor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Void_Int32_0;
	}
}
