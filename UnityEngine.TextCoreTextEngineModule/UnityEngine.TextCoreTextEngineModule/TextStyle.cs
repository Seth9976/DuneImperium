using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x0200003A RID: 58
	[Serializable]
	public class TextStyle : Object
	{
		// Token: 0x060006B4 RID: 1716 RVA: 0x0001AB78 File Offset: 0x00018D78
		// Note: this type is marked as 'beforefieldinit'.
		static TextStyle()
		{
			Il2CppClassPointerStore<TextStyle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "TextStyle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextStyle>.NativeClassPtr);
			TextStyle.NativeFieldInfoPtr_k_NormalStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextStyle>.NativeClassPtr, "k_NormalStyle");
			TextStyle.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextStyle>.NativeClassPtr, "m_Name");
			TextStyle.NativeFieldInfoPtr_m_HashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextStyle>.NativeClassPtr, "m_HashCode");
			TextStyle.NativeFieldInfoPtr_m_OpeningDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextStyle>.NativeClassPtr, "m_OpeningDefinition");
			TextStyle.NativeFieldInfoPtr_m_ClosingDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextStyle>.NativeClassPtr, "m_ClosingDefinition");
			TextStyle.NativeFieldInfoPtr_m_OpeningTagArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextStyle>.NativeClassPtr, "m_OpeningTagArray");
			TextStyle.NativeFieldInfoPtr_m_ClosingTagArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextStyle>.NativeClassPtr, "m_ClosingTagArray");
			TextStyle.NativeFieldInfoPtr_m_OpeningTagUnicodeArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextStyle>.NativeClassPtr, "m_OpeningTagUnicodeArray");
			TextStyle.NativeFieldInfoPtr_m_ClosingTagUnicodeArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextStyle>.NativeClassPtr, "m_ClosingTagUnicodeArray");
			TextStyle.NativeMethodInfoPtr_get_hashCode_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextStyle>.NativeClassPtr, 100663745);
			TextStyle.NativeMethodInfoPtr_get_styleOpeningTagArray_Public_get_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextStyle>.NativeClassPtr, 100663746);
			TextStyle.NativeMethodInfoPtr_get_styleClosingTagArray_Public_get_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextStyle>.NativeClassPtr, 100663747);
			TextStyle.NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextStyle>.NativeClassPtr, 100663748);
			TextStyle.NativeMethodInfoPtr_RefreshStyle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextStyle>.NativeClassPtr, 100663749);
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x060006B5 RID: 1717 RVA: 0x0001ACC0 File Offset: 0x00018EC0
		// (set) Token: 0x060006D0 RID: 1744 RVA: 0x0001B024 File Offset: 0x00019224
		public unsafe int hashCode
		{
			[CallerCount(66)]
			[CachedScanResults(RefRangeStart = 320372, RefRangeEnd = 320438, XrefRangeStart = 320372, XrefRangeEnd = 320438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextStyle.NativeMethodInfoPtr_get_hashCode_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				bool flag = value != this.m_HashCode;
				if (flag)
				{
					this.m_HashCode = value;
				}
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x060006B6 RID: 1718 RVA: 0x0001ACFC File Offset: 0x00018EFC
		public unsafe Il2CppStructArray<uint> styleOpeningTagArray
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextStyle.NativeMethodInfoPtr_get_styleOpeningTagArray_Public_get_Il2CppStructArray_1_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr3) : null;
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x060006B7 RID: 1719 RVA: 0x0001AD3C File Offset: 0x00018F3C
		public unsafe Il2CppStructArray<uint> styleClosingTagArray
		{
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 285338, RefRangeEnd = 285365, XrefRangeStart = 285338, XrefRangeEnd = 285365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextStyle.NativeMethodInfoPtr_get_styleClosingTagArray_Public_get_Il2CppStructArray_1_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr3) : null;
			}
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x0001AD7C File Offset: 0x00018F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106145, XrefRangeEnd = 1106151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextStyle(string styleName, string styleOpeningDefinition, string styleClosingDefinition)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextStyle>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(styleName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(styleOpeningDefinition);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(styleClosingDefinition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextStyle.NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x0001ADEC File Offset: 0x00018FEC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1106173, RefRangeEnd = 1106176, XrefRangeStart = 1106151, XrefRangeEnd = 1106173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshStyle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextStyle.NativeMethodInfoPtr_RefreshStyle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x00005FBE File Offset: 0x000041BE
		public TextStyle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x060006BB RID: 1723 RVA: 0x0001AE20 File Offset: 0x00019020
		// (set) Token: 0x060006BC RID: 1724 RVA: 0x00005FC7 File Offset: 0x000041C7
		public unsafe static TextStyle k_NormalStyle
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextStyle.NativeFieldInfoPtr_k_NormalStyle, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextStyle>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextStyle.NativeFieldInfoPtr_k_NormalStyle, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x060006BD RID: 1725 RVA: 0x0001AE48 File Offset: 0x00019048
		// (set) Token: 0x060006BE RID: 1726 RVA: 0x00005FD9 File Offset: 0x000041D9
		public unsafe string m_Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextStyle.NativeFieldInfoPtr_m_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextStyle.NativeFieldInfoPtr_m_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x060006BF RID: 1727 RVA: 0x0001AE70 File Offset: 0x00019070
		// (set) Token: 0x060006C0 RID: 1728 RVA: 0x00005FF8 File Offset: 0x000041F8
		public unsafe int m_HashCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextStyle.NativeFieldInfoPtr_m_HashCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextStyle.NativeFieldInfoPtr_m_HashCode)) = value;
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x060006C1 RID: 1729 RVA: 0x0001AE98 File Offset: 0x00019098
		// (set) Token: 0x060006C2 RID: 1730 RVA: 0x00006013 File Offset: 0x00004213
		public unsafe string m_OpeningDefinition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextStyle.NativeFieldInfoPtr_m_OpeningDefinition);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextStyle.NativeFieldInfoPtr_m_OpeningDefinition), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x060006C3 RID: 1731 RVA: 0x0001AEC0 File Offset: 0x000190C0
		// (set) Token: 0x060006C4 RID: 1732 RVA: 0x00006032 File Offset: 0x00004232
		public unsafe string m_ClosingDefinition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextStyle.NativeFieldInfoPtr_m_ClosingDefinition);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextStyle.NativeFieldInfoPtr_m_ClosingDefinition), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x060006C5 RID: 1733 RVA: 0x0001AEE8 File Offset: 0x000190E8
		// (set) Token: 0x060006C6 RID: 1734 RVA: 0x00006051 File Offset: 0x00004251
		public unsafe Il2CppStructArray<uint> m_OpeningTagArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextStyle.NativeFieldInfoPtr_m_OpeningTagArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextStyle.NativeFieldInfoPtr_m_OpeningTagArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x060006C7 RID: 1735 RVA: 0x0001AF18 File Offset: 0x00019118
		// (set) Token: 0x060006C8 RID: 1736 RVA: 0x00006070 File Offset: 0x00004270
		public unsafe Il2CppStructArray<uint> m_ClosingTagArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextStyle.NativeFieldInfoPtr_m_ClosingTagArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextStyle.NativeFieldInfoPtr_m_ClosingTagArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x060006C9 RID: 1737 RVA: 0x0001AF48 File Offset: 0x00019148
		// (set) Token: 0x060006CA RID: 1738 RVA: 0x0000608F File Offset: 0x0000428F
		public unsafe Il2CppStructArray<uint> m_OpeningTagUnicodeArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextStyle.NativeFieldInfoPtr_m_OpeningTagUnicodeArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextStyle.NativeFieldInfoPtr_m_OpeningTagUnicodeArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x060006CB RID: 1739 RVA: 0x0001AF78 File Offset: 0x00019178
		// (set) Token: 0x060006CC RID: 1740 RVA: 0x000060AE File Offset: 0x000042AE
		public unsafe Il2CppStructArray<uint> m_ClosingTagUnicodeArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextStyle.NativeFieldInfoPtr_m_ClosingTagUnicodeArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextStyle.NativeFieldInfoPtr_m_ClosingTagUnicodeArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x060006CD RID: 1741 RVA: 0x0001AFA8 File Offset: 0x000191A8
		public static TextStyle NormalStyle
		{
			get
			{
				bool flag = TextStyle.k_NormalStyle == null;
				if (flag)
				{
					TextStyle.k_NormalStyle = new TextStyle("Normal", String.Empty, String.Empty);
				}
				return TextStyle.k_NormalStyle;
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x060006CE RID: 1742 RVA: 0x0001AFE4 File Offset: 0x000191E4
		// (set) Token: 0x060006CF RID: 1743 RVA: 0x0001AFFC File Offset: 0x000191FC
		public string name
		{
			get
			{
				return this.m_Name;
			}
			set
			{
				bool flag = value != this.m_Name;
				if (flag)
				{
					this.m_Name = value;
				}
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x060006D1 RID: 1745 RVA: 0x0001B04C File Offset: 0x0001924C
		public string styleOpeningDefinition
		{
			get
			{
				return this.m_OpeningDefinition;
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x060006D2 RID: 1746 RVA: 0x0001B064 File Offset: 0x00019264
		public string styleClosingDefinition
		{
			get
			{
				return this.m_ClosingDefinition;
			}
		}

		// Token: 0x04000587 RID: 1415
		private static readonly IntPtr NativeFieldInfoPtr_k_NormalStyle;

		// Token: 0x04000588 RID: 1416
		private static readonly IntPtr NativeFieldInfoPtr_m_Name;

		// Token: 0x04000589 RID: 1417
		private static readonly IntPtr NativeFieldInfoPtr_m_HashCode;

		// Token: 0x0400058A RID: 1418
		private static readonly IntPtr NativeFieldInfoPtr_m_OpeningDefinition;

		// Token: 0x0400058B RID: 1419
		private static readonly IntPtr NativeFieldInfoPtr_m_ClosingDefinition;

		// Token: 0x0400058C RID: 1420
		private static readonly IntPtr NativeFieldInfoPtr_m_OpeningTagArray;

		// Token: 0x0400058D RID: 1421
		private static readonly IntPtr NativeFieldInfoPtr_m_ClosingTagArray;

		// Token: 0x0400058E RID: 1422
		private static readonly IntPtr NativeFieldInfoPtr_m_OpeningTagUnicodeArray;

		// Token: 0x0400058F RID: 1423
		private static readonly IntPtr NativeFieldInfoPtr_m_ClosingTagUnicodeArray;

		// Token: 0x04000590 RID: 1424
		private static readonly IntPtr NativeMethodInfoPtr_get_hashCode_Public_get_Int32_0;

		// Token: 0x04000591 RID: 1425
		private static readonly IntPtr NativeMethodInfoPtr_get_styleOpeningTagArray_Public_get_Il2CppStructArray_1_UInt32_0;

		// Token: 0x04000592 RID: 1426
		private static readonly IntPtr NativeMethodInfoPtr_get_styleClosingTagArray_Public_get_Il2CppStructArray_1_UInt32_0;

		// Token: 0x04000593 RID: 1427
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_0;

		// Token: 0x04000594 RID: 1428
		private static readonly IntPtr NativeMethodInfoPtr_RefreshStyle_Public_Void_0;
	}
}
