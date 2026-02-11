using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000B1 RID: 177
	public class DivInstruction : Instruction
	{
		// Token: 0x0600095A RID: 2394 RVA: 0x0003925C File Offset: 0x0003745C
		// Note: this type is marked as 'beforefieldinit'.
		static DivInstruction()
		{
			Il2CppClassPointerStore<DivInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "DivInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DivInstruction>.NativeClassPtr);
			DivInstruction.NativeFieldInfoPtr_s_Int16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DivInstruction>.NativeClassPtr, "s_Int16");
			DivInstruction.NativeFieldInfoPtr_s_Int32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DivInstruction>.NativeClassPtr, "s_Int32");
			DivInstruction.NativeFieldInfoPtr_s_Int64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DivInstruction>.NativeClassPtr, "s_Int64");
			DivInstruction.NativeFieldInfoPtr_s_UInt16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DivInstruction>.NativeClassPtr, "s_UInt16");
			DivInstruction.NativeFieldInfoPtr_s_UInt32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DivInstruction>.NativeClassPtr, "s_UInt32");
			DivInstruction.NativeFieldInfoPtr_s_UInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DivInstruction>.NativeClassPtr, "s_UInt64");
			DivInstruction.NativeFieldInfoPtr_s_Single = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DivInstruction>.NativeClassPtr, "s_Single");
			DivInstruction.NativeFieldInfoPtr_s_Double = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DivInstruction>.NativeClassPtr, "s_Double");
			DivInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DivInstruction>.NativeClassPtr, 100665052);
			DivInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DivInstruction>.NativeClassPtr, 100665053);
			DivInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DivInstruction>.NativeClassPtr, 100665054);
			DivInstruction.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DivInstruction>.NativeClassPtr, 100665055);
			DivInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DivInstruction>.NativeClassPtr, 100665056);
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x0600095B RID: 2395 RVA: 0x00039390 File Offset: 0x00037590
		public unsafe override int ConsumedStack
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 72978, RefRangeEnd = 72985, XrefRangeStart = 72978, XrefRangeEnd = 72985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DivInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x0600095C RID: 2396 RVA: 0x000393D8 File Offset: 0x000375D8
		public unsafe override int ProducedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DivInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x0600095D RID: 2397 RVA: 0x00039420 File Offset: 0x00037620
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016376, XrefRangeEnd = 1016378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DivInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x00039464 File Offset: 0x00037664
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DivInstruction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DivInstruction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DivInstruction.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x000394A0 File Offset: 0x000376A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1016402, RefRangeEnd = 1016404, XrefRangeStart = 1016378, XrefRangeEnd = 1016402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Instruction Create(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DivInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x0000485F File Offset: 0x00002A5F
		public DivInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000961 RID: 2401 RVA: 0x000394E4 File Offset: 0x000376E4
		// (set) Token: 0x06000962 RID: 2402 RVA: 0x00004868 File Offset: 0x00002A68
		public unsafe static Instruction s_Int16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DivInstruction.NativeFieldInfoPtr_s_Int16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DivInstruction.NativeFieldInfoPtr_s_Int16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000963 RID: 2403 RVA: 0x0003950C File Offset: 0x0003770C
		// (set) Token: 0x06000964 RID: 2404 RVA: 0x0000487A File Offset: 0x00002A7A
		public unsafe static Instruction s_Int32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DivInstruction.NativeFieldInfoPtr_s_Int32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DivInstruction.NativeFieldInfoPtr_s_Int32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000965 RID: 2405 RVA: 0x00039534 File Offset: 0x00037734
		// (set) Token: 0x06000966 RID: 2406 RVA: 0x0000488C File Offset: 0x00002A8C
		public unsafe static Instruction s_Int64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DivInstruction.NativeFieldInfoPtr_s_Int64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DivInstruction.NativeFieldInfoPtr_s_Int64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000967 RID: 2407 RVA: 0x0003955C File Offset: 0x0003775C
		// (set) Token: 0x06000968 RID: 2408 RVA: 0x0000489E File Offset: 0x00002A9E
		public unsafe static Instruction s_UInt16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DivInstruction.NativeFieldInfoPtr_s_UInt16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DivInstruction.NativeFieldInfoPtr_s_UInt16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000969 RID: 2409 RVA: 0x00039584 File Offset: 0x00037784
		// (set) Token: 0x0600096A RID: 2410 RVA: 0x000048B0 File Offset: 0x00002AB0
		public unsafe static Instruction s_UInt32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DivInstruction.NativeFieldInfoPtr_s_UInt32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DivInstruction.NativeFieldInfoPtr_s_UInt32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x0600096B RID: 2411 RVA: 0x000395AC File Offset: 0x000377AC
		// (set) Token: 0x0600096C RID: 2412 RVA: 0x000048C2 File Offset: 0x00002AC2
		public unsafe static Instruction s_UInt64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DivInstruction.NativeFieldInfoPtr_s_UInt64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DivInstruction.NativeFieldInfoPtr_s_UInt64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x0600096D RID: 2413 RVA: 0x000395D4 File Offset: 0x000377D4
		// (set) Token: 0x0600096E RID: 2414 RVA: 0x000048D4 File Offset: 0x00002AD4
		public unsafe static Instruction s_Single
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DivInstruction.NativeFieldInfoPtr_s_Single, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DivInstruction.NativeFieldInfoPtr_s_Single, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x0600096F RID: 2415 RVA: 0x000395FC File Offset: 0x000377FC
		// (set) Token: 0x06000970 RID: 2416 RVA: 0x000048E6 File Offset: 0x00002AE6
		public unsafe static Instruction s_Double
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DivInstruction.NativeFieldInfoPtr_s_Double, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DivInstruction.NativeFieldInfoPtr_s_Double, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000722 RID: 1826
		private static readonly IntPtr NativeFieldInfoPtr_s_Int16;

		// Token: 0x04000723 RID: 1827
		private static readonly IntPtr NativeFieldInfoPtr_s_Int32;

		// Token: 0x04000724 RID: 1828
		private static readonly IntPtr NativeFieldInfoPtr_s_Int64;

		// Token: 0x04000725 RID: 1829
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt16;

		// Token: 0x04000726 RID: 1830
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt32;

		// Token: 0x04000727 RID: 1831
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt64;

		// Token: 0x04000728 RID: 1832
		private static readonly IntPtr NativeFieldInfoPtr_s_Single;

		// Token: 0x04000729 RID: 1833
		private static readonly IntPtr NativeFieldInfoPtr_s_Double;

		// Token: 0x0400072A RID: 1834
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0;

		// Token: 0x0400072B RID: 1835
		private static readonly IntPtr NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0;

		// Token: 0x0400072C RID: 1836
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x0400072D RID: 1837
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x0400072E RID: 1838
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0;

		// Token: 0x02000206 RID: 518
		public sealed class DivInt16 : DivInstruction
		{
			// Token: 0x060016E8 RID: 5864 RVA: 0x0006F9EC File Offset: 0x0006DBEC
			// Note: this type is marked as 'beforefieldinit'.
			static DivInt16()
			{
				Il2CppClassPointerStore<DivInstruction.DivInt16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DivInstruction>.NativeClassPtr, "DivInt16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DivInstruction.DivInt16>.NativeClassPtr);
				DivInstruction.DivInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DivInstruction.DivInt16>.NativeClassPtr, 100665057);
				DivInstruction.DivInt16.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DivInstruction.DivInt16>.NativeClassPtr, 100665058);
			}

			// Token: 0x060016E9 RID: 5865 RVA: 0x0006FA40 File Offset: 0x0006DC40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016360, XrefRangeEnd = 1016362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DivInstruction.DivInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060016EA RID: 5866 RVA: 0x0006FA90 File Offset: 0x0006DC90
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DivInt16()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DivInstruction.DivInt16>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DivInstruction.DivInt16.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016EB RID: 5867 RVA: 0x00009976 File Offset: 0x00007B76
			public DivInt16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001005 RID: 4101
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001006 RID: 4102
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000207 RID: 519
		public sealed class DivInt32 : DivInstruction
		{
			// Token: 0x060016EC RID: 5868 RVA: 0x0006FACC File Offset: 0x0006DCCC
			// Note: this type is marked as 'beforefieldinit'.
			static DivInt32()
			{
				Il2CppClassPointerStore<DivInstruction.DivInt32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DivInstruction>.NativeClassPtr, "DivInt32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DivInstruction.DivInt32>.NativeClassPtr);
				DivInstruction.DivInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DivInstruction.DivInt32>.NativeClassPtr, 100665059);
				DivInstruction.DivInt32.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DivInstruction.DivInt32>.NativeClassPtr, 100665060);
			}

			// Token: 0x060016ED RID: 5869 RVA: 0x0006FB20 File Offset: 0x0006DD20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016362, XrefRangeEnd = 1016364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DivInstruction.DivInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060016EE RID: 5870 RVA: 0x0006FB70 File Offset: 0x0006DD70
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DivInt32()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DivInstruction.DivInt32>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DivInstruction.DivInt32.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016EF RID: 5871 RVA: 0x0000997F File Offset: 0x00007B7F
			public DivInt32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001007 RID: 4103
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001008 RID: 4104
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000208 RID: 520
		public sealed class DivInt64 : DivInstruction
		{
			// Token: 0x060016F0 RID: 5872 RVA: 0x0006FBAC File Offset: 0x0006DDAC
			// Note: this type is marked as 'beforefieldinit'.
			static DivInt64()
			{
				Il2CppClassPointerStore<DivInstruction.DivInt64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DivInstruction>.NativeClassPtr, "DivInt64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DivInstruction.DivInt64>.NativeClassPtr);
				DivInstruction.DivInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DivInstruction.DivInt64>.NativeClassPtr, 100665061);
				DivInstruction.DivInt64.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DivInstruction.DivInt64>.NativeClassPtr, 100665062);
			}

			// Token: 0x060016F1 RID: 5873 RVA: 0x0006FC00 File Offset: 0x0006DE00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016364, XrefRangeEnd = 1016366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DivInstruction.DivInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060016F2 RID: 5874 RVA: 0x0006FC50 File Offset: 0x0006DE50
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DivInt64()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DivInstruction.DivInt64>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DivInstruction.DivInt64.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016F3 RID: 5875 RVA: 0x00009988 File Offset: 0x00007B88
			public DivInt64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001009 RID: 4105
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x0400100A RID: 4106
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000209 RID: 521
		public sealed class DivUInt16 : DivInstruction
		{
			// Token: 0x060016F4 RID: 5876 RVA: 0x0006FC8C File Offset: 0x0006DE8C
			// Note: this type is marked as 'beforefieldinit'.
			static DivUInt16()
			{
				Il2CppClassPointerStore<DivInstruction.DivUInt16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DivInstruction>.NativeClassPtr, "DivUInt16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DivInstruction.DivUInt16>.NativeClassPtr);
				DivInstruction.DivUInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DivInstruction.DivUInt16>.NativeClassPtr, 100665063);
				DivInstruction.DivUInt16.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DivInstruction.DivUInt16>.NativeClassPtr, 100665064);
			}

			// Token: 0x060016F5 RID: 5877 RVA: 0x0006FCE0 File Offset: 0x0006DEE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016366, XrefRangeEnd = 1016368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DivInstruction.DivUInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060016F6 RID: 5878 RVA: 0x0006FD30 File Offset: 0x0006DF30
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DivUInt16()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DivInstruction.DivUInt16>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DivInstruction.DivUInt16.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016F7 RID: 5879 RVA: 0x00009991 File Offset: 0x00007B91
			public DivUInt16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400100B RID: 4107
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x0400100C RID: 4108
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200020A RID: 522
		public sealed class DivUInt32 : DivInstruction
		{
			// Token: 0x060016F8 RID: 5880 RVA: 0x0006FD6C File Offset: 0x0006DF6C
			// Note: this type is marked as 'beforefieldinit'.
			static DivUInt32()
			{
				Il2CppClassPointerStore<DivInstruction.DivUInt32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DivInstruction>.NativeClassPtr, "DivUInt32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DivInstruction.DivUInt32>.NativeClassPtr);
				DivInstruction.DivUInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DivInstruction.DivUInt32>.NativeClassPtr, 100665065);
				DivInstruction.DivUInt32.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DivInstruction.DivUInt32>.NativeClassPtr, 100665066);
			}

			// Token: 0x060016F9 RID: 5881 RVA: 0x0006FDC0 File Offset: 0x0006DFC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016368, XrefRangeEnd = 1016370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DivInstruction.DivUInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060016FA RID: 5882 RVA: 0x0006FE10 File Offset: 0x0006E010
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DivUInt32()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DivInstruction.DivUInt32>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DivInstruction.DivUInt32.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016FB RID: 5883 RVA: 0x0000999A File Offset: 0x00007B9A
			public DivUInt32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400100D RID: 4109
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x0400100E RID: 4110
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200020B RID: 523
		public sealed class DivUInt64 : DivInstruction
		{
			// Token: 0x060016FC RID: 5884 RVA: 0x0006FE4C File Offset: 0x0006E04C
			// Note: this type is marked as 'beforefieldinit'.
			static DivUInt64()
			{
				Il2CppClassPointerStore<DivInstruction.DivUInt64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DivInstruction>.NativeClassPtr, "DivUInt64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DivInstruction.DivUInt64>.NativeClassPtr);
				DivInstruction.DivUInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DivInstruction.DivUInt64>.NativeClassPtr, 100665067);
				DivInstruction.DivUInt64.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DivInstruction.DivUInt64>.NativeClassPtr, 100665068);
			}

			// Token: 0x060016FD RID: 5885 RVA: 0x0006FEA0 File Offset: 0x0006E0A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016370, XrefRangeEnd = 1016372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DivInstruction.DivUInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060016FE RID: 5886 RVA: 0x0006FEF0 File Offset: 0x0006E0F0
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DivUInt64()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DivInstruction.DivUInt64>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DivInstruction.DivUInt64.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016FF RID: 5887 RVA: 0x000099A3 File Offset: 0x00007BA3
			public DivUInt64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400100F RID: 4111
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001010 RID: 4112
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200020C RID: 524
		public sealed class DivSingle : DivInstruction
		{
			// Token: 0x06001700 RID: 5888 RVA: 0x0006FF2C File Offset: 0x0006E12C
			// Note: this type is marked as 'beforefieldinit'.
			static DivSingle()
			{
				Il2CppClassPointerStore<DivInstruction.DivSingle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DivInstruction>.NativeClassPtr, "DivSingle");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DivInstruction.DivSingle>.NativeClassPtr);
				DivInstruction.DivSingle.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DivInstruction.DivSingle>.NativeClassPtr, 100665069);
				DivInstruction.DivSingle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DivInstruction.DivSingle>.NativeClassPtr, 100665070);
			}

			// Token: 0x06001701 RID: 5889 RVA: 0x0006FF80 File Offset: 0x0006E180
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016372, XrefRangeEnd = 1016374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DivInstruction.DivSingle.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001702 RID: 5890 RVA: 0x0006FFD0 File Offset: 0x0006E1D0
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DivSingle()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DivInstruction.DivSingle>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DivInstruction.DivSingle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001703 RID: 5891 RVA: 0x000099AC File Offset: 0x00007BAC
			public DivSingle(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001011 RID: 4113
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001012 RID: 4114
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200020D RID: 525
		public sealed class DivDouble : DivInstruction
		{
			// Token: 0x06001704 RID: 5892 RVA: 0x0007000C File Offset: 0x0006E20C
			// Note: this type is marked as 'beforefieldinit'.
			static DivDouble()
			{
				Il2CppClassPointerStore<DivInstruction.DivDouble>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DivInstruction>.NativeClassPtr, "DivDouble");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DivInstruction.DivDouble>.NativeClassPtr);
				DivInstruction.DivDouble.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DivInstruction.DivDouble>.NativeClassPtr, 100665071);
				DivInstruction.DivDouble.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DivInstruction.DivDouble>.NativeClassPtr, 100665072);
			}

			// Token: 0x06001705 RID: 5893 RVA: 0x00070060 File Offset: 0x0006E260
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016374, XrefRangeEnd = 1016376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DivInstruction.DivDouble.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001706 RID: 5894 RVA: 0x000700B0 File Offset: 0x0006E2B0
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DivDouble()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DivInstruction.DivDouble>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DivInstruction.DivDouble.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001707 RID: 5895 RVA: 0x000099B5 File Offset: 0x00007BB5
			public DivDouble(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001013 RID: 4115
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001014 RID: 4116
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
