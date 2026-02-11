using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine
{
	// Token: 0x02000008 RID: 8
	public class ISubsystemDescriptor : Il2CppObjectBase
	{
		// Token: 0x06000028 RID: 40 RVA: 0x00002155 File Offset: 0x00000355
		// Note: this type is marked as 'beforefieldinit'.
		static ISubsystemDescriptor()
		{
			Il2CppClassPointerStore<ISubsystemDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SubsystemsModule.dll", "UnityEngine", "ISubsystemDescriptor");
			ISubsystemDescriptor.NativeMethodInfoPtr_get_id_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISubsystemDescriptor>.NativeClassPtr, 100663307);
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00002C34 File Offset: 0x00000E34
		public unsafe virtual string id
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISubsystemDescriptor.NativeMethodInfoPtr_get_id_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002184 File Offset: 0x00000384
		public ISubsystemDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_Abstract_Virtual_New_get_String_0;
	}
}
