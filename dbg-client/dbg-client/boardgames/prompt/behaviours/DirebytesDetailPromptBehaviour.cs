using System;
using dwd.core.direBytes.data;
using dwd.core.ui.match.prompt.prompts;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine.UI;

namespace boardgames.prompt.behaviours
{
	// Token: 0x02000102 RID: 258
	public class DirebytesDetailPromptBehaviour : PromptBehaviour<FlavoredDismissablePrompt>
	{
		// Token: 0x06000B09 RID: 2825 RVA: 0x000408A0 File Offset: 0x0003EAA0
		// Note: this type is marked as 'beforefieldinit'.
		static DirebytesDetailPromptBehaviour()
		{
			Il2CppClassPointerStore<DirebytesDetailPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.prompt.behaviours", "DirebytesDetailPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DirebytesDetailPromptBehaviour>.NativeClassPtr);
			DirebytesDetailPromptBehaviour.NativeFieldInfoPtr_linkLocKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirebytesDetailPromptBehaviour>.NativeClassPtr, "linkLocKey");
			DirebytesDetailPromptBehaviour.NativeFieldInfoPtr_storeLocKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirebytesDetailPromptBehaviour>.NativeClassPtr, "storeLocKey");
			DirebytesDetailPromptBehaviour.NativeFieldInfoPtr_backLocKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirebytesDetailPromptBehaviour>.NativeClassPtr, "backLocKey");
			DirebytesDetailPromptBehaviour.NativeFieldInfoPtr_continueLocKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirebytesDetailPromptBehaviour>.NativeClassPtr, "continueLocKey");
			DirebytesDetailPromptBehaviour.NativeFieldInfoPtr_linkButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirebytesDetailPromptBehaviour>.NativeClassPtr, "linkButton");
			DirebytesDetailPromptBehaviour.NativeFieldInfoPtr_linkText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirebytesDetailPromptBehaviour>.NativeClassPtr, "linkText");
			DirebytesDetailPromptBehaviour.NativeFieldInfoPtr_backText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirebytesDetailPromptBehaviour>.NativeClassPtr, "backText");
			DirebytesDetailPromptBehaviour.NativeFieldInfoPtr_typeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirebytesDetailPromptBehaviour>.NativeClassPtr, "typeName");
			DirebytesDetailPromptBehaviour.NativeFieldInfoPtr_newsSubpageData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirebytesDetailPromptBehaviour>.NativeClassPtr, "newsSubpageData");
			DirebytesDetailPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirebytesDetailPromptBehaviour>.NativeClassPtr, 100664915);
			DirebytesDetailPromptBehaviour.NativeMethodInfoPtr_Event_LinkClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirebytesDetailPromptBehaviour>.NativeClassPtr, 100664916);
			DirebytesDetailPromptBehaviour.NativeMethodInfoPtr_Event_Hide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirebytesDetailPromptBehaviour>.NativeClassPtr, 100664917);
			DirebytesDetailPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirebytesDetailPromptBehaviour>.NativeClassPtr, 100664918);
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x000409D4 File Offset: 0x0003EBD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507681, XrefRangeEnd = 507737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DirebytesDetailPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x00040A10 File Offset: 0x0003EC10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507737, XrefRangeEnd = 507783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_LinkClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirebytesDetailPromptBehaviour.NativeMethodInfoPtr_Event_LinkClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x00040A44 File Offset: 0x0003EC44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507783, XrefRangeEnd = 507788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Hide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirebytesDetailPromptBehaviour.NativeMethodInfoPtr_Event_Hide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x00040A78 File Offset: 0x0003EC78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507788, XrefRangeEnd = 507791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DirebytesDetailPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DirebytesDetailPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirebytesDetailPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x000073CD File Offset: 0x000055CD
		public DirebytesDetailPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000B0F RID: 2831 RVA: 0x00040AB4 File Offset: 0x0003ECB4
		// (set) Token: 0x06000B10 RID: 2832 RVA: 0x000073D6 File Offset: 0x000055D6
		public unsafe static string linkLocKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DirebytesDetailPromptBehaviour.NativeFieldInfoPtr_linkLocKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DirebytesDetailPromptBehaviour.NativeFieldInfoPtr_linkLocKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000B11 RID: 2833 RVA: 0x00040AD4 File Offset: 0x0003ECD4
		// (set) Token: 0x06000B12 RID: 2834 RVA: 0x000073E8 File Offset: 0x000055E8
		public unsafe static string storeLocKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DirebytesDetailPromptBehaviour.NativeFieldInfoPtr_storeLocKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DirebytesDetailPromptBehaviour.NativeFieldInfoPtr_storeLocKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000B13 RID: 2835 RVA: 0x00040AF4 File Offset: 0x0003ECF4
		// (set) Token: 0x06000B14 RID: 2836 RVA: 0x000073FA File Offset: 0x000055FA
		public unsafe static string backLocKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DirebytesDetailPromptBehaviour.NativeFieldInfoPtr_backLocKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DirebytesDetailPromptBehaviour.NativeFieldInfoPtr_backLocKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000B15 RID: 2837 RVA: 0x00040B14 File Offset: 0x0003ED14
		// (set) Token: 0x06000B16 RID: 2838 RVA: 0x0000740C File Offset: 0x0000560C
		public unsafe static string continueLocKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DirebytesDetailPromptBehaviour.NativeFieldInfoPtr_continueLocKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DirebytesDetailPromptBehaviour.NativeFieldInfoPtr_continueLocKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000B17 RID: 2839 RVA: 0x00040B34 File Offset: 0x0003ED34
		// (set) Token: 0x06000B18 RID: 2840 RVA: 0x0000741E File Offset: 0x0000561E
		public unsafe Button linkButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirebytesDetailPromptBehaviour.NativeFieldInfoPtr_linkButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirebytesDetailPromptBehaviour.NativeFieldInfoPtr_linkButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000B19 RID: 2841 RVA: 0x00040B64 File Offset: 0x0003ED64
		// (set) Token: 0x06000B1A RID: 2842 RVA: 0x0000743D File Offset: 0x0000563D
		public unsafe TMP_Text linkText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirebytesDetailPromptBehaviour.NativeFieldInfoPtr_linkText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirebytesDetailPromptBehaviour.NativeFieldInfoPtr_linkText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000B1B RID: 2843 RVA: 0x00040B94 File Offset: 0x0003ED94
		// (set) Token: 0x06000B1C RID: 2844 RVA: 0x0000745C File Offset: 0x0000565C
		public unsafe TMP_Text backText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirebytesDetailPromptBehaviour.NativeFieldInfoPtr_backText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirebytesDetailPromptBehaviour.NativeFieldInfoPtr_backText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000B1D RID: 2845 RVA: 0x00040BC4 File Offset: 0x0003EDC4
		// (set) Token: 0x06000B1E RID: 2846 RVA: 0x0000747B File Offset: 0x0000567B
		public unsafe string typeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirebytesDetailPromptBehaviour.NativeFieldInfoPtr_typeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirebytesDetailPromptBehaviour.NativeFieldInfoPtr_typeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000B1F RID: 2847 RVA: 0x00040BEC File Offset: 0x0003EDEC
		// (set) Token: 0x06000B20 RID: 2848 RVA: 0x0000749A File Offset: 0x0000569A
		public unsafe DireByteTileNewsSubpageData newsSubpageData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirebytesDetailPromptBehaviour.NativeFieldInfoPtr_newsSubpageData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DireByteTileNewsSubpageData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirebytesDetailPromptBehaviour.NativeFieldInfoPtr_newsSubpageData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006CA RID: 1738
		private static readonly IntPtr NativeFieldInfoPtr_linkLocKey;

		// Token: 0x040006CB RID: 1739
		private static readonly IntPtr NativeFieldInfoPtr_storeLocKey;

		// Token: 0x040006CC RID: 1740
		private static readonly IntPtr NativeFieldInfoPtr_backLocKey;

		// Token: 0x040006CD RID: 1741
		private static readonly IntPtr NativeFieldInfoPtr_continueLocKey;

		// Token: 0x040006CE RID: 1742
		private static readonly IntPtr NativeFieldInfoPtr_linkButton;

		// Token: 0x040006CF RID: 1743
		private static readonly IntPtr NativeFieldInfoPtr_linkText;

		// Token: 0x040006D0 RID: 1744
		private static readonly IntPtr NativeFieldInfoPtr_backText;

		// Token: 0x040006D1 RID: 1745
		private static readonly IntPtr NativeFieldInfoPtr_typeName;

		// Token: 0x040006D2 RID: 1746
		private static readonly IntPtr NativeFieldInfoPtr_newsSubpageData;

		// Token: 0x040006D3 RID: 1747
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x040006D4 RID: 1748
		private static readonly IntPtr NativeMethodInfoPtr_Event_LinkClicked_Public_Void_0;

		// Token: 0x040006D5 RID: 1749
		private static readonly IntPtr NativeMethodInfoPtr_Event_Hide_Public_Void_0;

		// Token: 0x040006D6 RID: 1750
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
