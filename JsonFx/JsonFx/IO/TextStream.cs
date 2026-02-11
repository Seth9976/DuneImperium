using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text;

namespace JsonFx.IO
{
	// Token: 0x02000034 RID: 52
	public class TextStream : Object
	{
		// Token: 0x060002D6 RID: 726 RVA: 0x0000E4B4 File Offset: 0x0000C6B4
		// Note: this type is marked as 'beforefieldinit'.
		static TextStream()
		{
			Il2CppClassPointerStore<TextStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("JsonFx.dll", "JsonFx.IO", "TextStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextStream>.NativeClassPtr);
			TextStream.NativeFieldInfoPtr_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextStream>.NativeClassPtr, "Index");
			TextStream.NativeFieldInfoPtr_Line = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextStream>.NativeClassPtr, "Line");
			TextStream.NativeFieldInfoPtr_Column = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextStream>.NativeClassPtr, "Column");
			TextStream.NativeFieldInfoPtr_IsCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextStream>.NativeClassPtr, "IsCompleted");
			TextStream.NativeMethodInfoPtr_get_IsChunking_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextStream>.NativeClassPtr, 100663734);
			TextStream.NativeMethodInfoPtr_get_ChunkSize_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextStream>.NativeClassPtr, 100663735);
			TextStream.NativeMethodInfoPtr_Peek_Public_Abstract_Virtual_New_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextStream>.NativeClassPtr, 100663736);
			TextStream.NativeMethodInfoPtr_Pop_Public_Abstract_Virtual_New_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextStream>.NativeClassPtr, 100663737);
			TextStream.NativeMethodInfoPtr_BeginChunk_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextStream>.NativeClassPtr, 100663738);
			TextStream.NativeMethodInfoPtr_EndChunk_Public_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextStream>.NativeClassPtr, 100663739);
			TextStream.NativeMethodInfoPtr_EndChunk_Public_Abstract_Virtual_New_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextStream>.NativeClassPtr, 100663740);
			TextStream.NativeMethodInfoPtr_Dispose_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextStream>.NativeClassPtr, 100663741);
			TextStream.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextStream>.NativeClassPtr, 100663742);
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060002D7 RID: 727 RVA: 0x0000E5E8 File Offset: 0x0000C7E8
		public unsafe virtual bool IsChunking
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextStream.NativeMethodInfoPtr_get_IsChunking_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x0000E630 File Offset: 0x0000C830
		public unsafe virtual int ChunkSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextStream.NativeMethodInfoPtr_get_ChunkSize_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0000E678 File Offset: 0x0000C878
		[CallerCount(0)]
		public unsafe virtual char Peek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextStream.NativeMethodInfoPtr_Peek_Public_Abstract_Virtual_New_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0000E6C0 File Offset: 0x0000C8C0
		[CallerCount(0)]
		public unsafe virtual char Pop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextStream.NativeMethodInfoPtr_Pop_Public_Abstract_Virtual_New_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0000E708 File Offset: 0x0000C908
		[CallerCount(0)]
		public unsafe virtual void BeginChunk()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextStream.NativeMethodInfoPtr_BeginChunk_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0000E744 File Offset: 0x0000C944
		[CallerCount(0)]
		public unsafe virtual string EndChunk()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextStream.NativeMethodInfoPtr_EndChunk_Public_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002DD RID: 733 RVA: 0x0000E788 File Offset: 0x0000C988
		[CallerCount(0)]
		public unsafe virtual void EndChunk(StringBuilder buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextStream.NativeMethodInfoPtr_EndChunk_Public_Abstract_Virtual_New_Void_StringBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002DE RID: 734 RVA: 0x0000E7D8 File Offset: 0x0000C9D8
		[CallerCount(0)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextStream.NativeMethodInfoPtr_Dispose_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002DF RID: 735 RVA: 0x0000E814 File Offset: 0x0000CA14
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextStream()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextStream>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextStream.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00003112 File Offset: 0x00001312
		public TextStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x0000E850 File Offset: 0x0000CA50
		// (set) Token: 0x060002E2 RID: 738 RVA: 0x0000311B File Offset: 0x0000131B
		public unsafe int Index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextStream.NativeFieldInfoPtr_Index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextStream.NativeFieldInfoPtr_Index)) = value;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x0000E878 File Offset: 0x0000CA78
		// (set) Token: 0x060002E4 RID: 740 RVA: 0x00003136 File Offset: 0x00001336
		public unsafe int Line
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextStream.NativeFieldInfoPtr_Line);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextStream.NativeFieldInfoPtr_Line)) = value;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x0000E8A0 File Offset: 0x0000CAA0
		// (set) Token: 0x060002E6 RID: 742 RVA: 0x00003151 File Offset: 0x00001351
		public unsafe int Column
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextStream.NativeFieldInfoPtr_Column);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextStream.NativeFieldInfoPtr_Column)) = value;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x0000E8C8 File Offset: 0x0000CAC8
		// (set) Token: 0x060002E8 RID: 744 RVA: 0x0000316C File Offset: 0x0000136C
		public unsafe bool IsCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextStream.NativeFieldInfoPtr_IsCompleted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextStream.NativeFieldInfoPtr_IsCompleted)) = value;
			}
		}

		// Token: 0x040001E9 RID: 489
		private static readonly IntPtr NativeFieldInfoPtr_Index;

		// Token: 0x040001EA RID: 490
		private static readonly IntPtr NativeFieldInfoPtr_Line;

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeFieldInfoPtr_Column;

		// Token: 0x040001EC RID: 492
		private static readonly IntPtr NativeFieldInfoPtr_IsCompleted;

		// Token: 0x040001ED RID: 493
		private static readonly IntPtr NativeMethodInfoPtr_get_IsChunking_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeMethodInfoPtr_get_ChunkSize_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x040001EF RID: 495
		private static readonly IntPtr NativeMethodInfoPtr_Peek_Public_Abstract_Virtual_New_Char_0;

		// Token: 0x040001F0 RID: 496
		private static readonly IntPtr NativeMethodInfoPtr_Pop_Public_Abstract_Virtual_New_Char_0;

		// Token: 0x040001F1 RID: 497
		private static readonly IntPtr NativeMethodInfoPtr_BeginChunk_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040001F2 RID: 498
		private static readonly IntPtr NativeMethodInfoPtr_EndChunk_Public_Abstract_Virtual_New_String_0;

		// Token: 0x040001F3 RID: 499
		private static readonly IntPtr NativeMethodInfoPtr_EndChunk_Public_Abstract_Virtual_New_Void_StringBuilder_0;

		// Token: 0x040001F4 RID: 500
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040001F5 RID: 501
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
