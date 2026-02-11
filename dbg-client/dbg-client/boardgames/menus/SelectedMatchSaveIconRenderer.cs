using System;
using Canis;
using dwd.core.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.menus
{
	// Token: 0x020001AC RID: 428
	public class SelectedMatchSaveIconRenderer : VersionedSubscriber<SelectedData<MatchInitData>>
	{
		// Token: 0x06001336 RID: 4918 RVA: 0x0005BCF4 File Offset: 0x00059EF4
		// Note: this type is marked as 'beforefieldinit'.
		static SelectedMatchSaveIconRenderer()
		{
			Il2CppClassPointerStore<SelectedMatchSaveIconRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus", "SelectedMatchSaveIconRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectedMatchSaveIconRenderer>.NativeClassPtr);
			SelectedMatchSaveIconRenderer.NativeFieldInfoPtr_saveIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedMatchSaveIconRenderer>.NativeClassPtr, "saveIcon");
			SelectedMatchSaveIconRenderer.NativeMethodInfoPtr_hasSavedGame_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedMatchSaveIconRenderer>.NativeClassPtr, 100666141);
			SelectedMatchSaveIconRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedMatchSaveIconRenderer>.NativeClassPtr, 100666142);
			SelectedMatchSaveIconRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedMatchSaveIconRenderer>.NativeClassPtr, 100666143);
		}

		// Token: 0x06001337 RID: 4919 RVA: 0x0005BD74 File Offset: 0x00059F74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519210, XrefRangeEnd = 519219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool hasSavedGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedMatchSaveIconRenderer.NativeMethodInfoPtr_hasSavedGame_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001338 RID: 4920 RVA: 0x0005BDB0 File Offset: 0x00059FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519219, XrefRangeEnd = 519230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectedMatchSaveIconRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x0005BDEC File Offset: 0x00059FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519230, XrefRangeEnd = 519233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectedMatchSaveIconRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectedMatchSaveIconRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedMatchSaveIconRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600133A RID: 4922 RVA: 0x0000B022 File Offset: 0x00009222
		public SelectedMatchSaveIconRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x0600133B RID: 4923 RVA: 0x0005BE28 File Offset: 0x0005A028
		// (set) Token: 0x0600133C RID: 4924 RVA: 0x0000B02B File Offset: 0x0000922B
		public unsafe GameObject saveIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedMatchSaveIconRenderer.NativeFieldInfoPtr_saveIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedMatchSaveIconRenderer.NativeFieldInfoPtr_saveIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BDC RID: 3036
		private static readonly IntPtr NativeFieldInfoPtr_saveIcon;

		// Token: 0x04000BDD RID: 3037
		private static readonly IntPtr NativeMethodInfoPtr_hasSavedGame_Private_Boolean_0;

		// Token: 0x04000BDE RID: 3038
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000BDF RID: 3039
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
