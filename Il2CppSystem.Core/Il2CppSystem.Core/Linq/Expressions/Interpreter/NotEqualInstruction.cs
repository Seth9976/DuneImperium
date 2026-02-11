using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000EF RID: 239
	public class NotEqualInstruction : Instruction
	{
		// Token: 0x06000E67 RID: 3687 RVA: 0x0004F1E4 File Offset: 0x0004D3E4
		// Note: this type is marked as 'beforefieldinit'.
		static NotEqualInstruction()
		{
			Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "NotEqualInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr);
			NotEqualInstruction.NativeFieldInfoPtr_s_reference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, "s_reference");
			NotEqualInstruction.NativeFieldInfoPtr_s_Boolean = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, "s_Boolean");
			NotEqualInstruction.NativeFieldInfoPtr_s_SByte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, "s_SByte");
			NotEqualInstruction.NativeFieldInfoPtr_s_Int16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, "s_Int16");
			NotEqualInstruction.NativeFieldInfoPtr_s_Char = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, "s_Char");
			NotEqualInstruction.NativeFieldInfoPtr_s_Int32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, "s_Int32");
			NotEqualInstruction.NativeFieldInfoPtr_s_Int64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, "s_Int64");
			NotEqualInstruction.NativeFieldInfoPtr_s_Byte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, "s_Byte");
			NotEqualInstruction.NativeFieldInfoPtr_s_UInt16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, "s_UInt16");
			NotEqualInstruction.NativeFieldInfoPtr_s_UInt32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, "s_UInt32");
			NotEqualInstruction.NativeFieldInfoPtr_s_UInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, "s_UInt64");
			NotEqualInstruction.NativeFieldInfoPtr_s_Single = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, "s_Single");
			NotEqualInstruction.NativeFieldInfoPtr_s_Double = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, "s_Double");
			NotEqualInstruction.NativeFieldInfoPtr_s_SByteLiftedToNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, "s_SByteLiftedToNull");
			NotEqualInstruction.NativeFieldInfoPtr_s_Int16LiftedToNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, "s_Int16LiftedToNull");
			NotEqualInstruction.NativeFieldInfoPtr_s_CharLiftedToNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, "s_CharLiftedToNull");
			NotEqualInstruction.NativeFieldInfoPtr_s_Int32LiftedToNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, "s_Int32LiftedToNull");
			NotEqualInstruction.NativeFieldInfoPtr_s_Int64LiftedToNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, "s_Int64LiftedToNull");
			NotEqualInstruction.NativeFieldInfoPtr_s_ByteLiftedToNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, "s_ByteLiftedToNull");
			NotEqualInstruction.NativeFieldInfoPtr_s_UInt16LiftedToNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, "s_UInt16LiftedToNull");
			NotEqualInstruction.NativeFieldInfoPtr_s_UInt32LiftedToNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, "s_UInt32LiftedToNull");
			NotEqualInstruction.NativeFieldInfoPtr_s_UInt64LiftedToNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, "s_UInt64LiftedToNull");
			NotEqualInstruction.NativeFieldInfoPtr_s_SingleLiftedToNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, "s_SingleLiftedToNull");
			NotEqualInstruction.NativeFieldInfoPtr_s_DoubleLiftedToNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, "s_DoubleLiftedToNull");
			NotEqualInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, 100665948);
			NotEqualInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, 100665949);
			NotEqualInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, 100665950);
			NotEqualInstruction.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, 100665951);
			NotEqualInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, 100665952);
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06000E68 RID: 3688 RVA: 0x0004F458 File Offset: 0x0004D658
		public unsafe override int ConsumedStack
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 72978, RefRangeEnd = 72985, XrefRangeStart = 72978, XrefRangeEnd = 72985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NotEqualInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06000E69 RID: 3689 RVA: 0x0004F4A0 File Offset: 0x0004D6A0
		public unsafe override int ProducedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NotEqualInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06000E6A RID: 3690 RVA: 0x0004F4E8 File Offset: 0x0004D6E8
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025478, XrefRangeEnd = 1025480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NotEqualInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x0004F52C File Offset: 0x0004D72C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NotEqualInstruction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotEqualInstruction.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x0004F568 File Offset: 0x0004D768
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1025687, RefRangeEnd = 1025690, XrefRangeStart = 1025480, XrefRangeEnd = 1025687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotEqualInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
		}

		// Token: 0x06000E6D RID: 3693 RVA: 0x0000660A File Offset: 0x0000480A
		public NotEqualInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06000E6E RID: 3694 RVA: 0x0004F5BC File Offset: 0x0004D7BC
		// (set) Token: 0x06000E6F RID: 3695 RVA: 0x00006613 File Offset: 0x00004813
		public unsafe static Instruction s_reference
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NotEqualInstruction.NativeFieldInfoPtr_s_reference, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NotEqualInstruction.NativeFieldInfoPtr_s_reference, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06000E70 RID: 3696 RVA: 0x0004F5E4 File Offset: 0x0004D7E4
		// (set) Token: 0x06000E71 RID: 3697 RVA: 0x00006625 File Offset: 0x00004825
		public unsafe static Instruction s_Boolean
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NotEqualInstruction.NativeFieldInfoPtr_s_Boolean, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NotEqualInstruction.NativeFieldInfoPtr_s_Boolean, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06000E72 RID: 3698 RVA: 0x0004F60C File Offset: 0x0004D80C
		// (set) Token: 0x06000E73 RID: 3699 RVA: 0x00006637 File Offset: 0x00004837
		public unsafe static Instruction s_SByte
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NotEqualInstruction.NativeFieldInfoPtr_s_SByte, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NotEqualInstruction.NativeFieldInfoPtr_s_SByte, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06000E74 RID: 3700 RVA: 0x0004F634 File Offset: 0x0004D834
		// (set) Token: 0x06000E75 RID: 3701 RVA: 0x00006649 File Offset: 0x00004849
		public unsafe static Instruction s_Int16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NotEqualInstruction.NativeFieldInfoPtr_s_Int16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NotEqualInstruction.NativeFieldInfoPtr_s_Int16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06000E76 RID: 3702 RVA: 0x0004F65C File Offset: 0x0004D85C
		// (set) Token: 0x06000E77 RID: 3703 RVA: 0x0000665B File Offset: 0x0000485B
		public unsafe static Instruction s_Char
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NotEqualInstruction.NativeFieldInfoPtr_s_Char, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NotEqualInstruction.NativeFieldInfoPtr_s_Char, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06000E78 RID: 3704 RVA: 0x0004F684 File Offset: 0x0004D884
		// (set) Token: 0x06000E79 RID: 3705 RVA: 0x0000666D File Offset: 0x0000486D
		public unsafe static Instruction s_Int32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NotEqualInstruction.NativeFieldInfoPtr_s_Int32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NotEqualInstruction.NativeFieldInfoPtr_s_Int32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06000E7A RID: 3706 RVA: 0x0004F6AC File Offset: 0x0004D8AC
		// (set) Token: 0x06000E7B RID: 3707 RVA: 0x0000667F File Offset: 0x0000487F
		public unsafe static Instruction s_Int64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NotEqualInstruction.NativeFieldInfoPtr_s_Int64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NotEqualInstruction.NativeFieldInfoPtr_s_Int64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06000E7C RID: 3708 RVA: 0x0004F6D4 File Offset: 0x0004D8D4
		// (set) Token: 0x06000E7D RID: 3709 RVA: 0x00006691 File Offset: 0x00004891
		public unsafe static Instruction s_Byte
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NotEqualInstruction.NativeFieldInfoPtr_s_Byte, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NotEqualInstruction.NativeFieldInfoPtr_s_Byte, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06000E7E RID: 3710 RVA: 0x0004F6FC File Offset: 0x0004D8FC
		// (set) Token: 0x06000E7F RID: 3711 RVA: 0x000066A3 File Offset: 0x000048A3
		public unsafe static Instruction s_UInt16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NotEqualInstruction.NativeFieldInfoPtr_s_UInt16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NotEqualInstruction.NativeFieldInfoPtr_s_UInt16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06000E80 RID: 3712 RVA: 0x0004F724 File Offset: 0x0004D924
		// (set) Token: 0x06000E81 RID: 3713 RVA: 0x000066B5 File Offset: 0x000048B5
		public unsafe static Instruction s_UInt32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NotEqualInstruction.NativeFieldInfoPtr_s_UInt32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NotEqualInstruction.NativeFieldInfoPtr_s_UInt32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06000E82 RID: 3714 RVA: 0x0004F74C File Offset: 0x0004D94C
		// (set) Token: 0x06000E83 RID: 3715 RVA: 0x000066C7 File Offset: 0x000048C7
		public unsafe static Instruction s_UInt64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NotEqualInstruction.NativeFieldInfoPtr_s_UInt64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NotEqualInstruction.NativeFieldInfoPtr_s_UInt64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06000E84 RID: 3716 RVA: 0x0004F774 File Offset: 0x0004D974
		// (set) Token: 0x06000E85 RID: 3717 RVA: 0x000066D9 File Offset: 0x000048D9
		public unsafe static Instruction s_Single
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NotEqualInstruction.NativeFieldInfoPtr_s_Single, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NotEqualInstruction.NativeFieldInfoPtr_s_Single, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06000E86 RID: 3718 RVA: 0x0004F79C File Offset: 0x0004D99C
		// (set) Token: 0x06000E87 RID: 3719 RVA: 0x000066EB File Offset: 0x000048EB
		public unsafe static Instruction s_Double
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NotEqualInstruction.NativeFieldInfoPtr_s_Double, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NotEqualInstruction.NativeFieldInfoPtr_s_Double, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06000E88 RID: 3720 RVA: 0x0004F7C4 File Offset: 0x0004D9C4
		// (set) Token: 0x06000E89 RID: 3721 RVA: 0x000066FD File Offset: 0x000048FD
		public unsafe static Instruction s_SByteLiftedToNull
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NotEqualInstruction.NativeFieldInfoPtr_s_SByteLiftedToNull, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NotEqualInstruction.NativeFieldInfoPtr_s_SByteLiftedToNull, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06000E8A RID: 3722 RVA: 0x0004F7EC File Offset: 0x0004D9EC
		// (set) Token: 0x06000E8B RID: 3723 RVA: 0x0000670F File Offset: 0x0000490F
		public unsafe static Instruction s_Int16LiftedToNull
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NotEqualInstruction.NativeFieldInfoPtr_s_Int16LiftedToNull, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NotEqualInstruction.NativeFieldInfoPtr_s_Int16LiftedToNull, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06000E8C RID: 3724 RVA: 0x0004F814 File Offset: 0x0004DA14
		// (set) Token: 0x06000E8D RID: 3725 RVA: 0x00006721 File Offset: 0x00004921
		public unsafe static Instruction s_CharLiftedToNull
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NotEqualInstruction.NativeFieldInfoPtr_s_CharLiftedToNull, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NotEqualInstruction.NativeFieldInfoPtr_s_CharLiftedToNull, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06000E8E RID: 3726 RVA: 0x0004F83C File Offset: 0x0004DA3C
		// (set) Token: 0x06000E8F RID: 3727 RVA: 0x00006733 File Offset: 0x00004933
		public unsafe static Instruction s_Int32LiftedToNull
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NotEqualInstruction.NativeFieldInfoPtr_s_Int32LiftedToNull, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NotEqualInstruction.NativeFieldInfoPtr_s_Int32LiftedToNull, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06000E90 RID: 3728 RVA: 0x0004F864 File Offset: 0x0004DA64
		// (set) Token: 0x06000E91 RID: 3729 RVA: 0x00006745 File Offset: 0x00004945
		public unsafe static Instruction s_Int64LiftedToNull
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NotEqualInstruction.NativeFieldInfoPtr_s_Int64LiftedToNull, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NotEqualInstruction.NativeFieldInfoPtr_s_Int64LiftedToNull, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06000E92 RID: 3730 RVA: 0x0004F88C File Offset: 0x0004DA8C
		// (set) Token: 0x06000E93 RID: 3731 RVA: 0x00006757 File Offset: 0x00004957
		public unsafe static Instruction s_ByteLiftedToNull
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NotEqualInstruction.NativeFieldInfoPtr_s_ByteLiftedToNull, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NotEqualInstruction.NativeFieldInfoPtr_s_ByteLiftedToNull, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06000E94 RID: 3732 RVA: 0x0004F8B4 File Offset: 0x0004DAB4
		// (set) Token: 0x06000E95 RID: 3733 RVA: 0x00006769 File Offset: 0x00004969
		public unsafe static Instruction s_UInt16LiftedToNull
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NotEqualInstruction.NativeFieldInfoPtr_s_UInt16LiftedToNull, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NotEqualInstruction.NativeFieldInfoPtr_s_UInt16LiftedToNull, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06000E96 RID: 3734 RVA: 0x0004F8DC File Offset: 0x0004DADC
		// (set) Token: 0x06000E97 RID: 3735 RVA: 0x0000677B File Offset: 0x0000497B
		public unsafe static Instruction s_UInt32LiftedToNull
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NotEqualInstruction.NativeFieldInfoPtr_s_UInt32LiftedToNull, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NotEqualInstruction.NativeFieldInfoPtr_s_UInt32LiftedToNull, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06000E98 RID: 3736 RVA: 0x0004F904 File Offset: 0x0004DB04
		// (set) Token: 0x06000E99 RID: 3737 RVA: 0x0000678D File Offset: 0x0000498D
		public unsafe static Instruction s_UInt64LiftedToNull
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NotEqualInstruction.NativeFieldInfoPtr_s_UInt64LiftedToNull, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NotEqualInstruction.NativeFieldInfoPtr_s_UInt64LiftedToNull, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06000E9A RID: 3738 RVA: 0x0004F92C File Offset: 0x0004DB2C
		// (set) Token: 0x06000E9B RID: 3739 RVA: 0x0000679F File Offset: 0x0000499F
		public unsafe static Instruction s_SingleLiftedToNull
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NotEqualInstruction.NativeFieldInfoPtr_s_SingleLiftedToNull, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NotEqualInstruction.NativeFieldInfoPtr_s_SingleLiftedToNull, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06000E9C RID: 3740 RVA: 0x0004F954 File Offset: 0x0004DB54
		// (set) Token: 0x06000E9D RID: 3741 RVA: 0x000067B1 File Offset: 0x000049B1
		public unsafe static Instruction s_DoubleLiftedToNull
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NotEqualInstruction.NativeFieldInfoPtr_s_DoubleLiftedToNull, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NotEqualInstruction.NativeFieldInfoPtr_s_DoubleLiftedToNull, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A89 RID: 2697
		private static readonly IntPtr NativeFieldInfoPtr_s_reference;

		// Token: 0x04000A8A RID: 2698
		private static readonly IntPtr NativeFieldInfoPtr_s_Boolean;

		// Token: 0x04000A8B RID: 2699
		private static readonly IntPtr NativeFieldInfoPtr_s_SByte;

		// Token: 0x04000A8C RID: 2700
		private static readonly IntPtr NativeFieldInfoPtr_s_Int16;

		// Token: 0x04000A8D RID: 2701
		private static readonly IntPtr NativeFieldInfoPtr_s_Char;

		// Token: 0x04000A8E RID: 2702
		private static readonly IntPtr NativeFieldInfoPtr_s_Int32;

		// Token: 0x04000A8F RID: 2703
		private static readonly IntPtr NativeFieldInfoPtr_s_Int64;

		// Token: 0x04000A90 RID: 2704
		private static readonly IntPtr NativeFieldInfoPtr_s_Byte;

		// Token: 0x04000A91 RID: 2705
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt16;

		// Token: 0x04000A92 RID: 2706
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt32;

		// Token: 0x04000A93 RID: 2707
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt64;

		// Token: 0x04000A94 RID: 2708
		private static readonly IntPtr NativeFieldInfoPtr_s_Single;

		// Token: 0x04000A95 RID: 2709
		private static readonly IntPtr NativeFieldInfoPtr_s_Double;

		// Token: 0x04000A96 RID: 2710
		private static readonly IntPtr NativeFieldInfoPtr_s_SByteLiftedToNull;

		// Token: 0x04000A97 RID: 2711
		private static readonly IntPtr NativeFieldInfoPtr_s_Int16LiftedToNull;

		// Token: 0x04000A98 RID: 2712
		private static readonly IntPtr NativeFieldInfoPtr_s_CharLiftedToNull;

		// Token: 0x04000A99 RID: 2713
		private static readonly IntPtr NativeFieldInfoPtr_s_Int32LiftedToNull;

		// Token: 0x04000A9A RID: 2714
		private static readonly IntPtr NativeFieldInfoPtr_s_Int64LiftedToNull;

		// Token: 0x04000A9B RID: 2715
		private static readonly IntPtr NativeFieldInfoPtr_s_ByteLiftedToNull;

		// Token: 0x04000A9C RID: 2716
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt16LiftedToNull;

		// Token: 0x04000A9D RID: 2717
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt32LiftedToNull;

		// Token: 0x04000A9E RID: 2718
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt64LiftedToNull;

		// Token: 0x04000A9F RID: 2719
		private static readonly IntPtr NativeFieldInfoPtr_s_SingleLiftedToNull;

		// Token: 0x04000AA0 RID: 2720
		private static readonly IntPtr NativeFieldInfoPtr_s_DoubleLiftedToNull;

		// Token: 0x04000AA1 RID: 2721
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000AA2 RID: 2722
		private static readonly IntPtr NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000AA3 RID: 2723
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x04000AA4 RID: 2724
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000AA5 RID: 2725
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_Boolean_0;

		// Token: 0x020002DE RID: 734
		public sealed class NotEqualBoolean : NotEqualInstruction
		{
			// Token: 0x060019DC RID: 6620 RVA: 0x0007C814 File Offset: 0x0007AA14
			// Note: this type is marked as 'beforefieldinit'.
			static NotEqualBoolean()
			{
				Il2CppClassPointerStore<NotEqualInstruction.NotEqualBoolean>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, "NotEqualBoolean");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotEqualInstruction.NotEqualBoolean>.NativeClassPtr);
				NotEqualInstruction.NotEqualBoolean.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction.NotEqualBoolean>.NativeClassPtr, 100665953);
				NotEqualInstruction.NotEqualBoolean.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction.NotEqualBoolean>.NativeClassPtr, 100665954);
			}

			// Token: 0x060019DD RID: 6621 RVA: 0x0007C868 File Offset: 0x0007AA68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025241, XrefRangeEnd = 1025251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotEqualInstruction.NotEqualBoolean.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060019DE RID: 6622 RVA: 0x0007C8B8 File Offset: 0x0007AAB8
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NotEqualBoolean()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotEqualInstruction.NotEqualBoolean>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotEqualInstruction.NotEqualBoolean.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019DF RID: 6623 RVA: 0x0000A252 File Offset: 0x00008452
			public NotEqualBoolean(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040011AF RID: 4527
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x040011B0 RID: 4528
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002DF RID: 735
		public sealed class NotEqualSByte : NotEqualInstruction
		{
			// Token: 0x060019E0 RID: 6624 RVA: 0x0007C8F4 File Offset: 0x0007AAF4
			// Note: this type is marked as 'beforefieldinit'.
			static NotEqualSByte()
			{
				Il2CppClassPointerStore<NotEqualInstruction.NotEqualSByte>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, "NotEqualSByte");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotEqualInstruction.NotEqualSByte>.NativeClassPtr);
				NotEqualInstruction.NotEqualSByte.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction.NotEqualSByte>.NativeClassPtr, 100665955);
				NotEqualInstruction.NotEqualSByte.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction.NotEqualSByte>.NativeClassPtr, 100665956);
			}

			// Token: 0x060019E1 RID: 6625 RVA: 0x0007C948 File Offset: 0x0007AB48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025251, XrefRangeEnd = 1025261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotEqualInstruction.NotEqualSByte.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060019E2 RID: 6626 RVA: 0x0007C998 File Offset: 0x0007AB98
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NotEqualSByte()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotEqualInstruction.NotEqualSByte>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotEqualInstruction.NotEqualSByte.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019E3 RID: 6627 RVA: 0x0000A25B File Offset: 0x0000845B
			public NotEqualSByte(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040011B1 RID: 4529
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x040011B2 RID: 4530
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002E0 RID: 736
		public sealed class NotEqualInt16 : NotEqualInstruction
		{
			// Token: 0x060019E4 RID: 6628 RVA: 0x0007C9D4 File Offset: 0x0007ABD4
			// Note: this type is marked as 'beforefieldinit'.
			static NotEqualInt16()
			{
				Il2CppClassPointerStore<NotEqualInstruction.NotEqualInt16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, "NotEqualInt16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotEqualInstruction.NotEqualInt16>.NativeClassPtr);
				NotEqualInstruction.NotEqualInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction.NotEqualInt16>.NativeClassPtr, 100665957);
				NotEqualInstruction.NotEqualInt16.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction.NotEqualInt16>.NativeClassPtr, 100665958);
			}

			// Token: 0x060019E5 RID: 6629 RVA: 0x0007CA28 File Offset: 0x0007AC28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025261, XrefRangeEnd = 1025271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotEqualInstruction.NotEqualInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060019E6 RID: 6630 RVA: 0x0007CA78 File Offset: 0x0007AC78
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NotEqualInt16()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotEqualInstruction.NotEqualInt16>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotEqualInstruction.NotEqualInt16.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019E7 RID: 6631 RVA: 0x0000A264 File Offset: 0x00008464
			public NotEqualInt16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040011B3 RID: 4531
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x040011B4 RID: 4532
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002E1 RID: 737
		public sealed class NotEqualChar : NotEqualInstruction
		{
			// Token: 0x060019E8 RID: 6632 RVA: 0x0007CAB4 File Offset: 0x0007ACB4
			// Note: this type is marked as 'beforefieldinit'.
			static NotEqualChar()
			{
				Il2CppClassPointerStore<NotEqualInstruction.NotEqualChar>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, "NotEqualChar");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotEqualInstruction.NotEqualChar>.NativeClassPtr);
				NotEqualInstruction.NotEqualChar.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction.NotEqualChar>.NativeClassPtr, 100665959);
				NotEqualInstruction.NotEqualChar.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction.NotEqualChar>.NativeClassPtr, 100665960);
			}

			// Token: 0x060019E9 RID: 6633 RVA: 0x0007CB08 File Offset: 0x0007AD08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025271, XrefRangeEnd = 1025281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotEqualInstruction.NotEqualChar.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060019EA RID: 6634 RVA: 0x0007CB58 File Offset: 0x0007AD58
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NotEqualChar()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotEqualInstruction.NotEqualChar>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotEqualInstruction.NotEqualChar.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019EB RID: 6635 RVA: 0x0000A26D File Offset: 0x0000846D
			public NotEqualChar(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040011B5 RID: 4533
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x040011B6 RID: 4534
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002E2 RID: 738
		public sealed class NotEqualInt32 : NotEqualInstruction
		{
			// Token: 0x060019EC RID: 6636 RVA: 0x0007CB94 File Offset: 0x0007AD94
			// Note: this type is marked as 'beforefieldinit'.
			static NotEqualInt32()
			{
				Il2CppClassPointerStore<NotEqualInstruction.NotEqualInt32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, "NotEqualInt32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotEqualInstruction.NotEqualInt32>.NativeClassPtr);
				NotEqualInstruction.NotEqualInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction.NotEqualInt32>.NativeClassPtr, 100665961);
				NotEqualInstruction.NotEqualInt32.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction.NotEqualInt32>.NativeClassPtr, 100665962);
			}

			// Token: 0x060019ED RID: 6637 RVA: 0x0007CBE8 File Offset: 0x0007ADE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025281, XrefRangeEnd = 1025291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotEqualInstruction.NotEqualInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060019EE RID: 6638 RVA: 0x0007CC38 File Offset: 0x0007AE38
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NotEqualInt32()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotEqualInstruction.NotEqualInt32>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotEqualInstruction.NotEqualInt32.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019EF RID: 6639 RVA: 0x0000A276 File Offset: 0x00008476
			public NotEqualInt32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040011B7 RID: 4535
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x040011B8 RID: 4536
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002E3 RID: 739
		public sealed class NotEqualInt64 : NotEqualInstruction
		{
			// Token: 0x060019F0 RID: 6640 RVA: 0x0007CC74 File Offset: 0x0007AE74
			// Note: this type is marked as 'beforefieldinit'.
			static NotEqualInt64()
			{
				Il2CppClassPointerStore<NotEqualInstruction.NotEqualInt64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, "NotEqualInt64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotEqualInstruction.NotEqualInt64>.NativeClassPtr);
				NotEqualInstruction.NotEqualInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction.NotEqualInt64>.NativeClassPtr, 100665963);
				NotEqualInstruction.NotEqualInt64.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction.NotEqualInt64>.NativeClassPtr, 100665964);
			}

			// Token: 0x060019F1 RID: 6641 RVA: 0x0007CCC8 File Offset: 0x0007AEC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025291, XrefRangeEnd = 1025301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotEqualInstruction.NotEqualInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060019F2 RID: 6642 RVA: 0x0007CD18 File Offset: 0x0007AF18
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NotEqualInt64()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotEqualInstruction.NotEqualInt64>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotEqualInstruction.NotEqualInt64.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019F3 RID: 6643 RVA: 0x0000A27F File Offset: 0x0000847F
			public NotEqualInt64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040011B9 RID: 4537
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x040011BA RID: 4538
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002E4 RID: 740
		public sealed class NotEqualByte : NotEqualInstruction
		{
			// Token: 0x060019F4 RID: 6644 RVA: 0x0007CD54 File Offset: 0x0007AF54
			// Note: this type is marked as 'beforefieldinit'.
			static NotEqualByte()
			{
				Il2CppClassPointerStore<NotEqualInstruction.NotEqualByte>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, "NotEqualByte");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotEqualInstruction.NotEqualByte>.NativeClassPtr);
				NotEqualInstruction.NotEqualByte.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction.NotEqualByte>.NativeClassPtr, 100665965);
				NotEqualInstruction.NotEqualByte.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction.NotEqualByte>.NativeClassPtr, 100665966);
			}

			// Token: 0x060019F5 RID: 6645 RVA: 0x0007CDA8 File Offset: 0x0007AFA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025301, XrefRangeEnd = 1025311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotEqualInstruction.NotEqualByte.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060019F6 RID: 6646 RVA: 0x0007CDF8 File Offset: 0x0007AFF8
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NotEqualByte()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotEqualInstruction.NotEqualByte>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotEqualInstruction.NotEqualByte.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019F7 RID: 6647 RVA: 0x0000A288 File Offset: 0x00008488
			public NotEqualByte(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040011BB RID: 4539
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x040011BC RID: 4540
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002E5 RID: 741
		public sealed class NotEqualUInt16 : NotEqualInstruction
		{
			// Token: 0x060019F8 RID: 6648 RVA: 0x0007CE34 File Offset: 0x0007B034
			// Note: this type is marked as 'beforefieldinit'.
			static NotEqualUInt16()
			{
				Il2CppClassPointerStore<NotEqualInstruction.NotEqualUInt16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, "NotEqualUInt16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotEqualInstruction.NotEqualUInt16>.NativeClassPtr);
				NotEqualInstruction.NotEqualUInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction.NotEqualUInt16>.NativeClassPtr, 100665967);
				NotEqualInstruction.NotEqualUInt16.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction.NotEqualUInt16>.NativeClassPtr, 100665968);
			}

			// Token: 0x060019F9 RID: 6649 RVA: 0x0007CE88 File Offset: 0x0007B088
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025311, XrefRangeEnd = 1025321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotEqualInstruction.NotEqualUInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060019FA RID: 6650 RVA: 0x0007CED8 File Offset: 0x0007B0D8
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NotEqualUInt16()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotEqualInstruction.NotEqualUInt16>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotEqualInstruction.NotEqualUInt16.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019FB RID: 6651 RVA: 0x0000A291 File Offset: 0x00008491
			public NotEqualUInt16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040011BD RID: 4541
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x040011BE RID: 4542
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002E6 RID: 742
		public sealed class NotEqualUInt32 : NotEqualInstruction
		{
			// Token: 0x060019FC RID: 6652 RVA: 0x0007CF14 File Offset: 0x0007B114
			// Note: this type is marked as 'beforefieldinit'.
			static NotEqualUInt32()
			{
				Il2CppClassPointerStore<NotEqualInstruction.NotEqualUInt32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, "NotEqualUInt32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotEqualInstruction.NotEqualUInt32>.NativeClassPtr);
				NotEqualInstruction.NotEqualUInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction.NotEqualUInt32>.NativeClassPtr, 100665969);
				NotEqualInstruction.NotEqualUInt32.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction.NotEqualUInt32>.NativeClassPtr, 100665970);
			}

			// Token: 0x060019FD RID: 6653 RVA: 0x0007CF68 File Offset: 0x0007B168
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025321, XrefRangeEnd = 1025331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotEqualInstruction.NotEqualUInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060019FE RID: 6654 RVA: 0x0007CFB8 File Offset: 0x0007B1B8
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NotEqualUInt32()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotEqualInstruction.NotEqualUInt32>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotEqualInstruction.NotEqualUInt32.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019FF RID: 6655 RVA: 0x0000A29A File Offset: 0x0000849A
			public NotEqualUInt32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040011BF RID: 4543
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x040011C0 RID: 4544
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002E7 RID: 743
		public sealed class NotEqualUInt64 : NotEqualInstruction
		{
			// Token: 0x06001A00 RID: 6656 RVA: 0x0007CFF4 File Offset: 0x0007B1F4
			// Note: this type is marked as 'beforefieldinit'.
			static NotEqualUInt64()
			{
				Il2CppClassPointerStore<NotEqualInstruction.NotEqualUInt64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, "NotEqualUInt64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotEqualInstruction.NotEqualUInt64>.NativeClassPtr);
				NotEqualInstruction.NotEqualUInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction.NotEqualUInt64>.NativeClassPtr, 100665971);
				NotEqualInstruction.NotEqualUInt64.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction.NotEqualUInt64>.NativeClassPtr, 100665972);
			}

			// Token: 0x06001A01 RID: 6657 RVA: 0x0007D048 File Offset: 0x0007B248
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025331, XrefRangeEnd = 1025341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotEqualInstruction.NotEqualUInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001A02 RID: 6658 RVA: 0x0007D098 File Offset: 0x0007B298
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NotEqualUInt64()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotEqualInstruction.NotEqualUInt64>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotEqualInstruction.NotEqualUInt64.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A03 RID: 6659 RVA: 0x0000A2A3 File Offset: 0x000084A3
			public NotEqualUInt64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040011C1 RID: 4545
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x040011C2 RID: 4546
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002E8 RID: 744
		public sealed class NotEqualSingle : NotEqualInstruction
		{
			// Token: 0x06001A04 RID: 6660 RVA: 0x0007D0D4 File Offset: 0x0007B2D4
			// Note: this type is marked as 'beforefieldinit'.
			static NotEqualSingle()
			{
				Il2CppClassPointerStore<NotEqualInstruction.NotEqualSingle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, "NotEqualSingle");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotEqualInstruction.NotEqualSingle>.NativeClassPtr);
				NotEqualInstruction.NotEqualSingle.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction.NotEqualSingle>.NativeClassPtr, 100665973);
				NotEqualInstruction.NotEqualSingle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction.NotEqualSingle>.NativeClassPtr, 100665974);
			}

			// Token: 0x06001A05 RID: 6661 RVA: 0x0007D128 File Offset: 0x0007B328
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025341, XrefRangeEnd = 1025351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotEqualInstruction.NotEqualSingle.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001A06 RID: 6662 RVA: 0x0007D178 File Offset: 0x0007B378
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NotEqualSingle()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotEqualInstruction.NotEqualSingle>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotEqualInstruction.NotEqualSingle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A07 RID: 6663 RVA: 0x0000A2AC File Offset: 0x000084AC
			public NotEqualSingle(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040011C3 RID: 4547
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x040011C4 RID: 4548
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002E9 RID: 745
		public sealed class NotEqualDouble : NotEqualInstruction
		{
			// Token: 0x06001A08 RID: 6664 RVA: 0x0007D1B4 File Offset: 0x0007B3B4
			// Note: this type is marked as 'beforefieldinit'.
			static NotEqualDouble()
			{
				Il2CppClassPointerStore<NotEqualInstruction.NotEqualDouble>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, "NotEqualDouble");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotEqualInstruction.NotEqualDouble>.NativeClassPtr);
				NotEqualInstruction.NotEqualDouble.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction.NotEqualDouble>.NativeClassPtr, 100665975);
				NotEqualInstruction.NotEqualDouble.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction.NotEqualDouble>.NativeClassPtr, 100665976);
			}

			// Token: 0x06001A09 RID: 6665 RVA: 0x0007D208 File Offset: 0x0007B408
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025351, XrefRangeEnd = 1025361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotEqualInstruction.NotEqualDouble.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001A0A RID: 6666 RVA: 0x0007D258 File Offset: 0x0007B458
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NotEqualDouble()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotEqualInstruction.NotEqualDouble>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotEqualInstruction.NotEqualDouble.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A0B RID: 6667 RVA: 0x0000A2B5 File Offset: 0x000084B5
			public NotEqualDouble(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040011C5 RID: 4549
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x040011C6 RID: 4550
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002EA RID: 746
		public sealed class NotEqualReference : NotEqualInstruction
		{
			// Token: 0x06001A0C RID: 6668 RVA: 0x0007D294 File Offset: 0x0007B494
			// Note: this type is marked as 'beforefieldinit'.
			static NotEqualReference()
			{
				Il2CppClassPointerStore<NotEqualInstruction.NotEqualReference>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, "NotEqualReference");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotEqualInstruction.NotEqualReference>.NativeClassPtr);
				NotEqualInstruction.NotEqualReference.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction.NotEqualReference>.NativeClassPtr, 100665977);
				NotEqualInstruction.NotEqualReference.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction.NotEqualReference>.NativeClassPtr, 100665978);
			}

			// Token: 0x06001A0D RID: 6669 RVA: 0x0007D2E8 File Offset: 0x0007B4E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025361, XrefRangeEnd = 1025364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotEqualInstruction.NotEqualReference.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001A0E RID: 6670 RVA: 0x0007D338 File Offset: 0x0007B538
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NotEqualReference()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotEqualInstruction.NotEqualReference>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotEqualInstruction.NotEqualReference.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A0F RID: 6671 RVA: 0x0000A2BE File Offset: 0x000084BE
			public NotEqualReference(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040011C7 RID: 4551
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x040011C8 RID: 4552
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002EB RID: 747
		public sealed class NotEqualSByteLiftedToNull : NotEqualInstruction
		{
			// Token: 0x06001A10 RID: 6672 RVA: 0x0007D374 File Offset: 0x0007B574
			// Note: this type is marked as 'beforefieldinit'.
			static NotEqualSByteLiftedToNull()
			{
				Il2CppClassPointerStore<NotEqualInstruction.NotEqualSByteLiftedToNull>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, "NotEqualSByteLiftedToNull");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotEqualInstruction.NotEqualSByteLiftedToNull>.NativeClassPtr);
				NotEqualInstruction.NotEqualSByteLiftedToNull.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction.NotEqualSByteLiftedToNull>.NativeClassPtr, 100665979);
				NotEqualInstruction.NotEqualSByteLiftedToNull.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction.NotEqualSByteLiftedToNull>.NativeClassPtr, 100665980);
			}

			// Token: 0x06001A11 RID: 6673 RVA: 0x0007D3C8 File Offset: 0x0007B5C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025364, XrefRangeEnd = 1025374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotEqualInstruction.NotEqualSByteLiftedToNull.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001A12 RID: 6674 RVA: 0x0007D418 File Offset: 0x0007B618
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NotEqualSByteLiftedToNull()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotEqualInstruction.NotEqualSByteLiftedToNull>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotEqualInstruction.NotEqualSByteLiftedToNull.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A13 RID: 6675 RVA: 0x0000A2C7 File Offset: 0x000084C7
			public NotEqualSByteLiftedToNull(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040011C9 RID: 4553
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x040011CA RID: 4554
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002EC RID: 748
		public sealed class NotEqualInt16LiftedToNull : NotEqualInstruction
		{
			// Token: 0x06001A14 RID: 6676 RVA: 0x0007D454 File Offset: 0x0007B654
			// Note: this type is marked as 'beforefieldinit'.
			static NotEqualInt16LiftedToNull()
			{
				Il2CppClassPointerStore<NotEqualInstruction.NotEqualInt16LiftedToNull>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, "NotEqualInt16LiftedToNull");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotEqualInstruction.NotEqualInt16LiftedToNull>.NativeClassPtr);
				NotEqualInstruction.NotEqualInt16LiftedToNull.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction.NotEqualInt16LiftedToNull>.NativeClassPtr, 100665981);
				NotEqualInstruction.NotEqualInt16LiftedToNull.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction.NotEqualInt16LiftedToNull>.NativeClassPtr, 100665982);
			}

			// Token: 0x06001A15 RID: 6677 RVA: 0x0007D4A8 File Offset: 0x0007B6A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025374, XrefRangeEnd = 1025384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotEqualInstruction.NotEqualInt16LiftedToNull.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001A16 RID: 6678 RVA: 0x0007D4F8 File Offset: 0x0007B6F8
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NotEqualInt16LiftedToNull()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotEqualInstruction.NotEqualInt16LiftedToNull>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotEqualInstruction.NotEqualInt16LiftedToNull.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A17 RID: 6679 RVA: 0x0000A2D0 File Offset: 0x000084D0
			public NotEqualInt16LiftedToNull(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040011CB RID: 4555
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x040011CC RID: 4556
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002ED RID: 749
		public sealed class NotEqualCharLiftedToNull : NotEqualInstruction
		{
			// Token: 0x06001A18 RID: 6680 RVA: 0x0007D534 File Offset: 0x0007B734
			// Note: this type is marked as 'beforefieldinit'.
			static NotEqualCharLiftedToNull()
			{
				Il2CppClassPointerStore<NotEqualInstruction.NotEqualCharLiftedToNull>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, "NotEqualCharLiftedToNull");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotEqualInstruction.NotEqualCharLiftedToNull>.NativeClassPtr);
				NotEqualInstruction.NotEqualCharLiftedToNull.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction.NotEqualCharLiftedToNull>.NativeClassPtr, 100665983);
				NotEqualInstruction.NotEqualCharLiftedToNull.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction.NotEqualCharLiftedToNull>.NativeClassPtr, 100665984);
			}

			// Token: 0x06001A19 RID: 6681 RVA: 0x0007D588 File Offset: 0x0007B788
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025384, XrefRangeEnd = 1025394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotEqualInstruction.NotEqualCharLiftedToNull.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001A1A RID: 6682 RVA: 0x0007D5D8 File Offset: 0x0007B7D8
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NotEqualCharLiftedToNull()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotEqualInstruction.NotEqualCharLiftedToNull>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotEqualInstruction.NotEqualCharLiftedToNull.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A1B RID: 6683 RVA: 0x0000A2D9 File Offset: 0x000084D9
			public NotEqualCharLiftedToNull(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040011CD RID: 4557
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x040011CE RID: 4558
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002EE RID: 750
		public sealed class NotEqualInt32LiftedToNull : NotEqualInstruction
		{
			// Token: 0x06001A1C RID: 6684 RVA: 0x0007D614 File Offset: 0x0007B814
			// Note: this type is marked as 'beforefieldinit'.
			static NotEqualInt32LiftedToNull()
			{
				Il2CppClassPointerStore<NotEqualInstruction.NotEqualInt32LiftedToNull>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, "NotEqualInt32LiftedToNull");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotEqualInstruction.NotEqualInt32LiftedToNull>.NativeClassPtr);
				NotEqualInstruction.NotEqualInt32LiftedToNull.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction.NotEqualInt32LiftedToNull>.NativeClassPtr, 100665985);
				NotEqualInstruction.NotEqualInt32LiftedToNull.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction.NotEqualInt32LiftedToNull>.NativeClassPtr, 100665986);
			}

			// Token: 0x06001A1D RID: 6685 RVA: 0x0007D668 File Offset: 0x0007B868
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025394, XrefRangeEnd = 1025404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotEqualInstruction.NotEqualInt32LiftedToNull.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001A1E RID: 6686 RVA: 0x0007D6B8 File Offset: 0x0007B8B8
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NotEqualInt32LiftedToNull()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotEqualInstruction.NotEqualInt32LiftedToNull>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotEqualInstruction.NotEqualInt32LiftedToNull.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A1F RID: 6687 RVA: 0x0000A2E2 File Offset: 0x000084E2
			public NotEqualInt32LiftedToNull(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040011CF RID: 4559
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x040011D0 RID: 4560
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002EF RID: 751
		public sealed class NotEqualInt64LiftedToNull : NotEqualInstruction
		{
			// Token: 0x06001A20 RID: 6688 RVA: 0x0007D6F4 File Offset: 0x0007B8F4
			// Note: this type is marked as 'beforefieldinit'.
			static NotEqualInt64LiftedToNull()
			{
				Il2CppClassPointerStore<NotEqualInstruction.NotEqualInt64LiftedToNull>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, "NotEqualInt64LiftedToNull");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotEqualInstruction.NotEqualInt64LiftedToNull>.NativeClassPtr);
				NotEqualInstruction.NotEqualInt64LiftedToNull.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction.NotEqualInt64LiftedToNull>.NativeClassPtr, 100665987);
				NotEqualInstruction.NotEqualInt64LiftedToNull.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction.NotEqualInt64LiftedToNull>.NativeClassPtr, 100665988);
			}

			// Token: 0x06001A21 RID: 6689 RVA: 0x0007D748 File Offset: 0x0007B948
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025404, XrefRangeEnd = 1025414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotEqualInstruction.NotEqualInt64LiftedToNull.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001A22 RID: 6690 RVA: 0x0007D798 File Offset: 0x0007B998
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NotEqualInt64LiftedToNull()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotEqualInstruction.NotEqualInt64LiftedToNull>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotEqualInstruction.NotEqualInt64LiftedToNull.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A23 RID: 6691 RVA: 0x0000A2EB File Offset: 0x000084EB
			public NotEqualInt64LiftedToNull(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040011D1 RID: 4561
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x040011D2 RID: 4562
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002F0 RID: 752
		public sealed class NotEqualByteLiftedToNull : NotEqualInstruction
		{
			// Token: 0x06001A24 RID: 6692 RVA: 0x0007D7D4 File Offset: 0x0007B9D4
			// Note: this type is marked as 'beforefieldinit'.
			static NotEqualByteLiftedToNull()
			{
				Il2CppClassPointerStore<NotEqualInstruction.NotEqualByteLiftedToNull>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, "NotEqualByteLiftedToNull");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotEqualInstruction.NotEqualByteLiftedToNull>.NativeClassPtr);
				NotEqualInstruction.NotEqualByteLiftedToNull.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction.NotEqualByteLiftedToNull>.NativeClassPtr, 100665989);
				NotEqualInstruction.NotEqualByteLiftedToNull.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction.NotEqualByteLiftedToNull>.NativeClassPtr, 100665990);
			}

			// Token: 0x06001A25 RID: 6693 RVA: 0x0007D828 File Offset: 0x0007BA28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025414, XrefRangeEnd = 1025424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotEqualInstruction.NotEqualByteLiftedToNull.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001A26 RID: 6694 RVA: 0x0007D878 File Offset: 0x0007BA78
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NotEqualByteLiftedToNull()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotEqualInstruction.NotEqualByteLiftedToNull>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotEqualInstruction.NotEqualByteLiftedToNull.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A27 RID: 6695 RVA: 0x0000A2F4 File Offset: 0x000084F4
			public NotEqualByteLiftedToNull(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040011D3 RID: 4563
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x040011D4 RID: 4564
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002F1 RID: 753
		public sealed class NotEqualUInt16LiftedToNull : NotEqualInstruction
		{
			// Token: 0x06001A28 RID: 6696 RVA: 0x0007D8B4 File Offset: 0x0007BAB4
			// Note: this type is marked as 'beforefieldinit'.
			static NotEqualUInt16LiftedToNull()
			{
				Il2CppClassPointerStore<NotEqualInstruction.NotEqualUInt16LiftedToNull>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, "NotEqualUInt16LiftedToNull");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotEqualInstruction.NotEqualUInt16LiftedToNull>.NativeClassPtr);
				NotEqualInstruction.NotEqualUInt16LiftedToNull.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction.NotEqualUInt16LiftedToNull>.NativeClassPtr, 100665991);
				NotEqualInstruction.NotEqualUInt16LiftedToNull.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction.NotEqualUInt16LiftedToNull>.NativeClassPtr, 100665992);
			}

			// Token: 0x06001A29 RID: 6697 RVA: 0x0007D908 File Offset: 0x0007BB08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025424, XrefRangeEnd = 1025434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotEqualInstruction.NotEqualUInt16LiftedToNull.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001A2A RID: 6698 RVA: 0x0007D958 File Offset: 0x0007BB58
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NotEqualUInt16LiftedToNull()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotEqualInstruction.NotEqualUInt16LiftedToNull>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotEqualInstruction.NotEqualUInt16LiftedToNull.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A2B RID: 6699 RVA: 0x0000A2FD File Offset: 0x000084FD
			public NotEqualUInt16LiftedToNull(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040011D5 RID: 4565
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x040011D6 RID: 4566
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002F2 RID: 754
		public sealed class NotEqualUInt32LiftedToNull : NotEqualInstruction
		{
			// Token: 0x06001A2C RID: 6700 RVA: 0x0007D994 File Offset: 0x0007BB94
			// Note: this type is marked as 'beforefieldinit'.
			static NotEqualUInt32LiftedToNull()
			{
				Il2CppClassPointerStore<NotEqualInstruction.NotEqualUInt32LiftedToNull>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, "NotEqualUInt32LiftedToNull");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotEqualInstruction.NotEqualUInt32LiftedToNull>.NativeClassPtr);
				NotEqualInstruction.NotEqualUInt32LiftedToNull.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction.NotEqualUInt32LiftedToNull>.NativeClassPtr, 100665993);
				NotEqualInstruction.NotEqualUInt32LiftedToNull.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction.NotEqualUInt32LiftedToNull>.NativeClassPtr, 100665994);
			}

			// Token: 0x06001A2D RID: 6701 RVA: 0x0007D9E8 File Offset: 0x0007BBE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025434, XrefRangeEnd = 1025444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotEqualInstruction.NotEqualUInt32LiftedToNull.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001A2E RID: 6702 RVA: 0x0007DA38 File Offset: 0x0007BC38
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NotEqualUInt32LiftedToNull()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotEqualInstruction.NotEqualUInt32LiftedToNull>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotEqualInstruction.NotEqualUInt32LiftedToNull.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A2F RID: 6703 RVA: 0x0000A306 File Offset: 0x00008506
			public NotEqualUInt32LiftedToNull(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040011D7 RID: 4567
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x040011D8 RID: 4568
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002F3 RID: 755
		public sealed class NotEqualUInt64LiftedToNull : NotEqualInstruction
		{
			// Token: 0x06001A30 RID: 6704 RVA: 0x0007DA74 File Offset: 0x0007BC74
			// Note: this type is marked as 'beforefieldinit'.
			static NotEqualUInt64LiftedToNull()
			{
				Il2CppClassPointerStore<NotEqualInstruction.NotEqualUInt64LiftedToNull>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, "NotEqualUInt64LiftedToNull");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotEqualInstruction.NotEqualUInt64LiftedToNull>.NativeClassPtr);
				NotEqualInstruction.NotEqualUInt64LiftedToNull.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction.NotEqualUInt64LiftedToNull>.NativeClassPtr, 100665995);
				NotEqualInstruction.NotEqualUInt64LiftedToNull.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction.NotEqualUInt64LiftedToNull>.NativeClassPtr, 100665996);
			}

			// Token: 0x06001A31 RID: 6705 RVA: 0x0007DAC8 File Offset: 0x0007BCC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025444, XrefRangeEnd = 1025454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotEqualInstruction.NotEqualUInt64LiftedToNull.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001A32 RID: 6706 RVA: 0x0007DB18 File Offset: 0x0007BD18
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NotEqualUInt64LiftedToNull()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotEqualInstruction.NotEqualUInt64LiftedToNull>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotEqualInstruction.NotEqualUInt64LiftedToNull.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A33 RID: 6707 RVA: 0x0000A30F File Offset: 0x0000850F
			public NotEqualUInt64LiftedToNull(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040011D9 RID: 4569
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x040011DA RID: 4570
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002F4 RID: 756
		public sealed class NotEqualSingleLiftedToNull : NotEqualInstruction
		{
			// Token: 0x06001A34 RID: 6708 RVA: 0x0007DB54 File Offset: 0x0007BD54
			// Note: this type is marked as 'beforefieldinit'.
			static NotEqualSingleLiftedToNull()
			{
				Il2CppClassPointerStore<NotEqualInstruction.NotEqualSingleLiftedToNull>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, "NotEqualSingleLiftedToNull");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotEqualInstruction.NotEqualSingleLiftedToNull>.NativeClassPtr);
				NotEqualInstruction.NotEqualSingleLiftedToNull.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction.NotEqualSingleLiftedToNull>.NativeClassPtr, 100665997);
				NotEqualInstruction.NotEqualSingleLiftedToNull.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction.NotEqualSingleLiftedToNull>.NativeClassPtr, 100665998);
			}

			// Token: 0x06001A35 RID: 6709 RVA: 0x0007DBA8 File Offset: 0x0007BDA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025454, XrefRangeEnd = 1025466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotEqualInstruction.NotEqualSingleLiftedToNull.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001A36 RID: 6710 RVA: 0x0007DBF8 File Offset: 0x0007BDF8
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NotEqualSingleLiftedToNull()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotEqualInstruction.NotEqualSingleLiftedToNull>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotEqualInstruction.NotEqualSingleLiftedToNull.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A37 RID: 6711 RVA: 0x0000A318 File Offset: 0x00008518
			public NotEqualSingleLiftedToNull(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040011DB RID: 4571
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x040011DC RID: 4572
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002F5 RID: 757
		public sealed class NotEqualDoubleLiftedToNull : NotEqualInstruction
		{
			// Token: 0x06001A38 RID: 6712 RVA: 0x0007DC34 File Offset: 0x0007BE34
			// Note: this type is marked as 'beforefieldinit'.
			static NotEqualDoubleLiftedToNull()
			{
				Il2CppClassPointerStore<NotEqualInstruction.NotEqualDoubleLiftedToNull>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NotEqualInstruction>.NativeClassPtr, "NotEqualDoubleLiftedToNull");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotEqualInstruction.NotEqualDoubleLiftedToNull>.NativeClassPtr);
				NotEqualInstruction.NotEqualDoubleLiftedToNull.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction.NotEqualDoubleLiftedToNull>.NativeClassPtr, 100665999);
				NotEqualInstruction.NotEqualDoubleLiftedToNull.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotEqualInstruction.NotEqualDoubleLiftedToNull>.NativeClassPtr, 100666000);
			}

			// Token: 0x06001A39 RID: 6713 RVA: 0x0007DC88 File Offset: 0x0007BE88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025466, XrefRangeEnd = 1025478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotEqualInstruction.NotEqualDoubleLiftedToNull.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001A3A RID: 6714 RVA: 0x0007DCD8 File Offset: 0x0007BED8
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NotEqualDoubleLiftedToNull()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotEqualInstruction.NotEqualDoubleLiftedToNull>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotEqualInstruction.NotEqualDoubleLiftedToNull.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A3B RID: 6715 RVA: 0x0000A321 File Offset: 0x00008521
			public NotEqualDoubleLiftedToNull(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040011DD RID: 4573
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x040011DE RID: 4574
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
