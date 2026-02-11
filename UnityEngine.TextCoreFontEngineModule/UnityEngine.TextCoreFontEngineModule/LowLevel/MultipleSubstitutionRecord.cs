using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.LowLevel
{
	// Token: 0x02000017 RID: 23
	[Serializable]
	public sealed class MultipleSubstitutionRecord : ValueType
	{
		// Token: 0x0600019F RID: 415 RVA: 0x000078F0 File Offset: 0x00005AF0
		// Note: this type is marked as 'beforefieldinit'.
		static MultipleSubstitutionRecord()
		{
			Il2CppClassPointerStore<MultipleSubstitutionRecord>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreFontEngineModule.dll", "UnityEngine.TextCore.LowLevel", "MultipleSubstitutionRecord");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultipleSubstitutionRecord>.NativeClassPtr);
			MultipleSubstitutionRecord.NativeFieldInfoPtr_m_TargetGlyphID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleSubstitutionRecord>.NativeClassPtr, "m_TargetGlyphID");
			MultipleSubstitutionRecord.NativeFieldInfoPtr_m_SubstituteGlyphIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleSubstitutionRecord>.NativeClassPtr, "m_SubstituteGlyphIDs");
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00002C1C File Offset: 0x00000E1C
		public MultipleSubstitutionRecord(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00002C25 File Offset: 0x00000E25
		public MultipleSubstitutionRecord()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultipleSubstitutionRecord>.NativeClassPtr))
		{
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x00007948 File Offset: 0x00005B48
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x00002C37 File Offset: 0x00000E37
		public unsafe uint m_TargetGlyphID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleSubstitutionRecord.NativeFieldInfoPtr_m_TargetGlyphID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleSubstitutionRecord.NativeFieldInfoPtr_m_TargetGlyphID)) = value;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x00007970 File Offset: 0x00005B70
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x00002C52 File Offset: 0x00000E52
		public unsafe Il2CppStructArray<uint> m_SubstituteGlyphIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleSubstitutionRecord.NativeFieldInfoPtr_m_SubstituteGlyphIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleSubstitutionRecord.NativeFieldInfoPtr_m_SubstituteGlyphIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x000079A0 File Offset: 0x00005BA0
		// (set) Token: 0x060001A7 RID: 423 RVA: 0x00002C71 File Offset: 0x00000E71
		public uint targetGlyphID
		{
			get
			{
				return this.m_TargetGlyphID;
			}
			set
			{
				this.m_TargetGlyphID = value;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x000079B8 File Offset: 0x00005BB8
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x00002C7B File Offset: 0x00000E7B
		public Il2CppStructArray<uint> substituteGlyphIDs
		{
			get
			{
				return this.m_SubstituteGlyphIDs;
			}
			set
			{
				this.m_SubstituteGlyphIDs = value;
			}
		}

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeFieldInfoPtr_m_TargetGlyphID;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeFieldInfoPtr_m_SubstituteGlyphIDs;
	}
}
