using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.loader.caching
{
	// Token: 0x0200018E RID: 398
	public class ManualReferenceTracker : Object
	{
		// Token: 0x06001658 RID: 5720 RVA: 0x0006DA2C File Offset: 0x0006BC2C
		// Note: this type is marked as 'beforefieldinit'.
		static ManualReferenceTracker()
		{
			Il2CppClassPointerStore<ManualReferenceTracker>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.loader.caching", "ManualReferenceTracker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManualReferenceTracker>.NativeClassPtr);
			ManualReferenceTracker.NativeFieldInfoPtr_killed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManualReferenceTracker>.NativeClassPtr, "killed");
			ManualReferenceTracker.NativeFieldInfoPtr_wrappedTracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManualReferenceTracker>.NativeClassPtr, "wrappedTracker");
			ManualReferenceTracker.NativeFieldInfoPtr_manuallyDropped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManualReferenceTracker>.NativeClassPtr, "manuallyDropped");
			ManualReferenceTracker.NativeMethodInfoPtr__ctor_Public_Void_IReferenceTracker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualReferenceTracker>.NativeClassPtr, 100666716);
			ManualReferenceTracker.NativeMethodInfoPtr_DropReference_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualReferenceTracker>.NativeClassPtr, 100666717);
			ManualReferenceTracker.NativeMethodInfoPtr_StillAlive_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualReferenceTracker>.NativeClassPtr, 100666718);
			ManualReferenceTracker.NativeMethodInfoPtr_GetSourceName_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualReferenceTracker>.NativeClassPtr, 100666719);
			ManualReferenceTracker.NativeMethodInfoPtr_Kill_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualReferenceTracker>.NativeClassPtr, 100666720);
		}

		// Token: 0x06001659 RID: 5721 RVA: 0x0006DAFC File Offset: 0x0006BCFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 878220, RefRangeEnd = 878221, XrefRangeStart = 878218, XrefRangeEnd = 878220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManualReferenceTracker(IReferenceTracker wrappedTracker)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManualReferenceTracker>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wrappedTracker);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualReferenceTracker.NativeMethodInfoPtr__ctor_Public_Void_IReferenceTracker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600165A RID: 5722 RVA: 0x0006DB48 File Offset: 0x0006BD48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 497605, RefRangeEnd = 497606, XrefRangeStart = 497605, XrefRangeEnd = 497606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DropReference()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualReferenceTracker.NativeMethodInfoPtr_DropReference_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x0006DB7C File Offset: 0x0006BD7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878221, XrefRangeEnd = 878224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool StillAlive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualReferenceTracker.NativeMethodInfoPtr_StillAlive_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600165C RID: 5724 RVA: 0x0006DBB8 File Offset: 0x0006BDB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878224, XrefRangeEnd = 878231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSourceName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualReferenceTracker.NativeMethodInfoPtr_GetSourceName_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600165D RID: 5725 RVA: 0x0006DBF0 File Offset: 0x0006BDF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 478427, RefRangeEnd = 478428, XrefRangeStart = 478427, XrefRangeEnd = 478428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Kill()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualReferenceTracker.NativeMethodInfoPtr_Kill_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x00009C57 File Offset: 0x00007E57
		public ManualReferenceTracker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x0600165F RID: 5727 RVA: 0x0006DC24 File Offset: 0x0006BE24
		// (set) Token: 0x06001660 RID: 5728 RVA: 0x00009C60 File Offset: 0x00007E60
		public unsafe bool killed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManualReferenceTracker.NativeFieldInfoPtr_killed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManualReferenceTracker.NativeFieldInfoPtr_killed)) = value;
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06001661 RID: 5729 RVA: 0x0006DC4C File Offset: 0x0006BE4C
		// (set) Token: 0x06001662 RID: 5730 RVA: 0x00009C7B File Offset: 0x00007E7B
		public unsafe IReferenceTracker wrappedTracker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManualReferenceTracker.NativeFieldInfoPtr_wrappedTracker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReferenceTracker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManualReferenceTracker.NativeFieldInfoPtr_wrappedTracker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06001663 RID: 5731 RVA: 0x0006DC7C File Offset: 0x0006BE7C
		// (set) Token: 0x06001664 RID: 5732 RVA: 0x00009C9A File Offset: 0x00007E9A
		public unsafe bool manuallyDropped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManualReferenceTracker.NativeFieldInfoPtr_manuallyDropped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManualReferenceTracker.NativeFieldInfoPtr_manuallyDropped)) = value;
			}
		}

		// Token: 0x04000FD8 RID: 4056
		private static readonly IntPtr NativeFieldInfoPtr_killed;

		// Token: 0x04000FD9 RID: 4057
		private static readonly IntPtr NativeFieldInfoPtr_wrappedTracker;

		// Token: 0x04000FDA RID: 4058
		private static readonly IntPtr NativeFieldInfoPtr_manuallyDropped;

		// Token: 0x04000FDB RID: 4059
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IReferenceTracker_0;

		// Token: 0x04000FDC RID: 4060
		private static readonly IntPtr NativeMethodInfoPtr_DropReference_Public_Void_0;

		// Token: 0x04000FDD RID: 4061
		private static readonly IntPtr NativeMethodInfoPtr_StillAlive_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x04000FDE RID: 4062
		private static readonly IntPtr NativeMethodInfoPtr_GetSourceName_Public_Virtual_Final_New_String_0;

		// Token: 0x04000FDF RID: 4063
		private static readonly IntPtr NativeMethodInfoPtr_Kill_Public_Virtual_Final_New_Void_0;
	}
}
