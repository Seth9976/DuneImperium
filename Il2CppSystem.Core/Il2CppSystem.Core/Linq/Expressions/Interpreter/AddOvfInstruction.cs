using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x0200008D RID: 141
	public class AddOvfInstruction : Instruction
	{
		// Token: 0x060007C0 RID: 1984 RVA: 0x0003376C File Offset: 0x0003196C
		// Note: this type is marked as 'beforefieldinit'.
		static AddOvfInstruction()
		{
			Il2CppClassPointerStore<AddOvfInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "AddOvfInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddOvfInstruction>.NativeClassPtr);
			AddOvfInstruction.NativeFieldInfoPtr_s_Int16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddOvfInstruction>.NativeClassPtr, "s_Int16");
			AddOvfInstruction.NativeFieldInfoPtr_s_Int32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddOvfInstruction>.NativeClassPtr, "s_Int32");
			AddOvfInstruction.NativeFieldInfoPtr_s_Int64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddOvfInstruction>.NativeClassPtr, "s_Int64");
			AddOvfInstruction.NativeFieldInfoPtr_s_UInt16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddOvfInstruction>.NativeClassPtr, "s_UInt16");
			AddOvfInstruction.NativeFieldInfoPtr_s_UInt32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddOvfInstruction>.NativeClassPtr, "s_UInt32");
			AddOvfInstruction.NativeFieldInfoPtr_s_UInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddOvfInstruction>.NativeClassPtr, "s_UInt64");
			AddOvfInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddOvfInstruction>.NativeClassPtr, 100664805);
			AddOvfInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddOvfInstruction>.NativeClassPtr, 100664806);
			AddOvfInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddOvfInstruction>.NativeClassPtr, 100664807);
			AddOvfInstruction.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddOvfInstruction>.NativeClassPtr, 100664808);
			AddOvfInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddOvfInstruction>.NativeClassPtr, 100664809);
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x060007C1 RID: 1985 RVA: 0x00033878 File Offset: 0x00031A78
		public unsafe override int ConsumedStack
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 72978, RefRangeEnd = 72985, XrefRangeStart = 72978, XrefRangeEnd = 72985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddOvfInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x060007C2 RID: 1986 RVA: 0x000338C0 File Offset: 0x00031AC0
		public unsafe override int ProducedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddOvfInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x060007C3 RID: 1987 RVA: 0x00033908 File Offset: 0x00031B08
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015498, XrefRangeEnd = 1015500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddOvfInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x0003394C File Offset: 0x00031B4C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddOvfInstruction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddOvfInstruction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddOvfInstruction.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x00033988 File Offset: 0x00031B88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1015522, RefRangeEnd = 1015524, XrefRangeStart = 1015500, XrefRangeEnd = 1015522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Instruction Create(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddOvfInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x0000404C File Offset: 0x0000224C
		public AddOvfInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x060007C7 RID: 1991 RVA: 0x000339CC File Offset: 0x00031BCC
		// (set) Token: 0x060007C8 RID: 1992 RVA: 0x00004055 File Offset: 0x00002255
		public unsafe static Instruction s_Int16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AddOvfInstruction.NativeFieldInfoPtr_s_Int16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AddOvfInstruction.NativeFieldInfoPtr_s_Int16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060007C9 RID: 1993 RVA: 0x000339F4 File Offset: 0x00031BF4
		// (set) Token: 0x060007CA RID: 1994 RVA: 0x00004067 File Offset: 0x00002267
		public unsafe static Instruction s_Int32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AddOvfInstruction.NativeFieldInfoPtr_s_Int32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AddOvfInstruction.NativeFieldInfoPtr_s_Int32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060007CB RID: 1995 RVA: 0x00033A1C File Offset: 0x00031C1C
		// (set) Token: 0x060007CC RID: 1996 RVA: 0x00004079 File Offset: 0x00002279
		public unsafe static Instruction s_Int64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AddOvfInstruction.NativeFieldInfoPtr_s_Int64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AddOvfInstruction.NativeFieldInfoPtr_s_Int64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x060007CD RID: 1997 RVA: 0x00033A44 File Offset: 0x00031C44
		// (set) Token: 0x060007CE RID: 1998 RVA: 0x0000408B File Offset: 0x0000228B
		public unsafe static Instruction s_UInt16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AddOvfInstruction.NativeFieldInfoPtr_s_UInt16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AddOvfInstruction.NativeFieldInfoPtr_s_UInt16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x060007CF RID: 1999 RVA: 0x00033A6C File Offset: 0x00031C6C
		// (set) Token: 0x060007D0 RID: 2000 RVA: 0x0000409D File Offset: 0x0000229D
		public unsafe static Instruction s_UInt32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AddOvfInstruction.NativeFieldInfoPtr_s_UInt32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AddOvfInstruction.NativeFieldInfoPtr_s_UInt32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x060007D1 RID: 2001 RVA: 0x00033A94 File Offset: 0x00031C94
		// (set) Token: 0x060007D2 RID: 2002 RVA: 0x000040AF File Offset: 0x000022AF
		public unsafe static Instruction s_UInt64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AddOvfInstruction.NativeFieldInfoPtr_s_UInt64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AddOvfInstruction.NativeFieldInfoPtr_s_UInt64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000615 RID: 1557
		private static readonly IntPtr NativeFieldInfoPtr_s_Int16;

		// Token: 0x04000616 RID: 1558
		private static readonly IntPtr NativeFieldInfoPtr_s_Int32;

		// Token: 0x04000617 RID: 1559
		private static readonly IntPtr NativeFieldInfoPtr_s_Int64;

		// Token: 0x04000618 RID: 1560
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt16;

		// Token: 0x04000619 RID: 1561
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt32;

		// Token: 0x0400061A RID: 1562
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt64;

		// Token: 0x0400061B RID: 1563
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0;

		// Token: 0x0400061C RID: 1564
		private static readonly IntPtr NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0;

		// Token: 0x0400061D RID: 1565
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x0400061E RID: 1566
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x0400061F RID: 1567
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0;

		// Token: 0x020001EF RID: 495
		public sealed class AddOvfInt16 : AddOvfInstruction
		{
			// Token: 0x0600168C RID: 5772 RVA: 0x0006E5CC File Offset: 0x0006C7CC
			// Note: this type is marked as 'beforefieldinit'.
			static AddOvfInt16()
			{
				Il2CppClassPointerStore<AddOvfInstruction.AddOvfInt16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddOvfInstruction>.NativeClassPtr, "AddOvfInt16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddOvfInstruction.AddOvfInt16>.NativeClassPtr);
				AddOvfInstruction.AddOvfInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddOvfInstruction.AddOvfInt16>.NativeClassPtr, 100664810);
				AddOvfInstruction.AddOvfInt16.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddOvfInstruction.AddOvfInt16>.NativeClassPtr, 100664811);
			}

			// Token: 0x0600168D RID: 5773 RVA: 0x0006E620 File Offset: 0x0006C820
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015480, XrefRangeEnd = 1015483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddOvfInstruction.AddOvfInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600168E RID: 5774 RVA: 0x0006E670 File Offset: 0x0006C870
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AddOvfInt16()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddOvfInstruction.AddOvfInt16>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddOvfInstruction.AddOvfInt16.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600168F RID: 5775 RVA: 0x000098A7 File Offset: 0x00007AA7
			public AddOvfInt16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000FD7 RID: 4055
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04000FD8 RID: 4056
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001F0 RID: 496
		public sealed class AddOvfInt32 : AddOvfInstruction
		{
			// Token: 0x06001690 RID: 5776 RVA: 0x0006E6AC File Offset: 0x0006C8AC
			// Note: this type is marked as 'beforefieldinit'.
			static AddOvfInt32()
			{
				Il2CppClassPointerStore<AddOvfInstruction.AddOvfInt32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddOvfInstruction>.NativeClassPtr, "AddOvfInt32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddOvfInstruction.AddOvfInt32>.NativeClassPtr);
				AddOvfInstruction.AddOvfInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddOvfInstruction.AddOvfInt32>.NativeClassPtr, 100664812);
				AddOvfInstruction.AddOvfInt32.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddOvfInstruction.AddOvfInt32>.NativeClassPtr, 100664813);
			}

			// Token: 0x06001691 RID: 5777 RVA: 0x0006E700 File Offset: 0x0006C900
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015483, XrefRangeEnd = 1015486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddOvfInstruction.AddOvfInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001692 RID: 5778 RVA: 0x0006E750 File Offset: 0x0006C950
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AddOvfInt32()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddOvfInstruction.AddOvfInt32>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddOvfInstruction.AddOvfInt32.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001693 RID: 5779 RVA: 0x000098B0 File Offset: 0x00007AB0
			public AddOvfInt32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000FD9 RID: 4057
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04000FDA RID: 4058
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001F1 RID: 497
		public sealed class AddOvfInt64 : AddOvfInstruction
		{
			// Token: 0x06001694 RID: 5780 RVA: 0x0006E78C File Offset: 0x0006C98C
			// Note: this type is marked as 'beforefieldinit'.
			static AddOvfInt64()
			{
				Il2CppClassPointerStore<AddOvfInstruction.AddOvfInt64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddOvfInstruction>.NativeClassPtr, "AddOvfInt64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddOvfInstruction.AddOvfInt64>.NativeClassPtr);
				AddOvfInstruction.AddOvfInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddOvfInstruction.AddOvfInt64>.NativeClassPtr, 100664814);
				AddOvfInstruction.AddOvfInt64.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddOvfInstruction.AddOvfInt64>.NativeClassPtr, 100664815);
			}

			// Token: 0x06001695 RID: 5781 RVA: 0x0006E7E0 File Offset: 0x0006C9E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015486, XrefRangeEnd = 1015489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddOvfInstruction.AddOvfInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001696 RID: 5782 RVA: 0x0006E830 File Offset: 0x0006CA30
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AddOvfInt64()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddOvfInstruction.AddOvfInt64>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddOvfInstruction.AddOvfInt64.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001697 RID: 5783 RVA: 0x000098B9 File Offset: 0x00007AB9
			public AddOvfInt64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000FDB RID: 4059
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04000FDC RID: 4060
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001F2 RID: 498
		public sealed class AddOvfUInt16 : AddOvfInstruction
		{
			// Token: 0x06001698 RID: 5784 RVA: 0x0006E86C File Offset: 0x0006CA6C
			// Note: this type is marked as 'beforefieldinit'.
			static AddOvfUInt16()
			{
				Il2CppClassPointerStore<AddOvfInstruction.AddOvfUInt16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddOvfInstruction>.NativeClassPtr, "AddOvfUInt16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddOvfInstruction.AddOvfUInt16>.NativeClassPtr);
				AddOvfInstruction.AddOvfUInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddOvfInstruction.AddOvfUInt16>.NativeClassPtr, 100664816);
				AddOvfInstruction.AddOvfUInt16.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddOvfInstruction.AddOvfUInt16>.NativeClassPtr, 100664817);
			}

			// Token: 0x06001699 RID: 5785 RVA: 0x0006E8C0 File Offset: 0x0006CAC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015489, XrefRangeEnd = 1015492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddOvfInstruction.AddOvfUInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600169A RID: 5786 RVA: 0x0006E910 File Offset: 0x0006CB10
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AddOvfUInt16()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddOvfInstruction.AddOvfUInt16>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddOvfInstruction.AddOvfUInt16.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600169B RID: 5787 RVA: 0x000098C2 File Offset: 0x00007AC2
			public AddOvfUInt16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000FDD RID: 4061
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04000FDE RID: 4062
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001F3 RID: 499
		public sealed class AddOvfUInt32 : AddOvfInstruction
		{
			// Token: 0x0600169C RID: 5788 RVA: 0x0006E94C File Offset: 0x0006CB4C
			// Note: this type is marked as 'beforefieldinit'.
			static AddOvfUInt32()
			{
				Il2CppClassPointerStore<AddOvfInstruction.AddOvfUInt32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddOvfInstruction>.NativeClassPtr, "AddOvfUInt32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddOvfInstruction.AddOvfUInt32>.NativeClassPtr);
				AddOvfInstruction.AddOvfUInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddOvfInstruction.AddOvfUInt32>.NativeClassPtr, 100664818);
				AddOvfInstruction.AddOvfUInt32.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddOvfInstruction.AddOvfUInt32>.NativeClassPtr, 100664819);
			}

			// Token: 0x0600169D RID: 5789 RVA: 0x0006E9A0 File Offset: 0x0006CBA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015492, XrefRangeEnd = 1015495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddOvfInstruction.AddOvfUInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600169E RID: 5790 RVA: 0x0006E9F0 File Offset: 0x0006CBF0
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AddOvfUInt32()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddOvfInstruction.AddOvfUInt32>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddOvfInstruction.AddOvfUInt32.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600169F RID: 5791 RVA: 0x000098CB File Offset: 0x00007ACB
			public AddOvfUInt32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000FDF RID: 4063
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04000FE0 RID: 4064
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001F4 RID: 500
		public sealed class AddOvfUInt64 : AddOvfInstruction
		{
			// Token: 0x060016A0 RID: 5792 RVA: 0x0006EA2C File Offset: 0x0006CC2C
			// Note: this type is marked as 'beforefieldinit'.
			static AddOvfUInt64()
			{
				Il2CppClassPointerStore<AddOvfInstruction.AddOvfUInt64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddOvfInstruction>.NativeClassPtr, "AddOvfUInt64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddOvfInstruction.AddOvfUInt64>.NativeClassPtr);
				AddOvfInstruction.AddOvfUInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddOvfInstruction.AddOvfUInt64>.NativeClassPtr, 100664820);
				AddOvfInstruction.AddOvfUInt64.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddOvfInstruction.AddOvfUInt64>.NativeClassPtr, 100664821);
			}

			// Token: 0x060016A1 RID: 5793 RVA: 0x0006EA80 File Offset: 0x0006CC80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015495, XrefRangeEnd = 1015498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddOvfInstruction.AddOvfUInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060016A2 RID: 5794 RVA: 0x0006EAD0 File Offset: 0x0006CCD0
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AddOvfUInt64()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddOvfInstruction.AddOvfUInt64>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddOvfInstruction.AddOvfUInt64.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016A3 RID: 5795 RVA: 0x000098D4 File Offset: 0x00007AD4
			public AddOvfUInt64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000FE1 RID: 4065
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04000FE2 RID: 4066
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
