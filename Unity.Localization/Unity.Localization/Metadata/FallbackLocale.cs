using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Localization.Metadata
{
	// Token: 0x020000D3 RID: 211
	[Serializable]
	public class FallbackLocale : Object
	{
		// Token: 0x06000AE2 RID: 2786 RVA: 0x00032320 File Offset: 0x00030520
		// Note: this type is marked as 'beforefieldinit'.
		static FallbackLocale()
		{
			Il2CppClassPointerStore<FallbackLocale>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Metadata", "FallbackLocale");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FallbackLocale>.NativeClassPtr);
			FallbackLocale.NativeFieldInfoPtr_m_Locale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallbackLocale>.NativeClassPtr, "m_Locale");
			FallbackLocale.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackLocale>.NativeClassPtr, 100665104);
			FallbackLocale.NativeMethodInfoPtr__ctor_Public_Void_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackLocale>.NativeClassPtr, 100665105);
			FallbackLocale.NativeMethodInfoPtr_get_Locale_Public_get_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackLocale>.NativeClassPtr, 100665106);
			FallbackLocale.NativeMethodInfoPtr_set_Locale_Public_set_Void_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackLocale>.NativeClassPtr, 100665107);
			FallbackLocale.NativeMethodInfoPtr_IsCyclic_Private_Boolean_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackLocale>.NativeClassPtr, 100665108);
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x000323C8 File Offset: 0x000305C8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FallbackLocale()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FallbackLocale>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallbackLocale.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x00032404 File Offset: 0x00030604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078934, XrefRangeEnd = 1078950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FallbackLocale(Locale fallback)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FallbackLocale>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallbackLocale.NativeMethodInfoPtr__ctor_Public_Void_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000AE5 RID: 2789 RVA: 0x00032450 File Offset: 0x00030650
		// (set) Token: 0x06000AE6 RID: 2790 RVA: 0x00032490 File Offset: 0x00030690
		public unsafe Locale Locale
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallbackLocale.NativeMethodInfoPtr_get_Locale_Public_get_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Locale>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078950, XrefRangeEnd = 1078965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallbackLocale.NativeMethodInfoPtr_set_Locale_Public_set_Void_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x000324D4 File Offset: 0x000306D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078965, XrefRangeEnd = 1078979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsCyclic(Locale locale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locale);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallbackLocale.NativeMethodInfoPtr_IsCyclic_Private_Boolean_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x000068ED File Offset: 0x00004AED
		public FallbackLocale(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000AE9 RID: 2793 RVA: 0x00032524 File Offset: 0x00030724
		// (set) Token: 0x06000AEA RID: 2794 RVA: 0x000068F6 File Offset: 0x00004AF6
		public unsafe Locale m_Locale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackLocale.NativeFieldInfoPtr_m_Locale);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Locale>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackLocale.NativeFieldInfoPtr_m_Locale), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007A7 RID: 1959
		private static readonly IntPtr NativeFieldInfoPtr_m_Locale;

		// Token: 0x040007A8 RID: 1960
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040007A9 RID: 1961
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Locale_0;

		// Token: 0x040007AA RID: 1962
		private static readonly IntPtr NativeMethodInfoPtr_get_Locale_Public_get_Locale_0;

		// Token: 0x040007AB RID: 1963
		private static readonly IntPtr NativeMethodInfoPtr_set_Locale_Public_set_Void_Locale_0;

		// Token: 0x040007AC RID: 1964
		private static readonly IntPtr NativeMethodInfoPtr_IsCyclic_Private_Boolean_Locale_0;
	}
}
