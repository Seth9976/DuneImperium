using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000B9 RID: 185
	public class GreaterThanInstruction : Instruction
	{
		// Token: 0x060009E2 RID: 2530 RVA: 0x0003A9B8 File Offset: 0x00038BB8
		// Note: this type is marked as 'beforefieldinit'.
		static GreaterThanInstruction()
		{
			Il2CppClassPointerStore<GreaterThanInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "GreaterThanInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GreaterThanInstruction>.NativeClassPtr);
			GreaterThanInstruction.NativeFieldInfoPtr__nullValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GreaterThanInstruction>.NativeClassPtr, "_nullValue");
			GreaterThanInstruction.NativeFieldInfoPtr_s_SByte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GreaterThanInstruction>.NativeClassPtr, "s_SByte");
			GreaterThanInstruction.NativeFieldInfoPtr_s_Int16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GreaterThanInstruction>.NativeClassPtr, "s_Int16");
			GreaterThanInstruction.NativeFieldInfoPtr_s_Char = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GreaterThanInstruction>.NativeClassPtr, "s_Char");
			GreaterThanInstruction.NativeFieldInfoPtr_s_Int32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GreaterThanInstruction>.NativeClassPtr, "s_Int32");
			GreaterThanInstruction.NativeFieldInfoPtr_s_Int64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GreaterThanInstruction>.NativeClassPtr, "s_Int64");
			GreaterThanInstruction.NativeFieldInfoPtr_s_Byte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GreaterThanInstruction>.NativeClassPtr, "s_Byte");
			GreaterThanInstruction.NativeFieldInfoPtr_s_UInt16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GreaterThanInstruction>.NativeClassPtr, "s_UInt16");
			GreaterThanInstruction.NativeFieldInfoPtr_s_UInt32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GreaterThanInstruction>.NativeClassPtr, "s_UInt32");
			GreaterThanInstruction.NativeFieldInfoPtr_s_UInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GreaterThanInstruction>.NativeClassPtr, "s_UInt64");
			GreaterThanInstruction.NativeFieldInfoPtr_s_Single = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GreaterThanInstruction>.NativeClassPtr, "s_Single");
			GreaterThanInstruction.NativeFieldInfoPtr_s_Double = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GreaterThanInstruction>.NativeClassPtr, "s_Double");
			GreaterThanInstruction.NativeFieldInfoPtr_s_liftedToNullSByte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GreaterThanInstruction>.NativeClassPtr, "s_liftedToNullSByte");
			GreaterThanInstruction.NativeFieldInfoPtr_s_liftedToNullInt16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GreaterThanInstruction>.NativeClassPtr, "s_liftedToNullInt16");
			GreaterThanInstruction.NativeFieldInfoPtr_s_liftedToNullChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GreaterThanInstruction>.NativeClassPtr, "s_liftedToNullChar");
			GreaterThanInstruction.NativeFieldInfoPtr_s_liftedToNullInt32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GreaterThanInstruction>.NativeClassPtr, "s_liftedToNullInt32");
			GreaterThanInstruction.NativeFieldInfoPtr_s_liftedToNullInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GreaterThanInstruction>.NativeClassPtr, "s_liftedToNullInt64");
			GreaterThanInstruction.NativeFieldInfoPtr_s_liftedToNullByte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GreaterThanInstruction>.NativeClassPtr, "s_liftedToNullByte");
			GreaterThanInstruction.NativeFieldInfoPtr_s_liftedToNullUInt16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GreaterThanInstruction>.NativeClassPtr, "s_liftedToNullUInt16");
			GreaterThanInstruction.NativeFieldInfoPtr_s_liftedToNullUInt32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GreaterThanInstruction>.NativeClassPtr, "s_liftedToNullUInt32");
			GreaterThanInstruction.NativeFieldInfoPtr_s_liftedToNullUInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GreaterThanInstruction>.NativeClassPtr, "s_liftedToNullUInt64");
			GreaterThanInstruction.NativeFieldInfoPtr_s_liftedToNullSingle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GreaterThanInstruction>.NativeClassPtr, "s_liftedToNullSingle");
			GreaterThanInstruction.NativeFieldInfoPtr_s_liftedToNullDouble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GreaterThanInstruction>.NativeClassPtr, "s_liftedToNullDouble");
			GreaterThanInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanInstruction>.NativeClassPtr, 100665170);
			GreaterThanInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanInstruction>.NativeClassPtr, 100665171);
			GreaterThanInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanInstruction>.NativeClassPtr, 100665172);
			GreaterThanInstruction.NativeMethodInfoPtr__ctor_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanInstruction>.NativeClassPtr, 100665173);
			GreaterThanInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanInstruction>.NativeClassPtr, 100665174);
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x060009E3 RID: 2531 RVA: 0x0003AC18 File Offset: 0x00038E18
		public unsafe override int ConsumedStack
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 72978, RefRangeEnd = 72985, XrefRangeStart = 72978, XrefRangeEnd = 72985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GreaterThanInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x060009E4 RID: 2532 RVA: 0x0003AC60 File Offset: 0x00038E60
		public unsafe override int ProducedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GreaterThanInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x060009E5 RID: 2533 RVA: 0x0003ACA8 File Offset: 0x00038EA8
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1017091, XrefRangeEnd = 1017093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GreaterThanInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x0003ACEC File Offset: 0x00038EEC
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GreaterThanInstruction(Object nullValue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GreaterThanInstruction>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullValue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GreaterThanInstruction.NativeMethodInfoPtr__ctor_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x0003AD38 File Offset: 0x00038F38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1017125, RefRangeEnd = 1017127, XrefRangeStart = 1017093, XrefRangeEnd = 1017125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Instruction Create(Type type, bool liftedToNull = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref liftedToNull;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GreaterThanInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x00004BBA File Offset: 0x00002DBA
		public GreaterThanInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x060009E9 RID: 2537 RVA: 0x0003AD8C File Offset: 0x00038F8C
		// (set) Token: 0x060009EA RID: 2538 RVA: 0x00004BC3 File Offset: 0x00002DC3
		public unsafe Object _nullValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GreaterThanInstruction.NativeFieldInfoPtr__nullValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GreaterThanInstruction.NativeFieldInfoPtr__nullValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x060009EB RID: 2539 RVA: 0x0003ADBC File Offset: 0x00038FBC
		// (set) Token: 0x060009EC RID: 2540 RVA: 0x00004BE2 File Offset: 0x00002DE2
		public unsafe static Instruction s_SByte
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GreaterThanInstruction.NativeFieldInfoPtr_s_SByte, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GreaterThanInstruction.NativeFieldInfoPtr_s_SByte, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x060009ED RID: 2541 RVA: 0x0003ADE4 File Offset: 0x00038FE4
		// (set) Token: 0x060009EE RID: 2542 RVA: 0x00004BF4 File Offset: 0x00002DF4
		public unsafe static Instruction s_Int16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GreaterThanInstruction.NativeFieldInfoPtr_s_Int16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GreaterThanInstruction.NativeFieldInfoPtr_s_Int16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x060009EF RID: 2543 RVA: 0x0003AE0C File Offset: 0x0003900C
		// (set) Token: 0x060009F0 RID: 2544 RVA: 0x00004C06 File Offset: 0x00002E06
		public unsafe static Instruction s_Char
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GreaterThanInstruction.NativeFieldInfoPtr_s_Char, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GreaterThanInstruction.NativeFieldInfoPtr_s_Char, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x060009F1 RID: 2545 RVA: 0x0003AE34 File Offset: 0x00039034
		// (set) Token: 0x060009F2 RID: 2546 RVA: 0x00004C18 File Offset: 0x00002E18
		public unsafe static Instruction s_Int32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GreaterThanInstruction.NativeFieldInfoPtr_s_Int32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GreaterThanInstruction.NativeFieldInfoPtr_s_Int32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x060009F3 RID: 2547 RVA: 0x0003AE5C File Offset: 0x0003905C
		// (set) Token: 0x060009F4 RID: 2548 RVA: 0x00004C2A File Offset: 0x00002E2A
		public unsafe static Instruction s_Int64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GreaterThanInstruction.NativeFieldInfoPtr_s_Int64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GreaterThanInstruction.NativeFieldInfoPtr_s_Int64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x060009F5 RID: 2549 RVA: 0x0003AE84 File Offset: 0x00039084
		// (set) Token: 0x060009F6 RID: 2550 RVA: 0x00004C3C File Offset: 0x00002E3C
		public unsafe static Instruction s_Byte
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GreaterThanInstruction.NativeFieldInfoPtr_s_Byte, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GreaterThanInstruction.NativeFieldInfoPtr_s_Byte, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x060009F7 RID: 2551 RVA: 0x0003AEAC File Offset: 0x000390AC
		// (set) Token: 0x060009F8 RID: 2552 RVA: 0x00004C4E File Offset: 0x00002E4E
		public unsafe static Instruction s_UInt16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GreaterThanInstruction.NativeFieldInfoPtr_s_UInt16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GreaterThanInstruction.NativeFieldInfoPtr_s_UInt16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x060009F9 RID: 2553 RVA: 0x0003AED4 File Offset: 0x000390D4
		// (set) Token: 0x060009FA RID: 2554 RVA: 0x00004C60 File Offset: 0x00002E60
		public unsafe static Instruction s_UInt32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GreaterThanInstruction.NativeFieldInfoPtr_s_UInt32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GreaterThanInstruction.NativeFieldInfoPtr_s_UInt32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x060009FB RID: 2555 RVA: 0x0003AEFC File Offset: 0x000390FC
		// (set) Token: 0x060009FC RID: 2556 RVA: 0x00004C72 File Offset: 0x00002E72
		public unsafe static Instruction s_UInt64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GreaterThanInstruction.NativeFieldInfoPtr_s_UInt64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GreaterThanInstruction.NativeFieldInfoPtr_s_UInt64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x060009FD RID: 2557 RVA: 0x0003AF24 File Offset: 0x00039124
		// (set) Token: 0x060009FE RID: 2558 RVA: 0x00004C84 File Offset: 0x00002E84
		public unsafe static Instruction s_Single
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GreaterThanInstruction.NativeFieldInfoPtr_s_Single, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GreaterThanInstruction.NativeFieldInfoPtr_s_Single, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x060009FF RID: 2559 RVA: 0x0003AF4C File Offset: 0x0003914C
		// (set) Token: 0x06000A00 RID: 2560 RVA: 0x00004C96 File Offset: 0x00002E96
		public unsafe static Instruction s_Double
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GreaterThanInstruction.NativeFieldInfoPtr_s_Double, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GreaterThanInstruction.NativeFieldInfoPtr_s_Double, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000A01 RID: 2561 RVA: 0x0003AF74 File Offset: 0x00039174
		// (set) Token: 0x06000A02 RID: 2562 RVA: 0x00004CA8 File Offset: 0x00002EA8
		public unsafe static Instruction s_liftedToNullSByte
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GreaterThanInstruction.NativeFieldInfoPtr_s_liftedToNullSByte, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GreaterThanInstruction.NativeFieldInfoPtr_s_liftedToNullSByte, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000A03 RID: 2563 RVA: 0x0003AF9C File Offset: 0x0003919C
		// (set) Token: 0x06000A04 RID: 2564 RVA: 0x00004CBA File Offset: 0x00002EBA
		public unsafe static Instruction s_liftedToNullInt16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GreaterThanInstruction.NativeFieldInfoPtr_s_liftedToNullInt16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GreaterThanInstruction.NativeFieldInfoPtr_s_liftedToNullInt16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000A05 RID: 2565 RVA: 0x0003AFC4 File Offset: 0x000391C4
		// (set) Token: 0x06000A06 RID: 2566 RVA: 0x00004CCC File Offset: 0x00002ECC
		public unsafe static Instruction s_liftedToNullChar
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GreaterThanInstruction.NativeFieldInfoPtr_s_liftedToNullChar, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GreaterThanInstruction.NativeFieldInfoPtr_s_liftedToNullChar, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000A07 RID: 2567 RVA: 0x0003AFEC File Offset: 0x000391EC
		// (set) Token: 0x06000A08 RID: 2568 RVA: 0x00004CDE File Offset: 0x00002EDE
		public unsafe static Instruction s_liftedToNullInt32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GreaterThanInstruction.NativeFieldInfoPtr_s_liftedToNullInt32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GreaterThanInstruction.NativeFieldInfoPtr_s_liftedToNullInt32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000A09 RID: 2569 RVA: 0x0003B014 File Offset: 0x00039214
		// (set) Token: 0x06000A0A RID: 2570 RVA: 0x00004CF0 File Offset: 0x00002EF0
		public unsafe static Instruction s_liftedToNullInt64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GreaterThanInstruction.NativeFieldInfoPtr_s_liftedToNullInt64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GreaterThanInstruction.NativeFieldInfoPtr_s_liftedToNullInt64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000A0B RID: 2571 RVA: 0x0003B03C File Offset: 0x0003923C
		// (set) Token: 0x06000A0C RID: 2572 RVA: 0x00004D02 File Offset: 0x00002F02
		public unsafe static Instruction s_liftedToNullByte
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GreaterThanInstruction.NativeFieldInfoPtr_s_liftedToNullByte, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GreaterThanInstruction.NativeFieldInfoPtr_s_liftedToNullByte, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000A0D RID: 2573 RVA: 0x0003B064 File Offset: 0x00039264
		// (set) Token: 0x06000A0E RID: 2574 RVA: 0x00004D14 File Offset: 0x00002F14
		public unsafe static Instruction s_liftedToNullUInt16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GreaterThanInstruction.NativeFieldInfoPtr_s_liftedToNullUInt16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GreaterThanInstruction.NativeFieldInfoPtr_s_liftedToNullUInt16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000A0F RID: 2575 RVA: 0x0003B08C File Offset: 0x0003928C
		// (set) Token: 0x06000A10 RID: 2576 RVA: 0x00004D26 File Offset: 0x00002F26
		public unsafe static Instruction s_liftedToNullUInt32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GreaterThanInstruction.NativeFieldInfoPtr_s_liftedToNullUInt32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GreaterThanInstruction.NativeFieldInfoPtr_s_liftedToNullUInt32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000A11 RID: 2577 RVA: 0x0003B0B4 File Offset: 0x000392B4
		// (set) Token: 0x06000A12 RID: 2578 RVA: 0x00004D38 File Offset: 0x00002F38
		public unsafe static Instruction s_liftedToNullUInt64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GreaterThanInstruction.NativeFieldInfoPtr_s_liftedToNullUInt64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GreaterThanInstruction.NativeFieldInfoPtr_s_liftedToNullUInt64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000A13 RID: 2579 RVA: 0x0003B0DC File Offset: 0x000392DC
		// (set) Token: 0x06000A14 RID: 2580 RVA: 0x00004D4A File Offset: 0x00002F4A
		public unsafe static Instruction s_liftedToNullSingle
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GreaterThanInstruction.NativeFieldInfoPtr_s_liftedToNullSingle, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GreaterThanInstruction.NativeFieldInfoPtr_s_liftedToNullSingle, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000A15 RID: 2581 RVA: 0x0003B104 File Offset: 0x00039304
		// (set) Token: 0x06000A16 RID: 2582 RVA: 0x00004D5C File Offset: 0x00002F5C
		public unsafe static Instruction s_liftedToNullDouble
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GreaterThanInstruction.NativeFieldInfoPtr_s_liftedToNullDouble, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GreaterThanInstruction.NativeFieldInfoPtr_s_liftedToNullDouble, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400076F RID: 1903
		private static readonly IntPtr NativeFieldInfoPtr__nullValue;

		// Token: 0x04000770 RID: 1904
		private static readonly IntPtr NativeFieldInfoPtr_s_SByte;

		// Token: 0x04000771 RID: 1905
		private static readonly IntPtr NativeFieldInfoPtr_s_Int16;

		// Token: 0x04000772 RID: 1906
		private static readonly IntPtr NativeFieldInfoPtr_s_Char;

		// Token: 0x04000773 RID: 1907
		private static readonly IntPtr NativeFieldInfoPtr_s_Int32;

		// Token: 0x04000774 RID: 1908
		private static readonly IntPtr NativeFieldInfoPtr_s_Int64;

		// Token: 0x04000775 RID: 1909
		private static readonly IntPtr NativeFieldInfoPtr_s_Byte;

		// Token: 0x04000776 RID: 1910
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt16;

		// Token: 0x04000777 RID: 1911
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt32;

		// Token: 0x04000778 RID: 1912
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt64;

		// Token: 0x04000779 RID: 1913
		private static readonly IntPtr NativeFieldInfoPtr_s_Single;

		// Token: 0x0400077A RID: 1914
		private static readonly IntPtr NativeFieldInfoPtr_s_Double;

		// Token: 0x0400077B RID: 1915
		private static readonly IntPtr NativeFieldInfoPtr_s_liftedToNullSByte;

		// Token: 0x0400077C RID: 1916
		private static readonly IntPtr NativeFieldInfoPtr_s_liftedToNullInt16;

		// Token: 0x0400077D RID: 1917
		private static readonly IntPtr NativeFieldInfoPtr_s_liftedToNullChar;

		// Token: 0x0400077E RID: 1918
		private static readonly IntPtr NativeFieldInfoPtr_s_liftedToNullInt32;

		// Token: 0x0400077F RID: 1919
		private static readonly IntPtr NativeFieldInfoPtr_s_liftedToNullInt64;

		// Token: 0x04000780 RID: 1920
		private static readonly IntPtr NativeFieldInfoPtr_s_liftedToNullByte;

		// Token: 0x04000781 RID: 1921
		private static readonly IntPtr NativeFieldInfoPtr_s_liftedToNullUInt16;

		// Token: 0x04000782 RID: 1922
		private static readonly IntPtr NativeFieldInfoPtr_s_liftedToNullUInt32;

		// Token: 0x04000783 RID: 1923
		private static readonly IntPtr NativeFieldInfoPtr_s_liftedToNullUInt64;

		// Token: 0x04000784 RID: 1924
		private static readonly IntPtr NativeFieldInfoPtr_s_liftedToNullSingle;

		// Token: 0x04000785 RID: 1925
		private static readonly IntPtr NativeFieldInfoPtr_s_liftedToNullDouble;

		// Token: 0x04000786 RID: 1926
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000787 RID: 1927
		private static readonly IntPtr NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000788 RID: 1928
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x04000789 RID: 1929
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Object_0;

		// Token: 0x0400078A RID: 1930
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_Boolean_0;

		// Token: 0x02000230 RID: 560
		public sealed class GreaterThanSByte : GreaterThanInstruction
		{
			// Token: 0x06001790 RID: 6032 RVA: 0x00071EAC File Offset: 0x000700AC
			// Note: this type is marked as 'beforefieldinit'.
			static GreaterThanSByte()
			{
				Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanSByte>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GreaterThanInstruction>.NativeClassPtr, "GreaterThanSByte");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanSByte>.NativeClassPtr);
				GreaterThanInstruction.GreaterThanSByte.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanSByte>.NativeClassPtr, 100665175);
				GreaterThanInstruction.GreaterThanSByte.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanSByte>.NativeClassPtr, 100665176);
			}

			// Token: 0x06001791 RID: 6033 RVA: 0x00071F00 File Offset: 0x00070100
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GreaterThanSByte(Object nullValue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanSByte>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullValue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GreaterThanInstruction.GreaterThanSByte.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001792 RID: 6034 RVA: 0x00071F4C File Offset: 0x0007014C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016992, XrefRangeEnd = 1017001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GreaterThanInstruction.GreaterThanSByte.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001793 RID: 6035 RVA: 0x00009AF0 File Offset: 0x00007CF0
			public GreaterThanSByte(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001059 RID: 4185
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

			// Token: 0x0400105A RID: 4186
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
		}

		// Token: 0x02000231 RID: 561
		public sealed class GreaterThanInt16 : GreaterThanInstruction
		{
			// Token: 0x06001794 RID: 6036 RVA: 0x00071F9C File Offset: 0x0007019C
			// Note: this type is marked as 'beforefieldinit'.
			static GreaterThanInt16()
			{
				Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanInt16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GreaterThanInstruction>.NativeClassPtr, "GreaterThanInt16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanInt16>.NativeClassPtr);
				GreaterThanInstruction.GreaterThanInt16.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanInt16>.NativeClassPtr, 100665177);
				GreaterThanInstruction.GreaterThanInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanInt16>.NativeClassPtr, 100665178);
			}

			// Token: 0x06001795 RID: 6037 RVA: 0x00071FF0 File Offset: 0x000701F0
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GreaterThanInt16(Object nullValue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanInt16>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullValue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GreaterThanInstruction.GreaterThanInt16.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001796 RID: 6038 RVA: 0x0007203C File Offset: 0x0007023C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1017001, XrefRangeEnd = 1017010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GreaterThanInstruction.GreaterThanInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001797 RID: 6039 RVA: 0x00009AF9 File Offset: 0x00007CF9
			public GreaterThanInt16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400105B RID: 4187
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

			// Token: 0x0400105C RID: 4188
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
		}

		// Token: 0x02000232 RID: 562
		public sealed class GreaterThanChar : GreaterThanInstruction
		{
			// Token: 0x06001798 RID: 6040 RVA: 0x0007208C File Offset: 0x0007028C
			// Note: this type is marked as 'beforefieldinit'.
			static GreaterThanChar()
			{
				Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanChar>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GreaterThanInstruction>.NativeClassPtr, "GreaterThanChar");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanChar>.NativeClassPtr);
				GreaterThanInstruction.GreaterThanChar.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanChar>.NativeClassPtr, 100665179);
				GreaterThanInstruction.GreaterThanChar.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanChar>.NativeClassPtr, 100665180);
			}

			// Token: 0x06001799 RID: 6041 RVA: 0x000720E0 File Offset: 0x000702E0
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GreaterThanChar(Object nullValue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanChar>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullValue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GreaterThanInstruction.GreaterThanChar.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600179A RID: 6042 RVA: 0x0007212C File Offset: 0x0007032C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1017010, XrefRangeEnd = 1017019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GreaterThanInstruction.GreaterThanChar.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600179B RID: 6043 RVA: 0x00009B02 File Offset: 0x00007D02
			public GreaterThanChar(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400105D RID: 4189
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

			// Token: 0x0400105E RID: 4190
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
		}

		// Token: 0x02000233 RID: 563
		public sealed class GreaterThanInt32 : GreaterThanInstruction
		{
			// Token: 0x0600179C RID: 6044 RVA: 0x0007217C File Offset: 0x0007037C
			// Note: this type is marked as 'beforefieldinit'.
			static GreaterThanInt32()
			{
				Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanInt32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GreaterThanInstruction>.NativeClassPtr, "GreaterThanInt32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanInt32>.NativeClassPtr);
				GreaterThanInstruction.GreaterThanInt32.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanInt32>.NativeClassPtr, 100665181);
				GreaterThanInstruction.GreaterThanInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanInt32>.NativeClassPtr, 100665182);
			}

			// Token: 0x0600179D RID: 6045 RVA: 0x000721D0 File Offset: 0x000703D0
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GreaterThanInt32(Object nullValue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanInt32>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullValue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GreaterThanInstruction.GreaterThanInt32.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600179E RID: 6046 RVA: 0x0007221C File Offset: 0x0007041C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1017019, XrefRangeEnd = 1017028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GreaterThanInstruction.GreaterThanInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600179F RID: 6047 RVA: 0x00009B0B File Offset: 0x00007D0B
			public GreaterThanInt32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400105F RID: 4191
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

			// Token: 0x04001060 RID: 4192
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
		}

		// Token: 0x02000234 RID: 564
		public sealed class GreaterThanInt64 : GreaterThanInstruction
		{
			// Token: 0x060017A0 RID: 6048 RVA: 0x0007226C File Offset: 0x0007046C
			// Note: this type is marked as 'beforefieldinit'.
			static GreaterThanInt64()
			{
				Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanInt64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GreaterThanInstruction>.NativeClassPtr, "GreaterThanInt64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanInt64>.NativeClassPtr);
				GreaterThanInstruction.GreaterThanInt64.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanInt64>.NativeClassPtr, 100665183);
				GreaterThanInstruction.GreaterThanInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanInt64>.NativeClassPtr, 100665184);
			}

			// Token: 0x060017A1 RID: 6049 RVA: 0x000722C0 File Offset: 0x000704C0
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GreaterThanInt64(Object nullValue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanInt64>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullValue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GreaterThanInstruction.GreaterThanInt64.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060017A2 RID: 6050 RVA: 0x0007230C File Offset: 0x0007050C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1017028, XrefRangeEnd = 1017037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GreaterThanInstruction.GreaterThanInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060017A3 RID: 6051 RVA: 0x00009B14 File Offset: 0x00007D14
			public GreaterThanInt64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001061 RID: 4193
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

			// Token: 0x04001062 RID: 4194
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
		}

		// Token: 0x02000235 RID: 565
		public sealed class GreaterThanByte : GreaterThanInstruction
		{
			// Token: 0x060017A4 RID: 6052 RVA: 0x0007235C File Offset: 0x0007055C
			// Note: this type is marked as 'beforefieldinit'.
			static GreaterThanByte()
			{
				Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanByte>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GreaterThanInstruction>.NativeClassPtr, "GreaterThanByte");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanByte>.NativeClassPtr);
				GreaterThanInstruction.GreaterThanByte.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanByte>.NativeClassPtr, 100665185);
				GreaterThanInstruction.GreaterThanByte.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanByte>.NativeClassPtr, 100665186);
			}

			// Token: 0x060017A5 RID: 6053 RVA: 0x000723B0 File Offset: 0x000705B0
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GreaterThanByte(Object nullValue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanByte>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullValue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GreaterThanInstruction.GreaterThanByte.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060017A6 RID: 6054 RVA: 0x000723FC File Offset: 0x000705FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1017037, XrefRangeEnd = 1017046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GreaterThanInstruction.GreaterThanByte.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060017A7 RID: 6055 RVA: 0x00009B1D File Offset: 0x00007D1D
			public GreaterThanByte(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001063 RID: 4195
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

			// Token: 0x04001064 RID: 4196
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
		}

		// Token: 0x02000236 RID: 566
		public sealed class GreaterThanUInt16 : GreaterThanInstruction
		{
			// Token: 0x060017A8 RID: 6056 RVA: 0x0007244C File Offset: 0x0007064C
			// Note: this type is marked as 'beforefieldinit'.
			static GreaterThanUInt16()
			{
				Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanUInt16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GreaterThanInstruction>.NativeClassPtr, "GreaterThanUInt16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanUInt16>.NativeClassPtr);
				GreaterThanInstruction.GreaterThanUInt16.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanUInt16>.NativeClassPtr, 100665187);
				GreaterThanInstruction.GreaterThanUInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanUInt16>.NativeClassPtr, 100665188);
			}

			// Token: 0x060017A9 RID: 6057 RVA: 0x000724A0 File Offset: 0x000706A0
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GreaterThanUInt16(Object nullValue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanUInt16>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullValue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GreaterThanInstruction.GreaterThanUInt16.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060017AA RID: 6058 RVA: 0x000724EC File Offset: 0x000706EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1017046, XrefRangeEnd = 1017055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GreaterThanInstruction.GreaterThanUInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060017AB RID: 6059 RVA: 0x00009B26 File Offset: 0x00007D26
			public GreaterThanUInt16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001065 RID: 4197
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

			// Token: 0x04001066 RID: 4198
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
		}

		// Token: 0x02000237 RID: 567
		public sealed class GreaterThanUInt32 : GreaterThanInstruction
		{
			// Token: 0x060017AC RID: 6060 RVA: 0x0007253C File Offset: 0x0007073C
			// Note: this type is marked as 'beforefieldinit'.
			static GreaterThanUInt32()
			{
				Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanUInt32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GreaterThanInstruction>.NativeClassPtr, "GreaterThanUInt32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanUInt32>.NativeClassPtr);
				GreaterThanInstruction.GreaterThanUInt32.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanUInt32>.NativeClassPtr, 100665189);
				GreaterThanInstruction.GreaterThanUInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanUInt32>.NativeClassPtr, 100665190);
			}

			// Token: 0x060017AD RID: 6061 RVA: 0x00072590 File Offset: 0x00070790
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GreaterThanUInt32(Object nullValue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanUInt32>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullValue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GreaterThanInstruction.GreaterThanUInt32.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060017AE RID: 6062 RVA: 0x000725DC File Offset: 0x000707DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1017055, XrefRangeEnd = 1017064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GreaterThanInstruction.GreaterThanUInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060017AF RID: 6063 RVA: 0x00009B2F File Offset: 0x00007D2F
			public GreaterThanUInt32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001067 RID: 4199
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

			// Token: 0x04001068 RID: 4200
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
		}

		// Token: 0x02000238 RID: 568
		public sealed class GreaterThanUInt64 : GreaterThanInstruction
		{
			// Token: 0x060017B0 RID: 6064 RVA: 0x0007262C File Offset: 0x0007082C
			// Note: this type is marked as 'beforefieldinit'.
			static GreaterThanUInt64()
			{
				Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanUInt64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GreaterThanInstruction>.NativeClassPtr, "GreaterThanUInt64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanUInt64>.NativeClassPtr);
				GreaterThanInstruction.GreaterThanUInt64.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanUInt64>.NativeClassPtr, 100665191);
				GreaterThanInstruction.GreaterThanUInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanUInt64>.NativeClassPtr, 100665192);
			}

			// Token: 0x060017B1 RID: 6065 RVA: 0x00072680 File Offset: 0x00070880
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GreaterThanUInt64(Object nullValue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanUInt64>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullValue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GreaterThanInstruction.GreaterThanUInt64.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060017B2 RID: 6066 RVA: 0x000726CC File Offset: 0x000708CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1017064, XrefRangeEnd = 1017073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GreaterThanInstruction.GreaterThanUInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060017B3 RID: 6067 RVA: 0x00009B38 File Offset: 0x00007D38
			public GreaterThanUInt64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001069 RID: 4201
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

			// Token: 0x0400106A RID: 4202
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
		}

		// Token: 0x02000239 RID: 569
		public sealed class GreaterThanSingle : GreaterThanInstruction
		{
			// Token: 0x060017B4 RID: 6068 RVA: 0x0007271C File Offset: 0x0007091C
			// Note: this type is marked as 'beforefieldinit'.
			static GreaterThanSingle()
			{
				Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanSingle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GreaterThanInstruction>.NativeClassPtr, "GreaterThanSingle");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanSingle>.NativeClassPtr);
				GreaterThanInstruction.GreaterThanSingle.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanSingle>.NativeClassPtr, 100665193);
				GreaterThanInstruction.GreaterThanSingle.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanSingle>.NativeClassPtr, 100665194);
			}

			// Token: 0x060017B5 RID: 6069 RVA: 0x00072770 File Offset: 0x00070970
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GreaterThanSingle(Object nullValue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanSingle>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullValue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GreaterThanInstruction.GreaterThanSingle.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060017B6 RID: 6070 RVA: 0x000727BC File Offset: 0x000709BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1017073, XrefRangeEnd = 1017082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GreaterThanInstruction.GreaterThanSingle.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060017B7 RID: 6071 RVA: 0x00009B41 File Offset: 0x00007D41
			public GreaterThanSingle(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400106B RID: 4203
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

			// Token: 0x0400106C RID: 4204
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
		}

		// Token: 0x0200023A RID: 570
		public sealed class GreaterThanDouble : GreaterThanInstruction
		{
			// Token: 0x060017B8 RID: 6072 RVA: 0x0007280C File Offset: 0x00070A0C
			// Note: this type is marked as 'beforefieldinit'.
			static GreaterThanDouble()
			{
				Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanDouble>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GreaterThanInstruction>.NativeClassPtr, "GreaterThanDouble");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanDouble>.NativeClassPtr);
				GreaterThanInstruction.GreaterThanDouble.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanDouble>.NativeClassPtr, 100665195);
				GreaterThanInstruction.GreaterThanDouble.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanDouble>.NativeClassPtr, 100665196);
			}

			// Token: 0x060017B9 RID: 6073 RVA: 0x00072860 File Offset: 0x00070A60
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GreaterThanDouble(Object nullValue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GreaterThanInstruction.GreaterThanDouble>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullValue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GreaterThanInstruction.GreaterThanDouble.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060017BA RID: 6074 RVA: 0x000728AC File Offset: 0x00070AAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1017082, XrefRangeEnd = 1017091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GreaterThanInstruction.GreaterThanDouble.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060017BB RID: 6075 RVA: 0x00009B4A File Offset: 0x00007D4A
			public GreaterThanDouble(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400106D RID: 4205
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

			// Token: 0x0400106E RID: 4206
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
		}
	}
}
