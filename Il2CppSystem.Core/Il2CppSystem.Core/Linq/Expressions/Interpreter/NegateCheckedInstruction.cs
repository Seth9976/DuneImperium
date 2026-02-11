using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000EC RID: 236
	public class NegateCheckedInstruction : Instruction
	{
		// Token: 0x06000E46 RID: 3654 RVA: 0x0004EA30 File Offset: 0x0004CC30
		// Note: this type is marked as 'beforefieldinit'.
		static NegateCheckedInstruction()
		{
			Il2CppClassPointerStore<NegateCheckedInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "NegateCheckedInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NegateCheckedInstruction>.NativeClassPtr);
			NegateCheckedInstruction.NativeFieldInfoPtr_s_Int16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NegateCheckedInstruction>.NativeClassPtr, "s_Int16");
			NegateCheckedInstruction.NativeFieldInfoPtr_s_Int32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NegateCheckedInstruction>.NativeClassPtr, "s_Int32");
			NegateCheckedInstruction.NativeFieldInfoPtr_s_Int64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NegateCheckedInstruction>.NativeClassPtr, "s_Int64");
			NegateCheckedInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NegateCheckedInstruction>.NativeClassPtr, 100665927);
			NegateCheckedInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NegateCheckedInstruction>.NativeClassPtr, 100665928);
			NegateCheckedInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NegateCheckedInstruction>.NativeClassPtr, 100665929);
			NegateCheckedInstruction.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NegateCheckedInstruction>.NativeClassPtr, 100665930);
			NegateCheckedInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NegateCheckedInstruction>.NativeClassPtr, 100665931);
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06000E47 RID: 3655 RVA: 0x0004EB00 File Offset: 0x0004CD00
		public unsafe override int ConsumedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NegateCheckedInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06000E48 RID: 3656 RVA: 0x0004EB48 File Offset: 0x0004CD48
		public unsafe override int ProducedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NegateCheckedInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06000E49 RID: 3657 RVA: 0x0004EB90 File Offset: 0x0004CD90
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025160, XrefRangeEnd = 1025162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NegateCheckedInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000E4A RID: 3658 RVA: 0x0004EBD4 File Offset: 0x0004CDD4
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NegateCheckedInstruction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NegateCheckedInstruction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NegateCheckedInstruction.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x0004EC10 File Offset: 0x0004CE10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1025196, RefRangeEnd = 1025197, XrefRangeStart = 1025162, XrefRangeEnd = 1025196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Instruction Create(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NegateCheckedInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x00006560 File Offset: 0x00004760
		public NegateCheckedInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06000E4D RID: 3661 RVA: 0x0004EC54 File Offset: 0x0004CE54
		// (set) Token: 0x06000E4E RID: 3662 RVA: 0x00006569 File Offset: 0x00004769
		public unsafe static Instruction s_Int16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NegateCheckedInstruction.NativeFieldInfoPtr_s_Int16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NegateCheckedInstruction.NativeFieldInfoPtr_s_Int16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06000E4F RID: 3663 RVA: 0x0004EC7C File Offset: 0x0004CE7C
		// (set) Token: 0x06000E50 RID: 3664 RVA: 0x0000657B File Offset: 0x0000477B
		public unsafe static Instruction s_Int32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NegateCheckedInstruction.NativeFieldInfoPtr_s_Int32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NegateCheckedInstruction.NativeFieldInfoPtr_s_Int32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06000E51 RID: 3665 RVA: 0x0004ECA4 File Offset: 0x0004CEA4
		// (set) Token: 0x06000E52 RID: 3666 RVA: 0x0000658D File Offset: 0x0000478D
		public unsafe static Instruction s_Int64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NegateCheckedInstruction.NativeFieldInfoPtr_s_Int64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NegateCheckedInstruction.NativeFieldInfoPtr_s_Int64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A74 RID: 2676
		private static readonly IntPtr NativeFieldInfoPtr_s_Int16;

		// Token: 0x04000A75 RID: 2677
		private static readonly IntPtr NativeFieldInfoPtr_s_Int32;

		// Token: 0x04000A76 RID: 2678
		private static readonly IntPtr NativeFieldInfoPtr_s_Int64;

		// Token: 0x04000A77 RID: 2679
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000A78 RID: 2680
		private static readonly IntPtr NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000A79 RID: 2681
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x04000A7A RID: 2682
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000A7B RID: 2683
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0;

		// Token: 0x020002DB RID: 731
		public sealed class NegateCheckedInt32 : NegateCheckedInstruction
		{
			// Token: 0x060019D0 RID: 6608 RVA: 0x0007C574 File Offset: 0x0007A774
			// Note: this type is marked as 'beforefieldinit'.
			static NegateCheckedInt32()
			{
				Il2CppClassPointerStore<NegateCheckedInstruction.NegateCheckedInt32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NegateCheckedInstruction>.NativeClassPtr, "NegateCheckedInt32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NegateCheckedInstruction.NegateCheckedInt32>.NativeClassPtr);
				NegateCheckedInstruction.NegateCheckedInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NegateCheckedInstruction.NegateCheckedInt32>.NativeClassPtr, 100665932);
				NegateCheckedInstruction.NegateCheckedInt32.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NegateCheckedInstruction.NegateCheckedInt32>.NativeClassPtr, 100665933);
			}

			// Token: 0x060019D1 RID: 6609 RVA: 0x0007C5C8 File Offset: 0x0007A7C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025126, XrefRangeEnd = 1025136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NegateCheckedInstruction.NegateCheckedInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060019D2 RID: 6610 RVA: 0x0007C618 File Offset: 0x0007A818
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NegateCheckedInt32()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NegateCheckedInstruction.NegateCheckedInt32>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NegateCheckedInstruction.NegateCheckedInt32.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019D3 RID: 6611 RVA: 0x0000A237 File Offset: 0x00008437
			public NegateCheckedInt32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040011A9 RID: 4521
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x040011AA RID: 4522
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002DC RID: 732
		public sealed class NegateCheckedInt16 : NegateCheckedInstruction
		{
			// Token: 0x060019D4 RID: 6612 RVA: 0x0007C654 File Offset: 0x0007A854
			// Note: this type is marked as 'beforefieldinit'.
			static NegateCheckedInt16()
			{
				Il2CppClassPointerStore<NegateCheckedInstruction.NegateCheckedInt16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NegateCheckedInstruction>.NativeClassPtr, "NegateCheckedInt16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NegateCheckedInstruction.NegateCheckedInt16>.NativeClassPtr);
				NegateCheckedInstruction.NegateCheckedInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NegateCheckedInstruction.NegateCheckedInt16>.NativeClassPtr, 100665934);
				NegateCheckedInstruction.NegateCheckedInt16.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NegateCheckedInstruction.NegateCheckedInt16>.NativeClassPtr, 100665935);
			}

			// Token: 0x060019D5 RID: 6613 RVA: 0x0007C6A8 File Offset: 0x0007A8A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025136, XrefRangeEnd = 1025148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NegateCheckedInstruction.NegateCheckedInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060019D6 RID: 6614 RVA: 0x0007C6F8 File Offset: 0x0007A8F8
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NegateCheckedInt16()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NegateCheckedInstruction.NegateCheckedInt16>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NegateCheckedInstruction.NegateCheckedInt16.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019D7 RID: 6615 RVA: 0x0000A240 File Offset: 0x00008440
			public NegateCheckedInt16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040011AB RID: 4523
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x040011AC RID: 4524
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002DD RID: 733
		public sealed class NegateCheckedInt64 : NegateCheckedInstruction
		{
			// Token: 0x060019D8 RID: 6616 RVA: 0x0007C734 File Offset: 0x0007A934
			// Note: this type is marked as 'beforefieldinit'.
			static NegateCheckedInt64()
			{
				Il2CppClassPointerStore<NegateCheckedInstruction.NegateCheckedInt64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NegateCheckedInstruction>.NativeClassPtr, "NegateCheckedInt64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NegateCheckedInstruction.NegateCheckedInt64>.NativeClassPtr);
				NegateCheckedInstruction.NegateCheckedInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NegateCheckedInstruction.NegateCheckedInt64>.NativeClassPtr, 100665936);
				NegateCheckedInstruction.NegateCheckedInt64.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NegateCheckedInstruction.NegateCheckedInt64>.NativeClassPtr, 100665937);
			}

			// Token: 0x060019D9 RID: 6617 RVA: 0x0007C788 File Offset: 0x0007A988
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025148, XrefRangeEnd = 1025160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NegateCheckedInstruction.NegateCheckedInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060019DA RID: 6618 RVA: 0x0007C7D8 File Offset: 0x0007A9D8
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NegateCheckedInt64()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NegateCheckedInstruction.NegateCheckedInt64>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NegateCheckedInstruction.NegateCheckedInt64.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019DB RID: 6619 RVA: 0x0000A249 File Offset: 0x00008449
			public NegateCheckedInt64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040011AD RID: 4525
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x040011AE RID: 4526
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
