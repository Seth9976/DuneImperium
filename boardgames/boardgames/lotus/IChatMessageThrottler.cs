using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace lotus
{
	// Token: 0x020000BB RID: 187
	public class IChatMessageThrottler : Il2CppObjectBase
	{
		// Token: 0x0600095D RID: 2397 RVA: 0x0002EBEC File Offset: 0x0002CDEC
		// Note: this type is marked as 'beforefieldinit'.
		static IChatMessageThrottler()
		{
			Il2CppClassPointerStore<IChatMessageThrottler>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus", "IChatMessageThrottler");
			IChatMessageThrottler.NativeMethodInfoPtr_IsMessageDelayed_Public_Abstract_Virtual_New_Boolean_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IChatMessageThrottler>.NativeClassPtr, 100664769);
			IChatMessageThrottler.NativeMethodInfoPtr_IsMessageBlocked_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IChatMessageThrottler>.NativeClassPtr, 100664770);
			IChatMessageThrottler.NativeMethodInfoPtr_RecordSentMessage_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IChatMessageThrottler>.NativeClassPtr, 100664771);
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x0002EC50 File Offset: 0x0002CE50
		[CallerCount(0)]
		public unsafe virtual bool IsMessageDelayed(out float delay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &delay;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IChatMessageThrottler.NativeMethodInfoPtr_IsMessageDelayed_Public_Abstract_Virtual_New_Boolean_byref_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x0002ECA4 File Offset: 0x0002CEA4
		[CallerCount(0)]
		public unsafe virtual bool IsMessageBlocked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IChatMessageThrottler.NativeMethodInfoPtr_IsMessageBlocked_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x0002ECEC File Offset: 0x0002CEEC
		[CallerCount(0)]
		public unsafe virtual void RecordSentMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IChatMessageThrottler.NativeMethodInfoPtr_RecordSentMessage_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x000064B2 File Offset: 0x000046B2
		public IChatMessageThrottler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040005C0 RID: 1472
		private static readonly IntPtr NativeMethodInfoPtr_IsMessageDelayed_Public_Abstract_Virtual_New_Boolean_byref_Single_0;

		// Token: 0x040005C1 RID: 1473
		private static readonly IntPtr NativeMethodInfoPtr_IsMessageBlocked_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x040005C2 RID: 1474
		private static readonly IntPtr NativeMethodInfoPtr_RecordSentMessage_Public_Abstract_Virtual_New_Void_0;
	}
}
