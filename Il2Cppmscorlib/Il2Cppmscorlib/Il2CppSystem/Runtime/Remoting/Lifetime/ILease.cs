using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.Remoting.Lifetime
{
	// Token: 0x020002B2 RID: 690
	public class ILease : Il2CppObjectBase
	{
		// Token: 0x06002C24 RID: 11300 RVA: 0x000E8240 File Offset: 0x000E6440
		// Note: this type is marked as 'beforefieldinit'.
		static ILease()
		{
			Il2CppClassPointerStore<ILease>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Lifetime", "ILease");
			ILease.NativeMethodInfoPtr_get_CurrentLeaseTime_Public_Abstract_Virtual_New_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILease>.NativeClassPtr, 100670422);
			ILease.NativeMethodInfoPtr_get_CurrentState_Public_Abstract_Virtual_New_get_LeaseState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILease>.NativeClassPtr, 100670423);
			ILease.NativeMethodInfoPtr_get_RenewOnCallTime_Public_Abstract_Virtual_New_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILease>.NativeClassPtr, 100670424);
			ILease.NativeMethodInfoPtr_Renew_Public_Abstract_Virtual_New_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILease>.NativeClassPtr, 100670425);
		}

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x06002C25 RID: 11301 RVA: 0x000E82B8 File Offset: 0x000E64B8
		public unsafe virtual TimeSpan CurrentLeaseTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILease.NativeMethodInfoPtr_get_CurrentLeaseTime_Public_Abstract_Virtual_New_get_TimeSpan_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x06002C26 RID: 11302 RVA: 0x000E8300 File Offset: 0x000E6500
		public unsafe virtual LeaseState CurrentState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILease.NativeMethodInfoPtr_get_CurrentState_Public_Abstract_Virtual_New_get_LeaseState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x06002C27 RID: 11303 RVA: 0x000E8348 File Offset: 0x000E6548
		public unsafe virtual TimeSpan RenewOnCallTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILease.NativeMethodInfoPtr_get_RenewOnCallTime_Public_Abstract_Virtual_New_get_TimeSpan_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C28 RID: 11304 RVA: 0x000E8390 File Offset: 0x000E6590
		[CallerCount(0)]
		public unsafe virtual TimeSpan Renew(TimeSpan renewalTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref renewalTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILease.NativeMethodInfoPtr_Renew_Public_Abstract_Virtual_New_TimeSpan_TimeSpan_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C29 RID: 11305 RVA: 0x0000EBE7 File Offset: 0x0000CDE7
		public ILease(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002544 RID: 9540
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentLeaseTime_Public_Abstract_Virtual_New_get_TimeSpan_0;

		// Token: 0x04002545 RID: 9541
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentState_Public_Abstract_Virtual_New_get_LeaseState_0;

		// Token: 0x04002546 RID: 9542
		private static readonly IntPtr NativeMethodInfoPtr_get_RenewOnCallTime_Public_Abstract_Virtual_New_get_TimeSpan_0;

		// Token: 0x04002547 RID: 9543
		private static readonly IntPtr NativeMethodInfoPtr_Renew_Public_Abstract_Virtual_New_TimeSpan_TimeSpan_0;
	}
}
