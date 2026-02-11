using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Steamworks.Data;

namespace Steamworks.Ugc
{
	// Token: 0x020000D0 RID: 208
	public sealed class SteamParamStringArray : ValueType
	{
		// Token: 0x06000D07 RID: 3335 RVA: 0x00054B80 File Offset: 0x00052D80
		// Note: this type is marked as 'beforefieldinit'.
		static SteamParamStringArray()
		{
			Il2CppClassPointerStore<SteamParamStringArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Ugc", "SteamParamStringArray");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamParamStringArray>.NativeClassPtr);
			SteamParamStringArray.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamParamStringArray>.NativeClassPtr, "Value");
			SteamParamStringArray.NativeFieldInfoPtr_NativeStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamParamStringArray>.NativeClassPtr, "NativeStrings");
			SteamParamStringArray.NativeFieldInfoPtr_NativeArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamParamStringArray>.NativeClassPtr, "NativeArray");
			SteamParamStringArray.NativeMethodInfoPtr_From_Public_Static_SteamParamStringArray_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParamStringArray>.NativeClassPtr, 100666464);
			SteamParamStringArray.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParamStringArray>.NativeClassPtr, 100666465);
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x00054C14 File Offset: 0x00052E14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 948460, RefRangeEnd = 948461, XrefRangeStart = 948440, XrefRangeEnd = 948460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamParamStringArray From(Il2CppStringArray array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParamStringArray.NativeMethodInfoPtr_From_Public_Static_SteamParamStringArray_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new SteamParamStringArray(intPtr);
			}
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x00054C50 File Offset: 0x00052E50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 948471, RefRangeEnd = 948473, XrefRangeStart = 948461, XrefRangeEnd = 948471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParamStringArray.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x00003442 File Offset: 0x00001642
		public SteamParamStringArray(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x0000344B File Offset: 0x0000164B
		public SteamParamStringArray()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamParamStringArray>.NativeClassPtr))
		{
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000D0C RID: 3340 RVA: 0x00054C88 File Offset: 0x00052E88
		// (set) Token: 0x06000D0D RID: 3341 RVA: 0x0000345D File Offset: 0x0000165D
		public unsafe SteamParamStringArray_t Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamParamStringArray.NativeFieldInfoPtr_Value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamParamStringArray.NativeFieldInfoPtr_Value)) = value;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000D0E RID: 3342 RVA: 0x00054CB0 File Offset: 0x00052EB0
		// (set) Token: 0x06000D0F RID: 3343 RVA: 0x00003478 File Offset: 0x00001678
		public unsafe Il2CppStructArray<IntPtr> NativeStrings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamParamStringArray.NativeFieldInfoPtr_NativeStrings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<IntPtr>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamParamStringArray.NativeFieldInfoPtr_NativeStrings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000D10 RID: 3344 RVA: 0x00054CE0 File Offset: 0x00052EE0
		// (set) Token: 0x06000D11 RID: 3345 RVA: 0x00003497 File Offset: 0x00001697
		public unsafe IntPtr NativeArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamParamStringArray.NativeFieldInfoPtr_NativeArray);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamParamStringArray.NativeFieldInfoPtr_NativeArray)) = value;
			}
		}

		// Token: 0x0400136B RID: 4971
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x0400136C RID: 4972
		private static readonly IntPtr NativeFieldInfoPtr_NativeStrings;

		// Token: 0x0400136D RID: 4973
		private static readonly IntPtr NativeFieldInfoPtr_NativeArray;

		// Token: 0x0400136E RID: 4974
		private static readonly IntPtr NativeMethodInfoPtr_From_Public_Static_SteamParamStringArray_Il2CppStringArray_0;

		// Token: 0x0400136F RID: 4975
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
	}
}
