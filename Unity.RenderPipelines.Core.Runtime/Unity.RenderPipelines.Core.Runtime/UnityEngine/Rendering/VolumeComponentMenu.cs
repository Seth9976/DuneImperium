using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x020000E8 RID: 232
	public class VolumeComponentMenu : Attribute
	{
		// Token: 0x060010B4 RID: 4276 RVA: 0x0004CC24 File Offset: 0x0004AE24
		// Note: this type is marked as 'beforefieldinit'.
		static VolumeComponentMenu()
		{
			Il2CppClassPointerStore<VolumeComponentMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "VolumeComponentMenu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeComponentMenu>.NativeClassPtr);
			VolumeComponentMenu.NativeFieldInfoPtr_menu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeComponentMenu>.NativeClassPtr, "menu");
			VolumeComponentMenu.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeComponentMenu>.NativeClassPtr, 100665762);
		}

		// Token: 0x060010B5 RID: 4277 RVA: 0x0004CC7C File Offset: 0x0004AE7C
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeComponentMenu(string menu)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeComponentMenu>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(menu);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeComponentMenu.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010B6 RID: 4278 RVA: 0x00008CC7 File Offset: 0x00006EC7
		public VolumeComponentMenu(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x060010B7 RID: 4279 RVA: 0x0004CCC8 File Offset: 0x0004AEC8
		// (set) Token: 0x060010B8 RID: 4280 RVA: 0x00008CD0 File Offset: 0x00006ED0
		public unsafe string menu
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeComponentMenu.NativeFieldInfoPtr_menu);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeComponentMenu.NativeFieldInfoPtr_menu), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000CB2 RID: 3250
		private static readonly IntPtr NativeFieldInfoPtr_menu;

		// Token: 0x04000CB3 RID: 3251
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
