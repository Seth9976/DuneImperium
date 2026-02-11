using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000E3 RID: 227
	public class InitializeLocalInstruction : LocalAccessInstruction
	{
		// Token: 0x06000DBF RID: 3519 RVA: 0x000061DF File Offset: 0x000043DF
		// Note: this type is marked as 'beforefieldinit'.
		static InitializeLocalInstruction()
		{
			Il2CppClassPointerStore<InitializeLocalInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "InitializeLocalInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitializeLocalInstruction>.NativeClassPtr);
			InitializeLocalInstruction.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeLocalInstruction>.NativeClassPtr, 100665800);
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x0004D0A8 File Offset: 0x0004B2A8
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 346333, RefRangeEnd = 346361, XrefRangeStart = 346333, XrefRangeEnd = 346361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InitializeLocalInstruction(int index)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitializeLocalInstruction>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeLocalInstruction.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x00006218 File Offset: 0x00004418
		public InitializeLocalInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A24 RID: 2596
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

		// Token: 0x020002B7 RID: 695
		public sealed class Reference : InitializeLocalInstruction
		{
			// Token: 0x06001923 RID: 6435 RVA: 0x00079F44 File Offset: 0x00078144
			// Note: this type is marked as 'beforefieldinit'.
			static Reference()
			{
				Il2CppClassPointerStore<InitializeLocalInstruction.Reference>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InitializeLocalInstruction>.NativeClassPtr, "Reference");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitializeLocalInstruction.Reference>.NativeClassPtr);
				InitializeLocalInstruction.Reference.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeLocalInstruction.Reference>.NativeClassPtr, 100665801);
				InitializeLocalInstruction.Reference.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeLocalInstruction.Reference>.NativeClassPtr, 100665802);
				InitializeLocalInstruction.Reference.NativeMethodInfoPtr_BoxIfIndexMatches_Public_Virtual_Final_New_Instruction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeLocalInstruction.Reference>.NativeClassPtr, 100665803);
				InitializeLocalInstruction.Reference.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeLocalInstruction.Reference>.NativeClassPtr, 100665804);
			}

			// Token: 0x06001924 RID: 6436 RVA: 0x00079FC0 File Offset: 0x000781C0
			[CallerCount(28)]
			[CachedScanResults(RefRangeStart = 346333, RefRangeEnd = 346361, XrefRangeStart = 346333, XrefRangeEnd = 346361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Reference(int index)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitializeLocalInstruction.Reference>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeLocalInstruction.Reference.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001925 RID: 6437 RVA: 0x0007A008 File Offset: 0x00078208
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024688, XrefRangeEnd = 1024689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeLocalInstruction.Reference.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001926 RID: 6438 RVA: 0x0007A058 File Offset: 0x00078258
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024689, XrefRangeEnd = 1024693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Instruction BoxIfIndexMatches(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeLocalInstruction.Reference.NativeMethodInfoPtr_BoxIfIndexMatches_Public_Virtual_Final_New_Instruction_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
				}
			}

			// Token: 0x170006BF RID: 1727
			// (get) Token: 0x06001927 RID: 6439 RVA: 0x0007A0A4 File Offset: 0x000782A4
			public unsafe override string InstructionName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024693, XrefRangeEnd = 1024695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeLocalInstruction.Reference.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06001928 RID: 6440 RVA: 0x00009FE4 File Offset: 0x000081E4
			public Reference(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400114D RID: 4429
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

			// Token: 0x0400114E RID: 4430
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x0400114F RID: 4431
			private static readonly IntPtr NativeMethodInfoPtr_BoxIfIndexMatches_Public_Virtual_Final_New_Instruction_Int32_0;

			// Token: 0x04001150 RID: 4432
			private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;
		}

		// Token: 0x020002B8 RID: 696
		public sealed class ImmutableValue : InitializeLocalInstruction
		{
			// Token: 0x06001929 RID: 6441 RVA: 0x0007A0DC File Offset: 0x000782DC
			// Note: this type is marked as 'beforefieldinit'.
			static ImmutableValue()
			{
				Il2CppClassPointerStore<InitializeLocalInstruction.ImmutableValue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InitializeLocalInstruction>.NativeClassPtr, "ImmutableValue");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitializeLocalInstruction.ImmutableValue>.NativeClassPtr);
				InitializeLocalInstruction.ImmutableValue.NativeFieldInfoPtr__defaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeLocalInstruction.ImmutableValue>.NativeClassPtr, "_defaultValue");
				InitializeLocalInstruction.ImmutableValue.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeLocalInstruction.ImmutableValue>.NativeClassPtr, 100665805);
				InitializeLocalInstruction.ImmutableValue.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeLocalInstruction.ImmutableValue>.NativeClassPtr, 100665806);
				InitializeLocalInstruction.ImmutableValue.NativeMethodInfoPtr_BoxIfIndexMatches_Public_Virtual_Final_New_Instruction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeLocalInstruction.ImmutableValue>.NativeClassPtr, 100665807);
				InitializeLocalInstruction.ImmutableValue.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeLocalInstruction.ImmutableValue>.NativeClassPtr, 100665808);
			}

			// Token: 0x0600192A RID: 6442 RVA: 0x0007A16C File Offset: 0x0007836C
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 971651, RefRangeEnd = 971655, XrefRangeStart = 971651, XrefRangeEnd = 971655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ImmutableValue(int index, Object defaultValue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitializeLocalInstruction.ImmutableValue>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultValue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeLocalInstruction.ImmutableValue.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600192B RID: 6443 RVA: 0x0007A1C8 File Offset: 0x000783C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024695, XrefRangeEnd = 1024697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeLocalInstruction.ImmutableValue.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600192C RID: 6444 RVA: 0x0007A218 File Offset: 0x00078418
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024697, XrefRangeEnd = 1024702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Instruction BoxIfIndexMatches(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeLocalInstruction.ImmutableValue.NativeMethodInfoPtr_BoxIfIndexMatches_Public_Virtual_Final_New_Instruction_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
				}
			}

			// Token: 0x170006C1 RID: 1729
			// (get) Token: 0x0600192D RID: 6445 RVA: 0x0007A264 File Offset: 0x00078464
			public unsafe override string InstructionName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024702, XrefRangeEnd = 1024704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeLocalInstruction.ImmutableValue.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600192E RID: 6446 RVA: 0x00009FED File Offset: 0x000081ED
			public ImmutableValue(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006C0 RID: 1728
			// (get) Token: 0x0600192F RID: 6447 RVA: 0x0007A29C File Offset: 0x0007849C
			// (set) Token: 0x06001930 RID: 6448 RVA: 0x00009FF6 File Offset: 0x000081F6
			public unsafe Object _defaultValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeLocalInstruction.ImmutableValue.NativeFieldInfoPtr__defaultValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeLocalInstruction.ImmutableValue.NativeFieldInfoPtr__defaultValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001151 RID: 4433
			private static readonly IntPtr NativeFieldInfoPtr__defaultValue;

			// Token: 0x04001152 RID: 4434
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Object_0;

			// Token: 0x04001153 RID: 4435
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001154 RID: 4436
			private static readonly IntPtr NativeMethodInfoPtr_BoxIfIndexMatches_Public_Virtual_Final_New_Instruction_Int32_0;

			// Token: 0x04001155 RID: 4437
			private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;
		}

		// Token: 0x020002B9 RID: 697
		public sealed class ImmutableBox : InitializeLocalInstruction
		{
			// Token: 0x06001931 RID: 6449 RVA: 0x0007A2CC File Offset: 0x000784CC
			// Note: this type is marked as 'beforefieldinit'.
			static ImmutableBox()
			{
				Il2CppClassPointerStore<InitializeLocalInstruction.ImmutableBox>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InitializeLocalInstruction>.NativeClassPtr, "ImmutableBox");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitializeLocalInstruction.ImmutableBox>.NativeClassPtr);
				InitializeLocalInstruction.ImmutableBox.NativeFieldInfoPtr__defaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeLocalInstruction.ImmutableBox>.NativeClassPtr, "_defaultValue");
				InitializeLocalInstruction.ImmutableBox.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeLocalInstruction.ImmutableBox>.NativeClassPtr, 100665809);
				InitializeLocalInstruction.ImmutableBox.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeLocalInstruction.ImmutableBox>.NativeClassPtr, 100665810);
				InitializeLocalInstruction.ImmutableBox.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeLocalInstruction.ImmutableBox>.NativeClassPtr, 100665811);
			}

			// Token: 0x06001932 RID: 6450 RVA: 0x0007A348 File Offset: 0x00078548
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 971651, RefRangeEnd = 971655, XrefRangeStart = 971651, XrefRangeEnd = 971655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ImmutableBox(int index, Object defaultValue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitializeLocalInstruction.ImmutableBox>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultValue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeLocalInstruction.ImmutableBox.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001933 RID: 6451 RVA: 0x0007A3A4 File Offset: 0x000785A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024704, XrefRangeEnd = 1024712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeLocalInstruction.ImmutableBox.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170006C3 RID: 1731
			// (get) Token: 0x06001934 RID: 6452 RVA: 0x0007A3F4 File Offset: 0x000785F4
			public unsafe override string InstructionName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024712, XrefRangeEnd = 1024714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeLocalInstruction.ImmutableBox.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06001935 RID: 6453 RVA: 0x0000A015 File Offset: 0x00008215
			public ImmutableBox(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006C2 RID: 1730
			// (get) Token: 0x06001936 RID: 6454 RVA: 0x0007A42C File Offset: 0x0007862C
			// (set) Token: 0x06001937 RID: 6455 RVA: 0x0000A01E File Offset: 0x0000821E
			public unsafe Object _defaultValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeLocalInstruction.ImmutableBox.NativeFieldInfoPtr__defaultValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeLocalInstruction.ImmutableBox.NativeFieldInfoPtr__defaultValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001156 RID: 4438
			private static readonly IntPtr NativeFieldInfoPtr__defaultValue;

			// Token: 0x04001157 RID: 4439
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Object_0;

			// Token: 0x04001158 RID: 4440
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001159 RID: 4441
			private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;
		}

		// Token: 0x020002BA RID: 698
		public sealed class ImmutableRefBox : InitializeLocalInstruction
		{
			// Token: 0x06001938 RID: 6456 RVA: 0x0007A45C File Offset: 0x0007865C
			// Note: this type is marked as 'beforefieldinit'.
			static ImmutableRefBox()
			{
				Il2CppClassPointerStore<InitializeLocalInstruction.ImmutableRefBox>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InitializeLocalInstruction>.NativeClassPtr, "ImmutableRefBox");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitializeLocalInstruction.ImmutableRefBox>.NativeClassPtr);
				InitializeLocalInstruction.ImmutableRefBox.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeLocalInstruction.ImmutableRefBox>.NativeClassPtr, 100665812);
				InitializeLocalInstruction.ImmutableRefBox.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeLocalInstruction.ImmutableRefBox>.NativeClassPtr, 100665813);
				InitializeLocalInstruction.ImmutableRefBox.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeLocalInstruction.ImmutableRefBox>.NativeClassPtr, 100665814);
			}

			// Token: 0x06001939 RID: 6457 RVA: 0x0007A4C4 File Offset: 0x000786C4
			[CallerCount(28)]
			[CachedScanResults(RefRangeStart = 346333, RefRangeEnd = 346361, XrefRangeStart = 346333, XrefRangeEnd = 346361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ImmutableRefBox(int index)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitializeLocalInstruction.ImmutableRefBox>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeLocalInstruction.ImmutableRefBox.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600193A RID: 6458 RVA: 0x0007A50C File Offset: 0x0007870C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024714, XrefRangeEnd = 1024722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeLocalInstruction.ImmutableRefBox.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170006C4 RID: 1732
			// (get) Token: 0x0600193B RID: 6459 RVA: 0x0007A55C File Offset: 0x0007875C
			public unsafe override string InstructionName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024722, XrefRangeEnd = 1024724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeLocalInstruction.ImmutableRefBox.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600193C RID: 6460 RVA: 0x0000A03D File Offset: 0x0000823D
			public ImmutableRefBox(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400115A RID: 4442
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

			// Token: 0x0400115B RID: 4443
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x0400115C RID: 4444
			private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;
		}

		// Token: 0x020002BB RID: 699
		public sealed class ParameterBox : InitializeLocalInstruction
		{
			// Token: 0x0600193D RID: 6461 RVA: 0x0007A594 File Offset: 0x00078794
			// Note: this type is marked as 'beforefieldinit'.
			static ParameterBox()
			{
				Il2CppClassPointerStore<InitializeLocalInstruction.ParameterBox>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InitializeLocalInstruction>.NativeClassPtr, "ParameterBox");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitializeLocalInstruction.ParameterBox>.NativeClassPtr);
				InitializeLocalInstruction.ParameterBox.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeLocalInstruction.ParameterBox>.NativeClassPtr, 100665815);
				InitializeLocalInstruction.ParameterBox.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeLocalInstruction.ParameterBox>.NativeClassPtr, 100665816);
				InitializeLocalInstruction.ParameterBox.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeLocalInstruction.ParameterBox>.NativeClassPtr, 100665817);
			}

			// Token: 0x0600193E RID: 6462 RVA: 0x0007A5FC File Offset: 0x000787FC
			[CallerCount(28)]
			[CachedScanResults(RefRangeStart = 346333, RefRangeEnd = 346361, XrefRangeStart = 346333, XrefRangeEnd = 346361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ParameterBox(int index)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitializeLocalInstruction.ParameterBox>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeLocalInstruction.ParameterBox.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600193F RID: 6463 RVA: 0x0007A644 File Offset: 0x00078844
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024724, XrefRangeEnd = 1024732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeLocalInstruction.ParameterBox.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170006C5 RID: 1733
			// (get) Token: 0x06001940 RID: 6464 RVA: 0x0007A694 File Offset: 0x00078894
			public unsafe override string InstructionName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024732, XrefRangeEnd = 1024734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeLocalInstruction.ParameterBox.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06001941 RID: 6465 RVA: 0x0000A046 File Offset: 0x00008246
			public ParameterBox(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400115D RID: 4445
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400115E RID: 4446
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x0400115F RID: 4447
			private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;
		}

		// Token: 0x020002BC RID: 700
		public sealed class Parameter : InitializeLocalInstruction
		{
			// Token: 0x06001942 RID: 6466 RVA: 0x0007A6CC File Offset: 0x000788CC
			// Note: this type is marked as 'beforefieldinit'.
			static Parameter()
			{
				Il2CppClassPointerStore<InitializeLocalInstruction.Parameter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InitializeLocalInstruction>.NativeClassPtr, "Parameter");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitializeLocalInstruction.Parameter>.NativeClassPtr);
				InitializeLocalInstruction.Parameter.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeLocalInstruction.Parameter>.NativeClassPtr, 100665818);
				InitializeLocalInstruction.Parameter.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeLocalInstruction.Parameter>.NativeClassPtr, 100665819);
				InitializeLocalInstruction.Parameter.NativeMethodInfoPtr_BoxIfIndexMatches_Public_Virtual_Final_New_Instruction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeLocalInstruction.Parameter>.NativeClassPtr, 100665820);
				InitializeLocalInstruction.Parameter.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeLocalInstruction.Parameter>.NativeClassPtr, 100665821);
			}

			// Token: 0x06001943 RID: 6467 RVA: 0x0007A748 File Offset: 0x00078948
			[CallerCount(28)]
			[CachedScanResults(RefRangeStart = 346333, RefRangeEnd = 346361, XrefRangeStart = 346333, XrefRangeEnd = 346361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Parameter(int index)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitializeLocalInstruction.Parameter>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeLocalInstruction.Parameter.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001944 RID: 6468 RVA: 0x0007A790 File Offset: 0x00078990
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeLocalInstruction.Parameter.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001945 RID: 6469 RVA: 0x0007A7E0 File Offset: 0x000789E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024734, XrefRangeEnd = 1024735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Instruction BoxIfIndexMatches(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeLocalInstruction.Parameter.NativeMethodInfoPtr_BoxIfIndexMatches_Public_Virtual_Final_New_Instruction_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
				}
			}

			// Token: 0x170006C6 RID: 1734
			// (get) Token: 0x06001946 RID: 6470 RVA: 0x0007A82C File Offset: 0x00078A2C
			public unsafe override string InstructionName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024735, XrefRangeEnd = 1024737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeLocalInstruction.Parameter.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06001947 RID: 6471 RVA: 0x0000A04F File Offset: 0x0000824F
			public Parameter(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001160 RID: 4448
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

			// Token: 0x04001161 RID: 4449
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001162 RID: 4450
			private static readonly IntPtr NativeMethodInfoPtr_BoxIfIndexMatches_Public_Virtual_Final_New_Instruction_Int32_0;

			// Token: 0x04001163 RID: 4451
			private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;
		}

		// Token: 0x020002BD RID: 701
		public sealed class MutableValue : InitializeLocalInstruction
		{
			// Token: 0x06001948 RID: 6472 RVA: 0x0007A864 File Offset: 0x00078A64
			// Note: this type is marked as 'beforefieldinit'.
			static MutableValue()
			{
				Il2CppClassPointerStore<InitializeLocalInstruction.MutableValue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InitializeLocalInstruction>.NativeClassPtr, "MutableValue");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitializeLocalInstruction.MutableValue>.NativeClassPtr);
				InitializeLocalInstruction.MutableValue.NativeFieldInfoPtr__type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeLocalInstruction.MutableValue>.NativeClassPtr, "_type");
				InitializeLocalInstruction.MutableValue.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeLocalInstruction.MutableValue>.NativeClassPtr, 100665822);
				InitializeLocalInstruction.MutableValue.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeLocalInstruction.MutableValue>.NativeClassPtr, 100665823);
				InitializeLocalInstruction.MutableValue.NativeMethodInfoPtr_BoxIfIndexMatches_Public_Virtual_Final_New_Instruction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeLocalInstruction.MutableValue>.NativeClassPtr, 100665824);
				InitializeLocalInstruction.MutableValue.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeLocalInstruction.MutableValue>.NativeClassPtr, 100665825);
			}

			// Token: 0x06001949 RID: 6473 RVA: 0x0007A8F4 File Offset: 0x00078AF4
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 971651, RefRangeEnd = 971655, XrefRangeStart = 971651, XrefRangeEnd = 971655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MutableValue(int index, Type type)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitializeLocalInstruction.MutableValue>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeLocalInstruction.MutableValue.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600194A RID: 6474 RVA: 0x0007A950 File Offset: 0x00078B50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024737, XrefRangeEnd = 1024740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeLocalInstruction.MutableValue.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600194B RID: 6475 RVA: 0x0007A9A0 File Offset: 0x00078BA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024740, XrefRangeEnd = 1024745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Instruction BoxIfIndexMatches(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeLocalInstruction.MutableValue.NativeMethodInfoPtr_BoxIfIndexMatches_Public_Virtual_Final_New_Instruction_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
				}
			}

			// Token: 0x170006C8 RID: 1736
			// (get) Token: 0x0600194C RID: 6476 RVA: 0x0007A9EC File Offset: 0x00078BEC
			public unsafe override string InstructionName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024745, XrefRangeEnd = 1024747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeLocalInstruction.MutableValue.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600194D RID: 6477 RVA: 0x0000A058 File Offset: 0x00008258
			public MutableValue(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006C7 RID: 1735
			// (get) Token: 0x0600194E RID: 6478 RVA: 0x0007AA24 File Offset: 0x00078C24
			// (set) Token: 0x0600194F RID: 6479 RVA: 0x0000A061 File Offset: 0x00008261
			public unsafe Type _type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeLocalInstruction.MutableValue.NativeFieldInfoPtr__type);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeLocalInstruction.MutableValue.NativeFieldInfoPtr__type), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001164 RID: 4452
			private static readonly IntPtr NativeFieldInfoPtr__type;

			// Token: 0x04001165 RID: 4453
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Type_0;

			// Token: 0x04001166 RID: 4454
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x04001167 RID: 4455
			private static readonly IntPtr NativeMethodInfoPtr_BoxIfIndexMatches_Public_Virtual_Final_New_Instruction_Int32_0;

			// Token: 0x04001168 RID: 4456
			private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;
		}

		// Token: 0x020002BE RID: 702
		public sealed class MutableBox : InitializeLocalInstruction
		{
			// Token: 0x06001950 RID: 6480 RVA: 0x0007AA54 File Offset: 0x00078C54
			// Note: this type is marked as 'beforefieldinit'.
			static MutableBox()
			{
				Il2CppClassPointerStore<InitializeLocalInstruction.MutableBox>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InitializeLocalInstruction>.NativeClassPtr, "MutableBox");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitializeLocalInstruction.MutableBox>.NativeClassPtr);
				InitializeLocalInstruction.MutableBox.NativeFieldInfoPtr__type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeLocalInstruction.MutableBox>.NativeClassPtr, "_type");
				InitializeLocalInstruction.MutableBox.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeLocalInstruction.MutableBox>.NativeClassPtr, 100665826);
				InitializeLocalInstruction.MutableBox.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeLocalInstruction.MutableBox>.NativeClassPtr, 100665827);
				InitializeLocalInstruction.MutableBox.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeLocalInstruction.MutableBox>.NativeClassPtr, 100665828);
			}

			// Token: 0x06001951 RID: 6481 RVA: 0x0007AAD0 File Offset: 0x00078CD0
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 971651, RefRangeEnd = 971655, XrefRangeStart = 971651, XrefRangeEnd = 971655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MutableBox(int index, Type type)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitializeLocalInstruction.MutableBox>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeLocalInstruction.MutableBox.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001952 RID: 6482 RVA: 0x0007AB2C File Offset: 0x00078D2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024747, XrefRangeEnd = 1024756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Run(InterpretedFrame frame)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeLocalInstruction.MutableBox.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170006CA RID: 1738
			// (get) Token: 0x06001953 RID: 6483 RVA: 0x0007AB7C File Offset: 0x00078D7C
			public unsafe override string InstructionName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024756, XrefRangeEnd = 1024758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeLocalInstruction.MutableBox.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06001954 RID: 6484 RVA: 0x0000A080 File Offset: 0x00008280
			public MutableBox(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006C9 RID: 1737
			// (get) Token: 0x06001955 RID: 6485 RVA: 0x0007ABB4 File Offset: 0x00078DB4
			// (set) Token: 0x06001956 RID: 6486 RVA: 0x0000A089 File Offset: 0x00008289
			public unsafe Type _type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeLocalInstruction.MutableBox.NativeFieldInfoPtr__type);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializeLocalInstruction.MutableBox.NativeFieldInfoPtr__type), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001169 RID: 4457
			private static readonly IntPtr NativeFieldInfoPtr__type;

			// Token: 0x0400116A RID: 4458
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Type_0;

			// Token: 0x0400116B RID: 4459
			private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

			// Token: 0x0400116C RID: 4460
			private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;
		}
	}
}
