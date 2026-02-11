using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000332 RID: 818
	public class ISafeSerializationData : Il2CppObjectBase
	{
		// Token: 0x0600320E RID: 12814 RVA: 0x000114B1 File Offset: 0x0000F6B1
		// Note: this type is marked as 'beforefieldinit'.
		static ISafeSerializationData()
		{
			Il2CppClassPointerStore<ISafeSerializationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "ISafeSerializationData");
			ISafeSerializationData.NativeMethodInfoPtr_CompleteDeserialization_Public_Abstract_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISafeSerializationData>.NativeClassPtr, 100671144);
		}

		// Token: 0x0600320F RID: 12815 RVA: 0x000FD71C File Offset: 0x000FB91C
		[CallerCount(0)]
		public unsafe virtual void CompleteDeserialization(Object deserialized)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(deserialized);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISafeSerializationData.NativeMethodInfoPtr_CompleteDeserialization_Public_Abstract_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003210 RID: 12816 RVA: 0x000114E0 File Offset: 0x0000F6E0
		public ISafeSerializationData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002918 RID: 10520
		private static readonly IntPtr NativeMethodInfoPtr_CompleteDeserialization_Public_Abstract_Virtual_New_Void_Object_0;
	}
}
