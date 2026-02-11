using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Localization.Metadata
{
	// Token: 0x020000D1 RID: 209
	[Serializable]
	public class Comment : Object
	{
		// Token: 0x06000AD7 RID: 2775 RVA: 0x0003212C File Offset: 0x0003032C
		// Note: this type is marked as 'beforefieldinit'.
		static Comment()
		{
			Il2CppClassPointerStore<Comment>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Metadata", "Comment");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Comment>.NativeClassPtr);
			Comment.NativeFieldInfoPtr_m_CommentText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Comment>.NativeClassPtr, "m_CommentText");
			Comment.NativeMethodInfoPtr_get_CommentText_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Comment>.NativeClassPtr, 100665099);
			Comment.NativeMethodInfoPtr_set_CommentText_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Comment>.NativeClassPtr, 100665100);
			Comment.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Comment>.NativeClassPtr, 100665101);
			Comment.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Comment>.NativeClassPtr, 100665102);
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000AD8 RID: 2776 RVA: 0x000321C0 File Offset: 0x000303C0
		// (set) Token: 0x06000AD9 RID: 2777 RVA: 0x000321F8 File Offset: 0x000303F8
		public unsafe string CommentText
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Comment.NativeMethodInfoPtr_get_CommentText_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Comment.NativeMethodInfoPtr_set_CommentText_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x0003223C File Offset: 0x0003043C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Comment.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x00032280 File Offset: 0x00030480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078929, XrefRangeEnd = 1078934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Comment()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Comment>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Comment.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x00006883 File Offset: 0x00004A83
		public Comment(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000ADD RID: 2781 RVA: 0x000322BC File Offset: 0x000304BC
		// (set) Token: 0x06000ADE RID: 2782 RVA: 0x0000688C File Offset: 0x00004A8C
		public unsafe string m_CommentText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Comment.NativeFieldInfoPtr_m_CommentText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Comment.NativeFieldInfoPtr_m_CommentText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040007A1 RID: 1953
		private static readonly IntPtr NativeFieldInfoPtr_m_CommentText;

		// Token: 0x040007A2 RID: 1954
		private static readonly IntPtr NativeMethodInfoPtr_get_CommentText_Public_get_String_0;

		// Token: 0x040007A3 RID: 1955
		private static readonly IntPtr NativeMethodInfoPtr_set_CommentText_Public_set_Void_String_0;

		// Token: 0x040007A4 RID: 1956
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040007A5 RID: 1957
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
