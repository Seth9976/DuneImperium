using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.TextCore.LowLevel;

namespace TMPro
{
	// Token: 0x0200003B RID: 59
	[Serializable]
	[StructLayout(2)]
	public struct TMP_GlyphValueRecord
	{
		// Token: 0x060005D1 RID: 1489 RVA: 0x0001CC90 File Offset: 0x0001AE90
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_GlyphValueRecord()
		{
			Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_GlyphValueRecord");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr);
			TMP_GlyphValueRecord.NativeFieldInfoPtr_m_XPlacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, "m_XPlacement");
			TMP_GlyphValueRecord.NativeFieldInfoPtr_m_YPlacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, "m_YPlacement");
			TMP_GlyphValueRecord.NativeFieldInfoPtr_m_XAdvance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, "m_XAdvance");
			TMP_GlyphValueRecord.NativeFieldInfoPtr_m_YAdvance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, "m_YAdvance");
			TMP_GlyphValueRecord.NativeMethodInfoPtr_get_xPlacement_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, 100663912);
			TMP_GlyphValueRecord.NativeMethodInfoPtr_set_xPlacement_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, 100663913);
			TMP_GlyphValueRecord.NativeMethodInfoPtr_get_yPlacement_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, 100663914);
			TMP_GlyphValueRecord.NativeMethodInfoPtr_set_yPlacement_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, 100663915);
			TMP_GlyphValueRecord.NativeMethodInfoPtr_get_xAdvance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, 100663916);
			TMP_GlyphValueRecord.NativeMethodInfoPtr_set_xAdvance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, 100663917);
			TMP_GlyphValueRecord.NativeMethodInfoPtr_get_yAdvance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, 100663918);
			TMP_GlyphValueRecord.NativeMethodInfoPtr_set_yAdvance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, 100663919);
			TMP_GlyphValueRecord.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, 100663920);
			TMP_GlyphValueRecord.NativeMethodInfoPtr__ctor_Internal_Void_GlyphValueRecord_Legacy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, 100663921);
			TMP_GlyphValueRecord.NativeMethodInfoPtr__ctor_Internal_Void_GlyphValueRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, 100663922);
			TMP_GlyphValueRecord.NativeMethodInfoPtr_op_Addition_Public_Static_TMP_GlyphValueRecord_TMP_GlyphValueRecord_TMP_GlyphValueRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, 100663923);
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060005D2 RID: 1490 RVA: 0x0001CE00 File Offset: 0x0001B000
		// (set) Token: 0x060005D3 RID: 1491 RVA: 0x0001CE30 File Offset: 0x0001B030
		public unsafe float xPlacement
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphValueRecord.NativeMethodInfoPtr_get_xPlacement_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 644340, RefRangeEnd = 644349, XrefRangeStart = 644340, XrefRangeEnd = 644349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphValueRecord.NativeMethodInfoPtr_set_xPlacement_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060005D4 RID: 1492 RVA: 0x0001CE64 File Offset: 0x0001B064
		// (set) Token: 0x060005D5 RID: 1493 RVA: 0x0001CE94 File Offset: 0x0001B094
		public unsafe float yPlacement
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphValueRecord.NativeMethodInfoPtr_get_yPlacement_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 644397, RefRangeEnd = 644403, XrefRangeStart = 644397, XrefRangeEnd = 644403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphValueRecord.NativeMethodInfoPtr_set_yPlacement_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x060005D6 RID: 1494 RVA: 0x0001CEC8 File Offset: 0x0001B0C8
		// (set) Token: 0x060005D7 RID: 1495 RVA: 0x0001CEF8 File Offset: 0x0001B0F8
		public unsafe float xAdvance
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphValueRecord.NativeMethodInfoPtr_get_xAdvance_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 644429, RefRangeEnd = 644431, XrefRangeStart = 644429, XrefRangeEnd = 644431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphValueRecord.NativeMethodInfoPtr_set_xAdvance_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x060005D8 RID: 1496 RVA: 0x0001CF2C File Offset: 0x0001B12C
		// (set) Token: 0x060005D9 RID: 1497 RVA: 0x0001CF5C File Offset: 0x0001B15C
		public unsafe float yAdvance
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphValueRecord.NativeMethodInfoPtr_get_yAdvance_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 642841, RefRangeEnd = 642843, XrefRangeStart = 642841, XrefRangeEnd = 642843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphValueRecord.NativeMethodInfoPtr_set_yAdvance_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x0001CF90 File Offset: 0x0001B190
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 323501, RefRangeEnd = 323508, XrefRangeStart = 323501, XrefRangeEnd = 323508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_GlyphValueRecord(float xPlacement, float yPlacement, float xAdvance, float yAdvance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xPlacement;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yPlacement;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xAdvance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yAdvance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphValueRecord.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x0001CFEC File Offset: 0x0001B1EC
		[CallerCount(0)]
		public unsafe TMP_GlyphValueRecord(GlyphValueRecord_Legacy valueRecord)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref valueRecord;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphValueRecord.NativeMethodInfoPtr__ctor_Internal_Void_GlyphValueRecord_Legacy_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x0001D020 File Offset: 0x0001B220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_GlyphValueRecord(GlyphValueRecord valueRecord)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref valueRecord;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphValueRecord.NativeMethodInfoPtr__ctor_Internal_Void_GlyphValueRecord_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x0001D054 File Offset: 0x0001B254
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1041474, RefRangeEnd = 1041477, XrefRangeStart = 1041474, XrefRangeEnd = 1041474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_GlyphValueRecord operator +(TMP_GlyphValueRecord a, TMP_GlyphValueRecord b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_GlyphValueRecord.NativeMethodInfoPtr_op_Addition_Public_Static_TMP_GlyphValueRecord_TMP_GlyphValueRecord_TMP_GlyphValueRecord_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x00004E56 File Offset: 0x00003056
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_GlyphValueRecord>.NativeClassPtr, ref this));
		}

		// Token: 0x04000435 RID: 1077
		private static readonly IntPtr NativeFieldInfoPtr_m_XPlacement;

		// Token: 0x04000436 RID: 1078
		private static readonly IntPtr NativeFieldInfoPtr_m_YPlacement;

		// Token: 0x04000437 RID: 1079
		private static readonly IntPtr NativeFieldInfoPtr_m_XAdvance;

		// Token: 0x04000438 RID: 1080
		private static readonly IntPtr NativeFieldInfoPtr_m_YAdvance;

		// Token: 0x04000439 RID: 1081
		private static readonly IntPtr NativeMethodInfoPtr_get_xPlacement_Public_get_Single_0;

		// Token: 0x0400043A RID: 1082
		private static readonly IntPtr NativeMethodInfoPtr_set_xPlacement_Public_set_Void_Single_0;

		// Token: 0x0400043B RID: 1083
		private static readonly IntPtr NativeMethodInfoPtr_get_yPlacement_Public_get_Single_0;

		// Token: 0x0400043C RID: 1084
		private static readonly IntPtr NativeMethodInfoPtr_set_yPlacement_Public_set_Void_Single_0;

		// Token: 0x0400043D RID: 1085
		private static readonly IntPtr NativeMethodInfoPtr_get_xAdvance_Public_get_Single_0;

		// Token: 0x0400043E RID: 1086
		private static readonly IntPtr NativeMethodInfoPtr_set_xAdvance_Public_set_Void_Single_0;

		// Token: 0x0400043F RID: 1087
		private static readonly IntPtr NativeMethodInfoPtr_get_yAdvance_Public_get_Single_0;

		// Token: 0x04000440 RID: 1088
		private static readonly IntPtr NativeMethodInfoPtr_set_yAdvance_Public_set_Void_Single_0;

		// Token: 0x04000441 RID: 1089
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;

		// Token: 0x04000442 RID: 1090
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_GlyphValueRecord_Legacy_0;

		// Token: 0x04000443 RID: 1091
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_GlyphValueRecord_0;

		// Token: 0x04000444 RID: 1092
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_TMP_GlyphValueRecord_TMP_GlyphValueRecord_TMP_GlyphValueRecord_0;

		// Token: 0x04000445 RID: 1093
		[FieldOffset(0)]
		public float m_XPlacement;

		// Token: 0x04000446 RID: 1094
		[FieldOffset(4)]
		public float m_YPlacement;

		// Token: 0x04000447 RID: 1095
		[FieldOffset(8)]
		public float m_XAdvance;

		// Token: 0x04000448 RID: 1096
		[FieldOffset(12)]
		public float m_YAdvance;
	}
}
