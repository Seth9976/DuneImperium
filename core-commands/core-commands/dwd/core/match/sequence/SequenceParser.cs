using System;
using Canis.attributes;
using Canis.messages;
using Canis.messages.sequence;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.match.sequence
{
	// Token: 0x0200000A RID: 10
	public class SequenceParser : Object
	{
		// Token: 0x0600003A RID: 58 RVA: 0x000053CC File Offset: 0x000035CC
		// Note: this type is marked as 'beforefieldinit'.
		static SequenceParser()
		{
			Il2CppClassPointerStore<SequenceParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-commands.dll", "dwd.core.match.sequence", "SequenceParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceParser>.NativeClassPtr);
			SequenceParser.NativeFieldInfoPtr_queue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceParser>.NativeClassPtr, "queue");
			SequenceParser.NativeFieldInfoPtr_sequences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceParser>.NativeClassPtr, "sequences");
			SequenceParser.NativeFieldInfoPtr_logging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceParser>.NativeClassPtr, "logging");
			SequenceParser.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceParser>.NativeClassPtr, 100663314);
			SequenceParser.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceParser>.NativeClassPtr, 100663315);
			SequenceParser.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceParser>.NativeClassPtr, 100663316);
			SequenceParser.NativeMethodInfoPtr_Enqueue_Public_Void_SequenceMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceParser>.NativeClassPtr, 100663317);
			SequenceParser.NativeMethodInfoPtr_Enqueue_Public_Void_SequenceMessage_byref_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceParser>.NativeClassPtr, 100663318);
			SequenceParser.NativeMethodInfoPtr_isNewSequenceMessage_Private_Boolean_IGameMessage_byref_String_byref_SequenceID_byref_ReadOnlyAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceParser>.NativeClassPtr, 100663319);
			SequenceParser.NativeMethodInfoPtr_isRemoveSequenceMessage_Private_Boolean_IGameMessage_byref_String_byref_SequenceID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceParser>.NativeClassPtr, 100663320);
			SequenceParser.NativeMethodInfoPtr_Dequeue_Public_SequenceElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceParser>.NativeClassPtr, 100663321);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000054D8 File Offset: 0x000036D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205891, XrefRangeEnd = 1205906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceParser()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceParser>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceParser.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00005514 File Offset: 0x00003714
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1205921, RefRangeEnd = 1205922, XrefRangeStart = 1205906, XrefRangeEnd = 1205921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceParser(bool logging)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceParser>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref logging;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceParser.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600003D RID: 61 RVA: 0x0000555C File Offset: 0x0000375C
		public unsafe int Count
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1205923, RefRangeEnd = 1205925, XrefRangeStart = 1205922, XrefRangeEnd = 1205923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceParser.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00005598 File Offset: 0x00003798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205925, XrefRangeEnd = 1205926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enqueue(SequenceMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceParser.NativeMethodInfoPtr_Enqueue_Public_Void_SequenceMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000055DC File Offset: 0x000037DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1206015, RefRangeEnd = 1206017, XrefRangeStart = 1205926, XrefRangeEnd = 1206015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enqueue(SequenceMessage message, out ErrorInfo error)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SequenceParser.NativeMethodInfoPtr_Enqueue_Public_Void_SequenceMessage_byref_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			error = ((intPtr4 == 0) ? null : new ErrorInfo(intPtr4));
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00005640 File Offset: 0x00003840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1206017, XrefRangeEnd = 1206036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool isNewSequenceMessage(IGameMessage gameMessage, out string name, out SequenceID sequenceID, out ReadOnlyAttributes attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameMessage);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr4 = &intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(SequenceParser.NativeMethodInfoPtr_isNewSequenceMessage_Private_Boolean_IGameMessage_byref_String_byref_SequenceID_byref_ReadOnlyAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			name = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr6 = intPtr2;
			sequenceID = ((intPtr6 == 0) ? null : new SequenceID(intPtr6));
			IntPtr intPtr7 = intPtr3;
			attributes = ((intPtr7 == 0) ? null : new ReadOnlyAttributes(intPtr7));
			return *IL2CPP.il2cpp_object_unbox(intPtr4);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000056F0 File Offset: 0x000038F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1206036, XrefRangeEnd = 1206056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool isRemoveSequenceMessage(IGameMessage gameMessage, out string name, out SequenceID sequenceID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameMessage);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SequenceParser.NativeMethodInfoPtr_isRemoveSequenceMessage_Private_Boolean_IGameMessage_byref_String_byref_SequenceID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			name = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			sequenceID = ((intPtr5 == 0) ? null : new SequenceID(intPtr5));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0000577C File Offset: 0x0000397C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1206060, RefRangeEnd = 1206061, XrefRangeStart = 1206056, XrefRangeEnd = 1206060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceElement Dequeue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceParser.NativeMethodInfoPtr_Dequeue_Public_SequenceElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceElement>(intPtr3) : null;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0000226E File Offset: 0x0000046E
		public SequenceParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000044 RID: 68 RVA: 0x000057BC File Offset: 0x000039BC
		// (set) Token: 0x06000045 RID: 69 RVA: 0x00002277 File Offset: 0x00000477
		public unsafe Queue<SequenceElement> queue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceParser.NativeFieldInfoPtr_queue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<SequenceElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceParser.NativeFieldInfoPtr_queue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000046 RID: 70 RVA: 0x000057EC File Offset: 0x000039EC
		// (set) Token: 0x06000047 RID: 71 RVA: 0x00002296 File Offset: 0x00000496
		public unsafe Stack<SequenceParser.InProgressSequence> sequences
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceParser.NativeFieldInfoPtr_sequences);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<SequenceParser.InProgressSequence>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceParser.NativeFieldInfoPtr_sequences), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000048 RID: 72 RVA: 0x0000581C File Offset: 0x00003A1C
		// (set) Token: 0x06000049 RID: 73 RVA: 0x000022B5 File Offset: 0x000004B5
		public unsafe bool logging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceParser.NativeFieldInfoPtr_logging);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceParser.NativeFieldInfoPtr_logging)) = value;
			}
		}

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeFieldInfoPtr_queue;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeFieldInfoPtr_sequences;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeFieldInfoPtr_logging;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_Enqueue_Public_Void_SequenceMessage_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_Enqueue_Public_Void_SequenceMessage_byref_ErrorInfo_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_isNewSequenceMessage_Private_Boolean_IGameMessage_byref_String_byref_SequenceID_byref_ReadOnlyAttributes_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_isRemoveSequenceMessage_Private_Boolean_IGameMessage_byref_String_byref_SequenceID_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_Dequeue_Public_SequenceElement_0;

		// Token: 0x0200003A RID: 58
		public class InProgressSequence : List<SequenceElement>
		{
			// Token: 0x06000220 RID: 544 RVA: 0x0000CDE8 File Offset: 0x0000AFE8
			// Note: this type is marked as 'beforefieldinit'.
			static InProgressSequence()
			{
				Il2CppClassPointerStore<SequenceParser.InProgressSequence>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequenceParser>.NativeClassPtr, "InProgressSequence");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceParser.InProgressSequence>.NativeClassPtr);
				SequenceParser.InProgressSequence.NativeFieldInfoPtr_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceParser.InProgressSequence>.NativeClassPtr, "Attributes");
				SequenceParser.InProgressSequence.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceParser.InProgressSequence>.NativeClassPtr, "Name");
				SequenceParser.InProgressSequence.NativeFieldInfoPtr_SequenceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceParser.InProgressSequence>.NativeClassPtr, "SequenceID");
				SequenceParser.InProgressSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_ReadOnlyAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceParser.InProgressSequence>.NativeClassPtr, 100663322);
				SequenceParser.InProgressSequence.NativeMethodInfoPtr_Export_Public_MatchSequence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceParser.InProgressSequence>.NativeClassPtr, 100663323);
			}

			// Token: 0x06000221 RID: 545 RVA: 0x0000CE78 File Offset: 0x0000B078
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205868, XrefRangeEnd = 1205877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InProgressSequence(SequenceID sequenceID, string name, ReadOnlyAttributes attributes)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceParser.InProgressSequence>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sequenceID);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceParser.InProgressSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_ReadOnlyAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000222 RID: 546 RVA: 0x0000CEE8 File Offset: 0x0000B0E8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1205889, RefRangeEnd = 1205891, XrefRangeStart = 1205877, XrefRangeEnd = 1205889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MatchSequence Export()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceParser.InProgressSequence.NativeMethodInfoPtr_Export_Public_MatchSequence_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MatchSequence>(intPtr3) : null;
			}

			// Token: 0x06000223 RID: 547 RVA: 0x00002E8B File Offset: 0x0000108B
			public InProgressSequence(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700006E RID: 110
			// (get) Token: 0x06000224 RID: 548 RVA: 0x0000CF28 File Offset: 0x0000B128
			// (set) Token: 0x06000225 RID: 549 RVA: 0x00002E94 File Offset: 0x00001094
			public unsafe ReadOnlyAttributes Attributes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceParser.InProgressSequence.NativeFieldInfoPtr_Attributes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceParser.InProgressSequence.NativeFieldInfoPtr_Attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700006F RID: 111
			// (get) Token: 0x06000226 RID: 550 RVA: 0x0000CF58 File Offset: 0x0000B158
			// (set) Token: 0x06000227 RID: 551 RVA: 0x00002EB3 File Offset: 0x000010B3
			public unsafe string Name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceParser.InProgressSequence.NativeFieldInfoPtr_Name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceParser.InProgressSequence.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000070 RID: 112
			// (get) Token: 0x06000228 RID: 552 RVA: 0x0000CF80 File Offset: 0x0000B180
			// (set) Token: 0x06000229 RID: 553 RVA: 0x00002ED2 File Offset: 0x000010D2
			public unsafe SequenceID SequenceID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceParser.InProgressSequence.NativeFieldInfoPtr_SequenceID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceParser.InProgressSequence.NativeFieldInfoPtr_SequenceID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400014E RID: 334
			private static readonly IntPtr NativeFieldInfoPtr_Attributes;

			// Token: 0x0400014F RID: 335
			private static readonly IntPtr NativeFieldInfoPtr_Name;

			// Token: 0x04000150 RID: 336
			private static readonly IntPtr NativeFieldInfoPtr_SequenceID;

			// Token: 0x04000151 RID: 337
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_ReadOnlyAttributes_0;

			// Token: 0x04000152 RID: 338
			private static readonly IntPtr NativeMethodInfoPtr_Export_Public_MatchSequence_0;
		}

		// Token: 0x0200003B RID: 59
		[ObfuscatedName("dwd.core.match.sequence.SequenceParser+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600022A RID: 554 RVA: 0x0000CFB0 File Offset: 0x0000B1B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SequenceParser.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequenceParser>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceParser.__c>.NativeClassPtr);
				SequenceParser.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceParser.__c>.NativeClassPtr, "<>9");
				SequenceParser.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceParser.__c>.NativeClassPtr, "<>9__8_0");
				SequenceParser.__c.NativeFieldInfoPtr___9__8_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceParser.__c>.NativeClassPtr, "<>9__8_1");
				SequenceParser.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceParser.__c>.NativeClassPtr, 100663325);
				SequenceParser.__c.NativeMethodInfoPtr__Enqueue_b__8_0_Internal_String_InProgressSequence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceParser.__c>.NativeClassPtr, 100663326);
				SequenceParser.__c.NativeMethodInfoPtr__Enqueue_b__8_1_Internal_String_InProgressSequence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceParser.__c>.NativeClassPtr, 100663327);
			}

			// Token: 0x0600022B RID: 555 RVA: 0x0000D054 File Offset: 0x0000B254
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceParser.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceParser.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600022C RID: 556 RVA: 0x0000D090 File Offset: 0x0000B290
			[CallerCount(0)]
			public unsafe string _Enqueue_b__8_0(SequenceParser.InProgressSequence s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceParser.__c.NativeMethodInfoPtr__Enqueue_b__8_0_Internal_String_InProgressSequence_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600022D RID: 557 RVA: 0x0000D0D8 File Offset: 0x0000B2D8
			[CallerCount(0)]
			public unsafe string _Enqueue_b__8_1(SequenceParser.InProgressSequence s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceParser.__c.NativeMethodInfoPtr__Enqueue_b__8_1_Internal_String_InProgressSequence_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600022E RID: 558 RVA: 0x00002EF1 File Offset: 0x000010F1
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000071 RID: 113
			// (get) Token: 0x0600022F RID: 559 RVA: 0x0000D120 File Offset: 0x0000B320
			// (set) Token: 0x06000230 RID: 560 RVA: 0x00002EFA File Offset: 0x000010FA
			public unsafe static SequenceParser.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SequenceParser.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceParser.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SequenceParser.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000072 RID: 114
			// (get) Token: 0x06000231 RID: 561 RVA: 0x0000D148 File Offset: 0x0000B348
			// (set) Token: 0x06000232 RID: 562 RVA: 0x00002F0C File Offset: 0x0000110C
			public unsafe static Func<SequenceParser.InProgressSequence, string> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SequenceParser.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SequenceParser.InProgressSequence, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SequenceParser.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000073 RID: 115
			// (get) Token: 0x06000233 RID: 563 RVA: 0x0000D170 File Offset: 0x0000B370
			// (set) Token: 0x06000234 RID: 564 RVA: 0x00002F1E File Offset: 0x0000111E
			public unsafe static Func<SequenceParser.InProgressSequence, string> __9__8_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SequenceParser.__c.NativeFieldInfoPtr___9__8_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SequenceParser.InProgressSequence, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SequenceParser.__c.NativeFieldInfoPtr___9__8_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000153 RID: 339
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000154 RID: 340
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x04000155 RID: 341
			private static readonly IntPtr NativeFieldInfoPtr___9__8_1;

			// Token: 0x04000156 RID: 342
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000157 RID: 343
			private static readonly IntPtr NativeMethodInfoPtr__Enqueue_b__8_0_Internal_String_InProgressSequence_0;

			// Token: 0x04000158 RID: 344
			private static readonly IntPtr NativeMethodInfoPtr__Enqueue_b__8_1_Internal_String_InProgressSequence_0;
		}
	}
}
