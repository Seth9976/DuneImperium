using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.UI;

namespace localization
{
	// Token: 0x02000030 RID: 48
	public class LocalizedImage : MonoBehaviour
	{
		// Token: 0x06000207 RID: 519 RVA: 0x000175A0 File Offset: 0x000157A0
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizedImage()
		{
			Il2CppClassPointerStore<LocalizedImage>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "localization", "LocalizedImage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedImage>.NativeClassPtr);
			LocalizedImage.NativeFieldInfoPtr_localeSprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedImage>.NativeClassPtr, "localeSprites");
			LocalizedImage.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedImage>.NativeClassPtr, "image");
			LocalizedImage.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedImage>.NativeClassPtr, 100663684);
			LocalizedImage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedImage>.NativeClassPtr, 100663685);
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00017620 File Offset: 0x00015820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984597, XrefRangeEnd = 984610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedImage.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00017654 File Offset: 0x00015854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984610, XrefRangeEnd = 984618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizedImage()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedImage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedImage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00002E65 File Offset: 0x00001065
		public LocalizedImage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600020B RID: 523 RVA: 0x00017690 File Offset: 0x00015890
		// (set) Token: 0x0600020C RID: 524 RVA: 0x00002E6E File Offset: 0x0000106E
		public unsafe Il2CppReferenceArray<LocalizedImage.LocaleSprite> localeSprites
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedImage.NativeFieldInfoPtr_localeSprites);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LocalizedImage.LocaleSprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedImage.NativeFieldInfoPtr_localeSprites), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600020D RID: 525 RVA: 0x000176C0 File Offset: 0x000158C0
		// (set) Token: 0x0600020E RID: 526 RVA: 0x00002E8D File Offset: 0x0000108D
		public unsafe Image image
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedImage.NativeFieldInfoPtr_image);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedImage.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeFieldInfoPtr_localeSprites;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeFieldInfoPtr_image;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020001B1 RID: 433
		[Serializable]
		public sealed class LocaleSprite : ValueType
		{
			// Token: 0x060014E5 RID: 5349 RVA: 0x000517E8 File Offset: 0x0004F9E8
			// Note: this type is marked as 'beforefieldinit'.
			static LocaleSprite()
			{
				Il2CppClassPointerStore<LocalizedImage.LocaleSprite>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalizedImage>.NativeClassPtr, "LocaleSprite");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedImage.LocaleSprite>.NativeClassPtr);
				LocalizedImage.LocaleSprite.NativeFieldInfoPtr_locale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedImage.LocaleSprite>.NativeClassPtr, "locale");
				LocalizedImage.LocaleSprite.NativeFieldInfoPtr_sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedImage.LocaleSprite>.NativeClassPtr, "sprite");
			}

			// Token: 0x060014E6 RID: 5350 RVA: 0x0000BC7C File Offset: 0x00009E7C
			public LocaleSprite(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060014E7 RID: 5351 RVA: 0x0000BC85 File Offset: 0x00009E85
			public LocaleSprite()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedImage.LocaleSprite>.NativeClassPtr))
			{
			}

			// Token: 0x170005F2 RID: 1522
			// (get) Token: 0x060014E8 RID: 5352 RVA: 0x0005183C File Offset: 0x0004FA3C
			// (set) Token: 0x060014E9 RID: 5353 RVA: 0x0000BC97 File Offset: 0x00009E97
			public unsafe TextLocalization.Locale locale
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedImage.LocaleSprite.NativeFieldInfoPtr_locale);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedImage.LocaleSprite.NativeFieldInfoPtr_locale)) = value;
				}
			}

			// Token: 0x170005F3 RID: 1523
			// (get) Token: 0x060014EA RID: 5354 RVA: 0x00051864 File Offset: 0x0004FA64
			// (set) Token: 0x060014EB RID: 5355 RVA: 0x0000BCB2 File Offset: 0x00009EB2
			public unsafe Sprite sprite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedImage.LocaleSprite.NativeFieldInfoPtr_sprite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedImage.LocaleSprite.NativeFieldInfoPtr_sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000CAB RID: 3243
			private static readonly IntPtr NativeFieldInfoPtr_locale;

			// Token: 0x04000CAC RID: 3244
			private static readonly IntPtr NativeFieldInfoPtr_sprite;
		}
	}
}
