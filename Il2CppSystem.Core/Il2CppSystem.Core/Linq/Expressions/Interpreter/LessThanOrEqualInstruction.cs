using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000C6 RID: 198
	public class LessThanOrEqualInstruction : Instruction
	{
		// Token: 0x06000BE4 RID: 3044 RVA: 0x00041628 File Offset: 0x0003F828
		// Note: this type is marked as 'beforefieldinit'.
		static LessThanOrEqualInstruction()
		{
			Il2CppClassPointerStore<LessThanOrEqualInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "LessThanOrEqualInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LessThanOrEqualInstruction>.NativeClassPtr);
			LessThanOrEqualInstruction.NativeFieldInfoPtr__nullValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LessThanOrEqualInstruction>.NativeClassPtr, "_nullValue");
			LessThanOrEqualInstruction.NativeFieldInfoPtr_s_SByte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LessThanOrEqualInstruction>.NativeClassPtr, "s_SByte");
			LessThanOrEqualInstruction.NativeFieldInfoPtr_s_Int16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LessThanOrEqualInstruction>.NativeClassPtr, "s_Int16");
			LessThanOrEqualInstruction.NativeFieldInfoPtr_s_Char = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LessThanOrEqualInstruction>.NativeClassPtr, "s_Char");
			LessThanOrEqualInstruction.NativeFieldInfoPtr_s_Int32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LessThanOrEqualInstruction>.NativeClassPtr, "s_Int32");
			LessThanOrEqualInstruction.NativeFieldInfoPtr_s_Int64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LessThanOrEqualInstruction>.NativeClassPtr, "s_Int64");
			LessThanOrEqualInstruction.NativeFieldInfoPtr_s_Byte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LessThanOrEqualInstruction>.NativeClassPtr, "s_Byte");
			LessThanOrEqualInstruction.NativeFieldInfoPtr_s_UInt16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LessThanOrEqualInstruction>.NativeClassPtr, "s_UInt16");
			LessThanOrEqualInstruction.NativeFieldInfoPtr_s_UInt32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LessThanOrEqualInstruction>.NativeClassPtr, "s_UInt32");
			LessThanOrEqualInstruction.NativeFieldInfoPtr_s_UInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LessThanOrEqualInstruction>.NativeClassPtr, "s_UInt64");
			LessThanOrEqualInstruction.NativeFieldInfoPtr_s_Single = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LessThanOrEqualInstruction>.NativeClassPtr, "s_Single");
			LessThanOrEqualInstruction.NativeFieldInfoPtr_s_Double = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LessThanOrEqualInstruction>.NativeClassPtr, "s_Double");
			LessThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullSByte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LessThanOrEqualInstruction>.NativeClassPtr, "s_liftedToNullSByte");
			LessThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullInt16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LessThanOrEqualInstruction>.NativeClassPtr, "s_liftedToNullInt16");
			LessThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LessThanOrEqualInstruction>.NativeClassPtr, "s_liftedToNullChar");
			LessThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullInt32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LessThanOrEqualInstruction>.NativeClassPtr, "s_liftedToNullInt32");
			LessThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LessThanOrEqualInstruction>.NativeClassPtr, "s_liftedToNullInt64");
			LessThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullByte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LessThanOrEqualInstruction>.NativeClassPtr, "s_liftedToNullByte");
			LessThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullUInt16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LessThanOrEqualInstruction>.NativeClassPtr, "s_liftedToNullUInt16");
			LessThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullUInt32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LessThanOrEqualInstruction>.NativeClassPtr, "s_liftedToNullUInt32");
			LessThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullUInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LessThanOrEqualInstruction>.NativeClassPtr, "s_liftedToNullUInt64");
			LessThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullSingle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LessThanOrEqualInstruction>.NativeClassPtr, "s_liftedToNullSingle");
			LessThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullDouble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LessThanOrEqualInstruction>.NativeClassPtr, "s_liftedToNullDouble");
			LessThanOrEqualInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanOrEqualInstruction>.NativeClassPtr, 100665490);
			LessThanOrEqualInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanOrEqualInstruction>.NativeClassPtr, 100665491);
			LessThanOrEqualInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanOrEqualInstruction>.NativeClassPtr, 100665492);
			LessThanOrEqualInstruction.NativeMethodInfoPtr__ctor_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanOrEqualInstruction>.NativeClassPtr, 100665493);
			LessThanOrEqualInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanOrEqualInstruction>.NativeClassPtr, 100665494);
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000BE5 RID: 3045 RVA: 0x00041888 File Offset: 0x0003FA88
		public unsafe override int ConsumedStack
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 72978, RefRangeEnd = 72985, XrefRangeStart = 72978, XrefRangeEnd = 72985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LessThanOrEqualInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000BE6 RID: 3046 RVA: 0x000418D0 File Offset: 0x0003FAD0
		public unsafe override int ProducedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LessThanOrEqualInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000BE7 RID: 3047 RVA: 0x00041918 File Offset: 0x0003FB18
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019946, XrefRangeEnd = 1019948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LessThanOrEqualInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x0004195C File Offset: 0x0003FB5C
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LessThanOrEqualInstruction(Object nullValue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LessThanOrEqualInstruction>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullValue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LessThanOrEqualInstruction.NativeMethodInfoPtr__ctor_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x000419A8 File Offset: 0x0003FBA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1019980, RefRangeEnd = 1019982, XrefRangeStart = 1019948, XrefRangeEnd = 1019980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LessThanOrEqualInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
		}

		// Token: 0x06000BEA RID: 3050 RVA: 0x0000584C File Offset: 0x00003A4C
		public LessThanOrEqualInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000BEB RID: 3051 RVA: 0x000419FC File Offset: 0x0003FBFC
		// (set) Token: 0x06000BEC RID: 3052 RVA: 0x00005855 File Offset: 0x00003A55
		public unsafe Object _nullValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LessThanOrEqualInstruction.NativeFieldInfoPtr__nullValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LessThanOrEqualInstruction.NativeFieldInfoPtr__nullValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000BED RID: 3053 RVA: 0x00041A2C File Offset: 0x0003FC2C
		// (set) Token: 0x06000BEE RID: 3054 RVA: 0x00005874 File Offset: 0x00003A74
		public unsafe static Instruction s_SByte
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LessThanOrEqualInstruction.NativeFieldInfoPtr_s_SByte, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LessThanOrEqualInstruction.NativeFieldInfoPtr_s_SByte, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000BEF RID: 3055 RVA: 0x00041A54 File Offset: 0x0003FC54
		// (set) Token: 0x06000BF0 RID: 3056 RVA: 0x00005886 File Offset: 0x00003A86
		public unsafe static Instruction s_Int16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LessThanOrEqualInstruction.NativeFieldInfoPtr_s_Int16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LessThanOrEqualInstruction.NativeFieldInfoPtr_s_Int16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000BF1 RID: 3057 RVA: 0x00041A7C File Offset: 0x0003FC7C
		// (set) Token: 0x06000BF2 RID: 3058 RVA: 0x00005898 File Offset: 0x00003A98
		public unsafe static Instruction s_Char
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LessThanOrEqualInstruction.NativeFieldInfoPtr_s_Char, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LessThanOrEqualInstruction.NativeFieldInfoPtr_s_Char, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000BF3 RID: 3059 RVA: 0x00041AA4 File Offset: 0x0003FCA4
		// (set) Token: 0x06000BF4 RID: 3060 RVA: 0x000058AA File Offset: 0x00003AAA
		public unsafe static Instruction s_Int32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LessThanOrEqualInstruction.NativeFieldInfoPtr_s_Int32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LessThanOrEqualInstruction.NativeFieldInfoPtr_s_Int32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000BF5 RID: 3061 RVA: 0x00041ACC File Offset: 0x0003FCCC
		// (set) Token: 0x06000BF6 RID: 3062 RVA: 0x000058BC File Offset: 0x00003ABC
		public unsafe static Instruction s_Int64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LessThanOrEqualInstruction.NativeFieldInfoPtr_s_Int64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LessThanOrEqualInstruction.NativeFieldInfoPtr_s_Int64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000BF7 RID: 3063 RVA: 0x00041AF4 File Offset: 0x0003FCF4
		// (set) Token: 0x06000BF8 RID: 3064 RVA: 0x000058CE File Offset: 0x00003ACE
		public unsafe static Instruction s_Byte
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LessThanOrEqualInstruction.NativeFieldInfoPtr_s_Byte, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LessThanOrEqualInstruction.NativeFieldInfoPtr_s_Byte, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000BF9 RID: 3065 RVA: 0x00041B1C File Offset: 0x0003FD1C
		// (set) Token: 0x06000BFA RID: 3066 RVA: 0x000058E0 File Offset: 0x00003AE0
		public unsafe static Instruction s_UInt16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LessThanOrEqualInstruction.NativeFieldInfoPtr_s_UInt16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LessThanOrEqualInstruction.NativeFieldInfoPtr_s_UInt16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000BFB RID: 3067 RVA: 0x00041B44 File Offset: 0x0003FD44
		// (set) Token: 0x06000BFC RID: 3068 RVA: 0x000058F2 File Offset: 0x00003AF2
		public unsafe static Instruction s_UInt32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LessThanOrEqualInstruction.NativeFieldInfoPtr_s_UInt32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LessThanOrEqualInstruction.NativeFieldInfoPtr_s_UInt32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000BFD RID: 3069 RVA: 0x00041B6C File Offset: 0x0003FD6C
		// (set) Token: 0x06000BFE RID: 3070 RVA: 0x00005904 File Offset: 0x00003B04
		public unsafe static Instruction s_UInt64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LessThanOrEqualInstruction.NativeFieldInfoPtr_s_UInt64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LessThanOrEqualInstruction.NativeFieldInfoPtr_s_UInt64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000BFF RID: 3071 RVA: 0x00041B94 File Offset: 0x0003FD94
		// (set) Token: 0x06000C00 RID: 3072 RVA: 0x00005916 File Offset: 0x00003B16
		public unsafe static Instruction s_Single
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LessThanOrEqualInstruction.NativeFieldInfoPtr_s_Single, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LessThanOrEqualInstruction.NativeFieldInfoPtr_s_Single, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000C01 RID: 3073 RVA: 0x00041BBC File Offset: 0x0003FDBC
		// (set) Token: 0x06000C02 RID: 3074 RVA: 0x00005928 File Offset: 0x00003B28
		public unsafe static Instruction s_Double
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LessThanOrEqualInstruction.NativeFieldInfoPtr_s_Double, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LessThanOrEqualInstruction.NativeFieldInfoPtr_s_Double, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000C03 RID: 3075 RVA: 0x00041BE4 File Offset: 0x0003FDE4
		// (set) Token: 0x06000C04 RID: 3076 RVA: 0x0000593A File Offset: 0x00003B3A
		public unsafe static Instruction s_liftedToNullSByte
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LessThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullSByte, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LessThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullSByte, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000C05 RID: 3077 RVA: 0x00041C0C File Offset: 0x0003FE0C
		// (set) Token: 0x06000C06 RID: 3078 RVA: 0x0000594C File Offset: 0x00003B4C
		public unsafe static Instruction s_liftedToNullInt16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LessThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullInt16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LessThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullInt16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000C07 RID: 3079 RVA: 0x00041C34 File Offset: 0x0003FE34
		// (set) Token: 0x06000C08 RID: 3080 RVA: 0x0000595E File Offset: 0x00003B5E
		public unsafe static Instruction s_liftedToNullChar
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LessThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullChar, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LessThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullChar, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000C09 RID: 3081 RVA: 0x00041C5C File Offset: 0x0003FE5C
		// (set) Token: 0x06000C0A RID: 3082 RVA: 0x00005970 File Offset: 0x00003B70
		public unsafe static Instruction s_liftedToNullInt32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LessThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullInt32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LessThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullInt32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000C0B RID: 3083 RVA: 0x00041C84 File Offset: 0x0003FE84
		// (set) Token: 0x06000C0C RID: 3084 RVA: 0x00005982 File Offset: 0x00003B82
		public unsafe static Instruction s_liftedToNullInt64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LessThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullInt64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LessThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullInt64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000C0D RID: 3085 RVA: 0x00041CAC File Offset: 0x0003FEAC
		// (set) Token: 0x06000C0E RID: 3086 RVA: 0x00005994 File Offset: 0x00003B94
		public unsafe static Instruction s_liftedToNullByte
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LessThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullByte, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LessThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullByte, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000C0F RID: 3087 RVA: 0x00041CD4 File Offset: 0x0003FED4
		// (set) Token: 0x06000C10 RID: 3088 RVA: 0x000059A6 File Offset: 0x00003BA6
		public unsafe static Instruction s_liftedToNullUInt16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LessThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullUInt16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LessThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullUInt16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000C11 RID: 3089 RVA: 0x00041CFC File Offset: 0x0003FEFC
		// (set) Token: 0x06000C12 RID: 3090 RVA: 0x000059B8 File Offset: 0x00003BB8
		public unsafe static Instruction s_liftedToNullUInt32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LessThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullUInt32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LessThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullUInt32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000C13 RID: 3091 RVA: 0x00041D24 File Offset: 0x0003FF24
		// (set) Token: 0x06000C14 RID: 3092 RVA: 0x000059CA File Offset: 0x00003BCA
		public unsafe static Instruction s_liftedToNullUInt64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LessThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullUInt64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LessThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullUInt64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000C15 RID: 3093 RVA: 0x00041D4C File Offset: 0x0003FF4C
		// (set) Token: 0x06000C16 RID: 3094 RVA: 0x000059DC File Offset: 0x00003BDC
		public unsafe static Instruction s_liftedToNullSingle
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LessThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullSingle, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LessThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullSingle, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000C17 RID: 3095 RVA: 0x00041D74 File Offset: 0x0003FF74
		// (set) Token: 0x06000C18 RID: 3096 RVA: 0x000059EE File Offset: 0x00003BEE
		public unsafe static Instruction s_liftedToNullDouble
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LessThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullDouble, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LessThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullDouble, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008D3 RID: 2259
		private static readonly IntPtr NativeFieldInfoPtr__nullValue;

		// Token: 0x040008D4 RID: 2260
		private static readonly IntPtr NativeFieldInfoPtr_s_SByte;

		// Token: 0x040008D5 RID: 2261
		private static readonly IntPtr NativeFieldInfoPtr_s_Int16;

		// Token: 0x040008D6 RID: 2262
		private static readonly IntPtr NativeFieldInfoPtr_s_Char;

		// Token: 0x040008D7 RID: 2263
		private static readonly IntPtr NativeFieldInfoPtr_s_Int32;

		// Token: 0x040008D8 RID: 2264
		private static readonly IntPtr NativeFieldInfoPtr_s_Int64;

		// Token: 0x040008D9 RID: 2265
		private static readonly IntPtr NativeFieldInfoPtr_s_Byte;

		// Token: 0x040008DA RID: 2266
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt16;

		// Token: 0x040008DB RID: 2267
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt32;

		// Token: 0x040008DC RID: 2268
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt64;

		// Token: 0x040008DD RID: 2269
		private static readonly IntPtr NativeFieldInfoPtr_s_Single;

		// Token: 0x040008DE RID: 2270
		private static readonly IntPtr NativeFieldInfoPtr_s_Double;

		// Token: 0x040008DF RID: 2271
		private static readonly IntPtr NativeFieldInfoPtr_s_liftedToNullSByte;

		// Token: 0x040008E0 RID: 2272
		private static readonly IntPtr NativeFieldInfoPtr_s_liftedToNullInt16;

		// Token: 0x040008E1 RID: 2273
		private static readonly IntPtr NativeFieldInfoPtr_s_liftedToNullChar;

		// Token: 0x040008E2 RID: 2274
		private static readonly IntPtr NativeFieldInfoPtr_s_liftedToNullInt32;

		// Token: 0x040008E3 RID: 2275
		private static readonly IntPtr NativeFieldInfoPtr_s_liftedToNullInt64;

		// Token: 0x040008E4 RID: 2276
		private static readonly IntPtr NativeFieldInfoPtr_s_liftedToNullByte;

		// Token: 0x040008E5 RID: 2277
		private static readonly IntPtr NativeFieldInfoPtr_s_liftedToNullUInt16;

		// Token: 0x040008E6 RID: 2278
		private static readonly IntPtr NativeFieldInfoPtr_s_liftedToNullUInt32;

		// Token: 0x040008E7 RID: 2279
		private static readonly IntPtr NativeFieldInfoPtr_s_liftedToNullUInt64;

		// Token: 0x040008E8 RID: 2280
		private static readonly IntPtr NativeFieldInfoPtr_s_liftedToNullSingle;

		// Token: 0x040008E9 RID: 2281
		private static readonly IntPtr NativeFieldInfoPtr_s_liftedToNullDouble;

		// Token: 0x040008EA RID: 2282
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0;

		// Token: 0x040008EB RID: 2283
		private static readonly IntPtr NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0;

		// Token: 0x040008EC RID: 2284
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x040008ED RID: 2285
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Object_0;

		// Token: 0x040008EE RID: 2286
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_Boolean_0;

		// Token: 0x02000267 RID: 615
		public sealed class LessThanOrEqualSByte : LessThanOrEqualInstruction
		{
			// Token: 0x0600187C RID: 6268 RVA: 0x000753A0 File Offset: 0x000735A0
			// Note: this type is marked as 'beforefieldinit'.
			static LessThanOrEqualSByte()
			{
				Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualSByte>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LessThanOrEqualInstruction>.NativeClassPtr, "LessThanOrEqualSByte");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualSByte>.NativeClassPtr);
				LessThanOrEqualInstruction.LessThanOrEqualSByte.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualSByte>.NativeClassPtr, 100665495);
				LessThanOrEqualInstruction.LessThanOrEqualSByte.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualSByte>.NativeClassPtr, 100665496);
			}

			// Token: 0x0600187D RID: 6269 RVA: 0x000753F4 File Offset: 0x000735F4
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LessThanOrEqualSByte(Object nullValue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualSByte>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullValue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LessThanOrEqualInstruction.LessThanOrEqualSByte.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600187E RID: 6270 RVA: 0x00075440 File Offset: 0x00073640
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019847, XrefRangeEnd = 1019856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LessThanOrEqualInstruction.LessThanOrEqualSByte.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600187F RID: 6271 RVA: 0x00009DF5 File Offset: 0x00007FF5
			public LessThanOrEqualSByte(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040010D3 RID: 4307
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

			// Token: 0x040010D4 RID: 4308
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
		}

		// Token: 0x02000268 RID: 616
		public sealed class LessThanOrEqualInt16 : LessThanOrEqualInstruction
		{
			// Token: 0x06001880 RID: 6272 RVA: 0x00075490 File Offset: 0x00073690
			// Note: this type is marked as 'beforefieldinit'.
			static LessThanOrEqualInt16()
			{
				Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualInt16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LessThanOrEqualInstruction>.NativeClassPtr, "LessThanOrEqualInt16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualInt16>.NativeClassPtr);
				LessThanOrEqualInstruction.LessThanOrEqualInt16.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualInt16>.NativeClassPtr, 100665497);
				LessThanOrEqualInstruction.LessThanOrEqualInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualInt16>.NativeClassPtr, 100665498);
			}

			// Token: 0x06001881 RID: 6273 RVA: 0x000754E4 File Offset: 0x000736E4
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LessThanOrEqualInt16(Object nullValue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualInt16>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullValue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LessThanOrEqualInstruction.LessThanOrEqualInt16.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001882 RID: 6274 RVA: 0x00075530 File Offset: 0x00073730
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019856, XrefRangeEnd = 1019865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LessThanOrEqualInstruction.LessThanOrEqualInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001883 RID: 6275 RVA: 0x00009DFE File Offset: 0x00007FFE
			public LessThanOrEqualInt16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040010D5 RID: 4309
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

			// Token: 0x040010D6 RID: 4310
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
		}

		// Token: 0x02000269 RID: 617
		public sealed class LessThanOrEqualChar : LessThanOrEqualInstruction
		{
			// Token: 0x06001884 RID: 6276 RVA: 0x00075580 File Offset: 0x00073780
			// Note: this type is marked as 'beforefieldinit'.
			static LessThanOrEqualChar()
			{
				Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualChar>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LessThanOrEqualInstruction>.NativeClassPtr, "LessThanOrEqualChar");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualChar>.NativeClassPtr);
				LessThanOrEqualInstruction.LessThanOrEqualChar.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualChar>.NativeClassPtr, 100665499);
				LessThanOrEqualInstruction.LessThanOrEqualChar.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualChar>.NativeClassPtr, 100665500);
			}

			// Token: 0x06001885 RID: 6277 RVA: 0x000755D4 File Offset: 0x000737D4
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LessThanOrEqualChar(Object nullValue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualChar>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullValue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LessThanOrEqualInstruction.LessThanOrEqualChar.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001886 RID: 6278 RVA: 0x00075620 File Offset: 0x00073820
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019865, XrefRangeEnd = 1019874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LessThanOrEqualInstruction.LessThanOrEqualChar.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001887 RID: 6279 RVA: 0x00009E07 File Offset: 0x00008007
			public LessThanOrEqualChar(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040010D7 RID: 4311
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

			// Token: 0x040010D8 RID: 4312
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
		}

		// Token: 0x0200026A RID: 618
		public sealed class LessThanOrEqualInt32 : LessThanOrEqualInstruction
		{
			// Token: 0x06001888 RID: 6280 RVA: 0x00075670 File Offset: 0x00073870
			// Note: this type is marked as 'beforefieldinit'.
			static LessThanOrEqualInt32()
			{
				Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualInt32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LessThanOrEqualInstruction>.NativeClassPtr, "LessThanOrEqualInt32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualInt32>.NativeClassPtr);
				LessThanOrEqualInstruction.LessThanOrEqualInt32.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualInt32>.NativeClassPtr, 100665501);
				LessThanOrEqualInstruction.LessThanOrEqualInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualInt32>.NativeClassPtr, 100665502);
			}

			// Token: 0x06001889 RID: 6281 RVA: 0x000756C4 File Offset: 0x000738C4
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LessThanOrEqualInt32(Object nullValue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualInt32>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullValue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LessThanOrEqualInstruction.LessThanOrEqualInt32.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600188A RID: 6282 RVA: 0x00075710 File Offset: 0x00073910
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019874, XrefRangeEnd = 1019883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LessThanOrEqualInstruction.LessThanOrEqualInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600188B RID: 6283 RVA: 0x00009E10 File Offset: 0x00008010
			public LessThanOrEqualInt32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040010D9 RID: 4313
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

			// Token: 0x040010DA RID: 4314
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
		}

		// Token: 0x0200026B RID: 619
		public sealed class LessThanOrEqualInt64 : LessThanOrEqualInstruction
		{
			// Token: 0x0600188C RID: 6284 RVA: 0x00075760 File Offset: 0x00073960
			// Note: this type is marked as 'beforefieldinit'.
			static LessThanOrEqualInt64()
			{
				Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualInt64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LessThanOrEqualInstruction>.NativeClassPtr, "LessThanOrEqualInt64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualInt64>.NativeClassPtr);
				LessThanOrEqualInstruction.LessThanOrEqualInt64.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualInt64>.NativeClassPtr, 100665503);
				LessThanOrEqualInstruction.LessThanOrEqualInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualInt64>.NativeClassPtr, 100665504);
			}

			// Token: 0x0600188D RID: 6285 RVA: 0x000757B4 File Offset: 0x000739B4
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LessThanOrEqualInt64(Object nullValue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualInt64>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullValue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LessThanOrEqualInstruction.LessThanOrEqualInt64.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600188E RID: 6286 RVA: 0x00075800 File Offset: 0x00073A00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019883, XrefRangeEnd = 1019892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LessThanOrEqualInstruction.LessThanOrEqualInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600188F RID: 6287 RVA: 0x00009E19 File Offset: 0x00008019
			public LessThanOrEqualInt64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040010DB RID: 4315
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

			// Token: 0x040010DC RID: 4316
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
		}

		// Token: 0x0200026C RID: 620
		public sealed class LessThanOrEqualByte : LessThanOrEqualInstruction
		{
			// Token: 0x06001890 RID: 6288 RVA: 0x00075850 File Offset: 0x00073A50
			// Note: this type is marked as 'beforefieldinit'.
			static LessThanOrEqualByte()
			{
				Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualByte>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LessThanOrEqualInstruction>.NativeClassPtr, "LessThanOrEqualByte");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualByte>.NativeClassPtr);
				LessThanOrEqualInstruction.LessThanOrEqualByte.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualByte>.NativeClassPtr, 100665505);
				LessThanOrEqualInstruction.LessThanOrEqualByte.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualByte>.NativeClassPtr, 100665506);
			}

			// Token: 0x06001891 RID: 6289 RVA: 0x000758A4 File Offset: 0x00073AA4
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LessThanOrEqualByte(Object nullValue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualByte>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullValue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LessThanOrEqualInstruction.LessThanOrEqualByte.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001892 RID: 6290 RVA: 0x000758F0 File Offset: 0x00073AF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019892, XrefRangeEnd = 1019901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LessThanOrEqualInstruction.LessThanOrEqualByte.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001893 RID: 6291 RVA: 0x00009E22 File Offset: 0x00008022
			public LessThanOrEqualByte(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040010DD RID: 4317
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

			// Token: 0x040010DE RID: 4318
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
		}

		// Token: 0x0200026D RID: 621
		public sealed class LessThanOrEqualUInt16 : LessThanOrEqualInstruction
		{
			// Token: 0x06001894 RID: 6292 RVA: 0x00075940 File Offset: 0x00073B40
			// Note: this type is marked as 'beforefieldinit'.
			static LessThanOrEqualUInt16()
			{
				Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualUInt16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LessThanOrEqualInstruction>.NativeClassPtr, "LessThanOrEqualUInt16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualUInt16>.NativeClassPtr);
				LessThanOrEqualInstruction.LessThanOrEqualUInt16.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualUInt16>.NativeClassPtr, 100665507);
				LessThanOrEqualInstruction.LessThanOrEqualUInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualUInt16>.NativeClassPtr, 100665508);
			}

			// Token: 0x06001895 RID: 6293 RVA: 0x00075994 File Offset: 0x00073B94
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LessThanOrEqualUInt16(Object nullValue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualUInt16>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullValue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LessThanOrEqualInstruction.LessThanOrEqualUInt16.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001896 RID: 6294 RVA: 0x000759E0 File Offset: 0x00073BE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019901, XrefRangeEnd = 1019910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LessThanOrEqualInstruction.LessThanOrEqualUInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001897 RID: 6295 RVA: 0x00009E2B File Offset: 0x0000802B
			public LessThanOrEqualUInt16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040010DF RID: 4319
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

			// Token: 0x040010E0 RID: 4320
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
		}

		// Token: 0x0200026E RID: 622
		public sealed class LessThanOrEqualUInt32 : LessThanOrEqualInstruction
		{
			// Token: 0x06001898 RID: 6296 RVA: 0x00075A30 File Offset: 0x00073C30
			// Note: this type is marked as 'beforefieldinit'.
			static LessThanOrEqualUInt32()
			{
				Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualUInt32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LessThanOrEqualInstruction>.NativeClassPtr, "LessThanOrEqualUInt32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualUInt32>.NativeClassPtr);
				LessThanOrEqualInstruction.LessThanOrEqualUInt32.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualUInt32>.NativeClassPtr, 100665509);
				LessThanOrEqualInstruction.LessThanOrEqualUInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualUInt32>.NativeClassPtr, 100665510);
			}

			// Token: 0x06001899 RID: 6297 RVA: 0x00075A84 File Offset: 0x00073C84
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LessThanOrEqualUInt32(Object nullValue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualUInt32>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullValue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LessThanOrEqualInstruction.LessThanOrEqualUInt32.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600189A RID: 6298 RVA: 0x00075AD0 File Offset: 0x00073CD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019910, XrefRangeEnd = 1019919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LessThanOrEqualInstruction.LessThanOrEqualUInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600189B RID: 6299 RVA: 0x00009E34 File Offset: 0x00008034
			public LessThanOrEqualUInt32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040010E1 RID: 4321
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

			// Token: 0x040010E2 RID: 4322
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
		}

		// Token: 0x0200026F RID: 623
		public sealed class LessThanOrEqualUInt64 : LessThanOrEqualInstruction
		{
			// Token: 0x0600189C RID: 6300 RVA: 0x00075B20 File Offset: 0x00073D20
			// Note: this type is marked as 'beforefieldinit'.
			static LessThanOrEqualUInt64()
			{
				Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualUInt64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LessThanOrEqualInstruction>.NativeClassPtr, "LessThanOrEqualUInt64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualUInt64>.NativeClassPtr);
				LessThanOrEqualInstruction.LessThanOrEqualUInt64.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualUInt64>.NativeClassPtr, 100665511);
				LessThanOrEqualInstruction.LessThanOrEqualUInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualUInt64>.NativeClassPtr, 100665512);
			}

			// Token: 0x0600189D RID: 6301 RVA: 0x00075B74 File Offset: 0x00073D74
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LessThanOrEqualUInt64(Object nullValue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualUInt64>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullValue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LessThanOrEqualInstruction.LessThanOrEqualUInt64.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600189E RID: 6302 RVA: 0x00075BC0 File Offset: 0x00073DC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019919, XrefRangeEnd = 1019928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LessThanOrEqualInstruction.LessThanOrEqualUInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600189F RID: 6303 RVA: 0x00009E3D File Offset: 0x0000803D
			public LessThanOrEqualUInt64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040010E3 RID: 4323
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

			// Token: 0x040010E4 RID: 4324
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
		}

		// Token: 0x02000270 RID: 624
		public sealed class LessThanOrEqualSingle : LessThanOrEqualInstruction
		{
			// Token: 0x060018A0 RID: 6304 RVA: 0x00075C10 File Offset: 0x00073E10
			// Note: this type is marked as 'beforefieldinit'.
			static LessThanOrEqualSingle()
			{
				Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualSingle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LessThanOrEqualInstruction>.NativeClassPtr, "LessThanOrEqualSingle");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualSingle>.NativeClassPtr);
				LessThanOrEqualInstruction.LessThanOrEqualSingle.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualSingle>.NativeClassPtr, 100665513);
				LessThanOrEqualInstruction.LessThanOrEqualSingle.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualSingle>.NativeClassPtr, 100665514);
			}

			// Token: 0x060018A1 RID: 6305 RVA: 0x00075C64 File Offset: 0x00073E64
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LessThanOrEqualSingle(Object nullValue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualSingle>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullValue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LessThanOrEqualInstruction.LessThanOrEqualSingle.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060018A2 RID: 6306 RVA: 0x00075CB0 File Offset: 0x00073EB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019928, XrefRangeEnd = 1019937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LessThanOrEqualInstruction.LessThanOrEqualSingle.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060018A3 RID: 6307 RVA: 0x00009E46 File Offset: 0x00008046
			public LessThanOrEqualSingle(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040010E5 RID: 4325
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

			// Token: 0x040010E6 RID: 4326
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
		}

		// Token: 0x02000271 RID: 625
		public sealed class LessThanOrEqualDouble : LessThanOrEqualInstruction
		{
			// Token: 0x060018A4 RID: 6308 RVA: 0x00075D00 File Offset: 0x00073F00
			// Note: this type is marked as 'beforefieldinit'.
			static LessThanOrEqualDouble()
			{
				Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualDouble>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LessThanOrEqualInstruction>.NativeClassPtr, "LessThanOrEqualDouble");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualDouble>.NativeClassPtr);
				LessThanOrEqualInstruction.LessThanOrEqualDouble.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualDouble>.NativeClassPtr, 100665515);
				LessThanOrEqualInstruction.LessThanOrEqualDouble.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualDouble>.NativeClassPtr, 100665516);
			}

			// Token: 0x060018A5 RID: 6309 RVA: 0x00075D54 File Offset: 0x00073F54
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LessThanOrEqualDouble(Object nullValue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LessThanOrEqualInstruction.LessThanOrEqualDouble>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullValue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LessThanOrEqualInstruction.LessThanOrEqualDouble.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060018A6 RID: 6310 RVA: 0x00075DA0 File Offset: 0x00073FA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019937, XrefRangeEnd = 1019946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LessThanOrEqualInstruction.LessThanOrEqualDouble.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060018A7 RID: 6311 RVA: 0x00009E4F File Offset: 0x0000804F
			public LessThanOrEqualDouble(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040010E7 RID: 4327
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

			// Token: 0x040010E8 RID: 4328
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
		}
	}
}
