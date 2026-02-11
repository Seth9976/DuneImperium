using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Security.Principal;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020002E6 RID: 742
	[Serializable]
	public class CallContextSecurityData : Object
	{
		// Token: 0x06002E0B RID: 11787 RVA: 0x000EE964 File Offset: 0x000ECB64
		// Note: this type is marked as 'beforefieldinit'.
		static CallContextSecurityData()
		{
			Il2CppClassPointerStore<CallContextSecurityData>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "CallContextSecurityData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallContextSecurityData>.NativeClassPtr);
			CallContextSecurityData.NativeFieldInfoPtr__principal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallContextSecurityData>.NativeClassPtr, "_principal");
			CallContextSecurityData.NativeMethodInfoPtr_get_HasInfo_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallContextSecurityData>.NativeClassPtr, 100670657);
			CallContextSecurityData.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallContextSecurityData>.NativeClassPtr, 100670658);
			CallContextSecurityData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallContextSecurityData>.NativeClassPtr, 100670659);
		}

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x06002E0C RID: 11788 RVA: 0x000EE9E4 File Offset: 0x000ECBE4
		public unsafe bool HasInfo
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 322834, RefRangeEnd = 322836, XrefRangeStart = 322834, XrefRangeEnd = 322836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallContextSecurityData.NativeMethodInfoPtr_get_HasInfo_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002E0D RID: 11789 RVA: 0x000EEA20 File Offset: 0x000ECC20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1382452, XrefRangeEnd = 1382457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallContextSecurityData.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002E0E RID: 11790 RVA: 0x000EEA60 File Offset: 0x000ECC60
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallContextSecurityData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallContextSecurityData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallContextSecurityData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E0F RID: 11791 RVA: 0x0000F8ED File Offset: 0x0000DAED
		public CallContextSecurityData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x06002E10 RID: 11792 RVA: 0x000EEA9C File Offset: 0x000ECC9C
		// (set) Token: 0x06002E11 RID: 11793 RVA: 0x0000F8F6 File Offset: 0x0000DAF6
		public unsafe IPrincipal _principal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallContextSecurityData.NativeFieldInfoPtr__principal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPrincipal>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallContextSecurityData.NativeFieldInfoPtr__principal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002675 RID: 9845
		private static readonly IntPtr NativeFieldInfoPtr__principal;

		// Token: 0x04002676 RID: 9846
		private static readonly IntPtr NativeMethodInfoPtr_get_HasInfo_Internal_get_Boolean_0;

		// Token: 0x04002677 RID: 9847
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

		// Token: 0x04002678 RID: 9848
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
