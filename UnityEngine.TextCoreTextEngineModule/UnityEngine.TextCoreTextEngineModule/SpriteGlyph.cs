using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x02000015 RID: 21
	[Serializable]
	public class SpriteGlyph : Glyph
	{
		// Token: 0x0600020F RID: 527 RVA: 0x0000D74C File Offset: 0x0000B94C
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteGlyph()
		{
			Il2CppClassPointerStore<SpriteGlyph>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "SpriteGlyph");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteGlyph>.NativeClassPtr);
			SpriteGlyph.NativeFieldInfoPtr_sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteGlyph>.NativeClassPtr, "sprite");
			SpriteGlyph.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteGlyph>.NativeClassPtr, 100663510);
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0000D7A4 File Offset: 0x0000B9A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpriteGlyph()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteGlyph>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteGlyph.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00003053 File Offset: 0x00001253
		public SpriteGlyph(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000212 RID: 530 RVA: 0x0000D7E0 File Offset: 0x0000B9E0
		// (set) Token: 0x06000213 RID: 531 RVA: 0x0000305C File Offset: 0x0000125C
		public unsafe Sprite sprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteGlyph.NativeFieldInfoPtr_sprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteGlyph.NativeFieldInfoPtr_sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeFieldInfoPtr_sprite;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
