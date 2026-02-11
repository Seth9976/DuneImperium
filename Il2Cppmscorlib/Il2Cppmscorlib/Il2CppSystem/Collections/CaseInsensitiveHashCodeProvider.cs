using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.Collections
{
	// Token: 0x020004C7 RID: 1223
	[Serializable]
	public class CaseInsensitiveHashCodeProvider : Object
	{
		// Token: 0x06004ABD RID: 19133 RVA: 0x001595D8 File Offset: 0x001577D8
		// Note: this type is marked as 'beforefieldinit'.
		static CaseInsensitiveHashCodeProvider()
		{
			Il2CppClassPointerStore<CaseInsensitiveHashCodeProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "CaseInsensitiveHashCodeProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CaseInsensitiveHashCodeProvider>.NativeClassPtr);
			CaseInsensitiveHashCodeProvider.NativeFieldInfoPtr__compareInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaseInsensitiveHashCodeProvider>.NativeClassPtr, "_compareInfo");
			CaseInsensitiveHashCodeProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaseInsensitiveHashCodeProvider>.NativeClassPtr, 100674182);
			CaseInsensitiveHashCodeProvider.NativeMethodInfoPtr__ctor_Public_Void_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaseInsensitiveHashCodeProvider>.NativeClassPtr, 100674183);
			CaseInsensitiveHashCodeProvider.NativeMethodInfoPtr_get_Default_Public_Static_get_CaseInsensitiveHashCodeProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaseInsensitiveHashCodeProvider>.NativeClassPtr, 100674184);
			CaseInsensitiveHashCodeProvider.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaseInsensitiveHashCodeProvider>.NativeClassPtr, 100674185);
		}

		// Token: 0x06004ABE RID: 19134 RVA: 0x0015966C File Offset: 0x0015786C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415044, XrefRangeEnd = 1415052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CaseInsensitiveHashCodeProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CaseInsensitiveHashCodeProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaseInsensitiveHashCodeProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004ABF RID: 19135 RVA: 0x001596A8 File Offset: 0x001578A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1415060, RefRangeEnd = 1415062, XrefRangeStart = 1415052, XrefRangeEnd = 1415060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CaseInsensitiveHashCodeProvider(CultureInfo culture)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CaseInsensitiveHashCodeProvider>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaseInsensitiveHashCodeProvider.NativeMethodInfoPtr__ctor_Public_Void_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001323 RID: 4899
		// (get) Token: 0x06004AC0 RID: 19136 RVA: 0x001596F4 File Offset: 0x001578F4
		public unsafe static CaseInsensitiveHashCodeProvider Default
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1415072, RefRangeEnd = 1415074, XrefRangeStart = 1415062, XrefRangeEnd = 1415072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaseInsensitiveHashCodeProvider.NativeMethodInfoPtr_get_Default_Public_Static_get_CaseInsensitiveHashCodeProvider_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CaseInsensitiveHashCodeProvider>(intPtr3) : null;
			}
		}

		// Token: 0x06004AC1 RID: 19137 RVA: 0x00159728 File Offset: 0x00157928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415074, XrefRangeEnd = 1415083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetHashCode(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaseInsensitiveHashCodeProvider.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004AC2 RID: 19138 RVA: 0x0001B63A File Offset: 0x0001983A
		public CaseInsensitiveHashCodeProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001322 RID: 4898
		// (get) Token: 0x06004AC3 RID: 19139 RVA: 0x00159778 File Offset: 0x00157978
		// (set) Token: 0x06004AC4 RID: 19140 RVA: 0x0001B643 File Offset: 0x00019843
		public unsafe CompareInfo _compareInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CaseInsensitiveHashCodeProvider.NativeFieldInfoPtr__compareInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CompareInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CaseInsensitiveHashCodeProvider.NativeFieldInfoPtr__compareInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003D33 RID: 15667
		private static readonly IntPtr NativeFieldInfoPtr__compareInfo;

		// Token: 0x04003D34 RID: 15668
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003D35 RID: 15669
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CultureInfo_0;

		// Token: 0x04003D36 RID: 15670
		private static readonly IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_CaseInsensitiveHashCodeProvider_0;

		// Token: 0x04003D37 RID: 15671
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Object_0;
	}
}
