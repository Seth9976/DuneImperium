using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.Remoting.Activation;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting.Contexts
{
	// Token: 0x020002B9 RID: 697
	public class Context : Object
	{
		// Token: 0x06002C72 RID: 11378 RVA: 0x000E91DC File Offset: 0x000E73DC
		// Note: this type is marked as 'beforefieldinit'.
		static Context()
		{
			Il2CppClassPointerStore<Context>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Contexts", "Context");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Context>.NativeClassPtr);
			Context.NativeFieldInfoPtr_domain_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "domain_id");
			Context.NativeFieldInfoPtr_context_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "context_id");
			Context.NativeFieldInfoPtr_static_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "static_data");
			Context.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "data");
			Context.NativeFieldInfoPtr_local_slots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "local_slots");
			Context.NativeFieldInfoPtr_default_server_context_sink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "default_server_context_sink");
			Context.NativeFieldInfoPtr_server_context_sink_chain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "server_context_sink_chain");
			Context.NativeFieldInfoPtr_client_context_sink_chain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "client_context_sink_chain");
			Context.NativeFieldInfoPtr_context_properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "context_properties");
			Context.NativeFieldInfoPtr_global_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "global_count");
			Context.NativeFieldInfoPtr__localDataStore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "_localDataStore");
			Context.NativeFieldInfoPtr__localDataStoreMgr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "_localDataStoreMgr");
			Context.NativeFieldInfoPtr_global_dynamic_properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "global_dynamic_properties");
			Context.NativeFieldInfoPtr_context_dynamic_properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "context_dynamic_properties");
			Context.NativeFieldInfoPtr_callback_object = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "callback_object");
			Context.NativeMethodInfoPtr_RegisterContext_Private_Static_Void_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100670461);
			Context.NativeMethodInfoPtr_ReleaseContext_Private_Static_Void_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100670462);
			Context.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100670463);
			Context.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100670464);
			Context.NativeMethodInfoPtr_get_DefaultContext_Public_Static_get_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100670465);
			Context.NativeMethodInfoPtr_get_ContextID_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100670466);
			Context.NativeMethodInfoPtr_get_ContextProperties_Public_Virtual_New_get_Il2CppReferenceArray_1_IContextProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100670467);
			Context.NativeMethodInfoPtr_get_IsDefaultContext_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100670468);
			Context.NativeMethodInfoPtr_get_NeedsContextSink_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100670469);
			Context.NativeMethodInfoPtr_RegisterDynamicProperty_Public_Static_Boolean_IDynamicProperty_ContextBoundObject_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100670470);
			Context.NativeMethodInfoPtr_UnregisterDynamicProperty_Public_Static_Boolean_String_ContextBoundObject_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100670471);
			Context.NativeMethodInfoPtr_GetDynamicPropertyCollection_Private_Static_DynamicPropertyCollection_ContextBoundObject_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100670472);
			Context.NativeMethodInfoPtr_NotifyGlobalDynamicSinks_Internal_Static_Void_Boolean_IMessage_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100670473);
			Context.NativeMethodInfoPtr_get_HasGlobalDynamicSinks_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100670474);
			Context.NativeMethodInfoPtr_NotifyDynamicSinks_Internal_Void_Boolean_IMessage_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100670475);
			Context.NativeMethodInfoPtr_get_HasDynamicSinks_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100670476);
			Context.NativeMethodInfoPtr_get_HasExitSinks_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100670477);
			Context.NativeMethodInfoPtr_GetProperty_Public_Virtual_New_IContextProperty_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100670478);
			Context.NativeMethodInfoPtr_SetProperty_Public_Virtual_New_Void_IContextProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100670479);
			Context.NativeMethodInfoPtr_Freeze_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100670480);
			Context.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100670481);
			Context.NativeMethodInfoPtr_GetServerContextSinkChain_Internal_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100670482);
			Context.NativeMethodInfoPtr_GetClientContextSinkChain_Internal_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100670483);
			Context.NativeMethodInfoPtr_CreateServerObjectSinkChain_Internal_IMessageSink_MarshalByRefObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100670484);
			Context.NativeMethodInfoPtr_CreateEnvoySink_Internal_IMessageSink_MarshalByRefObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100670485);
			Context.NativeMethodInfoPtr_SwitchToContext_Internal_Static_Context_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100670486);
			Context.NativeMethodInfoPtr_CreateNewContext_Internal_Static_Context_IConstructionCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100670487);
			Context.NativeMethodInfoPtr_DoCallBack_Public_Void_CrossContextDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100670488);
			Context.NativeMethodInfoPtr_get_MyLocalStore_Private_get_LocalDataStore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100670489);
			Context.NativeMethodInfoPtr_AllocateDataSlot_Public_Static_LocalDataStoreSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100670490);
			Context.NativeMethodInfoPtr_AllocateNamedDataSlot_Public_Static_LocalDataStoreSlot_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100670491);
			Context.NativeMethodInfoPtr_FreeNamedDataSlot_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100670492);
			Context.NativeMethodInfoPtr_GetNamedDataSlot_Public_Static_LocalDataStoreSlot_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100670493);
			Context.NativeMethodInfoPtr_GetData_Public_Static_Object_LocalDataStoreSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100670494);
			Context.NativeMethodInfoPtr_SetData_Public_Static_Void_LocalDataStoreSlot_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Context>.NativeClassPtr, 100670495);
		}

		// Token: 0x06002C73 RID: 11379 RVA: 0x000E95F4 File Offset: 0x000E77F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380405, XrefRangeEnd = 1380406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterContext(Context ctx)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctx);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_RegisterContext_Private_Static_Void_Context_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C74 RID: 11380 RVA: 0x000E962C File Offset: 0x000E782C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380406, XrefRangeEnd = 1380407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleaseContext(Context ctx)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctx);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_ReleaseContext_Private_Static_Void_Context_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C75 RID: 11381 RVA: 0x000E9664 File Offset: 0x000E7864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380407, XrefRangeEnd = 1380415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Context()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Context>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C76 RID: 11382 RVA: 0x000E96A0 File Offset: 0x000E78A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380415, XrefRangeEnd = 1380422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Context.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x06002C77 RID: 11383 RVA: 0x000E96DC File Offset: 0x000E78DC
		public unsafe static Context DefaultContext
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 1356071, RefRangeEnd = 1356091, XrefRangeStart = 1356071, XrefRangeEnd = 1356091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_get_DefaultContext_Public_Static_get_Context_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Context>(intPtr3) : null;
			}
		}

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x06002C78 RID: 11384 RVA: 0x000E9710 File Offset: 0x000E7910
		public unsafe virtual int ContextID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Context.NativeMethodInfoPtr_get_ContextID_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x06002C79 RID: 11385 RVA: 0x000E9758 File Offset: 0x000E7958
		public unsafe virtual Il2CppReferenceArray<IContextProperty> ContextProperties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380422, XrefRangeEnd = 1380428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Context.NativeMethodInfoPtr_get_ContextProperties_Public_Virtual_New_get_Il2CppReferenceArray_1_IContextProperty_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IContextProperty>>(intPtr3) : null;
			}
		}

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x06002C7A RID: 11386 RVA: 0x000E97A4 File Offset: 0x000E79A4
		public unsafe bool IsDefaultContext
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_get_IsDefaultContext_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x06002C7B RID: 11387 RVA: 0x000E97E0 File Offset: 0x000E79E0
		public unsafe bool NeedsContextSink
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380428, XrefRangeEnd = 1380434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_get_NeedsContextSink_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C7C RID: 11388 RVA: 0x000E981C File Offset: 0x000E7A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380434, XrefRangeEnd = 1380480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RegisterDynamicProperty(IDynamicProperty prop, ContextBoundObject obj, Context ctx)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prop);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ctx);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_RegisterDynamicProperty_Public_Static_Boolean_IDynamicProperty_ContextBoundObject_Context_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C7D RID: 11389 RVA: 0x000E9884 File Offset: 0x000E7A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380480, XrefRangeEnd = 1380534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UnregisterDynamicProperty(string name, ContextBoundObject obj, Context ctx)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ctx);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_UnregisterDynamicProperty_Public_Static_Boolean_String_ContextBoundObject_Context_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C7E RID: 11390 RVA: 0x000E98EC File Offset: 0x000E7AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380534, XrefRangeEnd = 1380551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynamicPropertyCollection GetDynamicPropertyCollection(ContextBoundObject obj, Context ctx)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ctx);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_GetDynamicPropertyCollection_Private_Static_DynamicPropertyCollection_ContextBoundObject_Context_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicPropertyCollection>(intPtr3) : null;
		}

		// Token: 0x06002C7F RID: 11391 RVA: 0x000E9944 File Offset: 0x000E7B44
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1380561, RefRangeEnd = 1380571, XrefRangeStart = 1380551, XrefRangeEnd = 1380561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NotifyGlobalDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(req_msg);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref client_site;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref async;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_NotifyGlobalDynamicSinks_Internal_Static_Void_Boolean_IMessage_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x06002C80 RID: 11392 RVA: 0x000E99A4 File Offset: 0x000E7BA4
		public unsafe static bool HasGlobalDynamicSinks
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1380575, RefRangeEnd = 1380577, XrefRangeStart = 1380571, XrefRangeEnd = 1380575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_get_HasGlobalDynamicSinks_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C81 RID: 11393 RVA: 0x000E99D4 File Offset: 0x000E7BD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1380578, RefRangeEnd = 1380580, XrefRangeStart = 1380577, XrefRangeEnd = 1380578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(req_msg);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref client_site;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref async;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_NotifyDynamicSinks_Internal_Void_Boolean_IMessage_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x06002C82 RID: 11394 RVA: 0x000E9A40 File Offset: 0x000E7C40
		public unsafe bool HasDynamicSinks
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_get_HasDynamicSinks_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x06002C83 RID: 11395 RVA: 0x000E9A7C File Offset: 0x000E7C7C
		public unsafe bool HasExitSinks
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1380584, RefRangeEnd = 1380585, XrefRangeStart = 1380580, XrefRangeEnd = 1380584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_get_HasExitSinks_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C84 RID: 11396 RVA: 0x000E9AB8 File Offset: 0x000E7CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380585, XrefRangeEnd = 1380599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IContextProperty GetProperty(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Context.NativeMethodInfoPtr_GetProperty_Public_Virtual_New_IContextProperty_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IContextProperty>(intPtr3) : null;
			}
		}

		// Token: 0x06002C85 RID: 11397 RVA: 0x000E9B14 File Offset: 0x000E7D14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380599, XrefRangeEnd = 1380628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetProperty(IContextProperty prop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prop);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Context.NativeMethodInfoPtr_SetProperty_Public_Virtual_New_Void_IContextProperty_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C86 RID: 11398 RVA: 0x000E9B64 File Offset: 0x000E7D64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380628, XrefRangeEnd = 1380646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Freeze()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Context.NativeMethodInfoPtr_Freeze_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C87 RID: 11399 RVA: 0x000E9BA0 File Offset: 0x000E7DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380646, XrefRangeEnd = 1380650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Context.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002C88 RID: 11400 RVA: 0x000E9BE4 File Offset: 0x000E7DE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1380677, RefRangeEnd = 1380679, XrefRangeStart = 1380650, XrefRangeEnd = 1380677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IMessageSink GetServerContextSinkChain()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_GetServerContextSinkChain_Internal_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr3) : null;
		}

		// Token: 0x06002C89 RID: 11401 RVA: 0x000E9C24 File Offset: 0x000E7E24
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1380705, RefRangeEnd = 1380709, XrefRangeStart = 1380679, XrefRangeEnd = 1380705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IMessageSink GetClientContextSinkChain()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_GetClientContextSinkChain_Internal_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr3) : null;
		}

		// Token: 0x06002C8A RID: 11402 RVA: 0x000E9C64 File Offset: 0x000E7E64
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1380741, RefRangeEnd = 1380747, XrefRangeStart = 1380709, XrefRangeEnd = 1380741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IMessageSink CreateServerObjectSinkChain(MarshalByRefObject obj, bool forceInternalExecute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceInternalExecute;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_CreateServerObjectSinkChain_Internal_IMessageSink_MarshalByRefObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr3) : null;
		}

		// Token: 0x06002C8B RID: 11403 RVA: 0x000E9CC4 File Offset: 0x000E7EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380747, XrefRangeEnd = 1380770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IMessageSink CreateEnvoySink(MarshalByRefObject serverObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serverObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_CreateEnvoySink_Internal_IMessageSink_MarshalByRefObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr3) : null;
			}
		}

		// Token: 0x06002C8C RID: 11404 RVA: 0x000E9D14 File Offset: 0x000E7F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380770, XrefRangeEnd = 1380771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Context SwitchToContext(Context newContext)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_SwitchToContext_Internal_Static_Context_Context_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Context>(intPtr3) : null;
			}
		}

		// Token: 0x06002C8D RID: 11405 RVA: 0x000E9D58 File Offset: 0x000E7F58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1380834, RefRangeEnd = 1380835, XrefRangeStart = 1380771, XrefRangeEnd = 1380834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Context CreateNewContext(IConstructionCallMessage msg)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_CreateNewContext_Internal_Static_Context_IConstructionCallMessage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Context>(intPtr3) : null;
			}
		}

		// Token: 0x06002C8E RID: 11406 RVA: 0x000E9D9C File Offset: 0x000E7F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380835, XrefRangeEnd = 1380849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoCallBack(CrossContextDelegate deleg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(deleg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_DoCallBack_Public_Void_CrossContextDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x06002C8F RID: 11407 RVA: 0x000E9DE0 File Offset: 0x000E7FE0
		public unsafe LocalDataStore MyLocalStore
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1380866, RefRangeEnd = 1380868, XrefRangeStart = 1380849, XrefRangeEnd = 1380866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_get_MyLocalStore_Private_get_LocalDataStore_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalDataStore>(intPtr3) : null;
			}
		}

		// Token: 0x06002C90 RID: 11408 RVA: 0x000E9E20 File Offset: 0x000E8020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380868, XrefRangeEnd = 1380874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LocalDataStoreSlot AllocateDataSlot()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_AllocateDataSlot_Public_Static_LocalDataStoreSlot_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalDataStoreSlot>(intPtr3) : null;
		}

		// Token: 0x06002C91 RID: 11409 RVA: 0x000E9E54 File Offset: 0x000E8054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380874, XrefRangeEnd = 1380880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LocalDataStoreSlot AllocateNamedDataSlot(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_AllocateNamedDataSlot_Public_Static_LocalDataStoreSlot_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalDataStoreSlot>(intPtr3) : null;
			}
		}

		// Token: 0x06002C92 RID: 11410 RVA: 0x000E9E98 File Offset: 0x000E8098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380880, XrefRangeEnd = 1380886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FreeNamedDataSlot(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_FreeNamedDataSlot_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C93 RID: 11411 RVA: 0x000E9ED0 File Offset: 0x000E80D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380886, XrefRangeEnd = 1380892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LocalDataStoreSlot GetNamedDataSlot(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_GetNamedDataSlot_Public_Static_LocalDataStoreSlot_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalDataStoreSlot>(intPtr3) : null;
			}
		}

		// Token: 0x06002C94 RID: 11412 RVA: 0x000E9F14 File Offset: 0x000E8114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380892, XrefRangeEnd = 1380896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object GetData(LocalDataStoreSlot slot)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_GetData_Public_Static_Object_LocalDataStoreSlot_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002C95 RID: 11413 RVA: 0x000E9F58 File Offset: 0x000E8158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380896, XrefRangeEnd = 1380900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetData(LocalDataStoreSlot slot, Object data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Context.NativeMethodInfoPtr_SetData_Public_Static_Void_LocalDataStoreSlot_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C96 RID: 11414 RVA: 0x0000EDD7 File Offset: 0x0000CFD7
		public Context(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x06002C97 RID: 11415 RVA: 0x000E9FA0 File Offset: 0x000E81A0
		// (set) Token: 0x06002C98 RID: 11416 RVA: 0x0000EDE0 File Offset: 0x0000CFE0
		public unsafe int domain_id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_domain_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_domain_id)) = value;
			}
		}

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x06002C99 RID: 11417 RVA: 0x000E9FC8 File Offset: 0x000E81C8
		// (set) Token: 0x06002C9A RID: 11418 RVA: 0x0000EDFB File Offset: 0x0000CFFB
		public unsafe int context_id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_context_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_context_id)) = value;
			}
		}

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x06002C9B RID: 11419 RVA: 0x000E9FF0 File Offset: 0x000E81F0
		// (set) Token: 0x06002C9C RID: 11420 RVA: 0x0000EE16 File Offset: 0x0000D016
		public unsafe UIntPtr static_data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_static_data);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_static_data)) = value;
			}
		}

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x06002C9D RID: 11421 RVA: 0x000EA018 File Offset: 0x000E8218
		// (set) Token: 0x06002C9E RID: 11422 RVA: 0x0000EE31 File Offset: 0x0000D031
		public unsafe UIntPtr data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_data);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_data)) = value;
			}
		}

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x06002C9F RID: 11423 RVA: 0x000EA040 File Offset: 0x000E8240
		// (set) Token: 0x06002CA0 RID: 11424 RVA: 0x0000EE4C File Offset: 0x0000D04C
		public unsafe static Il2CppReferenceArray<Object> local_slots
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Context.NativeFieldInfoPtr_local_slots, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Context.NativeFieldInfoPtr_local_slots, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x06002CA1 RID: 11425 RVA: 0x000EA068 File Offset: 0x000E8268
		// (set) Token: 0x06002CA2 RID: 11426 RVA: 0x0000EE5E File Offset: 0x0000D05E
		public unsafe static IMessageSink default_server_context_sink
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Context.NativeFieldInfoPtr_default_server_context_sink, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Context.NativeFieldInfoPtr_default_server_context_sink, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x06002CA3 RID: 11427 RVA: 0x000EA090 File Offset: 0x000E8290
		// (set) Token: 0x06002CA4 RID: 11428 RVA: 0x0000EE70 File Offset: 0x0000D070
		public unsafe IMessageSink server_context_sink_chain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_server_context_sink_chain);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_server_context_sink_chain), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x06002CA5 RID: 11429 RVA: 0x000EA0C0 File Offset: 0x000E82C0
		// (set) Token: 0x06002CA6 RID: 11430 RVA: 0x0000EE8F File Offset: 0x0000D08F
		public unsafe IMessageSink client_context_sink_chain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_client_context_sink_chain);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_client_context_sink_chain), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x06002CA7 RID: 11431 RVA: 0x000EA0F0 File Offset: 0x000E82F0
		// (set) Token: 0x06002CA8 RID: 11432 RVA: 0x0000EEAE File Offset: 0x0000D0AE
		public unsafe List<IContextProperty> context_properties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_context_properties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IContextProperty>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_context_properties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x06002CA9 RID: 11433 RVA: 0x000EA120 File Offset: 0x000E8320
		// (set) Token: 0x06002CAA RID: 11434 RVA: 0x0000EECD File Offset: 0x0000D0CD
		public unsafe static int global_count
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Context.NativeFieldInfoPtr_global_count, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Context.NativeFieldInfoPtr_global_count, (void*)(&value));
			}
		}

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x06002CAB RID: 11435 RVA: 0x000EA13C File Offset: 0x000E833C
		// (set) Token: 0x06002CAC RID: 11436 RVA: 0x0000EEDB File Offset: 0x0000D0DB
		public unsafe LocalDataStoreHolder _localDataStore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr__localDataStore);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalDataStoreHolder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr__localDataStore), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x06002CAD RID: 11437 RVA: 0x000EA16C File Offset: 0x000E836C
		// (set) Token: 0x06002CAE RID: 11438 RVA: 0x0000EEFA File Offset: 0x0000D0FA
		public unsafe static LocalDataStoreMgr _localDataStoreMgr
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Context.NativeFieldInfoPtr__localDataStoreMgr, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalDataStoreMgr>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Context.NativeFieldInfoPtr__localDataStoreMgr, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x06002CAF RID: 11439 RVA: 0x000EA194 File Offset: 0x000E8394
		// (set) Token: 0x06002CB0 RID: 11440 RVA: 0x0000EF0C File Offset: 0x0000D10C
		public unsafe static DynamicPropertyCollection global_dynamic_properties
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Context.NativeFieldInfoPtr_global_dynamic_properties, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicPropertyCollection>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Context.NativeFieldInfoPtr_global_dynamic_properties, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x06002CB1 RID: 11441 RVA: 0x000EA1BC File Offset: 0x000E83BC
		// (set) Token: 0x06002CB2 RID: 11442 RVA: 0x0000EF1E File Offset: 0x0000D11E
		public unsafe DynamicPropertyCollection context_dynamic_properties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_context_dynamic_properties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicPropertyCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_context_dynamic_properties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x06002CB3 RID: 11443 RVA: 0x000EA1EC File Offset: 0x000E83EC
		// (set) Token: 0x06002CB4 RID: 11444 RVA: 0x0000EF3D File Offset: 0x0000D13D
		public unsafe ContextCallbackObject callback_object
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_callback_object);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextCallbackObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Context.NativeFieldInfoPtr_callback_object), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400257C RID: 9596
		private static readonly IntPtr NativeFieldInfoPtr_domain_id;

		// Token: 0x0400257D RID: 9597
		private static readonly IntPtr NativeFieldInfoPtr_context_id;

		// Token: 0x0400257E RID: 9598
		private static readonly IntPtr NativeFieldInfoPtr_static_data;

		// Token: 0x0400257F RID: 9599
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x04002580 RID: 9600
		private static readonly IntPtr NativeFieldInfoPtr_local_slots;

		// Token: 0x04002581 RID: 9601
		private static readonly IntPtr NativeFieldInfoPtr_default_server_context_sink;

		// Token: 0x04002582 RID: 9602
		private static readonly IntPtr NativeFieldInfoPtr_server_context_sink_chain;

		// Token: 0x04002583 RID: 9603
		private static readonly IntPtr NativeFieldInfoPtr_client_context_sink_chain;

		// Token: 0x04002584 RID: 9604
		private static readonly IntPtr NativeFieldInfoPtr_context_properties;

		// Token: 0x04002585 RID: 9605
		private static readonly IntPtr NativeFieldInfoPtr_global_count;

		// Token: 0x04002586 RID: 9606
		private static readonly IntPtr NativeFieldInfoPtr__localDataStore;

		// Token: 0x04002587 RID: 9607
		private static readonly IntPtr NativeFieldInfoPtr__localDataStoreMgr;

		// Token: 0x04002588 RID: 9608
		private static readonly IntPtr NativeFieldInfoPtr_global_dynamic_properties;

		// Token: 0x04002589 RID: 9609
		private static readonly IntPtr NativeFieldInfoPtr_context_dynamic_properties;

		// Token: 0x0400258A RID: 9610
		private static readonly IntPtr NativeFieldInfoPtr_callback_object;

		// Token: 0x0400258B RID: 9611
		private static readonly IntPtr NativeMethodInfoPtr_RegisterContext_Private_Static_Void_Context_0;

		// Token: 0x0400258C RID: 9612
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseContext_Private_Static_Void_Context_0;

		// Token: 0x0400258D RID: 9613
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400258E RID: 9614
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x0400258F RID: 9615
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultContext_Public_Static_get_Context_0;

		// Token: 0x04002590 RID: 9616
		private static readonly IntPtr NativeMethodInfoPtr_get_ContextID_Public_Virtual_New_get_Int32_0;

		// Token: 0x04002591 RID: 9617
		private static readonly IntPtr NativeMethodInfoPtr_get_ContextProperties_Public_Virtual_New_get_Il2CppReferenceArray_1_IContextProperty_0;

		// Token: 0x04002592 RID: 9618
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDefaultContext_Internal_get_Boolean_0;

		// Token: 0x04002593 RID: 9619
		private static readonly IntPtr NativeMethodInfoPtr_get_NeedsContextSink_Internal_get_Boolean_0;

		// Token: 0x04002594 RID: 9620
		private static readonly IntPtr NativeMethodInfoPtr_RegisterDynamicProperty_Public_Static_Boolean_IDynamicProperty_ContextBoundObject_Context_0;

		// Token: 0x04002595 RID: 9621
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterDynamicProperty_Public_Static_Boolean_String_ContextBoundObject_Context_0;

		// Token: 0x04002596 RID: 9622
		private static readonly IntPtr NativeMethodInfoPtr_GetDynamicPropertyCollection_Private_Static_DynamicPropertyCollection_ContextBoundObject_Context_0;

		// Token: 0x04002597 RID: 9623
		private static readonly IntPtr NativeMethodInfoPtr_NotifyGlobalDynamicSinks_Internal_Static_Void_Boolean_IMessage_Boolean_Boolean_0;

		// Token: 0x04002598 RID: 9624
		private static readonly IntPtr NativeMethodInfoPtr_get_HasGlobalDynamicSinks_Internal_Static_get_Boolean_0;

		// Token: 0x04002599 RID: 9625
		private static readonly IntPtr NativeMethodInfoPtr_NotifyDynamicSinks_Internal_Void_Boolean_IMessage_Boolean_Boolean_0;

		// Token: 0x0400259A RID: 9626
		private static readonly IntPtr NativeMethodInfoPtr_get_HasDynamicSinks_Internal_get_Boolean_0;

		// Token: 0x0400259B RID: 9627
		private static readonly IntPtr NativeMethodInfoPtr_get_HasExitSinks_Internal_get_Boolean_0;

		// Token: 0x0400259C RID: 9628
		private static readonly IntPtr NativeMethodInfoPtr_GetProperty_Public_Virtual_New_IContextProperty_String_0;

		// Token: 0x0400259D RID: 9629
		private static readonly IntPtr NativeMethodInfoPtr_SetProperty_Public_Virtual_New_Void_IContextProperty_0;

		// Token: 0x0400259E RID: 9630
		private static readonly IntPtr NativeMethodInfoPtr_Freeze_Public_Virtual_New_Void_0;

		// Token: 0x0400259F RID: 9631
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040025A0 RID: 9632
		private static readonly IntPtr NativeMethodInfoPtr_GetServerContextSinkChain_Internal_IMessageSink_0;

		// Token: 0x040025A1 RID: 9633
		private static readonly IntPtr NativeMethodInfoPtr_GetClientContextSinkChain_Internal_IMessageSink_0;

		// Token: 0x040025A2 RID: 9634
		private static readonly IntPtr NativeMethodInfoPtr_CreateServerObjectSinkChain_Internal_IMessageSink_MarshalByRefObject_Boolean_0;

		// Token: 0x040025A3 RID: 9635
		private static readonly IntPtr NativeMethodInfoPtr_CreateEnvoySink_Internal_IMessageSink_MarshalByRefObject_0;

		// Token: 0x040025A4 RID: 9636
		private static readonly IntPtr NativeMethodInfoPtr_SwitchToContext_Internal_Static_Context_Context_0;

		// Token: 0x040025A5 RID: 9637
		private static readonly IntPtr NativeMethodInfoPtr_CreateNewContext_Internal_Static_Context_IConstructionCallMessage_0;

		// Token: 0x040025A6 RID: 9638
		private static readonly IntPtr NativeMethodInfoPtr_DoCallBack_Public_Void_CrossContextDelegate_0;

		// Token: 0x040025A7 RID: 9639
		private static readonly IntPtr NativeMethodInfoPtr_get_MyLocalStore_Private_get_LocalDataStore_0;

		// Token: 0x040025A8 RID: 9640
		private static readonly IntPtr NativeMethodInfoPtr_AllocateDataSlot_Public_Static_LocalDataStoreSlot_0;

		// Token: 0x040025A9 RID: 9641
		private static readonly IntPtr NativeMethodInfoPtr_AllocateNamedDataSlot_Public_Static_LocalDataStoreSlot_String_0;

		// Token: 0x040025AA RID: 9642
		private static readonly IntPtr NativeMethodInfoPtr_FreeNamedDataSlot_Public_Static_Void_String_0;

		// Token: 0x040025AB RID: 9643
		private static readonly IntPtr NativeMethodInfoPtr_GetNamedDataSlot_Public_Static_LocalDataStoreSlot_String_0;

		// Token: 0x040025AC RID: 9644
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_Static_Object_LocalDataStoreSlot_0;

		// Token: 0x040025AD RID: 9645
		private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Static_Void_LocalDataStoreSlot_Object_0;
	}
}
