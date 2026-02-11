using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200000F RID: 15
	[Serializable]
	public sealed class GUISettings : Object
	{
		// Token: 0x060002CB RID: 715 RVA: 0x0000BBFC File Offset: 0x00009DFC
		// Note: this type is marked as 'beforefieldinit'.
		static GUISettings()
		{
			Il2CppClassPointerStore<GUISettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUISettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUISettings>.NativeClassPtr);
			GUISettings.NativeFieldInfoPtr_m_DoubleClickSelectsWord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISettings>.NativeClassPtr, "m_DoubleClickSelectsWord");
			GUISettings.NativeFieldInfoPtr_m_TripleClickSelectsLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISettings>.NativeClassPtr, "m_TripleClickSelectsLine");
			GUISettings.NativeFieldInfoPtr_m_CursorColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISettings>.NativeClassPtr, "m_CursorColor");
			GUISettings.NativeFieldInfoPtr_m_CursorFlashSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISettings>.NativeClassPtr, "m_CursorFlashSpeed");
			GUISettings.NativeFieldInfoPtr_m_SelectionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUISettings>.NativeClassPtr, "m_SelectionColor");
			GUISettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUISettings>.NativeClassPtr, 100663448);
			GUISettings.Internal_GetCursorFlashSpeedDelegateField = IL2CPP.ResolveICall<GUISettings.Internal_GetCursorFlashSpeedDelegate>("UnityEngine.GUISettings::Internal_GetCursorFlashSpeed");
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0000BCB4 File Offset: 0x00009EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186327, XrefRangeEnd = 1186328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUISettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUISettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUISettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00003221 File Offset: 0x00001421
		public GUISettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060002CE RID: 718 RVA: 0x0000BCF0 File Offset: 0x00009EF0
		// (set) Token: 0x060002CF RID: 719 RVA: 0x0000322A File Offset: 0x0000142A
		public unsafe bool m_DoubleClickSelectsWord
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISettings.NativeFieldInfoPtr_m_DoubleClickSelectsWord);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISettings.NativeFieldInfoPtr_m_DoubleClickSelectsWord)) = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x0000BD18 File Offset: 0x00009F18
		// (set) Token: 0x060002D1 RID: 721 RVA: 0x00003245 File Offset: 0x00001445
		public unsafe bool m_TripleClickSelectsLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISettings.NativeFieldInfoPtr_m_TripleClickSelectsLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISettings.NativeFieldInfoPtr_m_TripleClickSelectsLine)) = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x0000BD40 File Offset: 0x00009F40
		// (set) Token: 0x060002D3 RID: 723 RVA: 0x00003260 File Offset: 0x00001460
		public unsafe Color m_CursorColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISettings.NativeFieldInfoPtr_m_CursorColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISettings.NativeFieldInfoPtr_m_CursorColor)) = value;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x0000BD68 File Offset: 0x00009F68
		// (set) Token: 0x060002D5 RID: 725 RVA: 0x0000327B File Offset: 0x0000147B
		public unsafe float m_CursorFlashSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISettings.NativeFieldInfoPtr_m_CursorFlashSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISettings.NativeFieldInfoPtr_m_CursorFlashSpeed)) = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x0000BD90 File Offset: 0x00009F90
		// (set) Token: 0x060002D7 RID: 727 RVA: 0x00003296 File Offset: 0x00001496
		public unsafe Color m_SelectionColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISettings.NativeFieldInfoPtr_m_SelectionColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUISettings.NativeFieldInfoPtr_m_SelectionColor)) = value;
			}
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x000032B1 File Offset: 0x000014B1
		public static float Internal_GetCursorFlashSpeed()
		{
			return GUISettings.Internal_GetCursorFlashSpeedDelegateField();
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060002D9 RID: 729 RVA: 0x0000BDB8 File Offset: 0x00009FB8
		// (set) Token: 0x060002DA RID: 730 RVA: 0x000032BD File Offset: 0x000014BD
		public bool doubleClickSelectsWord
		{
			get
			{
				return this.m_DoubleClickSelectsWord;
			}
			set
			{
				this.m_DoubleClickSelectsWord = value;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060002DB RID: 731 RVA: 0x0000BDD0 File Offset: 0x00009FD0
		// (set) Token: 0x060002DC RID: 732 RVA: 0x000032C7 File Offset: 0x000014C7
		public bool tripleClickSelectsLine
		{
			get
			{
				return this.m_TripleClickSelectsLine;
			}
			set
			{
				this.m_TripleClickSelectsLine = value;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060002DD RID: 733 RVA: 0x0000BDE8 File Offset: 0x00009FE8
		// (set) Token: 0x060002DE RID: 734 RVA: 0x000032D1 File Offset: 0x000014D1
		public Color cursorColor
		{
			get
			{
				return this.m_CursorColor;
			}
			set
			{
				this.m_CursorColor = value;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060002DF RID: 735 RVA: 0x0000BE00 File Offset: 0x0000A000
		// (set) Token: 0x060002E0 RID: 736 RVA: 0x000032DB File Offset: 0x000014DB
		public float cursorFlashSpeed
		{
			get
			{
				bool flag = this.m_CursorFlashSpeed >= 0f;
				float num;
				if (flag)
				{
					num = this.m_CursorFlashSpeed;
				}
				else
				{
					num = GUISettings.Internal_GetCursorFlashSpeed();
				}
				return num;
			}
			set
			{
				this.m_CursorFlashSpeed = value;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x0000BE38 File Offset: 0x0000A038
		// (set) Token: 0x060002E2 RID: 738 RVA: 0x000032E5 File Offset: 0x000014E5
		public Color selectionColor
		{
			get
			{
				return this.m_SelectionColor;
			}
			set
			{
				this.m_SelectionColor = value;
			}
		}

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeFieldInfoPtr_m_DoubleClickSelectsWord;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeFieldInfoPtr_m_TripleClickSelectsLine;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeFieldInfoPtr_m_CursorColor;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeFieldInfoPtr_m_CursorFlashSpeed;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectionColor;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400012B RID: 299
		private static readonly GUISettings.Internal_GetCursorFlashSpeedDelegate Internal_GetCursorFlashSpeedDelegateField;

		// Token: 0x02000072 RID: 114
		// (Invoke) Token: 0x0600070E RID: 1806
		private delegate float Internal_GetCursorFlashSpeedDelegate();
	}
}
