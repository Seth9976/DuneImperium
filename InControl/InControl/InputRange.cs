using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace InControl
{
	// Token: 0x0200002C RID: 44
	[Serializable]
	[StructLayout(2)]
	public struct InputRange
	{
		// Token: 0x060002DD RID: 733 RVA: 0x00012350 File Offset: 0x00010550
		// Note: this type is marked as 'beforefieldinit'.
		static InputRange()
		{
			Il2CppClassPointerStore<InputRange>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "InputRange");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputRange>.NativeClassPtr);
			InputRange.NativeFieldInfoPtr_None = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRange>.NativeClassPtr, "None");
			InputRange.NativeFieldInfoPtr_MinusOneToOne = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRange>.NativeClassPtr, "MinusOneToOne");
			InputRange.NativeFieldInfoPtr_OneToMinusOne = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRange>.NativeClassPtr, "OneToMinusOne");
			InputRange.NativeFieldInfoPtr_ZeroToOne = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRange>.NativeClassPtr, "ZeroToOne");
			InputRange.NativeFieldInfoPtr_ZeroToMinusOne = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRange>.NativeClassPtr, "ZeroToMinusOne");
			InputRange.NativeFieldInfoPtr_OneToZero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRange>.NativeClassPtr, "OneToZero");
			InputRange.NativeFieldInfoPtr_MinusOneToZero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRange>.NativeClassPtr, "MinusOneToZero");
			InputRange.NativeFieldInfoPtr_typeToRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRange>.NativeClassPtr, "typeToRange");
			InputRange.NativeFieldInfoPtr_Value0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRange>.NativeClassPtr, "Value0");
			InputRange.NativeFieldInfoPtr_Value1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRange>.NativeClassPtr, "Value1");
			InputRange.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRange>.NativeClassPtr, "Type");
			InputRange.NativeMethodInfoPtr__ctor_Private_Void_Single_Single_InputRangeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputRange>.NativeClassPtr, 100663698);
			InputRange.NativeMethodInfoPtr__ctor_Public_Void_InputRangeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputRange>.NativeClassPtr, 100663699);
			InputRange.NativeMethodInfoPtr_Includes_Public_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputRange>.NativeClassPtr, 100663700);
			InputRange.NativeMethodInfoPtr_Excludes_Private_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputRange>.NativeClassPtr, 100663701);
			InputRange.NativeMethodInfoPtr_Excludes_Public_Static_Boolean_InputRangeType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputRange>.NativeClassPtr, 100663702);
			InputRange.NativeMethodInfoPtr_Remap_Private_Static_Single_Single_InputRange_InputRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputRange>.NativeClassPtr, 100663703);
			InputRange.NativeMethodInfoPtr_Remap_Public_Static_Single_Single_InputRangeType_InputRangeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputRange>.NativeClassPtr, 100663704);
		}

		// Token: 0x060002DE RID: 734 RVA: 0x000124E8 File Offset: 0x000106E8
		[CallerCount(0)]
		public unsafe InputRange(float value0, float value1, InputRangeType type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputRange.NativeMethodInfoPtr__ctor_Private_Void_Single_Single_InputRangeType_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00012538 File Offset: 0x00010738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 773279, XrefRangeEnd = 773284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputRange(InputRangeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputRange.NativeMethodInfoPtr__ctor_Public_Void_InputRangeType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0001256C File Offset: 0x0001076C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 773284, XrefRangeEnd = 773287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Includes(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputRange.NativeMethodInfoPtr_Includes_Public_Boolean_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x000125AC File Offset: 0x000107AC
		[CallerCount(0)]
		public unsafe bool Excludes(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputRange.NativeMethodInfoPtr_Excludes_Private_Boolean_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x000125EC File Offset: 0x000107EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 773287, XrefRangeEnd = 773291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Excludes(InputRangeType rangeType, float value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rangeType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputRange.NativeMethodInfoPtr_Excludes_Public_Static_Boolean_InputRangeType_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00012638 File Offset: 0x00010838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 773291, XrefRangeEnd = 773294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Remap(float value, InputRange sourceRange, InputRange targetRange)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceRange;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetRange;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputRange.NativeMethodInfoPtr_Remap_Private_Static_Single_Single_InputRange_InputRange_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00012694 File Offset: 0x00010894
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 773303, RefRangeEnd = 773307, XrefRangeStart = 773294, XrefRangeEnd = 773303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Remap(float value, InputRangeType sourceRangeType, InputRangeType targetRangeType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceRangeType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetRangeType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputRange.NativeMethodInfoPtr_Remap_Public_Static_Single_Single_InputRangeType_InputRangeType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0000306E File Offset: 0x0000126E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputRange>.NativeClassPtr, ref this));
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x000126F0 File Offset: 0x000108F0
		// (set) Token: 0x060002E7 RID: 743 RVA: 0x00003080 File Offset: 0x00001280
		public unsafe static InputRange None
		{
			get
			{
				InputRange inputRange;
				IL2CPP.il2cpp_field_static_get_value(InputRange.NativeFieldInfoPtr_None, (void*)(&inputRange));
				return inputRange;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputRange.NativeFieldInfoPtr_None, (void*)(&value));
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x0001270C File Offset: 0x0001090C
		// (set) Token: 0x060002E9 RID: 745 RVA: 0x0000308E File Offset: 0x0000128E
		public unsafe static InputRange MinusOneToOne
		{
			get
			{
				InputRange inputRange;
				IL2CPP.il2cpp_field_static_get_value(InputRange.NativeFieldInfoPtr_MinusOneToOne, (void*)(&inputRange));
				return inputRange;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputRange.NativeFieldInfoPtr_MinusOneToOne, (void*)(&value));
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060002EA RID: 746 RVA: 0x00012728 File Offset: 0x00010928
		// (set) Token: 0x060002EB RID: 747 RVA: 0x0000309C File Offset: 0x0000129C
		public unsafe static InputRange OneToMinusOne
		{
			get
			{
				InputRange inputRange;
				IL2CPP.il2cpp_field_static_get_value(InputRange.NativeFieldInfoPtr_OneToMinusOne, (void*)(&inputRange));
				return inputRange;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputRange.NativeFieldInfoPtr_OneToMinusOne, (void*)(&value));
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060002EC RID: 748 RVA: 0x00012744 File Offset: 0x00010944
		// (set) Token: 0x060002ED RID: 749 RVA: 0x000030AA File Offset: 0x000012AA
		public unsafe static InputRange ZeroToOne
		{
			get
			{
				InputRange inputRange;
				IL2CPP.il2cpp_field_static_get_value(InputRange.NativeFieldInfoPtr_ZeroToOne, (void*)(&inputRange));
				return inputRange;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputRange.NativeFieldInfoPtr_ZeroToOne, (void*)(&value));
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060002EE RID: 750 RVA: 0x00012760 File Offset: 0x00010960
		// (set) Token: 0x060002EF RID: 751 RVA: 0x000030B8 File Offset: 0x000012B8
		public unsafe static InputRange ZeroToMinusOne
		{
			get
			{
				InputRange inputRange;
				IL2CPP.il2cpp_field_static_get_value(InputRange.NativeFieldInfoPtr_ZeroToMinusOne, (void*)(&inputRange));
				return inputRange;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputRange.NativeFieldInfoPtr_ZeroToMinusOne, (void*)(&value));
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x0001277C File Offset: 0x0001097C
		// (set) Token: 0x060002F1 RID: 753 RVA: 0x000030C6 File Offset: 0x000012C6
		public unsafe static InputRange OneToZero
		{
			get
			{
				InputRange inputRange;
				IL2CPP.il2cpp_field_static_get_value(InputRange.NativeFieldInfoPtr_OneToZero, (void*)(&inputRange));
				return inputRange;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputRange.NativeFieldInfoPtr_OneToZero, (void*)(&value));
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060002F2 RID: 754 RVA: 0x00012798 File Offset: 0x00010998
		// (set) Token: 0x060002F3 RID: 755 RVA: 0x000030D4 File Offset: 0x000012D4
		public unsafe static InputRange MinusOneToZero
		{
			get
			{
				InputRange inputRange;
				IL2CPP.il2cpp_field_static_get_value(InputRange.NativeFieldInfoPtr_MinusOneToZero, (void*)(&inputRange));
				return inputRange;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputRange.NativeFieldInfoPtr_MinusOneToZero, (void*)(&value));
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x000127B4 File Offset: 0x000109B4
		// (set) Token: 0x060002F5 RID: 757 RVA: 0x000030E2 File Offset: 0x000012E2
		public unsafe static Il2CppStructArray<InputRange> typeToRange
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InputRange.NativeFieldInfoPtr_typeToRange, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<InputRange>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputRange.NativeFieldInfoPtr_typeToRange, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003A4 RID: 932
		private static readonly IntPtr NativeFieldInfoPtr_None;

		// Token: 0x040003A5 RID: 933
		private static readonly IntPtr NativeFieldInfoPtr_MinusOneToOne;

		// Token: 0x040003A6 RID: 934
		private static readonly IntPtr NativeFieldInfoPtr_OneToMinusOne;

		// Token: 0x040003A7 RID: 935
		private static readonly IntPtr NativeFieldInfoPtr_ZeroToOne;

		// Token: 0x040003A8 RID: 936
		private static readonly IntPtr NativeFieldInfoPtr_ZeroToMinusOne;

		// Token: 0x040003A9 RID: 937
		private static readonly IntPtr NativeFieldInfoPtr_OneToZero;

		// Token: 0x040003AA RID: 938
		private static readonly IntPtr NativeFieldInfoPtr_MinusOneToZero;

		// Token: 0x040003AB RID: 939
		private static readonly IntPtr NativeFieldInfoPtr_typeToRange;

		// Token: 0x040003AC RID: 940
		private static readonly IntPtr NativeFieldInfoPtr_Value0;

		// Token: 0x040003AD RID: 941
		private static readonly IntPtr NativeFieldInfoPtr_Value1;

		// Token: 0x040003AE RID: 942
		private static readonly IntPtr NativeFieldInfoPtr_Type;

		// Token: 0x040003AF RID: 943
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Single_Single_InputRangeType_0;

		// Token: 0x040003B0 RID: 944
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_InputRangeType_0;

		// Token: 0x040003B1 RID: 945
		private static readonly IntPtr NativeMethodInfoPtr_Includes_Public_Boolean_Single_0;

		// Token: 0x040003B2 RID: 946
		private static readonly IntPtr NativeMethodInfoPtr_Excludes_Private_Boolean_Single_0;

		// Token: 0x040003B3 RID: 947
		private static readonly IntPtr NativeMethodInfoPtr_Excludes_Public_Static_Boolean_InputRangeType_Single_0;

		// Token: 0x040003B4 RID: 948
		private static readonly IntPtr NativeMethodInfoPtr_Remap_Private_Static_Single_Single_InputRange_InputRange_0;

		// Token: 0x040003B5 RID: 949
		private static readonly IntPtr NativeMethodInfoPtr_Remap_Public_Static_Single_Single_InputRangeType_InputRangeType_0;

		// Token: 0x040003B6 RID: 950
		[FieldOffset(0)]
		public readonly float Value0;

		// Token: 0x040003B7 RID: 951
		[FieldOffset(4)]
		public readonly float Value1;

		// Token: 0x040003B8 RID: 952
		[FieldOffset(8)]
		public readonly InputRangeType Type;
	}
}
