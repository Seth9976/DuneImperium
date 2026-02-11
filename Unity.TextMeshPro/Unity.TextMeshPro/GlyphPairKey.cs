using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace TMPro
{
	// Token: 0x0200003E RID: 62
	[StructLayout(2)]
	public struct GlyphPairKey
	{
		// Token: 0x060005F7 RID: 1527 RVA: 0x0001D644 File Offset: 0x0001B844
		// Note: this type is marked as 'beforefieldinit'.
		static GlyphPairKey()
		{
			Il2CppClassPointerStore<GlyphPairKey>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "GlyphPairKey");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlyphPairKey>.NativeClassPtr);
			GlyphPairKey.NativeFieldInfoPtr_firstGlyphIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphPairKey>.NativeClassPtr, "firstGlyphIndex");
			GlyphPairKey.NativeFieldInfoPtr_secondGlyphIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphPairKey>.NativeClassPtr, "secondGlyphIndex");
			GlyphPairKey.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphPairKey>.NativeClassPtr, "key");
			GlyphPairKey.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphPairKey>.NativeClassPtr, 100663938);
			GlyphPairKey.NativeMethodInfoPtr__ctor_Internal_Void_TMP_GlyphPairAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphPairKey>.NativeClassPtr, 100663939);
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x0001D6D8 File Offset: 0x0001B8D8
		[CallerCount(0)]
		public unsafe GlyphPairKey(uint firstGlyphIndex, uint secondGlyphIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref firstGlyphIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref secondGlyphIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphPairKey.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x0001D718 File Offset: 0x0001B918
		[CallerCount(0)]
		public unsafe GlyphPairKey(TMP_GlyphPairAdjustmentRecord record)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(record);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphPairKey.NativeMethodInfoPtr__ctor_Internal_Void_TMP_GlyphPairAdjustmentRecord_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00004ED4 File Offset: 0x000030D4
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlyphPairKey>.NativeClassPtr, ref this));
		}

		// Token: 0x0400045E RID: 1118
		private static readonly IntPtr NativeFieldInfoPtr_firstGlyphIndex;

		// Token: 0x0400045F RID: 1119
		private static readonly IntPtr NativeFieldInfoPtr_secondGlyphIndex;

		// Token: 0x04000460 RID: 1120
		private static readonly IntPtr NativeFieldInfoPtr_key;

		// Token: 0x04000461 RID: 1121
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_0;

		// Token: 0x04000462 RID: 1122
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_TMP_GlyphPairAdjustmentRecord_0;

		// Token: 0x04000463 RID: 1123
		[FieldOffset(0)]
		public uint firstGlyphIndex;

		// Token: 0x04000464 RID: 1124
		[FieldOffset(4)]
		public uint secondGlyphIndex;

		// Token: 0x04000465 RID: 1125
		[FieldOffset(8)]
		public uint key;
	}
}
