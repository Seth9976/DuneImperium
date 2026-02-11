using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.ComponentModel;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Net.Sockets
{
	// Token: 0x02000232 RID: 562
	[Serializable]
	public class SocketException : Win32Exception
	{
		// Token: 0x06002622 RID: 9762 RVA: 0x000AFE08 File Offset: 0x000AE008
		// Note: this type is marked as 'beforefieldinit'.
		static SocketException()
		{
			Il2CppClassPointerStore<SocketException>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Sockets", "SocketException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SocketException>.NativeClassPtr);
			SocketException.NativeFieldInfoPtr_m_EndPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketException>.NativeClassPtr, "m_EndPoint");
			SocketException.NativeMethodInfoPtr_WSAGetLastError_icall_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketException>.NativeClassPtr, 100669025);
			SocketException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketException>.NativeClassPtr, 100669026);
			SocketException.NativeMethodInfoPtr__ctor_Internal_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketException>.NativeClassPtr, 100669027);
			SocketException.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketException>.NativeClassPtr, 100669028);
			SocketException.NativeMethodInfoPtr__ctor_Internal_Void_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketException>.NativeClassPtr, 100669029);
			SocketException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketException>.NativeClassPtr, 100669030);
			SocketException.NativeMethodInfoPtr_get_ErrorCode_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketException>.NativeClassPtr, 100669031);
			SocketException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketException>.NativeClassPtr, 100669032);
			SocketException.NativeMethodInfoPtr_get_SocketErrorCode_Public_get_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketException>.NativeClassPtr, 100669033);
		}

		// Token: 0x06002623 RID: 9763 RVA: 0x000AFF00 File Offset: 0x000AE100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489864, XrefRangeEnd = 489865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int WSAGetLastError_icall()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketException.NativeMethodInfoPtr_WSAGetLastError_icall_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002624 RID: 9764 RVA: 0x000AFF30 File Offset: 0x000AE130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489865, XrefRangeEnd = 489867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SocketException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocketException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002625 RID: 9765 RVA: 0x000AFF6C File Offset: 0x000AE16C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 474059, RefRangeEnd = 474064, XrefRangeStart = 474059, XrefRangeEnd = 474064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SocketException(int error, string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocketException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref error;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketException.NativeMethodInfoPtr__ctor_Internal_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002626 RID: 9766 RVA: 0x000AFFC8 File Offset: 0x000AE1C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 489868, RefRangeEnd = 489871, XrefRangeStart = 489867, XrefRangeEnd = 489868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SocketException(int errorCode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocketException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref errorCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketException.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002627 RID: 9767 RVA: 0x000B0010 File Offset: 0x000AE210
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 489868, RefRangeEnd = 489871, XrefRangeStart = 489868, XrefRangeEnd = 489871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SocketException(SocketError socketError)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocketException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref socketError;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketException.NativeMethodInfoPtr__ctor_Internal_Void_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002628 RID: 9768 RVA: 0x000B0058 File Offset: 0x000AE258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SocketException(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocketException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x06002629 RID: 9769 RVA: 0x000B00BC File Offset: 0x000AE2BC
		public unsafe override int ErrorCode
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 311826, RefRangeEnd = 311839, XrefRangeStart = 311826, XrefRangeEnd = 311839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SocketException.NativeMethodInfoPtr_get_ErrorCode_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x0600262A RID: 9770 RVA: 0x000B0104 File Offset: 0x000AE304
		public unsafe override string Message
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489871, XrefRangeEnd = 489877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SocketException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x0600262B RID: 9771 RVA: 0x000B0148 File Offset: 0x000AE348
		public unsafe SocketError SocketErrorCode
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 311826, RefRangeEnd = 311839, XrefRangeStart = 311826, XrefRangeEnd = 311839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketException.NativeMethodInfoPtr_get_SocketErrorCode_Public_get_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600262C RID: 9772 RVA: 0x0001066E File Offset: 0x0000E86E
		public SocketException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x0600262D RID: 9773 RVA: 0x000B0184 File Offset: 0x000AE384
		// (set) Token: 0x0600262E RID: 9774 RVA: 0x00010677 File Offset: 0x0000E877
		public unsafe EndPoint m_EndPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketException.NativeFieldInfoPtr_m_EndPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EndPoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketException.NativeFieldInfoPtr_m_EndPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D8B RID: 7563
		private static readonly IntPtr NativeFieldInfoPtr_m_EndPoint;

		// Token: 0x04001D8C RID: 7564
		private static readonly IntPtr NativeMethodInfoPtr_WSAGetLastError_icall_Private_Static_Int32_0;

		// Token: 0x04001D8D RID: 7565
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001D8E RID: 7566
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_String_0;

		// Token: 0x04001D8F RID: 7567
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001D90 RID: 7568
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SocketError_0;

		// Token: 0x04001D91 RID: 7569
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001D92 RID: 7570
		private static readonly IntPtr NativeMethodInfoPtr_get_ErrorCode_Public_Virtual_get_Int32_0;

		// Token: 0x04001D93 RID: 7571
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0;

		// Token: 0x04001D94 RID: 7572
		private static readonly IntPtr NativeMethodInfoPtr_get_SocketErrorCode_Public_get_SocketError_0;
	}
}
