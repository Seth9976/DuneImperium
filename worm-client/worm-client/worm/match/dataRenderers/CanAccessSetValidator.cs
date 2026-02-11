using System;
using Canis.utils.ids;
using dwd.iap.store;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using worm.canis.data.enums;

namespace worm.match.dataRenderers
{
	// Token: 0x020000F0 RID: 240
	public class CanAccessSetValidator : MonoBehaviour
	{
		// Token: 0x06000A98 RID: 2712 RVA: 0x00038574 File Offset: 0x00036774
		// Note: this type is marked as 'beforefieldinit'.
		static CanAccessSetValidator()
		{
			Il2CppClassPointerStore<CanAccessSetValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "CanAccessSetValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanAccessSetValidator>.NativeClassPtr);
			CanAccessSetValidator.NativeFieldInfoPtr_set = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanAccessSetValidator>.NativeClassPtr, "set");
			CanAccessSetValidator.NativeFieldInfoPtr__Valid_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanAccessSetValidator>.NativeClassPtr, "<Valid>k__BackingField");
			CanAccessSetValidator.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanAccessSetValidator>.NativeClassPtr, 100664750);
			CanAccessSetValidator.NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanAccessSetValidator>.NativeClassPtr, 100664751);
			CanAccessSetValidator.NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanAccessSetValidator>.NativeClassPtr, 100664752);
			CanAccessSetValidator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanAccessSetValidator>.NativeClassPtr, 100664753);
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x0003861C File Offset: 0x0003681C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701755, XrefRangeEnd = 701792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanAccessSetValidator.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000A9A RID: 2714 RVA: 0x00038650 File Offset: 0x00036850
		// (set) Token: 0x06000A9B RID: 2715 RVA: 0x0003868C File Offset: 0x0003688C
		public unsafe virtual bool Valid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanAccessSetValidator.NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanAccessSetValidator.NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x000386CC File Offset: 0x000368CC
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CanAccessSetValidator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanAccessSetValidator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanAccessSetValidator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x000078AA File Offset: 0x00005AAA
		public CanAccessSetValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000A9E RID: 2718 RVA: 0x00038708 File Offset: 0x00036908
		// (set) Token: 0x06000A9F RID: 2719 RVA: 0x000078B3 File Offset: 0x00005AB3
		public unsafe Set set
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanAccessSetValidator.NativeFieldInfoPtr_set);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanAccessSetValidator.NativeFieldInfoPtr_set)) = value;
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000AA0 RID: 2720 RVA: 0x00038730 File Offset: 0x00036930
		// (set) Token: 0x06000AA1 RID: 2721 RVA: 0x000078CE File Offset: 0x00005ACE
		public unsafe bool _Valid_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanAccessSetValidator.NativeFieldInfoPtr__Valid_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanAccessSetValidator.NativeFieldInfoPtr__Valid_k__BackingField)) = value;
			}
		}

		// Token: 0x0400061E RID: 1566
		private static readonly IntPtr NativeFieldInfoPtr_set;

		// Token: 0x0400061F RID: 1567
		private static readonly IntPtr NativeFieldInfoPtr__Valid_k__BackingField;

		// Token: 0x04000620 RID: 1568
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000621 RID: 1569
		private static readonly IntPtr NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000622 RID: 1570
		private static readonly IntPtr NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04000623 RID: 1571
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000351 RID: 849
		[ObfuscatedName("worm.match.dataRenderers.CanAccessSetValidator+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002250 RID: 8784 RVA: 0x0008065C File Offset: 0x0007E85C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<CanAccessSetValidator.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CanAccessSetValidator>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanAccessSetValidator.__c__DisplayClass1_0>.NativeClassPtr);
				CanAccessSetValidator.__c__DisplayClass1_0.NativeFieldInfoPtr_iapStoreBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanAccessSetValidator.__c__DisplayClass1_0>.NativeClassPtr, "iapStoreBehaviour");
				CanAccessSetValidator.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanAccessSetValidator.__c__DisplayClass1_0>.NativeClassPtr, "<>4__this");
				CanAccessSetValidator.__c__DisplayClass1_0.NativeFieldInfoPtr_product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanAccessSetValidator.__c__DisplayClass1_0>.NativeClassPtr, "product");
				CanAccessSetValidator.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanAccessSetValidator.__c__DisplayClass1_0>.NativeClassPtr, 100664754);
				CanAccessSetValidator.__c__DisplayClass1_0.NativeMethodInfoPtr__Awake_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanAccessSetValidator.__c__DisplayClass1_0>.NativeClassPtr, 100664755);
				CanAccessSetValidator.__c__DisplayClass1_0.NativeMethodInfoPtr__Awake_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanAccessSetValidator.__c__DisplayClass1_0>.NativeClassPtr, 100664756);
				CanAccessSetValidator.__c__DisplayClass1_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanAccessSetValidator.__c__DisplayClass1_0>.NativeClassPtr, 100664757);
			}

			// Token: 0x06002251 RID: 8785 RVA: 0x00080714 File Offset: 0x0007E914
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanAccessSetValidator.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanAccessSetValidator.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002252 RID: 8786 RVA: 0x00080750 File Offset: 0x0007E950
			[CallerCount(0)]
			public unsafe bool _Awake_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanAccessSetValidator.__c__DisplayClass1_0.NativeMethodInfoPtr__Awake_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002253 RID: 8787 RVA: 0x0008078C File Offset: 0x0007E98C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701749, XrefRangeEnd = 701754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanAccessSetValidator.__c__DisplayClass1_0.NativeMethodInfoPtr__Awake_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002254 RID: 8788 RVA: 0x000807C0 File Offset: 0x0007E9C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701754, XrefRangeEnd = 701755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanAccessSetValidator.__c__DisplayClass1_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002255 RID: 8789 RVA: 0x000133BA File Offset: 0x000115BA
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000977 RID: 2423
			// (get) Token: 0x06002256 RID: 8790 RVA: 0x000807F4 File Offset: 0x0007E9F4
			// (set) Token: 0x06002257 RID: 8791 RVA: 0x000133C3 File Offset: 0x000115C3
			public unsafe IAPStoreBehaviour iapStoreBehaviour
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanAccessSetValidator.__c__DisplayClass1_0.NativeFieldInfoPtr_iapStoreBehaviour);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAPStoreBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanAccessSetValidator.__c__DisplayClass1_0.NativeFieldInfoPtr_iapStoreBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000978 RID: 2424
			// (get) Token: 0x06002258 RID: 8792 RVA: 0x00080824 File Offset: 0x0007EA24
			// (set) Token: 0x06002259 RID: 8793 RVA: 0x000133E2 File Offset: 0x000115E2
			public unsafe CanAccessSetValidator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanAccessSetValidator.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanAccessSetValidator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanAccessSetValidator.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000979 RID: 2425
			// (get) Token: 0x0600225A RID: 8794 RVA: 0x00080854 File Offset: 0x0007EA54
			// (set) Token: 0x0600225B RID: 8795 RVA: 0x00013401 File Offset: 0x00011601
			public unsafe ArchetypeID product
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanAccessSetValidator.__c__DisplayClass1_0.NativeFieldInfoPtr_product);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanAccessSetValidator.__c__DisplayClass1_0.NativeFieldInfoPtr_product), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040013BF RID: 5055
			private static readonly IntPtr NativeFieldInfoPtr_iapStoreBehaviour;

			// Token: 0x040013C0 RID: 5056
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040013C1 RID: 5057
			private static readonly IntPtr NativeFieldInfoPtr_product;

			// Token: 0x040013C2 RID: 5058
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040013C3 RID: 5059
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__0_Internal_Boolean_0;

			// Token: 0x040013C4 RID: 5060
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__1_Internal_Void_0;

			// Token: 0x040013C5 RID: 5061
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}
	}
}
