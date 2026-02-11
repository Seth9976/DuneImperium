using System;
using boardgames.ranked.menus;
using boardgames.utils;
using dwd.iap.store;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.menus.components
{
	// Token: 0x0200009C RID: 156
	public class RankedExpansionLocalizationSubstitutor : VersionedView<RankedPlayProvider>
	{
		// Token: 0x0600061D RID: 1565 RVA: 0x0002B510 File Offset: 0x00029710
		// Note: this type is marked as 'beforefieldinit'.
		static RankedExpansionLocalizationSubstitutor()
		{
			Il2CppClassPointerStore<RankedExpansionLocalizationSubstitutor>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.menus.components", "RankedExpansionLocalizationSubstitutor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedExpansionLocalizationSubstitutor>.NativeClassPtr);
			RankedExpansionLocalizationSubstitutor.NativeFieldInfoPtr_ixSuffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedExpansionLocalizationSubstitutor>.NativeClassPtr, "ixSuffix");
			RankedExpansionLocalizationSubstitutor.NativeFieldInfoPtr_immortalitySuffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedExpansionLocalizationSubstitutor>.NativeClassPtr, "immortalitySuffix");
			RankedExpansionLocalizationSubstitutor.NativeFieldInfoPtr_locKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedExpansionLocalizationSubstitutor>.NativeClassPtr, "locKey");
			RankedExpansionLocalizationSubstitutor.NativeFieldInfoPtr_iapStoreBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedExpansionLocalizationSubstitutor>.NativeClassPtr, "iapStoreBehaviour");
			RankedExpansionLocalizationSubstitutor.NativeFieldInfoPtr_productUtils = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedExpansionLocalizationSubstitutor>.NativeClassPtr, "productUtils");
			RankedExpansionLocalizationSubstitutor.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedExpansionLocalizationSubstitutor>.NativeClassPtr, 100664166);
			RankedExpansionLocalizationSubstitutor.NativeMethodInfoPtr_Substitute_Public_Virtual_Final_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedExpansionLocalizationSubstitutor>.NativeClassPtr, 100664167);
			RankedExpansionLocalizationSubstitutor.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedExpansionLocalizationSubstitutor>.NativeClassPtr, 100664168);
			RankedExpansionLocalizationSubstitutor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedExpansionLocalizationSubstitutor>.NativeClassPtr, 100664169);
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x0002B5F4 File Offset: 0x000297F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696021, XrefRangeEnd = 696033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RankedExpansionLocalizationSubstitutor.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x0002B630 File Offset: 0x00029830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696033, XrefRangeEnd = 696068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string Substitute(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedExpansionLocalizationSubstitutor.NativeMethodInfoPtr_Substitute_Public_Virtual_Final_New_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x0002B678 File Offset: 0x00029878
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RankedExpansionLocalizationSubstitutor.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x0002B6B4 File Offset: 0x000298B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696068, XrefRangeEnd = 696078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankedExpansionLocalizationSubstitutor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankedExpansionLocalizationSubstitutor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedExpansionLocalizationSubstitutor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00005103 File Offset: 0x00003303
		public RankedExpansionLocalizationSubstitutor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000623 RID: 1571 RVA: 0x0002B6F0 File Offset: 0x000298F0
		// (set) Token: 0x06000624 RID: 1572 RVA: 0x0000510C File Offset: 0x0000330C
		public unsafe string ixSuffix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedExpansionLocalizationSubstitutor.NativeFieldInfoPtr_ixSuffix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedExpansionLocalizationSubstitutor.NativeFieldInfoPtr_ixSuffix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000625 RID: 1573 RVA: 0x0002B718 File Offset: 0x00029918
		// (set) Token: 0x06000626 RID: 1574 RVA: 0x0000512B File Offset: 0x0000332B
		public unsafe string immortalitySuffix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedExpansionLocalizationSubstitutor.NativeFieldInfoPtr_immortalitySuffix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedExpansionLocalizationSubstitutor.NativeFieldInfoPtr_immortalitySuffix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000627 RID: 1575 RVA: 0x0002B740 File Offset: 0x00029940
		// (set) Token: 0x06000628 RID: 1576 RVA: 0x0000514A File Offset: 0x0000334A
		public unsafe string locKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedExpansionLocalizationSubstitutor.NativeFieldInfoPtr_locKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedExpansionLocalizationSubstitutor.NativeFieldInfoPtr_locKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000629 RID: 1577 RVA: 0x0002B768 File Offset: 0x00029968
		// (set) Token: 0x0600062A RID: 1578 RVA: 0x00005169 File Offset: 0x00003369
		public unsafe IAPStoreBehaviour iapStoreBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedExpansionLocalizationSubstitutor.NativeFieldInfoPtr_iapStoreBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAPStoreBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedExpansionLocalizationSubstitutor.NativeFieldInfoPtr_iapStoreBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x0600062B RID: 1579 RVA: 0x0002B798 File Offset: 0x00029998
		// (set) Token: 0x0600062C RID: 1580 RVA: 0x00005188 File Offset: 0x00003388
		public unsafe ProductUtils productUtils
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedExpansionLocalizationSubstitutor.NativeFieldInfoPtr_productUtils);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductUtils>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedExpansionLocalizationSubstitutor.NativeFieldInfoPtr_productUtils), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000385 RID: 901
		private static readonly IntPtr NativeFieldInfoPtr_ixSuffix;

		// Token: 0x04000386 RID: 902
		private static readonly IntPtr NativeFieldInfoPtr_immortalitySuffix;

		// Token: 0x04000387 RID: 903
		private static readonly IntPtr NativeFieldInfoPtr_locKey;

		// Token: 0x04000388 RID: 904
		private static readonly IntPtr NativeFieldInfoPtr_iapStoreBehaviour;

		// Token: 0x04000389 RID: 905
		private static readonly IntPtr NativeFieldInfoPtr_productUtils;

		// Token: 0x0400038A RID: 906
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400038B RID: 907
		private static readonly IntPtr NativeMethodInfoPtr_Substitute_Public_Virtual_Final_New_String_String_0;

		// Token: 0x0400038C RID: 908
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x0400038D RID: 909
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
