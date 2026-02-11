using System;
using Canis.attributes;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.data.enums;

namespace worm.match.data
{
	// Token: 0x0200018B RID: 395
	public class WormFactionInfluenceData : VersionedDataComponent
	{
		// Token: 0x060011B5 RID: 4533 RVA: 0x0004D8B0 File Offset: 0x0004BAB0
		// Note: this type is marked as 'beforefieldinit'.
		static WormFactionInfluenceData()
		{
			Il2CppClassPointerStore<WormFactionInfluenceData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.data", "WormFactionInfluenceData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormFactionInfluenceData>.NativeClassPtr);
			WormFactionInfluenceData.NativeFieldInfoPtr_factionInfluenceAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionInfluenceData>.NativeClassPtr, "factionInfluenceAttribute");
			WormFactionInfluenceData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionInfluenceData>.NativeClassPtr, 100665736);
			WormFactionInfluenceData.NativeMethodInfoPtr__ctor_Public_Void_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionInfluenceData>.NativeClassPtr, 100665737);
			WormFactionInfluenceData.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_Factions_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionInfluenceData>.NativeClassPtr, 100665738);
			WormFactionInfluenceData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionInfluenceData>.NativeClassPtr, 100665739);
			WormFactionInfluenceData.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionInfluenceData>.NativeClassPtr, 100665740);
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x060011B6 RID: 4534 RVA: 0x0004D958 File Offset: 0x0004BB58
		public unsafe override ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711460, XrefRangeEnd = 711464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormFactionInfluenceData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011B7 RID: 4535 RVA: 0x0004D9A0 File Offset: 0x0004BBA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 711476, RefRangeEnd = 711477, XrefRangeStart = 711464, XrefRangeEnd = 711476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormFactionInfluenceData(IHasAttributes attributes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormFactionInfluenceData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionInfluenceData.NativeMethodInfoPtr__ctor_Public_Void_IHasAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x0004D9EC File Offset: 0x0004BBEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 711494, RefRangeEnd = 711495, XrefRangeStart = 711477, XrefRangeEnd = 711494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<KeyValuePair<Factions, int>> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionInfluenceData.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_Factions_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<Factions, int>>>(intPtr3) : null;
		}

		// Token: 0x060011B9 RID: 4537 RVA: 0x0004DA2C File Offset: 0x0004BC2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711495, XrefRangeEnd = 711532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormFactionInfluenceData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060011BA RID: 4538 RVA: 0x0004DA70 File Offset: 0x0004BC70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711532, XrefRangeEnd = 711533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionInfluenceData.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x0000B40E File Offset: 0x0000960E
		public WormFactionInfluenceData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x060011BC RID: 4540 RVA: 0x0004DAB0 File Offset: 0x0004BCB0
		// (set) Token: 0x060011BD RID: 4541 RVA: 0x0000B417 File Offset: 0x00009617
		public unsafe IAttribute<Dictionary<Factions, int>> factionInfluenceAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionInfluenceData.NativeFieldInfoPtr_factionInfluenceAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Dictionary<Factions, int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionInfluenceData.NativeFieldInfoPtr_factionInfluenceAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A38 RID: 2616
		private static readonly IntPtr NativeFieldInfoPtr_factionInfluenceAttribute;

		// Token: 0x04000A39 RID: 2617
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;

		// Token: 0x04000A3A RID: 2618
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IHasAttributes_0;

		// Token: 0x04000A3B RID: 2619
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_Factions_Int32_0;

		// Token: 0x04000A3C RID: 2620
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000A3D RID: 2621
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x020003BD RID: 957
		[ObfuscatedName("worm.match.data.WormFactionInfluenceData+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600269E RID: 9886 RVA: 0x0008D568 File Offset: 0x0008B768
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormFactionInfluenceData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormFactionInfluenceData>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormFactionInfluenceData.__c>.NativeClassPtr);
				WormFactionInfluenceData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionInfluenceData.__c>.NativeClassPtr, "<>9");
				WormFactionInfluenceData.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionInfluenceData.__c>.NativeClassPtr, "<>9__5_0");
				WormFactionInfluenceData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionInfluenceData.__c>.NativeClassPtr, 100665742);
				WormFactionInfluenceData.__c.NativeMethodInfoPtr__ToString_b__5_0_Internal_String_KeyValuePair_2_Factions_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionInfluenceData.__c>.NativeClassPtr, 100665743);
			}

			// Token: 0x0600269F RID: 9887 RVA: 0x0008D5E4 File Offset: 0x0008B7E4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormFactionInfluenceData.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionInfluenceData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060026A0 RID: 9888 RVA: 0x0008D620 File Offset: 0x0008B820
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711449, XrefRangeEnd = 711460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ToString_b__5_0(KeyValuePair<Factions, int> kvp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(kvp));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionInfluenceData.__c.NativeMethodInfoPtr__ToString_b__5_0_Internal_String_KeyValuePair_2_Factions_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060026A1 RID: 9889 RVA: 0x000154FF File Offset: 0x000136FF
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AB9 RID: 2745
			// (get) Token: 0x060026A2 RID: 9890 RVA: 0x0008D670 File Offset: 0x0008B870
			// (set) Token: 0x060026A3 RID: 9891 RVA: 0x00015508 File Offset: 0x00013708
			public unsafe static WormFactionInfluenceData.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormFactionInfluenceData.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormFactionInfluenceData.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormFactionInfluenceData.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000ABA RID: 2746
			// (get) Token: 0x060026A4 RID: 9892 RVA: 0x0008D698 File Offset: 0x0008B898
			// (set) Token: 0x060026A5 RID: 9893 RVA: 0x0001551A File Offset: 0x0001371A
			public unsafe static Func<KeyValuePair<Factions, int>, string> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormFactionInfluenceData.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Factions, int>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormFactionInfluenceData.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400163C RID: 5692
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400163D RID: 5693
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x0400163E RID: 5694
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400163F RID: 5695
			private static readonly IntPtr NativeMethodInfoPtr__ToString_b__5_0_Internal_String_KeyValuePair_2_Factions_Int32_0;
		}
	}
}
