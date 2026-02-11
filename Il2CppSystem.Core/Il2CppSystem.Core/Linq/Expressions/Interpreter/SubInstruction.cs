using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000FA RID: 250
	public class SubInstruction : Instruction
	{
		// Token: 0x06000F28 RID: 3880 RVA: 0x00051458 File Offset: 0x0004F658
		// Note: this type is marked as 'beforefieldinit'.
		static SubInstruction()
		{
			Il2CppClassPointerStore<SubInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "SubInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubInstruction>.NativeClassPtr);
			SubInstruction.NativeFieldInfoPtr_s_Int16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubInstruction>.NativeClassPtr, "s_Int16");
			SubInstruction.NativeFieldInfoPtr_s_Int32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubInstruction>.NativeClassPtr, "s_Int32");
			SubInstruction.NativeFieldInfoPtr_s_Int64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubInstruction>.NativeClassPtr, "s_Int64");
			SubInstruction.NativeFieldInfoPtr_s_UInt16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubInstruction>.NativeClassPtr, "s_UInt16");
			SubInstruction.NativeFieldInfoPtr_s_UInt32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubInstruction>.NativeClassPtr, "s_UInt32");
			SubInstruction.NativeFieldInfoPtr_s_UInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubInstruction>.NativeClassPtr, "s_UInt64");
			SubInstruction.NativeFieldInfoPtr_s_Single = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubInstruction>.NativeClassPtr, "s_Single");
			SubInstruction.NativeFieldInfoPtr_s_Double = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubInstruction>.NativeClassPtr, "s_Double");
			SubInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubInstruction>.NativeClassPtr, 100666121);
			SubInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubInstruction>.NativeClassPtr, 100666122);
			SubInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubInstruction>.NativeClassPtr, 100666123);
			SubInstruction.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubInstruction>.NativeClassPtr, 100666124);
			SubInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubInstruction>.NativeClassPtr, 100666125);
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06000F29 RID: 3881 RVA: 0x0005158C File Offset: 0x0004F78C
		public unsafe override int ConsumedStack
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 72978, RefRangeEnd = 72985, XrefRangeStart = 72978, XrefRangeEnd = 72985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SubInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06000F2A RID: 3882 RVA: 0x000515D4 File Offset: 0x0004F7D4
		public unsafe override int ProducedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SubInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06000F2B RID: 3883 RVA: 0x0005161C File Offset: 0x0004F81C
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026374, XrefRangeEnd = 1026376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SubInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x00051660 File Offset: 0x0004F860
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SubInstruction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubInstruction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubInstruction.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x0005169C File Offset: 0x0004F89C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1026400, RefRangeEnd = 1026402, XrefRangeStart = 1026376, XrefRangeEnd = 1026400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Instruction Create(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x06000F2E RID: 3886 RVA: 0x00006AD1 File Offset: 0x00004CD1
		public SubInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06000F2F RID: 3887 RVA: 0x000516E0 File Offset: 0x0004F8E0
		// (set) Token: 0x06000F30 RID: 3888 RVA: 0x00006ADA File Offset: 0x00004CDA
		public unsafe static Instruction s_Int16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SubInstruction.NativeFieldInfoPtr_s_Int16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SubInstruction.NativeFieldInfoPtr_s_Int16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06000F31 RID: 3889 RVA: 0x00051708 File Offset: 0x0004F908
		// (set) Token: 0x06000F32 RID: 3890 RVA: 0x00006AEC File Offset: 0x00004CEC
		public unsafe static Instruction s_Int32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SubInstruction.NativeFieldInfoPtr_s_Int32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SubInstruction.NativeFieldInfoPtr_s_Int32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06000F33 RID: 3891 RVA: 0x00051730 File Offset: 0x0004F930
		// (set) Token: 0x06000F34 RID: 3892 RVA: 0x00006AFE File Offset: 0x00004CFE
		public unsafe static Instruction s_Int64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SubInstruction.NativeFieldInfoPtr_s_Int64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SubInstruction.NativeFieldInfoPtr_s_Int64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06000F35 RID: 3893 RVA: 0x00051758 File Offset: 0x0004F958
		// (set) Token: 0x06000F36 RID: 3894 RVA: 0x00006B10 File Offset: 0x00004D10
		public unsafe static Instruction s_UInt16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SubInstruction.NativeFieldInfoPtr_s_UInt16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SubInstruction.NativeFieldInfoPtr_s_UInt16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06000F37 RID: 3895 RVA: 0x00051780 File Offset: 0x0004F980
		// (set) Token: 0x06000F38 RID: 3896 RVA: 0x00006B22 File Offset: 0x00004D22
		public unsafe static Instruction s_UInt32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SubInstruction.NativeFieldInfoPtr_s_UInt32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SubInstruction.NativeFieldInfoPtr_s_UInt32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06000F39 RID: 3897 RVA: 0x000517A8 File Offset: 0x0004F9A8
		// (set) Token: 0x06000F3A RID: 3898 RVA: 0x00006B34 File Offset: 0x00004D34
		public unsafe static Instruction s_UInt64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SubInstruction.NativeFieldInfoPtr_s_UInt64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SubInstruction.NativeFieldInfoPtr_s_UInt64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06000F3B RID: 3899 RVA: 0x000517D0 File Offset: 0x0004F9D0
		// (set) Token: 0x06000F3C RID: 3900 RVA: 0x00006B46 File Offset: 0x00004D46
		public unsafe static Instruction s_Single
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SubInstruction.NativeFieldInfoPtr_s_Single, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SubInstruction.NativeFieldInfoPtr_s_Single, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06000F3D RID: 3901 RVA: 0x000517F8 File Offset: 0x0004F9F8
		// (set) Token: 0x06000F3E RID: 3902 RVA: 0x00006B58 File Offset: 0x00004D58
		public unsafe static Instruction s_Double
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SubInstruction.NativeFieldInfoPtr_s_Double, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SubInstruction.NativeFieldInfoPtr_s_Double, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AF9 RID: 2809
		private static readonly IntPtr NativeFieldInfoPtr_s_Int16;

		// Token: 0x04000AFA RID: 2810
		private static readonly IntPtr NativeFieldInfoPtr_s_Int32;

		// Token: 0x04000AFB RID: 2811
		private static readonly IntPtr NativeFieldInfoPtr_s_Int64;

		// Token: 0x04000AFC RID: 2812
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt16;

		// Token: 0x04000AFD RID: 2813
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt32;

		// Token: 0x04000AFE RID: 2814
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt64;

		// Token: 0x04000AFF RID: 2815
		private static readonly IntPtr NativeFieldInfoPtr_s_Single;

		// Token: 0x04000B00 RID: 2816
		private static readonly IntPtr NativeFieldInfoPtr_s_Double;

		// Token: 0x04000B01 RID: 2817
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000B02 RID: 2818
		private static readonly IntPtr NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000B03 RID: 2819
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x04000B04 RID: 2820
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000B05 RID: 2821
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0;

		// Token: 0x02000313 RID: 787
		public sealed class SubInt16 : SubInstruction
		{
			// Token: 0x06001ABB RID: 6843 RVA: 0x0007FAC4 File Offset: 0x0007DCC4
			// Note: this type is marked as 'beforefieldinit'.
			static SubInt16()
			{
				Il2CppClassPointerStore<SubInstruction.SubInt16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubInstruction>.NativeClassPtr, "SubInt16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubInstruction.SubInt16>.NativeClassPtr);
				SubInstruction.SubInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubInstruction.SubInt16>.NativeClassPtr, 100666126);
				SubInstruction.SubInt16.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubInstruction.SubInt16>.NativeClassPtr, 100666127);
			}

			// Token: 0x06001ABC RID: 6844 RVA: 0x0007FB18 File Offset: 0x0007DD18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026358, XrefRangeEnd = 1026360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubInstruction.SubInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001ABD RID: 6845 RVA: 0x0007FB68 File Offset: 0x0007DD68
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SubInt16()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubInstruction.SubInt16>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubInstruction.SubInt16.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001ABE RID: 6846 RVA: 0x0000A42F File Offset: 0x0000862F
			public SubInt16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001224 RID: 4644
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001225 RID: 4645
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000314 RID: 788
		public sealed class SubInt32 : SubInstruction
		{
			// Token: 0x06001ABF RID: 6847 RVA: 0x0007FBA4 File Offset: 0x0007DDA4
			// Note: this type is marked as 'beforefieldinit'.
			static SubInt32()
			{
				Il2CppClassPointerStore<SubInstruction.SubInt32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubInstruction>.NativeClassPtr, "SubInt32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubInstruction.SubInt32>.NativeClassPtr);
				SubInstruction.SubInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubInstruction.SubInt32>.NativeClassPtr, 100666128);
				SubInstruction.SubInt32.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubInstruction.SubInt32>.NativeClassPtr, 100666129);
			}

			// Token: 0x06001AC0 RID: 6848 RVA: 0x0007FBF8 File Offset: 0x0007DDF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026360, XrefRangeEnd = 1026362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubInstruction.SubInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001AC1 RID: 6849 RVA: 0x0007FC48 File Offset: 0x0007DE48
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SubInt32()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubInstruction.SubInt32>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubInstruction.SubInt32.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AC2 RID: 6850 RVA: 0x0000A438 File Offset: 0x00008638
			public SubInt32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001226 RID: 4646
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001227 RID: 4647
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000315 RID: 789
		public sealed class SubInt64 : SubInstruction
		{
			// Token: 0x06001AC3 RID: 6851 RVA: 0x0007FC84 File Offset: 0x0007DE84
			// Note: this type is marked as 'beforefieldinit'.
			static SubInt64()
			{
				Il2CppClassPointerStore<SubInstruction.SubInt64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubInstruction>.NativeClassPtr, "SubInt64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubInstruction.SubInt64>.NativeClassPtr);
				SubInstruction.SubInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubInstruction.SubInt64>.NativeClassPtr, 100666130);
				SubInstruction.SubInt64.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubInstruction.SubInt64>.NativeClassPtr, 100666131);
			}

			// Token: 0x06001AC4 RID: 6852 RVA: 0x0007FCD8 File Offset: 0x0007DED8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026362, XrefRangeEnd = 1026364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubInstruction.SubInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001AC5 RID: 6853 RVA: 0x0007FD28 File Offset: 0x0007DF28
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SubInt64()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubInstruction.SubInt64>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubInstruction.SubInt64.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AC6 RID: 6854 RVA: 0x0000A441 File Offset: 0x00008641
			public SubInt64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001228 RID: 4648
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001229 RID: 4649
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000316 RID: 790
		public sealed class SubUInt16 : SubInstruction
		{
			// Token: 0x06001AC7 RID: 6855 RVA: 0x0007FD64 File Offset: 0x0007DF64
			// Note: this type is marked as 'beforefieldinit'.
			static SubUInt16()
			{
				Il2CppClassPointerStore<SubInstruction.SubUInt16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubInstruction>.NativeClassPtr, "SubUInt16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubInstruction.SubUInt16>.NativeClassPtr);
				SubInstruction.SubUInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubInstruction.SubUInt16>.NativeClassPtr, 100666132);
				SubInstruction.SubUInt16.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubInstruction.SubUInt16>.NativeClassPtr, 100666133);
			}

			// Token: 0x06001AC8 RID: 6856 RVA: 0x0007FDB8 File Offset: 0x0007DFB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026364, XrefRangeEnd = 1026366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubInstruction.SubUInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001AC9 RID: 6857 RVA: 0x0007FE08 File Offset: 0x0007E008
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SubUInt16()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubInstruction.SubUInt16>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubInstruction.SubUInt16.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001ACA RID: 6858 RVA: 0x0000A44A File Offset: 0x0000864A
			public SubUInt16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400122A RID: 4650
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x0400122B RID: 4651
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000317 RID: 791
		public sealed class SubUInt32 : SubInstruction
		{
			// Token: 0x06001ACB RID: 6859 RVA: 0x0007FE44 File Offset: 0x0007E044
			// Note: this type is marked as 'beforefieldinit'.
			static SubUInt32()
			{
				Il2CppClassPointerStore<SubInstruction.SubUInt32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubInstruction>.NativeClassPtr, "SubUInt32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubInstruction.SubUInt32>.NativeClassPtr);
				SubInstruction.SubUInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubInstruction.SubUInt32>.NativeClassPtr, 100666134);
				SubInstruction.SubUInt32.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubInstruction.SubUInt32>.NativeClassPtr, 100666135);
			}

			// Token: 0x06001ACC RID: 6860 RVA: 0x0007FE98 File Offset: 0x0007E098
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026366, XrefRangeEnd = 1026368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubInstruction.SubUInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001ACD RID: 6861 RVA: 0x0007FEE8 File Offset: 0x0007E0E8
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SubUInt32()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubInstruction.SubUInt32>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubInstruction.SubUInt32.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001ACE RID: 6862 RVA: 0x0000A453 File Offset: 0x00008653
			public SubUInt32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400122C RID: 4652
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x0400122D RID: 4653
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000318 RID: 792
		public sealed class SubUInt64 : SubInstruction
		{
			// Token: 0x06001ACF RID: 6863 RVA: 0x0007FF24 File Offset: 0x0007E124
			// Note: this type is marked as 'beforefieldinit'.
			static SubUInt64()
			{
				Il2CppClassPointerStore<SubInstruction.SubUInt64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubInstruction>.NativeClassPtr, "SubUInt64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubInstruction.SubUInt64>.NativeClassPtr);
				SubInstruction.SubUInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubInstruction.SubUInt64>.NativeClassPtr, 100666136);
				SubInstruction.SubUInt64.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubInstruction.SubUInt64>.NativeClassPtr, 100666137);
			}

			// Token: 0x06001AD0 RID: 6864 RVA: 0x0007FF78 File Offset: 0x0007E178
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026368, XrefRangeEnd = 1026370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubInstruction.SubUInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001AD1 RID: 6865 RVA: 0x0007FFC8 File Offset: 0x0007E1C8
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SubUInt64()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubInstruction.SubUInt64>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubInstruction.SubUInt64.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AD2 RID: 6866 RVA: 0x0000A45C File Offset: 0x0000865C
			public SubUInt64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400122E RID: 4654
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x0400122F RID: 4655
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000319 RID: 793
		public sealed class SubSingle : SubInstruction
		{
			// Token: 0x06001AD3 RID: 6867 RVA: 0x00080004 File Offset: 0x0007E204
			// Note: this type is marked as 'beforefieldinit'.
			static SubSingle()
			{
				Il2CppClassPointerStore<SubInstruction.SubSingle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubInstruction>.NativeClassPtr, "SubSingle");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubInstruction.SubSingle>.NativeClassPtr);
				SubInstruction.SubSingle.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubInstruction.SubSingle>.NativeClassPtr, 100666138);
				SubInstruction.SubSingle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubInstruction.SubSingle>.NativeClassPtr, 100666139);
			}

			// Token: 0x06001AD4 RID: 6868 RVA: 0x00080058 File Offset: 0x0007E258
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026370, XrefRangeEnd = 1026372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubInstruction.SubSingle.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001AD5 RID: 6869 RVA: 0x000800A8 File Offset: 0x0007E2A8
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SubSingle()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubInstruction.SubSingle>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubInstruction.SubSingle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AD6 RID: 6870 RVA: 0x0000A465 File Offset: 0x00008665
			public SubSingle(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001230 RID: 4656
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001231 RID: 4657
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200031A RID: 794
		public sealed class SubDouble : SubInstruction
		{
			// Token: 0x06001AD7 RID: 6871 RVA: 0x000800E4 File Offset: 0x0007E2E4
			// Note: this type is marked as 'beforefieldinit'.
			static SubDouble()
			{
				Il2CppClassPointerStore<SubInstruction.SubDouble>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubInstruction>.NativeClassPtr, "SubDouble");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubInstruction.SubDouble>.NativeClassPtr);
				SubInstruction.SubDouble.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubInstruction.SubDouble>.NativeClassPtr, 100666140);
				SubInstruction.SubDouble.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubInstruction.SubDouble>.NativeClassPtr, 100666141);
			}

			// Token: 0x06001AD8 RID: 6872 RVA: 0x00080138 File Offset: 0x0007E338
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026372, XrefRangeEnd = 1026374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubInstruction.SubDouble.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001AD9 RID: 6873 RVA: 0x00080188 File Offset: 0x0007E388
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SubDouble()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubInstruction.SubDouble>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubInstruction.SubDouble.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001ADA RID: 6874 RVA: 0x0000A46E File Offset: 0x0000866E
			public SubDouble(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001232 RID: 4658
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001233 RID: 4659
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
