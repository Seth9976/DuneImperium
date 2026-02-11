using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020002F0 RID: 752
	public class CADMethodReturnMessage : CADMessageBase
	{
		// Token: 0x06002E9A RID: 11930 RVA: 0x000F07F8 File Offset: 0x000EE9F8
		// Note: this type is marked as 'beforefieldinit'.
		static CADMethodReturnMessage()
		{
			Il2CppClassPointerStore<CADMethodReturnMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "CADMethodReturnMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CADMethodReturnMessage>.NativeClassPtr);
			CADMethodReturnMessage.NativeFieldInfoPtr__returnValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMethodReturnMessage>.NativeClassPtr, "_returnValue");
			CADMethodReturnMessage.NativeFieldInfoPtr__exception = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMethodReturnMessage>.NativeClassPtr, "_exception");
			CADMethodReturnMessage.NativeFieldInfoPtr__sig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMethodReturnMessage>.NativeClassPtr, "_sig");
			CADMethodReturnMessage.NativeMethodInfoPtr_Create_Internal_Static_CADMethodReturnMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodReturnMessage>.NativeClassPtr, 100670710);
			CADMethodReturnMessage.NativeMethodInfoPtr__ctor_Internal_Void_IMethodReturnMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodReturnMessage>.NativeClassPtr, 100670711);
			CADMethodReturnMessage.NativeMethodInfoPtr_GetArguments_Internal_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodReturnMessage>.NativeClassPtr, 100670712);
			CADMethodReturnMessage.NativeMethodInfoPtr_GetArgs_Internal_Il2CppReferenceArray_1_Object_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodReturnMessage>.NativeClassPtr, 100670713);
			CADMethodReturnMessage.NativeMethodInfoPtr_GetReturnValue_Internal_Object_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodReturnMessage>.NativeClassPtr, 100670714);
			CADMethodReturnMessage.NativeMethodInfoPtr_GetException_Internal_Exception_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodReturnMessage>.NativeClassPtr, 100670715);
			CADMethodReturnMessage.NativeMethodInfoPtr_get_PropertiesCount_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodReturnMessage>.NativeClassPtr, 100670716);
		}

		// Token: 0x06002E9B RID: 11931 RVA: 0x000F08F0 File Offset: 0x000EEAF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1382883, RefRangeEnd = 1382884, XrefRangeStart = 1382876, XrefRangeEnd = 1382883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CADMethodReturnMessage Create(IMessage callMsg)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callMsg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMethodReturnMessage.NativeMethodInfoPtr_Create_Internal_Static_CADMethodReturnMessage_IMessage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CADMethodReturnMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06002E9C RID: 11932 RVA: 0x000F0934 File Offset: 0x000EEB34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1382918, RefRangeEnd = 1382919, XrefRangeStart = 1382884, XrefRangeEnd = 1382918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CADMethodReturnMessage(IMethodReturnMessage retMsg)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CADMethodReturnMessage>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(retMsg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMethodReturnMessage.NativeMethodInfoPtr__ctor_Internal_Void_IMethodReturnMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E9D RID: 11933 RVA: 0x000F0980 File Offset: 0x000EEB80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1382919, XrefRangeEnd = 1382942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArrayList GetArguments()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMethodReturnMessage.NativeMethodInfoPtr_GetArguments_Internal_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
		}

		// Token: 0x06002E9E RID: 11934 RVA: 0x000F09C0 File Offset: 0x000EEBC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Object> GetArgs(ArrayList args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMethodReturnMessage.NativeMethodInfoPtr_GetArgs_Internal_Il2CppReferenceArray_1_Object_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06002E9F RID: 11935 RVA: 0x000F0A10 File Offset: 0x000EEC10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1382942, XrefRangeEnd = 1382943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetReturnValue(ArrayList args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMethodReturnMessage.NativeMethodInfoPtr_GetReturnValue_Internal_Object_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002EA0 RID: 11936 RVA: 0x000F0A60 File Offset: 0x000EEC60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1382943, XrefRangeEnd = 1382946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception GetException(ArrayList args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMethodReturnMessage.NativeMethodInfoPtr_GetException_Internal_Exception_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x06002EA1 RID: 11937 RVA: 0x000F0AB0 File Offset: 0x000EECB0
		public unsafe int PropertiesCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMethodReturnMessage.NativeMethodInfoPtr_get_PropertiesCount_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002EA2 RID: 11938 RVA: 0x0000FD72 File Offset: 0x0000DF72
		public CADMethodReturnMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x06002EA3 RID: 11939 RVA: 0x000F0AEC File Offset: 0x000EECEC
		// (set) Token: 0x06002EA4 RID: 11940 RVA: 0x0000FD7B File Offset: 0x0000DF7B
		public unsafe Object _returnValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodReturnMessage.NativeFieldInfoPtr__returnValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodReturnMessage.NativeFieldInfoPtr__returnValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x06002EA5 RID: 11941 RVA: 0x000F0B1C File Offset: 0x000EED1C
		// (set) Token: 0x06002EA6 RID: 11942 RVA: 0x0000FD9A File Offset: 0x0000DF9A
		public unsafe CADArgHolder _exception
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodReturnMessage.NativeFieldInfoPtr__exception);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CADArgHolder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodReturnMessage.NativeFieldInfoPtr__exception), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x06002EA7 RID: 11943 RVA: 0x000F0B4C File Offset: 0x000EED4C
		// (set) Token: 0x06002EA8 RID: 11944 RVA: 0x0000FDB9 File Offset: 0x0000DFB9
		public unsafe Il2CppReferenceArray<Type> _sig
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodReturnMessage.NativeFieldInfoPtr__sig);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodReturnMessage.NativeFieldInfoPtr__sig), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040026D1 RID: 9937
		private static readonly IntPtr NativeFieldInfoPtr__returnValue;

		// Token: 0x040026D2 RID: 9938
		private static readonly IntPtr NativeFieldInfoPtr__exception;

		// Token: 0x040026D3 RID: 9939
		private static readonly IntPtr NativeFieldInfoPtr__sig;

		// Token: 0x040026D4 RID: 9940
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_CADMethodReturnMessage_IMessage_0;

		// Token: 0x040026D5 RID: 9941
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IMethodReturnMessage_0;

		// Token: 0x040026D6 RID: 9942
		private static readonly IntPtr NativeMethodInfoPtr_GetArguments_Internal_ArrayList_0;

		// Token: 0x040026D7 RID: 9943
		private static readonly IntPtr NativeMethodInfoPtr_GetArgs_Internal_Il2CppReferenceArray_1_Object_ArrayList_0;

		// Token: 0x040026D8 RID: 9944
		private static readonly IntPtr NativeMethodInfoPtr_GetReturnValue_Internal_Object_ArrayList_0;

		// Token: 0x040026D9 RID: 9945
		private static readonly IntPtr NativeMethodInfoPtr_GetException_Internal_Exception_ArrayList_0;

		// Token: 0x040026DA RID: 9946
		private static readonly IntPtr NativeMethodInfoPtr_get_PropertiesCount_Internal_get_Int32_0;
	}
}
