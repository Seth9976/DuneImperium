using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Jobs
{
	// Token: 0x0200018F RID: 399
	public class IJobParallelForTransform : Il2CppObjectBase
	{
		// Token: 0x06001DE7 RID: 7655 RVA: 0x0000B35F File Offset: 0x0000955F
		// Note: this type is marked as 'beforefieldinit'.
		static IJobParallelForTransform()
		{
			Il2CppClassPointerStore<IJobParallelForTransform>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Jobs", "IJobParallelForTransform");
			IJobParallelForTransform.NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Void_Int32_TransformAccess_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobParallelForTransform>.NativeClassPtr, 100667439);
		}

		// Token: 0x06001DE8 RID: 7656 RVA: 0x00087EBC File Offset: 0x000860BC
		[CallerCount(0)]
		public unsafe virtual void Execute(int index, TransformAccess transform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transform;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IJobParallelForTransform.NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Void_Int32_TransformAccess_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DE9 RID: 7657 RVA: 0x0000B38E File Offset: 0x0000958E
		public IJobParallelForTransform(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001A53 RID: 6739
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Void_Int32_TransformAccess_0;
	}
}
