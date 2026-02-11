using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000E9 RID: 233
	public class MulInstruction : Instruction
	{
		// Token: 0x06000E0B RID: 3595 RVA: 0x0004E004 File Offset: 0x0004C204
		// Note: this type is marked as 'beforefieldinit'.
		static MulInstruction()
		{
			Il2CppClassPointerStore<MulInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "MulInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MulInstruction>.NativeClassPtr);
			MulInstruction.NativeFieldInfoPtr_s_Int16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MulInstruction>.NativeClassPtr, "s_Int16");
			MulInstruction.NativeFieldInfoPtr_s_Int32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MulInstruction>.NativeClassPtr, "s_Int32");
			MulInstruction.NativeFieldInfoPtr_s_Int64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MulInstruction>.NativeClassPtr, "s_Int64");
			MulInstruction.NativeFieldInfoPtr_s_UInt16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MulInstruction>.NativeClassPtr, "s_UInt16");
			MulInstruction.NativeFieldInfoPtr_s_UInt32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MulInstruction>.NativeClassPtr, "s_UInt32");
			MulInstruction.NativeFieldInfoPtr_s_UInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MulInstruction>.NativeClassPtr, "s_UInt64");
			MulInstruction.NativeFieldInfoPtr_s_Single = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MulInstruction>.NativeClassPtr, "s_Single");
			MulInstruction.NativeFieldInfoPtr_s_Double = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MulInstruction>.NativeClassPtr, "s_Double");
			MulInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulInstruction>.NativeClassPtr, 100665874);
			MulInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulInstruction>.NativeClassPtr, 100665875);
			MulInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulInstruction>.NativeClassPtr, 100665876);
			MulInstruction.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulInstruction>.NativeClassPtr, 100665877);
			MulInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulInstruction>.NativeClassPtr, 100665878);
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06000E0C RID: 3596 RVA: 0x0004E138 File Offset: 0x0004C338
		public unsafe override int ConsumedStack
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 72978, RefRangeEnd = 72985, XrefRangeStart = 72978, XrefRangeEnd = 72985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MulInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06000E0D RID: 3597 RVA: 0x0004E180 File Offset: 0x0004C380
		public unsafe override int ProducedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MulInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06000E0E RID: 3598 RVA: 0x0004E1C8 File Offset: 0x0004C3C8
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024995, XrefRangeEnd = 1024997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MulInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x0004E20C File Offset: 0x0004C40C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MulInstruction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MulInstruction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulInstruction.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x0004E248 File Offset: 0x0004C448
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1025021, RefRangeEnd = 1025023, XrefRangeStart = 1024997, XrefRangeEnd = 1025021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Instruction Create(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x000063EF File Offset: 0x000045EF
		public MulInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06000E12 RID: 3602 RVA: 0x0004E28C File Offset: 0x0004C48C
		// (set) Token: 0x06000E13 RID: 3603 RVA: 0x000063F8 File Offset: 0x000045F8
		public unsafe static Instruction s_Int16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MulInstruction.NativeFieldInfoPtr_s_Int16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MulInstruction.NativeFieldInfoPtr_s_Int16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06000E14 RID: 3604 RVA: 0x0004E2B4 File Offset: 0x0004C4B4
		// (set) Token: 0x06000E15 RID: 3605 RVA: 0x0000640A File Offset: 0x0000460A
		public unsafe static Instruction s_Int32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MulInstruction.NativeFieldInfoPtr_s_Int32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MulInstruction.NativeFieldInfoPtr_s_Int32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06000E16 RID: 3606 RVA: 0x0004E2DC File Offset: 0x0004C4DC
		// (set) Token: 0x06000E17 RID: 3607 RVA: 0x0000641C File Offset: 0x0000461C
		public unsafe static Instruction s_Int64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MulInstruction.NativeFieldInfoPtr_s_Int64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MulInstruction.NativeFieldInfoPtr_s_Int64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06000E18 RID: 3608 RVA: 0x0004E304 File Offset: 0x0004C504
		// (set) Token: 0x06000E19 RID: 3609 RVA: 0x0000642E File Offset: 0x0000462E
		public unsafe static Instruction s_UInt16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MulInstruction.NativeFieldInfoPtr_s_UInt16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MulInstruction.NativeFieldInfoPtr_s_UInt16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06000E1A RID: 3610 RVA: 0x0004E32C File Offset: 0x0004C52C
		// (set) Token: 0x06000E1B RID: 3611 RVA: 0x00006440 File Offset: 0x00004640
		public unsafe static Instruction s_UInt32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MulInstruction.NativeFieldInfoPtr_s_UInt32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MulInstruction.NativeFieldInfoPtr_s_UInt32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06000E1C RID: 3612 RVA: 0x0004E354 File Offset: 0x0004C554
		// (set) Token: 0x06000E1D RID: 3613 RVA: 0x00006452 File Offset: 0x00004652
		public unsafe static Instruction s_UInt64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MulInstruction.NativeFieldInfoPtr_s_UInt64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MulInstruction.NativeFieldInfoPtr_s_UInt64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06000E1E RID: 3614 RVA: 0x0004E37C File Offset: 0x0004C57C
		// (set) Token: 0x06000E1F RID: 3615 RVA: 0x00006464 File Offset: 0x00004664
		public unsafe static Instruction s_Single
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MulInstruction.NativeFieldInfoPtr_s_Single, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MulInstruction.NativeFieldInfoPtr_s_Single, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06000E20 RID: 3616 RVA: 0x0004E3A4 File Offset: 0x0004C5A4
		// (set) Token: 0x06000E21 RID: 3617 RVA: 0x00006476 File Offset: 0x00004676
		public unsafe static Instruction s_Double
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MulInstruction.NativeFieldInfoPtr_s_Double, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MulInstruction.NativeFieldInfoPtr_s_Double, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A52 RID: 2642
		private static readonly IntPtr NativeFieldInfoPtr_s_Int16;

		// Token: 0x04000A53 RID: 2643
		private static readonly IntPtr NativeFieldInfoPtr_s_Int32;

		// Token: 0x04000A54 RID: 2644
		private static readonly IntPtr NativeFieldInfoPtr_s_Int64;

		// Token: 0x04000A55 RID: 2645
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt16;

		// Token: 0x04000A56 RID: 2646
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt32;

		// Token: 0x04000A57 RID: 2647
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt64;

		// Token: 0x04000A58 RID: 2648
		private static readonly IntPtr NativeFieldInfoPtr_s_Single;

		// Token: 0x04000A59 RID: 2649
		private static readonly IntPtr NativeFieldInfoPtr_s_Double;

		// Token: 0x04000A5A RID: 2650
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000A5B RID: 2651
		private static readonly IntPtr NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000A5C RID: 2652
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x04000A5D RID: 2653
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000A5E RID: 2654
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0;

		// Token: 0x020002C8 RID: 712
		public sealed class MulInt16 : MulInstruction
		{
			// Token: 0x06001984 RID: 6532 RVA: 0x0007B4D4 File Offset: 0x000796D4
			// Note: this type is marked as 'beforefieldinit'.
			static MulInt16()
			{
				Il2CppClassPointerStore<MulInstruction.MulInt16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MulInstruction>.NativeClassPtr, "MulInt16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MulInstruction.MulInt16>.NativeClassPtr);
				MulInstruction.MulInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulInstruction.MulInt16>.NativeClassPtr, 100665879);
				MulInstruction.MulInt16.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulInstruction.MulInt16>.NativeClassPtr, 100665880);
			}

			// Token: 0x06001985 RID: 6533 RVA: 0x0007B528 File Offset: 0x00079728
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024979, XrefRangeEnd = 1024981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulInstruction.MulInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001986 RID: 6534 RVA: 0x0007B578 File Offset: 0x00079778
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MulInt16()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MulInstruction.MulInt16>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulInstruction.MulInt16.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001987 RID: 6535 RVA: 0x0000A18C File Offset: 0x0000838C
			public MulInt16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001183 RID: 4483
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001184 RID: 4484
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002C9 RID: 713
		public sealed class MulInt32 : MulInstruction
		{
			// Token: 0x06001988 RID: 6536 RVA: 0x0007B5B4 File Offset: 0x000797B4
			// Note: this type is marked as 'beforefieldinit'.
			static MulInt32()
			{
				Il2CppClassPointerStore<MulInstruction.MulInt32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MulInstruction>.NativeClassPtr, "MulInt32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MulInstruction.MulInt32>.NativeClassPtr);
				MulInstruction.MulInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulInstruction.MulInt32>.NativeClassPtr, 100665881);
				MulInstruction.MulInt32.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulInstruction.MulInt32>.NativeClassPtr, 100665882);
			}

			// Token: 0x06001989 RID: 6537 RVA: 0x0007B608 File Offset: 0x00079808
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024981, XrefRangeEnd = 1024983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulInstruction.MulInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600198A RID: 6538 RVA: 0x0007B658 File Offset: 0x00079858
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MulInt32()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MulInstruction.MulInt32>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulInstruction.MulInt32.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600198B RID: 6539 RVA: 0x0000A195 File Offset: 0x00008395
			public MulInt32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001185 RID: 4485
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001186 RID: 4486
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002CA RID: 714
		public sealed class MulInt64 : MulInstruction
		{
			// Token: 0x0600198C RID: 6540 RVA: 0x0007B694 File Offset: 0x00079894
			// Note: this type is marked as 'beforefieldinit'.
			static MulInt64()
			{
				Il2CppClassPointerStore<MulInstruction.MulInt64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MulInstruction>.NativeClassPtr, "MulInt64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MulInstruction.MulInt64>.NativeClassPtr);
				MulInstruction.MulInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulInstruction.MulInt64>.NativeClassPtr, 100665883);
				MulInstruction.MulInt64.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulInstruction.MulInt64>.NativeClassPtr, 100665884);
			}

			// Token: 0x0600198D RID: 6541 RVA: 0x0007B6E8 File Offset: 0x000798E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024983, XrefRangeEnd = 1024985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulInstruction.MulInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600198E RID: 6542 RVA: 0x0007B738 File Offset: 0x00079938
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MulInt64()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MulInstruction.MulInt64>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulInstruction.MulInt64.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600198F RID: 6543 RVA: 0x0000A19E File Offset: 0x0000839E
			public MulInt64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001187 RID: 4487
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001188 RID: 4488
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002CB RID: 715
		public sealed class MulUInt16 : MulInstruction
		{
			// Token: 0x06001990 RID: 6544 RVA: 0x0007B774 File Offset: 0x00079974
			// Note: this type is marked as 'beforefieldinit'.
			static MulUInt16()
			{
				Il2CppClassPointerStore<MulInstruction.MulUInt16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MulInstruction>.NativeClassPtr, "MulUInt16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MulInstruction.MulUInt16>.NativeClassPtr);
				MulInstruction.MulUInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulInstruction.MulUInt16>.NativeClassPtr, 100665885);
				MulInstruction.MulUInt16.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulInstruction.MulUInt16>.NativeClassPtr, 100665886);
			}

			// Token: 0x06001991 RID: 6545 RVA: 0x0007B7C8 File Offset: 0x000799C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024985, XrefRangeEnd = 1024987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulInstruction.MulUInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001992 RID: 6546 RVA: 0x0007B818 File Offset: 0x00079A18
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MulUInt16()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MulInstruction.MulUInt16>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulInstruction.MulUInt16.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001993 RID: 6547 RVA: 0x0000A1A7 File Offset: 0x000083A7
			public MulUInt16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001189 RID: 4489
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x0400118A RID: 4490
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002CC RID: 716
		public sealed class MulUInt32 : MulInstruction
		{
			// Token: 0x06001994 RID: 6548 RVA: 0x0007B854 File Offset: 0x00079A54
			// Note: this type is marked as 'beforefieldinit'.
			static MulUInt32()
			{
				Il2CppClassPointerStore<MulInstruction.MulUInt32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MulInstruction>.NativeClassPtr, "MulUInt32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MulInstruction.MulUInt32>.NativeClassPtr);
				MulInstruction.MulUInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulInstruction.MulUInt32>.NativeClassPtr, 100665887);
				MulInstruction.MulUInt32.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulInstruction.MulUInt32>.NativeClassPtr, 100665888);
			}

			// Token: 0x06001995 RID: 6549 RVA: 0x0007B8A8 File Offset: 0x00079AA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024987, XrefRangeEnd = 1024989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulInstruction.MulUInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001996 RID: 6550 RVA: 0x0007B8F8 File Offset: 0x00079AF8
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MulUInt32()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MulInstruction.MulUInt32>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulInstruction.MulUInt32.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001997 RID: 6551 RVA: 0x0000A1B0 File Offset: 0x000083B0
			public MulUInt32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400118B RID: 4491
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x0400118C RID: 4492
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002CD RID: 717
		public sealed class MulUInt64 : MulInstruction
		{
			// Token: 0x06001998 RID: 6552 RVA: 0x0007B934 File Offset: 0x00079B34
			// Note: this type is marked as 'beforefieldinit'.
			static MulUInt64()
			{
				Il2CppClassPointerStore<MulInstruction.MulUInt64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MulInstruction>.NativeClassPtr, "MulUInt64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MulInstruction.MulUInt64>.NativeClassPtr);
				MulInstruction.MulUInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulInstruction.MulUInt64>.NativeClassPtr, 100665889);
				MulInstruction.MulUInt64.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulInstruction.MulUInt64>.NativeClassPtr, 100665890);
			}

			// Token: 0x06001999 RID: 6553 RVA: 0x0007B988 File Offset: 0x00079B88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024989, XrefRangeEnd = 1024991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulInstruction.MulUInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600199A RID: 6554 RVA: 0x0007B9D8 File Offset: 0x00079BD8
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MulUInt64()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MulInstruction.MulUInt64>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulInstruction.MulUInt64.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600199B RID: 6555 RVA: 0x0000A1B9 File Offset: 0x000083B9
			public MulUInt64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400118D RID: 4493
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x0400118E RID: 4494
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002CE RID: 718
		public sealed class MulSingle : MulInstruction
		{
			// Token: 0x0600199C RID: 6556 RVA: 0x0007BA14 File Offset: 0x00079C14
			// Note: this type is marked as 'beforefieldinit'.
			static MulSingle()
			{
				Il2CppClassPointerStore<MulInstruction.MulSingle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MulInstruction>.NativeClassPtr, "MulSingle");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MulInstruction.MulSingle>.NativeClassPtr);
				MulInstruction.MulSingle.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulInstruction.MulSingle>.NativeClassPtr, 100665891);
				MulInstruction.MulSingle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulInstruction.MulSingle>.NativeClassPtr, 100665892);
			}

			// Token: 0x0600199D RID: 6557 RVA: 0x0007BA68 File Offset: 0x00079C68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024991, XrefRangeEnd = 1024993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulInstruction.MulSingle.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600199E RID: 6558 RVA: 0x0007BAB8 File Offset: 0x00079CB8
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MulSingle()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MulInstruction.MulSingle>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulInstruction.MulSingle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600199F RID: 6559 RVA: 0x0000A1C2 File Offset: 0x000083C2
			public MulSingle(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400118F RID: 4495
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001190 RID: 4496
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002CF RID: 719
		public sealed class MulDouble : MulInstruction
		{
			// Token: 0x060019A0 RID: 6560 RVA: 0x0007BAF4 File Offset: 0x00079CF4
			// Note: this type is marked as 'beforefieldinit'.
			static MulDouble()
			{
				Il2CppClassPointerStore<MulInstruction.MulDouble>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MulInstruction>.NativeClassPtr, "MulDouble");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MulInstruction.MulDouble>.NativeClassPtr);
				MulInstruction.MulDouble.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulInstruction.MulDouble>.NativeClassPtr, 100665893);
				MulInstruction.MulDouble.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulInstruction.MulDouble>.NativeClassPtr, 100665894);
			}

			// Token: 0x060019A1 RID: 6561 RVA: 0x0007BB48 File Offset: 0x00079D48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024993, XrefRangeEnd = 1024995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulInstruction.MulDouble.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060019A2 RID: 6562 RVA: 0x0007BB98 File Offset: 0x00079D98
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MulDouble()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MulInstruction.MulDouble>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulInstruction.MulDouble.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019A3 RID: 6563 RVA: 0x0000A1CB File Offset: 0x000083CB
			public MulDouble(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001191 RID: 4497
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001192 RID: 4498
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
