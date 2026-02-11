using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x0200031E RID: 798
	public class ISerializationSurrogate : Il2CppObjectBase
	{
		// Token: 0x060030CD RID: 12493 RVA: 0x000F8894 File Offset: 0x000F6A94
		// Note: this type is marked as 'beforefieldinit'.
		static ISerializationSurrogate()
		{
			Il2CppClassPointerStore<ISerializationSurrogate>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "ISerializationSurrogate");
			ISerializationSurrogate.NativeMethodInfoPtr_GetObjectData_Public_Abstract_Virtual_New_Void_Object_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISerializationSurrogate>.NativeClassPtr, 100670983);
			ISerializationSurrogate.NativeMethodInfoPtr_SetObjectData_Public_Abstract_Virtual_New_Object_Object_SerializationInfo_StreamingContext_ISurrogateSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISerializationSurrogate>.NativeClassPtr, 100670984);
		}

		// Token: 0x060030CE RID: 12494 RVA: 0x000F88E4 File Offset: 0x000F6AE4
		[CallerCount(0)]
		public unsafe virtual void GetObjectData(Object obj, SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISerializationSurrogate.NativeMethodInfoPtr_GetObjectData_Public_Abstract_Virtual_New_Void_Object_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030CF RID: 12495 RVA: 0x000F895C File Offset: 0x000F6B5C
		[CallerCount(0)]
		public unsafe virtual Object SetObjectData(Object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISerializationSurrogate.NativeMethodInfoPtr_SetObjectData_Public_Abstract_Virtual_New_Object_Object_SerializationInfo_StreamingContext_ISurrogateSelector_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060030D0 RID: 12496 RVA: 0x00010C85 File Offset: 0x0000EE85
		public ISerializationSurrogate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400283F RID: 10303
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Abstract_Virtual_New_Void_Object_SerializationInfo_StreamingContext_0;

		// Token: 0x04002840 RID: 10304
		private static readonly IntPtr NativeMethodInfoPtr_SetObjectData_Public_Abstract_Virtual_New_Object_Object_SerializationInfo_StreamingContext_ISurrogateSelector_0;
	}
}
