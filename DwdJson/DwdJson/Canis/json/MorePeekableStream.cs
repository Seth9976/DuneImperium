using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using JsonFx.IO;
using JsonFx.Serialization;

namespace Canis.json
{
	// Token: 0x02000017 RID: 23
	public sealed class MorePeekableStream : Stream<Token>
	{
		// Token: 0x060000B5 RID: 181 RVA: 0x000050E0 File Offset: 0x000032E0
		// Note: this type is marked as 'beforefieldinit'.
		static MorePeekableStream()
		{
			Il2CppClassPointerStore<MorePeekableStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("DwdJson.dll", "Canis.json", "MorePeekableStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MorePeekableStream>.NativeClassPtr);
			MorePeekableStream.NativeFieldInfoPtr_Cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MorePeekableStream>.NativeClassPtr, "Cache");
			MorePeekableStream.NativeFieldInfoPtr_Stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MorePeekableStream>.NativeClassPtr, "Stream");
			MorePeekableStream.NativeMethodInfoPtr__ctor_Public_Void_Stream_1_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MorePeekableStream>.NativeClassPtr, 100663378);
			MorePeekableStream.NativeMethodInfoPtr_Create_Public_Static_MorePeekableStream_Stream_1_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MorePeekableStream>.NativeClassPtr, 100663379);
			MorePeekableStream.NativeMethodInfoPtr_Create_Public_Static_MorePeekableStream_IEnumerable_1_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MorePeekableStream>.NativeClassPtr, 100663380);
			MorePeekableStream.NativeMethodInfoPtr_PeekAhead_Public_Token_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MorePeekableStream>.NativeClassPtr, 100663381);
			MorePeekableStream.NativeMethodInfoPtr_PeekUntilName_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MorePeekableStream>.NativeClassPtr, 100663382);
			MorePeekableStream.NativeMethodInfoPtr_get_ChunkSize_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MorePeekableStream>.NativeClassPtr, 100663383);
			MorePeekableStream.NativeMethodInfoPtr_get_IsChunking_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MorePeekableStream>.NativeClassPtr, 100663384);
			MorePeekableStream.NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MorePeekableStream>.NativeClassPtr, 100663385);
			MorePeekableStream.NativeMethodInfoPtr_BeginChunk_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MorePeekableStream>.NativeClassPtr, 100663386);
			MorePeekableStream.NativeMethodInfoPtr_EndChunk_Public_Virtual_IEnumerable_1_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MorePeekableStream>.NativeClassPtr, 100663387);
			MorePeekableStream.NativeMethodInfoPtr_Peek_Public_Virtual_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MorePeekableStream>.NativeClassPtr, 100663388);
			MorePeekableStream.NativeMethodInfoPtr_Pop_Public_Virtual_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MorePeekableStream>.NativeClassPtr, 100663389);
			MorePeekableStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MorePeekableStream>.NativeClassPtr, 100663390);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000523C File Offset: 0x0000343C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1249210, RefRangeEnd = 1249212, XrefRangeStart = 1249199, XrefRangeEnd = 1249210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MorePeekableStream(Stream<Token> stream)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MorePeekableStream>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MorePeekableStream.NativeMethodInfoPtr__ctor_Public_Void_Stream_1_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00005288 File Offset: 0x00003488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249212, XrefRangeEnd = 1249216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MorePeekableStream Create(Stream<Token> stream)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MorePeekableStream.NativeMethodInfoPtr_Create_Public_Static_MorePeekableStream_Stream_1_Token_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MorePeekableStream>(intPtr3) : null;
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000052CC File Offset: 0x000034CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1249238, RefRangeEnd = 1249241, XrefRangeStart = 1249216, XrefRangeEnd = 1249238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static MorePeekableStream Create(IEnumerable<Token> ts)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ts);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MorePeekableStream.NativeMethodInfoPtr_Create_Public_Static_MorePeekableStream_IEnumerable_1_Token_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MorePeekableStream>(intPtr3) : null;
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00005310 File Offset: 0x00003510
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1249249, RefRangeEnd = 1249255, XrefRangeStart = 1249241, XrefRangeEnd = 1249249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Token PeekAhead(int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref offset;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MorePeekableStream.NativeMethodInfoPtr_PeekAhead_Public_Token_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Token(intPtr);
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00005354 File Offset: 0x00003554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249255, XrefRangeEnd = 1249259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int PeekUntilName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MorePeekableStream.NativeMethodInfoPtr_PeekUntilName_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000BB RID: 187 RVA: 0x000053A4 File Offset: 0x000035A4
		public unsafe override int ChunkSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249259, XrefRangeEnd = 1249260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MorePeekableStream.NativeMethodInfoPtr_get_ChunkSize_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000BC RID: 188 RVA: 0x000053E0 File Offset: 0x000035E0
		public unsafe override bool IsChunking
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249260, XrefRangeEnd = 1249261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MorePeekableStream.NativeMethodInfoPtr_get_IsChunking_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000BD RID: 189 RVA: 0x0000541C File Offset: 0x0000361C
		public unsafe override bool IsCompleted
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249261, XrefRangeEnd = 1249262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MorePeekableStream.NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00005458 File Offset: 0x00003658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249262, XrefRangeEnd = 1249270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BeginChunk()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MorePeekableStream.NativeMethodInfoPtr_BeginChunk_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000548C File Offset: 0x0000368C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249270, XrefRangeEnd = 1249271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Token> EndChunk()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MorePeekableStream.NativeMethodInfoPtr_EndChunk_Public_Virtual_IEnumerable_1_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Token>>(intPtr3) : null;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000054CC File Offset: 0x000036CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249271, XrefRangeEnd = 1249273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Token Peek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MorePeekableStream.NativeMethodInfoPtr_Peek_Public_Virtual_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Token(intPtr);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00005504 File Offset: 0x00003704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249273, XrefRangeEnd = 1249280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Token Pop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MorePeekableStream.NativeMethodInfoPtr_Pop_Public_Virtual_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Token(intPtr);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000553C File Offset: 0x0000373C
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MorePeekableStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000024EB File Offset: 0x000006EB
		public MorePeekableStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x0000557C File Offset: 0x0000377C
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x000024F4 File Offset: 0x000006F4
		public unsafe List<Token> Cache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MorePeekableStream.NativeFieldInfoPtr_Cache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Token>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MorePeekableStream.NativeFieldInfoPtr_Cache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x000055AC File Offset: 0x000037AC
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x00002513 File Offset: 0x00000713
		public unsafe Stream<Token> Stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MorePeekableStream.NativeFieldInfoPtr_Stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream<Token>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MorePeekableStream.NativeFieldInfoPtr_Stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeFieldInfoPtr_Cache;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeFieldInfoPtr_Stream;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_1_Token_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_MorePeekableStream_Stream_1_Token_0;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_MorePeekableStream_IEnumerable_1_Token_0;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr_PeekAhead_Public_Token_Int32_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_PeekUntilName_Public_Int32_String_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_get_ChunkSize_Public_Virtual_get_Int32_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_get_IsChunking_Public_Virtual_get_Boolean_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_get_Boolean_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_BeginChunk_Public_Virtual_Void_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_EndChunk_Public_Virtual_IEnumerable_1_Token_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_Peek_Public_Virtual_Token_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_Pop_Public_Virtual_Token_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;
	}
}
