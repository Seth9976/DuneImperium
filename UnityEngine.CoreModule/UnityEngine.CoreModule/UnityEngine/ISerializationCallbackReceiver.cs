using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine
{
	// Token: 0x02000164 RID: 356
	public class ISerializationCallbackReceiver : Il2CppObjectBase
	{
		// Token: 0x06001A0D RID: 6669 RVA: 0x0007A5B0 File Offset: 0x000787B0
		// Note: this type is marked as 'beforefieldinit'.
		static ISerializationCallbackReceiver()
		{
			Il2CppClassPointerStore<ISerializationCallbackReceiver>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ISerializationCallbackReceiver");
			ISerializationCallbackReceiver.NativeMethodInfoPtr_OnBeforeSerialize_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISerializationCallbackReceiver>.NativeClassPtr, 100666921);
			ISerializationCallbackReceiver.NativeMethodInfoPtr_OnAfterDeserialize_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISerializationCallbackReceiver>.NativeClassPtr, 100666922);
		}

		// Token: 0x06001A0E RID: 6670 RVA: 0x0007A600 File Offset: 0x00078800
		[CallerCount(0)]
		public unsafe virtual void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISerializationCallbackReceiver.NativeMethodInfoPtr_OnBeforeSerialize_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A0F RID: 6671 RVA: 0x0007A63C File Offset: 0x0007883C
		[CallerCount(0)]
		public unsafe virtual void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISerializationCallbackReceiver.NativeMethodInfoPtr_OnAfterDeserialize_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A10 RID: 6672 RVA: 0x0000A15C File Offset: 0x0000835C
		public ISerializationCallbackReceiver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001728 RID: 5928
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04001729 RID: 5929
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Abstract_Virtual_New_Void_0;
	}
}
