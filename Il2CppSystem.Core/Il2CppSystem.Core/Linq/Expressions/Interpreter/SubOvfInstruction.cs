using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000FB RID: 251
	public class SubOvfInstruction : Instruction
	{
		// Token: 0x06000F3F RID: 3903 RVA: 0x00051820 File Offset: 0x0004FA20
		// Note: this type is marked as 'beforefieldinit'.
		static SubOvfInstruction()
		{
			Il2CppClassPointerStore<SubOvfInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "SubOvfInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubOvfInstruction>.NativeClassPtr);
			SubOvfInstruction.NativeFieldInfoPtr_s_Int16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubOvfInstruction>.NativeClassPtr, "s_Int16");
			SubOvfInstruction.NativeFieldInfoPtr_s_Int32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubOvfInstruction>.NativeClassPtr, "s_Int32");
			SubOvfInstruction.NativeFieldInfoPtr_s_Int64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubOvfInstruction>.NativeClassPtr, "s_Int64");
			SubOvfInstruction.NativeFieldInfoPtr_s_UInt16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubOvfInstruction>.NativeClassPtr, "s_UInt16");
			SubOvfInstruction.NativeFieldInfoPtr_s_UInt32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubOvfInstruction>.NativeClassPtr, "s_UInt32");
			SubOvfInstruction.NativeFieldInfoPtr_s_UInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubOvfInstruction>.NativeClassPtr, "s_UInt64");
			SubOvfInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubOvfInstruction>.NativeClassPtr, 100666142);
			SubOvfInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubOvfInstruction>.NativeClassPtr, 100666143);
			SubOvfInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubOvfInstruction>.NativeClassPtr, 100666144);
			SubOvfInstruction.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubOvfInstruction>.NativeClassPtr, 100666145);
			SubOvfInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubOvfInstruction>.NativeClassPtr, 100666146);
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06000F40 RID: 3904 RVA: 0x0005192C File Offset: 0x0004FB2C
		public unsafe override int ConsumedStack
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 72978, RefRangeEnd = 72985, XrefRangeStart = 72978, XrefRangeEnd = 72985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SubOvfInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06000F41 RID: 3905 RVA: 0x00051974 File Offset: 0x0004FB74
		public unsafe override int ProducedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SubOvfInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06000F42 RID: 3906 RVA: 0x000519BC File Offset: 0x0004FBBC
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026420, XrefRangeEnd = 1026422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SubOvfInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x00051A00 File Offset: 0x0004FC00
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SubOvfInstruction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubOvfInstruction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubOvfInstruction.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x00051A3C File Offset: 0x0004FC3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1026444, RefRangeEnd = 1026446, XrefRangeStart = 1026422, XrefRangeEnd = 1026444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Instruction Create(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubOvfInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x00006B6A File Offset: 0x00004D6A
		public SubOvfInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06000F46 RID: 3910 RVA: 0x00051A80 File Offset: 0x0004FC80
		// (set) Token: 0x06000F47 RID: 3911 RVA: 0x00006B73 File Offset: 0x00004D73
		public unsafe static Instruction s_Int16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SubOvfInstruction.NativeFieldInfoPtr_s_Int16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SubOvfInstruction.NativeFieldInfoPtr_s_Int16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06000F48 RID: 3912 RVA: 0x00051AA8 File Offset: 0x0004FCA8
		// (set) Token: 0x06000F49 RID: 3913 RVA: 0x00006B85 File Offset: 0x00004D85
		public unsafe static Instruction s_Int32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SubOvfInstruction.NativeFieldInfoPtr_s_Int32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SubOvfInstruction.NativeFieldInfoPtr_s_Int32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06000F4A RID: 3914 RVA: 0x00051AD0 File Offset: 0x0004FCD0
		// (set) Token: 0x06000F4B RID: 3915 RVA: 0x00006B97 File Offset: 0x00004D97
		public unsafe static Instruction s_Int64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SubOvfInstruction.NativeFieldInfoPtr_s_Int64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SubOvfInstruction.NativeFieldInfoPtr_s_Int64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06000F4C RID: 3916 RVA: 0x00051AF8 File Offset: 0x0004FCF8
		// (set) Token: 0x06000F4D RID: 3917 RVA: 0x00006BA9 File Offset: 0x00004DA9
		public unsafe static Instruction s_UInt16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SubOvfInstruction.NativeFieldInfoPtr_s_UInt16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SubOvfInstruction.NativeFieldInfoPtr_s_UInt16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06000F4E RID: 3918 RVA: 0x00051B20 File Offset: 0x0004FD20
		// (set) Token: 0x06000F4F RID: 3919 RVA: 0x00006BBB File Offset: 0x00004DBB
		public unsafe static Instruction s_UInt32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SubOvfInstruction.NativeFieldInfoPtr_s_UInt32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SubOvfInstruction.NativeFieldInfoPtr_s_UInt32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06000F50 RID: 3920 RVA: 0x00051B48 File Offset: 0x0004FD48
		// (set) Token: 0x06000F51 RID: 3921 RVA: 0x00006BCD File Offset: 0x00004DCD
		public unsafe static Instruction s_UInt64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SubOvfInstruction.NativeFieldInfoPtr_s_UInt64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SubOvfInstruction.NativeFieldInfoPtr_s_UInt64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B06 RID: 2822
		private static readonly IntPtr NativeFieldInfoPtr_s_Int16;

		// Token: 0x04000B07 RID: 2823
		private static readonly IntPtr NativeFieldInfoPtr_s_Int32;

		// Token: 0x04000B08 RID: 2824
		private static readonly IntPtr NativeFieldInfoPtr_s_Int64;

		// Token: 0x04000B09 RID: 2825
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt16;

		// Token: 0x04000B0A RID: 2826
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt32;

		// Token: 0x04000B0B RID: 2827
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt64;

		// Token: 0x04000B0C RID: 2828
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000B0D RID: 2829
		private static readonly IntPtr NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000B0E RID: 2830
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x04000B0F RID: 2831
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000B10 RID: 2832
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0;

		// Token: 0x0200031B RID: 795
		public sealed class SubOvfInt16 : SubOvfInstruction
		{
			// Token: 0x06001ADB RID: 6875 RVA: 0x000801C4 File Offset: 0x0007E3C4
			// Note: this type is marked as 'beforefieldinit'.
			static SubOvfInt16()
			{
				Il2CppClassPointerStore<SubOvfInstruction.SubOvfInt16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubOvfInstruction>.NativeClassPtr, "SubOvfInt16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubOvfInstruction.SubOvfInt16>.NativeClassPtr);
				SubOvfInstruction.SubOvfInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubOvfInstruction.SubOvfInt16>.NativeClassPtr, 100666147);
				SubOvfInstruction.SubOvfInt16.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubOvfInstruction.SubOvfInt16>.NativeClassPtr, 100666148);
			}

			// Token: 0x06001ADC RID: 6876 RVA: 0x00080218 File Offset: 0x0007E418
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026402, XrefRangeEnd = 1026405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubOvfInstruction.SubOvfInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001ADD RID: 6877 RVA: 0x00080268 File Offset: 0x0007E468
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SubOvfInt16()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubOvfInstruction.SubOvfInt16>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubOvfInstruction.SubOvfInt16.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001ADE RID: 6878 RVA: 0x0000A477 File Offset: 0x00008677
			public SubOvfInt16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001234 RID: 4660
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001235 RID: 4661
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200031C RID: 796
		public sealed class SubOvfInt32 : SubOvfInstruction
		{
			// Token: 0x06001ADF RID: 6879 RVA: 0x000802A4 File Offset: 0x0007E4A4
			// Note: this type is marked as 'beforefieldinit'.
			static SubOvfInt32()
			{
				Il2CppClassPointerStore<SubOvfInstruction.SubOvfInt32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubOvfInstruction>.NativeClassPtr, "SubOvfInt32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubOvfInstruction.SubOvfInt32>.NativeClassPtr);
				SubOvfInstruction.SubOvfInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubOvfInstruction.SubOvfInt32>.NativeClassPtr, 100666149);
				SubOvfInstruction.SubOvfInt32.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubOvfInstruction.SubOvfInt32>.NativeClassPtr, 100666150);
			}

			// Token: 0x06001AE0 RID: 6880 RVA: 0x000802F8 File Offset: 0x0007E4F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026405, XrefRangeEnd = 1026408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubOvfInstruction.SubOvfInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001AE1 RID: 6881 RVA: 0x00080348 File Offset: 0x0007E548
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SubOvfInt32()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubOvfInstruction.SubOvfInt32>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubOvfInstruction.SubOvfInt32.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AE2 RID: 6882 RVA: 0x0000A480 File Offset: 0x00008680
			public SubOvfInt32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001236 RID: 4662
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001237 RID: 4663
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200031D RID: 797
		public sealed class SubOvfInt64 : SubOvfInstruction
		{
			// Token: 0x06001AE3 RID: 6883 RVA: 0x00080384 File Offset: 0x0007E584
			// Note: this type is marked as 'beforefieldinit'.
			static SubOvfInt64()
			{
				Il2CppClassPointerStore<SubOvfInstruction.SubOvfInt64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubOvfInstruction>.NativeClassPtr, "SubOvfInt64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubOvfInstruction.SubOvfInt64>.NativeClassPtr);
				SubOvfInstruction.SubOvfInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubOvfInstruction.SubOvfInt64>.NativeClassPtr, 100666151);
				SubOvfInstruction.SubOvfInt64.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubOvfInstruction.SubOvfInt64>.NativeClassPtr, 100666152);
			}

			// Token: 0x06001AE4 RID: 6884 RVA: 0x000803D8 File Offset: 0x0007E5D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026408, XrefRangeEnd = 1026411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubOvfInstruction.SubOvfInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001AE5 RID: 6885 RVA: 0x00080428 File Offset: 0x0007E628
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SubOvfInt64()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubOvfInstruction.SubOvfInt64>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubOvfInstruction.SubOvfInt64.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AE6 RID: 6886 RVA: 0x0000A489 File Offset: 0x00008689
			public SubOvfInt64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001238 RID: 4664
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001239 RID: 4665
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200031E RID: 798
		public sealed class SubOvfUInt16 : SubOvfInstruction
		{
			// Token: 0x06001AE7 RID: 6887 RVA: 0x00080464 File Offset: 0x0007E664
			// Note: this type is marked as 'beforefieldinit'.
			static SubOvfUInt16()
			{
				Il2CppClassPointerStore<SubOvfInstruction.SubOvfUInt16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubOvfInstruction>.NativeClassPtr, "SubOvfUInt16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubOvfInstruction.SubOvfUInt16>.NativeClassPtr);
				SubOvfInstruction.SubOvfUInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubOvfInstruction.SubOvfUInt16>.NativeClassPtr, 100666153);
				SubOvfInstruction.SubOvfUInt16.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubOvfInstruction.SubOvfUInt16>.NativeClassPtr, 100666154);
			}

			// Token: 0x06001AE8 RID: 6888 RVA: 0x000804B8 File Offset: 0x0007E6B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026411, XrefRangeEnd = 1026414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubOvfInstruction.SubOvfUInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001AE9 RID: 6889 RVA: 0x00080508 File Offset: 0x0007E708
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SubOvfUInt16()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubOvfInstruction.SubOvfUInt16>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubOvfInstruction.SubOvfUInt16.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AEA RID: 6890 RVA: 0x0000A492 File Offset: 0x00008692
			public SubOvfUInt16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400123A RID: 4666
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x0400123B RID: 4667
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200031F RID: 799
		public sealed class SubOvfUInt32 : SubOvfInstruction
		{
			// Token: 0x06001AEB RID: 6891 RVA: 0x00080544 File Offset: 0x0007E744
			// Note: this type is marked as 'beforefieldinit'.
			static SubOvfUInt32()
			{
				Il2CppClassPointerStore<SubOvfInstruction.SubOvfUInt32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubOvfInstruction>.NativeClassPtr, "SubOvfUInt32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubOvfInstruction.SubOvfUInt32>.NativeClassPtr);
				SubOvfInstruction.SubOvfUInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubOvfInstruction.SubOvfUInt32>.NativeClassPtr, 100666155);
				SubOvfInstruction.SubOvfUInt32.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubOvfInstruction.SubOvfUInt32>.NativeClassPtr, 100666156);
			}

			// Token: 0x06001AEC RID: 6892 RVA: 0x00080598 File Offset: 0x0007E798
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026414, XrefRangeEnd = 1026417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubOvfInstruction.SubOvfUInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001AED RID: 6893 RVA: 0x000805E8 File Offset: 0x0007E7E8
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SubOvfUInt32()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubOvfInstruction.SubOvfUInt32>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubOvfInstruction.SubOvfUInt32.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AEE RID: 6894 RVA: 0x0000A49B File Offset: 0x0000869B
			public SubOvfUInt32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400123C RID: 4668
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x0400123D RID: 4669
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000320 RID: 800
		public sealed class SubOvfUInt64 : SubOvfInstruction
		{
			// Token: 0x06001AEF RID: 6895 RVA: 0x00080624 File Offset: 0x0007E824
			// Note: this type is marked as 'beforefieldinit'.
			static SubOvfUInt64()
			{
				Il2CppClassPointerStore<SubOvfInstruction.SubOvfUInt64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubOvfInstruction>.NativeClassPtr, "SubOvfUInt64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubOvfInstruction.SubOvfUInt64>.NativeClassPtr);
				SubOvfInstruction.SubOvfUInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubOvfInstruction.SubOvfUInt64>.NativeClassPtr, 100666157);
				SubOvfInstruction.SubOvfUInt64.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubOvfInstruction.SubOvfUInt64>.NativeClassPtr, 100666158);
			}

			// Token: 0x06001AF0 RID: 6896 RVA: 0x00080678 File Offset: 0x0007E878
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026417, XrefRangeEnd = 1026420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubOvfInstruction.SubOvfUInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001AF1 RID: 6897 RVA: 0x000806C8 File Offset: 0x0007E8C8
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SubOvfUInt64()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubOvfInstruction.SubOvfUInt64>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubOvfInstruction.SubOvfUInt64.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AF2 RID: 6898 RVA: 0x0000A4A4 File Offset: 0x000086A4
			public SubOvfUInt64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400123E RID: 4670
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x0400123F RID: 4671
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
