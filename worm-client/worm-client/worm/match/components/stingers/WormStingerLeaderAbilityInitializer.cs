using System;
using Canis.attributes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;

namespace worm.match.components.stingers
{
	// Token: 0x0200022C RID: 556
	public class WormStingerLeaderAbilityInitializer : MonoBehaviour
	{
		// Token: 0x06001849 RID: 6217 RVA: 0x00061D10 File Offset: 0x0005FF10
		// Note: this type is marked as 'beforefieldinit'.
		static WormStingerLeaderAbilityInitializer()
		{
			Il2CppClassPointerStore<WormStingerLeaderAbilityInitializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components.stingers", "WormStingerLeaderAbilityInitializer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormStingerLeaderAbilityInitializer>.NativeClassPtr);
			WormStingerLeaderAbilityInitializer.NativeFieldInfoPtr_abilityNameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormStingerLeaderAbilityInitializer>.NativeClassPtr, "abilityNameText");
			WormStingerLeaderAbilityInitializer.NativeFieldInfoPtr_abilityNameFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormStingerLeaderAbilityInitializer>.NativeClassPtr, "abilityNameFormat");
			WormStingerLeaderAbilityInitializer.NativeMethodInfoPtr_InitViews_Public_Virtual_Final_New_Void_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormStingerLeaderAbilityInitializer>.NativeClassPtr, 100666659);
			WormStingerLeaderAbilityInitializer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormStingerLeaderAbilityInitializer>.NativeClassPtr, 100666660);
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x00061D90 File Offset: 0x0005FF90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718205, XrefRangeEnd = 718242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitViews(IHasAttributes attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormStingerLeaderAbilityInitializer.NativeMethodInfoPtr_InitViews_Public_Virtual_Final_New_Void_IHasAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600184B RID: 6219 RVA: 0x00061DD4 File Offset: 0x0005FFD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718242, XrefRangeEnd = 718246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormStingerLeaderAbilityInitializer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormStingerLeaderAbilityInitializer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormStingerLeaderAbilityInitializer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x0000E6A1 File Offset: 0x0000C8A1
		public WormStingerLeaderAbilityInitializer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x0600184D RID: 6221 RVA: 0x00061E10 File Offset: 0x00060010
		// (set) Token: 0x0600184E RID: 6222 RVA: 0x0000E6AA File Offset: 0x0000C8AA
		public unsafe TMP_Text abilityNameText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormStingerLeaderAbilityInitializer.NativeFieldInfoPtr_abilityNameText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormStingerLeaderAbilityInitializer.NativeFieldInfoPtr_abilityNameText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x0600184F RID: 6223 RVA: 0x00061E40 File Offset: 0x00060040
		// (set) Token: 0x06001850 RID: 6224 RVA: 0x0000E6C9 File Offset: 0x0000C8C9
		public unsafe string abilityNameFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormStingerLeaderAbilityInitializer.NativeFieldInfoPtr_abilityNameFormat);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormStingerLeaderAbilityInitializer.NativeFieldInfoPtr_abilityNameFormat), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000E14 RID: 3604
		private static readonly IntPtr NativeFieldInfoPtr_abilityNameText;

		// Token: 0x04000E15 RID: 3605
		private static readonly IntPtr NativeFieldInfoPtr_abilityNameFormat;

		// Token: 0x04000E16 RID: 3606
		private static readonly IntPtr NativeMethodInfoPtr_InitViews_Public_Virtual_Final_New_Void_IHasAttributes_0;

		// Token: 0x04000E17 RID: 3607
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
