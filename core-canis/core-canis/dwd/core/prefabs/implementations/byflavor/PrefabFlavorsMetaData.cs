using System;
using dwd.core.data.readonlyWrappers;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.prefabs.implementations.byflavor
{
	// Token: 0x02000115 RID: 277
	[Serializable]
	public sealed class PrefabFlavorsMetaData : ValueType
	{
		// Token: 0x06000FAE RID: 4014 RVA: 0x00051C1C File Offset: 0x0004FE1C
		// Note: this type is marked as 'beforefieldinit'.
		static PrefabFlavorsMetaData()
		{
			Il2CppClassPointerStore<PrefabFlavorsMetaData>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.prefabs.implementations.byflavor", "PrefabFlavorsMetaData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabFlavorsMetaData>.NativeClassPtr);
			PrefabFlavorsMetaData.NativeFieldInfoPtr_flavors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabFlavorsMetaData>.NativeClassPtr, "flavors");
			PrefabFlavorsMetaData.NativeFieldInfoPtr_flavorProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabFlavorsMetaData>.NativeClassPtr, "flavorProviders");
			PrefabFlavorsMetaData.NativeFieldInfoPtr_readonlyFlavors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabFlavorsMetaData>.NativeClassPtr, "readonlyFlavors");
			PrefabFlavorsMetaData.NativeMethodInfoPtr_IsMatch_Public_Boolean_ICollection_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabFlavorsMetaData>.NativeClassPtr, 100665576);
			PrefabFlavorsMetaData.NativeMethodInfoPtr_getFlavors_Private_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabFlavorsMetaData>.NativeClassPtr, 100665577);
			PrefabFlavorsMetaData.NativeMethodInfoPtr_get_FlavorCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabFlavorsMetaData>.NativeClassPtr, 100665578);
			PrefabFlavorsMetaData.NativeMethodInfoPtr_get_Flavors_Public_get_ReadOnlyList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabFlavorsMetaData>.NativeClassPtr, 100665579);
			PrefabFlavorsMetaData.NativeMethodInfoPtr_AppendFlavor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabFlavorsMetaData>.NativeClassPtr, 100665580);
			PrefabFlavorsMetaData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabFlavorsMetaData>.NativeClassPtr, 100665581);
			PrefabFlavorsMetaData.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabFlavorsMetaData>.NativeClassPtr, 100665582);
			PrefabFlavorsMetaData.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabFlavorsMetaData>.NativeClassPtr, 100665583);
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x00051D28 File Offset: 0x0004FF28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 868782, RefRangeEnd = 868783, XrefRangeStart = 868755, XrefRangeEnd = 868782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMatch(ICollection<string> otherFlavors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(otherFlavors);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabFlavorsMetaData.NativeMethodInfoPtr_IsMatch_Public_Boolean_ICollection_1_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x00051D7C File Offset: 0x0004FF7C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 868789, RefRangeEnd = 868793, XrefRangeStart = 868783, XrefRangeEnd = 868789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<string> getFlavors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabFlavorsMetaData.NativeMethodInfoPtr_getFlavors_Private_IEnumerable_1_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06000FB1 RID: 4017 RVA: 0x00051DC0 File Offset: 0x0004FFC0
		public unsafe int FlavorCount
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 868829, RefRangeEnd = 868831, XrefRangeStart = 868793, XrefRangeEnd = 868829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabFlavorsMetaData.NativeMethodInfoPtr_get_FlavorCount_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06000FB2 RID: 4018 RVA: 0x00051E04 File Offset: 0x00050004
		public unsafe ReadOnlyList<string> Flavors
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 868842, RefRangeEnd = 868848, XrefRangeStart = 868831, XrefRangeEnd = 868842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabFlavorsMetaData.NativeMethodInfoPtr_get_Flavors_Public_get_ReadOnlyList_1_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyList<string>>(intPtr3) : null;
			}
		}

		// Token: 0x06000FB3 RID: 4019 RVA: 0x00051E48 File Offset: 0x00050048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 868848, XrefRangeEnd = 868854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendFlavor(string flavor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(flavor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabFlavorsMetaData.NativeMethodInfoPtr_AppendFlavor_Public_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FB4 RID: 4020 RVA: 0x00051E90 File Offset: 0x00050090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 868854, XrefRangeEnd = 868860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabFlavorsMetaData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000FB5 RID: 4021 RVA: 0x00051ECC File Offset: 0x000500CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 868860, XrefRangeEnd = 868865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator<string> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabFlavorsMetaData.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<string>>(intPtr3) : null;
		}

		// Token: 0x06000FB6 RID: 4022 RVA: 0x00051F10 File Offset: 0x00050110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabFlavorsMetaData.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x000075D6 File Offset: 0x000057D6
		public PrefabFlavorsMetaData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x000075DF File Offset: 0x000057DF
		public PrefabFlavorsMetaData()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabFlavorsMetaData>.NativeClassPtr))
		{
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06000FB9 RID: 4025 RVA: 0x00051F54 File Offset: 0x00050154
		// (set) Token: 0x06000FBA RID: 4026 RVA: 0x000075F1 File Offset: 0x000057F1
		public unsafe List<string> flavors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabFlavorsMetaData.NativeFieldInfoPtr_flavors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabFlavorsMetaData.NativeFieldInfoPtr_flavors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06000FBB RID: 4027 RVA: 0x00051F84 File Offset: 0x00050184
		// (set) Token: 0x06000FBC RID: 4028 RVA: 0x00007610 File Offset: 0x00005810
		public unsafe List<FlavorProvider> flavorProviders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabFlavorsMetaData.NativeFieldInfoPtr_flavorProviders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FlavorProvider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabFlavorsMetaData.NativeFieldInfoPtr_flavorProviders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06000FBD RID: 4029 RVA: 0x00051FB4 File Offset: 0x000501B4
		// (set) Token: 0x06000FBE RID: 4030 RVA: 0x0000762F File Offset: 0x0000582F
		public unsafe ReadOnlyList<string> readonlyFlavors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabFlavorsMetaData.NativeFieldInfoPtr_readonlyFlavors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyList<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabFlavorsMetaData.NativeFieldInfoPtr_readonlyFlavors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B2D RID: 2861
		private static readonly IntPtr NativeFieldInfoPtr_flavors;

		// Token: 0x04000B2E RID: 2862
		private static readonly IntPtr NativeFieldInfoPtr_flavorProviders;

		// Token: 0x04000B2F RID: 2863
		private static readonly IntPtr NativeFieldInfoPtr_readonlyFlavors;

		// Token: 0x04000B30 RID: 2864
		private static readonly IntPtr NativeMethodInfoPtr_IsMatch_Public_Boolean_ICollection_1_String_0;

		// Token: 0x04000B31 RID: 2865
		private static readonly IntPtr NativeMethodInfoPtr_getFlavors_Private_IEnumerable_1_String_0;

		// Token: 0x04000B32 RID: 2866
		private static readonly IntPtr NativeMethodInfoPtr_get_FlavorCount_Public_get_Int32_0;

		// Token: 0x04000B33 RID: 2867
		private static readonly IntPtr NativeMethodInfoPtr_get_Flavors_Public_get_ReadOnlyList_1_String_0;

		// Token: 0x04000B34 RID: 2868
		private static readonly IntPtr NativeMethodInfoPtr_AppendFlavor_Public_Void_String_0;

		// Token: 0x04000B35 RID: 2869
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000B36 RID: 2870
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_String_0;

		// Token: 0x04000B37 RID: 2871
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x020002C3 RID: 707
		[ObfuscatedName("dwd.core.prefabs.implementations.byflavor.PrefabFlavorsMetaData+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002105 RID: 8453 RVA: 0x000946E0 File Offset: 0x000928E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PrefabFlavorsMetaData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabFlavorsMetaData>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabFlavorsMetaData.__c>.NativeClassPtr);
				PrefabFlavorsMetaData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabFlavorsMetaData.__c>.NativeClassPtr, "<>9");
				PrefabFlavorsMetaData.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabFlavorsMetaData.__c>.NativeClassPtr, "<>9__5_0");
				PrefabFlavorsMetaData.__c.NativeFieldInfoPtr___9__5_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabFlavorsMetaData.__c>.NativeClassPtr, "<>9__5_1");
				PrefabFlavorsMetaData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabFlavorsMetaData.__c>.NativeClassPtr, 100665585);
				PrefabFlavorsMetaData.__c.NativeMethodInfoPtr__get_FlavorCount_b__5_0_Internal_Boolean_FlavorProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabFlavorsMetaData.__c>.NativeClassPtr, 100665586);
				PrefabFlavorsMetaData.__c.NativeMethodInfoPtr__get_FlavorCount_b__5_1_Internal_Int32_FlavorProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabFlavorsMetaData.__c>.NativeClassPtr, 100665587);
			}

			// Token: 0x06002106 RID: 8454 RVA: 0x00094784 File Offset: 0x00092984
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabFlavorsMetaData.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabFlavorsMetaData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002107 RID: 8455 RVA: 0x000947C0 File Offset: 0x000929C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 868659, XrefRangeEnd = 868663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_FlavorCount_b__5_0(FlavorProvider provider)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabFlavorsMetaData.__c.NativeMethodInfoPtr__get_FlavorCount_b__5_0_Internal_Boolean_FlavorProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002108 RID: 8456 RVA: 0x00094810 File Offset: 0x00092A10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 868663, XrefRangeEnd = 868667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _get_FlavorCount_b__5_1(FlavorProvider provider)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabFlavorsMetaData.__c.NativeMethodInfoPtr__get_FlavorCount_b__5_1_Internal_Int32_FlavorProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002109 RID: 8457 RVA: 0x0000E1C3 File Offset: 0x0000C3C3
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008FE RID: 2302
			// (get) Token: 0x0600210A RID: 8458 RVA: 0x00094860 File Offset: 0x00092A60
			// (set) Token: 0x0600210B RID: 8459 RVA: 0x0000E1CC File Offset: 0x0000C3CC
			public unsafe static PrefabFlavorsMetaData.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PrefabFlavorsMetaData.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefabFlavorsMetaData.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PrefabFlavorsMetaData.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008FF RID: 2303
			// (get) Token: 0x0600210C RID: 8460 RVA: 0x00094888 File Offset: 0x00092A88
			// (set) Token: 0x0600210D RID: 8461 RVA: 0x0000E1DE File Offset: 0x0000C3DE
			public unsafe static Func<FlavorProvider, bool> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PrefabFlavorsMetaData.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<FlavorProvider, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PrefabFlavorsMetaData.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000900 RID: 2304
			// (get) Token: 0x0600210E RID: 8462 RVA: 0x000948B0 File Offset: 0x00092AB0
			// (set) Token: 0x0600210F RID: 8463 RVA: 0x0000E1F0 File Offset: 0x0000C3F0
			public unsafe static Func<FlavorProvider, int> __9__5_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PrefabFlavorsMetaData.__c.NativeFieldInfoPtr___9__5_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<FlavorProvider, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PrefabFlavorsMetaData.__c.NativeFieldInfoPtr___9__5_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040016EC RID: 5868
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040016ED RID: 5869
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x040016EE RID: 5870
			private static readonly IntPtr NativeFieldInfoPtr___9__5_1;

			// Token: 0x040016EF RID: 5871
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040016F0 RID: 5872
			private static readonly IntPtr NativeMethodInfoPtr__get_FlavorCount_b__5_0_Internal_Boolean_FlavorProvider_0;

			// Token: 0x040016F1 RID: 5873
			private static readonly IntPtr NativeMethodInfoPtr__get_FlavorCount_b__5_1_Internal_Int32_FlavorProvider_0;
		}

		// Token: 0x020002C4 RID: 708
		[ObfuscatedName("dwd.core.prefabs.implementations.byflavor.PrefabFlavorsMetaData+<getFlavors>d__3")]
		public sealed class _getFlavors_d__3 : Object
		{
			// Token: 0x06002110 RID: 8464 RVA: 0x000948D8 File Offset: 0x00092AD8
			// Note: this type is marked as 'beforefieldinit'.
			static _getFlavors_d__3()
			{
				Il2CppClassPointerStore<PrefabFlavorsMetaData._getFlavors_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabFlavorsMetaData>.NativeClassPtr, "<getFlavors>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabFlavorsMetaData._getFlavors_d__3>.NativeClassPtr);
				PrefabFlavorsMetaData._getFlavors_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabFlavorsMetaData._getFlavors_d__3>.NativeClassPtr, "<>1__state");
				PrefabFlavorsMetaData._getFlavors_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabFlavorsMetaData._getFlavors_d__3>.NativeClassPtr, "<>2__current");
				PrefabFlavorsMetaData._getFlavors_d__3.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabFlavorsMetaData._getFlavors_d__3>.NativeClassPtr, "<>l__initialThreadId");
				PrefabFlavorsMetaData._getFlavors_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabFlavorsMetaData._getFlavors_d__3>.NativeClassPtr, "<>4__this");
				PrefabFlavorsMetaData._getFlavors_d__3.NativeFieldInfoPtr___3____4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabFlavorsMetaData._getFlavors_d__3>.NativeClassPtr, "<>3__<>4__this");
				PrefabFlavorsMetaData._getFlavors_d__3.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabFlavorsMetaData._getFlavors_d__3>.NativeClassPtr, "<>7__wrap1");
				PrefabFlavorsMetaData._getFlavors_d__3.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabFlavorsMetaData._getFlavors_d__3>.NativeClassPtr, "<>7__wrap2");
				PrefabFlavorsMetaData._getFlavors_d__3.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabFlavorsMetaData._getFlavors_d__3>.NativeClassPtr, "<>7__wrap3");
				PrefabFlavorsMetaData._getFlavors_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabFlavorsMetaData._getFlavors_d__3>.NativeClassPtr, 100665588);
				PrefabFlavorsMetaData._getFlavors_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabFlavorsMetaData._getFlavors_d__3>.NativeClassPtr, 100665589);
				PrefabFlavorsMetaData._getFlavors_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabFlavorsMetaData._getFlavors_d__3>.NativeClassPtr, 100665590);
				PrefabFlavorsMetaData._getFlavors_d__3.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabFlavorsMetaData._getFlavors_d__3>.NativeClassPtr, 100665591);
				PrefabFlavorsMetaData._getFlavors_d__3.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabFlavorsMetaData._getFlavors_d__3>.NativeClassPtr, 100665592);
				PrefabFlavorsMetaData._getFlavors_d__3.NativeMethodInfoPtr___m__Finally3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabFlavorsMetaData._getFlavors_d__3>.NativeClassPtr, 100665593);
				PrefabFlavorsMetaData._getFlavors_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabFlavorsMetaData._getFlavors_d__3>.NativeClassPtr, 100665594);
				PrefabFlavorsMetaData._getFlavors_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabFlavorsMetaData._getFlavors_d__3>.NativeClassPtr, 100665595);
				PrefabFlavorsMetaData._getFlavors_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabFlavorsMetaData._getFlavors_d__3>.NativeClassPtr, 100665596);
				PrefabFlavorsMetaData._getFlavors_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabFlavorsMetaData._getFlavors_d__3>.NativeClassPtr, 100665597);
				PrefabFlavorsMetaData._getFlavors_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabFlavorsMetaData._getFlavors_d__3>.NativeClassPtr, 100665598);
			}

			// Token: 0x06002111 RID: 8465 RVA: 0x00094A80 File Offset: 0x00092C80
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _getFlavors_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabFlavorsMetaData._getFlavors_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabFlavorsMetaData._getFlavors_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002112 RID: 8466 RVA: 0x00094AC8 File Offset: 0x00092CC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 868667, XrefRangeEnd = 868683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabFlavorsMetaData._getFlavors_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002113 RID: 8467 RVA: 0x00094AFC File Offset: 0x00092CFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 868683, XrefRangeEnd = 868733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabFlavorsMetaData._getFlavors_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002114 RID: 8468 RVA: 0x00094B38 File Offset: 0x00092D38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 868733, XrefRangeEnd = 868736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabFlavorsMetaData._getFlavors_d__3.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002115 RID: 8469 RVA: 0x00094B6C File Offset: 0x00092D6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 868736, XrefRangeEnd = 868739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabFlavorsMetaData._getFlavors_d__3.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002116 RID: 8470 RVA: 0x00094BA0 File Offset: 0x00092DA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 868739, XrefRangeEnd = 868742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabFlavorsMetaData._getFlavors_d__3.NativeMethodInfoPtr___m__Finally3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000909 RID: 2313
			// (get) Token: 0x06002117 RID: 8471 RVA: 0x00094BD4 File Offset: 0x00092DD4
			public unsafe string System.Collections.Generic.IEnumerator<System.String>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabFlavorsMetaData._getFlavors_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06002118 RID: 8472 RVA: 0x00094C0C File Offset: 0x00092E0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 868742, XrefRangeEnd = 868747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabFlavorsMetaData._getFlavors_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700090A RID: 2314
			// (get) Token: 0x06002119 RID: 8473 RVA: 0x00094C40 File Offset: 0x00092E40
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabFlavorsMetaData._getFlavors_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600211A RID: 8474 RVA: 0x00094C80 File Offset: 0x00092E80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 868747, XrefRangeEnd = 868755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<string> System_Collections_Generic_IEnumerable_System_String__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabFlavorsMetaData._getFlavors_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<string>>(intPtr3) : null;
			}

			// Token: 0x0600211B RID: 8475 RVA: 0x00094CC0 File Offset: 0x00092EC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabFlavorsMetaData._getFlavors_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600211C RID: 8476 RVA: 0x0000E202 File Offset: 0x0000C402
			public _getFlavors_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000901 RID: 2305
			// (get) Token: 0x0600211D RID: 8477 RVA: 0x00094D00 File Offset: 0x00092F00
			// (set) Token: 0x0600211E RID: 8478 RVA: 0x0000E20B File Offset: 0x0000C40B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabFlavorsMetaData._getFlavors_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabFlavorsMetaData._getFlavors_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000902 RID: 2306
			// (get) Token: 0x0600211F RID: 8479 RVA: 0x00094D28 File Offset: 0x00092F28
			// (set) Token: 0x06002120 RID: 8480 RVA: 0x0000E226 File Offset: 0x0000C426
			public unsafe string __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabFlavorsMetaData._getFlavors_d__3.NativeFieldInfoPtr___2__current);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabFlavorsMetaData._getFlavors_d__3.NativeFieldInfoPtr___2__current), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000903 RID: 2307
			// (get) Token: 0x06002121 RID: 8481 RVA: 0x00094D50 File Offset: 0x00092F50
			// (set) Token: 0x06002122 RID: 8482 RVA: 0x0000E245 File Offset: 0x0000C445
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabFlavorsMetaData._getFlavors_d__3.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabFlavorsMetaData._getFlavors_d__3.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000904 RID: 2308
			// (get) Token: 0x06002123 RID: 8483 RVA: 0x00094D78 File Offset: 0x00092F78
			// (set) Token: 0x06002124 RID: 8484 RVA: 0x0000E260 File Offset: 0x0000C460
			public PrefabFlavorsMetaData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabFlavorsMetaData._getFlavors_d__3.NativeFieldInfoPtr___4__this);
					return new PrefabFlavorsMetaData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrefabFlavorsMetaData>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabFlavorsMetaData._getFlavors_d__3.NativeFieldInfoPtr___4__this), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PrefabFlavorsMetaData>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000905 RID: 2309
			// (get) Token: 0x06002125 RID: 8485 RVA: 0x00094DA8 File Offset: 0x00092FA8
			// (set) Token: 0x06002126 RID: 8486 RVA: 0x0000E28E File Offset: 0x0000C48E
			public PrefabFlavorsMetaData __3____4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabFlavorsMetaData._getFlavors_d__3.NativeFieldInfoPtr___3____4__this);
					return new PrefabFlavorsMetaData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrefabFlavorsMetaData>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabFlavorsMetaData._getFlavors_d__3.NativeFieldInfoPtr___3____4__this), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PrefabFlavorsMetaData>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000906 RID: 2310
			// (get) Token: 0x06002127 RID: 8487 RVA: 0x00094DD8 File Offset: 0x00092FD8
			// (set) Token: 0x06002128 RID: 8488 RVA: 0x0000E2BC File Offset: 0x0000C4BC
			public List<string>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabFlavorsMetaData._getFlavors_d__3.NativeFieldInfoPtr___7__wrap1);
					return new List<string>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<string>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabFlavorsMetaData._getFlavors_d__3.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<string>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000907 RID: 2311
			// (get) Token: 0x06002129 RID: 8489 RVA: 0x00094E08 File Offset: 0x00093008
			// (set) Token: 0x0600212A RID: 8490 RVA: 0x0000E2EA File Offset: 0x0000C4EA
			public List<FlavorProvider>.Enumerator __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabFlavorsMetaData._getFlavors_d__3.NativeFieldInfoPtr___7__wrap2);
					return new List<FlavorProvider>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<FlavorProvider>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabFlavorsMetaData._getFlavors_d__3.NativeFieldInfoPtr___7__wrap2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<FlavorProvider>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000908 RID: 2312
			// (get) Token: 0x0600212B RID: 8491 RVA: 0x00094E38 File Offset: 0x00093038
			// (set) Token: 0x0600212C RID: 8492 RVA: 0x0000E318 File Offset: 0x0000C518
			public unsafe IEnumerator<string> __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabFlavorsMetaData._getFlavors_d__3.NativeFieldInfoPtr___7__wrap3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabFlavorsMetaData._getFlavors_d__3.NativeFieldInfoPtr___7__wrap3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040016F2 RID: 5874
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040016F3 RID: 5875
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040016F4 RID: 5876
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040016F5 RID: 5877
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040016F6 RID: 5878
			private static readonly IntPtr NativeFieldInfoPtr___3____4__this;

			// Token: 0x040016F7 RID: 5879
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040016F8 RID: 5880
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x040016F9 RID: 5881
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x040016FA RID: 5882
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040016FB RID: 5883
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040016FC RID: 5884
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040016FD RID: 5885
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040016FE RID: 5886
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x040016FF RID: 5887
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally3_Private_Void_0;

			// Token: 0x04001700 RID: 5888
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0;

			// Token: 0x04001701 RID: 5889
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001702 RID: 5890
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001703 RID: 5891
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0;

			// Token: 0x04001704 RID: 5892
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
