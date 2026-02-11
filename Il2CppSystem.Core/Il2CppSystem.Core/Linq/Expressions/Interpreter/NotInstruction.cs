using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000F0 RID: 240
	public class NotInstruction : Instruction
	{
		// Token: 0x06000E9E RID: 3742 RVA: 0x0004F97C File Offset: 0x0004DB7C
		// Note: this type is marked as 'beforefieldinit'.
		static NotInstruction()
		{
			Il2CppClassPointerStore<NotInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "NotInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotInstruction>.NativeClassPtr);
			NotInstruction.NativeFieldInfoPtr_s_Boolean = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotInstruction>.NativeClassPtr, "s_Boolean");
			NotInstruction.NativeFieldInfoPtr_s_Int64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotInstruction>.NativeClassPtr, "s_Int64");
			NotInstruction.NativeFieldInfoPtr_s_Int32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotInstruction>.NativeClassPtr, "s_Int32");
			NotInstruction.NativeFieldInfoPtr_s_Int16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotInstruction>.NativeClassPtr, "s_Int16");
			NotInstruction.NativeFieldInfoPtr_s_UInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotInstruction>.NativeClassPtr, "s_UInt64");
			NotInstruction.NativeFieldInfoPtr_s_UInt32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotInstruction>.NativeClassPtr, "s_UInt32");
			NotInstruction.NativeFieldInfoPtr_s_UInt16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotInstruction>.NativeClassPtr, "s_UInt16");
			NotInstruction.NativeFieldInfoPtr_s_Byte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotInstruction>.NativeClassPtr, "s_Byte");
			NotInstruction.NativeFieldInfoPtr_s_SByte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotInstruction>.NativeClassPtr, "s_SByte");
			NotInstruction.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotInstruction>.NativeClassPtr, 100666001);
			NotInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotInstruction>.NativeClassPtr, 100666002);
			NotInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotInstruction>.NativeClassPtr, 100666003);
			NotInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotInstruction>.NativeClassPtr, 100666004);
			NotInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotInstruction>.NativeClassPtr, 100666005);
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x0004FAC4 File Offset: 0x0004DCC4
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NotInstruction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotInstruction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotInstruction.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06000EA0 RID: 3744 RVA: 0x0004FB00 File Offset: 0x0004DD00
		public unsafe override int ConsumedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NotInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06000EA1 RID: 3745 RVA: 0x0004FB48 File Offset: 0x0004DD48
		public unsafe override int ProducedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NotInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06000EA2 RID: 3746 RVA: 0x0004FB90 File Offset: 0x0004DD90
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025744, XrefRangeEnd = 1025746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NotInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x0004FBD4 File Offset: 0x0004DDD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1025771, RefRangeEnd = 1025773, XrefRangeStart = 1025746, XrefRangeEnd = 1025771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Instruction Create(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x000067C3 File Offset: 0x000049C3
		public NotInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06000EA5 RID: 3749 RVA: 0x0004FC18 File Offset: 0x0004DE18
		// (set) Token: 0x06000EA6 RID: 3750 RVA: 0x000067CC File Offset: 0x000049CC
		public unsafe static Instruction s_Boolean
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NotInstruction.NativeFieldInfoPtr_s_Boolean, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NotInstruction.NativeFieldInfoPtr_s_Boolean, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06000EA7 RID: 3751 RVA: 0x0004FC40 File Offset: 0x0004DE40
		// (set) Token: 0x06000EA8 RID: 3752 RVA: 0x000067DE File Offset: 0x000049DE
		public unsafe static Instruction s_Int64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NotInstruction.NativeFieldInfoPtr_s_Int64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NotInstruction.NativeFieldInfoPtr_s_Int64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06000EA9 RID: 3753 RVA: 0x0004FC68 File Offset: 0x0004DE68
		// (set) Token: 0x06000EAA RID: 3754 RVA: 0x000067F0 File Offset: 0x000049F0
		public unsafe static Instruction s_Int32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NotInstruction.NativeFieldInfoPtr_s_Int32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NotInstruction.NativeFieldInfoPtr_s_Int32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06000EAB RID: 3755 RVA: 0x0004FC90 File Offset: 0x0004DE90
		// (set) Token: 0x06000EAC RID: 3756 RVA: 0x00006802 File Offset: 0x00004A02
		public unsafe static Instruction s_Int16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NotInstruction.NativeFieldInfoPtr_s_Int16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NotInstruction.NativeFieldInfoPtr_s_Int16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06000EAD RID: 3757 RVA: 0x0004FCB8 File Offset: 0x0004DEB8
		// (set) Token: 0x06000EAE RID: 3758 RVA: 0x00006814 File Offset: 0x00004A14
		public unsafe static Instruction s_UInt64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NotInstruction.NativeFieldInfoPtr_s_UInt64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NotInstruction.NativeFieldInfoPtr_s_UInt64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06000EAF RID: 3759 RVA: 0x0004FCE0 File Offset: 0x0004DEE0
		// (set) Token: 0x06000EB0 RID: 3760 RVA: 0x00006826 File Offset: 0x00004A26
		public unsafe static Instruction s_UInt32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NotInstruction.NativeFieldInfoPtr_s_UInt32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NotInstruction.NativeFieldInfoPtr_s_UInt32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06000EB1 RID: 3761 RVA: 0x0004FD08 File Offset: 0x0004DF08
		// (set) Token: 0x06000EB2 RID: 3762 RVA: 0x00006838 File Offset: 0x00004A38
		public unsafe static Instruction s_UInt16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NotInstruction.NativeFieldInfoPtr_s_UInt16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NotInstruction.NativeFieldInfoPtr_s_UInt16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06000EB3 RID: 3763 RVA: 0x0004FD30 File Offset: 0x0004DF30
		// (set) Token: 0x06000EB4 RID: 3764 RVA: 0x0000684A File Offset: 0x00004A4A
		public unsafe static Instruction s_Byte
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NotInstruction.NativeFieldInfoPtr_s_Byte, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NotInstruction.NativeFieldInfoPtr_s_Byte, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06000EB5 RID: 3765 RVA: 0x0004FD58 File Offset: 0x0004DF58
		// (set) Token: 0x06000EB6 RID: 3766 RVA: 0x0000685C File Offset: 0x00004A5C
		public unsafe static Instruction s_SByte
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NotInstruction.NativeFieldInfoPtr_s_SByte, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NotInstruction.NativeFieldInfoPtr_s_SByte, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AA6 RID: 2726
		private static readonly IntPtr NativeFieldInfoPtr_s_Boolean;

		// Token: 0x04000AA7 RID: 2727
		private static readonly IntPtr NativeFieldInfoPtr_s_Int64;

		// Token: 0x04000AA8 RID: 2728
		private static readonly IntPtr NativeFieldInfoPtr_s_Int32;

		// Token: 0x04000AA9 RID: 2729
		private static readonly IntPtr NativeFieldInfoPtr_s_Int16;

		// Token: 0x04000AAA RID: 2730
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt64;

		// Token: 0x04000AAB RID: 2731
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt32;

		// Token: 0x04000AAC RID: 2732
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt16;

		// Token: 0x04000AAD RID: 2733
		private static readonly IntPtr NativeFieldInfoPtr_s_Byte;

		// Token: 0x04000AAE RID: 2734
		private static readonly IntPtr NativeFieldInfoPtr_s_SByte;

		// Token: 0x04000AAF RID: 2735
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000AB0 RID: 2736
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000AB1 RID: 2737
		private static readonly IntPtr NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000AB2 RID: 2738
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x04000AB3 RID: 2739
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0;

		// Token: 0x020002F6 RID: 758
		public sealed class NotBoolean : NotInstruction
		{
			// Token: 0x06001A3C RID: 6716 RVA: 0x0007DD14 File Offset: 0x0007BF14
			// Note: this type is marked as 'beforefieldinit'.
			static NotBoolean()
			{
				Il2CppClassPointerStore<NotInstruction.NotBoolean>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NotInstruction>.NativeClassPtr, "NotBoolean");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotInstruction.NotBoolean>.NativeClassPtr);
				NotInstruction.NotBoolean.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotInstruction.NotBoolean>.NativeClassPtr, 100666006);
				NotInstruction.NotBoolean.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotInstruction.NotBoolean>.NativeClassPtr, 100666007);
			}

			// Token: 0x06001A3D RID: 6717 RVA: 0x0007DD68 File Offset: 0x0007BF68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025690, XrefRangeEnd = 1025695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotInstruction.NotBoolean.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001A3E RID: 6718 RVA: 0x0007DDB8 File Offset: 0x0007BFB8
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NotBoolean()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotInstruction.NotBoolean>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotInstruction.NotBoolean.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A3F RID: 6719 RVA: 0x0000A32A File Offset: 0x0000852A
			public NotBoolean(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040011DF RID: 4575
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x040011E0 RID: 4576
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002F7 RID: 759
		public sealed class NotInt64 : NotInstruction
		{
			// Token: 0x06001A40 RID: 6720 RVA: 0x0007DDF4 File Offset: 0x0007BFF4
			// Note: this type is marked as 'beforefieldinit'.
			static NotInt64()
			{
				Il2CppClassPointerStore<NotInstruction.NotInt64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NotInstruction>.NativeClassPtr, "NotInt64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotInstruction.NotInt64>.NativeClassPtr);
				NotInstruction.NotInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotInstruction.NotInt64>.NativeClassPtr, 100666008);
				NotInstruction.NotInt64.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotInstruction.NotInt64>.NativeClassPtr, 100666009);
			}

			// Token: 0x06001A41 RID: 6721 RVA: 0x0007DE48 File Offset: 0x0007C048
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025695, XrefRangeEnd = 1025703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotInstruction.NotInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001A42 RID: 6722 RVA: 0x0007DE98 File Offset: 0x0007C098
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NotInt64()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotInstruction.NotInt64>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotInstruction.NotInt64.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A43 RID: 6723 RVA: 0x0000A333 File Offset: 0x00008533
			public NotInt64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040011E1 RID: 4577
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x040011E2 RID: 4578
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002F8 RID: 760
		public sealed class NotInt32 : NotInstruction
		{
			// Token: 0x06001A44 RID: 6724 RVA: 0x0007DED4 File Offset: 0x0007C0D4
			// Note: this type is marked as 'beforefieldinit'.
			static NotInt32()
			{
				Il2CppClassPointerStore<NotInstruction.NotInt32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NotInstruction>.NativeClassPtr, "NotInt32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotInstruction.NotInt32>.NativeClassPtr);
				NotInstruction.NotInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotInstruction.NotInt32>.NativeClassPtr, 100666010);
				NotInstruction.NotInt32.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotInstruction.NotInt32>.NativeClassPtr, 100666011);
			}

			// Token: 0x06001A45 RID: 6725 RVA: 0x0007DF28 File Offset: 0x0007C128
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025703, XrefRangeEnd = 1025708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotInstruction.NotInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001A46 RID: 6726 RVA: 0x0007DF78 File Offset: 0x0007C178
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NotInt32()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotInstruction.NotInt32>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotInstruction.NotInt32.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A47 RID: 6727 RVA: 0x0000A33C File Offset: 0x0000853C
			public NotInt32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040011E3 RID: 4579
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x040011E4 RID: 4580
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002F9 RID: 761
		public sealed class NotInt16 : NotInstruction
		{
			// Token: 0x06001A48 RID: 6728 RVA: 0x0007DFB4 File Offset: 0x0007C1B4
			// Note: this type is marked as 'beforefieldinit'.
			static NotInt16()
			{
				Il2CppClassPointerStore<NotInstruction.NotInt16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NotInstruction>.NativeClassPtr, "NotInt16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotInstruction.NotInt16>.NativeClassPtr);
				NotInstruction.NotInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotInstruction.NotInt16>.NativeClassPtr, 100666012);
				NotInstruction.NotInt16.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotInstruction.NotInt16>.NativeClassPtr, 100666013);
			}

			// Token: 0x06001A49 RID: 6729 RVA: 0x0007E008 File Offset: 0x0007C208
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025708, XrefRangeEnd = 1025713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotInstruction.NotInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001A4A RID: 6730 RVA: 0x0007E058 File Offset: 0x0007C258
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NotInt16()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotInstruction.NotInt16>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotInstruction.NotInt16.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A4B RID: 6731 RVA: 0x0000A345 File Offset: 0x00008545
			public NotInt16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040011E5 RID: 4581
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x040011E6 RID: 4582
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002FA RID: 762
		public sealed class NotUInt64 : NotInstruction
		{
			// Token: 0x06001A4C RID: 6732 RVA: 0x0007E094 File Offset: 0x0007C294
			// Note: this type is marked as 'beforefieldinit'.
			static NotUInt64()
			{
				Il2CppClassPointerStore<NotInstruction.NotUInt64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NotInstruction>.NativeClassPtr, "NotUInt64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotInstruction.NotUInt64>.NativeClassPtr);
				NotInstruction.NotUInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotInstruction.NotUInt64>.NativeClassPtr, 100666014);
				NotInstruction.NotUInt64.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotInstruction.NotUInt64>.NativeClassPtr, 100666015);
			}

			// Token: 0x06001A4D RID: 6733 RVA: 0x0007E0E8 File Offset: 0x0007C2E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025713, XrefRangeEnd = 1025721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotInstruction.NotUInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001A4E RID: 6734 RVA: 0x0007E138 File Offset: 0x0007C338
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NotUInt64()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotInstruction.NotUInt64>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotInstruction.NotUInt64.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A4F RID: 6735 RVA: 0x0000A34E File Offset: 0x0000854E
			public NotUInt64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040011E7 RID: 4583
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x040011E8 RID: 4584
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002FB RID: 763
		public sealed class NotUInt32 : NotInstruction
		{
			// Token: 0x06001A50 RID: 6736 RVA: 0x0007E174 File Offset: 0x0007C374
			// Note: this type is marked as 'beforefieldinit'.
			static NotUInt32()
			{
				Il2CppClassPointerStore<NotInstruction.NotUInt32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NotInstruction>.NativeClassPtr, "NotUInt32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotInstruction.NotUInt32>.NativeClassPtr);
				NotInstruction.NotUInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotInstruction.NotUInt32>.NativeClassPtr, 100666016);
				NotInstruction.NotUInt32.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotInstruction.NotUInt32>.NativeClassPtr, 100666017);
			}

			// Token: 0x06001A51 RID: 6737 RVA: 0x0007E1C8 File Offset: 0x0007C3C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025721, XrefRangeEnd = 1025729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotInstruction.NotUInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001A52 RID: 6738 RVA: 0x0007E218 File Offset: 0x0007C418
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NotUInt32()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotInstruction.NotUInt32>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotInstruction.NotUInt32.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A53 RID: 6739 RVA: 0x0000A357 File Offset: 0x00008557
			public NotUInt32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040011E9 RID: 4585
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x040011EA RID: 4586
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002FC RID: 764
		public sealed class NotUInt16 : NotInstruction
		{
			// Token: 0x06001A54 RID: 6740 RVA: 0x0007E254 File Offset: 0x0007C454
			// Note: this type is marked as 'beforefieldinit'.
			static NotUInt16()
			{
				Il2CppClassPointerStore<NotInstruction.NotUInt16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NotInstruction>.NativeClassPtr, "NotUInt16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotInstruction.NotUInt16>.NativeClassPtr);
				NotInstruction.NotUInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotInstruction.NotUInt16>.NativeClassPtr, 100666018);
				NotInstruction.NotUInt16.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotInstruction.NotUInt16>.NativeClassPtr, 100666019);
			}

			// Token: 0x06001A55 RID: 6741 RVA: 0x0007E2A8 File Offset: 0x0007C4A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025729, XrefRangeEnd = 1025734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotInstruction.NotUInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001A56 RID: 6742 RVA: 0x0007E2F8 File Offset: 0x0007C4F8
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NotUInt16()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotInstruction.NotUInt16>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotInstruction.NotUInt16.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A57 RID: 6743 RVA: 0x0000A360 File Offset: 0x00008560
			public NotUInt16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040011EB RID: 4587
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x040011EC RID: 4588
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002FD RID: 765
		public sealed class NotByte : NotInstruction
		{
			// Token: 0x06001A58 RID: 6744 RVA: 0x0007E334 File Offset: 0x0007C534
			// Note: this type is marked as 'beforefieldinit'.
			static NotByte()
			{
				Il2CppClassPointerStore<NotInstruction.NotByte>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NotInstruction>.NativeClassPtr, "NotByte");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotInstruction.NotByte>.NativeClassPtr);
				NotInstruction.NotByte.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotInstruction.NotByte>.NativeClassPtr, 100666020);
				NotInstruction.NotByte.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotInstruction.NotByte>.NativeClassPtr, 100666021);
			}

			// Token: 0x06001A59 RID: 6745 RVA: 0x0007E388 File Offset: 0x0007C588
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025734, XrefRangeEnd = 1025739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotInstruction.NotByte.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001A5A RID: 6746 RVA: 0x0007E3D8 File Offset: 0x0007C5D8
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NotByte()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotInstruction.NotByte>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotInstruction.NotByte.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A5B RID: 6747 RVA: 0x0000A369 File Offset: 0x00008569
			public NotByte(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040011ED RID: 4589
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x040011EE RID: 4590
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002FE RID: 766
		public sealed class NotSByte : NotInstruction
		{
			// Token: 0x06001A5C RID: 6748 RVA: 0x0007E414 File Offset: 0x0007C614
			// Note: this type is marked as 'beforefieldinit'.
			static NotSByte()
			{
				Il2CppClassPointerStore<NotInstruction.NotSByte>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NotInstruction>.NativeClassPtr, "NotSByte");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotInstruction.NotSByte>.NativeClassPtr);
				NotInstruction.NotSByte.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotInstruction.NotSByte>.NativeClassPtr, 100666022);
				NotInstruction.NotSByte.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotInstruction.NotSByte>.NativeClassPtr, 100666023);
			}

			// Token: 0x06001A5D RID: 6749 RVA: 0x0007E468 File Offset: 0x0007C668
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025739, XrefRangeEnd = 1025744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotInstruction.NotSByte.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001A5E RID: 6750 RVA: 0x0007E4B8 File Offset: 0x0007C6B8
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NotSByte()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotInstruction.NotSByte>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotInstruction.NotSByte.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A5F RID: 6751 RVA: 0x0000A372 File Offset: 0x00008572
			public NotSByte(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040011EF RID: 4591
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x040011F0 RID: 4592
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
