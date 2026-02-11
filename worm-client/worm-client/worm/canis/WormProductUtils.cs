using System;
using boardgames.utils;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using worm.canis.data.enums;

namespace worm.canis
{
	// Token: 0x02000079 RID: 121
	public class WormProductUtils : ProductUtils<Set>
	{
		// Token: 0x0600049D RID: 1181 RVA: 0x00026C14 File Offset: 0x00024E14
		// Note: this type is marked as 'beforefieldinit'.
		static WormProductUtils()
		{
			Il2CppClassPointerStore<WormProductUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.canis", "WormProductUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormProductUtils>.NativeClassPtr);
			WormProductUtils.NativeFieldInfoPtr_ArchIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormProductUtils>.NativeClassPtr, "ArchIDs");
			WormProductUtils.NativeFieldInfoPtr_NintendoAOCIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormProductUtils>.NativeClassPtr, "NintendoAOCIndices");
			WormProductUtils.NativeFieldInfoPtr_LocStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormProductUtils>.NativeClassPtr, "LocStrings");
			WormProductUtils.NativeFieldInfoPtr_VariantOwnershipRequirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormProductUtils>.NativeClassPtr, "VariantOwnershipRequirements");
			WormProductUtils.NativeMethodInfoPtr_archIDForProduct_Protected_Virtual_ArchetypeID_Set_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormProductUtils>.NativeClassPtr, 100663956);
			WormProductUtils.NativeMethodInfoPtr_productForArchId_Protected_Virtual_Set_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormProductUtils>.NativeClassPtr, 100663957);
			WormProductUtils.NativeMethodInfoPtr_stringForProduct_Protected_Virtual_String_Set_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormProductUtils>.NativeClassPtr, 100663958);
			WormProductUtils.NativeMethodInfoPtr_productForString_Protected_Virtual_Set_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormProductUtils>.NativeClassPtr, 100663959);
			WormProductUtils.NativeMethodInfoPtr_productForNintendoAocIndex_Protected_Virtual_Set_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormProductUtils>.NativeClassPtr, 100663960);
			WormProductUtils.NativeMethodInfoPtr_get_NintendoAocIndicesCount_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormProductUtils>.NativeClassPtr, 100663961);
			WormProductUtils.NativeMethodInfoPtr_getProductLocName_Protected_Virtual_String_Set_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormProductUtils>.NativeClassPtr, 100663962);
			WormProductUtils.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormProductUtils>.NativeClassPtr, 100663963);
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00026D34 File Offset: 0x00024F34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 693830, XrefRangeEnd = 693841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ArchetypeID archIDForProduct(Set product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref product;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormProductUtils.NativeMethodInfoPtr_archIDForProduct_Protected_Virtual_ArchetypeID_Set_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr3) : null;
			}
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00026D8C File Offset: 0x00024F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 693841, XrefRangeEnd = 693860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Set productForArchId(ArchetypeID archID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(archID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormProductUtils.NativeMethodInfoPtr_productForArchId_Protected_Virtual_Set_ArchetypeID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00026DE4 File Offset: 0x00024FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 693860, XrefRangeEnd = 693863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string stringForProduct(Set product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref product;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormProductUtils.NativeMethodInfoPtr_stringForProduct_Protected_Virtual_String_Set_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00026E34 File Offset: 0x00025034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 693863, XrefRangeEnd = 693869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Set productForString(string productName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(productName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormProductUtils.NativeMethodInfoPtr_productForString_Protected_Virtual_Set_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00026E8C File Offset: 0x0002508C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 693869, XrefRangeEnd = 693876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Set productForNintendoAocIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormProductUtils.NativeMethodInfoPtr_productForNintendoAocIndex_Protected_Virtual_Set_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060004A3 RID: 1187 RVA: 0x00026EE0 File Offset: 0x000250E0
		public unsafe override int NintendoAocIndicesCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 693876, XrefRangeEnd = 693884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormProductUtils.NativeMethodInfoPtr_get_NintendoAocIndicesCount_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00026F28 File Offset: 0x00025128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 693884, XrefRangeEnd = 693897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string getProductLocName(Set product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref product;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormProductUtils.NativeMethodInfoPtr_getProductLocName_Protected_Virtual_String_Set_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00026F78 File Offset: 0x00025178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 693897, XrefRangeEnd = 693900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormProductUtils()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormProductUtils>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormProductUtils.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00004509 File Offset: 0x00002709
		public WormProductUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060004A7 RID: 1191 RVA: 0x00026FB4 File Offset: 0x000251B4
		// (set) Token: 0x060004A8 RID: 1192 RVA: 0x00004512 File Offset: 0x00002712
		public unsafe static Dictionary<Set, ArchetypeID> ArchIDs
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormProductUtils.NativeFieldInfoPtr_ArchIDs, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Set, ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormProductUtils.NativeFieldInfoPtr_ArchIDs, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060004A9 RID: 1193 RVA: 0x00026FDC File Offset: 0x000251DC
		// (set) Token: 0x060004AA RID: 1194 RVA: 0x00004524 File Offset: 0x00002724
		public unsafe static Dictionary<int, Set> NintendoAOCIndices
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormProductUtils.NativeFieldInfoPtr_NintendoAOCIndices, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Set>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormProductUtils.NativeFieldInfoPtr_NintendoAOCIndices, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x00027004 File Offset: 0x00025204
		// (set) Token: 0x060004AC RID: 1196 RVA: 0x00004536 File Offset: 0x00002736
		public unsafe static Dictionary<Set, string> LocStrings
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormProductUtils.NativeFieldInfoPtr_LocStrings, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Set, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormProductUtils.NativeFieldInfoPtr_LocStrings, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x0002702C File Offset: 0x0002522C
		// (set) Token: 0x060004AE RID: 1198 RVA: 0x00004548 File Offset: 0x00002748
		public unsafe static IReadOnlyDictionary<string, Set> VariantOwnershipRequirements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormProductUtils.NativeFieldInfoPtr_VariantOwnershipRequirements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyDictionary<string, Set>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormProductUtils.NativeFieldInfoPtr_VariantOwnershipRequirements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002A6 RID: 678
		private static readonly IntPtr NativeFieldInfoPtr_ArchIDs;

		// Token: 0x040002A7 RID: 679
		private static readonly IntPtr NativeFieldInfoPtr_NintendoAOCIndices;

		// Token: 0x040002A8 RID: 680
		private static readonly IntPtr NativeFieldInfoPtr_LocStrings;

		// Token: 0x040002A9 RID: 681
		private static readonly IntPtr NativeFieldInfoPtr_VariantOwnershipRequirements;

		// Token: 0x040002AA RID: 682
		private static readonly IntPtr NativeMethodInfoPtr_archIDForProduct_Protected_Virtual_ArchetypeID_Set_0;

		// Token: 0x040002AB RID: 683
		private static readonly IntPtr NativeMethodInfoPtr_productForArchId_Protected_Virtual_Set_ArchetypeID_0;

		// Token: 0x040002AC RID: 684
		private static readonly IntPtr NativeMethodInfoPtr_stringForProduct_Protected_Virtual_String_Set_0;

		// Token: 0x040002AD RID: 685
		private static readonly IntPtr NativeMethodInfoPtr_productForString_Protected_Virtual_Set_String_0;

		// Token: 0x040002AE RID: 686
		private static readonly IntPtr NativeMethodInfoPtr_productForNintendoAocIndex_Protected_Virtual_Set_Int32_0;

		// Token: 0x040002AF RID: 687
		private static readonly IntPtr NativeMethodInfoPtr_get_NintendoAocIndicesCount_Public_Virtual_get_Int32_0;

		// Token: 0x040002B0 RID: 688
		private static readonly IntPtr NativeMethodInfoPtr_getProductLocName_Protected_Virtual_String_Set_0;

		// Token: 0x040002B1 RID: 689
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002EF RID: 751
		[ObfuscatedName("worm.canis.WormProductUtils+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x06001E89 RID: 7817 RVA: 0x00075A4C File Offset: 0x00073C4C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<WormProductUtils.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormProductUtils>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormProductUtils.__c__DisplayClass1_0>.NativeClassPtr);
				WormProductUtils.__c__DisplayClass1_0.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormProductUtils.__c__DisplayClass1_0>.NativeClassPtr, "archID");
				WormProductUtils.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormProductUtils.__c__DisplayClass1_0>.NativeClassPtr, 100663965);
				WormProductUtils.__c__DisplayClass1_0.NativeMethodInfoPtr__productForArchId_b__0_Internal_Boolean_KeyValuePair_2_Set_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormProductUtils.__c__DisplayClass1_0>.NativeClassPtr, 100663966);
			}

			// Token: 0x06001E8A RID: 7818 RVA: 0x00075AB4 File Offset: 0x00073CB4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormProductUtils.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormProductUtils.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E8B RID: 7819 RVA: 0x00075AF0 File Offset: 0x00073CF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 693825, XrefRangeEnd = 693830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _productForArchId_b__0(KeyValuePair<Set, ArchetypeID> a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(a));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormProductUtils.__c__DisplayClass1_0.NativeMethodInfoPtr__productForArchId_b__0_Internal_Boolean_KeyValuePair_2_Set_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001E8C RID: 7820 RVA: 0x00011514 File Offset: 0x0000F714
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000860 RID: 2144
			// (get) Token: 0x06001E8D RID: 7821 RVA: 0x00075B44 File Offset: 0x00073D44
			// (set) Token: 0x06001E8E RID: 7822 RVA: 0x0001151D File Offset: 0x0000F71D
			public unsafe ArchetypeID archID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormProductUtils.__c__DisplayClass1_0.NativeFieldInfoPtr_archID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormProductUtils.__c__DisplayClass1_0.NativeFieldInfoPtr_archID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040011B1 RID: 4529
			private static readonly IntPtr NativeFieldInfoPtr_archID;

			// Token: 0x040011B2 RID: 4530
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040011B3 RID: 4531
			private static readonly IntPtr NativeMethodInfoPtr__productForArchId_b__0_Internal_Boolean_KeyValuePair_2_Set_ArchetypeID_0;
		}
	}
}
