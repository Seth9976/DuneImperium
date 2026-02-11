using System;
using boardgames.match.selection;
using Canis.attributes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using lotus;
using UnityEngine;
using UnityEngine.UI;
using worm.canis.data.enums;

namespace worm.match.components
{
	// Token: 0x020001C9 RID: 457
	public class WormAbilityButtonHinter : VersionedView<DBGSelectionResponder>
	{
		// Token: 0x0600140B RID: 5131 RVA: 0x00054FE8 File Offset: 0x000531E8
		// Note: this type is marked as 'beforefieldinit'.
		static WormAbilityButtonHinter()
		{
			Il2CppClassPointerStore<WormAbilityButtonHinter>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormAbilityButtonHinter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAbilityButtonHinter>.NativeClassPtr);
			WormAbilityButtonHinter.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAbilityButtonHinter>.NativeClassPtr, "button");
			WormAbilityButtonHinter.NativeFieldInfoPtr_hintAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAbilityButtonHinter>.NativeClassPtr, "hintAnimator");
			WormAbilityButtonHinter.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAbilityButtonHinter>.NativeClassPtr, "parent");
			WormAbilityButtonHinter.NativeFieldInfoPtr_turnTypeAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAbilityButtonHinter>.NativeClassPtr, "turnTypeAttribute");
			WormAbilityButtonHinter.NativeFieldInfoPtr_HintParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAbilityButtonHinter>.NativeClassPtr, "HintParam");
			WormAbilityButtonHinter.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityButtonHinter>.NativeClassPtr, 100666053);
			WormAbilityButtonHinter.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityButtonHinter>.NativeClassPtr, 100666054);
			WormAbilityButtonHinter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityButtonHinter>.NativeClassPtr, 100666055);
		}

		// Token: 0x0600140C RID: 5132 RVA: 0x000550B8 File Offset: 0x000532B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713642, XrefRangeEnd = 713670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAbilityButtonHinter.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600140D RID: 5133 RVA: 0x000550F4 File Offset: 0x000532F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713670, XrefRangeEnd = 713682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAbilityButtonHinter.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600140E RID: 5134 RVA: 0x00055130 File Offset: 0x00053330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713682, XrefRangeEnd = 713685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormAbilityButtonHinter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAbilityButtonHinter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAbilityButtonHinter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600140F RID: 5135 RVA: 0x0000C494 File Offset: 0x0000A694
		public WormAbilityButtonHinter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06001410 RID: 5136 RVA: 0x0005516C File Offset: 0x0005336C
		// (set) Token: 0x06001411 RID: 5137 RVA: 0x0000C49D File Offset: 0x0000A69D
		public unsafe Button button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityButtonHinter.NativeFieldInfoPtr_button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityButtonHinter.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06001412 RID: 5138 RVA: 0x0005519C File Offset: 0x0005339C
		// (set) Token: 0x06001413 RID: 5139 RVA: 0x0000C4BC File Offset: 0x0000A6BC
		public unsafe Animator hintAnimator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityButtonHinter.NativeFieldInfoPtr_hintAnimator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityButtonHinter.NativeFieldInfoPtr_hintAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06001414 RID: 5140 RVA: 0x000551CC File Offset: 0x000533CC
		// (set) Token: 0x06001415 RID: 5141 RVA: 0x0000C4DB File Offset: 0x0000A6DB
		public unsafe EntityView parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityButtonHinter.NativeFieldInfoPtr_parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityButtonHinter.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06001416 RID: 5142 RVA: 0x000551FC File Offset: 0x000533FC
		// (set) Token: 0x06001417 RID: 5143 RVA: 0x0000C4FA File Offset: 0x0000A6FA
		public unsafe IAttribute<Nullable<PlayerTurnTypes>> turnTypeAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityButtonHinter.NativeFieldInfoPtr_turnTypeAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<PlayerTurnTypes>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityButtonHinter.NativeFieldInfoPtr_turnTypeAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06001418 RID: 5144 RVA: 0x0005522C File Offset: 0x0005342C
		// (set) Token: 0x06001419 RID: 5145 RVA: 0x0000C519 File Offset: 0x0000A719
		public unsafe static int HintParam
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WormAbilityButtonHinter.NativeFieldInfoPtr_HintParam, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAbilityButtonHinter.NativeFieldInfoPtr_HintParam, (void*)(&value));
			}
		}

		// Token: 0x04000B9D RID: 2973
		private static readonly IntPtr NativeFieldInfoPtr_button;

		// Token: 0x04000B9E RID: 2974
		private static readonly IntPtr NativeFieldInfoPtr_hintAnimator;

		// Token: 0x04000B9F RID: 2975
		private static readonly IntPtr NativeFieldInfoPtr_parent;

		// Token: 0x04000BA0 RID: 2976
		private static readonly IntPtr NativeFieldInfoPtr_turnTypeAttribute;

		// Token: 0x04000BA1 RID: 2977
		private static readonly IntPtr NativeFieldInfoPtr_HintParam;

		// Token: 0x04000BA2 RID: 2978
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000BA3 RID: 2979
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000BA4 RID: 2980
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
