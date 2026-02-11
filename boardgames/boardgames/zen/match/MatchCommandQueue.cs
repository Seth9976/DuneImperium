using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace zen.match
{
	// Token: 0x02000044 RID: 68
	public class MatchCommandQueue : CommandQueue
	{
		// Token: 0x060002AE RID: 686 RVA: 0x00019A24 File Offset: 0x00017C24
		// Note: this type is marked as 'beforefieldinit'.
		static MatchCommandQueue()
		{
			Il2CppClassPointerStore<MatchCommandQueue>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.match", "MatchCommandQueue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchCommandQueue>.NativeClassPtr);
			MatchCommandQueue.NativeFieldInfoPtr_pausers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchCommandQueue>.NativeClassPtr, "pausers");
			MatchCommandQueue.NativeMethodInfoPtr_getIsDequeuePaused_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchCommandQueue>.NativeClassPtr, 100663775);
			MatchCommandQueue.NativeMethodInfoPtr_RemoveWhere_Public_Void_Func_2_Command_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchCommandQueue>.NativeClassPtr, 100663776);
			MatchCommandQueue.NativeMethodInfoPtr_Register_Public_Void_IPauseCommandQueue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchCommandQueue>.NativeClassPtr, 100663777);
			MatchCommandQueue.NativeMethodInfoPtr_Unregister_Public_Void_IPauseCommandQueue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchCommandQueue>.NativeClassPtr, 100663778);
			MatchCommandQueue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchCommandQueue>.NativeClassPtr, 100663779);
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00019ACC File Offset: 0x00017CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985269, XrefRangeEnd = 985288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool getIsDequeuePaused()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MatchCommandQueue.NativeMethodInfoPtr_getIsDequeuePaused_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00019B14 File Offset: 0x00017D14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 985314, RefRangeEnd = 985315, XrefRangeStart = 985288, XrefRangeEnd = 985314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveWhere(Func<Command, bool> filterPredicate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(filterPredicate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchCommandQueue.NativeMethodInfoPtr_RemoveWhere_Public_Void_Func_2_Command_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00019B58 File Offset: 0x00017D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985315, XrefRangeEnd = 985319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Register(IPauseCommandQueue pauser)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pauser);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchCommandQueue.NativeMethodInfoPtr_Register_Public_Void_IPauseCommandQueue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00019B9C File Offset: 0x00017D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985319, XrefRangeEnd = 985323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unregister(IPauseCommandQueue pauser)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pauser);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchCommandQueue.NativeMethodInfoPtr_Unregister_Public_Void_IPauseCommandQueue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00019BE0 File Offset: 0x00017DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985323, XrefRangeEnd = 985331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MatchCommandQueue()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchCommandQueue>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchCommandQueue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x000032BE File Offset: 0x000014BE
		public MatchCommandQueue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x00019C1C File Offset: 0x00017E1C
		// (set) Token: 0x060002B6 RID: 694 RVA: 0x000032C7 File Offset: 0x000014C7
		public unsafe HashSet<IPauseCommandQueue> pausers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchCommandQueue.NativeFieldInfoPtr_pausers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<IPauseCommandQueue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchCommandQueue.NativeFieldInfoPtr_pausers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001B8 RID: 440
		private static readonly IntPtr NativeFieldInfoPtr_pausers;

		// Token: 0x040001B9 RID: 441
		private static readonly IntPtr NativeMethodInfoPtr_getIsDequeuePaused_Protected_Virtual_Boolean_0;

		// Token: 0x040001BA RID: 442
		private static readonly IntPtr NativeMethodInfoPtr_RemoveWhere_Public_Void_Func_2_Command_Boolean_0;

		// Token: 0x040001BB RID: 443
		private static readonly IntPtr NativeMethodInfoPtr_Register_Public_Void_IPauseCommandQueue_0;

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeMethodInfoPtr_Unregister_Public_Void_IPauseCommandQueue_0;

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
