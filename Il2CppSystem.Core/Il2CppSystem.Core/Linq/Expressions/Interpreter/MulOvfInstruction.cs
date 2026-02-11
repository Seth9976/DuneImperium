using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000EA RID: 234
	public class MulOvfInstruction : Instruction
	{
		// Token: 0x06000E22 RID: 3618 RVA: 0x0004E3CC File Offset: 0x0004C5CC
		// Note: this type is marked as 'beforefieldinit'.
		static MulOvfInstruction()
		{
			Il2CppClassPointerStore<MulOvfInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "MulOvfInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MulOvfInstruction>.NativeClassPtr);
			MulOvfInstruction.NativeFieldInfoPtr_s_Int16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MulOvfInstruction>.NativeClassPtr, "s_Int16");
			MulOvfInstruction.NativeFieldInfoPtr_s_Int32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MulOvfInstruction>.NativeClassPtr, "s_Int32");
			MulOvfInstruction.NativeFieldInfoPtr_s_Int64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MulOvfInstruction>.NativeClassPtr, "s_Int64");
			MulOvfInstruction.NativeFieldInfoPtr_s_UInt16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MulOvfInstruction>.NativeClassPtr, "s_UInt16");
			MulOvfInstruction.NativeFieldInfoPtr_s_UInt32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MulOvfInstruction>.NativeClassPtr, "s_UInt32");
			MulOvfInstruction.NativeFieldInfoPtr_s_UInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MulOvfInstruction>.NativeClassPtr, "s_UInt64");
			MulOvfInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulOvfInstruction>.NativeClassPtr, 100665895);
			MulOvfInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulOvfInstruction>.NativeClassPtr, 100665896);
			MulOvfInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulOvfInstruction>.NativeClassPtr, 100665897);
			MulOvfInstruction.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulOvfInstruction>.NativeClassPtr, 100665898);
			MulOvfInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulOvfInstruction>.NativeClassPtr, 100665899);
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06000E23 RID: 3619 RVA: 0x0004E4D8 File Offset: 0x0004C6D8
		public unsafe override int ConsumedStack
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 72978, RefRangeEnd = 72985, XrefRangeStart = 72978, XrefRangeEnd = 72985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MulOvfInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06000E24 RID: 3620 RVA: 0x0004E520 File Offset: 0x0004C720
		public unsafe override int ProducedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MulOvfInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06000E25 RID: 3621 RVA: 0x0004E568 File Offset: 0x0004C768
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025041, XrefRangeEnd = 1025043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MulOvfInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x0004E5AC File Offset: 0x0004C7AC
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MulOvfInstruction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MulOvfInstruction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulOvfInstruction.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x0004E5E8 File Offset: 0x0004C7E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1025065, RefRangeEnd = 1025067, XrefRangeStart = 1025043, XrefRangeEnd = 1025065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Instruction Create(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulOvfInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x00006488 File Offset: 0x00004688
		public MulOvfInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06000E29 RID: 3625 RVA: 0x0004E62C File Offset: 0x0004C82C
		// (set) Token: 0x06000E2A RID: 3626 RVA: 0x00006491 File Offset: 0x00004691
		public unsafe static Instruction s_Int16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MulOvfInstruction.NativeFieldInfoPtr_s_Int16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MulOvfInstruction.NativeFieldInfoPtr_s_Int16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06000E2B RID: 3627 RVA: 0x0004E654 File Offset: 0x0004C854
		// (set) Token: 0x06000E2C RID: 3628 RVA: 0x000064A3 File Offset: 0x000046A3
		public unsafe static Instruction s_Int32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MulOvfInstruction.NativeFieldInfoPtr_s_Int32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MulOvfInstruction.NativeFieldInfoPtr_s_Int32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06000E2D RID: 3629 RVA: 0x0004E67C File Offset: 0x0004C87C
		// (set) Token: 0x06000E2E RID: 3630 RVA: 0x000064B5 File Offset: 0x000046B5
		public unsafe static Instruction s_Int64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MulOvfInstruction.NativeFieldInfoPtr_s_Int64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MulOvfInstruction.NativeFieldInfoPtr_s_Int64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06000E2F RID: 3631 RVA: 0x0004E6A4 File Offset: 0x0004C8A4
		// (set) Token: 0x06000E30 RID: 3632 RVA: 0x000064C7 File Offset: 0x000046C7
		public unsafe static Instruction s_UInt16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MulOvfInstruction.NativeFieldInfoPtr_s_UInt16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MulOvfInstruction.NativeFieldInfoPtr_s_UInt16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06000E31 RID: 3633 RVA: 0x0004E6CC File Offset: 0x0004C8CC
		// (set) Token: 0x06000E32 RID: 3634 RVA: 0x000064D9 File Offset: 0x000046D9
		public unsafe static Instruction s_UInt32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MulOvfInstruction.NativeFieldInfoPtr_s_UInt32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MulOvfInstruction.NativeFieldInfoPtr_s_UInt32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06000E33 RID: 3635 RVA: 0x0004E6F4 File Offset: 0x0004C8F4
		// (set) Token: 0x06000E34 RID: 3636 RVA: 0x000064EB File Offset: 0x000046EB
		public unsafe static Instruction s_UInt64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MulOvfInstruction.NativeFieldInfoPtr_s_UInt64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MulOvfInstruction.NativeFieldInfoPtr_s_UInt64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A5F RID: 2655
		private static readonly IntPtr NativeFieldInfoPtr_s_Int16;

		// Token: 0x04000A60 RID: 2656
		private static readonly IntPtr NativeFieldInfoPtr_s_Int32;

		// Token: 0x04000A61 RID: 2657
		private static readonly IntPtr NativeFieldInfoPtr_s_Int64;

		// Token: 0x04000A62 RID: 2658
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt16;

		// Token: 0x04000A63 RID: 2659
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt32;

		// Token: 0x04000A64 RID: 2660
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt64;

		// Token: 0x04000A65 RID: 2661
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000A66 RID: 2662
		private static readonly IntPtr NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000A67 RID: 2663
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x04000A68 RID: 2664
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000A69 RID: 2665
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0;

		// Token: 0x020002D0 RID: 720
		public sealed class MulOvfInt16 : MulOvfInstruction
		{
			// Token: 0x060019A4 RID: 6564 RVA: 0x0007BBD4 File Offset: 0x00079DD4
			// Note: this type is marked as 'beforefieldinit'.
			static MulOvfInt16()
			{
				Il2CppClassPointerStore<MulOvfInstruction.MulOvfInt16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MulOvfInstruction>.NativeClassPtr, "MulOvfInt16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MulOvfInstruction.MulOvfInt16>.NativeClassPtr);
				MulOvfInstruction.MulOvfInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulOvfInstruction.MulOvfInt16>.NativeClassPtr, 100665900);
				MulOvfInstruction.MulOvfInt16.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulOvfInstruction.MulOvfInt16>.NativeClassPtr, 100665901);
			}

			// Token: 0x060019A5 RID: 6565 RVA: 0x0007BC28 File Offset: 0x00079E28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025023, XrefRangeEnd = 1025026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulOvfInstruction.MulOvfInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060019A6 RID: 6566 RVA: 0x0007BC78 File Offset: 0x00079E78
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MulOvfInt16()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MulOvfInstruction.MulOvfInt16>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulOvfInstruction.MulOvfInt16.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019A7 RID: 6567 RVA: 0x0000A1D4 File Offset: 0x000083D4
			public MulOvfInt16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001193 RID: 4499
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001194 RID: 4500
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002D1 RID: 721
		public sealed class MulOvfInt32 : MulOvfInstruction
		{
			// Token: 0x060019A8 RID: 6568 RVA: 0x0007BCB4 File Offset: 0x00079EB4
			// Note: this type is marked as 'beforefieldinit'.
			static MulOvfInt32()
			{
				Il2CppClassPointerStore<MulOvfInstruction.MulOvfInt32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MulOvfInstruction>.NativeClassPtr, "MulOvfInt32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MulOvfInstruction.MulOvfInt32>.NativeClassPtr);
				MulOvfInstruction.MulOvfInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulOvfInstruction.MulOvfInt32>.NativeClassPtr, 100665902);
				MulOvfInstruction.MulOvfInt32.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulOvfInstruction.MulOvfInt32>.NativeClassPtr, 100665903);
			}

			// Token: 0x060019A9 RID: 6569 RVA: 0x0007BD08 File Offset: 0x00079F08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025026, XrefRangeEnd = 1025029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulOvfInstruction.MulOvfInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060019AA RID: 6570 RVA: 0x0007BD58 File Offset: 0x00079F58
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MulOvfInt32()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MulOvfInstruction.MulOvfInt32>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulOvfInstruction.MulOvfInt32.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019AB RID: 6571 RVA: 0x0000A1DD File Offset: 0x000083DD
			public MulOvfInt32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001195 RID: 4501
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001196 RID: 4502
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002D2 RID: 722
		public sealed class MulOvfInt64 : MulOvfInstruction
		{
			// Token: 0x060019AC RID: 6572 RVA: 0x0007BD94 File Offset: 0x00079F94
			// Note: this type is marked as 'beforefieldinit'.
			static MulOvfInt64()
			{
				Il2CppClassPointerStore<MulOvfInstruction.MulOvfInt64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MulOvfInstruction>.NativeClassPtr, "MulOvfInt64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MulOvfInstruction.MulOvfInt64>.NativeClassPtr);
				MulOvfInstruction.MulOvfInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulOvfInstruction.MulOvfInt64>.NativeClassPtr, 100665904);
				MulOvfInstruction.MulOvfInt64.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulOvfInstruction.MulOvfInt64>.NativeClassPtr, 100665905);
			}

			// Token: 0x060019AD RID: 6573 RVA: 0x0007BDE8 File Offset: 0x00079FE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025029, XrefRangeEnd = 1025032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulOvfInstruction.MulOvfInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060019AE RID: 6574 RVA: 0x0007BE38 File Offset: 0x0007A038
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MulOvfInt64()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MulOvfInstruction.MulOvfInt64>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulOvfInstruction.MulOvfInt64.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019AF RID: 6575 RVA: 0x0000A1E6 File Offset: 0x000083E6
			public MulOvfInt64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001197 RID: 4503
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001198 RID: 4504
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002D3 RID: 723
		public sealed class MulOvfUInt16 : MulOvfInstruction
		{
			// Token: 0x060019B0 RID: 6576 RVA: 0x0007BE74 File Offset: 0x0007A074
			// Note: this type is marked as 'beforefieldinit'.
			static MulOvfUInt16()
			{
				Il2CppClassPointerStore<MulOvfInstruction.MulOvfUInt16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MulOvfInstruction>.NativeClassPtr, "MulOvfUInt16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MulOvfInstruction.MulOvfUInt16>.NativeClassPtr);
				MulOvfInstruction.MulOvfUInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulOvfInstruction.MulOvfUInt16>.NativeClassPtr, 100665906);
				MulOvfInstruction.MulOvfUInt16.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulOvfInstruction.MulOvfUInt16>.NativeClassPtr, 100665907);
			}

			// Token: 0x060019B1 RID: 6577 RVA: 0x0007BEC8 File Offset: 0x0007A0C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025032, XrefRangeEnd = 1025035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulOvfInstruction.MulOvfUInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060019B2 RID: 6578 RVA: 0x0007BF18 File Offset: 0x0007A118
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MulOvfUInt16()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MulOvfInstruction.MulOvfUInt16>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulOvfInstruction.MulOvfUInt16.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019B3 RID: 6579 RVA: 0x0000A1EF File Offset: 0x000083EF
			public MulOvfUInt16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001199 RID: 4505
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x0400119A RID: 4506
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002D4 RID: 724
		public sealed class MulOvfUInt32 : MulOvfInstruction
		{
			// Token: 0x060019B4 RID: 6580 RVA: 0x0007BF54 File Offset: 0x0007A154
			// Note: this type is marked as 'beforefieldinit'.
			static MulOvfUInt32()
			{
				Il2CppClassPointerStore<MulOvfInstruction.MulOvfUInt32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MulOvfInstruction>.NativeClassPtr, "MulOvfUInt32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MulOvfInstruction.MulOvfUInt32>.NativeClassPtr);
				MulOvfInstruction.MulOvfUInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulOvfInstruction.MulOvfUInt32>.NativeClassPtr, 100665908);
				MulOvfInstruction.MulOvfUInt32.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulOvfInstruction.MulOvfUInt32>.NativeClassPtr, 100665909);
			}

			// Token: 0x060019B5 RID: 6581 RVA: 0x0007BFA8 File Offset: 0x0007A1A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025035, XrefRangeEnd = 1025038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulOvfInstruction.MulOvfUInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060019B6 RID: 6582 RVA: 0x0007BFF8 File Offset: 0x0007A1F8
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MulOvfUInt32()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MulOvfInstruction.MulOvfUInt32>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulOvfInstruction.MulOvfUInt32.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019B7 RID: 6583 RVA: 0x0000A1F8 File Offset: 0x000083F8
			public MulOvfUInt32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400119B RID: 4507
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x0400119C RID: 4508
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002D5 RID: 725
		public sealed class MulOvfUInt64 : MulOvfInstruction
		{
			// Token: 0x060019B8 RID: 6584 RVA: 0x0007C034 File Offset: 0x0007A234
			// Note: this type is marked as 'beforefieldinit'.
			static MulOvfUInt64()
			{
				Il2CppClassPointerStore<MulOvfInstruction.MulOvfUInt64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MulOvfInstruction>.NativeClassPtr, "MulOvfUInt64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MulOvfInstruction.MulOvfUInt64>.NativeClassPtr);
				MulOvfInstruction.MulOvfUInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulOvfInstruction.MulOvfUInt64>.NativeClassPtr, 100665910);
				MulOvfInstruction.MulOvfUInt64.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulOvfInstruction.MulOvfUInt64>.NativeClassPtr, 100665911);
			}

			// Token: 0x060019B9 RID: 6585 RVA: 0x0007C088 File Offset: 0x0007A288
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025038, XrefRangeEnd = 1025041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulOvfInstruction.MulOvfUInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060019BA RID: 6586 RVA: 0x0007C0D8 File Offset: 0x0007A2D8
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MulOvfUInt64()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MulOvfInstruction.MulOvfUInt64>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulOvfInstruction.MulOvfUInt64.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019BB RID: 6587 RVA: 0x0000A201 File Offset: 0x00008401
			public MulOvfUInt64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400119D RID: 4509
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x0400119E RID: 4510
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
