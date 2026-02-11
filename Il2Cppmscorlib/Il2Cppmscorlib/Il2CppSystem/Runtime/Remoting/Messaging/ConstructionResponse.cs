using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020002F5 RID: 757
	[Serializable]
	public class ConstructionResponse : MethodResponse
	{
		// Token: 0x06002EE1 RID: 12001 RVA: 0x000F18F0 File Offset: 0x000EFAF0
		// Note: this type is marked as 'beforefieldinit'.
		static ConstructionResponse()
		{
			Il2CppClassPointerStore<ConstructionResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "ConstructionResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructionResponse>.NativeClassPtr);
			ConstructionResponse.NativeMethodInfoPtr__ctor_Internal_Void_Object_LogicalCallContext_IMethodCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionResponse>.NativeClassPtr, 100670744);
			ConstructionResponse.NativeMethodInfoPtr__ctor_Internal_Void_Exception_IMethodCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionResponse>.NativeClassPtr, 100670745);
			ConstructionResponse.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionResponse>.NativeClassPtr, 100670746);
			ConstructionResponse.NativeMethodInfoPtr_get_Properties_Public_Virtual_get_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionResponse>.NativeClassPtr, 100670747);
		}

		// Token: 0x06002EE2 RID: 12002 RVA: 0x000F1970 File Offset: 0x000EFB70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1383272, XrefRangeEnd = 1383273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructionResponse(Object resultObject, LogicalCallContext callCtx, IMethodCallMessage msg)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructionResponse>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resultObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callCtx);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(msg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionResponse.NativeMethodInfoPtr__ctor_Internal_Void_Object_LogicalCallContext_IMethodCallMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EE3 RID: 12003 RVA: 0x000F19E0 File Offset: 0x000EFBE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1383273, XrefRangeEnd = 1383274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructionResponse(Exception e, IMethodCallMessage msg)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructionResponse>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(msg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionResponse.NativeMethodInfoPtr__ctor_Internal_Void_Exception_IMethodCallMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EE4 RID: 12004 RVA: 0x000F1A40 File Offset: 0x000EFC40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1383274, XrefRangeEnd = 1383280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructionResponse(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructionResponse>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionResponse.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x06002EE5 RID: 12005 RVA: 0x000F1AA4 File Offset: 0x000EFCA4
		public unsafe override IDictionary Properties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1383280, XrefRangeEnd = 1383287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructionResponse.NativeMethodInfoPtr_get_Properties_Public_Virtual_get_IDictionary_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary>(intPtr3) : null;
			}
		}

		// Token: 0x06002EE6 RID: 12006 RVA: 0x0000FF40 File Offset: 0x0000E140
		public ConstructionResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002700 RID: 9984
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Object_LogicalCallContext_IMethodCallMessage_0;

		// Token: 0x04002701 RID: 9985
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Exception_IMethodCallMessage_0;

		// Token: 0x04002702 RID: 9986
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04002703 RID: 9987
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Public_Virtual_get_IDictionary_0;
	}
}
