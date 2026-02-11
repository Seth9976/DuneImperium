using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020002E5 RID: 741
	[Serializable]
	public sealed class LogicalCallContext : Object
	{
		// Token: 0x06002DED RID: 11757 RVA: 0x000EE34C File Offset: 0x000EC54C
		// Note: this type is marked as 'beforefieldinit'.
		static LogicalCallContext()
		{
			Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "LogicalCallContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr);
			LogicalCallContext.NativeFieldInfoPtr_s_callContextType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, "s_callContextType");
			LogicalCallContext.NativeFieldInfoPtr_s_CorrelationMgrSlotName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, "s_CorrelationMgrSlotName");
			LogicalCallContext.NativeFieldInfoPtr_m_Datastore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, "m_Datastore");
			LogicalCallContext.NativeFieldInfoPtr_m_RemotingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, "m_RemotingData");
			LogicalCallContext.NativeFieldInfoPtr_m_SecurityData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, "m_SecurityData");
			LogicalCallContext.NativeFieldInfoPtr_m_HostContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, "m_HostContext");
			LogicalCallContext.NativeFieldInfoPtr_m_IsCorrelationMgr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, "m_IsCorrelationMgr");
			LogicalCallContext.NativeFieldInfoPtr__sendHeaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, "_sendHeaders");
			LogicalCallContext.NativeFieldInfoPtr__recvHeaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, "_recvHeaders");
			LogicalCallContext.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, 100670641);
			LogicalCallContext.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, 100670642);
			LogicalCallContext.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, 100670643);
			LogicalCallContext.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, 100670644);
			LogicalCallContext.NativeMethodInfoPtr_Merge_Internal_Void_LogicalCallContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, 100670645);
			LogicalCallContext.NativeMethodInfoPtr_get_HasInfo_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, 100670646);
			LogicalCallContext.NativeMethodInfoPtr_get_HasUserData_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, 100670647);
			LogicalCallContext.NativeMethodInfoPtr_get_Datastore_Private_get_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, 100670648);
			LogicalCallContext.NativeMethodInfoPtr_GetData_Public_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, 100670649);
			LogicalCallContext.NativeMethodInfoPtr_SetData_Public_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, 100670650);
		}

		// Token: 0x06002DEE RID: 11758 RVA: 0x000EE4F8 File Offset: 0x000EC6F8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LogicalCallContext()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogicalCallContext.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DEF RID: 11759 RVA: 0x000EE534 File Offset: 0x000EC734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1382263, XrefRangeEnd = 1382300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LogicalCallContext(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogicalCallContext.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DF0 RID: 11760 RVA: 0x000EE598 File Offset: 0x000EC798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1382300, XrefRangeEnd = 1382332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetObjectData(SerializationInfo info, StreamingContext context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogicalCallContext.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DF1 RID: 11761 RVA: 0x000EE5F4 File Offset: 0x000EC7F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1382400, RefRangeEnd = 1382403, XrefRangeStart = 1382332, XrefRangeEnd = 1382400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogicalCallContext.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002DF2 RID: 11762 RVA: 0x000EE634 File Offset: 0x000EC834
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1382423, RefRangeEnd = 1382425, XrefRangeStart = 1382403, XrefRangeEnd = 1382423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Merge(LogicalCallContext lc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogicalCallContext.NativeMethodInfoPtr_Merge_Internal_Void_LogicalCallContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x06002DF3 RID: 11763 RVA: 0x000EE678 File Offset: 0x000EC878
		public unsafe bool HasInfo
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1382425, RefRangeEnd = 1382429, XrefRangeStart = 1382425, XrefRangeEnd = 1382425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogicalCallContext.NativeMethodInfoPtr_get_HasInfo_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x06002DF4 RID: 11764 RVA: 0x000EE6B4 File Offset: 0x000EC8B4
		public unsafe bool HasUserData
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1382226, RefRangeEnd = 1382228, XrefRangeStart = 1382226, XrefRangeEnd = 1382228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogicalCallContext.NativeMethodInfoPtr_get_HasUserData_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x06002DF5 RID: 11765 RVA: 0x000EE6F0 File Offset: 0x000EC8F0
		public unsafe Hashtable Datastore
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1382434, RefRangeEnd = 1382438, XrefRangeStart = 1382429, XrefRangeEnd = 1382434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogicalCallContext.NativeMethodInfoPtr_get_Datastore_Private_get_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr3) : null;
			}
		}

		// Token: 0x06002DF6 RID: 11766 RVA: 0x000EE730 File Offset: 0x000EC930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1382438, XrefRangeEnd = 1382444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetData(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogicalCallContext.NativeMethodInfoPtr_GetData_Public_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002DF7 RID: 11767 RVA: 0x000EE780 File Offset: 0x000EC980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1382444, XrefRangeEnd = 1382452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetData(string name, Object data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogicalCallContext.NativeMethodInfoPtr_SetData_Public_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DF8 RID: 11768 RVA: 0x0000F7EB File Offset: 0x0000D9EB
		public LogicalCallContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x06002DF9 RID: 11769 RVA: 0x000EE7D4 File Offset: 0x000EC9D4
		// (set) Token: 0x06002DFA RID: 11770 RVA: 0x0000F7F4 File Offset: 0x0000D9F4
		public unsafe static Type s_callContextType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LogicalCallContext.NativeFieldInfoPtr_s_callContextType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LogicalCallContext.NativeFieldInfoPtr_s_callContextType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x06002DFB RID: 11771 RVA: 0x000EE7FC File Offset: 0x000EC9FC
		// (set) Token: 0x06002DFC RID: 11772 RVA: 0x0000F806 File Offset: 0x0000DA06
		public unsafe static string s_CorrelationMgrSlotName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LogicalCallContext.NativeFieldInfoPtr_s_CorrelationMgrSlotName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LogicalCallContext.NativeFieldInfoPtr_s_CorrelationMgrSlotName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x06002DFD RID: 11773 RVA: 0x000EE81C File Offset: 0x000ECA1C
		// (set) Token: 0x06002DFE RID: 11774 RVA: 0x0000F818 File Offset: 0x0000DA18
		public unsafe Hashtable m_Datastore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogicalCallContext.NativeFieldInfoPtr_m_Datastore);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogicalCallContext.NativeFieldInfoPtr_m_Datastore), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x06002DFF RID: 11775 RVA: 0x000EE84C File Offset: 0x000ECA4C
		// (set) Token: 0x06002E00 RID: 11776 RVA: 0x0000F837 File Offset: 0x0000DA37
		public unsafe CallContextRemotingData m_RemotingData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogicalCallContext.NativeFieldInfoPtr_m_RemotingData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallContextRemotingData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogicalCallContext.NativeFieldInfoPtr_m_RemotingData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x06002E01 RID: 11777 RVA: 0x000EE87C File Offset: 0x000ECA7C
		// (set) Token: 0x06002E02 RID: 11778 RVA: 0x0000F856 File Offset: 0x0000DA56
		public unsafe CallContextSecurityData m_SecurityData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogicalCallContext.NativeFieldInfoPtr_m_SecurityData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallContextSecurityData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogicalCallContext.NativeFieldInfoPtr_m_SecurityData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x06002E03 RID: 11779 RVA: 0x000EE8AC File Offset: 0x000ECAAC
		// (set) Token: 0x06002E04 RID: 11780 RVA: 0x0000F875 File Offset: 0x0000DA75
		public unsafe Object m_HostContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogicalCallContext.NativeFieldInfoPtr_m_HostContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogicalCallContext.NativeFieldInfoPtr_m_HostContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x06002E05 RID: 11781 RVA: 0x000EE8DC File Offset: 0x000ECADC
		// (set) Token: 0x06002E06 RID: 11782 RVA: 0x0000F894 File Offset: 0x0000DA94
		public unsafe bool m_IsCorrelationMgr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogicalCallContext.NativeFieldInfoPtr_m_IsCorrelationMgr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogicalCallContext.NativeFieldInfoPtr_m_IsCorrelationMgr)) = value;
			}
		}

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x06002E07 RID: 11783 RVA: 0x000EE904 File Offset: 0x000ECB04
		// (set) Token: 0x06002E08 RID: 11784 RVA: 0x0000F8AF File Offset: 0x0000DAAF
		public unsafe Il2CppReferenceArray<Header> _sendHeaders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogicalCallContext.NativeFieldInfoPtr__sendHeaders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Header>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogicalCallContext.NativeFieldInfoPtr__sendHeaders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x06002E09 RID: 11785 RVA: 0x000EE934 File Offset: 0x000ECB34
		// (set) Token: 0x06002E0A RID: 11786 RVA: 0x0000F8CE File Offset: 0x0000DACE
		public unsafe Il2CppReferenceArray<Header> _recvHeaders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogicalCallContext.NativeFieldInfoPtr__recvHeaders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Header>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogicalCallContext.NativeFieldInfoPtr__recvHeaders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002662 RID: 9826
		private static readonly IntPtr NativeFieldInfoPtr_s_callContextType;

		// Token: 0x04002663 RID: 9827
		private static readonly IntPtr NativeFieldInfoPtr_s_CorrelationMgrSlotName;

		// Token: 0x04002664 RID: 9828
		private static readonly IntPtr NativeFieldInfoPtr_m_Datastore;

		// Token: 0x04002665 RID: 9829
		private static readonly IntPtr NativeFieldInfoPtr_m_RemotingData;

		// Token: 0x04002666 RID: 9830
		private static readonly IntPtr NativeFieldInfoPtr_m_SecurityData;

		// Token: 0x04002667 RID: 9831
		private static readonly IntPtr NativeFieldInfoPtr_m_HostContext;

		// Token: 0x04002668 RID: 9832
		private static readonly IntPtr NativeFieldInfoPtr_m_IsCorrelationMgr;

		// Token: 0x04002669 RID: 9833
		private static readonly IntPtr NativeFieldInfoPtr__sendHeaders;

		// Token: 0x0400266A RID: 9834
		private static readonly IntPtr NativeFieldInfoPtr__recvHeaders;

		// Token: 0x0400266B RID: 9835
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x0400266C RID: 9836
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400266D RID: 9837
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400266E RID: 9838
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

		// Token: 0x0400266F RID: 9839
		private static readonly IntPtr NativeMethodInfoPtr_Merge_Internal_Void_LogicalCallContext_0;

		// Token: 0x04002670 RID: 9840
		private static readonly IntPtr NativeMethodInfoPtr_get_HasInfo_Public_get_Boolean_0;

		// Token: 0x04002671 RID: 9841
		private static readonly IntPtr NativeMethodInfoPtr_get_HasUserData_Private_get_Boolean_0;

		// Token: 0x04002672 RID: 9842
		private static readonly IntPtr NativeMethodInfoPtr_get_Datastore_Private_get_Hashtable_0;

		// Token: 0x04002673 RID: 9843
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_Object_String_0;

		// Token: 0x04002674 RID: 9844
		private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Void_String_Object_0;

		// Token: 0x0200066C RID: 1644
		public sealed class Reader : ValueType
		{
			// Token: 0x06005B47 RID: 23367 RVA: 0x0019F6C0 File Offset: 0x0019D8C0
			// Note: this type is marked as 'beforefieldinit'.
			static Reader()
			{
				Il2CppClassPointerStore<LogicalCallContext.Reader>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LogicalCallContext>.NativeClassPtr, "Reader");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogicalCallContext.Reader>.NativeClassPtr);
				LogicalCallContext.Reader.NativeFieldInfoPtr_m_ctx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogicalCallContext.Reader>.NativeClassPtr, "m_ctx");
				LogicalCallContext.Reader.NativeMethodInfoPtr__ctor_Public_Void_LogicalCallContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogicalCallContext.Reader>.NativeClassPtr, 100670652);
				LogicalCallContext.Reader.NativeMethodInfoPtr_get_IsNull_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogicalCallContext.Reader>.NativeClassPtr, 100670653);
				LogicalCallContext.Reader.NativeMethodInfoPtr_get_HasInfo_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogicalCallContext.Reader>.NativeClassPtr, 100670654);
				LogicalCallContext.Reader.NativeMethodInfoPtr_Clone_Public_LogicalCallContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogicalCallContext.Reader>.NativeClassPtr, 100670655);
				LogicalCallContext.Reader.NativeMethodInfoPtr_GetData_Public_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogicalCallContext.Reader>.NativeClassPtr, 100670656);
			}

			// Token: 0x06005B48 RID: 23368 RVA: 0x0019F764 File Offset: 0x0019D964
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Reader(LogicalCallContext ctx)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogicalCallContext.Reader>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctx);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogicalCallContext.Reader.NativeMethodInfoPtr__ctor_Public_Void_LogicalCallContext_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17001763 RID: 5987
			// (get) Token: 0x06005B49 RID: 23369 RVA: 0x0019F7B4 File Offset: 0x0019D9B4
			public unsafe bool IsNull
			{
				[CallerCount(13)]
				[CachedScanResults(RefRangeStart = 745863, RefRangeEnd = 745876, XrefRangeStart = 745863, XrefRangeEnd = 745876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogicalCallContext.Reader.NativeMethodInfoPtr_get_IsNull_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001764 RID: 5988
			// (get) Token: 0x06005B4A RID: 23370 RVA: 0x0019F7F8 File Offset: 0x0019D9F8
			public unsafe bool HasInfo
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogicalCallContext.Reader.NativeMethodInfoPtr_get_HasInfo_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005B4B RID: 23371 RVA: 0x0019F83C File Offset: 0x0019DA3C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1382262, RefRangeEnd = 1382263, XrefRangeStart = 1382259, XrefRangeEnd = 1382262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LogicalCallContext Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogicalCallContext.Reader.NativeMethodInfoPtr_Clone_Public_LogicalCallContext_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LogicalCallContext>(intPtr3) : null;
			}

			// Token: 0x06005B4C RID: 23372 RVA: 0x0019F880 File Offset: 0x0019DA80
			[CallerCount(0)]
			public unsafe Object GetData(string name)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogicalCallContext.Reader.NativeMethodInfoPtr_GetData_Public_Object_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005B4D RID: 23373 RVA: 0x0002115C File Offset: 0x0001F35C
			public Reader(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005B4E RID: 23374 RVA: 0x00021165 File Offset: 0x0001F365
			public Reader()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogicalCallContext.Reader>.NativeClassPtr))
			{
			}

			// Token: 0x17001762 RID: 5986
			// (get) Token: 0x06005B4F RID: 23375 RVA: 0x0019F8D8 File Offset: 0x0019DAD8
			// (set) Token: 0x06005B50 RID: 23376 RVA: 0x00021177 File Offset: 0x0001F377
			public unsafe LogicalCallContext m_ctx
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogicalCallContext.Reader.NativeFieldInfoPtr_m_ctx);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LogicalCallContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogicalCallContext.Reader.NativeFieldInfoPtr_m_ctx), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004A64 RID: 19044
			private static readonly IntPtr NativeFieldInfoPtr_m_ctx;

			// Token: 0x04004A65 RID: 19045
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LogicalCallContext_0;

			// Token: 0x04004A66 RID: 19046
			private static readonly IntPtr NativeMethodInfoPtr_get_IsNull_Public_get_Boolean_0;

			// Token: 0x04004A67 RID: 19047
			private static readonly IntPtr NativeMethodInfoPtr_get_HasInfo_Public_get_Boolean_0;

			// Token: 0x04004A68 RID: 19048
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_LogicalCallContext_0;

			// Token: 0x04004A69 RID: 19049
			private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_Object_String_0;
		}
	}
}
