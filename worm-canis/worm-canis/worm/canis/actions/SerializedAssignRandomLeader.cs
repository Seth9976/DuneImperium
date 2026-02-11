using System;
using Canis;
using Canis.actions;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace worm.canis.actions
{
	// Token: 0x0200022D RID: 557
	public class SerializedAssignRandomLeader : SerializedAssignLeader
	{
		// Token: 0x06001884 RID: 6276 RVA: 0x000B850C File Offset: 0x000B670C
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedAssignRandomLeader()
		{
			Il2CppClassPointerStore<SerializedAssignRandomLeader>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "SerializedAssignRandomLeader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedAssignRandomLeader>.NativeClassPtr);
			SerializedAssignRandomLeader.NativeFieldInfoPtr_Options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedAssignRandomLeader>.NativeClassPtr, "Options");
			SerializedAssignRandomLeader.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedAssignRandomLeader>.NativeClassPtr, 100667514);
			SerializedAssignRandomLeader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedAssignRandomLeader>.NativeClassPtr, 100667515);
		}

		// Token: 0x06001885 RID: 6277 RVA: 0x000B8578 File Offset: 0x000B6778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132284, XrefRangeEnd = 132290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedAssignRandomLeader.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001886 RID: 6278 RVA: 0x000B85D4 File Offset: 0x000B67D4
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedAssignRandomLeader()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedAssignRandomLeader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedAssignRandomLeader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001887 RID: 6279 RVA: 0x0000A9A5 File Offset: 0x00008BA5
		public SerializedAssignRandomLeader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x06001888 RID: 6280 RVA: 0x000B8610 File Offset: 0x000B6810
		// (set) Token: 0x06001889 RID: 6281 RVA: 0x0000A9AE File Offset: 0x00008BAE
		public unsafe List<ArchetypeID> Options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedAssignRandomLeader.NativeFieldInfoPtr_Options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedAssignRandomLeader.NativeFieldInfoPtr_Options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F2B RID: 3883
		private static readonly IntPtr NativeFieldInfoPtr_Options;

		// Token: 0x04000F2C RID: 3884
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000F2D RID: 3885
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
