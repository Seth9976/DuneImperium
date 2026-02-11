using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000BA RID: 186
	public class GreaterThanOrEqualInstruction : Instruction
	{
		// Token: 0x06000A17 RID: 2583 RVA: 0x0003B12C File Offset: 0x0003932C
		// Note: this type is marked as 'beforefieldinit'.
		static GreaterThanOrEqualInstruction()
		{
			Il2CppClassPointerStore<GreaterThanOrEqualInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "GreaterThanOrEqualInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GreaterThanOrEqualInstruction>.NativeClassPtr);
			GreaterThanOrEqualInstruction.NativeFieldInfoPtr__nullValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GreaterThanOrEqualInstruction>.NativeClassPtr, "_nullValue");
			GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_SByte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GreaterThanOrEqualInstruction>.NativeClassPtr, "s_SByte");
			GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_Int16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GreaterThanOrEqualInstruction>.NativeClassPtr, "s_Int16");
			GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_Char = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GreaterThanOrEqualInstruction>.NativeClassPtr, "s_Char");
			GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_Int32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GreaterThanOrEqualInstruction>.NativeClassPtr, "s_Int32");
			GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_Int64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GreaterThanOrEqualInstruction>.NativeClassPtr, "s_Int64");
			GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_Byte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GreaterThanOrEqualInstruction>.NativeClassPtr, "s_Byte");
			GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_UInt16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GreaterThanOrEqualInstruction>.NativeClassPtr, "s_UInt16");
			GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_UInt32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GreaterThanOrEqualInstruction>.NativeClassPtr, "s_UInt32");
			GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_UInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GreaterThanOrEqualInstruction>.NativeClassPtr, "s_UInt64");
			GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_Single = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GreaterThanOrEqualInstruction>.NativeClassPtr, "s_Single");
			GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_Double = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GreaterThanOrEqualInstruction>.NativeClassPtr, "s_Double");
			GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullSByte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GreaterThanOrEqualInstruction>.NativeClassPtr, "s_liftedToNullSByte");
			GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullInt16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GreaterThanOrEqualInstruction>.NativeClassPtr, "s_liftedToNullInt16");
			GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GreaterThanOrEqualInstruction>.NativeClassPtr, "s_liftedToNullChar");
			GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullInt32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GreaterThanOrEqualInstruction>.NativeClassPtr, "s_liftedToNullInt32");
			GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GreaterThanOrEqualInstruction>.NativeClassPtr, "s_liftedToNullInt64");
			GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullByte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GreaterThanOrEqualInstruction>.NativeClassPtr, "s_liftedToNullByte");
			GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullUInt16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GreaterThanOrEqualInstruction>.NativeClassPtr, "s_liftedToNullUInt16");
			GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullUInt32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GreaterThanOrEqualInstruction>.NativeClassPtr, "s_liftedToNullUInt32");
			GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullUInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GreaterThanOrEqualInstruction>.NativeClassPtr, "s_liftedToNullUInt64");
			GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullSingle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GreaterThanOrEqualInstruction>.NativeClassPtr, "s_liftedToNullSingle");
			GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullDouble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GreaterThanOrEqualInstruction>.NativeClassPtr, "s_liftedToNullDouble");
			GreaterThanOrEqualInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanOrEqualInstruction>.NativeClassPtr, 100665197);
			GreaterThanOrEqualInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanOrEqualInstruction>.NativeClassPtr, 100665198);
			GreaterThanOrEqualInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanOrEqualInstruction>.NativeClassPtr, 100665199);
			GreaterThanOrEqualInstruction.NativeMethodInfoPtr__ctor_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanOrEqualInstruction>.NativeClassPtr, 100665200);
			GreaterThanOrEqualInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanOrEqualInstruction>.NativeClassPtr, 100665201);
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000A18 RID: 2584 RVA: 0x0003B38C File Offset: 0x0003958C
		public unsafe override int ConsumedStack
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 72978, RefRangeEnd = 72985, XrefRangeStart = 72978, XrefRangeEnd = 72985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GreaterThanOrEqualInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x0003B3D4 File Offset: 0x000395D4
		public unsafe override int ProducedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GreaterThanOrEqualInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000A1A RID: 2586 RVA: 0x0003B41C File Offset: 0x0003961C
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1017226, XrefRangeEnd = 1017228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GreaterThanOrEqualInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x0003B460 File Offset: 0x00039660
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GreaterThanOrEqualInstruction(Object nullValue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GreaterThanOrEqualInstruction>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullValue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GreaterThanOrEqualInstruction.NativeMethodInfoPtr__ctor_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x0003B4AC File Offset: 0x000396AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1017260, RefRangeEnd = 1017262, XrefRangeStart = 1017228, XrefRangeEnd = 1017260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GreaterThanOrEqualInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x00004D6E File Offset: 0x00002F6E
		public GreaterThanOrEqualInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000A1E RID: 2590 RVA: 0x0003B500 File Offset: 0x00039700
		// (set) Token: 0x06000A1F RID: 2591 RVA: 0x00004D77 File Offset: 0x00002F77
		public unsafe Object _nullValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GreaterThanOrEqualInstruction.NativeFieldInfoPtr__nullValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GreaterThanOrEqualInstruction.NativeFieldInfoPtr__nullValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000A20 RID: 2592 RVA: 0x0003B530 File Offset: 0x00039730
		// (set) Token: 0x06000A21 RID: 2593 RVA: 0x00004D96 File Offset: 0x00002F96
		public unsafe static Instruction s_SByte
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_SByte, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_SByte, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000A22 RID: 2594 RVA: 0x0003B558 File Offset: 0x00039758
		// (set) Token: 0x06000A23 RID: 2595 RVA: 0x00004DA8 File Offset: 0x00002FA8
		public unsafe static Instruction s_Int16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_Int16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_Int16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000A24 RID: 2596 RVA: 0x0003B580 File Offset: 0x00039780
		// (set) Token: 0x06000A25 RID: 2597 RVA: 0x00004DBA File Offset: 0x00002FBA
		public unsafe static Instruction s_Char
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_Char, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_Char, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000A26 RID: 2598 RVA: 0x0003B5A8 File Offset: 0x000397A8
		// (set) Token: 0x06000A27 RID: 2599 RVA: 0x00004DCC File Offset: 0x00002FCC
		public unsafe static Instruction s_Int32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_Int32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_Int32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000A28 RID: 2600 RVA: 0x0003B5D0 File Offset: 0x000397D0
		// (set) Token: 0x06000A29 RID: 2601 RVA: 0x00004DDE File Offset: 0x00002FDE
		public unsafe static Instruction s_Int64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_Int64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_Int64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000A2A RID: 2602 RVA: 0x0003B5F8 File Offset: 0x000397F8
		// (set) Token: 0x06000A2B RID: 2603 RVA: 0x00004DF0 File Offset: 0x00002FF0
		public unsafe static Instruction s_Byte
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_Byte, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_Byte, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000A2C RID: 2604 RVA: 0x0003B620 File Offset: 0x00039820
		// (set) Token: 0x06000A2D RID: 2605 RVA: 0x00004E02 File Offset: 0x00003002
		public unsafe static Instruction s_UInt16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_UInt16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_UInt16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000A2E RID: 2606 RVA: 0x0003B648 File Offset: 0x00039848
		// (set) Token: 0x06000A2F RID: 2607 RVA: 0x00004E14 File Offset: 0x00003014
		public unsafe static Instruction s_UInt32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_UInt32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_UInt32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000A30 RID: 2608 RVA: 0x0003B670 File Offset: 0x00039870
		// (set) Token: 0x06000A31 RID: 2609 RVA: 0x00004E26 File Offset: 0x00003026
		public unsafe static Instruction s_UInt64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_UInt64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_UInt64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000A32 RID: 2610 RVA: 0x0003B698 File Offset: 0x00039898
		// (set) Token: 0x06000A33 RID: 2611 RVA: 0x00004E38 File Offset: 0x00003038
		public unsafe static Instruction s_Single
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_Single, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_Single, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000A34 RID: 2612 RVA: 0x0003B6C0 File Offset: 0x000398C0
		// (set) Token: 0x06000A35 RID: 2613 RVA: 0x00004E4A File Offset: 0x0000304A
		public unsafe static Instruction s_Double
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_Double, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_Double, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000A36 RID: 2614 RVA: 0x0003B6E8 File Offset: 0x000398E8
		// (set) Token: 0x06000A37 RID: 2615 RVA: 0x00004E5C File Offset: 0x0000305C
		public unsafe static Instruction s_liftedToNullSByte
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullSByte, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullSByte, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000A38 RID: 2616 RVA: 0x0003B710 File Offset: 0x00039910
		// (set) Token: 0x06000A39 RID: 2617 RVA: 0x00004E6E File Offset: 0x0000306E
		public unsafe static Instruction s_liftedToNullInt16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullInt16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullInt16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000A3A RID: 2618 RVA: 0x0003B738 File Offset: 0x00039938
		// (set) Token: 0x06000A3B RID: 2619 RVA: 0x00004E80 File Offset: 0x00003080
		public unsafe static Instruction s_liftedToNullChar
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullChar, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullChar, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000A3C RID: 2620 RVA: 0x0003B760 File Offset: 0x00039960
		// (set) Token: 0x06000A3D RID: 2621 RVA: 0x00004E92 File Offset: 0x00003092
		public unsafe static Instruction s_liftedToNullInt32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullInt32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullInt32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000A3E RID: 2622 RVA: 0x0003B788 File Offset: 0x00039988
		// (set) Token: 0x06000A3F RID: 2623 RVA: 0x00004EA4 File Offset: 0x000030A4
		public unsafe static Instruction s_liftedToNullInt64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullInt64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullInt64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000A40 RID: 2624 RVA: 0x0003B7B0 File Offset: 0x000399B0
		// (set) Token: 0x06000A41 RID: 2625 RVA: 0x00004EB6 File Offset: 0x000030B6
		public unsafe static Instruction s_liftedToNullByte
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullByte, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullByte, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000A42 RID: 2626 RVA: 0x0003B7D8 File Offset: 0x000399D8
		// (set) Token: 0x06000A43 RID: 2627 RVA: 0x00004EC8 File Offset: 0x000030C8
		public unsafe static Instruction s_liftedToNullUInt16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullUInt16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullUInt16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000A44 RID: 2628 RVA: 0x0003B800 File Offset: 0x00039A00
		// (set) Token: 0x06000A45 RID: 2629 RVA: 0x00004EDA File Offset: 0x000030DA
		public unsafe static Instruction s_liftedToNullUInt32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullUInt32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullUInt32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000A46 RID: 2630 RVA: 0x0003B828 File Offset: 0x00039A28
		// (set) Token: 0x06000A47 RID: 2631 RVA: 0x00004EEC File Offset: 0x000030EC
		public unsafe static Instruction s_liftedToNullUInt64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullUInt64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullUInt64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000A48 RID: 2632 RVA: 0x0003B850 File Offset: 0x00039A50
		// (set) Token: 0x06000A49 RID: 2633 RVA: 0x00004EFE File Offset: 0x000030FE
		public unsafe static Instruction s_liftedToNullSingle
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullSingle, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullSingle, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000A4A RID: 2634 RVA: 0x0003B878 File Offset: 0x00039A78
		// (set) Token: 0x06000A4B RID: 2635 RVA: 0x00004F10 File Offset: 0x00003110
		public unsafe static Instruction s_liftedToNullDouble
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullDouble, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GreaterThanOrEqualInstruction.NativeFieldInfoPtr_s_liftedToNullDouble, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400078B RID: 1931
		private static readonly IntPtr NativeFieldInfoPtr__nullValue;

		// Token: 0x0400078C RID: 1932
		private static readonly IntPtr NativeFieldInfoPtr_s_SByte;

		// Token: 0x0400078D RID: 1933
		private static readonly IntPtr NativeFieldInfoPtr_s_Int16;

		// Token: 0x0400078E RID: 1934
		private static readonly IntPtr NativeFieldInfoPtr_s_Char;

		// Token: 0x0400078F RID: 1935
		private static readonly IntPtr NativeFieldInfoPtr_s_Int32;

		// Token: 0x04000790 RID: 1936
		private static readonly IntPtr NativeFieldInfoPtr_s_Int64;

		// Token: 0x04000791 RID: 1937
		private static readonly IntPtr NativeFieldInfoPtr_s_Byte;

		// Token: 0x04000792 RID: 1938
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt16;

		// Token: 0x04000793 RID: 1939
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt32;

		// Token: 0x04000794 RID: 1940
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt64;

		// Token: 0x04000795 RID: 1941
		private static readonly IntPtr NativeFieldInfoPtr_s_Single;

		// Token: 0x04000796 RID: 1942
		private static readonly IntPtr NativeFieldInfoPtr_s_Double;

		// Token: 0x04000797 RID: 1943
		private static readonly IntPtr NativeFieldInfoPtr_s_liftedToNullSByte;

		// Token: 0x04000798 RID: 1944
		private static readonly IntPtr NativeFieldInfoPtr_s_liftedToNullInt16;

		// Token: 0x04000799 RID: 1945
		private static readonly IntPtr NativeFieldInfoPtr_s_liftedToNullChar;

		// Token: 0x0400079A RID: 1946
		private static readonly IntPtr NativeFieldInfoPtr_s_liftedToNullInt32;

		// Token: 0x0400079B RID: 1947
		private static readonly IntPtr NativeFieldInfoPtr_s_liftedToNullInt64;

		// Token: 0x0400079C RID: 1948
		private static readonly IntPtr NativeFieldInfoPtr_s_liftedToNullByte;

		// Token: 0x0400079D RID: 1949
		private static readonly IntPtr NativeFieldInfoPtr_s_liftedToNullUInt16;

		// Token: 0x0400079E RID: 1950
		private static readonly IntPtr NativeFieldInfoPtr_s_liftedToNullUInt32;

		// Token: 0x0400079F RID: 1951
		private static readonly IntPtr NativeFieldInfoPtr_s_liftedToNullUInt64;

		// Token: 0x040007A0 RID: 1952
		private static readonly IntPtr NativeFieldInfoPtr_s_liftedToNullSingle;

		// Token: 0x040007A1 RID: 1953
		private static readonly IntPtr NativeFieldInfoPtr_s_liftedToNullDouble;

		// Token: 0x040007A2 RID: 1954
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0;

		// Token: 0x040007A3 RID: 1955
		private static readonly IntPtr NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0;

		// Token: 0x040007A4 RID: 1956
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x040007A5 RID: 1957
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Object_0;

		// Token: 0x040007A6 RID: 1958
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_Boolean_0;

		// Token: 0x0200023B RID: 571
		public sealed class GreaterThanOrEqualSByte : GreaterThanOrEqualInstruction
		{
			// Token: 0x060017BC RID: 6076 RVA: 0x000728FC File Offset: 0x00070AFC
			// Note: this type is marked as 'beforefieldinit'.
			static GreaterThanOrEqualSByte()
			{
				Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualSByte>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GreaterThanOrEqualInstruction>.NativeClassPtr, "GreaterThanOrEqualSByte");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualSByte>.NativeClassPtr);
				GreaterThanOrEqualInstruction.GreaterThanOrEqualSByte.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualSByte>.NativeClassPtr, 100665202);
				GreaterThanOrEqualInstruction.GreaterThanOrEqualSByte.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualSByte>.NativeClassPtr, 100665203);
			}

			// Token: 0x060017BD RID: 6077 RVA: 0x00072950 File Offset: 0x00070B50
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GreaterThanOrEqualSByte(Object nullValue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualSByte>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullValue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GreaterThanOrEqualInstruction.GreaterThanOrEqualSByte.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060017BE RID: 6078 RVA: 0x0007299C File Offset: 0x00070B9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1017127, XrefRangeEnd = 1017136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GreaterThanOrEqualInstruction.GreaterThanOrEqualSByte.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060017BF RID: 6079 RVA: 0x00009B53 File Offset: 0x00007D53
			public GreaterThanOrEqualSByte(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400106F RID: 4207
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

			// Token: 0x04001070 RID: 4208
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
		}

		// Token: 0x0200023C RID: 572
		public sealed class GreaterThanOrEqualInt16 : GreaterThanOrEqualInstruction
		{
			// Token: 0x060017C0 RID: 6080 RVA: 0x000729EC File Offset: 0x00070BEC
			// Note: this type is marked as 'beforefieldinit'.
			static GreaterThanOrEqualInt16()
			{
				Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualInt16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GreaterThanOrEqualInstruction>.NativeClassPtr, "GreaterThanOrEqualInt16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualInt16>.NativeClassPtr);
				GreaterThanOrEqualInstruction.GreaterThanOrEqualInt16.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualInt16>.NativeClassPtr, 100665204);
				GreaterThanOrEqualInstruction.GreaterThanOrEqualInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualInt16>.NativeClassPtr, 100665205);
			}

			// Token: 0x060017C1 RID: 6081 RVA: 0x00072A40 File Offset: 0x00070C40
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GreaterThanOrEqualInt16(Object nullValue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualInt16>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullValue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GreaterThanOrEqualInstruction.GreaterThanOrEqualInt16.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060017C2 RID: 6082 RVA: 0x00072A8C File Offset: 0x00070C8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1017136, XrefRangeEnd = 1017145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GreaterThanOrEqualInstruction.GreaterThanOrEqualInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060017C3 RID: 6083 RVA: 0x00009B5C File Offset: 0x00007D5C
			public GreaterThanOrEqualInt16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001071 RID: 4209
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

			// Token: 0x04001072 RID: 4210
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
		}

		// Token: 0x0200023D RID: 573
		public sealed class GreaterThanOrEqualChar : GreaterThanOrEqualInstruction
		{
			// Token: 0x060017C4 RID: 6084 RVA: 0x00072ADC File Offset: 0x00070CDC
			// Note: this type is marked as 'beforefieldinit'.
			static GreaterThanOrEqualChar()
			{
				Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualChar>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GreaterThanOrEqualInstruction>.NativeClassPtr, "GreaterThanOrEqualChar");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualChar>.NativeClassPtr);
				GreaterThanOrEqualInstruction.GreaterThanOrEqualChar.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualChar>.NativeClassPtr, 100665206);
				GreaterThanOrEqualInstruction.GreaterThanOrEqualChar.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualChar>.NativeClassPtr, 100665207);
			}

			// Token: 0x060017C5 RID: 6085 RVA: 0x00072B30 File Offset: 0x00070D30
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GreaterThanOrEqualChar(Object nullValue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualChar>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullValue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GreaterThanOrEqualInstruction.GreaterThanOrEqualChar.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060017C6 RID: 6086 RVA: 0x00072B7C File Offset: 0x00070D7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1017145, XrefRangeEnd = 1017154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GreaterThanOrEqualInstruction.GreaterThanOrEqualChar.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060017C7 RID: 6087 RVA: 0x00009B65 File Offset: 0x00007D65
			public GreaterThanOrEqualChar(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001073 RID: 4211
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

			// Token: 0x04001074 RID: 4212
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
		}

		// Token: 0x0200023E RID: 574
		public sealed class GreaterThanOrEqualInt32 : GreaterThanOrEqualInstruction
		{
			// Token: 0x060017C8 RID: 6088 RVA: 0x00072BCC File Offset: 0x00070DCC
			// Note: this type is marked as 'beforefieldinit'.
			static GreaterThanOrEqualInt32()
			{
				Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualInt32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GreaterThanOrEqualInstruction>.NativeClassPtr, "GreaterThanOrEqualInt32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualInt32>.NativeClassPtr);
				GreaterThanOrEqualInstruction.GreaterThanOrEqualInt32.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualInt32>.NativeClassPtr, 100665208);
				GreaterThanOrEqualInstruction.GreaterThanOrEqualInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualInt32>.NativeClassPtr, 100665209);
			}

			// Token: 0x060017C9 RID: 6089 RVA: 0x00072C20 File Offset: 0x00070E20
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GreaterThanOrEqualInt32(Object nullValue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualInt32>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullValue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GreaterThanOrEqualInstruction.GreaterThanOrEqualInt32.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060017CA RID: 6090 RVA: 0x00072C6C File Offset: 0x00070E6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1017154, XrefRangeEnd = 1017163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GreaterThanOrEqualInstruction.GreaterThanOrEqualInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060017CB RID: 6091 RVA: 0x00009B6E File Offset: 0x00007D6E
			public GreaterThanOrEqualInt32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001075 RID: 4213
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

			// Token: 0x04001076 RID: 4214
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
		}

		// Token: 0x0200023F RID: 575
		public sealed class GreaterThanOrEqualInt64 : GreaterThanOrEqualInstruction
		{
			// Token: 0x060017CC RID: 6092 RVA: 0x00072CBC File Offset: 0x00070EBC
			// Note: this type is marked as 'beforefieldinit'.
			static GreaterThanOrEqualInt64()
			{
				Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualInt64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GreaterThanOrEqualInstruction>.NativeClassPtr, "GreaterThanOrEqualInt64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualInt64>.NativeClassPtr);
				GreaterThanOrEqualInstruction.GreaterThanOrEqualInt64.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualInt64>.NativeClassPtr, 100665210);
				GreaterThanOrEqualInstruction.GreaterThanOrEqualInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualInt64>.NativeClassPtr, 100665211);
			}

			// Token: 0x060017CD RID: 6093 RVA: 0x00072D10 File Offset: 0x00070F10
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GreaterThanOrEqualInt64(Object nullValue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualInt64>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullValue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GreaterThanOrEqualInstruction.GreaterThanOrEqualInt64.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060017CE RID: 6094 RVA: 0x00072D5C File Offset: 0x00070F5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1017163, XrefRangeEnd = 1017172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GreaterThanOrEqualInstruction.GreaterThanOrEqualInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060017CF RID: 6095 RVA: 0x00009B77 File Offset: 0x00007D77
			public GreaterThanOrEqualInt64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001077 RID: 4215
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

			// Token: 0x04001078 RID: 4216
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
		}

		// Token: 0x02000240 RID: 576
		public sealed class GreaterThanOrEqualByte : GreaterThanOrEqualInstruction
		{
			// Token: 0x060017D0 RID: 6096 RVA: 0x00072DAC File Offset: 0x00070FAC
			// Note: this type is marked as 'beforefieldinit'.
			static GreaterThanOrEqualByte()
			{
				Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualByte>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GreaterThanOrEqualInstruction>.NativeClassPtr, "GreaterThanOrEqualByte");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualByte>.NativeClassPtr);
				GreaterThanOrEqualInstruction.GreaterThanOrEqualByte.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualByte>.NativeClassPtr, 100665212);
				GreaterThanOrEqualInstruction.GreaterThanOrEqualByte.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualByte>.NativeClassPtr, 100665213);
			}

			// Token: 0x060017D1 RID: 6097 RVA: 0x00072E00 File Offset: 0x00071000
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GreaterThanOrEqualByte(Object nullValue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualByte>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullValue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GreaterThanOrEqualInstruction.GreaterThanOrEqualByte.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060017D2 RID: 6098 RVA: 0x00072E4C File Offset: 0x0007104C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1017172, XrefRangeEnd = 1017181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GreaterThanOrEqualInstruction.GreaterThanOrEqualByte.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060017D3 RID: 6099 RVA: 0x00009B80 File Offset: 0x00007D80
			public GreaterThanOrEqualByte(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001079 RID: 4217
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

			// Token: 0x0400107A RID: 4218
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
		}

		// Token: 0x02000241 RID: 577
		public sealed class GreaterThanOrEqualUInt16 : GreaterThanOrEqualInstruction
		{
			// Token: 0x060017D4 RID: 6100 RVA: 0x00072E9C File Offset: 0x0007109C
			// Note: this type is marked as 'beforefieldinit'.
			static GreaterThanOrEqualUInt16()
			{
				Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualUInt16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GreaterThanOrEqualInstruction>.NativeClassPtr, "GreaterThanOrEqualUInt16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualUInt16>.NativeClassPtr);
				GreaterThanOrEqualInstruction.GreaterThanOrEqualUInt16.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualUInt16>.NativeClassPtr, 100665214);
				GreaterThanOrEqualInstruction.GreaterThanOrEqualUInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualUInt16>.NativeClassPtr, 100665215);
			}

			// Token: 0x060017D5 RID: 6101 RVA: 0x00072EF0 File Offset: 0x000710F0
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GreaterThanOrEqualUInt16(Object nullValue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualUInt16>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullValue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GreaterThanOrEqualInstruction.GreaterThanOrEqualUInt16.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060017D6 RID: 6102 RVA: 0x00072F3C File Offset: 0x0007113C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1017181, XrefRangeEnd = 1017190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GreaterThanOrEqualInstruction.GreaterThanOrEqualUInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060017D7 RID: 6103 RVA: 0x00009B89 File Offset: 0x00007D89
			public GreaterThanOrEqualUInt16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400107B RID: 4219
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

			// Token: 0x0400107C RID: 4220
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
		}

		// Token: 0x02000242 RID: 578
		public sealed class GreaterThanOrEqualUInt32 : GreaterThanOrEqualInstruction
		{
			// Token: 0x060017D8 RID: 6104 RVA: 0x00072F8C File Offset: 0x0007118C
			// Note: this type is marked as 'beforefieldinit'.
			static GreaterThanOrEqualUInt32()
			{
				Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualUInt32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GreaterThanOrEqualInstruction>.NativeClassPtr, "GreaterThanOrEqualUInt32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualUInt32>.NativeClassPtr);
				GreaterThanOrEqualInstruction.GreaterThanOrEqualUInt32.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualUInt32>.NativeClassPtr, 100665216);
				GreaterThanOrEqualInstruction.GreaterThanOrEqualUInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualUInt32>.NativeClassPtr, 100665217);
			}

			// Token: 0x060017D9 RID: 6105 RVA: 0x00072FE0 File Offset: 0x000711E0
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GreaterThanOrEqualUInt32(Object nullValue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualUInt32>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullValue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GreaterThanOrEqualInstruction.GreaterThanOrEqualUInt32.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060017DA RID: 6106 RVA: 0x0007302C File Offset: 0x0007122C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1017190, XrefRangeEnd = 1017199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GreaterThanOrEqualInstruction.GreaterThanOrEqualUInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060017DB RID: 6107 RVA: 0x00009B92 File Offset: 0x00007D92
			public GreaterThanOrEqualUInt32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400107D RID: 4221
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

			// Token: 0x0400107E RID: 4222
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
		}

		// Token: 0x02000243 RID: 579
		public sealed class GreaterThanOrEqualUInt64 : GreaterThanOrEqualInstruction
		{
			// Token: 0x060017DC RID: 6108 RVA: 0x0007307C File Offset: 0x0007127C
			// Note: this type is marked as 'beforefieldinit'.
			static GreaterThanOrEqualUInt64()
			{
				Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualUInt64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GreaterThanOrEqualInstruction>.NativeClassPtr, "GreaterThanOrEqualUInt64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualUInt64>.NativeClassPtr);
				GreaterThanOrEqualInstruction.GreaterThanOrEqualUInt64.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualUInt64>.NativeClassPtr, 100665218);
				GreaterThanOrEqualInstruction.GreaterThanOrEqualUInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualUInt64>.NativeClassPtr, 100665219);
			}

			// Token: 0x060017DD RID: 6109 RVA: 0x000730D0 File Offset: 0x000712D0
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GreaterThanOrEqualUInt64(Object nullValue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualUInt64>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullValue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GreaterThanOrEqualInstruction.GreaterThanOrEqualUInt64.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060017DE RID: 6110 RVA: 0x0007311C File Offset: 0x0007131C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1017199, XrefRangeEnd = 1017208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GreaterThanOrEqualInstruction.GreaterThanOrEqualUInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060017DF RID: 6111 RVA: 0x00009B9B File Offset: 0x00007D9B
			public GreaterThanOrEqualUInt64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400107F RID: 4223
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

			// Token: 0x04001080 RID: 4224
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
		}

		// Token: 0x02000244 RID: 580
		public sealed class GreaterThanOrEqualSingle : GreaterThanOrEqualInstruction
		{
			// Token: 0x060017E0 RID: 6112 RVA: 0x0007316C File Offset: 0x0007136C
			// Note: this type is marked as 'beforefieldinit'.
			static GreaterThanOrEqualSingle()
			{
				Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualSingle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GreaterThanOrEqualInstruction>.NativeClassPtr, "GreaterThanOrEqualSingle");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualSingle>.NativeClassPtr);
				GreaterThanOrEqualInstruction.GreaterThanOrEqualSingle.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualSingle>.NativeClassPtr, 100665220);
				GreaterThanOrEqualInstruction.GreaterThanOrEqualSingle.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualSingle>.NativeClassPtr, 100665221);
			}

			// Token: 0x060017E1 RID: 6113 RVA: 0x000731C0 File Offset: 0x000713C0
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GreaterThanOrEqualSingle(Object nullValue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualSingle>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullValue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GreaterThanOrEqualInstruction.GreaterThanOrEqualSingle.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060017E2 RID: 6114 RVA: 0x0007320C File Offset: 0x0007140C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1017208, XrefRangeEnd = 1017217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GreaterThanOrEqualInstruction.GreaterThanOrEqualSingle.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060017E3 RID: 6115 RVA: 0x00009BA4 File Offset: 0x00007DA4
			public GreaterThanOrEqualSingle(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001081 RID: 4225
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

			// Token: 0x04001082 RID: 4226
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
		}

		// Token: 0x02000245 RID: 581
		public sealed class GreaterThanOrEqualDouble : GreaterThanOrEqualInstruction
		{
			// Token: 0x060017E4 RID: 6116 RVA: 0x0007325C File Offset: 0x0007145C
			// Note: this type is marked as 'beforefieldinit'.
			static GreaterThanOrEqualDouble()
			{
				Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualDouble>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GreaterThanOrEqualInstruction>.NativeClassPtr, "GreaterThanOrEqualDouble");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualDouble>.NativeClassPtr);
				GreaterThanOrEqualInstruction.GreaterThanOrEqualDouble.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualDouble>.NativeClassPtr, 100665222);
				GreaterThanOrEqualInstruction.GreaterThanOrEqualDouble.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualDouble>.NativeClassPtr, 100665223);
			}

			// Token: 0x060017E5 RID: 6117 RVA: 0x000732B0 File Offset: 0x000714B0
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GreaterThanOrEqualDouble(Object nullValue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GreaterThanOrEqualInstruction.GreaterThanOrEqualDouble>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullValue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GreaterThanOrEqualInstruction.GreaterThanOrEqualDouble.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060017E6 RID: 6118 RVA: 0x000732FC File Offset: 0x000714FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1017217, XrefRangeEnd = 1017226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GreaterThanOrEqualInstruction.GreaterThanOrEqualDouble.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060017E7 RID: 6119 RVA: 0x00009BAD File Offset: 0x00007DAD
			public GreaterThanOrEqualDouble(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001083 RID: 4227
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

			// Token: 0x04001084 RID: 4228
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
		}
	}
}
