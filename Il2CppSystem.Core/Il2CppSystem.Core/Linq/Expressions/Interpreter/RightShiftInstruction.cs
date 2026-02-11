using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000F4 RID: 244
	public class RightShiftInstruction : Instruction
	{
		// Token: 0x06000EE8 RID: 3816 RVA: 0x00050728 File Offset: 0x0004E928
		// Note: this type is marked as 'beforefieldinit'.
		static RightShiftInstruction()
		{
			Il2CppClassPointerStore<RightShiftInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "RightShiftInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RightShiftInstruction>.NativeClassPtr);
			RightShiftInstruction.NativeFieldInfoPtr_s_SByte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RightShiftInstruction>.NativeClassPtr, "s_SByte");
			RightShiftInstruction.NativeFieldInfoPtr_s_Int16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RightShiftInstruction>.NativeClassPtr, "s_Int16");
			RightShiftInstruction.NativeFieldInfoPtr_s_Int32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RightShiftInstruction>.NativeClassPtr, "s_Int32");
			RightShiftInstruction.NativeFieldInfoPtr_s_Int64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RightShiftInstruction>.NativeClassPtr, "s_Int64");
			RightShiftInstruction.NativeFieldInfoPtr_s_Byte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RightShiftInstruction>.NativeClassPtr, "s_Byte");
			RightShiftInstruction.NativeFieldInfoPtr_s_UInt16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RightShiftInstruction>.NativeClassPtr, "s_UInt16");
			RightShiftInstruction.NativeFieldInfoPtr_s_UInt32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RightShiftInstruction>.NativeClassPtr, "s_UInt32");
			RightShiftInstruction.NativeFieldInfoPtr_s_UInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RightShiftInstruction>.NativeClassPtr, "s_UInt64");
			RightShiftInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightShiftInstruction>.NativeClassPtr, 100666077);
			RightShiftInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightShiftInstruction>.NativeClassPtr, 100666078);
			RightShiftInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightShiftInstruction>.NativeClassPtr, 100666079);
			RightShiftInstruction.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightShiftInstruction>.NativeClassPtr, 100666080);
			RightShiftInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightShiftInstruction>.NativeClassPtr, 100666081);
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06000EE9 RID: 3817 RVA: 0x0005085C File Offset: 0x0004EA5C
		public unsafe override int ConsumedStack
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 72978, RefRangeEnd = 72985, XrefRangeStart = 72978, XrefRangeEnd = 72985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RightShiftInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06000EEA RID: 3818 RVA: 0x000508A4 File Offset: 0x0004EAA4
		public unsafe override int ProducedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RightShiftInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06000EEB RID: 3819 RVA: 0x000508EC File Offset: 0x0004EAEC
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026285, XrefRangeEnd = 1026287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RightShiftInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000EEC RID: 3820 RVA: 0x00050930 File Offset: 0x0004EB30
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RightShiftInstruction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RightShiftInstruction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightShiftInstruction.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EED RID: 3821 RVA: 0x0005096C File Offset: 0x0004EB6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1026311, RefRangeEnd = 1026312, XrefRangeStart = 1026287, XrefRangeEnd = 1026311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Instruction Create(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightShiftInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x0000698E File Offset: 0x00004B8E
		public RightShiftInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06000EEF RID: 3823 RVA: 0x000509B0 File Offset: 0x0004EBB0
		// (set) Token: 0x06000EF0 RID: 3824 RVA: 0x00006997 File Offset: 0x00004B97
		public unsafe static Instruction s_SByte
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RightShiftInstruction.NativeFieldInfoPtr_s_SByte, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RightShiftInstruction.NativeFieldInfoPtr_s_SByte, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06000EF1 RID: 3825 RVA: 0x000509D8 File Offset: 0x0004EBD8
		// (set) Token: 0x06000EF2 RID: 3826 RVA: 0x000069A9 File Offset: 0x00004BA9
		public unsafe static Instruction s_Int16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RightShiftInstruction.NativeFieldInfoPtr_s_Int16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RightShiftInstruction.NativeFieldInfoPtr_s_Int16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06000EF3 RID: 3827 RVA: 0x00050A00 File Offset: 0x0004EC00
		// (set) Token: 0x06000EF4 RID: 3828 RVA: 0x000069BB File Offset: 0x00004BBB
		public unsafe static Instruction s_Int32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RightShiftInstruction.NativeFieldInfoPtr_s_Int32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RightShiftInstruction.NativeFieldInfoPtr_s_Int32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06000EF5 RID: 3829 RVA: 0x00050A28 File Offset: 0x0004EC28
		// (set) Token: 0x06000EF6 RID: 3830 RVA: 0x000069CD File Offset: 0x00004BCD
		public unsafe static Instruction s_Int64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RightShiftInstruction.NativeFieldInfoPtr_s_Int64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RightShiftInstruction.NativeFieldInfoPtr_s_Int64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06000EF7 RID: 3831 RVA: 0x00050A50 File Offset: 0x0004EC50
		// (set) Token: 0x06000EF8 RID: 3832 RVA: 0x000069DF File Offset: 0x00004BDF
		public unsafe static Instruction s_Byte
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RightShiftInstruction.NativeFieldInfoPtr_s_Byte, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RightShiftInstruction.NativeFieldInfoPtr_s_Byte, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06000EF9 RID: 3833 RVA: 0x00050A78 File Offset: 0x0004EC78
		// (set) Token: 0x06000EFA RID: 3834 RVA: 0x000069F1 File Offset: 0x00004BF1
		public unsafe static Instruction s_UInt16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RightShiftInstruction.NativeFieldInfoPtr_s_UInt16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RightShiftInstruction.NativeFieldInfoPtr_s_UInt16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06000EFB RID: 3835 RVA: 0x00050AA0 File Offset: 0x0004ECA0
		// (set) Token: 0x06000EFC RID: 3836 RVA: 0x00006A03 File Offset: 0x00004C03
		public unsafe static Instruction s_UInt32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RightShiftInstruction.NativeFieldInfoPtr_s_UInt32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RightShiftInstruction.NativeFieldInfoPtr_s_UInt32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06000EFD RID: 3837 RVA: 0x00050AC8 File Offset: 0x0004ECC8
		// (set) Token: 0x06000EFE RID: 3838 RVA: 0x00006A15 File Offset: 0x00004C15
		public unsafe static Instruction s_UInt64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RightShiftInstruction.NativeFieldInfoPtr_s_UInt64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RightShiftInstruction.NativeFieldInfoPtr_s_UInt64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AD2 RID: 2770
		private static readonly IntPtr NativeFieldInfoPtr_s_SByte;

		// Token: 0x04000AD3 RID: 2771
		private static readonly IntPtr NativeFieldInfoPtr_s_Int16;

		// Token: 0x04000AD4 RID: 2772
		private static readonly IntPtr NativeFieldInfoPtr_s_Int32;

		// Token: 0x04000AD5 RID: 2773
		private static readonly IntPtr NativeFieldInfoPtr_s_Int64;

		// Token: 0x04000AD6 RID: 2774
		private static readonly IntPtr NativeFieldInfoPtr_s_Byte;

		// Token: 0x04000AD7 RID: 2775
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt16;

		// Token: 0x04000AD8 RID: 2776
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt32;

		// Token: 0x04000AD9 RID: 2777
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt64;

		// Token: 0x04000ADA RID: 2778
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000ADB RID: 2779
		private static readonly IntPtr NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000ADC RID: 2780
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x04000ADD RID: 2781
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000ADE RID: 2782
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0;

		// Token: 0x0200030B RID: 779
		public sealed class RightShiftSByte : RightShiftInstruction
		{
			// Token: 0x06001A9B RID: 6811 RVA: 0x0007F3C4 File Offset: 0x0007D5C4
			// Note: this type is marked as 'beforefieldinit'.
			static RightShiftSByte()
			{
				Il2CppClassPointerStore<RightShiftInstruction.RightShiftSByte>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RightShiftInstruction>.NativeClassPtr, "RightShiftSByte");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RightShiftInstruction.RightShiftSByte>.NativeClassPtr);
				RightShiftInstruction.RightShiftSByte.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightShiftInstruction.RightShiftSByte>.NativeClassPtr, 100666082);
				RightShiftInstruction.RightShiftSByte.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightShiftInstruction.RightShiftSByte>.NativeClassPtr, 100666083);
			}

			// Token: 0x06001A9C RID: 6812 RVA: 0x0007F418 File Offset: 0x0007D618
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026195, XrefRangeEnd = 1026206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightShiftInstruction.RightShiftSByte.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001A9D RID: 6813 RVA: 0x0007F468 File Offset: 0x0007D668
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RightShiftSByte()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RightShiftInstruction.RightShiftSByte>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightShiftInstruction.RightShiftSByte.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A9E RID: 6814 RVA: 0x0000A3E7 File Offset: 0x000085E7
			public RightShiftSByte(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001214 RID: 4628
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001215 RID: 4629
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200030C RID: 780
		public sealed class RightShiftInt16 : RightShiftInstruction
		{
			// Token: 0x06001A9F RID: 6815 RVA: 0x0007F4A4 File Offset: 0x0007D6A4
			// Note: this type is marked as 'beforefieldinit'.
			static RightShiftInt16()
			{
				Il2CppClassPointerStore<RightShiftInstruction.RightShiftInt16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RightShiftInstruction>.NativeClassPtr, "RightShiftInt16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RightShiftInstruction.RightShiftInt16>.NativeClassPtr);
				RightShiftInstruction.RightShiftInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightShiftInstruction.RightShiftInt16>.NativeClassPtr, 100666084);
				RightShiftInstruction.RightShiftInt16.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightShiftInstruction.RightShiftInt16>.NativeClassPtr, 100666085);
			}

			// Token: 0x06001AA0 RID: 6816 RVA: 0x0007F4F8 File Offset: 0x0007D6F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026206, XrefRangeEnd = 1026217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightShiftInstruction.RightShiftInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001AA1 RID: 6817 RVA: 0x0007F548 File Offset: 0x0007D748
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RightShiftInt16()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RightShiftInstruction.RightShiftInt16>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightShiftInstruction.RightShiftInt16.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AA2 RID: 6818 RVA: 0x0000A3F0 File Offset: 0x000085F0
			public RightShiftInt16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001216 RID: 4630
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001217 RID: 4631
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200030D RID: 781
		public sealed class RightShiftInt32 : RightShiftInstruction
		{
			// Token: 0x06001AA3 RID: 6819 RVA: 0x0007F584 File Offset: 0x0007D784
			// Note: this type is marked as 'beforefieldinit'.
			static RightShiftInt32()
			{
				Il2CppClassPointerStore<RightShiftInstruction.RightShiftInt32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RightShiftInstruction>.NativeClassPtr, "RightShiftInt32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RightShiftInstruction.RightShiftInt32>.NativeClassPtr);
				RightShiftInstruction.RightShiftInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightShiftInstruction.RightShiftInt32>.NativeClassPtr, 100666086);
				RightShiftInstruction.RightShiftInt32.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightShiftInstruction.RightShiftInt32>.NativeClassPtr, 100666087);
			}

			// Token: 0x06001AA4 RID: 6820 RVA: 0x0007F5D8 File Offset: 0x0007D7D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026217, XrefRangeEnd = 1026227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightShiftInstruction.RightShiftInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001AA5 RID: 6821 RVA: 0x0007F628 File Offset: 0x0007D828
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RightShiftInt32()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RightShiftInstruction.RightShiftInt32>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightShiftInstruction.RightShiftInt32.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AA6 RID: 6822 RVA: 0x0000A3F9 File Offset: 0x000085F9
			public RightShiftInt32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001218 RID: 4632
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001219 RID: 4633
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200030E RID: 782
		public sealed class RightShiftInt64 : RightShiftInstruction
		{
			// Token: 0x06001AA7 RID: 6823 RVA: 0x0007F664 File Offset: 0x0007D864
			// Note: this type is marked as 'beforefieldinit'.
			static RightShiftInt64()
			{
				Il2CppClassPointerStore<RightShiftInstruction.RightShiftInt64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RightShiftInstruction>.NativeClassPtr, "RightShiftInt64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RightShiftInstruction.RightShiftInt64>.NativeClassPtr);
				RightShiftInstruction.RightShiftInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightShiftInstruction.RightShiftInt64>.NativeClassPtr, 100666088);
				RightShiftInstruction.RightShiftInt64.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightShiftInstruction.RightShiftInt64>.NativeClassPtr, 100666089);
			}

			// Token: 0x06001AA8 RID: 6824 RVA: 0x0007F6B8 File Offset: 0x0007D8B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026227, XrefRangeEnd = 1026239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightShiftInstruction.RightShiftInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001AA9 RID: 6825 RVA: 0x0007F708 File Offset: 0x0007D908
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RightShiftInt64()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RightShiftInstruction.RightShiftInt64>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightShiftInstruction.RightShiftInt64.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AAA RID: 6826 RVA: 0x0000A402 File Offset: 0x00008602
			public RightShiftInt64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400121A RID: 4634
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x0400121B RID: 4635
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200030F RID: 783
		public sealed class RightShiftByte : RightShiftInstruction
		{
			// Token: 0x06001AAB RID: 6827 RVA: 0x0007F744 File Offset: 0x0007D944
			// Note: this type is marked as 'beforefieldinit'.
			static RightShiftByte()
			{
				Il2CppClassPointerStore<RightShiftInstruction.RightShiftByte>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RightShiftInstruction>.NativeClassPtr, "RightShiftByte");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RightShiftInstruction.RightShiftByte>.NativeClassPtr);
				RightShiftInstruction.RightShiftByte.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightShiftInstruction.RightShiftByte>.NativeClassPtr, 100666090);
				RightShiftInstruction.RightShiftByte.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightShiftInstruction.RightShiftByte>.NativeClassPtr, 100666091);
			}

			// Token: 0x06001AAC RID: 6828 RVA: 0x0007F798 File Offset: 0x0007D998
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026239, XrefRangeEnd = 1026250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightShiftInstruction.RightShiftByte.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001AAD RID: 6829 RVA: 0x0007F7E8 File Offset: 0x0007D9E8
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RightShiftByte()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RightShiftInstruction.RightShiftByte>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightShiftInstruction.RightShiftByte.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AAE RID: 6830 RVA: 0x0000A40B File Offset: 0x0000860B
			public RightShiftByte(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400121C RID: 4636
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x0400121D RID: 4637
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000310 RID: 784
		public sealed class RightShiftUInt16 : RightShiftInstruction
		{
			// Token: 0x06001AAF RID: 6831 RVA: 0x0007F824 File Offset: 0x0007DA24
			// Note: this type is marked as 'beforefieldinit'.
			static RightShiftUInt16()
			{
				Il2CppClassPointerStore<RightShiftInstruction.RightShiftUInt16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RightShiftInstruction>.NativeClassPtr, "RightShiftUInt16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RightShiftInstruction.RightShiftUInt16>.NativeClassPtr);
				RightShiftInstruction.RightShiftUInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightShiftInstruction.RightShiftUInt16>.NativeClassPtr, 100666092);
				RightShiftInstruction.RightShiftUInt16.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightShiftInstruction.RightShiftUInt16>.NativeClassPtr, 100666093);
			}

			// Token: 0x06001AB0 RID: 6832 RVA: 0x0007F878 File Offset: 0x0007DA78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026250, XrefRangeEnd = 1026261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightShiftInstruction.RightShiftUInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001AB1 RID: 6833 RVA: 0x0007F8C8 File Offset: 0x0007DAC8
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RightShiftUInt16()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RightShiftInstruction.RightShiftUInt16>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightShiftInstruction.RightShiftUInt16.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AB2 RID: 6834 RVA: 0x0000A414 File Offset: 0x00008614
			public RightShiftUInt16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400121E RID: 4638
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x0400121F RID: 4639
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000311 RID: 785
		public sealed class RightShiftUInt32 : RightShiftInstruction
		{
			// Token: 0x06001AB3 RID: 6835 RVA: 0x0007F904 File Offset: 0x0007DB04
			// Note: this type is marked as 'beforefieldinit'.
			static RightShiftUInt32()
			{
				Il2CppClassPointerStore<RightShiftInstruction.RightShiftUInt32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RightShiftInstruction>.NativeClassPtr, "RightShiftUInt32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RightShiftInstruction.RightShiftUInt32>.NativeClassPtr);
				RightShiftInstruction.RightShiftUInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightShiftInstruction.RightShiftUInt32>.NativeClassPtr, 100666094);
				RightShiftInstruction.RightShiftUInt32.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightShiftInstruction.RightShiftUInt32>.NativeClassPtr, 100666095);
			}

			// Token: 0x06001AB4 RID: 6836 RVA: 0x0007F958 File Offset: 0x0007DB58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026261, XrefRangeEnd = 1026273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightShiftInstruction.RightShiftUInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001AB5 RID: 6837 RVA: 0x0007F9A8 File Offset: 0x0007DBA8
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RightShiftUInt32()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RightShiftInstruction.RightShiftUInt32>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightShiftInstruction.RightShiftUInt32.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AB6 RID: 6838 RVA: 0x0000A41D File Offset: 0x0000861D
			public RightShiftUInt32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001220 RID: 4640
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001221 RID: 4641
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000312 RID: 786
		public sealed class RightShiftUInt64 : RightShiftInstruction
		{
			// Token: 0x06001AB7 RID: 6839 RVA: 0x0007F9E4 File Offset: 0x0007DBE4
			// Note: this type is marked as 'beforefieldinit'.
			static RightShiftUInt64()
			{
				Il2CppClassPointerStore<RightShiftInstruction.RightShiftUInt64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RightShiftInstruction>.NativeClassPtr, "RightShiftUInt64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RightShiftInstruction.RightShiftUInt64>.NativeClassPtr);
				RightShiftInstruction.RightShiftUInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightShiftInstruction.RightShiftUInt64>.NativeClassPtr, 100666096);
				RightShiftInstruction.RightShiftUInt64.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightShiftInstruction.RightShiftUInt64>.NativeClassPtr, 100666097);
			}

			// Token: 0x06001AB8 RID: 6840 RVA: 0x0007FA38 File Offset: 0x0007DC38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026273, XrefRangeEnd = 1026285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightShiftInstruction.RightShiftUInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001AB9 RID: 6841 RVA: 0x0007FA88 File Offset: 0x0007DC88
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RightShiftUInt64()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RightShiftInstruction.RightShiftUInt64>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RightShiftInstruction.RightShiftUInt64.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001ABA RID: 6842 RVA: 0x0000A426 File Offset: 0x00008626
			public RightShiftUInt64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001222 RID: 4642
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001223 RID: 4643
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
