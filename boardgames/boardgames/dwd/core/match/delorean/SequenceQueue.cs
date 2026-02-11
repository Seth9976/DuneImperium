using System;
using System.Runtime.InteropServices;
using Canis.messages;
using dwd.core.commands;
using dwd.core.match.sequence;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.ObjectModel;

namespace dwd.core.match.delorean
{
	// Token: 0x020000A3 RID: 163
	public class SequenceQueue : Object
	{
		// Token: 0x060007C8 RID: 1992 RVA: 0x000298C8 File Offset: 0x00027AC8
		// Note: this type is marked as 'beforefieldinit'.
		static SequenceQueue()
		{
			Il2CppClassPointerStore<SequenceQueue>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "dwd.core.match.delorean", "SequenceQueue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceQueue>.NativeClassPtr);
			SequenceQueue.NativeFieldInfoPtr_autoSequenceMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceQueue>.NativeClassPtr, "autoSequenceMessages");
			SequenceQueue.NativeFieldInfoPtr_blockage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceQueue>.NativeClassPtr, "blockage");
			SequenceQueue.NativeFieldInfoPtr_commandQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceQueue>.NativeClassPtr, "commandQueue");
			SequenceQueue.NativeFieldInfoPtr_factory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceQueue>.NativeClassPtr, "factory");
			SequenceQueue.NativeFieldInfoPtr_sequenceParser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceQueue>.NativeClassPtr, "sequenceParser");
			SequenceQueue.NativeFieldInfoPtr_blocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceQueue>.NativeClassPtr, "blocker");
			SequenceQueue.NativeFieldInfoPtr_SequenceGenerated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceQueue>.NativeClassPtr, "SequenceGenerated");
			SequenceQueue.NativeMethodInfoPtr_add_SequenceGenerated_Public_add_Void_Action_1_SequenceElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceQueue>.NativeClassPtr, 100664531);
			SequenceQueue.NativeMethodInfoPtr_remove_SequenceGenerated_Public_rem_Void_Action_1_SequenceElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceQueue>.NativeClassPtr, 100664532);
			SequenceQueue.NativeMethodInfoPtr__ctor_Public_Void_SequenceCommandFactory_ICommandQueue_ISequenceBlockage_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceQueue>.NativeClassPtr, 100664533);
			SequenceQueue.NativeMethodInfoPtr_get_Blocking_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceQueue>.NativeClassPtr, 100664534);
			SequenceQueue.NativeMethodInfoPtr_Enqueue_Public_Virtual_Final_New_Void_IGameMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceQueue>.NativeClassPtr, 100664535);
			SequenceQueue.NativeMethodInfoPtr_Enqueue_Public_Virtual_Final_New_Void_IGameMessage_byref_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceQueue>.NativeClassPtr, 100664536);
			SequenceQueue.NativeMethodInfoPtr_parseCommand_Private_Command_SequenceElement_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceQueue>.NativeClassPtr, 100664537);
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x00029A10 File Offset: 0x00027C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991031, XrefRangeEnd = 991036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_SequenceGenerated(Action<SequenceElement> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceQueue.NativeMethodInfoPtr_add_SequenceGenerated_Public_add_Void_Action_1_SequenceElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x00029A54 File Offset: 0x00027C54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991036, XrefRangeEnd = 991041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_SequenceGenerated(Action<SequenceElement> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceQueue.NativeMethodInfoPtr_remove_SequenceGenerated_Public_rem_Void_Action_1_SequenceElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x00029A98 File Offset: 0x00027C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991041, XrefRangeEnd = 991076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceQueue(SequenceCommandFactory factory, ICommandQueue commandQueue, ISequenceBlockage blockage, [Optional] Il2CppReferenceArray<Type> messagesToAutoSequence)
		{
			if (messagesToAutoSequence == null)
			{
				messagesToAutoSequence = new Il2CppReferenceArray<Type>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceQueue>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(factory);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(commandQueue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(blockage);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(messagesToAutoSequence);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceQueue.NativeMethodInfoPtr__ctor_Public_Void_SequenceCommandFactory_ICommandQueue_ISequenceBlockage_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x060007CC RID: 1996 RVA: 0x00029B28 File Offset: 0x00027D28
		public unsafe virtual bool Blocking
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991076, XrefRangeEnd = 991080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceQueue.NativeMethodInfoPtr_get_Blocking_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x00029B64 File Offset: 0x00027D64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991080, XrefRangeEnd = 991081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Enqueue(IGameMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceQueue.NativeMethodInfoPtr_Enqueue_Public_Virtual_Final_New_Void_IGameMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x00029BA8 File Offset: 0x00027DA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 991116, RefRangeEnd = 991117, XrefRangeStart = 991081, XrefRangeEnd = 991116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Enqueue(IGameMessage message, out ErrorInfo error)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SequenceQueue.NativeMethodInfoPtr_Enqueue_Public_Virtual_Final_New_Void_IGameMessage_byref_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			error = ((intPtr4 == 0) ? null : new ErrorInfo(intPtr4));
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x00029C0C File Offset: 0x00027E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991117, XrefRangeEnd = 991121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Command parseCommand(SequenceElement element, out bool isBlocker)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isBlocker;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceQueue.NativeMethodInfoPtr_parseCommand_Private_Command_SequenceElement_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x0000583E File Offset: 0x00003A3E
		public SequenceQueue(SequenceCommandFactory factory, ICommandQueue commandQueue, ISequenceBlockage blockage, params Type[] messagesToAutoSequence)
			: this(factory, commandQueue, blockage, new Il2CppReferenceArray<Type>(messagesToAutoSequence))
		{
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x00005850 File Offset: 0x00003A50
		public SequenceQueue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x060007D2 RID: 2002 RVA: 0x00029C6C File Offset: 0x00027E6C
		// (set) Token: 0x060007D3 RID: 2003 RVA: 0x00005859 File Offset: 0x00003A59
		public unsafe ReadOnlyCollection<Type> autoSequenceMessages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceQueue.NativeFieldInfoPtr_autoSequenceMessages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceQueue.NativeFieldInfoPtr_autoSequenceMessages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x060007D4 RID: 2004 RVA: 0x00029C9C File Offset: 0x00027E9C
		// (set) Token: 0x060007D5 RID: 2005 RVA: 0x00005878 File Offset: 0x00003A78
		public unsafe ISequenceBlockage blockage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceQueue.NativeFieldInfoPtr_blockage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISequenceBlockage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceQueue.NativeFieldInfoPtr_blockage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x060007D6 RID: 2006 RVA: 0x00029CCC File Offset: 0x00027ECC
		// (set) Token: 0x060007D7 RID: 2007 RVA: 0x00005897 File Offset: 0x00003A97
		public unsafe ICommandQueue commandQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceQueue.NativeFieldInfoPtr_commandQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICommandQueue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceQueue.NativeFieldInfoPtr_commandQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x060007D8 RID: 2008 RVA: 0x00029CFC File Offset: 0x00027EFC
		// (set) Token: 0x060007D9 RID: 2009 RVA: 0x000058B6 File Offset: 0x00003AB6
		public unsafe SequenceCommandFactory factory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceQueue.NativeFieldInfoPtr_factory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceCommandFactory>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceQueue.NativeFieldInfoPtr_factory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060007DA RID: 2010 RVA: 0x00029D2C File Offset: 0x00027F2C
		// (set) Token: 0x060007DB RID: 2011 RVA: 0x000058D5 File Offset: 0x00003AD5
		public unsafe SequenceParser sequenceParser
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceQueue.NativeFieldInfoPtr_sequenceParser);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceParser>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceQueue.NativeFieldInfoPtr_sequenceParser), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x060007DC RID: 2012 RVA: 0x00029D5C File Offset: 0x00027F5C
		// (set) Token: 0x060007DD RID: 2013 RVA: 0x000058F4 File Offset: 0x00003AF4
		public unsafe Command blocker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceQueue.NativeFieldInfoPtr_blocker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Command>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceQueue.NativeFieldInfoPtr_blocker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x060007DE RID: 2014 RVA: 0x00029D8C File Offset: 0x00027F8C
		// (set) Token: 0x060007DF RID: 2015 RVA: 0x00005913 File Offset: 0x00003B13
		public unsafe Action<SequenceElement> SequenceGenerated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceQueue.NativeFieldInfoPtr_SequenceGenerated);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SequenceElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceQueue.NativeFieldInfoPtr_SequenceGenerated), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004BE RID: 1214
		private static readonly IntPtr NativeFieldInfoPtr_autoSequenceMessages;

		// Token: 0x040004BF RID: 1215
		private static readonly IntPtr NativeFieldInfoPtr_blockage;

		// Token: 0x040004C0 RID: 1216
		private static readonly IntPtr NativeFieldInfoPtr_commandQueue;

		// Token: 0x040004C1 RID: 1217
		private static readonly IntPtr NativeFieldInfoPtr_factory;

		// Token: 0x040004C2 RID: 1218
		private static readonly IntPtr NativeFieldInfoPtr_sequenceParser;

		// Token: 0x040004C3 RID: 1219
		private static readonly IntPtr NativeFieldInfoPtr_blocker;

		// Token: 0x040004C4 RID: 1220
		private static readonly IntPtr NativeFieldInfoPtr_SequenceGenerated;

		// Token: 0x040004C5 RID: 1221
		private static readonly IntPtr NativeMethodInfoPtr_add_SequenceGenerated_Public_add_Void_Action_1_SequenceElement_0;

		// Token: 0x040004C6 RID: 1222
		private static readonly IntPtr NativeMethodInfoPtr_remove_SequenceGenerated_Public_rem_Void_Action_1_SequenceElement_0;

		// Token: 0x040004C7 RID: 1223
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SequenceCommandFactory_ICommandQueue_ISequenceBlockage_Il2CppReferenceArray_1_Type_0;

		// Token: 0x040004C8 RID: 1224
		private static readonly IntPtr NativeMethodInfoPtr_get_Blocking_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040004C9 RID: 1225
		private static readonly IntPtr NativeMethodInfoPtr_Enqueue_Public_Virtual_Final_New_Void_IGameMessage_0;

		// Token: 0x040004CA RID: 1226
		private static readonly IntPtr NativeMethodInfoPtr_Enqueue_Public_Virtual_Final_New_Void_IGameMessage_byref_ErrorInfo_0;

		// Token: 0x040004CB RID: 1227
		private static readonly IntPtr NativeMethodInfoPtr_parseCommand_Private_Command_SequenceElement_byref_Boolean_0;
	}
}
