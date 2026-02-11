using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x0200008C RID: 140
	public class AddInstruction : Instruction
	{
		// Token: 0x060007A9 RID: 1961 RVA: 0x000333A4 File Offset: 0x000315A4
		// Note: this type is marked as 'beforefieldinit'.
		static AddInstruction()
		{
			Il2CppClassPointerStore<AddInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "AddInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddInstruction>.NativeClassPtr);
			AddInstruction.NativeFieldInfoPtr_s_Int16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddInstruction>.NativeClassPtr, "s_Int16");
			AddInstruction.NativeFieldInfoPtr_s_Int32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddInstruction>.NativeClassPtr, "s_Int32");
			AddInstruction.NativeFieldInfoPtr_s_Int64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddInstruction>.NativeClassPtr, "s_Int64");
			AddInstruction.NativeFieldInfoPtr_s_UInt16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddInstruction>.NativeClassPtr, "s_UInt16");
			AddInstruction.NativeFieldInfoPtr_s_UInt32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddInstruction>.NativeClassPtr, "s_UInt32");
			AddInstruction.NativeFieldInfoPtr_s_UInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddInstruction>.NativeClassPtr, "s_UInt64");
			AddInstruction.NativeFieldInfoPtr_s_Single = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddInstruction>.NativeClassPtr, "s_Single");
			AddInstruction.NativeFieldInfoPtr_s_Double = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddInstruction>.NativeClassPtr, "s_Double");
			AddInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddInstruction>.NativeClassPtr, 100664784);
			AddInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddInstruction>.NativeClassPtr, 100664785);
			AddInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddInstruction>.NativeClassPtr, 100664786);
			AddInstruction.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddInstruction>.NativeClassPtr, 100664787);
			AddInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddInstruction>.NativeClassPtr, 100664788);
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x060007AA RID: 1962 RVA: 0x000334D8 File Offset: 0x000316D8
		public unsafe override int ConsumedStack
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 72978, RefRangeEnd = 72985, XrefRangeStart = 72978, XrefRangeEnd = 72985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x060007AB RID: 1963 RVA: 0x00033520 File Offset: 0x00031720
		public unsafe override int ProducedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x060007AC RID: 1964 RVA: 0x00033568 File Offset: 0x00031768
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015452, XrefRangeEnd = 1015454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x000335AC File Offset: 0x000317AC
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddInstruction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddInstruction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddInstruction.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x000335E8 File Offset: 0x000317E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1015478, RefRangeEnd = 1015480, XrefRangeStart = 1015454, XrefRangeEnd = 1015478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Instruction Create(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x00003FB3 File Offset: 0x000021B3
		public AddInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x060007B0 RID: 1968 RVA: 0x0003362C File Offset: 0x0003182C
		// (set) Token: 0x060007B1 RID: 1969 RVA: 0x00003FBC File Offset: 0x000021BC
		public unsafe static Instruction s_Int16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AddInstruction.NativeFieldInfoPtr_s_Int16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AddInstruction.NativeFieldInfoPtr_s_Int16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x060007B2 RID: 1970 RVA: 0x00033654 File Offset: 0x00031854
		// (set) Token: 0x060007B3 RID: 1971 RVA: 0x00003FCE File Offset: 0x000021CE
		public unsafe static Instruction s_Int32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AddInstruction.NativeFieldInfoPtr_s_Int32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AddInstruction.NativeFieldInfoPtr_s_Int32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x060007B4 RID: 1972 RVA: 0x0003367C File Offset: 0x0003187C
		// (set) Token: 0x060007B5 RID: 1973 RVA: 0x00003FE0 File Offset: 0x000021E0
		public unsafe static Instruction s_Int64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AddInstruction.NativeFieldInfoPtr_s_Int64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AddInstruction.NativeFieldInfoPtr_s_Int64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x060007B6 RID: 1974 RVA: 0x000336A4 File Offset: 0x000318A4
		// (set) Token: 0x060007B7 RID: 1975 RVA: 0x00003FF2 File Offset: 0x000021F2
		public unsafe static Instruction s_UInt16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AddInstruction.NativeFieldInfoPtr_s_UInt16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AddInstruction.NativeFieldInfoPtr_s_UInt16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x060007B8 RID: 1976 RVA: 0x000336CC File Offset: 0x000318CC
		// (set) Token: 0x060007B9 RID: 1977 RVA: 0x00004004 File Offset: 0x00002204
		public unsafe static Instruction s_UInt32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AddInstruction.NativeFieldInfoPtr_s_UInt32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AddInstruction.NativeFieldInfoPtr_s_UInt32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060007BA RID: 1978 RVA: 0x000336F4 File Offset: 0x000318F4
		// (set) Token: 0x060007BB RID: 1979 RVA: 0x00004016 File Offset: 0x00002216
		public unsafe static Instruction s_UInt64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AddInstruction.NativeFieldInfoPtr_s_UInt64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AddInstruction.NativeFieldInfoPtr_s_UInt64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060007BC RID: 1980 RVA: 0x0003371C File Offset: 0x0003191C
		// (set) Token: 0x060007BD RID: 1981 RVA: 0x00004028 File Offset: 0x00002228
		public unsafe static Instruction s_Single
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AddInstruction.NativeFieldInfoPtr_s_Single, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AddInstruction.NativeFieldInfoPtr_s_Single, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x060007BE RID: 1982 RVA: 0x00033744 File Offset: 0x00031944
		// (set) Token: 0x060007BF RID: 1983 RVA: 0x0000403A File Offset: 0x0000223A
		public unsafe static Instruction s_Double
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AddInstruction.NativeFieldInfoPtr_s_Double, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AddInstruction.NativeFieldInfoPtr_s_Double, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000608 RID: 1544
		private static readonly IntPtr NativeFieldInfoPtr_s_Int16;

		// Token: 0x04000609 RID: 1545
		private static readonly IntPtr NativeFieldInfoPtr_s_Int32;

		// Token: 0x0400060A RID: 1546
		private static readonly IntPtr NativeFieldInfoPtr_s_Int64;

		// Token: 0x0400060B RID: 1547
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt16;

		// Token: 0x0400060C RID: 1548
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt32;

		// Token: 0x0400060D RID: 1549
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt64;

		// Token: 0x0400060E RID: 1550
		private static readonly IntPtr NativeFieldInfoPtr_s_Single;

		// Token: 0x0400060F RID: 1551
		private static readonly IntPtr NativeFieldInfoPtr_s_Double;

		// Token: 0x04000610 RID: 1552
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000611 RID: 1553
		private static readonly IntPtr NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000612 RID: 1554
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x04000613 RID: 1555
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000614 RID: 1556
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0;

		// Token: 0x020001E7 RID: 487
		public sealed class AddInt16 : AddInstruction
		{
			// Token: 0x0600166C RID: 5740 RVA: 0x0006DECC File Offset: 0x0006C0CC
			// Note: this type is marked as 'beforefieldinit'.
			static AddInt16()
			{
				Il2CppClassPointerStore<AddInstruction.AddInt16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddInstruction>.NativeClassPtr, "AddInt16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddInstruction.AddInt16>.NativeClassPtr);
				AddInstruction.AddInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddInstruction.AddInt16>.NativeClassPtr, 100664789);
				AddInstruction.AddInt16.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddInstruction.AddInt16>.NativeClassPtr, 100664790);
			}

			// Token: 0x0600166D RID: 5741 RVA: 0x0006DF20 File Offset: 0x0006C120
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015436, XrefRangeEnd = 1015438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddInstruction.AddInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600166E RID: 5742 RVA: 0x0006DF70 File Offset: 0x0006C170
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AddInt16()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddInstruction.AddInt16>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddInstruction.AddInt16.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600166F RID: 5743 RVA: 0x0000985F File Offset: 0x00007A5F
			public AddInt16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000FC7 RID: 4039
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04000FC8 RID: 4040
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001E8 RID: 488
		public sealed class AddInt32 : AddInstruction
		{
			// Token: 0x06001670 RID: 5744 RVA: 0x0006DFAC File Offset: 0x0006C1AC
			// Note: this type is marked as 'beforefieldinit'.
			static AddInt32()
			{
				Il2CppClassPointerStore<AddInstruction.AddInt32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddInstruction>.NativeClassPtr, "AddInt32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddInstruction.AddInt32>.NativeClassPtr);
				AddInstruction.AddInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddInstruction.AddInt32>.NativeClassPtr, 100664791);
				AddInstruction.AddInt32.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddInstruction.AddInt32>.NativeClassPtr, 100664792);
			}

			// Token: 0x06001671 RID: 5745 RVA: 0x0006E000 File Offset: 0x0006C200
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015438, XrefRangeEnd = 1015440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddInstruction.AddInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001672 RID: 5746 RVA: 0x0006E050 File Offset: 0x0006C250
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AddInt32()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddInstruction.AddInt32>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddInstruction.AddInt32.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001673 RID: 5747 RVA: 0x00009868 File Offset: 0x00007A68
			public AddInt32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000FC9 RID: 4041
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04000FCA RID: 4042
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001E9 RID: 489
		public sealed class AddInt64 : AddInstruction
		{
			// Token: 0x06001674 RID: 5748 RVA: 0x0006E08C File Offset: 0x0006C28C
			// Note: this type is marked as 'beforefieldinit'.
			static AddInt64()
			{
				Il2CppClassPointerStore<AddInstruction.AddInt64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddInstruction>.NativeClassPtr, "AddInt64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddInstruction.AddInt64>.NativeClassPtr);
				AddInstruction.AddInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddInstruction.AddInt64>.NativeClassPtr, 100664793);
				AddInstruction.AddInt64.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddInstruction.AddInt64>.NativeClassPtr, 100664794);
			}

			// Token: 0x06001675 RID: 5749 RVA: 0x0006E0E0 File Offset: 0x0006C2E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015440, XrefRangeEnd = 1015442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddInstruction.AddInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001676 RID: 5750 RVA: 0x0006E130 File Offset: 0x0006C330
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AddInt64()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddInstruction.AddInt64>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddInstruction.AddInt64.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001677 RID: 5751 RVA: 0x00009871 File Offset: 0x00007A71
			public AddInt64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000FCB RID: 4043
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04000FCC RID: 4044
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001EA RID: 490
		public sealed class AddUInt16 : AddInstruction
		{
			// Token: 0x06001678 RID: 5752 RVA: 0x0006E16C File Offset: 0x0006C36C
			// Note: this type is marked as 'beforefieldinit'.
			static AddUInt16()
			{
				Il2CppClassPointerStore<AddInstruction.AddUInt16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddInstruction>.NativeClassPtr, "AddUInt16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddInstruction.AddUInt16>.NativeClassPtr);
				AddInstruction.AddUInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddInstruction.AddUInt16>.NativeClassPtr, 100664795);
				AddInstruction.AddUInt16.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddInstruction.AddUInt16>.NativeClassPtr, 100664796);
			}

			// Token: 0x06001679 RID: 5753 RVA: 0x0006E1C0 File Offset: 0x0006C3C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015442, XrefRangeEnd = 1015444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddInstruction.AddUInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600167A RID: 5754 RVA: 0x0006E210 File Offset: 0x0006C410
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AddUInt16()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddInstruction.AddUInt16>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddInstruction.AddUInt16.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600167B RID: 5755 RVA: 0x0000987A File Offset: 0x00007A7A
			public AddUInt16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000FCD RID: 4045
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04000FCE RID: 4046
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001EB RID: 491
		public sealed class AddUInt32 : AddInstruction
		{
			// Token: 0x0600167C RID: 5756 RVA: 0x0006E24C File Offset: 0x0006C44C
			// Note: this type is marked as 'beforefieldinit'.
			static AddUInt32()
			{
				Il2CppClassPointerStore<AddInstruction.AddUInt32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddInstruction>.NativeClassPtr, "AddUInt32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddInstruction.AddUInt32>.NativeClassPtr);
				AddInstruction.AddUInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddInstruction.AddUInt32>.NativeClassPtr, 100664797);
				AddInstruction.AddUInt32.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddInstruction.AddUInt32>.NativeClassPtr, 100664798);
			}

			// Token: 0x0600167D RID: 5757 RVA: 0x0006E2A0 File Offset: 0x0006C4A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015444, XrefRangeEnd = 1015446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddInstruction.AddUInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600167E RID: 5758 RVA: 0x0006E2F0 File Offset: 0x0006C4F0
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AddUInt32()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddInstruction.AddUInt32>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddInstruction.AddUInt32.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600167F RID: 5759 RVA: 0x00009883 File Offset: 0x00007A83
			public AddUInt32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000FCF RID: 4047
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04000FD0 RID: 4048
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001EC RID: 492
		public sealed class AddUInt64 : AddInstruction
		{
			// Token: 0x06001680 RID: 5760 RVA: 0x0006E32C File Offset: 0x0006C52C
			// Note: this type is marked as 'beforefieldinit'.
			static AddUInt64()
			{
				Il2CppClassPointerStore<AddInstruction.AddUInt64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddInstruction>.NativeClassPtr, "AddUInt64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddInstruction.AddUInt64>.NativeClassPtr);
				AddInstruction.AddUInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddInstruction.AddUInt64>.NativeClassPtr, 100664799);
				AddInstruction.AddUInt64.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddInstruction.AddUInt64>.NativeClassPtr, 100664800);
			}

			// Token: 0x06001681 RID: 5761 RVA: 0x0006E380 File Offset: 0x0006C580
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015446, XrefRangeEnd = 1015448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddInstruction.AddUInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001682 RID: 5762 RVA: 0x0006E3D0 File Offset: 0x0006C5D0
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AddUInt64()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddInstruction.AddUInt64>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddInstruction.AddUInt64.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001683 RID: 5763 RVA: 0x0000988C File Offset: 0x00007A8C
			public AddUInt64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000FD1 RID: 4049
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04000FD2 RID: 4050
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001ED RID: 493
		public sealed class AddSingle : AddInstruction
		{
			// Token: 0x06001684 RID: 5764 RVA: 0x0006E40C File Offset: 0x0006C60C
			// Note: this type is marked as 'beforefieldinit'.
			static AddSingle()
			{
				Il2CppClassPointerStore<AddInstruction.AddSingle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddInstruction>.NativeClassPtr, "AddSingle");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddInstruction.AddSingle>.NativeClassPtr);
				AddInstruction.AddSingle.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddInstruction.AddSingle>.NativeClassPtr, 100664801);
				AddInstruction.AddSingle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddInstruction.AddSingle>.NativeClassPtr, 100664802);
			}

			// Token: 0x06001685 RID: 5765 RVA: 0x0006E460 File Offset: 0x0006C660
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015448, XrefRangeEnd = 1015450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddInstruction.AddSingle.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001686 RID: 5766 RVA: 0x0006E4B0 File Offset: 0x0006C6B0
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AddSingle()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddInstruction.AddSingle>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddInstruction.AddSingle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001687 RID: 5767 RVA: 0x00009895 File Offset: 0x00007A95
			public AddSingle(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000FD3 RID: 4051
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04000FD4 RID: 4052
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001EE RID: 494
		public sealed class AddDouble : AddInstruction
		{
			// Token: 0x06001688 RID: 5768 RVA: 0x0006E4EC File Offset: 0x0006C6EC
			// Note: this type is marked as 'beforefieldinit'.
			static AddDouble()
			{
				Il2CppClassPointerStore<AddInstruction.AddDouble>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddInstruction>.NativeClassPtr, "AddDouble");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddInstruction.AddDouble>.NativeClassPtr);
				AddInstruction.AddDouble.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddInstruction.AddDouble>.NativeClassPtr, 100664803);
				AddInstruction.AddDouble.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddInstruction.AddDouble>.NativeClassPtr, 100664804);
			}

			// Token: 0x06001689 RID: 5769 RVA: 0x0006E540 File Offset: 0x0006C740
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015450, XrefRangeEnd = 1015452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddInstruction.AddDouble.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600168A RID: 5770 RVA: 0x0006E590 File Offset: 0x0006C790
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AddDouble()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddInstruction.AddDouble>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddInstruction.AddDouble.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600168B RID: 5771 RVA: 0x0000989E File Offset: 0x00007A9E
			public AddDouble(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000FD5 RID: 4053
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04000FD6 RID: 4054
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
