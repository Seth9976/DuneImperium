using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using offlineChallenges;

namespace zen.src.challenges.definitions
{
	// Token: 0x02000014 RID: 20
	public class BaseChallengeDefinition : ChallengeDefinition
	{
		// Token: 0x060000D1 RID: 209 RVA: 0x00005560 File Offset: 0x00003760
		// Note: this type is marked as 'beforefieldinit'.
		static BaseChallengeDefinition()
		{
			Il2CppClassPointerStore<BaseChallengeDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("offlineChallenges.dll", "zen.src.challenges.definitions", "BaseChallengeDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseChallengeDefinition>.NativeClassPtr);
			BaseChallengeDefinition.NativeFieldInfoPtr_locKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseChallengeDefinition>.NativeClassPtr, "locKey");
			BaseChallengeDefinition.NativeFieldInfoPtr__Icon_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseChallengeDefinition>.NativeClassPtr, "<Icon>k__BackingField");
			BaseChallengeDefinition.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseChallengeDefinition>.NativeClassPtr, 100663417);
			BaseChallengeDefinition.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseChallengeDefinition>.NativeClassPtr, 100663418);
			BaseChallengeDefinition.NativeMethodInfoPtr_get_Icon_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseChallengeDefinition>.NativeClassPtr, 100663419);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000055F4 File Offset: 0x000037F4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1261204, RefRangeEnd = 1261208, XrefRangeStart = 1261188, XrefRangeEnd = 1261204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseChallengeDefinition(int id, string locKey, string icon, int amount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseChallengeDefinition>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(locKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(icon);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseChallengeDefinition.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00005670 File Offset: 0x00003870
		public unsafe override string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261208, XrefRangeEnd = 1261220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseChallengeDefinition.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x000056B4 File Offset: 0x000038B4
		public unsafe override string Icon
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseChallengeDefinition.NativeMethodInfoPtr_get_Icon_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x000025E6 File Offset: 0x000007E6
		public BaseChallengeDefinition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x000056F8 File Offset: 0x000038F8
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x000025EF File Offset: 0x000007EF
		public unsafe string locKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseChallengeDefinition.NativeFieldInfoPtr_locKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseChallengeDefinition.NativeFieldInfoPtr_locKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00005720 File Offset: 0x00003920
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x0000260E File Offset: 0x0000080E
		public unsafe string _Icon_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseChallengeDefinition.NativeFieldInfoPtr__Icon_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseChallengeDefinition.NativeFieldInfoPtr__Icon_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeFieldInfoPtr_locKey;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeFieldInfoPtr__Icon_k__BackingField;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_String_String_Int32_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_get_Icon_Public_Virtual_get_String_0;
	}
}
