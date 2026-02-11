using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.ResourceManagement
{
	// Token: 0x0200000B RID: 11
	public class IUpdateReceiver : Il2CppObjectBase
	{
		// Token: 0x06000103 RID: 259 RVA: 0x00002719 File Offset: 0x00000919
		// Note: this type is marked as 'beforefieldinit'.
		static IUpdateReceiver()
		{
			Il2CppClassPointerStore<IUpdateReceiver>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement", "IUpdateReceiver");
			IUpdateReceiver.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUpdateReceiver>.NativeClassPtr, 100663462);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00009180 File Offset: 0x00007380
		[CallerCount(0)]
		public unsafe virtual void Update(float unscaledDeltaTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unscaledDeltaTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUpdateReceiver.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002748 File Offset: 0x00000948
		public IUpdateReceiver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_Single_0;
	}
}
