using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000EB RID: 235
	public class NegateInstruction : Instruction
	{
		// Token: 0x06000E35 RID: 3637 RVA: 0x0004E71C File Offset: 0x0004C91C
		// Note: this type is marked as 'beforefieldinit'.
		static NegateInstruction()
		{
			Il2CppClassPointerStore<NegateInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "NegateInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NegateInstruction>.NativeClassPtr);
			NegateInstruction.NativeFieldInfoPtr_s_Int16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NegateInstruction>.NativeClassPtr, "s_Int16");
			NegateInstruction.NativeFieldInfoPtr_s_Int32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NegateInstruction>.NativeClassPtr, "s_Int32");
			NegateInstruction.NativeFieldInfoPtr_s_Int64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NegateInstruction>.NativeClassPtr, "s_Int64");
			NegateInstruction.NativeFieldInfoPtr_s_Single = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NegateInstruction>.NativeClassPtr, "s_Single");
			NegateInstruction.NativeFieldInfoPtr_s_Double = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NegateInstruction>.NativeClassPtr, "s_Double");
			NegateInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NegateInstruction>.NativeClassPtr, 100665912);
			NegateInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NegateInstruction>.NativeClassPtr, 100665913);
			NegateInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NegateInstruction>.NativeClassPtr, 100665914);
			NegateInstruction.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NegateInstruction>.NativeClassPtr, 100665915);
			NegateInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NegateInstruction>.NativeClassPtr, 100665916);
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06000E36 RID: 3638 RVA: 0x0004E814 File Offset: 0x0004CA14
		public unsafe override int ConsumedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NegateInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06000E37 RID: 3639 RVA: 0x0004E85C File Offset: 0x0004CA5C
		public unsafe override int ProducedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NegateInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06000E38 RID: 3640 RVA: 0x0004E8A4 File Offset: 0x0004CAA4
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025101, XrefRangeEnd = 1025103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NegateInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x0004E8E8 File Offset: 0x0004CAE8
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NegateInstruction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NegateInstruction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NegateInstruction.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x0004E924 File Offset: 0x0004CB24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1025124, RefRangeEnd = 1025126, XrefRangeStart = 1025103, XrefRangeEnd = 1025124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Instruction Create(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NegateInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x000064FD File Offset: 0x000046FD
		public NegateInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06000E3C RID: 3644 RVA: 0x0004E968 File Offset: 0x0004CB68
		// (set) Token: 0x06000E3D RID: 3645 RVA: 0x00006506 File Offset: 0x00004706
		public unsafe static Instruction s_Int16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NegateInstruction.NativeFieldInfoPtr_s_Int16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NegateInstruction.NativeFieldInfoPtr_s_Int16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06000E3E RID: 3646 RVA: 0x0004E990 File Offset: 0x0004CB90
		// (set) Token: 0x06000E3F RID: 3647 RVA: 0x00006518 File Offset: 0x00004718
		public unsafe static Instruction s_Int32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NegateInstruction.NativeFieldInfoPtr_s_Int32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NegateInstruction.NativeFieldInfoPtr_s_Int32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06000E40 RID: 3648 RVA: 0x0004E9B8 File Offset: 0x0004CBB8
		// (set) Token: 0x06000E41 RID: 3649 RVA: 0x0000652A File Offset: 0x0000472A
		public unsafe static Instruction s_Int64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NegateInstruction.NativeFieldInfoPtr_s_Int64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NegateInstruction.NativeFieldInfoPtr_s_Int64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06000E42 RID: 3650 RVA: 0x0004E9E0 File Offset: 0x0004CBE0
		// (set) Token: 0x06000E43 RID: 3651 RVA: 0x0000653C File Offset: 0x0000473C
		public unsafe static Instruction s_Single
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NegateInstruction.NativeFieldInfoPtr_s_Single, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NegateInstruction.NativeFieldInfoPtr_s_Single, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06000E44 RID: 3652 RVA: 0x0004EA08 File Offset: 0x0004CC08
		// (set) Token: 0x06000E45 RID: 3653 RVA: 0x0000654E File Offset: 0x0000474E
		public unsafe static Instruction s_Double
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NegateInstruction.NativeFieldInfoPtr_s_Double, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NegateInstruction.NativeFieldInfoPtr_s_Double, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A6A RID: 2666
		private static readonly IntPtr NativeFieldInfoPtr_s_Int16;

		// Token: 0x04000A6B RID: 2667
		private static readonly IntPtr NativeFieldInfoPtr_s_Int32;

		// Token: 0x04000A6C RID: 2668
		private static readonly IntPtr NativeFieldInfoPtr_s_Int64;

		// Token: 0x04000A6D RID: 2669
		private static readonly IntPtr NativeFieldInfoPtr_s_Single;

		// Token: 0x04000A6E RID: 2670
		private static readonly IntPtr NativeFieldInfoPtr_s_Double;

		// Token: 0x04000A6F RID: 2671
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000A70 RID: 2672
		private static readonly IntPtr NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000A71 RID: 2673
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x04000A72 RID: 2674
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000A73 RID: 2675
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0;

		// Token: 0x020002D6 RID: 726
		public sealed class NegateInt16 : NegateInstruction
		{
			// Token: 0x060019BC RID: 6588 RVA: 0x0007C114 File Offset: 0x0007A314
			// Note: this type is marked as 'beforefieldinit'.
			static NegateInt16()
			{
				Il2CppClassPointerStore<NegateInstruction.NegateInt16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NegateInstruction>.NativeClassPtr, "NegateInt16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NegateInstruction.NegateInt16>.NativeClassPtr);
				NegateInstruction.NegateInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NegateInstruction.NegateInt16>.NativeClassPtr, 100665917);
				NegateInstruction.NegateInt16.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NegateInstruction.NegateInt16>.NativeClassPtr, 100665918);
			}

			// Token: 0x060019BD RID: 6589 RVA: 0x0007C168 File Offset: 0x0007A368
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025067, XrefRangeEnd = 1025072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NegateInstruction.NegateInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060019BE RID: 6590 RVA: 0x0007C1B8 File Offset: 0x0007A3B8
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NegateInt16()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NegateInstruction.NegateInt16>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NegateInstruction.NegateInt16.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019BF RID: 6591 RVA: 0x0000A20A File Offset: 0x0000840A
			public NegateInt16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400119F RID: 4511
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x040011A0 RID: 4512
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002D7 RID: 727
		public sealed class NegateInt32 : NegateInstruction
		{
			// Token: 0x060019C0 RID: 6592 RVA: 0x0007C1F4 File Offset: 0x0007A3F4
			// Note: this type is marked as 'beforefieldinit'.
			static NegateInt32()
			{
				Il2CppClassPointerStore<NegateInstruction.NegateInt32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NegateInstruction>.NativeClassPtr, "NegateInt32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NegateInstruction.NegateInt32>.NativeClassPtr);
				NegateInstruction.NegateInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NegateInstruction.NegateInt32>.NativeClassPtr, 100665919);
				NegateInstruction.NegateInt32.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NegateInstruction.NegateInt32>.NativeClassPtr, 100665920);
			}

			// Token: 0x060019C1 RID: 6593 RVA: 0x0007C248 File Offset: 0x0007A448
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025072, XrefRangeEnd = 1025077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NegateInstruction.NegateInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060019C2 RID: 6594 RVA: 0x0007C298 File Offset: 0x0007A498
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NegateInt32()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NegateInstruction.NegateInt32>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NegateInstruction.NegateInt32.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019C3 RID: 6595 RVA: 0x0000A213 File Offset: 0x00008413
			public NegateInt32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040011A1 RID: 4513
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x040011A2 RID: 4514
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002D8 RID: 728
		public sealed class NegateInt64 : NegateInstruction
		{
			// Token: 0x060019C4 RID: 6596 RVA: 0x0007C2D4 File Offset: 0x0007A4D4
			// Note: this type is marked as 'beforefieldinit'.
			static NegateInt64()
			{
				Il2CppClassPointerStore<NegateInstruction.NegateInt64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NegateInstruction>.NativeClassPtr, "NegateInt64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NegateInstruction.NegateInt64>.NativeClassPtr);
				NegateInstruction.NegateInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NegateInstruction.NegateInt64>.NativeClassPtr, 100665921);
				NegateInstruction.NegateInt64.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NegateInstruction.NegateInt64>.NativeClassPtr, 100665922);
			}

			// Token: 0x060019C5 RID: 6597 RVA: 0x0007C328 File Offset: 0x0007A528
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025077, XrefRangeEnd = 1025085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NegateInstruction.NegateInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060019C6 RID: 6598 RVA: 0x0007C378 File Offset: 0x0007A578
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NegateInt64()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NegateInstruction.NegateInt64>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NegateInstruction.NegateInt64.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019C7 RID: 6599 RVA: 0x0000A21C File Offset: 0x0000841C
			public NegateInt64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040011A3 RID: 4515
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x040011A4 RID: 4516
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002D9 RID: 729
		public sealed class NegateSingle : NegateInstruction
		{
			// Token: 0x060019C8 RID: 6600 RVA: 0x0007C3B4 File Offset: 0x0007A5B4
			// Note: this type is marked as 'beforefieldinit'.
			static NegateSingle()
			{
				Il2CppClassPointerStore<NegateInstruction.NegateSingle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NegateInstruction>.NativeClassPtr, "NegateSingle");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NegateInstruction.NegateSingle>.NativeClassPtr);
				NegateInstruction.NegateSingle.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NegateInstruction.NegateSingle>.NativeClassPtr, 100665923);
				NegateInstruction.NegateSingle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NegateInstruction.NegateSingle>.NativeClassPtr, 100665924);
			}

			// Token: 0x060019C9 RID: 6601 RVA: 0x0007C408 File Offset: 0x0007A608
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025085, XrefRangeEnd = 1025093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NegateInstruction.NegateSingle.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060019CA RID: 6602 RVA: 0x0007C458 File Offset: 0x0007A658
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NegateSingle()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NegateInstruction.NegateSingle>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NegateInstruction.NegateSingle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019CB RID: 6603 RVA: 0x0000A225 File Offset: 0x00008425
			public NegateSingle(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040011A5 RID: 4517
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x040011A6 RID: 4518
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002DA RID: 730
		public sealed class NegateDouble : NegateInstruction
		{
			// Token: 0x060019CC RID: 6604 RVA: 0x0007C494 File Offset: 0x0007A694
			// Note: this type is marked as 'beforefieldinit'.
			static NegateDouble()
			{
				Il2CppClassPointerStore<NegateInstruction.NegateDouble>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NegateInstruction>.NativeClassPtr, "NegateDouble");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NegateInstruction.NegateDouble>.NativeClassPtr);
				NegateInstruction.NegateDouble.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NegateInstruction.NegateDouble>.NativeClassPtr, 100665925);
				NegateInstruction.NegateDouble.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NegateInstruction.NegateDouble>.NativeClassPtr, 100665926);
			}

			// Token: 0x060019CD RID: 6605 RVA: 0x0007C4E8 File Offset: 0x0007A6E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025093, XrefRangeEnd = 1025101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NegateInstruction.NegateDouble.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060019CE RID: 6606 RVA: 0x0007C538 File Offset: 0x0007A738
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NegateDouble()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NegateInstruction.NegateDouble>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NegateInstruction.NegateDouble.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019CF RID: 6607 RVA: 0x0000A22E File Offset: 0x0000842E
			public NegateDouble(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040011A7 RID: 4519
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x040011A8 RID: 4520
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
