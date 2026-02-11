using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace InterfaceMovement
{
	// Token: 0x02000011 RID: 17
	public class ButtonFocus : MonoBehaviour
	{
		// Token: 0x06000103 RID: 259 RVA: 0x00005E6C File Offset: 0x0000406C
		// Note: this type is marked as 'beforefieldinit'.
		static ButtonFocus()
		{
			Il2CppClassPointerStore<ButtonFocus>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.Examples.dll", "InterfaceMovement", "ButtonFocus");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ButtonFocus>.NativeClassPtr);
			ButtonFocus.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonFocus>.NativeClassPtr, 100663404);
			ButtonFocus.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonFocus>.NativeClassPtr, 100663405);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00005EC4 File Offset: 0x000040C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252259, XrefRangeEnd = 1252277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonFocus.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00005EF8 File Offset: 0x000040F8
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ButtonFocus()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ButtonFocus>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonFocus.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002875 File Offset: 0x00000A75
		public ButtonFocus(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
