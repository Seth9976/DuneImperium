using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000B2 RID: 178
	public class EqualInstruction : Instruction
	{
		// Token: 0x06000971 RID: 2417 RVA: 0x00039624 File Offset: 0x00037824
		// Note: this type is marked as 'beforefieldinit'.
		static EqualInstruction()
		{
			Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "EqualInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr);
			EqualInstruction.NativeFieldInfoPtr_s_reference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, "s_reference");
			EqualInstruction.NativeFieldInfoPtr_s_Boolean = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, "s_Boolean");
			EqualInstruction.NativeFieldInfoPtr_s_SByte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, "s_SByte");
			EqualInstruction.NativeFieldInfoPtr_s_Int16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, "s_Int16");
			EqualInstruction.NativeFieldInfoPtr_s_Char = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, "s_Char");
			EqualInstruction.NativeFieldInfoPtr_s_Int32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, "s_Int32");
			EqualInstruction.NativeFieldInfoPtr_s_Int64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, "s_Int64");
			EqualInstruction.NativeFieldInfoPtr_s_Byte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, "s_Byte");
			EqualInstruction.NativeFieldInfoPtr_s_UInt16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, "s_UInt16");
			EqualInstruction.NativeFieldInfoPtr_s_UInt32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, "s_UInt32");
			EqualInstruction.NativeFieldInfoPtr_s_UInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, "s_UInt64");
			EqualInstruction.NativeFieldInfoPtr_s_Single = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, "s_Single");
			EqualInstruction.NativeFieldInfoPtr_s_Double = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, "s_Double");
			EqualInstruction.NativeFieldInfoPtr_s_BooleanLiftedToNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, "s_BooleanLiftedToNull");
			EqualInstruction.NativeFieldInfoPtr_s_SByteLiftedToNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, "s_SByteLiftedToNull");
			EqualInstruction.NativeFieldInfoPtr_s_Int16LiftedToNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, "s_Int16LiftedToNull");
			EqualInstruction.NativeFieldInfoPtr_s_CharLiftedToNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, "s_CharLiftedToNull");
			EqualInstruction.NativeFieldInfoPtr_s_Int32LiftedToNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, "s_Int32LiftedToNull");
			EqualInstruction.NativeFieldInfoPtr_s_Int64LiftedToNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, "s_Int64LiftedToNull");
			EqualInstruction.NativeFieldInfoPtr_s_ByteLiftedToNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, "s_ByteLiftedToNull");
			EqualInstruction.NativeFieldInfoPtr_s_UInt16LiftedToNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, "s_UInt16LiftedToNull");
			EqualInstruction.NativeFieldInfoPtr_s_UInt32LiftedToNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, "s_UInt32LiftedToNull");
			EqualInstruction.NativeFieldInfoPtr_s_UInt64LiftedToNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, "s_UInt64LiftedToNull");
			EqualInstruction.NativeFieldInfoPtr_s_SingleLiftedToNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, "s_SingleLiftedToNull");
			EqualInstruction.NativeFieldInfoPtr_s_DoubleLiftedToNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, "s_DoubleLiftedToNull");
			EqualInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, 100665073);
			EqualInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, 100665074);
			EqualInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, 100665075);
			EqualInstruction.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, 100665076);
			EqualInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, 100665077);
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000972 RID: 2418 RVA: 0x000398AC File Offset: 0x00037AAC
		public unsafe override int ConsumedStack
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 72978, RefRangeEnd = 72985, XrefRangeStart = 72978, XrefRangeEnd = 72985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EqualInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000973 RID: 2419 RVA: 0x000398F4 File Offset: 0x00037AF4
		public unsafe override int ProducedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EqualInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000974 RID: 2420 RVA: 0x0003993C File Offset: 0x00037B3C
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016651, XrefRangeEnd = 1016653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EqualInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x00039980 File Offset: 0x00037B80
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EqualInstruction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x000399BC File Offset: 0x00037BBC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1016867, RefRangeEnd = 1016873, XrefRangeStart = 1016653, XrefRangeEnd = 1016867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Instruction Create(Type type, bool liftedToNull)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref liftedToNull;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x000048F8 File Offset: 0x00002AF8
		public EqualInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000978 RID: 2424 RVA: 0x00039A10 File Offset: 0x00037C10
		// (set) Token: 0x06000979 RID: 2425 RVA: 0x00004901 File Offset: 0x00002B01
		public unsafe static Instruction s_reference
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EqualInstruction.NativeFieldInfoPtr_s_reference, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EqualInstruction.NativeFieldInfoPtr_s_reference, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x0600097A RID: 2426 RVA: 0x00039A38 File Offset: 0x00037C38
		// (set) Token: 0x0600097B RID: 2427 RVA: 0x00004913 File Offset: 0x00002B13
		public unsafe static Instruction s_Boolean
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EqualInstruction.NativeFieldInfoPtr_s_Boolean, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EqualInstruction.NativeFieldInfoPtr_s_Boolean, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x0600097C RID: 2428 RVA: 0x00039A60 File Offset: 0x00037C60
		// (set) Token: 0x0600097D RID: 2429 RVA: 0x00004925 File Offset: 0x00002B25
		public unsafe static Instruction s_SByte
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EqualInstruction.NativeFieldInfoPtr_s_SByte, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EqualInstruction.NativeFieldInfoPtr_s_SByte, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x0600097E RID: 2430 RVA: 0x00039A88 File Offset: 0x00037C88
		// (set) Token: 0x0600097F RID: 2431 RVA: 0x00004937 File Offset: 0x00002B37
		public unsafe static Instruction s_Int16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EqualInstruction.NativeFieldInfoPtr_s_Int16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EqualInstruction.NativeFieldInfoPtr_s_Int16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000980 RID: 2432 RVA: 0x00039AB0 File Offset: 0x00037CB0
		// (set) Token: 0x06000981 RID: 2433 RVA: 0x00004949 File Offset: 0x00002B49
		public unsafe static Instruction s_Char
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EqualInstruction.NativeFieldInfoPtr_s_Char, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EqualInstruction.NativeFieldInfoPtr_s_Char, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000982 RID: 2434 RVA: 0x00039AD8 File Offset: 0x00037CD8
		// (set) Token: 0x06000983 RID: 2435 RVA: 0x0000495B File Offset: 0x00002B5B
		public unsafe static Instruction s_Int32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EqualInstruction.NativeFieldInfoPtr_s_Int32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EqualInstruction.NativeFieldInfoPtr_s_Int32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000984 RID: 2436 RVA: 0x00039B00 File Offset: 0x00037D00
		// (set) Token: 0x06000985 RID: 2437 RVA: 0x0000496D File Offset: 0x00002B6D
		public unsafe static Instruction s_Int64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EqualInstruction.NativeFieldInfoPtr_s_Int64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EqualInstruction.NativeFieldInfoPtr_s_Int64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000986 RID: 2438 RVA: 0x00039B28 File Offset: 0x00037D28
		// (set) Token: 0x06000987 RID: 2439 RVA: 0x0000497F File Offset: 0x00002B7F
		public unsafe static Instruction s_Byte
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EqualInstruction.NativeFieldInfoPtr_s_Byte, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EqualInstruction.NativeFieldInfoPtr_s_Byte, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000988 RID: 2440 RVA: 0x00039B50 File Offset: 0x00037D50
		// (set) Token: 0x06000989 RID: 2441 RVA: 0x00004991 File Offset: 0x00002B91
		public unsafe static Instruction s_UInt16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EqualInstruction.NativeFieldInfoPtr_s_UInt16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EqualInstruction.NativeFieldInfoPtr_s_UInt16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x0600098A RID: 2442 RVA: 0x00039B78 File Offset: 0x00037D78
		// (set) Token: 0x0600098B RID: 2443 RVA: 0x000049A3 File Offset: 0x00002BA3
		public unsafe static Instruction s_UInt32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EqualInstruction.NativeFieldInfoPtr_s_UInt32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EqualInstruction.NativeFieldInfoPtr_s_UInt32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x0600098C RID: 2444 RVA: 0x00039BA0 File Offset: 0x00037DA0
		// (set) Token: 0x0600098D RID: 2445 RVA: 0x000049B5 File Offset: 0x00002BB5
		public unsafe static Instruction s_UInt64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EqualInstruction.NativeFieldInfoPtr_s_UInt64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EqualInstruction.NativeFieldInfoPtr_s_UInt64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x0600098E RID: 2446 RVA: 0x00039BC8 File Offset: 0x00037DC8
		// (set) Token: 0x0600098F RID: 2447 RVA: 0x000049C7 File Offset: 0x00002BC7
		public unsafe static Instruction s_Single
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EqualInstruction.NativeFieldInfoPtr_s_Single, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EqualInstruction.NativeFieldInfoPtr_s_Single, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000990 RID: 2448 RVA: 0x00039BF0 File Offset: 0x00037DF0
		// (set) Token: 0x06000991 RID: 2449 RVA: 0x000049D9 File Offset: 0x00002BD9
		public unsafe static Instruction s_Double
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EqualInstruction.NativeFieldInfoPtr_s_Double, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EqualInstruction.NativeFieldInfoPtr_s_Double, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000992 RID: 2450 RVA: 0x00039C18 File Offset: 0x00037E18
		// (set) Token: 0x06000993 RID: 2451 RVA: 0x000049EB File Offset: 0x00002BEB
		public unsafe static Instruction s_BooleanLiftedToNull
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EqualInstruction.NativeFieldInfoPtr_s_BooleanLiftedToNull, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EqualInstruction.NativeFieldInfoPtr_s_BooleanLiftedToNull, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000994 RID: 2452 RVA: 0x00039C40 File Offset: 0x00037E40
		// (set) Token: 0x06000995 RID: 2453 RVA: 0x000049FD File Offset: 0x00002BFD
		public unsafe static Instruction s_SByteLiftedToNull
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EqualInstruction.NativeFieldInfoPtr_s_SByteLiftedToNull, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EqualInstruction.NativeFieldInfoPtr_s_SByteLiftedToNull, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000996 RID: 2454 RVA: 0x00039C68 File Offset: 0x00037E68
		// (set) Token: 0x06000997 RID: 2455 RVA: 0x00004A0F File Offset: 0x00002C0F
		public unsafe static Instruction s_Int16LiftedToNull
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EqualInstruction.NativeFieldInfoPtr_s_Int16LiftedToNull, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EqualInstruction.NativeFieldInfoPtr_s_Int16LiftedToNull, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000998 RID: 2456 RVA: 0x00039C90 File Offset: 0x00037E90
		// (set) Token: 0x06000999 RID: 2457 RVA: 0x00004A21 File Offset: 0x00002C21
		public unsafe static Instruction s_CharLiftedToNull
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EqualInstruction.NativeFieldInfoPtr_s_CharLiftedToNull, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EqualInstruction.NativeFieldInfoPtr_s_CharLiftedToNull, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x0600099A RID: 2458 RVA: 0x00039CB8 File Offset: 0x00037EB8
		// (set) Token: 0x0600099B RID: 2459 RVA: 0x00004A33 File Offset: 0x00002C33
		public unsafe static Instruction s_Int32LiftedToNull
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EqualInstruction.NativeFieldInfoPtr_s_Int32LiftedToNull, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EqualInstruction.NativeFieldInfoPtr_s_Int32LiftedToNull, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x0600099C RID: 2460 RVA: 0x00039CE0 File Offset: 0x00037EE0
		// (set) Token: 0x0600099D RID: 2461 RVA: 0x00004A45 File Offset: 0x00002C45
		public unsafe static Instruction s_Int64LiftedToNull
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EqualInstruction.NativeFieldInfoPtr_s_Int64LiftedToNull, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EqualInstruction.NativeFieldInfoPtr_s_Int64LiftedToNull, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x0600099E RID: 2462 RVA: 0x00039D08 File Offset: 0x00037F08
		// (set) Token: 0x0600099F RID: 2463 RVA: 0x00004A57 File Offset: 0x00002C57
		public unsafe static Instruction s_ByteLiftedToNull
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EqualInstruction.NativeFieldInfoPtr_s_ByteLiftedToNull, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EqualInstruction.NativeFieldInfoPtr_s_ByteLiftedToNull, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x060009A0 RID: 2464 RVA: 0x00039D30 File Offset: 0x00037F30
		// (set) Token: 0x060009A1 RID: 2465 RVA: 0x00004A69 File Offset: 0x00002C69
		public unsafe static Instruction s_UInt16LiftedToNull
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EqualInstruction.NativeFieldInfoPtr_s_UInt16LiftedToNull, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EqualInstruction.NativeFieldInfoPtr_s_UInt16LiftedToNull, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x060009A2 RID: 2466 RVA: 0x00039D58 File Offset: 0x00037F58
		// (set) Token: 0x060009A3 RID: 2467 RVA: 0x00004A7B File Offset: 0x00002C7B
		public unsafe static Instruction s_UInt32LiftedToNull
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EqualInstruction.NativeFieldInfoPtr_s_UInt32LiftedToNull, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EqualInstruction.NativeFieldInfoPtr_s_UInt32LiftedToNull, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x060009A4 RID: 2468 RVA: 0x00039D80 File Offset: 0x00037F80
		// (set) Token: 0x060009A5 RID: 2469 RVA: 0x00004A8D File Offset: 0x00002C8D
		public unsafe static Instruction s_UInt64LiftedToNull
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EqualInstruction.NativeFieldInfoPtr_s_UInt64LiftedToNull, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EqualInstruction.NativeFieldInfoPtr_s_UInt64LiftedToNull, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x060009A6 RID: 2470 RVA: 0x00039DA8 File Offset: 0x00037FA8
		// (set) Token: 0x060009A7 RID: 2471 RVA: 0x00004A9F File Offset: 0x00002C9F
		public unsafe static Instruction s_SingleLiftedToNull
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EqualInstruction.NativeFieldInfoPtr_s_SingleLiftedToNull, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EqualInstruction.NativeFieldInfoPtr_s_SingleLiftedToNull, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x060009A8 RID: 2472 RVA: 0x00039DD0 File Offset: 0x00037FD0
		// (set) Token: 0x060009A9 RID: 2473 RVA: 0x00004AB1 File Offset: 0x00002CB1
		public unsafe static Instruction s_DoubleLiftedToNull
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EqualInstruction.NativeFieldInfoPtr_s_DoubleLiftedToNull, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EqualInstruction.NativeFieldInfoPtr_s_DoubleLiftedToNull, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400072F RID: 1839
		private static readonly IntPtr NativeFieldInfoPtr_s_reference;

		// Token: 0x04000730 RID: 1840
		private static readonly IntPtr NativeFieldInfoPtr_s_Boolean;

		// Token: 0x04000731 RID: 1841
		private static readonly IntPtr NativeFieldInfoPtr_s_SByte;

		// Token: 0x04000732 RID: 1842
		private static readonly IntPtr NativeFieldInfoPtr_s_Int16;

		// Token: 0x04000733 RID: 1843
		private static readonly IntPtr NativeFieldInfoPtr_s_Char;

		// Token: 0x04000734 RID: 1844
		private static readonly IntPtr NativeFieldInfoPtr_s_Int32;

		// Token: 0x04000735 RID: 1845
		private static readonly IntPtr NativeFieldInfoPtr_s_Int64;

		// Token: 0x04000736 RID: 1846
		private static readonly IntPtr NativeFieldInfoPtr_s_Byte;

		// Token: 0x04000737 RID: 1847
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt16;

		// Token: 0x04000738 RID: 1848
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt32;

		// Token: 0x04000739 RID: 1849
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt64;

		// Token: 0x0400073A RID: 1850
		private static readonly IntPtr NativeFieldInfoPtr_s_Single;

		// Token: 0x0400073B RID: 1851
		private static readonly IntPtr NativeFieldInfoPtr_s_Double;

		// Token: 0x0400073C RID: 1852
		private static readonly IntPtr NativeFieldInfoPtr_s_BooleanLiftedToNull;

		// Token: 0x0400073D RID: 1853
		private static readonly IntPtr NativeFieldInfoPtr_s_SByteLiftedToNull;

		// Token: 0x0400073E RID: 1854
		private static readonly IntPtr NativeFieldInfoPtr_s_Int16LiftedToNull;

		// Token: 0x0400073F RID: 1855
		private static readonly IntPtr NativeFieldInfoPtr_s_CharLiftedToNull;

		// Token: 0x04000740 RID: 1856
		private static readonly IntPtr NativeFieldInfoPtr_s_Int32LiftedToNull;

		// Token: 0x04000741 RID: 1857
		private static readonly IntPtr NativeFieldInfoPtr_s_Int64LiftedToNull;

		// Token: 0x04000742 RID: 1858
		private static readonly IntPtr NativeFieldInfoPtr_s_ByteLiftedToNull;

		// Token: 0x04000743 RID: 1859
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt16LiftedToNull;

		// Token: 0x04000744 RID: 1860
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt32LiftedToNull;

		// Token: 0x04000745 RID: 1861
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt64LiftedToNull;

		// Token: 0x04000746 RID: 1862
		private static readonly IntPtr NativeFieldInfoPtr_s_SingleLiftedToNull;

		// Token: 0x04000747 RID: 1863
		private static readonly IntPtr NativeFieldInfoPtr_s_DoubleLiftedToNull;

		// Token: 0x04000748 RID: 1864
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000749 RID: 1865
		private static readonly IntPtr NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0;

		// Token: 0x0400074A RID: 1866
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x0400074B RID: 1867
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x0400074C RID: 1868
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_Boolean_0;

		// Token: 0x0200020E RID: 526
		public sealed class EqualBoolean : EqualInstruction
		{
			// Token: 0x06001708 RID: 5896 RVA: 0x000700EC File Offset: 0x0006E2EC
			// Note: this type is marked as 'beforefieldinit'.
			static EqualBoolean()
			{
				Il2CppClassPointerStore<EqualInstruction.EqualBoolean>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, "EqualBoolean");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EqualInstruction.EqualBoolean>.NativeClassPtr);
				EqualInstruction.EqualBoolean.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction.EqualBoolean>.NativeClassPtr, 100665078);
				EqualInstruction.EqualBoolean.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction.EqualBoolean>.NativeClassPtr, 100665079);
			}

			// Token: 0x06001709 RID: 5897 RVA: 0x00070140 File Offset: 0x0006E340
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016404, XrefRangeEnd = 1016414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.EqualBoolean.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600170A RID: 5898 RVA: 0x00070190 File Offset: 0x0006E390
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EqualBoolean()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EqualInstruction.EqualBoolean>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.EqualBoolean.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600170B RID: 5899 RVA: 0x000099BE File Offset: 0x00007BBE
			public EqualBoolean(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001015 RID: 4117
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001016 RID: 4118
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200020F RID: 527
		public sealed class EqualSByte : EqualInstruction
		{
			// Token: 0x0600170C RID: 5900 RVA: 0x000701CC File Offset: 0x0006E3CC
			// Note: this type is marked as 'beforefieldinit'.
			static EqualSByte()
			{
				Il2CppClassPointerStore<EqualInstruction.EqualSByte>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, "EqualSByte");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EqualInstruction.EqualSByte>.NativeClassPtr);
				EqualInstruction.EqualSByte.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction.EqualSByte>.NativeClassPtr, 100665080);
				EqualInstruction.EqualSByte.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction.EqualSByte>.NativeClassPtr, 100665081);
			}

			// Token: 0x0600170D RID: 5901 RVA: 0x00070220 File Offset: 0x0006E420
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016414, XrefRangeEnd = 1016424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.EqualSByte.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600170E RID: 5902 RVA: 0x00070270 File Offset: 0x0006E470
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EqualSByte()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EqualInstruction.EqualSByte>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.EqualSByte.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600170F RID: 5903 RVA: 0x000099C7 File Offset: 0x00007BC7
			public EqualSByte(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001017 RID: 4119
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001018 RID: 4120
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000210 RID: 528
		public sealed class EqualInt16 : EqualInstruction
		{
			// Token: 0x06001710 RID: 5904 RVA: 0x000702AC File Offset: 0x0006E4AC
			// Note: this type is marked as 'beforefieldinit'.
			static EqualInt16()
			{
				Il2CppClassPointerStore<EqualInstruction.EqualInt16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, "EqualInt16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EqualInstruction.EqualInt16>.NativeClassPtr);
				EqualInstruction.EqualInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction.EqualInt16>.NativeClassPtr, 100665082);
				EqualInstruction.EqualInt16.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction.EqualInt16>.NativeClassPtr, 100665083);
			}

			// Token: 0x06001711 RID: 5905 RVA: 0x00070300 File Offset: 0x0006E500
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016424, XrefRangeEnd = 1016434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.EqualInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001712 RID: 5906 RVA: 0x00070350 File Offset: 0x0006E550
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EqualInt16()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EqualInstruction.EqualInt16>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.EqualInt16.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001713 RID: 5907 RVA: 0x000099D0 File Offset: 0x00007BD0
			public EqualInt16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001019 RID: 4121
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x0400101A RID: 4122
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000211 RID: 529
		public sealed class EqualChar : EqualInstruction
		{
			// Token: 0x06001714 RID: 5908 RVA: 0x0007038C File Offset: 0x0006E58C
			// Note: this type is marked as 'beforefieldinit'.
			static EqualChar()
			{
				Il2CppClassPointerStore<EqualInstruction.EqualChar>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, "EqualChar");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EqualInstruction.EqualChar>.NativeClassPtr);
				EqualInstruction.EqualChar.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction.EqualChar>.NativeClassPtr, 100665084);
				EqualInstruction.EqualChar.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction.EqualChar>.NativeClassPtr, 100665085);
			}

			// Token: 0x06001715 RID: 5909 RVA: 0x000703E0 File Offset: 0x0006E5E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016434, XrefRangeEnd = 1016444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.EqualChar.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001716 RID: 5910 RVA: 0x00070430 File Offset: 0x0006E630
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EqualChar()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EqualInstruction.EqualChar>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.EqualChar.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001717 RID: 5911 RVA: 0x000099D9 File Offset: 0x00007BD9
			public EqualChar(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400101B RID: 4123
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x0400101C RID: 4124
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000212 RID: 530
		public sealed class EqualInt32 : EqualInstruction
		{
			// Token: 0x06001718 RID: 5912 RVA: 0x0007046C File Offset: 0x0006E66C
			// Note: this type is marked as 'beforefieldinit'.
			static EqualInt32()
			{
				Il2CppClassPointerStore<EqualInstruction.EqualInt32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, "EqualInt32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EqualInstruction.EqualInt32>.NativeClassPtr);
				EqualInstruction.EqualInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction.EqualInt32>.NativeClassPtr, 100665086);
				EqualInstruction.EqualInt32.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction.EqualInt32>.NativeClassPtr, 100665087);
			}

			// Token: 0x06001719 RID: 5913 RVA: 0x000704C0 File Offset: 0x0006E6C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016444, XrefRangeEnd = 1016454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.EqualInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600171A RID: 5914 RVA: 0x00070510 File Offset: 0x0006E710
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EqualInt32()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EqualInstruction.EqualInt32>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.EqualInt32.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600171B RID: 5915 RVA: 0x000099E2 File Offset: 0x00007BE2
			public EqualInt32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400101D RID: 4125
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x0400101E RID: 4126
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000213 RID: 531
		public sealed class EqualInt64 : EqualInstruction
		{
			// Token: 0x0600171C RID: 5916 RVA: 0x0007054C File Offset: 0x0006E74C
			// Note: this type is marked as 'beforefieldinit'.
			static EqualInt64()
			{
				Il2CppClassPointerStore<EqualInstruction.EqualInt64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, "EqualInt64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EqualInstruction.EqualInt64>.NativeClassPtr);
				EqualInstruction.EqualInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction.EqualInt64>.NativeClassPtr, 100665088);
				EqualInstruction.EqualInt64.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction.EqualInt64>.NativeClassPtr, 100665089);
			}

			// Token: 0x0600171D RID: 5917 RVA: 0x000705A0 File Offset: 0x0006E7A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016454, XrefRangeEnd = 1016464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.EqualInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600171E RID: 5918 RVA: 0x000705F0 File Offset: 0x0006E7F0
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EqualInt64()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EqualInstruction.EqualInt64>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.EqualInt64.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600171F RID: 5919 RVA: 0x000099EB File Offset: 0x00007BEB
			public EqualInt64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400101F RID: 4127
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001020 RID: 4128
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000214 RID: 532
		public sealed class EqualByte : EqualInstruction
		{
			// Token: 0x06001720 RID: 5920 RVA: 0x0007062C File Offset: 0x0006E82C
			// Note: this type is marked as 'beforefieldinit'.
			static EqualByte()
			{
				Il2CppClassPointerStore<EqualInstruction.EqualByte>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, "EqualByte");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EqualInstruction.EqualByte>.NativeClassPtr);
				EqualInstruction.EqualByte.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction.EqualByte>.NativeClassPtr, 100665090);
				EqualInstruction.EqualByte.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction.EqualByte>.NativeClassPtr, 100665091);
			}

			// Token: 0x06001721 RID: 5921 RVA: 0x00070680 File Offset: 0x0006E880
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016464, XrefRangeEnd = 1016474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.EqualByte.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001722 RID: 5922 RVA: 0x000706D0 File Offset: 0x0006E8D0
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EqualByte()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EqualInstruction.EqualByte>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.EqualByte.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001723 RID: 5923 RVA: 0x000099F4 File Offset: 0x00007BF4
			public EqualByte(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001021 RID: 4129
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001022 RID: 4130
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000215 RID: 533
		public sealed class EqualUInt16 : EqualInstruction
		{
			// Token: 0x06001724 RID: 5924 RVA: 0x0007070C File Offset: 0x0006E90C
			// Note: this type is marked as 'beforefieldinit'.
			static EqualUInt16()
			{
				Il2CppClassPointerStore<EqualInstruction.EqualUInt16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, "EqualUInt16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EqualInstruction.EqualUInt16>.NativeClassPtr);
				EqualInstruction.EqualUInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction.EqualUInt16>.NativeClassPtr, 100665092);
				EqualInstruction.EqualUInt16.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction.EqualUInt16>.NativeClassPtr, 100665093);
			}

			// Token: 0x06001725 RID: 5925 RVA: 0x00070760 File Offset: 0x0006E960
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016474, XrefRangeEnd = 1016484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.EqualUInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001726 RID: 5926 RVA: 0x000707B0 File Offset: 0x0006E9B0
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EqualUInt16()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EqualInstruction.EqualUInt16>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.EqualUInt16.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001727 RID: 5927 RVA: 0x000099FD File Offset: 0x00007BFD
			public EqualUInt16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001023 RID: 4131
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001024 RID: 4132
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000216 RID: 534
		public sealed class EqualUInt32 : EqualInstruction
		{
			// Token: 0x06001728 RID: 5928 RVA: 0x000707EC File Offset: 0x0006E9EC
			// Note: this type is marked as 'beforefieldinit'.
			static EqualUInt32()
			{
				Il2CppClassPointerStore<EqualInstruction.EqualUInt32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, "EqualUInt32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EqualInstruction.EqualUInt32>.NativeClassPtr);
				EqualInstruction.EqualUInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction.EqualUInt32>.NativeClassPtr, 100665094);
				EqualInstruction.EqualUInt32.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction.EqualUInt32>.NativeClassPtr, 100665095);
			}

			// Token: 0x06001729 RID: 5929 RVA: 0x00070840 File Offset: 0x0006EA40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016484, XrefRangeEnd = 1016494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.EqualUInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600172A RID: 5930 RVA: 0x00070890 File Offset: 0x0006EA90
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EqualUInt32()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EqualInstruction.EqualUInt32>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.EqualUInt32.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600172B RID: 5931 RVA: 0x00009A06 File Offset: 0x00007C06
			public EqualUInt32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001025 RID: 4133
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001026 RID: 4134
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000217 RID: 535
		public sealed class EqualUInt64 : EqualInstruction
		{
			// Token: 0x0600172C RID: 5932 RVA: 0x000708CC File Offset: 0x0006EACC
			// Note: this type is marked as 'beforefieldinit'.
			static EqualUInt64()
			{
				Il2CppClassPointerStore<EqualInstruction.EqualUInt64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, "EqualUInt64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EqualInstruction.EqualUInt64>.NativeClassPtr);
				EqualInstruction.EqualUInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction.EqualUInt64>.NativeClassPtr, 100665096);
				EqualInstruction.EqualUInt64.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction.EqualUInt64>.NativeClassPtr, 100665097);
			}

			// Token: 0x0600172D RID: 5933 RVA: 0x00070920 File Offset: 0x0006EB20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016494, XrefRangeEnd = 1016504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.EqualUInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600172E RID: 5934 RVA: 0x00070970 File Offset: 0x0006EB70
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EqualUInt64()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EqualInstruction.EqualUInt64>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.EqualUInt64.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600172F RID: 5935 RVA: 0x00009A0F File Offset: 0x00007C0F
			public EqualUInt64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001027 RID: 4135
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001028 RID: 4136
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000218 RID: 536
		public sealed class EqualSingle : EqualInstruction
		{
			// Token: 0x06001730 RID: 5936 RVA: 0x000709AC File Offset: 0x0006EBAC
			// Note: this type is marked as 'beforefieldinit'.
			static EqualSingle()
			{
				Il2CppClassPointerStore<EqualInstruction.EqualSingle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, "EqualSingle");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EqualInstruction.EqualSingle>.NativeClassPtr);
				EqualInstruction.EqualSingle.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction.EqualSingle>.NativeClassPtr, 100665098);
				EqualInstruction.EqualSingle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction.EqualSingle>.NativeClassPtr, 100665099);
			}

			// Token: 0x06001731 RID: 5937 RVA: 0x00070A00 File Offset: 0x0006EC00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016504, XrefRangeEnd = 1016514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.EqualSingle.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001732 RID: 5938 RVA: 0x00070A50 File Offset: 0x0006EC50
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EqualSingle()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EqualInstruction.EqualSingle>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.EqualSingle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001733 RID: 5939 RVA: 0x00009A18 File Offset: 0x00007C18
			public EqualSingle(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001029 RID: 4137
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x0400102A RID: 4138
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000219 RID: 537
		public sealed class EqualDouble : EqualInstruction
		{
			// Token: 0x06001734 RID: 5940 RVA: 0x00070A8C File Offset: 0x0006EC8C
			// Note: this type is marked as 'beforefieldinit'.
			static EqualDouble()
			{
				Il2CppClassPointerStore<EqualInstruction.EqualDouble>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, "EqualDouble");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EqualInstruction.EqualDouble>.NativeClassPtr);
				EqualInstruction.EqualDouble.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction.EqualDouble>.NativeClassPtr, 100665100);
				EqualInstruction.EqualDouble.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction.EqualDouble>.NativeClassPtr, 100665101);
			}

			// Token: 0x06001735 RID: 5941 RVA: 0x00070AE0 File Offset: 0x0006ECE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016514, XrefRangeEnd = 1016524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.EqualDouble.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001736 RID: 5942 RVA: 0x00070B30 File Offset: 0x0006ED30
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EqualDouble()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EqualInstruction.EqualDouble>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.EqualDouble.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001737 RID: 5943 RVA: 0x00009A21 File Offset: 0x00007C21
			public EqualDouble(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400102B RID: 4139
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x0400102C RID: 4140
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200021A RID: 538
		public sealed class EqualReference : EqualInstruction
		{
			// Token: 0x06001738 RID: 5944 RVA: 0x00070B6C File Offset: 0x0006ED6C
			// Note: this type is marked as 'beforefieldinit'.
			static EqualReference()
			{
				Il2CppClassPointerStore<EqualInstruction.EqualReference>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, "EqualReference");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EqualInstruction.EqualReference>.NativeClassPtr);
				EqualInstruction.EqualReference.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction.EqualReference>.NativeClassPtr, 100665102);
				EqualInstruction.EqualReference.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction.EqualReference>.NativeClassPtr, 100665103);
			}

			// Token: 0x06001739 RID: 5945 RVA: 0x00070BC0 File Offset: 0x0006EDC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016524, XrefRangeEnd = 1016527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.EqualReference.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600173A RID: 5946 RVA: 0x00070C10 File Offset: 0x0006EE10
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EqualReference()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EqualInstruction.EqualReference>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.EqualReference.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600173B RID: 5947 RVA: 0x00009A2A File Offset: 0x00007C2A
			public EqualReference(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400102D RID: 4141
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x0400102E RID: 4142
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200021B RID: 539
		public sealed class EqualBooleanLiftedToNull : EqualInstruction
		{
			// Token: 0x0600173C RID: 5948 RVA: 0x00070C4C File Offset: 0x0006EE4C
			// Note: this type is marked as 'beforefieldinit'.
			static EqualBooleanLiftedToNull()
			{
				Il2CppClassPointerStore<EqualInstruction.EqualBooleanLiftedToNull>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, "EqualBooleanLiftedToNull");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EqualInstruction.EqualBooleanLiftedToNull>.NativeClassPtr);
				EqualInstruction.EqualBooleanLiftedToNull.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction.EqualBooleanLiftedToNull>.NativeClassPtr, 100665104);
				EqualInstruction.EqualBooleanLiftedToNull.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction.EqualBooleanLiftedToNull>.NativeClassPtr, 100665105);
			}

			// Token: 0x0600173D RID: 5949 RVA: 0x00070CA0 File Offset: 0x0006EEA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016527, XrefRangeEnd = 1016537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.EqualBooleanLiftedToNull.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600173E RID: 5950 RVA: 0x00070CF0 File Offset: 0x0006EEF0
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EqualBooleanLiftedToNull()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EqualInstruction.EqualBooleanLiftedToNull>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.EqualBooleanLiftedToNull.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600173F RID: 5951 RVA: 0x00009A33 File Offset: 0x00007C33
			public EqualBooleanLiftedToNull(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400102F RID: 4143
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001030 RID: 4144
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200021C RID: 540
		public sealed class EqualSByteLiftedToNull : EqualInstruction
		{
			// Token: 0x06001740 RID: 5952 RVA: 0x00070D2C File Offset: 0x0006EF2C
			// Note: this type is marked as 'beforefieldinit'.
			static EqualSByteLiftedToNull()
			{
				Il2CppClassPointerStore<EqualInstruction.EqualSByteLiftedToNull>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, "EqualSByteLiftedToNull");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EqualInstruction.EqualSByteLiftedToNull>.NativeClassPtr);
				EqualInstruction.EqualSByteLiftedToNull.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction.EqualSByteLiftedToNull>.NativeClassPtr, 100665106);
				EqualInstruction.EqualSByteLiftedToNull.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction.EqualSByteLiftedToNull>.NativeClassPtr, 100665107);
			}

			// Token: 0x06001741 RID: 5953 RVA: 0x00070D80 File Offset: 0x0006EF80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016537, XrefRangeEnd = 1016547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.EqualSByteLiftedToNull.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001742 RID: 5954 RVA: 0x00070DD0 File Offset: 0x0006EFD0
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EqualSByteLiftedToNull()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EqualInstruction.EqualSByteLiftedToNull>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.EqualSByteLiftedToNull.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001743 RID: 5955 RVA: 0x00009A3C File Offset: 0x00007C3C
			public EqualSByteLiftedToNull(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001031 RID: 4145
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001032 RID: 4146
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200021D RID: 541
		public sealed class EqualInt16LiftedToNull : EqualInstruction
		{
			// Token: 0x06001744 RID: 5956 RVA: 0x00070E0C File Offset: 0x0006F00C
			// Note: this type is marked as 'beforefieldinit'.
			static EqualInt16LiftedToNull()
			{
				Il2CppClassPointerStore<EqualInstruction.EqualInt16LiftedToNull>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, "EqualInt16LiftedToNull");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EqualInstruction.EqualInt16LiftedToNull>.NativeClassPtr);
				EqualInstruction.EqualInt16LiftedToNull.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction.EqualInt16LiftedToNull>.NativeClassPtr, 100665108);
				EqualInstruction.EqualInt16LiftedToNull.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction.EqualInt16LiftedToNull>.NativeClassPtr, 100665109);
			}

			// Token: 0x06001745 RID: 5957 RVA: 0x00070E60 File Offset: 0x0006F060
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016547, XrefRangeEnd = 1016557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.EqualInt16LiftedToNull.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001746 RID: 5958 RVA: 0x00070EB0 File Offset: 0x0006F0B0
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EqualInt16LiftedToNull()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EqualInstruction.EqualInt16LiftedToNull>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.EqualInt16LiftedToNull.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001747 RID: 5959 RVA: 0x00009A45 File Offset: 0x00007C45
			public EqualInt16LiftedToNull(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001033 RID: 4147
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001034 RID: 4148
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200021E RID: 542
		public sealed class EqualCharLiftedToNull : EqualInstruction
		{
			// Token: 0x06001748 RID: 5960 RVA: 0x00070EEC File Offset: 0x0006F0EC
			// Note: this type is marked as 'beforefieldinit'.
			static EqualCharLiftedToNull()
			{
				Il2CppClassPointerStore<EqualInstruction.EqualCharLiftedToNull>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, "EqualCharLiftedToNull");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EqualInstruction.EqualCharLiftedToNull>.NativeClassPtr);
				EqualInstruction.EqualCharLiftedToNull.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction.EqualCharLiftedToNull>.NativeClassPtr, 100665110);
				EqualInstruction.EqualCharLiftedToNull.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction.EqualCharLiftedToNull>.NativeClassPtr, 100665111);
			}

			// Token: 0x06001749 RID: 5961 RVA: 0x00070F40 File Offset: 0x0006F140
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016557, XrefRangeEnd = 1016567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.EqualCharLiftedToNull.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600174A RID: 5962 RVA: 0x00070F90 File Offset: 0x0006F190
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EqualCharLiftedToNull()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EqualInstruction.EqualCharLiftedToNull>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.EqualCharLiftedToNull.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600174B RID: 5963 RVA: 0x00009A4E File Offset: 0x00007C4E
			public EqualCharLiftedToNull(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001035 RID: 4149
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001036 RID: 4150
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200021F RID: 543
		public sealed class EqualInt32LiftedToNull : EqualInstruction
		{
			// Token: 0x0600174C RID: 5964 RVA: 0x00070FCC File Offset: 0x0006F1CC
			// Note: this type is marked as 'beforefieldinit'.
			static EqualInt32LiftedToNull()
			{
				Il2CppClassPointerStore<EqualInstruction.EqualInt32LiftedToNull>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, "EqualInt32LiftedToNull");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EqualInstruction.EqualInt32LiftedToNull>.NativeClassPtr);
				EqualInstruction.EqualInt32LiftedToNull.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction.EqualInt32LiftedToNull>.NativeClassPtr, 100665112);
				EqualInstruction.EqualInt32LiftedToNull.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction.EqualInt32LiftedToNull>.NativeClassPtr, 100665113);
			}

			// Token: 0x0600174D RID: 5965 RVA: 0x00071020 File Offset: 0x0006F220
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016567, XrefRangeEnd = 1016577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.EqualInt32LiftedToNull.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600174E RID: 5966 RVA: 0x00071070 File Offset: 0x0006F270
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EqualInt32LiftedToNull()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EqualInstruction.EqualInt32LiftedToNull>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.EqualInt32LiftedToNull.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600174F RID: 5967 RVA: 0x00009A57 File Offset: 0x00007C57
			public EqualInt32LiftedToNull(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001037 RID: 4151
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001038 RID: 4152
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000220 RID: 544
		public sealed class EqualInt64LiftedToNull : EqualInstruction
		{
			// Token: 0x06001750 RID: 5968 RVA: 0x000710AC File Offset: 0x0006F2AC
			// Note: this type is marked as 'beforefieldinit'.
			static EqualInt64LiftedToNull()
			{
				Il2CppClassPointerStore<EqualInstruction.EqualInt64LiftedToNull>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, "EqualInt64LiftedToNull");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EqualInstruction.EqualInt64LiftedToNull>.NativeClassPtr);
				EqualInstruction.EqualInt64LiftedToNull.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction.EqualInt64LiftedToNull>.NativeClassPtr, 100665114);
				EqualInstruction.EqualInt64LiftedToNull.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction.EqualInt64LiftedToNull>.NativeClassPtr, 100665115);
			}

			// Token: 0x06001751 RID: 5969 RVA: 0x00071100 File Offset: 0x0006F300
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016577, XrefRangeEnd = 1016587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.EqualInt64LiftedToNull.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001752 RID: 5970 RVA: 0x00071150 File Offset: 0x0006F350
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EqualInt64LiftedToNull()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EqualInstruction.EqualInt64LiftedToNull>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.EqualInt64LiftedToNull.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001753 RID: 5971 RVA: 0x00009A60 File Offset: 0x00007C60
			public EqualInt64LiftedToNull(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001039 RID: 4153
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x0400103A RID: 4154
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000221 RID: 545
		public sealed class EqualByteLiftedToNull : EqualInstruction
		{
			// Token: 0x06001754 RID: 5972 RVA: 0x0007118C File Offset: 0x0006F38C
			// Note: this type is marked as 'beforefieldinit'.
			static EqualByteLiftedToNull()
			{
				Il2CppClassPointerStore<EqualInstruction.EqualByteLiftedToNull>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, "EqualByteLiftedToNull");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EqualInstruction.EqualByteLiftedToNull>.NativeClassPtr);
				EqualInstruction.EqualByteLiftedToNull.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction.EqualByteLiftedToNull>.NativeClassPtr, 100665116);
				EqualInstruction.EqualByteLiftedToNull.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction.EqualByteLiftedToNull>.NativeClassPtr, 100665117);
			}

			// Token: 0x06001755 RID: 5973 RVA: 0x000711E0 File Offset: 0x0006F3E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016587, XrefRangeEnd = 1016597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.EqualByteLiftedToNull.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001756 RID: 5974 RVA: 0x00071230 File Offset: 0x0006F430
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EqualByteLiftedToNull()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EqualInstruction.EqualByteLiftedToNull>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.EqualByteLiftedToNull.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001757 RID: 5975 RVA: 0x00009A69 File Offset: 0x00007C69
			public EqualByteLiftedToNull(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400103B RID: 4155
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x0400103C RID: 4156
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000222 RID: 546
		public sealed class EqualUInt16LiftedToNull : EqualInstruction
		{
			// Token: 0x06001758 RID: 5976 RVA: 0x0007126C File Offset: 0x0006F46C
			// Note: this type is marked as 'beforefieldinit'.
			static EqualUInt16LiftedToNull()
			{
				Il2CppClassPointerStore<EqualInstruction.EqualUInt16LiftedToNull>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, "EqualUInt16LiftedToNull");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EqualInstruction.EqualUInt16LiftedToNull>.NativeClassPtr);
				EqualInstruction.EqualUInt16LiftedToNull.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction.EqualUInt16LiftedToNull>.NativeClassPtr, 100665118);
				EqualInstruction.EqualUInt16LiftedToNull.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction.EqualUInt16LiftedToNull>.NativeClassPtr, 100665119);
			}

			// Token: 0x06001759 RID: 5977 RVA: 0x000712C0 File Offset: 0x0006F4C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016597, XrefRangeEnd = 1016607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.EqualUInt16LiftedToNull.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600175A RID: 5978 RVA: 0x00071310 File Offset: 0x0006F510
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EqualUInt16LiftedToNull()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EqualInstruction.EqualUInt16LiftedToNull>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.EqualUInt16LiftedToNull.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600175B RID: 5979 RVA: 0x00009A72 File Offset: 0x00007C72
			public EqualUInt16LiftedToNull(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400103D RID: 4157
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x0400103E RID: 4158
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000223 RID: 547
		public sealed class EqualUInt32LiftedToNull : EqualInstruction
		{
			// Token: 0x0600175C RID: 5980 RVA: 0x0007134C File Offset: 0x0006F54C
			// Note: this type is marked as 'beforefieldinit'.
			static EqualUInt32LiftedToNull()
			{
				Il2CppClassPointerStore<EqualInstruction.EqualUInt32LiftedToNull>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, "EqualUInt32LiftedToNull");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EqualInstruction.EqualUInt32LiftedToNull>.NativeClassPtr);
				EqualInstruction.EqualUInt32LiftedToNull.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction.EqualUInt32LiftedToNull>.NativeClassPtr, 100665120);
				EqualInstruction.EqualUInt32LiftedToNull.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction.EqualUInt32LiftedToNull>.NativeClassPtr, 100665121);
			}

			// Token: 0x0600175D RID: 5981 RVA: 0x000713A0 File Offset: 0x0006F5A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016607, XrefRangeEnd = 1016617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.EqualUInt32LiftedToNull.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600175E RID: 5982 RVA: 0x000713F0 File Offset: 0x0006F5F0
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EqualUInt32LiftedToNull()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EqualInstruction.EqualUInt32LiftedToNull>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.EqualUInt32LiftedToNull.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600175F RID: 5983 RVA: 0x00009A7B File Offset: 0x00007C7B
			public EqualUInt32LiftedToNull(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400103F RID: 4159
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001040 RID: 4160
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000224 RID: 548
		public sealed class EqualUInt64LiftedToNull : EqualInstruction
		{
			// Token: 0x06001760 RID: 5984 RVA: 0x0007142C File Offset: 0x0006F62C
			// Note: this type is marked as 'beforefieldinit'.
			static EqualUInt64LiftedToNull()
			{
				Il2CppClassPointerStore<EqualInstruction.EqualUInt64LiftedToNull>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, "EqualUInt64LiftedToNull");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EqualInstruction.EqualUInt64LiftedToNull>.NativeClassPtr);
				EqualInstruction.EqualUInt64LiftedToNull.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction.EqualUInt64LiftedToNull>.NativeClassPtr, 100665122);
				EqualInstruction.EqualUInt64LiftedToNull.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction.EqualUInt64LiftedToNull>.NativeClassPtr, 100665123);
			}

			// Token: 0x06001761 RID: 5985 RVA: 0x00071480 File Offset: 0x0006F680
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016617, XrefRangeEnd = 1016627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.EqualUInt64LiftedToNull.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001762 RID: 5986 RVA: 0x000714D0 File Offset: 0x0006F6D0
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EqualUInt64LiftedToNull()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EqualInstruction.EqualUInt64LiftedToNull>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.EqualUInt64LiftedToNull.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001763 RID: 5987 RVA: 0x00009A84 File Offset: 0x00007C84
			public EqualUInt64LiftedToNull(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001041 RID: 4161
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001042 RID: 4162
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000225 RID: 549
		public sealed class EqualSingleLiftedToNull : EqualInstruction
		{
			// Token: 0x06001764 RID: 5988 RVA: 0x0007150C File Offset: 0x0006F70C
			// Note: this type is marked as 'beforefieldinit'.
			static EqualSingleLiftedToNull()
			{
				Il2CppClassPointerStore<EqualInstruction.EqualSingleLiftedToNull>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, "EqualSingleLiftedToNull");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EqualInstruction.EqualSingleLiftedToNull>.NativeClassPtr);
				EqualInstruction.EqualSingleLiftedToNull.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction.EqualSingleLiftedToNull>.NativeClassPtr, 100665124);
				EqualInstruction.EqualSingleLiftedToNull.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction.EqualSingleLiftedToNull>.NativeClassPtr, 100665125);
			}

			// Token: 0x06001765 RID: 5989 RVA: 0x00071560 File Offset: 0x0006F760
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016627, XrefRangeEnd = 1016639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.EqualSingleLiftedToNull.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001766 RID: 5990 RVA: 0x000715B0 File Offset: 0x0006F7B0
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EqualSingleLiftedToNull()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EqualInstruction.EqualSingleLiftedToNull>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.EqualSingleLiftedToNull.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001767 RID: 5991 RVA: 0x00009A8D File Offset: 0x00007C8D
			public EqualSingleLiftedToNull(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001043 RID: 4163
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001044 RID: 4164
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000226 RID: 550
		public sealed class EqualDoubleLiftedToNull : EqualInstruction
		{
			// Token: 0x06001768 RID: 5992 RVA: 0x000715EC File Offset: 0x0006F7EC
			// Note: this type is marked as 'beforefieldinit'.
			static EqualDoubleLiftedToNull()
			{
				Il2CppClassPointerStore<EqualInstruction.EqualDoubleLiftedToNull>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EqualInstruction>.NativeClassPtr, "EqualDoubleLiftedToNull");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EqualInstruction.EqualDoubleLiftedToNull>.NativeClassPtr);
				EqualInstruction.EqualDoubleLiftedToNull.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction.EqualDoubleLiftedToNull>.NativeClassPtr, 100665126);
				EqualInstruction.EqualDoubleLiftedToNull.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualInstruction.EqualDoubleLiftedToNull>.NativeClassPtr, 100665127);
			}

			// Token: 0x06001769 RID: 5993 RVA: 0x00071640 File Offset: 0x0006F840
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016639, XrefRangeEnd = 1016651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.EqualDoubleLiftedToNull.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600176A RID: 5994 RVA: 0x00071690 File Offset: 0x0006F890
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EqualDoubleLiftedToNull()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EqualInstruction.EqualDoubleLiftedToNull>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualInstruction.EqualDoubleLiftedToNull.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600176B RID: 5995 RVA: 0x00009A96 File Offset: 0x00007C96
			public EqualDoubleLiftedToNull(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001045 RID: 4165
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001046 RID: 4166
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
