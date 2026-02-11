using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000E8 RID: 232
	public class ModuloInstruction : Instruction
	{
		// Token: 0x06000DF4 RID: 3572 RVA: 0x0004DC3C File Offset: 0x0004BE3C
		// Note: this type is marked as 'beforefieldinit'.
		static ModuloInstruction()
		{
			Il2CppClassPointerStore<ModuloInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "ModuloInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModuloInstruction>.NativeClassPtr);
			ModuloInstruction.NativeFieldInfoPtr_s_Int16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModuloInstruction>.NativeClassPtr, "s_Int16");
			ModuloInstruction.NativeFieldInfoPtr_s_Int32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModuloInstruction>.NativeClassPtr, "s_Int32");
			ModuloInstruction.NativeFieldInfoPtr_s_Int64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModuloInstruction>.NativeClassPtr, "s_Int64");
			ModuloInstruction.NativeFieldInfoPtr_s_UInt16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModuloInstruction>.NativeClassPtr, "s_UInt16");
			ModuloInstruction.NativeFieldInfoPtr_s_UInt32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModuloInstruction>.NativeClassPtr, "s_UInt32");
			ModuloInstruction.NativeFieldInfoPtr_s_UInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModuloInstruction>.NativeClassPtr, "s_UInt64");
			ModuloInstruction.NativeFieldInfoPtr_s_Single = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModuloInstruction>.NativeClassPtr, "s_Single");
			ModuloInstruction.NativeFieldInfoPtr_s_Double = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModuloInstruction>.NativeClassPtr, "s_Double");
			ModuloInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuloInstruction>.NativeClassPtr, 100665853);
			ModuloInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuloInstruction>.NativeClassPtr, 100665854);
			ModuloInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuloInstruction>.NativeClassPtr, 100665855);
			ModuloInstruction.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuloInstruction>.NativeClassPtr, 100665856);
			ModuloInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuloInstruction>.NativeClassPtr, 100665857);
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06000DF5 RID: 3573 RVA: 0x0004DD70 File Offset: 0x0004BF70
		public unsafe override int ConsumedStack
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 72978, RefRangeEnd = 72985, XrefRangeStart = 72978, XrefRangeEnd = 72985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ModuloInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06000DF6 RID: 3574 RVA: 0x0004DDB8 File Offset: 0x0004BFB8
		public unsafe override int ProducedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ModuloInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06000DF7 RID: 3575 RVA: 0x0004DE00 File Offset: 0x0004C000
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024951, XrefRangeEnd = 1024953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ModuloInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x0004DE44 File Offset: 0x0004C044
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ModuloInstruction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModuloInstruction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuloInstruction.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x0004DE80 File Offset: 0x0004C080
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1024977, RefRangeEnd = 1024979, XrefRangeStart = 1024953, XrefRangeEnd = 1024977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Instruction Create(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuloInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x00006356 File Offset: 0x00004556
		public ModuloInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06000DFB RID: 3579 RVA: 0x0004DEC4 File Offset: 0x0004C0C4
		// (set) Token: 0x06000DFC RID: 3580 RVA: 0x0000635F File Offset: 0x0000455F
		public unsafe static Instruction s_Int16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ModuloInstruction.NativeFieldInfoPtr_s_Int16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ModuloInstruction.NativeFieldInfoPtr_s_Int16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06000DFD RID: 3581 RVA: 0x0004DEEC File Offset: 0x0004C0EC
		// (set) Token: 0x06000DFE RID: 3582 RVA: 0x00006371 File Offset: 0x00004571
		public unsafe static Instruction s_Int32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ModuloInstruction.NativeFieldInfoPtr_s_Int32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ModuloInstruction.NativeFieldInfoPtr_s_Int32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06000DFF RID: 3583 RVA: 0x0004DF14 File Offset: 0x0004C114
		// (set) Token: 0x06000E00 RID: 3584 RVA: 0x00006383 File Offset: 0x00004583
		public unsafe static Instruction s_Int64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ModuloInstruction.NativeFieldInfoPtr_s_Int64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ModuloInstruction.NativeFieldInfoPtr_s_Int64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06000E01 RID: 3585 RVA: 0x0004DF3C File Offset: 0x0004C13C
		// (set) Token: 0x06000E02 RID: 3586 RVA: 0x00006395 File Offset: 0x00004595
		public unsafe static Instruction s_UInt16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ModuloInstruction.NativeFieldInfoPtr_s_UInt16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ModuloInstruction.NativeFieldInfoPtr_s_UInt16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06000E03 RID: 3587 RVA: 0x0004DF64 File Offset: 0x0004C164
		// (set) Token: 0x06000E04 RID: 3588 RVA: 0x000063A7 File Offset: 0x000045A7
		public unsafe static Instruction s_UInt32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ModuloInstruction.NativeFieldInfoPtr_s_UInt32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ModuloInstruction.NativeFieldInfoPtr_s_UInt32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06000E05 RID: 3589 RVA: 0x0004DF8C File Offset: 0x0004C18C
		// (set) Token: 0x06000E06 RID: 3590 RVA: 0x000063B9 File Offset: 0x000045B9
		public unsafe static Instruction s_UInt64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ModuloInstruction.NativeFieldInfoPtr_s_UInt64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ModuloInstruction.NativeFieldInfoPtr_s_UInt64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06000E07 RID: 3591 RVA: 0x0004DFB4 File Offset: 0x0004C1B4
		// (set) Token: 0x06000E08 RID: 3592 RVA: 0x000063CB File Offset: 0x000045CB
		public unsafe static Instruction s_Single
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ModuloInstruction.NativeFieldInfoPtr_s_Single, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ModuloInstruction.NativeFieldInfoPtr_s_Single, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06000E09 RID: 3593 RVA: 0x0004DFDC File Offset: 0x0004C1DC
		// (set) Token: 0x06000E0A RID: 3594 RVA: 0x000063DD File Offset: 0x000045DD
		public unsafe static Instruction s_Double
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ModuloInstruction.NativeFieldInfoPtr_s_Double, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ModuloInstruction.NativeFieldInfoPtr_s_Double, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A45 RID: 2629
		private static readonly IntPtr NativeFieldInfoPtr_s_Int16;

		// Token: 0x04000A46 RID: 2630
		private static readonly IntPtr NativeFieldInfoPtr_s_Int32;

		// Token: 0x04000A47 RID: 2631
		private static readonly IntPtr NativeFieldInfoPtr_s_Int64;

		// Token: 0x04000A48 RID: 2632
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt16;

		// Token: 0x04000A49 RID: 2633
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt32;

		// Token: 0x04000A4A RID: 2634
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt64;

		// Token: 0x04000A4B RID: 2635
		private static readonly IntPtr NativeFieldInfoPtr_s_Single;

		// Token: 0x04000A4C RID: 2636
		private static readonly IntPtr NativeFieldInfoPtr_s_Double;

		// Token: 0x04000A4D RID: 2637
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000A4E RID: 2638
		private static readonly IntPtr NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000A4F RID: 2639
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x04000A50 RID: 2640
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000A51 RID: 2641
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0;

		// Token: 0x020002C0 RID: 704
		public sealed class ModuloInt16 : ModuloInstruction
		{
			// Token: 0x06001964 RID: 6500 RVA: 0x0007ADD4 File Offset: 0x00078FD4
			// Note: this type is marked as 'beforefieldinit'.
			static ModuloInt16()
			{
				Il2CppClassPointerStore<ModuloInstruction.ModuloInt16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ModuloInstruction>.NativeClassPtr, "ModuloInt16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModuloInstruction.ModuloInt16>.NativeClassPtr);
				ModuloInstruction.ModuloInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuloInstruction.ModuloInt16>.NativeClassPtr, 100665858);
				ModuloInstruction.ModuloInt16.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuloInstruction.ModuloInt16>.NativeClassPtr, 100665859);
			}

			// Token: 0x06001965 RID: 6501 RVA: 0x0007AE28 File Offset: 0x00079028
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024935, XrefRangeEnd = 1024937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuloInstruction.ModuloInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001966 RID: 6502 RVA: 0x0007AE78 File Offset: 0x00079078
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ModuloInt16()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModuloInstruction.ModuloInt16>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuloInstruction.ModuloInt16.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001967 RID: 6503 RVA: 0x0000A144 File Offset: 0x00008344
			public ModuloInt16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001173 RID: 4467
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001174 RID: 4468
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002C1 RID: 705
		public sealed class ModuloInt32 : ModuloInstruction
		{
			// Token: 0x06001968 RID: 6504 RVA: 0x0007AEB4 File Offset: 0x000790B4
			// Note: this type is marked as 'beforefieldinit'.
			static ModuloInt32()
			{
				Il2CppClassPointerStore<ModuloInstruction.ModuloInt32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ModuloInstruction>.NativeClassPtr, "ModuloInt32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModuloInstruction.ModuloInt32>.NativeClassPtr);
				ModuloInstruction.ModuloInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuloInstruction.ModuloInt32>.NativeClassPtr, 100665860);
				ModuloInstruction.ModuloInt32.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuloInstruction.ModuloInt32>.NativeClassPtr, 100665861);
			}

			// Token: 0x06001969 RID: 6505 RVA: 0x0007AF08 File Offset: 0x00079108
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024937, XrefRangeEnd = 1024939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuloInstruction.ModuloInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600196A RID: 6506 RVA: 0x0007AF58 File Offset: 0x00079158
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ModuloInt32()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModuloInstruction.ModuloInt32>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuloInstruction.ModuloInt32.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600196B RID: 6507 RVA: 0x0000A14D File Offset: 0x0000834D
			public ModuloInt32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001175 RID: 4469
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001176 RID: 4470
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002C2 RID: 706
		public sealed class ModuloInt64 : ModuloInstruction
		{
			// Token: 0x0600196C RID: 6508 RVA: 0x0007AF94 File Offset: 0x00079194
			// Note: this type is marked as 'beforefieldinit'.
			static ModuloInt64()
			{
				Il2CppClassPointerStore<ModuloInstruction.ModuloInt64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ModuloInstruction>.NativeClassPtr, "ModuloInt64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModuloInstruction.ModuloInt64>.NativeClassPtr);
				ModuloInstruction.ModuloInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuloInstruction.ModuloInt64>.NativeClassPtr, 100665862);
				ModuloInstruction.ModuloInt64.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuloInstruction.ModuloInt64>.NativeClassPtr, 100665863);
			}

			// Token: 0x0600196D RID: 6509 RVA: 0x0007AFE8 File Offset: 0x000791E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024939, XrefRangeEnd = 1024941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuloInstruction.ModuloInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600196E RID: 6510 RVA: 0x0007B038 File Offset: 0x00079238
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ModuloInt64()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModuloInstruction.ModuloInt64>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuloInstruction.ModuloInt64.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600196F RID: 6511 RVA: 0x0000A156 File Offset: 0x00008356
			public ModuloInt64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001177 RID: 4471
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001178 RID: 4472
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002C3 RID: 707
		public sealed class ModuloUInt16 : ModuloInstruction
		{
			// Token: 0x06001970 RID: 6512 RVA: 0x0007B074 File Offset: 0x00079274
			// Note: this type is marked as 'beforefieldinit'.
			static ModuloUInt16()
			{
				Il2CppClassPointerStore<ModuloInstruction.ModuloUInt16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ModuloInstruction>.NativeClassPtr, "ModuloUInt16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModuloInstruction.ModuloUInt16>.NativeClassPtr);
				ModuloInstruction.ModuloUInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuloInstruction.ModuloUInt16>.NativeClassPtr, 100665864);
				ModuloInstruction.ModuloUInt16.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuloInstruction.ModuloUInt16>.NativeClassPtr, 100665865);
			}

			// Token: 0x06001971 RID: 6513 RVA: 0x0007B0C8 File Offset: 0x000792C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024941, XrefRangeEnd = 1024943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuloInstruction.ModuloUInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001972 RID: 6514 RVA: 0x0007B118 File Offset: 0x00079318
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ModuloUInt16()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModuloInstruction.ModuloUInt16>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuloInstruction.ModuloUInt16.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001973 RID: 6515 RVA: 0x0000A15F File Offset: 0x0000835F
			public ModuloUInt16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001179 RID: 4473
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x0400117A RID: 4474
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002C4 RID: 708
		public sealed class ModuloUInt32 : ModuloInstruction
		{
			// Token: 0x06001974 RID: 6516 RVA: 0x0007B154 File Offset: 0x00079354
			// Note: this type is marked as 'beforefieldinit'.
			static ModuloUInt32()
			{
				Il2CppClassPointerStore<ModuloInstruction.ModuloUInt32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ModuloInstruction>.NativeClassPtr, "ModuloUInt32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModuloInstruction.ModuloUInt32>.NativeClassPtr);
				ModuloInstruction.ModuloUInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuloInstruction.ModuloUInt32>.NativeClassPtr, 100665866);
				ModuloInstruction.ModuloUInt32.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuloInstruction.ModuloUInt32>.NativeClassPtr, 100665867);
			}

			// Token: 0x06001975 RID: 6517 RVA: 0x0007B1A8 File Offset: 0x000793A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024943, XrefRangeEnd = 1024945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuloInstruction.ModuloUInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001976 RID: 6518 RVA: 0x0007B1F8 File Offset: 0x000793F8
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ModuloUInt32()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModuloInstruction.ModuloUInt32>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuloInstruction.ModuloUInt32.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001977 RID: 6519 RVA: 0x0000A168 File Offset: 0x00008368
			public ModuloUInt32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400117B RID: 4475
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x0400117C RID: 4476
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002C5 RID: 709
		public sealed class ModuloUInt64 : ModuloInstruction
		{
			// Token: 0x06001978 RID: 6520 RVA: 0x0007B234 File Offset: 0x00079434
			// Note: this type is marked as 'beforefieldinit'.
			static ModuloUInt64()
			{
				Il2CppClassPointerStore<ModuloInstruction.ModuloUInt64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ModuloInstruction>.NativeClassPtr, "ModuloUInt64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModuloInstruction.ModuloUInt64>.NativeClassPtr);
				ModuloInstruction.ModuloUInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuloInstruction.ModuloUInt64>.NativeClassPtr, 100665868);
				ModuloInstruction.ModuloUInt64.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuloInstruction.ModuloUInt64>.NativeClassPtr, 100665869);
			}

			// Token: 0x06001979 RID: 6521 RVA: 0x0007B288 File Offset: 0x00079488
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024945, XrefRangeEnd = 1024947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuloInstruction.ModuloUInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600197A RID: 6522 RVA: 0x0007B2D8 File Offset: 0x000794D8
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ModuloUInt64()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModuloInstruction.ModuloUInt64>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuloInstruction.ModuloUInt64.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600197B RID: 6523 RVA: 0x0000A171 File Offset: 0x00008371
			public ModuloUInt64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400117D RID: 4477
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x0400117E RID: 4478
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002C6 RID: 710
		public sealed class ModuloSingle : ModuloInstruction
		{
			// Token: 0x0600197C RID: 6524 RVA: 0x0007B314 File Offset: 0x00079514
			// Note: this type is marked as 'beforefieldinit'.
			static ModuloSingle()
			{
				Il2CppClassPointerStore<ModuloInstruction.ModuloSingle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ModuloInstruction>.NativeClassPtr, "ModuloSingle");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModuloInstruction.ModuloSingle>.NativeClassPtr);
				ModuloInstruction.ModuloSingle.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuloInstruction.ModuloSingle>.NativeClassPtr, 100665870);
				ModuloInstruction.ModuloSingle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuloInstruction.ModuloSingle>.NativeClassPtr, 100665871);
			}

			// Token: 0x0600197D RID: 6525 RVA: 0x0007B368 File Offset: 0x00079568
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024947, XrefRangeEnd = 1024949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuloInstruction.ModuloSingle.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600197E RID: 6526 RVA: 0x0007B3B8 File Offset: 0x000795B8
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ModuloSingle()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModuloInstruction.ModuloSingle>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuloInstruction.ModuloSingle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600197F RID: 6527 RVA: 0x0000A17A File Offset: 0x0000837A
			public ModuloSingle(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400117F RID: 4479
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001180 RID: 4480
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002C7 RID: 711
		public sealed class ModuloDouble : ModuloInstruction
		{
			// Token: 0x06001980 RID: 6528 RVA: 0x0007B3F4 File Offset: 0x000795F4
			// Note: this type is marked as 'beforefieldinit'.
			static ModuloDouble()
			{
				Il2CppClassPointerStore<ModuloInstruction.ModuloDouble>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ModuloInstruction>.NativeClassPtr, "ModuloDouble");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModuloInstruction.ModuloDouble>.NativeClassPtr);
				ModuloInstruction.ModuloDouble.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuloInstruction.ModuloDouble>.NativeClassPtr, 100665872);
				ModuloInstruction.ModuloDouble.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuloInstruction.ModuloDouble>.NativeClassPtr, 100665873);
			}

			// Token: 0x06001981 RID: 6529 RVA: 0x0007B448 File Offset: 0x00079648
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024949, XrefRangeEnd = 1024951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuloInstruction.ModuloDouble.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001982 RID: 6530 RVA: 0x0007B498 File Offset: 0x00079698
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ModuloDouble()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModuloInstruction.ModuloDouble>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuloInstruction.ModuloDouble.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001983 RID: 6531 RVA: 0x0000A183 File Offset: 0x00008383
			public ModuloDouble(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001181 RID: 4481
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001182 RID: 4482
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
