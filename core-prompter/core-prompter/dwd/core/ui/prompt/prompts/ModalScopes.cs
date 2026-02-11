using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.core.ui.prompt.prompts
{
	// Token: 0x02000012 RID: 18
	public class ModalScopes : MonoBehaviour
	{
		// Token: 0x0600008C RID: 140 RVA: 0x00005DD0 File Offset: 0x00003FD0
		// Note: this type is marked as 'beforefieldinit'.
		static ModalScopes()
		{
			Il2CppClassPointerStore<ModalScopes>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.prompts", "ModalScopes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModalScopes>.NativeClassPtr);
			ModalScopes.NativeFieldInfoPtr_BehindUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModalScopes>.NativeClassPtr, "BehindUI");
			ModalScopes.NativeFieldInfoPtr_Menus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModalScopes>.NativeClassPtr, "Menus");
			ModalScopes.NativeFieldInfoPtr_Modal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModalScopes>.NativeClassPtr, "Modal");
			ModalScopes.NativeFieldInfoPtr_InFrontOfModal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModalScopes>.NativeClassPtr, "InFrontOfModal");
			ModalScopes.NativeFieldInfoPtr_Tutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModalScopes>.NativeClassPtr, "Tutorial");
			ModalScopes.NativeFieldInfoPtr_SuperModal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModalScopes>.NativeClassPtr, "SuperModal");
			ModalScopes.NativeFieldInfoPtr_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModalScopes>.NativeClassPtr, "Settings");
			ModalScopes.NativeFieldInfoPtr_EnableControllerSupport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModalScopes>.NativeClassPtr, "EnableControllerSupport");
			ModalScopes.NativeFieldInfoPtr_Curtain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModalScopes>.NativeClassPtr, "Curtain");
			ModalScopes.NativeFieldInfoPtr_NetworkMessageModal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModalScopes>.NativeClassPtr, "NetworkMessageModal");
			ModalScopes.NativeMethodInfoPtr_Find_Public_Static_ModalScopes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModalScopes>.NativeClassPtr, 100663368);
			ModalScopes.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModalScopes>.NativeClassPtr, 100663369);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00005EF0 File Offset: 0x000040F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1213469, RefRangeEnd = 1213470, XrefRangeStart = 1213466, XrefRangeEnd = 1213469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ModalScopes Find()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModalScopes.NativeMethodInfoPtr_Find_Public_Static_ModalScopes_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ModalScopes>(intPtr3) : null;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00005F24 File Offset: 0x00004124
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ModalScopes()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModalScopes>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModalScopes.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002440 File Offset: 0x00000640
		public ModalScopes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00005F60 File Offset: 0x00004160
		// (set) Token: 0x06000091 RID: 145 RVA: 0x00002449 File Offset: 0x00000649
		public unsafe ModalScope BehindUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModalScopes.NativeFieldInfoPtr_BehindUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ModalScope>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModalScopes.NativeFieldInfoPtr_BehindUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00005F90 File Offset: 0x00004190
		// (set) Token: 0x06000093 RID: 147 RVA: 0x00002468 File Offset: 0x00000668
		public unsafe ModalScope Menus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModalScopes.NativeFieldInfoPtr_Menus);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ModalScope>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModalScopes.NativeFieldInfoPtr_Menus), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00005FC0 File Offset: 0x000041C0
		// (set) Token: 0x06000095 RID: 149 RVA: 0x00002487 File Offset: 0x00000687
		public unsafe ModalScope Modal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModalScopes.NativeFieldInfoPtr_Modal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ModalScope>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModalScopes.NativeFieldInfoPtr_Modal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00005FF0 File Offset: 0x000041F0
		// (set) Token: 0x06000097 RID: 151 RVA: 0x000024A6 File Offset: 0x000006A6
		public unsafe ModalScope InFrontOfModal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModalScopes.NativeFieldInfoPtr_InFrontOfModal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ModalScope>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModalScopes.NativeFieldInfoPtr_InFrontOfModal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00006020 File Offset: 0x00004220
		// (set) Token: 0x06000099 RID: 153 RVA: 0x000024C5 File Offset: 0x000006C5
		public unsafe ModalScope Tutorial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModalScopes.NativeFieldInfoPtr_Tutorial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ModalScope>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModalScopes.NativeFieldInfoPtr_Tutorial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00006050 File Offset: 0x00004250
		// (set) Token: 0x0600009B RID: 155 RVA: 0x000024E4 File Offset: 0x000006E4
		public unsafe ModalScope SuperModal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModalScopes.NativeFieldInfoPtr_SuperModal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ModalScope>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModalScopes.NativeFieldInfoPtr_SuperModal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00006080 File Offset: 0x00004280
		// (set) Token: 0x0600009D RID: 157 RVA: 0x00002503 File Offset: 0x00000703
		public unsafe ModalScope Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModalScopes.NativeFieldInfoPtr_Settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ModalScope>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModalScopes.NativeFieldInfoPtr_Settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600009E RID: 158 RVA: 0x000060B0 File Offset: 0x000042B0
		// (set) Token: 0x0600009F RID: 159 RVA: 0x00002522 File Offset: 0x00000722
		public unsafe ModalScope EnableControllerSupport
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModalScopes.NativeFieldInfoPtr_EnableControllerSupport);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ModalScope>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModalScopes.NativeFieldInfoPtr_EnableControllerSupport), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x000060E0 File Offset: 0x000042E0
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x00002541 File Offset: 0x00000741
		public unsafe ModalScope Curtain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModalScopes.NativeFieldInfoPtr_Curtain);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ModalScope>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModalScopes.NativeFieldInfoPtr_Curtain), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00006110 File Offset: 0x00004310
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x00002560 File Offset: 0x00000760
		public unsafe ModalScope NetworkMessageModal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModalScopes.NativeFieldInfoPtr_NetworkMessageModal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ModalScope>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModalScopes.NativeFieldInfoPtr_NetworkMessageModal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeFieldInfoPtr_BehindUI;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeFieldInfoPtr_Menus;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeFieldInfoPtr_Modal;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeFieldInfoPtr_InFrontOfModal;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeFieldInfoPtr_Tutorial;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeFieldInfoPtr_SuperModal;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeFieldInfoPtr_Settings;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeFieldInfoPtr_EnableControllerSupport;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeFieldInfoPtr_Curtain;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeFieldInfoPtr_NetworkMessageModal;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Static_ModalScopes_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
