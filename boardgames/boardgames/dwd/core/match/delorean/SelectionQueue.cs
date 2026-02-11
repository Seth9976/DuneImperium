using System;
using Canis.messages;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.match.delorean
{
	// Token: 0x020000A2 RID: 162
	public class SelectionQueue : Object
	{
		// Token: 0x060007BA RID: 1978 RVA: 0x000295E4 File Offset: 0x000277E4
		// Note: this type is marked as 'beforefieldinit'.
		static SelectionQueue()
		{
			Il2CppClassPointerStore<SelectionQueue>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "dwd.core.match.delorean", "SelectionQueue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionQueue>.NativeClassPtr);
			SelectionQueue.NativeFieldInfoPtr_executor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionQueue>.NativeClassPtr, "executor");
			SelectionQueue.NativeFieldInfoPtr_model = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionQueue>.NativeClassPtr, "model");
			SelectionQueue.NativeFieldInfoPtr_commands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionQueue>.NativeClassPtr, "commands");
			SelectionQueue.NativeFieldInfoPtr_blocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionQueue>.NativeClassPtr, "blocker");
			SelectionQueue.NativeMethodInfoPtr__ctor_Public_Void_ISelectionModel_CommandExecutor_ISelectionCommandParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionQueue>.NativeClassPtr, 100664527);
			SelectionQueue.NativeMethodInfoPtr_get_Blocking_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionQueue>.NativeClassPtr, 100664528);
			SelectionQueue.NativeMethodInfoPtr_Enqueue_Public_Virtual_Final_New_Void_IGameMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionQueue>.NativeClassPtr, 100664529);
			SelectionQueue.NativeMethodInfoPtr_Enqueue_Public_Virtual_Final_New_Void_IGameMessage_byref_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionQueue>.NativeClassPtr, 100664530);
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x000296B4 File Offset: 0x000278B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990977, XrefRangeEnd = 991006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectionQueue(ISelectionModel model, CommandExecutor executor, ISelectionCommandParser commands)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionQueue>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(model);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(executor);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(commands);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionQueue.NativeMethodInfoPtr__ctor_Public_Void_ISelectionModel_CommandExecutor_ISelectionCommandParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x060007BC RID: 1980 RVA: 0x00029724 File Offset: 0x00027924
		public unsafe virtual bool Blocking
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionQueue.NativeMethodInfoPtr_get_Blocking_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x00029760 File Offset: 0x00027960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991006, XrefRangeEnd = 991007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Enqueue(IGameMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionQueue.NativeMethodInfoPtr_Enqueue_Public_Virtual_Final_New_Void_IGameMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x000297A4 File Offset: 0x000279A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 991030, RefRangeEnd = 991031, XrefRangeStart = 991007, XrefRangeEnd = 991030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SelectionQueue.NativeMethodInfoPtr_Enqueue_Public_Virtual_Final_New_Void_IGameMessage_byref_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			error = ((intPtr4 == 0) ? null : new ErrorInfo(intPtr4));
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x000057B9 File Offset: 0x000039B9
		public SelectionQueue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x060007C0 RID: 1984 RVA: 0x00029808 File Offset: 0x00027A08
		// (set) Token: 0x060007C1 RID: 1985 RVA: 0x000057C2 File Offset: 0x000039C2
		public unsafe CommandExecutor executor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionQueue.NativeFieldInfoPtr_executor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CommandExecutor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionQueue.NativeFieldInfoPtr_executor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x060007C2 RID: 1986 RVA: 0x00029838 File Offset: 0x00027A38
		// (set) Token: 0x060007C3 RID: 1987 RVA: 0x000057E1 File Offset: 0x000039E1
		public unsafe ISelectionModel model
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionQueue.NativeFieldInfoPtr_model);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISelectionModel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionQueue.NativeFieldInfoPtr_model), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x060007C4 RID: 1988 RVA: 0x00029868 File Offset: 0x00027A68
		// (set) Token: 0x060007C5 RID: 1989 RVA: 0x00005800 File Offset: 0x00003A00
		public unsafe ISelectionCommandParser commands
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionQueue.NativeFieldInfoPtr_commands);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISelectionCommandParser>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionQueue.NativeFieldInfoPtr_commands), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x060007C6 RID: 1990 RVA: 0x00029898 File Offset: 0x00027A98
		// (set) Token: 0x060007C7 RID: 1991 RVA: 0x0000581F File Offset: 0x00003A1F
		public unsafe Command blocker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionQueue.NativeFieldInfoPtr_blocker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Command>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionQueue.NativeFieldInfoPtr_blocker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004B6 RID: 1206
		private static readonly IntPtr NativeFieldInfoPtr_executor;

		// Token: 0x040004B7 RID: 1207
		private static readonly IntPtr NativeFieldInfoPtr_model;

		// Token: 0x040004B8 RID: 1208
		private static readonly IntPtr NativeFieldInfoPtr_commands;

		// Token: 0x040004B9 RID: 1209
		private static readonly IntPtr NativeFieldInfoPtr_blocker;

		// Token: 0x040004BA RID: 1210
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionModel_CommandExecutor_ISelectionCommandParser_0;

		// Token: 0x040004BB RID: 1211
		private static readonly IntPtr NativeMethodInfoPtr_get_Blocking_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040004BC RID: 1212
		private static readonly IntPtr NativeMethodInfoPtr_Enqueue_Public_Virtual_Final_New_Void_IGameMessage_0;

		// Token: 0x040004BD RID: 1213
		private static readonly IntPtr NativeMethodInfoPtr_Enqueue_Public_Virtual_Final_New_Void_IGameMessage_byref_ErrorInfo_0;
	}
}
