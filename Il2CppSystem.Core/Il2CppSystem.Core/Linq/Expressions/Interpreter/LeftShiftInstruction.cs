using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000C4 RID: 196
	public class LeftShiftInstruction : Instruction
	{
		// Token: 0x06000B98 RID: 2968 RVA: 0x00040AEC File Offset: 0x0003ECEC
		// Note: this type is marked as 'beforefieldinit'.
		static LeftShiftInstruction()
		{
			Il2CppClassPointerStore<LeftShiftInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "LeftShiftInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeftShiftInstruction>.NativeClassPtr);
			LeftShiftInstruction.NativeFieldInfoPtr_s_SByte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeftShiftInstruction>.NativeClassPtr, "s_SByte");
			LeftShiftInstruction.NativeFieldInfoPtr_s_Int16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeftShiftInstruction>.NativeClassPtr, "s_Int16");
			LeftShiftInstruction.NativeFieldInfoPtr_s_Int32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeftShiftInstruction>.NativeClassPtr, "s_Int32");
			LeftShiftInstruction.NativeFieldInfoPtr_s_Int64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeftShiftInstruction>.NativeClassPtr, "s_Int64");
			LeftShiftInstruction.NativeFieldInfoPtr_s_Byte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeftShiftInstruction>.NativeClassPtr, "s_Byte");
			LeftShiftInstruction.NativeFieldInfoPtr_s_UInt16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeftShiftInstruction>.NativeClassPtr, "s_UInt16");
			LeftShiftInstruction.NativeFieldInfoPtr_s_UInt32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeftShiftInstruction>.NativeClassPtr, "s_UInt32");
			LeftShiftInstruction.NativeFieldInfoPtr_s_UInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeftShiftInstruction>.NativeClassPtr, "s_UInt64");
			LeftShiftInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeftShiftInstruction>.NativeClassPtr, 100665442);
			LeftShiftInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeftShiftInstruction>.NativeClassPtr, 100665443);
			LeftShiftInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeftShiftInstruction>.NativeClassPtr, 100665444);
			LeftShiftInstruction.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeftShiftInstruction>.NativeClassPtr, 100665445);
			LeftShiftInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeftShiftInstruction>.NativeClassPtr, 100665446);
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000B99 RID: 2969 RVA: 0x00040C20 File Offset: 0x0003EE20
		public unsafe override int ConsumedStack
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 72978, RefRangeEnd = 72985, XrefRangeStart = 72978, XrefRangeEnd = 72985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LeftShiftInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000B9A RID: 2970 RVA: 0x00040C68 File Offset: 0x0003EE68
		public unsafe override int ProducedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LeftShiftInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000B9B RID: 2971 RVA: 0x00040CB0 File Offset: 0x0003EEB0
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019685, XrefRangeEnd = 1019687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LeftShiftInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x00040CF4 File Offset: 0x0003EEF4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LeftShiftInstruction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeftShiftInstruction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeftShiftInstruction.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x00040D30 File Offset: 0x0003EF30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1019711, RefRangeEnd = 1019712, XrefRangeStart = 1019687, XrefRangeEnd = 1019711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Instruction Create(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeftShiftInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x000055FF File Offset: 0x000037FF
		public LeftShiftInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000B9F RID: 2975 RVA: 0x00040D74 File Offset: 0x0003EF74
		// (set) Token: 0x06000BA0 RID: 2976 RVA: 0x00005608 File Offset: 0x00003808
		public unsafe static Instruction s_SByte
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LeftShiftInstruction.NativeFieldInfoPtr_s_SByte, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LeftShiftInstruction.NativeFieldInfoPtr_s_SByte, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000BA1 RID: 2977 RVA: 0x00040D9C File Offset: 0x0003EF9C
		// (set) Token: 0x06000BA2 RID: 2978 RVA: 0x0000561A File Offset: 0x0000381A
		public unsafe static Instruction s_Int16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LeftShiftInstruction.NativeFieldInfoPtr_s_Int16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LeftShiftInstruction.NativeFieldInfoPtr_s_Int16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000BA3 RID: 2979 RVA: 0x00040DC4 File Offset: 0x0003EFC4
		// (set) Token: 0x06000BA4 RID: 2980 RVA: 0x0000562C File Offset: 0x0000382C
		public unsafe static Instruction s_Int32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LeftShiftInstruction.NativeFieldInfoPtr_s_Int32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LeftShiftInstruction.NativeFieldInfoPtr_s_Int32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000BA5 RID: 2981 RVA: 0x00040DEC File Offset: 0x0003EFEC
		// (set) Token: 0x06000BA6 RID: 2982 RVA: 0x0000563E File Offset: 0x0000383E
		public unsafe static Instruction s_Int64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LeftShiftInstruction.NativeFieldInfoPtr_s_Int64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LeftShiftInstruction.NativeFieldInfoPtr_s_Int64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000BA7 RID: 2983 RVA: 0x00040E14 File Offset: 0x0003F014
		// (set) Token: 0x06000BA8 RID: 2984 RVA: 0x00005650 File Offset: 0x00003850
		public unsafe static Instruction s_Byte
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LeftShiftInstruction.NativeFieldInfoPtr_s_Byte, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LeftShiftInstruction.NativeFieldInfoPtr_s_Byte, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000BA9 RID: 2985 RVA: 0x00040E3C File Offset: 0x0003F03C
		// (set) Token: 0x06000BAA RID: 2986 RVA: 0x00005662 File Offset: 0x00003862
		public unsafe static Instruction s_UInt16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LeftShiftInstruction.NativeFieldInfoPtr_s_UInt16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LeftShiftInstruction.NativeFieldInfoPtr_s_UInt16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000BAB RID: 2987 RVA: 0x00040E64 File Offset: 0x0003F064
		// (set) Token: 0x06000BAC RID: 2988 RVA: 0x00005674 File Offset: 0x00003874
		public unsafe static Instruction s_UInt32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LeftShiftInstruction.NativeFieldInfoPtr_s_UInt32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LeftShiftInstruction.NativeFieldInfoPtr_s_UInt32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000BAD RID: 2989 RVA: 0x00040E8C File Offset: 0x0003F08C
		// (set) Token: 0x06000BAE RID: 2990 RVA: 0x00005686 File Offset: 0x00003886
		public unsafe static Instruction s_UInt64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LeftShiftInstruction.NativeFieldInfoPtr_s_UInt64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LeftShiftInstruction.NativeFieldInfoPtr_s_UInt64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008AA RID: 2218
		private static readonly IntPtr NativeFieldInfoPtr_s_SByte;

		// Token: 0x040008AB RID: 2219
		private static readonly IntPtr NativeFieldInfoPtr_s_Int16;

		// Token: 0x040008AC RID: 2220
		private static readonly IntPtr NativeFieldInfoPtr_s_Int32;

		// Token: 0x040008AD RID: 2221
		private static readonly IntPtr NativeFieldInfoPtr_s_Int64;

		// Token: 0x040008AE RID: 2222
		private static readonly IntPtr NativeFieldInfoPtr_s_Byte;

		// Token: 0x040008AF RID: 2223
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt16;

		// Token: 0x040008B0 RID: 2224
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt32;

		// Token: 0x040008B1 RID: 2225
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt64;

		// Token: 0x040008B2 RID: 2226
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0;

		// Token: 0x040008B3 RID: 2227
		private static readonly IntPtr NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0;

		// Token: 0x040008B4 RID: 2228
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x040008B5 RID: 2229
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x040008B6 RID: 2230
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0;

		// Token: 0x02000254 RID: 596
		public sealed class LeftShiftSByte : LeftShiftInstruction
		{
			// Token: 0x06001830 RID: 6192 RVA: 0x00074250 File Offset: 0x00072450
			// Note: this type is marked as 'beforefieldinit'.
			static LeftShiftSByte()
			{
				Il2CppClassPointerStore<LeftShiftInstruction.LeftShiftSByte>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LeftShiftInstruction>.NativeClassPtr, "LeftShiftSByte");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeftShiftInstruction.LeftShiftSByte>.NativeClassPtr);
				LeftShiftInstruction.LeftShiftSByte.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeftShiftInstruction.LeftShiftSByte>.NativeClassPtr, 100665447);
				LeftShiftInstruction.LeftShiftSByte.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeftShiftInstruction.LeftShiftSByte>.NativeClassPtr, 100665448);
			}

			// Token: 0x06001831 RID: 6193 RVA: 0x000742A4 File Offset: 0x000724A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019605, XrefRangeEnd = 1019617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeftShiftInstruction.LeftShiftSByte.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001832 RID: 6194 RVA: 0x000742F4 File Offset: 0x000724F4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LeftShiftSByte()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeftShiftInstruction.LeftShiftSByte>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeftShiftInstruction.LeftShiftSByte.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001833 RID: 6195 RVA: 0x00009D4A File Offset: 0x00007F4A
			public LeftShiftSByte(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040010AD RID: 4269
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x040010AE RID: 4270
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000255 RID: 597
		public sealed class LeftShiftInt16 : LeftShiftInstruction
		{
			// Token: 0x06001834 RID: 6196 RVA: 0x00074330 File Offset: 0x00072530
			// Note: this type is marked as 'beforefieldinit'.
			static LeftShiftInt16()
			{
				Il2CppClassPointerStore<LeftShiftInstruction.LeftShiftInt16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LeftShiftInstruction>.NativeClassPtr, "LeftShiftInt16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeftShiftInstruction.LeftShiftInt16>.NativeClassPtr);
				LeftShiftInstruction.LeftShiftInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeftShiftInstruction.LeftShiftInt16>.NativeClassPtr, 100665449);
				LeftShiftInstruction.LeftShiftInt16.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeftShiftInstruction.LeftShiftInt16>.NativeClassPtr, 100665450);
			}

			// Token: 0x06001835 RID: 6197 RVA: 0x00074384 File Offset: 0x00072584
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019617, XrefRangeEnd = 1019626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeftShiftInstruction.LeftShiftInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001836 RID: 6198 RVA: 0x000743D4 File Offset: 0x000725D4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LeftShiftInt16()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeftShiftInstruction.LeftShiftInt16>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeftShiftInstruction.LeftShiftInt16.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001837 RID: 6199 RVA: 0x00009D53 File Offset: 0x00007F53
			public LeftShiftInt16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040010AF RID: 4271
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x040010B0 RID: 4272
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000256 RID: 598
		public sealed class LeftShiftInt32 : LeftShiftInstruction
		{
			// Token: 0x06001838 RID: 6200 RVA: 0x00074410 File Offset: 0x00072610
			// Note: this type is marked as 'beforefieldinit'.
			static LeftShiftInt32()
			{
				Il2CppClassPointerStore<LeftShiftInstruction.LeftShiftInt32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LeftShiftInstruction>.NativeClassPtr, "LeftShiftInt32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeftShiftInstruction.LeftShiftInt32>.NativeClassPtr);
				LeftShiftInstruction.LeftShiftInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeftShiftInstruction.LeftShiftInt32>.NativeClassPtr, 100665451);
				LeftShiftInstruction.LeftShiftInt32.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeftShiftInstruction.LeftShiftInt32>.NativeClassPtr, 100665452);
			}

			// Token: 0x06001839 RID: 6201 RVA: 0x00074464 File Offset: 0x00072664
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019626, XrefRangeEnd = 1019634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeftShiftInstruction.LeftShiftInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600183A RID: 6202 RVA: 0x000744B4 File Offset: 0x000726B4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LeftShiftInt32()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeftShiftInstruction.LeftShiftInt32>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeftShiftInstruction.LeftShiftInt32.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600183B RID: 6203 RVA: 0x00009D5C File Offset: 0x00007F5C
			public LeftShiftInt32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040010B1 RID: 4273
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x040010B2 RID: 4274
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000257 RID: 599
		public sealed class LeftShiftInt64 : LeftShiftInstruction
		{
			// Token: 0x0600183C RID: 6204 RVA: 0x000744F0 File Offset: 0x000726F0
			// Note: this type is marked as 'beforefieldinit'.
			static LeftShiftInt64()
			{
				Il2CppClassPointerStore<LeftShiftInstruction.LeftShiftInt64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LeftShiftInstruction>.NativeClassPtr, "LeftShiftInt64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeftShiftInstruction.LeftShiftInt64>.NativeClassPtr);
				LeftShiftInstruction.LeftShiftInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeftShiftInstruction.LeftShiftInt64>.NativeClassPtr, 100665453);
				LeftShiftInstruction.LeftShiftInt64.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeftShiftInstruction.LeftShiftInt64>.NativeClassPtr, 100665454);
			}

			// Token: 0x0600183D RID: 6205 RVA: 0x00074544 File Offset: 0x00072744
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019634, XrefRangeEnd = 1019645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeftShiftInstruction.LeftShiftInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600183E RID: 6206 RVA: 0x00074594 File Offset: 0x00072794
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LeftShiftInt64()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeftShiftInstruction.LeftShiftInt64>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeftShiftInstruction.LeftShiftInt64.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600183F RID: 6207 RVA: 0x00009D65 File Offset: 0x00007F65
			public LeftShiftInt64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040010B3 RID: 4275
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x040010B4 RID: 4276
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000258 RID: 600
		public sealed class LeftShiftByte : LeftShiftInstruction
		{
			// Token: 0x06001840 RID: 6208 RVA: 0x000745D0 File Offset: 0x000727D0
			// Note: this type is marked as 'beforefieldinit'.
			static LeftShiftByte()
			{
				Il2CppClassPointerStore<LeftShiftInstruction.LeftShiftByte>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LeftShiftInstruction>.NativeClassPtr, "LeftShiftByte");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeftShiftInstruction.LeftShiftByte>.NativeClassPtr);
				LeftShiftInstruction.LeftShiftByte.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeftShiftInstruction.LeftShiftByte>.NativeClassPtr, 100665455);
				LeftShiftInstruction.LeftShiftByte.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeftShiftInstruction.LeftShiftByte>.NativeClassPtr, 100665456);
			}

			// Token: 0x06001841 RID: 6209 RVA: 0x00074624 File Offset: 0x00072824
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019645, XrefRangeEnd = 1019654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeftShiftInstruction.LeftShiftByte.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001842 RID: 6210 RVA: 0x00074674 File Offset: 0x00072874
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LeftShiftByte()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeftShiftInstruction.LeftShiftByte>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeftShiftInstruction.LeftShiftByte.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001843 RID: 6211 RVA: 0x00009D6E File Offset: 0x00007F6E
			public LeftShiftByte(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040010B5 RID: 4277
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x040010B6 RID: 4278
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000259 RID: 601
		public sealed class LeftShiftUInt16 : LeftShiftInstruction
		{
			// Token: 0x06001844 RID: 6212 RVA: 0x000746B0 File Offset: 0x000728B0
			// Note: this type is marked as 'beforefieldinit'.
			static LeftShiftUInt16()
			{
				Il2CppClassPointerStore<LeftShiftInstruction.LeftShiftUInt16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LeftShiftInstruction>.NativeClassPtr, "LeftShiftUInt16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeftShiftInstruction.LeftShiftUInt16>.NativeClassPtr);
				LeftShiftInstruction.LeftShiftUInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeftShiftInstruction.LeftShiftUInt16>.NativeClassPtr, 100665457);
				LeftShiftInstruction.LeftShiftUInt16.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeftShiftInstruction.LeftShiftUInt16>.NativeClassPtr, 100665458);
			}

			// Token: 0x06001845 RID: 6213 RVA: 0x00074704 File Offset: 0x00072904
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019654, XrefRangeEnd = 1019663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeftShiftInstruction.LeftShiftUInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001846 RID: 6214 RVA: 0x00074754 File Offset: 0x00072954
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LeftShiftUInt16()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeftShiftInstruction.LeftShiftUInt16>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeftShiftInstruction.LeftShiftUInt16.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001847 RID: 6215 RVA: 0x00009D77 File Offset: 0x00007F77
			public LeftShiftUInt16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040010B7 RID: 4279
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x040010B8 RID: 4280
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200025A RID: 602
		public sealed class LeftShiftUInt32 : LeftShiftInstruction
		{
			// Token: 0x06001848 RID: 6216 RVA: 0x00074790 File Offset: 0x00072990
			// Note: this type is marked as 'beforefieldinit'.
			static LeftShiftUInt32()
			{
				Il2CppClassPointerStore<LeftShiftInstruction.LeftShiftUInt32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LeftShiftInstruction>.NativeClassPtr, "LeftShiftUInt32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeftShiftInstruction.LeftShiftUInt32>.NativeClassPtr);
				LeftShiftInstruction.LeftShiftUInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeftShiftInstruction.LeftShiftUInt32>.NativeClassPtr, 100665459);
				LeftShiftInstruction.LeftShiftUInt32.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeftShiftInstruction.LeftShiftUInt32>.NativeClassPtr, 100665460);
			}

			// Token: 0x06001849 RID: 6217 RVA: 0x000747E4 File Offset: 0x000729E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019663, XrefRangeEnd = 1019674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeftShiftInstruction.LeftShiftUInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600184A RID: 6218 RVA: 0x00074834 File Offset: 0x00072A34
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LeftShiftUInt32()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeftShiftInstruction.LeftShiftUInt32>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeftShiftInstruction.LeftShiftUInt32.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600184B RID: 6219 RVA: 0x00009D80 File Offset: 0x00007F80
			public LeftShiftUInt32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040010B9 RID: 4281
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x040010BA RID: 4282
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200025B RID: 603
		public sealed class LeftShiftUInt64 : LeftShiftInstruction
		{
			// Token: 0x0600184C RID: 6220 RVA: 0x00074870 File Offset: 0x00072A70
			// Note: this type is marked as 'beforefieldinit'.
			static LeftShiftUInt64()
			{
				Il2CppClassPointerStore<LeftShiftInstruction.LeftShiftUInt64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LeftShiftInstruction>.NativeClassPtr, "LeftShiftUInt64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeftShiftInstruction.LeftShiftUInt64>.NativeClassPtr);
				LeftShiftInstruction.LeftShiftUInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeftShiftInstruction.LeftShiftUInt64>.NativeClassPtr, 100665461);
				LeftShiftInstruction.LeftShiftUInt64.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeftShiftInstruction.LeftShiftUInt64>.NativeClassPtr, 100665462);
			}

			// Token: 0x0600184D RID: 6221 RVA: 0x000748C4 File Offset: 0x00072AC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019674, XrefRangeEnd = 1019685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeftShiftInstruction.LeftShiftUInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600184E RID: 6222 RVA: 0x00074914 File Offset: 0x00072B14
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LeftShiftUInt64()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeftShiftInstruction.LeftShiftUInt64>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeftShiftInstruction.LeftShiftUInt64.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600184F RID: 6223 RVA: 0x00009D89 File Offset: 0x00007F89
			public LeftShiftUInt64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040010BB RID: 4283
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x040010BC RID: 4284
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
