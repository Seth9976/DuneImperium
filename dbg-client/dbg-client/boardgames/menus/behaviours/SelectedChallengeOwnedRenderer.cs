using System;
using Canis;
using dwd.core.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine.UI;

namespace boardgames.menus.behaviours
{
	// Token: 0x020001BD RID: 445
	public class SelectedChallengeOwnedRenderer : VersionedView<SelectedData<MatchInitData>>
	{
		// Token: 0x0600140B RID: 5131 RVA: 0x0005E588 File Offset: 0x0005C788
		// Note: this type is marked as 'beforefieldinit'.
		static SelectedChallengeOwnedRenderer()
		{
			Il2CppClassPointerStore<SelectedChallengeOwnedRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.behaviours", "SelectedChallengeOwnedRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectedChallengeOwnedRenderer>.NativeClassPtr);
			SelectedChallengeOwnedRenderer.NativeFieldInfoPtr_playLocString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedChallengeOwnedRenderer>.NativeClassPtr, "playLocString");
			SelectedChallengeOwnedRenderer.NativeFieldInfoPtr_purchaseLocString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedChallengeOwnedRenderer>.NativeClassPtr, "purchaseLocString");
			SelectedChallengeOwnedRenderer.NativeFieldInfoPtr_buttonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedChallengeOwnedRenderer>.NativeClassPtr, "buttonText");
			SelectedChallengeOwnedRenderer.NativeFieldInfoPtr_dlcLockedIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedChallengeOwnedRenderer>.NativeClassPtr, "dlcLockedIcon");
			SelectedChallengeOwnedRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedChallengeOwnedRenderer>.NativeClassPtr, 100666238);
			SelectedChallengeOwnedRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedChallengeOwnedRenderer>.NativeClassPtr, 100666239);
			SelectedChallengeOwnedRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedChallengeOwnedRenderer>.NativeClassPtr, 100666240);
		}

		// Token: 0x0600140C RID: 5132 RVA: 0x0005E644 File Offset: 0x0005C844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519939, XrefRangeEnd = 519949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectedChallengeOwnedRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600140D RID: 5133 RVA: 0x0005E680 File Offset: 0x0005C880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519949, XrefRangeEnd = 519958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectedChallengeOwnedRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600140E RID: 5134 RVA: 0x0005E6BC File Offset: 0x0005C8BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519958, XrefRangeEnd = 519966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectedChallengeOwnedRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectedChallengeOwnedRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedChallengeOwnedRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600140F RID: 5135 RVA: 0x0000B6C3 File Offset: 0x000098C3
		public SelectedChallengeOwnedRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06001410 RID: 5136 RVA: 0x0005E6F8 File Offset: 0x0005C8F8
		// (set) Token: 0x06001411 RID: 5137 RVA: 0x0000B6CC File Offset: 0x000098CC
		public unsafe string playLocString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedChallengeOwnedRenderer.NativeFieldInfoPtr_playLocString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedChallengeOwnedRenderer.NativeFieldInfoPtr_playLocString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06001412 RID: 5138 RVA: 0x0005E720 File Offset: 0x0005C920
		// (set) Token: 0x06001413 RID: 5139 RVA: 0x0000B6EB File Offset: 0x000098EB
		public unsafe string purchaseLocString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedChallengeOwnedRenderer.NativeFieldInfoPtr_purchaseLocString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedChallengeOwnedRenderer.NativeFieldInfoPtr_purchaseLocString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06001414 RID: 5140 RVA: 0x0005E748 File Offset: 0x0005C948
		// (set) Token: 0x06001415 RID: 5141 RVA: 0x0000B70A File Offset: 0x0000990A
		public unsafe TMP_Text buttonText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedChallengeOwnedRenderer.NativeFieldInfoPtr_buttonText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedChallengeOwnedRenderer.NativeFieldInfoPtr_buttonText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06001416 RID: 5142 RVA: 0x0005E778 File Offset: 0x0005C978
		// (set) Token: 0x06001417 RID: 5143 RVA: 0x0000B729 File Offset: 0x00009929
		public unsafe Image dlcLockedIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedChallengeOwnedRenderer.NativeFieldInfoPtr_dlcLockedIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedChallengeOwnedRenderer.NativeFieldInfoPtr_dlcLockedIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C5C RID: 3164
		private static readonly IntPtr NativeFieldInfoPtr_playLocString;

		// Token: 0x04000C5D RID: 3165
		private static readonly IntPtr NativeFieldInfoPtr_purchaseLocString;

		// Token: 0x04000C5E RID: 3166
		private static readonly IntPtr NativeFieldInfoPtr_buttonText;

		// Token: 0x04000C5F RID: 3167
		private static readonly IntPtr NativeFieldInfoPtr_dlcLockedIcon;

		// Token: 0x04000C60 RID: 3168
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000C61 RID: 3169
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000C62 RID: 3170
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
