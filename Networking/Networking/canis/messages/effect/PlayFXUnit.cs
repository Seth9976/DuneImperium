using System;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Networking.game.messages.effect;

namespace Canis.messages.effect
{
	// Token: 0x02000047 RID: 71
	public class PlayFXUnit : FXUnitMessage
	{
		// Token: 0x0600025E RID: 606 RVA: 0x0000BF38 File Offset: 0x0000A138
		// Note: this type is marked as 'beforefieldinit'.
		static PlayFXUnit()
		{
			Il2CppClassPointerStore<PlayFXUnit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.messages.effect", "PlayFXUnit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayFXUnit>.NativeClassPtr);
			PlayFXUnit.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayFXUnit>.NativeClassPtr, "Text");
			PlayFXUnit.NativeFieldInfoPtr_ShouldBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayFXUnit>.NativeClassPtr, "ShouldBlock");
			PlayFXUnit.NativeFieldInfoPtr_Persist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayFXUnit>.NativeClassPtr, "Persist");
			PlayFXUnit.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayFXUnit>.NativeClassPtr, 100663415);
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0000BFB8 File Offset: 0x0000A1B8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayFXUnit()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayFXUnit>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayFXUnit.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00003943 File Offset: 0x00001B43
		public PlayFXUnit(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000261 RID: 609 RVA: 0x0000BFF4 File Offset: 0x0000A1F4
		// (set) Token: 0x06000262 RID: 610 RVA: 0x0000394C File Offset: 0x00001B4C
		public unsafe LocalizableTextVariables Text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayFXUnit.NativeFieldInfoPtr_Text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizableTextVariables>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayFXUnit.NativeFieldInfoPtr_Text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000263 RID: 611 RVA: 0x0000C024 File Offset: 0x0000A224
		// (set) Token: 0x06000264 RID: 612 RVA: 0x0000396B File Offset: 0x00001B6B
		public unsafe bool ShouldBlock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayFXUnit.NativeFieldInfoPtr_ShouldBlock);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayFXUnit.NativeFieldInfoPtr_ShouldBlock)) = value;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000265 RID: 613 RVA: 0x0000C04C File Offset: 0x0000A24C
		// (set) Token: 0x06000266 RID: 614 RVA: 0x00003986 File Offset: 0x00001B86
		public unsafe bool Persist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayFXUnit.NativeFieldInfoPtr_Persist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayFXUnit.NativeFieldInfoPtr_Persist)) = value;
			}
		}

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeFieldInfoPtr_Text;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeFieldInfoPtr_ShouldBlock;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeFieldInfoPtr_Persist;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
