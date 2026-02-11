using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;

namespace Il2CppSystem.Net
{
	// Token: 0x020001EE RID: 494
	public class ChunkedInputStream : RequestStream
	{
		// Token: 0x06001EA7 RID: 7847 RVA: 0x00093258 File Offset: 0x00091458
		// Note: this type is marked as 'beforefieldinit'.
		static ChunkedInputStream()
		{
			Il2CppClassPointerStore<ChunkedInputStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "ChunkedInputStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkedInputStream>.NativeClassPtr);
			ChunkedInputStream.NativeFieldInfoPtr_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkedInputStream>.NativeClassPtr, "disposed");
			ChunkedInputStream.NativeFieldInfoPtr_decoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkedInputStream>.NativeClassPtr, "decoder");
			ChunkedInputStream.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkedInputStream>.NativeClassPtr, "context");
			ChunkedInputStream.NativeFieldInfoPtr_no_more_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkedInputStream>.NativeClassPtr, "no_more_data");
			ChunkedInputStream.NativeMethodInfoPtr__ctor_Public_Void_HttpListenerContext_Stream_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkedInputStream>.NativeClassPtr, 100667963);
			ChunkedInputStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkedInputStream>.NativeClassPtr, 100667964);
			ChunkedInputStream.NativeMethodInfoPtr_BeginRead_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkedInputStream>.NativeClassPtr, 100667965);
			ChunkedInputStream.NativeMethodInfoPtr_OnRead_Private_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkedInputStream>.NativeClassPtr, 100667966);
			ChunkedInputStream.NativeMethodInfoPtr_EndRead_Public_Virtual_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkedInputStream>.NativeClassPtr, 100667967);
			ChunkedInputStream.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkedInputStream>.NativeClassPtr, 100667968);
		}

		// Token: 0x06001EA8 RID: 7848 RVA: 0x00093350 File Offset: 0x00091550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478814, XrefRangeEnd = 478825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChunkedInputStream(HttpListenerContext context, Stream stream, Il2CppStructArray<byte> buffer, int offset, int length)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChunkedInputStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stream);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChunkedInputStream.NativeMethodInfoPtr__ctor_Public_Void_HttpListenerContext_Stream_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EA9 RID: 7849 RVA: 0x000933DC File Offset: 0x000915DC
		[CallerCount(0)]
		public unsafe override int Read([In] [Out] Il2CppStructArray<byte> buffer, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChunkedInputStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*buffer = ((intPtr4 == 0) ? null : new Il2CppStructArray<byte>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001EAA RID: 7850 RVA: 0x00093464 File Offset: 0x00091664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478825, XrefRangeEnd = 478855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IAsyncResult BeginRead(Il2CppStructArray<byte> buffer, int offset, int count, AsyncCallback cback, Object state)
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
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChunkedInputStream.NativeMethodInfoPtr_BeginRead_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06001EAB RID: 7851 RVA: 0x00093504 File Offset: 0x00091704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478855, XrefRangeEnd = 478883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnRead(IAsyncResult base_ares)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(base_ares);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChunkedInputStream.NativeMethodInfoPtr_OnRead_Private_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EAC RID: 7852 RVA: 0x00093548 File Offset: 0x00091748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478883, XrefRangeEnd = 478891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int EndRead(IAsyncResult ares)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChunkedInputStream.NativeMethodInfoPtr_EndRead_Public_Virtual_Int32_IAsyncResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EAD RID: 7853 RVA: 0x000935A0 File Offset: 0x000917A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478891, XrefRangeEnd = 478892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChunkedInputStream.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EAE RID: 7854 RVA: 0x0000D07B File Offset: 0x0000B27B
		public ChunkedInputStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x06001EAF RID: 7855 RVA: 0x000935DC File Offset: 0x000917DC
		// (set) Token: 0x06001EB0 RID: 7856 RVA: 0x0000D084 File Offset: 0x0000B284
		public new unsafe bool disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChunkedInputStream.NativeFieldInfoPtr_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChunkedInputStream.NativeFieldInfoPtr_disposed)) = value;
			}
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x06001EB1 RID: 7857 RVA: 0x00093604 File Offset: 0x00091804
		// (set) Token: 0x06001EB2 RID: 7858 RVA: 0x0000D09F File Offset: 0x0000B29F
		public unsafe MonoChunkParser decoder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChunkedInputStream.NativeFieldInfoPtr_decoder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoChunkParser>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChunkedInputStream.NativeFieldInfoPtr_decoder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x06001EB3 RID: 7859 RVA: 0x00093634 File Offset: 0x00091834
		// (set) Token: 0x06001EB4 RID: 7860 RVA: 0x0000D0BE File Offset: 0x0000B2BE
		public unsafe HttpListenerContext context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChunkedInputStream.NativeFieldInfoPtr_context);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpListenerContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChunkedInputStream.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x06001EB5 RID: 7861 RVA: 0x00093664 File Offset: 0x00091864
		// (set) Token: 0x06001EB6 RID: 7862 RVA: 0x0000D0DD File Offset: 0x0000B2DD
		public unsafe bool no_more_data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChunkedInputStream.NativeFieldInfoPtr_no_more_data);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChunkedInputStream.NativeFieldInfoPtr_no_more_data)) = value;
			}
		}

		// Token: 0x04001837 RID: 6199
		private static readonly IntPtr NativeFieldInfoPtr_disposed;

		// Token: 0x04001838 RID: 6200
		private static readonly IntPtr NativeFieldInfoPtr_decoder;

		// Token: 0x04001839 RID: 6201
		private static readonly IntPtr NativeFieldInfoPtr_context;

		// Token: 0x0400183A RID: 6202
		private static readonly IntPtr NativeFieldInfoPtr_no_more_data;

		// Token: 0x0400183B RID: 6203
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_HttpListenerContext_Stream_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x0400183C RID: 6204
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x0400183D RID: 6205
		private static readonly IntPtr NativeMethodInfoPtr_BeginRead_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

		// Token: 0x0400183E RID: 6206
		private static readonly IntPtr NativeMethodInfoPtr_OnRead_Private_Void_IAsyncResult_0;

		// Token: 0x0400183F RID: 6207
		private static readonly IntPtr NativeMethodInfoPtr_EndRead_Public_Virtual_Int32_IAsyncResult_0;

		// Token: 0x04001840 RID: 6208
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x02000333 RID: 819
		public class ReadBufferState : Object
		{
			// Token: 0x06002F77 RID: 12151 RVA: 0x000CE9E0 File Offset: 0x000CCBE0
			// Note: this type is marked as 'beforefieldinit'.
			static ReadBufferState()
			{
				Il2CppClassPointerStore<ChunkedInputStream.ReadBufferState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChunkedInputStream>.NativeClassPtr, "ReadBufferState");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkedInputStream.ReadBufferState>.NativeClassPtr);
				ChunkedInputStream.ReadBufferState.NativeFieldInfoPtr_Buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkedInputStream.ReadBufferState>.NativeClassPtr, "Buffer");
				ChunkedInputStream.ReadBufferState.NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkedInputStream.ReadBufferState>.NativeClassPtr, "Offset");
				ChunkedInputStream.ReadBufferState.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkedInputStream.ReadBufferState>.NativeClassPtr, "Count");
				ChunkedInputStream.ReadBufferState.NativeFieldInfoPtr_InitialCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkedInputStream.ReadBufferState>.NativeClassPtr, "InitialCount");
				ChunkedInputStream.ReadBufferState.NativeFieldInfoPtr_Ares = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkedInputStream.ReadBufferState>.NativeClassPtr, "Ares");
				ChunkedInputStream.ReadBufferState.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_HttpStreamAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkedInputStream.ReadBufferState>.NativeClassPtr, 100667969);
			}

			// Token: 0x06002F78 RID: 12152 RVA: 0x000CEA84 File Offset: 0x000CCC84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478811, XrefRangeEnd = 478814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReadBufferState(Il2CppStructArray<byte> buffer, int offset, int count, HttpStreamAsyncResult ares)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChunkedInputStream.ReadBufferState>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ares);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChunkedInputStream.ReadBufferState.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_HttpStreamAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F79 RID: 12153 RVA: 0x00015534 File Offset: 0x00013734
			public ReadBufferState(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000ED7 RID: 3799
			// (get) Token: 0x06002F7A RID: 12154 RVA: 0x000CEB00 File Offset: 0x000CCD00
			// (set) Token: 0x06002F7B RID: 12155 RVA: 0x0001553D File Offset: 0x0001373D
			public unsafe Il2CppStructArray<byte> Buffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChunkedInputStream.ReadBufferState.NativeFieldInfoPtr_Buffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChunkedInputStream.ReadBufferState.NativeFieldInfoPtr_Buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000ED8 RID: 3800
			// (get) Token: 0x06002F7C RID: 12156 RVA: 0x000CEB30 File Offset: 0x000CCD30
			// (set) Token: 0x06002F7D RID: 12157 RVA: 0x0001555C File Offset: 0x0001375C
			public unsafe int Offset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChunkedInputStream.ReadBufferState.NativeFieldInfoPtr_Offset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChunkedInputStream.ReadBufferState.NativeFieldInfoPtr_Offset)) = value;
				}
			}

			// Token: 0x17000ED9 RID: 3801
			// (get) Token: 0x06002F7E RID: 12158 RVA: 0x000CEB58 File Offset: 0x000CCD58
			// (set) Token: 0x06002F7F RID: 12159 RVA: 0x00015577 File Offset: 0x00013777
			public unsafe int Count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChunkedInputStream.ReadBufferState.NativeFieldInfoPtr_Count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChunkedInputStream.ReadBufferState.NativeFieldInfoPtr_Count)) = value;
				}
			}

			// Token: 0x17000EDA RID: 3802
			// (get) Token: 0x06002F80 RID: 12160 RVA: 0x000CEB80 File Offset: 0x000CCD80
			// (set) Token: 0x06002F81 RID: 12161 RVA: 0x00015592 File Offset: 0x00013792
			public unsafe int InitialCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChunkedInputStream.ReadBufferState.NativeFieldInfoPtr_InitialCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChunkedInputStream.ReadBufferState.NativeFieldInfoPtr_InitialCount)) = value;
				}
			}

			// Token: 0x17000EDB RID: 3803
			// (get) Token: 0x06002F82 RID: 12162 RVA: 0x000CEBA8 File Offset: 0x000CCDA8
			// (set) Token: 0x06002F83 RID: 12163 RVA: 0x000155AD File Offset: 0x000137AD
			public unsafe HttpStreamAsyncResult Ares
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChunkedInputStream.ReadBufferState.NativeFieldInfoPtr_Ares);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpStreamAsyncResult>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChunkedInputStream.ReadBufferState.NativeFieldInfoPtr_Ares), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002526 RID: 9510
			private static readonly IntPtr NativeFieldInfoPtr_Buffer;

			// Token: 0x04002527 RID: 9511
			private static readonly IntPtr NativeFieldInfoPtr_Offset;

			// Token: 0x04002528 RID: 9512
			private static readonly IntPtr NativeFieldInfoPtr_Count;

			// Token: 0x04002529 RID: 9513
			private static readonly IntPtr NativeFieldInfoPtr_InitialCount;

			// Token: 0x0400252A RID: 9514
			private static readonly IntPtr NativeFieldInfoPtr_Ares;

			// Token: 0x0400252B RID: 9515
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_HttpStreamAsyncResult_0;
		}
	}
}
