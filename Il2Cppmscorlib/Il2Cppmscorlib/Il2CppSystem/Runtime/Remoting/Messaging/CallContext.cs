using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020002E3 RID: 739
	[Serializable]
	public sealed class CallContext : Object
	{
		// Token: 0x06002DD9 RID: 11737 RVA: 0x000EDE64 File Offset: 0x000EC064
		// Note: this type is marked as 'beforefieldinit'.
		static CallContext()
		{
			Il2CppClassPointerStore<CallContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "CallContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallContext>.NativeClassPtr);
			CallContext.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallContext>.NativeClassPtr, 100670629);
			CallContext.NativeMethodInfoPtr_SetCurrentCallContext_Internal_Static_Object_LogicalCallContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallContext>.NativeClassPtr, 100670630);
			CallContext.NativeMethodInfoPtr_SetLogicalCallContext_Internal_Static_LogicalCallContext_LogicalCallContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallContext>.NativeClassPtr, 100670631);
			CallContext.NativeMethodInfoPtr_LogicalGetData_Public_Static_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallContext>.NativeClassPtr, 100670632);
			CallContext.NativeMethodInfoPtr_LogicalSetData_Public_Static_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallContext>.NativeClassPtr, 100670633);
		}

		// Token: 0x06002DDA RID: 11738 RVA: 0x000EDEF8 File Offset: 0x000EC0F8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallContext()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallContext>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallContext.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DDB RID: 11739 RVA: 0x000EDF34 File Offset: 0x000EC134
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object SetCurrentCallContext(LogicalCallContext ctx)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctx);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallContext.NativeMethodInfoPtr_SetCurrentCallContext_Internal_Static_Object_LogicalCallContext_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002DDC RID: 11740 RVA: 0x000EDF78 File Offset: 0x000EC178
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1382191, RefRangeEnd = 1382193, XrefRangeStart = 1382187, XrefRangeEnd = 1382191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LogicalCallContext SetLogicalCallContext(LogicalCallContext callCtx)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callCtx);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallContext.NativeMethodInfoPtr_SetLogicalCallContext_Internal_Static_LogicalCallContext_LogicalCallContext_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LogicalCallContext>(intPtr3) : null;
			}
		}

		// Token: 0x06002DDD RID: 11741 RVA: 0x000EDFBC File Offset: 0x000EC1BC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1382196, RefRangeEnd = 1382200, XrefRangeStart = 1382193, XrefRangeEnd = 1382196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object LogicalGetData(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallContext.NativeMethodInfoPtr_LogicalGetData_Public_Static_Object_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002DDE RID: 11742 RVA: 0x000EE000 File Offset: 0x000EC200
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1382217, RefRangeEnd = 1382221, XrefRangeStart = 1382200, XrefRangeEnd = 1382217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogicalSetData(string name, Object data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallContext.NativeMethodInfoPtr_LogicalSetData_Public_Static_Void_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DDF RID: 11743 RVA: 0x0000F79B File Offset: 0x0000D99B
		public CallContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002654 RID: 9812
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04002655 RID: 9813
		private static readonly IntPtr NativeMethodInfoPtr_SetCurrentCallContext_Internal_Static_Object_LogicalCallContext_0;

		// Token: 0x04002656 RID: 9814
		private static readonly IntPtr NativeMethodInfoPtr_SetLogicalCallContext_Internal_Static_LogicalCallContext_LogicalCallContext_0;

		// Token: 0x04002657 RID: 9815
		private static readonly IntPtr NativeMethodInfoPtr_LogicalGetData_Public_Static_Object_String_0;

		// Token: 0x04002658 RID: 9816
		private static readonly IntPtr NativeMethodInfoPtr_LogicalSetData_Public_Static_Void_String_Object_0;
	}
}
