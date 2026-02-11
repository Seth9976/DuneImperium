using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x0200021D RID: 541
	public class WormVPCategoryDisplay : MonoBehaviour
	{
		// Token: 0x060017B9 RID: 6073 RVA: 0x00060050 File Offset: 0x0005E250
		// Note: this type is marked as 'beforefieldinit'.
		static WormVPCategoryDisplay()
		{
			Il2CppClassPointerStore<WormVPCategoryDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormVPCategoryDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormVPCategoryDisplay>.NativeClassPtr);
			WormVPCategoryDisplay.NativeFieldInfoPtr_headerText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVPCategoryDisplay>.NativeClassPtr, "headerText");
			WormVPCategoryDisplay.NativeFieldInfoPtr_sourcesRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVPCategoryDisplay>.NativeClassPtr, "sourcesRoot");
			WormVPCategoryDisplay.NativeFieldInfoPtr_sourcePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVPCategoryDisplay>.NativeClassPtr, "sourcePrefab");
			WormVPCategoryDisplay.NativeMethodInfoPtr_Initialize_Public_Void_String_IReadOnlyList_1_ValueTuple_2_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVPCategoryDisplay>.NativeClassPtr, 100666590);
			WormVPCategoryDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVPCategoryDisplay>.NativeClassPtr, 100666591);
		}

		// Token: 0x060017BA RID: 6074 RVA: 0x000600E4 File Offset: 0x0005E2E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 717706, RefRangeEnd = 717707, XrefRangeStart = 717671, XrefRangeEnd = 717706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(string category, IReadOnlyList<ValueTuple<string, int>> sources)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(category);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sources);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVPCategoryDisplay.NativeMethodInfoPtr_Initialize_Public_Void_String_IReadOnlyList_1_ValueTuple_2_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017BB RID: 6075 RVA: 0x00060138 File Offset: 0x0005E338
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormVPCategoryDisplay()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormVPCategoryDisplay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVPCategoryDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017BC RID: 6076 RVA: 0x0000E294 File Offset: 0x0000C494
		public WormVPCategoryDisplay(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x060017BD RID: 6077 RVA: 0x00060174 File Offset: 0x0005E374
		// (set) Token: 0x060017BE RID: 6078 RVA: 0x0000E29D File Offset: 0x0000C49D
		public unsafe TMP_Text headerText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVPCategoryDisplay.NativeFieldInfoPtr_headerText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVPCategoryDisplay.NativeFieldInfoPtr_headerText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x060017BF RID: 6079 RVA: 0x000601A4 File Offset: 0x0005E3A4
		// (set) Token: 0x060017C0 RID: 6080 RVA: 0x0000E2BC File Offset: 0x0000C4BC
		public unsafe Transform sourcesRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVPCategoryDisplay.NativeFieldInfoPtr_sourcesRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVPCategoryDisplay.NativeFieldInfoPtr_sourcesRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x060017C1 RID: 6081 RVA: 0x000601D4 File Offset: 0x0005E3D4
		// (set) Token: 0x060017C2 RID: 6082 RVA: 0x0000E2DB File Offset: 0x0000C4DB
		public unsafe WormVPSourceDisplay sourcePrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVPCategoryDisplay.NativeFieldInfoPtr_sourcePrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormVPSourceDisplay>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVPCategoryDisplay.NativeFieldInfoPtr_sourcePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000DBF RID: 3519
		private static readonly IntPtr NativeFieldInfoPtr_headerText;

		// Token: 0x04000DC0 RID: 3520
		private static readonly IntPtr NativeFieldInfoPtr_sourcesRoot;

		// Token: 0x04000DC1 RID: 3521
		private static readonly IntPtr NativeFieldInfoPtr_sourcePrefab;

		// Token: 0x04000DC2 RID: 3522
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_String_IReadOnlyList_1_ValueTuple_2_String_Int32_0;

		// Token: 0x04000DC3 RID: 3523
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
