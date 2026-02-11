using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace boardgames.match.data
{
	// Token: 0x02000279 RID: 633
	public sealed class ReferencedEntityID : TypedID
	{
		// Token: 0x06001D96 RID: 7574 RVA: 0x0007FE68 File Offset: 0x0007E068
		// Note: this type is marked as 'beforefieldinit'.
		static ReferencedEntityID()
		{
			Il2CppClassPointerStore<ReferencedEntityID>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.data", "ReferencedEntityID");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReferencedEntityID>.NativeClassPtr);
			ReferencedEntityID.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferencedEntityID>.NativeClassPtr, 100668143);
			ReferencedEntityID.NativeMethodInfoPtr__ctor_Public_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferencedEntityID>.NativeClassPtr, 100668144);
			ReferencedEntityID.NativeMethodInfoPtr__ctor_Public_Void_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferencedEntityID>.NativeClassPtr, 100668145);
			ReferencedEntityID.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferencedEntityID>.NativeClassPtr, 100668146);
			ReferencedEntityID.NativeMethodInfoPtr_CreateID_Public_Static_TypedID_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferencedEntityID>.NativeClassPtr, 100668147);
			ReferencedEntityID.NativeMethodInfoPtr_op_Explicit_Public_Static_EntityID_ReferencedEntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferencedEntityID>.NativeClassPtr, 100668148);
		}

		// Token: 0x06001D97 RID: 7575 RVA: 0x0007FF10 File Offset: 0x0007E110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 537075, XrefRangeEnd = 537079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReferencedEntityID(string id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReferencedEntityID>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReferencedEntityID.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D98 RID: 7576 RVA: 0x0007FF5C File Offset: 0x0007E15C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 537079, XrefRangeEnd = 537083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReferencedEntityID(Guid id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReferencedEntityID>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReferencedEntityID.NativeMethodInfoPtr__ctor_Public_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D99 RID: 7577 RVA: 0x0007FFA4 File Offset: 0x0007E1A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 537087, RefRangeEnd = 537088, XrefRangeStart = 537083, XrefRangeEnd = 537087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReferencedEntityID(EntityID id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReferencedEntityID>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReferencedEntityID.NativeMethodInfoPtr__ctor_Public_Void_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D9A RID: 7578 RVA: 0x0007FFF0 File Offset: 0x0007E1F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 537088, XrefRangeEnd = 537093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReferencedEntityID()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReferencedEntityID>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReferencedEntityID.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D9B RID: 7579 RVA: 0x0008002C File Offset: 0x0007E22C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 537093, XrefRangeEnd = 537100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypedID CreateID(string guid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReferencedEntityID.NativeMethodInfoPtr_CreateID_Public_Static_TypedID_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypedID>(intPtr3) : null;
			}
		}

		// Token: 0x06001D9C RID: 7580 RVA: 0x00080070 File Offset: 0x0007E270
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 537101, RefRangeEnd = 537114, XrefRangeStart = 537100, XrefRangeEnd = 537101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator EntityID(ReferencedEntityID id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReferencedEntityID.NativeMethodInfoPtr_op_Explicit_Public_Static_EntityID_ReferencedEntityID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
			}
		}

		// Token: 0x06001D9D RID: 7581 RVA: 0x0000FAF0 File Offset: 0x0000DCF0
		public ReferencedEntityID(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040012AB RID: 4779
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040012AC RID: 4780
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_0;

		// Token: 0x040012AD RID: 4781
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityID_0;

		// Token: 0x040012AE RID: 4782
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040012AF RID: 4783
		private static readonly IntPtr NativeMethodInfoPtr_CreateID_Public_Static_TypedID_String_0;

		// Token: 0x040012B0 RID: 4784
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_EntityID_ReferencedEntityID_0;
	}
}
