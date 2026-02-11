using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.src.menus
{
	// Token: 0x02000158 RID: 344
	public class ButtonSaveIcon : MonoBehaviour
	{
		// Token: 0x06001172 RID: 4466 RVA: 0x00046A08 File Offset: 0x00044C08
		// Note: this type is marked as 'beforefieldinit'.
		static ButtonSaveIcon()
		{
			Il2CppClassPointerStore<ButtonSaveIcon>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.src.menus", "ButtonSaveIcon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ButtonSaveIcon>.NativeClassPtr);
			ButtonSaveIcon.NativeFieldInfoPtr_icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonSaveIcon>.NativeClassPtr, "icon");
			ButtonSaveIcon.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonSaveIcon>.NativeClassPtr, 100665858);
			ButtonSaveIcon.NativeMethodInfoPtr_hasSavedGame_Protected_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonSaveIcon>.NativeClassPtr, 100665859);
			ButtonSaveIcon.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonSaveIcon>.NativeClassPtr, 100665860);
		}

		// Token: 0x06001173 RID: 4467 RVA: 0x00046A88 File Offset: 0x00044C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000041, XrefRangeEnd = 1000043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonSaveIcon.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001174 RID: 4468 RVA: 0x00046ABC File Offset: 0x00044CBC
		[CallerCount(0)]
		public unsafe virtual bool hasSavedGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ButtonSaveIcon.NativeMethodInfoPtr_hasSavedGame_Protected_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x00046B04 File Offset: 0x00044D04
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ButtonSaveIcon()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ButtonSaveIcon>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonSaveIcon.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x0000A239 File Offset: 0x00008439
		public ButtonSaveIcon(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06001177 RID: 4471 RVA: 0x00046B40 File Offset: 0x00044D40
		// (set) Token: 0x06001178 RID: 4472 RVA: 0x0000A242 File Offset: 0x00008442
		public unsafe GameObject icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSaveIcon.NativeFieldInfoPtr_icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSaveIcon.NativeFieldInfoPtr_icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A9B RID: 2715
		private static readonly IntPtr NativeFieldInfoPtr_icon;

		// Token: 0x04000A9C RID: 2716
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000A9D RID: 2717
		private static readonly IntPtr NativeMethodInfoPtr_hasSavedGame_Protected_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04000A9E RID: 2718
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
