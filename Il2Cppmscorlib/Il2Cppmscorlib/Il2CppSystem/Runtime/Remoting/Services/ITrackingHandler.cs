using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.Remoting.Services
{
	// Token: 0x020002AC RID: 684
	public class ITrackingHandler : Il2CppObjectBase
	{
		// Token: 0x06002BCC RID: 11212 RVA: 0x000E6C30 File Offset: 0x000E4E30
		// Note: this type is marked as 'beforefieldinit'.
		static ITrackingHandler()
		{
			Il2CppClassPointerStore<ITrackingHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Services", "ITrackingHandler");
			ITrackingHandler.NativeMethodInfoPtr_DisconnectedObject_Public_Abstract_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITrackingHandler>.NativeClassPtr, 100670378);
			ITrackingHandler.NativeMethodInfoPtr_MarshaledObject_Public_Abstract_Virtual_New_Void_Object_ObjRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITrackingHandler>.NativeClassPtr, 100670379);
			ITrackingHandler.NativeMethodInfoPtr_UnmarshaledObject_Public_Abstract_Virtual_New_Void_Object_ObjRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITrackingHandler>.NativeClassPtr, 100670380);
		}

		// Token: 0x06002BCD RID: 11213 RVA: 0x000E6C94 File Offset: 0x000E4E94
		[CallerCount(0)]
		public unsafe virtual void DisconnectedObject(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITrackingHandler.NativeMethodInfoPtr_DisconnectedObject_Public_Abstract_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BCE RID: 11214 RVA: 0x000E6CE4 File Offset: 0x000E4EE4
		[CallerCount(0)]
		public unsafe virtual void MarshaledObject(Object obj, ObjRef or)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(or);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITrackingHandler.NativeMethodInfoPtr_MarshaledObject_Public_Abstract_Virtual_New_Void_Object_ObjRef_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BCF RID: 11215 RVA: 0x000E6D44 File Offset: 0x000E4F44
		[CallerCount(0)]
		public unsafe virtual void UnmarshaledObject(Object obj, ObjRef or)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(or);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITrackingHandler.NativeMethodInfoPtr_UnmarshaledObject_Public_Abstract_Virtual_New_Void_Object_ObjRef_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BD0 RID: 11216 RVA: 0x0000E9D9 File Offset: 0x0000CBD9
		public ITrackingHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002509 RID: 9481
		private static readonly IntPtr NativeMethodInfoPtr_DisconnectedObject_Public_Abstract_Virtual_New_Void_Object_0;

		// Token: 0x0400250A RID: 9482
		private static readonly IntPtr NativeMethodInfoPtr_MarshaledObject_Public_Abstract_Virtual_New_Void_Object_ObjRef_0;

		// Token: 0x0400250B RID: 9483
		private static readonly IntPtr NativeMethodInfoPtr_UnmarshaledObject_Public_Abstract_Virtual_New_Void_Object_ObjRef_0;
	}
}
