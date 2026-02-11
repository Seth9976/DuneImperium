using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Runtime.ExceptionServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.IO
{
	// Token: 0x0200053E RID: 1342
	[Serializable]
	public class Stream : MarshalByRefObject
	{
		// Token: 0x06005208 RID: 21000 RVA: 0x0017DC04 File Offset: 0x0017BE04
		// Note: this type is marked as 'beforefieldinit'.
		static Stream()
		{
			Il2CppClassPointerStore<Stream>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "Stream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Stream>.NativeClassPtr);
			Stream.NativeFieldInfoPtr_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream>.NativeClassPtr, "Null");
			Stream.NativeFieldInfoPtr__activeReadWriteTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream>.NativeClassPtr, "_activeReadWriteTask");
			Stream.NativeFieldInfoPtr__asyncActiveSemaphore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream>.NativeClassPtr, "_asyncActiveSemaphore");
			Stream.NativeMethodInfoPtr_EnsureAsyncActiveSemaphoreInitialized_Internal_SemaphoreSlim_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675791);
			Stream.NativeMethodInfoPtr_get_CanRead_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675792);
			Stream.NativeMethodInfoPtr_get_CanSeek_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675793);
			Stream.NativeMethodInfoPtr_get_CanTimeout_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675794);
			Stream.NativeMethodInfoPtr_get_CanWrite_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675795);
			Stream.NativeMethodInfoPtr_get_Length_Public_Abstract_Virtual_New_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675796);
			Stream.NativeMethodInfoPtr_get_Position_Public_Abstract_Virtual_New_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675797);
			Stream.NativeMethodInfoPtr_set_Position_Public_Abstract_Virtual_New_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675798);
			Stream.NativeMethodInfoPtr_get_ReadTimeout_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675799);
			Stream.NativeMethodInfoPtr_set_ReadTimeout_Public_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675800);
			Stream.NativeMethodInfoPtr_get_WriteTimeout_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675801);
			Stream.NativeMethodInfoPtr_set_WriteTimeout_Public_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675802);
			Stream.NativeMethodInfoPtr_CopyToAsync_Public_Task_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675803);
			Stream.NativeMethodInfoPtr_CopyToAsync_Public_Task_Stream_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675804);
			Stream.NativeMethodInfoPtr_CopyToAsync_Public_Virtual_New_Task_Stream_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675805);
			Stream.NativeMethodInfoPtr_CopyToAsyncInternal_Private_Task_Stream_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675806);
			Stream.NativeMethodInfoPtr_CopyTo_Public_Void_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675807);
			Stream.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Stream_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675808);
			Stream.NativeMethodInfoPtr_GetCopyBufferSize_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675809);
			Stream.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675810);
			Stream.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675811);
			Stream.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675812);
			Stream.NativeMethodInfoPtr_Flush_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675813);
			Stream.NativeMethodInfoPtr_FlushAsync_Public_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675814);
			Stream.NativeMethodInfoPtr_FlushAsync_Public_Virtual_New_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675815);
			Stream.NativeMethodInfoPtr_BeginRead_Public_Virtual_New_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675816);
			Stream.NativeMethodInfoPtr_BeginReadInternal_Internal_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675817);
			Stream.NativeMethodInfoPtr_EndRead_Public_Virtual_New_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675818);
			Stream.NativeMethodInfoPtr_ReadAsync_Public_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675819);
			Stream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_New_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675820);
			Stream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_New_ValueTask_1_Int32_Memory_1_Byte_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675821);
			Stream.NativeMethodInfoPtr_BeginEndReadAsync_Private_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675822);
			Stream.NativeMethodInfoPtr_BeginWrite_Public_Virtual_New_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675823);
			Stream.NativeMethodInfoPtr_BeginWriteInternal_Internal_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675824);
			Stream.NativeMethodInfoPtr_RunReadWriteTaskWhenReady_Private_Void_Task_ReadWriteTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675825);
			Stream.NativeMethodInfoPtr_RunReadWriteTask_Private_Void_ReadWriteTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675826);
			Stream.NativeMethodInfoPtr_FinishTrackingAsyncOperation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675827);
			Stream.NativeMethodInfoPtr_EndWrite_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675828);
			Stream.NativeMethodInfoPtr_WriteAsync_Public_Task_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675829);
			Stream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_New_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675830);
			Stream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_New_ValueTask_ReadOnlyMemory_1_Byte_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675831);
			Stream.NativeMethodInfoPtr_FinishWriteAsync_Private_Task_Task_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675832);
			Stream.NativeMethodInfoPtr_BeginEndWriteAsync_Private_Task_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675833);
			Stream.NativeMethodInfoPtr_Seek_Public_Abstract_Virtual_New_Int64_Int64_SeekOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675834);
			Stream.NativeMethodInfoPtr_SetLength_Public_Abstract_Virtual_New_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675835);
			Stream.NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675836);
			Stream.NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_Span_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675837);
			Stream.NativeMethodInfoPtr_ReadByte_Public_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675838);
			Stream.NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675839);
			Stream.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_ReadOnlySpan_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675840);
			Stream.NativeMethodInfoPtr_WriteByte_Public_Virtual_New_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675841);
			Stream.NativeMethodInfoPtr_BlockingBeginRead_Internal_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675842);
			Stream.NativeMethodInfoPtr_BlockingEndRead_Internal_Static_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675843);
			Stream.NativeMethodInfoPtr_BlockingBeginWrite_Internal_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675844);
			Stream.NativeMethodInfoPtr_BlockingEndWrite_Internal_Static_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675845);
			Stream.NativeMethodInfoPtr_HasOverriddenBeginEndRead_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675846);
			Stream.NativeMethodInfoPtr_HasOverriddenBeginEndWrite_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675847);
			Stream.NativeMethodInfoPtr_DisposeAsync_Public_Virtual_New_ValueTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675848);
			Stream.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675849);
			Stream.NativeMethodInfoPtr_Method_Internal_Static_ValueTask_1_Int32_Task_1_Int32_Il2CppStructArray_1_Byte_Memory_1_Byte_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100675851);
		}

		// Token: 0x06005209 RID: 21001 RVA: 0x0017E120 File Offset: 0x0017C320
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1431324, RefRangeEnd = 1431326, XrefRangeStart = 1431306, XrefRangeEnd = 1431324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SemaphoreSlim EnsureAsyncActiveSemaphoreInitialized()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_EnsureAsyncActiveSemaphoreInitialized_Internal_SemaphoreSlim_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SemaphoreSlim>(intPtr3) : null;
		}

		// Token: 0x170014E5 RID: 5349
		// (get) Token: 0x0600520A RID: 21002 RVA: 0x0017E160 File Offset: 0x0017C360
		public unsafe virtual bool CanRead
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_get_CanRead_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170014E6 RID: 5350
		// (get) Token: 0x0600520B RID: 21003 RVA: 0x0017E1A8 File Offset: 0x0017C3A8
		public unsafe virtual bool CanSeek
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_get_CanSeek_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170014E7 RID: 5351
		// (get) Token: 0x0600520C RID: 21004 RVA: 0x0017E1F0 File Offset: 0x0017C3F0
		public unsafe virtual bool CanTimeout
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_get_CanTimeout_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170014E8 RID: 5352
		// (get) Token: 0x0600520D RID: 21005 RVA: 0x0017E238 File Offset: 0x0017C438
		public unsafe virtual bool CanWrite
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_get_CanWrite_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170014E9 RID: 5353
		// (get) Token: 0x0600520E RID: 21006 RVA: 0x0017E280 File Offset: 0x0017C480
		public unsafe virtual long Length
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_get_Length_Public_Abstract_Virtual_New_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170014EA RID: 5354
		// (get) Token: 0x0600520F RID: 21007 RVA: 0x0017E2C8 File Offset: 0x0017C4C8
		// (set) Token: 0x06005210 RID: 21008 RVA: 0x0017E310 File Offset: 0x0017C510
		public unsafe virtual long Position
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_get_Position_Public_Abstract_Virtual_New_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_set_Position_Public_Abstract_Virtual_New_set_Void_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014EB RID: 5355
		// (get) Token: 0x06005211 RID: 21009 RVA: 0x0017E35C File Offset: 0x0017C55C
		// (set) Token: 0x06005212 RID: 21010 RVA: 0x0017E3A4 File Offset: 0x0017C5A4
		public unsafe virtual int ReadTimeout
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431326, XrefRangeEnd = 1431332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_get_ReadTimeout_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431332, XrefRangeEnd = 1431338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_set_ReadTimeout_Public_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170014EC RID: 5356
		// (get) Token: 0x06005213 RID: 21011 RVA: 0x0017E3F0 File Offset: 0x0017C5F0
		// (set) Token: 0x06005214 RID: 21012 RVA: 0x0017E438 File Offset: 0x0017C638
		public unsafe virtual int WriteTimeout
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431338, XrefRangeEnd = 1431344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_get_WriteTimeout_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431344, XrefRangeEnd = 1431350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_set_WriteTimeout_Public_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06005215 RID: 21013 RVA: 0x0017E484 File Offset: 0x0017C684
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1431355, RefRangeEnd = 1431359, XrefRangeStart = 1431350, XrefRangeEnd = 1431355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task CopyToAsync(Stream destination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_CopyToAsync_Public_Task_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06005216 RID: 21014 RVA: 0x0017E4D4 File Offset: 0x0017C6D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431359, XrefRangeEnd = 1431363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task CopyToAsync(Stream destination, int bufferSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_CopyToAsync_Public_Task_Stream_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06005217 RID: 21015 RVA: 0x0017E534 File Offset: 0x0017C734
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1431376, RefRangeEnd = 1431377, XrefRangeStart = 1431363, XrefRangeEnd = 1431376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_CopyToAsync_Public_Virtual_New_Task_Stream_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06005218 RID: 21016 RVA: 0x0017E5B4 File Offset: 0x0017C7B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431377, XrefRangeEnd = 1431389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task CopyToAsyncInternal(Stream destination, int bufferSize, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_CopyToAsyncInternal_Private_Task_Stream_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06005219 RID: 21017 RVA: 0x0017E62C File Offset: 0x0017C82C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1431390, RefRangeEnd = 1431394, XrefRangeStart = 1431389, XrefRangeEnd = 1431390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyTo(Stream destination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_CopyTo_Public_Void_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600521A RID: 21018 RVA: 0x0017E670 File Offset: 0x0017C870
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1431408, RefRangeEnd = 1431409, XrefRangeStart = 1431394, XrefRangeEnd = 1431408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Stream destination, int bufferSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Stream_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600521B RID: 21019 RVA: 0x0017E6CC File Offset: 0x0017C8CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1431413, RefRangeEnd = 1431415, XrefRangeStart = 1431409, XrefRangeEnd = 1431413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetCopyBufferSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_GetCopyBufferSize_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600521C RID: 21020 RVA: 0x0017E708 File Offset: 0x0017C908
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1431419, RefRangeEnd = 1431420, XrefRangeStart = 1431415, XrefRangeEnd = 1431419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600521D RID: 21021 RVA: 0x0017E744 File Offset: 0x0017C944
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 873163, RefRangeEnd = 873182, XrefRangeStart = 873163, XrefRangeEnd = 873182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600521E RID: 21022 RVA: 0x0017E778 File Offset: 0x0017C978
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600521F RID: 21023 RVA: 0x0017E7C4 File Offset: 0x0017C9C4
		[CallerCount(0)]
		public unsafe virtual void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_Flush_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005220 RID: 21024 RVA: 0x0017E800 File Offset: 0x0017CA00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1431424, RefRangeEnd = 1431425, XrefRangeStart = 1431420, XrefRangeEnd = 1431424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task FlushAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_FlushAsync_Public_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06005221 RID: 21025 RVA: 0x0017E840 File Offset: 0x0017CA40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431425, XrefRangeEnd = 1431455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task FlushAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_FlushAsync_Public_Virtual_New_Task_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06005222 RID: 21026 RVA: 0x0017E8A0 File Offset: 0x0017CAA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431455, XrefRangeEnd = 1431456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IAsyncResult BeginRead(Il2CppStructArray<byte> buffer, int offset, int count, AsyncCallback callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_BeginRead_Public_Virtual_New_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06005223 RID: 21027 RVA: 0x0017E940 File Offset: 0x0017CB40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1431482, RefRangeEnd = 1431483, XrefRangeStart = 1431456, XrefRangeEnd = 1431482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginReadInternal(Il2CppStructArray<byte> buffer, int offset, int count, AsyncCallback callback, Object state, bool serializeAsynchronously, bool apm)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref serializeAsynchronously;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref apm;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_BeginReadInternal_Internal_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06005224 RID: 21028 RVA: 0x0017E9F0 File Offset: 0x0017CBF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431483, XrefRangeEnd = 1431493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int EndRead(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_EndRead_Public_Virtual_New_Int32_IAsyncResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005225 RID: 21029 RVA: 0x0017EA48 File Offset: 0x0017CC48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1431497, RefRangeEnd = 1431499, XrefRangeStart = 1431493, XrefRangeEnd = 1431497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<int> ReadAsync(Il2CppStructArray<byte> buffer, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_ReadAsync_Public_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x06005226 RID: 21030 RVA: 0x0017EAB4 File Offset: 0x0017CCB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431499, XrefRangeEnd = 1431511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task<int> ReadAsync(Il2CppStructArray<byte> buffer, int offset, int count, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_New_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x06005227 RID: 21031 RVA: 0x0017EB44 File Offset: 0x0017CD44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1431553, RefRangeEnd = 1431555, XrefRangeStart = 1431511, XrefRangeEnd = 1431553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(buffer));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_New_ValueTask_1_Int32_Memory_1_Byte_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTask<int>(intPtr);
		}

		// Token: 0x06005228 RID: 21032 RVA: 0x0017EBB4 File Offset: 0x0017CDB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1431589, RefRangeEnd = 1431591, XrefRangeStart = 1431555, XrefRangeEnd = 1431589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<int> BeginEndReadAsync(Il2CppStructArray<byte> buffer, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_BeginEndReadAsync_Private_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x06005229 RID: 21033 RVA: 0x0017EC20 File Offset: 0x0017CE20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431591, XrefRangeEnd = 1431592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IAsyncResult BeginWrite(Il2CppStructArray<byte> buffer, int offset, int count, AsyncCallback callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_BeginWrite_Public_Virtual_New_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x0600522A RID: 21034 RVA: 0x0017ECC0 File Offset: 0x0017CEC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1431618, RefRangeEnd = 1431619, XrefRangeStart = 1431592, XrefRangeEnd = 1431618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginWriteInternal(Il2CppStructArray<byte> buffer, int offset, int count, AsyncCallback callback, Object state, bool serializeAsynchronously, bool apm)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref serializeAsynchronously;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref apm;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_BeginWriteInternal_Internal_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x0600522B RID: 21035 RVA: 0x0017ED70 File Offset: 0x0017CF70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1431643, RefRangeEnd = 1431645, XrefRangeStart = 1431619, XrefRangeEnd = 1431643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunReadWriteTaskWhenReady(Task asyncWaiter, Stream.ReadWriteTask readWriteTask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncWaiter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(readWriteTask);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_RunReadWriteTaskWhenReady_Private_Void_Task_ReadWriteTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600522C RID: 21036 RVA: 0x0017EDC4 File Offset: 0x0017CFC4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1431656, RefRangeEnd = 1431659, XrefRangeStart = 1431645, XrefRangeEnd = 1431656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunReadWriteTask(Stream.ReadWriteTask readWriteTask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(readWriteTask);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_RunReadWriteTask_Private_Void_ReadWriteTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600522D RID: 21037 RVA: 0x0017EE08 File Offset: 0x0017D008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431659, XrefRangeEnd = 1431662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishTrackingAsyncOperation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_FinishTrackingAsyncOperation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600522E RID: 21038 RVA: 0x0017EE3C File Offset: 0x0017D03C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1431672, RefRangeEnd = 1431673, XrefRangeStart = 1431662, XrefRangeEnd = 1431672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EndWrite(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_EndWrite_Public_Virtual_New_Void_IAsyncResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600522F RID: 21039 RVA: 0x0017EE8C File Offset: 0x0017D08C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1431677, RefRangeEnd = 1431685, XrefRangeStart = 1431673, XrefRangeEnd = 1431677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task WriteAsync(Il2CppStructArray<byte> buffer, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_WriteAsync_Public_Task_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06005230 RID: 21040 RVA: 0x0017EEF8 File Offset: 0x0017D0F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431685, XrefRangeEnd = 1431695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteAsync(Il2CppStructArray<byte> buffer, int offset, int count, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_New_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06005231 RID: 21041 RVA: 0x0017EF88 File Offset: 0x0017D188
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1431735, RefRangeEnd = 1431737, XrefRangeStart = 1431695, XrefRangeEnd = 1431735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(buffer));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_New_ValueTask_ReadOnlyMemory_1_Byte_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTask(intPtr);
		}

		// Token: 0x06005232 RID: 21042 RVA: 0x0017EFF8 File Offset: 0x0017D1F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431737, XrefRangeEnd = 1431748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task FinishWriteAsync(Task writeTask, Il2CppStructArray<byte> localBuffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writeTask);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(localBuffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_FinishWriteAsync_Private_Task_Task_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06005233 RID: 21043 RVA: 0x0017F05C File Offset: 0x0017D25C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1431782, RefRangeEnd = 1431784, XrefRangeStart = 1431748, XrefRangeEnd = 1431782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task BeginEndWriteAsync(Il2CppStructArray<byte> buffer, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_BeginEndWriteAsync_Private_Task_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06005234 RID: 21044 RVA: 0x0017F0C8 File Offset: 0x0017D2C8
		[CallerCount(0)]
		public unsafe virtual long Seek(long offset, SeekOrigin origin)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref offset;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref origin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_Seek_Public_Abstract_Virtual_New_Int64_Int64_SeekOrigin_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005235 RID: 21045 RVA: 0x0017F12C File Offset: 0x0017D32C
		[CallerCount(0)]
		public unsafe virtual void SetLength(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_SetLength_Public_Abstract_Virtual_New_Void_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005236 RID: 21046 RVA: 0x0017F178 File Offset: 0x0017D378
		[CallerCount(0)]
		public unsafe virtual int Read(Il2CppStructArray<byte> buffer, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005237 RID: 21047 RVA: 0x0017F1EC File Offset: 0x0017D3EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1431804, RefRangeEnd = 1431805, XrefRangeStart = 1431784, XrefRangeEnd = 1431804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int Read(Span<byte> buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(buffer));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_Span_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005238 RID: 21048 RVA: 0x0017F24C File Offset: 0x0017D44C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1431808, RefRangeEnd = 1431809, XrefRangeStart = 1431805, XrefRangeEnd = 1431808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int ReadByte()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_ReadByte_Public_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005239 RID: 21049 RVA: 0x0017F294 File Offset: 0x0017D494
		[CallerCount(0)]
		public unsafe virtual void Write(Il2CppStructArray<byte> buffer, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600523A RID: 21050 RVA: 0x0017F300 File Offset: 0x0017D500
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1431828, RefRangeEnd = 1431831, XrefRangeStart = 1431809, XrefRangeEnd = 1431828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Write(ReadOnlySpan<byte> buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(buffer));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_ReadOnlySpan_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600523B RID: 21051 RVA: 0x0017F354 File Offset: 0x0017D554
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1431834, RefRangeEnd = 1431835, XrefRangeStart = 1431831, XrefRangeEnd = 1431834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteByte(byte value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_WriteByte_Public_Virtual_New_Void_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600523C RID: 21052 RVA: 0x0017F3A0 File Offset: 0x0017D5A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1431844, RefRangeEnd = 1431845, XrefRangeStart = 1431835, XrefRangeEnd = 1431844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BlockingBeginRead(Il2CppStructArray<byte> buffer, int offset, int count, AsyncCallback callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_BlockingBeginRead_Internal_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x0600523D RID: 21053 RVA: 0x0017F434 File Offset: 0x0017D634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int BlockingEndRead(IAsyncResult asyncResult)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_BlockingEndRead_Internal_Static_Int32_IAsyncResult_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600523E RID: 21054 RVA: 0x0017F478 File Offset: 0x0017D678
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1431854, RefRangeEnd = 1431855, XrefRangeStart = 1431845, XrefRangeEnd = 1431854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BlockingBeginWrite(Il2CppStructArray<byte> buffer, int offset, int count, AsyncCallback callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_BlockingBeginWrite_Internal_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x0600523F RID: 21055 RVA: 0x0017F50C File Offset: 0x0017D70C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BlockingEndWrite(IAsyncResult asyncResult)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_BlockingEndWrite_Internal_Static_Void_IAsyncResult_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005240 RID: 21056 RVA: 0x0017F544 File Offset: 0x0017D744
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasOverriddenBeginEndRead()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_HasOverriddenBeginEndRead_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005241 RID: 21057 RVA: 0x0017F580 File Offset: 0x0017D780
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasOverriddenBeginEndWrite()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_HasOverriddenBeginEndWrite_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005242 RID: 21058 RVA: 0x0017F5BC File Offset: 0x0017D7BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431855, XrefRangeEnd = 1431861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ValueTask DisposeAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_DisposeAsync_Public_Virtual_New_ValueTask_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTask(intPtr);
		}

		// Token: 0x06005243 RID: 21059 RVA: 0x0017F600 File Offset: 0x0017D800
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Stream()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stream>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005244 RID: 21060 RVA: 0x0017F63C File Offset: 0x0017D83C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431861, XrefRangeEnd = 1431878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ValueTask<int> Method_Internal_Static_ValueTask_1_Int32_Task_1_Int32_Il2CppStructArray_1_Byte_Memory_1_Byte_PDM_0(Task<int> readTask, Il2CppStructArray<byte> localBuffer, Memory<byte> localDestination)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(readTask);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(localBuffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(localDestination));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_Method_Internal_Static_ValueTask_1_Int32_Task_1_Int32_Il2CppStructArray_1_Byte_Memory_1_Byte_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTask<int>(intPtr);
		}

		// Token: 0x06005245 RID: 21061 RVA: 0x0001D30B File Offset: 0x0001B50B
		public Stream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170014E2 RID: 5346
		// (get) Token: 0x06005246 RID: 21062 RVA: 0x0017F6A4 File Offset: 0x0017D8A4
		// (set) Token: 0x06005247 RID: 21063 RVA: 0x0001D314 File Offset: 0x0001B514
		public unsafe static Stream Null
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Stream.NativeFieldInfoPtr_Null, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Stream.NativeFieldInfoPtr_Null, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014E3 RID: 5347
		// (get) Token: 0x06005248 RID: 21064 RVA: 0x0017F6CC File Offset: 0x0017D8CC
		// (set) Token: 0x06005249 RID: 21065 RVA: 0x0001D326 File Offset: 0x0001B526
		public unsafe Stream.ReadWriteTask _activeReadWriteTask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.NativeFieldInfoPtr__activeReadWriteTask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream.ReadWriteTask>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.NativeFieldInfoPtr__activeReadWriteTask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014E4 RID: 5348
		// (get) Token: 0x0600524A RID: 21066 RVA: 0x0017F6FC File Offset: 0x0017D8FC
		// (set) Token: 0x0600524B RID: 21067 RVA: 0x0001D345 File Offset: 0x0001B545
		public unsafe SemaphoreSlim _asyncActiveSemaphore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.NativeFieldInfoPtr__asyncActiveSemaphore);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SemaphoreSlim>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.NativeFieldInfoPtr__asyncActiveSemaphore), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004302 RID: 17154
		private static readonly IntPtr NativeFieldInfoPtr_Null;

		// Token: 0x04004303 RID: 17155
		private static readonly IntPtr NativeFieldInfoPtr__activeReadWriteTask;

		// Token: 0x04004304 RID: 17156
		private static readonly IntPtr NativeFieldInfoPtr__asyncActiveSemaphore;

		// Token: 0x04004305 RID: 17157
		private static readonly IntPtr NativeMethodInfoPtr_EnsureAsyncActiveSemaphoreInitialized_Internal_SemaphoreSlim_0;

		// Token: 0x04004306 RID: 17158
		private static readonly IntPtr NativeMethodInfoPtr_get_CanRead_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04004307 RID: 17159
		private static readonly IntPtr NativeMethodInfoPtr_get_CanSeek_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04004308 RID: 17160
		private static readonly IntPtr NativeMethodInfoPtr_get_CanTimeout_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04004309 RID: 17161
		private static readonly IntPtr NativeMethodInfoPtr_get_CanWrite_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x0400430A RID: 17162
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_Abstract_Virtual_New_get_Int64_0;

		// Token: 0x0400430B RID: 17163
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_Abstract_Virtual_New_get_Int64_0;

		// Token: 0x0400430C RID: 17164
		private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_Abstract_Virtual_New_set_Void_Int64_0;

		// Token: 0x0400430D RID: 17165
		private static readonly IntPtr NativeMethodInfoPtr_get_ReadTimeout_Public_Virtual_New_get_Int32_0;

		// Token: 0x0400430E RID: 17166
		private static readonly IntPtr NativeMethodInfoPtr_set_ReadTimeout_Public_Virtual_New_set_Void_Int32_0;

		// Token: 0x0400430F RID: 17167
		private static readonly IntPtr NativeMethodInfoPtr_get_WriteTimeout_Public_Virtual_New_get_Int32_0;

		// Token: 0x04004310 RID: 17168
		private static readonly IntPtr NativeMethodInfoPtr_set_WriteTimeout_Public_Virtual_New_set_Void_Int32_0;

		// Token: 0x04004311 RID: 17169
		private static readonly IntPtr NativeMethodInfoPtr_CopyToAsync_Public_Task_Stream_0;

		// Token: 0x04004312 RID: 17170
		private static readonly IntPtr NativeMethodInfoPtr_CopyToAsync_Public_Task_Stream_Int32_0;

		// Token: 0x04004313 RID: 17171
		private static readonly IntPtr NativeMethodInfoPtr_CopyToAsync_Public_Virtual_New_Task_Stream_Int32_CancellationToken_0;

		// Token: 0x04004314 RID: 17172
		private static readonly IntPtr NativeMethodInfoPtr_CopyToAsyncInternal_Private_Task_Stream_Int32_CancellationToken_0;

		// Token: 0x04004315 RID: 17173
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Void_Stream_0;

		// Token: 0x04004316 RID: 17174
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Stream_Int32_0;

		// Token: 0x04004317 RID: 17175
		private static readonly IntPtr NativeMethodInfoPtr_GetCopyBufferSize_Private_Int32_0;

		// Token: 0x04004318 RID: 17176
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0;

		// Token: 0x04004319 RID: 17177
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400431A RID: 17178
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x0400431B RID: 17179
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x0400431C RID: 17180
		private static readonly IntPtr NativeMethodInfoPtr_FlushAsync_Public_Task_0;

		// Token: 0x0400431D RID: 17181
		private static readonly IntPtr NativeMethodInfoPtr_FlushAsync_Public_Virtual_New_Task_CancellationToken_0;

		// Token: 0x0400431E RID: 17182
		private static readonly IntPtr NativeMethodInfoPtr_BeginRead_Public_Virtual_New_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

		// Token: 0x0400431F RID: 17183
		private static readonly IntPtr NativeMethodInfoPtr_BeginReadInternal_Internal_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_Boolean_Boolean_0;

		// Token: 0x04004320 RID: 17184
		private static readonly IntPtr NativeMethodInfoPtr_EndRead_Public_Virtual_New_Int32_IAsyncResult_0;

		// Token: 0x04004321 RID: 17185
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsync_Public_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04004322 RID: 17186
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsync_Public_Virtual_New_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04004323 RID: 17187
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsync_Public_Virtual_New_ValueTask_1_Int32_Memory_1_Byte_CancellationToken_0;

		// Token: 0x04004324 RID: 17188
		private static readonly IntPtr NativeMethodInfoPtr_BeginEndReadAsync_Private_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04004325 RID: 17189
		private static readonly IntPtr NativeMethodInfoPtr_BeginWrite_Public_Virtual_New_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

		// Token: 0x04004326 RID: 17190
		private static readonly IntPtr NativeMethodInfoPtr_BeginWriteInternal_Internal_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_Boolean_Boolean_0;

		// Token: 0x04004327 RID: 17191
		private static readonly IntPtr NativeMethodInfoPtr_RunReadWriteTaskWhenReady_Private_Void_Task_ReadWriteTask_0;

		// Token: 0x04004328 RID: 17192
		private static readonly IntPtr NativeMethodInfoPtr_RunReadWriteTask_Private_Void_ReadWriteTask_0;

		// Token: 0x04004329 RID: 17193
		private static readonly IntPtr NativeMethodInfoPtr_FinishTrackingAsyncOperation_Private_Void_0;

		// Token: 0x0400432A RID: 17194
		private static readonly IntPtr NativeMethodInfoPtr_EndWrite_Public_Virtual_New_Void_IAsyncResult_0;

		// Token: 0x0400432B RID: 17195
		private static readonly IntPtr NativeMethodInfoPtr_WriteAsync_Public_Task_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x0400432C RID: 17196
		private static readonly IntPtr NativeMethodInfoPtr_WriteAsync_Public_Virtual_New_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x0400432D RID: 17197
		private static readonly IntPtr NativeMethodInfoPtr_WriteAsync_Public_Virtual_New_ValueTask_ReadOnlyMemory_1_Byte_CancellationToken_0;

		// Token: 0x0400432E RID: 17198
		private static readonly IntPtr NativeMethodInfoPtr_FinishWriteAsync_Private_Task_Task_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400432F RID: 17199
		private static readonly IntPtr NativeMethodInfoPtr_BeginEndWriteAsync_Private_Task_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04004330 RID: 17200
		private static readonly IntPtr NativeMethodInfoPtr_Seek_Public_Abstract_Virtual_New_Int64_Int64_SeekOrigin_0;

		// Token: 0x04004331 RID: 17201
		private static readonly IntPtr NativeMethodInfoPtr_SetLength_Public_Abstract_Virtual_New_Void_Int64_0;

		// Token: 0x04004332 RID: 17202
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04004333 RID: 17203
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_Span_1_Byte_0;

		// Token: 0x04004334 RID: 17204
		private static readonly IntPtr NativeMethodInfoPtr_ReadByte_Public_Virtual_New_Int32_0;

		// Token: 0x04004335 RID: 17205
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04004336 RID: 17206
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_Void_ReadOnlySpan_1_Byte_0;

		// Token: 0x04004337 RID: 17207
		private static readonly IntPtr NativeMethodInfoPtr_WriteByte_Public_Virtual_New_Void_Byte_0;

		// Token: 0x04004338 RID: 17208
		private static readonly IntPtr NativeMethodInfoPtr_BlockingBeginRead_Internal_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

		// Token: 0x04004339 RID: 17209
		private static readonly IntPtr NativeMethodInfoPtr_BlockingEndRead_Internal_Static_Int32_IAsyncResult_0;

		// Token: 0x0400433A RID: 17210
		private static readonly IntPtr NativeMethodInfoPtr_BlockingBeginWrite_Internal_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

		// Token: 0x0400433B RID: 17211
		private static readonly IntPtr NativeMethodInfoPtr_BlockingEndWrite_Internal_Static_Void_IAsyncResult_0;

		// Token: 0x0400433C RID: 17212
		private static readonly IntPtr NativeMethodInfoPtr_HasOverriddenBeginEndRead_Private_Boolean_0;

		// Token: 0x0400433D RID: 17213
		private static readonly IntPtr NativeMethodInfoPtr_HasOverriddenBeginEndWrite_Private_Boolean_0;

		// Token: 0x0400433E RID: 17214
		private static readonly IntPtr NativeMethodInfoPtr_DisposeAsync_Public_Virtual_New_ValueTask_0;

		// Token: 0x0400433F RID: 17215
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04004340 RID: 17216
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_ValueTask_1_Int32_Task_1_Int32_Il2CppStructArray_1_Byte_Memory_1_Byte_PDM_0;

		// Token: 0x02000723 RID: 1827
		public sealed class ReadWriteParameters : ValueType
		{
			// Token: 0x06006139 RID: 24889 RVA: 0x001B4FA0 File Offset: 0x001B31A0
			// Note: this type is marked as 'beforefieldinit'.
			static ReadWriteParameters()
			{
				Il2CppClassPointerStore<Stream.ReadWriteParameters>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Stream>.NativeClassPtr, "ReadWriteParameters");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Stream.ReadWriteParameters>.NativeClassPtr);
				Stream.ReadWriteParameters.NativeFieldInfoPtr_Buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.ReadWriteParameters>.NativeClassPtr, "Buffer");
				Stream.ReadWriteParameters.NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.ReadWriteParameters>.NativeClassPtr, "Offset");
				Stream.ReadWriteParameters.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.ReadWriteParameters>.NativeClassPtr, "Count");
			}

			// Token: 0x0600613A RID: 24890 RVA: 0x00023DFC File Offset: 0x00021FFC
			public ReadWriteParameters(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600613B RID: 24891 RVA: 0x00023E05 File Offset: 0x00022005
			public ReadWriteParameters()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stream.ReadWriteParameters>.NativeClassPtr))
			{
			}

			// Token: 0x1700193A RID: 6458
			// (get) Token: 0x0600613C RID: 24892 RVA: 0x001B5008 File Offset: 0x001B3208
			// (set) Token: 0x0600613D RID: 24893 RVA: 0x00023E17 File Offset: 0x00022017
			public unsafe Il2CppStructArray<byte> Buffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteParameters.NativeFieldInfoPtr_Buffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteParameters.NativeFieldInfoPtr_Buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700193B RID: 6459
			// (get) Token: 0x0600613E RID: 24894 RVA: 0x001B5038 File Offset: 0x001B3238
			// (set) Token: 0x0600613F RID: 24895 RVA: 0x00023E36 File Offset: 0x00022036
			public unsafe int Offset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteParameters.NativeFieldInfoPtr_Offset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteParameters.NativeFieldInfoPtr_Offset)) = value;
				}
			}

			// Token: 0x1700193C RID: 6460
			// (get) Token: 0x06006140 RID: 24896 RVA: 0x001B5060 File Offset: 0x001B3260
			// (set) Token: 0x06006141 RID: 24897 RVA: 0x00023E51 File Offset: 0x00022051
			public unsafe int Count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteParameters.NativeFieldInfoPtr_Count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteParameters.NativeFieldInfoPtr_Count)) = value;
				}
			}

			// Token: 0x04004EB3 RID: 20147
			private static readonly IntPtr NativeFieldInfoPtr_Buffer;

			// Token: 0x04004EB4 RID: 20148
			private static readonly IntPtr NativeFieldInfoPtr_Offset;

			// Token: 0x04004EB5 RID: 20149
			private static readonly IntPtr NativeFieldInfoPtr_Count;
		}

		// Token: 0x02000724 RID: 1828
		public sealed class ReadWriteTask : Task<int>
		{
			// Token: 0x06006142 RID: 24898 RVA: 0x001B5088 File Offset: 0x001B3288
			// Note: this type is marked as 'beforefieldinit'.
			static ReadWriteTask()
			{
				Il2CppClassPointerStore<Stream.ReadWriteTask>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Stream>.NativeClassPtr, "ReadWriteTask");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Stream.ReadWriteTask>.NativeClassPtr);
				Stream.ReadWriteTask.NativeFieldInfoPtr__isRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.ReadWriteTask>.NativeClassPtr, "_isRead");
				Stream.ReadWriteTask.NativeFieldInfoPtr__apm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.ReadWriteTask>.NativeClassPtr, "_apm");
				Stream.ReadWriteTask.NativeFieldInfoPtr__stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.ReadWriteTask>.NativeClassPtr, "_stream");
				Stream.ReadWriteTask.NativeFieldInfoPtr__buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.ReadWriteTask>.NativeClassPtr, "_buffer");
				Stream.ReadWriteTask.NativeFieldInfoPtr__offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.ReadWriteTask>.NativeClassPtr, "_offset");
				Stream.ReadWriteTask.NativeFieldInfoPtr__count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.ReadWriteTask>.NativeClassPtr, "_count");
				Stream.ReadWriteTask.NativeFieldInfoPtr__callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.ReadWriteTask>.NativeClassPtr, "_callback");
				Stream.ReadWriteTask.NativeFieldInfoPtr__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.ReadWriteTask>.NativeClassPtr, "_context");
				Stream.ReadWriteTask.NativeFieldInfoPtr_s_invokeAsyncCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.ReadWriteTask>.NativeClassPtr, "s_invokeAsyncCallback");
				Stream.ReadWriteTask.NativeMethodInfoPtr_ClearBeginState_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.ReadWriteTask>.NativeClassPtr, 100675852);
				Stream.ReadWriteTask.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Func_2_Object_Int32_Object_Stream_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.ReadWriteTask>.NativeClassPtr, 100675853);
				Stream.ReadWriteTask.NativeMethodInfoPtr_InvokeAsyncCallback_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.ReadWriteTask>.NativeClassPtr, 100675854);
				Stream.ReadWriteTask.NativeMethodInfoPtr_System_Threading_Tasks_ITaskCompletionAction_Invoke_Private_Virtual_Final_New_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.ReadWriteTask>.NativeClassPtr, 100675855);
				Stream.ReadWriteTask.NativeMethodInfoPtr_System_Threading_Tasks_ITaskCompletionAction_get_InvokeMayRunArbitraryCode_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.ReadWriteTask>.NativeClassPtr, 100675856);
			}

			// Token: 0x06006143 RID: 24899 RVA: 0x001B51CC File Offset: 0x001B33CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1430985, XrefRangeEnd = 1430987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ClearBeginState()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.ReadWriteTask.NativeMethodInfoPtr_ClearBeginState_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006144 RID: 24900 RVA: 0x001B5200 File Offset: 0x001B3400
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1431003, RefRangeEnd = 1431005, XrefRangeStart = 1430987, XrefRangeEnd = 1431003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReadWriteTask(bool isRead, bool apm, Func<Object, int> function, Object state, Stream stream, Il2CppStructArray<byte> buffer, int offset, int count, AsyncCallback callback)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stream.ReadWriteTask>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref isRead;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref apm;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(function);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stream);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.ReadWriteTask.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Func_2_Object_Int32_Object_Stream_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006145 RID: 24901 RVA: 0x001B52D0 File Offset: 0x001B34D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431005, XrefRangeEnd = 1431010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void InvokeAsyncCallback(Object completedTask)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(completedTask);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.ReadWriteTask.NativeMethodInfoPtr_InvokeAsyncCallback_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006146 RID: 24902 RVA: 0x001B5308 File Offset: 0x001B3508
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431010, XrefRangeEnd = 1431026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Threading_Tasks_ITaskCompletionAction_Invoke(Task completingTask)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(completingTask);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.ReadWriteTask.NativeMethodInfoPtr_System_Threading_Tasks_ITaskCompletionAction_Invoke_Private_Virtual_Final_New_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17001946 RID: 6470
			// (get) Token: 0x06006147 RID: 24903 RVA: 0x001B534C File Offset: 0x001B354C
			public unsafe bool System.Threading.Tasks.ITaskCompletionAction.InvokeMayRunArbitraryCode
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.ReadWriteTask.NativeMethodInfoPtr_System_Threading_Tasks_ITaskCompletionAction_get_InvokeMayRunArbitraryCode_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006148 RID: 24904 RVA: 0x00023E6C File Offset: 0x0002206C
			public ReadWriteTask(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700193D RID: 6461
			// (get) Token: 0x06006149 RID: 24905 RVA: 0x001B5388 File Offset: 0x001B3588
			// (set) Token: 0x0600614A RID: 24906 RVA: 0x00023E75 File Offset: 0x00022075
			public unsafe bool _isRead
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteTask.NativeFieldInfoPtr__isRead);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteTask.NativeFieldInfoPtr__isRead)) = value;
				}
			}

			// Token: 0x1700193E RID: 6462
			// (get) Token: 0x0600614B RID: 24907 RVA: 0x001B53B0 File Offset: 0x001B35B0
			// (set) Token: 0x0600614C RID: 24908 RVA: 0x00023E90 File Offset: 0x00022090
			public unsafe bool _apm
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteTask.NativeFieldInfoPtr__apm);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteTask.NativeFieldInfoPtr__apm)) = value;
				}
			}

			// Token: 0x1700193F RID: 6463
			// (get) Token: 0x0600614D RID: 24909 RVA: 0x001B53D8 File Offset: 0x001B35D8
			// (set) Token: 0x0600614E RID: 24910 RVA: 0x00023EAB File Offset: 0x000220AB
			public unsafe Stream _stream
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteTask.NativeFieldInfoPtr__stream);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteTask.NativeFieldInfoPtr__stream), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001940 RID: 6464
			// (get) Token: 0x0600614F RID: 24911 RVA: 0x001B5408 File Offset: 0x001B3608
			// (set) Token: 0x06006150 RID: 24912 RVA: 0x00023ECA File Offset: 0x000220CA
			public unsafe Il2CppStructArray<byte> _buffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteTask.NativeFieldInfoPtr__buffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteTask.NativeFieldInfoPtr__buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001941 RID: 6465
			// (get) Token: 0x06006151 RID: 24913 RVA: 0x001B5438 File Offset: 0x001B3638
			// (set) Token: 0x06006152 RID: 24914 RVA: 0x00023EE9 File Offset: 0x000220E9
			public unsafe int _offset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteTask.NativeFieldInfoPtr__offset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteTask.NativeFieldInfoPtr__offset)) = value;
				}
			}

			// Token: 0x17001942 RID: 6466
			// (get) Token: 0x06006153 RID: 24915 RVA: 0x001B5460 File Offset: 0x001B3660
			// (set) Token: 0x06006154 RID: 24916 RVA: 0x00023F04 File Offset: 0x00022104
			public unsafe int _count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteTask.NativeFieldInfoPtr__count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteTask.NativeFieldInfoPtr__count)) = value;
				}
			}

			// Token: 0x17001943 RID: 6467
			// (get) Token: 0x06006155 RID: 24917 RVA: 0x001B5488 File Offset: 0x001B3688
			// (set) Token: 0x06006156 RID: 24918 RVA: 0x00023F1F File Offset: 0x0002211F
			public unsafe AsyncCallback _callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteTask.NativeFieldInfoPtr__callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteTask.NativeFieldInfoPtr__callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001944 RID: 6468
			// (get) Token: 0x06006157 RID: 24919 RVA: 0x001B54B8 File Offset: 0x001B36B8
			// (set) Token: 0x06006158 RID: 24920 RVA: 0x00023F3E File Offset: 0x0002213E
			public unsafe ExecutionContext _context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteTask.NativeFieldInfoPtr__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteTask.NativeFieldInfoPtr__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001945 RID: 6469
			// (get) Token: 0x06006159 RID: 24921 RVA: 0x001B54E8 File Offset: 0x001B36E8
			// (set) Token: 0x0600615A RID: 24922 RVA: 0x00023F5D File Offset: 0x0002215D
			public unsafe static ContextCallback s_invokeAsyncCallback
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Stream.ReadWriteTask.NativeFieldInfoPtr_s_invokeAsyncCallback, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Stream.ReadWriteTask.NativeFieldInfoPtr_s_invokeAsyncCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004EB6 RID: 20150
			private static readonly IntPtr NativeFieldInfoPtr__isRead;

			// Token: 0x04004EB7 RID: 20151
			private static readonly IntPtr NativeFieldInfoPtr__apm;

			// Token: 0x04004EB8 RID: 20152
			private static readonly IntPtr NativeFieldInfoPtr__stream;

			// Token: 0x04004EB9 RID: 20153
			private static readonly IntPtr NativeFieldInfoPtr__buffer;

			// Token: 0x04004EBA RID: 20154
			private static readonly IntPtr NativeFieldInfoPtr__offset;

			// Token: 0x04004EBB RID: 20155
			private static readonly IntPtr NativeFieldInfoPtr__count;

			// Token: 0x04004EBC RID: 20156
			private static readonly IntPtr NativeFieldInfoPtr__callback;

			// Token: 0x04004EBD RID: 20157
			private static readonly IntPtr NativeFieldInfoPtr__context;

			// Token: 0x04004EBE RID: 20158
			private static readonly IntPtr NativeFieldInfoPtr_s_invokeAsyncCallback;

			// Token: 0x04004EBF RID: 20159
			private static readonly IntPtr NativeMethodInfoPtr_ClearBeginState_Internal_Void_0;

			// Token: 0x04004EC0 RID: 20160
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Func_2_Object_Int32_Object_Stream_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_0;

			// Token: 0x04004EC1 RID: 20161
			private static readonly IntPtr NativeMethodInfoPtr_InvokeAsyncCallback_Private_Static_Void_Object_0;

			// Token: 0x04004EC2 RID: 20162
			private static readonly IntPtr NativeMethodInfoPtr_System_Threading_Tasks_ITaskCompletionAction_Invoke_Private_Virtual_Final_New_Void_Task_0;

			// Token: 0x04004EC3 RID: 20163
			private static readonly IntPtr NativeMethodInfoPtr_System_Threading_Tasks_ITaskCompletionAction_get_InvokeMayRunArbitraryCode_Private_Virtual_Final_New_get_Boolean_0;
		}

		// Token: 0x02000725 RID: 1829
		public sealed class NullStream : Stream
		{
			// Token: 0x0600615B RID: 24923 RVA: 0x001B5510 File Offset: 0x001B3710
			// Note: this type is marked as 'beforefieldinit'.
			static NullStream()
			{
				Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Stream>.NativeClassPtr, "NullStream");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr);
				Stream.NullStream.NativeFieldInfoPtr_s_zeroTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, "s_zeroTask");
				Stream.NullStream.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100675857);
				Stream.NullStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100675858);
				Stream.NullStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100675859);
				Stream.NullStream.NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100675860);
				Stream.NullStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100675861);
				Stream.NullStream.NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100675862);
				Stream.NullStream.NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100675863);
				Stream.NullStream.NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Stream_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100675864);
				Stream.NullStream.NativeMethodInfoPtr_CopyToAsync_Public_Virtual_Task_Stream_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100675865);
				Stream.NullStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100675866);
				Stream.NullStream.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100675867);
				Stream.NullStream.NativeMethodInfoPtr_FlushAsync_Public_Virtual_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100675868);
				Stream.NullStream.NativeMethodInfoPtr_BeginRead_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100675869);
				Stream.NullStream.NativeMethodInfoPtr_EndRead_Public_Virtual_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100675870);
				Stream.NullStream.NativeMethodInfoPtr_BeginWrite_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100675871);
				Stream.NullStream.NativeMethodInfoPtr_EndWrite_Public_Virtual_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100675872);
				Stream.NullStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100675873);
				Stream.NullStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Span_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100675874);
				Stream.NullStream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100675875);
				Stream.NullStream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_ValueTask_1_Int32_Memory_1_Byte_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100675876);
				Stream.NullStream.NativeMethodInfoPtr_ReadByte_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100675877);
				Stream.NullStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100675878);
				Stream.NullStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_ReadOnlySpan_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100675879);
				Stream.NullStream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100675880);
				Stream.NullStream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_ValueTask_ReadOnlyMemory_1_Byte_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100675881);
				Stream.NullStream.NativeMethodInfoPtr_WriteByte_Public_Virtual_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100675882);
				Stream.NullStream.NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100675883);
				Stream.NullStream.NativeMethodInfoPtr_SetLength_Public_Virtual_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100675884);
			}

			// Token: 0x0600615C RID: 24924 RVA: 0x001B5780 File Offset: 0x001B3980
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431026, XrefRangeEnd = 1431030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NullStream()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001948 RID: 6472
			// (get) Token: 0x0600615D RID: 24925 RVA: 0x001B57BC File Offset: 0x001B39BC
			public unsafe override bool CanRead
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001949 RID: 6473
			// (get) Token: 0x0600615E RID: 24926 RVA: 0x001B57F8 File Offset: 0x001B39F8
			public unsafe override bool CanWrite
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700194A RID: 6474
			// (get) Token: 0x0600615F RID: 24927 RVA: 0x001B5834 File Offset: 0x001B3A34
			public unsafe override bool CanSeek
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700194B RID: 6475
			// (get) Token: 0x06006160 RID: 24928 RVA: 0x001B5870 File Offset: 0x001B3A70
			public unsafe override long Length
			{
				[CallerCount(74)]
				[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700194C RID: 6476
			// (get) Token: 0x06006161 RID: 24929 RVA: 0x001B58AC File Offset: 0x001B3AAC
			// (set) Token: 0x06006162 RID: 24930 RVA: 0x001B58E8 File Offset: 0x001B3AE8
			public unsafe override long Position
			{
				[CallerCount(74)]
				[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(21425)]
				[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06006163 RID: 24931 RVA: 0x001B5928 File Offset: 0x001B3B28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431030, XrefRangeEnd = 1431031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void CopyTo(Stream destination, int bufferSize)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Stream_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006164 RID: 24932 RVA: 0x001B5978 File Offset: 0x001B3B78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431031, XrefRangeEnd = 1431040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_CopyToAsync_Public_Virtual_Task_Stream_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}

			// Token: 0x06006165 RID: 24933 RVA: 0x001B59F0 File Offset: 0x001B3BF0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Dispose(bool disposing)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref disposing;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006166 RID: 24934 RVA: 0x001B5A30 File Offset: 0x001B3C30
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Flush()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006167 RID: 24935 RVA: 0x001B5A64 File Offset: 0x001B3C64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431040, XrefRangeEnd = 1431048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Task FlushAsync(CancellationToken cancellationToken)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_FlushAsync_Public_Virtual_Task_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
				}
			}

			// Token: 0x06006168 RID: 24936 RVA: 0x001B5ABC File Offset: 0x001B3CBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431048, XrefRangeEnd = 1431052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IAsyncResult BeginRead(Il2CppStructArray<byte> buffer, int offset, int count, AsyncCallback callback, Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_BeginRead_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06006169 RID: 24937 RVA: 0x001B5B50 File Offset: 0x001B3D50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431052, XrefRangeEnd = 1431058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int EndRead(IAsyncResult asyncResult)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_EndRead_Public_Virtual_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600616A RID: 24938 RVA: 0x001B5BA0 File Offset: 0x001B3DA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431058, XrefRangeEnd = 1431062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IAsyncResult BeginWrite(Il2CppStructArray<byte> buffer, int offset, int count, AsyncCallback callback, Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_BeginWrite_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600616B RID: 24939 RVA: 0x001B5C34 File Offset: 0x001B3E34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431062, XrefRangeEnd = 1431068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void EndWrite(IAsyncResult asyncResult)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_EndWrite_Public_Virtual_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600616C RID: 24940 RVA: 0x001B5C78 File Offset: 0x001B3E78
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Read(Il2CppStructArray<byte> buffer, int offset, int count)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600616D RID: 24941 RVA: 0x001B5CE4 File Offset: 0x001B3EE4
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Read(Span<byte> buffer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(buffer));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Span_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600616E RID: 24942 RVA: 0x001B5D38 File Offset: 0x001B3F38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431068, XrefRangeEnd = 1431072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Task<int> ReadAsync(Il2CppStructArray<byte> buffer, int offset, int count, CancellationToken cancellationToken)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
			}

			// Token: 0x0600616F RID: 24943 RVA: 0x001B5DBC File Offset: 0x001B3FBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431072, XrefRangeEnd = 1431074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = null)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(buffer));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_ValueTask_1_Int32_Memory_1_Byte_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ValueTask<int>(intPtr);
			}

			// Token: 0x06006170 RID: 24944 RVA: 0x001B5E20 File Offset: 0x001B4020
			[CallerCount(0)]
			public unsafe override int ReadByte()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_ReadByte_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06006171 RID: 24945 RVA: 0x001B5E5C File Offset: 0x001B405C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Write(Il2CppStructArray<byte> buffer, int offset, int count)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006172 RID: 24946 RVA: 0x001B5EBC File Offset: 0x001B40BC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Write(ReadOnlySpan<byte> buffer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(buffer));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_ReadOnlySpan_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006173 RID: 24947 RVA: 0x001B5F04 File Offset: 0x001B4104
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431074, XrefRangeEnd = 1431082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Task WriteAsync(Il2CppStructArray<byte> buffer, int offset, int count, CancellationToken cancellationToken)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}

			// Token: 0x06006174 RID: 24948 RVA: 0x001B5F88 File Offset: 0x001B4188
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431082, XrefRangeEnd = 1431092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = null)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(buffer));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_ValueTask_ReadOnlyMemory_1_Byte_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ValueTask(intPtr);
			}

			// Token: 0x06006175 RID: 24949 RVA: 0x001B5FEC File Offset: 0x001B41EC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void WriteByte(byte value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_WriteByte_Public_Virtual_Void_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006176 RID: 24950 RVA: 0x001B602C File Offset: 0x001B422C
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override long Seek(long offset, SeekOrigin origin)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref offset;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref origin;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06006177 RID: 24951 RVA: 0x001B6084 File Offset: 0x001B4284
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void SetLength(long length)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref length;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_SetLength_Public_Virtual_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006178 RID: 24952 RVA: 0x00023F6F File Offset: 0x0002216F
			public NullStream(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001947 RID: 6471
			// (get) Token: 0x06006179 RID: 24953 RVA: 0x001B60C4 File Offset: 0x001B42C4
			// (set) Token: 0x0600617A RID: 24954 RVA: 0x00023F78 File Offset: 0x00022178
			public unsafe static Task<int> s_zeroTask
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Stream.NullStream.NativeFieldInfoPtr_s_zeroTask, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Stream.NullStream.NativeFieldInfoPtr_s_zeroTask, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004EC4 RID: 20164
			private static readonly IntPtr NativeFieldInfoPtr_s_zeroTask;

			// Token: 0x04004EC5 RID: 20165
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

			// Token: 0x04004EC6 RID: 20166
			private static readonly IntPtr NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0;

			// Token: 0x04004EC7 RID: 20167
			private static readonly IntPtr NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0;

			// Token: 0x04004EC8 RID: 20168
			private static readonly IntPtr NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0;

			// Token: 0x04004EC9 RID: 20169
			private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0;

			// Token: 0x04004ECA RID: 20170
			private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0;

			// Token: 0x04004ECB RID: 20171
			private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0;

			// Token: 0x04004ECC RID: 20172
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Stream_Int32_0;

			// Token: 0x04004ECD RID: 20173
			private static readonly IntPtr NativeMethodInfoPtr_CopyToAsync_Public_Virtual_Task_Stream_Int32_CancellationToken_0;

			// Token: 0x04004ECE RID: 20174
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

			// Token: 0x04004ECF RID: 20175
			private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Virtual_Void_0;

			// Token: 0x04004ED0 RID: 20176
			private static readonly IntPtr NativeMethodInfoPtr_FlushAsync_Public_Virtual_Task_CancellationToken_0;

			// Token: 0x04004ED1 RID: 20177
			private static readonly IntPtr NativeMethodInfoPtr_BeginRead_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

			// Token: 0x04004ED2 RID: 20178
			private static readonly IntPtr NativeMethodInfoPtr_EndRead_Public_Virtual_Int32_IAsyncResult_0;

			// Token: 0x04004ED3 RID: 20179
			private static readonly IntPtr NativeMethodInfoPtr_BeginWrite_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

			// Token: 0x04004ED4 RID: 20180
			private static readonly IntPtr NativeMethodInfoPtr_EndWrite_Public_Virtual_Void_IAsyncResult_0;

			// Token: 0x04004ED5 RID: 20181
			private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

			// Token: 0x04004ED6 RID: 20182
			private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_Span_1_Byte_0;

			// Token: 0x04004ED7 RID: 20183
			private static readonly IntPtr NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

			// Token: 0x04004ED8 RID: 20184
			private static readonly IntPtr NativeMethodInfoPtr_ReadAsync_Public_Virtual_ValueTask_1_Int32_Memory_1_Byte_CancellationToken_0;

			// Token: 0x04004ED9 RID: 20185
			private static readonly IntPtr NativeMethodInfoPtr_ReadByte_Public_Virtual_Int32_0;

			// Token: 0x04004EDA RID: 20186
			private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

			// Token: 0x04004EDB RID: 20187
			private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_ReadOnlySpan_1_Byte_0;

			// Token: 0x04004EDC RID: 20188
			private static readonly IntPtr NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

			// Token: 0x04004EDD RID: 20189
			private static readonly IntPtr NativeMethodInfoPtr_WriteAsync_Public_Virtual_ValueTask_ReadOnlyMemory_1_Byte_CancellationToken_0;

			// Token: 0x04004EDE RID: 20190
			private static readonly IntPtr NativeMethodInfoPtr_WriteByte_Public_Virtual_Void_Byte_0;

			// Token: 0x04004EDF RID: 20191
			private static readonly IntPtr NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0;

			// Token: 0x04004EE0 RID: 20192
			private static readonly IntPtr NativeMethodInfoPtr_SetLength_Public_Virtual_Void_Int64_0;
		}

		// Token: 0x02000726 RID: 1830
		public sealed class SynchronousAsyncResult : Object
		{
			// Token: 0x0600617B RID: 24955 RVA: 0x001B60EC File Offset: 0x001B42EC
			// Note: this type is marked as 'beforefieldinit'.
			static SynchronousAsyncResult()
			{
				Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Stream>.NativeClassPtr, "SynchronousAsyncResult");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr);
				Stream.SynchronousAsyncResult.NativeFieldInfoPtr__stateObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, "_stateObject");
				Stream.SynchronousAsyncResult.NativeFieldInfoPtr__isWrite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, "_isWrite");
				Stream.SynchronousAsyncResult.NativeFieldInfoPtr__waitHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, "_waitHandle");
				Stream.SynchronousAsyncResult.NativeFieldInfoPtr__exceptionInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, "_exceptionInfo");
				Stream.SynchronousAsyncResult.NativeFieldInfoPtr__endXxxCalled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, "_endXxxCalled");
				Stream.SynchronousAsyncResult.NativeFieldInfoPtr__bytesRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, "_bytesRead");
				Stream.SynchronousAsyncResult.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, 100675886);
				Stream.SynchronousAsyncResult.NativeMethodInfoPtr__ctor_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, 100675887);
				Stream.SynchronousAsyncResult.NativeMethodInfoPtr__ctor_Internal_Void_Exception_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, 100675888);
				Stream.SynchronousAsyncResult.NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, 100675889);
				Stream.SynchronousAsyncResult.NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_Final_New_get_WaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, 100675890);
				Stream.SynchronousAsyncResult.NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, 100675891);
				Stream.SynchronousAsyncResult.NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, 100675892);
				Stream.SynchronousAsyncResult.NativeMethodInfoPtr_ThrowIfError_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, 100675893);
				Stream.SynchronousAsyncResult.NativeMethodInfoPtr_EndRead_Internal_Static_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, 100675894);
				Stream.SynchronousAsyncResult.NativeMethodInfoPtr_EndWrite_Internal_Static_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, 100675895);
			}

			// Token: 0x0600617C RID: 24956 RVA: 0x001B6258 File Offset: 0x001B4458
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431096, XrefRangeEnd = 1431098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SynchronousAsyncResult(int bytesRead, Object asyncStateObject)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref bytesRead;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asyncStateObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.SynchronousAsyncResult.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600617D RID: 24957 RVA: 0x001B62B4 File Offset: 0x001B44B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431098, XrefRangeEnd = 1431100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SynchronousAsyncResult(Object asyncStateObject)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncStateObject);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.SynchronousAsyncResult.NativeMethodInfoPtr__ctor_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600617E RID: 24958 RVA: 0x001B6300 File Offset: 0x001B4500
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1431104, RefRangeEnd = 1431106, XrefRangeStart = 1431100, XrefRangeEnd = 1431104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SynchronousAsyncResult(Exception ex, Object asyncStateObject, bool isWrite)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ex);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asyncStateObject);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isWrite;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.SynchronousAsyncResult.NativeMethodInfoPtr__ctor_Internal_Void_Exception_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001953 RID: 6483
			// (get) Token: 0x0600617F RID: 24959 RVA: 0x001B636C File Offset: 0x001B456C
			public unsafe bool IsCompleted
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.SynchronousAsyncResult.NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001954 RID: 6484
			// (get) Token: 0x06006180 RID: 24960 RVA: 0x001B63A8 File Offset: 0x001B45A8
			public unsafe WaitHandle AsyncWaitHandle
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431106, XrefRangeEnd = 1431124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.SynchronousAsyncResult.NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_Final_New_get_WaitHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<WaitHandle>(intPtr3) : null;
				}
			}

			// Token: 0x17001955 RID: 6485
			// (get) Token: 0x06006181 RID: 24961 RVA: 0x001B63E8 File Offset: 0x001B45E8
			public unsafe Object AsyncState
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.SynchronousAsyncResult.NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001956 RID: 6486
			// (get) Token: 0x06006182 RID: 24962 RVA: 0x001B6428 File Offset: 0x001B4628
			public unsafe bool CompletedSynchronously
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.SynchronousAsyncResult.NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006183 RID: 24963 RVA: 0x001B6464 File Offset: 0x001B4664
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431124, XrefRangeEnd = 1431125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ThrowIfError()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.SynchronousAsyncResult.NativeMethodInfoPtr_ThrowIfError_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006184 RID: 24964 RVA: 0x001B6498 File Offset: 0x001B4698
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431125, XrefRangeEnd = 1431128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int EndRead(IAsyncResult asyncResult)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.SynchronousAsyncResult.NativeMethodInfoPtr_EndRead_Internal_Static_Int32_IAsyncResult_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006185 RID: 24965 RVA: 0x001B64DC File Offset: 0x001B46DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431128, XrefRangeEnd = 1431131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void EndWrite(IAsyncResult asyncResult)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.SynchronousAsyncResult.NativeMethodInfoPtr_EndWrite_Internal_Static_Void_IAsyncResult_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006186 RID: 24966 RVA: 0x00023F8A File Offset: 0x0002218A
			public SynchronousAsyncResult(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700194D RID: 6477
			// (get) Token: 0x06006187 RID: 24967 RVA: 0x001B6514 File Offset: 0x001B4714
			// (set) Token: 0x06006188 RID: 24968 RVA: 0x00023F93 File Offset: 0x00022193
			public unsafe Object _stateObject
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.SynchronousAsyncResult.NativeFieldInfoPtr__stateObject);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.SynchronousAsyncResult.NativeFieldInfoPtr__stateObject), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700194E RID: 6478
			// (get) Token: 0x06006189 RID: 24969 RVA: 0x001B6544 File Offset: 0x001B4744
			// (set) Token: 0x0600618A RID: 24970 RVA: 0x00023FB2 File Offset: 0x000221B2
			public unsafe bool _isWrite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.SynchronousAsyncResult.NativeFieldInfoPtr__isWrite);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.SynchronousAsyncResult.NativeFieldInfoPtr__isWrite)) = value;
				}
			}

			// Token: 0x1700194F RID: 6479
			// (get) Token: 0x0600618B RID: 24971 RVA: 0x001B656C File Offset: 0x001B476C
			// (set) Token: 0x0600618C RID: 24972 RVA: 0x00023FCD File Offset: 0x000221CD
			public unsafe ManualResetEvent _waitHandle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.SynchronousAsyncResult.NativeFieldInfoPtr__waitHandle);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManualResetEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.SynchronousAsyncResult.NativeFieldInfoPtr__waitHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001950 RID: 6480
			// (get) Token: 0x0600618D RID: 24973 RVA: 0x001B659C File Offset: 0x001B479C
			// (set) Token: 0x0600618E RID: 24974 RVA: 0x00023FEC File Offset: 0x000221EC
			public unsafe ExceptionDispatchInfo _exceptionInfo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.SynchronousAsyncResult.NativeFieldInfoPtr__exceptionInfo);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExceptionDispatchInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.SynchronousAsyncResult.NativeFieldInfoPtr__exceptionInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001951 RID: 6481
			// (get) Token: 0x0600618F RID: 24975 RVA: 0x001B65CC File Offset: 0x001B47CC
			// (set) Token: 0x06006190 RID: 24976 RVA: 0x0002400B File Offset: 0x0002220B
			public unsafe bool _endXxxCalled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.SynchronousAsyncResult.NativeFieldInfoPtr__endXxxCalled);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.SynchronousAsyncResult.NativeFieldInfoPtr__endXxxCalled)) = value;
				}
			}

			// Token: 0x17001952 RID: 6482
			// (get) Token: 0x06006191 RID: 24977 RVA: 0x001B65F4 File Offset: 0x001B47F4
			// (set) Token: 0x06006192 RID: 24978 RVA: 0x00024026 File Offset: 0x00022226
			public unsafe int _bytesRead
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.SynchronousAsyncResult.NativeFieldInfoPtr__bytesRead);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.SynchronousAsyncResult.NativeFieldInfoPtr__bytesRead)) = value;
				}
			}

			// Token: 0x04004EE1 RID: 20193
			private static readonly IntPtr NativeFieldInfoPtr__stateObject;

			// Token: 0x04004EE2 RID: 20194
			private static readonly IntPtr NativeFieldInfoPtr__isWrite;

			// Token: 0x04004EE3 RID: 20195
			private static readonly IntPtr NativeFieldInfoPtr__waitHandle;

			// Token: 0x04004EE4 RID: 20196
			private static readonly IntPtr NativeFieldInfoPtr__exceptionInfo;

			// Token: 0x04004EE5 RID: 20197
			private static readonly IntPtr NativeFieldInfoPtr__endXxxCalled;

			// Token: 0x04004EE6 RID: 20198
			private static readonly IntPtr NativeFieldInfoPtr__bytesRead;

			// Token: 0x04004EE7 RID: 20199
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Object_0;

			// Token: 0x04004EE8 RID: 20200
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Object_0;

			// Token: 0x04004EE9 RID: 20201
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Exception_Object_Boolean_0;

			// Token: 0x04004EEA RID: 20202
			private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04004EEB RID: 20203
			private static readonly IntPtr NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_Final_New_get_WaitHandle_0;

			// Token: 0x04004EEC RID: 20204
			private static readonly IntPtr NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x04004EED RID: 20205
			private static readonly IntPtr NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04004EEE RID: 20206
			private static readonly IntPtr NativeMethodInfoPtr_ThrowIfError_Internal_Void_0;

			// Token: 0x04004EEF RID: 20207
			private static readonly IntPtr NativeMethodInfoPtr_EndRead_Internal_Static_Int32_IAsyncResult_0;

			// Token: 0x04004EF0 RID: 20208
			private static readonly IntPtr NativeMethodInfoPtr_EndWrite_Internal_Static_Void_IAsyncResult_0;

			// Token: 0x02000795 RID: 1941
			[ObfuscatedName("System.IO.Stream+SynchronousAsyncResult+<>c")]
			[Serializable]
			public sealed class __c : Object
			{
				// Token: 0x0600635E RID: 25438 RVA: 0x001BAF50 File Offset: 0x001B9150
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<Stream.SynchronousAsyncResult.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Stream.SynchronousAsyncResult.__c>.NativeClassPtr);
					Stream.SynchronousAsyncResult.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.SynchronousAsyncResult.__c>.NativeClassPtr, "<>9");
					Stream.SynchronousAsyncResult.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.SynchronousAsyncResult.__c>.NativeClassPtr, "<>9__12_0");
					Stream.SynchronousAsyncResult.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.SynchronousAsyncResult.__c>.NativeClassPtr, 100675897);
					Stream.SynchronousAsyncResult.__c.NativeMethodInfoPtr__get_AsyncWaitHandle_b__12_0_Internal_ManualResetEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.SynchronousAsyncResult.__c>.NativeClassPtr, 100675898);
				}

				// Token: 0x0600635F RID: 25439 RVA: 0x001BAFCC File Offset: 0x001B91CC
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stream.SynchronousAsyncResult.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.SynchronousAsyncResult.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06006360 RID: 25440 RVA: 0x001BB008 File Offset: 0x001B9208
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431092, XrefRangeEnd = 1431096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ManualResetEvent _get_AsyncWaitHandle_b__12_0()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.SynchronousAsyncResult.__c.NativeMethodInfoPtr__get_AsyncWaitHandle_b__12_0_Internal_ManualResetEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ManualResetEvent>(intPtr3) : null;
				}

				// Token: 0x06006361 RID: 25441 RVA: 0x000253A5 File Offset: 0x000235A5
				public __c(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170019AC RID: 6572
				// (get) Token: 0x06006362 RID: 25442 RVA: 0x001BB048 File Offset: 0x001B9248
				// (set) Token: 0x06006363 RID: 25443 RVA: 0x000253AE File Offset: 0x000235AE
				public unsafe static Stream.SynchronousAsyncResult.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(Stream.SynchronousAsyncResult.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream.SynchronousAsyncResult.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Stream.SynchronousAsyncResult.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170019AD RID: 6573
				// (get) Token: 0x06006364 RID: 25444 RVA: 0x001BB070 File Offset: 0x001B9270
				// (set) Token: 0x06006365 RID: 25445 RVA: 0x000253C0 File Offset: 0x000235C0
				public unsafe static Func<ManualResetEvent> __9__12_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(Stream.SynchronousAsyncResult.__c.NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ManualResetEvent>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Stream.SynchronousAsyncResult.__c.NativeFieldInfoPtr___9__12_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04005114 RID: 20756
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x04005115 RID: 20757
				private static readonly IntPtr NativeFieldInfoPtr___9__12_0;

				// Token: 0x04005116 RID: 20758
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04005117 RID: 20759
				private static readonly IntPtr NativeMethodInfoPtr__get_AsyncWaitHandle_b__12_0_Internal_ManualResetEvent_0;
			}
		}

		// Token: 0x02000727 RID: 1831
		[ObfuscatedName("System.IO.Stream+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06006193 RID: 24979 RVA: 0x001B661C File Offset: 0x001B481C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Stream.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Stream>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr);
				Stream.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, "<>9");
				Stream.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, "<>9__4_0");
				Stream.__c.NativeFieldInfoPtr___9__37_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, "<>9__37_0");
				Stream.__c.NativeFieldInfoPtr___9__40_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, "<>9__40_0");
				Stream.__c.NativeFieldInfoPtr___9__45_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, "<>9__45_0");
				Stream.__c.NativeFieldInfoPtr___9__45_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, "<>9__45_1");
				Stream.__c.NativeFieldInfoPtr___9__48_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, "<>9__48_0");
				Stream.__c.NativeFieldInfoPtr___9__49_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, "<>9__49_0");
				Stream.__c.NativeFieldInfoPtr___9__58_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, "<>9__58_0");
				Stream.__c.NativeFieldInfoPtr___9__58_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, "<>9__58_1");
				Stream.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, 100675900);
				Stream.__c.NativeMethodInfoPtr__EnsureAsyncActiveSemaphoreInitialized_b__4_0_Internal_SemaphoreSlim_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, 100675901);
				Stream.__c.NativeMethodInfoPtr__FlushAsync_b__37_0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, 100675902);
				Stream.__c.NativeMethodInfoPtr__BeginReadInternal_b__40_0_Internal_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, 100675903);
				Stream.__c.NativeMethodInfoPtr__BeginEndReadAsync_b__45_0_Internal_IAsyncResult_Stream_ReadWriteParameters_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, 100675904);
				Stream.__c.NativeMethodInfoPtr__BeginEndReadAsync_b__45_1_Internal_Int32_Stream_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, 100675905);
				Stream.__c.NativeMethodInfoPtr__BeginWriteInternal_b__48_0_Internal_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, 100675906);
				Stream.__c.NativeMethodInfoPtr__RunReadWriteTaskWhenReady_b__49_0_Internal_Void_Task_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, 100675907);
				Stream.__c.NativeMethodInfoPtr__BeginEndWriteAsync_b__58_0_Internal_IAsyncResult_Stream_ReadWriteParameters_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, 100675908);
				Stream.__c.NativeMethodInfoPtr__BeginEndWriteAsync_b__58_1_Internal_VoidTaskResult_Stream_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, 100675909);
			}

			// Token: 0x06006194 RID: 24980 RVA: 0x001B67D8 File Offset: 0x001B49D8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006195 RID: 24981 RVA: 0x001B6814 File Offset: 0x001B4A14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431131, XrefRangeEnd = 1431135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SemaphoreSlim _EnsureAsyncActiveSemaphoreInitialized_b__4_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.__c.NativeMethodInfoPtr__EnsureAsyncActiveSemaphoreInitialized_b__4_0_Internal_SemaphoreSlim_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SemaphoreSlim>(intPtr3) : null;
			}

			// Token: 0x06006196 RID: 24982 RVA: 0x001B6854 File Offset: 0x001B4A54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431135, XrefRangeEnd = 1431139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _FlushAsync_b__37_0(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.__c.NativeMethodInfoPtr__FlushAsync_b__37_0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006197 RID: 24983 RVA: 0x001B6898 File Offset: 0x001B4A98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431139, XrefRangeEnd = 1431152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _BeginReadInternal_b__40_0(Object <p0>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.__c.NativeMethodInfoPtr__BeginReadInternal_b__40_0_Internal_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006198 RID: 24984 RVA: 0x001B68E8 File Offset: 0x001B4AE8
			[CallerCount(0)]
			public unsafe IAsyncResult _BeginEndReadAsync_b__45_0(Stream stream, Stream.ReadWriteParameters args, AsyncCallback callback, Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.__c.NativeMethodInfoPtr__BeginEndReadAsync_b__45_0_Internal_IAsyncResult_Stream_ReadWriteParameters_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06006199 RID: 24985 RVA: 0x001B6974 File Offset: 0x001B4B74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431152, XrefRangeEnd = 1431153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _BeginEndReadAsync_b__45_1(Stream stream, IAsyncResult asyncResult)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.__c.NativeMethodInfoPtr__BeginEndReadAsync_b__45_1_Internal_Int32_Stream_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600619A RID: 24986 RVA: 0x001B69D4 File Offset: 0x001B4BD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431153, XrefRangeEnd = 1431166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _BeginWriteInternal_b__48_0(Object <p0>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.__c.NativeMethodInfoPtr__BeginWriteInternal_b__48_0_Internal_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600619B RID: 24987 RVA: 0x001B6A24 File Offset: 0x001B4C24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431166, XrefRangeEnd = 1431171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RunReadWriteTaskWhenReady_b__49_0(Task t, Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.__c.NativeMethodInfoPtr__RunReadWriteTaskWhenReady_b__49_0_Internal_Void_Task_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600619C RID: 24988 RVA: 0x001B6A78 File Offset: 0x001B4C78
			[CallerCount(0)]
			public unsafe IAsyncResult _BeginEndWriteAsync_b__58_0(Stream stream, Stream.ReadWriteParameters args, AsyncCallback callback, Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.__c.NativeMethodInfoPtr__BeginEndWriteAsync_b__58_0_Internal_IAsyncResult_Stream_ReadWriteParameters_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600619D RID: 24989 RVA: 0x001B6B04 File Offset: 0x001B4D04
			[CallerCount(0)]
			public unsafe VoidTaskResult _BeginEndWriteAsync_b__58_1(Stream stream, IAsyncResult asyncResult)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.__c.NativeMethodInfoPtr__BeginEndWriteAsync_b__58_1_Internal_VoidTaskResult_Stream_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600619E RID: 24990 RVA: 0x00024041 File Offset: 0x00022241
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001957 RID: 6487
			// (get) Token: 0x0600619F RID: 24991 RVA: 0x001B6B64 File Offset: 0x001B4D64
			// (set) Token: 0x060061A0 RID: 24992 RVA: 0x0002404A File Offset: 0x0002224A
			public unsafe static Stream.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Stream.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Stream.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001958 RID: 6488
			// (get) Token: 0x060061A1 RID: 24993 RVA: 0x001B6B8C File Offset: 0x001B4D8C
			// (set) Token: 0x060061A2 RID: 24994 RVA: 0x0002405C File Offset: 0x0002225C
			public unsafe static Func<SemaphoreSlim> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Stream.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SemaphoreSlim>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Stream.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001959 RID: 6489
			// (get) Token: 0x060061A3 RID: 24995 RVA: 0x001B6BB4 File Offset: 0x001B4DB4
			// (set) Token: 0x060061A4 RID: 24996 RVA: 0x0002406E File Offset: 0x0002226E
			public unsafe static Action<Object> __9__37_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Stream.__c.NativeFieldInfoPtr___9__37_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Stream.__c.NativeFieldInfoPtr___9__37_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700195A RID: 6490
			// (get) Token: 0x060061A5 RID: 24997 RVA: 0x001B6BDC File Offset: 0x001B4DDC
			// (set) Token: 0x060061A6 RID: 24998 RVA: 0x00024080 File Offset: 0x00022280
			public unsafe static Func<Object, int> __9__40_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Stream.__c.NativeFieldInfoPtr___9__40_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Stream.__c.NativeFieldInfoPtr___9__40_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700195B RID: 6491
			// (get) Token: 0x060061A7 RID: 24999 RVA: 0x001B6C04 File Offset: 0x001B4E04
			// (set) Token: 0x060061A8 RID: 25000 RVA: 0x00024092 File Offset: 0x00022292
			public unsafe static Func<Stream, Stream.ReadWriteParameters, AsyncCallback, Object, IAsyncResult> __9__45_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Stream.__c.NativeFieldInfoPtr___9__45_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Stream, Stream.ReadWriteParameters, AsyncCallback, Object, IAsyncResult>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Stream.__c.NativeFieldInfoPtr___9__45_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700195C RID: 6492
			// (get) Token: 0x060061A9 RID: 25001 RVA: 0x001B6C2C File Offset: 0x001B4E2C
			// (set) Token: 0x060061AA RID: 25002 RVA: 0x000240A4 File Offset: 0x000222A4
			public unsafe static Func<Stream, IAsyncResult, int> __9__45_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Stream.__c.NativeFieldInfoPtr___9__45_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Stream, IAsyncResult, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Stream.__c.NativeFieldInfoPtr___9__45_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700195D RID: 6493
			// (get) Token: 0x060061AB RID: 25003 RVA: 0x001B6C54 File Offset: 0x001B4E54
			// (set) Token: 0x060061AC RID: 25004 RVA: 0x000240B6 File Offset: 0x000222B6
			public unsafe static Func<Object, int> __9__48_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Stream.__c.NativeFieldInfoPtr___9__48_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Stream.__c.NativeFieldInfoPtr___9__48_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700195E RID: 6494
			// (get) Token: 0x060061AD RID: 25005 RVA: 0x001B6C7C File Offset: 0x001B4E7C
			// (set) Token: 0x060061AE RID: 25006 RVA: 0x000240C8 File Offset: 0x000222C8
			public unsafe static Action<Task, Object> __9__49_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Stream.__c.NativeFieldInfoPtr___9__49_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Task, Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Stream.__c.NativeFieldInfoPtr___9__49_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700195F RID: 6495
			// (get) Token: 0x060061AF RID: 25007 RVA: 0x001B6CA4 File Offset: 0x001B4EA4
			// (set) Token: 0x060061B0 RID: 25008 RVA: 0x000240DA File Offset: 0x000222DA
			public unsafe static Func<Stream, Stream.ReadWriteParameters, AsyncCallback, Object, IAsyncResult> __9__58_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Stream.__c.NativeFieldInfoPtr___9__58_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Stream, Stream.ReadWriteParameters, AsyncCallback, Object, IAsyncResult>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Stream.__c.NativeFieldInfoPtr___9__58_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001960 RID: 6496
			// (get) Token: 0x060061B1 RID: 25009 RVA: 0x001B6CCC File Offset: 0x001B4ECC
			// (set) Token: 0x060061B2 RID: 25010 RVA: 0x000240EC File Offset: 0x000222EC
			public unsafe static Func<Stream, IAsyncResult, VoidTaskResult> __9__58_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Stream.__c.NativeFieldInfoPtr___9__58_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Stream, IAsyncResult, VoidTaskResult>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Stream.__c.NativeFieldInfoPtr___9__58_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004EF1 RID: 20209
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04004EF2 RID: 20210
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x04004EF3 RID: 20211
			private static readonly IntPtr NativeFieldInfoPtr___9__37_0;

			// Token: 0x04004EF4 RID: 20212
			private static readonly IntPtr NativeFieldInfoPtr___9__40_0;

			// Token: 0x04004EF5 RID: 20213
			private static readonly IntPtr NativeFieldInfoPtr___9__45_0;

			// Token: 0x04004EF6 RID: 20214
			private static readonly IntPtr NativeFieldInfoPtr___9__45_1;

			// Token: 0x04004EF7 RID: 20215
			private static readonly IntPtr NativeFieldInfoPtr___9__48_0;

			// Token: 0x04004EF8 RID: 20216
			private static readonly IntPtr NativeFieldInfoPtr___9__49_0;

			// Token: 0x04004EF9 RID: 20217
			private static readonly IntPtr NativeFieldInfoPtr___9__58_0;

			// Token: 0x04004EFA RID: 20218
			private static readonly IntPtr NativeFieldInfoPtr___9__58_1;

			// Token: 0x04004EFB RID: 20219
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004EFC RID: 20220
			private static readonly IntPtr NativeMethodInfoPtr__EnsureAsyncActiveSemaphoreInitialized_b__4_0_Internal_SemaphoreSlim_0;

			// Token: 0x04004EFD RID: 20221
			private static readonly IntPtr NativeMethodInfoPtr__FlushAsync_b__37_0_Internal_Void_Object_0;

			// Token: 0x04004EFE RID: 20222
			private static readonly IntPtr NativeMethodInfoPtr__BeginReadInternal_b__40_0_Internal_Int32_Object_0;

			// Token: 0x04004EFF RID: 20223
			private static readonly IntPtr NativeMethodInfoPtr__BeginEndReadAsync_b__45_0_Internal_IAsyncResult_Stream_ReadWriteParameters_AsyncCallback_Object_0;

			// Token: 0x04004F00 RID: 20224
			private static readonly IntPtr NativeMethodInfoPtr__BeginEndReadAsync_b__45_1_Internal_Int32_Stream_IAsyncResult_0;

			// Token: 0x04004F01 RID: 20225
			private static readonly IntPtr NativeMethodInfoPtr__BeginWriteInternal_b__48_0_Internal_Int32_Object_0;

			// Token: 0x04004F02 RID: 20226
			private static readonly IntPtr NativeMethodInfoPtr__RunReadWriteTaskWhenReady_b__49_0_Internal_Void_Task_Object_0;

			// Token: 0x04004F03 RID: 20227
			private static readonly IntPtr NativeMethodInfoPtr__BeginEndWriteAsync_b__58_0_Internal_IAsyncResult_Stream_ReadWriteParameters_AsyncCallback_Object_0;

			// Token: 0x04004F04 RID: 20228
			private static readonly IntPtr NativeMethodInfoPtr__BeginEndWriteAsync_b__58_1_Internal_VoidTaskResult_Stream_IAsyncResult_0;
		}

		// Token: 0x02000728 RID: 1832
		[ObfuscatedName("System.IO.Stream+<CopyToAsyncInternal>d__28")]
		public sealed class _CopyToAsyncInternal_d__28 : ValueType
		{
			// Token: 0x060061B3 RID: 25011 RVA: 0x001B6CF4 File Offset: 0x001B4EF4
			// Note: this type is marked as 'beforefieldinit'.
			static _CopyToAsyncInternal_d__28()
			{
				Il2CppClassPointerStore<Stream._CopyToAsyncInternal_d__28>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Stream>.NativeClassPtr, "<CopyToAsyncInternal>d__28");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Stream._CopyToAsyncInternal_d__28>.NativeClassPtr);
				Stream._CopyToAsyncInternal_d__28.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream._CopyToAsyncInternal_d__28>.NativeClassPtr, "<>1__state");
				Stream._CopyToAsyncInternal_d__28.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream._CopyToAsyncInternal_d__28>.NativeClassPtr, "<>t__builder");
				Stream._CopyToAsyncInternal_d__28.NativeFieldInfoPtr_bufferSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream._CopyToAsyncInternal_d__28>.NativeClassPtr, "bufferSize");
				Stream._CopyToAsyncInternal_d__28.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream._CopyToAsyncInternal_d__28>.NativeClassPtr, "<>4__this");
				Stream._CopyToAsyncInternal_d__28.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream._CopyToAsyncInternal_d__28>.NativeClassPtr, "cancellationToken");
				Stream._CopyToAsyncInternal_d__28.NativeFieldInfoPtr_destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream._CopyToAsyncInternal_d__28>.NativeClassPtr, "destination");
				Stream._CopyToAsyncInternal_d__28.NativeFieldInfoPtr__buffer_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream._CopyToAsyncInternal_d__28>.NativeClassPtr, "<buffer>5__2");
				Stream._CopyToAsyncInternal_d__28.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream._CopyToAsyncInternal_d__28>.NativeClassPtr, "<>u__1");
				Stream._CopyToAsyncInternal_d__28.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream._CopyToAsyncInternal_d__28>.NativeClassPtr, "<>u__2");
				Stream._CopyToAsyncInternal_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream._CopyToAsyncInternal_d__28>.NativeClassPtr, 100675910);
				Stream._CopyToAsyncInternal_d__28.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream._CopyToAsyncInternal_d__28>.NativeClassPtr, 100675911);
			}

			// Token: 0x060061B4 RID: 25012 RVA: 0x001B6DFC File Offset: 0x001B4FFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431171, XrefRangeEnd = 1431255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream._CopyToAsyncInternal_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060061B5 RID: 25013 RVA: 0x001B6E34 File Offset: 0x001B5034
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431255, XrefRangeEnd = 1431259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream._CopyToAsyncInternal_d__28.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060061B6 RID: 25014 RVA: 0x000240FE File Offset: 0x000222FE
			public _CopyToAsyncInternal_d__28(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060061B7 RID: 25015 RVA: 0x00024107 File Offset: 0x00022307
			public _CopyToAsyncInternal_d__28()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stream._CopyToAsyncInternal_d__28>.NativeClassPtr))
			{
			}

			// Token: 0x17001961 RID: 6497
			// (get) Token: 0x060061B8 RID: 25016 RVA: 0x001B6E7C File Offset: 0x001B507C
			// (set) Token: 0x060061B9 RID: 25017 RVA: 0x00024119 File Offset: 0x00022319
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream._CopyToAsyncInternal_d__28.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream._CopyToAsyncInternal_d__28.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001962 RID: 6498
			// (get) Token: 0x060061BA RID: 25018 RVA: 0x001B6EA4 File Offset: 0x001B50A4
			// (set) Token: 0x060061BB RID: 25019 RVA: 0x00024134 File Offset: 0x00022334
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream._CopyToAsyncInternal_d__28.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream._CopyToAsyncInternal_d__28.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001963 RID: 6499
			// (get) Token: 0x060061BC RID: 25020 RVA: 0x001B6ED4 File Offset: 0x001B50D4
			// (set) Token: 0x060061BD RID: 25021 RVA: 0x00024162 File Offset: 0x00022362
			public unsafe int bufferSize
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream._CopyToAsyncInternal_d__28.NativeFieldInfoPtr_bufferSize);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream._CopyToAsyncInternal_d__28.NativeFieldInfoPtr_bufferSize)) = value;
				}
			}

			// Token: 0x17001964 RID: 6500
			// (get) Token: 0x060061BE RID: 25022 RVA: 0x001B6EFC File Offset: 0x001B50FC
			// (set) Token: 0x060061BF RID: 25023 RVA: 0x0002417D File Offset: 0x0002237D
			public unsafe Stream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream._CopyToAsyncInternal_d__28.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream._CopyToAsyncInternal_d__28.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001965 RID: 6501
			// (get) Token: 0x060061C0 RID: 25024 RVA: 0x001B6F2C File Offset: 0x001B512C
			// (set) Token: 0x060061C1 RID: 25025 RVA: 0x0002419C File Offset: 0x0002239C
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream._CopyToAsyncInternal_d__28.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream._CopyToAsyncInternal_d__28.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001966 RID: 6502
			// (get) Token: 0x060061C2 RID: 25026 RVA: 0x001B6F5C File Offset: 0x001B515C
			// (set) Token: 0x060061C3 RID: 25027 RVA: 0x000241CA File Offset: 0x000223CA
			public unsafe Stream destination
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream._CopyToAsyncInternal_d__28.NativeFieldInfoPtr_destination);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream._CopyToAsyncInternal_d__28.NativeFieldInfoPtr_destination), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001967 RID: 6503
			// (get) Token: 0x060061C4 RID: 25028 RVA: 0x001B6F8C File Offset: 0x001B518C
			// (set) Token: 0x060061C5 RID: 25029 RVA: 0x000241E9 File Offset: 0x000223E9
			public unsafe Il2CppStructArray<byte> _buffer_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream._CopyToAsyncInternal_d__28.NativeFieldInfoPtr__buffer_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream._CopyToAsyncInternal_d__28.NativeFieldInfoPtr__buffer_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001968 RID: 6504
			// (get) Token: 0x060061C6 RID: 25030 RVA: 0x001B6FBC File Offset: 0x001B51BC
			// (set) Token: 0x060061C7 RID: 25031 RVA: 0x00024208 File Offset: 0x00022408
			public ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream._CopyToAsyncInternal_d__28.NativeFieldInfoPtr___u__1);
					return new ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream._CopyToAsyncInternal_d__28.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001969 RID: 6505
			// (get) Token: 0x060061C8 RID: 25032 RVA: 0x001B6FEC File Offset: 0x001B51EC
			// (set) Token: 0x060061C9 RID: 25033 RVA: 0x00024236 File Offset: 0x00022436
			public ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream._CopyToAsyncInternal_d__28.NativeFieldInfoPtr___u__2);
					return new ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream._CopyToAsyncInternal_d__28.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04004F05 RID: 20229
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004F06 RID: 20230
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04004F07 RID: 20231
			private static readonly IntPtr NativeFieldInfoPtr_bufferSize;

			// Token: 0x04004F08 RID: 20232
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004F09 RID: 20233
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04004F0A RID: 20234
			private static readonly IntPtr NativeFieldInfoPtr_destination;

			// Token: 0x04004F0B RID: 20235
			private static readonly IntPtr NativeFieldInfoPtr__buffer_5__2;

			// Token: 0x04004F0C RID: 20236
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04004F0D RID: 20237
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04004F0E RID: 20238
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004F0F RID: 20239
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000729 RID: 1833
		[ObfuscatedName("System.IO.Stream+<FinishWriteAsync>d__57")]
		public sealed class _FinishWriteAsync_d__57 : ValueType
		{
			// Token: 0x060061CA RID: 25034 RVA: 0x001B701C File Offset: 0x001B521C
			// Note: this type is marked as 'beforefieldinit'.
			static _FinishWriteAsync_d__57()
			{
				Il2CppClassPointerStore<Stream._FinishWriteAsync_d__57>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Stream>.NativeClassPtr, "<FinishWriteAsync>d__57");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Stream._FinishWriteAsync_d__57>.NativeClassPtr);
				Stream._FinishWriteAsync_d__57.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream._FinishWriteAsync_d__57>.NativeClassPtr, "<>1__state");
				Stream._FinishWriteAsync_d__57.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream._FinishWriteAsync_d__57>.NativeClassPtr, "<>t__builder");
				Stream._FinishWriteAsync_d__57.NativeFieldInfoPtr_writeTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream._FinishWriteAsync_d__57>.NativeClassPtr, "writeTask");
				Stream._FinishWriteAsync_d__57.NativeFieldInfoPtr_localBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream._FinishWriteAsync_d__57>.NativeClassPtr, "localBuffer");
				Stream._FinishWriteAsync_d__57.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream._FinishWriteAsync_d__57>.NativeClassPtr, "<>u__1");
				Stream._FinishWriteAsync_d__57.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream._FinishWriteAsync_d__57>.NativeClassPtr, 100675912);
				Stream._FinishWriteAsync_d__57.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream._FinishWriteAsync_d__57>.NativeClassPtr, 100675913);
			}

			// Token: 0x060061CB RID: 25035 RVA: 0x001B70D4 File Offset: 0x001B52D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431259, XrefRangeEnd = 1431271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream._FinishWriteAsync_d__57.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060061CC RID: 25036 RVA: 0x001B710C File Offset: 0x001B530C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431271, XrefRangeEnd = 1431275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream._FinishWriteAsync_d__57.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060061CD RID: 25037 RVA: 0x00024264 File Offset: 0x00022464
			public _FinishWriteAsync_d__57(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060061CE RID: 25038 RVA: 0x0002426D File Offset: 0x0002246D
			public _FinishWriteAsync_d__57()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stream._FinishWriteAsync_d__57>.NativeClassPtr))
			{
			}

			// Token: 0x1700196A RID: 6506
			// (get) Token: 0x060061CF RID: 25039 RVA: 0x001B7154 File Offset: 0x001B5354
			// (set) Token: 0x060061D0 RID: 25040 RVA: 0x0002427F File Offset: 0x0002247F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream._FinishWriteAsync_d__57.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream._FinishWriteAsync_d__57.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700196B RID: 6507
			// (get) Token: 0x060061D1 RID: 25041 RVA: 0x001B717C File Offset: 0x001B537C
			// (set) Token: 0x060061D2 RID: 25042 RVA: 0x0002429A File Offset: 0x0002249A
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream._FinishWriteAsync_d__57.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream._FinishWriteAsync_d__57.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700196C RID: 6508
			// (get) Token: 0x060061D3 RID: 25043 RVA: 0x001B71AC File Offset: 0x001B53AC
			// (set) Token: 0x060061D4 RID: 25044 RVA: 0x000242C8 File Offset: 0x000224C8
			public unsafe Task writeTask
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream._FinishWriteAsync_d__57.NativeFieldInfoPtr_writeTask);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream._FinishWriteAsync_d__57.NativeFieldInfoPtr_writeTask), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700196D RID: 6509
			// (get) Token: 0x060061D5 RID: 25045 RVA: 0x001B71DC File Offset: 0x001B53DC
			// (set) Token: 0x060061D6 RID: 25046 RVA: 0x000242E7 File Offset: 0x000224E7
			public unsafe Il2CppStructArray<byte> localBuffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream._FinishWriteAsync_d__57.NativeFieldInfoPtr_localBuffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream._FinishWriteAsync_d__57.NativeFieldInfoPtr_localBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700196E RID: 6510
			// (get) Token: 0x060061D7 RID: 25047 RVA: 0x001B720C File Offset: 0x001B540C
			// (set) Token: 0x060061D8 RID: 25048 RVA: 0x00024306 File Offset: 0x00022506
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream._FinishWriteAsync_d__57.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream._FinishWriteAsync_d__57.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04004F10 RID: 20240
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004F11 RID: 20241
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04004F12 RID: 20242
			private static readonly IntPtr NativeFieldInfoPtr_writeTask;

			// Token: 0x04004F13 RID: 20243
			private static readonly IntPtr NativeFieldInfoPtr_localBuffer;

			// Token: 0x04004F14 RID: 20244
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04004F15 RID: 20245
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004F16 RID: 20246
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200072A RID: 1834
		[ObfuscatedName("System.IO.Stream+<<ReadAsync>g__FinishReadAsync|44_0>d")]
		public sealed class ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1TaInre1ByloInUnique : ValueType
		{
			// Token: 0x060061D9 RID: 25049 RVA: 0x001B723C File Offset: 0x001B543C
			// Note: this type is marked as 'beforefieldinit'.
			static ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1TaInre1ByloInUnique()
			{
				Il2CppClassPointerStore<Stream.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1TaInre1ByloInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Stream>.NativeClassPtr, "<<ReadAsync>g__FinishReadAsync|44_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Stream.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1TaInre1ByloInUnique>.NativeClassPtr);
				Stream.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1TaInre1ByloInUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1TaInre1ByloInUnique>.NativeClassPtr, "<>1__state");
				Stream.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1TaInre1ByloInUnique.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1TaInre1ByloInUnique>.NativeClassPtr, "<>t__builder");
				Stream.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1TaInre1ByloInUnique.NativeFieldInfoPtr_readTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1TaInre1ByloInUnique>.NativeClassPtr, "readTask");
				Stream.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1TaInre1ByloInUnique.NativeFieldInfoPtr_localBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1TaInre1ByloInUnique>.NativeClassPtr, "localBuffer");
				Stream.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1TaInre1ByloInUnique.NativeFieldInfoPtr_localDestination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1TaInre1ByloInUnique>.NativeClassPtr, "localDestination");
				Stream.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1TaInre1ByloInUnique.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1TaInre1ByloInUnique>.NativeClassPtr, "<>u__1");
				Stream.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1TaInre1ByloInUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1TaInre1ByloInUnique>.NativeClassPtr, 100675914);
				Stream.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1TaInre1ByloInUnique.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1TaInre1ByloInUnique>.NativeClassPtr, 100675915);
			}

			// Token: 0x060061DA RID: 25050 RVA: 0x001B7308 File Offset: 0x001B5508
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431275, XrefRangeEnd = 1431303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1TaInre1ByloInUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060061DB RID: 25051 RVA: 0x001B7340 File Offset: 0x001B5540
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1431303, XrefRangeEnd = 1431306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1TaInre1ByloInUnique.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060061DC RID: 25052 RVA: 0x00024334 File Offset: 0x00022534
			public ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1TaInre1ByloInUnique(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060061DD RID: 25053 RVA: 0x0002433D File Offset: 0x0002253D
			public ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1TaInre1ByloInUnique()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stream.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1TaInre1ByloInUnique>.NativeClassPtr))
			{
			}

			// Token: 0x1700196F RID: 6511
			// (get) Token: 0x060061DE RID: 25054 RVA: 0x001B7388 File Offset: 0x001B5588
			// (set) Token: 0x060061DF RID: 25055 RVA: 0x0002434F File Offset: 0x0002254F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1TaInre1ByloInUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1TaInre1ByloInUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001970 RID: 6512
			// (get) Token: 0x060061E0 RID: 25056 RVA: 0x001B73B0 File Offset: 0x001B55B0
			// (set) Token: 0x060061E1 RID: 25057 RVA: 0x0002436A File Offset: 0x0002256A
			public AsyncValueTaskMethodBuilder<int> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1TaInre1ByloInUnique.NativeFieldInfoPtr___t__builder);
					return new AsyncValueTaskMethodBuilder<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1TaInre1ByloInUnique.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001971 RID: 6513
			// (get) Token: 0x060061E2 RID: 25058 RVA: 0x001B73E0 File Offset: 0x001B55E0
			// (set) Token: 0x060061E3 RID: 25059 RVA: 0x00024398 File Offset: 0x00022598
			public unsafe Task<int> readTask
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1TaInre1ByloInUnique.NativeFieldInfoPtr_readTask);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1TaInre1ByloInUnique.NativeFieldInfoPtr_readTask), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001972 RID: 6514
			// (get) Token: 0x060061E4 RID: 25060 RVA: 0x001B7410 File Offset: 0x001B5610
			// (set) Token: 0x060061E5 RID: 25061 RVA: 0x000243B7 File Offset: 0x000225B7
			public unsafe Il2CppStructArray<byte> localBuffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1TaInre1ByloInUnique.NativeFieldInfoPtr_localBuffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1TaInre1ByloInUnique.NativeFieldInfoPtr_localBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001973 RID: 6515
			// (get) Token: 0x060061E6 RID: 25062 RVA: 0x001B7440 File Offset: 0x001B5640
			// (set) Token: 0x060061E7 RID: 25063 RVA: 0x000243D6 File Offset: 0x000225D6
			public Memory<byte> localDestination
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1TaInre1ByloInUnique.NativeFieldInfoPtr_localDestination);
					return new Memory<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Memory<byte>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1TaInre1ByloInUnique.NativeFieldInfoPtr_localDestination), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Memory<byte>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001974 RID: 6516
			// (get) Token: 0x060061E8 RID: 25064 RVA: 0x001B7470 File Offset: 0x001B5670
			// (set) Token: 0x060061E9 RID: 25065 RVA: 0x00024404 File Offset: 0x00022604
			public ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1TaInre1ByloInUnique.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1TaInre1ByloInUnique.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04004F17 RID: 20247
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004F18 RID: 20248
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04004F19 RID: 20249
			private static readonly IntPtr NativeFieldInfoPtr_readTask;

			// Token: 0x04004F1A RID: 20250
			private static readonly IntPtr NativeFieldInfoPtr_localBuffer;

			// Token: 0x04004F1B RID: 20251
			private static readonly IntPtr NativeFieldInfoPtr_localDestination;

			// Token: 0x04004F1C RID: 20252
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04004F1D RID: 20253
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004F1E RID: 20254
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
