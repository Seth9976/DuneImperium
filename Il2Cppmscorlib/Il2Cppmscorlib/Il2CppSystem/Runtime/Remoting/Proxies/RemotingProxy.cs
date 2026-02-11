using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting.Proxies
{
	// Token: 0x020002B1 RID: 689
	public class RemotingProxy : RealProxy
	{
		// Token: 0x06002C10 RID: 11280 RVA: 0x000E7DA0 File Offset: 0x000E5FA0
		// Note: this type is marked as 'beforefieldinit'.
		static RemotingProxy()
		{
			Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Proxies", "RemotingProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr);
			RemotingProxy.NativeFieldInfoPtr__cache_GetTypeMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr, "_cache_GetTypeMethod");
			RemotingProxy.NativeFieldInfoPtr__cache_GetHashCodeMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr, "_cache_GetHashCodeMethod");
			RemotingProxy.NativeFieldInfoPtr__sink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr, "_sink");
			RemotingProxy.NativeFieldInfoPtr__hasEnvoySink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr, "_hasEnvoySink");
			RemotingProxy.NativeFieldInfoPtr__ctorCall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr, "_ctorCall");
			RemotingProxy.NativeMethodInfoPtr__ctor_Internal_Void_Type_ClientIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr, 100670413);
			RemotingProxy.NativeMethodInfoPtr__ctor_Internal_Void_Type_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr, 100670414);
			RemotingProxy.NativeMethodInfoPtr_Invoke_Public_Virtual_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr, 100670415);
			RemotingProxy.NativeMethodInfoPtr_AttachIdentity_Internal_Void_Identity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr, 100670416);
			RemotingProxy.NativeMethodInfoPtr_ActivateRemoteObject_Internal_IMessage_IMethodMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr, 100670417);
			RemotingProxy.NativeMethodInfoPtr_get_TypeName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr, 100670418);
			RemotingProxy.NativeMethodInfoPtr_CanCastTo_Public_Virtual_Final_New_Boolean_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr, 100670419);
			RemotingProxy.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr, 100670420);
		}

		// Token: 0x06002C11 RID: 11281 RVA: 0x000E7ED4 File Offset: 0x000E60D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1379975, RefRangeEnd = 1379976, XrefRangeStart = 1379970, XrefRangeEnd = 1379975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RemotingProxy(Type type, ClientIdentity identity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(identity);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingProxy.NativeMethodInfoPtr__ctor_Internal_Void_Type_ClientIdentity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C12 RID: 11282 RVA: 0x000E7F34 File Offset: 0x000E6134
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1379979, RefRangeEnd = 1379981, XrefRangeStart = 1379976, XrefRangeEnd = 1379979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RemotingProxy(Type type, string activationUrl, Il2CppReferenceArray<Object> activationAttributes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemotingProxy>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(activationUrl);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(activationAttributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingProxy.NativeMethodInfoPtr__ctor_Internal_Void_Type_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C13 RID: 11283 RVA: 0x000E7FA4 File Offset: 0x000E61A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379981, XrefRangeEnd = 1380012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IMessage Invoke(IMessage request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RemotingProxy.NativeMethodInfoPtr_Invoke_Public_Virtual_IMessage_IMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06002C14 RID: 11284 RVA: 0x000E8000 File Offset: 0x000E6200
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1380039, RefRangeEnd = 1380041, XrefRangeStart = 1380012, XrefRangeEnd = 1380039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AttachIdentity(Identity identity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(identity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingProxy.NativeMethodInfoPtr_AttachIdentity_Internal_Void_Identity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C15 RID: 11285 RVA: 0x000E8044 File Offset: 0x000E6244
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1380051, RefRangeEnd = 1380052, XrefRangeStart = 1380041, XrefRangeEnd = 1380051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IMessage ActivateRemoteObject(IMethodMessage request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingProxy.NativeMethodInfoPtr_ActivateRemoteObject_Internal_IMessage_IMethodMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x06002C16 RID: 11286 RVA: 0x000E8094 File Offset: 0x000E6294
		public unsafe virtual string TypeName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380052, XrefRangeEnd = 1380059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingProxy.NativeMethodInfoPtr_get_TypeName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002C17 RID: 11287 RVA: 0x000E80CC File Offset: 0x000E62CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380059, XrefRangeEnd = 1380072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanCastTo(Type fromType, Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fromType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingProxy.NativeMethodInfoPtr_CanCastTo_Public_Virtual_Final_New_Boolean_Type_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C18 RID: 11288 RVA: 0x000E812C File Offset: 0x000E632C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380072, XrefRangeEnd = 1380081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RemotingProxy.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C19 RID: 11289 RVA: 0x0000EB61 File Offset: 0x0000CD61
		public RemotingProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x06002C1A RID: 11290 RVA: 0x000E8168 File Offset: 0x000E6368
		// (set) Token: 0x06002C1B RID: 11291 RVA: 0x0000EB6A File Offset: 0x0000CD6A
		public unsafe static MethodInfo _cache_GetTypeMethod
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingProxy.NativeFieldInfoPtr__cache_GetTypeMethod, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingProxy.NativeFieldInfoPtr__cache_GetTypeMethod, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x06002C1C RID: 11292 RVA: 0x000E8190 File Offset: 0x000E6390
		// (set) Token: 0x06002C1D RID: 11293 RVA: 0x0000EB7C File Offset: 0x0000CD7C
		public unsafe static MethodInfo _cache_GetHashCodeMethod
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingProxy.NativeFieldInfoPtr__cache_GetHashCodeMethod, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingProxy.NativeFieldInfoPtr__cache_GetHashCodeMethod, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x06002C1E RID: 11294 RVA: 0x000E81B8 File Offset: 0x000E63B8
		// (set) Token: 0x06002C1F RID: 11295 RVA: 0x0000EB8E File Offset: 0x0000CD8E
		public unsafe IMessageSink _sink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemotingProxy.NativeFieldInfoPtr__sink);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemotingProxy.NativeFieldInfoPtr__sink), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x06002C20 RID: 11296 RVA: 0x000E81E8 File Offset: 0x000E63E8
		// (set) Token: 0x06002C21 RID: 11297 RVA: 0x0000EBAD File Offset: 0x0000CDAD
		public unsafe bool _hasEnvoySink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemotingProxy.NativeFieldInfoPtr__hasEnvoySink);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemotingProxy.NativeFieldInfoPtr__hasEnvoySink)) = value;
			}
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x06002C22 RID: 11298 RVA: 0x000E8210 File Offset: 0x000E6410
		// (set) Token: 0x06002C23 RID: 11299 RVA: 0x0000EBC8 File Offset: 0x0000CDC8
		public unsafe ConstructionCall _ctorCall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemotingProxy.NativeFieldInfoPtr__ctorCall);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstructionCall>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemotingProxy.NativeFieldInfoPtr__ctorCall), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002537 RID: 9527
		private static readonly IntPtr NativeFieldInfoPtr__cache_GetTypeMethod;

		// Token: 0x04002538 RID: 9528
		private static readonly IntPtr NativeFieldInfoPtr__cache_GetHashCodeMethod;

		// Token: 0x04002539 RID: 9529
		private static readonly IntPtr NativeFieldInfoPtr__sink;

		// Token: 0x0400253A RID: 9530
		private static readonly IntPtr NativeFieldInfoPtr__hasEnvoySink;

		// Token: 0x0400253B RID: 9531
		private static readonly IntPtr NativeFieldInfoPtr__ctorCall;

		// Token: 0x0400253C RID: 9532
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Type_ClientIdentity_0;

		// Token: 0x0400253D RID: 9533
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Type_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400253E RID: 9534
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_IMessage_IMessage_0;

		// Token: 0x0400253F RID: 9535
		private static readonly IntPtr NativeMethodInfoPtr_AttachIdentity_Internal_Void_Identity_0;

		// Token: 0x04002540 RID: 9536
		private static readonly IntPtr NativeMethodInfoPtr_ActivateRemoteObject_Internal_IMessage_IMethodMessage_0;

		// Token: 0x04002541 RID: 9537
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04002542 RID: 9538
		private static readonly IntPtr NativeMethodInfoPtr_CanCastTo_Public_Virtual_Final_New_Boolean_Type_Object_0;

		// Token: 0x04002543 RID: 9539
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;
	}
}
