using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using InControl;
using UnityEngine;

namespace InterfaceMovement
{
	// Token: 0x02000012 RID: 18
	public class ButtonManager : MonoBehaviour
	{
		// Token: 0x06000107 RID: 263 RVA: 0x00005F34 File Offset: 0x00004134
		// Note: this type is marked as 'beforefieldinit'.
		static ButtonManager()
		{
			Il2CppClassPointerStore<ButtonManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.Examples.dll", "InterfaceMovement", "ButtonManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ButtonManager>.NativeClassPtr);
			ButtonManager.NativeFieldInfoPtr_focusedButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonManager>.NativeClassPtr, "focusedButton");
			ButtonManager.NativeFieldInfoPtr_filteredDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonManager>.NativeClassPtr, "filteredDirection");
			ButtonManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonManager>.NativeClassPtr, 100663406);
			ButtonManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonManager>.NativeClassPtr, 100663407);
			ButtonManager.NativeMethodInfoPtr_MoveFocusTo_Private_Void_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonManager>.NativeClassPtr, 100663408);
			ButtonManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonManager>.NativeClassPtr, 100663409);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00005FDC File Offset: 0x000041DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252277, XrefRangeEnd = 1252284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00006010 File Offset: 0x00004210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252284, XrefRangeEnd = 1252306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00006044 File Offset: 0x00004244
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1252311, RefRangeEnd = 1252315, XrefRangeStart = 1252306, XrefRangeEnd = 1252311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveFocusTo(Button newFocusedButton)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newFocusedButton);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonManager.NativeMethodInfoPtr_MoveFocusTo_Private_Void_Button_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00006088 File Offset: 0x00004288
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ButtonManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ButtonManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0000287E File Offset: 0x00000A7E
		public ButtonManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600010D RID: 269 RVA: 0x000060C4 File Offset: 0x000042C4
		// (set) Token: 0x0600010E RID: 270 RVA: 0x00002887 File Offset: 0x00000A87
		public unsafe Button focusedButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonManager.NativeFieldInfoPtr_focusedButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonManager.NativeFieldInfoPtr_focusedButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600010F RID: 271 RVA: 0x000060F4 File Offset: 0x000042F4
		// (set) Token: 0x06000110 RID: 272 RVA: 0x000028A6 File Offset: 0x00000AA6
		public unsafe TwoAxisInputControl filteredDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonManager.NativeFieldInfoPtr_filteredDirection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TwoAxisInputControl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonManager.NativeFieldInfoPtr_filteredDirection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeFieldInfoPtr_focusedButton;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeFieldInfoPtr_filteredDirection;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_MoveFocusTo_Private_Void_Button_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
