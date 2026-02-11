using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace lotus
{
	// Token: 0x02000083 RID: 131
	public class MoveLayers : Object
	{
		// Token: 0x060007C2 RID: 1986 RVA: 0x0002316C File Offset: 0x0002136C
		// Note: this type is marked as 'beforefieldinit'.
		static MoveLayers()
		{
			Il2CppClassPointerStore<MoveLayers>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "MoveLayers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveLayers>.NativeClassPtr);
			MoveLayers.NativeFieldInfoPtr_None = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveLayers>.NativeClassPtr, "None");
			MoveLayers.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveLayers>.NativeClassPtr, "Default");
			MoveLayers.NativeFieldInfoPtr_SecondaryMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveLayers>.NativeClassPtr, "SecondaryMove");
			MoveLayers.NativeFieldInfoPtr_GamepadMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveLayers>.NativeClassPtr, "GamepadMovement");
			MoveLayers.NativeFieldInfoPtr_Moving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveLayers>.NativeClassPtr, "Moving");
			MoveLayers.NativeFieldInfoPtr_ClickAndDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveLayers>.NativeClassPtr, "ClickAndDrag");
			MoveLayers.NativeFieldInfoPtr_Moz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveLayers>.NativeClassPtr, "Moz");
			MoveLayers.NativeFieldInfoPtr_Hidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveLayers>.NativeClassPtr, "Hidden");
			MoveLayers.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveLayers>.NativeClassPtr, 100664342);
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x00023250 File Offset: 0x00021450
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoveLayers()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveLayers>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveLayers.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x00005D30 File Offset: 0x00003F30
		public MoveLayers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x060007C5 RID: 1989 RVA: 0x0002328C File Offset: 0x0002148C
		// (set) Token: 0x060007C6 RID: 1990 RVA: 0x00005D39 File Offset: 0x00003F39
		public unsafe static int None
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MoveLayers.NativeFieldInfoPtr_None, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MoveLayers.NativeFieldInfoPtr_None, (void*)(&value));
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x060007C7 RID: 1991 RVA: 0x000232A8 File Offset: 0x000214A8
		// (set) Token: 0x060007C8 RID: 1992 RVA: 0x00005D47 File Offset: 0x00003F47
		public unsafe static int Default
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MoveLayers.NativeFieldInfoPtr_Default, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MoveLayers.NativeFieldInfoPtr_Default, (void*)(&value));
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x060007C9 RID: 1993 RVA: 0x000232C4 File Offset: 0x000214C4
		// (set) Token: 0x060007CA RID: 1994 RVA: 0x00005D55 File Offset: 0x00003F55
		public unsafe static int SecondaryMove
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MoveLayers.NativeFieldInfoPtr_SecondaryMove, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MoveLayers.NativeFieldInfoPtr_SecondaryMove, (void*)(&value));
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x060007CB RID: 1995 RVA: 0x000232E0 File Offset: 0x000214E0
		// (set) Token: 0x060007CC RID: 1996 RVA: 0x00005D63 File Offset: 0x00003F63
		public unsafe static int GamepadMovement
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MoveLayers.NativeFieldInfoPtr_GamepadMovement, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MoveLayers.NativeFieldInfoPtr_GamepadMovement, (void*)(&value));
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x060007CD RID: 1997 RVA: 0x000232FC File Offset: 0x000214FC
		// (set) Token: 0x060007CE RID: 1998 RVA: 0x00005D71 File Offset: 0x00003F71
		public unsafe static int Moving
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MoveLayers.NativeFieldInfoPtr_Moving, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MoveLayers.NativeFieldInfoPtr_Moving, (void*)(&value));
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x060007CF RID: 1999 RVA: 0x00023318 File Offset: 0x00021518
		// (set) Token: 0x060007D0 RID: 2000 RVA: 0x00005D7F File Offset: 0x00003F7F
		public unsafe static int ClickAndDrag
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MoveLayers.NativeFieldInfoPtr_ClickAndDrag, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MoveLayers.NativeFieldInfoPtr_ClickAndDrag, (void*)(&value));
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x060007D1 RID: 2001 RVA: 0x00023334 File Offset: 0x00021534
		// (set) Token: 0x060007D2 RID: 2002 RVA: 0x00005D8D File Offset: 0x00003F8D
		public unsafe static int Moz
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MoveLayers.NativeFieldInfoPtr_Moz, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MoveLayers.NativeFieldInfoPtr_Moz, (void*)(&value));
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x060007D3 RID: 2003 RVA: 0x00023350 File Offset: 0x00021550
		// (set) Token: 0x060007D4 RID: 2004 RVA: 0x00005D9B File Offset: 0x00003F9B
		public unsafe static int Hidden
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MoveLayers.NativeFieldInfoPtr_Hidden, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MoveLayers.NativeFieldInfoPtr_Hidden, (void*)(&value));
			}
		}

		// Token: 0x040004DC RID: 1244
		private static readonly IntPtr NativeFieldInfoPtr_None;

		// Token: 0x040004DD RID: 1245
		private static readonly IntPtr NativeFieldInfoPtr_Default;

		// Token: 0x040004DE RID: 1246
		private static readonly IntPtr NativeFieldInfoPtr_SecondaryMove;

		// Token: 0x040004DF RID: 1247
		private static readonly IntPtr NativeFieldInfoPtr_GamepadMovement;

		// Token: 0x040004E0 RID: 1248
		private static readonly IntPtr NativeFieldInfoPtr_Moving;

		// Token: 0x040004E1 RID: 1249
		private static readonly IntPtr NativeFieldInfoPtr_ClickAndDrag;

		// Token: 0x040004E2 RID: 1250
		private static readonly IntPtr NativeFieldInfoPtr_Moz;

		// Token: 0x040004E3 RID: 1251
		private static readonly IntPtr NativeFieldInfoPtr_Hidden;

		// Token: 0x040004E4 RID: 1252
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
