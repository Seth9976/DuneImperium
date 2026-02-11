using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.Sockets
{
	// Token: 0x02000244 RID: 580
	public sealed class UdpReceiveResult : ValueType
	{
		// Token: 0x06002689 RID: 9865 RVA: 0x000B17DC File Offset: 0x000AF9DC
		// Note: this type is marked as 'beforefieldinit'.
		static UdpReceiveResult()
		{
			Il2CppClassPointerStore<UdpReceiveResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Sockets", "UdpReceiveResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UdpReceiveResult>.NativeClassPtr);
			UdpReceiveResult.NativeFieldInfoPtr_m_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UdpReceiveResult>.NativeClassPtr, "m_buffer");
			UdpReceiveResult.NativeFieldInfoPtr_m_remoteEndPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UdpReceiveResult>.NativeClassPtr, "m_remoteEndPoint");
			UdpReceiveResult.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_IPEndPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpReceiveResult>.NativeClassPtr, 100669080);
			UdpReceiveResult.NativeMethodInfoPtr_get_Buffer_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpReceiveResult>.NativeClassPtr, 100669081);
			UdpReceiveResult.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpReceiveResult>.NativeClassPtr, 100669082);
			UdpReceiveResult.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpReceiveResult>.NativeClassPtr, 100669083);
			UdpReceiveResult.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_UdpReceiveResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpReceiveResult>.NativeClassPtr, 100669084);
		}

		// Token: 0x0600268A RID: 9866 RVA: 0x000B1898 File Offset: 0x000AFA98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 490388, RefRangeEnd = 490389, XrefRangeStart = 490374, XrefRangeEnd = 490388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UdpReceiveResult(Il2CppStructArray<byte> buffer, IPEndPoint remoteEndPoint)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UdpReceiveResult>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(remoteEndPoint);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UdpReceiveResult.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_IPEndPoint_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000C2E RID: 3118
		// (get) Token: 0x0600268B RID: 9867 RVA: 0x000B18FC File Offset: 0x000AFAFC
		public unsafe Il2CppStructArray<byte> Buffer
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UdpReceiveResult.NativeMethodInfoPtr_get_Buffer_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x0600268C RID: 9868 RVA: 0x000B1940 File Offset: 0x000AFB40
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UdpReceiveResult.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600268D RID: 9869 RVA: 0x000B1984 File Offset: 0x000AFB84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490389, XrefRangeEnd = 490394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UdpReceiveResult.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600268E RID: 9870 RVA: 0x000B19D8 File Offset: 0x000AFBD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490394, XrefRangeEnd = 490395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(UdpReceiveResult other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UdpReceiveResult.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_UdpReceiveResult_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600268F RID: 9871 RVA: 0x000108CB File Offset: 0x0000EACB
		public UdpReceiveResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002690 RID: 9872 RVA: 0x000108D4 File Offset: 0x0000EAD4
		public UdpReceiveResult()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UdpReceiveResult>.NativeClassPtr))
		{
		}

		// Token: 0x17000C2C RID: 3116
		// (get) Token: 0x06002691 RID: 9873 RVA: 0x000B1A30 File Offset: 0x000AFC30
		// (set) Token: 0x06002692 RID: 9874 RVA: 0x000108E6 File Offset: 0x0000EAE6
		public unsafe Il2CppStructArray<byte> m_buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UdpReceiveResult.NativeFieldInfoPtr_m_buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UdpReceiveResult.NativeFieldInfoPtr_m_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C2D RID: 3117
		// (get) Token: 0x06002693 RID: 9875 RVA: 0x000B1A60 File Offset: 0x000AFC60
		// (set) Token: 0x06002694 RID: 9876 RVA: 0x00010905 File Offset: 0x0000EB05
		public unsafe IPEndPoint m_remoteEndPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UdpReceiveResult.NativeFieldInfoPtr_m_remoteEndPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPEndPoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UdpReceiveResult.NativeFieldInfoPtr_m_remoteEndPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001EC0 RID: 7872
		private static readonly IntPtr NativeFieldInfoPtr_m_buffer;

		// Token: 0x04001EC1 RID: 7873
		private static readonly IntPtr NativeFieldInfoPtr_m_remoteEndPoint;

		// Token: 0x04001EC2 RID: 7874
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_IPEndPoint_0;

		// Token: 0x04001EC3 RID: 7875
		private static readonly IntPtr NativeMethodInfoPtr_get_Buffer_Public_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001EC4 RID: 7876
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001EC5 RID: 7877
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001EC6 RID: 7878
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_UdpReceiveResult_0;
	}
}
