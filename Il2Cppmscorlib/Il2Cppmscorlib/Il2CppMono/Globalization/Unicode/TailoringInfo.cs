using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Globalization.Unicode
{
	// Token: 0x02000020 RID: 32
	public class TailoringInfo : Object
	{
		// Token: 0x060000F3 RID: 243 RVA: 0x00029038 File Offset: 0x00027238
		// Note: this type is marked as 'beforefieldinit'.
		static TailoringInfo()
		{
			Il2CppClassPointerStore<TailoringInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Globalization.Unicode", "TailoringInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TailoringInfo>.NativeClassPtr);
			TailoringInfo.NativeFieldInfoPtr_LCID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TailoringInfo>.NativeClassPtr, "LCID");
			TailoringInfo.NativeFieldInfoPtr_TailoringIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TailoringInfo>.NativeClassPtr, "TailoringIndex");
			TailoringInfo.NativeFieldInfoPtr_TailoringCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TailoringInfo>.NativeClassPtr, "TailoringCount");
			TailoringInfo.NativeFieldInfoPtr_FrenchSort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TailoringInfo>.NativeClassPtr, "FrenchSort");
			TailoringInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TailoringInfo>.NativeClassPtr, 100663488);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x000290CC File Offset: 0x000272CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1276468, RefRangeEnd = 1276470, XrefRangeStart = 1276467, XrefRangeEnd = 1276468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TailoringInfo(int lcid, int tailoringIndex, int tailoringCount, bool frenchSort)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TailoringInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lcid;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tailoringIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tailoringCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frenchSort;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TailoringInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00002646 File Offset: 0x00000846
		public TailoringInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x00029140 File Offset: 0x00027340
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x0000264F File Offset: 0x0000084F
		public unsafe int LCID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TailoringInfo.NativeFieldInfoPtr_LCID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TailoringInfo.NativeFieldInfoPtr_LCID)) = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x00029168 File Offset: 0x00027368
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x0000266A File Offset: 0x0000086A
		public unsafe int TailoringIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TailoringInfo.NativeFieldInfoPtr_TailoringIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TailoringInfo.NativeFieldInfoPtr_TailoringIndex)) = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000FA RID: 250 RVA: 0x00029190 File Offset: 0x00027390
		// (set) Token: 0x060000FB RID: 251 RVA: 0x00002685 File Offset: 0x00000885
		public unsafe int TailoringCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TailoringInfo.NativeFieldInfoPtr_TailoringCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TailoringInfo.NativeFieldInfoPtr_TailoringCount)) = value;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000FC RID: 252 RVA: 0x000291B8 File Offset: 0x000273B8
		// (set) Token: 0x060000FD RID: 253 RVA: 0x000026A0 File Offset: 0x000008A0
		public unsafe bool FrenchSort
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TailoringInfo.NativeFieldInfoPtr_FrenchSort);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TailoringInfo.NativeFieldInfoPtr_FrenchSort)) = value;
			}
		}

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeFieldInfoPtr_LCID;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeFieldInfoPtr_TailoringIndex;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeFieldInfoPtr_TailoringCount;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeFieldInfoPtr_FrenchSort;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Boolean_0;
	}
}
