using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020002E7 RID: 743
	[Serializable]
	public class CallContextRemotingData : Object
	{
		// Token: 0x06002E12 RID: 11794 RVA: 0x000EEACC File Offset: 0x000ECCCC
		// Note: this type is marked as 'beforefieldinit'.
		static CallContextRemotingData()
		{
			Il2CppClassPointerStore<CallContextRemotingData>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "CallContextRemotingData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallContextRemotingData>.NativeClassPtr);
			CallContextRemotingData.NativeFieldInfoPtr__logicalCallID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallContextRemotingData>.NativeClassPtr, "_logicalCallID");
			CallContextRemotingData.NativeMethodInfoPtr_get_LogicalCallID_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallContextRemotingData>.NativeClassPtr, 100670660);
			CallContextRemotingData.NativeMethodInfoPtr_set_LogicalCallID_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallContextRemotingData>.NativeClassPtr, 100670661);
			CallContextRemotingData.NativeMethodInfoPtr_get_HasInfo_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallContextRemotingData>.NativeClassPtr, 100670662);
			CallContextRemotingData.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallContextRemotingData>.NativeClassPtr, 100670663);
			CallContextRemotingData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallContextRemotingData>.NativeClassPtr, 100670664);
		}

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x06002E13 RID: 11795 RVA: 0x000EEB74 File Offset: 0x000ECD74
		// (set) Token: 0x06002E14 RID: 11796 RVA: 0x000EEBAC File Offset: 0x000ECDAC
		public unsafe string LogicalCallID
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallContextRemotingData.NativeMethodInfoPtr_get_LogicalCallID_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallContextRemotingData.NativeMethodInfoPtr_set_LogicalCallID_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x06002E15 RID: 11797 RVA: 0x000EEBF0 File Offset: 0x000ECDF0
		public unsafe bool HasInfo
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 322834, RefRangeEnd = 322836, XrefRangeStart = 322834, XrefRangeEnd = 322836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallContextRemotingData.NativeMethodInfoPtr_get_HasInfo_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002E16 RID: 11798 RVA: 0x000EEC2C File Offset: 0x000ECE2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1382457, XrefRangeEnd = 1382462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallContextRemotingData.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002E17 RID: 11799 RVA: 0x000EEC6C File Offset: 0x000ECE6C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallContextRemotingData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallContextRemotingData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallContextRemotingData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E18 RID: 11800 RVA: 0x0000F915 File Offset: 0x0000DB15
		public CallContextRemotingData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x06002E19 RID: 11801 RVA: 0x000EECA8 File Offset: 0x000ECEA8
		// (set) Token: 0x06002E1A RID: 11802 RVA: 0x0000F91E File Offset: 0x0000DB1E
		public unsafe string _logicalCallID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallContextRemotingData.NativeFieldInfoPtr__logicalCallID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallContextRemotingData.NativeFieldInfoPtr__logicalCallID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002679 RID: 9849
		private static readonly IntPtr NativeFieldInfoPtr__logicalCallID;

		// Token: 0x0400267A RID: 9850
		private static readonly IntPtr NativeMethodInfoPtr_get_LogicalCallID_Internal_get_String_0;

		// Token: 0x0400267B RID: 9851
		private static readonly IntPtr NativeMethodInfoPtr_set_LogicalCallID_Internal_set_Void_String_0;

		// Token: 0x0400267C RID: 9852
		private static readonly IntPtr NativeMethodInfoPtr_get_HasInfo_Internal_get_Boolean_0;

		// Token: 0x0400267D RID: 9853
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

		// Token: 0x0400267E RID: 9854
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
