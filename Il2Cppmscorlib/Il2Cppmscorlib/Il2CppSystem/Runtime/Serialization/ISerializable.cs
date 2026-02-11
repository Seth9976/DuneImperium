using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000317 RID: 791
	public class ISerializable : Il2CppObjectBase
	{
		// Token: 0x06003088 RID: 12424 RVA: 0x00010A9A File Offset: 0x0000EC9A
		// Note: this type is marked as 'beforefieldinit'.
		static ISerializable()
		{
			Il2CppClassPointerStore<ISerializable>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "ISerializable");
			ISerializable.NativeMethodInfoPtr_GetObjectData_Public_Abstract_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISerializable>.NativeClassPtr, 100670954);
		}

		// Token: 0x06003089 RID: 12425 RVA: 0x000F7A98 File Offset: 0x000F5C98
		[CallerCount(0)]
		public unsafe virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISerializable.NativeMethodInfoPtr_GetObjectData_Public_Abstract_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600308A RID: 12426 RVA: 0x00010AC9 File Offset: 0x0000ECC9
		public ISerializable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002819 RID: 10265
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Abstract_Virtual_New_Void_SerializationInfo_StreamingContext_0;
	}
}
