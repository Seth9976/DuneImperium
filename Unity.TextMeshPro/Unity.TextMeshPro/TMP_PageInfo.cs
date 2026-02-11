using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace TMPro
{
	// Token: 0x02000016 RID: 22
	[StructLayout(2)]
	public struct TMP_PageInfo
	{
		// Token: 0x0600023B RID: 571 RVA: 0x00011DD8 File Offset: 0x0000FFD8
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_PageInfo()
		{
			Il2CppClassPointerStore<TMP_PageInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_PageInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_PageInfo>.NativeClassPtr);
			TMP_PageInfo.NativeFieldInfoPtr_firstCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_PageInfo>.NativeClassPtr, "firstCharacterIndex");
			TMP_PageInfo.NativeFieldInfoPtr_lastCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_PageInfo>.NativeClassPtr, "lastCharacterIndex");
			TMP_PageInfo.NativeFieldInfoPtr_ascender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_PageInfo>.NativeClassPtr, "ascender");
			TMP_PageInfo.NativeFieldInfoPtr_baseLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_PageInfo>.NativeClassPtr, "baseLine");
			TMP_PageInfo.NativeFieldInfoPtr_descender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_PageInfo>.NativeClassPtr, "descender");
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00002D52 File Offset: 0x00000F52
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_PageInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeFieldInfoPtr_firstCharacterIndex;

		// Token: 0x040001AD RID: 429
		private static readonly IntPtr NativeFieldInfoPtr_lastCharacterIndex;

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeFieldInfoPtr_ascender;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeFieldInfoPtr_baseLine;

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeFieldInfoPtr_descender;

		// Token: 0x040001B1 RID: 433
		[FieldOffset(0)]
		public int firstCharacterIndex;

		// Token: 0x040001B2 RID: 434
		[FieldOffset(4)]
		public int lastCharacterIndex;

		// Token: 0x040001B3 RID: 435
		[FieldOffset(8)]
		public float ascender;

		// Token: 0x040001B4 RID: 436
		[FieldOffset(12)]
		public float baseLine;

		// Token: 0x040001B5 RID: 437
		[FieldOffset(16)]
		public float descender;
	}
}
