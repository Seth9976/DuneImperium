using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace JsonFx.IO
{
	// Token: 0x02000031 RID: 49
	public sealed class StringStream : TextStream
	{
		// Token: 0x06000293 RID: 659 RVA: 0x0000D3C0 File Offset: 0x0000B5C0
		// Note: this type is marked as 'beforefieldinit'.
		static StringStream()
		{
			Il2CppClassPointerStore<StringStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("JsonFx.dll", "JsonFx.IO", "StringStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringStream>.NativeClassPtr);
			StringStream.NativeFieldInfoPtr_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringStream>.NativeClassPtr, "Null");
			StringStream.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringStream>.NativeClassPtr, "current");
			StringStream.NativeFieldInfoPtr_Buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringStream>.NativeClassPtr, "Buffer");
			StringStream.NativeFieldInfoPtr_chunkStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringStream>.NativeClassPtr, "chunkStart");
			StringStream.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringStream>.NativeClassPtr, 100663688);
			StringStream.NativeMethodInfoPtr_get_IsChunking_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringStream>.NativeClassPtr, 100663689);
			StringStream.NativeMethodInfoPtr_get_ChunkSize_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringStream>.NativeClassPtr, 100663690);
			StringStream.NativeMethodInfoPtr_BeginChunk_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringStream>.NativeClassPtr, 100663691);
			StringStream.NativeMethodInfoPtr_EndChunk_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringStream>.NativeClassPtr, 100663692);
			StringStream.NativeMethodInfoPtr_EndChunk_Public_Virtual_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringStream>.NativeClassPtr, 100663693);
			StringStream.NativeMethodInfoPtr_Peek_Public_Virtual_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringStream>.NativeClassPtr, 100663694);
			StringStream.NativeMethodInfoPtr_Pop_Public_Virtual_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringStream>.NativeClassPtr, 100663695);
			StringStream.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringStream>.NativeClassPtr, 100663696);
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0000D4F4 File Offset: 0x0000B6F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1193169, RefRangeEnd = 1193172, XrefRangeStart = 1193164, XrefRangeEnd = 1193169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringStream(string value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringStream>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringStream.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000295 RID: 661 RVA: 0x0000D540 File Offset: 0x0000B740
		public unsafe override bool IsChunking
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringStream.NativeMethodInfoPtr_get_IsChunking_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000296 RID: 662 RVA: 0x0000D57C File Offset: 0x0000B77C
		public unsafe override int ChunkSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringStream.NativeMethodInfoPtr_get_ChunkSize_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0000D5B8 File Offset: 0x0000B7B8
		[CallerCount(0)]
		public unsafe override void BeginChunk()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringStream.NativeMethodInfoPtr_BeginChunk_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0000D5EC File Offset: 0x0000B7EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193172, XrefRangeEnd = 1193173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string EndChunk()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringStream.NativeMethodInfoPtr_EndChunk_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0000D624 File Offset: 0x0000B824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193173, XrefRangeEnd = 1193174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EndChunk(StringBuilder buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringStream.NativeMethodInfoPtr_EndChunk_Public_Virtual_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0000D668 File Offset: 0x0000B868
		[CallerCount(0)]
		public unsafe override char Peek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringStream.NativeMethodInfoPtr_Peek_Public_Virtual_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0000D6A4 File Offset: 0x0000B8A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193174, XrefRangeEnd = 1193180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override char Pop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringStream.NativeMethodInfoPtr_Pop_Public_Virtual_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0000D6E0 File Offset: 0x0000B8E0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringStream.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00002F9A File Offset: 0x0000119A
		public StringStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x0600029E RID: 670 RVA: 0x0000D714 File Offset: 0x0000B914
		// (set) Token: 0x0600029F RID: 671 RVA: 0x00002FA3 File Offset: 0x000011A3
		public unsafe static StringStream Null
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StringStream.NativeFieldInfoPtr_Null, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringStream>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringStream.NativeFieldInfoPtr_Null, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x0000D73C File Offset: 0x0000B93C
		// (set) Token: 0x060002A1 RID: 673 RVA: 0x00002FB5 File Offset: 0x000011B5
		public unsafe char current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringStream.NativeFieldInfoPtr_current);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringStream.NativeFieldInfoPtr_current)) = value;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x0000D764 File Offset: 0x0000B964
		// (set) Token: 0x060002A3 RID: 675 RVA: 0x00002FD0 File Offset: 0x000011D0
		public unsafe string Buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringStream.NativeFieldInfoPtr_Buffer);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringStream.NativeFieldInfoPtr_Buffer), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x0000D78C File Offset: 0x0000B98C
		// (set) Token: 0x060002A5 RID: 677 RVA: 0x00002FEF File Offset: 0x000011EF
		public unsafe int chunkStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringStream.NativeFieldInfoPtr_chunkStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringStream.NativeFieldInfoPtr_chunkStart)) = value;
			}
		}

		// Token: 0x040001B9 RID: 441
		private static readonly IntPtr NativeFieldInfoPtr_Null;

		// Token: 0x040001BA RID: 442
		private static readonly IntPtr NativeFieldInfoPtr_current;

		// Token: 0x040001BB RID: 443
		private static readonly IntPtr NativeFieldInfoPtr_Buffer;

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeFieldInfoPtr_chunkStart;

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeMethodInfoPtr_get_IsChunking_Public_Virtual_get_Boolean_0;

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeMethodInfoPtr_get_ChunkSize_Public_Virtual_get_Int32_0;

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeMethodInfoPtr_BeginChunk_Public_Virtual_Void_0;

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeMethodInfoPtr_EndChunk_Public_Virtual_String_0;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeMethodInfoPtr_EndChunk_Public_Virtual_Void_StringBuilder_0;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeMethodInfoPtr_Peek_Public_Virtual_Char_0;

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeMethodInfoPtr_Pop_Public_Virtual_Char_0;

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0;
	}
}
