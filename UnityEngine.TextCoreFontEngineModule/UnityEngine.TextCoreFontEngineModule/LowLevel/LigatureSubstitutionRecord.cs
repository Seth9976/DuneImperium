using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.LowLevel
{
	// Token: 0x02000018 RID: 24
	[Serializable]
	public sealed class LigatureSubstitutionRecord : ValueType
	{
		// Token: 0x060001AA RID: 426 RVA: 0x000079D0 File Offset: 0x00005BD0
		// Note: this type is marked as 'beforefieldinit'.
		static LigatureSubstitutionRecord()
		{
			Il2CppClassPointerStore<LigatureSubstitutionRecord>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreFontEngineModule.dll", "UnityEngine.TextCore.LowLevel", "LigatureSubstitutionRecord");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LigatureSubstitutionRecord>.NativeClassPtr);
			LigatureSubstitutionRecord.NativeFieldInfoPtr_m_ComponentGlyphIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LigatureSubstitutionRecord>.NativeClassPtr, "m_ComponentGlyphIDs");
			LigatureSubstitutionRecord.NativeFieldInfoPtr_m_LigatureGlyphID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LigatureSubstitutionRecord>.NativeClassPtr, "m_LigatureGlyphID");
			LigatureSubstitutionRecord.NativeMethodInfoPtr_get_componentGlyphIDs_Public_get_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LigatureSubstitutionRecord>.NativeClassPtr, 100663433);
			LigatureSubstitutionRecord.NativeMethodInfoPtr_get_ligatureGlyphID_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LigatureSubstitutionRecord>.NativeClassPtr, 100663434);
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001AB RID: 427 RVA: 0x00007A50 File Offset: 0x00005C50
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x00002CDA File Offset: 0x00000EDA
		public unsafe Il2CppStructArray<uint> componentGlyphIDs
		{
			[CallerCount(128)]
			[CachedScanResults(RefRangeStart = 323623, RefRangeEnd = 323751, XrefRangeStart = 323623, XrefRangeEnd = 323751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LigatureSubstitutionRecord.NativeMethodInfoPtr_get_componentGlyphIDs_Public_get_Il2CppStructArray_1_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr3) : null;
			}
			set
			{
				this.m_ComponentGlyphIDs = value;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001AC RID: 428 RVA: 0x00007A94 File Offset: 0x00005C94
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x00002CE4 File Offset: 0x00000EE4
		public unsafe uint ligatureGlyphID
		{
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 335516, RefRangeEnd = 335543, XrefRangeStart = 335516, XrefRangeEnd = 335543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LigatureSubstitutionRecord.NativeMethodInfoPtr_get_ligatureGlyphID_Public_get_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_LigatureGlyphID = value;
			}
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00002C85 File Offset: 0x00000E85
		public LigatureSubstitutionRecord(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00002C8E File Offset: 0x00000E8E
		public LigatureSubstitutionRecord()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LigatureSubstitutionRecord>.NativeClassPtr))
		{
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001AF RID: 431 RVA: 0x00007AD8 File Offset: 0x00005CD8
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x00002CA0 File Offset: 0x00000EA0
		public unsafe Il2CppStructArray<uint> m_ComponentGlyphIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LigatureSubstitutionRecord.NativeFieldInfoPtr_m_ComponentGlyphIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LigatureSubstitutionRecord.NativeFieldInfoPtr_m_ComponentGlyphIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x00007B08 File Offset: 0x00005D08
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x00002CBF File Offset: 0x00000EBF
		public unsafe uint m_LigatureGlyphID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LigatureSubstitutionRecord.NativeFieldInfoPtr_m_LigatureGlyphID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LigatureSubstitutionRecord.NativeFieldInfoPtr_m_LigatureGlyphID)) = value;
			}
		}

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeFieldInfoPtr_m_ComponentGlyphIDs;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeFieldInfoPtr_m_LigatureGlyphID;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeMethodInfoPtr_get_componentGlyphIDs_Public_get_Il2CppStructArray_1_UInt32_0;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeMethodInfoPtr_get_ligatureGlyphID_Public_get_UInt32_0;
	}
}
