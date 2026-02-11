using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Text;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x0200009C RID: 156
	public class AsyncStreamReader : Object
	{
		// Token: 0x06000B3B RID: 2875 RVA: 0x00046C14 File Offset: 0x00044E14
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncStreamReader()
		{
			Il2CppClassPointerStore<AsyncStreamReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Diagnostics", "AsyncStreamReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncStreamReader>.NativeClassPtr);
			AsyncStreamReader.NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncStreamReader>.NativeClassPtr, "stream");
			AsyncStreamReader.NativeFieldInfoPtr_encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncStreamReader>.NativeClassPtr, "encoding");
			AsyncStreamReader.NativeFieldInfoPtr_decoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncStreamReader>.NativeClassPtr, "decoder");
			AsyncStreamReader.NativeFieldInfoPtr_byteBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncStreamReader>.NativeClassPtr, "byteBuffer");
			AsyncStreamReader.NativeFieldInfoPtr_charBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncStreamReader>.NativeClassPtr, "charBuffer");
			AsyncStreamReader.NativeFieldInfoPtr_cancelOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncStreamReader>.NativeClassPtr, "cancelOperation");
			AsyncStreamReader.NativeFieldInfoPtr_eofEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncStreamReader>.NativeClassPtr, "eofEvent");
			AsyncStreamReader.NativeFieldInfoPtr_syncObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncStreamReader>.NativeClassPtr, "syncObject");
			AsyncStreamReader.NativeFieldInfoPtr_asyncReadResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncStreamReader>.NativeClassPtr, "asyncReadResult");
			AsyncStreamReader.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncStreamReader>.NativeClassPtr, 100664972);
			AsyncStreamReader.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncStreamReader>.NativeClassPtr, 100664973);
			AsyncStreamReader.NativeMethodInfoPtr_CancelOperation_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncStreamReader>.NativeClassPtr, 100664974);
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x00046D34 File Offset: 0x00044F34
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 451127, RefRangeEnd = 451138, XrefRangeStart = 451127, XrefRangeEnd = 451127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncStreamReader.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x00046D70 File Offset: 0x00044F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 451138, XrefRangeEnd = 451162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncStreamReader.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x00046DBC File Offset: 0x00044FBC
		[CallerCount(0)]
		public unsafe void CancelOperation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncStreamReader.NativeMethodInfoPtr_CancelOperation_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x00005EDD File Offset: 0x000040DD
		public AsyncStreamReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000B40 RID: 2880 RVA: 0x00046DF0 File Offset: 0x00044FF0
		// (set) Token: 0x06000B41 RID: 2881 RVA: 0x00005EE6 File Offset: 0x000040E6
		public unsafe Stream stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncStreamReader.NativeFieldInfoPtr_stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncStreamReader.NativeFieldInfoPtr_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000B42 RID: 2882 RVA: 0x00046E20 File Offset: 0x00045020
		// (set) Token: 0x06000B43 RID: 2883 RVA: 0x00005F05 File Offset: 0x00004105
		public unsafe Encoding encoding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncStreamReader.NativeFieldInfoPtr_encoding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncStreamReader.NativeFieldInfoPtr_encoding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000B44 RID: 2884 RVA: 0x00046E50 File Offset: 0x00045050
		// (set) Token: 0x06000B45 RID: 2885 RVA: 0x00005F24 File Offset: 0x00004124
		public unsafe Decoder decoder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncStreamReader.NativeFieldInfoPtr_decoder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Decoder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncStreamReader.NativeFieldInfoPtr_decoder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000B46 RID: 2886 RVA: 0x00046E80 File Offset: 0x00045080
		// (set) Token: 0x06000B47 RID: 2887 RVA: 0x00005F43 File Offset: 0x00004143
		public unsafe Il2CppStructArray<byte> byteBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncStreamReader.NativeFieldInfoPtr_byteBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncStreamReader.NativeFieldInfoPtr_byteBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000B48 RID: 2888 RVA: 0x00046EB0 File Offset: 0x000450B0
		// (set) Token: 0x06000B49 RID: 2889 RVA: 0x00005F62 File Offset: 0x00004162
		public unsafe Il2CppStructArray<char> charBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncStreamReader.NativeFieldInfoPtr_charBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncStreamReader.NativeFieldInfoPtr_charBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000B4A RID: 2890 RVA: 0x00046EE0 File Offset: 0x000450E0
		// (set) Token: 0x06000B4B RID: 2891 RVA: 0x00005F81 File Offset: 0x00004181
		public unsafe bool cancelOperation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncStreamReader.NativeFieldInfoPtr_cancelOperation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncStreamReader.NativeFieldInfoPtr_cancelOperation)) = value;
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000B4C RID: 2892 RVA: 0x00046F08 File Offset: 0x00045108
		// (set) Token: 0x06000B4D RID: 2893 RVA: 0x00005F9C File Offset: 0x0000419C
		public unsafe ManualResetEvent eofEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncStreamReader.NativeFieldInfoPtr_eofEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManualResetEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncStreamReader.NativeFieldInfoPtr_eofEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000B4E RID: 2894 RVA: 0x00046F38 File Offset: 0x00045138
		// (set) Token: 0x06000B4F RID: 2895 RVA: 0x00005FBB File Offset: 0x000041BB
		public unsafe Object syncObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncStreamReader.NativeFieldInfoPtr_syncObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncStreamReader.NativeFieldInfoPtr_syncObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000B50 RID: 2896 RVA: 0x00046F68 File Offset: 0x00045168
		// (set) Token: 0x06000B51 RID: 2897 RVA: 0x00005FDA File Offset: 0x000041DA
		public unsafe IAsyncResult asyncReadResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncStreamReader.NativeFieldInfoPtr_asyncReadResult);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncStreamReader.NativeFieldInfoPtr_asyncReadResult), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000900 RID: 2304
		private static readonly IntPtr NativeFieldInfoPtr_stream;

		// Token: 0x04000901 RID: 2305
		private static readonly IntPtr NativeFieldInfoPtr_encoding;

		// Token: 0x04000902 RID: 2306
		private static readonly IntPtr NativeFieldInfoPtr_decoder;

		// Token: 0x04000903 RID: 2307
		private static readonly IntPtr NativeFieldInfoPtr_byteBuffer;

		// Token: 0x04000904 RID: 2308
		private static readonly IntPtr NativeFieldInfoPtr_charBuffer;

		// Token: 0x04000905 RID: 2309
		private static readonly IntPtr NativeFieldInfoPtr_cancelOperation;

		// Token: 0x04000906 RID: 2310
		private static readonly IntPtr NativeFieldInfoPtr_eofEvent;

		// Token: 0x04000907 RID: 2311
		private static readonly IntPtr NativeFieldInfoPtr_syncObject;

		// Token: 0x04000908 RID: 2312
		private static readonly IntPtr NativeFieldInfoPtr_asyncReadResult;

		// Token: 0x04000909 RID: 2313
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0;

		// Token: 0x0400090A RID: 2314
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x0400090B RID: 2315
		private static readonly IntPtr NativeMethodInfoPtr_CancelOperation_Internal_Void_0;
	}
}
