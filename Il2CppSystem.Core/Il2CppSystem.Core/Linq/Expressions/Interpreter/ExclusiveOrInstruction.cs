using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000B3 RID: 179
	public class ExclusiveOrInstruction : Instruction
	{
		// Token: 0x060009AA RID: 2474 RVA: 0x00039DF8 File Offset: 0x00037FF8
		// Note: this type is marked as 'beforefieldinit'.
		static ExclusiveOrInstruction()
		{
			Il2CppClassPointerStore<ExclusiveOrInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "ExclusiveOrInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExclusiveOrInstruction>.NativeClassPtr);
			ExclusiveOrInstruction.NativeFieldInfoPtr_s_SByte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExclusiveOrInstruction>.NativeClassPtr, "s_SByte");
			ExclusiveOrInstruction.NativeFieldInfoPtr_s_Int16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExclusiveOrInstruction>.NativeClassPtr, "s_Int16");
			ExclusiveOrInstruction.NativeFieldInfoPtr_s_Int32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExclusiveOrInstruction>.NativeClassPtr, "s_Int32");
			ExclusiveOrInstruction.NativeFieldInfoPtr_s_Int64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExclusiveOrInstruction>.NativeClassPtr, "s_Int64");
			ExclusiveOrInstruction.NativeFieldInfoPtr_s_Byte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExclusiveOrInstruction>.NativeClassPtr, "s_Byte");
			ExclusiveOrInstruction.NativeFieldInfoPtr_s_UInt16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExclusiveOrInstruction>.NativeClassPtr, "s_UInt16");
			ExclusiveOrInstruction.NativeFieldInfoPtr_s_UInt32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExclusiveOrInstruction>.NativeClassPtr, "s_UInt32");
			ExclusiveOrInstruction.NativeFieldInfoPtr_s_UInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExclusiveOrInstruction>.NativeClassPtr, "s_UInt64");
			ExclusiveOrInstruction.NativeFieldInfoPtr_s_Boolean = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExclusiveOrInstruction>.NativeClassPtr, "s_Boolean");
			ExclusiveOrInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExclusiveOrInstruction>.NativeClassPtr, 100665128);
			ExclusiveOrInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExclusiveOrInstruction>.NativeClassPtr, 100665129);
			ExclusiveOrInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExclusiveOrInstruction>.NativeClassPtr, 100665130);
			ExclusiveOrInstruction.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExclusiveOrInstruction>.NativeClassPtr, 100665131);
			ExclusiveOrInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExclusiveOrInstruction>.NativeClassPtr, 100665132);
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x060009AB RID: 2475 RVA: 0x00039F40 File Offset: 0x00038140
		public unsafe override int ConsumedStack
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 72978, RefRangeEnd = 72985, XrefRangeStart = 72978, XrefRangeEnd = 72985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExclusiveOrInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x060009AC RID: 2476 RVA: 0x00039F88 File Offset: 0x00038188
		public unsafe override int ProducedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExclusiveOrInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x060009AD RID: 2477 RVA: 0x00039FD0 File Offset: 0x000381D0
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016943, XrefRangeEnd = 1016945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExclusiveOrInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x0003A014 File Offset: 0x00038214
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExclusiveOrInstruction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExclusiveOrInstruction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExclusiveOrInstruction.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x0003A050 File Offset: 0x00038250
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1016970, RefRangeEnd = 1016972, XrefRangeStart = 1016945, XrefRangeEnd = 1016970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Instruction Create(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExclusiveOrInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x00004AC3 File Offset: 0x00002CC3
		public ExclusiveOrInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x060009B1 RID: 2481 RVA: 0x0003A094 File Offset: 0x00038294
		// (set) Token: 0x060009B2 RID: 2482 RVA: 0x00004ACC File Offset: 0x00002CCC
		public unsafe static Instruction s_SByte
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExclusiveOrInstruction.NativeFieldInfoPtr_s_SByte, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExclusiveOrInstruction.NativeFieldInfoPtr_s_SByte, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x060009B3 RID: 2483 RVA: 0x0003A0BC File Offset: 0x000382BC
		// (set) Token: 0x060009B4 RID: 2484 RVA: 0x00004ADE File Offset: 0x00002CDE
		public unsafe static Instruction s_Int16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExclusiveOrInstruction.NativeFieldInfoPtr_s_Int16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExclusiveOrInstruction.NativeFieldInfoPtr_s_Int16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x060009B5 RID: 2485 RVA: 0x0003A0E4 File Offset: 0x000382E4
		// (set) Token: 0x060009B6 RID: 2486 RVA: 0x00004AF0 File Offset: 0x00002CF0
		public unsafe static Instruction s_Int32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExclusiveOrInstruction.NativeFieldInfoPtr_s_Int32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExclusiveOrInstruction.NativeFieldInfoPtr_s_Int32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x060009B7 RID: 2487 RVA: 0x0003A10C File Offset: 0x0003830C
		// (set) Token: 0x060009B8 RID: 2488 RVA: 0x00004B02 File Offset: 0x00002D02
		public unsafe static Instruction s_Int64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExclusiveOrInstruction.NativeFieldInfoPtr_s_Int64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExclusiveOrInstruction.NativeFieldInfoPtr_s_Int64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x060009B9 RID: 2489 RVA: 0x0003A134 File Offset: 0x00038334
		// (set) Token: 0x060009BA RID: 2490 RVA: 0x00004B14 File Offset: 0x00002D14
		public unsafe static Instruction s_Byte
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExclusiveOrInstruction.NativeFieldInfoPtr_s_Byte, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExclusiveOrInstruction.NativeFieldInfoPtr_s_Byte, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x060009BB RID: 2491 RVA: 0x0003A15C File Offset: 0x0003835C
		// (set) Token: 0x060009BC RID: 2492 RVA: 0x00004B26 File Offset: 0x00002D26
		public unsafe static Instruction s_UInt16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExclusiveOrInstruction.NativeFieldInfoPtr_s_UInt16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExclusiveOrInstruction.NativeFieldInfoPtr_s_UInt16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x060009BD RID: 2493 RVA: 0x0003A184 File Offset: 0x00038384
		// (set) Token: 0x060009BE RID: 2494 RVA: 0x00004B38 File Offset: 0x00002D38
		public unsafe static Instruction s_UInt32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExclusiveOrInstruction.NativeFieldInfoPtr_s_UInt32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExclusiveOrInstruction.NativeFieldInfoPtr_s_UInt32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x060009BF RID: 2495 RVA: 0x0003A1AC File Offset: 0x000383AC
		// (set) Token: 0x060009C0 RID: 2496 RVA: 0x00004B4A File Offset: 0x00002D4A
		public unsafe static Instruction s_UInt64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExclusiveOrInstruction.NativeFieldInfoPtr_s_UInt64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExclusiveOrInstruction.NativeFieldInfoPtr_s_UInt64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x060009C1 RID: 2497 RVA: 0x0003A1D4 File Offset: 0x000383D4
		// (set) Token: 0x060009C2 RID: 2498 RVA: 0x00004B5C File Offset: 0x00002D5C
		public unsafe static Instruction s_Boolean
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExclusiveOrInstruction.NativeFieldInfoPtr_s_Boolean, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExclusiveOrInstruction.NativeFieldInfoPtr_s_Boolean, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400074D RID: 1869
		private static readonly IntPtr NativeFieldInfoPtr_s_SByte;

		// Token: 0x0400074E RID: 1870
		private static readonly IntPtr NativeFieldInfoPtr_s_Int16;

		// Token: 0x0400074F RID: 1871
		private static readonly IntPtr NativeFieldInfoPtr_s_Int32;

		// Token: 0x04000750 RID: 1872
		private static readonly IntPtr NativeFieldInfoPtr_s_Int64;

		// Token: 0x04000751 RID: 1873
		private static readonly IntPtr NativeFieldInfoPtr_s_Byte;

		// Token: 0x04000752 RID: 1874
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt16;

		// Token: 0x04000753 RID: 1875
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt32;

		// Token: 0x04000754 RID: 1876
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt64;

		// Token: 0x04000755 RID: 1877
		private static readonly IntPtr NativeFieldInfoPtr_s_Boolean;

		// Token: 0x04000756 RID: 1878
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000757 RID: 1879
		private static readonly IntPtr NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000758 RID: 1880
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x04000759 RID: 1881
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x0400075A RID: 1882
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0;

		// Token: 0x02000227 RID: 551
		public sealed class ExclusiveOrSByte : ExclusiveOrInstruction
		{
			// Token: 0x0600176C RID: 5996 RVA: 0x000716CC File Offset: 0x0006F8CC
			// Note: this type is marked as 'beforefieldinit'.
			static ExclusiveOrSByte()
			{
				Il2CppClassPointerStore<ExclusiveOrInstruction.ExclusiveOrSByte>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExclusiveOrInstruction>.NativeClassPtr, "ExclusiveOrSByte");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExclusiveOrInstruction.ExclusiveOrSByte>.NativeClassPtr);
				ExclusiveOrInstruction.ExclusiveOrSByte.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExclusiveOrInstruction.ExclusiveOrSByte>.NativeClassPtr, 100665133);
				ExclusiveOrInstruction.ExclusiveOrSByte.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExclusiveOrInstruction.ExclusiveOrSByte>.NativeClassPtr, 100665134);
			}

			// Token: 0x0600176D RID: 5997 RVA: 0x00071720 File Offset: 0x0006F920
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016873, XrefRangeEnd = 1016881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExclusiveOrInstruction.ExclusiveOrSByte.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600176E RID: 5998 RVA: 0x00071770 File Offset: 0x0006F970
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ExclusiveOrSByte()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExclusiveOrInstruction.ExclusiveOrSByte>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExclusiveOrInstruction.ExclusiveOrSByte.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600176F RID: 5999 RVA: 0x00009A9F File Offset: 0x00007C9F
			public ExclusiveOrSByte(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001047 RID: 4167
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001048 RID: 4168
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000228 RID: 552
		public sealed class ExclusiveOrInt16 : ExclusiveOrInstruction
		{
			// Token: 0x06001770 RID: 6000 RVA: 0x000717AC File Offset: 0x0006F9AC
			// Note: this type is marked as 'beforefieldinit'.
			static ExclusiveOrInt16()
			{
				Il2CppClassPointerStore<ExclusiveOrInstruction.ExclusiveOrInt16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExclusiveOrInstruction>.NativeClassPtr, "ExclusiveOrInt16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExclusiveOrInstruction.ExclusiveOrInt16>.NativeClassPtr);
				ExclusiveOrInstruction.ExclusiveOrInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExclusiveOrInstruction.ExclusiveOrInt16>.NativeClassPtr, 100665135);
				ExclusiveOrInstruction.ExclusiveOrInt16.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExclusiveOrInstruction.ExclusiveOrInt16>.NativeClassPtr, 100665136);
			}

			// Token: 0x06001771 RID: 6001 RVA: 0x00071800 File Offset: 0x0006FA00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016881, XrefRangeEnd = 1016889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExclusiveOrInstruction.ExclusiveOrInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001772 RID: 6002 RVA: 0x00071850 File Offset: 0x0006FA50
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ExclusiveOrInt16()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExclusiveOrInstruction.ExclusiveOrInt16>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExclusiveOrInstruction.ExclusiveOrInt16.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001773 RID: 6003 RVA: 0x00009AA8 File Offset: 0x00007CA8
			public ExclusiveOrInt16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001049 RID: 4169
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x0400104A RID: 4170
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000229 RID: 553
		public sealed class ExclusiveOrInt32 : ExclusiveOrInstruction
		{
			// Token: 0x06001774 RID: 6004 RVA: 0x0007188C File Offset: 0x0006FA8C
			// Note: this type is marked as 'beforefieldinit'.
			static ExclusiveOrInt32()
			{
				Il2CppClassPointerStore<ExclusiveOrInstruction.ExclusiveOrInt32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExclusiveOrInstruction>.NativeClassPtr, "ExclusiveOrInt32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExclusiveOrInstruction.ExclusiveOrInt32>.NativeClassPtr);
				ExclusiveOrInstruction.ExclusiveOrInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExclusiveOrInstruction.ExclusiveOrInt32>.NativeClassPtr, 100665137);
				ExclusiveOrInstruction.ExclusiveOrInt32.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExclusiveOrInstruction.ExclusiveOrInt32>.NativeClassPtr, 100665138);
			}

			// Token: 0x06001775 RID: 6005 RVA: 0x000718E0 File Offset: 0x0006FAE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016889, XrefRangeEnd = 1016897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExclusiveOrInstruction.ExclusiveOrInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001776 RID: 6006 RVA: 0x00071930 File Offset: 0x0006FB30
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ExclusiveOrInt32()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExclusiveOrInstruction.ExclusiveOrInt32>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExclusiveOrInstruction.ExclusiveOrInt32.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001777 RID: 6007 RVA: 0x00009AB1 File Offset: 0x00007CB1
			public ExclusiveOrInt32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400104B RID: 4171
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x0400104C RID: 4172
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200022A RID: 554
		public sealed class ExclusiveOrInt64 : ExclusiveOrInstruction
		{
			// Token: 0x06001778 RID: 6008 RVA: 0x0007196C File Offset: 0x0006FB6C
			// Note: this type is marked as 'beforefieldinit'.
			static ExclusiveOrInt64()
			{
				Il2CppClassPointerStore<ExclusiveOrInstruction.ExclusiveOrInt64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExclusiveOrInstruction>.NativeClassPtr, "ExclusiveOrInt64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExclusiveOrInstruction.ExclusiveOrInt64>.NativeClassPtr);
				ExclusiveOrInstruction.ExclusiveOrInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExclusiveOrInstruction.ExclusiveOrInt64>.NativeClassPtr, 100665139);
				ExclusiveOrInstruction.ExclusiveOrInt64.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExclusiveOrInstruction.ExclusiveOrInt64>.NativeClassPtr, 100665140);
			}

			// Token: 0x06001779 RID: 6009 RVA: 0x000719C0 File Offset: 0x0006FBC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016897, XrefRangeEnd = 1016907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExclusiveOrInstruction.ExclusiveOrInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600177A RID: 6010 RVA: 0x00071A10 File Offset: 0x0006FC10
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ExclusiveOrInt64()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExclusiveOrInstruction.ExclusiveOrInt64>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExclusiveOrInstruction.ExclusiveOrInt64.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600177B RID: 6011 RVA: 0x00009ABA File Offset: 0x00007CBA
			public ExclusiveOrInt64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400104D RID: 4173
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x0400104E RID: 4174
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200022B RID: 555
		public sealed class ExclusiveOrByte : ExclusiveOrInstruction
		{
			// Token: 0x0600177C RID: 6012 RVA: 0x00071A4C File Offset: 0x0006FC4C
			// Note: this type is marked as 'beforefieldinit'.
			static ExclusiveOrByte()
			{
				Il2CppClassPointerStore<ExclusiveOrInstruction.ExclusiveOrByte>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExclusiveOrInstruction>.NativeClassPtr, "ExclusiveOrByte");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExclusiveOrInstruction.ExclusiveOrByte>.NativeClassPtr);
				ExclusiveOrInstruction.ExclusiveOrByte.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExclusiveOrInstruction.ExclusiveOrByte>.NativeClassPtr, 100665141);
				ExclusiveOrInstruction.ExclusiveOrByte.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExclusiveOrInstruction.ExclusiveOrByte>.NativeClassPtr, 100665142);
			}

			// Token: 0x0600177D RID: 6013 RVA: 0x00071AA0 File Offset: 0x0006FCA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016907, XrefRangeEnd = 1016913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExclusiveOrInstruction.ExclusiveOrByte.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600177E RID: 6014 RVA: 0x00071AF0 File Offset: 0x0006FCF0
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 146959, RefRangeEnd = 146969, XrefRangeStart = 146959, XrefRangeEnd = 146969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ExclusiveOrByte()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExclusiveOrInstruction.ExclusiveOrByte>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExclusiveOrInstruction.ExclusiveOrByte.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600177F RID: 6015 RVA: 0x00009AC3 File Offset: 0x00007CC3
			public ExclusiveOrByte(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400104F RID: 4175
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001050 RID: 4176
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200022C RID: 556
		public sealed class ExclusiveOrUInt16 : ExclusiveOrInstruction
		{
			// Token: 0x06001780 RID: 6016 RVA: 0x00071B2C File Offset: 0x0006FD2C
			// Note: this type is marked as 'beforefieldinit'.
			static ExclusiveOrUInt16()
			{
				Il2CppClassPointerStore<ExclusiveOrInstruction.ExclusiveOrUInt16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExclusiveOrInstruction>.NativeClassPtr, "ExclusiveOrUInt16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExclusiveOrInstruction.ExclusiveOrUInt16>.NativeClassPtr);
				ExclusiveOrInstruction.ExclusiveOrUInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExclusiveOrInstruction.ExclusiveOrUInt16>.NativeClassPtr, 100665143);
				ExclusiveOrInstruction.ExclusiveOrUInt16.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExclusiveOrInstruction.ExclusiveOrUInt16>.NativeClassPtr, 100665144);
			}

			// Token: 0x06001781 RID: 6017 RVA: 0x00071B80 File Offset: 0x0006FD80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016913, XrefRangeEnd = 1016919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExclusiveOrInstruction.ExclusiveOrUInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001782 RID: 6018 RVA: 0x00071BD0 File Offset: 0x0006FDD0
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 146959, RefRangeEnd = 146969, XrefRangeStart = 146959, XrefRangeEnd = 146969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ExclusiveOrUInt16()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExclusiveOrInstruction.ExclusiveOrUInt16>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExclusiveOrInstruction.ExclusiveOrUInt16.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001783 RID: 6019 RVA: 0x00009ACC File Offset: 0x00007CCC
			public ExclusiveOrUInt16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001051 RID: 4177
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001052 RID: 4178
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200022D RID: 557
		public sealed class ExclusiveOrUInt32 : ExclusiveOrInstruction
		{
			// Token: 0x06001784 RID: 6020 RVA: 0x00071C0C File Offset: 0x0006FE0C
			// Note: this type is marked as 'beforefieldinit'.
			static ExclusiveOrUInt32()
			{
				Il2CppClassPointerStore<ExclusiveOrInstruction.ExclusiveOrUInt32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExclusiveOrInstruction>.NativeClassPtr, "ExclusiveOrUInt32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExclusiveOrInstruction.ExclusiveOrUInt32>.NativeClassPtr);
				ExclusiveOrInstruction.ExclusiveOrUInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExclusiveOrInstruction.ExclusiveOrUInt32>.NativeClassPtr, 100665145);
				ExclusiveOrInstruction.ExclusiveOrUInt32.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExclusiveOrInstruction.ExclusiveOrUInt32>.NativeClassPtr, 100665146);
			}

			// Token: 0x06001785 RID: 6021 RVA: 0x00071C60 File Offset: 0x0006FE60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016919, XrefRangeEnd = 1016928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExclusiveOrInstruction.ExclusiveOrUInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001786 RID: 6022 RVA: 0x00071CB0 File Offset: 0x0006FEB0
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 146959, RefRangeEnd = 146969, XrefRangeStart = 146959, XrefRangeEnd = 146969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ExclusiveOrUInt32()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExclusiveOrInstruction.ExclusiveOrUInt32>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExclusiveOrInstruction.ExclusiveOrUInt32.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001787 RID: 6023 RVA: 0x00009AD5 File Offset: 0x00007CD5
			public ExclusiveOrUInt32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001053 RID: 4179
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001054 RID: 4180
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200022E RID: 558
		public sealed class ExclusiveOrUInt64 : ExclusiveOrInstruction
		{
			// Token: 0x06001788 RID: 6024 RVA: 0x00071CEC File Offset: 0x0006FEEC
			// Note: this type is marked as 'beforefieldinit'.
			static ExclusiveOrUInt64()
			{
				Il2CppClassPointerStore<ExclusiveOrInstruction.ExclusiveOrUInt64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExclusiveOrInstruction>.NativeClassPtr, "ExclusiveOrUInt64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExclusiveOrInstruction.ExclusiveOrUInt64>.NativeClassPtr);
				ExclusiveOrInstruction.ExclusiveOrUInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExclusiveOrInstruction.ExclusiveOrUInt64>.NativeClassPtr, 100665147);
				ExclusiveOrInstruction.ExclusiveOrUInt64.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExclusiveOrInstruction.ExclusiveOrUInt64>.NativeClassPtr, 100665148);
			}

			// Token: 0x06001789 RID: 6025 RVA: 0x00071D40 File Offset: 0x0006FF40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016928, XrefRangeEnd = 1016937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExclusiveOrInstruction.ExclusiveOrUInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600178A RID: 6026 RVA: 0x00071D90 File Offset: 0x0006FF90
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 146959, RefRangeEnd = 146969, XrefRangeStart = 146959, XrefRangeEnd = 146969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ExclusiveOrUInt64()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExclusiveOrInstruction.ExclusiveOrUInt64>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExclusiveOrInstruction.ExclusiveOrUInt64.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600178B RID: 6027 RVA: 0x00009ADE File Offset: 0x00007CDE
			public ExclusiveOrUInt64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001055 RID: 4181
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001056 RID: 4182
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200022F RID: 559
		public sealed class ExclusiveOrBoolean : ExclusiveOrInstruction
		{
			// Token: 0x0600178C RID: 6028 RVA: 0x00071DCC File Offset: 0x0006FFCC
			// Note: this type is marked as 'beforefieldinit'.
			static ExclusiveOrBoolean()
			{
				Il2CppClassPointerStore<ExclusiveOrInstruction.ExclusiveOrBoolean>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExclusiveOrInstruction>.NativeClassPtr, "ExclusiveOrBoolean");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExclusiveOrInstruction.ExclusiveOrBoolean>.NativeClassPtr);
				ExclusiveOrInstruction.ExclusiveOrBoolean.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExclusiveOrInstruction.ExclusiveOrBoolean>.NativeClassPtr, 100665149);
				ExclusiveOrInstruction.ExclusiveOrBoolean.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExclusiveOrInstruction.ExclusiveOrBoolean>.NativeClassPtr, 100665150);
			}

			// Token: 0x0600178D RID: 6029 RVA: 0x00071E20 File Offset: 0x00070020
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016937, XrefRangeEnd = 1016943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExclusiveOrInstruction.ExclusiveOrBoolean.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600178E RID: 6030 RVA: 0x00071E70 File Offset: 0x00070070
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 146959, RefRangeEnd = 146969, XrefRangeStart = 146959, XrefRangeEnd = 146969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ExclusiveOrBoolean()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExclusiveOrInstruction.ExclusiveOrBoolean>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExclusiveOrInstruction.ExclusiveOrBoolean.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600178F RID: 6031 RVA: 0x00009AE7 File Offset: 0x00007CE7
			public ExclusiveOrBoolean(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001057 RID: 4183
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001058 RID: 4184
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
