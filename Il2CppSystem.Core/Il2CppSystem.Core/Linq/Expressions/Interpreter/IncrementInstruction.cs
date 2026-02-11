using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000BB RID: 187
	public class IncrementInstruction : Instruction
	{
		// Token: 0x06000A4C RID: 2636 RVA: 0x0003B8A0 File Offset: 0x00039AA0
		// Note: this type is marked as 'beforefieldinit'.
		static IncrementInstruction()
		{
			Il2CppClassPointerStore<IncrementInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "IncrementInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncrementInstruction>.NativeClassPtr);
			IncrementInstruction.NativeFieldInfoPtr_s_Int16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncrementInstruction>.NativeClassPtr, "s_Int16");
			IncrementInstruction.NativeFieldInfoPtr_s_Int32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncrementInstruction>.NativeClassPtr, "s_Int32");
			IncrementInstruction.NativeFieldInfoPtr_s_Int64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncrementInstruction>.NativeClassPtr, "s_Int64");
			IncrementInstruction.NativeFieldInfoPtr_s_UInt16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncrementInstruction>.NativeClassPtr, "s_UInt16");
			IncrementInstruction.NativeFieldInfoPtr_s_UInt32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncrementInstruction>.NativeClassPtr, "s_UInt32");
			IncrementInstruction.NativeFieldInfoPtr_s_UInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncrementInstruction>.NativeClassPtr, "s_UInt64");
			IncrementInstruction.NativeFieldInfoPtr_s_Single = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncrementInstruction>.NativeClassPtr, "s_Single");
			IncrementInstruction.NativeFieldInfoPtr_s_Double = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncrementInstruction>.NativeClassPtr, "s_Double");
			IncrementInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementInstruction>.NativeClassPtr, 100665224);
			IncrementInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementInstruction>.NativeClassPtr, 100665225);
			IncrementInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementInstruction>.NativeClassPtr, 100665226);
			IncrementInstruction.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementInstruction>.NativeClassPtr, 100665227);
			IncrementInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementInstruction>.NativeClassPtr, 100665228);
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000A4D RID: 2637 RVA: 0x0003B9D4 File Offset: 0x00039BD4
		public unsafe override int ConsumedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IncrementInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000A4E RID: 2638 RVA: 0x0003BA1C File Offset: 0x00039C1C
		public unsafe override int ProducedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IncrementInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000A4F RID: 2639 RVA: 0x0003BA64 File Offset: 0x00039C64
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1017317, XrefRangeEnd = 1017319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IncrementInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x0003BAA8 File Offset: 0x00039CA8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IncrementInstruction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncrementInstruction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncrementInstruction.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x0003BAE4 File Offset: 0x00039CE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1017343, RefRangeEnd = 1017344, XrefRangeStart = 1017319, XrefRangeEnd = 1017343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Instruction Create(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncrementInstruction.NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x00004F22 File Offset: 0x00003122
		public IncrementInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000A53 RID: 2643 RVA: 0x0003BB28 File Offset: 0x00039D28
		// (set) Token: 0x06000A54 RID: 2644 RVA: 0x00004F2B File Offset: 0x0000312B
		public unsafe static Instruction s_Int16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IncrementInstruction.NativeFieldInfoPtr_s_Int16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IncrementInstruction.NativeFieldInfoPtr_s_Int16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000A55 RID: 2645 RVA: 0x0003BB50 File Offset: 0x00039D50
		// (set) Token: 0x06000A56 RID: 2646 RVA: 0x00004F3D File Offset: 0x0000313D
		public unsafe static Instruction s_Int32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IncrementInstruction.NativeFieldInfoPtr_s_Int32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IncrementInstruction.NativeFieldInfoPtr_s_Int32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000A57 RID: 2647 RVA: 0x0003BB78 File Offset: 0x00039D78
		// (set) Token: 0x06000A58 RID: 2648 RVA: 0x00004F4F File Offset: 0x0000314F
		public unsafe static Instruction s_Int64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IncrementInstruction.NativeFieldInfoPtr_s_Int64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IncrementInstruction.NativeFieldInfoPtr_s_Int64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000A59 RID: 2649 RVA: 0x0003BBA0 File Offset: 0x00039DA0
		// (set) Token: 0x06000A5A RID: 2650 RVA: 0x00004F61 File Offset: 0x00003161
		public unsafe static Instruction s_UInt16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IncrementInstruction.NativeFieldInfoPtr_s_UInt16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IncrementInstruction.NativeFieldInfoPtr_s_UInt16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000A5B RID: 2651 RVA: 0x0003BBC8 File Offset: 0x00039DC8
		// (set) Token: 0x06000A5C RID: 2652 RVA: 0x00004F73 File Offset: 0x00003173
		public unsafe static Instruction s_UInt32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IncrementInstruction.NativeFieldInfoPtr_s_UInt32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IncrementInstruction.NativeFieldInfoPtr_s_UInt32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000A5D RID: 2653 RVA: 0x0003BBF0 File Offset: 0x00039DF0
		// (set) Token: 0x06000A5E RID: 2654 RVA: 0x00004F85 File Offset: 0x00003185
		public unsafe static Instruction s_UInt64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IncrementInstruction.NativeFieldInfoPtr_s_UInt64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IncrementInstruction.NativeFieldInfoPtr_s_UInt64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000A5F RID: 2655 RVA: 0x0003BC18 File Offset: 0x00039E18
		// (set) Token: 0x06000A60 RID: 2656 RVA: 0x00004F97 File Offset: 0x00003197
		public unsafe static Instruction s_Single
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IncrementInstruction.NativeFieldInfoPtr_s_Single, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IncrementInstruction.NativeFieldInfoPtr_s_Single, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000A61 RID: 2657 RVA: 0x0003BC40 File Offset: 0x00039E40
		// (set) Token: 0x06000A62 RID: 2658 RVA: 0x00004FA9 File Offset: 0x000031A9
		public unsafe static Instruction s_Double
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IncrementInstruction.NativeFieldInfoPtr_s_Double, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IncrementInstruction.NativeFieldInfoPtr_s_Double, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007A7 RID: 1959
		private static readonly IntPtr NativeFieldInfoPtr_s_Int16;

		// Token: 0x040007A8 RID: 1960
		private static readonly IntPtr NativeFieldInfoPtr_s_Int32;

		// Token: 0x040007A9 RID: 1961
		private static readonly IntPtr NativeFieldInfoPtr_s_Int64;

		// Token: 0x040007AA RID: 1962
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt16;

		// Token: 0x040007AB RID: 1963
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt32;

		// Token: 0x040007AC RID: 1964
		private static readonly IntPtr NativeFieldInfoPtr_s_UInt64;

		// Token: 0x040007AD RID: 1965
		private static readonly IntPtr NativeFieldInfoPtr_s_Single;

		// Token: 0x040007AE RID: 1966
		private static readonly IntPtr NativeFieldInfoPtr_s_Double;

		// Token: 0x040007AF RID: 1967
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0;

		// Token: 0x040007B0 RID: 1968
		private static readonly IntPtr NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0;

		// Token: 0x040007B1 RID: 1969
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x040007B2 RID: 1970
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x040007B3 RID: 1971
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Instruction_Type_0;

		// Token: 0x02000246 RID: 582
		public sealed class IncrementInt16 : IncrementInstruction
		{
			// Token: 0x060017E8 RID: 6120 RVA: 0x0007334C File Offset: 0x0007154C
			// Note: this type is marked as 'beforefieldinit'.
			static IncrementInt16()
			{
				Il2CppClassPointerStore<IncrementInstruction.IncrementInt16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IncrementInstruction>.NativeClassPtr, "IncrementInt16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncrementInstruction.IncrementInt16>.NativeClassPtr);
				IncrementInstruction.IncrementInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementInstruction.IncrementInt16>.NativeClassPtr, 100665229);
				IncrementInstruction.IncrementInt16.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementInstruction.IncrementInt16>.NativeClassPtr, 100665230);
			}

			// Token: 0x060017E9 RID: 6121 RVA: 0x000733A0 File Offset: 0x000715A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1017262, XrefRangeEnd = 1017266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncrementInstruction.IncrementInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060017EA RID: 6122 RVA: 0x000733F0 File Offset: 0x000715F0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IncrementInt16()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncrementInstruction.IncrementInt16>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncrementInstruction.IncrementInt16.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060017EB RID: 6123 RVA: 0x00009BB6 File Offset: 0x00007DB6
			public IncrementInt16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001085 RID: 4229
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001086 RID: 4230
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000247 RID: 583
		public sealed class IncrementInt32 : IncrementInstruction
		{
			// Token: 0x060017EC RID: 6124 RVA: 0x0007342C File Offset: 0x0007162C
			// Note: this type is marked as 'beforefieldinit'.
			static IncrementInt32()
			{
				Il2CppClassPointerStore<IncrementInstruction.IncrementInt32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IncrementInstruction>.NativeClassPtr, "IncrementInt32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncrementInstruction.IncrementInt32>.NativeClassPtr);
				IncrementInstruction.IncrementInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementInstruction.IncrementInt32>.NativeClassPtr, 100665231);
				IncrementInstruction.IncrementInt32.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementInstruction.IncrementInt32>.NativeClassPtr, 100665232);
			}

			// Token: 0x060017ED RID: 6125 RVA: 0x00073480 File Offset: 0x00071680
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1017266, XrefRangeEnd = 1017273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncrementInstruction.IncrementInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060017EE RID: 6126 RVA: 0x000734D0 File Offset: 0x000716D0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IncrementInt32()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncrementInstruction.IncrementInt32>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncrementInstruction.IncrementInt32.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060017EF RID: 6127 RVA: 0x00009BBF File Offset: 0x00007DBF
			public IncrementInt32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001087 RID: 4231
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001088 RID: 4232
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000248 RID: 584
		public sealed class IncrementInt64 : IncrementInstruction
		{
			// Token: 0x060017F0 RID: 6128 RVA: 0x0007350C File Offset: 0x0007170C
			// Note: this type is marked as 'beforefieldinit'.
			static IncrementInt64()
			{
				Il2CppClassPointerStore<IncrementInstruction.IncrementInt64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IncrementInstruction>.NativeClassPtr, "IncrementInt64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncrementInstruction.IncrementInt64>.NativeClassPtr);
				IncrementInstruction.IncrementInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementInstruction.IncrementInt64>.NativeClassPtr, 100665233);
				IncrementInstruction.IncrementInt64.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementInstruction.IncrementInt64>.NativeClassPtr, 100665234);
			}

			// Token: 0x060017F1 RID: 6129 RVA: 0x00073560 File Offset: 0x00071760
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1017273, XrefRangeEnd = 1017281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncrementInstruction.IncrementInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060017F2 RID: 6130 RVA: 0x000735B0 File Offset: 0x000717B0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IncrementInt64()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncrementInstruction.IncrementInt64>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncrementInstruction.IncrementInt64.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060017F3 RID: 6131 RVA: 0x00009BC8 File Offset: 0x00007DC8
			public IncrementInt64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001089 RID: 4233
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x0400108A RID: 4234
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000249 RID: 585
		public sealed class IncrementUInt16 : IncrementInstruction
		{
			// Token: 0x060017F4 RID: 6132 RVA: 0x000735EC File Offset: 0x000717EC
			// Note: this type is marked as 'beforefieldinit'.
			static IncrementUInt16()
			{
				Il2CppClassPointerStore<IncrementInstruction.IncrementUInt16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IncrementInstruction>.NativeClassPtr, "IncrementUInt16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncrementInstruction.IncrementUInt16>.NativeClassPtr);
				IncrementInstruction.IncrementUInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementInstruction.IncrementUInt16>.NativeClassPtr, 100665235);
				IncrementInstruction.IncrementUInt16.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementInstruction.IncrementUInt16>.NativeClassPtr, 100665236);
			}

			// Token: 0x060017F5 RID: 6133 RVA: 0x00073640 File Offset: 0x00071840
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1017281, XrefRangeEnd = 1017285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncrementInstruction.IncrementUInt16.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060017F6 RID: 6134 RVA: 0x00073690 File Offset: 0x00071890
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IncrementUInt16()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncrementInstruction.IncrementUInt16>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncrementInstruction.IncrementUInt16.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060017F7 RID: 6135 RVA: 0x00009BD1 File Offset: 0x00007DD1
			public IncrementUInt16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400108B RID: 4235
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x0400108C RID: 4236
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200024A RID: 586
		public sealed class IncrementUInt32 : IncrementInstruction
		{
			// Token: 0x060017F8 RID: 6136 RVA: 0x000736CC File Offset: 0x000718CC
			// Note: this type is marked as 'beforefieldinit'.
			static IncrementUInt32()
			{
				Il2CppClassPointerStore<IncrementInstruction.IncrementUInt32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IncrementInstruction>.NativeClassPtr, "IncrementUInt32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncrementInstruction.IncrementUInt32>.NativeClassPtr);
				IncrementInstruction.IncrementUInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementInstruction.IncrementUInt32>.NativeClassPtr, 100665237);
				IncrementInstruction.IncrementUInt32.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementInstruction.IncrementUInt32>.NativeClassPtr, 100665238);
			}

			// Token: 0x060017F9 RID: 6137 RVA: 0x00073720 File Offset: 0x00071920
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1017285, XrefRangeEnd = 1017293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncrementInstruction.IncrementUInt32.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060017FA RID: 6138 RVA: 0x00073770 File Offset: 0x00071970
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IncrementUInt32()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncrementInstruction.IncrementUInt32>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncrementInstruction.IncrementUInt32.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060017FB RID: 6139 RVA: 0x00009BDA File Offset: 0x00007DDA
			public IncrementUInt32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400108D RID: 4237
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x0400108E RID: 4238
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200024B RID: 587
		public sealed class IncrementUInt64 : IncrementInstruction
		{
			// Token: 0x060017FC RID: 6140 RVA: 0x000737AC File Offset: 0x000719AC
			// Note: this type is marked as 'beforefieldinit'.
			static IncrementUInt64()
			{
				Il2CppClassPointerStore<IncrementInstruction.IncrementUInt64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IncrementInstruction>.NativeClassPtr, "IncrementUInt64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncrementInstruction.IncrementUInt64>.NativeClassPtr);
				IncrementInstruction.IncrementUInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementInstruction.IncrementUInt64>.NativeClassPtr, 100665239);
				IncrementInstruction.IncrementUInt64.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementInstruction.IncrementUInt64>.NativeClassPtr, 100665240);
			}

			// Token: 0x060017FD RID: 6141 RVA: 0x00073800 File Offset: 0x00071A00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1017293, XrefRangeEnd = 1017301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncrementInstruction.IncrementUInt64.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060017FE RID: 6142 RVA: 0x00073850 File Offset: 0x00071A50
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IncrementUInt64()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncrementInstruction.IncrementUInt64>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncrementInstruction.IncrementUInt64.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060017FF RID: 6143 RVA: 0x00009BE3 File Offset: 0x00007DE3
			public IncrementUInt64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400108F RID: 4239
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001090 RID: 4240
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200024C RID: 588
		public sealed class IncrementSingle : IncrementInstruction
		{
			// Token: 0x06001800 RID: 6144 RVA: 0x0007388C File Offset: 0x00071A8C
			// Note: this type is marked as 'beforefieldinit'.
			static IncrementSingle()
			{
				Il2CppClassPointerStore<IncrementInstruction.IncrementSingle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IncrementInstruction>.NativeClassPtr, "IncrementSingle");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncrementInstruction.IncrementSingle>.NativeClassPtr);
				IncrementInstruction.IncrementSingle.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementInstruction.IncrementSingle>.NativeClassPtr, 100665241);
				IncrementInstruction.IncrementSingle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementInstruction.IncrementSingle>.NativeClassPtr, 100665242);
			}

			// Token: 0x06001801 RID: 6145 RVA: 0x000738E0 File Offset: 0x00071AE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1017301, XrefRangeEnd = 1017309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncrementInstruction.IncrementSingle.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001802 RID: 6146 RVA: 0x00073930 File Offset: 0x00071B30
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IncrementSingle()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncrementInstruction.IncrementSingle>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncrementInstruction.IncrementSingle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001803 RID: 6147 RVA: 0x00009BEC File Offset: 0x00007DEC
			public IncrementSingle(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001091 RID: 4241
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001092 RID: 4242
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200024D RID: 589
		public sealed class IncrementDouble : IncrementInstruction
		{
			// Token: 0x06001804 RID: 6148 RVA: 0x0007396C File Offset: 0x00071B6C
			// Note: this type is marked as 'beforefieldinit'.
			static IncrementDouble()
			{
				Il2CppClassPointerStore<IncrementInstruction.IncrementDouble>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IncrementInstruction>.NativeClassPtr, "IncrementDouble");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncrementInstruction.IncrementDouble>.NativeClassPtr);
				IncrementInstruction.IncrementDouble.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementInstruction.IncrementDouble>.NativeClassPtr, 100665243);
				IncrementInstruction.IncrementDouble.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncrementInstruction.IncrementDouble>.NativeClassPtr, 100665244);
			}

			// Token: 0x06001805 RID: 6149 RVA: 0x000739C0 File Offset: 0x00071BC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1017309, XrefRangeEnd = 1017317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncrementInstruction.IncrementDouble.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001806 RID: 6150 RVA: 0x00073A10 File Offset: 0x00071C10
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IncrementDouble()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncrementInstruction.IncrementDouble>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncrementInstruction.IncrementDouble.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001807 RID: 6151 RVA: 0x00009BF5 File Offset: 0x00007DF5
			public IncrementDouble(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001093 RID: 4243
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001094 RID: 4244
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
