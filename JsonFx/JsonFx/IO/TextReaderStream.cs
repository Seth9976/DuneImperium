using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Text;

namespace JsonFx.IO
{
	// Token: 0x02000033 RID: 51
	public sealed class TextReaderStream : TextStream
	{
		// Token: 0x060002BE RID: 702 RVA: 0x0000DFE4 File Offset: 0x0000C1E4
		// Note: this type is marked as 'beforefieldinit'.
		static TextReaderStream()
		{
			Il2CppClassPointerStore<TextReaderStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("JsonFx.dll", "JsonFx.IO", "TextReaderStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextReaderStream>.NativeClassPtr);
			TextReaderStream.NativeFieldInfoPtr_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextReaderStream>.NativeClassPtr, "Null");
			TextReaderStream.NativeFieldInfoPtr_Reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextReaderStream>.NativeClassPtr, "Reader");
			TextReaderStream.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextReaderStream>.NativeClassPtr, "current");
			TextReaderStream.NativeFieldInfoPtr_prev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextReaderStream>.NativeClassPtr, "prev");
			TextReaderStream.NativeFieldInfoPtr_sb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextReaderStream>.NativeClassPtr, "sb");
			TextReaderStream.NativeFieldInfoPtr_isChunking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextReaderStream>.NativeClassPtr, "isChunking");
			TextReaderStream.NativeMethodInfoPtr__ctor_Public_Void_TextReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReaderStream>.NativeClassPtr, 100663723);
			TextReaderStream.NativeMethodInfoPtr_get_IsChunking_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReaderStream>.NativeClassPtr, 100663724);
			TextReaderStream.NativeMethodInfoPtr_get_ChunkSize_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReaderStream>.NativeClassPtr, 100663725);
			TextReaderStream.NativeMethodInfoPtr_BeginChunk_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReaderStream>.NativeClassPtr, 100663726);
			TextReaderStream.NativeMethodInfoPtr_EndChunk_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReaderStream>.NativeClassPtr, 100663727);
			TextReaderStream.NativeMethodInfoPtr_EndChunk_Public_Virtual_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReaderStream>.NativeClassPtr, 100663728);
			TextReaderStream.NativeMethodInfoPtr_Peek_Public_Virtual_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReaderStream>.NativeClassPtr, 100663729);
			TextReaderStream.NativeMethodInfoPtr_Pop_Public_Virtual_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReaderStream>.NativeClassPtr, 100663730);
			TextReaderStream.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReaderStream>.NativeClassPtr, 100663731);
			TextReaderStream.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextReaderStream>.NativeClassPtr, 100663732);
		}

		// Token: 0x060002BF RID: 703 RVA: 0x0000E154 File Offset: 0x0000C354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193227, XrefRangeEnd = 1193229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextReaderStream(TextReader reader)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextReaderStream>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReaderStream.NativeMethodInfoPtr__ctor_Public_Void_TextReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x0000E1A0 File Offset: 0x0000C3A0
		public unsafe override bool IsChunking
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReaderStream.NativeMethodInfoPtr_get_IsChunking_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x0000E1DC File Offset: 0x0000C3DC
		public unsafe override int ChunkSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193229, XrefRangeEnd = 1193237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReaderStream.NativeMethodInfoPtr_get_ChunkSize_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0000E218 File Offset: 0x0000C418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193237, XrefRangeEnd = 1193239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BeginChunk()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReaderStream.NativeMethodInfoPtr_BeginChunk_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0000E24C File Offset: 0x0000C44C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193239, XrefRangeEnd = 1193240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string EndChunk()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReaderStream.NativeMethodInfoPtr_EndChunk_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0000E284 File Offset: 0x0000C484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193240, XrefRangeEnd = 1193242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EndChunk(StringBuilder buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReaderStream.NativeMethodInfoPtr_EndChunk_Public_Virtual_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0000E2C8 File Offset: 0x0000C4C8
		[CallerCount(0)]
		public unsafe override char Peek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReaderStream.NativeMethodInfoPtr_Peek_Public_Virtual_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0000E304 File Offset: 0x0000C504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193242, XrefRangeEnd = 1193247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override char Pop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReaderStream.NativeMethodInfoPtr_Pop_Public_Virtual_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0000E340 File Offset: 0x0000C540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193247, XrefRangeEnd = 1193248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReaderStream.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0000E374 File Offset: 0x0000C574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193248, XrefRangeEnd = 1193249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextReaderStream.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00003068 File Offset: 0x00001268
		public TextReaderStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060002CA RID: 714 RVA: 0x0000E3B4 File Offset: 0x0000C5B4
		// (set) Token: 0x060002CB RID: 715 RVA: 0x00003071 File Offset: 0x00001271
		public unsafe static TextReaderStream Null
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextReaderStream.NativeFieldInfoPtr_Null, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextReaderStream>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextReaderStream.NativeFieldInfoPtr_Null, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060002CC RID: 716 RVA: 0x0000E3DC File Offset: 0x0000C5DC
		// (set) Token: 0x060002CD RID: 717 RVA: 0x00003083 File Offset: 0x00001283
		public unsafe TextReader Reader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextReaderStream.NativeFieldInfoPtr_Reader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextReaderStream.NativeFieldInfoPtr_Reader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060002CE RID: 718 RVA: 0x0000E40C File Offset: 0x0000C60C
		// (set) Token: 0x060002CF RID: 719 RVA: 0x000030A2 File Offset: 0x000012A2
		public unsafe char current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextReaderStream.NativeFieldInfoPtr_current);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextReaderStream.NativeFieldInfoPtr_current)) = value;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x0000E434 File Offset: 0x0000C634
		// (set) Token: 0x060002D1 RID: 721 RVA: 0x000030BD File Offset: 0x000012BD
		public unsafe char prev
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextReaderStream.NativeFieldInfoPtr_prev);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextReaderStream.NativeFieldInfoPtr_prev)) = value;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x0000E45C File Offset: 0x0000C65C
		// (set) Token: 0x060002D3 RID: 723 RVA: 0x000030D8 File Offset: 0x000012D8
		public unsafe StringBuilder sb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextReaderStream.NativeFieldInfoPtr_sb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextReaderStream.NativeFieldInfoPtr_sb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x0000E48C File Offset: 0x0000C68C
		// (set) Token: 0x060002D5 RID: 725 RVA: 0x000030F7 File Offset: 0x000012F7
		public unsafe bool isChunking
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextReaderStream.NativeFieldInfoPtr_isChunking);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextReaderStream.NativeFieldInfoPtr_isChunking)) = value;
			}
		}

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeFieldInfoPtr_Null;

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeFieldInfoPtr_Reader;

		// Token: 0x040001DB RID: 475
		private static readonly IntPtr NativeFieldInfoPtr_current;

		// Token: 0x040001DC RID: 476
		private static readonly IntPtr NativeFieldInfoPtr_prev;

		// Token: 0x040001DD RID: 477
		private static readonly IntPtr NativeFieldInfoPtr_sb;

		// Token: 0x040001DE RID: 478
		private static readonly IntPtr NativeFieldInfoPtr_isChunking;

		// Token: 0x040001DF RID: 479
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TextReader_0;

		// Token: 0x040001E0 RID: 480
		private static readonly IntPtr NativeMethodInfoPtr_get_IsChunking_Public_Virtual_get_Boolean_0;

		// Token: 0x040001E1 RID: 481
		private static readonly IntPtr NativeMethodInfoPtr_get_ChunkSize_Public_Virtual_get_Int32_0;

		// Token: 0x040001E2 RID: 482
		private static readonly IntPtr NativeMethodInfoPtr_BeginChunk_Public_Virtual_Void_0;

		// Token: 0x040001E3 RID: 483
		private static readonly IntPtr NativeMethodInfoPtr_EndChunk_Public_Virtual_String_0;

		// Token: 0x040001E4 RID: 484
		private static readonly IntPtr NativeMethodInfoPtr_EndChunk_Public_Virtual_Void_StringBuilder_0;

		// Token: 0x040001E5 RID: 485
		private static readonly IntPtr NativeMethodInfoPtr_Peek_Public_Virtual_Char_0;

		// Token: 0x040001E6 RID: 486
		private static readonly IntPtr NativeMethodInfoPtr_Pop_Public_Virtual_Char_0;

		// Token: 0x040001E7 RID: 487
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0;

		// Token: 0x040001E8 RID: 488
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0;
	}
}
