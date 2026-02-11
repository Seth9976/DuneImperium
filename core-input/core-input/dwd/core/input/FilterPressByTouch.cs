using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.input
{
	// Token: 0x02000043 RID: 67
	public class FilterPressByTouch : PressFilter
	{
		// Token: 0x060001FE RID: 510 RVA: 0x0000D138 File Offset: 0x0000B338
		// Note: this type is marked as 'beforefieldinit'.
		static FilterPressByTouch()
		{
			Il2CppClassPointerStore<FilterPressByTouch>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input", "FilterPressByTouch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterPressByTouch>.NativeClassPtr);
			FilterPressByTouch.NativeFieldInfoPtr_RespondsTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterPressByTouch>.NativeClassPtr, "RespondsTo");
			FilterPressByTouch.NativeMethodInfoPtr_Matches_Public_Virtual_Boolean_Press_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterPressByTouch>.NativeClassPtr, 100663558);
			FilterPressByTouch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterPressByTouch>.NativeClassPtr, 100663559);
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0000D1A4 File Offset: 0x0000B3A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120415, XrefRangeEnd = 1120420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Matches(Press press)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(press);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterPressByTouch.NativeMethodInfoPtr_Matches_Public_Virtual_Boolean_Press_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0000D1FC File Offset: 0x0000B3FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120420, XrefRangeEnd = 1120423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FilterPressByTouch()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterPressByTouch>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterPressByTouch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00003302 File Offset: 0x00001502
		public FilterPressByTouch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000202 RID: 514 RVA: 0x0000D238 File Offset: 0x0000B438
		// (set) Token: 0x06000203 RID: 515 RVA: 0x0000330B File Offset: 0x0000150B
		public unsafe FilterPressByTouch.PressType RespondsTo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterPressByTouch.NativeFieldInfoPtr_RespondsTo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterPressByTouch.NativeFieldInfoPtr_RespondsTo)) = value;
			}
		}

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeFieldInfoPtr_RespondsTo;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeMethodInfoPtr_Matches_Public_Virtual_Boolean_Press_0;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000C0 RID: 192
		public enum PressType
		{
			// Token: 0x0400055C RID: 1372
			Touch,
			// Token: 0x0400055D RID: 1373
			Click
		}
	}
}
