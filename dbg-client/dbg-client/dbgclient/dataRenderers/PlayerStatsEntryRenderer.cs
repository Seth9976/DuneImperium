using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;

namespace dbgclient.dataRenderers
{
	// Token: 0x020000BE RID: 190
	public class PlayerStatsEntryRenderer : MonoBehaviour
	{
		// Token: 0x060007BD RID: 1981 RVA: 0x00035C24 File Offset: 0x00033E24
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerStatsEntryRenderer()
		{
			Il2CppClassPointerStore<PlayerStatsEntryRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.dataRenderers", "PlayerStatsEntryRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerStatsEntryRenderer>.NativeClassPtr);
			PlayerStatsEntryRenderer.NativeFieldInfoPtr_categoryText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStatsEntryRenderer>.NativeClassPtr, "categoryText");
			PlayerStatsEntryRenderer.NativeFieldInfoPtr_categoryFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStatsEntryRenderer>.NativeClassPtr, "categoryFormat");
			PlayerStatsEntryRenderer.NativeFieldInfoPtr_ownerValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStatsEntryRenderer>.NativeClassPtr, "ownerValue");
			PlayerStatsEntryRenderer.NativeFieldInfoPtr_friendsValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStatsEntryRenderer>.NativeClassPtr, "friendsValue");
			PlayerStatsEntryRenderer.NativeMethodInfoPtr_Init_Public_Virtual_New_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerStatsEntryRenderer>.NativeClassPtr, 100664458);
			PlayerStatsEntryRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerStatsEntryRenderer>.NativeClassPtr, 100664459);
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00035CCC File Offset: 0x00033ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504530, XrefRangeEnd = 504543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Init(string categoryID, string ownerValueString, string friendsValueString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(categoryID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ownerValueString);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(friendsValueString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerStatsEntryRenderer.NativeMethodInfoPtr_Init_Public_Virtual_New_Void_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x00035D40 File Offset: 0x00033F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504543, XrefRangeEnd = 504548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerStatsEntryRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerStatsEntryRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerStatsEntryRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x000059AE File Offset: 0x00003BAE
		public PlayerStatsEntryRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x060007C1 RID: 1985 RVA: 0x00035D7C File Offset: 0x00033F7C
		// (set) Token: 0x060007C2 RID: 1986 RVA: 0x000059B7 File Offset: 0x00003BB7
		public unsafe TMP_Text categoryText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerStatsEntryRenderer.NativeFieldInfoPtr_categoryText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerStatsEntryRenderer.NativeFieldInfoPtr_categoryText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x060007C3 RID: 1987 RVA: 0x00035DAC File Offset: 0x00033FAC
		// (set) Token: 0x060007C4 RID: 1988 RVA: 0x000059D6 File Offset: 0x00003BD6
		public unsafe string categoryFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerStatsEntryRenderer.NativeFieldInfoPtr_categoryFormat);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerStatsEntryRenderer.NativeFieldInfoPtr_categoryFormat), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x060007C5 RID: 1989 RVA: 0x00035DD4 File Offset: 0x00033FD4
		// (set) Token: 0x060007C6 RID: 1990 RVA: 0x000059F5 File Offset: 0x00003BF5
		public unsafe TMP_Text ownerValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerStatsEntryRenderer.NativeFieldInfoPtr_ownerValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerStatsEntryRenderer.NativeFieldInfoPtr_ownerValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x060007C7 RID: 1991 RVA: 0x00035E04 File Offset: 0x00034004
		// (set) Token: 0x060007C8 RID: 1992 RVA: 0x00005A14 File Offset: 0x00003C14
		public unsafe TMP_Text friendsValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerStatsEntryRenderer.NativeFieldInfoPtr_friendsValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerStatsEntryRenderer.NativeFieldInfoPtr_friendsValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004B7 RID: 1207
		private static readonly IntPtr NativeFieldInfoPtr_categoryText;

		// Token: 0x040004B8 RID: 1208
		private static readonly IntPtr NativeFieldInfoPtr_categoryFormat;

		// Token: 0x040004B9 RID: 1209
		private static readonly IntPtr NativeFieldInfoPtr_ownerValue;

		// Token: 0x040004BA RID: 1210
		private static readonly IntPtr NativeFieldInfoPtr_friendsValue;

		// Token: 0x040004BB RID: 1211
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_New_Void_String_String_String_0;

		// Token: 0x040004BC RID: 1212
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
