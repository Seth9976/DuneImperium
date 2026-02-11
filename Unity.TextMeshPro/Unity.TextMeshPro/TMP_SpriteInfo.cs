using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace TMPro
{
	// Token: 0x02000019 RID: 25
	[StructLayout(2)]
	public struct TMP_SpriteInfo
	{
		// Token: 0x0600025D RID: 605 RVA: 0x000122E0 File Offset: 0x000104E0
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_SpriteInfo()
		{
			Il2CppClassPointerStore<TMP_SpriteInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_SpriteInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_SpriteInfo>.NativeClassPtr);
			TMP_SpriteInfo.NativeFieldInfoPtr_spriteIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteInfo>.NativeClassPtr, "spriteIndex");
			TMP_SpriteInfo.NativeFieldInfoPtr_characterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteInfo>.NativeClassPtr, "characterIndex");
			TMP_SpriteInfo.NativeFieldInfoPtr_vertexIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteInfo>.NativeClassPtr, "vertexIndex");
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00002ECF File Offset: 0x000010CF
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_SpriteInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeFieldInfoPtr_spriteIndex;

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeFieldInfoPtr_characterIndex;

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeFieldInfoPtr_vertexIndex;

		// Token: 0x040001C8 RID: 456
		[FieldOffset(0)]
		public int spriteIndex;

		// Token: 0x040001C9 RID: 457
		[FieldOffset(4)]
		public int characterIndex;

		// Token: 0x040001CA RID: 458
		[FieldOffset(8)]
		public int vertexIndex;
	}
}
