using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace dwd.core.loader.caching
{
	// Token: 0x0200018D RID: 397
	public class IReferenceTracker : Il2CppObjectBase
	{
		// Token: 0x06001653 RID: 5715 RVA: 0x0006D900 File Offset: 0x0006BB00
		// Note: this type is marked as 'beforefieldinit'.
		static IReferenceTracker()
		{
			Il2CppClassPointerStore<IReferenceTracker>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.loader.caching", "IReferenceTracker");
			IReferenceTracker.NativeMethodInfoPtr_GetSourceName_Public_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IReferenceTracker>.NativeClassPtr, 100666713);
			IReferenceTracker.NativeMethodInfoPtr_StillAlive_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IReferenceTracker>.NativeClassPtr, 100666714);
			IReferenceTracker.NativeMethodInfoPtr_Kill_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IReferenceTracker>.NativeClassPtr, 100666715);
		}

		// Token: 0x06001654 RID: 5716 RVA: 0x0006D964 File Offset: 0x0006BB64
		[CallerCount(0)]
		public unsafe virtual string GetSourceName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IReferenceTracker.NativeMethodInfoPtr_GetSourceName_Public_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x0006D9A8 File Offset: 0x0006BBA8
		[CallerCount(0)]
		public unsafe virtual bool StillAlive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IReferenceTracker.NativeMethodInfoPtr_StillAlive_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x0006D9F0 File Offset: 0x0006BBF0
		[CallerCount(0)]
		public unsafe virtual void Kill()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IReferenceTracker.NativeMethodInfoPtr_Kill_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001657 RID: 5719 RVA: 0x00009C4E File Offset: 0x00007E4E
		public IReferenceTracker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000FD5 RID: 4053
		private static readonly IntPtr NativeMethodInfoPtr_GetSourceName_Public_Abstract_Virtual_New_String_0;

		// Token: 0x04000FD6 RID: 4054
		private static readonly IntPtr NativeMethodInfoPtr_StillAlive_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04000FD7 RID: 4055
		private static readonly IntPtr NativeMethodInfoPtr_Kill_Public_Abstract_Virtual_New_Void_0;
	}
}
