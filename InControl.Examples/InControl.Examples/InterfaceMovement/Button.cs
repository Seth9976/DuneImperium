using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace InterfaceMovement
{
	// Token: 0x02000010 RID: 16
	public class Button : MonoBehaviour
	{
		// Token: 0x060000F4 RID: 244 RVA: 0x00005C08 File Offset: 0x00003E08
		// Note: this type is marked as 'beforefieldinit'.
		static Button()
		{
			Il2CppClassPointerStore<Button>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.Examples.dll", "InterfaceMovement", "Button");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Button>.NativeClassPtr);
			Button.NativeFieldInfoPtr_cachedRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Button>.NativeClassPtr, "cachedRenderer");
			Button.NativeFieldInfoPtr_up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Button>.NativeClassPtr, "up");
			Button.NativeFieldInfoPtr_down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Button>.NativeClassPtr, "down");
			Button.NativeFieldInfoPtr_left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Button>.NativeClassPtr, "left");
			Button.NativeFieldInfoPtr_right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Button>.NativeClassPtr, "right");
			Button.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Button>.NativeClassPtr, 100663401);
			Button.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Button>.NativeClassPtr, 100663402);
			Button.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Button>.NativeClassPtr, 100663403);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00005CD8 File Offset: 0x00003ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252239, XrefRangeEnd = 1252243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Button.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00005D0C File Offset: 0x00003F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252243, XrefRangeEnd = 1252259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Button.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00005D40 File Offset: 0x00003F40
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Button()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Button>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Button.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x000027D1 File Offset: 0x000009D1
		public Button(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x00005D7C File Offset: 0x00003F7C
		// (set) Token: 0x060000FA RID: 250 RVA: 0x000027DA File Offset: 0x000009DA
		public unsafe Renderer cachedRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Button.NativeFieldInfoPtr_cachedRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Renderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Button.NativeFieldInfoPtr_cachedRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000FB RID: 251 RVA: 0x00005DAC File Offset: 0x00003FAC
		// (set) Token: 0x060000FC RID: 252 RVA: 0x000027F9 File Offset: 0x000009F9
		public unsafe Button up
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Button.NativeFieldInfoPtr_up);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Button.NativeFieldInfoPtr_up), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00005DDC File Offset: 0x00003FDC
		// (set) Token: 0x060000FE RID: 254 RVA: 0x00002818 File Offset: 0x00000A18
		public unsafe Button down
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Button.NativeFieldInfoPtr_down);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Button.NativeFieldInfoPtr_down), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00005E0C File Offset: 0x0000400C
		// (set) Token: 0x06000100 RID: 256 RVA: 0x00002837 File Offset: 0x00000A37
		public unsafe Button left
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Button.NativeFieldInfoPtr_left);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Button.NativeFieldInfoPtr_left), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000101 RID: 257 RVA: 0x00005E3C File Offset: 0x0000403C
		// (set) Token: 0x06000102 RID: 258 RVA: 0x00002856 File Offset: 0x00000A56
		public unsafe Button right
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Button.NativeFieldInfoPtr_right);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Button.NativeFieldInfoPtr_right), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeFieldInfoPtr_cachedRenderer;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeFieldInfoPtr_up;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeFieldInfoPtr_down;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeFieldInfoPtr_left;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeFieldInfoPtr_right;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
