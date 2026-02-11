using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000314 RID: 788
	public class IDeserializationCallback : Il2CppObjectBase
	{
		// Token: 0x0600307A RID: 12410 RVA: 0x00010A21 File Offset: 0x0000EC21
		// Note: this type is marked as 'beforefieldinit'.
		static IDeserializationCallback()
		{
			Il2CppClassPointerStore<IDeserializationCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "IDeserializationCallback");
			IDeserializationCallback.NativeMethodInfoPtr_OnDeserialization_Public_Abstract_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDeserializationCallback>.NativeClassPtr, 100670946);
		}

		// Token: 0x0600307B RID: 12411 RVA: 0x000F7724 File Offset: 0x000F5924
		[CallerCount(0)]
		public unsafe virtual void OnDeserialization(Object sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDeserializationCallback.NativeMethodInfoPtr_OnDeserialization_Public_Abstract_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600307C RID: 12412 RVA: 0x00010A50 File Offset: 0x0000EC50
		public IDeserializationCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002811 RID: 10257
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialization_Public_Abstract_Virtual_New_Void_Object_0;
	}
}
