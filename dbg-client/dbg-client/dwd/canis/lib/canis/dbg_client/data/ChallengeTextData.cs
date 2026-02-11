using System;
using Canis;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.canis.lib.canis.dbg_client.data
{
	// Token: 0x0200005F RID: 95
	public class ChallengeTextData : DataComponent
	{
		// Token: 0x0600039C RID: 924 RVA: 0x00028FD0 File Offset: 0x000271D0
		// Note: this type is marked as 'beforefieldinit'.
		static ChallengeTextData()
		{
			Il2CppClassPointerStore<ChallengeTextData>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis.lib.canis.dbg_client.data", "ChallengeTextData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengeTextData>.NativeClassPtr);
			ChallengeTextData.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeTextData>.NativeClassPtr, "name");
			ChallengeTextData.NativeFieldInfoPtr_description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeTextData>.NativeClassPtr, "description");
			ChallengeTextData.NativeMethodInfoPtr__ctor_Public_Void_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeTextData>.NativeClassPtr, 100663858);
			ChallengeTextData.NativeMethodInfoPtr_GetText_Public_String_ChallengeTextType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeTextData>.NativeClassPtr, 100663859);
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00029050 File Offset: 0x00027250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499922, XrefRangeEnd = 499926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChallengeTextData(MatchInitData matchInitData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChallengeTextData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matchInitData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeTextData.NativeMethodInfoPtr__ctor_Public_Void_MatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600039E RID: 926 RVA: 0x0002909C File Offset: 0x0002729C
		[CallerCount(0)]
		public unsafe string GetText(ChallengeTextData.ChallengeTextType textType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref textType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeTextData.NativeMethodInfoPtr_GetText_Public_String_ChallengeTextType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0000393B File Offset: 0x00001B3B
		public ChallengeTextData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x000290E0 File Offset: 0x000272E0
		// (set) Token: 0x060003A1 RID: 929 RVA: 0x00003944 File Offset: 0x00001B44
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeTextData.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeTextData.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x00029108 File Offset: 0x00027308
		// (set) Token: 0x060003A3 RID: 931 RVA: 0x00003963 File Offset: 0x00001B63
		public unsafe string description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeTextData.NativeFieldInfoPtr_description);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeTextData.NativeFieldInfoPtr_description), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04000235 RID: 565
		private static readonly IntPtr NativeFieldInfoPtr_description;

		// Token: 0x04000236 RID: 566
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MatchInitData_0;

		// Token: 0x04000237 RID: 567
		private static readonly IntPtr NativeMethodInfoPtr_GetText_Public_String_ChallengeTextType_0;

		// Token: 0x020002EB RID: 747
		[Serializable]
		public enum ChallengeTextType
		{
			// Token: 0x0400162C RID: 5676
			Name,
			// Token: 0x0400162D RID: 5677
			Description
		}
	}
}
