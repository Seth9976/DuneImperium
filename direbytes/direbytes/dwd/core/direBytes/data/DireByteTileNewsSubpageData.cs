using System;
using Canis.utils.localization;
using dwd.core.data.composition;
using dwd.core.direBytes.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.direBytes.data
{
	// Token: 0x02000022 RID: 34
	public class DireByteTileNewsSubpageData : DataComponent
	{
		// Token: 0x06000190 RID: 400 RVA: 0x00007DEC File Offset: 0x00005FEC
		// Note: this type is marked as 'beforefieldinit'.
		static DireByteTileNewsSubpageData()
		{
			Il2CppClassPointerStore<DireByteTileNewsSubpageData>.NativeClassPtr = IL2CPP.GetIl2CppClass("direbytes.dll", "dwd.core.direBytes.data", "DireByteTileNewsSubpageData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DireByteTileNewsSubpageData>.NativeClassPtr);
			DireByteTileNewsSubpageData.NativeFieldInfoPtr_urlLink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteTileNewsSubpageData>.NativeClassPtr, "urlLink");
			DireByteTileNewsSubpageData.NativeFieldInfoPtr_sceneLink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteTileNewsSubpageData>.NativeClassPtr, "sceneLink");
			DireByteTileNewsSubpageData.NativeFieldInfoPtr_subpageTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteTileNewsSubpageData>.NativeClassPtr, "subpageTitle");
			DireByteTileNewsSubpageData.NativeFieldInfoPtr_subpageDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteTileNewsSubpageData>.NativeClassPtr, "subpageDescription");
			DireByteTileNewsSubpageData.NativeFieldInfoPtr_subpageImageToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteTileNewsSubpageData>.NativeClassPtr, "subpageImageToken");
			DireByteTileNewsSubpageData.NativeFieldInfoPtr_subpageImageText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteTileNewsSubpageData>.NativeClassPtr, "subpageImageText");
			DireByteTileNewsSubpageData.NativeFieldInfoPtr_baseData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteTileNewsSubpageData>.NativeClassPtr, "baseData");
			DireByteTileNewsSubpageData.NativeFieldInfoPtr__SceneLink_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteTileNewsSubpageData>.NativeClassPtr, "<SceneLink>k__BackingField");
			DireByteTileNewsSubpageData.NativeMethodInfoPtr_get_SceneLink_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireByteTileNewsSubpageData>.NativeClassPtr, 100663453);
			DireByteTileNewsSubpageData.NativeMethodInfoPtr_set_SceneLink_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireByteTileNewsSubpageData>.NativeClassPtr, 100663454);
			DireByteTileNewsSubpageData.NativeMethodInfoPtr__ctor_Public_Void_DireByteTileType_DireByteTileBaseData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireByteTileNewsSubpageData>.NativeClassPtr, 100663455);
			DireByteTileNewsSubpageData.NativeMethodInfoPtr_GetTileSubpageData_Public_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireByteTileNewsSubpageData>.NativeClassPtr, 100663456);
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000191 RID: 401 RVA: 0x00007F0C File Offset: 0x0000610C
		// (set) Token: 0x06000192 RID: 402 RVA: 0x00007F44 File Offset: 0x00006144
		public unsafe string SceneLink
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireByteTileNewsSubpageData.NativeMethodInfoPtr_get_SceneLink_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireByteTileNewsSubpageData.NativeMethodInfoPtr_set_SceneLink_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00007F88 File Offset: 0x00006188
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1235126, RefRangeEnd = 1235128, XrefRangeStart = 1235104, XrefRangeEnd = 1235126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DireByteTileNewsSubpageData(DireByteTileType newsTile, DireByteTileBaseData baseData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DireByteTileNewsSubpageData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newsTile);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireByteTileNewsSubpageData.NativeMethodInfoPtr__ctor_Public_Void_DireByteTileType_DireByteTileBaseData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00007FE8 File Offset: 0x000061E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1235175, RefRangeEnd = 1235177, XrefRangeStart = 1235128, XrefRangeEnd = 1235175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataComposition GetTileSubpageData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireByteTileNewsSubpageData.NativeMethodInfoPtr_GetTileSubpageData_Public_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00002DB5 File Offset: 0x00000FB5
		public DireByteTileNewsSubpageData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000196 RID: 406 RVA: 0x00008028 File Offset: 0x00006228
		// (set) Token: 0x06000197 RID: 407 RVA: 0x00002DBE File Offset: 0x00000FBE
		public unsafe string urlLink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileNewsSubpageData.NativeFieldInfoPtr_urlLink);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileNewsSubpageData.NativeFieldInfoPtr_urlLink), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000198 RID: 408 RVA: 0x00008050 File Offset: 0x00006250
		// (set) Token: 0x06000199 RID: 409 RVA: 0x00002DDD File Offset: 0x00000FDD
		public unsafe string sceneLink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileNewsSubpageData.NativeFieldInfoPtr_sceneLink);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileNewsSubpageData.NativeFieldInfoPtr_sceneLink), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600019A RID: 410 RVA: 0x00008078 File Offset: 0x00006278
		// (set) Token: 0x0600019B RID: 411 RVA: 0x00002DFC File Offset: 0x00000FFC
		public unsafe LocalizableText subpageTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileNewsSubpageData.NativeFieldInfoPtr_subpageTitle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizableText>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileNewsSubpageData.NativeFieldInfoPtr_subpageTitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600019C RID: 412 RVA: 0x000080A8 File Offset: 0x000062A8
		// (set) Token: 0x0600019D RID: 413 RVA: 0x00002E1B File Offset: 0x0000101B
		public unsafe LocalizableText subpageDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileNewsSubpageData.NativeFieldInfoPtr_subpageDescription);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizableText>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileNewsSubpageData.NativeFieldInfoPtr_subpageDescription), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600019E RID: 414 RVA: 0x000080D8 File Offset: 0x000062D8
		// (set) Token: 0x0600019F RID: 415 RVA: 0x00002E3A File Offset: 0x0000103A
		public unsafe string subpageImageToken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileNewsSubpageData.NativeFieldInfoPtr_subpageImageToken);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileNewsSubpageData.NativeFieldInfoPtr_subpageImageToken), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x00008100 File Offset: 0x00006300
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x00002E59 File Offset: 0x00001059
		public unsafe string subpageImageText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileNewsSubpageData.NativeFieldInfoPtr_subpageImageText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileNewsSubpageData.NativeFieldInfoPtr_subpageImageText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x00008128 File Offset: 0x00006328
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x00002E78 File Offset: 0x00001078
		public unsafe DireByteTileBaseData baseData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileNewsSubpageData.NativeFieldInfoPtr_baseData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DireByteTileBaseData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileNewsSubpageData.NativeFieldInfoPtr_baseData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x00008158 File Offset: 0x00006358
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x00002E97 File Offset: 0x00001097
		public unsafe string _SceneLink_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileNewsSubpageData.NativeFieldInfoPtr__SceneLink_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileNewsSubpageData.NativeFieldInfoPtr__SceneLink_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeFieldInfoPtr_urlLink;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeFieldInfoPtr_sceneLink;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeFieldInfoPtr_subpageTitle;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeFieldInfoPtr_subpageDescription;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeFieldInfoPtr_subpageImageToken;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeFieldInfoPtr_subpageImageText;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeFieldInfoPtr_baseData;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeFieldInfoPtr__SceneLink_k__BackingField;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeMethodInfoPtr_get_SceneLink_Public_get_String_0;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeMethodInfoPtr_set_SceneLink_Private_set_Void_String_0;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DireByteTileType_DireByteTileBaseData_0;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeMethodInfoPtr_GetTileSubpageData_Public_DataComposition_0;
	}
}
