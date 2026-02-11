using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000F3 RID: 243
	public class OrInstruction : Instruction
	{
		// Token: 0x06000ECF RID: 3791 RVA: 0x00050324 File Offset: 0x0004E524
		// Note: this type is marked as 'beforefieldinit'.
		static OrInstruction()
		{
			Il2CppClassPointerStore<OrInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "OrInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrInstruction>.NativeClassPtr);
			OrInstruction.NativeFieldInfoPtr_s_SByte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrInstruction>.NativeClassPtr, "s_SByte");
			OrInstruction.NativeFieldInfoPtr_s_Int16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrInstruction>.NativeClassPtr, "s_Int16");
			OrInstruction.NativeFieldInfoPtr_s_Int32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrInstruction>.NativeClassPtr, "s_Int32");
			OrInstruction.NativeFieldInfoPtr_s_Int64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrInstruction>.NativeClassPtr, "s_Int64");
			OrInstruction.NativeFieldInfoPtr_s_Byte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrInstruction>.NativeClassPtr, "s_Byte");
			OrInstruction.NativeFieldInfoPtr_s_UInt16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrInstruction>.NativeClassPtr, "s_UInt16");
			OrInstruction.NativeFieldInfoPtr_s_UInt32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrInstruction>.NativeClassPtr, "s_UInt32");
			OrInstruction.NativeFieldInfoPtr_s_UInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrInstruction>.NativeClassPtr, "s_UInt64");
			OrInstruction.NativeFieldInfoPtr_s_Boolean = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrInstruction>.NativeClassPtr, "s_Boolean");
			OrInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrInstruction>.NativeClassPtr, 100666054);
			OrInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrInstruction>.NativeClassPtr, 100666055);
			OrInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrInstruction>.NativeClassPtr, 100666056);
			OrInstruction.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrInstruction>.NativeClassPtr, 100666057);
			OrInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrInstruction>.NativeClassPtr, 100666058);
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06000ED0 RID: 3792 RVA: 0x0005046C File Offset: 0x0004E66C
		public unsafe override int ConsumedStack
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 72978, RefRangeEnd = 72985, XrefRangeStart = 72978, XrefRangeEnd = 72985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OrInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06000ED1 RID: 3793 RVA: 0x000504B4 File Offset: 0x0004E6B4
		public unsafe override int ProducedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OrInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06000ED2 RID: 3794 RVA: 0x000504FC File Offset: 0x0004E6FC
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026167, XrefRangeEnd = 1026169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OrInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000ED3 RID: 3795 RVA: 0x00050540 File Offset: 0x0004E740
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OrInstruction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrInstruction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrInstruction.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x0005057C File Offset: 0x0004E77C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1026194, RefRangeEnd = 1026195, XrefRangeStart = 1026169, XrefRangeEnd = 1026194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Instruction Create(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x06000ED5 RID: 3797 RVA: 0x000068E3 File Offset: 0x00004AE3
		public OrInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06000ED6 RID: 3798 RVA: 0x000505C0 File Offset: 0x0004E7C0
		// (set) Token: 0x06000ED7 RID: 3799 RVA: 0x000068EC File Offset: 0x00004AEC
		public unsafe static Instruction s_SByte
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(OrInstruction.NativeFieldInfoPtr_s_SByte, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OrInstruction.NativeFieldInfoPtr_s_SByte, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06000ED8 RID: 3800 RVA: 0x000505E8 File Offset: 0x0004E7E8
		// (set) Token: 0x06000ED9 RID: 3801 RVA: 0x000068FE File Offset: 0x00004AFE
		public unsafe static Instruction s_Int16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(OrInstruction.NativeFieldInfoPtr_s_Int16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OrInstruction.NativeFieldInfoPtr_s_Int16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06000EDA RID: 3802 RVA: 0x00050610 File Offset: 0x0004E810
		// (set) Token: 0x06000EDB RID: 3803 RVA: 0x00006910 File Offset: 0x00004B10
		public unsafe static Instruction s_Int32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(OrInstruction.NativeFieldInfoPtr_s_Int32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OrInstruction.NativeFieldInfoPtr_s_Int32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06000EDC RID: 3804 RVA: 0x00050638 File Offset: 0x0004E838
		// (set) Token: 0x06000EDD RID: 3805 RVA: 0x00006922 File Offset: 0x00004B22
		public unsafe static Instruction s_Int64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(OrInstruction.NativeFieldInfoPtr_s_Int64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OrInstruction.NativeFieldInfoPtr_s_Int64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06000EDE RID: 3806 RVA: 0x00050660 File Offset: 0x0004E860
		// (set) Token: 0x06000EDF RID: 3807 RVA: 0x00006934 File Offset: 0x00004B34
		public unsafe static Instruction s_Byte
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(OrInstruction.NativeFieldInfoPtr_s_Byte, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OrInstruction.NativeFieldInfoPtr_s_Byte, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06000EE0 RID: 3808 RVA: 0x00050688 File Offset: 0x0004E888
		// (set) Token: 0x06000EE1 RID: 3809 RVA: 0x00006946 File Offset: 0x00004B46
		public unsafe static Instruction s_UInt16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(OrInstruction.NativeFieldInfoPtr_s_UInt16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OrInstruction.NativeFieldInfoPtr_s_UInt16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06000EE2 RID: 3810 RVA: 0x000506B0 File Offset: 0x0004E8B0
		// (set) Token: 0x06000EE3 RID: 3811 RVA: 0x00006958 File Offset: 0x00004B58
		public unsafe static Instruction s_UInt32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(OrInstruction.NativeFieldInfoPtr_s_UInt32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OrInstruction.NativeFieldInfoPtr_s_UInt32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06000EE4 RID: 3812 RVA: 0x000506D8 File Offset: 0x0004E8D8
		// (set) Token: 0x06000EE5 RID: 3813 RVA: 0x0000696A File Offset: 0x00004B6A
		public unsafe static Instruction s_UInt64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(OrInstruction.NativeFieldInfoPtr_s_UInt64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OrInstruction.NativeFieldInfoPtr_s_UInt64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06000EE6 RID: 3814 RVA: 0x00050700 File Offset: 0x0004E900
		// (set) Token: 0x06000EE7 RID: 3815 RVA: 0x0000697C File Offset: 0x00004B7C
		public unsafe static Instruction s_Boolean
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(OrInstruction.NativeFieldInfoPtr_s_Boolean, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OrInstruction.NativeFieldInfoPtr_s_Boolean, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AC4 RID: 2756
		private static readonly IntPtr NativeFieldInfoPtr_s_SByte;

		// Token: 0x04000AC5 RID: 2757
		private static readonly IntPtr NativeFieldInfoPtr_s_Int16;

		// Token: 0x04000AC6 RID: 2758
		private static readonly IntPtr NativeFieldInfoPtr_s_Int32;

		// Token: 0x04000AC7 RID: 2759
		private static readonly IntPtr NativeFieldInfoPtr_s_Int64;

		// Token: 0x04000AC8 RID: 2760
		private static readonly IntPtr NativeFieldInfoPtr_s_Byte;

		// Token: 0x04000AC9 RID: 2761
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt16;

		// Token: 0x04000ACA RID: 2762
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt32;

		// Token: 0x04000ACB RID: 2763
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt64;

		// Token: 0x04000ACC RID: 2764
		private static readonly IntPtr NativeFieldInfoPtr_s_Boolean;

		// Token: 0x04000ACD RID: 2765
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000ACE RID: 2766
		private static readonly IntPtr NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000ACF RID: 2767
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x04000AD0 RID: 2768
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000AD1 RID: 2769
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0;

		// Token: 0x02000302 RID: 770
		public sealed class OrSByte : OrInstruction
		{
			// Token: 0x06001A77 RID: 6775 RVA: 0x0007EBE4 File Offset: 0x0007CDE4
			// Note: this type is marked as 'beforefieldinit'.
			static OrSByte()
			{
				Il2CppClassPointerStore<OrInstruction.OrSByte>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OrInstruction>.NativeClassPtr, "OrSByte");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrInstruction.OrSByte>.NativeClassPtr);
				OrInstruction.OrSByte.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrInstruction.OrSByte>.NativeClassPtr, 100666059);
				OrInstruction.OrSByte.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrInstruction.OrSByte>.NativeClassPtr, 100666060);
			}

			// Token: 0x06001A78 RID: 6776 RVA: 0x0007EC38 File Offset: 0x0007CE38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026088, XrefRangeEnd = 1026096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrInstruction.OrSByte.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001A79 RID: 6777 RVA: 0x0007EC88 File Offset: 0x0007CE88
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OrSByte()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrInstruction.OrSByte>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrInstruction.OrSByte.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A7A RID: 6778 RVA: 0x0000A396 File Offset: 0x00008596
			public OrSByte(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001202 RID: 4610
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001203 RID: 4611
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000303 RID: 771
		public sealed class OrInt16 : OrInstruction
		{
			// Token: 0x06001A7B RID: 6779 RVA: 0x0007ECC4 File Offset: 0x0007CEC4
			// Note: this type is marked as 'beforefieldinit'.
			static OrInt16()
			{
				Il2CppClassPointerStore<OrInstruction.OrInt16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OrInstruction>.NativeClassPtr, "OrInt16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrInstruction.OrInt16>.NativeClassPtr);
				OrInstruction.OrInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrInstruction.OrInt16>.NativeClassPtr, 100666061);
				OrInstruction.OrInt16.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrInstruction.OrInt16>.NativeClassPtr, 100666062);
			}

			// Token: 0x06001A7C RID: 6780 RVA: 0x0007ED18 File Offset: 0x0007CF18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026096, XrefRangeEnd = 1026104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrInstruction.OrInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001A7D RID: 6781 RVA: 0x0007ED68 File Offset: 0x0007CF68
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OrInt16()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrInstruction.OrInt16>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrInstruction.OrInt16.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A7E RID: 6782 RVA: 0x0000A39F File Offset: 0x0000859F
			public OrInt16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001204 RID: 4612
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001205 RID: 4613
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000304 RID: 772
		public sealed class OrInt32 : OrInstruction
		{
			// Token: 0x06001A7F RID: 6783 RVA: 0x0007EDA4 File Offset: 0x0007CFA4
			// Note: this type is marked as 'beforefieldinit'.
			static OrInt32()
			{
				Il2CppClassPointerStore<OrInstruction.OrInt32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OrInstruction>.NativeClassPtr, "OrInt32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrInstruction.OrInt32>.NativeClassPtr);
				OrInstruction.OrInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrInstruction.OrInt32>.NativeClassPtr, 100666063);
				OrInstruction.OrInt32.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrInstruction.OrInt32>.NativeClassPtr, 100666064);
			}

			// Token: 0x06001A80 RID: 6784 RVA: 0x0007EDF8 File Offset: 0x0007CFF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026104, XrefRangeEnd = 1026112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrInstruction.OrInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001A81 RID: 6785 RVA: 0x0007EE48 File Offset: 0x0007D048
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OrInt32()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrInstruction.OrInt32>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrInstruction.OrInt32.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A82 RID: 6786 RVA: 0x0000A3A8 File Offset: 0x000085A8
			public OrInt32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001206 RID: 4614
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001207 RID: 4615
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000305 RID: 773
		public sealed class OrInt64 : OrInstruction
		{
			// Token: 0x06001A83 RID: 6787 RVA: 0x0007EE84 File Offset: 0x0007D084
			// Note: this type is marked as 'beforefieldinit'.
			static OrInt64()
			{
				Il2CppClassPointerStore<OrInstruction.OrInt64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OrInstruction>.NativeClassPtr, "OrInt64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrInstruction.OrInt64>.NativeClassPtr);
				OrInstruction.OrInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrInstruction.OrInt64>.NativeClassPtr, 100666065);
				OrInstruction.OrInt64.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrInstruction.OrInt64>.NativeClassPtr, 100666066);
			}

			// Token: 0x06001A84 RID: 6788 RVA: 0x0007EED8 File Offset: 0x0007D0D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026112, XrefRangeEnd = 1026122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrInstruction.OrInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001A85 RID: 6789 RVA: 0x0007EF28 File Offset: 0x0007D128
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OrInt64()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrInstruction.OrInt64>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrInstruction.OrInt64.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A86 RID: 6790 RVA: 0x0000A3B1 File Offset: 0x000085B1
			public OrInt64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001208 RID: 4616
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001209 RID: 4617
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000306 RID: 774
		public sealed class OrByte : OrInstruction
		{
			// Token: 0x06001A87 RID: 6791 RVA: 0x0007EF64 File Offset: 0x0007D164
			// Note: this type is marked as 'beforefieldinit'.
			static OrByte()
			{
				Il2CppClassPointerStore<OrInstruction.OrByte>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OrInstruction>.NativeClassPtr, "OrByte");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrInstruction.OrByte>.NativeClassPtr);
				OrInstruction.OrByte.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrInstruction.OrByte>.NativeClassPtr, 100666067);
				OrInstruction.OrByte.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrInstruction.OrByte>.NativeClassPtr, 100666068);
			}

			// Token: 0x06001A88 RID: 6792 RVA: 0x0007EFB8 File Offset: 0x0007D1B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026122, XrefRangeEnd = 1026130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrInstruction.OrByte.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001A89 RID: 6793 RVA: 0x0007F008 File Offset: 0x0007D208
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OrByte()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrInstruction.OrByte>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrInstruction.OrByte.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A8A RID: 6794 RVA: 0x0000A3BA File Offset: 0x000085BA
			public OrByte(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400120A RID: 4618
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x0400120B RID: 4619
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000307 RID: 775
		public sealed class OrUInt16 : OrInstruction
		{
			// Token: 0x06001A8B RID: 6795 RVA: 0x0007F044 File Offset: 0x0007D244
			// Note: this type is marked as 'beforefieldinit'.
			static OrUInt16()
			{
				Il2CppClassPointerStore<OrInstruction.OrUInt16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OrInstruction>.NativeClassPtr, "OrUInt16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrInstruction.OrUInt16>.NativeClassPtr);
				OrInstruction.OrUInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrInstruction.OrUInt16>.NativeClassPtr, 100666069);
				OrInstruction.OrUInt16.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrInstruction.OrUInt16>.NativeClassPtr, 100666070);
			}

			// Token: 0x06001A8C RID: 6796 RVA: 0x0007F098 File Offset: 0x0007D298
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026130, XrefRangeEnd = 1026138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrInstruction.OrUInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001A8D RID: 6797 RVA: 0x0007F0E8 File Offset: 0x0007D2E8
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OrUInt16()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrInstruction.OrUInt16>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrInstruction.OrUInt16.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A8E RID: 6798 RVA: 0x0000A3C3 File Offset: 0x000085C3
			public OrUInt16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400120C RID: 4620
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x0400120D RID: 4621
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000308 RID: 776
		public sealed class OrUInt32 : OrInstruction
		{
			// Token: 0x06001A8F RID: 6799 RVA: 0x0007F124 File Offset: 0x0007D324
			// Note: this type is marked as 'beforefieldinit'.
			static OrUInt32()
			{
				Il2CppClassPointerStore<OrInstruction.OrUInt32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OrInstruction>.NativeClassPtr, "OrUInt32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrInstruction.OrUInt32>.NativeClassPtr);
				OrInstruction.OrUInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrInstruction.OrUInt32>.NativeClassPtr, 100666071);
				OrInstruction.OrUInt32.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrInstruction.OrUInt32>.NativeClassPtr, 100666072);
			}

			// Token: 0x06001A90 RID: 6800 RVA: 0x0007F178 File Offset: 0x0007D378
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026138, XrefRangeEnd = 1026148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrInstruction.OrUInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001A91 RID: 6801 RVA: 0x0007F1C8 File Offset: 0x0007D3C8
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OrUInt32()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrInstruction.OrUInt32>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrInstruction.OrUInt32.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A92 RID: 6802 RVA: 0x0000A3CC File Offset: 0x000085CC
			public OrUInt32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400120E RID: 4622
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x0400120F RID: 4623
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000309 RID: 777
		public sealed class OrUInt64 : OrInstruction
		{
			// Token: 0x06001A93 RID: 6803 RVA: 0x0007F204 File Offset: 0x0007D404
			// Note: this type is marked as 'beforefieldinit'.
			static OrUInt64()
			{
				Il2CppClassPointerStore<OrInstruction.OrUInt64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OrInstruction>.NativeClassPtr, "OrUInt64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrInstruction.OrUInt64>.NativeClassPtr);
				OrInstruction.OrUInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrInstruction.OrUInt64>.NativeClassPtr, 100666073);
				OrInstruction.OrUInt64.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrInstruction.OrUInt64>.NativeClassPtr, 100666074);
			}

			// Token: 0x06001A94 RID: 6804 RVA: 0x0007F258 File Offset: 0x0007D458
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026148, XrefRangeEnd = 1026158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrInstruction.OrUInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001A95 RID: 6805 RVA: 0x0007F2A8 File Offset: 0x0007D4A8
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OrUInt64()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrInstruction.OrUInt64>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrInstruction.OrUInt64.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A96 RID: 6806 RVA: 0x0000A3D5 File Offset: 0x000085D5
			public OrUInt64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001210 RID: 4624
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001211 RID: 4625
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200030A RID: 778
		public sealed class OrBoolean : OrInstruction
		{
			// Token: 0x06001A97 RID: 6807 RVA: 0x0007F2E4 File Offset: 0x0007D4E4
			// Note: this type is marked as 'beforefieldinit'.
			static OrBoolean()
			{
				Il2CppClassPointerStore<OrInstruction.OrBoolean>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OrInstruction>.NativeClassPtr, "OrBoolean");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrInstruction.OrBoolean>.NativeClassPtr);
				OrInstruction.OrBoolean.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrInstruction.OrBoolean>.NativeClassPtr, 100666075);
				OrInstruction.OrBoolean.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrInstruction.OrBoolean>.NativeClassPtr, 100666076);
			}

			// Token: 0x06001A98 RID: 6808 RVA: 0x0007F338 File Offset: 0x0007D538
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026158, XrefRangeEnd = 1026167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrInstruction.OrBoolean.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001A99 RID: 6809 RVA: 0x0007F388 File Offset: 0x0007D588
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OrBoolean()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrInstruction.OrBoolean>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrInstruction.OrBoolean.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A9A RID: 6810 RVA: 0x0000A3DE File Offset: 0x000085DE
			public OrBoolean(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001212 RID: 4626
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001213 RID: 4627
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
