using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x0200008E RID: 142
	public class AndInstruction : Instruction
	{
		// Token: 0x060007D3 RID: 2003 RVA: 0x00033ABC File Offset: 0x00031CBC
		// Note: this type is marked as 'beforefieldinit'.
		static AndInstruction()
		{
			Il2CppClassPointerStore<AndInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "AndInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndInstruction>.NativeClassPtr);
			AndInstruction.NativeFieldInfoPtr_s_SByte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndInstruction>.NativeClassPtr, "s_SByte");
			AndInstruction.NativeFieldInfoPtr_s_Int16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndInstruction>.NativeClassPtr, "s_Int16");
			AndInstruction.NativeFieldInfoPtr_s_Int32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndInstruction>.NativeClassPtr, "s_Int32");
			AndInstruction.NativeFieldInfoPtr_s_Int64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndInstruction>.NativeClassPtr, "s_Int64");
			AndInstruction.NativeFieldInfoPtr_s_Byte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndInstruction>.NativeClassPtr, "s_Byte");
			AndInstruction.NativeFieldInfoPtr_s_UInt16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndInstruction>.NativeClassPtr, "s_UInt16");
			AndInstruction.NativeFieldInfoPtr_s_UInt32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndInstruction>.NativeClassPtr, "s_UInt32");
			AndInstruction.NativeFieldInfoPtr_s_UInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndInstruction>.NativeClassPtr, "s_UInt64");
			AndInstruction.NativeFieldInfoPtr_s_Boolean = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndInstruction>.NativeClassPtr, "s_Boolean");
			AndInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndInstruction>.NativeClassPtr, 100664822);
			AndInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndInstruction>.NativeClassPtr, 100664823);
			AndInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndInstruction>.NativeClassPtr, 100664824);
			AndInstruction.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndInstruction>.NativeClassPtr, 100664825);
			AndInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndInstruction>.NativeClassPtr, 100664826);
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x060007D4 RID: 2004 RVA: 0x00033C04 File Offset: 0x00031E04
		public unsafe override int ConsumedStack
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 72978, RefRangeEnd = 72985, XrefRangeStart = 72978, XrefRangeEnd = 72985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AndInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060007D5 RID: 2005 RVA: 0x00033C4C File Offset: 0x00031E4C
		public unsafe override int ProducedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AndInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x060007D6 RID: 2006 RVA: 0x00033C94 File Offset: 0x00031E94
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015603, XrefRangeEnd = 1015605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AndInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x00033CD8 File Offset: 0x00031ED8
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AndInstruction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndInstruction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndInstruction.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x00033D14 File Offset: 0x00031F14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1015630, RefRangeEnd = 1015632, XrefRangeStart = 1015605, XrefRangeEnd = 1015630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Instruction Create(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x000040C1 File Offset: 0x000022C1
		public AndInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x060007DA RID: 2010 RVA: 0x00033D58 File Offset: 0x00031F58
		// (set) Token: 0x060007DB RID: 2011 RVA: 0x000040CA File Offset: 0x000022CA
		public unsafe static Instruction s_SByte
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndInstruction.NativeFieldInfoPtr_s_SByte, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndInstruction.NativeFieldInfoPtr_s_SByte, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x060007DC RID: 2012 RVA: 0x00033D80 File Offset: 0x00031F80
		// (set) Token: 0x060007DD RID: 2013 RVA: 0x000040DC File Offset: 0x000022DC
		public unsafe static Instruction s_Int16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndInstruction.NativeFieldInfoPtr_s_Int16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndInstruction.NativeFieldInfoPtr_s_Int16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x060007DE RID: 2014 RVA: 0x00033DA8 File Offset: 0x00031FA8
		// (set) Token: 0x060007DF RID: 2015 RVA: 0x000040EE File Offset: 0x000022EE
		public unsafe static Instruction s_Int32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndInstruction.NativeFieldInfoPtr_s_Int32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndInstruction.NativeFieldInfoPtr_s_Int32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x060007E0 RID: 2016 RVA: 0x00033DD0 File Offset: 0x00031FD0
		// (set) Token: 0x060007E1 RID: 2017 RVA: 0x00004100 File Offset: 0x00002300
		public unsafe static Instruction s_Int64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndInstruction.NativeFieldInfoPtr_s_Int64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndInstruction.NativeFieldInfoPtr_s_Int64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x060007E2 RID: 2018 RVA: 0x00033DF8 File Offset: 0x00031FF8
		// (set) Token: 0x060007E3 RID: 2019 RVA: 0x00004112 File Offset: 0x00002312
		public unsafe static Instruction s_Byte
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndInstruction.NativeFieldInfoPtr_s_Byte, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndInstruction.NativeFieldInfoPtr_s_Byte, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x060007E4 RID: 2020 RVA: 0x00033E20 File Offset: 0x00032020
		// (set) Token: 0x060007E5 RID: 2021 RVA: 0x00004124 File Offset: 0x00002324
		public unsafe static Instruction s_UInt16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndInstruction.NativeFieldInfoPtr_s_UInt16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndInstruction.NativeFieldInfoPtr_s_UInt16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x060007E6 RID: 2022 RVA: 0x00033E48 File Offset: 0x00032048
		// (set) Token: 0x060007E7 RID: 2023 RVA: 0x00004136 File Offset: 0x00002336
		public unsafe static Instruction s_UInt32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndInstruction.NativeFieldInfoPtr_s_UInt32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndInstruction.NativeFieldInfoPtr_s_UInt32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x060007E8 RID: 2024 RVA: 0x00033E70 File Offset: 0x00032070
		// (set) Token: 0x060007E9 RID: 2025 RVA: 0x00004148 File Offset: 0x00002348
		public unsafe static Instruction s_UInt64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndInstruction.NativeFieldInfoPtr_s_UInt64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndInstruction.NativeFieldInfoPtr_s_UInt64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x060007EA RID: 2026 RVA: 0x00033E98 File Offset: 0x00032098
		// (set) Token: 0x060007EB RID: 2027 RVA: 0x0000415A File Offset: 0x0000235A
		public unsafe static Instruction s_Boolean
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndInstruction.NativeFieldInfoPtr_s_Boolean, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndInstruction.NativeFieldInfoPtr_s_Boolean, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000620 RID: 1568
		private static readonly IntPtr NativeFieldInfoPtr_s_SByte;

		// Token: 0x04000621 RID: 1569
		private static readonly IntPtr NativeFieldInfoPtr_s_Int16;

		// Token: 0x04000622 RID: 1570
		private static readonly IntPtr NativeFieldInfoPtr_s_Int32;

		// Token: 0x04000623 RID: 1571
		private static readonly IntPtr NativeFieldInfoPtr_s_Int64;

		// Token: 0x04000624 RID: 1572
		private static readonly IntPtr NativeFieldInfoPtr_s_Byte;

		// Token: 0x04000625 RID: 1573
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt16;

		// Token: 0x04000626 RID: 1574
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt32;

		// Token: 0x04000627 RID: 1575
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt64;

		// Token: 0x04000628 RID: 1576
		private static readonly IntPtr NativeFieldInfoPtr_s_Boolean;

		// Token: 0x04000629 RID: 1577
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0;

		// Token: 0x0400062A RID: 1578
		private static readonly IntPtr NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0;

		// Token: 0x0400062B RID: 1579
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x0400062C RID: 1580
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x0400062D RID: 1581
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0;

		// Token: 0x020001F5 RID: 501
		public sealed class AndSByte : AndInstruction
		{
			// Token: 0x060016A4 RID: 5796 RVA: 0x0006EB0C File Offset: 0x0006CD0C
			// Note: this type is marked as 'beforefieldinit'.
			static AndSByte()
			{
				Il2CppClassPointerStore<AndInstruction.AndSByte>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AndInstruction>.NativeClassPtr, "AndSByte");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndInstruction.AndSByte>.NativeClassPtr);
				AndInstruction.AndSByte.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndInstruction.AndSByte>.NativeClassPtr, 100664827);
				AndInstruction.AndSByte.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndInstruction.AndSByte>.NativeClassPtr, 100664828);
			}

			// Token: 0x060016A5 RID: 5797 RVA: 0x0006EB60 File Offset: 0x0006CD60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015524, XrefRangeEnd = 1015532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndInstruction.AndSByte.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060016A6 RID: 5798 RVA: 0x0006EBB0 File Offset: 0x0006CDB0
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AndSByte()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndInstruction.AndSByte>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndInstruction.AndSByte.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016A7 RID: 5799 RVA: 0x000098DD File Offset: 0x00007ADD
			public AndSByte(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000FE3 RID: 4067
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04000FE4 RID: 4068
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001F6 RID: 502
		public sealed class AndInt16 : AndInstruction
		{
			// Token: 0x060016A8 RID: 5800 RVA: 0x0006EBEC File Offset: 0x0006CDEC
			// Note: this type is marked as 'beforefieldinit'.
			static AndInt16()
			{
				Il2CppClassPointerStore<AndInstruction.AndInt16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AndInstruction>.NativeClassPtr, "AndInt16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndInstruction.AndInt16>.NativeClassPtr);
				AndInstruction.AndInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndInstruction.AndInt16>.NativeClassPtr, 100664829);
				AndInstruction.AndInt16.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndInstruction.AndInt16>.NativeClassPtr, 100664830);
			}

			// Token: 0x060016A9 RID: 5801 RVA: 0x0006EC40 File Offset: 0x0006CE40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015532, XrefRangeEnd = 1015540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndInstruction.AndInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060016AA RID: 5802 RVA: 0x0006EC90 File Offset: 0x0006CE90
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AndInt16()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndInstruction.AndInt16>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndInstruction.AndInt16.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016AB RID: 5803 RVA: 0x000098E6 File Offset: 0x00007AE6
			public AndInt16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000FE5 RID: 4069
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04000FE6 RID: 4070
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001F7 RID: 503
		public sealed class AndInt32 : AndInstruction
		{
			// Token: 0x060016AC RID: 5804 RVA: 0x0006ECCC File Offset: 0x0006CECC
			// Note: this type is marked as 'beforefieldinit'.
			static AndInt32()
			{
				Il2CppClassPointerStore<AndInstruction.AndInt32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AndInstruction>.NativeClassPtr, "AndInt32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndInstruction.AndInt32>.NativeClassPtr);
				AndInstruction.AndInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndInstruction.AndInt32>.NativeClassPtr, 100664831);
				AndInstruction.AndInt32.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndInstruction.AndInt32>.NativeClassPtr, 100664832);
			}

			// Token: 0x060016AD RID: 5805 RVA: 0x0006ED20 File Offset: 0x0006CF20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015540, XrefRangeEnd = 1015548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndInstruction.AndInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060016AE RID: 5806 RVA: 0x0006ED70 File Offset: 0x0006CF70
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AndInt32()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndInstruction.AndInt32>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndInstruction.AndInt32.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016AF RID: 5807 RVA: 0x000098EF File Offset: 0x00007AEF
			public AndInt32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000FE7 RID: 4071
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04000FE8 RID: 4072
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001F8 RID: 504
		public sealed class AndInt64 : AndInstruction
		{
			// Token: 0x060016B0 RID: 5808 RVA: 0x0006EDAC File Offset: 0x0006CFAC
			// Note: this type is marked as 'beforefieldinit'.
			static AndInt64()
			{
				Il2CppClassPointerStore<AndInstruction.AndInt64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AndInstruction>.NativeClassPtr, "AndInt64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndInstruction.AndInt64>.NativeClassPtr);
				AndInstruction.AndInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndInstruction.AndInt64>.NativeClassPtr, 100664833);
				AndInstruction.AndInt64.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndInstruction.AndInt64>.NativeClassPtr, 100664834);
			}

			// Token: 0x060016B1 RID: 5809 RVA: 0x0006EE00 File Offset: 0x0006D000
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015548, XrefRangeEnd = 1015558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndInstruction.AndInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060016B2 RID: 5810 RVA: 0x0006EE50 File Offset: 0x0006D050
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AndInt64()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndInstruction.AndInt64>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndInstruction.AndInt64.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016B3 RID: 5811 RVA: 0x000098F8 File Offset: 0x00007AF8
			public AndInt64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000FE9 RID: 4073
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04000FEA RID: 4074
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001F9 RID: 505
		public sealed class AndByte : AndInstruction
		{
			// Token: 0x060016B4 RID: 5812 RVA: 0x0006EE8C File Offset: 0x0006D08C
			// Note: this type is marked as 'beforefieldinit'.
			static AndByte()
			{
				Il2CppClassPointerStore<AndInstruction.AndByte>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AndInstruction>.NativeClassPtr, "AndByte");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndInstruction.AndByte>.NativeClassPtr);
				AndInstruction.AndByte.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndInstruction.AndByte>.NativeClassPtr, 100664835);
				AndInstruction.AndByte.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndInstruction.AndByte>.NativeClassPtr, 100664836);
			}

			// Token: 0x060016B5 RID: 5813 RVA: 0x0006EEE0 File Offset: 0x0006D0E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015558, XrefRangeEnd = 1015566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndInstruction.AndByte.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060016B6 RID: 5814 RVA: 0x0006EF30 File Offset: 0x0006D130
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AndByte()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndInstruction.AndByte>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndInstruction.AndByte.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016B7 RID: 5815 RVA: 0x00009901 File Offset: 0x00007B01
			public AndByte(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000FEB RID: 4075
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04000FEC RID: 4076
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001FA RID: 506
		public sealed class AndUInt16 : AndInstruction
		{
			// Token: 0x060016B8 RID: 5816 RVA: 0x0006EF6C File Offset: 0x0006D16C
			// Note: this type is marked as 'beforefieldinit'.
			static AndUInt16()
			{
				Il2CppClassPointerStore<AndInstruction.AndUInt16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AndInstruction>.NativeClassPtr, "AndUInt16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndInstruction.AndUInt16>.NativeClassPtr);
				AndInstruction.AndUInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndInstruction.AndUInt16>.NativeClassPtr, 100664837);
				AndInstruction.AndUInt16.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndInstruction.AndUInt16>.NativeClassPtr, 100664838);
			}

			// Token: 0x060016B9 RID: 5817 RVA: 0x0006EFC0 File Offset: 0x0006D1C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015566, XrefRangeEnd = 1015574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndInstruction.AndUInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060016BA RID: 5818 RVA: 0x0006F010 File Offset: 0x0006D210
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AndUInt16()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndInstruction.AndUInt16>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndInstruction.AndUInt16.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016BB RID: 5819 RVA: 0x0000990A File Offset: 0x00007B0A
			public AndUInt16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000FED RID: 4077
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04000FEE RID: 4078
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001FB RID: 507
		public sealed class AndUInt32 : AndInstruction
		{
			// Token: 0x060016BC RID: 5820 RVA: 0x0006F04C File Offset: 0x0006D24C
			// Note: this type is marked as 'beforefieldinit'.
			static AndUInt32()
			{
				Il2CppClassPointerStore<AndInstruction.AndUInt32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AndInstruction>.NativeClassPtr, "AndUInt32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndInstruction.AndUInt32>.NativeClassPtr);
				AndInstruction.AndUInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndInstruction.AndUInt32>.NativeClassPtr, 100664839);
				AndInstruction.AndUInt32.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndInstruction.AndUInt32>.NativeClassPtr, 100664840);
			}

			// Token: 0x060016BD RID: 5821 RVA: 0x0006F0A0 File Offset: 0x0006D2A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015574, XrefRangeEnd = 1015584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndInstruction.AndUInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060016BE RID: 5822 RVA: 0x0006F0F0 File Offset: 0x0006D2F0
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AndUInt32()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndInstruction.AndUInt32>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndInstruction.AndUInt32.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016BF RID: 5823 RVA: 0x00009913 File Offset: 0x00007B13
			public AndUInt32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000FEF RID: 4079
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04000FF0 RID: 4080
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001FC RID: 508
		public sealed class AndUInt64 : AndInstruction
		{
			// Token: 0x060016C0 RID: 5824 RVA: 0x0006F12C File Offset: 0x0006D32C
			// Note: this type is marked as 'beforefieldinit'.
			static AndUInt64()
			{
				Il2CppClassPointerStore<AndInstruction.AndUInt64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AndInstruction>.NativeClassPtr, "AndUInt64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndInstruction.AndUInt64>.NativeClassPtr);
				AndInstruction.AndUInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndInstruction.AndUInt64>.NativeClassPtr, 100664841);
				AndInstruction.AndUInt64.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndInstruction.AndUInt64>.NativeClassPtr, 100664842);
			}

			// Token: 0x060016C1 RID: 5825 RVA: 0x0006F180 File Offset: 0x0006D380
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015584, XrefRangeEnd = 1015594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndInstruction.AndUInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060016C2 RID: 5826 RVA: 0x0006F1D0 File Offset: 0x0006D3D0
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AndUInt64()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndInstruction.AndUInt64>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndInstruction.AndUInt64.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016C3 RID: 5827 RVA: 0x0000991C File Offset: 0x00007B1C
			public AndUInt64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000FF1 RID: 4081
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04000FF2 RID: 4082
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001FD RID: 509
		public sealed class AndBoolean : AndInstruction
		{
			// Token: 0x060016C4 RID: 5828 RVA: 0x0006F20C File Offset: 0x0006D40C
			// Note: this type is marked as 'beforefieldinit'.
			static AndBoolean()
			{
				Il2CppClassPointerStore<AndInstruction.AndBoolean>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AndInstruction>.NativeClassPtr, "AndBoolean");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndInstruction.AndBoolean>.NativeClassPtr);
				AndInstruction.AndBoolean.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndInstruction.AndBoolean>.NativeClassPtr, 100664843);
				AndInstruction.AndBoolean.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndInstruction.AndBoolean>.NativeClassPtr, 100664844);
			}

			// Token: 0x060016C5 RID: 5829 RVA: 0x0006F260 File Offset: 0x0006D460
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015594, XrefRangeEnd = 1015603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndInstruction.AndBoolean.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060016C6 RID: 5830 RVA: 0x0006F2B0 File Offset: 0x0006D4B0
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AndBoolean()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndInstruction.AndBoolean>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndInstruction.AndBoolean.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016C7 RID: 5831 RVA: 0x00009925 File Offset: 0x00007B25
			public AndBoolean(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000FF3 RID: 4083
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04000FF4 RID: 4084
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
