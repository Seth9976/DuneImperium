using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.Collections
{
	// Token: 0x020004C6 RID: 1222
	[Serializable]
	public class CaseInsensitiveComparer : Object
	{
		// Token: 0x06004AB5 RID: 19125 RVA: 0x001593F8 File Offset: 0x001575F8
		// Note: this type is marked as 'beforefieldinit'.
		static CaseInsensitiveComparer()
		{
			Il2CppClassPointerStore<CaseInsensitiveComparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "CaseInsensitiveComparer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CaseInsensitiveComparer>.NativeClassPtr);
			CaseInsensitiveComparer.NativeFieldInfoPtr__compareInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaseInsensitiveComparer>.NativeClassPtr, "_compareInfo");
			CaseInsensitiveComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaseInsensitiveComparer>.NativeClassPtr, 100674178);
			CaseInsensitiveComparer.NativeMethodInfoPtr__ctor_Public_Void_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaseInsensitiveComparer>.NativeClassPtr, 100674179);
			CaseInsensitiveComparer.NativeMethodInfoPtr_get_Default_Public_Static_get_CaseInsensitiveComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaseInsensitiveComparer>.NativeClassPtr, 100674180);
			CaseInsensitiveComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaseInsensitiveComparer>.NativeClassPtr, 100674181);
		}

		// Token: 0x06004AB6 RID: 19126 RVA: 0x0015948C File Offset: 0x0015768C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415011, XrefRangeEnd = 1415019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CaseInsensitiveComparer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CaseInsensitiveComparer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaseInsensitiveComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AB7 RID: 19127 RVA: 0x001594C8 File Offset: 0x001576C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1415027, RefRangeEnd = 1415029, XrefRangeStart = 1415019, XrefRangeEnd = 1415027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CaseInsensitiveComparer(CultureInfo culture)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CaseInsensitiveComparer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaseInsensitiveComparer.NativeMethodInfoPtr__ctor_Public_Void_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001321 RID: 4897
		// (get) Token: 0x06004AB8 RID: 19128 RVA: 0x00159514 File Offset: 0x00157714
		public unsafe static CaseInsensitiveComparer Default
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1415039, RefRangeEnd = 1415041, XrefRangeStart = 1415029, XrefRangeEnd = 1415039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaseInsensitiveComparer.NativeMethodInfoPtr_get_Default_Public_Static_get_CaseInsensitiveComparer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CaseInsensitiveComparer>(intPtr3) : null;
			}
		}

		// Token: 0x06004AB9 RID: 19129 RVA: 0x00159548 File Offset: 0x00157748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415041, XrefRangeEnd = 1415044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int Compare(Object a, Object b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaseInsensitiveComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004ABA RID: 19130 RVA: 0x0001B612 File Offset: 0x00019812
		public CaseInsensitiveComparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001320 RID: 4896
		// (get) Token: 0x06004ABB RID: 19131 RVA: 0x001595A8 File Offset: 0x001577A8
		// (set) Token: 0x06004ABC RID: 19132 RVA: 0x0001B61B File Offset: 0x0001981B
		public unsafe CompareInfo _compareInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CaseInsensitiveComparer.NativeFieldInfoPtr__compareInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CompareInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CaseInsensitiveComparer.NativeFieldInfoPtr__compareInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003D2E RID: 15662
		private static readonly IntPtr NativeFieldInfoPtr__compareInfo;

		// Token: 0x04003D2F RID: 15663
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003D30 RID: 15664
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CultureInfo_0;

		// Token: 0x04003D31 RID: 15665
		private static readonly IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_CaseInsensitiveComparer_0;

		// Token: 0x04003D32 RID: 15666
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0;
	}
}
