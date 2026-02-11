using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace boardgames.match.data
{
	// Token: 0x02000276 RID: 630
	public class EntityIndexData : DataComponent
	{
		// Token: 0x06001D7A RID: 7546 RVA: 0x0007F86C File Offset: 0x0007DA6C
		// Note: this type is marked as 'beforefieldinit'.
		static EntityIndexData()
		{
			Il2CppClassPointerStore<EntityIndexData>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.data", "EntityIndexData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityIndexData>.NativeClassPtr);
			EntityIndexData.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityIndexData>.NativeClassPtr, "index");
			EntityIndexData.NativeFieldInfoPtr__Version_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityIndexData>.NativeClassPtr, "<Version>k__BackingField");
			EntityIndexData.NativeMethodInfoPtr_get_Index_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityIndexData>.NativeClassPtr, 100668131);
			EntityIndexData.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityIndexData>.NativeClassPtr, 100668132);
			EntityIndexData.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityIndexData>.NativeClassPtr, 100668133);
			EntityIndexData.NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityIndexData>.NativeClassPtr, 100668134);
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x06001D7B RID: 7547 RVA: 0x0007F914 File Offset: 0x0007DB14
		public unsafe int Index
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityIndexData.NativeMethodInfoPtr_get_Index_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D7C RID: 7548 RVA: 0x0007F950 File Offset: 0x0007DB50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 537025, XrefRangeEnd = 537026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityIndexData(int index)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityIndexData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityIndexData.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x06001D7D RID: 7549 RVA: 0x0007F998 File Offset: 0x0007DB98
		// (set) Token: 0x06001D7E RID: 7550 RVA: 0x0007F9D4 File Offset: 0x0007DBD4
		public unsafe virtual ulong Version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityIndexData.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityIndexData.NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001D7F RID: 7551 RVA: 0x0000FA42 File Offset: 0x0000DC42
		public EntityIndexData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x06001D80 RID: 7552 RVA: 0x0007FA14 File Offset: 0x0007DC14
		// (set) Token: 0x06001D81 RID: 7553 RVA: 0x0000FA4B File Offset: 0x0000DC4B
		public unsafe int index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityIndexData.NativeFieldInfoPtr_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityIndexData.NativeFieldInfoPtr_index)) = value;
			}
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x06001D82 RID: 7554 RVA: 0x0007FA3C File Offset: 0x0007DC3C
		// (set) Token: 0x06001D83 RID: 7555 RVA: 0x0000FA66 File Offset: 0x0000DC66
		public unsafe ulong _Version_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityIndexData.NativeFieldInfoPtr__Version_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityIndexData.NativeFieldInfoPtr__Version_k__BackingField)) = value;
			}
		}

		// Token: 0x0400129A RID: 4762
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x0400129B RID: 4763
		private static readonly IntPtr NativeFieldInfoPtr__Version_k__BackingField;

		// Token: 0x0400129C RID: 4764
		private static readonly IntPtr NativeMethodInfoPtr_get_Index_Public_get_Int32_0;

		// Token: 0x0400129D RID: 4765
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400129E RID: 4766
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0;

		// Token: 0x0400129F RID: 4767
		private static readonly IntPtr NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0;
	}
}
