using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x02000300 RID: 768
	public class IMethodReturnMessage : Il2CppObjectBase
	{
		// Token: 0x06002F2A RID: 12074 RVA: 0x000F2934 File Offset: 0x000F0B34
		// Note: this type is marked as 'beforefieldinit'.
		static IMethodReturnMessage()
		{
			Il2CppClassPointerStore<IMethodReturnMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "IMethodReturnMessage");
			IMethodReturnMessage.NativeMethodInfoPtr_get_Exception_Public_Abstract_Virtual_New_get_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMethodReturnMessage>.NativeClassPtr, 100670781);
			IMethodReturnMessage.NativeMethodInfoPtr_get_OutArgs_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMethodReturnMessage>.NativeClassPtr, 100670782);
			IMethodReturnMessage.NativeMethodInfoPtr_get_ReturnValue_Public_Abstract_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMethodReturnMessage>.NativeClassPtr, 100670783);
		}

		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x06002F2B RID: 12075 RVA: 0x000F2998 File Offset: 0x000F0B98
		public unsafe virtual Exception Exception
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMethodReturnMessage.NativeMethodInfoPtr_get_Exception_Public_Abstract_Virtual_New_get_Exception_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x06002F2C RID: 12076 RVA: 0x000F29E4 File Offset: 0x000F0BE4
		public unsafe virtual Il2CppReferenceArray<Object> OutArgs
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMethodReturnMessage.NativeMethodInfoPtr_get_OutArgs_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x06002F2D RID: 12077 RVA: 0x000F2A30 File Offset: 0x000F0C30
		public unsafe virtual Object ReturnValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMethodReturnMessage.NativeMethodInfoPtr_get_ReturnValue_Public_Abstract_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002F2E RID: 12078 RVA: 0x000100D8 File Offset: 0x0000E2D8
		public IMethodReturnMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400272A RID: 10026
		private static readonly IntPtr NativeMethodInfoPtr_get_Exception_Public_Abstract_Virtual_New_get_Exception_0;

		// Token: 0x0400272B RID: 10027
		private static readonly IntPtr NativeMethodInfoPtr_get_OutArgs_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400272C RID: 10028
		private static readonly IntPtr NativeMethodInfoPtr_get_ReturnValue_Public_Abstract_Virtual_New_get_Object_0;
	}
}
