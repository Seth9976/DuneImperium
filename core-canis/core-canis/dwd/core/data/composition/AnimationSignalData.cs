using System;
using dwd.core.data.readonlyWrappers;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.data.composition
{
	// Token: 0x020001D7 RID: 471
	public class AnimationSignalData : VersionedDataComponent
	{
		// Token: 0x060019EC RID: 6636 RVA: 0x0007AE90 File Offset: 0x00079090
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationSignalData()
		{
			Il2CppClassPointerStore<AnimationSignalData>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.data.composition", "AnimationSignalData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationSignalData>.NativeClassPtr);
			AnimationSignalData.NativeFieldInfoPtr_SetBools = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationSignalData>.NativeClassPtr, "SetBools");
			AnimationSignalData.NativeFieldInfoPtr_PendingTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationSignalData>.NativeClassPtr, "PendingTriggers");
			AnimationSignalData.NativeFieldInfoPtr_setBoolParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationSignalData>.NativeClassPtr, "setBoolParams");
			AnimationSignalData.NativeFieldInfoPtr_pendingTriggerParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationSignalData>.NativeClassPtr, "pendingTriggerParams");
			AnimationSignalData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationSignalData>.NativeClassPtr, 100667402);
			AnimationSignalData.NativeMethodInfoPtr_SetBool_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationSignalData>.NativeClassPtr, 100667403);
			AnimationSignalData.NativeMethodInfoPtr_SetTrigger_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationSignalData>.NativeClassPtr, 100667404);
			AnimationSignalData.NativeMethodInfoPtr_ConsumeTriggers_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationSignalData>.NativeClassPtr, 100667405);
			AnimationSignalData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationSignalData>.NativeClassPtr, 100667406);
		}

		// Token: 0x060019ED RID: 6637 RVA: 0x0007AF74 File Offset: 0x00079174
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 881901, RefRangeEnd = 881902, XrefRangeStart = 881875, XrefRangeEnd = 881901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationSignalData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationSignalData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationSignalData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019EE RID: 6638 RVA: 0x0007AFB0 File Offset: 0x000791B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 881902, XrefRangeEnd = 881909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBool(string param, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(param);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationSignalData.NativeMethodInfoPtr_SetBool_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019EF RID: 6639 RVA: 0x0007B000 File Offset: 0x00079200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 881909, XrefRangeEnd = 881912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTrigger(string param)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(param);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationSignalData.NativeMethodInfoPtr_SetTrigger_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019F0 RID: 6640 RVA: 0x0007B044 File Offset: 0x00079244
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 881915, RefRangeEnd = 881916, XrefRangeStart = 881912, XrefRangeEnd = 881915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConsumeTriggers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationSignalData.NativeMethodInfoPtr_ConsumeTriggers_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019F1 RID: 6641 RVA: 0x0007B078 File Offset: 0x00079278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 881916, XrefRangeEnd = 881925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimationSignalData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060019F2 RID: 6642 RVA: 0x0000B505 File Offset: 0x00009705
		public AnimationSignalData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x060019F3 RID: 6643 RVA: 0x0007B0BC File Offset: 0x000792BC
		// (set) Token: 0x060019F4 RID: 6644 RVA: 0x0000B50E File Offset: 0x0000970E
		public unsafe ReadOnlyHashSet<string> SetBools
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationSignalData.NativeFieldInfoPtr_SetBools);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyHashSet<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationSignalData.NativeFieldInfoPtr_SetBools), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x060019F5 RID: 6645 RVA: 0x0007B0EC File Offset: 0x000792EC
		// (set) Token: 0x060019F6 RID: 6646 RVA: 0x0000B52D File Offset: 0x0000972D
		public unsafe ReadOnlyHashSet<string> PendingTriggers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationSignalData.NativeFieldInfoPtr_PendingTriggers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyHashSet<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationSignalData.NativeFieldInfoPtr_PendingTriggers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x060019F7 RID: 6647 RVA: 0x0007B11C File Offset: 0x0007931C
		// (set) Token: 0x060019F8 RID: 6648 RVA: 0x0000B54C File Offset: 0x0000974C
		public unsafe HashSet<string> setBoolParams
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationSignalData.NativeFieldInfoPtr_setBoolParams);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationSignalData.NativeFieldInfoPtr_setBoolParams), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x060019F9 RID: 6649 RVA: 0x0007B14C File Offset: 0x0007934C
		// (set) Token: 0x060019FA RID: 6650 RVA: 0x0000B56B File Offset: 0x0000976B
		public unsafe HashSet<string> pendingTriggerParams
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationSignalData.NativeFieldInfoPtr_pendingTriggerParams);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationSignalData.NativeFieldInfoPtr_pendingTriggerParams), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400122E RID: 4654
		private static readonly IntPtr NativeFieldInfoPtr_SetBools;

		// Token: 0x0400122F RID: 4655
		private static readonly IntPtr NativeFieldInfoPtr_PendingTriggers;

		// Token: 0x04001230 RID: 4656
		private static readonly IntPtr NativeFieldInfoPtr_setBoolParams;

		// Token: 0x04001231 RID: 4657
		private static readonly IntPtr NativeFieldInfoPtr_pendingTriggerParams;

		// Token: 0x04001232 RID: 4658
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001233 RID: 4659
		private static readonly IntPtr NativeMethodInfoPtr_SetBool_Public_Void_String_Boolean_0;

		// Token: 0x04001234 RID: 4660
		private static readonly IntPtr NativeMethodInfoPtr_SetTrigger_Public_Void_String_0;

		// Token: 0x04001235 RID: 4661
		private static readonly IntPtr NativeMethodInfoPtr_ConsumeTriggers_Public_Void_0;

		// Token: 0x04001236 RID: 4662
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
