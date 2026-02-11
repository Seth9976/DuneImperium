using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000C5 RID: 197
	public class LessThanInstruction : Instruction
	{
		// Token: 0x06000BAF RID: 2991 RVA: 0x00040EB4 File Offset: 0x0003F0B4
		// Note: this type is marked as 'beforefieldinit'.
		static LessThanInstruction()
		{
			Il2CppClassPointerStore<LessThanInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "LessThanInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LessThanInstruction>.NativeClassPtr);
			LessThanInstruction.NativeFieldInfoPtr__nullValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LessThanInstruction>.NativeClassPtr, "_nullValue");
			LessThanInstruction.NativeFieldInfoPtr_s_SByte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LessThanInstruction>.NativeClassPtr, "s_SByte");
			LessThanInstruction.NativeFieldInfoPtr_s_Int16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LessThanInstruction>.NativeClassPtr, "s_Int16");
			LessThanInstruction.NativeFieldInfoPtr_s_Char = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LessThanInstruction>.NativeClassPtr, "s_Char");
			LessThanInstruction.NativeFieldInfoPtr_s_Int32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LessThanInstruction>.NativeClassPtr, "s_Int32");
			LessThanInstruction.NativeFieldInfoPtr_s_Int64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LessThanInstruction>.NativeClassPtr, "s_Int64");
			LessThanInstruction.NativeFieldInfoPtr_s_Byte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LessThanInstruction>.NativeClassPtr, "s_Byte");
			LessThanInstruction.NativeFieldInfoPtr_s_UInt16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LessThanInstruction>.NativeClassPtr, "s_UInt16");
			LessThanInstruction.NativeFieldInfoPtr_s_UInt32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LessThanInstruction>.NativeClassPtr, "s_UInt32");
			LessThanInstruction.NativeFieldInfoPtr_s_UInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LessThanInstruction>.NativeClassPtr, "s_UInt64");
			LessThanInstruction.NativeFieldInfoPtr_s_Single = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LessThanInstruction>.NativeClassPtr, "s_Single");
			LessThanInstruction.NativeFieldInfoPtr_s_Double = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LessThanInstruction>.NativeClassPtr, "s_Double");
			LessThanInstruction.NativeFieldInfoPtr_s_liftedToNullSByte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LessThanInstruction>.NativeClassPtr, "s_liftedToNullSByte");
			LessThanInstruction.NativeFieldInfoPtr_s_liftedToNullInt16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LessThanInstruction>.NativeClassPtr, "s_liftedToNullInt16");
			LessThanInstruction.NativeFieldInfoPtr_s_liftedToNullChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LessThanInstruction>.NativeClassPtr, "s_liftedToNullChar");
			LessThanInstruction.NativeFieldInfoPtr_s_liftedToNullInt32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LessThanInstruction>.NativeClassPtr, "s_liftedToNullInt32");
			LessThanInstruction.NativeFieldInfoPtr_s_liftedToNullInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LessThanInstruction>.NativeClassPtr, "s_liftedToNullInt64");
			LessThanInstruction.NativeFieldInfoPtr_s_liftedToNullByte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LessThanInstruction>.NativeClassPtr, "s_liftedToNullByte");
			LessThanInstruction.NativeFieldInfoPtr_s_liftedToNullUInt16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LessThanInstruction>.NativeClassPtr, "s_liftedToNullUInt16");
			LessThanInstruction.NativeFieldInfoPtr_s_liftedToNullUInt32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LessThanInstruction>.NativeClassPtr, "s_liftedToNullUInt32");
			LessThanInstruction.NativeFieldInfoPtr_s_liftedToNullUInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LessThanInstruction>.NativeClassPtr, "s_liftedToNullUInt64");
			LessThanInstruction.NativeFieldInfoPtr_s_liftedToNullSingle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LessThanInstruction>.NativeClassPtr, "s_liftedToNullSingle");
			LessThanInstruction.NativeFieldInfoPtr_s_liftedToNullDouble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LessThanInstruction>.NativeClassPtr, "s_liftedToNullDouble");
			LessThanInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanInstruction>.NativeClassPtr, 100665463);
			LessThanInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanInstruction>.NativeClassPtr, 100665464);
			LessThanInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanInstruction>.NativeClassPtr, 100665465);
			LessThanInstruction.NativeMethodInfoPtr__ctor_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanInstruction>.NativeClassPtr, 100665466);
			LessThanInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanInstruction>.NativeClassPtr, 100665467);
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000BB0 RID: 2992 RVA: 0x00041114 File Offset: 0x0003F314
		public unsafe override int ConsumedStack
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 72978, RefRangeEnd = 72985, XrefRangeStart = 72978, XrefRangeEnd = 72985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LessThanInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000BB1 RID: 2993 RVA: 0x0004115C File Offset: 0x0003F35C
		public unsafe override int ProducedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LessThanInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000BB2 RID: 2994 RVA: 0x000411A4 File Offset: 0x0003F3A4
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019811, XrefRangeEnd = 1019813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LessThanInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x000411E8 File Offset: 0x0003F3E8
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LessThanInstruction(Object nullValue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LessThanInstruction>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullValue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LessThanInstruction.NativeMethodInfoPtr__ctor_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BB4 RID: 2996 RVA: 0x00041234 File Offset: 0x0003F434
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1019845, RefRangeEnd = 1019847, XrefRangeStart = 1019813, XrefRangeEnd = 1019845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LessThanInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x00005698 File Offset: 0x00003898
		public LessThanInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000BB6 RID: 2998 RVA: 0x00041288 File Offset: 0x0003F488
		// (set) Token: 0x06000BB7 RID: 2999 RVA: 0x000056A1 File Offset: 0x000038A1
		public unsafe Object _nullValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LessThanInstruction.NativeFieldInfoPtr__nullValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LessThanInstruction.NativeFieldInfoPtr__nullValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000BB8 RID: 3000 RVA: 0x000412B8 File Offset: 0x0003F4B8
		// (set) Token: 0x06000BB9 RID: 3001 RVA: 0x000056C0 File Offset: 0x000038C0
		public unsafe static Instruction s_SByte
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LessThanInstruction.NativeFieldInfoPtr_s_SByte, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LessThanInstruction.NativeFieldInfoPtr_s_SByte, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000BBA RID: 3002 RVA: 0x000412E0 File Offset: 0x0003F4E0
		// (set) Token: 0x06000BBB RID: 3003 RVA: 0x000056D2 File Offset: 0x000038D2
		public unsafe static Instruction s_Int16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LessThanInstruction.NativeFieldInfoPtr_s_Int16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LessThanInstruction.NativeFieldInfoPtr_s_Int16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000BBC RID: 3004 RVA: 0x00041308 File Offset: 0x0003F508
		// (set) Token: 0x06000BBD RID: 3005 RVA: 0x000056E4 File Offset: 0x000038E4
		public unsafe static Instruction s_Char
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LessThanInstruction.NativeFieldInfoPtr_s_Char, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LessThanInstruction.NativeFieldInfoPtr_s_Char, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000BBE RID: 3006 RVA: 0x00041330 File Offset: 0x0003F530
		// (set) Token: 0x06000BBF RID: 3007 RVA: 0x000056F6 File Offset: 0x000038F6
		public unsafe static Instruction s_Int32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LessThanInstruction.NativeFieldInfoPtr_s_Int32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LessThanInstruction.NativeFieldInfoPtr_s_Int32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000BC0 RID: 3008 RVA: 0x00041358 File Offset: 0x0003F558
		// (set) Token: 0x06000BC1 RID: 3009 RVA: 0x00005708 File Offset: 0x00003908
		public unsafe static Instruction s_Int64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LessThanInstruction.NativeFieldInfoPtr_s_Int64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LessThanInstruction.NativeFieldInfoPtr_s_Int64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000BC2 RID: 3010 RVA: 0x00041380 File Offset: 0x0003F580
		// (set) Token: 0x06000BC3 RID: 3011 RVA: 0x0000571A File Offset: 0x0000391A
		public unsafe static Instruction s_Byte
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LessThanInstruction.NativeFieldInfoPtr_s_Byte, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LessThanInstruction.NativeFieldInfoPtr_s_Byte, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000BC4 RID: 3012 RVA: 0x000413A8 File Offset: 0x0003F5A8
		// (set) Token: 0x06000BC5 RID: 3013 RVA: 0x0000572C File Offset: 0x0000392C
		public unsafe static Instruction s_UInt16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LessThanInstruction.NativeFieldInfoPtr_s_UInt16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LessThanInstruction.NativeFieldInfoPtr_s_UInt16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000BC6 RID: 3014 RVA: 0x000413D0 File Offset: 0x0003F5D0
		// (set) Token: 0x06000BC7 RID: 3015 RVA: 0x0000573E File Offset: 0x0000393E
		public unsafe static Instruction s_UInt32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LessThanInstruction.NativeFieldInfoPtr_s_UInt32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LessThanInstruction.NativeFieldInfoPtr_s_UInt32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000BC8 RID: 3016 RVA: 0x000413F8 File Offset: 0x0003F5F8
		// (set) Token: 0x06000BC9 RID: 3017 RVA: 0x00005750 File Offset: 0x00003950
		public unsafe static Instruction s_UInt64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LessThanInstruction.NativeFieldInfoPtr_s_UInt64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LessThanInstruction.NativeFieldInfoPtr_s_UInt64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000BCA RID: 3018 RVA: 0x00041420 File Offset: 0x0003F620
		// (set) Token: 0x06000BCB RID: 3019 RVA: 0x00005762 File Offset: 0x00003962
		public unsafe static Instruction s_Single
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LessThanInstruction.NativeFieldInfoPtr_s_Single, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LessThanInstruction.NativeFieldInfoPtr_s_Single, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000BCC RID: 3020 RVA: 0x00041448 File Offset: 0x0003F648
		// (set) Token: 0x06000BCD RID: 3021 RVA: 0x00005774 File Offset: 0x00003974
		public unsafe static Instruction s_Double
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LessThanInstruction.NativeFieldInfoPtr_s_Double, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LessThanInstruction.NativeFieldInfoPtr_s_Double, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000BCE RID: 3022 RVA: 0x00041470 File Offset: 0x0003F670
		// (set) Token: 0x06000BCF RID: 3023 RVA: 0x00005786 File Offset: 0x00003986
		public unsafe static Instruction s_liftedToNullSByte
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LessThanInstruction.NativeFieldInfoPtr_s_liftedToNullSByte, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LessThanInstruction.NativeFieldInfoPtr_s_liftedToNullSByte, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06000BD0 RID: 3024 RVA: 0x00041498 File Offset: 0x0003F698
		// (set) Token: 0x06000BD1 RID: 3025 RVA: 0x00005798 File Offset: 0x00003998
		public unsafe static Instruction s_liftedToNullInt16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LessThanInstruction.NativeFieldInfoPtr_s_liftedToNullInt16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LessThanInstruction.NativeFieldInfoPtr_s_liftedToNullInt16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000BD2 RID: 3026 RVA: 0x000414C0 File Offset: 0x0003F6C0
		// (set) Token: 0x06000BD3 RID: 3027 RVA: 0x000057AA File Offset: 0x000039AA
		public unsafe static Instruction s_liftedToNullChar
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LessThanInstruction.NativeFieldInfoPtr_s_liftedToNullChar, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LessThanInstruction.NativeFieldInfoPtr_s_liftedToNullChar, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000BD4 RID: 3028 RVA: 0x000414E8 File Offset: 0x0003F6E8
		// (set) Token: 0x06000BD5 RID: 3029 RVA: 0x000057BC File Offset: 0x000039BC
		public unsafe static Instruction s_liftedToNullInt32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LessThanInstruction.NativeFieldInfoPtr_s_liftedToNullInt32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LessThanInstruction.NativeFieldInfoPtr_s_liftedToNullInt32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000BD6 RID: 3030 RVA: 0x00041510 File Offset: 0x0003F710
		// (set) Token: 0x06000BD7 RID: 3031 RVA: 0x000057CE File Offset: 0x000039CE
		public unsafe static Instruction s_liftedToNullInt64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LessThanInstruction.NativeFieldInfoPtr_s_liftedToNullInt64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LessThanInstruction.NativeFieldInfoPtr_s_liftedToNullInt64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000BD8 RID: 3032 RVA: 0x00041538 File Offset: 0x0003F738
		// (set) Token: 0x06000BD9 RID: 3033 RVA: 0x000057E0 File Offset: 0x000039E0
		public unsafe static Instruction s_liftedToNullByte
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LessThanInstruction.NativeFieldInfoPtr_s_liftedToNullByte, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LessThanInstruction.NativeFieldInfoPtr_s_liftedToNullByte, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000BDA RID: 3034 RVA: 0x00041560 File Offset: 0x0003F760
		// (set) Token: 0x06000BDB RID: 3035 RVA: 0x000057F2 File Offset: 0x000039F2
		public unsafe static Instruction s_liftedToNullUInt16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LessThanInstruction.NativeFieldInfoPtr_s_liftedToNullUInt16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LessThanInstruction.NativeFieldInfoPtr_s_liftedToNullUInt16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000BDC RID: 3036 RVA: 0x00041588 File Offset: 0x0003F788
		// (set) Token: 0x06000BDD RID: 3037 RVA: 0x00005804 File Offset: 0x00003A04
		public unsafe static Instruction s_liftedToNullUInt32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LessThanInstruction.NativeFieldInfoPtr_s_liftedToNullUInt32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LessThanInstruction.NativeFieldInfoPtr_s_liftedToNullUInt32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000BDE RID: 3038 RVA: 0x000415B0 File Offset: 0x0003F7B0
		// (set) Token: 0x06000BDF RID: 3039 RVA: 0x00005816 File Offset: 0x00003A16
		public unsafe static Instruction s_liftedToNullUInt64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LessThanInstruction.NativeFieldInfoPtr_s_liftedToNullUInt64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LessThanInstruction.NativeFieldInfoPtr_s_liftedToNullUInt64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06000BE0 RID: 3040 RVA: 0x000415D8 File Offset: 0x0003F7D8
		// (set) Token: 0x06000BE1 RID: 3041 RVA: 0x00005828 File Offset: 0x00003A28
		public unsafe static Instruction s_liftedToNullSingle
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LessThanInstruction.NativeFieldInfoPtr_s_liftedToNullSingle, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LessThanInstruction.NativeFieldInfoPtr_s_liftedToNullSingle, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06000BE2 RID: 3042 RVA: 0x00041600 File Offset: 0x0003F800
		// (set) Token: 0x06000BE3 RID: 3043 RVA: 0x0000583A File Offset: 0x00003A3A
		public unsafe static Instruction s_liftedToNullDouble
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LessThanInstruction.NativeFieldInfoPtr_s_liftedToNullDouble, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LessThanInstruction.NativeFieldInfoPtr_s_liftedToNullDouble, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008B7 RID: 2231
		private static readonly IntPtr NativeFieldInfoPtr__nullValue;

		// Token: 0x040008B8 RID: 2232
		private static readonly IntPtr NativeFieldInfoPtr_s_SByte;

		// Token: 0x040008B9 RID: 2233
		private static readonly IntPtr NativeFieldInfoPtr_s_Int16;

		// Token: 0x040008BA RID: 2234
		private static readonly IntPtr NativeFieldInfoPtr_s_Char;

		// Token: 0x040008BB RID: 2235
		private static readonly IntPtr NativeFieldInfoPtr_s_Int32;

		// Token: 0x040008BC RID: 2236
		private static readonly IntPtr NativeFieldInfoPtr_s_Int64;

		// Token: 0x040008BD RID: 2237
		private static readonly IntPtr NativeFieldInfoPtr_s_Byte;

		// Token: 0x040008BE RID: 2238
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt16;

		// Token: 0x040008BF RID: 2239
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt32;

		// Token: 0x040008C0 RID: 2240
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt64;

		// Token: 0x040008C1 RID: 2241
		private static readonly IntPtr NativeFieldInfoPtr_s_Single;

		// Token: 0x040008C2 RID: 2242
		private static readonly IntPtr NativeFieldInfoPtr_s_Double;

		// Token: 0x040008C3 RID: 2243
		private static readonly IntPtr NativeFieldInfoPtr_s_liftedToNullSByte;

		// Token: 0x040008C4 RID: 2244
		private static readonly IntPtr NativeFieldInfoPtr_s_liftedToNullInt16;

		// Token: 0x040008C5 RID: 2245
		private static readonly IntPtr NativeFieldInfoPtr_s_liftedToNullChar;

		// Token: 0x040008C6 RID: 2246
		private static readonly IntPtr NativeFieldInfoPtr_s_liftedToNullInt32;

		// Token: 0x040008C7 RID: 2247
		private static readonly IntPtr NativeFieldInfoPtr_s_liftedToNullInt64;

		// Token: 0x040008C8 RID: 2248
		private static readonly IntPtr NativeFieldInfoPtr_s_liftedToNullByte;

		// Token: 0x040008C9 RID: 2249
		private static readonly IntPtr NativeFieldInfoPtr_s_liftedToNullUInt16;

		// Token: 0x040008CA RID: 2250
		private static readonly IntPtr NativeFieldInfoPtr_s_liftedToNullUInt32;

		// Token: 0x040008CB RID: 2251
		private static readonly IntPtr NativeFieldInfoPtr_s_liftedToNullUInt64;

		// Token: 0x040008CC RID: 2252
		private static readonly IntPtr NativeFieldInfoPtr_s_liftedToNullSingle;

		// Token: 0x040008CD RID: 2253
		private static readonly IntPtr NativeFieldInfoPtr_s_liftedToNullDouble;

		// Token: 0x040008CE RID: 2254
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0;

		// Token: 0x040008CF RID: 2255
		private static readonly IntPtr NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0;

		// Token: 0x040008D0 RID: 2256
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x040008D1 RID: 2257
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Object_0;

		// Token: 0x040008D2 RID: 2258
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_Boolean_0;

		// Token: 0x0200025C RID: 604
		public sealed class LessThanSByte : LessThanInstruction
		{
			// Token: 0x06001850 RID: 6224 RVA: 0x00074950 File Offset: 0x00072B50
			// Note: this type is marked as 'beforefieldinit'.
			static LessThanSByte()
			{
				Il2CppClassPointerStore<LessThanInstruction.LessThanSByte>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LessThanInstruction>.NativeClassPtr, "LessThanSByte");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LessThanInstruction.LessThanSByte>.NativeClassPtr);
				LessThanInstruction.LessThanSByte.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanInstruction.LessThanSByte>.NativeClassPtr, 100665468);
				LessThanInstruction.LessThanSByte.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanInstruction.LessThanSByte>.NativeClassPtr, 100665469);
			}

			// Token: 0x06001851 RID: 6225 RVA: 0x000749A4 File Offset: 0x00072BA4
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LessThanSByte(Object nullValue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LessThanInstruction.LessThanSByte>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullValue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LessThanInstruction.LessThanSByte.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001852 RID: 6226 RVA: 0x000749F0 File Offset: 0x00072BF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019712, XrefRangeEnd = 1019721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LessThanInstruction.LessThanSByte.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001853 RID: 6227 RVA: 0x00009D92 File Offset: 0x00007F92
			public LessThanSByte(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040010BD RID: 4285
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

			// Token: 0x040010BE RID: 4286
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
		}

		// Token: 0x0200025D RID: 605
		public sealed class LessThanInt16 : LessThanInstruction
		{
			// Token: 0x06001854 RID: 6228 RVA: 0x00074A40 File Offset: 0x00072C40
			// Note: this type is marked as 'beforefieldinit'.
			static LessThanInt16()
			{
				Il2CppClassPointerStore<LessThanInstruction.LessThanInt16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LessThanInstruction>.NativeClassPtr, "LessThanInt16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LessThanInstruction.LessThanInt16>.NativeClassPtr);
				LessThanInstruction.LessThanInt16.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanInstruction.LessThanInt16>.NativeClassPtr, 100665470);
				LessThanInstruction.LessThanInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanInstruction.LessThanInt16>.NativeClassPtr, 100665471);
			}

			// Token: 0x06001855 RID: 6229 RVA: 0x00074A94 File Offset: 0x00072C94
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LessThanInt16(Object nullValue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LessThanInstruction.LessThanInt16>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullValue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LessThanInstruction.LessThanInt16.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001856 RID: 6230 RVA: 0x00074AE0 File Offset: 0x00072CE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019721, XrefRangeEnd = 1019730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LessThanInstruction.LessThanInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001857 RID: 6231 RVA: 0x00009D9B File Offset: 0x00007F9B
			public LessThanInt16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040010BF RID: 4287
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

			// Token: 0x040010C0 RID: 4288
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
		}

		// Token: 0x0200025E RID: 606
		public sealed class LessThanChar : LessThanInstruction
		{
			// Token: 0x06001858 RID: 6232 RVA: 0x00074B30 File Offset: 0x00072D30
			// Note: this type is marked as 'beforefieldinit'.
			static LessThanChar()
			{
				Il2CppClassPointerStore<LessThanInstruction.LessThanChar>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LessThanInstruction>.NativeClassPtr, "LessThanChar");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LessThanInstruction.LessThanChar>.NativeClassPtr);
				LessThanInstruction.LessThanChar.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanInstruction.LessThanChar>.NativeClassPtr, 100665472);
				LessThanInstruction.LessThanChar.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanInstruction.LessThanChar>.NativeClassPtr, 100665473);
			}

			// Token: 0x06001859 RID: 6233 RVA: 0x00074B84 File Offset: 0x00072D84
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LessThanChar(Object nullValue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LessThanInstruction.LessThanChar>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullValue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LessThanInstruction.LessThanChar.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600185A RID: 6234 RVA: 0x00074BD0 File Offset: 0x00072DD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019730, XrefRangeEnd = 1019739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LessThanInstruction.LessThanChar.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600185B RID: 6235 RVA: 0x00009DA4 File Offset: 0x00007FA4
			public LessThanChar(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040010C1 RID: 4289
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

			// Token: 0x040010C2 RID: 4290
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
		}

		// Token: 0x0200025F RID: 607
		public sealed class LessThanInt32 : LessThanInstruction
		{
			// Token: 0x0600185C RID: 6236 RVA: 0x00074C20 File Offset: 0x00072E20
			// Note: this type is marked as 'beforefieldinit'.
			static LessThanInt32()
			{
				Il2CppClassPointerStore<LessThanInstruction.LessThanInt32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LessThanInstruction>.NativeClassPtr, "LessThanInt32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LessThanInstruction.LessThanInt32>.NativeClassPtr);
				LessThanInstruction.LessThanInt32.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanInstruction.LessThanInt32>.NativeClassPtr, 100665474);
				LessThanInstruction.LessThanInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanInstruction.LessThanInt32>.NativeClassPtr, 100665475);
			}

			// Token: 0x0600185D RID: 6237 RVA: 0x00074C74 File Offset: 0x00072E74
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LessThanInt32(Object nullValue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LessThanInstruction.LessThanInt32>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullValue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LessThanInstruction.LessThanInt32.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600185E RID: 6238 RVA: 0x00074CC0 File Offset: 0x00072EC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019739, XrefRangeEnd = 1019748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LessThanInstruction.LessThanInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600185F RID: 6239 RVA: 0x00009DAD File Offset: 0x00007FAD
			public LessThanInt32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040010C3 RID: 4291
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

			// Token: 0x040010C4 RID: 4292
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
		}

		// Token: 0x02000260 RID: 608
		public sealed class LessThanInt64 : LessThanInstruction
		{
			// Token: 0x06001860 RID: 6240 RVA: 0x00074D10 File Offset: 0x00072F10
			// Note: this type is marked as 'beforefieldinit'.
			static LessThanInt64()
			{
				Il2CppClassPointerStore<LessThanInstruction.LessThanInt64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LessThanInstruction>.NativeClassPtr, "LessThanInt64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LessThanInstruction.LessThanInt64>.NativeClassPtr);
				LessThanInstruction.LessThanInt64.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanInstruction.LessThanInt64>.NativeClassPtr, 100665476);
				LessThanInstruction.LessThanInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanInstruction.LessThanInt64>.NativeClassPtr, 100665477);
			}

			// Token: 0x06001861 RID: 6241 RVA: 0x00074D64 File Offset: 0x00072F64
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LessThanInt64(Object nullValue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LessThanInstruction.LessThanInt64>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullValue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LessThanInstruction.LessThanInt64.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001862 RID: 6242 RVA: 0x00074DB0 File Offset: 0x00072FB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019748, XrefRangeEnd = 1019757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LessThanInstruction.LessThanInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001863 RID: 6243 RVA: 0x00009DB6 File Offset: 0x00007FB6
			public LessThanInt64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040010C5 RID: 4293
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

			// Token: 0x040010C6 RID: 4294
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
		}

		// Token: 0x02000261 RID: 609
		public sealed class LessThanByte : LessThanInstruction
		{
			// Token: 0x06001864 RID: 6244 RVA: 0x00074E00 File Offset: 0x00073000
			// Note: this type is marked as 'beforefieldinit'.
			static LessThanByte()
			{
				Il2CppClassPointerStore<LessThanInstruction.LessThanByte>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LessThanInstruction>.NativeClassPtr, "LessThanByte");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LessThanInstruction.LessThanByte>.NativeClassPtr);
				LessThanInstruction.LessThanByte.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanInstruction.LessThanByte>.NativeClassPtr, 100665478);
				LessThanInstruction.LessThanByte.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanInstruction.LessThanByte>.NativeClassPtr, 100665479);
			}

			// Token: 0x06001865 RID: 6245 RVA: 0x00074E54 File Offset: 0x00073054
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LessThanByte(Object nullValue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LessThanInstruction.LessThanByte>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullValue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LessThanInstruction.LessThanByte.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001866 RID: 6246 RVA: 0x00074EA0 File Offset: 0x000730A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019757, XrefRangeEnd = 1019766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LessThanInstruction.LessThanByte.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001867 RID: 6247 RVA: 0x00009DBF File Offset: 0x00007FBF
			public LessThanByte(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040010C7 RID: 4295
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

			// Token: 0x040010C8 RID: 4296
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
		}

		// Token: 0x02000262 RID: 610
		public sealed class LessThanUInt16 : LessThanInstruction
		{
			// Token: 0x06001868 RID: 6248 RVA: 0x00074EF0 File Offset: 0x000730F0
			// Note: this type is marked as 'beforefieldinit'.
			static LessThanUInt16()
			{
				Il2CppClassPointerStore<LessThanInstruction.LessThanUInt16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LessThanInstruction>.NativeClassPtr, "LessThanUInt16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LessThanInstruction.LessThanUInt16>.NativeClassPtr);
				LessThanInstruction.LessThanUInt16.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanInstruction.LessThanUInt16>.NativeClassPtr, 100665480);
				LessThanInstruction.LessThanUInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanInstruction.LessThanUInt16>.NativeClassPtr, 100665481);
			}

			// Token: 0x06001869 RID: 6249 RVA: 0x00074F44 File Offset: 0x00073144
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LessThanUInt16(Object nullValue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LessThanInstruction.LessThanUInt16>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullValue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LessThanInstruction.LessThanUInt16.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600186A RID: 6250 RVA: 0x00074F90 File Offset: 0x00073190
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019766, XrefRangeEnd = 1019775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LessThanInstruction.LessThanUInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600186B RID: 6251 RVA: 0x00009DC8 File Offset: 0x00007FC8
			public LessThanUInt16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040010C9 RID: 4297
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

			// Token: 0x040010CA RID: 4298
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
		}

		// Token: 0x02000263 RID: 611
		public sealed class LessThanUInt32 : LessThanInstruction
		{
			// Token: 0x0600186C RID: 6252 RVA: 0x00074FE0 File Offset: 0x000731E0
			// Note: this type is marked as 'beforefieldinit'.
			static LessThanUInt32()
			{
				Il2CppClassPointerStore<LessThanInstruction.LessThanUInt32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LessThanInstruction>.NativeClassPtr, "LessThanUInt32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LessThanInstruction.LessThanUInt32>.NativeClassPtr);
				LessThanInstruction.LessThanUInt32.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanInstruction.LessThanUInt32>.NativeClassPtr, 100665482);
				LessThanInstruction.LessThanUInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanInstruction.LessThanUInt32>.NativeClassPtr, 100665483);
			}

			// Token: 0x0600186D RID: 6253 RVA: 0x00075034 File Offset: 0x00073234
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LessThanUInt32(Object nullValue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LessThanInstruction.LessThanUInt32>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullValue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LessThanInstruction.LessThanUInt32.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600186E RID: 6254 RVA: 0x00075080 File Offset: 0x00073280
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019775, XrefRangeEnd = 1019784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LessThanInstruction.LessThanUInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600186F RID: 6255 RVA: 0x00009DD1 File Offset: 0x00007FD1
			public LessThanUInt32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040010CB RID: 4299
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

			// Token: 0x040010CC RID: 4300
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
		}

		// Token: 0x02000264 RID: 612
		public sealed class LessThanUInt64 : LessThanInstruction
		{
			// Token: 0x06001870 RID: 6256 RVA: 0x000750D0 File Offset: 0x000732D0
			// Note: this type is marked as 'beforefieldinit'.
			static LessThanUInt64()
			{
				Il2CppClassPointerStore<LessThanInstruction.LessThanUInt64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LessThanInstruction>.NativeClassPtr, "LessThanUInt64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LessThanInstruction.LessThanUInt64>.NativeClassPtr);
				LessThanInstruction.LessThanUInt64.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanInstruction.LessThanUInt64>.NativeClassPtr, 100665484);
				LessThanInstruction.LessThanUInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanInstruction.LessThanUInt64>.NativeClassPtr, 100665485);
			}

			// Token: 0x06001871 RID: 6257 RVA: 0x00075124 File Offset: 0x00073324
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LessThanUInt64(Object nullValue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LessThanInstruction.LessThanUInt64>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullValue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LessThanInstruction.LessThanUInt64.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001872 RID: 6258 RVA: 0x00075170 File Offset: 0x00073370
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019784, XrefRangeEnd = 1019793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LessThanInstruction.LessThanUInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001873 RID: 6259 RVA: 0x00009DDA File Offset: 0x00007FDA
			public LessThanUInt64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040010CD RID: 4301
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

			// Token: 0x040010CE RID: 4302
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
		}

		// Token: 0x02000265 RID: 613
		public sealed class LessThanSingle : LessThanInstruction
		{
			// Token: 0x06001874 RID: 6260 RVA: 0x000751C0 File Offset: 0x000733C0
			// Note: this type is marked as 'beforefieldinit'.
			static LessThanSingle()
			{
				Il2CppClassPointerStore<LessThanInstruction.LessThanSingle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LessThanInstruction>.NativeClassPtr, "LessThanSingle");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LessThanInstruction.LessThanSingle>.NativeClassPtr);
				LessThanInstruction.LessThanSingle.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanInstruction.LessThanSingle>.NativeClassPtr, 100665486);
				LessThanInstruction.LessThanSingle.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanInstruction.LessThanSingle>.NativeClassPtr, 100665487);
			}

			// Token: 0x06001875 RID: 6261 RVA: 0x00075214 File Offset: 0x00073414
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LessThanSingle(Object nullValue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LessThanInstruction.LessThanSingle>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullValue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LessThanInstruction.LessThanSingle.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001876 RID: 6262 RVA: 0x00075260 File Offset: 0x00073460
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019793, XrefRangeEnd = 1019802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LessThanInstruction.LessThanSingle.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001877 RID: 6263 RVA: 0x00009DE3 File Offset: 0x00007FE3
			public LessThanSingle(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040010CF RID: 4303
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

			// Token: 0x040010D0 RID: 4304
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
		}

		// Token: 0x02000266 RID: 614
		public sealed class LessThanDouble : LessThanInstruction
		{
			// Token: 0x06001878 RID: 6264 RVA: 0x000752B0 File Offset: 0x000734B0
			// Note: this type is marked as 'beforefieldinit'.
			static LessThanDouble()
			{
				Il2CppClassPointerStore<LessThanInstruction.LessThanDouble>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LessThanInstruction>.NativeClassPtr, "LessThanDouble");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LessThanInstruction.LessThanDouble>.NativeClassPtr);
				LessThanInstruction.LessThanDouble.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanInstruction.LessThanDouble>.NativeClassPtr, 100665488);
				LessThanInstruction.LessThanDouble.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanInstruction.LessThanDouble>.NativeClassPtr, 100665489);
			}

			// Token: 0x06001879 RID: 6265 RVA: 0x00075304 File Offset: 0x00073504
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LessThanDouble(Object nullValue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LessThanInstruction.LessThanDouble>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullValue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LessThanInstruction.LessThanDouble.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600187A RID: 6266 RVA: 0x00075350 File Offset: 0x00073550
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019802, XrefRangeEnd = 1019811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LessThanInstruction.LessThanDouble.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600187B RID: 6267 RVA: 0x00009DEC File Offset: 0x00007FEC
			public LessThanDouble(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040010D1 RID: 4305
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

			// Token: 0x040010D2 RID: 4306
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
		}
	}
}
