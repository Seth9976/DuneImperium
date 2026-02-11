using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020002E4 RID: 740
	public class IllogicalCallContext : Object
	{
		// Token: 0x06002DE0 RID: 11744 RVA: 0x000EE048 File Offset: 0x000EC248
		// Note: this type is marked as 'beforefieldinit'.
		static IllogicalCallContext()
		{
			Il2CppClassPointerStore<IllogicalCallContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "IllogicalCallContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IllogicalCallContext>.NativeClassPtr);
			IllogicalCallContext.NativeFieldInfoPtr_m_Datastore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IllogicalCallContext>.NativeClassPtr, "m_Datastore");
			IllogicalCallContext.NativeFieldInfoPtr_m_HostContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IllogicalCallContext>.NativeClassPtr, "m_HostContext");
			IllogicalCallContext.NativeMethodInfoPtr_get_Datastore_Private_get_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IllogicalCallContext>.NativeClassPtr, 100670634);
			IllogicalCallContext.NativeMethodInfoPtr_get_HostContext_Internal_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IllogicalCallContext>.NativeClassPtr, 100670635);
			IllogicalCallContext.NativeMethodInfoPtr_set_HostContext_Internal_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IllogicalCallContext>.NativeClassPtr, 100670636);
			IllogicalCallContext.NativeMethodInfoPtr_get_HasUserData_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IllogicalCallContext>.NativeClassPtr, 100670637);
			IllogicalCallContext.NativeMethodInfoPtr_FreeNamedDataSlot_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IllogicalCallContext>.NativeClassPtr, 100670638);
			IllogicalCallContext.NativeMethodInfoPtr_CreateCopy_Public_IllogicalCallContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IllogicalCallContext>.NativeClassPtr, 100670639);
			IllogicalCallContext.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IllogicalCallContext>.NativeClassPtr, 100670640);
		}

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x06002DE1 RID: 11745 RVA: 0x000EE12C File Offset: 0x000EC32C
		public unsafe Hashtable Datastore
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1382221, XrefRangeEnd = 1382226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IllogicalCallContext.NativeMethodInfoPtr_get_Datastore_Private_get_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr3) : null;
			}
		}

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x06002DE2 RID: 11746 RVA: 0x000EE16C File Offset: 0x000EC36C
		// (set) Token: 0x06002DE3 RID: 11747 RVA: 0x000EE1AC File Offset: 0x000EC3AC
		public unsafe Object HostContext
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IllogicalCallContext.NativeMethodInfoPtr_get_HostContext_Internal_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IllogicalCallContext.NativeMethodInfoPtr_set_HostContext_Internal_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x06002DE4 RID: 11748 RVA: 0x000EE1F0 File Offset: 0x000EC3F0
		public unsafe bool HasUserData
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1382226, RefRangeEnd = 1382228, XrefRangeStart = 1382226, XrefRangeEnd = 1382226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IllogicalCallContext.NativeMethodInfoPtr_get_HasUserData_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002DE5 RID: 11749 RVA: 0x000EE22C File Offset: 0x000EC42C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1382228, XrefRangeEnd = 1382234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FreeNamedDataSlot(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IllogicalCallContext.NativeMethodInfoPtr_FreeNamedDataSlot_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002DE6 RID: 11750 RVA: 0x000EE270 File Offset: 0x000EC470
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1382258, RefRangeEnd = 1382259, XrefRangeStart = 1382234, XrefRangeEnd = 1382258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IllogicalCallContext CreateCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IllogicalCallContext.NativeMethodInfoPtr_CreateCopy_Public_IllogicalCallContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IllogicalCallContext>(intPtr3) : null;
		}

		// Token: 0x06002DE7 RID: 11751 RVA: 0x000EE2B0 File Offset: 0x000EC4B0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IllogicalCallContext()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IllogicalCallContext>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IllogicalCallContext.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DE8 RID: 11752 RVA: 0x0000F7A4 File Offset: 0x0000D9A4
		public IllogicalCallContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x06002DE9 RID: 11753 RVA: 0x000EE2EC File Offset: 0x000EC4EC
		// (set) Token: 0x06002DEA RID: 11754 RVA: 0x0000F7AD File Offset: 0x0000D9AD
		public unsafe Hashtable m_Datastore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IllogicalCallContext.NativeFieldInfoPtr_m_Datastore);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IllogicalCallContext.NativeFieldInfoPtr_m_Datastore), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x06002DEB RID: 11755 RVA: 0x000EE31C File Offset: 0x000EC51C
		// (set) Token: 0x06002DEC RID: 11756 RVA: 0x0000F7CC File Offset: 0x0000D9CC
		public unsafe Object m_HostContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IllogicalCallContext.NativeFieldInfoPtr_m_HostContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IllogicalCallContext.NativeFieldInfoPtr_m_HostContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002659 RID: 9817
		private static readonly IntPtr NativeFieldInfoPtr_m_Datastore;

		// Token: 0x0400265A RID: 9818
		private static readonly IntPtr NativeFieldInfoPtr_m_HostContext;

		// Token: 0x0400265B RID: 9819
		private static readonly IntPtr NativeMethodInfoPtr_get_Datastore_Private_get_Hashtable_0;

		// Token: 0x0400265C RID: 9820
		private static readonly IntPtr NativeMethodInfoPtr_get_HostContext_Internal_get_Object_0;

		// Token: 0x0400265D RID: 9821
		private static readonly IntPtr NativeMethodInfoPtr_set_HostContext_Internal_set_Void_Object_0;

		// Token: 0x0400265E RID: 9822
		private static readonly IntPtr NativeMethodInfoPtr_get_HasUserData_Internal_get_Boolean_0;

		// Token: 0x0400265F RID: 9823
		private static readonly IntPtr NativeMethodInfoPtr_FreeNamedDataSlot_Public_Void_String_0;

		// Token: 0x04002660 RID: 9824
		private static readonly IntPtr NativeMethodInfoPtr_CreateCopy_Public_IllogicalCallContext_0;

		// Token: 0x04002661 RID: 9825
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
