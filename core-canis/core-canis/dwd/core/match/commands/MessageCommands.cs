using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace dwd.core.match.commands
{
	// Token: 0x02000170 RID: 368
	public class MessageCommands : Object
	{
		// Token: 0x0600152F RID: 5423 RVA: 0x00068C04 File Offset: 0x00066E04
		// Note: this type is marked as 'beforefieldinit'.
		static MessageCommands()
		{
			Il2CppClassPointerStore<MessageCommands>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.commands", "MessageCommands");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageCommands>.NativeClassPtr);
			MessageCommands.NativeFieldInfoPtr_transLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageCommands>.NativeClassPtr, "transLookup");
			MessageCommands.NativeFieldInfoPtr_SEP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageCommands>.NativeClassPtr, "SEP");
			MessageCommands.NativeFieldInfoPtr_LoggingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageCommands>.NativeClassPtr, "LoggingEnabled");
			MessageCommands.NativeFieldInfoPtr_shouldIgnoreMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageCommands>.NativeClassPtr, "shouldIgnoreMessage");
			MessageCommands.NativeMethodInfoPtr__ctor_Public_Void_Predicate_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageCommands>.NativeClassPtr, 100666495);
			MessageCommands.NativeMethodInfoPtr_Create_Public_Virtual_Final_New_Command_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageCommands>.NativeClassPtr, 100666496);
			MessageCommands.NativeMethodInfoPtr_GetCommand_Public_Command_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageCommands>.NativeClassPtr, 100666497);
			MessageCommands.NativeMethodInfoPtr_getCommand_Private_Command_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageCommands>.NativeClassPtr, 100666498);
			MessageCommands.NativeMethodInfoPtr_Reset_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageCommands>.NativeClassPtr, 100666499);
			MessageCommands.NativeMethodInfoPtr_Initialize_Public_Static_Void_IEnumerable_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageCommands>.NativeClassPtr, 100666500);
			MessageCommands.NativeMethodInfoPtr_getError_Private_Static_String_String_Type_IDictionary_2_ConstructorInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageCommands>.NativeClassPtr, 100666501);
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x00068D10 File Offset: 0x00066F10
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 320067, RefRangeEnd = 320078, XrefRangeStart = 320067, XrefRangeEnd = 320078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessageCommands(Predicate<Object> shouldIgnore)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessageCommands>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shouldIgnore);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageCommands.NativeMethodInfoPtr__ctor_Public_Void_Predicate_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x00068D5C File Offset: 0x00066F5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875642, XrefRangeEnd = 875654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Command Create(Object message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageCommands.NativeMethodInfoPtr_Create_Public_Virtual_Final_New_Command_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
			}
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x00068DAC File Offset: 0x00066FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Command GetCommand(Object message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageCommands.NativeMethodInfoPtr_GetCommand_Public_Command_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
			}
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x00068DFC File Offset: 0x00066FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875654, XrefRangeEnd = 875699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Command getCommand(Object arg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageCommands.NativeMethodInfoPtr_getCommand_Private_Command_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
			}
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x00068E4C File Offset: 0x0006704C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875699, XrefRangeEnd = 875713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Reset()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageCommands.NativeMethodInfoPtr_Reset_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x00068E74 File Offset: 0x00067074
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 875895, RefRangeEnd = 875896, XrefRangeStart = 875713, XrefRangeEnd = 875895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize(IEnumerable<Type> types)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(types);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageCommands.NativeMethodInfoPtr_Initialize_Public_Static_Void_IEnumerable_1_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x00068EAC File Offset: 0x000670AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 875947, RefRangeEnd = 875949, XrefRangeStart = 875896, XrefRangeEnd = 875947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string getError(string prefix, Type messageType, IDictionary<ConstructorInfo, bool> pairs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(messageType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pairs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageCommands.NativeMethodInfoPtr_getError_Private_Static_String_String_Type_IDictionary_2_ConstructorInfo_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x000095C2 File Offset: 0x000077C2
		public MessageCommands(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06001538 RID: 5432 RVA: 0x00068F0C File Offset: 0x0006710C
		// (set) Token: 0x06001539 RID: 5433 RVA: 0x000095CB File Offset: 0x000077CB
		public unsafe static ReadOnlyDictionary<Type, MessageCommands.Translator> transLookup
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MessageCommands.NativeFieldInfoPtr_transLookup, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyDictionary<Type, MessageCommands.Translator>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MessageCommands.NativeFieldInfoPtr_transLookup, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x0600153A RID: 5434 RVA: 0x00068F34 File Offset: 0x00067134
		// (set) Token: 0x0600153B RID: 5435 RVA: 0x000095DD File Offset: 0x000077DD
		public unsafe static string SEP
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MessageCommands.NativeFieldInfoPtr_SEP, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MessageCommands.NativeFieldInfoPtr_SEP, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x0600153C RID: 5436 RVA: 0x00068F54 File Offset: 0x00067154
		// (set) Token: 0x0600153D RID: 5437 RVA: 0x000095EF File Offset: 0x000077EF
		public unsafe bool LoggingEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageCommands.NativeFieldInfoPtr_LoggingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageCommands.NativeFieldInfoPtr_LoggingEnabled)) = value;
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x0600153E RID: 5438 RVA: 0x00068F7C File Offset: 0x0006717C
		// (set) Token: 0x0600153F RID: 5439 RVA: 0x0000960A File Offset: 0x0000780A
		public unsafe Predicate<Object> shouldIgnoreMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageCommands.NativeFieldInfoPtr_shouldIgnoreMessage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageCommands.NativeFieldInfoPtr_shouldIgnoreMessage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F16 RID: 3862
		private static readonly IntPtr NativeFieldInfoPtr_transLookup;

		// Token: 0x04000F17 RID: 3863
		private static readonly IntPtr NativeFieldInfoPtr_SEP;

		// Token: 0x04000F18 RID: 3864
		private static readonly IntPtr NativeFieldInfoPtr_LoggingEnabled;

		// Token: 0x04000F19 RID: 3865
		private static readonly IntPtr NativeFieldInfoPtr_shouldIgnoreMessage;

		// Token: 0x04000F1A RID: 3866
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Predicate_1_Object_0;

		// Token: 0x04000F1B RID: 3867
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Virtual_Final_New_Command_Object_0;

		// Token: 0x04000F1C RID: 3868
		private static readonly IntPtr NativeMethodInfoPtr_GetCommand_Public_Command_Object_0;

		// Token: 0x04000F1D RID: 3869
		private static readonly IntPtr NativeMethodInfoPtr_getCommand_Private_Command_Object_0;

		// Token: 0x04000F1E RID: 3870
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Static_Void_0;

		// Token: 0x04000F1F RID: 3871
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_IEnumerable_1_Type_0;

		// Token: 0x04000F20 RID: 3872
		private static readonly IntPtr NativeMethodInfoPtr_getError_Private_Static_String_String_Type_IDictionary_2_ConstructorInfo_Boolean_0;

		// Token: 0x020002EA RID: 746
		public sealed class Translator : ValueType
		{
			// Token: 0x0600228D RID: 8845 RVA: 0x00099240 File Offset: 0x00097440
			// Note: this type is marked as 'beforefieldinit'.
			static Translator()
			{
				Il2CppClassPointerStore<MessageCommands.Translator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MessageCommands>.NativeClassPtr, "Translator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageCommands.Translator>.NativeClassPtr);
				MessageCommands.Translator.NativeFieldInfoPtr_invoke = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageCommands.Translator>.NativeClassPtr, "invoke");
				MessageCommands.Translator.NativeMethodInfoPtr__ctor_Public_Void_Func_2_Il2CppReferenceArray_1_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageCommands.Translator>.NativeClassPtr, 100666503);
				MessageCommands.Translator.NativeMethodInfoPtr_Invoke_Public_Command_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageCommands.Translator>.NativeClassPtr, 100666504);
			}

			// Token: 0x0600228E RID: 8846 RVA: 0x000992A8 File Offset: 0x000974A8
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Translator(Func<Il2CppReferenceArray<Object>, Object> invoke)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessageCommands.Translator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(invoke);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageCommands.Translator.NativeMethodInfoPtr__ctor_Public_Void_Func_2_Il2CppReferenceArray_1_Object_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600228F RID: 8847 RVA: 0x000992F8 File Offset: 0x000974F8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 875639, RefRangeEnd = 875640, XrefRangeStart = 875632, XrefRangeEnd = 875639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Command Invoke(Object message)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageCommands.Translator.NativeMethodInfoPtr_Invoke_Public_Command_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
				}
			}

			// Token: 0x06002290 RID: 8848 RVA: 0x0000ED86 File Offset: 0x0000CF86
			public Translator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002291 RID: 8849 RVA: 0x0000ED8F File Offset: 0x0000CF8F
			public Translator()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessageCommands.Translator>.NativeClassPtr))
			{
			}

			// Token: 0x17000972 RID: 2418
			// (get) Token: 0x06002292 RID: 8850 RVA: 0x00099350 File Offset: 0x00097550
			// (set) Token: 0x06002293 RID: 8851 RVA: 0x0000EDA1 File Offset: 0x0000CFA1
			public unsafe Func<Il2CppReferenceArray<Object>, Object> invoke
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageCommands.Translator.NativeFieldInfoPtr_invoke);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Il2CppReferenceArray<Object>, Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageCommands.Translator.NativeFieldInfoPtr_invoke), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017DE RID: 6110
			private static readonly IntPtr NativeFieldInfoPtr_invoke;

			// Token: 0x040017DF RID: 6111
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_2_Il2CppReferenceArray_1_Object_Object_0;

			// Token: 0x040017E0 RID: 6112
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Command_Object_0;
		}

		// Token: 0x020002EB RID: 747
		[ObfuscatedName("dwd.core.match.commands.MessageCommands+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002294 RID: 8852 RVA: 0x00099380 File Offset: 0x00097580
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MessageCommands.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MessageCommands>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageCommands.__c>.NativeClassPtr);
				MessageCommands.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageCommands.__c>.NativeClassPtr, "<>9");
				MessageCommands.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageCommands.__c>.NativeClassPtr, "<>9__10_0");
				MessageCommands.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageCommands.__c>.NativeClassPtr, 100666506);
				MessageCommands.__c.NativeMethodInfoPtr__getError_b__10_0_Internal_String_KeyValuePair_2_ConstructorInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageCommands.__c>.NativeClassPtr, 100666507);
			}

			// Token: 0x06002295 RID: 8853 RVA: 0x000993FC File Offset: 0x000975FC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessageCommands.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageCommands.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002296 RID: 8854 RVA: 0x00099438 File Offset: 0x00097638
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875640, XrefRangeEnd = 875642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _getError_b__10_0(KeyValuePair<ConstructorInfo, bool> pair)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pair));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageCommands.__c.NativeMethodInfoPtr__getError_b__10_0_Internal_String_KeyValuePair_2_ConstructorInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06002297 RID: 8855 RVA: 0x0000EDC0 File Offset: 0x0000CFC0
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000973 RID: 2419
			// (get) Token: 0x06002298 RID: 8856 RVA: 0x00099488 File Offset: 0x00097688
			// (set) Token: 0x06002299 RID: 8857 RVA: 0x0000EDC9 File Offset: 0x0000CFC9
			public unsafe static MessageCommands.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MessageCommands.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MessageCommands.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MessageCommands.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000974 RID: 2420
			// (get) Token: 0x0600229A RID: 8858 RVA: 0x000994B0 File Offset: 0x000976B0
			// (set) Token: 0x0600229B RID: 8859 RVA: 0x0000EDDB File Offset: 0x0000CFDB
			public unsafe static Func<KeyValuePair<ConstructorInfo, bool>, string> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MessageCommands.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<ConstructorInfo, bool>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MessageCommands.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017E1 RID: 6113
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040017E2 RID: 6114
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x040017E3 RID: 6115
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040017E4 RID: 6116
			private static readonly IntPtr NativeMethodInfoPtr__getError_b__10_0_Internal_String_KeyValuePair_2_ConstructorInfo_Boolean_0;
		}
	}
}
