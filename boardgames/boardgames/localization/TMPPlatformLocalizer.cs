using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace localization
{
	// Token: 0x02000031 RID: 49
	public class TMPPlatformLocalizer : MonoBehaviour
	{
		// Token: 0x0600020F RID: 527 RVA: 0x000176F0 File Offset: 0x000158F0
		// Note: this type is marked as 'beforefieldinit'.
		static TMPPlatformLocalizer()
		{
			Il2CppClassPointerStore<TMPPlatformLocalizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "localization", "TMPPlatformLocalizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMPPlatformLocalizer>.NativeClassPtr);
			TMPPlatformLocalizer.NativeFieldInfoPtr_defaultLocKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPPlatformLocalizer>.NativeClassPtr, "defaultLocKey");
			TMPPlatformLocalizer.NativeFieldInfoPtr_platformKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPPlatformLocalizer>.NativeClassPtr, "platformKeys");
			TMPPlatformLocalizer.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPPlatformLocalizer>.NativeClassPtr, 100663686);
			TMPPlatformLocalizer.NativeMethodInfoPtr_getLocKeyForPlatform_Private_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPPlatformLocalizer>.NativeClassPtr, 100663687);
			TMPPlatformLocalizer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPPlatformLocalizer>.NativeClassPtr, 100663688);
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00017784 File Offset: 0x00015984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984618, XrefRangeEnd = 984629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPPlatformLocalizer.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x000177B8 File Offset: 0x000159B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984629, XrefRangeEnd = 984630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string getLocKeyForPlatform(uint platform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref platform;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPPlatformLocalizer.NativeMethodInfoPtr_getLocKeyForPlatform_Private_String_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000212 RID: 530 RVA: 0x000177FC File Offset: 0x000159FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984630, XrefRangeEnd = 984641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMPPlatformLocalizer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMPPlatformLocalizer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPPlatformLocalizer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00002EAC File Offset: 0x000010AC
		public TMPPlatformLocalizer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000214 RID: 532 RVA: 0x00017838 File Offset: 0x00015A38
		// (set) Token: 0x06000215 RID: 533 RVA: 0x00002EB5 File Offset: 0x000010B5
		public unsafe string defaultLocKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMPPlatformLocalizer.NativeFieldInfoPtr_defaultLocKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMPPlatformLocalizer.NativeFieldInfoPtr_defaultLocKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000216 RID: 534 RVA: 0x00017860 File Offset: 0x00015A60
		// (set) Token: 0x06000217 RID: 535 RVA: 0x00002ED4 File Offset: 0x000010D4
		public unsafe Il2CppReferenceArray<TMPPlatformLocalizer.PlatformLocKey> platformKeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMPPlatformLocalizer.NativeFieldInfoPtr_platformKeys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TMPPlatformLocalizer.PlatformLocKey>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMPPlatformLocalizer.NativeFieldInfoPtr_platformKeys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeFieldInfoPtr_defaultLocKey;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeFieldInfoPtr_platformKeys;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeMethodInfoPtr_getLocKeyForPlatform_Private_String_UInt32_0;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020001B2 RID: 434
		[Serializable]
		public sealed class PlatformLocKey : ValueType
		{
			// Token: 0x060014EC RID: 5356 RVA: 0x00051894 File Offset: 0x0004FA94
			// Note: this type is marked as 'beforefieldinit'.
			static PlatformLocKey()
			{
				Il2CppClassPointerStore<TMPPlatformLocalizer.PlatformLocKey>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMPPlatformLocalizer>.NativeClassPtr, "PlatformLocKey");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMPPlatformLocalizer.PlatformLocKey>.NativeClassPtr);
				TMPPlatformLocalizer.PlatformLocKey.NativeFieldInfoPtr_Platform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPPlatformLocalizer.PlatformLocKey>.NativeClassPtr, "Platform");
				TMPPlatformLocalizer.PlatformLocKey.NativeFieldInfoPtr_LocKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPPlatformLocalizer.PlatformLocKey>.NativeClassPtr, "LocKey");
			}

			// Token: 0x060014ED RID: 5357 RVA: 0x0000BCD1 File Offset: 0x00009ED1
			public PlatformLocKey(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060014EE RID: 5358 RVA: 0x0000BCDA File Offset: 0x00009EDA
			public PlatformLocKey()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMPPlatformLocalizer.PlatformLocKey>.NativeClassPtr))
			{
			}

			// Token: 0x170005F4 RID: 1524
			// (get) Token: 0x060014EF RID: 5359 RVA: 0x000518E8 File Offset: 0x0004FAE8
			// (set) Token: 0x060014F0 RID: 5360 RVA: 0x0000BCEC File Offset: 0x00009EEC
			public unsafe uint Platform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMPPlatformLocalizer.PlatformLocKey.NativeFieldInfoPtr_Platform);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMPPlatformLocalizer.PlatformLocKey.NativeFieldInfoPtr_Platform)) = value;
				}
			}

			// Token: 0x170005F5 RID: 1525
			// (get) Token: 0x060014F1 RID: 5361 RVA: 0x00051910 File Offset: 0x0004FB10
			// (set) Token: 0x060014F2 RID: 5362 RVA: 0x0000BD07 File Offset: 0x00009F07
			public unsafe string LocKey
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMPPlatformLocalizer.PlatformLocKey.NativeFieldInfoPtr_LocKey);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMPPlatformLocalizer.PlatformLocKey.NativeFieldInfoPtr_LocKey), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04000CAD RID: 3245
			private static readonly IntPtr NativeFieldInfoPtr_Platform;

			// Token: 0x04000CAE RID: 3246
			private static readonly IntPtr NativeFieldInfoPtr_LocKey;
		}
	}
}
