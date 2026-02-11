using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace products.rewards
{
	// Token: 0x02000007 RID: 7
	public class RewardDefinition : Object
	{
		// Token: 0x06000016 RID: 22 RVA: 0x000039B4 File Offset: 0x00001BB4
		// Note: this type is marked as 'beforefieldinit'.
		static RewardDefinition()
		{
			Il2CppClassPointerStore<RewardDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Attributes.dll", "products.rewards", "RewardDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RewardDefinition>.NativeClassPtr);
			RewardDefinition.NativeFieldInfoPtr_RewardType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewardDefinition>.NativeClassPtr, "RewardType");
			RewardDefinition.NativeFieldInfoPtr_RewardAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewardDefinition>.NativeClassPtr, "RewardAmount");
			RewardDefinition.NativeFieldInfoPtr_Flavor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewardDefinition>.NativeClassPtr, "Flavor");
			RewardDefinition.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewardDefinition>.NativeClassPtr, 100663304);
			RewardDefinition.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewardDefinition>.NativeClassPtr, 100663305);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00003A48 File Offset: 0x00001C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215062, XrefRangeEnd = 1215080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RewardDefinition.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00003A8C File Offset: 0x00001C8C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RewardDefinition()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RewardDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewardDefinition.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002129 File Offset: 0x00000329
		public RewardDefinition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00003AC8 File Offset: 0x00001CC8
		// (set) Token: 0x0600001B RID: 27 RVA: 0x00002132 File Offset: 0x00000332
		public unsafe string RewardType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewardDefinition.NativeFieldInfoPtr_RewardType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewardDefinition.NativeFieldInfoPtr_RewardType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00003AF0 File Offset: 0x00001CF0
		// (set) Token: 0x0600001D RID: 29 RVA: 0x00002151 File Offset: 0x00000351
		public unsafe int RewardAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewardDefinition.NativeFieldInfoPtr_RewardAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewardDefinition.NativeFieldInfoPtr_RewardAmount)) = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00003B18 File Offset: 0x00001D18
		// (set) Token: 0x0600001F RID: 31 RVA: 0x0000216C File Offset: 0x0000036C
		public unsafe string Flavor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewardDefinition.NativeFieldInfoPtr_Flavor);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewardDefinition.NativeFieldInfoPtr_Flavor), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeFieldInfoPtr_RewardType;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeFieldInfoPtr_RewardAmount;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeFieldInfoPtr_Flavor;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
