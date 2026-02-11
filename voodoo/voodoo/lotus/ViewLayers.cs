using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace lotus
{
	// Token: 0x02000082 RID: 130
	public class ViewLayers : Object
	{
		// Token: 0x060007B3 RID: 1971 RVA: 0x00022FCC File Offset: 0x000211CC
		// Note: this type is marked as 'beforefieldinit'.
		static ViewLayers()
		{
			Il2CppClassPointerStore<ViewLayers>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "ViewLayers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ViewLayers>.NativeClassPtr);
			ViewLayers.NativeFieldInfoPtr_None = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewLayers>.NativeClassPtr, "None");
			ViewLayers.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewLayers>.NativeClassPtr, "Default");
			ViewLayers.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewLayers>.NativeClassPtr, "Container");
			ViewLayers.NativeFieldInfoPtr_Playmat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewLayers>.NativeClassPtr, "Playmat");
			ViewLayers.NativeFieldInfoPtr_UI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewLayers>.NativeClassPtr, "UI");
			ViewLayers.NativeFieldInfoPtr_Moz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewLayers>.NativeClassPtr, "Moz");
			ViewLayers.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewLayers>.NativeClassPtr, 100664341);
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x00023088 File Offset: 0x00021288
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ViewLayers()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ViewLayers>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewLayers.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x00005CD3 File Offset: 0x00003ED3
		public ViewLayers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x060007B6 RID: 1974 RVA: 0x000230C4 File Offset: 0x000212C4
		// (set) Token: 0x060007B7 RID: 1975 RVA: 0x00005CDC File Offset: 0x00003EDC
		public unsafe static int None
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ViewLayers.NativeFieldInfoPtr_None, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ViewLayers.NativeFieldInfoPtr_None, (void*)(&value));
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x060007B8 RID: 1976 RVA: 0x000230E0 File Offset: 0x000212E0
		// (set) Token: 0x060007B9 RID: 1977 RVA: 0x00005CEA File Offset: 0x00003EEA
		public unsafe static int Default
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ViewLayers.NativeFieldInfoPtr_Default, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ViewLayers.NativeFieldInfoPtr_Default, (void*)(&value));
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x060007BA RID: 1978 RVA: 0x000230FC File Offset: 0x000212FC
		// (set) Token: 0x060007BB RID: 1979 RVA: 0x00005CF8 File Offset: 0x00003EF8
		public unsafe static int Container
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ViewLayers.NativeFieldInfoPtr_Container, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ViewLayers.NativeFieldInfoPtr_Container, (void*)(&value));
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x060007BC RID: 1980 RVA: 0x00023118 File Offset: 0x00021318
		// (set) Token: 0x060007BD RID: 1981 RVA: 0x00005D06 File Offset: 0x00003F06
		public unsafe static int Playmat
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ViewLayers.NativeFieldInfoPtr_Playmat, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ViewLayers.NativeFieldInfoPtr_Playmat, (void*)(&value));
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x060007BE RID: 1982 RVA: 0x00023134 File Offset: 0x00021334
		// (set) Token: 0x060007BF RID: 1983 RVA: 0x00005D14 File Offset: 0x00003F14
		public unsafe static int UI
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ViewLayers.NativeFieldInfoPtr_UI, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ViewLayers.NativeFieldInfoPtr_UI, (void*)(&value));
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x060007C0 RID: 1984 RVA: 0x00023150 File Offset: 0x00021350
		// (set) Token: 0x060007C1 RID: 1985 RVA: 0x00005D22 File Offset: 0x00003F22
		public unsafe static int Moz
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ViewLayers.NativeFieldInfoPtr_Moz, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ViewLayers.NativeFieldInfoPtr_Moz, (void*)(&value));
			}
		}

		// Token: 0x040004D5 RID: 1237
		private static readonly IntPtr NativeFieldInfoPtr_None;

		// Token: 0x040004D6 RID: 1238
		private static readonly IntPtr NativeFieldInfoPtr_Default;

		// Token: 0x040004D7 RID: 1239
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x040004D8 RID: 1240
		private static readonly IntPtr NativeFieldInfoPtr_Playmat;

		// Token: 0x040004D9 RID: 1241
		private static readonly IntPtr NativeFieldInfoPtr_UI;

		// Token: 0x040004DA RID: 1242
		private static readonly IntPtr NativeFieldInfoPtr_Moz;

		// Token: 0x040004DB RID: 1243
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
